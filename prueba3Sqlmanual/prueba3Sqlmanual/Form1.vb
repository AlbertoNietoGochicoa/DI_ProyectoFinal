Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventarioDataSet.productos' table. You can move, or remove it, as needed.
        Me.ProductosTableAdapter.Fill(Me.InventarioDataSet.productos)

    End Sub
End Class
