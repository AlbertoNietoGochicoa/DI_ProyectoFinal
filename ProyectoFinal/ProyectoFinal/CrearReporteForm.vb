Public Class CrearReporteForm
    Private Sub CrearReporteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        Button2.Enabled = False
        GuardarReporBut.Enabled = False
        MsgBox("Implementacion en fase de desarollo, funcionalidad desabilitada temporalmente.")

        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'cerramos la ventana y volvemos a la principal
        Me.Close()
    End Sub


End Class