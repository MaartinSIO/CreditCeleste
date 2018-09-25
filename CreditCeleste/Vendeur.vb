Public Class Vendeur

    Private monIdtVendeur As String
    Private monNomVendeur As String
    Private monPrenomVendeur As String


    'constructeur
    '
    'En C# et java -> le nom de la classe

    Sub New()

    End Sub

    Sub New(ByVal idtVendeur As String, nomVendeur As String, prenomVendeur As String)
        monIdtVendeur = idtVendeur
        monNomVendeur = nomVendeur
        monPrenomVendeur = prenomVendeur

    End Sub

    Public Function getVendeur() As String

        Return monIdtVendeur + " " + monNomVendeur + " " + monPrenomVendeur

    End Function


End Class

