Public Class vcliente
    Dim id_cliente As Integer
    Dim nombre, apellidos, direccion, telefono, dni As String

    'seeter y getter

    Public Property gid_cliente
        Get
            Return id_cliente

        End Get
        Set(ByVal value)
            id_cliente = value

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

    Public Property gapellidos
        Get
            Return apellidos
        End Get
        Set(ByVal value)
            apellidos = value

        End Set
    End Property

    Public Property gdireccion
        Get
            Return direccion
        End Get
        Set(ByVal value)
            direccion = value

        End Set
    End Property

    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(ByVal value)
            telefono = value

        End Set
    End Property

    Public Property gdni
        Get
            Return dni
        End Get
        Set(ByVal value)
            dni = value

        End Set
    End Property

    'constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal id_cliente As Integer, ByVal nombre As String, ByVal apellidos As String, ByVal direccion As String,
                   ByVal telefono As String, ByVal dni As String)

        gid_cliente = id_cliente
        gnombre = nombre
        gapellidos = apellidos
        gdireccion = direccion
        gtelefono = telefono
        gdni = dni
    End Sub

End Class
