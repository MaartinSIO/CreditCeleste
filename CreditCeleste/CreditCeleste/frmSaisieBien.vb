Imports System.Data.SqlClient



Public Class frmSaisieBien

    Dim age As String 'age de la voiture
    Dim i As Integer
    Dim radio As RadioButton

    Private Sub frmSaisieBien_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        lblAncVeh.Text = uneVoiture.getAncVehicule()
        txtDate1Imm.Text = uneVoiture.getDatePremiereImmatriculation()
        txtAnnMod.Text = uneVoiture.getAnneeModele()
        txtNumImm.Text = uneVoiture.getNumeroImmatriculation()
        txtNumSer.Text = uneVoiture.getNumeroSerie()
        txtPuiss.Text = uneVoiture.getPuissance()

        'pour ré afficher le radio bouton sur l'age de la voiture
        i = 0
        age = uneVoiture.getAgeVehicule()
        radio = gpbAge.Controls(i)
        Do While radio.Checked = False And i < gpbAge.Controls.Count - 1
            radio = gpbAge.Controls(i)
            If age = radio.Text Then
                radio.Checked = True
            Else
                i = i + 1
            End If

        Loop




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

        uneVoiture = New Voiture()
        uneVoiture.setVehicule(txtDate1Imm.Text, txtAnnMod.Text, txtNumImm.Text, txtNumSer.Text, txtPuiss.Text)
        MsgBox(uneVoiture.getVehiculeAff() + "    => " + "Enregistré")


        radio = gpbAge.Controls(i)

        Do While radio.Checked = False And i < gpbAge.Controls.Count - 1
            i = i + 1 ' i+=1
            radio = gpbAge.Controls(i)
        Loop
        'Je m'arrête au bon endroit, pas beoin de parcourir toutes la liste
        age = radio.Text
        uneVoiture.setAgeVehicule(age)

        'Sauvegarde dans la BDD

        'Mettre la table et les champs associés 
        Dim strRequete As String = "INSERT INTO [dbo].[VEHICULE]
                                  ()
                                  VALUES
                                  (lblAncVeh.Text, txtDate1Imm.Text, txtAnnMod.Text, txtNumImm.Text, txtNumSer.Text, txtPuiss.Text)"
        Try

            '//connexion à la BDD

            Dim oConnexion As SqlConnection = New SqlConnection(strConnexion)

            '//lancer ma commande
            Dim oCommand As SqlCommand = New SqlCommand(strRequete, oConnexion)

            '//ouvrir la BDD
            oConnexion.Open()
            oCommand.ExecuteNonQuery()



            oConnexion.Close()

        Catch ex As Exception

            Console.WriteLine("Erreur : " + ex.Message)

        End Try

    End Sub

    Private Sub cmdCredit_Click(sender As Object, e As EventArgs) Handles cmdCredit.Click
        'chainage vers le credit
        If fenCredit Is Nothing Then
            fenCredit = New frmCredit 'Design pattern : singleton
        ElseIf fenCredit.IsDisposed Then
            fenCredit = New frmCredit
        End If


        fenCredit.Show()  'affichage objet
        fenCredit.BringToFront()
        Me.Close()


    End Sub
End Class