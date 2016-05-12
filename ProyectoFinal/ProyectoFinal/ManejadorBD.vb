Imports System.Data.SqlClient



Public Class ManejadorBD

    'Hacemos la conexion

    Dim con As SqlConnection = New SqlConnection(My.Settings.conexion)
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

    Public Sub anadirSocio()

        Dim ventanaAnadiSocio As New añadirSocioForm

        Dim command As New SqlCommand("ANADIRSOCIO", con)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@dni", ventanaAnadiSocio.TextBoxDni.Text)
        command.Parameters.AddWithValue("@nom_soc", ventanaAnadiSocio.TextBoxNombre.Text)
        command.Parameters.AddWithValue("@email", ventanaAnadiSocio.TextBoxMail.Text)
        command.Parameters.AddWithValue("@iban", ventanaAnadiSocio.TextBoxIban.Text)
        ' command.Parameters.AddWithValue("@foto", )
        command.Parameters.AddWithValue("@observacions", ventanaAnadiSocio.TextBoxObservaciones.Text)


        con.Open()
        command.ExecuteNonQuery()
        con.Close()

        Beep()
        MsgBox("hecho")

    End Sub
    Public Sub anadirProducto(v1, v2, v3, v4, v5)



        Dim command As New SqlCommand("ADDPRODUCTO", con)
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@nom_prod", v1)
        command.Parameters.AddWithValue("@descripcion", v2)
        command.Parameters.AddWithValue("@precio", v3)
        command.Parameters.AddWithValue("@stock", v4)
        command.Parameters.AddWithValue("@stock_minimo", v5)

        Try
            con.Open()
            command.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MsgBox("Error")
        End Try

        Beep()
        MsgBox("hecho")

    End Sub

End Class

