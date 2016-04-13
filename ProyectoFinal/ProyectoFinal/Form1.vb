Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AñadirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirToolStripMenuItem.Click
        'Al pulsar el boton se muestra la ventana de nuevo socio.
        Dim ventSocioNuevo As New añadirSocioForm
        ventSocioNuevo.Show()

    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        'Al pulsar el boton se muestra la ventana de modificar socio
        Dim ventModifSocio As New ModificarSocioForm
        ventModifSocio.Show()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        'Al pulsar el boton se muestra la ventana de eliminar socio
        Dim ventElimSocio As New EliminarSocioForm
        ventElimSocio.Show()
    End Sub

    Private Sub AñadirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AñadirToolStripMenuItem1.Click
        'Al pulsar el boton se muestra la ventana de Añadir pedido
        Dim ventAddPedido As New AddPedidoForm
        ventAddPedido.Show()
    End Sub
End Class
