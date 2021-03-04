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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMonitor = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtVolt11 = New System.Windows.Forms.TextBox()
        Me.txtCurr11 = New System.Windows.Forms.TextBox()
        Me.txtCurr12 = New System.Windows.Forms.TextBox()
        Me.txtVolt12 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLogical = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtVolt22 = New System.Windows.Forms.TextBox()
        Me.txtCurr22 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtVolt21 = New System.Windows.Forms.TextBox()
        Me.txtCurr21 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCurrent21 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnListBox = New System.Windows.Forms.Button()
        Me.btnGridView = New System.Windows.Forms.Button()
        Me.btnChart = New System.Windows.Forms.Button()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.SevenSegmentArray1 = New DmitryBrant.CustomControls.SevenSegmentArray()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SevenSegmentArray2 = New DmitryBrant.CustomControls.SevenSegmentArray()
        Me.SevenSegmentArray3 = New DmitryBrant.CustomControls.SevenSegmentArray()
        Me.SevenSegmentArray4 = New DmitryBrant.CustomControls.SevenSegmentArray()
        Me.SevenSegmentArray5 = New DmitryBrant.CustomControls.SevenSegmentArray()
        Me.SevenSegmentArray6 = New DmitryBrant.CustomControls.SevenSegmentArray()
        Me.SevenSegmentArray7 = New DmitryBrant.CustomControls.SevenSegmentArray()
        Me.SevenSegmentArray8 = New DmitryBrant.CustomControls.SevenSegmentArray()
        Me.SevenSegmentArray9 = New DmitryBrant.CustomControls.SevenSegmentArray()
        Me.btnCyl1 = New System.Windows.Forms.Button()
        Me.btnCyl2 = New System.Windows.Forms.Button()
        Me.btnCyl3 = New System.Windows.Forms.Button()
        Me.btnCyl4 = New System.Windows.Forms.Button()
        Me.btnCyl8 = New System.Windows.Forms.Button()
        Me.btnCyl7 = New System.Windows.Forms.Button()
        Me.btnCyl6 = New System.Windows.Forms.Button()
        Me.btnCyl5 = New System.Windows.Forms.Button()
        Me.btnCylAll = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(12, 85)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 114)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnMonitor
        '
        Me.btnMonitor.Location = New System.Drawing.Point(12, 143)
        Me.btnMonitor.Name = "btnMonitor"
        Me.btnMonitor.Size = New System.Drawing.Size(75, 23)
        Me.btnMonitor.TabIndex = 2
        Me.btnMonitor.Text = "Monitor Start"
        Me.btnMonitor.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 172)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtVolt11
        '
        Me.txtVolt11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolt11.Location = New System.Drawing.Point(58, 19)
        Me.txtVolt11.Name = "txtVolt11"
        Me.txtVolt11.ReadOnly = True
        Me.txtVolt11.Size = New System.Drawing.Size(100, 29)
        Me.txtVolt11.TabIndex = 4
        Me.txtVolt11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCurr11
        '
        Me.txtCurr11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurr11.Location = New System.Drawing.Point(58, 51)
        Me.txtCurr11.Name = "txtCurr11"
        Me.txtCurr11.ReadOnly = True
        Me.txtCurr11.Size = New System.Drawing.Size(100, 29)
        Me.txtCurr11.TabIndex = 5
        Me.txtCurr11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCurr12
        '
        Me.txtCurr12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurr12.Location = New System.Drawing.Point(58, 50)
        Me.txtCurr12.Name = "txtCurr12"
        Me.txtCurr12.ReadOnly = True
        Me.txtCurr12.Size = New System.Drawing.Size(100, 29)
        Me.txtCurr12.TabIndex = 6
        Me.txtCurr12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVolt12
        '
        Me.txtVolt12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolt12.Location = New System.Drawing.Point(58, 19)
        Me.txtVolt12.Name = "txtVolt12"
        Me.txtVolt12.ReadOnly = True
        Me.txtVolt12.Size = New System.Drawing.Size(100, 29)
        Me.txtVolt12.TabIndex = 7
        Me.txtVolt12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(5, 30)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(43, 13)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Voltage"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Current"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Current"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Voltage"
        '
        'txtLogical
        '
        Me.txtLogical.Location = New System.Drawing.Point(12, 221)
        Me.txtLogical.Name = "txtLogical"
        Me.txtLogical.Size = New System.Drawing.Size(72, 20)
        Me.txtLogical.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Logical Station"
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(99, 287)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(342, 20)
        Me.txtMessage.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(97, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Message"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(165, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(214, 25)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Cylindrical 3 X-Ray"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(140, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 20)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Inpection 1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(311, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 20)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Inpection 2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtVolt11)
        Me.GroupBox1.Controls.Add(Me.txtCurr11)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(99, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(168, 91)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Upper"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtVolt12)
        Me.GroupBox2.Controls.Add(Me.txtCurr12)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(99, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 91)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lower"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtVolt22)
        Me.GroupBox3.Controls.Add(Me.txtCurr22)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(273, 178)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(168, 91)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lower"
        '
        'txtVolt22
        '
        Me.txtVolt22.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolt22.Location = New System.Drawing.Point(58, 19)
        Me.txtVolt22.Name = "txtVolt22"
        Me.txtVolt22.ReadOnly = True
        Me.txtVolt22.Size = New System.Drawing.Size(100, 29)
        Me.txtVolt22.TabIndex = 7
        Me.txtVolt22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCurr22
        '
        Me.txtCurr22.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurr22.Location = New System.Drawing.Point(58, 50)
        Me.txtCurr22.Name = "txtCurr22"
        Me.txtCurr22.ReadOnly = True
        Me.txtCurr22.Size = New System.Drawing.Size(100, 29)
        Me.txtCurr22.TabIndex = 6
        Me.txtCurr22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Current"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Voltage"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtVolt21)
        Me.GroupBox4.Controls.Add(Me.txtCurr21)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txtCurrent21)
        Me.GroupBox4.Location = New System.Drawing.Point(273, 81)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(168, 91)
        Me.GroupBox4.TabIndex = 29
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Upper"
        '
        'txtVolt21
        '
        Me.txtVolt21.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVolt21.Location = New System.Drawing.Point(58, 19)
        Me.txtVolt21.Name = "txtVolt21"
        Me.txtVolt21.ReadOnly = True
        Me.txtVolt21.Size = New System.Drawing.Size(100, 29)
        Me.txtVolt21.TabIndex = 4
        Me.txtVolt21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCurr21
        '
        Me.txtCurr21.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurr21.Location = New System.Drawing.Point(58, 51)
        Me.txtCurr21.Name = "txtCurr21"
        Me.txtCurr21.ReadOnly = True
        Me.txtCurr21.Size = New System.Drawing.Size(100, 29)
        Me.txtCurr21.TabIndex = 5
        Me.txtCurr21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Voltage"
        '
        'txtCurrent21
        '
        Me.txtCurrent21.AutoSize = True
        Me.txtCurrent21.Location = New System.Drawing.Point(10, 62)
        Me.txtCurrent21.Name = "txtCurrent21"
        Me.txtCurrent21.Size = New System.Drawing.Size(41, 13)
        Me.txtCurrent21.TabIndex = 9
        Me.txtCurrent21.Text = "Current"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.DarkGray
        Me.Label9.Location = New System.Drawing.Point(9, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 26)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Developer:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fakhruddin"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'btnListBox
        '
        Me.btnListBox.Location = New System.Drawing.Point(447, 85)
        Me.btnListBox.Name = "btnListBox"
        Me.btnListBox.Size = New System.Drawing.Size(75, 23)
        Me.btnListBox.TabIndex = 37
        Me.btnListBox.Text = "ListBox"
        Me.btnListBox.UseVisualStyleBackColor = True
        '
        'btnGridView
        '
        Me.btnGridView.Location = New System.Drawing.Point(447, 114)
        Me.btnGridView.Name = "btnGridView"
        Me.btnGridView.Size = New System.Drawing.Size(75, 23)
        Me.btnGridView.TabIndex = 38
        Me.btnGridView.Text = "GridView"
        Me.btnGridView.UseVisualStyleBackColor = True
        '
        'btnChart
        '
        Me.btnChart.Location = New System.Drawing.Point(447, 143)
        Me.btnChart.Name = "btnChart"
        Me.btnChart.Size = New System.Drawing.Size(75, 23)
        Me.btnChart.TabIndex = 39
        Me.btnChart.Text = "Chart"
        Me.btnChart.UseVisualStyleBackColor = True
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PLC_PC_Datamonitoring_with_ACT.My.Resources.Resources.red
        Me.PictureBox1.Location = New System.Drawing.Point(502, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(447, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 43)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Restart"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(447, 221)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 41)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Cancel Shutdown"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(12, 9)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(40, 13)
        Me.lblTime.TabIndex = 43
        Me.lblTime.Text = "lblTime"
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
        Me.SevenSegmentArray1.Location = New System.Drawing.Point(544, 81)
        Me.SevenSegmentArray1.Name = "SevenSegmentArray1"
        Me.SevenSegmentArray1.Size = New System.Drawing.Size(178, 71)
        Me.SevenSegmentArray1.TabIndex = 44
        Me.SevenSegmentArray1.TabStop = False
        Me.SevenSegmentArray1.Value = Nothing
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(485, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "MONITOR"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(457, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(22, 13)
        Me.Label15.TabIndex = 47
        Me.Label15.Text = "DB"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PLC_PC_Datamonitoring_with_ACT.My.Resources.Resources.red
        Me.PictureBox2.Location = New System.Drawing.Point(463, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 46
        Me.PictureBox2.TabStop = False
        '
        'SevenSegmentArray2
        '
        Me.SevenSegmentArray2.ArrayCount = 4
        Me.SevenSegmentArray2.ColorBackground = System.Drawing.Color.Black
        Me.SevenSegmentArray2.ColorDark = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SevenSegmentArray2.ColorLight = System.Drawing.Color.Red
        Me.SevenSegmentArray2.DecimalShow = True
        Me.SevenSegmentArray2.ElementPadding = New System.Windows.Forms.Padding(4)
        Me.SevenSegmentArray2.ElementWidth = 10
        Me.SevenSegmentArray2.ItalicFactor = 0!
        Me.SevenSegmentArray2.Location = New System.Drawing.Point(12, 35)
        Me.SevenSegmentArray2.Name = "SevenSegmentArray2"
        Me.SevenSegmentArray2.Size = New System.Drawing.Size(61, 26)
        Me.SevenSegmentArray2.TabIndex = 48
        Me.SevenSegmentArray2.TabStop = False
        Me.SevenSegmentArray2.Value = Nothing
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
        Me.SevenSegmentArray3.Location = New System.Drawing.Point(544, 155)
        Me.SevenSegmentArray3.Name = "SevenSegmentArray3"
        Me.SevenSegmentArray3.Size = New System.Drawing.Size(178, 71)
        Me.SevenSegmentArray3.TabIndex = 49
        Me.SevenSegmentArray3.TabStop = False
        Me.SevenSegmentArray3.Value = Nothing
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
        Me.SevenSegmentArray4.Location = New System.Drawing.Point(544, 228)
        Me.SevenSegmentArray4.Name = "SevenSegmentArray4"
        Me.SevenSegmentArray4.Size = New System.Drawing.Size(178, 71)
        Me.SevenSegmentArray4.TabIndex = 50
        Me.SevenSegmentArray4.TabStop = False
        Me.SevenSegmentArray4.Value = Nothing
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
        Me.SevenSegmentArray5.Location = New System.Drawing.Point(544, 302)
        Me.SevenSegmentArray5.Name = "SevenSegmentArray5"
        Me.SevenSegmentArray5.Size = New System.Drawing.Size(178, 71)
        Me.SevenSegmentArray5.TabIndex = 51
        Me.SevenSegmentArray5.TabStop = False
        Me.SevenSegmentArray5.Value = Nothing
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
        Me.SevenSegmentArray6.Location = New System.Drawing.Point(728, 81)
        Me.SevenSegmentArray6.Name = "SevenSegmentArray6"
        Me.SevenSegmentArray6.Size = New System.Drawing.Size(178, 71)
        Me.SevenSegmentArray6.TabIndex = 52
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
        Me.SevenSegmentArray7.Location = New System.Drawing.Point(728, 155)
        Me.SevenSegmentArray7.Name = "SevenSegmentArray7"
        Me.SevenSegmentArray7.Size = New System.Drawing.Size(178, 71)
        Me.SevenSegmentArray7.TabIndex = 53
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
        Me.SevenSegmentArray8.Location = New System.Drawing.Point(728, 228)
        Me.SevenSegmentArray8.Name = "SevenSegmentArray8"
        Me.SevenSegmentArray8.Size = New System.Drawing.Size(178, 71)
        Me.SevenSegmentArray8.TabIndex = 54
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
        Me.SevenSegmentArray9.Location = New System.Drawing.Point(728, 302)
        Me.SevenSegmentArray9.Name = "SevenSegmentArray9"
        Me.SevenSegmentArray9.Size = New System.Drawing.Size(178, 71)
        Me.SevenSegmentArray9.TabIndex = 55
        Me.SevenSegmentArray9.TabStop = False
        Me.SevenSegmentArray9.Value = Nothing
        '
        'btnCyl1
        '
        Me.btnCyl1.Location = New System.Drawing.Point(31, 355)
        Me.btnCyl1.Name = "btnCyl1"
        Me.btnCyl1.Size = New System.Drawing.Size(75, 40)
        Me.btnCyl1.TabIndex = 56
        Me.btnCyl1.Text = "Cyl1"
        Me.btnCyl1.UseVisualStyleBackColor = True
        '
        'btnCyl2
        '
        Me.btnCyl2.Location = New System.Drawing.Point(112, 355)
        Me.btnCyl2.Name = "btnCyl2"
        Me.btnCyl2.Size = New System.Drawing.Size(75, 40)
        Me.btnCyl2.TabIndex = 57
        Me.btnCyl2.Text = "Cyl2"
        Me.btnCyl2.UseVisualStyleBackColor = True
        '
        'btnCyl3
        '
        Me.btnCyl3.Location = New System.Drawing.Point(193, 355)
        Me.btnCyl3.Name = "btnCyl3"
        Me.btnCyl3.Size = New System.Drawing.Size(75, 40)
        Me.btnCyl3.TabIndex = 58
        Me.btnCyl3.Text = "Cyl3"
        Me.btnCyl3.UseVisualStyleBackColor = True
        '
        'btnCyl4
        '
        Me.btnCyl4.Location = New System.Drawing.Point(274, 355)
        Me.btnCyl4.Name = "btnCyl4"
        Me.btnCyl4.Size = New System.Drawing.Size(75, 40)
        Me.btnCyl4.TabIndex = 59
        Me.btnCyl4.Text = "Cyl4"
        Me.btnCyl4.UseVisualStyleBackColor = True
        '
        'btnCyl8
        '
        Me.btnCyl8.Location = New System.Drawing.Point(274, 401)
        Me.btnCyl8.Name = "btnCyl8"
        Me.btnCyl8.Size = New System.Drawing.Size(75, 40)
        Me.btnCyl8.TabIndex = 63
        Me.btnCyl8.Text = "Cyl8"
        Me.btnCyl8.UseVisualStyleBackColor = True
        '
        'btnCyl7
        '
        Me.btnCyl7.Location = New System.Drawing.Point(193, 401)
        Me.btnCyl7.Name = "btnCyl7"
        Me.btnCyl7.Size = New System.Drawing.Size(75, 40)
        Me.btnCyl7.TabIndex = 62
        Me.btnCyl7.Text = "Cyl7"
        Me.btnCyl7.UseVisualStyleBackColor = True
        '
        'btnCyl6
        '
        Me.btnCyl6.Location = New System.Drawing.Point(112, 401)
        Me.btnCyl6.Name = "btnCyl6"
        Me.btnCyl6.Size = New System.Drawing.Size(75, 40)
        Me.btnCyl6.TabIndex = 61
        Me.btnCyl6.Text = "Cyl6"
        Me.btnCyl6.UseVisualStyleBackColor = True
        '
        'btnCyl5
        '
        Me.btnCyl5.Location = New System.Drawing.Point(31, 401)
        Me.btnCyl5.Name = "btnCyl5"
        Me.btnCyl5.Size = New System.Drawing.Size(75, 40)
        Me.btnCyl5.TabIndex = 60
        Me.btnCyl5.Text = "Cyl5"
        Me.btnCyl5.UseVisualStyleBackColor = True
        '
        'btnCylAll
        '
        Me.btnCylAll.Location = New System.Drawing.Point(355, 401)
        Me.btnCylAll.Name = "btnCylAll"
        Me.btnCylAll.Size = New System.Drawing.Size(75, 40)
        Me.btnCylAll.TabIndex = 64
        Me.btnCylAll.Text = "Cyl All"
        Me.btnCylAll.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 469)
        Me.Controls.Add(Me.btnCylAll)
        Me.Controls.Add(Me.btnCyl8)
        Me.Controls.Add(Me.btnCyl7)
        Me.Controls.Add(Me.btnCyl6)
        Me.Controls.Add(Me.btnCyl5)
        Me.Controls.Add(Me.btnCyl4)
        Me.Controls.Add(Me.btnCyl3)
        Me.Controls.Add(Me.btnCyl2)
        Me.Controls.Add(Me.btnCyl1)
        Me.Controls.Add(Me.SevenSegmentArray9)
        Me.Controls.Add(Me.SevenSegmentArray8)
        Me.Controls.Add(Me.SevenSegmentArray7)
        Me.Controls.Add(Me.SevenSegmentArray6)
        Me.Controls.Add(Me.SevenSegmentArray5)
        Me.Controls.Add(Me.SevenSegmentArray4)
        Me.Controls.Add(Me.SevenSegmentArray3)
        Me.Controls.Add(Me.SevenSegmentArray2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.SevenSegmentArray1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnChart)
        Me.Controls.Add(Me.btnGridView)
        Me.Controls.Add(Me.btnListBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLogical)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMonitor)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnOpen)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "X-Ray Data Monitoring"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOpen As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnMonitor As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtVolt11 As TextBox
    Friend WithEvents txtCurr11 As TextBox
    Friend WithEvents txtCurr12 As TextBox
    Friend WithEvents txtVolt12 As TextBox
    Friend WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLogical As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtVolt22 As TextBox
    Friend WithEvents txtCurr22 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtVolt21 As TextBox
    Friend WithEvents txtCurr21 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCurrent21 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents btnListBox As Button
    Friend WithEvents btnGridView As Button
    Friend WithEvents btnChart As Button
    Friend WithEvents Timer3 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents SevenSegmentArray1 As DmitryBrant.CustomControls.SevenSegmentArray
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SevenSegmentArray2 As DmitryBrant.CustomControls.SevenSegmentArray
    Friend WithEvents SevenSegmentArray3 As DmitryBrant.CustomControls.SevenSegmentArray
    Friend WithEvents SevenSegmentArray4 As DmitryBrant.CustomControls.SevenSegmentArray
    Friend WithEvents SevenSegmentArray5 As DmitryBrant.CustomControls.SevenSegmentArray
    Friend WithEvents SevenSegmentArray6 As DmitryBrant.CustomControls.SevenSegmentArray
    Friend WithEvents SevenSegmentArray7 As DmitryBrant.CustomControls.SevenSegmentArray
    Friend WithEvents SevenSegmentArray8 As DmitryBrant.CustomControls.SevenSegmentArray
    Friend WithEvents SevenSegmentArray9 As DmitryBrant.CustomControls.SevenSegmentArray
    Friend WithEvents btnCyl1 As Button
    Friend WithEvents btnCyl2 As Button
    Friend WithEvents btnCyl3 As Button
    Friend WithEvents btnCyl4 As Button
    Friend WithEvents btnCyl8 As Button
    Friend WithEvents btnCyl7 As Button
    Friend WithEvents btnCyl6 As Button
    Friend WithEvents btnCyl5 As Button
    Friend WithEvents btnCylAll As Button
End Class
