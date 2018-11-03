<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class insertShiftForm
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
        Me.insertDateLabel = New System.Windows.Forms.Label()
        Me.dateTB = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'insertDateLabel
        '
        Me.insertDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.insertDateLabel.AutoSize = True
        Me.insertDateLabel.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.insertDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.insertDateLabel.Location = New System.Drawing.Point(12, 50)
        Me.insertDateLabel.Name = "insertDateLabel"
        Me.insertDateLabel.Size = New System.Drawing.Size(132, 26)
        Me.insertDateLabel.TabIndex = 0
        Me.insertDateLabel.Text = "Insert date:"
        '
        'dateTB
        '
        Me.dateTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.dateTB.Location = New System.Drawing.Point(150, 50)
        Me.dateTB.Name = "dateTB"
        Me.dateTB.Size = New System.Drawing.Size(100, 32)
        Me.dateTB.TabIndex = 1
        '
        'insertShiftForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(359, 336)
        Me.Controls.Add(Me.dateTB)
        Me.Controls.Add(Me.insertDateLabel)
        Me.Name = "insertShiftForm"
        Me.Text = "Shift"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents insertDateLabel As Label
    Friend WithEvents dateTB As TextBox
End Class
