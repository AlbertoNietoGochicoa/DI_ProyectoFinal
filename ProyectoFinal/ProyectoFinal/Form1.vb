Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AñadirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirToolStripMenuItem.Click
        'Al pulsar el boton se cierra la ventana principal y se muestra la ventana de nuevo socio.
        Dim ventSocioNuevo As New añadirSocioForm
        ventSocioNuevo.Show()

    End Sub
End Class
