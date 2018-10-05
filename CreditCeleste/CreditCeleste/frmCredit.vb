Imports ClscCalcul
Imports System.Data.SqlClient

Public Class frmCredit
    Private taux1 As Double
    Private duree1 As Double
    Private mensualite1 As Double
    Private montant1 As Double
    Private Sub frmCredit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub taux_TextChanged(sender As System.Object, e As System.EventArgs) Handles taux.TextChanged
        taux1 = Convert.ToDouble(taux.Text)

    End Sub

    Private Sub montant_TextChanged(sender As System.Object, e As System.EventArgs) Handles montant.TextChanged
        montant1 = Convert.ToDouble(montant.Text)
    End Sub

    Private Sub duree_TextChanged(sender As System.Object, e As System.EventArgs) Handles duree.TextChanged
        duree1 = Convert.ToDouble(duree.Text)

    End Sub

    Private Sub mensualite_TextChanged(sender As System.Object, e As System.EventArgs) Handles mensualite.TextChanged

    End Sub

    Private Sub Btn_Click(sender As System.Object, e As System.EventArgs) Handles Btn.Click
        Dim Credit = New ClscCalcul.Calcul(taux1, montant1, duree1)

        mensualite1 = Credit.calcmensualite()
        mensualite.Text = mensualite1






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


        unCredit.setCredit(mensualite.Text, montant.Text, taux.Text)
        MsgBox(unCredit.getCredit())

    End Sub
    Private Sub cmdConnexion_Click(sender As Object, e As EventArgs) Handles cmdConnexion.Click
        'unCredit.setCredit(mensualite.Text, montant.Text, taux.Text)

        lblConnexion.Text = "connecté"


        Dim strConnexion As String = "Data Source=172.16.12.99;User Id=connEleveSio;password=mdpEleveSio;Initial Catalog=KREYDER-CreditCeleste"
        'Authentification sqlServeur


        'requete
        Dim strRequete As String = "SELECT NomVendeur, PrenomVendeur FROM VENDEUR"

        Try

            '//connexion à la BDD

            Dim oConnexion As SqlConnection = New SqlConnection(strConnexion)

            '//lancer ma commande
            Dim oCommand As SqlCommand = New SqlCommand(strRequete, oConnexion)

            '//ouvrir la BDD
            oConnexion.Open()
            '//
            '//se positionner sur le premier objet

            Dim oReader As SqlDataReader = oCommand.ExecuteReader()

            '//lire l'enregistrement
            '//
            '//Console.WriteLine(oReader.GetValue(0) + " " + oReader.GetValue(1));
            '//Console.WriteLine(oReader.Item(0) + " " + oReader.Item(1));  //selon version
            '//Console.WriteLine(oReader.GetString(0) + " " + oReader.GetString(1));
            '//Console.WriteLine(oReader(0) + " " + oReader(1));  // en vb
            'Console.WriteLine(oReader("NomVendeur") + " " + oReader("PrenomVendeur"))


            While (oReader.Read())

                '//affiche tout les lignes de la requete
                Console.WriteLine(oReader.GetValue(0) + " " + oReader.GetValue(1))

            End While

            oReader.Close()
            oConnexion.Close()

        Catch ex As Exception

            Console.WriteLine("Erreur : " + ex.Message)

        End Try





    End Sub



End Class