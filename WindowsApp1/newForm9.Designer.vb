<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newForm9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newForm9))
        Dim M_IDLabel As System.Windows.Forms.Label
        Dim Sender_IDLabel As System.Windows.Forms.Label
        Dim SendDateLabel As System.Windows.Forms.Label
        Dim M_ContentLabel As System.Windows.Forms.Label
        Me.Contacts_DBDataSet = New WindowsApp1.Contacts_DBDataSet()
        Me.Message_TBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Message_TBTableAdapter = New WindowsApp1.Contacts_DBDataSetTableAdapters.Message_TBTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.Contacts_DBDataSetTableAdapters.TableAdapterManager()
        Me.Message_TBBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Message_TBBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.M_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Sender_IDTextBox = New System.Windows.Forms.TextBox()
        Me.SendDateTextBox = New System.Windows.Forms.TextBox()
        Me.M_ContentTextBox = New System.Windows.Forms.TextBox()
        M_IDLabel = New System.Windows.Forms.Label()
        Sender_IDLabel = New System.Windows.Forms.Label()
        SendDateLabel = New System.Windows.Forms.Label()
        M_ContentLabel = New System.Windows.Forms.Label()
        CType(Me.Contacts_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Message_TBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Message_TBBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Message_TBBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Contacts_DBDataSet
        '
        Me.Contacts_DBDataSet.DataSetName = "Contacts_DBDataSet"
        Me.Contacts_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Message_TBBindingSource
        '
        Me.Message_TBBindingSource.DataMember = "Message_TB"
        Me.Message_TBBindingSource.DataSource = Me.Contacts_DBDataSet
        '
        'Message_TBTableAdapter
        '
        Me.Message_TBTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Call_TBTableAdapter = Nothing
        Me.TableAdapterManager.Message_TBTableAdapter = Me.Message_TBTableAdapter
        Me.TableAdapterManager.Person_TBTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.Contacts_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Message_TBBindingNavigator
        '
        Me.Message_TBBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Message_TBBindingNavigator.BindingSource = Me.Message_TBBindingSource
        Me.Message_TBBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Message_TBBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Message_TBBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Message_TBBindingNavigatorSaveItem})
        Me.Message_TBBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Message_TBBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Message_TBBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Message_TBBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Message_TBBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Message_TBBindingNavigator.Name = "Message_TBBindingNavigator"
        Me.Message_TBBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Message_TBBindingNavigator.Size = New System.Drawing.Size(328, 25)
        Me.Message_TBBindingNavigator.TabIndex = 0
        Me.Message_TBBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Message_TBBindingNavigatorSaveItem
        '
        Me.Message_TBBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Message_TBBindingNavigatorSaveItem.Image = CType(resources.GetObject("Message_TBBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Message_TBBindingNavigatorSaveItem.Name = "Message_TBBindingNavigatorSaveItem"
        Me.Message_TBBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Message_TBBindingNavigatorSaveItem.Text = "Save Data"
        '
        'M_IDLabel
        '
        M_IDLabel.AutoSize = True
        M_IDLabel.Location = New System.Drawing.Point(12, 44)
        M_IDLabel.Name = "M_IDLabel"
        M_IDLabel.Size = New System.Drawing.Size(33, 13)
        M_IDLabel.TabIndex = 1
        M_IDLabel.Text = "M ID:"
        '
        'M_IDTextBox
        '
        Me.M_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Message_TBBindingSource, "M_ID", True))
        Me.M_IDTextBox.Location = New System.Drawing.Point(79, 41)
        Me.M_IDTextBox.Name = "M_IDTextBox"
        Me.M_IDTextBox.Size = New System.Drawing.Size(235, 20)
        Me.M_IDTextBox.TabIndex = 2
        '
        'Sender_IDLabel
        '
        Sender_IDLabel.AutoSize = True
        Sender_IDLabel.Location = New System.Drawing.Point(12, 70)
        Sender_IDLabel.Name = "Sender_IDLabel"
        Sender_IDLabel.Size = New System.Drawing.Size(58, 13)
        Sender_IDLabel.TabIndex = 3
        Sender_IDLabel.Text = "Sender ID:"
        '
        'Sender_IDTextBox
        '
        Me.Sender_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Message_TBBindingSource, "Sender_ID", True))
        Me.Sender_IDTextBox.Location = New System.Drawing.Point(79, 67)
        Me.Sender_IDTextBox.Name = "Sender_IDTextBox"
        Me.Sender_IDTextBox.Size = New System.Drawing.Size(235, 20)
        Me.Sender_IDTextBox.TabIndex = 4
        '
        'SendDateLabel
        '
        SendDateLabel.AutoSize = True
        SendDateLabel.Location = New System.Drawing.Point(12, 96)
        SendDateLabel.Name = "SendDateLabel"
        SendDateLabel.Size = New System.Drawing.Size(61, 13)
        SendDateLabel.TabIndex = 5
        SendDateLabel.Text = "Send Date:"
        '
        'SendDateTextBox
        '
        Me.SendDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Message_TBBindingSource, "SendDate", True))
        Me.SendDateTextBox.Location = New System.Drawing.Point(79, 93)
        Me.SendDateTextBox.Name = "SendDateTextBox"
        Me.SendDateTextBox.Size = New System.Drawing.Size(235, 20)
        Me.SendDateTextBox.TabIndex = 6
        '
        'M_ContentLabel
        '
        M_ContentLabel.AutoSize = True
        M_ContentLabel.Location = New System.Drawing.Point(12, 122)
        M_ContentLabel.Name = "M_ContentLabel"
        M_ContentLabel.Size = New System.Drawing.Size(59, 13)
        M_ContentLabel.TabIndex = 7
        M_ContentLabel.Text = "M Content:"
        '
        'M_ContentTextBox
        '
        Me.M_ContentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Message_TBBindingSource, "M_Content", True))
        Me.M_ContentTextBox.Location = New System.Drawing.Point(79, 119)
        Me.M_ContentTextBox.Name = "M_ContentTextBox"
        Me.M_ContentTextBox.Size = New System.Drawing.Size(235, 20)
        Me.M_ContentTextBox.TabIndex = 8
        '
        'newForm9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 160)
        Me.Controls.Add(M_IDLabel)
        Me.Controls.Add(Me.M_IDTextBox)
        Me.Controls.Add(Sender_IDLabel)
        Me.Controls.Add(Me.Sender_IDTextBox)
        Me.Controls.Add(SendDateLabel)
        Me.Controls.Add(Me.SendDateTextBox)
        Me.Controls.Add(M_ContentLabel)
        Me.Controls.Add(Me.M_ContentTextBox)
        Me.Controls.Add(Me.Message_TBBindingNavigator)
        Me.Name = "newForm9"
        Me.Text = "newForm9"
        CType(Me.Contacts_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Message_TBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Message_TBBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Message_TBBindingNavigator.ResumeLayout(False)
        Me.Message_TBBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Contacts_DBDataSet As Contacts_DBDataSet
    Friend WithEvents Message_TBBindingSource As BindingSource
    Friend WithEvents Message_TBTableAdapter As Contacts_DBDataSetTableAdapters.Message_TBTableAdapter
    Friend WithEvents TableAdapterManager As Contacts_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Message_TBBindingNavigator As BindingNavigator
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
    Friend WithEvents Message_TBBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents M_IDTextBox As TextBox
    Friend WithEvents Sender_IDTextBox As TextBox
    Friend WithEvents SendDateTextBox As TextBox
    Friend WithEvents M_ContentTextBox As TextBox
End Class
