Imports System.Data.SqlClient
Public Class EliminarSocioForm
    Dim contador
    Dim ds As New DataSet
    Dim da As SqlDataAdapter
    Dim con As SqlConnection

    Private Sub EliminarSocioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contador = 0

        'Hacemos que los text box sean de solo lectura
        TextBoxDNI.ReadOnly = True
        TextBoxNombre.ReadOnly = True
        TextBoxIban.ReadOnly = True
        TextBoxMail.ReadOnly = True
        TextBoxObservaciones.ReadOnly = True

        'Hacemos la conexion
        con = New SqlConnection(My.Settings.conexion)

        'Establece la conexion con el origen de los datos
        Dim sql As String = "SELECT dni, nom_soc, iban, email, observacions FROM SOCIO"

        'consulta
        Dim cmd As New SqlCommand(sql, con)
        da = New SqlDataAdapter(cmd)

        'Ejecuta la consulta y recupera los datos del proveedor

        'conj de comandos y conexion para rellenar el dataset
        da.Fill(ds, "SOCIO")

        'LLamamos al metodo rellenar
        rellenarTextBox()

    End Sub
    Sub limpiarTextBox()
        'se vacian los textBox del formulario
        TextBoxDNI.Clear()
        TextBoxIban.Clear()
        TextBoxMail.Clear()
        TextBoxNombre.Clear()
        TextBoxObservaciones.Clear()
    End Sub
    Sub rellenarTextBox()
        If ds.Tables("SOCIO").Rows.Count > 0 Then
            Try
                TextBoxDNI.Text = ds.Tables("SOCIO").Rows(contador).Item("dni").ToString()
                TextBoxNombre.Text = ds.Tables("SOCIO").Rows(contador).Item("nom_soc").ToString()
                TextBoxIban.Text = ds.Tables("SOCIO").Rows(contador).Item("iban").ToString()
                TextBoxMail.Text = ds.Tables("SOCIO").Rows(contador).Item("email").ToString
                TextBoxObservaciones.Text = ds.Tables("SOCIO").Rows(contador).Item("observacions").ToString
            Catch ex As Exception
                MsgBox("Error al rellenar el socio")
            End Try
        Else
            MsgBox("No hay socios que mostrar")
            Me.Close()

        End If

    End Sub

    Private Sub ButtonVolver_Click(sender As Object, e As EventArgs) Handles ButtonVolver.Click
        'Cerramos la ventana de eliminar socio
        Me.Dispose()
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Boton de ir al final  (boton >> )

        If contador = ds.Tables("SOCIO").Rows.Count Then
            Beep()
            MsgBox("Estas en el ultimo elemento de la tabla")
        Else
            contador = ds.Tables("SOCIO").Rows.Count - 1
        End If

        rellenarTextBox()

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

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click

        If (MessageBox.Show("¿Estás seguro de que quieres eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) =
         DialogResult.No) Then
            MsgBox("Operación cancelada")
        Else

            Dim dni = TextBoxDNI.Text
            'Eliminamos la fila del dataset
            ds.Tables("SOCIO").Rows(contador).Delete()

            'Limpiamos todos los textBox de la fila
            limpiarTextBox()


            ' consulta sql para eliminar de la bd
            da.DeleteCommand = New SqlCommand("DELETE FROM SOCIO WHERE dni = @dni", con)
            da.DeleteCommand.Parameters.Add("@dni", SqlDbType.VarChar).Value = dni
            ' update
            da.Update(ds, "SOCIO")
            MsgBox("ELIMINADO")
            contador = 0
            rellenarTextBox()
            'Me.Close()
        End If

    End Sub
End Class