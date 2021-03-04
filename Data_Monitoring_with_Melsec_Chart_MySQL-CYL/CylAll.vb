Imports System.Drawing.Text
Imports System.Threading
Imports DmitryBrant.CustomControls
Imports MySql.Data.MySqlClient

Public Class CylAll
    Private ActUtl(8) As ActUtlTypeLib.ActUtlTypeClass
    Dim conn As New MySqlConnection

    Private Sub CylAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActUtl(1) = New ActUtlTypeLib.ActUtlTypeClass()
        ActUtl(2) = New ActUtlTypeLib.ActUtlTypeClass()
        ActUtl(3) = New ActUtlTypeLib.ActUtlTypeClass()
        ActUtl(4) = New ActUtlTypeLib.ActUtlTypeClass()
        ActUtl(5) = New ActUtlTypeLib.ActUtlTypeClass()
        ActUtl(6) = New ActUtlTypeLib.ActUtlTypeClass()
        ActUtl(7) = New ActUtlTypeLib.ActUtlTypeClass()
        ActUtl(8) = New ActUtlTypeLib.ActUtlTypeClass()

    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click

        OpenPort(1, 1, 1)
        OpenPort(2, 2, 2)
        OpenPort(3, 3, 3)
        OpenPort(4, 4, 4)
        OpenPort(5, 5, 5)
        OpenPort(6, 6, 6)
        OpenPort(7, 7, 7)
        OpenPort(8, 8, 8)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ClosePort(1, 1)
        ClosePort(2, 2)
        ClosePort(3, 3)
        ClosePort(4, 4)
        ClosePort(5, 5)
        ClosePort(6, 6)
        ClosePort(7, 7)
        ClosePort(8, 8)
    End Sub

    Private Sub btnMonitor_Click(sender As Object, e As EventArgs) Handles btnMonitor.Click
        'Try
        '    Connect()
        'Catch ex As Exception
        '    MessageBox.Show("Database connection Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

        If tmrMonitor.Enabled = False Then
            tmrMonitor.Enabled = True
            btnMonitor.Text = "Monitor Stop"
            btnClose.Enabled = False
        ElseIf tmrMonitor.Enabled = True Then
            tmrMonitor.Enabled = False
            btnMonitor.Text = "Monitor Start"
            btnClose.Enabled = True
            ClearDisplay()
        End If
    End Sub

    Private Sub tmrMonitor_Tick(sender As Object, e As EventArgs) Handles tmrMonitor.Tick
        Monitor1(1, 1)
        Monitor2(2, 2)
        Monitor3(3, 3)
        Monitor4(4, 4)
        Monitor5(5, 5)
        Monitor6(6, 6)
        Monitor7(7, 7)
        Monitor8(8, 8)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private SevenSegmentArray(8) As SevenSegmentArray
    Private Sub ClearDisplay()
        'Dim SevenSegmentArray(8) As SevenSegmentArray
        'SevenSegmentArray(1) = New SevenSegmentArray()

        'SevenSegmentArray(1).Value = 0

        SevenSegmentArray1.Value = 0
        SevenSegmentArray2.Value = 0
        SevenSegmentArray3.Value = 0
        SevenSegmentArray4.Value = 0
        SevenSegmentArray5.Value = 0
        SevenSegmentArray6.Value = 0
        SevenSegmentArray7.Value = 0
        SevenSegmentArray8.Value = 0
        SevenSegmentArray9.Value = 0
        SevenSegmentArray10.Value = 0
        SevenSegmentArray11.Value = 0
        SevenSegmentArray12.Value = 0
        SevenSegmentArray13.Value = 0
        SevenSegmentArray14.Value = 0
        SevenSegmentArray15.Value = 0
        SevenSegmentArray16.Value = 0
        SevenSegmentArray17.Value = 0
        SevenSegmentArray18.Value = 0
        SevenSegmentArray19.Value = 0
        SevenSegmentArray20.Value = 0
        SevenSegmentArray21.Value = 0
        SevenSegmentArray22.Value = 0
        SevenSegmentArray23.Value = 0
        SevenSegmentArray24.Value = 0
        SevenSegmentArray25.Value = 0
        SevenSegmentArray26.Value = 0
        SevenSegmentArray27.Value = 0




    End Sub

    Private Sub OpenPort(ByVal LogicalNumber As Integer, ByVal Control As Integer, ByVal iReturn As Integer)
        Dim lRet(8) As Long

        Try
            ActUtl(Control).ActLogicalStationNumber = LogicalNumber

            lRet(iReturn) = ActUtl(Control).Open()

            If lRet(iReturn) = 0 Then
                txtMessage.Text = String.Format("Communication open: 0x{0:x8}", lRet)
                txtMessage.ForeColor = Color.Green
            Else
                txtMessage.Text = String.Format("Communication Error: 0x{0:x8}", lRet)
                txtMessage.ForeColor = Color.Red
            End If

            btnOpen.Enabled = False
            btnClose.Enabled = True
            btnMonitor.Enabled = True
            btnExit.Enabled = False

        Catch ex As Exception
            MessageBox.Show("Please input logical station", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Connect()
    End Sub

    Private Sub ClosePort(ByVal Control As Integer, ByVal iReturn As Integer)
        Dim lRet(8) As Long

        lRet(iReturn) = ActUtl(Control).Close()

        If lRet(iReturn) = 0 Then
            txtMessage.Text = String.Format("Communication Close: 0x{0:x8}", lRet(iReturn))
            txtMessage.ForeColor = Color.Green
        Else
            txtMessage.Text = String.Format("Communication Error: 0x{0:x8}", lRet(iReturn))
            txtMessage.ForeColor = Color.Red
        End If

        btnOpen.Enabled = True
        btnClose.Enabled = False
        btnMonitor.Enabled = False
        btnExit.Enabled = True
    End Sub

    Private Sub Monitor1(ByVal Control As Integer, ByVal iReturn As Integer)
        Dim lRet(8) As Long
        Dim lData(10)

        lRet(iReturn) = ActUtl(Control).GetDevice("D1400", lData(0)) 'Voltage Upper
        lRet(iReturn) = ActUtl(Control).GetDevice("D1401", lData(1)) 'Current Upper
        lRet(iReturn) = ActUtl(Control).GetDevice("D1405", lData(2)) 'Voltage Lower
        lRet(iReturn) = ActUtl(Control).GetDevice("D1406", lData(3)) 'Current Lower

        'lRet = ActUtl.GetDevice("D1305", lData(4)) 'Index speed

        SevenSegmentArray1.Value = lData(0)
        SevenSegmentArray3.Value = lData(1)
        SevenSegmentArray2.Value = lData(2)
        SevenSegmentArray4.Value = lData(3)

        'SevenSegmentArray5.Value = lData(4)

        If lRet(iReturn) <> 0 Then
            txtMessage.Text = String.Format("Error: 0x{0:x8}", lRet(iReturn))
        End If

        updateDB_1()
    End Sub

    Private Sub Monitor2(ByVal Control As Integer, ByVal iReturn As Integer)
        Dim lRet(8) As Long
        Dim lData(10)

        lRet(iReturn) = ActUtl(Control).GetDevice("D1400", lData(0)) 'Voltage Upper
        lRet(iReturn) = ActUtl(Control).GetDevice("D1401", lData(1)) 'Current Upper
        lRet(iReturn) = ActUtl(Control).GetDevice("D1405", lData(2)) 'Voltage Lower
        lRet(iReturn) = ActUtl(Control).GetDevice("D1406", lData(3)) 'Current Lower

        'lRet = ActUtl.GetDevice("D1305", lData(4)) 'Index speed

        SevenSegmentArray5.Value = lData(0)
        SevenSegmentArray6.Value = lData(1)
        SevenSegmentArray7.Value = lData(2)
        SevenSegmentArray8.Value = lData(3)

        'SevenSegmentArray5.Value = lData(4)

        If lRet(iReturn) <> 0 Then
            txtMessage.Text = String.Format("Error: 0x{0:x8}", lRet(iReturn))
        End If

        updateDB_2()

    End Sub

    Private Sub Monitor3(ByVal Control As Integer, ByVal iReturn As Integer)
        Dim lRet(8) As Long
        Dim lData(10)

        lRet(iReturn) = ActUtl(Control).GetDevice("D1430", lData(0)) 'Voltage Upper
        lRet(iReturn) = ActUtl(Control).GetDevice("D1431", lData(1)) 'Current Upper
        lRet(iReturn) = ActUtl(Control).GetDevice("D1435", lData(2)) 'Voltage Lower
        lRet(iReturn) = ActUtl(Control).GetDevice("D1436", lData(3)) 'Current Lower

        'lRet = ActUtl.GetDevice("D1305", lData(4)) 'Index speed

        SevenSegmentArray9.Value = lData(0)
        SevenSegmentArray10.Value = lData(1)
        SevenSegmentArray11.Value = lData(2)
        SevenSegmentArray12.Value = lData(3)

        'SevenSegmentArray5.Value = lData(4)

        If lRet(iReturn) <> 0 Then
            txtMessage.Text = String.Format("Error: 0x{0:x8}", lRet(iReturn))
        End If

        updateDB_3()

    End Sub

    Private Sub Monitor4(ByVal Control As Integer, ByVal iReturn As Integer)
        Dim lRet(8) As Long
        Dim lData(10)

        lRet(iReturn) = ActUtl(Control).GetDevice("D12610", lData(0)) 'Voltage Upper
        lRet(iReturn) = ActUtl(Control).GetDevice("D12611", lData(1)) 'Current Upper
        lRet(iReturn) = ActUtl(Control).GetDevice("D12612", lData(2)) 'Voltage Lower
        lRet(iReturn) = ActUtl(Control).GetDevice("D12613", lData(3)) 'Current Lower

        'lRet = ActUtl.GetDevice("D1305", lData(4)) 'Index speed

        SevenSegmentArray13.Value = lData(0)
        SevenSegmentArray14.Value = lData(1)
        SevenSegmentArray15.Value = lData(2)
        SevenSegmentArray16.Value = lData(3)

        'SevenSegmentArray5.Value = lData(4)

        If lRet(iReturn) <> 0 Then
            txtMessage.Text = String.Format("Error: 0x{0:x8}", lRet(iReturn))
        End If

        updateDB_4()

    End Sub

    Private Sub Monitor5(ByVal Control As Integer, ByVal iReturn As Integer)
        Dim lRet(8) As Long
        Dim lData(10)

        lRet(iReturn) = ActUtl(Control).GetDevice("D12610", lData(0)) 'Voltage Upper
        lRet(iReturn) = ActUtl(Control).GetDevice("D12611", lData(1)) 'Current Upper
        lRet(iReturn) = ActUtl(Control).GetDevice("D12612", lData(2)) 'Voltage Lower
        lRet(iReturn) = ActUtl(Control).GetDevice("D12613", lData(3)) 'Current Lower

        'lRet = ActUtl.GetDevice("D1305", lData(4)) 'Index speed

        SevenSegmentArray17.Value = lData(0)
        SevenSegmentArray18.Value = lData(1)
        SevenSegmentArray19.Value = lData(2)
        SevenSegmentArray20.Value = lData(3)

        'SevenSegmentArray5.Value = lData(4)

        If lRet(iReturn) <> 0 Then
            txtMessage.Text = String.Format("Error: 0x{0:x8}", lRet(iReturn))
        End If

        updateDB_5()

    End Sub

    Private Sub Monitor6(ByVal Control As Integer, ByVal iReturn As Integer)
        Dim lRet(8) As Long
        Dim lData(10)

        'Inspection 1
        lRet(iReturn) = ActUtl(Control).GetDevice("D1400", lData(0)) 'Voltage Upper
        lRet(iReturn) = ActUtl(Control).GetDevice("D1401", lData(1)) 'Current Upper
        lRet(iReturn) = ActUtl(Control).GetDevice("D1405", lData(2)) 'Voltage Lower
        lRet(iReturn) = ActUtl(Control).GetDevice("D1406", lData(3)) 'Current Lower

        'Inspection 2
        lRet(iReturn) = ActUtl(Control).GetDevice("D1430", lData(4)) 'Voltage Upper
        lRet(iReturn) = ActUtl(Control).GetDevice("D1431", lData(5)) 'Current Upper
        lRet(iReturn) = ActUtl(Control).GetDevice("D1435", lData(6)) 'Voltage Lower
        lRet(iReturn) = ActUtl(Control).GetDevice("D1436", lData(7)) 'Current Lower

        'lRet = ActUtl.GetDevice("D1305", lData(4)) 'Index speed

        SevenSegmentArray21.Value = lData(0)
        SevenSegmentArray22.Value = lData(1)
        SevenSegmentArray23.Value = lData(2)
        SevenSegmentArray24.Value = lData(3)

        SevenSegmentArray25.Value = lData(4)
        SevenSegmentArray26.Value = lData(5)
        SevenSegmentArray27.Value = lData(6)
        SevenSegmentArray28.Value = lData(7)

        'SevenSegmentArray5.Value = lData(4)

        If lRet(iReturn) <> 0 Then
            txtMessage.Text = String.Format("Error: 0x{0:x8}", lRet(iReturn))
        End If

        updateDB_6()

    End Sub

    Private Sub Monitor7(ByVal Control As Integer, ByVal iReturn As Integer)
        Dim lRet(8) As Long
        Dim lData(10)

        'Inspection 1
        lRet(iReturn) = ActUtl(Control).GetDevice("D1400", lData(0)) 'Voltage Upper
        lRet(iReturn) = ActUtl(Control).GetDevice("D1401", lData(1)) 'Current Upper
        lRet(iReturn) = ActUtl(Control).GetDevice("D1405", lData(2)) 'Voltage Lower
        lRet(iReturn) = ActUtl(Control).GetDevice("D1406", lData(3)) 'Current Lower

        'Inspection 2
        lRet(iReturn) = ActUtl(Control).GetDevice("D1430", lData(4)) 'Voltage Upper
        lRet(iReturn) = ActUtl(Control).GetDevice("D1431", lData(5)) 'Current Upper
        lRet(iReturn) = ActUtl(Control).GetDevice("D1435", lData(6)) 'Voltage Lower
        lRet(iReturn) = ActUtl(Control).GetDevice("D1436", lData(7)) 'Current Lower

        'lRet = ActUtl.GetDevice("D1305", lData(4)) 'Index speed

        SevenSegmentArray29.Value = lData(0)
        SevenSegmentArray30.Value = lData(1)
        SevenSegmentArray31.Value = lData(2)
        SevenSegmentArray32.Value = lData(3)

        SevenSegmentArray33.Value = lData(4)
        SevenSegmentArray34.Value = lData(5)
        SevenSegmentArray35.Value = lData(6)
        SevenSegmentArray36.Value = lData(7)

        'SevenSegmentArray5.Value = lData(4)

        If lRet(iReturn) <> 0 Then
            txtMessage.Text = String.Format("Error: 0x{0:x8}", lRet(iReturn))
        End If

        updateDB_7()

    End Sub

    Private Sub Monitor8(ByVal Control As Integer, ByVal iReturn As Integer)
        Dim lRet(8) As Long
        Dim lData(10)

        lRet(iReturn) = ActUtl(Control).GetDevice("D1430", lData(0)) 'Voltage Upper
        lRet(iReturn) = ActUtl(Control).GetDevice("D1431", lData(1)) 'Current Upper
        lRet(iReturn) = ActUtl(Control).GetDevice("D1435", lData(2)) 'Voltage Lower
        lRet(iReturn) = ActUtl(Control).GetDevice("D1436", lData(3)) 'Current Lower

        'lRet = ActUtl.GetDevice("D1305", lData(4)) 'Index speed

        SevenSegmentArray37.Value = lData(0)
        SevenSegmentArray38.Value = lData(1)
        SevenSegmentArray39.Value = lData(2)
        SevenSegmentArray40.Value = lData(3)

        'SevenSegmentArray5.Value = lData(4)

        If lRet(iReturn) <> 0 Then
            txtMessage.Text = String.Format("Error: 0x{0:x8}", lRet(iReturn))
        End If

        updateDB_8()

    End Sub

#Region "Connect to mysql database"
    'Don't forget to copy this function together with instances Dim conn As New MySqlConnection
    Public Sub Connect()
        Dim DatabaseName As String = "datamonitoring_db"
        Dim server As String = "localhost"
        Dim userName As String = "root"
        Dim password As String = ""
        If Not conn Is Nothing Then conn.Close()
        'conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        conn.ConnectionString = String.Format($"server={server}; user id={userName}; password={password}; database={DatabaseName}; pooling=false")
        Try
            conn.Open()
            'MsgBox("Connected")
            PictureBox2.Image = My.Resources.green

        Catch ex As Exception
            MsgBox(ex.Message)
            PictureBox2.Image = My.Resources.red
        End Try
        conn.Close()
    End Sub
#End Region

    Function execCommand(ByVal cmd As MySqlCommand) As Boolean

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Try
            If cmd.ExecuteNonQuery() = 1 Then
                Return True

            Else
                Return False
            End If
        Catch ex As Exception

            MessageBox.Show("ERROR")
            Return False

        End Try

        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

    End Function

    Public Sub updateDB_1()
        Dim insert_command As New MySqlCommand("INSERT INTO `cyl_1_table`(`Volt11`, `Curr11`, `Volt12`, `Curr12`) VALUES (@volt11,@curr11,@volt12,@curr12)", conn)
        insert_command.Parameters.Add("@volt11", MySqlDbType.Int16).Value = SevenSegmentArray1.Value
        insert_command.Parameters.Add("@curr11", MySqlDbType.Int16).Value = SevenSegmentArray2.Value
        insert_command.Parameters.Add("@volt12", MySqlDbType.Int16).Value = SevenSegmentArray3.Value
        insert_command.Parameters.Add("@curr12", MySqlDbType.Int16).Value = SevenSegmentArray4.Value

        If execCommand(insert_command) Then
            'MessageBox.Show("Data Inserted")

        Else
            MessageBox.Show("Data NOT Inserted")
        End If
    End Sub

    Public Sub updateDB_2()
        Dim insert_command As New MySqlCommand("INSERT INTO `cyl_2_table`(`Volt11`, `Curr11`, `Volt12`, `Curr12`) VALUES (@volt11,@curr11,@volt12,@curr12)", conn)
        insert_command.Parameters.Add("@volt11", MySqlDbType.Int16).Value = SevenSegmentArray5.Value
        insert_command.Parameters.Add("@curr11", MySqlDbType.Int16).Value = SevenSegmentArray6.Value
        insert_command.Parameters.Add("@volt12", MySqlDbType.Int16).Value = SevenSegmentArray7.Value
        insert_command.Parameters.Add("@curr12", MySqlDbType.Int16).Value = SevenSegmentArray8.Value

        If execCommand(insert_command) Then
            'MessageBox.Show("Data Inserted")

        Else
            MessageBox.Show("Data NOT Inserted")
        End If
    End Sub

    Public Sub updateDB_3()
        Dim insert_command As New MySqlCommand("INSERT INTO `cyl_3_table`(`Volt11`, `Curr11`, `Volt12`, `Curr12`) VALUES (@volt11,@curr11,@volt12,@curr12)", conn)
        insert_command.Parameters.Add("@volt11", MySqlDbType.Int16).Value = SevenSegmentArray9.Value
        insert_command.Parameters.Add("@curr11", MySqlDbType.Int16).Value = SevenSegmentArray10.Value
        insert_command.Parameters.Add("@volt12", MySqlDbType.Int16).Value = SevenSegmentArray11.Value
        insert_command.Parameters.Add("@curr12", MySqlDbType.Int16).Value = SevenSegmentArray12.Value

        If execCommand(insert_command) Then
            'MessageBox.Show("Data Inserted")

        Else
            MessageBox.Show("Data NOT Inserted")
        End If
    End Sub

    Public Sub updateDB_4()
        Dim insert_command As New MySqlCommand("INSERT INTO `cyl_4_table`(`volt11`, `curr11`, `volt12`, `curr12`) VALUES (@volt11,@curr11,@volt12,@curr12)", conn)
        insert_command.Parameters.Add("@volt11", MySqlDbType.Int16).Value = SevenSegmentArray13.Value
        insert_command.Parameters.Add("@curr11", MySqlDbType.Int16).Value = SevenSegmentArray14.Value
        insert_command.Parameters.Add("@volt12", MySqlDbType.Int16).Value = SevenSegmentArray15.Value
        insert_command.Parameters.Add("@curr12", MySqlDbType.Int16).Value = SevenSegmentArray16.Value

        If execCommand(insert_command) Then
            'MessageBox.Show("Data Inserted")

        Else
            MessageBox.Show("Data NOT Inserted")
        End If
    End Sub

    Public Sub updateDB_5()
        Dim insert_command As New MySqlCommand("INSERT INTO `cyl_5_table`(`Volt11`, `Curr11`, `Volt12`, `Curr12`) VALUES (@volt11,@curr11,@volt12,@curr12)", conn)
        insert_command.Parameters.Add("@volt11", MySqlDbType.Int16).Value = SevenSegmentArray17.Value
        insert_command.Parameters.Add("@curr11", MySqlDbType.Int16).Value = SevenSegmentArray18.Value
        insert_command.Parameters.Add("@volt12", MySqlDbType.Int16).Value = SevenSegmentArray19.Value
        insert_command.Parameters.Add("@curr12", MySqlDbType.Int16).Value = SevenSegmentArray20.Value

        If execCommand(insert_command) Then
            'MessageBox.Show("Data Inserted")

        Else
            MessageBox.Show("Data NOT Inserted")
        End If
    End Sub

    Public Sub updateDB_6()
        Dim insert_command As New MySqlCommand("INSERT INTO `cyl_6_table`(`Volt11`, `Curr11`, `Volt12`, `Curr12`, `Volt21`, `Curr21`, `Volt22`, `Curr22`) VALUES (@volt11,@curr11,@volt12,@curr12,@volt21,@curr21,@volt22,@curr22)", conn)
        insert_command.Parameters.Add("@volt11", MySqlDbType.Int16).Value = SevenSegmentArray21.Value
        insert_command.Parameters.Add("@curr11", MySqlDbType.Int16).Value = SevenSegmentArray22.Value
        insert_command.Parameters.Add("@volt12", MySqlDbType.Int16).Value = SevenSegmentArray23.Value
        insert_command.Parameters.Add("@curr12", MySqlDbType.Int16).Value = SevenSegmentArray24.Value

        insert_command.Parameters.Add("@volt21", MySqlDbType.Int16).Value = SevenSegmentArray25.Value
        insert_command.Parameters.Add("@curr21", MySqlDbType.Int16).Value = SevenSegmentArray26.Value
        insert_command.Parameters.Add("@volt22", MySqlDbType.Int16).Value = SevenSegmentArray27.Value
        insert_command.Parameters.Add("@curr22", MySqlDbType.Int16).Value = SevenSegmentArray28.Value

        If execCommand(insert_command) Then
            'MessageBox.Show("Data Inserted")

        Else
            MessageBox.Show("Data NOT Inserted")
        End If
    End Sub

    Public Sub updateDB_7()
        Dim insert_command As New MySqlCommand("INSERT INTO `cyl_7_table`(`Volt11`, `Curr11`, `Volt12`, `Curr12`, `Volt21`, `Curr21`, `Volt22`, `Curr22`) VALUES (@volt11,@curr11,@volt12,@curr12,@volt21,@curr21,@volt22,@curr22)", conn)
        insert_command.Parameters.Add("@volt11", MySqlDbType.Int16).Value = SevenSegmentArray29.Value
        insert_command.Parameters.Add("@curr11", MySqlDbType.Int16).Value = SevenSegmentArray30.Value
        insert_command.Parameters.Add("@volt12", MySqlDbType.Int16).Value = SevenSegmentArray31.Value
        insert_command.Parameters.Add("@curr12", MySqlDbType.Int16).Value = SevenSegmentArray32.Value

        insert_command.Parameters.Add("@volt21", MySqlDbType.Int16).Value = SevenSegmentArray33.Value
        insert_command.Parameters.Add("@curr21", MySqlDbType.Int16).Value = SevenSegmentArray34.Value
        insert_command.Parameters.Add("@volt22", MySqlDbType.Int16).Value = SevenSegmentArray35.Value
        insert_command.Parameters.Add("@curr22", MySqlDbType.Int16).Value = SevenSegmentArray36.Value

        If execCommand(insert_command) Then
            'MessageBox.Show("Data Inserted")

        Else
            MessageBox.Show("Data NOT Inserted")
        End If
    End Sub

    Public Sub updateDB_8()
        Dim insert_command As New MySqlCommand("INSERT INTO `cyl_8_table`(`Volt11`, `Curr11`, `Volt12`, `Curr12`) VALUES (@volt11,@curr11,@volt12,@curr12)", conn)
        insert_command.Parameters.Add("@volt11", MySqlDbType.Int16).Value = SevenSegmentArray37.Value
        insert_command.Parameters.Add("@curr11", MySqlDbType.Int16).Value = SevenSegmentArray38.Value
        insert_command.Parameters.Add("@volt12", MySqlDbType.Int16).Value = SevenSegmentArray39.Value
        insert_command.Parameters.Add("@curr12", MySqlDbType.Int16).Value = SevenSegmentArray40.Value

        If execCommand(insert_command) Then
            'MessageBox.Show("Data Inserted")

        Else
            MessageBox.Show("Data NOT Inserted")
        End If
    End Sub

End Class