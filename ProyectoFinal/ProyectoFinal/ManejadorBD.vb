Imports System.Data.SqlClient



Public Class ManejadorBD

    'Hacemos la conexion

    Public con As SqlConnection = New SqlConnection(My.Settings.conexion)

    ' Objetos
    Dim da As SqlDataAdapter
    Dim dsLinea As DataSet
    Dim dsSocio As DataSet
    Dim dsProductos As DataSet


    ' Procedimiento para rellenar los datos que hay en la tabla socio
    Sub rellenarSocio()

        ' String para la consulta
        Dim sql As String = "Select * From SOCIO"
        ' Nos quedamos en comando con el string del SQL y la conexión
        Dim comando As New SqlCommand(sql, con)


        Try

            ' Creamos el dataAdapter con el comando de arriba

            da = New SqlDataAdapter(comando)
            ' Rellenamos el dataSet con los datos de la tabla
            da.Fill(dsSocio, "SOCIO")
            MsgBox("DataSet SOCIO rellenado con éxito")

        Catch ex As SqlException

            MsgBox("Imposible conectar a la BD")

        End Try

    End Sub

    ' Procedimiento para rellenar los datos que hay en la tabla PRODUCTO

    Sub rellenarProducto()

        ' String para la consulta
        Dim sql As String = "Select * From PRODUCTO"
        ' Nos quedamos en comando con el string del SQL y la conexión
        Dim comando As New SqlCommand(sql, con)


        Try

            ' Creamos el dataAdapter con el comando de arriba

            da = New SqlDataAdapter(comando)
            ' Rellenamos el dataSet con los datos de la tabla
            da.Fill(dsProductos, "PRODUCTO")
            MsgBox("DataSet PRODUCTO rellenado con éxito")

        Catch ex As SqlException

            MsgBox("Imposible conectar a la BD")

        End Try

    End Sub
    Sub rellenarLineaPedido()

        ' String para la consulta
        Dim sql As String = "Select * From LINEA_PEDIDO"
        ' Nos quedamos en comando con el string del SQL y la conexión
        Dim comando As New SqlCommand(sql, con)


        Try

            ' Creamos el dataAdapter con el comando de arriba

            da = New SqlDataAdapter(comando)
            ' Rellenamos el dataSet con los datos de la tabla
            da.Fill(dsLinea, "LINEA_PEDIDO")
            MsgBox("DataSet LINEA_PEDIDO rellenado con éxito")

        Catch ex As SqlException

            MsgBox("Imposible conectar a la BD")

        End Try

    End Sub

    Public Sub anadirSocio(ByRef dni, ByRef nombre, ByRef email, ByRef iban, ByRef foto, ByRef observaciones)

        Dim ventanaAnadiSocio As New añadirSocioForm

        Dim command As New SqlCommand("ANADIRSOCIO", con)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@dni", ventanaAnadiSocio.TextBoxDni.Text)
        command.Parameters.AddWithValue("@nom_soc", ventanaAnadiSocio.TextBoxNombre.Text)
        command.Parameters.AddWithValue("@email", ventanaAnadiSocio.TextBoxMail.Text)
        command.Parameters.AddWithValue("@iban", ventanaAnadiSocio.TextBoxIban.Text)
        command.Parameters.AddWithValue("@foto", ventanaAnadiSocio.PictureBox1.Image)
        command.Parameters.AddWithValue("@observacions", ventanaAnadiSocio.TextBoxObservaciones.Text)

        Try
            con.Open()
        Catch ex As SqlException
            MsgBox("Imposible conectarse a la BD")
        End Try

        Try
            command.ExecuteNonQuery()

        Catch ex As SqlException
            MsgBox(ex.ToString)
        End Try


        con.Close()

        Beep()
        MsgBox("hecho")

    End Sub
    Public Sub anadirProducto(ByRef v1, ByRef v2, ByRef v3, ByRef v4, ByRef v5)


        Dim command As New SqlCommand("ADDPRODUCTO", con)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@nom_prod", v1)
        command.Parameters.AddWithValue("@precio", v2)
        command.Parameters.AddWithValue("@stock", v3)
        command.Parameters.AddWithValue("@stock_minimo", v4)
        command.Parameters.AddWithValue("@descripcion", v5)

        Try
            con.Open()

        Catch ex As SqlException
            MsgBox("Imposible conectarse a la BD")
        End Try
        Try
            command.ExecuteNonQuery()
            Beep()
            MsgBox("Producto añadido correctamente")



        Catch ex As SqlException
            MsgBox("No se puede hacer la inserción del producto")
        End Try

        con.Close()

    End Sub

    Sub modificarProducto(ByRef v1, ByRef v2, ByRef v3, ByRef v4, ByRef v5, ByRef v6)
        Dim command As New SqlCommand("MODIFICARPRODUCTO", con)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@cod_prod", v1)
        command.Parameters.AddWithValue("@nom_prod", v2)
        command.Parameters.AddWithValue("@precio", v3)
        command.Parameters.AddWithValue("@stock", v4)
        command.Parameters.AddWithValue("@stock_minimo", v5)
        command.Parameters.AddWithValue("@descripcion", v6)

        Try
            con.Open()

        Catch ex As SqlException
            MsgBox("Imposible conectarse a la BD")
        End Try
        Try
            command.ExecuteNonQuery()
            Beep()
            MsgBox("Producto modificado correctamente")

        Catch ex As SqlException
            MsgBox("No se puede hacer la modificacion del producto")
        End Try

        con.Close()

    End Sub
    Sub modificarSocio(ByRef v1, ByRef v2, ByRef v3, ByRef v4, ByRef v5)
        Dim command As New SqlCommand("MODIFICARSOCIO", con)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@dni", v1)
        command.Parameters.AddWithValue("@nom_soc", v2)
        command.Parameters.AddWithValue("@email", v3)
        command.Parameters.AddWithValue("@iban", v4)
        command.Parameters.AddWithValue("@observacions", v5)

        Try
            con.Open()

        Catch ex As SqlException
            MsgBox("Imposible conectarse a la BD")
        End Try
        Try
            command.ExecuteNonQuery()
            Beep()
            MsgBox("Socio modificado correctamente")

        Catch ex As SqlException
            MsgBox("No se puede hacer la modificacion del Socio")
        End Try

        con.Close()

    End Sub
    Public Sub anadirPedido(ByRef v1, ByRef v3)

        Dim command As New SqlCommand("ANADIRPEDIDO", con)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@dni", v1)
        command.Parameters.AddWithValue("@fecha_pedido", Today.Date)
        command.Parameters.AddWithValue("@importe", v3)


        Try
            con.Open()

        Catch ex As SqlException
            MsgBox("Imposible conectarse a la BD")
        End Try
        Try
            command.ExecuteNonQuery()
            Beep()
            MsgBox("Pedido añadido")

        Catch ex As SqlException
            MsgBox(ex.ToString)
        End Try

        con.Close()

    End Sub


End Class

