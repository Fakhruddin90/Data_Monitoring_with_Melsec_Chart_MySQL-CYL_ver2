Public Class Form3

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim date1 As Date = Date.Now

        DataGridView1.Rows.Add(date1, Form1.txtVolt11.Text, Form1.txtCurr11.Text, Form1.txtVolt12.Text, Form1.txtCurr12.Text)
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Enabled = True
        btnStart.Enabled = False
        btnStop.Enabled = True
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer1.Enabled = False
        btnStart.Enabled = True
        btnStop.Enabled = False
    End Sub

End Class