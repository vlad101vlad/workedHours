<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
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
        Me.loginBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'loginBTN
        '
        Me.loginBTN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.loginBTN.Location = New System.Drawing.Point(0, 0)
        Me.loginBTN.Name = "loginBTN"
        Me.loginBTN.Size = New System.Drawing.Size(284, 261)
        Me.loginBTN.TabIndex = 0
        Me.loginBTN.Text = "Log in "
        Me.loginBTN.UseVisualStyleBackColor = True
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.loginBTN)
        Me.Name = "loginForm"
        Me.Text = "loginForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents loginBTN As Button
End Class
