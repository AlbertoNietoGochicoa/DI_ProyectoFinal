Public Class añadirSocioForm

    Private Sub añadirSocioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonVolver.Click
        'Cerramos la ventana de nuevo socio
        Me.Dispose()
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        ' Referencia a la clase
        Dim mbd = New ManejadorBD
        ' Debug


        ' mbd.anadirSocio(TextBoxDni.Text, TextBoxNombre.Text, TextBoxMail.Text, TextBoxIban, TextBoxImagen, TextBoxObservaciones)


    End Sub

    Private Sub ButtonSeleccionar_Click(sender As Object, e As EventArgs) Handles ButtonSeleccionar.Click

        PictureBox1.Image = Image.FromFile("C:\Users\Public\Pictures\Sample Pictures\Koala.jpg")

    End Sub
End Class