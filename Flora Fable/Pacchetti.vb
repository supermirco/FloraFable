Public Class pacchetti

    Dim pacchettoComune As String
        Dim pacchettoRaro As String
        Dim pacchettoSuperRaro As String
        Dim rnd As New Random()

        Private Sub pctPacchettoComune_Click(sender As Object, e As EventArgs) Handles pctPacchettoComune.Click
            MsgBox("QUESTO PACCHETTO HA 1 PROBABILITà DEL 50% DI USCIRE")
        End Sub
        Private Sub pctPacchettoRaro_Click(sender As Object, e As EventArgs) Handles pctPacchettoRaro.Click
            MsgBox("QUESTO PACCHETTO HA 1 PROBABILITà DEL 30% DI USCIRE")
        End Sub

        Private Sub pctPacchettoSuperRaro_Click(sender As Object, e As EventArgs) Handles pctPacchettoSuperRaro.Click
            MsgBox("QUESTO PACCHETTO HA 1 PROBABILITà DEL 20% DI USCIRE")
        End Sub
        'PESCAGGO DEI PACCHETI CON PROBABILITà
        Private Sub SelezionaCasualmentePictureBox()

            Dim numeroCasuale As Integer = rnd.Next(1, 101)

            ' Nasconde tutte le PictureBox
            pctPacchettoComune.Visible = False
            pctPacchettoRaro.Visible = False
            pctPacchettoSuperRaro.Visible = False

            ' Definizione degli intervalli di probabilità
            Dim intervalloPictureBox1 As Integer = 50
            Dim intervalloPictureBox2 As Integer = 30 + intervalloPictureBox1
            Dim intervalloPictureBox3 As Integer = 20 + intervalloPictureBox2

            ' Seleziona casualmente una delle PictureBox basata sul numero casuale generato
            If numeroCasuale <= intervalloPictureBox1 Then
                pctPacchettoComune.Visible = True
            ElseIf numeroCasuale <= intervalloPictureBox2 Then
                pctPacchettoRaro.Visible = True
            Else
                pctPacchettoSuperRaro.Visible = True
            End If
        End Sub
        Private Sub btnPesca_Click(sender As Object, e As EventArgs) Handles btnPesca.Click



            SelezionaCasualmentePictureBox()

            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False

            If pctPacchettoComune.Visible = True Then
                MsgBox("COMPLIMENTI HAI TROVATO UN PACCHETTO COMUNE")
            ElseIf pctPacchettoRaro.Visible = True Then
                MsgBox("COMPLIMENTI HAI TROVATO UN PACCHETTO RARO")
            ElseIf pctPacchettoSuperRaro.Visible = True Then
                MsgBox("COMPLIMENTI HAI TROVATO UN PACCHETTO SUPER RARO")
            End If

            btnPesca.Enabled = False
            btnPesca.Visible = False

            Dim newX As Integer = (Me.Width - pctPacchettoComune.Width) / 2
            Dim newY As Integer = (Me.Height - pctPacchettoComune.Height) / 2


            pctPacchettoComune.Location = New Point(newX, newY)
            pctPacchettoRaro.Location = New Point(newX, newY)
            pctPacchettoSuperRaro.Location = New Point(newX, newY)
        End Sub
        Private Sub btnApri_Click(sender As Object, e As EventArgs) Handles btnApri.Click

        End Sub

    End Class
