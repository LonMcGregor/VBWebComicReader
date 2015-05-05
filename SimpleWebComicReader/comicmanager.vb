Public Class comicmanager

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        My.Settings.C1Arc = C1Arc.Text
        My.Settings.C1Format = C1Date.SelectedIndex
        My.Settings.C1Link = C1URL.Text
        My.Settings.C1Name = C1Name.Text

        My.Settings.C2Arc = C2Arc.Text
        My.Settings.C2Format = C2Date.SelectedIndex
        My.Settings.C2Link = C2URL.Text
        My.Settings.C2Name = C2Name.Text

        My.Settings.C3Arc = C3Arc.Text
        My.Settings.C3Format = C3Date.SelectedIndex
        My.Settings.C3Link = C3URL.Text
        My.Settings.C3Name = C3Name.Text

        My.Settings.C4Arc = C4Arc.Text
        My.Settings.C4Format = C4Date.SelectedIndex
        My.Settings.C4Link = C4URL.Text
        My.Settings.C4Name = C4Name.Text

        Form1.selectedComic.Items.Clear()
        Form1.selectedComic.Items.Add(My.Settings.C1Name)
        Form1.selectedComic.Items.Add(My.Settings.C2Name)
        Form1.selectedComic.Items.Add(My.Settings.C3Name)
        Form1.selectedComic.Items.Add(My.Settings.C4Name)

        Me.Close()
    End Sub

    Private Sub comicmanager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        C1Arc.Text = My.Settings.C1Arc
        C1Date.SelectedIndex = My.Settings.C1Format
        C1URL.Text = My.Settings.C1Link
        C1Name.Text = My.Settings.C1Name

        C2Arc.Text = My.Settings.C2Arc
        C2Date.SelectedIndex = My.Settings.C2Format
        C2URL.Text = My.Settings.C2Link
        C2Name.Text = My.Settings.C2Name

        C3Arc.Text = My.Settings.C3Arc
        C3Date.SelectedIndex = My.Settings.C3Format
        C3URL.Text = My.Settings.C3Link
        C3Name.Text = My.Settings.C3Name

        C4Arc.Text = My.Settings.C4Arc
        C4Date.SelectedIndex = My.Settings.C4Format
        C4URL.Text = My.Settings.C4Link
        C4Name.Text = My.Settings.C4Name
    End Sub
End Class