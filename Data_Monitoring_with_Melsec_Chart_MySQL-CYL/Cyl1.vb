﻿Public Class Cyl1
    Private WithEvents ACTUtl As ActUtlTypeLib.ActMLUtlTypeClass

    Private Sub Cyl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ACTUtl = New ActUtlTypeLib.ActMLUtlTypeClass
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim lRet As Long

        Try
            ACTUtl.ActLogicalStationNumber = 1

            lRet = ACTUtl.Open()

            If lRet = 0 Then
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

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim lRet As Long

        lRet = ACTUtl.Close()

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

        lRet = ACTUtl.GetDevice("D1400", lData(0)) 'Voltage Upper
        lRet = ACTUtl.GetDevice("D1401", lData(1)) 'Current Upper
        lRet = ACTUtl.GetDevice("D1405", lData(2)) 'Voltage Lower
        lRet = ACTUtl.GetDevice("D1406", lData(3)) 'Current Lower

        lRet = ACTUtl.GetDevice("D1305", lData(4)) 'Index speed

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