Public Class Principal
    Private Sub Media_Click(sender As Object, e As EventArgs) Handles Media.Click
        Me.Hide()
        MediaDesviacion.Show()

    End Sub

    Private Sub Cajero_Click(sender As Object, e As EventArgs) Handles Cajero.Click
        Me.Hide()
        CajeroAutomatico.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Impuesto.Show()
    End Sub
End Class