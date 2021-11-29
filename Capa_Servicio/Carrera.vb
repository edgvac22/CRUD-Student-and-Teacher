Imports Capa_Datos
Imports System.Windows.Forms

Public Class Carrera
    Private _cod_carrera As String
    Private _carrera As String
    Dim obj_BD As BD
    Dim lista_parametros As List(Of Parametros)

    Public Sub New()
        obj_BD = New BD()
        lista_parametros = New List(Of Parametros)
        _cod_carrera = ""
        _carrera = ""

    End Sub

    Public Property cod_carrera As String
        Get
            Return _cod_carrera
        End Get
        Set(value As String)
            _cod_carrera = value
        End Set
    End Property

    Public Property carrera As String
        Get
            Return _carrera
        End Get
        Set(value As String)
            _carrera = value
        End Set
    End Property

    Public Function cargar(ByRef cb As ComboBox, cod_facultad As String)
        lista_parametros.Clear()
        lista_parametros.Add(New Parametros("@cod_facultad", cod_facultad))
        cb.DataSource = obj_BD.SP_Reader("sp_Carrera_Select", lista_parametros).Tables(0)
        cb.DisplayMember = "carrera"
        cb.ValueMember = "cod_carrera"
    End Function

End Class
