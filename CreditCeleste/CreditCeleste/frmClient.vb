Imports csClient
Public Class frmClient
    Dim radio As RadioButton
    Dim i As Integer
    Dim situation As String

    Private Sub frmClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboCidt.Text = unClient.getcidt()
        txtNom.Text = unClient.getnomClient()
        txtPrenom.Text = unClient.getprenomClient()


        ''client general
        If unClientVoit.getdateNaissanceClient() = "" And unClientVoit.getrevenuClient() = "" And unClientVoit.getprofessionClient() = "" And unClientVoit.getmailClient = "" Then
            ' on verifie ici que c'est bien un client general

            txtAdresse.Text = unClient.getadresseClient()
            txtCodePostale.Text = unClient.getcodePostaleClient()

            txtVille.Text = unClient.getvilleClient()
            txtTelephone.Text = unClient.getvilleClient()

        Else
            ' client spe

            cboCidt.Text = unClientVoit.getcidt()
            txtNom.Text = unClientVoit.getnomClient()
            txtPrenom.Text = unClientVoit.getprenomClient()
            txtAdresse.Text = unClientVoit.getadresseClient()
            txtCodePostale.Text = unClientVoit.getcodePostaleClient()

            txtVille.Text = unClientVoit.getvilleClient()
            txtTelephone.Text = unClientVoit.getvilleClient()

            txtDateNaissance.Text = unClientVoit.getdateNaissanceClient()
            txtRevenu.Text = unClientVoit.getrevenuClient()
            txtProfession.Text = unClientVoit.getprofessionClient()
            txtNomJeuneFille.Text = unClientVoit.getnomJeuneFilleclient()

            txtMail.Text = unClientVoit.getmailClient()



            'recup la situation patrimoniale
            radio = gpbSp.Controls(i)
            Do While radio.Text <> unClientVoit.getsituationPatrimonialeClient() And i < gpbSp.Controls.Count - 1
                i = i + 1
                radio.Checked = False
                radio = gpbSp.Controls(i)
            Loop
            radio.Checked = True


            'To DO A VERIF

            'affiche des autorisations cochées
            If unClientVoit.getcommercialeClient Then
                cbCommerciale.Checked = True
            End If
            If unClientVoit.getcorrespondanceClient Then
                cbCorrespondance.Checked = True
            End If
            If unClientVoit.getprestatairesClient Then
                cbPrestataires.Checked = True
            End If

        End If

    End Sub

    Private Sub cmdBien_Click(sender As Object, e As EventArgs) Handles cmdBien.Click

        If fenBien Is Nothing Then
            fenBien = New frmSaisieBien 'Design pattern : singleton
        ElseIf fenBien.IsDisposed Then
            fenBien = New frmSaisieBien
        End If


        fenBien.Show()  'affichage objet
        fenBien.BringToFront()
        Me.Close()
        'Me.Hide()

    End Sub

    Private Sub cmdCredit_Click(sender As Object, e As EventArgs) Handles cmdCredit.Click

        If fenCredit Is Nothing Then
            fenCredit = New frmCredit 'Design pattern : singleton
        ElseIf fenCredit.IsDisposed Then
            fenCredit = New frmCredit
        End If


        fenCredit.Show()  'affichage objet
        fenCredit.BringToFront()
        Me.Close()
        ' Me.Hide()

    End Sub

    Private Sub cmdIntro_Click(sender As Object, e As EventArgs) Handles cmdIntro.Click

        If fenIntro Is Nothing Then
            fenIntro = New frmIntroduction 'Design pattern : singleton
        ElseIf fenIntro.IsDisposed Then
            fenIntro = New frmIntroduction
        End If


        fenIntro.Show()  'affichage objet
        fenIntro.BringToFront()
        'Me.Hide()
        Me.Close()

    End Sub

    Private Sub cmdEnr_Click(sender As Object, e As EventArgs) Handles cmdEnr.Click


        'frmClient.Controls.
        'si c'est un textbox 
        'regarder si il est vide
        'se positionner dessus anciennement (setfocus)
        'while  // ou for pour mettre toutes les erreurs en rouge
        '


        If txtNom.Text = "" Or txtPrenom.Text = "" Or txtAdresse.Text = "" Or txtCodePostale.Text = "" Or txtVille.Text = "" Then
            MsgBox("un ou  des champs obligatoires ne sont pas renseignés")

        ElseIf txtDateNaissance.Text = "" And txtProfession.Text = "" And txtRevenu.Text = "" Then

            unClient.setcidt(cboCidt.Text)
            unClient.setnomClient(txtNom.Text)
            unClient.setprenomClient(txtPrenom.Text)
            unClient.setadresseClient(txtAdresse.Text)
            unClient.setcodePostaleClient(txtCodePostale.Text)
            unClient.setvilleClient(txtVille.Text)
            unClient.settelephoneClient(txtTelephone.Text)

            MsgBox("Client enregistré")


        ElseIf txtDateNaissance.Text = "" Or txtProfession.Text = "" Or txtRevenu.Text = "" Or txtMail.Text = "" Then
            MsgBox("un ou des champs obligatoires du Client Spécial ne sont pas renseignés")

        Else

            unClientVoit.setcidt(cboCidt.Text)
            unClientVoit.setnomClient(txtNom.Text)
            unClientVoit.setprenomClient(txtPrenom.Text)
            unClientVoit.setadresseClient(txtAdresse.Text)
            unClientVoit.setcodePostaleClient(txtCodePostale.Text)
            unClientVoit.setvilleClient(txtVille.Text)
            unClientVoit.settelephoneClient(txtTelephone.Text)

            unClientVoit.setdateNaissanceClient(txtDateNaissance.Text)
            unClientVoit.setrevenuClient(txtRevenu.Text)
            unClientVoit.setprofessionClient(txtProfession.Text)
            unClientVoit.setnomJeuneFilleClient(txtProfession.Text)



            '' enregister info complement appli
            radio = gpbSp.Controls(i)

            Do While radio.Checked = False And i < gpbSp.Controls.Count - 1
                i = i + 1 ' i+=1
                radio = gpbSp.Controls(i)
            Loop
            'Je m'arrête au bon endroit, pas beoin de parcourir toutes la liste
            situation = radio.Text
            unClientVoit.setsituationPatrimonialeClient(situation)

            unClientVoit.setmailClient(txtMail.Text)

            unClientVoit.setcorrespondanceClient(cbCorrespondance.Checked)
            unClientVoit.setcommercialeClient(cbCorrespondance.Checked)
            unClientVoit.setprestatairesClient(cbPrestataires.Checked)

            MsgBox("Client Spécial enregistré")
        End If

    End Sub

End Class