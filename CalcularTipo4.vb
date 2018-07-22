Public Class CalcularTipo4
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim a, x As Integer
        If txt4A.Text = "" Or Not Int32.TryParse(txt4A.Text, a) Then
            MsgBox("Error al ingresar A")
        ElseIf txt4X.Text = "" Or Not Int32.TryParse(txt4X.Text, x) Then
            MsgBox("Error al ingresar X")
        Else
            Dim resultado1 As Integer = (x * x) - a
            If resultado1 >= 0 Then
                Dim resultado As Double = Math.Sqrt(resultado1)
                MsgBox(String.Concat("Resultado: " + resultado.ToString()))
            Else
                MsgBox("El resultado no existe")
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Visible = False
        Home.Visible = True
    End Sub
End Class