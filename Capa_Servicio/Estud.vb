Imports System.Data.SqlClient
Imports Capa_Datos

Public Class Estud

    Dim obj_BD As BD
    Dim lista_parametros As List(Of Parametros)
    Dim connection As SqlConnection

    Private _cedula, _nombre, _apellido, _direccion, _celular, _correo, _facultad, _carrera, _sexo, _status, _radio As String
    Private _indice As Decimal

    Public Sub New()
        obj_BD = New BD()
        lista_parametros = New List(Of Parametros)
        connection = obj_BD.conexion()
        _cedula = ""
        _nombre = ""
        _apellido = ""
        _direccion = ""
        _celular = ""
        _correo = ""
        _facultad = ""
        _carrera = ""
        _sexo = ""
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

    Public Property carrera As String
        Get
            Return _carrera
        End Get
        Set(value As String)
            _carrera = value
        End Set
    End Property

    Public Property indice As Decimal
        Get
            Return _indice
        End Get
        Set(value As Decimal)
            _indice = value
        End Set
    End Property

    Public Property sexo As String
        Get
            Return _sexo
        End Get
        Set(value As String)
            _sexo = value
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
        ds = obj_BD.SP_Reader("sp_Estudiante_Select", lista_parametros)

        ds.Tables(0).Columns.Remove("id")
        ds.Tables(0).Columns.Remove("direccion")
        ds.Tables(0).Columns.Remove("celular")
        ds.Tables(0).Columns.Remove("correo")
        ds.Tables(0).Columns.Remove("cod_facultad")
        ds.Tables(0).Columns.Remove("cod_carrera")
        ds.Tables(0).Columns.Remove("indice_academico")
        ds.Tables(0).Columns.Remove("sexo")
        ds.Tables(0).Columns.Remove("estatus")
        ds.Tables(0).Columns.Remove("id1")
        ds.Tables(0).Columns.Remove("id2")
        ds.Tables(0).Columns.Remove("cod_carrera1")
        ds.Tables(0).Columns.Remove("cod_facultad1")

        Return ds
    End Function

    Public Function buscar(cedula As String) As Boolean
        Dim ds As New DataSet()
        Dim encontrado As Boolean
        encontrado = False
        _cedula = cedula
        Try
            lista_parametros.Clear()
            lista_parametros.Add(New Parametros("@cedula", _cedula))

            ds = obj_BD.SP_Reader("sp_Estudiante_Select", lista_parametros)

            If ds.Tables(0).Rows.Count() > 0 Then
                encontrado = True
                _nombre = ds.Tables(0).Rows(0).Item("nombre")
                _apellido = ds.Tables(0).Rows(0).Item("apellido")
                _direccion = ds.Tables(0).Rows(0).Item("direccion")
                _celular = ds.Tables(0).Rows(0).Item("celular")
                _correo = ds.Tables(0).Rows(0).Item("correo")
                _facultad = ds.Tables(0).Rows(0).Item("cod_facultad")
                _carrera = ds.Tables(0).Rows(0).Item("cod_carrera")
                _indice = ds.Tables(0).Rows(0).Item("indice_academico")
                _sexo = ds.Tables(0).Rows(0).Item("sexo")
                _status = ds.Tables(0).Rows(0).Item("estatus")
            Else
                encontrado = False
                _nombre = ""
                _apellido = ""
                _direccion = ""
                _celular = ""
                _correo = ""
                _facultad = ""
                _carrera = ""
                _sexo = ""
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
        Return obj_BD.SP_NoQuery("sp_Estudiante_Insert", lista_parametros)
    End Function

    Public Function actualizar() As Boolean
        asignar_parametros()
        Return obj_BD.SP_NoQuery("sp_Estudiante_Update", lista_parametros)
    End Function

    Public Function eliminar() As Boolean
        lista_parametros.Clear()
        lista_parametros.Add(New Parametros("@cedula", _cedula))
        Return obj_BD.SP_NoQuery("sp_Estudiante_Delete", lista_parametros)
    End Function

    Private Sub asignar_parametros()
        lista_parametros.Clear()
        lista_parametros.Add(New Parametros("@cedula", _cedula))
        lista_parametros.Add(New Parametros("@nombre", _nombre))
        lista_parametros.Add(New Parametros("@apellido", _apellido))
        lista_parametros.Add(New Parametros("@direccion", _direccion))
        lista_parametros.Add(New Parametros("@celular", _celular))
        lista_parametros.Add(New Parametros("@correo", _correo))
        lista_parametros.Add(New Parametros("@cod_facultad", _facultad))
        lista_parametros.Add(New Parametros("@cod_carrera", _carrera))
        lista_parametros.Add(New Parametros("@indice_academico", _indice))
        lista_parametros.Add(New Parametros("@sexo", _sexo))
        lista_parametros.Add(New Parametros("@estatus", _status))
    End Sub

End Class
