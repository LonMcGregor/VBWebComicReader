<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.comicWeb = New System.Windows.Forms.WebBrowser()
        Me.archiveWeb = New System.Windows.Forms.WebBrowser()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dayNo = New System.Windows.Forms.NumericUpDown()
        Me.monthNo = New System.Windows.Forms.NumericUpDown()
        Me.yearNo = New System.Windows.Forms.NumericUpDown()
        Me.cmdReload = New System.Windows.Forms.Button()
        Me.selectedComic = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.selectedFormat = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.archiveContainer = New System.Windows.Forms.GroupBox()
        Me.autoLoad = New System.Windows.Forms.CheckBox()
        Me.controlContainer = New System.Windows.Forms.GroupBox()
        Me.cmdMainFor = New System.Windows.Forms.Button()
        Me.cmdMainBack = New System.Windows.Forms.Button()
        Me.cmdManageComics = New System.Windows.Forms.Button()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.cmdHideAll = New System.Windows.Forms.Button()
        Me.cmdBookmark = New System.Windows.Forms.Button()
        Me.cmdHideArc = New System.Windows.Forms.Button()
        Me.cmdForward = New System.Windows.Forms.Button()
        Me.cmdShowAll = New System.Windows.Forms.Button()
        Me.miniContainer = New System.Windows.Forms.GroupBox()
        Me.cmdBackwards = New System.Windows.Forms.Button()
        Me.browserBox = New System.Windows.Forms.GroupBox()
        CType(Me.dayNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.monthNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yearNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.archiveContainer.SuspendLayout()
        Me.controlContainer.SuspendLayout()
        Me.miniContainer.SuspendLayout()
        Me.browserBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'comicWeb
        '
        Me.comicWeb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.comicWeb.Location = New System.Drawing.Point(3, 16)
        Me.comicWeb.MinimumSize = New System.Drawing.Size(20, 20)
        Me.comicWeb.Name = "comicWeb"
        Me.comicWeb.ScriptErrorsSuppressed = True
        Me.comicWeb.Size = New System.Drawing.Size(728, 372)
        Me.comicWeb.TabIndex = 0
        Me.comicWeb.WebBrowserShortcutsEnabled = False
        '
        'archiveWeb
        '
        Me.archiveWeb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.archiveWeb.Location = New System.Drawing.Point(3, 16)
        Me.archiveWeb.MinimumSize = New System.Drawing.Size(20, 20)
        Me.archiveWeb.Name = "archiveWeb"
        Me.archiveWeb.ScriptErrorsSuppressed = True
        Me.archiveWeb.Size = New System.Drawing.Size(728, 187)
        Me.archiveWeb.TabIndex = 1
        Me.archiveWeb.WebBrowserShortcutsEnabled = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(142, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Day"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(187, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Month"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(230, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Year"
        '
        'dayNo
        '
        Me.dayNo.Location = New System.Drawing.Point(145, 28)
        Me.dayNo.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.dayNo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.dayNo.Name = "dayNo"
        Me.dayNo.Size = New System.Drawing.Size(39, 20)
        Me.dayNo.TabIndex = 9
        Me.dayNo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'monthNo
        '
        Me.monthNo.Location = New System.Drawing.Point(190, 28)
        Me.monthNo.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.monthNo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.monthNo.Name = "monthNo"
        Me.monthNo.Size = New System.Drawing.Size(37, 20)
        Me.monthNo.TabIndex = 10
        Me.monthNo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'yearNo
        '
        Me.yearNo.Location = New System.Drawing.Point(233, 28)
        Me.yearNo.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.yearNo.Minimum = New Decimal(New Integer() {1990, 0, 0, 0})
        Me.yearNo.Name = "yearNo"
        Me.yearNo.Size = New System.Drawing.Size(54, 20)
        Me.yearNo.TabIndex = 11
        Me.yearNo.Value = New Decimal(New Integer() {1990, 0, 0, 0})
        '
        'cmdReload
        '
        Me.cmdReload.Enabled = False
        Me.cmdReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.cmdReload.Image = Global.SimpleWebComicReader.My.Resources.Resources.bR
        Me.cmdReload.Location = New System.Drawing.Point(507, 22)
        Me.cmdReload.Name = "cmdReload"
        Me.cmdReload.Size = New System.Drawing.Size(40, 40)
        Me.cmdReload.TabIndex = 12
        Me.cmdReload.UseVisualStyleBackColor = True
        '
        'selectedComic
        '
        Me.selectedComic.FormattingEnabled = True
        Me.selectedComic.Location = New System.Drawing.Point(304, 27)
        Me.selectedComic.Name = "selectedComic"
        Me.selectedComic.Size = New System.Drawing.Size(123, 21)
        Me.selectedComic.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(301, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Comic"
        '
        'selectedFormat
        '
        Me.selectedFormat.FormattingEnabled = True
        Me.selectedFormat.Items.AddRange(New Object() {".jpg", ".JPG", ".jpeg", ".JPEG", ".png", ".PNG", ".gif", ".GIF"})
        Me.selectedFormat.Location = New System.Drawing.Point(448, 28)
        Me.selectedFormat.Name = "selectedFormat"
        Me.selectedFormat.Size = New System.Drawing.Size(53, 21)
        Me.selectedFormat.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(445, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Format"
        '
        'archiveContainer
        '
        Me.archiveContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.archiveContainer.Controls.Add(Me.archiveWeb)
        Me.archiveContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.archiveContainer.ForeColor = System.Drawing.Color.White
        Me.archiveContainer.Location = New System.Drawing.Point(0, 455)
        Me.archiveContainer.Name = "archiveContainer"
        Me.archiveContainer.Size = New System.Drawing.Size(734, 206)
        Me.archiveContainer.TabIndex = 17
        Me.archiveContainer.TabStop = False
        Me.archiveContainer.Text = "Archive"
        '
        'autoLoad
        '
        Me.autoLoad.AutoSize = True
        Me.autoLoad.BackColor = System.Drawing.Color.Transparent
        Me.autoLoad.Enabled = False
        Me.autoLoad.ForeColor = System.Drawing.Color.White
        Me.autoLoad.Location = New System.Drawing.Point(89, 22)
        Me.autoLoad.Name = "autoLoad"
        Me.autoLoad.Size = New System.Drawing.Size(50, 30)
        Me.autoLoad.TabIndex = 18
        Me.autoLoad.Text = "Auto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Load" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.autoLoad.UseVisualStyleBackColor = False
        '
        'controlContainer
        '
        Me.controlContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.controlContainer.Controls.Add(Me.cmdMainFor)
        Me.controlContainer.Controls.Add(Me.autoLoad)
        Me.controlContainer.Controls.Add(Me.cmdMainBack)
        Me.controlContainer.Controls.Add(Me.cmdManageComics)
        Me.controlContainer.Controls.Add(Me.cmdLoad)
        Me.controlContainer.Controls.Add(Me.cmdHideAll)
        Me.controlContainer.Controls.Add(Me.cmdBookmark)
        Me.controlContainer.Controls.Add(Me.cmdHideArc)
        Me.controlContainer.Controls.Add(Me.dayNo)
        Me.controlContainer.Controls.Add(Me.Label6)
        Me.controlContainer.Controls.Add(Me.Label7)
        Me.controlContainer.Controls.Add(Me.Label3)
        Me.controlContainer.Controls.Add(Me.selectedFormat)
        Me.controlContainer.Controls.Add(Me.cmdReload)
        Me.controlContainer.Controls.Add(Me.Label4)
        Me.controlContainer.Controls.Add(Me.Label5)
        Me.controlContainer.Controls.Add(Me.selectedComic)
        Me.controlContainer.Controls.Add(Me.yearNo)
        Me.controlContainer.Controls.Add(Me.monthNo)
        Me.controlContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.controlContainer.ForeColor = System.Drawing.Color.White
        Me.controlContainer.Location = New System.Drawing.Point(0, 391)
        Me.controlContainer.Name = "controlContainer"
        Me.controlContainer.Size = New System.Drawing.Size(734, 64)
        Me.controlContainer.TabIndex = 18
        Me.controlContainer.TabStop = False
        Me.controlContainer.Text = "Current Comic"
        '
        'cmdMainFor
        '
        Me.cmdMainFor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMainFor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMainFor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.cmdMainFor.Image = Global.SimpleWebComicReader.My.Resources.Resources.mF
        Me.cmdMainFor.Location = New System.Drawing.Point(28, 12)
        Me.cmdMainFor.Name = "cmdMainFor"
        Me.cmdMainFor.Size = New System.Drawing.Size(63, 50)
        Me.cmdMainFor.TabIndex = 24
        Me.cmdMainFor.UseVisualStyleBackColor = True
        '
        'cmdMainBack
        '
        Me.cmdMainBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMainBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.cmdMainBack.Image = Global.SimpleWebComicReader.My.Resources.Resources.bB
        Me.cmdMainBack.Location = New System.Drawing.Point(3, 12)
        Me.cmdMainBack.Name = "cmdMainBack"
        Me.cmdMainBack.Size = New System.Drawing.Size(28, 50)
        Me.cmdMainBack.TabIndex = 23
        Me.cmdMainBack.UseVisualStyleBackColor = True
        '
        'cmdManageComics
        '
        Me.cmdManageComics.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdManageComics.ForeColor = System.Drawing.Color.Black
        Me.cmdManageComics.Location = New System.Drawing.Point(425, 27)
        Me.cmdManageComics.Name = "cmdManageComics"
        Me.cmdManageComics.Size = New System.Drawing.Size(17, 21)
        Me.cmdManageComics.TabIndex = 22
        Me.cmdManageComics.Text = "+"
        Me.cmdManageComics.UseVisualStyleBackColor = True
        '
        'cmdLoad
        '
        Me.cmdLoad.Enabled = False
        Me.cmdLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLoad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.cmdLoad.Image = Global.SimpleWebComicReader.My.Resources.Resources.bL
        Me.cmdLoad.Location = New System.Drawing.Point(688, 22)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(40, 40)
        Me.cmdLoad.TabIndex = 21
        Me.cmdLoad.UseVisualStyleBackColor = True
        '
        'cmdHideAll
        '
        Me.cmdHideAll.Enabled = False
        Me.cmdHideAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdHideAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.cmdHideAll.Image = Global.SimpleWebComicReader.My.Resources.Resources.bT
        Me.cmdHideAll.Location = New System.Drawing.Point(596, 22)
        Me.cmdHideAll.Name = "cmdHideAll"
        Me.cmdHideAll.Size = New System.Drawing.Size(40, 40)
        Me.cmdHideAll.TabIndex = 20
        Me.cmdHideAll.UseVisualStyleBackColor = True
        '
        'cmdBookmark
        '
        Me.cmdBookmark.Enabled = False
        Me.cmdBookmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBookmark.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.cmdBookmark.Image = Global.SimpleWebComicReader.My.Resources.Resources.bBk
        Me.cmdBookmark.Location = New System.Drawing.Point(642, 9)
        Me.cmdBookmark.Name = "cmdBookmark"
        Me.cmdBookmark.Size = New System.Drawing.Size(40, 40)
        Me.cmdBookmark.TabIndex = 19
        Me.cmdBookmark.UseVisualStyleBackColor = True
        '
        'cmdHideArc
        '
        Me.cmdHideArc.Enabled = False
        Me.cmdHideArc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdHideArc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.cmdHideArc.Image = Global.SimpleWebComicReader.My.Resources.Resources.bA
        Me.cmdHideArc.Location = New System.Drawing.Point(550, 8)
        Me.cmdHideArc.Name = "cmdHideArc"
        Me.cmdHideArc.Size = New System.Drawing.Size(40, 40)
        Me.cmdHideArc.TabIndex = 17
        Me.cmdHideArc.UseVisualStyleBackColor = True
        '
        'cmdForward
        '
        Me.cmdForward.Enabled = False
        Me.cmdForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdForward.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdForward.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.cmdForward.Image = Global.SimpleWebComicReader.My.Resources.Resources.mF
        Me.cmdForward.Location = New System.Drawing.Point(28, 7)
        Me.cmdForward.Name = "cmdForward"
        Me.cmdForward.Size = New System.Drawing.Size(63, 50)
        Me.cmdForward.TabIndex = 19
        Me.cmdForward.UseVisualStyleBackColor = True
        '
        'cmdShowAll
        '
        Me.cmdShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdShowAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.cmdShowAll.Image = Global.SimpleWebComicReader.My.Resources.Resources.mT
        Me.cmdShowAll.Location = New System.Drawing.Point(3, 34)
        Me.cmdShowAll.Name = "cmdShowAll"
        Me.cmdShowAll.Size = New System.Drawing.Size(23, 23)
        Me.cmdShowAll.TabIndex = 20
        Me.cmdShowAll.UseVisualStyleBackColor = True
        '
        'miniContainer
        '
        Me.miniContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.miniContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.miniContainer.Controls.Add(Me.cmdBackwards)
        Me.miniContainer.Controls.Add(Me.cmdShowAll)
        Me.miniContainer.Controls.Add(Me.cmdForward)
        Me.miniContainer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.miniContainer.Location = New System.Drawing.Point(0, 331)
        Me.miniContainer.MaximumSize = New System.Drawing.Size(100, 60)
        Me.miniContainer.MinimumSize = New System.Drawing.Size(100, 60)
        Me.miniContainer.Name = "miniContainer"
        Me.miniContainer.Size = New System.Drawing.Size(100, 60)
        Me.miniContainer.TabIndex = 21
        Me.miniContainer.TabStop = False
        Me.miniContainer.Visible = False
        '
        'cmdBackwards
        '
        Me.cmdBackwards.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBackwards.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.cmdBackwards.Image = Global.SimpleWebComicReader.My.Resources.Resources.mB
        Me.cmdBackwards.Location = New System.Drawing.Point(3, 7)
        Me.cmdBackwards.Name = "cmdBackwards"
        Me.cmdBackwards.Size = New System.Drawing.Size(23, 23)
        Me.cmdBackwards.TabIndex = 21
        Me.cmdBackwards.UseVisualStyleBackColor = True
        '
        'browserBox
        '
        Me.browserBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.browserBox.Controls.Add(Me.comicWeb)
        Me.browserBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.browserBox.ForeColor = System.Drawing.Color.White
        Me.browserBox.Location = New System.Drawing.Point(0, 0)
        Me.browserBox.Name = "browserBox"
        Me.browserBox.Size = New System.Drawing.Size(734, 391)
        Me.browserBox.TabIndex = 22
        Me.browserBox.TabStop = False
        Me.browserBox.Text = "Select a Comic"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(734, 661)
        Me.Controls.Add(Me.miniContainer)
        Me.Controls.Add(Me.controlContainer)
        Me.Controls.Add(Me.archiveContainer)
        Me.Controls.Add(Me.browserBox)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(750, 700)
        Me.Name = "Form1"
        Me.Text = "Simple Comic Reader"
        CType(Me.dayNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.monthNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yearNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.archiveContainer.ResumeLayout(False)
        Me.controlContainer.ResumeLayout(False)
        Me.controlContainer.PerformLayout()
        Me.miniContainer.ResumeLayout(False)
        Me.browserBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents comicWeb As System.Windows.Forms.WebBrowser
    Friend WithEvents archiveWeb As System.Windows.Forms.WebBrowser
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dayNo As System.Windows.Forms.NumericUpDown
    Friend WithEvents monthNo As System.Windows.Forms.NumericUpDown
    Friend WithEvents yearNo As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdReload As System.Windows.Forms.Button
    Friend WithEvents selectedComic As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents selectedFormat As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents archiveContainer As System.Windows.Forms.GroupBox
    Friend WithEvents controlContainer As System.Windows.Forms.GroupBox
    Friend WithEvents cmdHideArc As System.Windows.Forms.Button
    Friend WithEvents autoLoad As System.Windows.Forms.CheckBox
    Friend WithEvents cmdHideAll As System.Windows.Forms.Button
    Friend WithEvents cmdBookmark As System.Windows.Forms.Button
    Friend WithEvents cmdForward As System.Windows.Forms.Button
    Friend WithEvents cmdShowAll As System.Windows.Forms.Button
    Friend WithEvents miniContainer As System.Windows.Forms.GroupBox
    Friend WithEvents cmdLoad As System.Windows.Forms.Button
    Friend WithEvents cmdManageComics As System.Windows.Forms.Button
    Friend WithEvents cmdBackwards As System.Windows.Forms.Button
    Friend WithEvents cmdMainFor As System.Windows.Forms.Button
    Friend WithEvents cmdMainBack As System.Windows.Forms.Button
    Friend WithEvents browserBox As System.Windows.Forms.GroupBox

End Class
