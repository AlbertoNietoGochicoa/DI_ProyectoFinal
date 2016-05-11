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

    Public Function anadirSocio() As Boolean
        Dim ventanaAnadirSocios As New añadirSocioForm
        Dim v1 = ventanaAnadirSocios.TextBoxDni.Text
        Dim v2 = ventanaAnadirSocios.TextBoxNombre.Text
        Dim v3 = ventanaAnadirSocios.TextBoxMail.Text
        Dim v4 = ventanaAnadirSocios.TextBoxIban.Text
        'Dim v5 = ventanaAnadirSocios.
        Dim v6 = ventanaAnadirSocios.TextBoxObservaciones.Text

        '   Try


        ' Insertar un nuevo elemento en la tabla  (Boton guardar)

        'creamos un row para insertarlo en el dataset
        Dim dsNewRow As DataRow

        'Se crea el row del tipo SOCIO del dataset
        ' Try
        dsNewRow = dsSocio.Tables("SOCIO").NewRow

        '  Catch ex As Exception

        '  End Try
        'Relleno la fila a insertar en el dataset
        dsNewRow.Item("dni") = ventanaAnadirSocios.TextBoxDni.Text
        dsNewRow.Item("nom_soc") = ventanaAnadirSocios.TextBoxNombre.Text
            dsNewRow.Item("email") = ventanaAnadirSocios.TextBoxMail.Text
            dsNewRow.Item("iban") = ventanaAnadirSocios.TextBoxIban.Text
            'Aqui falta la imagen
            dsNewRow.Item("observacions") = ventanaAnadirSocios.TextBoxObservaciones.Text

            'se añade el row a la table
            dsSocio.Tables("SOCIO").Rows.Add(dsNewRow)


            'Añadir la nueva fila a la base de datos!!
            'Crear la sentencia sql para hacer la insercion
            Dim insertsql As String = "INSERT into SOCIO (dni, nom_soc, email, iban, foto, observacions) values (@dni, @nom_soc, @email, @iban, @observacions)"
            da.InsertCommand = New SqlCommand(insertSql, con)
            da.InsertCommand.Parameters.Add("@dni", SqlDbType.VarChar, 9).Value = ventanaAnadirSocios.TextBoxDni.Text
            da.InsertCommand.Parameters.Add("@nom_soc", SqlDbType.VarChar, 30).Value = ventanaAnadirSocios.TextBoxNombre.Text
            da.InsertCommand.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = ventanaAnadirSocios.TextBoxMail.Text
            da.InsertCommand.Parameters.Add("@iban", SqlDbType.VarChar, 34).Value = ventanaAnadirSocios.TextBoxIban.Text
            da.InsertCommand.Parameters.Add("@observacions", SqlDbType.VarChar, 200).Value = ventanaAnadirSocios.TextBoxObservaciones.Text


            da.Update(dsSocio, "SOCIO")
            Beep()
            MsgBox("Nuevo registro introducido")



            Return True

            ''     Catch ex As Exception
        '    MsgBox("Corre y busca el error!!!!")
        '     End Try
    End Function

End Class
