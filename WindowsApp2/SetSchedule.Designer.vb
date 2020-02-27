<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SetSchedule
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetSchedule))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Appointment = New System.Windows.Forms.ComboBox()
        Me.Schedule = New System.Windows.Forms.ComboBox()
        Me.FacultyName = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.FacultyEmail = New System.Windows.Forms.TextBox()
        Me.StudentEmail = New System.Windows.Forms.TextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Appointment)
        Me.Panel1.Controls.Add(Me.Schedule)
        Me.Panel1.Controls.Add(Me.FacultyName)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.FacultyEmail)
        Me.Panel1.Controls.Add(Me.StudentEmail)
        Me.Panel1.Location = New System.Drawing.Point(37, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(357, 317)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(153, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 25)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Set Appointment"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Appointment"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Schedule"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Faculty ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Faculty Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Faculty"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Email"
        '
        'Appointment
        '
        Me.Appointment.FormattingEnabled = True
        Me.Appointment.Items.AddRange(New Object() {"Grade Consultation"})
        Me.Appointment.Location = New System.Drawing.Point(153, 207)
        Me.Appointment.Name = "Appointment"
        Me.Appointment.Size = New System.Drawing.Size(166, 21)
        Me.Appointment.TabIndex = 6
        '
        'Schedule
        '
        Me.Schedule.FormattingEnabled = True
        Me.Schedule.Location = New System.Drawing.Point(153, 166)
        Me.Schedule.Name = "Schedule"
        Me.Schedule.Size = New System.Drawing.Size(166, 21)
        Me.Schedule.TabIndex = 7
        '
        'FacultyName
        '
        Me.FacultyName.FormattingEnabled = True
        Me.FacultyName.Items.AddRange(New Object() {"Patrick Mack", "Patrick Marlowe", "Maria Ramila Jimenez"})
        Me.FacultyName.Location = New System.Drawing.Point(153, 56)
        Me.FacultyName.Name = "FacultyName"
        Me.FacultyName.Size = New System.Drawing.Size(166, 21)
        Me.FacultyName.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(153, 93)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(164, 20)
        Me.TextBox1.TabIndex = 4
        '
        'FacultyEmail
        '
        Me.FacultyEmail.Location = New System.Drawing.Point(153, 128)
        Me.FacultyEmail.Name = "FacultyEmail"
        Me.FacultyEmail.Size = New System.Drawing.Size(164, 20)
        Me.FacultyEmail.TabIndex = 4
        '
        'StudentEmail
        '
        Me.StudentEmail.Location = New System.Drawing.Point(153, 22)
        Me.StudentEmail.Name = "StudentEmail"
        Me.StudentEmail.Size = New System.Drawing.Size(164, 20)
        Me.StudentEmail.TabIndex = 5
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipTitle = "Click Me!"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'SetSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 347)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SetSchedule"
        Me.Text = "SetSchedule"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Appointment As ComboBox
    Friend WithEvents Schedule As ComboBox
    Friend WithEvents FacultyName As ComboBox
    Friend WithEvents FacultyEmail As TextBox
    Friend WithEvents StudentEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class
