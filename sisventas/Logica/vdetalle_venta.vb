Public Class vdetalle_venta

    Dim id_detalle_venta, id_venta, id_producto As Integer
    Dim cantidad, precio_unitario As Decimal

    Public Property gid_detalle_venta
        Get
            Return id_detalle_venta
        End Get

        Set(value)
            id_detalle_venta = value
        End Set
    End Property

    Public Property gid_venta
        Get
            Return id_venta
        End Get

        Set(value)
            id_venta = value
        End Set
    End Property

    Public Property gid_producto
        Get
            Return id_producto
        End Get

        Set(value)
            id_producto = value
        End Set
    End Property

    Public Property gcantidad
        Get
            Return cantidad
        End Get

        Set(value)
            cantidad = value
        End Set
    End Property

    Public Property gprecio_unitario
        Get
            Return precio_unitario
        End Get

        Set(value)
            precio_unitario = value
        End Set
    End Property

    Public Sub New()

    End Sub


    Public Sub New(ByVal id_detalle_venta As Integer, ByVal id_venta As Integer, ByVal id_producto As Integer, ByVal cantidad As Decimal, ByVal precio_unitario As Decimal)

        gid_detalle_venta = id_detalle_venta
        gid_venta = id_venta
        gid_producto = id_producto
        gcantidad = cantidad
        gprecio_unitario = precio_unitario


    End Sub
End Class
