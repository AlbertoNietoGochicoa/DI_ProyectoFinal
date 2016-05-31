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
        Try
            mbd.anadirSocio(TextBoxDni.Text, TextBoxNombre.Text, TextBoxMail.Text, TextBoxIban, PictureBox1.Image, TextBoxObservaciones)

        Catch ex As Exception
            MsgBox("Error al añadir el socio a la base de datos")
        End Try


    End Sub

    Private Sub ButtonSeleccionar_Click(sender As Object, e As EventArgs) Handles ButtonSeleccionar.Click
        'Abrir el navegador para cargar la imagen

        Dim imagen As Image
        Dim dialogo As New OpenFileDialog
        dialogo.InitialDirectory = "C:"

        dialogo.Filter = "(*.*)|*.*|(*.jpg) |*.jpg |(*.png)|*.png"
        dialogo.FilterIndex = 1

        If dialogo.ShowDialog() = DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(dialogo.FileName)



            '      // Stream usado como buffer

            Dim MS As New System.IO.MemoryStream
            '// Se guarda la imagen en el buffer
            PictureBox1.Image.Save(MS, Imaging.ImageFormat.Jpeg)


            '// Se extraen los bytes del buffer para asignarlos como valor para el parámetro.
            '  cmd.Parameters["@image"].Value = ms.GetBuffer()

        End If






    End Sub
End Class