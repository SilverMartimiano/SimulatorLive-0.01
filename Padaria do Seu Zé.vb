Public Class Padaria_do_Seu_Zé

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Fome < 10 Then
            If Dinheiro >= 3 Then
                Dinheiro -= 3
            End If
        Else
            MsgBox("Você está cheio")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Trabalho = "Null" Then
            Trabalho = "Padaria do Seu Zé"
            Button2.Text = "Trabalhar R$ 6"
            MsgBox("Zé, dono da padaria aceitou o seu curriculo")
        Else
            If Energia < 1 Then
                MsgBox("No céu tem pão? E morreu!")
                Form1.Close()
            End If
            If Fome < 1 Then
                MsgBox("No céu tem pão? E morreu!")
                Form1.Close()
            End If
            Energia -= 2
            Fome -= 2
            Dinheiro += 6
        End If
    End Sub
End Class