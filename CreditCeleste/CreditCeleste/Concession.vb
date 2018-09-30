Public Class Concession

    Private monNomConcession As String
    Private monAdresseConcession As String

    Public lesVendeurs As New List(Of Vendeur) 'collection fortement typé




    Sub New()

    End Sub

    Sub New(ByVal nomConcession As String, ByVal adresseConcession As String)
        monNomConcession = nomConcession
        monAdresseConcession = adresseConcession
    End Sub

    Sub SetConcession(ByVal nomConcession As String, ByVal adresseConcession As String)
        monNomConcession = nomConcession
        monAdresseConcession = adresseConcession
    End Sub


End Class
