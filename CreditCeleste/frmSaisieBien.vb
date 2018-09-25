Public Class frmSaisieBien

    Dim age As String 'age de la voiture
    Dim i As Integer
    Dim radio As RadioButton

    Private Sub frmSaisieBien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fenBien.BringToFront()

        lblAncVeh.Text = uneVoiture.getAncVehicule()
        txtDate1Imm.Text = uneVoiture.getDatePremiereImmatriculation()
        txtAnnMod.Text = uneVoiture.getAnneeModele()
        txtNumImm.Text = uneVoiture.getNumeroImmatriculation()
        txtNumSer.Text = uneVoiture.getNumeroSerie()
        txtPuiss.Text = uneVoiture.getPuissance()
        ''test

        'i = 0
        'age = uneVoiture.getAgeVehiculee()


        'radio = gpbAge.Controls(i)


        'Do While radio.Checked = False And i < gpbAge.Controls.Count - 1
        '    i = i + 1 ' i+=1
        '    radio = gpbAge.Controls(i)
        'Loop

        'If age = rdbNeuf.Text Then
        '    gpbAge.Controls(i).Checked


        'End If


        ''
    End Sub

    Private Sub cmdIntro_Click(sender As Object, e As EventArgs) Handles cmdIntro.Click

        If fenIntro Is Nothing Then
            fenIntro = New frmIntroduction 'Design pattern : singleton
        ElseIf fenIntro.IsDisposed Then
            fenIntro = New frmIntroduction
        End If


        fenIntro.Show()  'affichage objet
        fenIntro.BringToFront()
        Me.Close()


        'Me.Hide()   'masque la fenetre, mais ne repasse pas dans le formload
        'Me.Dispose()

    End Sub

    Private Sub cmdEnr_Click(sender As Object, e As EventArgs) Handles cmdEnr.Click

        Dim datePremiereImmatriculation As String
        Dim anneeModele As String
        Dim numeroImmatriculation As String
        Dim numeroSerie As String
        Dim puissance As String

        datePremiereImmatriculation = txtDate1Imm.Text
        anneeModele = txtAnnMod.Text
        numeroImmatriculation = txtNumImm.Text
        numeroSerie = txtNumSer.Text
        puissance = txtPuiss.Text

        uneVoiture = New Voiture()
        uneVoiture.setVehicule(datePremiereImmatriculation, anneeModele, numeroImmatriculation, numeroSerie, puissance)
        MsgBox(uneVoiture.getVehiculeAff() + "    => " + "Enregistré")


        radio = gpbAge.Controls(i)

        Do While radio.Checked = False And i < gpbAge.Controls.Count - 1
            i = i + 1 ' i+=1
            radio = gpbAge.Controls(i)
        Loop
        'Je m'arrête au bon endroit, pas beoin de parcourir toutes la liste
        age = radio.Text
        uneVoiture.setAgeVehicule(age)



    End Sub

    Private Sub cmdCredit_Click(sender As Object, e As EventArgs) Handles cmdCredit.Click
        'chainage vers le credit
    End Sub
End Class