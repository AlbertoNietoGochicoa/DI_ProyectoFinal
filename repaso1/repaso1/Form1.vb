Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventarioDataSet.productos' table. You can move, or remove it, as needed.
        Me.ProductosTableAdapter.Fill(Me.InventarioDataSet.productos)

    End Sub
    Private Sub form_Closing(sender As Object, e As EventArgs) Handles Me.FormClosing
        If (InventarioDataSet.HasChanges()) Then
            'Guaradr los datos
            ProductosTableAdapter.Update(InventarioDataSet)
            'avisar de que se guardan los cambios
            Beep()
            MsgBox("Cambios guardados!!!")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.InventarioDataSet.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.ProductosTableAdapter.Fill(Me.InventarioDataSet.productos)
    End Sub
End Class
