Imports Capa_Datos
Imports System.Windows.Forms

Public Class Categoria
    Private _codigo As String
    Private _categoria As String
    Dim obj_BD As BD

    Public Sub New()
        obj_BD = New BD()
        _codigo = ""
        _categoria = ""
    End Sub

    Public Property codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    Public Property categoria As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property

    Public Function cargar() As DataTable
        Return obj_BD.SP_Reader("sp_Categoria_Select").Tables(0)
    End Function

    Public Sub cargar(ByRef cb As ComboBox)
        cb.DataSource = obj_BD.SP_Reader("sp_Categoria_Select").Tables(0)
        cb.DisplayMember = "categoria"
        cb.ValueMember = "codigo"
    End Sub
End Class
