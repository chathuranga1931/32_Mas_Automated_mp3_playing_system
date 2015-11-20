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
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblSystemSerialNumbers = New System.Windows.Forms.Label
        Me.lblCpuIds = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "System Serial Numbers:"
        '
        'lblSystemSerialNumbers
        '
        Me.lblSystemSerialNumbers.AutoSize = True
        Me.lblSystemSerialNumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemSerialNumbers.Location = New System.Drawing.Point(24, 32)
        Me.lblSystemSerialNumbers.Name = "lblSystemSerialNumbers"
        Me.lblSystemSerialNumbers.Size = New System.Drawing.Size(86, 29)
        Me.lblSystemSerialNumbers.TabIndex = 1
        Me.lblSystemSerialNumbers.Text = "Label2"
        '
        'lblCpuIds
        '
        Me.lblCpuIds.AutoSize = True
        Me.lblCpuIds.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCpuIds.Location = New System.Drawing.Point(24, 96)
        Me.lblCpuIds.Name = "lblCpuIds"
        Me.lblCpuIds.Size = New System.Drawing.Size(86, 29)
        Me.lblCpuIds.TabIndex = 3
        Me.lblCpuIds.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CPU IDs:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 266)
        Me.Controls.Add(Me.lblCpuIds)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSystemSerialNumbers)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSystemSerialNumbers As System.Windows.Forms.Label
    Friend WithEvents lblCpuIds As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
