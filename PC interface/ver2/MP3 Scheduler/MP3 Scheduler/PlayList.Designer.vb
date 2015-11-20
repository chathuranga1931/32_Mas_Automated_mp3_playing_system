<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayList
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
        Me.components = New System.ComponentModel.Container
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.fd = New System.Windows.Forms.OpenFileDialog
        Me.btOpen = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.tbPlaylist = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbPlaylist = New System.Windows.Forms.ListBox
        Me.btAdd = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'fd
        '
        Me.fd.FileName = "OpenFileDialog1"
        '
        'btOpen
        '
        Me.btOpen.Location = New System.Drawing.Point(430, 373)
        Me.btOpen.Name = "btOpen"
        Me.btOpen.Size = New System.Drawing.Size(75, 23)
        Me.btOpen.TabIndex = 1
        Me.btOpen.Text = "Open"
        Me.btOpen.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(511, 373)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(75, 23)
        Me.btSave.TabIndex = 3
        Me.btSave.Text = "Save"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'tbPlaylist
        '
        Me.tbPlaylist.Location = New System.Drawing.Point(97, 27)
        Me.tbPlaylist.Name = "tbPlaylist"
        Me.tbPlaylist.Size = New System.Drawing.Size(489, 20)
        Me.tbPlaylist.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Playlist Name"
        '
        'lbPlaylist
        '
        Me.lbPlaylist.FormattingEnabled = True
        Me.lbPlaylist.Location = New System.Drawing.Point(97, 64)
        Me.lbPlaylist.Name = "lbPlaylist"
        Me.lbPlaylist.Size = New System.Drawing.Size(489, 303)
        Me.lbPlaylist.TabIndex = 6
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(430, 373)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(75, 23)
        Me.btAdd.TabIndex = 7
        Me.btAdd.Text = "Add"
        Me.btAdd.UseVisualStyleBackColor = True
        Me.btAdd.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btAdd)
        Me.GroupBox1.Controls.Add(Me.lbPlaylist)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbPlaylist)
        Me.GroupBox1.Controls.Add(Me.btSave)
        Me.GroupBox1.Controls.Add(Me.btOpen)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(604, 411)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'PlayList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 435)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PlayList"
        Me.Text = "Create New Playlist"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents fd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btOpen As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents tbPlaylist As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbPlaylist As System.Windows.Forms.ListBox
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
