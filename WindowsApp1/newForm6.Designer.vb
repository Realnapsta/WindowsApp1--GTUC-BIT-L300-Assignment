<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newForm6
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
        Dim P_IDLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim DateOfBirthLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newForm6))
        Me.Contacts_DBDataSet = New WindowsApp1.Contacts_DBDataSet()
        Me.Person_TBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Person_TBTableAdapter = New WindowsApp1.Contacts_DBDataSetTableAdapters.Person_TBTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.Contacts_DBDataSetTableAdapters.TableAdapterManager()
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
        Me.P_IDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.DateOfBirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Call_TBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Call_TBTableAdapter = New WindowsApp1.Contacts_DBDataSetTableAdapters.Call_TBTableAdapter()
        Me.Call_TBDataGridView = New System.Windows.Forms.DataGridView()
        Me.ViewCall = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        P_IDLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        DateOfBirthLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        NotesLabel = New System.Windows.Forms.Label()
        CType(Me.Contacts_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Person_TBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Person_TBBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Person_TBBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Call_TBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Call_TBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P_IDLabel
        '
        P_IDLabel.AutoSize = True
        P_IDLabel.Location = New System.Drawing.Point(13, 22)
        P_IDLabel.Name = "P_IDLabel"
        P_IDLabel.Size = New System.Drawing.Size(31, 13)
        P_IDLabel.TabIndex = 1
        P_IDLabel.Text = "P ID:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(13, 48)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 3
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(13, 74)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 5
        LastNameLabel.Text = "Last Name:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(13, 100)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 7
        GenderLabel.Text = "Gender:"
        '
        'DateOfBirthLabel
        '
        DateOfBirthLabel.AutoSize = True
        DateOfBirthLabel.Location = New System.Drawing.Point(13, 127)
        DateOfBirthLabel.Name = "DateOfBirthLabel"
        DateOfBirthLabel.Size = New System.Drawing.Size(71, 13)
        DateOfBirthLabel.TabIndex = 9
        DateOfBirthLabel.Text = "Date Of Birth:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(13, 152)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 11
        EmailLabel.Text = "Email:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(13, 178)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(81, 13)
        PhoneNumberLabel.TabIndex = 13
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(13, 204)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 15
        AddressLabel.Text = "Address:"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Location = New System.Drawing.Point(402, 19)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(38, 13)
        NotesLabel.TabIndex = 17
        NotesLabel.Text = "Notes:"
        '
        'Contacts_DBDataSet
        '
        Me.Contacts_DBDataSet.DataSetName = "Contacts_DBDataSet"
        Me.Contacts_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Person_TBBindingSource
        '
        Me.Person_TBBindingSource.DataMember = "Person_TB"
        Me.Person_TBBindingSource.DataSource = Me.Contacts_DBDataSet
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
        'Person_TBBindingNavigator
        '
        Me.Person_TBBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Person_TBBindingNavigator.BindingSource = Me.Person_TBBindingSource
        Me.Person_TBBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Person_TBBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Person_TBBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Person_TBBindingNavigatorSaveItem})
        Me.Person_TBBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Person_TBBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Person_TBBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Person_TBBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Person_TBBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Person_TBBindingNavigator.Name = "Person_TBBindingNavigator"
        Me.Person_TBBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Person_TBBindingNavigator.Size = New System.Drawing.Size(651, 25)
        Me.Person_TBBindingNavigator.TabIndex = 0
        Me.Person_TBBindingNavigator.Text = "BindingNavigator1"
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
        'Person_TBBindingNavigatorSaveItem
        '
        Me.Person_TBBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Person_TBBindingNavigatorSaveItem.Image = CType(resources.GetObject("Person_TBBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Person_TBBindingNavigatorSaveItem.Name = "Person_TBBindingNavigatorSaveItem"
        Me.Person_TBBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Person_TBBindingNavigatorSaveItem.Text = "Save Data"
        '
        'P_IDTextBox
        '
        Me.P_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_TBBindingSource, "P_ID", True))
        Me.P_IDTextBox.Location = New System.Drawing.Point(100, 19)
        Me.P_IDTextBox.Name = "P_IDTextBox"
        Me.P_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.P_IDTextBox.TabIndex = 2
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_TBBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(100, 45)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FirstNameTextBox.TabIndex = 4
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_TBBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(100, 71)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LastNameTextBox.TabIndex = 6
        '
        'GenderTextBox
        '
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_TBBindingSource, "Gender", True))
        Me.GenderTextBox.Location = New System.Drawing.Point(100, 97)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(200, 20)
        Me.GenderTextBox.TabIndex = 8
        '
        'DateOfBirthDateTimePicker
        '
        Me.DateOfBirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Person_TBBindingSource, "DateOfBirth", True))
        Me.DateOfBirthDateTimePicker.Location = New System.Drawing.Point(100, 123)
        Me.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker"
        Me.DateOfBirthDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateOfBirthDateTimePicker.TabIndex = 10
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_TBBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(100, 149)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 12
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_TBBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(100, 175)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PhoneNumberTextBox.TabIndex = 14
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_TBBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(100, 201)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AddressTextBox.TabIndex = 16
        '
        'NotesTextBox
        '
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Person_TBBindingSource, "Notes", True))
        Me.NotesTextBox.Location = New System.Drawing.Point(390, 35)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(233, 182)
        Me.NotesTextBox.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(P_IDLabel)
        Me.GroupBox1.Controls.Add(Me.P_IDTextBox)
        Me.GroupBox1.Controls.Add(Me.NotesTextBox)
        Me.GroupBox1.Controls.Add(FirstNameLabel)
        Me.GroupBox1.Controls.Add(NotesLabel)
        Me.GroupBox1.Controls.Add(Me.FirstNameTextBox)
        Me.GroupBox1.Controls.Add(Me.AddressTextBox)
        Me.GroupBox1.Controls.Add(LastNameLabel)
        Me.GroupBox1.Controls.Add(AddressLabel)
        Me.GroupBox1.Controls.Add(Me.LastNameTextBox)
        Me.GroupBox1.Controls.Add(Me.PhoneNumberTextBox)
        Me.GroupBox1.Controls.Add(GenderLabel)
        Me.GroupBox1.Controls.Add(PhoneNumberLabel)
        Me.GroupBox1.Controls.Add(Me.GenderTextBox)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(DateOfBirthLabel)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(Me.DateOfBirthDateTimePicker)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(629, 234)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contact"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Call_TBDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 268)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(629, 264)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Calls"
        '
        'Call_TBBindingSource
        '
        Me.Call_TBBindingSource.DataMember = "FK_Person_TB_Call_TB"
        Me.Call_TBBindingSource.DataSource = Me.Person_TBBindingSource
        '
        'Call_TBTableAdapter
        '
        Me.Call_TBTableAdapter.ClearBeforeFill = True
        '
        'Call_TBDataGridView
        '
        Me.Call_TBDataGridView.AutoGenerateColumns = False
        Me.Call_TBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Call_TBDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ViewCall, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Call_TBDataGridView.DataSource = Me.Call_TBBindingSource
        Me.Call_TBDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.Call_TBDataGridView.Name = "Call_TBDataGridView"
        Me.Call_TBDataGridView.Size = New System.Drawing.Size(617, 220)
        Me.Call_TBDataGridView.TabIndex = 0
        '
        'ViewCall
        '
        Me.ViewCall.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ViewCall.HeaderText = "ViewCall"
        Me.ViewCall.Name = "ViewCall"
        Me.ViewCall.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ViewCall.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ViewCall.Text = "View Details"
        Me.ViewCall.UseColumnTextForButtonValue = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "C_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "C_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Caller_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Caller_ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "StatdTime"
        Me.DataGridViewTextBoxColumn3.HeaderText = "StatdTime"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "EndTime"
        Me.DataGridViewTextBoxColumn4.HeaderText = "EndTime"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CallDate"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CallDate"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'newForm6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 517)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Person_TBBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "newForm6"
        Me.Text = "newForm6"
        CType(Me.Contacts_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Person_TBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Person_TBBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Person_TBBindingNavigator.ResumeLayout(False)
        Me.Person_TBBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Call_TBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Call_TBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents P_IDTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents GenderTextBox As TextBox
    Friend WithEvents DateOfBirthDateTimePicker As DateTimePicker
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents NotesTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Call_TBBindingSource As BindingSource
    Friend WithEvents Call_TBTableAdapter As Contacts_DBDataSetTableAdapters.Call_TBTableAdapter
    Friend WithEvents Call_TBDataGridView As DataGridView
    Friend WithEvents ViewCall As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
