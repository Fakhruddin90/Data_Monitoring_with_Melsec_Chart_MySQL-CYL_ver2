
Public Class Form2


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim date1 As Date = Date.Now

        ListBox1.Items.Add(date1.ToString() & Form1.txtVolt11.Text & " " & Form1.txtCurr11.Text & " " & Form1.txtVolt12.Text & " " & Form1.txtCurr12.Text & " ")

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer1.Enabled = False
        btnStart.Enabled = True
        btnStop.Enabled = False
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Enabled = True
        btnStart.Enabled = False
        btnStop.Enabled = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Form1.ExportCSV()
        Form1.DataClear(ListBox1)
        Form1.TracingTest("LogInfo.csv")
    End Sub
End Class