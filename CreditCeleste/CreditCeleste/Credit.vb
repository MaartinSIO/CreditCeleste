Public Class Credit




    Private MontantFinance As Double
    'Private NombreMensualites As Integer
    Private MontantMensualites As Double
    Private TauxAnnuel As Double
    Private DateOuverture As Date

    Sub New()

    End Sub

    Sub setCredit(ByVal MntFinance As Double, MntMensualites As Double, TxAnnuel As Double)

        MontantFinance = MntFinance
        'NombreMensualites = NbMensualites
        MontantMensualites = MntMensualites
        TauxAnnuel = TxAnnuel

    End Sub

    Public Function getCredit() As String
        Return MontantMensualites + " " + TauxAnnuel + " " + MontantFinance
    End Function

End Class
