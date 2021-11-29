<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profesor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ms_Menu = New System.Windows.Forms.MenuStrip()
        Me.ms_Inicio = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_Presentacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_Mantenimiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_Estudiante = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_Profesor = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_Salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.txt_Apellido = New System.Windows.Forms.TextBox()
        Me.txt_Estatus = New System.Windows.Forms.TextBox()
        Me.txt_Salario = New System.Windows.Forms.TextBox()
        Me.txt_Correo = New System.Windows.Forms.TextBox()
        Me.txt_Celular = New System.Windows.Forms.TextBox()
        Me.txt_Direccion = New System.Windows.Forms.TextBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.txt_Cedula = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Listar = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.dgv_Profesor = New System.Windows.Forms.DataGridView()
        Me.txt_Codigo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb_Codigo = New System.Windows.Forms.RadioButton()
        Me.rb_Cedula = New System.Windows.Forms.RadioButton()
        Me.rb_Nombre = New System.Windows.Forms.RadioButton()
        Me.rb_Apellido = New System.Windows.Forms.RadioButton()
        Me.cb_Facultad = New System.Windows.Forms.ComboBox()
        Me.cb_Categoria = New System.Windows.Forms.ComboBox()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.ms_Menu.SuspendLayout()
        CType(Me.dgv_Profesor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ms_Menu
        '
        Me.ms_Menu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ms_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ms_Inicio, Me.ms_Mantenimiento, Me.ms_Salir})
        Me.ms_Menu.Location = New System.Drawing.Point(0, 0)
        Me.ms_Menu.Name = "ms_Menu"
        Me.ms_Menu.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.ms_Menu.Size = New System.Drawing.Size(800, 24)
        Me.ms_Menu.TabIndex = 1
        Me.ms_Menu.Text = "Inicio"
        '
        'ms_Inicio
        '
        Me.ms_Inicio.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ms_Presentacion})
        Me.ms_Inicio.Name = "ms_Inicio"
        Me.ms_Inicio.Size = New System.Drawing.Size(48, 20)
        Me.ms_Inicio.Text = "Inicio"
        '
        'ms_Presentacion
        '
        Me.ms_Presentacion.Name = "ms_Presentacion"
        Me.ms_Presentacion.Size = New System.Drawing.Size(142, 22)
        Me.ms_Presentacion.Text = "Presentación"
        '
        'ms_Mantenimiento
        '
        Me.ms_Mantenimiento.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ms_Estudiante, Me.ms_Profesor})
        Me.ms_Mantenimiento.Name = "ms_Mantenimiento"
        Me.ms_Mantenimiento.Size = New System.Drawing.Size(101, 20)
        Me.ms_Mantenimiento.Text = "Mantenimiento"
        '
        'ms_Estudiante
        '
        Me.ms_Estudiante.Name = "ms_Estudiante"
        Me.ms_Estudiante.Size = New System.Drawing.Size(129, 22)
        Me.ms_Estudiante.Text = "Estudiante"
        '
        'ms_Profesor
        '
        Me.ms_Profesor.Name = "ms_Profesor"
        Me.ms_Profesor.Size = New System.Drawing.Size(129, 22)
        Me.ms_Profesor.Text = "Profesor"
        '
        'ms_Salir
        '
        Me.ms_Salir.Name = "ms_Salir"
        Me.ms_Salir.Size = New System.Drawing.Size(41, 20)
        Me.ms_Salir.Text = "Salir"
        '
        'txt_Apellido
        '
        Me.txt_Apellido.Enabled = False
        Me.txt_Apellido.Location = New System.Drawing.Point(93, 155)
        Me.txt_Apellido.Name = "txt_Apellido"
        Me.txt_Apellido.Size = New System.Drawing.Size(121, 20)
        Me.txt_Apellido.TabIndex = 44
        '
        'txt_Estatus
        '
        Me.txt_Estatus.Enabled = False
        Me.txt_Estatus.Location = New System.Drawing.Point(93, 408)
        Me.txt_Estatus.Name = "txt_Estatus"
        Me.txt_Estatus.Size = New System.Drawing.Size(121, 20)
        Me.txt_Estatus.TabIndex = 43
        '
        'txt_Salario
        '
        Me.txt_Salario.Enabled = False
        Me.txt_Salario.Location = New System.Drawing.Point(93, 372)
        Me.txt_Salario.Name = "txt_Salario"
        Me.txt_Salario.Size = New System.Drawing.Size(121, 20)
        Me.txt_Salario.TabIndex = 42
        '
        'txt_Correo
        '
        Me.txt_Correo.Enabled = False
        Me.txt_Correo.Location = New System.Drawing.Point(93, 264)
        Me.txt_Correo.Name = "txt_Correo"
        Me.txt_Correo.Size = New System.Drawing.Size(121, 20)
        Me.txt_Correo.TabIndex = 38
        '
        'txt_Celular
        '
        Me.txt_Celular.Enabled = False
        Me.txt_Celular.Location = New System.Drawing.Point(93, 226)
        Me.txt_Celular.Name = "txt_Celular"
        Me.txt_Celular.Size = New System.Drawing.Size(121, 20)
        Me.txt_Celular.TabIndex = 37
        '
        'txt_Direccion
        '
        Me.txt_Direccion.Enabled = False
        Me.txt_Direccion.Location = New System.Drawing.Point(93, 188)
        Me.txt_Direccion.Name = "txt_Direccion"
        Me.txt_Direccion.Size = New System.Drawing.Size(121, 20)
        Me.txt_Direccion.TabIndex = 36
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Enabled = False
        Me.txt_Nombre.Location = New System.Drawing.Point(93, 119)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(121, 20)
        Me.txt_Nombre.TabIndex = 35
        '
        'txt_Cedula
        '
        Me.txt_Cedula.Enabled = False
        Me.txt_Cedula.Location = New System.Drawing.Point(93, 86)
        Me.txt_Cedula.Name = "txt_Cedula"
        Me.txt_Cedula.Size = New System.Drawing.Size(121, 20)
        Me.txt_Cedula.TabIndex = 34
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 411)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Estatus:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 339)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Categoría:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 302)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Facultad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Correo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Celular:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Dirección:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Apelllido:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Cédula:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 375)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Salario:"
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Location = New System.Drawing.Point(703, 219)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Eliminar.TabIndex = 50
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'btn_Listar
        '
        Me.btn_Listar.Location = New System.Drawing.Point(703, 116)
        Me.btn_Listar.Name = "btn_Listar"
        Me.btn_Listar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Listar.TabIndex = 49
        Me.btn_Listar.Text = "Listar"
        Me.btn_Listar.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Location = New System.Drawing.Point(703, 183)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Modificar.TabIndex = 48
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.Location = New System.Drawing.Point(703, 81)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Limpiar.TabIndex = 47
        Me.btn_Limpiar.Text = "Limpiar"
        Me.btn_Limpiar.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Location = New System.Drawing.Point(703, 47)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 46
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'dgv_Profesor
        '
        Me.dgv_Profesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Profesor.Location = New System.Drawing.Point(248, 49)
        Me.dgv_Profesor.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_Profesor.Name = "dgv_Profesor"
        Me.dgv_Profesor.RowHeadersWidth = 51
        Me.dgv_Profesor.RowTemplate.Height = 24
        Me.dgv_Profesor.Size = New System.Drawing.Size(410, 235)
        Me.dgv_Profesor.TabIndex = 51
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Location = New System.Drawing.Point(93, 54)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(121, 20)
        Me.txt_Codigo.TabIndex = 53
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "Código:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_Codigo)
        Me.GroupBox2.Controls.Add(Me.rb_Cedula)
        Me.GroupBox2.Controls.Add(Me.rb_Nombre)
        Me.GroupBox2.Controls.Add(Me.rb_Apellido)
        Me.GroupBox2.Location = New System.Drawing.Point(639, 302)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(149, 136)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ordenar por:"
        '
        'rb_Codigo
        '
        Me.rb_Codigo.AutoSize = True
        Me.rb_Codigo.Checked = True
        Me.rb_Codigo.Location = New System.Drawing.Point(18, 19)
        Me.rb_Codigo.Name = "rb_Codigo"
        Me.rb_Codigo.Size = New System.Drawing.Size(58, 17)
        Me.rb_Codigo.TabIndex = 36
        Me.rb_Codigo.TabStop = True
        Me.rb_Codigo.Text = "Código"
        Me.rb_Codigo.UseVisualStyleBackColor = True
        '
        'rb_Cedula
        '
        Me.rb_Cedula.AutoSize = True
        Me.rb_Cedula.Location = New System.Drawing.Point(18, 46)
        Me.rb_Cedula.Name = "rb_Cedula"
        Me.rb_Cedula.Size = New System.Drawing.Size(58, 17)
        Me.rb_Cedula.TabIndex = 33
        Me.rb_Cedula.Text = "Cédula"
        Me.rb_Cedula.UseVisualStyleBackColor = True
        '
        'rb_Nombre
        '
        Me.rb_Nombre.AutoSize = True
        Me.rb_Nombre.Location = New System.Drawing.Point(18, 76)
        Me.rb_Nombre.Name = "rb_Nombre"
        Me.rb_Nombre.Size = New System.Drawing.Size(62, 17)
        Me.rb_Nombre.TabIndex = 34
        Me.rb_Nombre.Text = "Nombre"
        Me.rb_Nombre.UseVisualStyleBackColor = True
        '
        'rb_Apellido
        '
        Me.rb_Apellido.AutoSize = True
        Me.rb_Apellido.Location = New System.Drawing.Point(18, 107)
        Me.rb_Apellido.Name = "rb_Apellido"
        Me.rb_Apellido.Size = New System.Drawing.Size(62, 17)
        Me.rb_Apellido.TabIndex = 35
        Me.rb_Apellido.Text = "Apellido"
        Me.rb_Apellido.UseVisualStyleBackColor = True
        '
        'cb_Facultad
        '
        Me.cb_Facultad.Enabled = False
        Me.cb_Facultad.FormattingEnabled = True
        Me.cb_Facultad.Location = New System.Drawing.Point(93, 302)
        Me.cb_Facultad.Name = "cb_Facultad"
        Me.cb_Facultad.Size = New System.Drawing.Size(121, 21)
        Me.cb_Facultad.TabIndex = 55
        '
        'cb_Categoria
        '
        Me.cb_Categoria.Enabled = False
        Me.cb_Categoria.FormattingEnabled = True
        Me.cb_Categoria.Location = New System.Drawing.Point(93, 339)
        Me.cb_Categoria.Name = "cb_Categoria"
        Me.cb_Categoria.Size = New System.Drawing.Size(121, 21)
        Me.cb_Categoria.TabIndex = 56
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Enabled = False
        Me.btn_Agregar.Location = New System.Drawing.Point(703, 149)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Agregar.TabIndex = 57
        Me.btn_Agregar.Text = "Agregar"
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'Profesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Agregar)
        Me.Controls.Add(Me.cb_Categoria)
        Me.Controls.Add(Me.cb_Facultad)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txt_Codigo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgv_Profesor)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Listar)
        Me.Controls.Add(Me.btn_Modificar)
        Me.Controls.Add(Me.btn_Limpiar)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_Apellido)
        Me.Controls.Add(Me.txt_Estatus)
        Me.Controls.Add(Me.txt_Salario)
        Me.Controls.Add(Me.txt_Correo)
        Me.Controls.Add(Me.txt_Celular)
        Me.Controls.Add(Me.txt_Direccion)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.txt_Cedula)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ms_Menu)
        Me.Name = "Profesor"
        Me.Text = "Profesor"
        Me.ms_Menu.ResumeLayout(False)
        Me.ms_Menu.PerformLayout()
        CType(Me.dgv_Profesor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ms_Menu As MenuStrip
    Friend WithEvents ms_Inicio As ToolStripMenuItem
    Friend WithEvents ms_Presentacion As ToolStripMenuItem
    Friend WithEvents ms_Mantenimiento As ToolStripMenuItem
    Friend WithEvents ms_Estudiante As ToolStripMenuItem
    Friend WithEvents ms_Profesor As ToolStripMenuItem
    Friend WithEvents ms_Salir As ToolStripMenuItem
    Friend WithEvents txt_Apellido As TextBox
    Friend WithEvents txt_Estatus As TextBox
    Friend WithEvents txt_Salario As TextBox
    Friend WithEvents txt_Correo As TextBox
    Friend WithEvents txt_Celular As TextBox
    Friend WithEvents txt_Direccion As TextBox
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents txt_Cedula As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents btn_Listar As Button
    Friend WithEvents btn_Modificar As Button
    Friend WithEvents btn_Limpiar As Button
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents dgv_Profesor As DataGridView
    Friend WithEvents txt_Codigo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rb_Codigo As RadioButton
    Friend WithEvents rb_Cedula As RadioButton
    Friend WithEvents rb_Nombre As RadioButton
    Friend WithEvents rb_Apellido As RadioButton
    Friend WithEvents cb_Facultad As ComboBox
    Friend WithEvents cb_Categoria As ComboBox
    Friend WithEvents btn_Agregar As Button
End Class
