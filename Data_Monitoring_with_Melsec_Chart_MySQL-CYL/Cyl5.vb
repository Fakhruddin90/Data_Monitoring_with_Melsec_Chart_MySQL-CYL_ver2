Public Class Cyl5
    Public WithEvents ActUtl As ActUtlTypeLib.ActUtlTypeClass

    Private Sub Cyl4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActUtl = New ActUtlTypeLib.ActUtlTypeClass()
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim lRet As Long

        Try
            ActUtl.ActLogicalStationNumber = 5

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
        Dim lData(4)

        lRet = ActUtl.GetDevice("D12610", lData(0)) 'Voltage Upper
        lRet = ActUtl.GetDevice("D12611", lData(1)) 'Current Upper
        lRet = ActUtl.GetDevice("D12612", lData(2)) 'Voltage Lower
        lRet = ActUtl.GetDevice("D12613", lData(3)) 'Current Lower

        lRet = ActUtl.GetDevice("D0126", lData(4)) 'Index speed

        SevenSegmentArray1.Value = lData(0)
        SevenSegmentArray2.Value = lData(1)
        SevenSegmentArray3.Value = lData(2)
        SevenSegmentArray4.Value = lData(3)

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
    End Sub
End Class