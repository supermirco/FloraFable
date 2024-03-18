Public Class Form1
    Dim pacchettoComune As String
    Dim pacchettoRaro As String
    Dim pacchettoSuperRaro As String

    Private Sub btnPesca_MouseHover(sender As Object, e As EventArgs) Handles btnPesca.MouseHover
        btnPesca.Width = 362
        btnPesca.Height = 50



    End Sub
    Private Sub btnPesca_MouseLeave(sender As Object, e As EventArgs) Handles btnPesca.MouseLeave
        btnPesca.Width = 262
        btnPesca.Height = 61



    End Sub
    Private rnd As New Random()
    Private Sub SelezionaCasualmentePictureBox()
        ' Genera un numero casuale compreso tra 1 e 100
        Dim numeroCasuale As Integer = rnd.Next(1, 101)

        ' Nasconde tutte le PictureBox
        pctPacchettoComune.Visible = False
        pctPacchettoRaro.Visible = False
        pctPacchettoSuperRaro.Visible = False

        ' Definizione degli intervalli di probabilità
        Dim intervalloPictureBox1 As Integer = 50
        Dim intervalloPictureBox2 As Integer = 30 + intervalloPictureBox1 ' 50 + 30 = 80
        Dim intervalloPictureBox3 As Integer = 20 + intervalloPictureBox2 ' 80 + 20 = 100

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

        btnPesca.Enabled = False



        SelezionaCasualmentePictureBox()

        If pctPacchettoComune.Visible = True Then
            MsgBox("COMPLIMENTI HAI TROVATO UN PACCHETTO COMUNE")
        ElseIf pctPacchettoRaro.Visible = True Then
            MsgBox("COMPLIMENTI HAI TROVATO UN PACCHETTO RARO")
        ElseIf pctPacchettoSuperRaro.Visible = True Then
            MsgBox("COMPLIMENTI HAI TROVATO UN PACCHETTO SUPER RARO")
        End If
    End Sub
End Class
