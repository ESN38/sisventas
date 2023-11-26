Public Class frmproductos

    Private dt As New DataTable
    Private Sub frmproductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtnombre.Text = ""
        txtdescripcion.Text = ""
        txtstock.Text = "0"
        txtpreciocompra.Text = "0"
        txtprecioventa.Text = "0"
        txtidproducto.Text = ""

        imagen.Image = Nothing
        imagen.BackgroundImage = My.Resources.clipping_picture1
        imagen.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fproductos
            dt = func.mostrar
            datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False

            Else
                datalistado.DataSource = Nothing
                txtbuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        btnnuevo.Visible = True
        btneditar.Visible = False

        buscar()
    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = cmbcampo.Text & " LIKE '" & txtbuscar.Text & "% '"


            If dv.Count <> 0 Then
                inexistente.Visible = False
                datalistado.DataSource = dv
                ocultar_columnas()

            Else
                inexistente.Visible = True
                datalistado.DataSource = Nothing

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
        datalistado.Columns(2).Visible = False
    End Sub


    Private Sub txtnombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorcono.SetError(sender, "")
        Else
            Me.errorcono.SetError(sender, "Ingrese el nombre del producto, dato obligatorio")
        End If
    End Sub
    Private Sub txtdescripcion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtdescripcion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorcono.SetError(sender, "")
        Else
            Me.errorcono.SetError(sender, "Ingrese la descripción del producto, dato obligatorio")
        End If
    End Sub
    Private Sub txtstock_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtstock.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorcono.SetError(sender, "")
        Else
            Me.errorcono.SetError(sender, "Ingrese la cantidad en stock del producto, dato obligatorio")
        End If
    End Sub
    Private Sub txtpreciocompra_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtpreciocompra.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorcono.SetError(sender, "")
        Else
            Me.errorcono.SetError(sender, "Ingrese el precio de compra del producto, dato obligatorio")
        End If
    End Sub
    Private Sub txtprecioventa_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtprecioventa.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorcono.SetError(sender, "")
        Else
            Me.errorcono.SetError(sender, "Ingrese el precio de venta del producto, dato obligatorio")
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" And txtdescripcion.Text <> "" And txtstock.Text <> "" And txtpreciocompra.Text <> "" And txtprecioventa.Text <> "" Then

            Try
                Dim dts As New vproductos
                Dim func As New fproductos

                dts.gnombre = txtnombre.Text
                dts.gid_categoria = txtidcategoria.Text
                dts.gdescripcion = txtdescripcion.Text
                dts.gstock = txtstock.Text
                dts.gprecio_compra = txtpreciocompra.Text
                dts.gprecio_venta = txtprecioventa.Text
                dts.gfecha_vencimiento = txtvencimiento.Text

                Dim ms As New IO.MemoryStream()

                If Not imagen.Image Is Nothing Then
                    imagen.Image.Save(ms, imagen.Image.RawFormat)
                Else
                    imagen.Image = My.Resources.clipping_picture1
                    imagen.Image.Save(ms, imagen.Image.RawFormat)

                End If
                dts.gimagen = ms.GetBuffer


                If func.insertar(dts) Then
                    MessageBox.Show("Producto registrado correctamente", "Guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("No registrado", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If


            Catch ex As Exception
                MsgBox(ex.Message)

            End Try

        Else
            MessageBox.Show("Falta ingresar algunos datos", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If




    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        txtidproducto.Text = datalistado.SelectedCells.Item(1).Value
        txtidcategoria.Text = datalistado.SelectedCells.Item(2).Value
        txtnomcategoria.Text = datalistado.SelectedCells.Item(3).Value
        txtnombre.Text = datalistado.SelectedCells.Item(4).Value
        txtdescripcion.Text = datalistado.SelectedCells.Item(5).Value
        txtstock.Text = datalistado.SelectedCells.Item(6).Value
        txtpreciocompra.Text = datalistado.SelectedCells.Item(7).Value
        txtprecioventa.Text = datalistado.SelectedCells.Item(8).Value
        txtvencimiento.Text = datalistado.SelectedCells.Item(9).Value

        imagen.BackgroundImage = Nothing
        Dim b() As Byte = datalistado.SelectedCells.Item(10).Value
        Dim ms As New IO.MemoryStream(b)

        imagen.Image = Image.FromStream(ms)
        imagen.SizeMode = PictureBoxSizeMode.StretchImage

        btneditar.Visible = True
        btnguardar.Visible = False
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("¿Realmente desea editar los datos del producto?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then


            If Me.ValidateChildren = True And txtnombre.Text <> "" And txtdescripcion.Text <> "" And txtstock.Text <> "" And txtpreciocompra.Text <> "" And txtprecioventa.Text <> "" And txtidproducto.Text <> "" Then

                Try
                    Dim dts As New vproductos
                    Dim func As New fproductos

                    dts.gid_producto = txtidproducto.Text
                    dts.gnombre = txtnombre.Text
                    dts.gid_categoria = txtidcategoria.Text
                    dts.gdescripcion = txtdescripcion.Text
                    dts.gstock = txtstock.Text
                    dts.gprecio_compra = txtpreciocompra.Text
                    dts.gprecio_venta = txtprecioventa.Text
                    dts.gfecha_vencimiento = txtvencimiento.Text

                    Dim ms As New IO.MemoryStream()

                    If Not imagen.Image Is Nothing Then
                        imagen.Image.Save(ms, imagen.Image.RawFormat)
                    Else
                        imagen.Image = My.Resources.clipping_picture1
                        imagen.Image.Save(ms, imagen.Image.RawFormat)

                    End If
                    dts.gimagen = ms.GetBuffer


                    If func.editar(dts) Then
                        MessageBox.Show("Producto modificado correctamente", "Guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Producto sin modificaciones", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If


                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try

            Else
                MessageBox.Show("Falta ingresar algunos datos", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If
        End If
    End Sub

    Private Sub cbeliminar_CheckedChanged(sender As Object, e As EventArgs) Handles cbeliminar.CheckedChanged
        If cbeliminar.CheckState = CheckState.Checked Then
            datalistado.Columns.Item("Eliminar").Visible = True
        Else
            datalistado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim result As DialogResult

        result = MessageBox.Show("¿Confirma la eliminación de los productos seleccionados?", "Eliminando resgistros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("id_producto").Value)
                        Dim vdb As New vproductos
                        Dim func As New fproductos

                        vdb.gid_producto = onekey

                        If func.eliminar(vdb) Then

                        Else
                            MessageBox.Show("Producto no eliminado", "Eliminando resgistros", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        End If
                    End If

                Next
                Call mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación", "Eliminando resgistros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()
        End If

        Call limpiar()

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtprecioventa.TextChanged

    End Sub

    Private Sub btncargar_Click(sender As Object, e As EventArgs) Handles btncargar.Click
        If dlg.ShowDialog() = DialogResult.OK Then
            imagen.BackgroundImage = Nothing
            imagen.Image = New Bitmap(dlg.FileName)
            imagen.SizeMode = PictureBoxSizeMode.StretchImage

        End If
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        imagen.Image = Nothing
        imagen.BackgroundImage = My.Resources.clipping_picture1
        imagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()
    End Sub

    Private Sub btnbuscarcategoria_Click(sender As Object, e As EventArgs) Handles btnbuscarcategoria.Click
        frmcategoria.txtflag.Text = "1"
        frmcategoria.ShowDialog()


    End Sub

    Private Sub txtstock_TextChanged(sender As Object, e As EventArgs) Handles txtstock.TextChanged

    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub datalistado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentDoubleClick
        If txtflag.Text = "1" Then
            frmdetalle_venta.txtidproducto.Text = datalistado.SelectedCells.Item(1).Value
            frmdetalle_venta.txtnombreproducto.Text = datalistado.SelectedCells.Item(2).Value
            frmdetalle_venta.txtstock.Text = datalistado.SelectedCells.Item(6).Value
            frmdetalle_venta.txtpreciounitario.Text = datalistado.SelectedCells.Item(8).Value
            Me.Close()

        End If
    End Sub
End Class



