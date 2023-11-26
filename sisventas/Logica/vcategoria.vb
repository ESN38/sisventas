Public Class vcategoria
    Dim idcategoria As Integer
    Dim nombre_categoria As String


    Public Property gidcategoria
        Get
            Return idcategoria
        End Get
        Set(value)
            idcategoria = value

        End Set
    End Property

    Public Property gnombre_categoria
        Get
            Return nombre_categoria
        End Get
        Set(value)
            nombre_categoria = value

        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal id_categoria As Integer, ByVal nombre_categoria As String)

        gidcategoria = id_categoria
        gnombre_categoria = nombre_categoria


    End Sub

End Class
