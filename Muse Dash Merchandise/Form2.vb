Public Class Form2
    Public Counter As Integer = 2
    Dim WithEvents Timer1 As New Timer
    Public Total As Integer = 0
    Public Item1 As Integer = 0
    Public Item2 As Integer = 0
    Public Item3 As Integer = 0
    Public Item4 As Integer = 0
    Public Item5 As Integer = 0
    Public Item6 As Integer = 0
    Public Item7 As Integer = 0
    Public Count1 As Integer = 0
    Public Count2 As Integer = 0
    Public Count3 As Integer = 0
    Public Count4 As Integer = 0
    Public Count5 As Integer = 0
    Public Count6 As Integer = 0
    Public Count7 As Integer = 0

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.Parent = PictureBox1
        PictureBox3.Parent = PictureBox1
        PictureBox4.Parent = PictureBox1
        PictureBox5.Parent = PictureBox1
        Button1.Parent = PictureBox1
        Button2.Parent = PictureBox1
        Button3.Parent = PictureBox1
        Button4.Parent = PictureBox1
        Button5.Parent = PictureBox1

        PictureBox5.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Counter < 8 Then
            Counter += 1
        End If
        Select Case Counter
            Case 1
                PictureBox2.Image = My.Resources.badge1
                PictureBox3.Image = My.Resources.blank
                PictureBox4.Image = My.Resources.bdg2_2
            Case 2
                PictureBox2.Image = My.Resources.badge2
                PictureBox3.Image = My.Resources.bdg1_2
                PictureBox4.Image = My.Resources.bdg3_2
            Case 3
                PictureBox2.Image = My.Resources.badge3
                PictureBox3.Image = My.Resources.bdg2_2
                PictureBox4.Image = My.Resources.bdg4_2
            Case 4
                PictureBox2.Image = My.Resources.badge4
                PictureBox3.Image = My.Resources.bdg3_2
                PictureBox4.Image = My.Resources.bdg5_2
            Case 5
                PictureBox2.Image = My.Resources.badge5
                PictureBox3.Image = My.Resources.bdg4_2
                PictureBox4.Image = My.Resources.bdg6_2
            Case 6
                PictureBox2.Image = My.Resources.badge6
                PictureBox3.Image = My.Resources.bdg5_2
                PictureBox4.Image = My.Resources.bdg7_2
            Case 7
                PictureBox2.Image = My.Resources.badge7
                PictureBox3.Image = My.Resources.bdg6_2
                PictureBox4.Image = My.Resources.blank
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Counter > 0 Then
            Counter -= 1
        End If
        Select Case Counter
            Case 1
                PictureBox2.Image = My.Resources.badge1
                PictureBox3.Image = My.Resources.blank
                PictureBox4.Image = My.Resources.bdg2_2
            Case 2
                PictureBox2.Image = My.Resources.badge2
                PictureBox3.Image = My.Resources.bdg1_2
                PictureBox4.Image = My.Resources.bdg3_2
            Case 3
                PictureBox2.Image = My.Resources.badge3
                PictureBox3.Image = My.Resources.bdg2_2
                PictureBox4.Image = My.Resources.bdg4_2
            Case 4
                PictureBox2.Image = My.Resources.badge4
                PictureBox3.Image = My.Resources.bdg3_2
                PictureBox4.Image = My.Resources.bdg5_2
            Case 5
                PictureBox2.Image = My.Resources.badge5
                PictureBox3.Image = My.Resources.bdg4_2
                PictureBox4.Image = My.Resources.bdg6_2
            Case 6
                PictureBox2.Image = My.Resources.badge6
                PictureBox3.Image = My.Resources.bdg5_2
                PictureBox4.Image = My.Resources.bdg7_2
            Case 7
                PictureBox2.Image = My.Resources.badge7
                PictureBox3.Image = My.Resources.bdg6_2
                PictureBox4.Image = My.Resources.blank
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox5.Visible = True
        Timer1.Interval = 1000
        Timer1.Start()

        Select Case Counter
            Case 1
                Total += 149
                Item1 += 149
                Count1 += 1
            Case 2
                Total += 149
                Item2 += 149
                Count2 += 1
            Case 3
                Total += 169
                Item3 += 169
                Count3 += 1
            Case 4
                Total += 169
                Item4 += 169
                Count4 += 1
            Case 5
                Total += 169
                Item5 += 169
                Count5 += 1
            Case 6
                Total += 199
                Item6 += 199
                Count6 += 1
            Case 7
                Total += 199
                Item7 += 199
                Count7 += 1
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox5.Visible = False
        Timer1.Stop()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Total > 0 Then
            Me.Hide()
            Form3.Show()
        End If
    End Sub

End Class