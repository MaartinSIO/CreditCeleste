Imports ClscCalcul
Imports System.Data.SqlClient

Public Class frmCredit

    Private Sub frmCredit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'objet vers ecran TO DO MS

        montant.Text = unCredit.getmontant()
        taux.Text = unCredit.getmontant()
        duree.Text = unCredit.getmontant()





    End Sub



    Private Sub Btn_Click(sender As System.Object, e As System.EventArgs) Handles Btn.Click
        Dim Credit = New credit(taux.Text, montant.Text, duree.Text)

        mensualite.Text = Credit.calcmensualite()


    End Sub

    Private Sub cmdIntroduction_Click(sender As Object, e As EventArgs) Handles cmdIntroduction.Click

        If fenIntro Is Nothing Then
            fenIntro = New frmIntroduction 'Design pattern : singleton
        ElseIf fenIntro.IsDisposed Then
            fenIntro = New frmIntroduction
        End If


        fenIntro.Show()  'affichage objet
        fenIntro.BringToFront()
        Me.Close()
    End Sub

    Private Sub CmdEnrCredit_Click(sender As Object, e As EventArgs) Handles CmdEnrCredit.Click
        Dim strRequete As String = "INSERT INTO [dbo].[CREDIT]
                                  (Montantfinance, NombreMensualites, MontantMensualites, TauxAnnuel, ClientCredit)
                                  VALUES
                                  (1000, 48, 201, 2.92,'Schultz')"

        Try

            '//connexion à la BDD

            Dim oConnexion As SqlConnection = New SqlConnection(strConnexion)

            '//lancer ma commande
            Dim oCommand As SqlCommand = New SqlCommand(strRequete, oConnexion)

            '//ouvrir la BDD
            oConnexion.Open()
            oCommand.ExecuteNonQuery()

            '//se positionner sur le premier objet

            'Dim oReader As SqlDataReader = oCommand.ExecuteReader()

            '//lire l'enregistrement
            '//
            '//Console.WriteLine(oReader.GetValue(0) + " " + oReader.GetValue(1));
            '//Console.WriteLine(oReader.Item(0) + " " + oReader.Item(1));  //selon version
            '//Console.WriteLine(oReader.GetString(0) + " " + oReader.GetString(1));
            '//Console.WriteLine(oReader(0) + " " + oReader(1));  // en vb
            'Console.WriteLine(oReader("NomVendeur") + " " + oReader("PrenomVendeur"))


            'While (oReader.Read())

            '    '//affiche tout les lignes de la requete
            '    Console.WriteLine(oReader.GetValue(0) + " " + oReader.GetValue(1))

            'End While
            'oReader.Close()


            oConnexion.Close()

        Catch ex As Exception

            Console.WriteLine("Erreur : " + ex.Message)

        End Try

        unCredit.setCredit(montant.Text, taux.Text, mensualite.Text, taux.Text)
        MsgBox(unCredit.getCredit())

    End Sub
    Private Sub cmdConnexion_Click(sender As Object, e As EventArgs) Handles cmdConnexion.Click

        'lblConnexion.Text = "connecté"




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

    End Sub
End Class