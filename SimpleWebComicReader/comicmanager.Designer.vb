<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class comicmanager
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
        Me.C1Arc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.C1URL = New System.Windows.Forms.TextBox()
        Me.C1Name = New System.Windows.Forms.TextBox()
        Me.C1Date = New System.Windows.Forms.ComboBox()
        Me.C2Arc = New System.Windows.Forms.TextBox()
        Me.C2URL = New System.Windows.Forms.TextBox()
        Me.C2Name = New System.Windows.Forms.TextBox()
        Me.C2Date = New System.Windows.Forms.ComboBox()
        Me.C3URL = New System.Windows.Forms.TextBox()
        Me.C3Arc = New System.Windows.Forms.TextBox()
        Me.C3Name = New System.Windows.Forms.TextBox()
        Me.C3Date = New System.Windows.Forms.ComboBox()
        Me.C4Arc = New System.Windows.Forms.TextBox()
        Me.C4URL = New System.Windows.Forms.TextBox()
        Me.C4Name = New System.Windows.Forms.TextBox()
        Me.C4Date = New System.Windows.Forms.ComboBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'C1Arc
        '
        Me.C1Arc.Location = New System.Drawing.Point(25, 22)
        Me.C1Arc.Name = "C1Arc"
        Me.C1Arc.Size = New System.Drawing.Size(197, 20)
        Me.C1Arc.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Archive URL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Image Base URL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(429, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(550, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Date Format"
        '
        'C1URL
        '
        Me.C1URL.Location = New System.Drawing.Point(228, 22)
        Me.C1URL.Name = "C1URL"
        Me.C1URL.Size = New System.Drawing.Size(197, 20)
        Me.C1URL.TabIndex = 5
        '
        'C1Name
        '
        Me.C1Name.Location = New System.Drawing.Point(432, 22)
        Me.C1Name.Name = "C1Name"
        Me.C1Name.Size = New System.Drawing.Size(110, 20)
        Me.C1Name.TabIndex = 6
        '
        'C1Date
        '
        Me.C1Date.FormattingEnabled = True
        Me.C1Date.Items.AddRange(New Object() {"YYYYMMDD"})
        Me.C1Date.Location = New System.Drawing.Point(553, 21)
        Me.C1Date.Name = "C1Date"
        Me.C1Date.Size = New System.Drawing.Size(147, 21)
        Me.C1Date.TabIndex = 7
        '
        'C2Arc
        '
        Me.C2Arc.Location = New System.Drawing.Point(25, 48)
        Me.C2Arc.Name = "C2Arc"
        Me.C2Arc.Size = New System.Drawing.Size(197, 20)
        Me.C2Arc.TabIndex = 8
        '
        'C2URL
        '
        Me.C2URL.Location = New System.Drawing.Point(228, 48)
        Me.C2URL.Name = "C2URL"
        Me.C2URL.Size = New System.Drawing.Size(197, 20)
        Me.C2URL.TabIndex = 9
        '
        'C2Name
        '
        Me.C2Name.Location = New System.Drawing.Point(432, 48)
        Me.C2Name.Name = "C2Name"
        Me.C2Name.Size = New System.Drawing.Size(110, 20)
        Me.C2Name.TabIndex = 10
        '
        'C2Date
        '
        Me.C2Date.FormattingEnabled = True
        Me.C2Date.Items.AddRange(New Object() {"YYYYMMDD"})
        Me.C2Date.Location = New System.Drawing.Point(553, 47)
        Me.C2Date.Name = "C2Date"
        Me.C2Date.Size = New System.Drawing.Size(147, 21)
        Me.C2Date.TabIndex = 11
        '
        'C3URL
        '
        Me.C3URL.Location = New System.Drawing.Point(228, 74)
        Me.C3URL.Name = "C3URL"
        Me.C3URL.Size = New System.Drawing.Size(197, 20)
        Me.C3URL.TabIndex = 12
        '
        'C3Arc
        '
        Me.C3Arc.Location = New System.Drawing.Point(25, 74)
        Me.C3Arc.Name = "C3Arc"
        Me.C3Arc.Size = New System.Drawing.Size(197, 20)
        Me.C3Arc.TabIndex = 13
        '
        'C3Name
        '
        Me.C3Name.Location = New System.Drawing.Point(432, 74)
        Me.C3Name.Name = "C3Name"
        Me.C3Name.Size = New System.Drawing.Size(110, 20)
        Me.C3Name.TabIndex = 14
        '
        'C3Date
        '
        Me.C3Date.FormattingEnabled = True
        Me.C3Date.Items.AddRange(New Object() {"YYYYMMDD"})
        Me.C3Date.Location = New System.Drawing.Point(553, 73)
        Me.C3Date.Name = "C3Date"
        Me.C3Date.Size = New System.Drawing.Size(147, 21)
        Me.C3Date.TabIndex = 15
        '
        'C4Arc
        '
        Me.C4Arc.Location = New System.Drawing.Point(25, 100)
        Me.C4Arc.Name = "C4Arc"
        Me.C4Arc.Size = New System.Drawing.Size(197, 20)
        Me.C4Arc.TabIndex = 16
        '
        'C4URL
        '
        Me.C4URL.Location = New System.Drawing.Point(228, 100)
        Me.C4URL.Name = "C4URL"
        Me.C4URL.Size = New System.Drawing.Size(197, 20)
        Me.C4URL.TabIndex = 17
        '
        'C4Name
        '
        Me.C4Name.Location = New System.Drawing.Point(432, 100)
        Me.C4Name.Name = "C4Name"
        Me.C4Name.Size = New System.Drawing.Size(110, 20)
        Me.C4Name.TabIndex = 18
        '
        'C4Date
        '
        Me.C4Date.FormattingEnabled = True
        Me.C4Date.Items.AddRange(New Object() {"YYYYMMDD"})
        Me.C4Date.Location = New System.Drawing.Point(553, 99)
        Me.C4Date.Name = "C4Date"
        Me.C4Date.Size = New System.Drawing.Size(147, 21)
        Me.C4Date.TabIndex = 19
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(25, 126)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(675, 40)
        Me.cmdSave.TabIndex = 20
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'comicmanager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 189)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.C4Date)
        Me.Controls.Add(Me.C4Name)
        Me.Controls.Add(Me.C4URL)
        Me.Controls.Add(Me.C4Arc)
        Me.Controls.Add(Me.C3Date)
        Me.Controls.Add(Me.C3Name)
        Me.Controls.Add(Me.C3Arc)
        Me.Controls.Add(Me.C3URL)
        Me.Controls.Add(Me.C2Date)
        Me.Controls.Add(Me.C2Name)
        Me.Controls.Add(Me.C2URL)
        Me.Controls.Add(Me.C2Arc)
        Me.Controls.Add(Me.C1Date)
        Me.Controls.Add(Me.C1Name)
        Me.Controls.Add(Me.C1URL)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.C1Arc)
        Me.MaximumSize = New System.Drawing.Size(741, 228)
        Me.MinimumSize = New System.Drawing.Size(741, 228)
        Me.Name = "comicmanager"
        Me.ShowIcon = False
        Me.Text = "Comic Manager"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1Arc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents C1URL As System.Windows.Forms.TextBox
    Friend WithEvents C1Name As System.Windows.Forms.TextBox
    Friend WithEvents C1Date As System.Windows.Forms.ComboBox
    Friend WithEvents C2Arc As System.Windows.Forms.TextBox
    Friend WithEvents C2URL As System.Windows.Forms.TextBox
    Friend WithEvents C2Name As System.Windows.Forms.TextBox
    Friend WithEvents C2Date As System.Windows.Forms.ComboBox
    Friend WithEvents C3URL As System.Windows.Forms.TextBox
    Friend WithEvents C3Arc As System.Windows.Forms.TextBox
    Friend WithEvents C3Name As System.Windows.Forms.TextBox
    Friend WithEvents C3Date As System.Windows.Forms.ComboBox
    Friend WithEvents C4Arc As System.Windows.Forms.TextBox
    Friend WithEvents C4URL As System.Windows.Forms.TextBox
    Friend WithEvents C4Name As System.Windows.Forms.TextBox
    Friend WithEvents C4Date As System.Windows.Forms.ComboBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
End Class
