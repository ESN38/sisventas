
'creamos todos los campos de la tabla ventas a manera de objetos'
Public Class vventa

    'creamos o declaramos varibles segun el tipo de dato'
    Dim id_venta, id_cliente As Integer
    Dim fecha_venta As Date
    Dim tipo_doc, num_doc As String

    'creamos los metodos seter y geter'
    Public Property gid_venta 'gid_venta es un prefijo que llama al metodo geter'
        Get                   'Empezamos con el metodo Get'
            Return id_venta
        End Get
        Set(value)
            id_venta = value  'El valor que se esta guardando'

        End Set
    End Property

    Public Property gid_cliente 'gid_venta es un prefijo que llama al metodo geter'
        Get                   'Empezamos con el metodo Get'
            Return id_cliente
        End Get
        Set(value)
            id_cliente = value  'El valor que se esta guardando'

        End Set
    End Property

    Public Property gfecha_venta 'gid_venta es un prefijo que llama al metodo geter'
        Get                   'Empezamos con el metodo Get'
            Return fecha_venta
        End Get
        Set(value)
            fecha_venta = value  'El valor que se esta guardando'

        End Set
    End Property

    Public Property gtipo_doc 'gid_venta es un prefijo que llama al metodo geter'
        Get                   'Empezamos con el metodo Get'
            Return tipo_doc
        End Get
        Set(value)
            tipo_doc = value  'El valor que se esta guardando'

        End Set
    End Property

    Public Property gnum_doc 'gid_venta es un prefijo que llama al metodo geter'
        Get                   'Empezamos con el metodo Get'
            Return num_doc
        End Get
        Set(value)
            num_doc = value  'El valor que se esta guardando'

        End Set
    End Property

    'Empezamos a crear los constructores, un contructor en blanco' 
    Public Sub New()

    End Sub
    'y un segundo constructor que contiene la informacion de los campos'
    Public Sub New(ByVal id_venta As Integer, ByVal id_cliente As Integer, ByVal fecha_venta As Date, ByVal tipo_doc As String, ByVal num_doc As String)

        'todos los parametros de arriba, los guardo en los objetos g'
        gid_venta = id_venta
        gid_cliente = id_cliente
        gfecha_venta = fecha_venta
        gtipo_doc = tipo_doc
        gnum_doc = num_doc

    End Sub


End Class
