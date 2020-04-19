<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtGender = New System.Windows.Forms.ComboBox()
        Me.txtDateofBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnViewDetails = New System.Windows.Forms.Button()
        Me.btnViewPersons = New System.Windows.Forms.Button()
        Me.btnMessageViewer = New System.Windows.Forms.Button()
        Me.btnViewMessage = New System.Windows.Forms.Button()
        Me.btnViewAll = New System.Windows.Forms.Button()
        Me.btnNavigateLast = New System.Windows.Forms.Button()
        Me.btnNavigateFirst = New System.Windows.Forms.Button()
        Me.btnNavigatePrevious = New System.Windows.Forms.Button()
        Me.btnNavigateNext = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.RichTextBox()
        Me.btnViewMessages = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtGender)
        Me.GroupBox1.Controls.Add(Me.txtDateofBirth)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtSName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.txtFName)
        Me.GroupBox1.Controls.Add(Me.txtPhone)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 30)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(326, 224)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contact"
        '
        'txtGender
        '
        Me.txtGender.FormattingEnabled = True
        Me.txtGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.txtGender.Location = New System.Drawing.Point(87, 63)
        Me.txtGender.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(234, 21)
        Me.txtGender.TabIndex = 27
        '
        'txtDateofBirth
        '
        Me.txtDateofBirth.Location = New System.Drawing.Point(87, 95)
        Me.txtDateofBirth.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDateofBirth.Name = "txtDateofBirth"
        Me.txtDateofBirth.Size = New System.Drawing.Size(234, 20)
        Me.txtDateofBirth.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 95)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "DateofBirth"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 40)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "LastName"
        '
        'txtSName
        '
        Me.txtSName.Location = New System.Drawing.Point(87, 40)
        Me.txtSName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSName.Name = "txtSName"
        Me.txtSName.Size = New System.Drawing.Size(234, 20)
        Me.txtSName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 128)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(87, 128)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(234, 20)
        Me.txtEmail.TabIndex = 5
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(87, 190)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(234, 20)
        Me.txtAddress.TabIndex = 7
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(87, 14)
        Me.txtFName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(234, 20)
        Me.txtFName.TabIndex = 1
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(87, 158)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(234, 20)
        Me.txtPhone.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(38, 190)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(154, 242)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 47)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 158)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Phone Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 194)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Gender"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FirstName"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnCancel)
        Me.GroupBox2.Controls.Add(Me.btnCommit)
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Controls.Add(Me.btnAddNew)
        Me.GroupBox2.Location = New System.Drawing.Point(408, 272)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(250, 97)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Action"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(168, 43)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(62, 20)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(100, 65)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(65, 24)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnCommit
        '
        Me.btnCommit.Enabled = False
        Me.btnCommit.Location = New System.Drawing.Point(168, 17)
        Me.btnCommit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(62, 21)
        Me.btnCommit.TabIndex = 4
        Me.btnCommit.Text = "Commit"
        Me.btnCommit.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(32, 43)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(62, 20)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(32, 17)
        Me.btnAddNew.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(62, 21)
        Me.btnAddNew.TabIndex = 2
        Me.btnAddNew.Text = "Add"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnViewMessages)
        Me.GroupBox3.Controls.Add(Me.btnViewDetails)
        Me.GroupBox3.Controls.Add(Me.btnViewPersons)
        Me.GroupBox3.Controls.Add(Me.btnMessageViewer)
        Me.GroupBox3.Controls.Add(Me.btnViewMessage)
        Me.GroupBox3.Controls.Add(Me.btnViewAll)
        Me.GroupBox3.Controls.Add(Me.btnNavigateLast)
        Me.GroupBox3.Controls.Add(Me.btnNavigateFirst)
        Me.GroupBox3.Controls.Add(Me.btnNavigatePrevious)
        Me.GroupBox3.Controls.Add(Me.btnNavigateNext)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 272)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(304, 143)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Navigation"
        '
        'btnViewDetails
        '
        Me.btnViewDetails.Location = New System.Drawing.Point(104, 93)
        Me.btnViewDetails.Margin = New System.Windows.Forms.Padding(2)
        Me.btnViewDetails.Name = "btnViewDetails"
        Me.btnViewDetails.Size = New System.Drawing.Size(90, 28)
        Me.btnViewDetails.TabIndex = 17
        Me.btnViewDetails.Text = "newform6"
        Me.btnViewDetails.UseVisualStyleBackColor = True
        '
        'btnViewPersons
        '
        Me.btnViewPersons.Location = New System.Drawing.Point(7, 93)
        Me.btnViewPersons.Margin = New System.Windows.Forms.Padding(2)
        Me.btnViewPersons.Name = "btnViewPersons"
        Me.btnViewPersons.Size = New System.Drawing.Size(90, 28)
        Me.btnViewPersons.TabIndex = 16
        Me.btnViewPersons.Text = "newform5"
        Me.btnViewPersons.UseVisualStyleBackColor = True
        '
        'btnMessageViewer
        '
        Me.btnMessageViewer.Location = New System.Drawing.Point(209, 60)
        Me.btnMessageViewer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMessageViewer.Name = "btnMessageViewer"
        Me.btnMessageViewer.Size = New System.Drawing.Size(90, 28)
        Me.btnMessageViewer.TabIndex = 15
        Me.btnMessageViewer.Text = "View Messages"
        Me.btnMessageViewer.UseVisualStyleBackColor = True
        '
        'btnViewMessage
        '
        Me.btnViewMessage.Location = New System.Drawing.Point(112, 60)
        Me.btnViewMessage.Margin = New System.Windows.Forms.Padding(2)
        Me.btnViewMessage.Name = "btnViewMessage"
        Me.btnViewMessage.Size = New System.Drawing.Size(82, 28)
        Me.btnViewMessage.TabIndex = 14
        Me.btnViewMessage.Text = "Message list"
        Me.btnViewMessage.UseVisualStyleBackColor = True
        '
        'btnViewAll
        '
        Me.btnViewAll.Location = New System.Drawing.Point(7, 60)
        Me.btnViewAll.Margin = New System.Windows.Forms.Padding(2)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(90, 28)
        Me.btnViewAll.TabIndex = 7
        Me.btnViewAll.Text = "View Contacts"
        Me.btnViewAll.UseVisualStyleBackColor = True
        '
        'btnNavigateLast
        '
        Me.btnNavigateLast.Location = New System.Drawing.Point(228, 32)
        Me.btnNavigateLast.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNavigateLast.Name = "btnNavigateLast"
        Me.btnNavigateLast.Size = New System.Drawing.Size(46, 23)
        Me.btnNavigateLast.TabIndex = 13
        Me.btnNavigateLast.Text = ">>|"
        Me.btnNavigateLast.UseVisualStyleBackColor = True
        '
        'btnNavigateFirst
        '
        Me.btnNavigateFirst.Location = New System.Drawing.Point(23, 32)
        Me.btnNavigateFirst.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNavigateFirst.Name = "btnNavigateFirst"
        Me.btnNavigateFirst.Size = New System.Drawing.Size(46, 23)
        Me.btnNavigateFirst.TabIndex = 12
        Me.btnNavigateFirst.Text = "|<<"
        Me.btnNavigateFirst.UseVisualStyleBackColor = True
        '
        'btnNavigatePrevious
        '
        Me.btnNavigatePrevious.Location = New System.Drawing.Point(87, 32)
        Me.btnNavigatePrevious.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNavigatePrevious.Name = "btnNavigatePrevious"
        Me.btnNavigatePrevious.Size = New System.Drawing.Size(46, 23)
        Me.btnNavigatePrevious.TabIndex = 11
        Me.btnNavigatePrevious.Text = "<"
        Me.btnNavigatePrevious.UseVisualStyleBackColor = True
        '
        'btnNavigateNext
        '
        Me.btnNavigateNext.Location = New System.Drawing.Point(157, 32)
        Me.btnNavigateNext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNavigateNext.Name = "btnNavigateNext"
        Me.btnNavigateNext.Size = New System.Drawing.Size(46, 23)
        Me.btnNavigateNext.TabIndex = 10
        Me.btnNavigateNext.Text = ">"
        Me.btnNavigateNext.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(406, 30)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Pick to Search ID"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(497, 28)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(162, 21)
        Me.ComboBox1.TabIndex = 22
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.SearchToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(676, 24)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Enabled = False
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label10.Location = New System.Drawing.Point(522, 63)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 15)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Note"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(408, 80)
        Me.txtNotes.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(252, 188)
        Me.txtNotes.TabIndex = 8
        Me.txtNotes.Text = ""
        '
        'btnViewMessages
        '
        Me.btnViewMessages.Location = New System.Drawing.Point(209, 92)
        Me.btnViewMessages.Margin = New System.Windows.Forms.Padding(2)
        Me.btnViewMessages.Name = "btnViewMessages"
        Me.btnViewMessages.Size = New System.Drawing.Size(90, 28)
        Me.btnViewMessages.TabIndex = 18
        Me.btnViewMessages.Text = "newform8"
        Me.btnViewMessages.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 457)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Contact Application - Home"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnCommit As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnNavigateNext As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtSName As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNotes As RichTextBox
    Friend WithEvents btnNavigateFirst As Button
    Friend WithEvents btnNavigatePrevious As Button
    Friend WithEvents btnNavigateLast As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnViewAll As Button
    Friend WithEvents btnViewMessage As Button
    Friend WithEvents btnMessageViewer As Button
    Friend WithEvents btnViewPersons As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtDateofBirth As DateTimePicker
    Friend WithEvents txtGender As ComboBox
    Friend WithEvents btnViewDetails As Button
    Friend WithEvents btnViewMessages As Button
End Class
