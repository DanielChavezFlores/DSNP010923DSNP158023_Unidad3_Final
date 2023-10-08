Public Class Impuesto
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Calcular.Click

        Dim Monto As Double
        Dim calcular As Calcular = New Calcular()

        Try

            erpEntrada.SetError(Entrada, "")
            Monto = Entrada.Text
            If Monto < 0.01 Or Monto > 99999999 Then
                MessageBox.Show("Ingrese un valor entre 0.01 y 99999999 ")
                Exit Sub
            End If
            If Monto >= 6000.01 And Monto <= 8000 Then
                MessageBox.Show("No hay un valor determinado para el bloque entre 6000.01 y 8000")
                Exit Sub
            End If

            Resultado.Text = "$" & " " & Math.Round(calcular.Calcular_resultado(Monto), 2)


        Catch ex As Exception

            erpEntrada.SetError(Entrada, "Ingrese un valor")

        End Try

    End Sub



    Private Sub InicioI_Click(sender As Object, e As EventArgs) Handles InicioI.Click
        Me.Hide()
        Principal.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Entrada.Clear()
        Resultado.Clear()
    End Sub
End Class