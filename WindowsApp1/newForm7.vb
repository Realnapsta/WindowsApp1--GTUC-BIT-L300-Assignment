Public Class newForm7
    Private Sub Call_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Call_TBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Call_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Contacts_DBDataSet)

    End Sub

    Private Sub newForm7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Call_ID As String = Me.Tag
        Try
            Me.Call_TBTableAdapter.FillByC_ID(Me.Contacts_DBDataSet.Call_TB,
            CType(Call_ID, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        'TODO: This line of code loads data into the 'Contacts_DBDataSet.Call_TB' table. You can move, or remove it, as needed.
        'Me.Call_TBTableAdapter.Fill(Me.Contacts_DBDataSet.Call_TB)

    End Sub
End Class