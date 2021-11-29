Imports System.Data.SqlClient
Imports Capa_Datos

Public Class Profe

    Dim obj_BD As BD
    Dim lista_parametros As List(Of Parametros)
    Dim connection As SqlConnection

    Private _codigo, _cedula, _nombre, _apellido, _direccion, _celular, _correo, _facultad, _categoria, _status, _radio As String
    Private _salario As Decimal

    Public Sub New()
        obj_BD = New BD()
        lista_parametros = New List(Of Parametros)
        connection = obj_BD.conexion()
        _codigo = ""
        _cedula = ""
        _nombre = ""
        _apellido = ""
        _direccion = ""
        _celular = ""
        _correo = ""
        _facultad = ""
        _categoria = ""
        _status = ""
    End Sub

    Public Property radio As String
        Get
            Return _radio
        End Get
        Set(value As String)
            _radio = value
        End Set
    End Property

    Public Property codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    Public Property cedula As String
        Get
            Return _cedula
        End Get
        Set(value As String)
            _cedula = value
        End Set
    End Property

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property


    Public Property celular As String
        Get
            Return _celular
        End Get
        Set(value As String)
            _celular = value
        End Set
    End Property

    Public Property correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
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

    Public Property categoria As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property

    Public Property salario As Decimal
        Get
            Return _salario
        End Get
        Set(value As Decimal)
            _salario = value
        End Set
    End Property

    Public Property status As String
        Get
            Return _status
        End Get
        Set(value As String)
            _status = value
        End Set
    End Property

    Public Function listar(_radio) As DataSet
        Dim ds As New DataSet()

        lista_parametros.Clear()
        lista_parametros.Add(New Parametros("@orden", _radio))
        ds = obj_BD.SP_Reader("sp_Profesor_Select", lista_parametros)

        ds.Tables(0).Columns.Remove("id")
        ds.Tables(0).Columns.Remove("direccion")
        ds.Tables(0).Columns.Remove("celular")
        ds.Tables(0).Columns.Remove("correo")
        ds.Tables(0).Columns.Remove("cod_facultad")
        ds.Tables(0).Columns.Remove("cod_categoria")
        ds.Tables(0).Columns.Remove("salario_base")
        ds.Tables(0).Columns.Remove("estatus")
        ds.Tables(0).Columns.Remove("id1")
        ds.Tables(0).Columns.Remove("id2")
        ds.Tables(0).Columns.Remove("codigo1")
        ds.Tables(0).Columns.Remove("codigo2")
        Return ds
    End Function

    Public Function buscar(codigo As String) As Boolean
        Dim ds As New DataSet()
        Dim encontrado As Boolean
        encontrado = False
        _codigo = codigo
        Try
            lista_parametros.Clear()
            lista_parametros.Add(New Parametros("@codigo", _codigo))

            ds = obj_BD.SP_Reader("sp_Profesor_Select", lista_parametros)

            If ds.Tables(0).Rows.Count() > 0 Then
                encontrado = True
                _cedula = ds.Tables(0).Rows(0).Item("cedula")
                _nombre = ds.Tables(0).Rows(0).Item("nombre")
                _apellido = ds.Tables(0).Rows(0).Item("apellido")
                _direccion = ds.Tables(0).Rows(0).Item("direccion")
                _celular = ds.Tables(0).Rows(0).Item("celular")
                _correo = ds.Tables(0).Rows(0).Item("correo")
                _facultad = ds.Tables(0).Rows(0).Item("cod_facultad")
                _categoria = ds.Tables(0).Rows(0).Item("cod_categoria")
                _salario = ds.Tables(0).Rows(0).Item("salario_base")
                _status = ds.Tables(0).Rows(0).Item("estatus")
            Else
                encontrado = False
                _cedula = ""
                _nombre = ""
                _apellido = ""
                _direccion = ""
                _celular = ""
                _correo = ""
                _facultad = ""
                _categoria = ""
                _status = ""
            End If

            Return encontrado

        Catch ex As Exception
            MsgBox("error" & ex.ToString)
        Finally
            connection.Close()
        End Try
    End Function

    Public Function agregar() As Boolean
        asignar_parametros()
        Return obj_BD.SP_NoQuery("sp_Profesor_Insert", lista_parametros)
    End Function

    Public Function actualizar() As Boolean
        asignar_parametros()
        Return obj_BD.SP_NoQuery("sp_Profesor_Update", lista_parametros)
    End Function

    Public Function eliminar() As Boolean
        lista_parametros.Clear()
        lista_parametros.Add(New Parametros("@codigo", _codigo))
        Return obj_BD.SP_NoQuery("sp_Profesor_Delete", lista_parametros)
    End Function

    Private Sub asignar_parametros()
        lista_parametros.Clear()
        lista_parametros.Add(New Parametros("@codigo", _codigo))
        lista_parametros.Add(New Parametros("@cedula", _cedula))
        lista_parametros.Add(New Parametros("@nombre", _nombre))
        lista_parametros.Add(New Parametros("@apellido", _apellido))
        lista_parametros.Add(New Parametros("@direccion", _direccion))
        lista_parametros.Add(New Parametros("@celular", _celular))
        lista_parametros.Add(New Parametros("@correo", _correo))
        lista_parametros.Add(New Parametros("@cod_facultad", _facultad))
        lista_parametros.Add(New Parametros("@cod_categoria", _categoria))
        lista_parametros.Add(New Parametros("@salario_base", _salario))
        lista_parametros.Add(New Parametros("@estatus", _status))
    End Sub

End Class
