<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClient
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodePostale = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDateNaissance = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRevenu = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtProfession = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNomJeuneFille = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboCidt = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmdCredit = New System.Windows.Forms.Button()
        Me.cmdBien = New System.Windows.Forms.Button()
        Me.cmdIntro = New System.Windows.Forms.Button()
        Me.cmdEnr = New System.Windows.Forms.Button()
        Me.gpbSp = New System.Windows.Forms.GroupBox()
        Me.rdbOccupantGratuit = New System.Windows.Forms.RadioButton()
        Me.rdbLocataire = New System.Windows.Forms.RadioButton()
        Me.rdbProprietaire = New System.Windows.Forms.RadioButton()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.gpbMail = New System.Windows.Forms.GroupBox()
        Me.cbCorrespondance = New System.Windows.Forms.CheckBox()
        Me.cbPrestataires = New System.Windows.Forms.CheckBox()
        Me.cbCommerciale = New System.Windows.Forms.CheckBox()
        Me.gpbSp.SuspendLayout()
        Me.gpbMail.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(12, 231)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(100, 20)
        Me.txtPrenom.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Prenom"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(12, 174)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nom"
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(155, 110)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(100, 20)
        Me.txtAdresse.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Adresse"
        '
        'txtCodePostale
        '
        Me.txtCodePostale.Location = New System.Drawing.Point(155, 174)
        Me.txtCodePostale.Name = "txtCodePostale"
        Me.txtCodePostale.Size = New System.Drawing.Size(100, 20)
        Me.txtCodePostale.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(155, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Code Postale"
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(155, 292)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(100, 20)
        Me.txtTelephone.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(155, 318)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Téléphone (optionnel)"
        '
        'txtVille
        '
        Me.txtVille.Location = New System.Drawing.Point(155, 231)
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(100, 20)
        Me.txtVille.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(155, 261)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Ville"
        '
        'txtDateNaissance
        '
        Me.txtDateNaissance.Location = New System.Drawing.Point(292, 110)
        Me.txtDateNaissance.Name = "txtDateNaissance"
        Me.txtDateNaissance.Size = New System.Drawing.Size(100, 20)
        Me.txtDateNaissance.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(290, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Date de Naissance"
        '
        'txtRevenu
        '
        Me.txtRevenu.Location = New System.Drawing.Point(292, 171)
        Me.txtRevenu.Name = "txtRevenu"
        Me.txtRevenu.Size = New System.Drawing.Size(100, 20)
        Me.txtRevenu.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(290, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Revenu Mensuel"
        '
        'txtProfession
        '
        Me.txtProfession.Location = New System.Drawing.Point(292, 231)
        Me.txtProfession.Name = "txtProfession"
        Me.txtProfession.Size = New System.Drawing.Size(100, 20)
        Me.txtProfession.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(289, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Profession"
        '
        'txtNomJeuneFille
        '
        Me.txtNomJeuneFille.Location = New System.Drawing.Point(292, 292)
        Me.txtNomJeuneFille.Name = "txtNomJeuneFille"
        Me.txtNomJeuneFille.Size = New System.Drawing.Size(100, 20)
        Me.txtNomJeuneFille.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(289, 318)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Nom de Jeune Fille"
        '
        'cboCidt
        '
        Me.cboCidt.FormattingEnabled = True
        Me.cboCidt.Items.AddRange(New Object() {"Madame", "Mademoiselle", "Monsieur"})
        Me.cboCidt.Location = New System.Drawing.Point(12, 109)
        Me.cboCidt.Name = "cboCidt"
        Me.cboCidt.Size = New System.Drawing.Size(121, 21)
        Me.cboCidt.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 143)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Civilité"
        '
        'cmdCredit
        '
        Me.cmdCredit.Location = New System.Drawing.Point(563, 390)
        Me.cmdCredit.Name = "cmdCredit"
        Me.cmdCredit.Size = New System.Drawing.Size(75, 23)
        Me.cmdCredit.TabIndex = 29
        Me.cmdCredit.Text = "Crédit"
        Me.cmdCredit.UseVisualStyleBackColor = True
        '
        'cmdBien
        '
        Me.cmdBien.Location = New System.Drawing.Point(438, 390)
        Me.cmdBien.Name = "cmdBien"
        Me.cmdBien.Size = New System.Drawing.Size(75, 23)
        Me.cmdBien.TabIndex = 28
        Me.cmdBien.Text = "Voiture"
        Me.cmdBien.UseVisualStyleBackColor = True
        '
        'cmdIntro
        '
        Me.cmdIntro.Location = New System.Drawing.Point(306, 390)
        Me.cmdIntro.Name = "cmdIntro"
        Me.cmdIntro.Size = New System.Drawing.Size(75, 23)
        Me.cmdIntro.TabIndex = 30
        Me.cmdIntro.Text = "Introduction"
        Me.cmdIntro.UseVisualStyleBackColor = True
        '
        'cmdEnr
        '
        Me.cmdEnr.Location = New System.Drawing.Point(130, 390)
        Me.cmdEnr.Name = "cmdEnr"
        Me.cmdEnr.Size = New System.Drawing.Size(75, 23)
        Me.cmdEnr.TabIndex = 31
        Me.cmdEnr.Text = "J'enregiste"
        Me.cmdEnr.UseVisualStyleBackColor = True
        '
        'gpbSp
        '
        Me.gpbSp.Controls.Add(Me.rdbOccupantGratuit)
        Me.gpbSp.Controls.Add(Me.rdbLocataire)
        Me.gpbSp.Controls.Add(Me.rdbProprietaire)
        Me.gpbSp.Location = New System.Drawing.Point(438, 110)
        Me.gpbSp.Name = "gpbSp"
        Me.gpbSp.Size = New System.Drawing.Size(132, 95)
        Me.gpbSp.TabIndex = 32
        Me.gpbSp.TabStop = False
        Me.gpbSp.Text = "Situation patrimoniale"
        '
        'rdbOccupantGratuit
        '
        Me.rdbOccupantGratuit.AutoSize = True
        Me.rdbOccupantGratuit.Location = New System.Drawing.Point(5, 65)
        Me.rdbOccupantGratuit.Name = "rdbOccupantGratuit"
        Me.rdbOccupantGratuit.Size = New System.Drawing.Size(131, 17)
        Me.rdbOccupantGratuit.TabIndex = 2
        Me.rdbOccupantGratuit.Text = "occupant à titre gratuit"
        Me.rdbOccupantGratuit.UseVisualStyleBackColor = True
        '
        'rdbLocataire
        '
        Me.rdbLocataire.AutoSize = True
        Me.rdbLocataire.Location = New System.Drawing.Point(5, 42)
        Me.rdbLocataire.Name = "rdbLocataire"
        Me.rdbLocataire.Size = New System.Drawing.Size(69, 17)
        Me.rdbLocataire.TabIndex = 1
        Me.rdbLocataire.Text = "Locataire"
        Me.rdbLocataire.UseVisualStyleBackColor = True
        '
        'rdbProprietaire
        '
        Me.rdbProprietaire.AutoSize = True
        Me.rdbProprietaire.Checked = True
        Me.rdbProprietaire.Location = New System.Drawing.Point(6, 19)
        Me.rdbProprietaire.Name = "rdbProprietaire"
        Me.rdbProprietaire.Size = New System.Drawing.Size(78, 17)
        Me.rdbProprietaire.TabIndex = 0
        Me.rdbProprietaire.TabStop = True
        Me.rdbProprietaire.Text = "Propriétaire"
        Me.rdbProprietaire.UseVisualStyleBackColor = True
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(438, 231)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(100, 20)
        Me.txtMail.TabIndex = 33
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(442, 252)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Adresse Mail"
        '
        'gpbMail
        '
        Me.gpbMail.Controls.Add(Me.cbCorrespondance)
        Me.gpbMail.Controls.Add(Me.cbPrestataires)
        Me.gpbMail.Controls.Add(Me.cbCommerciale)
        Me.gpbMail.Location = New System.Drawing.Point(438, 280)
        Me.gpbMail.Name = "gpbMail"
        Me.gpbMail.Size = New System.Drawing.Size(356, 95)
        Me.gpbMail.TabIndex = 35
        Me.gpbMail.TabStop = False
        Me.gpbMail.Text = "J'accepte"
        '
        'cbCorrespondance
        '
        Me.cbCorrespondance.AutoSize = True
        Me.cbCorrespondance.Location = New System.Drawing.Point(6, 23)
        Me.cbCorrespondance.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbCorrespondance.Name = "cbCorrespondance"
        Me.cbCorrespondance.Size = New System.Drawing.Size(294, 17)
        Me.cbCorrespondance.TabIndex = 3
        Me.cbCorrespondance.Text = "L'utilisation de mon adresse mail  pour la correspondance"
        Me.cbCorrespondance.UseVisualStyleBackColor = True
        '
        'cbPrestataires
        '
        Me.cbPrestataires.AutoSize = True
        Me.cbPrestataires.Location = New System.Drawing.Point(6, 67)
        Me.cbPrestataires.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbPrestataires.Name = "cbPrestataires"
        Me.cbPrestataires.Size = New System.Drawing.Size(341, 17)
        Me.cbPrestataires.TabIndex = 2
        Me.cbPrestataires.Text = "Mon adresse mail pourra être utilisée pour des prestataires externes"
        Me.cbPrestataires.UseVisualStyleBackColor = True
        '
        'cbCommerciale
        '
        Me.cbCommerciale.AutoSize = True
        Me.cbCommerciale.Location = New System.Drawing.Point(6, 45)
        Me.cbCommerciale.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbCommerciale.Name = "cbCommerciale"
        Me.cbCommerciale.Size = New System.Drawing.Size(288, 17)
        Me.cbCommerciale.TabIndex = 1
        Me.cbCommerciale.Text = "Mon adresse mail pourra être utilisée à titre commerciale"
        Me.cbCommerciale.UseVisualStyleBackColor = True
        '
        'frmClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 497)
        Me.Controls.Add(Me.gpbMail)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.gpbSp)
        Me.Controls.Add(Me.cmdEnr)
        Me.Controls.Add(Me.cmdIntro)
        Me.Controls.Add(Me.cmdCredit)
        Me.Controls.Add(Me.cmdBien)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboCidt)
        Me.Controls.Add(Me.txtNomJeuneFille)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtProfession)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtRevenu)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDateNaissance)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtVille)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTelephone)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCodePostale)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAdresse)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmClient"
        Me.Text = "frmClient"
        Me.gpbSp.ResumeLayout(False)
        Me.gpbSp.PerformLayout()
        Me.gpbMail.ResumeLayout(False)
        Me.gpbMail.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodePostale As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtVille As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDateNaissance As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRevenu As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtProfession As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNomJeuneFille As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cboCidt As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmdCredit As Button
    Friend WithEvents cmdBien As Button
    Friend WithEvents cmdIntro As Button
    Friend WithEvents cmdEnr As Button
    Friend WithEvents gpbSp As GroupBox
    Friend WithEvents rdbOccupantGratuit As RadioButton
    Friend WithEvents rdbLocataire As RadioButton
    Friend WithEvents rdbProprietaire As RadioButton
    Friend WithEvents txtMail As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents gpbMail As GroupBox
    Friend WithEvents cbPrestataires As CheckBox
    Friend WithEvents cbCommerciale As CheckBox
    Friend WithEvents cbCorrespondance As CheckBox
End Class
