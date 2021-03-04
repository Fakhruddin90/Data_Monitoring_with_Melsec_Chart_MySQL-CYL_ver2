Public Class Cyl6
    Public WithEvents ActUtl As ActUtlTypeLib.ActUtlTypeClass

    Private Sub Cyl4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActUtl = New ActUtlTypeLib.ActUtlTypeClass()
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim lRet As Long

        Try
            ActUtl.ActLogicalStationNumber = 6

            lRet = ActUtl.Open()

            If lRet = 0 Then
                txtMessage.Text = String.Format("Communication Open: 0x{0:x8}[HEX]", lRet)
                txtMessage.ForeColor = Color.Green
            Else
                txtMessage.Text = String.Format("Communication Error: 0x{0:x8}[HEX]", lRet)
                txtMessage.ForeColor = Color.Red
            End If

            btnOpen.Enabled = False
            btnClose.Enabled = True
            btnMonitor.Enabled = True
            btnExit.Enabled = False

        Catch ex As Exception
            MessageBox.Show("Please input logical station", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim lRet As Long

        lRet = ActUtl.Close()

        If lRet = 0 Then
            txtMessage.Text = String.Format("Communication Close: 0x{0:x8}", lRet)
            txtMessage.ForeColor = Color.Green
        Else
            txtMessage.Text = String.Format("Communication Error: 0x{0:x8}", lRet)
            txtMessage.ForeColor = Color.Red
        End If

        btnOpen.Enabled = True
        btnClose.Enabled = False
        btnMonitor.Enabled = False
        btnExit.Enabled = True

    End Sub

    Private Sub btnMonitor_Click(sender As Object, e As EventArgs) Handles btnMonitor.Click
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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub tmrMonitor_Tick(sender As Object, e As EventArgs) Handles tmrMonitor.Tick
        Dim lRet As Long
        Dim lData(10)

        'Inspection 1
        lRet = ActUtl.GetDevice("D1400", lData(0)) 'Voltage Upper
        lRet = ActUtl.GetDevice("D1401", lData(1)) 'Current Upper
        lRet = ActUtl.GetDevice("D1405", lData(2)) 'Voltage Lower
        lRet = ActUtl.GetDevice("D1406", lData(3)) 'Current Lower

        'Inspection 2
        lRet = ActUtl.GetDevice("D1430", lData(5)) 'Voltage Upper
        lRet = ActUtl.GetDevice("D1431", lData(6)) 'Current Upper
        lRet = ActUtl.GetDevice("D1435", lData(7)) 'Voltage Lower
        lRet = ActUtl.GetDevice("D1436", lData(8)) 'Current Lower

        lRet = ActUtl.GetDevice("D1316", lData(4)) 'Index speed

        'Inspection 1
        SevenSegmentArray1.Value = lData(0)
        SevenSegmentArray2.Value = lData(1)
        SevenSegmentArray3.Value = lData(2)
        SevenSegmentArray4.Value = lData(3)

        'Inspection 2
        SevenSegmentArray6.Value = lData(5)
        SevenSegmentArray7.Value = lData(6)
        SevenSegmentArray8.Value = lData(7)
        SevenSegmentArray9.Value = lData(8)

        SevenSegmentArray5.Value = lData(4)

        If lRet <> 0 Then
            txtMessage.Text = String.Format("Error: 0x{0:x8}", lRet)
        End If
    End Sub

    Private Sub ClearDisplay()
        SevenSegmentArray1.Value = 0
        SevenSegmentArray2.Value = 0
        SevenSegmentArray3.Value = 0
        SevenSegmentArray4.Value = 0

        SevenSegmentArray5.Value = 0

        SevenSegmentArray6.Value = 0
        SevenSegmentArray7.Value = 0
        SevenSegmentArray8.Value = 0
        SevenSegmentArray9.Value = 0
    End Sub
End Class