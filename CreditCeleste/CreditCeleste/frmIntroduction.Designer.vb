<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntroduction
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
        Me.cboCidt = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboVendeur = New System.Windows.Forms.ComboBox()
        Me.gpbAge = New System.Windows.Forms.GroupBox()
        Me.rdbOcc5 = New System.Windows.Forms.RadioButton()
        Me.rdbOcc3a5 = New System.Windows.Forms.RadioButton()
        Me.rdbOcc3 = New System.Windows.Forms.RadioButton()
        Me.rdbNeuf = New System.Windows.Forms.RadioButton()
        Me.txtNouVeh = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdEnr = New System.Windows.Forms.Button()
        Me.cmdBien = New System.Windows.Forms.Button()
        Me.cmdCredit = New System.Windows.Forms.Button()
        Me.cmdPlus = New System.Windows.Forms.Button()
        Me.txtAncVeh = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gpbAge.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboCidt
        '
        Me.cboCidt.FormattingEnabled = True
        Me.cboCidt.Items.AddRange(New Object() {"Madame", "Mademoiselle", "Monsieur"})
        Me.cboCidt.Location = New System.Drawing.Point(85, 89)
        Me.cboCidt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboCidt.Name = "cboCidt"
        Me.cboCidt.Size = New System.Drawing.Size(160, 24)
        Me.cboCidt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 65)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Je m'appelle"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 164)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nom"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(85, 135)
        Me.txtNom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(132, 22)
        Me.txtNom.TabIndex = 3
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(85, 204)
        Me.txtPrenom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(132, 22)
        Me.txtPrenom.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 233)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Prenom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 383)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Vendeur"
        '
        'cboVendeur
        '
        Me.cboVendeur.FormattingEnabled = True
        Me.cboVendeur.Location = New System.Drawing.Point(89, 402)
        Me.cboVendeur.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboVendeur.Name = "cboVendeur"
        Me.cboVendeur.Size = New System.Drawing.Size(160, 24)
        Me.cboVendeur.TabIndex = 7
        '
        'gpbAge
        '
        Me.gpbAge.Controls.Add(Me.rdbOcc5)
        Me.gpbAge.Controls.Add(Me.rdbOcc3a5)
        Me.gpbAge.Controls.Add(Me.rdbOcc3)
        Me.gpbAge.Controls.Add(Me.rdbNeuf)
        Me.gpbAge.Location = New System.Drawing.Point(356, 298)
        Me.gpbAge.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpbAge.Name = "gpbAge"
        Me.gpbAge.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpbAge.Size = New System.Drawing.Size(217, 155)
        Me.gpbAge.TabIndex = 8
        Me.gpbAge.TabStop = False
        Me.gpbAge.Text = "Age du véhicule"
        '
        'rdbOcc5
        '
        Me.rdbOcc5.AutoSize = True
        Me.rdbOcc5.Location = New System.Drawing.Point(8, 113)
        Me.rdbOcc5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdbOcc5.Name = "rdbOcc5"
        Me.rdbOcc5.Size = New System.Drawing.Size(171, 21)
        Me.rdbOcc5.TabIndex = 3
        Me.rdbOcc5.Text = "Occasion de 5ans et +"
        Me.rdbOcc5.UseVisualStyleBackColor = True
        '
        'rdbOcc3a5
        '
        Me.rdbOcc3a5.AutoSize = True
        Me.rdbOcc3a5.Location = New System.Drawing.Point(7, 80)
        Me.rdbOcc3a5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdbOcc3a5.Name = "rdbOcc3a5"
        Me.rdbOcc3a5.Size = New System.Drawing.Size(167, 21)
        Me.rdbOcc3a5.TabIndex = 2
        Me.rdbOcc3a5.Text = "Occasion de 3 à 5ans"
        Me.rdbOcc3a5.UseVisualStyleBackColor = True
        '
        'rdbOcc3
        '
        Me.rdbOcc3.AutoSize = True
        Me.rdbOcc3.Location = New System.Drawing.Point(7, 52)
        Me.rdbOcc3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdbOcc3.Name = "rdbOcc3"
        Me.rdbOcc3.Size = New System.Drawing.Size(152, 21)
        Me.rdbOcc3.TabIndex = 1
        Me.rdbOcc3.Text = "Occasion de - 3ans"
        Me.rdbOcc3.UseVisualStyleBackColor = True
        '
        'rdbNeuf
        '
        Me.rdbNeuf.AutoSize = True
        Me.rdbNeuf.Checked = True
        Me.rdbNeuf.Location = New System.Drawing.Point(8, 23)
        Me.rdbNeuf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdbNeuf.Name = "rdbNeuf"
        Me.rdbNeuf.Size = New System.Drawing.Size(59, 21)
        Me.rdbNeuf.TabIndex = 0
        Me.rdbNeuf.TabStop = True
        Me.rdbNeuf.Text = "Neuf"
        Me.rdbNeuf.UseVisualStyleBackColor = True
        '
        'txtNouVeh
        '
        Me.txtNouVeh.Location = New System.Drawing.Point(356, 135)
        Me.txtNouVeh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNouVeh.Name = "txtNouVeh"
        Me.txtNouVeh.Size = New System.Drawing.Size(161, 22)
        Me.txtNouVeh.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(352, 89)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Mon Nouveau véhicule"
        '
        'cmdEnr
        '
        Me.cmdEnr.Location = New System.Drawing.Point(149, 482)
        Me.cmdEnr.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdEnr.Name = "cmdEnr"
        Me.cmdEnr.Size = New System.Drawing.Size(100, 28)
        Me.cmdEnr.TabIndex = 11
        Me.cmdEnr.Text = "J'enregistre"
        Me.cmdEnr.UseVisualStyleBackColor = True
        '
        'cmdBien
        '
        Me.cmdBien.Location = New System.Drawing.Point(336, 482)
        Me.cmdBien.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdBien.Name = "cmdBien"
        Me.cmdBien.Size = New System.Drawing.Size(100, 28)
        Me.cmdBien.TabIndex = 12
        Me.cmdBien.Text = "Voiture"
        Me.cmdBien.UseVisualStyleBackColor = True
        '
        'cmdCredit
        '
        Me.cmdCredit.Location = New System.Drawing.Point(512, 482)
        Me.cmdCredit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCredit.Name = "cmdCredit"
        Me.cmdCredit.Size = New System.Drawing.Size(100, 28)
        Me.cmdCredit.TabIndex = 13
        Me.cmdCredit.Text = "Crédit"
        Me.cmdCredit.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        Me.cmdPlus.Location = New System.Drawing.Point(855, 482)
        Me.cmdPlus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.Size = New System.Drawing.Size(100, 28)
        Me.cmdPlus.TabIndex = 14
        Me.cmdPlus.Text = "Plus..."
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'txtAncVeh
        '
        Me.txtAncVeh.Location = New System.Drawing.Point(356, 233)
        Me.txtAncVeh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAncVeh.Name = "txtAncVeh"
        Me.txtAncVeh.Size = New System.Drawing.Size(161, 22)
        Me.txtAncVeh.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(352, 204)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Mon Ancien véhicule"
        '
        'frmIntroduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.txtAncVeh)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdPlus)
        Me.Controls.Add(Me.cmdCredit)
        Me.Controls.Add(Me.cmdBien)
        Me.Controls.Add(Me.cmdEnr)
        Me.Controls.Add(Me.txtNouVeh)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.gpbAge)
        Me.Controls.Add(Me.cboVendeur)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboCidt)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmIntroduction"
        Me.Text = "frmIntroduction"
        Me.gpbAge.ResumeLayout(False)
        Me.gpbAge.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboCidt As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboVendeur As ComboBox
    Friend WithEvents gpbAge As GroupBox
    Friend WithEvents rdbOcc5 As RadioButton
    Friend WithEvents rdbOcc3a5 As RadioButton
    Friend WithEvents rdbOcc3 As RadioButton
    Friend WithEvents rdbNeuf As RadioButton
    Friend WithEvents txtNouVeh As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdEnr As Button
    Friend WithEvents cmdBien As Button
    Friend WithEvents cmdCredit As Button
    Friend WithEvents cmdPlus As Button
    Friend WithEvents txtAncVeh As TextBox
    Friend WithEvents Label6 As Label
End Class
