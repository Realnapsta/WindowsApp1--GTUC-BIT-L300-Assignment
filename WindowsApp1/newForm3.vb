Imports System.Data.SqlClient

Public Class newForm3

    Dim con As New SqlConnection
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter
    Dim daPerson As New SqlDataAdapter
    Dim daMessage As New SqlDataAdapter
    Dim sql As String
    Dim conString As String
    Dim inc As Integer
    Dim maxrows As Integer
    Dim dsNewRow As DataRow
    Dim PersonBS As New BindingSource()
    Dim MessageBS As New BindingSource()
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 0 Then
            ' View Line Items button clicked
            ' Get the ID of the selected Message
            Dim i As Integer = e.RowIndex
            Dim row As DataGridViewRow = DataGridView1.Rows(i)
            Dim cell As DataGridViewCell = row.Cells(1)
            Dim MessageID As String = cell.Value
            ' Display the newForm3 form
            Dim messageForm As New newForm3
            messageForm.Tag = MessageID
            messageForm.ShowDialog()
        End If
    End Sub

    Private Sub secondNavigateRecords()
        txtFName.DataBindings.Add("Text", PersonBS, "FirstName")
        txtLName.DataBindings.Add("Text", PersonBS, "LastName")
        txtGender.DataBindings.Add("Text", PersonBS, "Gender")
        txtEmail.DataBindings.Add("Text", PersonBS, "eMail")
        txtDateOfBirth.DataBindings.Add("Text", PersonBS, "DateOfBirth")
        txtPhoneNumber.DataBindings.Add("Text", PersonBS, "PhoneNumber")
        txtAddress.DataBindings.Add("Text", PersonBS, "Address")
        txtDetails.DataBindings.Add("Text", PersonBS, "Details")
    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub newForm3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            conString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Contacts_DB;Integrated Security=True;
                  Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
            con.ConnectionString = conString
            con.Open()
            Dim sqlPerson As New SqlCommand("select * from Person_TB",
            con)
            Dim sqlMessage As New SqlCommand("select * from 
Message_TB", con)
            daPerson.SelectCommand = sqlPerson
            daMessage.SelectCommand = sqlMessage
            daPerson.Fill(ds, "PersonTable")
            daMessage.Fill(ds, "MessageTable")
            ' Define the relationship between the tables.
            Dim data_relation As New DataRelation("Per_Message",
            ds.Tables("PersonTable").Columns("P_ID"),
            ds.Tables("MessageTable").Columns("Sender_ID"))
            ds.Relations.Add(data_relation)
            con.Close()
        Catch EXP As Exception
            MessageBox.Show(EXP.ToString)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class