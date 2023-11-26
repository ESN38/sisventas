<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmventa
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
        Me.txtnumdoc = New System.Windows.Forms.TextBox()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cmbcampo = New System.Windows.Forms.ComboBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.errorcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidventa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbtipodoc = New System.Windows.Forms.ComboBox()
        Me.txtfecha = New System.Windows.Forms.DateTimePicker()
        Me.btnbuscar_cliente = New System.Windows.Forms.Button()
        Me.txtnombrecliente = New System.Windows.Forms.TextBox()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.btnguardar.Location = New System.Drawing.Point(132, 212)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(71, 36)
        Me.btnguardar.TabIndex = 15
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(219, 212)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(71, 36)
        Me.btncancelar.TabIndex = 14
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.Location = New System.Drawing.Point(132, 212)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(71, 36)
        Me.btneditar.TabIndex = 13
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.Gainsboro
        Me.btnnuevo.Location = New System.Drawing.Point(47, 212)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(71, 36)
        Me.btnnuevo.TabIndex = 12
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'txtnumdoc
        '
        Me.txtnumdoc.Location = New System.Drawing.Point(123, 157)
        Me.txtnumdoc.MaxLength = 10
        Me.txtnumdoc.Name = "txtnumdoc"
        Me.txtnumdoc.Size = New System.Drawing.Size(130, 20)
        Me.txtnumdoc.TabIndex = 9
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
        Me.cmbcampo.Items.AddRange(New Object() {"num_doc", "dni"})
        Me.cmbcampo.Location = New System.Drawing.Point(16, 16)
        Me.cmbcampo.Name = "cmbcampo"
        Me.cmbcampo.Size = New System.Drawing.Size(130, 21)
        Me.cmbcampo.TabIndex = 2
        Me.cmbcampo.Text = "num_doc"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
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
        'errorcono
        '
        Me.errorcono.ContainerControl = Me
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbeliminar)
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
        Me.GroupBox2.Text = ".:. Ventas .:."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.cbtipodoc)
        Me.GroupBox1.Controls.Add(Me.txtfecha)
        Me.GroupBox1.Controls.Add(Me.btnbuscar_cliente)
        Me.GroupBox1.Controls.Add(Me.txtnombrecliente)
        Me.GroupBox1.Controls.Add(Me.btnguardar)
        Me.GroupBox1.Controls.Add(Me.btncancelar)
        Me.GroupBox1.Controls.Add(Me.btneditar)
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
        Me.GroupBox1.Location = New System.Drawing.Point(8, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 286)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'cbtipodoc
        '
        Me.cbtipodoc.FormattingEnabled = True
        Me.cbtipodoc.Items.AddRange(New Object() {"Ticket" & Global.Microsoft.VisualBasic.ChrW(9), "Factura"})
        Me.cbtipodoc.Location = New System.Drawing.Point(123, 123)
        Me.cbtipodoc.Name = "cbtipodoc"
        Me.cbtipodoc.Size = New System.Drawing.Size(130, 21)
        Me.cbtipodoc.TabIndex = 19
        Me.cbtipodoc.Text = "Ticket"
        '
        'txtfecha
        '
        Me.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha.Location = New System.Drawing.Point(94, 89)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(145, 20)
        Me.txtfecha.TabIndex = 18
        '
        'btnbuscar_cliente
        '
        Me.btnbuscar_cliente.BackColor = System.Drawing.Color.Gainsboro
        Me.btnbuscar_cliente.Location = New System.Drawing.Point(245, 53)
        Me.btnbuscar_cliente.Name = "btnbuscar_cliente"
        Me.btnbuscar_cliente.Size = New System.Drawing.Size(55, 20)
        Me.btnbuscar_cliente.TabIndex = 17
        Me.btnbuscar_cliente.Text = "..."
        Me.btnbuscar_cliente.UseVisualStyleBackColor = False
        '
        'txtnombrecliente
        '
        Me.txtnombrecliente.Location = New System.Drawing.Point(138, 54)
        Me.txtnombrecliente.Name = "txtnombrecliente"
        Me.txtnombrecliente.Size = New System.Drawing.Size(101, 20)
        Me.txtnombrecliente.TabIndex = 16
        '
        'frmventa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(820, 487)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmventa"
        Me.Text = ".:. Listado de Ventas .:."
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbeliminar As CheckBox
    Friend WithEvents btnguardar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents txtnumdoc As TextBox
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents cmbcampo As ComboBox
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents errorcono As ErrorProvider
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtidcliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtidventa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtfecha As DateTimePicker
    Friend WithEvents btnbuscar_cliente As Button
    Friend WithEvents txtnombrecliente As TextBox
    Friend WithEvents cbtipodoc As ComboBox
End Class
