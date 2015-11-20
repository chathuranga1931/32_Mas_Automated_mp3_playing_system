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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlayList))
        Me.wmp = New AxWMPLib.AxWindowsMediaPlayer
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.fd = New System.Windows.Forms.OpenFileDialog
        Me.btOpen = New System.Windows.Forms.Button
        Me.lbPlaylist = New System.Windows.Forms.ListBox
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.wmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'wmp
        '
        Me.wmp.Dock = System.Windows.Forms.DockStyle.Left
        Me.wmp.Enabled = True
        Me.wmp.Location = New System.Drawing.Point(0, 0)
        Me.wmp.Name = "wmp"
        Me.wmp.OcxState = CType(resources.GetObject("wmp.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmp.Size = New System.Drawing.Size(222, 487)
        Me.wmp.TabIndex = 0
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
        Me.btOpen.Location = New System.Drawing.Point(228, 452)
        Me.btOpen.Name = "btOpen"
        Me.btOpen.Size = New System.Drawing.Size(75, 23)
        Me.btOpen.TabIndex = 1
        Me.btOpen.Text = "Open"
        Me.btOpen.UseVisualStyleBackColor = True
        '
        'lbPlaylist
        '
        Me.lbPlaylist.FormattingEnabled = True
        Me.lbPlaylist.Items.AddRange(New Object() {"Add your media"})
        Me.lbPlaylist.Location = New System.Drawing.Point(228, 5)
        Me.lbPlaylist.Name = "lbPlaylist"
        Me.lbPlaylist.Size = New System.Drawing.Size(421, 173)
        Me.lbPlaylist.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(310, 451)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PlayList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 487)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbPlaylist)
        Me.Controls.Add(Me.btOpen)
        Me.Controls.Add(Me.wmp)
        Me.Name = "PlayList"
        Me.Text = "Windows Media Player"
        CType(Me.wmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents wmp As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents fd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btOpen As System.Windows.Forms.Button
    Friend WithEvents lbPlaylist As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
