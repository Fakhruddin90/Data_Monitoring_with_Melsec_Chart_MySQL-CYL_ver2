Imports System.Windows.Forms.VisualStyles
Imports System.IO
Imports System.IO.File
Imports Microsoft.VisualBasic.Logging
Imports MySql.Data.MySqlClient

Public Class Form1

    Dim conn As New MySqlConnection
#Region "Connect to mysql"
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

    Private WithEvents ACTUtl As ActUtlTypeLib.ActUtlTypeClass

    Private frm2 As Form2
    Private frm3 As Form3
    Private frm1 As Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm2 = New Form2()
        frm3 = New Form3()

        Timer3.Enabled = True

        ACTUtl = New ActUtlTypeLib.ActUtlTypeClass
        ApplicationLog()
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim lRet As Long

        Connect()

        Try

            ACTUtl.ActLogicalStationNumber = Convert.ToInt16(txtLogical.Text)

            lRet = ACTUtl.Open()

            If lRet = 0 Then
                txtMessage.Text = String.Format("Communication Open: 0x{0:x8} [HEX]", lRet)
                txtMessage.ForeColor = Color.Green
            Else
                txtMessage.Text = String.Format("Communication Error: 0x{0:x8} [HEX]", lRet)
                txtMessage.ForeColor = Color.Red
            End If

            btnOpen.Enabled = False
            btnClose.Enabled = True
            btnMonitor.Enabled = True
            btnExit.Enabled = False

        Catch ex As Exception
            'MessageBox.Show(ex.Message, Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            MessageBox.Show("Please input logical station", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim lRet As Long

        lRet = ACTUtl.Close()

        If lRet = 0 Then
            txtMessage.Text = String.Format("Communication Open: 0x{0:x8} [HEX]", lRet)
            txtMessage.ForeColor = Color.Green
        Else
            txtMessage.Text = String.Format("Communication Error: 0x{0:x8} [HEX]", lRet)
            txtMessage.ForeColor = Color.Red
        End If

        btnOpen.Enabled = True
        btnClose.Enabled = False
        btnMonitor.Enabled = False
        btnExit.Enabled = True

        If conn.State = ConnectionState.Closed Then
            PictureBox2.Image = My.Resources.red
        End If

    End Sub

    Private Sub btnMonitor_Click(sender As Object, e As EventArgs) Handles btnMonitor.Click
        If Timer1.Enabled = False Then
            Timer1.Enabled = True
            btnMonitor.Text = "Monitor Stop"
            btnClose.Enabled = False
            Timer3.Enabled = True
            PictureBox1.Image = My.Resources.green
        ElseIf Timer1.Enabled = True Then
            Timer1.Enabled = False
            btnMonitor.Text = "Monitor Start"
            btnClose.Enabled = True
            Timer3.Enabled = False
            PictureBox1.Image = My.Resources.red
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim lRet As Long
        Dim lData(7)

        'INSPECTION 1
        lRet = ACTUtl.GetDevice("D1400", lData(0))
        lRet = ACTUtl.GetDevice("D1401", lData(1))
        lRet = ACTUtl.GetDevice("D1405", lData(2))
        lRet = ACTUtl.GetDevice("D1406", lData(3))

        'INSPECTION 2
        lRet = ACTUtl.GetDevice("D1430", lData(4))
        lRet = ACTUtl.GetDevice("D1431", lData(5))
        lRet = ACTUtl.GetDevice("D1435", lData(6))
        lRet = ACTUtl.GetDevice("D1436", lData(7))

        'INSPECTION 1
        txtVolt11.Text = lData(0)
        txtCurr11.Text = lData(1)
        txtVolt12.Text = lData(2)
        txtCurr12.Text = lData(3)

        'INSPECTION 2
        txtVolt21.Text = lData(4)
        txtCurr21.Text = lData(5)
        txtVolt22.Text = lData(6)
        txtCurr22.Text = lData(7)

        'SEVEN SEGMENT
        SevenSegmentArray1.Value = lData(0)
        SevenSegmentArray3.Value = lData(1)
        SevenSegmentArray4.Value = lData(2)
        SevenSegmentArray5.Value = lData(3)
        SevenSegmentArray6.Value = lData(4)
        SevenSegmentArray7.Value = lData(5)
        SevenSegmentArray8.Value = lData(6)
        SevenSegmentArray9.Value = lData(7)


        If lRet <> 0 Then
            txtMessage.Text = String.Format("Error: 0x{0:x8} [HEX]", lRet)
        End If


        If lData(0) >= 70 Then
            Label7.ForeColor = Color.Red
            'Process.Start("C:\")
        End If

        updateDB()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.ExitThread()
    End Sub

    Private Sub CreateCSV(ByVal _CSVPath As String, ByVal _Voltage11 As String, ByVal _Voltage12 As String, ByVal _Current11 As String, ByVal _Current12 As String, ByVal _Date As String)

        Try
            Dim stLine As String = ""
            Dim objWriter As IO.StreamWriter = IO.File.AppendText(_CSVPath)
            If IO.File.Exists(_CSVPath) Then
                objWriter.Write(_Date)
                objWriter.Write(_Voltage11 & ",")
                objWriter.Write(_Voltage12 & ",")
                objWriter.Write(_Current11 & ",")
                objWriter.Write(_Current12 & ",")


                objWriter.Write(Environment.NewLine)
            End If
            objWriter.Close()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim date1 As Date = Date.Now
        'Dim header As String

        CreateCSV(Application.StartupPath & "\" & "Log_" & DateTime.Today.ToString("dd-MMM-yyyy") & ".csv", txtVolt11.Text.ToString, txtCurr11.Text.ToString(), txtVolt12.Text.ToString(), txtCurr12.Text.ToString(), date1.ToString())
        'frm2.ListBox1.Items.Add(date1.ToString() & txtVolt11.Text & " " & txtCurr11.Text & " " & txtVolt12.Text & " " & txtCurr12.Text & " ")

        'frm3.DataGridView1.Rows.Add(txtVolt11.Text, txtCurr11.Text, txtVolt12.Text, txtCurr12.Text, date1)
    End Sub

    Public Sub DataClear(list As Object)
        list.Items.Clear()
    End Sub


    Public Sub ExportCSV()
        'Create empty string
        frm3 = New Form3()
        Dim thecsvfile As String = String.Empty

        'Get column header
        For Each column As DataGridViewColumn In frm3.DataGridView1.Columns
            thecsvfile = thecsvfile & column.HeaderText & ","
        Next

        'Trim the last comma
        thecsvfile = thecsvfile.TrimEnd(",")
        'Add line to the output
        thecsvfile = thecsvfile & vbCr & vbLf
        'Get the rows
        For Each row As DataGridViewRow In frm3.DataGridView1.Rows
            'Get the cells
            For Each cell As DataGridViewCell In row.Cells
                thecsvfile = thecsvfile & cell.FormattedValue & ","
            Next
            'Trim the last comma
            thecsvfile = thecsvfile.TrimEnd(",")
            'Add the line to the output
            thecsvfile = thecsvfile & vbCr & vbLf
        Next
        'Write the file


        My.Computer.FileSystem.WriteAllText($"Log_{DateTime.Today.ToString("dd-MMM-yyyy")}.csv", thecsvfile, False)

    End Sub

#Region "Tracing Information"
    Public Sub TracingTest(ByVal fileName As String)
        My.Application.Log.WriteEntry(
            "Entering TracingTest with argument " &
            fileName & ".")
        ' Code to trace goes here.
        My.Application.Log.WriteEntry(
            "Exiting TracingTest with argument " &
            fileName & ".")
    End Sub
#End Region

    Public Sub ApplicationLog()
        Dim filename As String = Application.StartupPath & "\test.log"
        Dim sw As StreamWriter = AppendText(filename)
        sw.WriteLine(Now() & " " & "sample log file entry")
        sw.Close()
    End Sub

    Public Sub DataLog()
        Dim thecsvfile As String = String.Empty

        'Get column header
        For Each column As DataGridViewColumn In frm3.DataGridView1.Columns
            thecsvfile = thecsvfile & column.HeaderText & ","
        Next

        Dim filename As String = Application.StartupPath & $"\Data_Log_{DateTime.Today.ToString("dd-MMM-yyyy")}.csv"
        Dim sw As StreamWriter = AppendText(filename)
        sw.WriteLine(Now() & "," & $"{txtVolt11.Text},{txtCurr11.Text},{txtVolt12.Text},{txtCurr12.Text}")
        'Console.WriteLine(Now() & "," & "sample log file entry")
        sw.Close()
    End Sub

    Public Sub EventLog()
        Dim filename As String = Application.StartupPath & "\Event_Log.log"
        Dim sw As StreamWriter = AppendText(filename)
        sw.WriteLine(Now() & " " & txtMessage.Text)
        sw.Close()
    End Sub

    Private Sub btnListBox_Click(sender As Object, e As EventArgs) Handles btnListBox.Click
        Form2.Show()
    End Sub

    Private Sub btnGridView_Click(sender As Object, e As EventArgs) Handles btnGridView.Click
        Form3.Show()
    End Sub

    Private Sub btnChart_Click(sender As Object, e As EventArgs) Handles btnChart.Click
        Form4.Show()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
#Region "Comment program"
        'Dim DT As DateTime = Now
        'Dim Limit As Integer
        'Dim lData(7)

        'Form4.Chart1.Series("Voltage11").Points.AddXY(DT.ToLongTimeString, txtVolt11.Text)
        'If Form4.Chart1.Series(0).Points.Count = Limit Then
        '    Form4.Chart1.Series(0).Points.RemoveAt(0)
        'End If

        'Form4.Chart1.Series("Current11").Points.AddXY(DT.ToLongTimeString, lData(1))
        'If Form4.Chart1.Series(1).Points.Count = Limit Then
        '    Form4.Chart1.Series(1).Points.RemoveAt(1)
        'End If

        'Form4.Chart1.Series("Voltage12").Points.AddXY(DT.ToLongTimeString, lData(2))
        'If Form4.Chart1.Series(2).Points.Count = Limit Then
        '    Form4.Chart1.Series(2).Points.RemoveAt(2)
        'End If

        'Form4.Chart1.Series("Current12").Points.AddXY(DT.ToLongTimeString, lData(3))
        'If Form4.Chart1.Series(3).Points.Count = Limit Then
        '    Form4.Chart1.Series(3).Points.RemoveAt(3)
        'End If
#End Region

        Dim time As DateTime

        time = DateTime.Now
        lblTime.Text = time
        DataLog()

        SevenSegmentArray2.Value = time
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pathFile As String = Application.StartupPath & "\restart.bat"
        'Process.Start("C:\")
        Process.Start(pathFile)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pathFile As String = Application.StartupPath & "\shutdown_cancel.bat"
        Process.Start(pathFile)
    End Sub


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

#Region "Update data to database"
    Public Sub updateDB()
        Dim insert_command As New MySqlCommand("INSERT INTO `datamonitoring_table`(`Volt11`, `Curr11`, `Volt12`, `Curr12`) VALUES (@volt11,@curr11,@volt12,@curr12)", conn)
        insert_command.Parameters.Add("@volt11", MySqlDbType.Int16).Value = txtVolt11.Text
        insert_command.Parameters.Add("@curr11", MySqlDbType.Int16).Value = txtCurr11.Text
        insert_command.Parameters.Add("@volt12", MySqlDbType.Int16).Value = txtVolt12.Text
        insert_command.Parameters.Add("@curr12", MySqlDbType.Int16).Value = txtCurr12.Text

        If execCommand(insert_command) Then
            'MessageBox.Show("Data Inserted")

        Else
            MessageBox.Show("Data NOT Inserted")
        End If
    End Sub

    Private Sub btnCyl1_Click(sender As Object, e As EventArgs) Handles btnCyl1.Click
        Cyl1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCyl2.Click
        Cyl2.Show()
    End Sub

    Private Sub btnCyl3_Click(sender As Object, e As EventArgs) Handles btnCyl3.Click
        Cyl3.Show()
    End Sub

    Private Sub btnCyl4_Click(sender As Object, e As EventArgs) Handles btnCyl4.Click
        Cyl4.Show()
    End Sub

    Private Sub btnCyl5_Click(sender As Object, e As EventArgs) Handles btnCyl5.Click
        Cyl5.Show()
    End Sub

    Private Sub btnCyl6_Click(sender As Object, e As EventArgs) Handles btnCyl6.Click
        Cyl6.Show()
    End Sub

    Private Sub btnCyl7_Click(sender As Object, e As EventArgs) Handles btnCyl7.Click
        Cyl7.Show()
    End Sub

    Private Sub btnCyl8_Click(sender As Object, e As EventArgs) Handles btnCyl8.Click
        Cyl8.Show()
    End Sub

    Private Sub btnCylAll_Click(sender As Object, e As EventArgs) Handles btnCylAll.Click
        CylAll.Show()
    End Sub
#End Region
End Class
