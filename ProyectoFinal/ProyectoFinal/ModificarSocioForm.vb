Public Class ModificarSocioForm
    Private Sub ModificarSocioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Añadir al combobox los string de busqueda
        ComboBox1.Items.Add("Nombre")
        ComboBox1.Items.Add("Direción")
        ComboBox1.Items.Add("Telefono")
        'Hacemos que el combobox sea el que tenga el focus
        ComboBox1.Focus()

        'Pintando un separador

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonVolver.Click
        'Cerramos la ventana de modificar socio
        Me.Dispose()
    End Sub
End Class