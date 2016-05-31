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



    End Sub


End Class