<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Faculty
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Faculty))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.PendingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New WindowsApp2.Database1DataSet()
        Me.ScheduleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PendingTableAdapter = New WindowsApp2.Database1DataSetTableAdapters.PendingTableAdapter()
        Me.TableAdapterManager = New WindowsApp2.Database1DataSetTableAdapters.TableAdapterManager()
        Me.ScheduleTableAdapter = New WindowsApp2.Database1DataSetTableAdapters.ScheduleTableAdapter()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.IconButton5 = New FontAwesome.Sharp.IconButton()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PanelMenu.SuspendLayout()
        CType(Me.PendingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScheduleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitleBar.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.LinkLabel1)
        Me.PanelMenu.Controls.Add(Me.IconButton2)
        Me.PanelMenu.Controls.Add(Me.IconButton1)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(170, 439)
        Me.PanelMenu.TabIndex = 0
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 19)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(32, 13)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Back"
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
        Me.IconButton2.Location = New System.Drawing.Point(3, 207)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton2.Rotation = 0R
        Me.IconButton2.Size = New System.Drawing.Size(150, 37)
        Me.IconButton2.TabIndex = 6
        Me.IconButton2.Text = "Schedule"
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
        Me.IconButton1.Location = New System.Drawing.Point(3, 147)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(150, 37)
        Me.IconButton1.TabIndex = 7
        Me.IconButton1.Text = "Pending"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'PendingBindingSource
        '
        Me.PendingBindingSource.DataMember = "Pending"
        Me.PendingBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ScheduleBindingSource
        '
        Me.ScheduleBindingSource.DataMember = "Schedule"
        Me.ScheduleBindingSource.DataSource = Me.Database1DataSet
        '
        'PendingTableAdapter
        '
        Me.PendingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FloginTableAdapter = Nothing
        Me.TableAdapterManager.HistoryTableAdapter = Nothing
        Me.TableAdapterManager.PendingTableAdapter = Me.PendingTableAdapter
        Me.TableAdapterManager.ScheduleTableAdapter = Me.ScheduleTableAdapter
        Me.TableAdapterManager.SloginTableAdapter = Nothing
        Me.TableAdapterManager.TableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp2.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ScheduleTableAdapter
        '
        Me.ScheduleTableAdapter.ClearBeforeFill = True
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
        Me.PanelTitleBar.Location = New System.Drawing.Point(170, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(662, 75)
        Me.PanelTitleBar.TabIndex = 2
        '
        'IconButton5
        '
        Me.IconButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconButton5.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton5.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton5.IconColor = System.Drawing.Color.Black
        Me.IconButton5.IconSize = 16
        Me.IconButton5.Location = New System.Drawing.Point(611, 12)
        Me.IconButton5.Name = "IconButton5"
        Me.IconButton5.Rotation = 0R
        Me.IconButton5.Size = New System.Drawing.Size(24, 26)
        Me.IconButton5.TabIndex = 3
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
        Me.IconButton4.Location = New System.Drawing.Point(581, 12)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Rotation = 0R
        Me.IconButton4.Size = New System.Drawing.Size(24, 26)
        Me.IconButton4.TabIndex = 4
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
        Me.IconButton3.Location = New System.Drawing.Point(551, 12)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Rotation = 0R
        Me.IconButton3.Size = New System.Drawing.Size(24, 26)
        Me.IconButton3.TabIndex = 5
        Me.IconButton3.Text = "IconButton3"
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFormTitle.Location = New System.Drawing.Point(69, 45)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(39, 13)
        Me.lblFormTitle.TabIndex = 2
        Me.lblFormTitle.Text = "Label1"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.Color.Gainsboro
        Me.IconCurrentForm.IconSize = 34
        Me.IconCurrentForm.Location = New System.Drawing.Point(17, 24)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(37, 34)
        Me.IconCurrentForm.TabIndex = 1
        Me.IconCurrentForm.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(170, 75)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(662, 364)
        Me.PanelDesktop.TabIndex = 3
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipTitle = "Click Me!"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Faculty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 439)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "Faculty"
        Me.Text = "Faculty"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        CType(Me.PendingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScheduleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitleBar.ResumeLayout(False)
        Me.PanelTitleBar.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents PendingBindingSource As BindingSource
    Friend WithEvents PendingTableAdapter As Database1DataSetTableAdapters.PendingTableAdapter
    Friend WithEvents TableAdapterManager As Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ScheduleTableAdapter As Database1DataSetTableAdapters.ScheduleTableAdapter
    Friend WithEvents ScheduleBindingSource As BindingSource
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class
