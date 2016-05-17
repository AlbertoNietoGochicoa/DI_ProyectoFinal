Imports System.Data.SqlClient


Public Class Form1

    Dim con As SqlConnection
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim contador As Integer

    Private Sub rellenarTextBox()

        NombreTextBox.Text = ds.Tables("personas").Rows(contador).Item("nombre").ToString()
        ApellidoTextBox.Text = ds.Tables("personas").Rows(contador).Item("apellido").ToString()

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contador = 0


        'Se hace la conexion
        con = New SqlConnection(My.Settings.conexion1)

        Dim sql As String = "select * from personas"
        Dim cmd As New SqlCommand(sql, con)
        da= New SqlDataAdapter(cmd)

        Try
            da.Fill(ds, "Personas")
            rellenarTextBox()

        Catch ex As Exception


            MsgBox("Error al rellenar el dataset")
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub NombreTextBox_TextChanged(sender As Object, e As EventArgs) Handles NombreTextBox.TextChanged

    End Sub
End Class
