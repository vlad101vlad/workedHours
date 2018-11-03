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
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.dateTB = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.checkInLabel = New System.Windows.Forms.Label()
        Me.checkOutLabel = New System.Windows.Forms.Label()
        Me.hours1Label = New System.Windows.Forms.Label()
        Me.hours2Label = New System.Windows.Forms.Label()
        Me.minutes1Label = New System.Windows.Forms.Label()
        Me.minutes2Label = New System.Windows.Forms.Label()
        Me.hoursCITB = New System.Windows.Forms.TextBox()
        Me.hoursCOTB = New System.Windows.Forms.TextBox()
        Me.minutesCITB = New System.Windows.Forms.TextBox()
        Me.minutesCOTB = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateLabel
        '
        Me.DateLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateLabel.AutoSize = True
        Me.DateLabel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.DateLabel.Location = New System.Drawing.Point(12, 50)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(69, 26)
        Me.DateLabel.TabIndex = 0
        Me.DateLabel.Text = "Date:"
        '
        'dateTB
        '
        Me.dateTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.dateTB.Location = New System.Drawing.Point(87, 46)
        Me.dateTB.Name = "dateTB"
        Me.dateTB.Size = New System.Drawing.Size(100, 32)
        Me.dateTB.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(193, 52)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(50, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.Label2.Location = New System.Drawing.Point(12, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hours:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Location = New System.Drawing.Point(14, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "*Note: You can add only quarters into the minutes box"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.minutesCOTB, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.minutesCITB, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.hoursCOTB, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.minutes2Label, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.minutes1Label, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.hours2Label, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.checkOutLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.checkInLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.hours1Label, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.hoursCITB, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 159)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.21951!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.78049!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(335, 82)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'checkInLabel
        '
        Me.checkInLabel.AutoSize = True
        Me.checkInLabel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.checkInLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.checkInLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.checkInLabel.Location = New System.Drawing.Point(3, 0)
        Me.checkInLabel.Name = "checkInLabel"
        Me.checkInLabel.Size = New System.Drawing.Size(126, 42)
        Me.checkInLabel.TabIndex = 0
        Me.checkInLabel.Text = "Check in:"
        Me.checkInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'checkOutLabel
        '
        Me.checkOutLabel.AutoSize = True
        Me.checkOutLabel.BackColor = System.Drawing.Color.CornflowerBlue
        Me.checkOutLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.checkOutLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.checkOutLabel.Location = New System.Drawing.Point(3, 42)
        Me.checkOutLabel.Name = "checkOutLabel"
        Me.checkOutLabel.Size = New System.Drawing.Size(126, 40)
        Me.checkOutLabel.TabIndex = 3
        Me.checkOutLabel.Text = "Check out:"
        Me.checkOutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'hours1Label
        '
        Me.hours1Label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.hours1Label.AutoSize = True
        Me.hours1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.hours1Label.Location = New System.Drawing.Point(135, 8)
        Me.hours1Label.Name = "hours1Label"
        Me.hours1Label.Size = New System.Drawing.Size(29, 26)
        Me.hours1Label.TabIndex = 4
        Me.hours1Label.Text = "H"
        Me.hours1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hours2Label
        '
        Me.hours2Label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.hours2Label.AutoSize = True
        Me.hours2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.hours2Label.Location = New System.Drawing.Point(135, 49)
        Me.hours2Label.Name = "hours2Label"
        Me.hours2Label.Size = New System.Drawing.Size(29, 26)
        Me.hours2Label.TabIndex = 12
        Me.hours2Label.Text = "H"
        Me.hours2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'minutes1Label
        '
        Me.minutes1Label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.minutes1Label.AutoSize = True
        Me.minutes1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.minutes1Label.Location = New System.Drawing.Point(215, 8)
        Me.minutes1Label.Name = "minutes1Label"
        Me.minutes1Label.Size = New System.Drawing.Size(31, 26)
        Me.minutes1Label.TabIndex = 13
        Me.minutes1Label.Text = "M"
        Me.minutes1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'minutes2Label
        '
        Me.minutes2Label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.minutes2Label.AutoSize = True
        Me.minutes2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.minutes2Label.Location = New System.Drawing.Point(215, 49)
        Me.minutes2Label.Name = "minutes2Label"
        Me.minutes2Label.Size = New System.Drawing.Size(31, 26)
        Me.minutes2Label.TabIndex = 14
        Me.minutes2Label.Text = "M"
        Me.minutes2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hoursCITB
        '
        Me.hoursCITB.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.hoursCITB.Location = New System.Drawing.Point(170, 3)
        Me.hoursCITB.Name = "hoursCITB"
        Me.hoursCITB.Size = New System.Drawing.Size(39, 32)
        Me.hoursCITB.TabIndex = 15
        '
        'hoursCOTB
        '
        Me.hoursCOTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.hoursCOTB.Location = New System.Drawing.Point(170, 45)
        Me.hoursCOTB.Name = "hoursCOTB"
        Me.hoursCOTB.Size = New System.Drawing.Size(39, 32)
        Me.hoursCOTB.TabIndex = 16
        '
        'minutesCITB
        '
        Me.minutesCITB.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.minutesCITB.Location = New System.Drawing.Point(252, 3)
        Me.minutesCITB.Name = "minutesCITB"
        Me.minutesCITB.Size = New System.Drawing.Size(39, 32)
        Me.minutesCITB.TabIndex = 17
        '
        'minutesCOTB
        '
        Me.minutesCOTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.minutesCOTB.Location = New System.Drawing.Point(252, 45)
        Me.minutesCOTB.Name = "minutesCOTB"
        Me.minutesCOTB.Size = New System.Drawing.Size(39, 32)
        Me.minutesCOTB.TabIndex = 18
        '
        'insertShiftForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(359, 336)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.dateTB)
        Me.Controls.Add(Me.DateLabel)
        Me.Name = "insertShiftForm"
        Me.Text = "Shift"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateLabel As Label
    Friend WithEvents dateTB As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents checkInLabel As Label
    Friend WithEvents checkOutLabel As Label
    Friend WithEvents minutes2Label As Label
    Friend WithEvents minutes1Label As Label
    Friend WithEvents hours2Label As Label
    Friend WithEvents hours1Label As Label
    Friend WithEvents minutesCOTB As TextBox
    Friend WithEvents minutesCITB As TextBox
    Friend WithEvents hoursCOTB As TextBox
    Friend WithEvents hoursCITB As TextBox
End Class
