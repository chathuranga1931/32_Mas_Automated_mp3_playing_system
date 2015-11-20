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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewEventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditEventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.opd = New System.Windows.Forms.OpenFileDialog
        Me.CurrentTime = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.wmp = New AxWMPLib.AxWindowsMediaPlayer
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.lb1 = New System.Windows.Forms.Label
        Me.tbXRead = New System.Windows.Forms.TextBox
        Me.MenuStrip1.SuspendLayout()
        CType(Me.wmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(740, 24)
        Me.MenuStrip1.TabIndex = 36
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewEventToolStripMenuItem, Me.EditEventToolStripMenuItem, Me.PlayToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewEventToolStripMenuItem
        '
        Me.NewEventToolStripMenuItem.Name = "NewEventToolStripMenuItem"
        Me.NewEventToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewEventToolStripMenuItem.Text = "New Event"
        '
        'EditEventToolStripMenuItem
        '
        Me.EditEventToolStripMenuItem.Name = "EditEventToolStripMenuItem"
        Me.EditEventToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditEventToolStripMenuItem.Text = "Edit Event"
        '
        'PlayToolStripMenuItem
        '
        Me.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem"
        Me.PlayToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PlayToolStripMenuItem.Text = "Play Playlist"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'opd
        '
        Me.opd.FileName = "OpenFileDialog1"
        '
        'CurrentTime
        '
        Me.CurrentTime.AutoSize = True
        Me.CurrentTime.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentTime.Location = New System.Drawing.Point(664, 9)
        Me.CurrentTime.Name = "CurrentTime"
        Me.CurrentTime.Size = New System.Drawing.Size(40, 13)
        Me.CurrentTime.TabIndex = 37
        Me.CurrentTime.Text = "Label1"
        Me.CurrentTime.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'wmp
        '
        Me.wmp.Enabled = True
        Me.wmp.Location = New System.Drawing.Point(12, 27)
        Me.wmp.Name = "wmp"
        Me.wmp.OcxState = CType(resources.GetObject("wmp.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmp.Size = New System.Drawing.Size(283, 492)
        Me.wmp.TabIndex = 38
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Mp3 file(.mp3)|*.mp3"
        '
        'Timer2
        '
        Me.Timer2.Interval = 60000
        '
        'Timer3
        '
        Me.Timer3.Interval = 5000
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb1.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb1.ForeColor = System.Drawing.Color.Red
        Me.lb1.Location = New System.Drawing.Point(106, 200)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(221, 73)
        Me.lb1.TabIndex = 41
        Me.lb1.Text = "Label1"
        Me.lb1.Visible = False
        '
        'tbXRead
        '
        Me.tbXRead.ImeMode = System.Windows.Forms.ImeMode.HangulFull
        Me.tbXRead.Location = New System.Drawing.Point(302, 28)
        Me.tbXRead.Multiline = True
        Me.tbXRead.Name = "tbXRead"
        Me.tbXRead.Size = New System.Drawing.Size(426, 491)
        Me.tbXRead.TabIndex = 42
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(740, 531)
        Me.Controls.Add(Me.tbXRead)
        Me.Controls.Add(Me.lb1)
        Me.Controls.Add(Me.wmp)
        Me.Controls.Add(Me.CurrentTime)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Automated mp3 Schedular"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.wmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewEventToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditEventToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents opd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CurrentTime As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents wmp As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents lb1 As System.Windows.Forms.Label
    Friend WithEvents PlayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbXRead As System.Windows.Forms.TextBox

End Class
