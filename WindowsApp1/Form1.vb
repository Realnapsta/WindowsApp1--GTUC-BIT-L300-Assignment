
Imports System.Data.SqlClient
Public Class Form1

    Dim con As New SqlClient.SqlConnection
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter
    Dim sql As String
    Dim conString As String
    Dim inc As Integer
    Dim maxrows As Integer
    Dim dsNewRow As DataRow


    Private Sub NavigateRecords()


        txtFName.Text = ds.Tables("Person_TB").Rows(inc).Item(1)
        txtSName.Text = ds.Tables("Person_TB").Rows(inc).Item(2)
        txtGender.Text = ds.Tables("Person_TB").Rows(inc).Item(3)
        txtDateofBirth.Text = ds.Tables("Person_TB").Rows(inc).Item(4)
        txtEmail.Text = ds.Tables("Person_TB").Rows(inc).Item(5)
        txtPhone.Text = ds.Tables("Person_TB").Rows(inc).Item(6)
        txtAddress.Text = ds.Tables("Person_TB").Rows(inc).Item(7)
        txtNotes.Text = ds.Tables("Person_TB").Rows(inc).Item(8)

        maxrows = ds.Tables("Person_TB").Rows.Count
    End Sub

    Public Sub AddRecords()
        Try

            dsNewRow.Item("FirstName") = txtFName.Text
            dsNewRow.Item("LastName") = txtSName.Text
            dsNewRow.Item("Address") = txtAddress.Text
            dsNewRow.Item("Gender") = txtGender.Text
            dsNewRow.Item("Email") = txtEmail.Text
            dsNewRow.Item("DateOfBirth") = txtDateofBirth.Text
            dsNewRow.Item("PhoneNumber") = txtPhone.Text
            dsNewRow.Item("Email") = txtEmail.Text
            dsNewRow.Item("Notes") = txtNotes.Text

            con.Close()

        Catch EXP As Exception
            MessageBox.Show(EXP.ToString)
        End Try
    End Sub

    Public Sub Clearrecords()
        txtFName.Text = ""
        txtSName.Text = ""
        txtAddress.Text = ""
        txtGender.Text = ""
        txtEmail.Text = ""
        'txtDateofBirth.Text = ""
        txtPhone.Text = ""
        txtEmail.Text = ""
        txtNotes.Text = ""
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Contacts_DB;Integrated Security=True;
                  Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

            con = New SqlClient.SqlConnection(conString)
            con.Open()
            sql = "select * from Person_TB"
            da = New SqlClient.SqlDataAdapter(sql, con)
            da.Fill(ds, “Person_TB")
            con.Close()
            txtFName.Text = ds.Tables("Person_TB").Rows(inc).Item(1)
            txtSName.Text = ds.Tables("Person_TB").Rows(inc).Item(2)
            txtGender.Text = ds.Tables("Person_TB").Rows(inc).Item(3)
            txtDateofBirth.Text = ds.Tables("Person_TB").Rows(inc).Item(4)
            txtEmail.Text = ds.Tables("Person_TB").Rows(inc).Item(5)
            txtPhone.Text = ds.Tables("Person_TB").Rows(inc).Item(6)
            txtAddress.Text = ds.Tables("Person_TB").Rows(inc).Item(7)
            txtNotes.Text = ds.Tables("Person_TB").Rows(inc).Item(8)
        Catch EXP As Exception
            MessageBox.Show(EXP.ToString)
        End Try

    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click

        btnCommit.Enabled = True
        btnAddNew.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        Clearrecords()
        MessageBox.Show("please fill in information and commit", "Info required")

    End Sub

    Private Sub btnCommit_Click(sender As Object, e As EventArgs) Handles btnCommit.Click
        Dim cb As New SqlCommandBuilder(da)
        Try
            dsNewRow = ds.Tables("Person_TB").NewRow()
            AddRecords()
            ds.Tables("Person_TB").Rows.Add(dsNewRow)
            da.Update(ds, "Person_TB")
            MessageBox.Show("New Record added to the Database")
            btnCommit.Enabled = False
            btnAddNew.Enabled = True
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
        Catch EXP As Exception
            MessageBox.Show(EXP.ToString)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cb As New SqlCommandBuilder(da)
        Try
            ds.Tables("Person_TB").Rows(inc).Item(1) = txtFName.Text
            ds.Tables("Person_TB").Rows(inc).Item(2) = txtSName.Text
            ds.Tables("Person_TB").Rows(inc).Item(3) = txtAddress.Text
            ds.Tables("Person_TB").Rows(inc).Item(4) = txtGender.Text
            ds.Tables("Person_TB").Rows(inc).Item(5) = txtEmail.Text
            ds.Tables("Person_TB").Rows(inc).Item(6) = txtDateofBirth.Text
            ds.Tables("Person_TB").Rows(inc).Item(7) = txtPhone.Text
            ds.Tables("Person_TB").Rows(inc).Item(8) = txtEmail.Text
            ds.Tables("Person_TB").Rows(inc).Item(9) = txtNotes.Text
            da.Update(ds, "Person_TB")
            MsgBox("Records successfuly saved", MsgBoxStyle.OkOnly, )
        Catch exp As Exception
            MessageBox.Show(exp.ToString)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Try
            If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                MsgBox("Operation Cancelled")
                Exit Sub
            Else
                Dim cb As New SqlCommandBuilder(da)
                ds.Tables(“Person_TB").Rows(inc).Delete()
                maxrows = maxrows - 1
                inc = 0
                NavigateRecords()
                da.Update(ds, “Person_TB")

            End If
        Catch exp As Exception
            MessageBox.Show(exp.ToString)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnCommit.Enabled = False
        btnAddNew.Enabled = True
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        Clearrecords()

        Try
            conString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Contacts_DB;Integrated Security=True;
                  Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

            con = New SqlClient.SqlConnection(conString)
            con.Open()
            sql = "select * from Person_TB"
            da = New SqlClient.SqlDataAdapter(sql, con)
            da.Fill(ds, “Person_TB")
            inc = 1

            txtFName.Text = ds.Tables("Person_TB").Rows(inc).Item(1)
            txtSName.Text = ds.Tables("Person_TB").Rows(inc).Item(2)
            txtGender.Text = ds.Tables("Person_TB").Rows(inc).Item(3)
            txtDateofBirth.Text = ds.Tables("Person_TB").Rows(inc).Item(4)
            txtEmail.Text = ds.Tables("Person_TB").Rows(inc).Item(5)
            txtPhone.Text = ds.Tables("Person_TB").Rows(inc).Item(6)
            txtAddress.Text = ds.Tables("Person_TB").Rows(inc).Item(7)
            txtNotes.Text = ds.Tables("Person_TB").Rows(inc).Item(8)

            con.Close()
        Catch EXP As Exception
            MessageBox.Show(EXP.ToString)
        End Try
    End Sub

    Private Sub btnNavigateFirst_Click(sender As Object, e As EventArgs) Handles btnNavigateFirst.Click
        Try
            If inc <> 0 Then
                inc = 0
                NavigateRecords()
            End If
        Catch EXP As Exception
            MessageBox.Show(EXP.ToString)
        End Try
    End Sub

    Private Sub btnNavigateLast_Click(sender As Object, e As EventArgs) Handles btnNavigateLast.Click
        Try
            If inc <> maxrows - 1 Then
                inc = maxrows - 1
                NavigateRecords()
            End If
        Catch EXP As Exception
            MessageBox.Show(EXP.ToString)
        End Try
    End Sub

    Private Sub btnNavigatePrevious_Click(sender As Object, e As EventArgs) Handles btnNavigatePrevious.Click
        Try
            If inc <> 0 Then
                inc = inc - 1
                NavigateRecords()
            Else
                MessageBox.Show("No Rec")
            End If

        Catch EXP As Exception
            MessageBox.Show(EXP.ToString)
        End Try
    End Sub

    Private Sub btnNavigateNext_Click(sender As Object, e As EventArgs) Handles btnNavigateNext.Click
        Try
            If inc <> maxrows - 1 Then
                inc = inc + 1
                NavigateRecords()
            Else
                MessageBox.Show("No Rec")
            End If
        Catch EXP As Exception
            MessageBox.Show(EXP.ToString)
        End Try
    End Sub

    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        Me.Hide()
        newForm2.Show()
    End Sub

    Private Sub btnViewMessage_Click(sender As Object, e As EventArgs) Handles btnViewMessage.Click
        Me.Hide()
        newForm3.Show()
    End Sub

    Private Sub btnMessageViewer_Click(sender As Object, e As EventArgs) Handles btnMessageViewer.Click
        Me.Hide()
        newForm4.Show()
    End Sub

    Private Sub btnViewPersons_Click(sender As Object, e As EventArgs) Handles btnViewPersons.Click
        Me.Hide()
        newForm5.Show()
    End Sub

    Private Sub btnViewDetails_Click(sender As Object, e As EventArgs) Handles btnViewDetails.Click
        Me.Hide()
        newForm6.Show()
    End Sub



    Private Sub btnViewMessages_Click(sender As Object, e As EventArgs) Handles btnViewMessages.Click
        Me.Hide()
        newForm8.Show()
    End Sub
End Class
