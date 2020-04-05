Imports System.Data.SqlClient

Public Class newForm4


    Dim con As New SqlConnection
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter
    Dim sql As String
    Dim conString As String
    Dim inc As Integer

    Private Sub ViewMessage()
        txtSender.Text = ds.Tables("myMessage").Rows(inc).Item(0)
        txtSender.Text = ds.Tables("myMessage").Rows(inc).Item(1)
        txtDate.Text = ds.Tables("myMessage").Rows(inc).Item(2)
        txtContent.Text = ds.Tables("myMessage").Rows(inc).Item(3)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class