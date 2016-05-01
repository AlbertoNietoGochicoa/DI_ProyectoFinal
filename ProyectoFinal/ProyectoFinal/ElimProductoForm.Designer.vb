<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ElimProductoForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonVolver = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.TextBoxDescripcion = New System.Windows.Forms.TextBox()
        Me.TextBoxStockMin = New System.Windows.Forms.TextBox()
        Me.TextBoxStock = New System.Windows.Forms.TextBox()
        Me.TextBoxPrecio = New System.Windows.Forms.TextBox()
        Me.TextBoxCodProd = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(361, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "___________________________________________________________"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(148, 69)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(143, 21)
        Me.ComboBox1.TabIndex = 16
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Location = New System.Drawing.Point(148, 33)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(143, 20)
        Me.TextBoxBuscar.TabIndex = 15
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Location = New System.Drawing.Point(333, 48)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBuscar.TabIndex = 14
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "En el campo: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Buscar: "
        '
        'ButtonVolver
        '
        Me.ButtonVolver.Location = New System.Drawing.Point(333, 417)
        Me.ButtonVolver.Name = "ButtonVolver"
        Me.ButtonVolver.Size = New System.Drawing.Size(75, 23)
        Me.ButtonVolver.TabIndex = 48
        Me.ButtonVolver.Text = "Volver"
        Me.ButtonVolver.UseVisualStyleBackColor = True
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Location = New System.Drawing.Point(105, 417)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEliminar.TabIndex = 47
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(173, 311)
        Me.TextBoxDescripcion.Multiline = True
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(222, 73)
        Me.TextBoxDescripcion.TabIndex = 46
        '
        'TextBoxStockMin
        '
        Me.TextBoxStockMin.Location = New System.Drawing.Point(173, 274)
        Me.TextBoxStockMin.Name = "TextBoxStockMin"
        Me.TextBoxStockMin.Size = New System.Drawing.Size(222, 20)
        Me.TextBoxStockMin.TabIndex = 45
        '
        'TextBoxStock
        '
        Me.TextBoxStock.Location = New System.Drawing.Point(173, 237)
        Me.TextBoxStock.Name = "TextBoxStock"
        Me.TextBoxStock.Size = New System.Drawing.Size(222, 20)
        Me.TextBoxStock.TabIndex = 44
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.Location = New System.Drawing.Point(173, 199)
        Me.TextBoxPrecio.Name = "TextBoxPrecio"
        Me.TextBoxPrecio.Size = New System.Drawing.Size(222, 20)
        Me.TextBoxPrecio.TabIndex = 43
        '
        'TextBoxCodProd
        '
        Me.TextBoxCodProd.Location = New System.Drawing.Point(173, 156)
        Me.TextBoxCodProd.Name = "TextBoxCodProd"
        Me.TextBoxCodProd.Size = New System.Drawing.Size(222, 20)
        Me.TextBoxCodProd.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Descripción del producto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Stock minimo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(104, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Stock:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(102, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Precio:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(37, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Codigo del producto:"
        '
        'ElimProductoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 468)
        Me.Controls.Add(Me.ButtonVolver)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.TextBoxDescripcion)
        Me.Controls.Add(Me.TextBoxStockMin)
        Me.Controls.Add(Me.TextBoxStock)
        Me.Controls.Add(Me.TextBoxPrecio)
        Me.Controls.Add(Me.TextBoxCodProd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBoxBuscar)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ElimProductoForm"
        Me.Text = "ElimProductoForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBoxBuscar As TextBox
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonVolver As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents TextBoxDescripcion As TextBox
    Friend WithEvents TextBoxStockMin As TextBox
    Friend WithEvents TextBoxStock As TextBox
    Friend WithEvents TextBoxPrecio As TextBox
    Friend WithEvents TextBoxCodProd As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
