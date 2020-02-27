Public Class notify


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Faculty.NotifyIcon1.ShowBalloonTip(500, "Click Me!", "You have an appointment request from" & Student.NameLabel1.Text, ToolTipIcon.Info)
    End Sub

    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles Button1.MouseClick

    End Sub


End Class