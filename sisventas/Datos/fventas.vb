'importamos la libreria para trabajar con sql server'
Imports System.Data.SqlClient
Public Class fventas
    Inherits conexion_base_datos
    Dim cmd As New SqlCommand


    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_venta")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cnn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt

            Else
                Return Nothing
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            desconectado()

        End Try
    End Function

    Public Function insertar(ByVal dts As vventa) As Boolean 'Llamamos al objeto que es esta en la clase vventa'
        Try
            conectado()
            cmd = New SqlCommand("insertar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            'Envío todos los parametros'
            cmd.Parameters.AddWithValue("@id_cliente", dts.gid_cliente)
            cmd.Parameters.AddWithValue("@fecha_venta", dts.gfecha_venta)
            cmd.Parameters.AddWithValue("@tipo_doc", dts.gtipo_doc)
            cmd.Parameters.AddWithValue("@num_doc", dts.gnum_doc)

            If cmd.ExecuteNonQuery Then
                Return True

            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function editar(ByVal dts As vventa) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_venta", dts.gid_venta)
            cmd.Parameters.AddWithValue("@id_cliente", dts.gid_cliente)
            cmd.Parameters.AddWithValue("@fecha_venta", dts.gfecha_venta)
            cmd.Parameters.AddWithValue("@tipo_doc", dts.gtipo_doc)
            cmd.Parameters.AddWithValue("@num_doc", dts.gnum_doc)


            If cmd.ExecuteNonQuery Then
                Return True

            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function eliminar(ByVal dts As vventa) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@id_venta", SqlDbType.NVarChar, 50).Value = dts.gid_venta
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function
End Class
