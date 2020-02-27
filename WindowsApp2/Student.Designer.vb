<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Student_IDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.NameLabel1 = New System.Windows.Forms.Label()
        Me.SloginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New WindowsApp2.Database1DataSet()
        Me.Student_IDLabel1 = New System.Windows.Forms.Label()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.HistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HistoryTableAdapter = New WindowsApp2.Database1DataSetTableAdapters.HistoryTableAdapter()
        Me.TableAdapterManager = New WindowsApp2.Database1DataSetTableAdapters.TableAdapterManager()
        Me.SloginTableAdapter = New WindowsApp2.Database1DataSetTableAdapters.SloginTableAdapter()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.IconButton5 = New FontAwesome.Sharp.IconButton()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.IconButton6 = New FontAwesome.Sharp.IconButton()
        Student_IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        Me.PanelMenu.SuspendLayout()
        CType(Me.SloginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Student_IDLabel
        '
        Student_IDLabel.AutoSize = True
        Student_IDLabel.Location = New System.Drawing.Point(28, 96)
        Student_IDLabel.Name = "Student_IDLabel"
        Student_IDLabel.Size = New System.Drawing.Size(61, 13)
        Student_IDLabel.TabIndex = 5
        Student_IDLabel.Text = "Student ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(28, 141)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 6
        NameLabel.Text = "Name:"
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.IconButton6)
        Me.PanelMenu.Controls.Add(NameLabel)
        Me.PanelMenu.Controls.Add(Me.NameLabel1)
        Me.PanelMenu.Controls.Add(Student_IDLabel)
        Me.PanelMenu.Controls.Add(Me.Student_IDLabel1)
        Me.PanelMenu.Controls.Add(Me.IconButton2)
        Me.PanelMenu.Controls.Add(Me.IconButton1)
        Me.PanelMenu.Controls.Add(Me.LinkLabel1)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(243, 395)
        Me.PanelMenu.TabIndex = 4
        '
        'NameLabel1
        '
        Me.NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SloginBindingSource, "Name", True))
        Me.NameLabel1.Location = New System.Drawing.Point(72, 141)
        Me.NameLabel1.Name = "NameLabel1"
        Me.NameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.NameLabel1.TabIndex = 7
        Me.NameLabel1.Text = "Label1"
        '
        'SloginBindingSource
        '
        Me.SloginBindingSource.DataMember = "Slogin"
        Me.SloginBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Student_IDLabel1
        '
        Me.Student_IDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SloginBindingSource, "Student_ID", True))
        Me.Student_IDLabel1.Location = New System.Drawing.Point(95, 96)
        Me.Student_IDLabel1.Name = "Student_IDLabel1"
        Me.Student_IDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Student_IDLabel1.TabIndex = 6
        Me.Student_IDLabel1.Text = "Label1"
        '
        'IconButton2
        '
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton2.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Forward
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconSize = 32
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(15, 226)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton2.Rotation = 0R
        Me.IconButton2.Size = New System.Drawing.Size(150, 37)
        Me.IconButton2.TabIndex = 5
        Me.IconButton2.Text = "History"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Forward
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconSize = 32
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(15, 166)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(150, 37)
        Me.IconButton1.TabIndex = 5
        Me.IconButton1.Text = "Set Schedule"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(32, 13)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Back"
        '
        'HistoryBindingSource
        '
        Me.HistoryBindingSource.DataMember = "History"
        Me.HistoryBindingSource.DataSource = Me.Database1DataSet
        '
        'HistoryTableAdapter
        '
        Me.HistoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FloginTableAdapter = Nothing
        Me.TableAdapterManager.HistoryTableAdapter = Me.HistoryTableAdapter
        Me.TableAdapterManager.PendingTableAdapter = Nothing
        Me.TableAdapterManager.ScheduleTableAdapter = Nothing
        Me.TableAdapterManager.SloginTableAdapter = Nothing
        Me.TableAdapterManager.TableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp2.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SloginTableAdapter
        '
        Me.SloginTableAdapter.ClearBeforeFill = True
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelTitleBar.Controls.Add(Me.IconButton5)
        Me.PanelTitleBar.Controls.Add(Me.IconButton4)
        Me.PanelTitleBar.Controls.Add(Me.IconButton3)
        Me.PanelTitleBar.Controls.Add(Me.lblFormTitle)
        Me.PanelTitleBar.Controls.Add(Me.IconCurrentForm)
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(243, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(668, 96)
        Me.PanelTitleBar.TabIndex = 7
        '
        'IconButton5
        '
        Me.IconButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton5.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton5.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton5.IconColor = System.Drawing.Color.Black
        Me.IconButton5.IconSize = 16
        Me.IconButton5.Location = New System.Drawing.Point(620, 9)
        Me.IconButton5.Name = "IconButton5"
        Me.IconButton5.Rotation = 0R
        Me.IconButton5.Size = New System.Drawing.Size(24, 26)
        Me.IconButton5.TabIndex = 2
        Me.IconButton5.Text = "IconButton3"
        Me.IconButton5.UseVisualStyleBackColor = True
        '
        'IconButton4
        '
        Me.IconButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton4.IconColor = System.Drawing.Color.Black
        Me.IconButton4.IconSize = 16
        Me.IconButton4.Location = New System.Drawing.Point(590, 9)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Rotation = 0R
        Me.IconButton4.Size = New System.Drawing.Size(24, 26)
        Me.IconButton4.TabIndex = 2
        Me.IconButton4.Text = "IconButton3"
        Me.IconButton4.UseVisualStyleBackColor = True
        '
        'IconButton3
        '
        Me.IconButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton3.IconColor = System.Drawing.Color.Black
        Me.IconButton3.IconSize = 16
        Me.IconButton3.Location = New System.Drawing.Point(560, 9)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Rotation = 0R
        Me.IconButton3.Size = New System.Drawing.Size(24, 26)
        Me.IconButton3.TabIndex = 2
        Me.IconButton3.Text = "IconButton3"
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFormTitle.Location = New System.Drawing.Point(74, 42)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(39, 13)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Label1"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.Color.Gainsboro
        Me.IconCurrentForm.IconSize = 34
        Me.IconCurrentForm.Location = New System.Drawing.Point(21, 21)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(37, 34)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(243, 96)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(668, 299)
        Me.PanelDesktop.TabIndex = 8
        '
        'IconButton6
        '
        Me.IconButton6.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton6.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton6.IconColor = System.Drawing.Color.Black
        Me.IconButton6.IconSize = 16
        Me.IconButton6.Location = New System.Drawing.Point(15, 282)
        Me.IconButton6.Name = "IconButton6"
        Me.IconButton6.Rotation = 0R
        Me.IconButton6.Size = New System.Drawing.Size(158, 41)
        Me.IconButton6.TabIndex = 8
        Me.IconButton6.Text = "View Schedule"
        Me.IconButton6.UseVisualStyleBackColor = True
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 395)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "Student"
        Me.Text = "Student"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        CType(Me.SloginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents HistoryBindingSource As BindingSource
    Friend WithEvents HistoryTableAdapter As Database1DataSetTableAdapters.HistoryTableAdapter
    Friend WithEvents TableAdapterManager As Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents SloginBindingSource As BindingSource
    Friend WithEvents SloginTableAdapter As Database1DataSetTableAdapters.SloginTableAdapter
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents NameLabel1 As Label
    Friend WithEvents Student_IDLabel1 As Label
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
End Class
