Public Class CalcularTipo1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim a As Integer = txt1A.Text
        Dim b As Integer = txt1B.Text
        Dim x As Integer = txt1X.Text
        Dim resultado = a * x + b
        MsgBox(String.Concat("Resultado: " + resultado))
    End Sub
End Class