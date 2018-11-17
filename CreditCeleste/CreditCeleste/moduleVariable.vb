Imports ClscCalcul
Imports csClient

Module moduleVariable
    'accessible a tout le monde
    Public fenIntro As frmIntroduction
    Public fenBien As frmSaisieBien
    Public fenCredit As frmCredit
    Public fenClient As frmClient




    Public uneConcession As New Concession 'dans tout les cas doit etre créee
    'ou Public uneConcession As Concession()

    Public uneVoiture As New Voiture ' la voiture appartient au client 
    Public unClientVoit As New ClientVoit
    Public unCredit As New credit
    Public unClient As New Client

    Public strConnexion As String = "Data Source=172.16.12.99;User Id=connEleveSio;password=mdpEleveSio;Initial Catalog=KREYDER-CreditCeleste"

End Module
