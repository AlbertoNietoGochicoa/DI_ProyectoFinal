Imports System.Data.SqlClient

Public Class ModProductForm

    Dim contador
    Dim ds As New DataSet
    Dim da As SqlDataAdapter
    Dim con As SqlConnection

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Cerramos la ventana y volvemos
        Me.Close()
    End Sub

    Private Sub ModProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxCodProd.ReadOnly = True

        'Hacemos la conexion
        con = New SqlConnection(My.Settings.conexion)

        'Establece la conexion con el origen de los datos
        Dim sql As String = "SELECT cod_prod, nom_prod, precio, stock, stock_minimo FROM PRODUCTO"

        'consulta
        Dim cmd As New SqlCommand(sql, con)
        da = New SqlDataAdapter(cmd)

        'Ejecuta la consulta y recupera los datos del proveedor

        'conj de comandos y conexion para rellenar el dataset
        da.Fill(ds, "PRODUCTO")

        'LLamamos al metodo rellenar
        rellenarTextBox()

    End Sub
    Sub rellenarTextBox()
        Try


            TextBoxCodProd.Text = ds.Tables("PRODUCTO").Rows(contador).Item("cod_prod").ToString()
            TextBoxNombre.Text = ds.Tables("PRODUCTO").Rows(contador).Item("nom_prod").ToString()
            TextBoxPrecio.Text = ds.Tables("PRODUCTO").Rows(contador).Item("precio").ToString()
            TextBoxStock.Text = ds.Tables("PRODUCTO").Rows(contador).Item("stock").ToString()
            TextBoxStockMin.Text = ds.Tables("PRODUCTO").Rows(contador).Item("stock_minimo").ToString
            TextBoxDescripcion.Text = ds.Tables("PRODUCTO").Rows(contador).Item("descripcion").ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Boton de guardar, insertamos la informacion en la base de datos.


    End Sub
End Class