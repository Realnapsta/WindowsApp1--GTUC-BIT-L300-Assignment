<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newForm4
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSender = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtMID = New System.Windows.Forms.TextBox()
        Me.txtContent = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Message ID"
        '
        'txtSender
        '
        Me.txtSender.Location = New System.Drawing.Point(140, 79)
        Me.txtSender.Name = "txtSender"
        Me.txtSender.Size = New System.Drawing.Size(224, 22)
        Me.txtSender.TabIndex = 3
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(140, 230)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(224, 22)
        Me.txtDate.TabIndex = 4
        '
        'txtMID
        '
        Me.txtMID.Location = New System.Drawing.Point(140, 153)
        Me.txtMID.Name = "txtMID"
        Me.txtMID.Size = New System.Drawing.Size(224, 22)
        Me.txtMID.TabIndex = 5
        '
        'txtContent
        '
        Me.txtContent.Location = New System.Drawing.Point(50, 311)
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(360, 190)
        Me.txtContent.TabIndex = 6
        Me.txtContent.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Message Content"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(335, 521)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'newForm4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 559)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtContent)
        Me.Controls.Add(Me.txtMID)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtSender)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "newForm4"
        Me.Text = "Message Viewer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSender As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtMID As TextBox
    Friend WithEvents txtContent As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnExit As Button
End Class
