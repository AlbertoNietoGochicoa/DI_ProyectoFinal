Public Class ElimProductoForm
    Private Sub ElimProductoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Ponemos todos los textBox en modo read Only
        TextBoxCodProd.ReadOnly = True
        TextBoxNombProd.ReadOnly = True
        TextBoxPrecio.ReadOnly = True
        TextBoxStock.ReadOnly = True
        TextBoxStockMin.ReadOnly = True
        TextBoxDescripcion.ReadOnly = True

    End Sub

    Private Sub ButtonVolver_Click(sender As Object, e As EventArgs) Handles ButtonVolver.Click
        'cerramos ventana y volvemos a la ventana principal
        Me.Close()
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNombProd.TextChanged

    End Sub


End Class