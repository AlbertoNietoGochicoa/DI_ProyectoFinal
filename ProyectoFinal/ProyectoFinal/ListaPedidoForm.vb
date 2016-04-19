Public Class ListaPedidoForm
    Private Sub ListaPedidoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Cerramos la ventana
        Me.Close()
    End Sub

    Private Sub ButtonCargar_Click(sender As Object, e As EventArgs) Handles ButtonCargar.Click
        'Guardamos el dni del socio en una variable y se crea la select para cargar el data grid
        Dim dni = TextBoxDni.Text


    End Sub
End Class