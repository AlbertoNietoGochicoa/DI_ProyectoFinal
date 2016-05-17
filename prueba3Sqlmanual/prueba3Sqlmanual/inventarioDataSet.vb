Partial Class inventarioDataSet
    Partial Public Class productosDataTable
        Private Sub productosDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.id_CodColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
