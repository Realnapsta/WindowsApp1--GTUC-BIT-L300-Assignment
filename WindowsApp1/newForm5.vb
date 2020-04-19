Public Class newForm5
    Private Sub Person_TBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Person_TBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Person_TBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Contacts_DBDataSet)

    End Sub

    Private Sub newForm5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Contacts_DBDataSet.Person_TB' table. You can move, or remove it, as needed.
        Me.Person_TBTableAdapter.Fill(Me.Contacts_DBDataSet.Person_TB)

    End Sub

    Private Sub btnGobackHome_Click(sender As Object, e As EventArgs) Handles btnGobackHome.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub FillBy_P_IDToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy_P_IDToolStripButton.Click
        Try
            Me.Person_TBTableAdapter.FillBy_P_ID(Me.Contacts_DBDataSet.Person_TB, CType(P_IDToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Person_TBTableAdapter.Fill(Me.Contacts_DBDataSet.Person_TB)
    End Sub
End Class