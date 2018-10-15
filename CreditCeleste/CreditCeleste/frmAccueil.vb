Imports System.Data.SqlClient


Public Class frmAccueil

    Private Sub cmdIntroduction_Click(sender As Object, e As EventArgs) Handles cmdIntroduction.Click



        ' Dim fenIntro As New frmIntroduction
        ' Dim fenIntro2 As New frmIntroduction  deux objet frm

        'aller vers la fenetre introduction
        '
        'frmIntroduction.Show()  'affiche une classe
        If fenIntro Is Nothing Then
            fenIntro = New frmIntroduction 'Design pattern : singleton
        End If


        fenIntro.Show()  'affichage objet
        fenIntro.BringToFront()

        Me.Hide()


        ' fenIntro.ShowDialog()  '' fenetre modale pour forcer la fermeture de la fenetre avant de changer
        'bdd

    End Sub

    Private Sub frmAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strRequete As String = "SELECT NomVendeur, PrenomVendeur FROM VENDEUR"

        Dim i As Integer = 0


        Try

            Dim oConnexion As SqlConnection = New SqlConnection(strConnexion)

                '//lancer ma commande
                Dim oCommand As SqlCommand = New SqlCommand(strRequete, oConnexion)

            '//ouvrir la BDD
            oConnexion.Open()
            'oCommand.ExecuteNonQuery()
            Dim oReader As SqlDataReader = oCommand.ExecuteReader()

            While (oReader.Read())
                i = i + 1
                '//affiche tout les lignes de la requete
                Dim unVendeur(i) As New Vendeur("nomVendeur", "prenomVendeur")
                uneConcession.lesVendeurs.Add(unVendeur(i))

            End While

            oConnexion.Close()

        Catch ex As Exception

            Console.WriteLine("Erreur : " + ex.Message)

        End Try



        uneConcession.SetConcession("garage du parc", "rue des rossignol") 'si declaration avec NEW
        'ou uneConcession= NewConcession("garage du parc", "rue des rossignol")

        'creation vendeur
        'Dim unVendeur As New Vendeur("M", "SCHULTZ", "Martin")
        Dim un2Vendeur As New Vendeur("Mme", "Quatre", "Quart")
        Dim un3Vendeur As New Vendeur("Mme", "Twu", "pack")

        'uneConcession.lesVendeurs.Add(unVendeur)
        uneConcession.lesVendeurs.Add(un2Vendeur)
        uneConcession.lesVendeurs.Add(un3Vendeur)


        'For Each row In Vendeur(i)
        '    i = i + 1
        '    uneConcession.lesVendeurs.Add(Vendeur(i))

        'Next

    End Sub
End Class
