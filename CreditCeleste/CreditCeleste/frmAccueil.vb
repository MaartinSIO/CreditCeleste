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

        Me.Hide()


        ' fenIntro.ShowDialog()  '' fenetre modale pour forcer la fermeture de la fenetre avant de changer


    End Sub

    Private Sub frmAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        uneConcession.SetConcession("garage du parc", "rue des rossignol") 'si declaration avec NEW
        'ou uneConcession= NewConcession("garage du parc", "rue des rossignol")

        'creation vendeur
        Dim unVendeur As New Vendeur("M", "SCHULTZ", "Martin")
        Dim un2Vendeur As New Vendeur("Mme", "Quatre", "Quart")
        Dim un3Vendeur As New Vendeur("Mme", "Twu", "pack")

        uneConcession.lesVendeurs.Add(unVendeur)
        uneConcession.lesVendeurs.Add(un2Vendeur)
        uneConcession.lesVendeurs.Add(un3Vendeur)



    End Sub
End Class
