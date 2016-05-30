Public Class NewProductForm


    Private Sub ButtonVolver_Click(sender As Object, e As EventArgs) Handles ButtonVolver.Click
        'cerramos ventana y volvemos para atras
        Me.Close()
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click

        Dim mbd As New ManejadorBD

        mbd.anadirProducto(Me.TextBoxNombProd.Text, Me.TextBoxPrecio.Text, Me.TextBoxStock.Text, Me.TextBoxStockMin.Text, Me.TextBoxDescrip.Text)

        'limpiar los texbox
        TextBoxNombProd.Clear()
        TextBoxPrecio.Clear()
        TextBoxStock.Clear()
        TextBoxStockMin.Clear()
        TextBoxDescrip.Clear()


    End Sub

    Private Sub NewProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class