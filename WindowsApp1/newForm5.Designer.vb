<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newForm5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newForm5))
        Me.Person_TBBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Person_TBBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnGobackHome = New System.Windows.Forms.ToolStripButton()
        Me.Person_TBDataGridView = New System.Windows.Forms.DataGridView()
        Me.FillBy_P_IDToolStrip = New System.Windows.Forms.ToolStrip()
        Me.P_IDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.P_IDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBy_P_IDToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Person_TBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Contacts_DBDataSet = New WindowsApp1.Contacts_DBDataSet()
        Me.Person_TBTableAdapter = New WindowsApp1.Contacts_DBDataSetTableAdapters.Person_TBTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.Contacts_DBDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.Person_TBBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Person_TBBindingNavigator.SuspendLayout()
        CType(Me.Person_TBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy_P_IDToolStrip.SuspendLayout()
        CType(Me.Person_TBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contacts_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Person_TBBindingNavigator
        '
        Me.Person_TBBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Person_TBBindingNavigator.BindingSource = Me.Person_TBBindingSource
        Me.Person_TBBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Person_TBBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Person_TBBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Person_TBBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Person_TBBindingNavigatorSaveItem, Me.btnGobackHome})
        Me.Person_TBBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Person_TBBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Person_TBBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Person_TBBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Person_TBBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Person_TBBindingNavigator.Name = "Person_TBBindingNavigator"
        Me.Person_TBBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Person_TBBindingNavigator.Size = New System.Drawing.Size(1094, 27)
        Me.Person_TBBindingNavigator.TabIndex = 0
        Me.Person_TBBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(38, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'Person_TBBindingNavigatorSaveItem
        '
        Me.Person_TBBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Person_TBBindingNavigatorSaveItem.Image = CType(resources.GetObject("Person_TBBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Person_TBBindingNavigatorSaveItem.Name = "Person_TBBindingNavigatorSaveItem"
        Me.Person_TBBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.Person_TBBindingNavigatorSaveItem.Text = "Save Data"
        '
        'btnGobackHome
        '
        Me.btnGobackHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnGobackHome.Image = CType(resources.GetObject("btnGobackHome.Image"), System.Drawing.Image)
        Me.btnGobackHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGobackHome.Name = "btnGobackHome"
        Me.btnGobackHome.Size = New System.Drawing.Size(44, 24)
        Me.btnGobackHome.Text = "Home"
        '
        'Person_TBDataGridView
        '
        Me.Person_TBDataGridView.AutoGenerateColumns = False
        Me.Person_TBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Person_TBDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.Person_TBDataGridView.DataSource = Me.Person_TBBindingSource
        Me.Person_TBDataGridView.Location = New System.Drawing.Point(11, 67)
        Me.Person_TBDataGridView.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Person_TBDataGridView.Name = "Person_TBDataGridView"
        Me.Person_TBDataGridView.RowHeadersWidth = 51
        Me.Person_TBDataGridView.RowTemplate.Height = 24
        Me.Person_TBDataGridView.Size = New System.Drawing.Size(1070, 336)
        Me.Person_TBDataGridView.TabIndex = 1
        '
        'FillBy_P_IDToolStrip
        '
        Me.FillBy_P_IDToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillBy_P_IDToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.P_IDToolStripLabel, Me.P_IDToolStripTextBox, Me.FillBy_P_IDToolStripButton, Me.ToolStripButton1})
        Me.FillBy_P_IDToolStrip.Location = New System.Drawing.Point(0, 27)
        Me.FillBy_P_IDToolStrip.Name = "FillBy_P_IDToolStrip"
        Me.FillBy_P_IDToolStrip.Size = New System.Drawing.Size(1094, 25)
        Me.FillBy_P_IDToolStrip.TabIndex = 2
        Me.FillBy_P_IDToolStrip.Text = "FillBy_P_IDToolStrip"
        '
        'P_IDToolStripLabel
        '
        Me.P_IDToolStripLabel.Name = "P_IDToolStripLabel"
        Me.P_IDToolStripLabel.Size = New System.Drawing.Size(109, 22)
        Me.P_IDToolStripLabel.Text = "Enter ID to Search : "
        '
        'P_IDToolStripTextBox
        '
        Me.P_IDToolStripTextBox.Name = "P_IDToolStripTextBox"
        Me.P_IDToolStripTextBox.Size = New System.Drawing.Size(76, 25)
        '
        'FillBy_P_IDToolStripButton
        '
        Me.FillBy_P_IDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy_P_IDToolStripButton.Name = "FillBy_P_IDToolStripButton"
        Me.FillBy_P_IDToolStripButton.Size = New System.Drawing.Size(46, 22)
        Me.FillBy_P_IDToolStripButton.Text = "Search"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripButton1.Text = "View All"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "P_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "P_ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DateOfBirth"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DateOfBirth"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PhoneNumber"
        Me.DataGridViewTextBoxColumn7.HeaderText = "PhoneNumber"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'Person_TBBindingSource
        '
        Me.Person_TBBindingSource.DataMember = "Person_TB"
        Me.Person_TBBindingSource.DataSource = Me.Contacts_DBDataSet
        '
        'Contacts_DBDataSet
        '
        Me.Contacts_DBDataSet.DataSetName = "Contacts_DBDataSet"
        Me.Contacts_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Person_TBTableAdapter
        '
        Me.Person_TBTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Call_TBTableAdapter = Nothing
        Me.TableAdapterManager.Message_TBTableAdapter = Nothing
        Me.TableAdapterManager.Person_TBTableAdapter = Me.Person_TBTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.Contacts_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(11, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1071, 348)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "All Contacts"
        '
        'newForm5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 414)
        Me.Controls.Add(Me.FillBy_P_IDToolStrip)
        Me.Controls.Add(Me.Person_TBDataGridView)
        Me.Controls.Add(Me.Person_TBBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "newForm5"
        Me.Text = "newForm5"
        CType(Me.Person_TBBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Person_TBBindingNavigator.ResumeLayout(False)
        Me.Person_TBBindingNavigator.PerformLayout()
        CType(Me.Person_TBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy_P_IDToolStrip.ResumeLayout(False)
        Me.FillBy_P_IDToolStrip.PerformLayout()
        CType(Me.Person_TBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contacts_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Contacts_DBDataSet As Contacts_DBDataSet
    Friend WithEvents Person_TBBindingSource As BindingSource
    Friend WithEvents Person_TBTableAdapter As Contacts_DBDataSetTableAdapters.Person_TBTableAdapter
    Friend WithEvents TableAdapterManager As Contacts_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Person_TBBindingNavigator As BindingNavigator
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
    Friend WithEvents Person_TBBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Person_TBDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents btnGobackHome As ToolStripButton
    Friend WithEvents FillBy_P_IDToolStrip As ToolStrip
    Friend WithEvents P_IDToolStripLabel As ToolStripLabel
    Friend WithEvents P_IDToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillBy_P_IDToolStripButton As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
End Class
