<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pending
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pending))
        Me.PendingPanel = New System.Windows.Forms.Panel()
        Me.PendingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New WindowsApp2.Database1DataSet()
        Me.RejectBtn = New System.Windows.Forms.Button()
        Me.AcceptBtn = New System.Windows.Forms.Button()
        Me.PendingTableAdapter = New WindowsApp2.Database1DataSetTableAdapters.PendingTableAdapter()
        Me.TableAdapterManager = New WindowsApp2.Database1DataSetTableAdapters.TableAdapterManager()
        Me.PendingBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PendingBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PendingDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PendingPanel.SuspendLayout()
        CType(Me.PendingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PendingBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PendingBindingNavigator.SuspendLayout()
        CType(Me.PendingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PendingPanel
        '
        Me.PendingPanel.Controls.Add(Me.PendingDataGridView)
        Me.PendingPanel.Controls.Add(Me.RejectBtn)
        Me.PendingPanel.Controls.Add(Me.AcceptBtn)
        Me.PendingPanel.Location = New System.Drawing.Point(0, 28)
        Me.PendingPanel.Name = "PendingPanel"
        Me.PendingPanel.Size = New System.Drawing.Size(667, 278)
        Me.PendingPanel.TabIndex = 1
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
        'RejectBtn
        '
        Me.RejectBtn.Location = New System.Drawing.Point(272, 229)
        Me.RejectBtn.Name = "RejectBtn"
        Me.RejectBtn.Size = New System.Drawing.Size(89, 26)
        Me.RejectBtn.TabIndex = 0
        Me.RejectBtn.Text = "Reject"
        Me.RejectBtn.UseVisualStyleBackColor = True
        '
        'AcceptBtn
        '
        Me.AcceptBtn.Location = New System.Drawing.Point(167, 229)
        Me.AcceptBtn.Name = "AcceptBtn"
        Me.AcceptBtn.Size = New System.Drawing.Size(89, 26)
        Me.AcceptBtn.TabIndex = 0
        Me.AcceptBtn.Text = "Accept"
        Me.AcceptBtn.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.ScheduleTableAdapter = Nothing
        Me.TableAdapterManager.SloginTableAdapter = Nothing
        Me.TableAdapterManager.TableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp2.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PendingBindingNavigator
        '
        Me.PendingBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PendingBindingNavigator.BindingSource = Me.PendingBindingSource
        Me.PendingBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PendingBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PendingBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PendingBindingNavigatorSaveItem})
        Me.PendingBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PendingBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PendingBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PendingBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PendingBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PendingBindingNavigator.Name = "PendingBindingNavigator"
        Me.PendingBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PendingBindingNavigator.Size = New System.Drawing.Size(702, 25)
        Me.PendingBindingNavigator.TabIndex = 2
        Me.PendingBindingNavigator.Text = "BindingNavigator1"
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
        'PendingBindingNavigatorSaveItem
        '
        Me.PendingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PendingBindingNavigatorSaveItem.Image = CType(resources.GetObject("PendingBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PendingBindingNavigatorSaveItem.Name = "PendingBindingNavigatorSaveItem"
        Me.PendingBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PendingBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PendingDataGridView
        '
        Me.PendingDataGridView.AutoGenerateColumns = False
        Me.PendingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PendingDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.PendingDataGridView.DataSource = Me.PendingBindingSource
        Me.PendingDataGridView.Location = New System.Drawing.Point(12, 3)
        Me.PendingDataGridView.Name = "PendingDataGridView"
        Me.PendingDataGridView.Size = New System.Drawing.Size(628, 220)
        Me.PendingDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Student_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Student_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Schedule"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Schedule"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Appointment"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Appointment"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Faculty_ID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Faculty_ID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Pending
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 306)
        Me.Controls.Add(Me.PendingBindingNavigator)
        Me.Controls.Add(Me.PendingPanel)
        Me.Name = "Pending"
        Me.Text = "Pending"
        Me.PendingPanel.ResumeLayout(False)
        CType(Me.PendingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PendingBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PendingBindingNavigator.ResumeLayout(False)
        Me.PendingBindingNavigator.PerformLayout()
        CType(Me.PendingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PendingPanel As Panel
    Friend WithEvents RejectBtn As Button
    Friend WithEvents AcceptBtn As Button
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents PendingBindingSource As BindingSource
    Friend WithEvents PendingTableAdapter As Database1DataSetTableAdapters.PendingTableAdapter
    Friend WithEvents TableAdapterManager As Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents PendingBindingNavigator As BindingNavigator
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
    Friend WithEvents PendingBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PendingDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
