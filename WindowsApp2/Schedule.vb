Public Class Schedule
    Private Sub Schedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.History' table. You can move, or remove it, as needed.
        Me.ScheduleTableAdapter.Fill(Me.Database1DataSet.Schedule)

    End Sub
End Class