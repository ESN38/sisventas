﻿Public Class vproductos
    Dim id_producto, id_categoria As Integer
    Dim nombre, descripcion As String
    Dim stock, precio_compra, precio_venta As Double
    Dim fecha_vencimiento As Date
    Dim imagen() As Byte


    Public Property gid_producto
        Get
            Return id_producto

        End Get
        Set(ByVal value)
            id_producto = value

        End Set
    End Property

    Public Property gid_categoria
        Get
            Return id_categoria

        End Get
        Set(ByVal value)
            id_categoria = value

        End Set
    End Property

    Public Property gnombre
        Get
            Return nombre

        End Get
        Set(ByVal value)
            nombre = value

        End Set
    End Property

    Public Property gdescripcion
        Get
            Return descripcion

        End Get
        Set(ByVal value)
            descripcion = value

        End Set
    End Property

    Public Property gstock
        Get
            Return stock

        End Get
        Set(ByVal value)
            stock = value

        End Set
    End Property

    Public Property gprecio_compra
        Get
            Return precio_compra

        End Get
        Set(ByVal value)
            precio_compra = value

        End Set
    End Property

    Public Property gprecio_venta
        Get
            Return precio_venta

        End Get
        Set(ByVal value)
            precio_venta = value

        End Set
    End Property

    Public Property gfecha_vencimiento
        Get
            Return fecha_vencimiento

        End Get
        Set(ByVal value)
            fecha_vencimiento = value

        End Set
    End Property

    Public Property gimagen
        Get
            Return imagen

        End Get
        Set(ByVal value)
            imagen = value

        End Set
    End Property


    Public Sub New()

    End Sub

    Public Sub New(ByVal id_producto As Integer, ByVal id_categoria As Integer, ByVal nombre As String, ByVal descripcion As String, ByVal stock As Double, ByVal precio_compra As Double, ByVal precio_venta As Double, ByVal fecha_vencimiento As Date, ByVal imagen() As Byte)

        gid_producto = id_producto
        gid_categoria = id_categoria
        gnombre = nombre
        gdescripcion = descripcion
        gstock = stock
        gprecio_compra = precio_compra
        gprecio_venta = precio_venta
        gfecha_vencimiento = fecha_vencimiento
        gimagen = imagen



    End Sub



End Class
