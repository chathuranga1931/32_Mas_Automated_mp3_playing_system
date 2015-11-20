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
        Me.AutomatedEventHandlerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WindowsMediaPlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditEventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.opd = New System.Windows.Forms.OpenFileDialog
        Me.CurrentTime = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.wmp = New AxWMPLib.AxWindowsMediaPlayer
        Me.fd = New System.Windows.Forms.OpenFileDialog
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.lb1 = New System.Windows.Forms.Label
        Me.tbXRead = New System.Windows.Forms.TextBox
        Me.wmp2 = New AxWMPLib.AxWindowsMediaPlayer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbEvents = New System.Windows.Forms.TextBox
        Me.btOff = New System.Windows.Forms.Button
        Me.btNew = New System.Windows.Forms.Button
        Me.btOn = New System.Windows.Forms.Button
        Me.lbPlaylist = New System.Windows.Forms.ListBox
        Me.MenuStrip1.SuspendLayout()
        CType(Me.wmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wmp2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(787, 24)
        Me.MenuStrip1.TabIndex = 36
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewEventToolStripMenuItem, Me.EditEventToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewEventToolStripMenuItem
        '
        Me.NewEventToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutomatedEventHandlerToolStripMenuItem, Me.WindowsMediaPlayerToolStripMenuItem})
        Me.NewEventToolStripMenuItem.Name = "NewEventToolStripMenuItem"
        Me.NewEventToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.NewEventToolStripMenuItem.Text = "New Event"
        '
        'AutomatedEventHandlerToolStripMenuItem
        '
        Me.AutomatedEventHandlerToolStripMenuItem.Name = "AutomatedEventHandlerToolStripMenuItem"
        Me.AutomatedEventHandlerToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.AutomatedEventHandlerToolStripMenuItem.Text = "Automated Event Handler"
        '
        'WindowsMediaPlayerToolStripMenuItem
        '
        Me.WindowsMediaPlayerToolStripMenuItem.Name = "WindowsMediaPlayerToolStripMenuItem"
        Me.WindowsMediaPlayerToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.WindowsMediaPlayerToolStripMenuItem.Text = "Windows Media Player"
        '
        'EditEventToolStripMenuItem
        '
        Me.EditEventToolStripMenuItem.Name = "EditEventToolStripMenuItem"
        Me.EditEventToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.EditEventToolStripMenuItem.Text = "Edit Event"
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
        Me.CurrentTime.Location = New System.Drawing.Point(703, 5)
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
        Me.wmp.Location = New System.Drawing.Point(22, 29)
        Me.wmp.Name = "wmp"
        Me.wmp.OcxState = CType(resources.GetObject("wmp.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmp.Size = New System.Drawing.Size(219, 189)
        Me.wmp.TabIndex = 38
        '
        'fd
        '
        Me.fd.FileName = "OpenFileDialog1"
        Me.fd.Filter = "Mp3 file(.mp3)|*.mp3"
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
        Me.lb1.Location = New System.Drawing.Point(90, 66)
        Me.lb1.MaximumSize = New System.Drawing.Size(120, 80)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(114, 80)
        Me.lb1.TabIndex = 41
        Me.lb1.Text = "Label1"
        Me.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lb1.Visible = False
        '
        'tbXRead
        '
        Me.tbXRead.ImeMode = System.Windows.Forms.ImeMode.HangulFull
        Me.tbXRead.Location = New System.Drawing.Point(269, 54)
        Me.tbXRead.Multiline = True
        Me.tbXRead.Name = "tbXRead"
        Me.tbXRead.Size = New System.Drawing.Size(449, 164)
        Me.tbXRead.TabIndex = 42
        '
        'wmp2
        '
        Me.wmp2.Enabled = True
        Me.wmp2.Location = New System.Drawing.Point(23, 33)
        Me.wmp2.Name = "wmp2"
        Me.wmp2.OcxState = CType(resources.GetObject("wmp2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmp2.Size = New System.Drawing.Size(219, 223)
        Me.wmp2.TabIndex = 43
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbXRead)
        Me.GroupBox1.Controls.Add(Me.lb1)
        Me.GroupBox1.Controls.Add(Me.wmp)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(742, 243)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Automated Event Hnadler"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(269, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Event List"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tbEvents)
        Me.GroupBox2.Controls.Add(Me.btOff)
        Me.GroupBox2.Controls.Add(Me.btNew)
        Me.GroupBox2.Controls.Add(Me.btOn)
        Me.GroupBox2.Controls.Add(Me.lbPlaylist)
        Me.GroupBox2.Controls.Add(Me.wmp2)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 291)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(743, 315)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Windows Media Player"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(271, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Event List"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(270, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "All Playlist"
        '
        'tbEvents
        '
        Me.tbEvents.ImeMode = System.Windows.Forms.ImeMode.HangulFull
        Me.tbEvents.Location = New System.Drawing.Point(270, 171)
        Me.tbEvents.Multiline = True
        Me.tbEvents.Name = "tbEvents"
        Me.tbEvents.Size = New System.Drawing.Size(449, 85)
        Me.tbEvents.TabIndex = 47
        '
        'btOff
        '
        Me.btOff.Location = New System.Drawing.Point(34, 271)
        Me.btOff.Name = "btOff"
        Me.btOff.Size = New System.Drawing.Size(91, 23)
        Me.btOff.TabIndex = 46
        Me.btOff.Text = "Off"
        Me.btOff.UseVisualStyleBackColor = True
        Me.btOff.Visible = False
        '
        'btNew
        '
        Me.btNew.Location = New System.Drawing.Point(132, 271)
        Me.btNew.Name = "btNew"
        Me.btNew.Size = New System.Drawing.Size(91, 23)
        Me.btNew.TabIndex = 45
        Me.btNew.Text = "New Playlist"
        Me.btNew.UseVisualStyleBackColor = True
        '
        'btOn
        '
        Me.btOn.Location = New System.Drawing.Point(35, 271)
        Me.btOn.Name = "btOn"
        Me.btOn.Size = New System.Drawing.Size(91, 23)
        Me.btOn.TabIndex = 45
        Me.btOn.Text = "On"
        Me.btOn.UseVisualStyleBackColor = True
        '
        'lbPlaylist
        '
        Me.lbPlaylist.Enabled = False
        Me.lbPlaylist.FormattingEnabled = True
        Me.lbPlaylist.Items.AddRange(New Object() {"Add your media"})
        Me.lbPlaylist.Location = New System.Drawing.Point(270, 54)
        Me.lbPlaylist.Name = "lbPlaylist"
        Me.lbPlaylist.Size = New System.Drawing.Size(449, 82)
        Me.lbPlaylist.TabIndex = 44
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(787, 619)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CurrentTime)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "MP3 Scheduler 15.1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.wmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wmp2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents fd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents lb1 As System.Windows.Forms.Label
    Friend WithEvents tbXRead As System.Windows.Forms.TextBox
    Friend WithEvents wmp2 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btNew As System.Windows.Forms.Button
    Friend WithEvents btOn As System.Windows.Forms.Button
    Friend WithEvents btOff As System.Windows.Forms.Button
    Friend WithEvents tbEvents As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbPlaylist As System.Windows.Forms.ListBox
    Friend WithEvents AutomatedEventHandlerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMediaPlayerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
