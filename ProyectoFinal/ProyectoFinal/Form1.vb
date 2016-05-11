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
        Dim ventAddPedido As New AddCompraForm
        ventAddPedido.Show()
    End Sub

    Private Sub ModificarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem1.Click
        'Al pulsar el boton se muestra la ventana de modificar pedido
        Dim ventModPedido As New ModPedidoForm
        ventModPedido.Show()

    End Sub

    Private Sub ListaDePedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDePedidosToolStripMenuItem.Click
        'Al pulsar el boton se muestra la ventana de la lista de pedidos
        Dim ventListaPedido As New ListaPedidoForm
        ventListaPedido.Show()
    End Sub

    Private Sub NuevoProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoProductoToolStripMenuItem.Click
        'Al pulsar el boton se muestra la ventana de Añadir nuevo producto
        Dim ventListaPedido As New ListaPedidoForm
        ventListaPedido.Show()
    End Sub

    Private Sub ModificarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarProductoToolStripMenuItem.Click
        'Al pulsar el boton se muestra la ventana de mnodificar un producto
        Dim ventModProduct As New ModProductForm
        ventModProduct.Show()
    End Sub

    Private Sub EliminarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarProductoToolStripMenuItem.Click
        'Al pulsar el boton se muestra la ventana de eliminar un producto
        Dim ventElimProducto As New ElimProductoForm
        ventElimProducto.Show()
    End Sub

    Private Sub CrearReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearReporteToolStripMenuItem.Click
        'Al pulsar el boton se muestra la ventana de crear reporte
        Dim ventCrearReporte As New CrearReporteForm
        ventCrearReporte.Show()
    End Sub

    Private Sub ConsultarReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarReportesToolStripMenuItem.Click
        'Al pulsar el boton se muestra la ventana de consultar reporte
        Dim ventConsultarReport As New ConsultarReportForm
        ventConsultarReport.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        'Al pulsar el boton se muestra la ventana de Acerca de...
        Dim ventAcercaDe As New AcercaDeForm
        ventAcercaDe.Show()
    End Sub
End Class
