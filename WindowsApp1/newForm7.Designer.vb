<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newForm7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newForm7))
        Dim C_IDLabel As System.Windows.Forms.Label
        Dim Caller_IDLabel As System.Windows.Forms.Label
        Dim StatdTimeLabel As System.Windows.Forms.Label
        Dim EndTimeLabel As System.Windows.Forms.Label
        Dim CallDateLabel As System.Windows.Forms.Label
        Me.Contacts_DBDataSet = New WindowsApp1.Contacts_DBDataSet()
        Me.Call_TBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Call_TBTableAdapter = New WindowsApp1.Contacts_DBDataSetTableAdapters.Call_TBTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.Contacts_DBDataSetTableAdapters.TableAdapterManager()
        Me.Call_TBBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Call_TBBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.C_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Caller_IDTextBox = New System.Windows.Forms.TextBox()
        Me.StatdTimeTextBox = New System.Windows.Forms.TextBox()
        Me.EndTimeTextBox = New System.Windows.Forms.TextBox()
        Me.CallDateTextBox = New System.Windows.Forms.TextBox()
        C_IDLabel = New System.Windows.Forms.Label()
        Caller_IDLabel = New System.Windows.Forms.Label()
        StatdTimeLabel = New System.Windows.Forms.Label()
        EndTimeLabel = New System.Windows.Forms.Label()
        CallDateLabel = New System.Windows.Forms.Label()
        CType(Me.Contacts_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Call_TBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Call_TBBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Call_TBBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Contacts_DBDataSet
        '
        Me.Contacts_DBDataSet.DataSetName = "Contacts_DBDataSet"
        Me.Contacts_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Call_TBBindingSource
        '
        Me.Call_TBBindingSource.DataMember = "Call_TB"
        Me.Call_TBBindingSource.DataSource = Me.Contacts_DBDataSet
        '
        'Call_TBTableAdapter
        '
        Me.Call_TBTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Call_TBTableAdapter = Me.Call_TBTableAdapter
        Me.TableAdapterManager.Message_TBTableAdapter = Nothing
        Me.TableAdapterManager.Person_TBTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.Contacts_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Call_TBBindingNavigator
        '
        Me.Call_TBBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Call_TBBindingNavigator.BindingSource = Me.Call_TBBindingSource
        Me.Call_TBBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Call_TBBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Call_TBBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Call_TBBindingNavigatorSaveItem})
        Me.Call_TBBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Call_TBBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Call_TBBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Call_TBBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Call_TBBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Call_TBBindingNavigator.Name = "Call_TBBindingNavigator"
        Me.Call_TBBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Call_TBBindingNavigator.Size = New System.Drawing.Size(360, 25)
        Me.Call_TBBindingNavigator.TabIndex = 0
        Me.Call_TBBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Call_TBBindingNavigatorSaveItem
        '
        Me.Call_TBBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Call_TBBindingNavigatorSaveItem.Image = CType(resources.GetObject("Call_TBBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Call_TBBindingNavigatorSaveItem.Name = "Call_TBBindingNavigatorSaveItem"
        Me.Call_TBBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Call_TBBindingNavigatorSaveItem.Text = "Save Data"
        '
        'C_IDLabel
        '
        C_IDLabel.AutoSize = True
        C_IDLabel.Location = New System.Drawing.Point(12, 39)
        C_IDLabel.Name = "C_IDLabel"
        C_IDLabel.Size = New System.Drawing.Size(31, 13)
        C_IDLabel.TabIndex = 1
        C_IDLabel.Text = "C ID:"
        '
        'C_IDTextBox
        '
        Me.C_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Call_TBBindingSource, "C_ID", True))
        Me.C_IDTextBox.Location = New System.Drawing.Point(79, 36)
        Me.C_IDTextBox.Name = "C_IDTextBox"
        Me.C_IDTextBox.Size = New System.Drawing.Size(260, 20)
        Me.C_IDTextBox.TabIndex = 2
        '
        'Caller_IDLabel
        '
        Caller_IDLabel.AutoSize = True
        Caller_IDLabel.Location = New System.Drawing.Point(12, 65)
        Caller_IDLabel.Name = "Caller_IDLabel"
        Caller_IDLabel.Size = New System.Drawing.Size(50, 13)
        Caller_IDLabel.TabIndex = 3
        Caller_IDLabel.Text = "Caller ID:"
        '
        'Caller_IDTextBox
        '
        Me.Caller_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Call_TBBindingSource, "Caller_ID", True))
        Me.Caller_IDTextBox.Location = New System.Drawing.Point(79, 62)
        Me.Caller_IDTextBox.Name = "Caller_IDTextBox"
        Me.Caller_IDTextBox.Size = New System.Drawing.Size(260, 20)
        Me.Caller_IDTextBox.TabIndex = 4
        '
        'StatdTimeLabel
        '
        StatdTimeLabel.AutoSize = True
        StatdTimeLabel.Location = New System.Drawing.Point(12, 91)
        StatdTimeLabel.Name = "StatdTimeLabel"
        StatdTimeLabel.Size = New System.Drawing.Size(61, 13)
        StatdTimeLabel.TabIndex = 5
        StatdTimeLabel.Text = "Statd Time:"
        '
        'StatdTimeTextBox
        '
        Me.StatdTimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Call_TBBindingSource, "StatdTime", True))
        Me.StatdTimeTextBox.Location = New System.Drawing.Point(79, 88)
        Me.StatdTimeTextBox.Name = "StatdTimeTextBox"
        Me.StatdTimeTextBox.Size = New System.Drawing.Size(260, 20)
        Me.StatdTimeTextBox.TabIndex = 6
        '
        'EndTimeLabel
        '
        EndTimeLabel.AutoSize = True
        EndTimeLabel.Location = New System.Drawing.Point(12, 117)
        EndTimeLabel.Name = "EndTimeLabel"
        EndTimeLabel.Size = New System.Drawing.Size(55, 13)
        EndTimeLabel.TabIndex = 7
        EndTimeLabel.Text = "End Time:"
        '
        'EndTimeTextBox
        '
        Me.EndTimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Call_TBBindingSource, "EndTime", True))
        Me.EndTimeTextBox.Location = New System.Drawing.Point(79, 114)
        Me.EndTimeTextBox.Name = "EndTimeTextBox"
        Me.EndTimeTextBox.Size = New System.Drawing.Size(260, 20)
        Me.EndTimeTextBox.TabIndex = 8
        '
        'CallDateLabel
        '
        CallDateLabel.AutoSize = True
        CallDateLabel.Location = New System.Drawing.Point(12, 143)
        CallDateLabel.Name = "CallDateLabel"
        CallDateLabel.Size = New System.Drawing.Size(53, 13)
        CallDateLabel.TabIndex = 9
        CallDateLabel.Text = "Call Date:"
        '
        'CallDateTextBox
        '
        Me.CallDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Call_TBBindingSource, "CallDate", True))
        Me.CallDateTextBox.Location = New System.Drawing.Point(79, 140)
        Me.CallDateTextBox.Name = "CallDateTextBox"
        Me.CallDateTextBox.Size = New System.Drawing.Size(260, 20)
        Me.CallDateTextBox.TabIndex = 10
        '
        'newForm7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 188)
        Me.Controls.Add(C_IDLabel)
        Me.Controls.Add(Me.C_IDTextBox)
        Me.Controls.Add(Caller_IDLabel)
        Me.Controls.Add(Me.Caller_IDTextBox)
        Me.Controls.Add(StatdTimeLabel)
        Me.Controls.Add(Me.StatdTimeTextBox)
        Me.Controls.Add(EndTimeLabel)
        Me.Controls.Add(Me.EndTimeTextBox)
        Me.Controls.Add(CallDateLabel)
        Me.Controls.Add(Me.CallDateTextBox)
        Me.Controls.Add(Me.Call_TBBindingNavigator)
        Me.Name = "newForm7"
        Me.Text = "newForm7"
        CType(Me.Contacts_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Call_TBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Call_TBBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Call_TBBindingNavigator.ResumeLayout(False)
        Me.Call_TBBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Contacts_DBDataSet As Contacts_DBDataSet
    Friend WithEvents Call_TBBindingSource As BindingSource
    Friend WithEvents Call_TBTableAdapter As Contacts_DBDataSetTableAdapters.Call_TBTableAdapter
    Friend WithEvents TableAdapterManager As Contacts_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Call_TBBindingNavigator As BindingNavigator
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
    Friend WithEvents Call_TBBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents C_IDTextBox As TextBox
    Friend WithEvents Caller_IDTextBox As TextBox
    Friend WithEvents StatdTimeTextBox As TextBox
    Friend WithEvents EndTimeTextBox As TextBox
    Friend WithEvents CallDateTextBox As TextBox
End Class
