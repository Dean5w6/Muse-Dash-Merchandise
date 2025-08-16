Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim hexColor As String = "#FF1884"
        Dim convertedColor As Color = ColorTranslator.FromHtml(hexColor)
        PictureBox2.Parent = PictureBox1
        ListBox1.BackColor = convertedColor
        ListBox1.Items.Add("                           Badges")
        'ListBox1.Items.Add($"   Mechanical Ballerina Marija")
        'ListBox1.Items.Add($"   Marija Keychain - 12")
        If Form2.Count1 > 0 Then
            ListBox1.Items.Add("   Amiya - " & Form2.Count1)
            ListBox1.Items.Add(" ")
        End If
        If Form2.Count2 > 0 Then
            ListBox1.Items.Add("   Wis'adel - " & Form2.Count2)
            ListBox1.Items.Add(" ")
        End If
        If Form2.Count3 > 0 Then
            ListBox1.Items.Add("   Year of the Dragon Buro - " & Form2.Count3)
            ListBox1.Items.Add(" ")
        End If
        If Form2.Count4 > 0 Then
            ListBox1.Items.Add("   Year of the Dragon Marija - " & Form2.Count4)
            ListBox1.Items.Add(" ")
        End If
        If Form2.Count5 > 0 Then
            ListBox1.Items.Add("   Year of the Dragon Rin - " & Form2.Count5)
            ListBox1.Items.Add(" ")
        End If
        If Form2.Count6 > 0 Then
            ListBox1.Items.Add("   Racer Rin - " & Form2.Count6)
            ListBox1.Items.Add(" ")
        End If
        If Form2.Count7 > 0 Then
            ListBox1.Items.Add("   Mechanical Ballerina Marija - " & Form2.Count7)
        End If

        ListBox1.Items.Add("                         Keychain")
        If Form3.KCount1 > 0 Then
            ListBox1.Items.Add("   Racer Rin Keychain - " & Form3.KCount1)
            ListBox1.Items.Add(" ")
        End If
        If Form3.KCount2 > 0 Then
            ListBox1.Items.Add("   Sailor Suit Buro - " & Form3.KCount2)
            ListBox1.Items.Add(" ")
        End If
        If Form3.KCount3 > 0 Then
            ListBox1.Items.Add("   Mechanical Ballerina Marija - " & Form3.KCount3)
            ListBox1.Items.Add(" ")
        End If
        ListBox1.Refresh()
        Button1.Refresh()
    End Sub

    Private Sub Form4_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ListBox1.Refresh()
        Button1.Refresh()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class