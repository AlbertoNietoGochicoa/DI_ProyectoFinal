Public Class EliminarSocioForm
    Private Sub EliminarSocioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hacemos que los text box sean de solo lectura
        TextBoxDNI.ReadOnly = True
        TextBoxNombre.ReadOnly = True
        TextBoxIban.ReadOnly = True
        TextBoxMail.ReadOnly = True
        TextBoxObservaciones.ReadOnly = True
    End Sub

    Private Sub ButtonVolver_Click(sender As Object, e As EventArgs) Handles ButtonVolver.Click
        'Cerramos la ventana de eliminar socio
        Me.Dispose()
    End Sub
End Class