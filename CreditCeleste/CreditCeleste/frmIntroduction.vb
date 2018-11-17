Public Class frmIntroduction

    Dim age As String 'age de la voiture
    Dim i As Integer
    Dim radio As RadioButton


    Private Sub frmIntroduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'affichage des vendeurs

        'lire les vendeurs de la concession
        For Each xVendeur In uneConcession.lesVendeurs
            cboVendeur.Items.Add(xVendeur.getVendeur())
        Next

        'de l'objet vers l'ecran
        txtNouVeh.Text = uneVoiture.getNouvVehicule()
        txtAncVeh.Text = uneVoiture.getAncVehicule()

        'gestion de l'age du véhicule
        'charger le client de l'objet  vers l'ecran
        txtNom.Text = unClientVoit.getnomClient()
        txtPrenom.Text = unClientVoit.getprenomClient()
        cboCidt.Text = unClientVoit.getcidt()


        'charger le radio bouton
        i = 0
        radio = gpbAge.Controls(i)
        age = uneVoiture.getAgeVehicule()

        'Do While radio.Checked = False And i < gpbAge.Controls.Count - 1
        '    radio = gpbAge.Controls(i)
        '    If age = radio.Text Then
        '        radio.Checked = True
        '    Else
        '        i = i + 1
        '    End If

        'Loop

        ''TO Do amélioration possible pour ne pas faire tout le tab

        For i = 0 To gpbAge.Controls.Count - 1
            radio = gpbAge.Controls(i) 'cast explicicte
            If age = radio.Text Then
                radio.Checked = True
            End If
        Next



    End Sub

    Private Sub cmdEnr_Click(sender As Object, e As EventArgs) Handles cmdEnr.Click

        uneVoiture.setNouvVehicule(txtNouVeh.Text)
        uneVoiture.setAncVehicule(txtAncVeh.Text)

        unClient.setcidt(cboCidt.Text)
        unClient.setnomClient(txtNom.Text)
        unClient.setprenomClient(txtPrenom.Text)



        '4ème methode
        i = 0
        radio = gpbAge.Controls(i)

        Do While radio.Checked = False And i < gpbAge.Controls.Count - 1
            i = i + 1 ' i+=1
            radio = gpbAge.Controls(i)
        Loop
        'Je m'arrête au bon endroit, pas beoin de parcourir toutes la liste

        age = radio.Text

        uneVoiture.setAgeVehicule(age)

        MsgBox(age + "     => " + "Enregistré")

    End Sub

    Private Sub cmdBien_Click(sender As Object, e As EventArgs) Handles cmdBien.Click
        'permet de saisr les infos du bien
        '
  


        If fenBien Is Nothing Then
            fenBien = New frmSaisieBien 'Design pattern : singleton
        ElseIf fenBien.IsDisposed Then
            fenBien = New frmSaisieBien
        End If


        fenBien.Show()  'affichage objet
        fenBien.BringToFront()
        Me.Close()


    End Sub

    Private Sub cmdCredit_Click(sender As Object, e As EventArgs) Handles cmdCredit.Click
        'mettre en place la fenetre du dredit
        ' le tout en c# (ecran et classe voiture)
        ' l'ecran en vb et la classe en c#


        If fenCredit Is Nothing Then
            fenCredit = New frmCredit 'Design pattern : singleton
        ElseIf fenCredit.IsDisposed Then
            fenCredit = New frmCredit
        End If


        fenCredit.Show()  'affichage objet
        fenCredit.BringToFront()
        Me.Close()

    End Sub

    Private Sub cmdClient_Click(sender As Object, e As EventArgs) Handles cmdClient.Click

        If fenClient Is Nothing Then
            fenClient = New frmClient 'Design pattern : singleton
        ElseIf fenClient.IsDisposed Then
            fenClient = New frmClient
        End If


        fenClient.Show()  'affichage objet
        fenClient.BringToFront()
        Me.Close()

    End Sub
End Class