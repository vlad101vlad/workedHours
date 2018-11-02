<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class menuForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.menuLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.welcomeLabel = New System.Windows.Forms.Label()
        Me.addShiftBTN = New System.Windows.Forms.Button()
        Me.menuLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuLayoutPanel
        '
        Me.menuLayoutPanel.ColumnCount = 1
        Me.menuLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.menuLayoutPanel.Controls.Add(Me.welcomeLabel, 0, 0)
        Me.menuLayoutPanel.Controls.Add(Me.addShiftBTN, 0, 1)
        Me.menuLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.menuLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.menuLayoutPanel.Name = "menuLayoutPanel"
        Me.menuLayoutPanel.RowCount = 3
        Me.menuLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947!))
        Me.menuLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.10526!))
        Me.menuLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.10526!))
        Me.menuLayoutPanel.Size = New System.Drawing.Size(884, 561)
        Me.menuLayoutPanel.TabIndex = 0
        '
        'welcomeLabel
        '
        Me.welcomeLabel.AutoSize = True
        Me.welcomeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.welcomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.welcomeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.welcomeLabel.Location = New System.Drawing.Point(3, 0)
        Me.welcomeLabel.Name = "welcomeLabel"
        Me.welcomeLabel.Size = New System.Drawing.Size(878, 88)
        Me.welcomeLabel.TabIndex = 0
        Me.welcomeLabel.Text = "Working Hours Tracker"
        Me.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'addShiftBTN
        '
        Me.addShiftBTN.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.addShiftBTN.FlatAppearance.BorderSize = 3
        Me.addShiftBTN.Location = New System.Drawing.Point(214, 156)
        Me.addShiftBTN.Name = "addShiftBTN"
        Me.addShiftBTN.Size = New System.Drawing.Size(455, 100)
        Me.addShiftBTN.TabIndex = 1
        Me.addShiftBTN.Text = "Insert a shift"
        Me.addShiftBTN.UseVisualStyleBackColor = True
        '
        'menuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.menuLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "menuForm"
        Me.Text = "Menu"
        Me.menuLayoutPanel.ResumeLayout(False)
        Me.menuLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents menuLayoutPanel As TableLayoutPanel
    Friend WithEvents welcomeLabel As Label
    Friend WithEvents addShiftBTN As Button
End Class
