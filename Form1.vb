Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Double = CDbl(TextBox1.Text)
        Dim num2 As Double = CDbl(TextBox2.Text)
        Dim result As Double = num1 + num2
        MsgBox(result)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1 As Double = CDbl(TextBox1.Text)
        Dim num2 As Double = CDbl(TextBox2.Text)
        Dim result As Double = num1 - num2
        MsgBox(result)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num1 As Double = CDbl(TextBox1.Text)
        Dim num2 As Double = CDbl(TextBox2.Text)
        Dim result As Double = num1 * num2
        MsgBox(result)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1 As Double = CDbl(TextBox1.Text)
        Dim num2 As Double = CDbl(TextBox2.Text)
        If num2 = 0 Then
            MsgBox("Cannot divide by zero.")
        Else
            Dim result As Double = num1 / num2
            MsgBox(result)
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("Enter the first number And the second number In the text boxes, then click the button to perform the calculation.")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox("CalcMe
Big-A-Software
Version 1.0
.NET Framework 4.8")
    End Sub
End Class
