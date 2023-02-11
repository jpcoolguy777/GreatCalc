Public Class Form1

    Dim OP As Integer = 0
    Dim num1 As Integer = 0
    Dim num2 As Integer = 0

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        OP = 1
        Label3.Text = "Number 1"
        Label2.Text = "Number 2"
    End Sub


    Private Sub Subtract_Click(sender As Object, e As EventArgs) Handles Subtract.Click
        OP = 2
        Label3.Text = "Number 1"
        Label2.Text = "Number 2"
    End Sub

    Private Sub Multiply_Click(sender As Object, e As EventArgs) Handles Multiply.Click
        OP = 3
        Label3.Text = "Number 1"
        Label2.Text = "Number 2"
    End Sub

    Private Sub Divide_Click(sender As Object, e As EventArgs) Handles Divide.Click
        OP = 4
        Label3.Text = "Number 1"
        Label2.Text = "Number 2"
    End Sub

    Private Sub square_Click(sender As Object, e As EventArgs) Handles square.Click
        OP = 5
        Label3.Text = "To the power of.."
        Label2.Text = "Desired number"
    End Sub

    Private Sub equals_Click(sender As Object, e As EventArgs) Handles equals.Click
        Label3.Text = "Number 1"
        Label2.Text = "Number 2"
        
        
        num1 = input1.Text
        num2 = input2.Text

        If OP = 1 Then
            result.Text = num1 + num2

        End If

        If OP = 2 Then
            result.Text = num1 - num2
        End If

        If OP = 3 Then
            result.Text = num1 * num2
        End If

        If OP = 4 Then
            result.Text = num1 / num2

        End If

        If OP = 5 Then
            result.Text = num1 ^ num2
        End If
    End Sub

    Private Sub ce_Click(sender As Object, e As EventArgs) Handles ce.Click
        input1.Clear()
        input2.Clear()
        result.Clear()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub
End Class
