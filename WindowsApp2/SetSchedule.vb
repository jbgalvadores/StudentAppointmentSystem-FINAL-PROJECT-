
Public Class SetSchedule
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If StudentEmail.Text = "" Then
            MessageBox.Show("Please enter email address.")
        End If

        If FacultyName.Text = "" Then
            MessageBox.Show("Please choose faculty member.")
        End If

        If Schedule.Text = "" Then
            MessageBox.Show("Please choose schedule of appointment.")
        End If

        If Appointment.Text = "" Then
            MessageBox.Show("Please choose reason of appointment.")
        End If

        History.HistoryTableAdapter.InsertHistory(StudentEmail.Text, FacultyName.Text, Schedule.Text, Appointment.Text, "PENDING")
        History.HistoryTableAdapter.Fill(History.Database1DataSet.History)

        Pending.PendingTableAdapter.InsertPending(Student.Student_IDLabel1.Text, Student.NameLabel1.Text, StudentEmail.Text, Schedule.Text, Appointment.Text, TextBox1.Text)
        Pending.PendingTableAdapter.Fill(Pending.Database1DataSet.Pending)

        If FacultyName.Text = "Patrick Mack" Then

            Faculty.NotifyIcon1.ShowBalloonTip(500, "Click Me!", "You have an appointment request from" & Student.NameLabel1.Text, ToolTipIcon.Info)
        End If



    End Sub





    Private Sub FacultyName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FacultyName.SelectedIndexChanged
        If FacultyName.SelectedItem = "Patrick Mack" Then

            Schedule.Items.Add("Mon 8:30am-12pm")
            Schedule.Items.Add("Mon 4:30am-6pm")
            Schedule.Items.Add("Tue 1:30pm-3:30pm")
            Schedule.Items.Add("Wed 8:30-11:30am")
            Schedule.Items.Add("Thu 8:30am-12pm")
            Schedule.SelectedIndex = 0

        ElseIf FacultyName.SelectedItem = "Patrick Oliva" Then

            Schedule.Items.Add("Mon 1:30am-3pm")
            Schedule.Items.Add("Tue 8:30pm-12pm")
            Schedule.Items.Add("Wed 8:30-11:30am")
            Schedule.Items.Add("Fri 8:30am-12pm")
            Schedule.SelectedIndex = 0

        End If

        If FacultyName.SelectedItem = "Patrick Mack" Then
            FacultyEmail.Text = "patrickmack@gmail.com"
        ElseIf FacultyName.SelectedItem = "Patrick Oliva" Then
            FacultyEmail.Text = "patrickoliva@gmail.com"
        ElseIf FacultyName.SelectedItem = "Maria Ramila Jimenez" Then
            FacultyEmail.Text = "mjimenez@gmail.com"

        End If



        If FacultyName.SelectedItem = "Patrick Mack" Then
            TextBox1.Text = "2020"
        ElseIf FacultyName.SelectedItem = "Maria Ramila Jimenez" Then
            TextBox1.Text = "2021"
        Else
            MessageBox.Show("GO!")
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub




End Class