Public Class History


    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.History' table. You can move, or remove it, as needed.
        Me.HistoryTableAdapter.Fill(Me.Database1DataSet.History)

    End Sub


End Class