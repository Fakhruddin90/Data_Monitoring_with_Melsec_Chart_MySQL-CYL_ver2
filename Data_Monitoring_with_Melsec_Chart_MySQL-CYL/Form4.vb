Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Limit As Integer
        Limit = 10
        For i = 0 To 10 Step 1
            Chart1.Series("Voltage11").Points.AddXY(DateTime.Now.ToLongTimeString, 0)
            If Chart1.Series(0).Points.Count = Limit Then
                Chart1.Series(0).Points.RemoveAt(0)
            End If

            Chart1.Series("Current11").Points.AddY(0)
            If Chart1.Series(1).Points.Count = Limit Then
                Chart1.Series(1).Points.RemoveAt(1)
            End If

            Chart1.Series("Voltage12").Points.AddY(0)
            If Chart1.Series(2).Points.Count = Limit Then
                Chart1.Series(2).Points.RemoveAt(2)
            End If

            Chart1.Series("Current12").Points.AddY(0)
            If Chart1.Series(3).Points.Count = Limit Then
                Chart1.Series(3).Points.RemoveAt(3)
            End If
        Next
        Chart1.ChartAreas(0).AxisY.Maximum = 250
        Chart1.ChartAreas(0).AxisX.Maximum = 500


#Region "Start timer1"
        Timer1.Enabled = True
#End Region

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim DT As DateTime = Now
        Dim Limit As Integer

        Chart1.Series("Voltage11").Points.AddXY(DT.ToLongTimeString, Form1.txtVolt11.Text)
        If Chart1.Series(0).Points.Count = Limit Then
            Chart1.Series(0).Points.RemoveAt(0)
        End If

        Chart1.Series("Current11").Points.AddXY(DT.ToLongTimeString, Form1.txtCurr11.Text)
        If Chart1.Series(1).Points.Count = Limit Then
            Chart1.Series(1).Points.RemoveAt(1)
        End If

        Chart1.Series("Voltage12").Points.AddXY(DT.ToLongTimeString, Form1.txtVolt12.Text)
        If Chart1.Series(2).Points.Count = Limit Then
            Chart1.Series(2).Points.RemoveAt(2)
        End If

        Chart1.Series("Current12").Points.AddXY(DT.ToLongTimeString, Form1.txtCurr12.Text)
        If Chart1.Series(3).Points.Count = Limit Then
            Chart1.Series(3).Points.RemoveAt(3)
        End If
    End Sub
End Class