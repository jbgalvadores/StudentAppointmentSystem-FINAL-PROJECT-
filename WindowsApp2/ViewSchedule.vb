Public Class ViewSchedule
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Patrick J. Mack" Then
        ElseIf ComboBox1.SelectedItem = "Maria Ramila Jimenez" Then
        ElseIf ComboBox1.SelectedItem = "Elvira B. Yaneza" Then
        ElseIf ComboBox1.SelectedItem = "Shayryl Mae R. Sabal" Then
        ElseIf ComboBox1.SelectedItem = "Florence B. Reyes" Then
        ElseIf ComboBox1.SelectedItem = "Harriet B. Fernandez" Then
        ElseIf ComboBox1.SelectedItem = "Jessie Christopher Lagrosas" Then
        ElseIf ComboBox1.SelectedItem = "Jun Rangie C. Obispo" Then
        ElseIf ComboBox1.SelectedItem = "Patrick Marlowe C. Oliva" Then
        ElseIf ComboBox1.SelectedItem = "Gerardo S. Doroja" Then
        ElseIf ComboBox1.SelectedItem = "Jordan K. Canete" Then
        ElseIf ComboBox1.SelectedItem = "Cristina Amor T. Cajilla" Then
        ElseIf ComboBox1.SelectedItem = "Kleb Dale G. Bayaras" Then
        ElseIf ComboBox1.SelectedItem = "Meldie A. Apag" Then
        ElseIf ComboBox1.SelectedItem = "Isabella Gillian Alvarez" Then
        ElseIf ComboBox1.SelectedItem = "Daniele Maae T. Romano" Then
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel13.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        MessageBox.Show("Monday:    1:30-4:30
                                    CC11 A LAB
                                    LAB C
                          Thursday: 1:30-3:30
                                    CC11 A
                                    FH 206")
    End Sub
End Class