Public Class Login
    Dim Registrazione As Boolean = False
    Private Sub BtnRegistrati_Click(sender As System.Object, e As System.EventArgs) Handles BtnRegistrati.Click
        TimerAnimazioni.Start()
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
        If BtnSalva.Top = 480 Then
            TimerAnimazioni.Stop()
        Else
            LblUser.Top = LblUser.Top + 1
            TxtBoxUser.Top = TxtBoxUser.Top + 1
            LblPsw.Top = LblPsw.Top + 1
            TxtBoxPsw.Top = TxtBoxPsw.Top + 1
            BtnSalva.Top = BtnSalva.Top + 1
        End If
    End Sub
End Class
