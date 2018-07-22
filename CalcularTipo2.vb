Public Class CalcularTipo2
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim a, b, c, x As Integer
        If txt2A.Text = "" Or Not Int32.TryParse(txt2A.Text, a) Then
            MsgBox("Error al ingresar A")
        ElseIf txt2B.Text = "" Or Not Int32.TryParse(txt2B.Text, b) Then
            MsgBox("Error al ingresar B")
        ElseIf txt2B.Text = "" Or Not Int32.TryParse(txt2C.Text, c) Then
            MsgBox("Error al ingresar C")
        ElseIf txt2X.Text = "" Or Not Int32.TryParse(txt2X.Text, x) Then
            MsgBox("Error al ingresar X")
        Else
            Dim resultado1 As Integer = (a * x) + b
            Dim resultado2 As Integer = (x * x) - c
            Dim resultado As Double = resultado1 / resultado2
            If (x * x) - c = 0 Then
                MsgBox("El resultado no existe")
            Else
                MsgBox(String.Concat("Resultado: " + resultado.ToString()))
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Visible = False
        Home.Visible = True
    End Sub
End Class