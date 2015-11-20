<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Event
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbSelectEvnt = New System.Windows.Forms.ComboBox
        Me.gbEdit = New System.Windows.Forms.GroupBox
        Me.cbSecond = New System.Windows.Forms.ComboBox
        Me.cbMinute = New System.Windows.Forms.ComboBox
        Me.cbHour = New System.Windows.Forms.ComboBox
        Me.tbFileLocaion = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbEventName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.BtnBrowseAdd = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cbSat = New System.Windows.Forms.CheckBox
        Me.cbFri = New System.Windows.Forms.CheckBox
        Me.cbSun = New System.Windows.Forms.CheckBox
        Me.cbThu = New System.Windows.Forms.CheckBox
        Me.cbWed = New System.Windows.Forms.CheckBox
        Me.cbTue = New System.Windows.Forms.CheckBox
        Me.cbMon = New System.Windows.Forms.CheckBox
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnDel = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.opd = New System.Windows.Forms.OpenFileDialog
        Me.GroupBox1.SuspendLayout()
        Me.gbEdit.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbSelectEvnt)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(566, 73)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Event"
        '
        'cbSelectEvnt
        '
        Me.cbSelectEvnt.FormattingEnabled = True
        Me.cbSelectEvnt.Location = New System.Drawing.Point(102, 25)
        Me.cbSelectEvnt.Name = "cbSelectEvnt"
        Me.cbSelectEvnt.Size = New System.Drawing.Size(451, 21)
        Me.cbSelectEvnt.TabIndex = 0
        Me.cbSelectEvnt.Text = "Select event"
        '
        'gbEdit
        '
        Me.gbEdit.Controls.Add(Me.cbSecond)
        Me.gbEdit.Controls.Add(Me.cbMinute)
        Me.gbEdit.Controls.Add(Me.cbHour)
        Me.gbEdit.Controls.Add(Me.tbFileLocaion)
        Me.gbEdit.Controls.Add(Me.Label10)
        Me.gbEdit.Controls.Add(Me.Label7)
        Me.gbEdit.Controls.Add(Me.Label6)
        Me.gbEdit.Controls.Add(Me.Label5)
        Me.gbEdit.Controls.Add(Me.Label4)
        Me.gbEdit.Controls.Add(Me.tbEventName)
        Me.gbEdit.Controls.Add(Me.Label3)
        Me.gbEdit.Controls.Add(Me.Label2)
        Me.gbEdit.Controls.Add(Me.Label8)
        Me.gbEdit.Controls.Add(Me.BtnBrowseAdd)
        Me.gbEdit.Controls.Add(Me.GroupBox3)
        Me.gbEdit.Controls.Add(Me.BtnCancel)
        Me.gbEdit.Controls.Add(Me.BtnDel)
        Me.gbEdit.Controls.Add(Me.BtnSave)
        Me.gbEdit.Enabled = False
        Me.gbEdit.Location = New System.Drawing.Point(13, 104)
        Me.gbEdit.Name = "gbEdit"
        Me.gbEdit.Size = New System.Drawing.Size(566, 327)
        Me.gbEdit.TabIndex = 1
        Me.gbEdit.TabStop = False
        Me.gbEdit.Text = "Edit settings"
        '
        'cbSecond
        '
        Me.cbSecond.FormattingEnabled = True
        Me.cbSecond.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.cbSecond.Location = New System.Drawing.Point(231, 72)
        Me.cbSecond.Name = "cbSecond"
        Me.cbSecond.Size = New System.Drawing.Size(47, 21)
        Me.cbSecond.TabIndex = 93
        Me.cbSecond.Text = "00"
        '
        'cbMinute
        '
        Me.cbMinute.FormattingEnabled = True
        Me.cbMinute.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.cbMinute.Location = New System.Drawing.Point(166, 72)
        Me.cbMinute.Name = "cbMinute"
        Me.cbMinute.Size = New System.Drawing.Size(47, 21)
        Me.cbMinute.TabIndex = 94
        Me.cbMinute.Text = "00"
        '
        'cbHour
        '
        Me.cbHour.FormattingEnabled = True
        Me.cbHour.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.cbHour.Location = New System.Drawing.Point(102, 71)
        Me.cbHour.Name = "cbHour"
        Me.cbHour.Size = New System.Drawing.Size(47, 21)
        Me.cbHour.TabIndex = 95
        Me.cbHour.Text = "07"
        '
        'tbFileLocaion
        '
        Me.tbFileLocaion.Location = New System.Drawing.Point(103, 113)
        Me.tbFileLocaion.Name = "tbFileLocaion"
        Me.tbFileLocaion.Size = New System.Drawing.Size(360, 20)
        Me.tbFileLocaion.TabIndex = 92
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "File Location"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(228, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 13)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "ss"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(163, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "mm"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(99, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 13)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "hh"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(219, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = ":"
        '
        'tbEventName
        '
        Me.tbEventName.Location = New System.Drawing.Point(103, 31)
        Me.tbEventName.Name = "tbEventName"
        Me.tbEventName.Size = New System.Drawing.Size(450, 20)
        Me.tbEventName.TabIndex = 86
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(155, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Start Time"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 84
        Me.Label8.Text = "Event Name"
        '
        'BtnBrowseAdd
        '
        Me.BtnBrowseAdd.Location = New System.Drawing.Point(469, 111)
        Me.BtnBrowseAdd.Name = "BtnBrowseAdd"
        Me.BtnBrowseAdd.Size = New System.Drawing.Size(84, 23)
        Me.BtnBrowseAdd.TabIndex = 82
        Me.BtnBrowseAdd.Text = "Browse"
        Me.BtnBrowseAdd.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbSat)
        Me.GroupBox3.Controls.Add(Me.cbFri)
        Me.GroupBox3.Controls.Add(Me.cbSun)
        Me.GroupBox3.Controls.Add(Me.cbThu)
        Me.GroupBox3.Controls.Add(Me.cbWed)
        Me.GroupBox3.Controls.Add(Me.cbTue)
        Me.GroupBox3.Controls.Add(Me.cbMon)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 166)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(533, 88)
        Me.GroupBox3.TabIndex = 81
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Check days"
        '
        'cbSat
        '
        Me.cbSat.AutoSize = True
        Me.cbSat.Location = New System.Drawing.Point(382, 40)
        Me.cbSat.Name = "cbSat"
        Me.cbSat.Size = New System.Drawing.Size(68, 17)
        Me.cbSat.TabIndex = 74
        Me.cbSat.Text = "Saturday"
        Me.cbSat.UseVisualStyleBackColor = True
        '
        'cbFri
        '
        Me.cbFri.AutoSize = True
        Me.cbFri.Location = New System.Drawing.Point(325, 40)
        Me.cbFri.Name = "cbFri"
        Me.cbFri.Size = New System.Drawing.Size(54, 17)
        Me.cbFri.TabIndex = 74
        Me.cbFri.Text = "Friday"
        Me.cbFri.UseVisualStyleBackColor = True
        '
        'cbSun
        '
        Me.cbSun.AutoSize = True
        Me.cbSun.Location = New System.Drawing.Point(456, 40)
        Me.cbSun.Name = "cbSun"
        Me.cbSun.Size = New System.Drawing.Size(62, 17)
        Me.cbSun.TabIndex = 74
        Me.cbSun.Text = "Sunday"
        Me.cbSun.UseVisualStyleBackColor = True
        '
        'cbThu
        '
        Me.cbThu.AutoSize = True
        Me.cbThu.Location = New System.Drawing.Point(248, 40)
        Me.cbThu.Name = "cbThu"
        Me.cbThu.Size = New System.Drawing.Size(70, 17)
        Me.cbThu.TabIndex = 74
        Me.cbThu.Text = "Thursday"
        Me.cbThu.UseVisualStyleBackColor = True
        '
        'cbWed
        '
        Me.cbWed.AutoSize = True
        Me.cbWed.Location = New System.Drawing.Point(159, 40)
        Me.cbWed.Name = "cbWed"
        Me.cbWed.Size = New System.Drawing.Size(83, 17)
        Me.cbWed.TabIndex = 74
        Me.cbWed.Text = "Wednesday"
        Me.cbWed.UseVisualStyleBackColor = True
        '
        'cbTue
        '
        Me.cbTue.AutoSize = True
        Me.cbTue.Location = New System.Drawing.Point(86, 40)
        Me.cbTue.Name = "cbTue"
        Me.cbTue.Size = New System.Drawing.Size(67, 17)
        Me.cbTue.TabIndex = 74
        Me.cbTue.Text = "Tuesday"
        Me.cbTue.UseVisualStyleBackColor = True
        '
        'cbMon
        '
        Me.cbMon.AutoSize = True
        Me.cbMon.Location = New System.Drawing.Point(16, 40)
        Me.cbMon.Name = "cbMon"
        Me.cbMon.Size = New System.Drawing.Size(64, 17)
        Me.cbMon.TabIndex = 74
        Me.cbMon.Text = "Monday"
        Me.cbMon.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(291, 278)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(83, 26)
        Me.BtnCancel.TabIndex = 79
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnDel
        '
        Me.BtnDel.Location = New System.Drawing.Point(380, 278)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(83, 26)
        Me.BtnDel.TabIndex = 79
        Me.BtnDel.Text = "Delete"
        Me.BtnDel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(470, 278)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(83, 26)
        Me.BtnSave.TabIndex = 79
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'opd
        '
        Me.opd.FileName = "OpenFileDialog1"
        '
        'Edit_Event
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 447)
        Me.Controls.Add(Me.gbEdit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Edit_Event"
        Me.Text = "Edit Event"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbEdit.ResumeLayout(False)
        Me.gbEdit.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbSelectEvnt As System.Windows.Forms.ComboBox
    Friend WithEvents gbEdit As System.Windows.Forms.GroupBox
    Friend WithEvents cbSecond As System.Windows.Forms.ComboBox
    Friend WithEvents cbMinute As System.Windows.Forms.ComboBox
    Friend WithEvents cbHour As System.Windows.Forms.ComboBox
    Friend WithEvents tbFileLocaion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbEventName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnBrowseAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbSat As System.Windows.Forms.CheckBox
    Friend WithEvents cbFri As System.Windows.Forms.CheckBox
    Friend WithEvents cbSun As System.Windows.Forms.CheckBox
    Friend WithEvents cbThu As System.Windows.Forms.CheckBox
    Friend WithEvents cbWed As System.Windows.Forms.CheckBox
    Friend WithEvents cbTue As System.Windows.Forms.CheckBox
    Friend WithEvents cbMon As System.Windows.Forms.CheckBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnDel As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents opd As System.Windows.Forms.OpenFileDialog
End Class
