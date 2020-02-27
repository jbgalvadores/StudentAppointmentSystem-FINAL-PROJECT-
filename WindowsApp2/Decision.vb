Public Class Decision
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Schedule.ScheduleTableAdapter.CopyQuery()
        Schedule.ScheduleTableAdapter.Fill(Schedule.Database1DataSet.Schedule)

    End Sub
End Class