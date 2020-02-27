Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.SloginTableAdapter.StudentLogin(TextBox1.Text, TextBox2.Text) Then
            Student.Show()

        ElseIf Me.FloginTableAdapter.FacultyLogin(TextBox1.Text, TextBox2.Text) Then
            Faculty.Show()
        Else
            MessageBox.Show("Unsuccessful Login")
        End If

        If TextBox1.Text = "2020" Then
            Faculty.NotifyIcon1.ShowBalloonTip(500, "Click Me!", "You have an appointment request from" & Student.NameLabel1.Text, ToolTipIcon.Info)
        End If
    End Sub

    Private Sub SloginBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SloginBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SloginBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub




End Class