Imports System.Data.SqlClient
Public Class ElimProductoForm
    Dim contador
    Dim ds As New DataSet
    Dim da As SqlDataAdapter
    Dim con As SqlConnection

    Private Sub ElimProductoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Ponemos todos los textBox en modo read Only
        TextBoxCodProd.ReadOnly = True
        TextBoxNombProd.ReadOnly = True
        TextBoxPrecio.ReadOnly = True
        TextBoxStock.ReadOnly = True
        TextBoxStockMin.ReadOnly = True
        TextBoxDescripcion.ReadOnly = True

        'Hacemos la conexion
        con = New SqlConnection(My.Settings.conexion)

        'Establece la conexion con el origen de los datos
        Dim sql As String = "SELECT cod_prod, nom_prod, precio, stock, stock_minimo, descripcion FROM PRODUCTO"

        'consulta
        Dim cmd As New SqlCommand(sql, con)
        da = New SqlDataAdapter(cmd)

        'Ejecuta la consulta y recupera los datos del proveedor

        'conj de comandos y conexion para rellenar el dataset
        da.Fill(ds, "PRODUCTO")

        'LLamamos al metodo rellenar
        rellenarTextBox()

    End Sub

    Private Sub ButtonVolver_Click(sender As Object, e As EventArgs) Handles ButtonVolver.Click
        'cerramos ventana y volvemos a la ventana principal
        Me.Close()
    End Sub

    Sub limpiarTextBox()
        'se vacian los textBox del formulario
        TextBoxCodProd.Clear()
        TextBoxNombProd.Clear()
        TextBoxPrecio.Clear()
        TextBoxStock.Clear()
        TextBoxStockMin.Clear()
        TextBoxDescripcion.Clear()

    End Sub
    Sub rellenarTextBox()
        Try
            TextBoxCodProd.Text = ds.Tables("PRODUCTO").Rows(contador).Item("cod_prod").ToString()
            TextBoxNombProd.Text = ds.Tables("PRODUCTO").Rows(contador).Item("nom_prod").ToString()
            TextBoxPrecio.Text = ds.Tables("PRODUCTO").Rows(contador).Item("precio").ToString()
            TextBoxStock.Text = ds.Tables("PRODUCTO").Rows(contador).Item("stock").ToString
            TextBoxStockMin.Text = ds.Tables("PRODUCTO").Rows(contador).Item("stock_minimo").ToString
            TextBoxDescripcion.Text = ds.Tables("PRODUCTO").Rows(contador).Item("descripcion").ToString
        Catch ex As Exception
            MsgBox("ERROR al rellenar los textBox")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Boton de ir al principio ( boton << )

        If contador = 0 Then
            Beep()
            MsgBox("Estas en el primer elemento de la tabla")
        Else
            contador = 0
        End If

        rellenarTextBox()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Boton de retroceder de uno en uno  (boton <) 
        If contador <> 0 Then
            contador = contador - 1

        Else
            Beep()
            MsgBox("Has llegado al Principio de la lista")
        End If

        rellenarTextBox()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Boton de avanzar de uno en uno
        If contador < ds.Tables("PRODUCTO").Rows.Count - 1 Then
            contador = contador + 1

        Else
            Beep()
            MsgBox("Has llegado al final de la lista")
        End If

        rellenarTextBox()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Boton de ir al final  (boton >> )

        If contador = ds.Tables("PRODUCTO").Rows.Count Then
            Beep()
            MsgBox("Estas en el ultimo elemento de la tabla")
        Else
            contador = ds.Tables("PRODUCTO").Rows.Count - 1
        End If

        rellenarTextBox()

    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Dim codigo = TextBoxCodProd.Text
        'Eliminamos la fila del dataset
        ds.Tables("PRODUCTO").Rows(contador).Delete()
        'Hay que eliminar la fila del dataAdapter!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        'Limpiamos todos los textBox de la fila
        limpiarTextBox()


        ' consulta sql para eliminar de la bd
        da.DeleteCommand = New SqlCommand("DELETE FROM PRODUCTO WHERE cod_prod=@cod_prod", con)
        da.DeleteCommand.Parameters.Add("@cod_prod", SqlDbType.Int).Value = codigo

        ' update
        da.Update(ds, "PRODUCTO")
        MsgBox("ELIMINADO")

    End Sub
End Class