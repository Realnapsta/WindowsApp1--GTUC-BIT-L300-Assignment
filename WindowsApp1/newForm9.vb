Public Class newForm9
    Private Sub Message_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Message_TBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Message_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Contacts_DBDataSet)

    End Sub

    Private Sub newForm9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Contacts_DBDataSet.Message_TB' table. You can move, or remove it, as needed.
        Me.Message_TBTableAdapter.Fill(Me.Contacts_DBDataSet.Message_TB)

    End Sub
End Class