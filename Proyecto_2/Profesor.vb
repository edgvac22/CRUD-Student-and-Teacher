Imports Capa_Servicio
Imports System.Text.RegularExpressions

Public Class Profesor

    Dim obj_Profe As Profe = New Profe()
    Dim obj_Facultad As Facultad = New Facultad()
    Dim obj_Categoria As Categoria = New Categoria()
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        obj_Facultad.cargar(cb_Facultad)
        cb_Facultad.SelectedValue = "00"
        obj_Categoria.cargar(cb_Categoria)
        cb_Categoria.SelectedValue = "00"
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

    Private Sub ms_Estudiante_Click(sender As Object, e As EventArgs) Handles ms_Estudiante.Click
        Estudiante.Show()
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        txt_Codigo.Enabled = True
        txt_Codigo.Text = ""
        txt_Cedula.Text = ""
        txt_Nombre.Text = ""
        txt_Apellido.Text = ""
        txt_Direccion.Text = ""
        txt_Celular.Text = ""
        txt_Correo.Text = ""
        cb_Facultad.SelectedValue = "00"
        cb_Categoria.SelectedValue = "00"
        txt_Salario.Text = ""
        txt_Estatus.Text = ""
        btn_Buscar.Enabled = True

        txt_Cedula.Enabled = False
        txt_Nombre.Enabled = False
        txt_Apellido.Enabled = False
        txt_Direccion.Enabled = False
        txt_Celular.Enabled = False
        txt_Correo.Enabled = False
        cb_Facultad.Enabled = False
        cb_Categoria.Enabled = False
        txt_Salario.Enabled = False
        txt_Estatus.Enabled = False
    End Sub

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        If txt_Estatus.Text = "A" Then
            obj_Profe.cedula = txt_Cedula.Text
            obj_Profe.nombre = txt_Nombre.Text
            obj_Profe.apellido = txt_Apellido.Text
            obj_Profe.direccion = txt_Direccion.Text
            obj_Profe.celular = txt_Celular.Text
            obj_Profe.correo = txt_Correo.Text
            obj_Profe.facultad = cb_Facultad.SelectedValue
            obj_Profe.categoria = cb_Categoria.SelectedValue
            obj_Profe.salario = txt_Salario.Text
            obj_Profe.status = txt_Estatus.Text

            If obj_Profe.actualizar() Then
                MsgBox("Estudiante modificado. Estatus Activo")
            Else
                MsgBox("Error al modificar estudiante")
            End If
        ElseIf txt_Estatus.Text = "I" Then
            obj_Profe.cedula = txt_Cedula.Text
            obj_Profe.nombre = txt_Nombre.Text
            obj_Profe.apellido = txt_Apellido.Text
            obj_Profe.direccion = txt_Direccion.Text
            obj_Profe.celular = txt_Celular.Text
            obj_Profe.correo = txt_Correo.Text
            obj_Profe.facultad = cb_Facultad.SelectedValue
            obj_Profe.categoria = cb_Categoria.SelectedValue
            obj_Profe.salario = txt_Salario.Text
            obj_Profe.status = txt_Estatus.Text

            If obj_Profe.actualizar() Then
                MsgBox("Estudiante modificado. Está inactivo.")
                txt_Cedula.Enabled = False
                txt_Nombre.Enabled = False
                txt_Apellido.Enabled = False
                txt_Direccion.Enabled = False
                txt_Correo.Enabled = False
                txt_Celular.Enabled = False
                cb_Facultad.Enabled = False
                cb_Categoria.Enabled = False
                txt_Salario.Enabled = False
            Else
                MsgBox("Error al modificar estudiante")
            End If
        Else
            MsgBox("Solo se permiten las letras A (usuario activo), I (usuario inactivo)")
        End If
    End Sub

    Private Sub btn_Listar_Click(sender As Object, e As EventArgs) Handles btn_Listar.Click

        If rb_Codigo.Checked Then
            dgv_Profesor.DataSource = obj_Profe.listar("codigo").Tables(0)
        ElseIf rb_Cedula.Checked Then
            dgv_Profesor.DataSource = obj_Profe.listar("cedula").Tables(0)
        ElseIf rb_Nombre.Checked Then
            dgv_Profesor.DataSource = obj_Profe.listar("nombre").Tables(0)
        ElseIf rb_Apellido.Checked Then
            dgv_Profesor.DataSource = obj_Profe.listar("apellido").Tables(0)
        Else
            MsgBox("No está mandando ningun parámetro")
        End If
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        If obj_Profe.buscar(txt_Codigo.Text) Then
            txt_Cedula.Text = obj_Profe.cedula
            txt_Nombre.Text = obj_Profe.nombre
            txt_Apellido.Text = obj_Profe.apellido
            txt_Direccion.Text = obj_Profe.direccion
            txt_Celular.Text = obj_Profe.celular
            txt_Correo.Text = obj_Profe.correo
            cb_Facultad.SelectedValue = obj_Profe.facultad
            cb_Categoria.SelectedValue = obj_Profe.categoria
            txt_Salario.Text = obj_Profe.salario
            txt_Estatus.Text = obj_Profe.status
            btn_Modificar.Enabled = True
            btn_Eliminar.Enabled = True
            btn_Agregar.Enabled = False
            txt_Codigo.Enabled = False
            txt_Cedula.Enabled = False
            txt_Nombre.Enabled = True
            txt_Apellido.Enabled = True
            txt_Direccion.Enabled = True
            txt_Celular.Enabled = True
            txt_Correo.Enabled = True
            cb_Facultad.Enabled = True
            cb_Categoria.Enabled = True
            txt_Salario.Enabled = True
            txt_Estatus.Enabled = True
            btn_Buscar.Enabled = False
        Else
            txt_Nombre.Text = ""
            txt_Apellido.Text = ""
            txt_Direccion.Text = ""
            txt_Celular.Text = ""
            txt_Correo.Text = ""
            cb_Facultad.SelectedValue = "00"
            cb_Categoria.SelectedValue = "00"
            txt_Salario.Text = ""
            txt_Estatus.Text = ""
            txt_Codigo.Enabled = False
            txt_Cedula.Enabled = True
            txt_Nombre.Enabled = True
            txt_Apellido.Enabled = True
            txt_Direccion.Enabled = True
            txt_Celular.Enabled = True
            txt_Correo.Enabled = True
            cb_Facultad.Enabled = True
            cb_Categoria.Enabled = True
            txt_Salario.Enabled = True
            txt_Estatus.Enabled = True
            btn_Agregar.Enabled = True
            btn_Buscar.Enabled = False
            btn_Modificar.Enabled = False
            btn_Eliminar.Enabled = False
        End If
    End Sub

    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        obj_Profe.cedula = txt_Cedula.Text
        obj_Profe.nombre = txt_Nombre.Text
        obj_Profe.apellido = txt_Apellido.Text
        obj_Profe.direccion = txt_Direccion.Text
        obj_Profe.celular = txt_Celular.Text
        obj_Profe.correo = txt_Correo.Text
        obj_Profe.facultad = cb_Facultad.SelectedValue
        obj_Profe.categoria = cb_Categoria.SelectedValue
        obj_Profe.salario = txt_Salario.Text
        obj_Profe.status = txt_Estatus.Text

        If obj_Profe.agregar() Then
            MsgBox("Estudiante agregado")
        Else
            MsgBox("Error al agregar al estudiante")
        End If
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

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        If obj_Profe.eliminar() Then
            MsgBox("Estudiante eliminado")
        Else
            MsgBox("Error al eliminar estudiante")
        End If
    End Sub
End Class