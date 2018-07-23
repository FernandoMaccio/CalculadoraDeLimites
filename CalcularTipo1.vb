Public Class CalcularTipo1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim a, b, x As Integer
        If txt1A.Text = "" Or Not Int32.TryParse(txt1A.Text, a) Then
            MsgBox("Error al ingresar A")
        ElseIf txt1B.Text = "" Or Not Int32.TryParse(txt1B.Text, b) Then
            MsgBox("Error al ingresar B")
        ElseIf txt1X.Text = "" Or Not Int32.TryParse(txt1X.Text, x) Then
            MsgBox("Error al ingresar X")
        Else
            Dim resultado = a * x + b
            MsgBox(String.Concat("Resultado: " + resultado.ToString()))
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Visible = False
        Home.Visible = True
    End Sub
End Class