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
        Me.L1 = New System.Windows.Forms.ListBox()
        Me.BGWMain = New System.ComponentModel.BackgroundWorker()
        Me.BtnEcDc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'L1
        '
        Me.L1.AllowDrop = True
        Me.L1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.L1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.L1.ForeColor = System.Drawing.Color.White
        Me.L1.FormattingEnabled = True
        Me.L1.Location = New System.Drawing.Point(0, 0)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(337, 263)
        Me.L1.TabIndex = 0
        '
        'BGWMain
        '
        '
        'BtnEcDc
        '
        Me.BtnEcDc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEcDc.Location = New System.Drawing.Point(260, 3)
        Me.BtnEcDc.Name = "BtnEcDc"
        Me.BtnEcDc.Size = New System.Drawing.Size(74, 38)
        Me.BtnEcDc.TabIndex = 1
        Me.BtnEcDc.Text = "Encrypt"
        Me.BtnEcDc.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 263)
        Me.Controls.Add(Me.BtnEcDc)
        Me.Controls.Add(Me.L1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multi-Thread Encrypt Decrypt File"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents L1 As System.Windows.Forms.ListBox
    Friend WithEvents BGWMain As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnEcDc As System.Windows.Forms.Button

End Class
