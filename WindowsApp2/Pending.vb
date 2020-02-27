Public Class Pending
    Private Sub Pending_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.History' table. You can move, or remove it, as needed.
        Me.PendingTableAdapter.Fill(Me.Database1DataSet.Pending)

    End Sub

    Private Sub AcceptBtn_Click(sender As Object, e As EventArgs) Handles AcceptBtn.Click
        Decision.Show()
    End Sub

    Private Sub RejectBtn_Click(sender As Object, e As EventArgs) Handles RejectBtn.Click
        Reschedule.Show()
    End Sub
End Class