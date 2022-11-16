Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles title.Click, btnSair.Click
        End
    End Sub

    Private Sub jogar_Click(sender As Object, e As EventArgs) Handles btnJogar.Click
        imgResultado.Visible = False
        Randomize()

        n1.Text = CStr(Int(Rnd() * 10))
        n2.Text = CStr(Int(Rnd() * 10))
        n3.Text = CStr(Int(Rnd() * 10))
        'Se todos os numeros forem = 7:'
        If (n1.Text = "7") And (n2.Text = "7" And (n3.Text = "7")) Then
            imgResultado.Image = Image.FromFile("C:\Users\Lucas\source\repos\Jogo7SorteSl\res7.jpg")
            imgWinLost.Image = Image.FromFile("C:\Users\Lucas\source\repos\Jogo7SorteSl\winMax.jpg")
            imgResultado.Visible = True
            win.Text += 1
            valorSaldo.Text += 10
            valorSaldo.BackColor = Color.Green
        ElseIf (n1.Text = "7") Or (n2.Text = "7" Or (n3.Text = "7")) Then
            imgResultado.Image = Image.FromFile("C:\Users\Lucas\source\repos\Jogo7SorteSl\ganhou.png")
            imgWinLost.Image = Image.FromFile("C:\Users\Lucas\source\repos\Jogo7SorteSl\win.png")
            imgResultado.Visible = True
            win.Text += 1
            valorSaldo.Text += 1
            valorSaldo.BackColor = Color.Green
            Beep()
        Else
            imgResultado.Image = Image.FromFile("C:\Users\Lucas\source\repos\Jogo7SorteSl\perdeu.png")
            imgWinLost.Image = Image.FromFile("C:\Users\Lucas\source\repos\Jogo7SorteSl\lost.png")
            imgResultado.Visible = True
            lost.Text += 1
            valorSaldo.Text -= 1
            valorSaldo.BackColor = Color.Red
            Beep()
        End If
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        valorSaldo.Text = 100
        win.Text = 0
        lost.Text = 0
    End Sub

    Private Sub win_Click(sender As Object, e As EventArgs) Handles win.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub valorSaldo_Click(sender As Object, e As EventArgs) Handles valorSaldo.Click

    End Sub

    Private Sub n2_Click(sender As Object, e As EventArgs) Handles n2.Click

    End Sub

    Private Sub n1_Click(sender As Object, e As EventArgs) Handles n1.Click

    End Sub

    Private Sub n3_Click(sender As Object, e As EventArgs) Handles n3.Click

    End Sub
End Class