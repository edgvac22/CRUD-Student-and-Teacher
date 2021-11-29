Imports Capa_Datos
Imports System.Windows.Forms

Public Class Facultad
    Private _codigo As String
    Private _facultad As String
    Dim obj_BD As BD

    Public Sub New()
        obj_BD = New BD()
        _codigo = ""
        _facultad = ""
    End Sub

    Public Property codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    Public Property facultad As String
        Get
            Return _facultad
        End Get
        Set(value As String)
            _facultad = value
        End Set
    End Property

    Public Function cargar() As DataTable
        Return obj_BD.SP_Reader("sp_Facultad_Select").Tables(0)
    End Function

    Public Sub cargar(ByRef cb As ComboBox)
        cb.DataSource = obj_BD.SP_Reader("sp_Facultad_Select").Tables(0)
        cb.DisplayMember = "facultad"
        cb.ValueMember = "codigo"
    End Sub
End Class
