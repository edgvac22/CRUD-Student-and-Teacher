<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Presentacion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ms_Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'ms_Menu
        '
        Me.ms_Menu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ms_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ms_Inicio, Me.ms_Mantenimiento, Me.ms_Salir})
        Me.ms_Menu.Location = New System.Drawing.Point(0, 0)
        Me.ms_Menu.Name = "ms_Menu"
        Me.ms_Menu.Size = New System.Drawing.Size(418, 24)
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
        Me.ms_Presentacion.Size = New System.Drawing.Size(180, 22)
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
        Me.ms_Estudiante.Size = New System.Drawing.Size(180, 22)
        Me.ms_Estudiante.Text = "Estudiante"
        '
        'ms_Profesor
        '
        Me.ms_Profesor.Name = "ms_Profesor"
        Me.ms_Profesor.Size = New System.Drawing.Size(180, 22)
        Me.ms_Profesor.Text = "Profesor"
        '
        'ms_Salir
        '
        Me.ms_Salir.Name = "ms_Salir"
        Me.ms_Salir.Size = New System.Drawing.Size(41, 20)
        Me.ms_Salir.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "UNIVERSIDAD TECNOLÓGICA DE PANAMÁ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(374, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "FACULTAD DE INGENIERÍA EN SIST. COMPUTACIONALES"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(323, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "LICENCIATURA EN DESARROLLO DE SOFTWARE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(131, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "MATERIA: DESARROLLO VIII"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(129, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "PROFESOR: RICARDO CHAN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(120, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(208, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "ESTUDIANTE: EDGARDO VACA"
        '
        'Presentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 288)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ms_Menu)
        Me.Name = "Presentacion"
        Me.Text = "Form2"
        Me.ms_Menu.ResumeLayout(False)
        Me.ms_Menu.PerformLayout()
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
