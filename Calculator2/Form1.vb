Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Dim number1 As Double
    Dim number2 As Double
    Dim operator1 As String
    Dim number3 As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'number1 = txtNum1.Text
        operator1 = txtOperator.Text
        'number2 = txtNum2.Text
        If IsNumeric(txtNum1.Text) Then
            number1 = CInt(txtNum1.Text)
        Else
            MsgBox("number1 is not numeric")
        End If
        If IsNumeric(txtNum2.Text) Then
            number2 = CInt(txtNum2.Text)
        Else
            MsgBox("number1 is not numeric")
        End If
        If operator1 = "*" Then
            number3 = number1 * number2
            MsgBox("the product of " & number1 & " and " & number2 & " is " & number3)
        ElseIf (operator1 = "/" Or operator1 = "\") Then
            number3 = number1 \ number2
            MsgBox("the quotient of " & number1 & " and " & number2 & " is " & number3)
        ElseIf operator1 = "+" Then
            number3 = number1 + number2
            MsgBox("the sum of " & number1 & " and " & number2 & " is " & number3)
        ElseIf operator1 = "-" Then
            number3 = number1 - number2
            MsgBox("the difference between " & number1 & " and " & number2 & " is " & number3)
        ElseIf operator1 = "%" Then
            number3 = number1 Mod number2
            MsgBox("the remainder of " & number1 & " and " & number2 & " is " & number3)
        Else
            MsgBox("you operator is invalid or not specified")
        End If
    End Sub
End Class
