Public Class Inicio
    Private Sub ms_Salir_Click(sender As Object, e As EventArgs) Handles ms_Salir.Click
        Application.Exit()
    End Sub

    Private Sub ms_Presentacion_Click(sender As Object, e As EventArgs) Handles ms_Presentacion.Click
        Presentacion.Show()
    End Sub

    Private Sub ms_Profesor_Click(sender As Object, e As EventArgs) Handles ms_Profesor.Click
        Profesor.Show()
    End Sub

    Private Sub ms_Estudiante_Click(sender As Object, e As EventArgs) Handles ms_Estudiante.Click
        Estudiante.Show()
    End Sub
End Class
