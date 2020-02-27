<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class History
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(History))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.HistoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New WindowsApp2.Database1DataSet()
        Me.HistoryTableAdapter = New WindowsApp2.Database1DataSetTableAdapters.HistoryTableAdapter()
        Me.TableAdapterManager = New WindowsApp2.Database1DataSetTableAdapters.TableAdapterManager()
        Me.HistoryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.HistoryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        CType(Me.HistoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HistoryBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.HistoryDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(12, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(545, 226)
        Me.Panel1.TabIndex = 0
        '
        'HistoryDataGridView
        '
        Me.HistoryDataGridView.AutoGenerateColumns = False
        Me.HistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HistoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.HistoryDataGridView.DataSource = Me.HistoryBindingSource
        Me.HistoryDataGridView.Location = New System.Drawing.Point(0, 3)
        Me.HistoryDataGridView.Name = "HistoryDataGridView"
        Me.HistoryDataGridView.Size = New System.Drawing.Size(542, 220)
        Me.HistoryDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Faculty"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Faculty"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Schedule"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Schedule"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Appointment"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Appointment"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Request"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Request"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'HistoryBindingSource
        '
        Me.HistoryBindingSource.DataMember = "History"
        Me.HistoryBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.UpdateOrder = WindowsApp2.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HistoryBindingNavigator
        '
        Me.HistoryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.HistoryBindingNavigator.BindingSource = Me.HistoryBindingSource
        Me.HistoryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.HistoryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.HistoryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.HistoryBindingNavigatorSaveItem})
        Me.HistoryBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.HistoryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.HistoryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.HistoryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.HistoryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.HistoryBindingNavigator.Name = "HistoryBindingNavigator"
        Me.HistoryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.HistoryBindingNavigator.Size = New System.Drawing.Size(565, 25)
        Me.HistoryBindingNavigator.TabIndex = 1
        Me.HistoryBindingNavigator.Text = "BindingNavigator1"
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
        'HistoryBindingNavigatorSaveItem
        '
        Me.HistoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HistoryBindingNavigatorSaveItem.Image = CType(resources.GetObject("HistoryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.HistoryBindingNavigatorSaveItem.Name = "HistoryBindingNavigatorSaveItem"
        Me.HistoryBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.HistoryBindingNavigatorSaveItem.Text = "Save Data"
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 281)
        Me.Controls.Add(Me.HistoryBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "History"
        Me.Text = "History"
        Me.Panel1.ResumeLayout(False)
        CType(Me.HistoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HistoryBindingNavigator.ResumeLayout(False)
        Me.HistoryBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents HistoryBindingSource As BindingSource
    Friend WithEvents HistoryTableAdapter As Database1DataSetTableAdapters.HistoryTableAdapter
    Friend WithEvents TableAdapterManager As Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents HistoryBindingNavigator As BindingNavigator
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
    Friend WithEvents HistoryBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents HistoryDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
