Public Class frmventa
    Private dt As DataTable

    Private Sub frmventa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtidcliente.Text = ""
        txtnombrecliente.Text = ""
        txtnumdoc.Text = ""
        txtnumdoc.Text = ""
        txtidventa.Text = ""

    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fventas
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


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtidcliente.Text <> "" And txtnombrecliente.Text <> "" And txtnumdoc.Text <> "" And txtnumdoc.Text <> "" Then

            Try
                Dim dts As New vventa
                Dim func As New fventas

                dts.gid_cliente = txtidcliente.Text
                dts.gfecha_venta = txtfecha.Text
                dts.gtipo_doc = cbtipodoc.Text
                dts.gnum_doc = txtnumdoc.Text


                If func.insertar(dts) Then
                    MessageBox.Show("Venta registrada correctamente, ", "Guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    cargar_detalle() 'Llamamos aun proceso llamado cargar detalle'
                Else
                    MessageBox.Show("Venta no registrada", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtidventa.Text = datalistado.SelectedCells.Item(1).Value
        txtidcliente.Text = datalistado.SelectedCells.Item(2).Value
        txtnombrecliente.Text = datalistado.SelectedCells.Item(3).Value
        txtfecha.Text = datalistado.SelectedCells.Item(5).Value
        cbtipodoc.Text = datalistado.SelectedCells.Item(6).Value
        txtnumdoc.Text = datalistado.SelectedCells.Item(7).Value

        btneditar.Visible = True
        btnguardar.Visible = False
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("¿Realmente desea editar los datos del la venta?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then


            If Me.ValidateChildren = True And txtidcliente.Text <> "" And txtnumdoc.Text <> "" And txtidventa.Text <> "" Then

                Try
                    Dim dts As New vventa
                    Dim func As New fventas

                    dts.gid_venta = txtidventa.Text
                    dts.gid_cliente = txtidcliente.Text
                    dts.gfecha_venta = txtfecha.Text
                    dts.gtipo_doc = cbtipodoc.Text
                    dts.gnum_doc = txtnumdoc.Text

                    If func.editar(dts) Then
                        MessageBox.Show("Venta modificada correctamente", "Guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Venta sin modificaciones", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click

    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtidcliente.Validating

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()
    End Sub

    Private Sub cargar_detalle()
        frmdetalle_venta.txtidventa.Text = datalistado.SelectedCells.Item(1).Value
        frmdetalle_venta.txtidcliente.Text = datalistado.SelectedCells.Item(2).Value
        frmdetalle_venta.txtnombrecliente.Text = datalistado.SelectedCells.Item(3).Value
        frmdetalle_venta.txtfecha.Text = datalistado.SelectedCells.Item(5).Value
        frmdetalle_venta.cbtipodoc.Text = datalistado.SelectedCells.Item(6).Value
        frmdetalle_venta.txtnumdoc.Text = datalistado.SelectedCells.Item(7).Value

        frmdetalle_venta.ShowDialog()
    End Sub

    Private Sub datalistado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentDoubleClick
        cargar_detalle()
    End Sub

    Private Sub btnbuscar_cliente_Click(sender As Object, e As EventArgs) Handles btnbuscar_cliente.Click
        frmcliente.txtflag.Text = "1" 'lo que esta en cero, conviertelo en 1 y enviale un mensaje mediante este cuadro de dialogo'
        frmcliente.ShowDialog()

    End Sub
End Class