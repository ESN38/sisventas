<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdetalle_venta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cbtipodoc = New System.Windows.Forms.ComboBox()
        Me.txtfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtnombrecliente = New System.Windows.Forms.TextBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.txtnumdoc = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtstock = New System.Windows.Forms.NumericUpDown()
        Me.txtcantidad = New System.Windows.Forms.NumericUpDown()
        Me.txtpreciounitario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnbuscarproducto = New System.Windows.Forms.Button()
        Me.txtnombreproducto = New System.Windows.Forms.TextBox()
        Me.txtidproducto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidventa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.errorcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtstock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbtipodoc
        '
        Me.cbtipodoc.Enabled = False
        Me.cbtipodoc.FormattingEnabled = True
        Me.cbtipodoc.Items.AddRange(New Object() {"Ticket" & Global.Microsoft.VisualBasic.ChrW(9), "Factura"})
        Me.cbtipodoc.Location = New System.Drawing.Point(123, 123)
        Me.cbtipodoc.Name = "cbtipodoc"
        Me.cbtipodoc.Size = New System.Drawing.Size(130, 21)
        Me.cbtipodoc.TabIndex = 19
        Me.cbtipodoc.Text = "Ticket" & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'txtfecha
        '
        Me.txtfecha.Enabled = False
        Me.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha.Location = New System.Drawing.Point(94, 89)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(159, 20)
        Me.txtfecha.TabIndex = 18
        '
        'txtnombrecliente
        '
        Me.txtnombrecliente.Enabled = False
        Me.txtnombrecliente.Location = New System.Drawing.Point(138, 54)
        Me.txtnombrecliente.Name = "txtnombrecliente"
        Me.txtnombrecliente.Size = New System.Drawing.Size(115, 20)
        Me.txtnombrecliente.TabIndex = 16
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(136, 409)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(71, 36)
        Me.btnguardar.TabIndex = 15
        Me.btnguardar.Text = "Agregar Articulo"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(219, 409)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(71, 36)
        Me.btncancelar.TabIndex = 14
        Me.btncancelar.Text = "Salir"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.Gainsboro
        Me.btnnuevo.Location = New System.Drawing.Point(47, 409)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(71, 36)
        Me.btnnuevo.TabIndex = 12
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'txtnumdoc
        '
        Me.txtnumdoc.Enabled = False
        Me.txtnumdoc.Location = New System.Drawing.Point(123, 157)
        Me.txtnumdoc.MaxLength = 10
        Me.txtnumdoc.Name = "txtnumdoc"
        Me.txtnumdoc.Size = New System.Drawing.Size(130, 20)
        Me.txtnumdoc.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.cbeliminar)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(347, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(466, 462)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = ".:. Items de Articulos .:."
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.Location = New System.Drawing.Point(179, 428)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 21)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Quitar Articulo"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cbeliminar
        '
        Me.cbeliminar.AutoSize = True
        Me.cbeliminar.Location = New System.Drawing.Point(19, 44)
        Me.cbeliminar.Name = "cbeliminar"
        Me.cbeliminar.Size = New System.Drawing.Size(70, 17)
        Me.cbeliminar.TabIndex = 16
        Me.cbeliminar.Text = "Eliminar"
        Me.cbeliminar.UseVisualStyleBackColor = True
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(176, 233)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(112, 13)
        Me.inexistente.TabIndex = 4
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos Inexistentes"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Location = New System.Drawing.Point(16, 75)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(445, 347)
        Me.datalistado.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.txtstock)
        Me.GroupBox1.Controls.Add(Me.txtcantidad)
        Me.GroupBox1.Controls.Add(Me.txtpreciounitario)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnbuscarproducto)
        Me.GroupBox1.Controls.Add(Me.txtnombreproducto)
        Me.GroupBox1.Controls.Add(Me.txtidproducto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbtipodoc)
        Me.GroupBox1.Controls.Add(Me.txtfecha)
        Me.GroupBox1.Controls.Add(Me.txtnombrecliente)
        Me.GroupBox1.Controls.Add(Me.btnguardar)
        Me.GroupBox1.Controls.Add(Me.btncancelar)
        Me.GroupBox1.Controls.Add(Me.btnnuevo)
        Me.GroupBox1.Controls.Add(Me.txtnumdoc)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtidcliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtidventa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 462)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(225, 226)
        Me.txtstock.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtstock.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(74, 20)
        Me.txtstock.TabIndex = 29
        Me.txtstock.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(81, 226)
        Me.txtcantidad.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(74, 20)
        Me.txtcantidad.TabIndex = 28
        '
        'txtpreciounitario
        '
        Me.txtpreciounitario.Location = New System.Drawing.Point(123, 261)
        Me.txtpreciounitario.Name = "txtpreciounitario"
        Me.txtpreciounitario.Size = New System.Drawing.Size(130, 20)
        Me.txtpreciounitario.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Precio unitario:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(177, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Stock:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Cantidad:"
        '
        'btnbuscarproducto
        '
        Me.btnbuscarproducto.BackColor = System.Drawing.Color.Gainsboro
        Me.btnbuscarproducto.Location = New System.Drawing.Point(245, 193)
        Me.btnbuscarproducto.Name = "btnbuscarproducto"
        Me.btnbuscarproducto.Size = New System.Drawing.Size(55, 21)
        Me.btnbuscarproducto.TabIndex = 23
        Me.btnbuscarproducto.Text = "..."
        Me.btnbuscarproducto.UseVisualStyleBackColor = False
        '
        'txtnombreproducto
        '
        Me.txtnombreproducto.Location = New System.Drawing.Point(138, 193)
        Me.txtnombreproducto.Name = "txtnombreproducto"
        Me.txtnombreproducto.Size = New System.Drawing.Size(101, 20)
        Me.txtnombreproducto.TabIndex = 22
        '
        'txtidproducto
        '
        Me.txtidproducto.Location = New System.Drawing.Point(94, 193)
        Me.txtidproducto.Name = "txtidproducto"
        Me.txtidproducto.Size = New System.Drawing.Size(36, 20)
        Me.txtidproducto.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Producto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "# Documento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = " Documento Tipo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha:"
        '
        'txtidcliente
        '
        Me.txtidcliente.Enabled = False
        Me.txtidcliente.Location = New System.Drawing.Point(94, 54)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.Size = New System.Drawing.Size(36, 20)
        Me.txtidcliente.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cliente:"
        '
        'txtidventa
        '
        Me.txtidventa.Enabled = False
        Me.txtidventa.Location = New System.Drawing.Point(94, 21)
        Me.txtidventa.Name = "txtidventa"
        Me.txtidventa.Size = New System.Drawing.Size(36, 20)
        Me.txtidventa.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Venta:"
        '
        'errorcono
        '
        Me.errorcono.ContainerControl = Me
        '
        'frmdetalle_venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 487)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmdetalle_venta"
        Me.Text = ".:. Detalle de venta .:."
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtstock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbtipodoc As ComboBox
    Friend WithEvents txtfecha As DateTimePicker
    Friend WithEvents txtnombrecliente As TextBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents txtnumdoc As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbeliminar As CheckBox
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtidcliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtidventa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents errorcono As ErrorProvider
    Friend WithEvents btnbuscarproducto As Button
    Friend WithEvents txtnombreproducto As TextBox
    Friend WithEvents txtidproducto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtstock As NumericUpDown
    Friend WithEvents txtcantidad As NumericUpDown
    Friend WithEvents txtpreciounitario As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
End Class
