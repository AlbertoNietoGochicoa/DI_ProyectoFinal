Imports System.Data.SqlClient
Public Class ListaPedidoForm

    Private Sub ListaPedidoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim manejador As New ManejadorBD
        Dim datos2 As SqlDataReader


        Dim sql2 As New SqlCommand("SELECT dni FROM SOCIO", manejador.con)

        Try
            manejador.con.Open()
        Catch ex As Exception
            MsgBox("No se puede abrir")
        End Try

        datos2 = sql2.ExecuteReader

        While datos2.Read
            ComboBox1.Items.Add(datos2.Item("dni"))
        End While
        manejador.con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Cerramos la ventana
        Me.Close()
    End Sub

    Private Sub ButtonCargar_Click(sender As Object, e As EventArgs) Handles ButtonCargar.Click
        'Guardamos el dni del socio en una variable y se crea la select para cargar el data grid

        Dim socio As String = ComboBox1.Text
        Dim manejador As New ManejadorBD
        Dim datos As SqlDataReader
        Dim sql2 As New SqlCommand("SELECT * FROM PEDIDO", manejador.con)


        Try
            manejador.con.Open()
        Catch ex As Exception
            MsgBox("No se puede abrir")
        End Try

        datos = sql2.ExecuteReader

        While datos.Read
            If datos.Item("dni").Equals(ComboBox1.Text) Then
                TextBox2.Text = TextBox2.Text + "Número de pedido: " + datos.Item("num_pedido").ToString + ", " + "DNI: " + datos.Item("dni") + ", " + "Fecha del pedido: " + datos.Item("fecha_pedido") + ", " + "Importe total: " + datos.Item("importe").ToString + vbCrLf
            End If
        End While
        manejador.con.Close()



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim manejador As New ManejadorBD
        Dim datos As SqlDataReader
        Dim sql2 As New SqlCommand("SELECT dni FROM SOCIO", manejador.con)


        Try
            manejador.con.Open()
        Catch ex As Exception
            MsgBox("No se puede abrir")
        End Try

        datos = sql2.ExecuteReader

        While datos.Read
            ComboBox1.Items.Add(datos.Item("dni"))
        End While
        manejador.con.Close()
    End Sub
End Class