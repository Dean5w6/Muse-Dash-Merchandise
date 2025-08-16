Public Class Form3
    Dim WithEvents Timer1 As New Timer
    Public Counter As Integer = 2
    Public Key1 As Integer = 0
    Public Key2 As Integer = 0
    Public Key3 As Integer = 0
    Public KCount1 As Integer = 0
    Public KCount2 As Integer = 0
    Public KCount3 As Integer = 0
    Public Total As Integer = 0

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Visible = True
        Timer1.Interval = 2000
        Timer1.Start()
        Button1.BackgroundImage = My.Resources.added
        Select Case Counter
            Case 1
                Key1 += 109
                KCount1 += 1
            Case 2
                Key2 += 99
                KCount2 += 1
            Case 3
                Key3 += 109
                KCount3 += 1
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Button1.BackgroundImage = My.Resources.proceed
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Total = Key1 + Key2 + Key3
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Counter > 0 Then
            Counter -= 1
        End If
        Select Case Counter
            Case 1
                Button3.Visible = False
                Button4.Visible = True
                BackgroundImage = My.Resources.keystore1
            Case 2
                Button3.Visible = True
                Button4.Visible = True
                BackgroundImage = My.Resources.keystore2
            Case 3
                Button3.Visible = True
                Button4.Visible = False
                BackgroundImage = My.Resources.keystore3
        End Select
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Counter < 4 Then
            Counter += 1
        End If
        Select Case Counter
            Case 1
                Button3.Visible = False
                Button4.Visible = True
                BackgroundImage = My.Resources.keystore1
            Case 2
                Button3.Visible = True
                Button4.Visible = True
                BackgroundImage = My.Resources.keystore2
            Case 3
                Button3.Visible = True
                Button4.Visible = False
                BackgroundImage = My.Resources.keystore3
        End Select
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class