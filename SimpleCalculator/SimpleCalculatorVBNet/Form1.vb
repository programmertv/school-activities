Public Class Form1
    Dim value As Double
    Dim op As String
    Private Sub btnNumberClick(sender As Object, e As EventArgs) Handles Button8.Click, Button7.Click, Button6.Click, Button19.Click, Button16.Click, Button15.Click, Button14.Click, Button12.Click, Button11.Click, Button10.Click
        Dim currentText As String = txtNum.Text
        Dim newValue As Double = CDbl(currentText)
        Dim btnText As String = DirectCast(sender, Button).Text
        If newValue = 0 Then
            txtNum.Text = btnText
        Else
            txtNum.Text = currentText + btnText
        End If
    End Sub

    Private Sub btnOperatorClick(sender As Object, e As EventArgs) Handles Button9.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button18.Click, Button17.Click, Button13.Click, Button1.Click
        Dim currentText As String = txtNum.Text
        Dim newValue As Double = CDbl(currentText)
        Dim btnText As String = DirectCast(sender, Button).Text
        Select Case btnText
            Case "/", "*", "+", "-"
                value = newValue
                op = btnText
                txtNum.Text = 0
            Case "="
                Select Case op
                    Case "/"
                        value = value / newValue
                    Case "*"
                        value = value * newValue
                    Case "+"
                        value = value + newValue
                    Case "-"
                        value = value - newValue
                End Select
                txtNum.Text = value
            Case "AC"
                value = 0
                op = ""
                txtNum.Text = 0
            Case "."
                If Not currentText.Contains("."c) Then
                    txtNum.Text = currentText + "."
                End If
            Case "+/-"
                txtNum.Text = -newValue
            Case "%"
                txtNum.Text = newValue / 100
        End Select
    End Sub
End Class