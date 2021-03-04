<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cyl6
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
        Me.SevenSegmentArray5 = New DmitryBrant.CustomControls.SevenSegmentArray()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLogical = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnMonitor = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SevenSegmentArray4 = New DmitryBrant.CustomControls.SevenSegmentArray()
        Me.SevenSegmentArray3 = New DmitryBrant.CustomControls.SevenSegmentArray()
        Me.SevenSegmentArray2 = New DmitryBrant.CustomControls.SevenSegmentArray()
        Me.SevenSegmentArray1 = New DmitryBrant.CustomControls.SevenSegmentArray()
        Me.tmrMonitor = New System.Windows.Forms.Timer(Me.components)
        Me.SevenSegmentArray6 = New DmitryBrant.CustomControls.SevenSegmentArray()
        Me.SevenSegmentArray7 = New DmitryBrant.CustomControls.SevenSegmentArray()
        Me.SevenSegmentArray8 = New DmitryBrant.CustomControls.SevenSegmentArray()
        Me.SevenSegmentArray9 = New DmitryBrant.CustomControls.SevenSegmentArray()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        Me.SevenSegmentArray5.Location = New System.Drawing.Point(12, 304)
        Me.SevenSegmentArray5.Name = "SevenSegmentArray5"
        Me.SevenSegmentArray5.Size = New System.Drawing.Size(158, 71)
        Me.SevenSegmentArray5.TabIndex = 166
        Me.SevenSegmentArray5.TabStop = False
        Me.SevenSegmentArray5.Value = Nothing
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(209, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 24)
        Me.Label7.TabIndex = 165
        Me.Label7.Text = "Current"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(209, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 24)
        Me.Label4.TabIndex = 164
        Me.Label4.Text = "Voltage"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(513, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 31)
        Me.Label3.TabIndex = 163
        Me.Label3.Text = "Lower"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 161
        Me.Label6.Text = "Message"
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(11, 267)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(159, 20)
        Me.txtMessage.TabIndex = 160
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 159
        Me.Label5.Text = "Logical Station"
        '
        'txtLogical
        '
        Me.txtLogical.Location = New System.Drawing.Point(12, 226)
        Me.txtLogical.Name = "txtLogical"
        Me.txtLogical.Size = New System.Drawing.Size(72, 20)
        Me.txtLogical.TabIndex = 158
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 177)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 157
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnMonitor
        '
        Me.btnMonitor.Location = New System.Drawing.Point(12, 148)
        Me.btnMonitor.Name = "btnMonitor"
        Me.btnMonitor.Size = New System.Drawing.Size(75, 23)
        Me.btnMonitor.TabIndex = 156
        Me.btnMonitor.Text = "Monitor Start"
        Me.btnMonitor.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 119)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 155
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(12, 90)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 154
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(385, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 31)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "Cylindrical 6"
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
        Me.SevenSegmentArray4.Location = New System.Drawing.Point(478, 193)
        Me.SevenSegmentArray4.Name = "SevenSegmentArray4"
        Me.SevenSegmentArray4.Size = New System.Drawing.Size(178, 71)
        Me.SevenSegmentArray4.TabIndex = 152
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
        Me.SevenSegmentArray3.Location = New System.Drawing.Point(478, 119)
        Me.SevenSegmentArray3.Name = "SevenSegmentArray3"
        Me.SevenSegmentArray3.Size = New System.Drawing.Size(178, 71)
        Me.SevenSegmentArray3.TabIndex = 151
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
        Me.SevenSegmentArray2.Location = New System.Drawing.Point(294, 193)
        Me.SevenSegmentArray2.Name = "SevenSegmentArray2"
        Me.SevenSegmentArray2.Size = New System.Drawing.Size(178, 71)
        Me.SevenSegmentArray2.TabIndex = 150
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
        Me.SevenSegmentArray1.Location = New System.Drawing.Point(294, 119)
        Me.SevenSegmentArray1.Name = "SevenSegmentArray1"
        Me.SevenSegmentArray1.Size = New System.Drawing.Size(178, 71)
        Me.SevenSegmentArray1.TabIndex = 149
        Me.SevenSegmentArray1.TabStop = False
        Me.SevenSegmentArray1.Value = Nothing
        '
        'tmrMonitor
        '
        '
        'SevenSegmentArray6
        '
        Me.SevenSegmentArray6.ArrayCount = 4
        Me.SevenSegmentArray6.ColorBackground = System.Drawing.Color.Black
        Me.SevenSegmentArray6.ColorDark = System.Drawing.Color.Black
        Me.SevenSegmentArray6.ColorLight = System.Drawing.Color.Red
        Me.SevenSegmentArray6.DecimalShow = True
        Me.SevenSegmentArray6.ElementPadding = New System.Windows.Forms.Padding(4)
        Me.SevenSegmentArray6.ElementWidth = 10
        Me.SevenSegmentArray6.ItalicFactor = 0!
        Me.SevenSegmentArray6.Location = New System.Drawing.Point(294, 368)
        Me.SevenSegmentArray6.Name = "SevenSegmentArray6"
        Me.SevenSegmentArray6.Size = New System.Drawing.Size(178, 71)
        Me.SevenSegmentArray6.TabIndex = 170
        Me.SevenSegmentArray6.TabStop = False
        Me.SevenSegmentArray6.Value = Nothing
        '
        'SevenSegmentArray7
        '
        Me.SevenSegmentArray7.ArrayCount = 4
        Me.SevenSegmentArray7.ColorBackground = System.Drawing.Color.Black
        Me.SevenSegmentArray7.ColorDark = System.Drawing.Color.Black
        Me.SevenSegmentArray7.ColorLight = System.Drawing.Color.Red
        Me.SevenSegmentArray7.DecimalShow = True
        Me.SevenSegmentArray7.ElementPadding = New System.Windows.Forms.Padding(4)
        Me.SevenSegmentArray7.ElementWidth = 10
        Me.SevenSegmentArray7.ItalicFactor = 0!
        Me.SevenSegmentArray7.Location = New System.Drawing.Point(294, 442)
        Me.SevenSegmentArray7.Name = "SevenSegmentArray7"
        Me.SevenSegmentArray7.Size = New System.Drawing.Size(178, 71)
        Me.SevenSegmentArray7.TabIndex = 169
        Me.SevenSegmentArray7.TabStop = False
        Me.SevenSegmentArray7.Value = Nothing
        '
        'SevenSegmentArray8
        '
        Me.SevenSegmentArray8.ArrayCount = 4
        Me.SevenSegmentArray8.ColorBackground = System.Drawing.Color.Black
        Me.SevenSegmentArray8.ColorDark = System.Drawing.Color.Black
        Me.SevenSegmentArray8.ColorLight = System.Drawing.Color.Red
        Me.SevenSegmentArray8.DecimalShow = True
        Me.SevenSegmentArray8.ElementPadding = New System.Windows.Forms.Padding(4)
        Me.SevenSegmentArray8.ElementWidth = 10
        Me.SevenSegmentArray8.ItalicFactor = 0!
        Me.SevenSegmentArray8.Location = New System.Drawing.Point(478, 368)
        Me.SevenSegmentArray8.Name = "SevenSegmentArray8"
        Me.SevenSegmentArray8.Size = New System.Drawing.Size(178, 71)
        Me.SevenSegmentArray8.TabIndex = 168
        Me.SevenSegmentArray8.TabStop = False
        Me.SevenSegmentArray8.Value = Nothing
        '
        'SevenSegmentArray9
        '
        Me.SevenSegmentArray9.ArrayCount = 4
        Me.SevenSegmentArray9.ColorBackground = System.Drawing.Color.Black
        Me.SevenSegmentArray9.ColorDark = System.Drawing.Color.Black
        Me.SevenSegmentArray9.ColorLight = System.Drawing.Color.Red
        Me.SevenSegmentArray9.DecimalShow = True
        Me.SevenSegmentArray9.ElementPadding = New System.Windows.Forms.Padding(4)
        Me.SevenSegmentArray9.ElementWidth = 10
        Me.SevenSegmentArray9.ItalicFactor = 0!
        Me.SevenSegmentArray9.Location = New System.Drawing.Point(478, 442)
        Me.SevenSegmentArray9.Name = "SevenSegmentArray9"
        Me.SevenSegmentArray9.Size = New System.Drawing.Size(178, 71)
        Me.SevenSegmentArray9.TabIndex = 167
        Me.SevenSegmentArray9.TabStop = False
        Me.SevenSegmentArray9.Value = Nothing
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(387, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(173, 31)
        Me.Label8.TabIndex = 171
        Me.Label8.Text = "Inspection 1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(387, 301)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(173, 31)
        Me.Label9.TabIndex = 172
        Me.Label9.Text = "Inspection 2"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(209, 467)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 24)
        Me.Label10.TabIndex = 174
        Me.Label10.Text = "Current"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(209, 392)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 24)
        Me.Label11.TabIndex = 173
        Me.Label11.Text = "Voltage"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(328, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 31)
        Me.Label2.TabIndex = 162
        Me.Label2.Text = "Upper"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(524, 332)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 31)
        Me.Label12.TabIndex = 176
        Me.Label12.Text = "Lower"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(339, 332)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 31)
        Me.Label13.TabIndex = 175
        Me.Label13.Text = "Upper"
        '
        'Cyl6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 546)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.SevenSegmentArray6)
        Me.Controls.Add(Me.SevenSegmentArray7)
        Me.Controls.Add(Me.SevenSegmentArray8)
        Me.Controls.Add(Me.SevenSegmentArray9)
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
        Me.Name = "Cyl6"
        Me.Text = "Cyl6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SevenSegmentArray5 As DmitryBrant.CustomControls.SevenSegmentArray
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLogical As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMonitor As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnOpen As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SevenSegmentArray4 As DmitryBrant.CustomControls.SevenSegmentArray
    Friend WithEvents SevenSegmentArray3 As DmitryBrant.CustomControls.SevenSegmentArray
    Friend WithEvents SevenSegmentArray2 As DmitryBrant.CustomControls.SevenSegmentArray
    Friend WithEvents SevenSegmentArray1 As DmitryBrant.CustomControls.SevenSegmentArray
    Friend WithEvents tmrMonitor As Timer
    Friend WithEvents SevenSegmentArray6 As DmitryBrant.CustomControls.SevenSegmentArray
    Friend WithEvents SevenSegmentArray7 As DmitryBrant.CustomControls.SevenSegmentArray
    Friend WithEvents SevenSegmentArray8 As DmitryBrant.CustomControls.SevenSegmentArray
    Friend WithEvents SevenSegmentArray9 As DmitryBrant.CustomControls.SevenSegmentArray
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
