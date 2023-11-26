Public Class frmcategoria
    Private dt As New DataTable
    Private Sub frmcategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub
    Private Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        txtnombrecategoria.Text = ""
        txtidcategoria.Text = ""


    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fcategoria
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
    End Sub


    Private Sub txtnombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtnombrecategoria.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorcono.SetError(sender, "")
        Else
            Me.errorcono.SetError(sender, "Ingrese el nombre de la categoria, dato obligatorio")
        End If
    End Sub



    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtnombrecategoria.Text <> "" Then

            Try
                Dim dts As New vcategoria
                Dim func As New fcategoria

                dts.gnombre_categoria = txtnombrecategoria.Text


                If func.insertar(dts) Then
                    MessageBox.Show("Categoria registrada correctamente", "Guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        txtidcategoria.Text = datalistado.SelectedCells.Item(1).Value
        txtnombrecategoria.Text = datalistado.SelectedCells.Item(2).Value

        btneditar.Visible = True
        btnguardar.Visible = False
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("¿Realmente desea editar los datos?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then


            If Me.ValidateChildren = True And txtnombrecategoria.Text <> "" Then

                Try
                    Dim dts As New vcategoria
                    Dim func As New fcategoria

                    dts.gidcategoria = txtidcategoria.Text
                    dts.gnombre_categoria = txtnombrecategoria.Text


                    If func.editar(dts) Then
                        MessageBox.Show("Categoria modificada correctamente", "Guardando registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("Sin modificaciones", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

        result = MessageBox.Show("¿Confirma la eliminación de las categorias seleccionados?", "Eliminando resgistros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("id_categoria").Value)
                        Dim vdb As New vcategoria
                        Dim func As New fcategoria

                        vdb.gidcategoria = onekey

                        If func.eliminar(vdb) Then

                        Else
                            MessageBox.Show("Categoria no eliminada", "Eliminando resgistros", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()
    End Sub

    Private Sub cmbcampo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcampo.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtflag.TextChanged

    End Sub

    Private Sub datalistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellDoubleClick
        If txtflag.Text = "1" Then
            frmproductos.txtidcategoria.Text = datalistado.SelectedCells.Item(1).Value
            frmproductos.txtnomcategoria.Text = datalistado.SelectedCells.Item(2).Value
            Me.Close()

        End If
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub
End Class