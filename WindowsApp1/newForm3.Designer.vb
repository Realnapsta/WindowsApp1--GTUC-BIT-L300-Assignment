<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newForm3
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtDetails = New System.Windows.Forms.RichTextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDateOfBirth = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnReadMessage = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnNavigateLast = New System.Windows.Forms.Button()
        Me.btnNavigateFirst = New System.Windows.Forms.Button()
        Me.btnNavigatePrevious = New System.Windows.Forms.Button()
        Me.btnNavigateNext = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtLName)
        Me.GroupBox1.Controls.Add(Me.txtFName)
        Me.GroupBox1.Controls.Add(Me.txtDetails)
        Me.GroupBox1.Controls.Add(Me.txtPhoneNumber)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtDateOfBirth)
        Me.GroupBox1.Controls.Add(Me.txtGender)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 279)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contact Information"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(550, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Details"
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(289, 22)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(140, 22)
        Me.txtLName.TabIndex = 40
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(119, 23)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(146, 22)
        Me.txtFName.TabIndex = 39
        '
        'txtDetails
        '
        Me.txtDetails.Location = New System.Drawing.Point(553, 49)
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Size = New System.Drawing.Size(301, 224)
        Me.txtDetails.TabIndex = 38
        Me.txtDetails.Text = ""
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(119, 203)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(310, 22)
        Me.txtPhoneNumber.TabIndex = 35
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(119, 160)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(310, 22)
        Me.txtEmail.TabIndex = 34
        '
        'txtDateOfBirth
        '
        Me.txtDateOfBirth.Location = New System.Drawing.Point(118, 114)
        Me.txtDateOfBirth.Name = "txtDateOfBirth"
        Me.txtDateOfBirth.Size = New System.Drawing.Size(310, 22)
        Me.txtDateOfBirth.TabIndex = 33
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(119, 72)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(310, 22)
        Me.txtGender.TabIndex = 32
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(118, 249)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(310, 22)
        Me.txtAddress.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(43, 251)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 17)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(47, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Phone Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Date Of Birth"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Full Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 297)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(860, 257)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Messages"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.btnReadMessage})
        Me.DataGridView1.Location = New System.Drawing.Point(7, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(847, 230)
        Me.DataGridView1.TabIndex = 0
        '
        'btnReadMessage
        '
        Me.btnReadMessage.HeaderText = "Read Message"
        Me.btnReadMessage.MinimumWidth = 6
        Me.btnReadMessage.Name = "btnReadMessage"
        Me.btnReadMessage.Text = "View Messaage"
        Me.btnReadMessage.UseColumnTextForButtonValue = True
        Me.btnReadMessage.Width = 125
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnNavigateLast)
        Me.GroupBox3.Controls.Add(Me.btnNavigateFirst)
        Me.GroupBox3.Controls.Add(Me.btnNavigatePrevious)
        Me.GroupBox3.Controls.Add(Me.btnNavigateNext)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 571)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(698, 63)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Navigation"
        '
        'btnNavigateLast
        '
        Me.btnNavigateLast.Location = New System.Drawing.Point(289, 28)
        Me.btnNavigateLast.Name = "btnNavigateLast"
        Me.btnNavigateLast.Size = New System.Drawing.Size(62, 28)
        Me.btnNavigateLast.TabIndex = 17
        Me.btnNavigateLast.Text = ">>|"
        Me.btnNavigateLast.UseVisualStyleBackColor = True
        '
        'btnNavigateFirst
        '
        Me.btnNavigateFirst.Location = New System.Drawing.Point(16, 28)
        Me.btnNavigateFirst.Name = "btnNavigateFirst"
        Me.btnNavigateFirst.Size = New System.Drawing.Size(62, 28)
        Me.btnNavigateFirst.TabIndex = 16
        Me.btnNavigateFirst.Text = "|<<"
        Me.btnNavigateFirst.UseVisualStyleBackColor = True
        '
        'btnNavigatePrevious
        '
        Me.btnNavigatePrevious.Location = New System.Drawing.Point(101, 28)
        Me.btnNavigatePrevious.Name = "btnNavigatePrevious"
        Me.btnNavigatePrevious.Size = New System.Drawing.Size(62, 28)
        Me.btnNavigatePrevious.TabIndex = 15
        Me.btnNavigatePrevious.Text = "<"
        Me.btnNavigatePrevious.UseVisualStyleBackColor = True
        '
        'btnNavigateNext
        '
        Me.btnNavigateNext.Location = New System.Drawing.Point(194, 28)
        Me.btnNavigateNext.Name = "btnNavigateNext"
        Me.btnNavigateNext.Size = New System.Drawing.Size(62, 28)
        Me.btnNavigateNext.TabIndex = 14
        Me.btnNavigateNext.Text = ">"
        Me.btnNavigateNext.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(791, 599)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(81, 35)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'newForm3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 646)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "newForm3"
        Me.Text = "View Messages"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtDateOfBirth As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtDetails As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnNavigateLast As Button
    Friend WithEvents btnNavigateFirst As Button
    Friend WithEvents btnNavigatePrevious As Button
    Friend WithEvents btnNavigateNext As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnReadMessage As DataGridViewButtonColumn
End Class
