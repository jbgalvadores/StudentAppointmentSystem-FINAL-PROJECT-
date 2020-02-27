<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Database1DataSet = New WindowsApp2.Database1DataSet()
        Me.SloginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SloginTableAdapter = New WindowsApp2.Database1DataSetTableAdapters.SloginTableAdapter()
        Me.TableAdapterManager = New WindowsApp2.Database1DataSetTableAdapters.TableAdapterManager()
        Me.FloginTableAdapter = New WindowsApp2.Database1DataSetTableAdapters.FloginTableAdapter()
        Me.SloginBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SloginBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FloginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SloginDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FloginDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SloginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SloginBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SloginBindingNavigator.SuspendLayout()
        CType(Me.FloginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SloginDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FloginDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(126, 137)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 21)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(126, 94)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(127, 20)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(126, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(127, 20)
        Me.TextBox1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "School ID"
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SloginBindingSource
        '
        Me.SloginBindingSource.DataMember = "Slogin"
        Me.SloginBindingSource.DataSource = Me.Database1DataSet
        '
        'SloginTableAdapter
        '
        Me.SloginTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FloginTableAdapter = Me.FloginTableAdapter
        Me.TableAdapterManager.HistoryTableAdapter = Nothing
        Me.TableAdapterManager.PendingTableAdapter = Nothing
        Me.TableAdapterManager.ScheduleTableAdapter = Nothing
        Me.TableAdapterManager.SloginTableAdapter = Me.SloginTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApp2.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FloginTableAdapter
        '
        Me.FloginTableAdapter.ClearBeforeFill = True
        '
        'SloginBindingNavigator
        '
        Me.SloginBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SloginBindingNavigator.BindingSource = Me.SloginBindingSource
        Me.SloginBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SloginBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SloginBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SloginBindingNavigatorSaveItem})
        Me.SloginBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SloginBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SloginBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SloginBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SloginBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SloginBindingNavigator.Name = "SloginBindingNavigator"
        Me.SloginBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SloginBindingNavigator.Size = New System.Drawing.Size(803, 25)
        Me.SloginBindingNavigator.TabIndex = 8
        Me.SloginBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SloginBindingNavigatorSaveItem
        '
        Me.SloginBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SloginBindingNavigatorSaveItem.Image = CType(resources.GetObject("SloginBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SloginBindingNavigatorSaveItem.Name = "SloginBindingNavigatorSaveItem"
        Me.SloginBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SloginBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FloginBindingSource
        '
        Me.FloginBindingSource.DataMember = "Flogin"
        Me.FloginBindingSource.DataSource = Me.Database1DataSet
        '
        'SloginDataGridView
        '
        Me.SloginDataGridView.AutoGenerateColumns = False
        Me.SloginDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SloginDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.SloginDataGridView.DataSource = Me.SloginBindingSource
        Me.SloginDataGridView.Location = New System.Drawing.Point(377, 106)
        Me.SloginDataGridView.Name = "SloginDataGridView"
        Me.SloginDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.SloginDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Student_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Student_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'FloginDataGridView
        '
        Me.FloginDataGridView.AutoGenerateColumns = False
        Me.FloginDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FloginDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.FloginDataGridView.DataSource = Me.FloginBindingSource
        Me.FloginDataGridView.Location = New System.Drawing.Point(156, 201)
        Me.FloginDataGridView.Name = "FloginDataGridView"
        Me.FloginDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.FloginDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Faculty_ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Faculty_ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 488)
        Me.Controls.Add(Me.FloginDataGridView)
        Me.Controls.Add(Me.SloginDataGridView)
        Me.Controls.Add(Me.SloginBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SloginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SloginBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SloginBindingNavigator.ResumeLayout(False)
        Me.SloginBindingNavigator.PerformLayout()
        CType(Me.FloginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SloginDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FloginDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents SloginBindingSource As BindingSource
    Friend WithEvents SloginTableAdapter As Database1DataSetTableAdapters.SloginTableAdapter
    Friend WithEvents TableAdapterManager As Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents SloginBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents SloginBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FloginTableAdapter As Database1DataSetTableAdapters.FloginTableAdapter
    Friend WithEvents FloginBindingSource As BindingSource
    Friend WithEvents SloginDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents FloginDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
