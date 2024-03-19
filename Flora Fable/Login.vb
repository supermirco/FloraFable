Public Class Login
    Dim Registrazione As Boolean = False
    Private Sub BtnRegistrati_Click(sender As System.Object, e As System.EventArgs) Handles BtnRegistrati.Click
        If Registrazione = False Then
            LblEmail.Visible = True
            TxtBoxEmail.Visible = True
            LblUser.Top = 250
            TxtBoxUser.Top = 300
            LblPsw.Top = 370
            TxtBoxPsw.Top = 420
            BtnSalva.Top = 480
            Registrazione = True
            BtnSalva.Text = "REGISTRATI"
        Else
            LblEmail.Visible = False
            TxtBoxEmail.Visible = False
            LblUser.Top = 150
            TxtBoxUser.Top = 200
            LblPsw.Top = 280
            TxtBoxPsw.Top = 330
            BtnSalva.Top = 430
            Registrazione = False
            BtnSalva.Text = "ACCEDI"
        End If
    End Sub

    Private Sub BtnEsci_Click(sender As System.Object, e As System.EventArgs) Handles BtnEsci.Click
        Me.Close()
    End Sub

    Private Sub BtnSalva_Click(sender As System.Object, e As System.EventArgs) Handles BtnSalva.Click
        If Registrazione = False Then

        Else
            Dim w As New IO.StreamWriter("Secret.txt")
            w.WriteLine("---------------------------", False)
            w.WriteLine("E-MAIL: " + TxtBoxEmail.Text, False)
            w.WriteLine("NIKNAME: " + TxtBoxUser.Text, False)
            w.WriteLine("PASSWORD: " + TxtBoxPsw.Text, False)
            w.WriteLine("---------------------------", False)
            w.Close()
        End If
    End Sub

    Private Sub TimerAnimazioni_Tick(sender As System.Object, e As System.EventArgs) Handles TimerAnimazioni.Tick
    End Sub
End Class
