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

        Dim cmd As New SqlCommand("")

        ventanaAnadirSocios.TextBoxDni.Text
    End Function

End Class
