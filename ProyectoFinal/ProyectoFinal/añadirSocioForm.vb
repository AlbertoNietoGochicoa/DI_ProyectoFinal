Imports System.Data.SqlClient

Public Class añadirSocioForm

    ' Stream usado como buffer

    Dim MS As New IO.MemoryStream

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

        If TextBoxDni.Text.Length = 0 Then
            MsgBox("El campo DNI es obligatorio")
        ElseIf TextBoxDni.Text.Length < 9 Then
            MsgBox("El DNI tiene que tener 9 caracteres")
        ElseIf TextBoxNombre.Text.Length = 0 Then
            MsgBox("El campo Nombre es obligatorio")
        ElseIf TextBoxIban.Text.Length = 0 Then
            MsgBox("El campo IBAN es obligatorio")
        Else
            Dim cmd = New SqlCommand
            cmd.Connection = mbd.con
            cmd.CommandText = "INSERT INTO SOCIO VALUES (@dni,@nom_soc,@email,@iban,@foto,@observacions)"


            cmd.Parameters.AddWithValue("@dni", TextBoxDni.Text)
            cmd.Parameters.AddWithValue("@nom_soc", TextBoxNombre.Text)
            cmd.Parameters.AddWithValue("@email", TextBoxMail.Text)
            cmd.Parameters.AddWithValue("@iban", TextBoxIban.Text)
            cmd.Parameters.Add("@foto", SqlDbType.Image).Value = MS.GetBuffer()
            cmd.Parameters.AddWithValue("@observacions", TextBoxObservaciones.Text)

            Try
                mbd.con.Open()
                MsgBox("Conexión abierta")
            Catch ex As SqlException
                MsgBox("No se puede conectar")
            End Try

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Nuevo socio guardado")
            Catch ex As SqlException
                MsgBox("Not se puede guardar")
            Finally
                mbd.con.Close()

            End Try

        End If

    End Sub

    Private Sub ButtonSeleccionar_Click(sender As Object, e As EventArgs) Handles ButtonSeleccionar.Click
        'Abrir el navegador para cargar la imagen

        Dim dialogo As New OpenFileDialog
        dialogo.InitialDirectory = "C:"

        dialogo.Filter = "(*.jpg) |*.jpg"
        dialogo.FilterIndex = 1

        If dialogo.ShowDialog() = DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(dialogo.FileName)

            '// Se guarda la imagen en el buffer
            Try
                PictureBox1.Image.Save(MS, Imaging.ImageFormat.Jpeg)
            Catch ex As Exception
                MsgBox("La imagen tiene que estar en .jpg")
            End Try

            MsgBox(MS.GetBuffer().Length)
        End If

    End Sub
End Class