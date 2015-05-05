Imports System
Imports System.Collections
Imports System.Collections.Specialized

Public Class Form1

    Dim currentTitle As String
    Dim currentArchive As String
    Dim currentFormat As Integer
    Dim currentLink As String
    Dim currentBookmark As String
    Dim currentSelectedComic As Integer

    Dim archiveEnabled As Boolean
    Dim toolbarsState As Integer    '0: all open, 1: arc closed, 2: all closed

    'forces a reload
    Private Sub cmdReload_Click(sender As Object, e As EventArgs) Handles cmdReload.Click
        Call doReload()
    End Sub

    'loads comic with values specified
    Private Sub doReload()
        Dim currentURL As String

        Dim month As String
        If monthNo.Value.ToString.Length <> 2 Then
            month = "0" & monthNo.Value.ToString
        Else
            month = monthNo.Value.ToString
        End If

        Dim day As String
        If dayNo.Value.ToString.Length <> 2 Then
            day = "0" & dayNo.Value.ToString
        Else
            day = dayNo.Value.ToString
        End If

        If selectedFormat.Text.Length = 0 Then selectedFormat.SelectedIndex = 0

        currentURL = currentLink & yearNo.Value.ToString & month & day
        currentURL = currentURL & selectedFormat.Text

        comicWeb.Navigate(currentURL)
    End Sub

    'if auto-load is checked, then reload when date changed
    Private Sub dayNo_ValueChanged(sender As Object, e As EventArgs) Handles dayNo.ValueChanged
        If autoLoad.Checked Then Call doReload()
    End Sub
    Private Sub yearNo_ValueChanged(sender As Object, e As EventArgs) Handles yearNo.ValueChanged
        If autoLoad.Checked Then Call doReload()
    End Sub
    Private Sub monthNo_ValueChanged(sender As Object, e As EventArgs) Handles monthNo.ValueChanged
        If autoLoad.Checked Then Call doReload()
    End Sub

    'toggles archive
    Private Sub cmdHideArc_Click(sender As Object, e As EventArgs) Handles cmdHideArc.Click
        If archiveContainer.Visible = False Then
            archiveContainer.Visible = True
            archiveEnabled = True
            toolbarsState = 0
            Call resizeBrowser()
        Else
            archiveContainer.Visible = False
            archiveEnabled = False
            toolbarsState = 1
            Call resizeBrowser()
        End If
    End Sub

    'hides main navbar and archive, shows minibar
    Private Sub cmdHideAll_Click(sender As Object, e As EventArgs) Handles cmdHideAll.Click
        archiveContainer.Visible = False
        controlContainer.Visible = False
        miniContainer.Visible = True
        toolbarsState = 2
        Call resizeBrowser()
    End Sub

    'increments forward 1 day
    Private Sub cmdForward_Click(sender As Object, e As EventArgs) Handles cmdForward.Click
        Call GoForwards()
    End Sub

    'increments back 1 day
    Private Sub cmdBackwards_Click(sender As Object, e As EventArgs) Handles cmdBackwards.Click
        Call GoBackwards()
    End Sub

    'shows main navbar & archive, hides mini bar
    Private Sub cmdShowAll_Click(sender As Object, e As EventArgs) Handles cmdShowAll.Click
        If archiveEnabled = True Then
            archiveContainer.Visible = True
            controlContainer.Visible = True
            miniContainer.Visible = False
            toolbarsState = 0
            Call resizeBrowser()
        Else
            controlContainer.Visible = True
            miniContainer.Visible = False
            toolbarsState = 1
            Call resizeBrowser()
        End If

    End Sub

    'stores a bookmark at current date
    Private Sub cmdBookmark_Click(sender As Object, e As EventArgs) Handles cmdBookmark.Click
        Dim tmpstore As String
        tmpstore = ""

        Dim month As String
        If monthNo.Value.ToString.Length <> 2 Then
            month = "0" & monthNo.Value.ToString
        Else
            month = monthNo.Value.ToString
        End If

        Dim day As String
        If dayNo.Value.ToString.Length <> 2 Then
            day = "0" & dayNo.Value.ToString
        Else
            day = dayNo.Value.ToString
        End If

        tmpstore = tmpstore & yearNo.Value.ToString & month & day
        currentBookmark = tmpstore

        Select Case currentSelectedComic
            Case Is = 0
                My.Settings.C1Bookmark = tmpstore
            Case Is = 1
                My.Settings.C2Bookmark = tmpstore
            Case Is = 2
                My.Settings.C3Bookmark = tmpstore
            Case Is = 3
                My.Settings.C4Bookmark = tmpstore
        End Select

    End Sub

    'forces the web browser to load a comic image
    Private Sub cmdLoad_Click(sender As Object, e As EventArgs) Handles cmdLoad.Click

        Dim day As Integer
        Dim month As Integer
        Dim year As Integer

        If currentBookmark.Length <> 0 Then
            year = currentBookmark.Substring(0, 4)
            month = currentBookmark.Substring(4, 2)
            day = currentBookmark.Substring(6, 2)

            dayNo.Value = day
            monthNo.Value = month
            yearNo.Value = year

            Call doReload()
        End If
    End Sub

    'shows comic url manager
    Private Sub cmdManageComics_Click(sender As Object, e As EventArgs) Handles cmdManageComics.Click
        comicmanager.Show()
    End Sub

    'loads the currently stored comic titles
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        selectedComic.Items.Add(My.Settings.C1Name)
        selectedComic.Items.Add(My.Settings.C2Name)
        selectedComic.Items.Add(My.Settings.C3Name)
        selectedComic.Items.Add(My.Settings.C4Name)

        archiveEnabled = True
        toolbarsState = 0
    End Sub

    'loads a comic once selected from drop-down menu
    Private Sub selectedComic_SelectedIndexChanged(sender As Object, e As EventArgs) Handles selectedComic.SelectedIndexChanged
        cmdReload.Enabled = True
        cmdForward.Enabled = True
        cmdHideAll.Enabled = True
        cmdHideArc.Enabled = True
        cmdLoad.Enabled = True
        autoLoad.Enabled = True
        cmdBookmark.Enabled = True

        currentSelectedComic = selectedComic.SelectedIndex
        Select Case currentSelectedComic
            Case Is = 0
                currentTitle = My.Settings.C1Name
                currentArchive = My.Settings.C1Arc
                currentFormat = My.Settings.C1Format
                currentLink = My.Settings.C1Link
                currentBookmark = My.Settings.C1Bookmark

            Case Is = 1
                currentTitle = My.Settings.C2Name
                currentArchive = My.Settings.C2Arc
                currentFormat = My.Settings.C2Format
                currentLink = My.Settings.C2Link
                currentBookmark = My.Settings.C2Bookmark

            Case Is = 2
                currentTitle = My.Settings.C3Name
                currentArchive = My.Settings.C3Arc
                currentFormat = My.Settings.C3Format
                currentLink = My.Settings.C3Link
                currentBookmark = My.Settings.C3Bookmark

            Case Is = 3
                currentTitle = My.Settings.C4Name
                currentArchive = My.Settings.C4Arc
                currentFormat = My.Settings.C4Format
                currentLink = My.Settings.C4Link
                currentBookmark = My.Settings.C4Bookmark

        End Select

        Me.Text = "Simple Comic Reader: " & currentTitle
        browserBox.Text = currentTitle
        archiveWeb.Navigate(currentArchive)

    End Sub

    'increments the date back by one day
    Private Sub GoBackwards()
        Dim days As Integer

        If dayNo.Value <> 1 Then
            dayNo.Value = dayNo.Value - 1
        Else
            If monthNo.Value <> 1 Then
                monthNo.Value = monthNo.Value - 1
                days = getMonthDays()
                dayNo.Value = days
            Else
                dayNo.Value = 31
                monthNo.Value = 12
                yearNo.Value = yearNo.Value - 1
            End If
        End If


        Call doReload()
    End Sub

    'this gets the number of days in month specified
    Private Function getMonthDays() As Integer
        Dim days As Integer
        If monthNo.Value = 1 Or monthNo.Value = 3 Or monthNo.Value = 5 Or monthNo.Value = 7 Or monthNo.Value = 8 Or monthNo.Value = 10 Or monthNo.Value = 12 Then
            days = 31
        ElseIf monthNo.Value = 2 Then
            If yearNo.Value Mod 4 = 0 Then
                days = 29
            Else
                days = 28
            End If
        Else
            days = 30
        End If
        Return days
    End Function

    ' This increments the date by one day
    Private Sub GoForwards()

        Dim days As Integer
        days = getMonthDays()

        If dayNo.Value < days Then
            dayNo.Value = dayNo.Value + 1
        Else
            dayNo.Value = 1
            If monthNo.Value < 12 Then
                monthNo.Value = monthNo.Value + 1
            Else
                monthNo.Value = 1
                yearNo.Value = yearNo.Value + 1
            End If
        End If

        Call doReload()
    End Sub

    'nav controls for main bar
    Private Sub cmdMainFor_Click(sender As Object, e As EventArgs) Handles cmdMainFor.Click
        Call GoForwards()
    End Sub
    Private Sub cmdMainBack_Click(sender As Object, e As EventArgs) Handles cmdMainBack.Click
        Call GoBackwards()
    End Sub

    Private Sub resizeBrowser()
        Select Case toolbarsState
            Case Is = 0
                browserBox.Height = Me.Height - archiveContainer.Height - controlContainer.Height - 20
            Case Is = 1
                browserBox.Height = Me.Height - controlContainer.Height - 20
            Case Is = 2
                browserBox.Height = Me.Height - 20
        End Select
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Call resizeBrowser()
    End Sub
End Class

'1.0 Made program
'1.1 Added bookmarking, hide all controls, button to advance page one by one in mini-controls mode
'1.2    add your own comic.
'       load of bookmark defaults to the lounge
'       load of bookmark starts archive
'       mini-view next button forces next even if auto-load is not turned on
'1.3 Auto-select jpg if none selected
'       browser fills window on esize
'       Capitalization of url ends
'1.4 Code optimization on forward/backwards
'       Added backwards button
'       Added navbuttons to main toolbar
'       Reworked Main Toolbar
'       Added icons and button graphics
'       Added minimum resize values
'1.4.1 Bookmark load button not receiving correc value until restart
'       Swtichign toolbar mode doesn't remember state of archive
'       Browser not filling correct area
'1.4.2.2 User selected resize doesn't update browser height.
'       Code ioptimization relating to above

