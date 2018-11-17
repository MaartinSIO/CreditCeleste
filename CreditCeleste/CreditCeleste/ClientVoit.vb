Imports csClient        'permet de recup le client en c#

Public Class ClientVoit ' declaration classe 

    Inherits Client  ' c'est un héritage ; en c# : Client

    Private dateNaissanceClient As String
    Private revenuClient As String
    Private professionClient As String
    Private nomJeuneFilleClient As String


    Private situationPatrimonialeClient As String
    Private mailClient As String
    Private correspondanceClient As Boolean
    Private commercialeClient As Boolean
    Private prestatairesClient As Boolean


    Sub New()

    End Sub


    ' get 
    Public Function getdateNaissanceClient() As String
        Return dateNaissanceClient
    End Function

    Public Function getrevenuClient() As String
        Return revenuClient
    End Function

    Public Function getprofessionClient() As String
        Return professionClient
    End Function


    Public Function getnomJeuneFilleclient() As String
        Return nomJeuneFilleClient
    End Function

    '''''''''''''''''''''''''get complement application

    Public Function getsituationPatrimonialeClient() As String
        Return situationPatrimonialeClient
    End Function
    Public Function getmailClient() As String
        Return mailClient
    End Function
    Public Function getcorrespondanceClient() As Boolean
        Return correspondanceClient
    End Function
    Public Function getcommercialeClient() As Boolean
        Return commercialeClient
    End Function
    Public Function getprestatairesClient() As Boolean
        Return prestatairesClient
    End Function

    ' set 

    Sub setdateNaissanceClient(ByVal dateNaissanceCli As String)
        dateNaissanceClient = dateNaissanceCli
    End Sub

    Sub setrevenuClient(ByVal revenuCli As String)
        revenuClient = revenuCli
    End Sub

    Sub setprofessionClient(ByVal professionCli As String)
        professionClient = professionClient
    End Sub

    Sub setnomJeuneFilleClient(ByVal nomJeuneFilleCli As String)
        nomJeuneFilleClient = nomJeuneFilleCli
    End Sub

    ''''''''''''''set complément application
    Sub setsituationPatrimonialeClient(ByVal situationPatrimonialeCli As String)
        situationPatrimonialeClient = situationPatrimonialeCli
    End Sub
    Sub setmailClient(ByVal mailCli As String)
        mailClient = mailCli
    End Sub

    Sub setcorrespondanceClient(ByVal correspondanceCli As Boolean)
        correspondanceClient = correspondanceCli
    End Sub
    Sub setcommercialeClient(ByVal commercialeCli As Boolean)
        commercialeClient = commercialeCli
    End Sub
    Sub setprestatairesClient(ByVal prestatairesCli As Boolean)
        prestatairesClient = prestatairesCli
    End Sub

    ''''''''''''''''''''' propriété (exemple) : equivalent à get et set
    'Public Property Profession() As String
    '    Get
    '        Return professionClient
    '    End Get
    '    Set(value As String)
    '        professionClient = value
    '    End Set
    'End Property


End Class
