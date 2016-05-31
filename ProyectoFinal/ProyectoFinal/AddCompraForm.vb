Imports System.Data.SqlClient

Public Class AddCompraForm

    Dim total As Double


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Cerramos la ventana de añadir pedido
        Me.Close()
    End Sub

    Private Sub AddCompraForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim manejador As New ManejadorBD
        Dim datos As SqlDataReader
        Dim datos2 As SqlDataReader
        Try
            manejador.con.Open()
        Catch ex As Exception
            MsgBox("No se puede abrir")
        End Try

        Dim sql As New SqlCommand("SELECT nom_prod FROM PRODUCTO", manejador.con)
        datos = sql.ExecuteReader

        While datos.Read
            ComboBoxArticulo.Items.Add(datos.Item("nom_prod"))
        End While
        manejador.con.Close()

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

        If TextBoxCantidad.Text.Length <= 0 Then
            MsgBox("Compra alguna cantidad")
        Else
            Dim dato As Integer
            Try
                dato = CInt(TextBoxCantidad.Text)
            Catch ex As Exception
                MsgBox("Introduzca un número válido (entero)")
            End Try
        End If

        If TextBox2.Text.Length = 0 Then

            TextBox2.Text = ComboBoxArticulo.Text + " " + TextBoxCantidad.Text + vbCrLf
        Else
            TextBox2.Text = TextBox2.Text + ComboBoxArticulo.Text + " " + TextBoxCantidad.Text + vbCrLf

        End If

        ' Nos quedamos con el dato

        Dim manejador As New ManejadorBD
        Dim datos3 As SqlDataReader


        Dim precio As Integer

        Try
            manejador.con.Open()
        Catch ex As Exception

            MsgBox("No se puede hacer la operación")

        End Try

        Dim sql As New SqlCommand("SELECT precio, nom_prod FROM PRODUCTO", manejador.con)
        datos3 = sql.ExecuteReader


        While datos3.Read
            If datos3.Item("nom_prod").Equals(ComboBoxArticulo.Text) Then
                precio = datos3.Item("precio")
            End If
        End While
        manejador.con.Close()

        total = total + (precio * TextBoxCantidad.Text)

        MsgBox("Total acumulado =" + total.ToString)






    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim manejador As New ManejadorBD

        manejador.anadirPedido(ComboBox1.Text, total)

    End Sub


End Class