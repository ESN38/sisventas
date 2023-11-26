'importamos la libreria para trabajar con sql server'
Imports System.Data.SqlClient
Public Class fdetalle_venta
    Inherits conexion_base_datos
    Dim cmd As New SqlCommand
    'funcion mostrar'

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_detalle_venta") 'procedimiento mostrar_detalle_venta creado en script de sql'
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
    'funcion insertar'

    Public Function insertar(ByVal dts As vdetalle_venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_detalle_venta") 'procedimiento mostrar_detalle_venta creado en script de sql'
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_venta", dts.gid_venta)
            cmd.Parameters.AddWithValue("@id_producto", dts.gid_producto)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            cmd.Parameters.AddWithValue("@precio_unitario", dts.gprecio_unitario)


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
    'funcion editar'

    Public Function editar(ByVal dts As vdetalle_venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_detalle_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_detalle_venta", dts.gid_detalle_venta)
            cmd.Parameters.AddWithValue("@id_venta", dts.gid_venta)
            cmd.Parameters.AddWithValue("@id_producto", dts.gid_producto)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            cmd.Parameters.AddWithValue("@precio_unitario", dts.gprecio_unitario)

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
    'funcion eliminar'

    Public Function eliminar(ByVal dts As vdetalle_venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_detalle_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@id_detalle_venta", SqlDbType.NVarChar, 50).Value = dts.gid_detalle_venta
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
    'funcion aumentar stock'

    Public Function aumentar_stock(ByVal dts As vdetalle_venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("aumentar_stock")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_producto", dts.gid_producto)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)


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
    'funcion disminuir stock'

    Public Function disminuir_stock(ByVal dts As vdetalle_venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("disminuir_stock")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_producto", dts.gid_producto)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)


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
End Class
