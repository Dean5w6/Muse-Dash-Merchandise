Public Class Form5
    Public GrandTotal As Integer = Form2.Total + Form3.Total
    Public Counter As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Payment As Integer = TextBox1.Text
        Dim Result As Integer = Payment - GrandTotal
        Label1.Refresh()
        If Counter = 1 Then
            Result *= 0.8
        End If
        If Result >= 1000 And Result < 10000 Then
            Label2.Text = "₱" & Result & "     "
        ElseIf Result >= 10000 Then
            Label2.Text = "₱" & Result & "    "
        ElseIf Result >= 100 And Result < 1000 Then
            Label2.Text = "₱" & Result & "      "
        ElseIf Result >= 10 And Result < 100 Then
            Label2.Text = "₱" & Result & "       "
        ElseIf Result >= 0 And Result < 10 Then
            Label2.Text = "₱" & Result & "        "
        End If

        If Result >= 0 Then
            PictureBox2.Image = My.Resources.Thanks
        Else
            PictureBox2.Image = My.Resources.Owe
        End If
        Label2.Refresh()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim hexColor As String = "#FF1884"
        Dim convertedColor As Color = ColorTranslator.FromHtml(hexColor)
        Label1.BackColor = convertedColor
        Label2.BackColor = convertedColor
        TextBox1.BackColor = convertedColor
        PictureBox2.Parent = PictureBox1

        If GrandTotal >= 1000 Then
            Label1.Text = "₱" & GrandTotal & "     "
        Else
            Label1.Text = "₱" & GrandTotal & "      "
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Counter < 2 Then
            Counter = 1
        End If
    End Sub
End Class