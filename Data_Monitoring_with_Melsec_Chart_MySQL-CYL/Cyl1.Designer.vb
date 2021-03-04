<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cyl1
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
        Me.components = New System.ComponentModel.Container()
        Me.SevenSegmentArray4 = New DmitryBrant.CustomControls.SevenSegmentArray()
        Me.SevenSegmentArray3 = New DmitryBrant.CustomControls.SevenSegmentArray()
        Me.SevenSegmentArray2 = New DmitryBrant.CustomControls.SevenSegmentArray()
        Me.SevenSegmentArray1 = New DmitryBrant.CustomControls.SevenSegmentArray()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLogical = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMonitor = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.tmrMonitor = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SevenSegmentArray5 = New DmitryBrant.CustomControls.SevenSegmentArray()
        Me.SuspendLayout()
        '
        'SevenSegmentArray4
        '
        Me.SevenSegmentArray4.ArrayCount = 4
        Me.SevenSegmentArray4.ColorBackground = System.Drawing.Color.Black
        Me.SevenSegmentArray4.ColorDark = System.Drawing.Color.Black
        Me.SevenSegmentArray4.ColorLight = System.Drawing.Color.Red
        Me.SevenSegmentArray4.DecimalShow = True
        Me.SevenSegmentArray4.ElementPadding = New System.Windows.Forms.Padding(4)
        Me.SevenSegmentArray4.ElementWidth = 10
        Me.SevenSegmentArray4.ItalicFactor = 0!
        Me.SevenSegmentArray4.Location = New System.Drawing.Point(410, 164)
        Me.SevenSegmentArray4.Name = "SevenSegmentArray4"
        Me.SevenSegmentArray4.Size = New System.Drawing.Size(178, 71)
        Me.SevenSegmentArray4.TabIndex = 59
        Me.SevenSegmentArray4.TabStop = False
        Me.SevenSegmentArray4.Value = Nothing
        '
        'SevenSegmentArray3
        '
        Me.SevenSegmentArray3.ArrayCount = 4
        Me.SevenSegmentArray3.ColorBackground = System.Drawing.Color.Black
        Me.SevenSegmentArray3.ColorDark = System.Drawing.Color.Black
        Me.SevenSegmentArray3.ColorLight = System.Drawing.Color.Red
        Me.SevenSegmentArray3.DecimalShow = True
        Me.SevenSegmentArray3.ElementPadding = New System.Windows.Forms.Padding(4)
        Me.SevenSegmentArray3.ElementWidth = 10
        Me.SevenSegmentArray3.ItalicFactor = 0!
        Me.SevenSegmentArray3.Location = New System.Drawing.Point(410, 90)
        Me.SevenSegmentArray3.Name = "SevenSegmentArray3"
        Me.SevenSegmentArray3.Size = New System.Drawing.Size(178, 71)
        Me.SevenSegmentArray3.TabIndex = 58
        Me.SevenSegmentArray3.TabStop = False
        Me.SevenSegmentArray3.Value = Nothing
        '
        'SevenSegmentArray2
        '
        Me.SevenSegmentArray2.ArrayCount = 4
        Me.SevenSegmentArray2.ColorBackground = System.Drawing.Color.Black
        Me.SevenSegmentArray2.ColorDark = System.Drawing.Color.Black
        Me.SevenSegmentArray2.ColorLight = System.Drawing.Color.Red
        Me.SevenSegmentArray2.DecimalShow = True
        Me.SevenSegmentArray2.ElementPadding = New System.Windows.Forms.Padding(4)
        Me.SevenSegmentArray2.ElementWidth = 10
        Me.SevenSegmentArray2.ItalicFactor = 0!
        Me.SevenSegmentArray2.Location = New System.Drawing.Point(226, 164)
        Me.SevenSegmentArray2.Name = "SevenSegmentArray2"
        Me.SevenSegmentArray2.Size = New System.Drawing.Size(178, 71)
        Me.SevenSegmentArray2.TabIndex = 57
        Me.SevenSegmentArray2.TabStop = False
        Me.SevenSegmentArray2.Value = Nothing
        '
        'SevenSegmentArray1
        '
        Me.SevenSegmentArray1.ArrayCount = 4
        Me.SevenSegmentArray1.ColorBackground = System.Drawing.Color.Black
        Me.SevenSegmentArray1.ColorDark = System.Drawing.Color.Black
        Me.SevenSegmentArray1.ColorLight = System.Drawing.Color.Red
        Me.SevenSegmentArray1.DecimalShow = True
        Me.SevenSegmentArray1.ElementPadding = New System.Windows.Forms.Padding(4)
        Me.SevenSegmentArray1.ElementWidth = 10
        Me.SevenSegmentArray1.ItalicFactor = 0!
        Me.SevenSegmentArray1.Location = New System.Drawing.Point(226, 90)
        Me.SevenSegmentArray1.Name = "SevenSegmentArray1"
        Me.SevenSegmentArray1.Size = New System.Drawing.Size(178, 71)
        Me.SevenSegmentArray1.TabIndex = 56
        Me.SevenSegmentArray1.TabStop = False
        Me.SevenSegmentArray1.Value = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(325, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 31)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Cylindrical 1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Logical Station"
        '
        'txtLogical
        '
        Me.txtLogical.Location = New System.Drawing.Point(19, 203)
        Me.txtLogical.Name = "txtLogical"
        Me.txtLogical.Size = New System.Drawing.Size(72, 20)
        Me.txtLogical.TabIndex = 69
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(19, 154)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 68
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnMonitor
        '
        Me.btnMonitor.Location = New System.Drawing.Point(19, 125)
        Me.btnMonitor.Name = "btnMonitor"
        Me.btnMonitor.Size = New System.Drawing.Size(75, 23)
        Me.btnMonitor.TabIndex = 67
        Me.btnMonitor.Text = "Monitor Start"
        Me.btnMonitor.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(19, 96)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 66
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(19, 67)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 65
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(224, 317)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Message"
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(226, 333)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(342, 20)
        Me.txtMessage.TabIndex = 71
        '
        'tmrMonitor
        '
        Me.tmrMonitor.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(260, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 31)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Upper"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(445, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 31)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Lower"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(141, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 24)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Voltage"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(141, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 24)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Current"
        '
        'SevenSegmentArray5
        '
        Me.SevenSegmentArray5.ArrayCount = 4
        Me.SevenSegmentArray5.ColorBackground = System.Drawing.Color.Black
        Me.SevenSegmentArray5.ColorDark = System.Drawing.Color.Black
        Me.SevenSegmentArray5.ColorLight = System.Drawing.Color.Red
        Me.SevenSegmentArray5.DecimalShow = True
        Me.SevenSegmentArray5.ElementPadding = New System.Windows.Forms.Padding(4)
        Me.SevenSegmentArray5.ElementWidth = 10
        Me.SevenSegmentArray5.ItalicFactor = 0!
        Me.SevenSegmentArray5.Location = New System.Drawing.Point(322, 241)
        Me.SevenSegmentArray5.Name = "SevenSegmentArray5"
        Me.SevenSegmentArray5.Size = New System.Drawing.Size(178, 71)
        Me.SevenSegmentArray5.TabIndex = 77
        Me.SevenSegmentArray5.TabStop = False
        Me.SevenSegmentArray5.Value = Nothing
        '
        'Cyl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 450)
        Me.Controls.Add(Me.SevenSegmentArray5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLogical)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMonitor)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SevenSegmentArray4)
        Me.Controls.Add(Me.SevenSegmentArray3)
        Me.Controls.Add(Me.SevenSegmentArray2)
        Me.Controls.Add(Me.SevenSegmentArray1)
        Me.Name = "Cyl1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cyl1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SevenSegmentArray4 As DmitryBrant.CustomControls.SevenSegmentArray
    Friend WithEvents SevenSegmentArray3 As DmitryBrant.CustomControls.SevenSegmentArray
    Friend WithEvents SevenSegmentArray2 As DmitryBrant.CustomControls.SevenSegmentArray
    Friend WithEvents SevenSegmentArray1 As DmitryBrant.CustomControls.SevenSegmentArray
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLogical As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMonitor As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnOpen As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents tmrMonitor As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents SevenSegmentArray5 As DmitryBrant.CustomControls.SevenSegmentArray
End Class
