<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewProductForm
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
        Me.ButtonVolver = New System.Windows.Forms.Button()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.TextBoxDescrip = New System.Windows.Forms.TextBox()
        Me.TextBoxStockMin = New System.Windows.Forms.TextBox()
        Me.TextBoxStock = New System.Windows.Forms.TextBox()
        Me.TextBoxPrecio = New System.Windows.Forms.TextBox()
        Me.TextBoxNombProd = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonVolver
        '
        Me.ButtonVolver.Location = New System.Drawing.Point(338, 415)
        Me.ButtonVolver.Name = "ButtonVolver"
        Me.ButtonVolver.Size = New System.Drawing.Size(75, 23)
        Me.ButtonVolver.TabIndex = 29
        Me.ButtonVolver.Text = "Volver"
        Me.ButtonVolver.UseVisualStyleBackColor = True
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.Location = New System.Drawing.Point(79, 415)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGuardar.TabIndex = 28
        Me.ButtonGuardar.Text = "Guardar"
        Me.ButtonGuardar.UseVisualStyleBackColor = True
        '
        'TextBoxDescrip
        '
        Me.TextBoxDescrip.Location = New System.Drawing.Point(173, 199)
        Me.TextBoxDescrip.Multiline = True
        Me.TextBoxDescrip.Name = "TextBoxDescrip"
        Me.TextBoxDescrip.Size = New System.Drawing.Size(222, 154)
        Me.TextBoxDescrip.TabIndex = 24
        '
        'TextBoxStockMin
        '
        Me.TextBoxStockMin.Location = New System.Drawing.Point(173, 162)
        Me.TextBoxStockMin.Name = "TextBoxStockMin"
        Me.TextBoxStockMin.Size = New System.Drawing.Size(222, 20)
        Me.TextBoxStockMin.TabIndex = 23
        '
        'TextBoxStock
        '
        Me.TextBoxStock.Location = New System.Drawing.Point(173, 125)
        Me.TextBoxStock.Name = "TextBoxStock"
        Me.TextBoxStock.Size = New System.Drawing.Size(222, 20)
        Me.TextBoxStock.TabIndex = 22
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.Location = New System.Drawing.Point(173, 87)
        Me.TextBoxPrecio.Name = "TextBoxPrecio"
        Me.TextBoxPrecio.Size = New System.Drawing.Size(222, 20)
        Me.TextBoxPrecio.TabIndex = 21
        '
        'TextBoxNombProd
        '
        Me.TextBoxNombProd.Location = New System.Drawing.Point(173, 44)
        Me.TextBoxNombProd.Name = "TextBoxNombProd"
        Me.TextBoxNombProd.Size = New System.Drawing.Size(222, 20)
        Me.TextBoxNombProd.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Descripción del producto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Stock minimo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Stock:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Precio:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Nombre del producto:"
        '
        'NewProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 488)
        Me.Controls.Add(Me.ButtonVolver)
        Me.Controls.Add(Me.ButtonGuardar)
        Me.Controls.Add(Me.TextBoxDescrip)
        Me.Controls.Add(Me.TextBoxStockMin)
        Me.Controls.Add(Me.TextBoxStock)
        Me.Controls.Add(Me.TextBoxPrecio)
        Me.Controls.Add(Me.TextBoxNombProd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NewProductForm"
        Me.Text = "Nuevo producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonVolver As Button
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents TextBoxDescrip As TextBox
    Friend WithEvents TextBoxStockMin As TextBox
    Friend WithEvents TextBoxStock As TextBox
    Friend WithEvents TextBoxPrecio As TextBox
    Friend WithEvents TextBoxNombProd As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
