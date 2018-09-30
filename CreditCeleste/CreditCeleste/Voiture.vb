Public Class Voiture
    ''attribut
    Private MonNouvVehicule As String
    Private MonAncVehicule As String
    Private MonAgeVehicule As String


    Private MaDatePremiereImmatriculation As String
    Private MonAnneeModele As String
    Private MonNumeroImmatriculation As String
    Private MonNumeroSerie As String
    Private MaPuissance As String

    'constructeur
    Sub New()

    End Sub

    Sub New(ByVal ancVehicule As String, ageAVehicule As String, nouvVehicule As String)
        MonAncVehicule = ancVehicule
        MonAgeVehicule = ageAVehicule
        MonNouvVehicule = nouvVehicule
    End Sub

    'principale
    Sub setbien(ByVal datePremiereImmatriculation As String, anneeModele As String, numeroImmatriculation As String, numeroSerie As String, puissance As String)
        MaDatePremiereImmatriculation = datePremiereImmatriculation
        MonAnneeModele = anneeModele
        MonNumeroImmatriculation = numeroImmatriculation
        MonNumeroSerie = numeroSerie
        MaPuissance = puissance
    End Sub

    Sub setVehicule(ByVal datePremiereImmatriculation As String, anneeModele As String, numeroImmatriculation As String, numeroSerie As String, puissance As String)
        MaDatePremiereImmatriculation = datePremiereImmatriculation
        MonAnneeModele = anneeModele
        MonNumeroImmatriculation = numeroImmatriculation
        MonNumeroSerie = numeroSerie
        MaPuissance = puissance
    End Sub


    Sub setVehicule(ByVal ancVehicule As String, ageAVehicule As String, nouvVehicule As String)
        MonAncVehicule = ancVehicule
        MonAgeVehicule = ageAVehicule
        MonNouvVehicule = nouvVehicule
    End Sub

    Public Function getVehicule() As String

        Return MonAncVehicule + " " + MonAgeVehicule + " " + MonNouvVehicule

    End Function


    ''perso
    Public Function getVehiculeAff() As String
        Return MaDatePremiereImmatriculation + " - " + MonAnneeModele + " - " + MonNumeroImmatriculation + " - " + MonNumeroSerie + " - " + MaPuissance
    End Function
    ''

    'Get de chaque attribut


    Public Function getAncVehicule() As String

        Return MonAncVehicule

    End Function

    Public Function getAgeVehiculee() As String

        Return MonAgeVehicule

    End Function
    Public Function getNouvVehicule() As String

        Return MonNouvVehicule

    End Function
    Public Function getDatePremiereImmatriculation() As String

        Return MaDatePremiereImmatriculation

    End Function
    Public Function getAnneeModele() As String

        Return MonAnneeModele

    End Function

    Public Function getNumeroImmatriculation() As String

        Return MonNumeroImmatriculation

    End Function

    Public Function getNumeroSerie() As String

        Return MonNumeroSerie

    End Function
    Public Function getPuissance() As String

        Return MaPuissance

    End Function


    'Set chaque attribut

    Sub setAncVehicule(ByVal ancVehicule As String)
        MonAncVehicule = ancVehicule
    End Sub
    Sub setAgeVehicule(ByVal ageAVehicule As String)
        MonAgeVehicule = ageAVehicule
    End Sub

    Sub setNouvVehicule(ByVal nouvVehicule As String)
        MonNouvVehicule = nouvVehicule
    End Sub

    Sub setDatePremiereImmatriculation(ByVal datePremiereImmatriculation As String)
        MaDatePremiereImmatriculation = datePremiereImmatriculation

    End Sub
    Sub setAnneeModele(ByVal anneeModele As String)
        MonAnneeModele = anneeModele
    End Sub

    Sub setNumeroImmatriculatio(ByVal numeroImmatriculation As String)
        MonNumeroImmatriculation = numeroImmatriculation
    End Sub

    Sub setNumeroSerie(ByVal numeroSerie As String)
        MonNumeroSerie = numeroSerie
    End Sub

    Sub setPuissance(ByVal puissance As String)

        MaPuissance = puissance
    End Sub
End Class