Imports Capa_Servicio
Imports System.Text.RegularExpressions

Public Class Estudiante

    Dim obj_Estud As Estud = New Estud()
    Dim obj_Facultad As Facultad = New Facultad()
    Dim obj_Carrera As Carrera = New Carrera()
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        obj_Facultad.cargar(cb_Facultad)
        cb_Facultad.SelectedValue = "00"
    End Sub

    Private Sub ms_Salir_Click(sender As Object, e As EventArgs) Handles ms_Salir.Click
        Application.Exit()
    End Sub

    Private Sub ms_Presentacion_Click(sender As Object, e As EventArgs) Handles ms_Presentacion.Click
        Presentacion.Show()
    End Sub

    Private Sub ms_Inicio_Click(sender As Object, e As EventArgs) Handles ms_Inicio.Click
        Inicio.Show()
    End Sub

    Private Sub ms_Profesor_Click(sender As Object, e As EventArgs) Handles ms_Profesor.Click
        Profesor.Show()
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        txt_Cedula.Enabled = True
        txt_Cedula.Text = ""
        txt_Nombre.Text = ""
        txt_Apellido.Text = ""
        txt_Direccion.Text = ""
        txt_Celular.Text = ""
        txt_Correo.Text = ""
        cb_Facultad.SelectedValue = "00"
        cb_Carrera.SelectedValue = "00"
        txt_Indice.Text = ""
        txt_Sexo.Text = ""
        txt_Estatus.Text = ""
        btn_Buscar.Enabled = True

        txt_Nombre.Enabled = False
        txt_Apellido.Enabled = False
        txt_Direccion.Enabled = False
        txt_Celular.Enabled = False
        txt_Correo.Enabled = False
        cb_Facultad.Enabled = False
        cb_Carrera.Enabled = False
        txt_Indice.Enabled = False
        txt_Sexo.Enabled = False
        txt_Estatus.Enabled = False
    End Sub

    Private Sub btn_Listar_Click(sender As Object, e As EventArgs) Handles btn_Listar.Click
        If rb_Cedula.Checked Then
            dgv_Estudiante.DataSource = obj_Estud.listar("cedula").Tables(0)
        ElseIf rb_Nombre.Checked Then
            dgv_Estudiante.DataSource = obj_Estud.listar("nombre").Tables(0)
        ElseIf rb_Apellido.Checked Then
            dgv_Estudiante.DataSource = obj_Estud.listar("apellido").Tables(0)
        Else
            MsgBox("No está mandando ningun parámetro")
        End If
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click

        If obj_Estud.buscar(txt_Cedula.Text) Then
            txt_Nombre.Text = obj_Estud.nombre
            txt_Apellido.Text = obj_Estud.apellido
            txt_Direccion.Text = obj_Estud.direccion
            txt_Celular.Text = obj_Estud.celular
            txt_Correo.Text = obj_Estud.correo
            cb_Facultad.SelectedValue = obj_Estud.facultad
            cb_Carrera.SelectedValue = obj_Estud.carrera
            txt_Indice.Text = obj_Estud.indice
            txt_Sexo.Text = obj_Estud.sexo
            txt_Estatus.Text = obj_Estud.status
            btn_Modificar.Enabled = True
            btn_Eliminar.Enabled = True
            btn_Agregar.Enabled = False
            txt_Cedula.Enabled = False
            txt_Nombre.Enabled = True
            txt_Apellido.Enabled = True
            txt_Direccion.Enabled = True
            txt_Celular.Enabled = True
            txt_Correo.Enabled = True
            cb_Facultad.Enabled = True
            cb_Carrera.Enabled = True
            txt_Indice.Enabled = True
            txt_Sexo.Enabled = True
            txt_Estatus.Enabled = True
            btn_Buscar.Enabled = False
        Else
            txt_Nombre.Text = ""
            txt_Apellido.Text = ""
            txt_Direccion.Text = ""
            txt_Celular.Text = ""
            txt_Correo.Text = ""
            cb_Facultad.SelectedValue = "00"
            cb_Carrera.SelectedValue = "00"
            txt_Indice.Text = ""
            txt_Sexo.Text = ""
            txt_Estatus.Text = ""
            txt_Cedula.Enabled = False
            txt_Nombre.Enabled = True
            txt_Apellido.Enabled = True
            txt_Direccion.Enabled = True
            txt_Celular.Enabled = True
            txt_Correo.Enabled = True
            cb_Facultad.Enabled = True
            cb_Carrera.Enabled = True
            txt_Indice.Enabled = True
            txt_Sexo.Enabled = True
            txt_Estatus.Enabled = True
            btn_Agregar.Enabled = True
            btn_Buscar.Enabled = False
        End If
    End Sub

    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click

        obj_Estud.nombre = txt_Nombre.Text
        obj_Estud.apellido = txt_Apellido.Text
        obj_Estud.direccion = txt_Direccion.Text
        obj_Estud.celular = txt_Celular.Text
        obj_Estud.correo = txt_Correo.Text
        obj_Estud.facultad = cb_Facultad.SelectedValue
        obj_Estud.carrera = cb_Carrera.SelectedValue
        obj_Estud.indice = txt_Indice.Text
        obj_Estud.sexo = txt_Sexo.Text
        obj_Estud.status = txt_Estatus.Text

        If obj_Estud.agregar() Then
            MsgBox("Estudiante agregado")
        Else
            MsgBox("Error al agregar al estudiante")
        End If
    End Sub

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click

        If txt_Estatus.Text = "A" Then
            obj_Estud.nombre = txt_Nombre.Text
            obj_Estud.apellido = txt_Apellido.Text
            obj_Estud.direccion = txt_Direccion.Text
            obj_Estud.celular = txt_Celular.Text
            obj_Estud.correo = txt_Correo.Text
            obj_Estud.facultad = cb_Facultad.SelectedValue
            obj_Estud.carrera = cb_Carrera.SelectedValue
            obj_Estud.indice = txt_Indice.Text
            obj_Estud.sexo = txt_Sexo.Text
            obj_Estud.status = txt_Estatus.Text

            If obj_Estud.actualizar() Then
                MsgBox("Estudiante modificado. Estatus Activo")
            Else
                MsgBox("Error al modificar estudiante")
            End If
        ElseIf txt_Estatus.Text = "I" Then
            obj_Estud.nombre = txt_Nombre.Text
            obj_Estud.apellido = txt_Apellido.Text
            obj_Estud.direccion = txt_Direccion.Text
            obj_Estud.celular = txt_Celular.Text
            obj_Estud.correo = txt_Correo.Text
            obj_Estud.facultad = cb_Facultad.SelectedValue
            obj_Estud.carrera = cb_Carrera.SelectedValue
            obj_Estud.indice = txt_Indice.Text
            obj_Estud.sexo = txt_Sexo.Text
            obj_Estud.status = txt_Estatus.Text

            If obj_Estud.actualizar() Then
                MsgBox("Estudiante modificado. Está inactivo.")
                txt_Nombre.Enabled = False
                txt_Apellido.Enabled = False
                txt_Direccion.Enabled = False
                txt_Correo.Enabled = False
                txt_Celular.Enabled = False
                cb_Facultad.Enabled = False
                cb_Carrera.Enabled = False
                txt_Indice.Enabled = False
                txt_Sexo.Enabled = False
            Else
                MsgBox("Error al modificar estudiante")
            End If
        Else
            MsgBox("Solo se permiten las letras A (usuario activo), I (usuario inactivo)")
        End If
    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        If obj_Estud.eliminar() Then
            MsgBox("Estudiante eliminado")
        Else
            MsgBox("Error al eliminar estudiante")
        End If
    End Sub

    Private Sub cb_facultad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Facultad.SelectedIndexChanged
        If Not cb_Facultad.SelectedValue.ToString() Is Nothing Then
            obj_Carrera.cargar(cb_Carrera, cb_Facultad.SelectedValue.ToString())
        End If
    End Sub

    Private Sub txt_Nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Nombre.KeyPress

    End Sub

    Private Sub txt_Nombre_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Nombre.Leave
        If Not Regex.Match(txt_Nombre.Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
            MsgBox("Favor colocar valores alfabéticos")
            txt_Nombre.Focus()
        End If
    End Sub

    Private Sub txt_Cedula_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Cedula.Leave
        If Not Regex.Match(txt_Cedula.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then
            MsgBox("Favor colocar valores numéricos")
            txt_Cedula.Focus()
        End If
    End Sub

    Private Sub txt_Celular_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Celular.Leave
        If Not Regex.Match(txt_Celular.Text, "^[0-9]*$", RegexOptions.IgnoreCase).Success Then
            MsgBox("Favor colocar valores numéricos")
            txt_Celular.Focus()
        End If
    End Sub

    Private Sub txt_Correo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Correo.Leave
        If Not Regex.Match(txt_Correo.Text, "^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase).Success Then
            MsgBox("Favor colocar un correo válido")
            txt_Correo.Focus()
        End If
    End Sub
End Class