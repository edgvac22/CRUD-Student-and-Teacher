<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.ms_Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'ms_Menu
        '
        Me.ms_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ms_Inicio, Me.ms_Mantenimiento, Me.ms_Salir})
        Me.ms_Menu.Location = New System.Drawing.Point(0, 0)
        Me.ms_Menu.Name = "ms_Menu"
        Me.ms_Menu.Size = New System.Drawing.Size(459, 24)
        Me.ms_Menu.TabIndex = 0
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bienvenido!"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 308)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ms_Menu)
        Me.MainMenuStrip = Me.ms_Menu
        Me.Name = "Inicio"
        Me.Text = "Form1"
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
End Class
