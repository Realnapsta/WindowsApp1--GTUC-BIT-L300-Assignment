
Imports System.Data.SqlClient
Public Class newForm2

    Dim con As New SqlClient.SqlConnection
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter
    Dim sql As String
    Dim conString As String
    Dim inc As Integer
    Dim maxrows As Integer
    Dim dsNewRow As DataRow
    Private Sub newForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Contacts_DB;Integrated Security=True;
                  Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
        Try
            con = New SqlConnection(conString)
            con.Open()
            sql = "select * from Person_TB"
            da = New SqlDataAdapter(sql, con)
            da.Fill(ds, “Person_TB")
            con.Close()
        Catch EXP As Exception
            MessageBox.Show(EXP.ToString)
        End Try

        Me.DataGridView1.DataSource = ds.Tables(“Person_TB")
        Me.ComboBox1.DataSource = ds.Tables("Person_TB ")
        Me.ComboBox1.DisplayMember = “Id"
        Form1.btnCommit.Enabled = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class