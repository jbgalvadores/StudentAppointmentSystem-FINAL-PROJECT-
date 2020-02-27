<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Schedule
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
        Me.SchedulePanel = New System.Windows.Forms.Panel()
        Me.ScheduleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScheduleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New WindowsApp2.Database1DataSet()
        Me.ScheduleTableAdapter = New WindowsApp2.Database1DataSetTableAdapters.ScheduleTableAdapter()
        Me.TableAdapterManager = New WindowsApp2.Database1DataSetTableAdapters.TableAdapterManager()
        Me.SchedulePanel.SuspendLayout()
        CType(Me.ScheduleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScheduleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SchedulePanel
        '
        Me.SchedulePanel.Controls.Add(Me.ScheduleDataGridView)
        Me.SchedulePanel.Location = New System.Drawing.Point(12, 12)
        Me.SchedulePanel.Name = "SchedulePanel"
        Me.SchedulePanel.Size = New System.Drawing.Size(649, 231)
        Me.SchedulePanel.TabIndex = 3
        '
        'ScheduleDataGridView
        '
        Me.ScheduleDataGridView.AutoGenerateColumns = False
        Me.ScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ScheduleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.ScheduleDataGridView.DataSource = Me.ScheduleBindingSource
        Me.ScheduleDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ScheduleDataGridView.Name = "ScheduleDataGridView"
        Me.ScheduleDataGridView.Size = New System.Drawing.Size(641, 220)
        Me.ScheduleDataGridView.TabIndex = 0
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
        'ScheduleBindingSource
        '
        Me.ScheduleBindingSource.DataMember = "Schedule"
        Me.ScheduleBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ScheduleTableAdapter
        '
        Me.ScheduleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FloginTableAdapter = Nothing
        Me.TableAdapterManager.HistoryTableAdapter = Nothing
        Me.TableAdapterManager.PendingTableAdapter = Nothing
        Me.TableAdapterManager.ScheduleTableAdapter = Me.ScheduleTableAdapter
        Me.TableAdapterManager.SloginTableAdapter = Nothing
        Me.TableAdapterManager.TableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp2.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Schedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 245)
        Me.Controls.Add(Me.SchedulePanel)
        Me.Name = "Schedule"
        Me.Text = "Schedule"
        Me.SchedulePanel.ResumeLayout(False)
        CType(Me.ScheduleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScheduleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SchedulePanel As Panel
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents ScheduleBindingSource As BindingSource
    Friend WithEvents ScheduleTableAdapter As Database1DataSetTableAdapters.ScheduleTableAdapter
    Friend WithEvents TableAdapterManager As Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ScheduleDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
