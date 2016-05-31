Imports System.Data.SqlClient
Public Class ModificarSocioForm

    Dim contador = 0
    Dim con As New SqlConnection
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter

    Sub rellenarTextBox()
        Try
            TextBoxDNI.Text = ds.Tables("SOCIO").Rows(contador).Item("dni").ToString()
            TextBoxNombre.Text = ds.Tables("SOCIO").Rows(contador).Item("nom_soc").ToString()
            TextBoxIban.Text = ds.Tables("SOCIO").Rows(contador).Item("iban").ToString()
            TextBoxMail.Text = ds.Tables("SOCIO").Rows(contador).Item("email").ToString
            TextBoxObservaciones.Text = ds.Tables("SOCIO").Rows(contador).Item("observacions").ToString
        Catch ex As Exception
            MsgBox("error al rellenar el socio")
        End Try
    End Sub

    Private Sub ModificarSocioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con = New SqlConnection(My.Settings.conexion)
        Dim sql As String = "Select dni, nom_soc, iban, email, observacions from SOCIO"
        Dim cmd As New SqlCommand(sql, con)
        da = New SqlDataAdapter(cmd)
        da.Fill(ds, "SOCIO")

        rellenarTextBox()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonVolver.Click
        'Cerramos la ventana de modificar socio
        Me.Dispose()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Boton de ir al principio ( boton << )

        If contador = 0 Then
            Beep()
            MsgBox("Estas en el primer elemento de la tabla")
        Else
            contador = 0
        End If

        rellenarTextBox()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Boton de retroceder de uno en uno  (boton <) 
        If contador <> 0 Then
            contador = contador - 1

        Else
            Beep()
            MsgBox("Has llegado al Principio de la lista")
        End If

        rellenarTextBox()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Boton de avanzar de uno en uno
        If contador < ds.Tables("SOCIO").Rows.Count - 1 Then
            contador = contador + 1

        Else
            Beep()
            MsgBox("Has llegado al final de la lista")
        End If

        rellenarTextBox()

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        ' Boton de ir al final  (boton >> )

        If contador = ds.Tables("SOCIO").Rows.Count Then
            Beep()
            MsgBox("Estas en el ultimo elemento de la tabla")
        Else
            contador = ds.Tables("SOCIO").Rows.Count - 1
        End If

        rellenarTextBox()

    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        'Boton de guardar, insertamos la informacion en la base de datos.

        Dim mbd As New ManejadorBD

        mbd.modificarSocio(Me.TextBoxDNI.Text, Me.TextBoxNombre.Text, Me.TextBoxMail.Text, Me.TextBoxIban.Text, Me.TextBoxObservaciones.Text)

        'consulta
        da.Update(ds, "SOCIO")
        contador = 0
        rellenarTextBox()
        Me.Close()

    End Sub
End Class