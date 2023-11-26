<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmproductos
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
        Me.cbeliminar = New System.Windows.Forms.CheckBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.txtpreciocompra = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cmbcampo = New System.Windows.Forms.ComboBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.txtidcategoria = New System.Windows.Forms.TextBox()
        Me.errorcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidproducto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnlimpiar = New System.Windows.Forms.PictureBox()
        Me.btncargar = New System.Windows.Forms.PictureBox()
        Me.imagen = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtvencimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtprecioventa = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnbuscarcategoria = New System.Windows.Forms.Button()
        Me.txtnomcategoria = New System.Windows.Forms.TextBox()
        Me.dlg = New System.Windows.Forms.OpenFileDialog()
        Me.txtflag = New System.Windows.Forms.TextBox()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btnlimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btncargar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(133, 418)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(71, 36)
        Me.btnguardar.TabIndex = 15
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(219, 418)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(71, 36)
        Me.btncancelar.TabIndex = 14
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.Location = New System.Drawing.Point(133, 418)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(71, 36)
        Me.btneditar.TabIndex = 13
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.Gainsboro
        Me.btnnuevo.Location = New System.Drawing.Point(47, 418)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(71, 36)
        Me.btnnuevo.TabIndex = 12
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'txtpreciocompra
        '
        Me.txtpreciocompra.Location = New System.Drawing.Point(90, 204)
        Me.txtpreciocompra.MaxLength = 10
        Me.txtpreciocompra.Name = "txtpreciocompra"
        Me.txtpreciocompra.Size = New System.Drawing.Size(130, 20)
        Me.txtpreciocompra.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "$ Compra:"
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(90, 174)
        Me.txtstock.MaxLength = 10
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(130, 20)
        Me.txtstock.TabIndex = 9
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(199, 218)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(112, 13)
        Me.inexistente.TabIndex = 4
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos Inexistentes"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(157, 16)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(303, 20)
        Me.txtbuscar.TabIndex = 3
        '
        'cmbcampo
        '
        Me.cmbcampo.FormattingEnabled = True
        Me.cmbcampo.Items.AddRange(New Object() {"nombre", "nombre_categoria"})
        Me.cmbcampo.Location = New System.Drawing.Point(16, 16)
        Me.cmbcampo.Name = "cmbcampo"
        Me.cmbcampo.Size = New System.Drawing.Size(130, 21)
        Me.cmbcampo.TabIndex = 2
        Me.cmbcampo.Text = "nombre"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Location = New System.Drawing.Point(16, 66)
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Stock:"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(90, 106)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdescripcion.Size = New System.Drawing.Size(225, 56)
        Me.txtdescripcion.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Descripción:"
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(375, 419)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(86, 37)
        Me.btneliminar.TabIndex = 15
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'txtidcategoria
        '
        Me.txtidcategoria.Location = New System.Drawing.Point(90, 76)
        Me.txtidcategoria.Name = "txtidcategoria"
        Me.txtidcategoria.Size = New System.Drawing.Size(43, 20)
        Me.txtidcategoria.TabIndex = 5
        '
        'errorcono
        '
        Me.errorcono.ContainerControl = Me
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Categoria:"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(90, 46)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(130, 20)
        Me.txtnombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Producto:"
        '
        'txtidproducto
        '
        Me.txtidproducto.Location = New System.Drawing.Point(90, 17)
        Me.txtidproducto.Name = "txtidproducto"
        Me.txtidproducto.Size = New System.Drawing.Size(130, 20)
        Me.txtidproducto.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Producto:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtflag)
        Me.GroupBox2.Controls.Add(Me.cbeliminar)
        Me.GroupBox2.Controls.Add(Me.btneliminar)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.cmbcampo)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(347, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(466, 462)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = ".:. Productos .:."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.btnlimpiar)
        Me.GroupBox1.Controls.Add(Me.btncargar)
        Me.GroupBox1.Controls.Add(Me.imagen)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtvencimiento)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtprecioventa)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnbuscarcategoria)
        Me.GroupBox1.Controls.Add(Me.txtnomcategoria)
        Me.GroupBox1.Controls.Add(Me.btnguardar)
        Me.GroupBox1.Controls.Add(Me.btncancelar)
        Me.GroupBox1.Controls.Add(Me.btneditar)
        Me.GroupBox1.Controls.Add(Me.btnnuevo)
        Me.GroupBox1.Controls.Add(Me.txtpreciocompra)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtstock)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtidcategoria)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtidproducto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 463)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackgroundImage = Global.sisventas.My.Resources.Resources.gtk_close1
        Me.btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlimpiar.Location = New System.Drawing.Point(221, 357)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(52, 52)
        Me.btnlimpiar.TabIndex = 27
        Me.btnlimpiar.TabStop = False
        '
        'btncargar
        '
        Me.btncargar.BackgroundImage = Global.sisventas.My.Resources.Resources.picture_add1
        Me.btncargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncargar.Location = New System.Drawing.Point(221, 297)
        Me.btncargar.Name = "btncargar"
        Me.btncargar.Size = New System.Drawing.Size(52, 52)
        Me.btncargar.TabIndex = 26
        Me.btncargar.TabStop = False
        '
        'imagen
        '
        Me.imagen.BackgroundImage = Global.sisventas.My.Resources.Resources.clipping_picture1
        Me.imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imagen.Location = New System.Drawing.Point(90, 296)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(114, 114)
        Me.imagen.TabIndex = 25
        Me.imagen.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 303)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Imagen:"
        '
        'txtvencimiento
        '
        Me.txtvencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtvencimiento.Location = New System.Drawing.Point(90, 266)
        Me.txtvencimiento.Name = "txtvencimiento"
        Me.txtvencimiento.Size = New System.Drawing.Size(200, 20)
        Me.txtvencimiento.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Caducidad:"
        '
        'txtprecioventa
        '
        Me.txtprecioventa.Location = New System.Drawing.Point(90, 234)
        Me.txtprecioventa.MaxLength = 10
        Me.txtprecioventa.Name = "txtprecioventa"
        Me.txtprecioventa.Size = New System.Drawing.Size(130, 20)
        Me.txtprecioventa.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "$ Venta:"
        '
        'btnbuscarcategoria
        '
        Me.btnbuscarcategoria.BackColor = System.Drawing.Color.Gainsboro
        Me.btnbuscarcategoria.Location = New System.Drawing.Point(267, 76)
        Me.btnbuscarcategoria.Name = "btnbuscarcategoria"
        Me.btnbuscarcategoria.Size = New System.Drawing.Size(48, 21)
        Me.btnbuscarcategoria.TabIndex = 17
        Me.btnbuscarcategoria.Text = "..."
        Me.btnbuscarcategoria.UseVisualStyleBackColor = False
        '
        'txtnomcategoria
        '
        Me.txtnomcategoria.Location = New System.Drawing.Point(139, 76)
        Me.txtnomcategoria.Name = "txtnomcategoria"
        Me.txtnomcategoria.Size = New System.Drawing.Size(123, 20)
        Me.txtnomcategoria.TabIndex = 16
        '
        'dlg
        '
        Me.dlg.FileName = "OpenFileDialog1"
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(413, 40)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(48, 20)
        Me.txtflag.TabIndex = 17
        Me.txtflag.Text = "0"
        Me.txtflag.Visible = False
        '
        'frmproductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(820, 487)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmproductos"
        Me.Text = ".:. Listado de Productos .:."
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btnlimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btncargar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbeliminar As CheckBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents txtpreciocompra As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtstock As TextBox
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents cmbcampo As ComboBox
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btneliminar As Button
    Friend WithEvents txtidcategoria As TextBox
    Friend WithEvents errorcono As ErrorProvider
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtidproducto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnomcategoria As TextBox
    Friend WithEvents btnbuscarcategoria As Button
    Friend WithEvents txtprecioventa As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents imagen As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtvencimiento As DateTimePicker
    Friend WithEvents btnlimpiar As PictureBox
    Friend WithEvents btncargar As PictureBox
    Friend WithEvents dlg As OpenFileDialog
    Friend WithEvents txtflag As TextBox
End Class
