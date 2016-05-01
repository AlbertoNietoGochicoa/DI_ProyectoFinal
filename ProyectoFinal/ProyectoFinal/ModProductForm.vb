Public Class ModProductForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Cerramos la ventana y volvemos
        Me.Close()
    End Sub

    Private Sub ModProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxCodProd.ReadOnly = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Boton de guardar, insertamos la informacion en la base de datos.


    End Sub
End Class