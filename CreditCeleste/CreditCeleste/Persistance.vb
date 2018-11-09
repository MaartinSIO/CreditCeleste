Imports System.Data.SqlClient



Public Class Persistance
    'classe avec methode de classe

    ' pas besoin de constructeur 

    Public Shared Sub versBddCredit() 'methode de classe, enc#, en java : mot clé static

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
            oConnexion.Close()

        Catch ex As Exception
            Console.WriteLine("Erreur : " + ex.Message)

        End Try

    End Sub

    Public Shared Sub depuisBddCredit()

    End Sub

    Public Shared Sub depuisBddVendeur()

        'recup les vendeurs depuis la bdd pour les mettres 

        Dim strRequete As String = "SELECT NomVendeur, PrenomVendeur FROM VENDEUR"
        Dim i As Integer = 0

        Try

            Dim oConnexion As SqlConnection = New SqlConnection(strConnexion)

            '//lancer ma commande
            Dim oCommand As SqlCommand = New SqlCommand(strRequete, oConnexion)

            oConnexion.Open()
            oCommand.ExecuteNonQuery()
            Dim oReader As SqlDataReader = oCommand.ExecuteReader()

            While (oReader.Read())

                i = i + 1

                '//affiche tout les lignes de la requete
                ' Dim unVendeur(i) As New Vendeur("nomVendeur", "prenomVendeur")


            End While

            oConnexion.Close()

        Catch ex As Exception

            Console.WriteLine("Erreur : " + ex.Message)

        End Try


    End Sub

End Class
