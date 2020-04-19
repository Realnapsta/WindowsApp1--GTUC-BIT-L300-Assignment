Public Class newForm8
    Private Sub Person_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Person_TBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Person_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Contacts_DBDataSet)

    End Sub

    Private Sub newForm8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Contacts_DBDataSet.Message_TB' table. You can move, or remove it, as needed.
        Me.Message_TBTableAdapter.Fill(Me.Contacts_DBDataSet.Message_TB)
        'TODO: This line of code loads data into the 'Contacts_DBDataSet.Person_TB' table. You can move, or remove it, as needed.
        Me.Person_TBTableAdapter.Fill(Me.Contacts_DBDataSet.Person_TB)

    End Sub

    Private Sub Message_TBDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Message_TBDataGridView.CellContentClick
        ' View Call button clicked
        ' Get the ID of the selected Message
        Dim i As Integer = e.RowIndex
        Dim row As DataGridViewRow =
        Message_TBDataGridView.Rows(i)
        Dim cell As DataGridViewCell = row.Cells(1)
        Dim Call_ID As String = cell.Value
        ' Display the newForm7 form
        Dim callForm As New newForm7
        callForm.Tag = Call_ID
        callForm.ShowDialog()
    End Sub
End Class