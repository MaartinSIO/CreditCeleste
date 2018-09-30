<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaisieBien
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDate1Imm = New System.Windows.Forms.TextBox()
        Me.txtAnnMod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumImm = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumSer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPuiss = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdEnr = New System.Windows.Forms.Button()
        Me.cmdIntro = New System.Windows.Forms.Button()
        Me.cmdCredit = New System.Windows.Forms.Button()
        Me.lblAncVeh = New System.Windows.Forms.Label()
        Me.gpbAge = New System.Windows.Forms.GroupBox()
        Me.rdbOcc5 = New System.Windows.Forms.RadioButton()
        Me.rdbOcc3a5 = New System.Windows.Forms.RadioButton()
        Me.rdbOcc3 = New System.Windows.Forms.RadioButton()
        Me.rdbNeuf = New System.Windows.Forms.RadioButton()
        Me.gpbAge.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 304)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "date de 1ère immatriculation"
        '
        'txtDate1Imm
        '
        Me.txtDate1Imm.Location = New System.Drawing.Point(40, 281)
        Me.txtDate1Imm.Name = "txtDate1Imm"
        Me.txtDate1Imm.Size = New System.Drawing.Size(100, 20)
        Me.txtDate1Imm.TabIndex = 2
        '
        'txtAnnMod
        '
        Me.txtAnnMod.Location = New System.Drawing.Point(198, 281)
        Me.txtAnnMod.Name = "txtAnnMod"
        Me.txtAnnMod.Size = New System.Drawing.Size(100, 20)
        Me.txtAnnMod.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 304)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Année Modèle"
        '
        'txtNumImm
        '
        Me.txtNumImm.Location = New System.Drawing.Point(328, 281)
        Me.txtNumImm.Name = "txtNumImm"
        Me.txtNumImm.Size = New System.Drawing.Size(100, 20)
        Me.txtNumImm.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(325, 304)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "numéro d'immatriculation"
        '
        'txtNumSer
        '
        Me.txtNumSer.Location = New System.Drawing.Point(471, 284)
        Me.txtNumSer.Name = "txtNumSer"
        Me.txtNumSer.Size = New System.Drawing.Size(100, 20)
        Me.txtNumSer.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(468, 307)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "numéro de série"
        '
        'txtPuiss
        '
        Me.txtPuiss.Location = New System.Drawing.Point(615, 281)
        Me.txtPuiss.Name = "txtPuiss"
        Me.txtPuiss.Size = New System.Drawing.Size(100, 20)
        Me.txtPuiss.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(612, 307)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Puissance"
        '
        'cmdEnr
        '
        Me.cmdEnr.Location = New System.Drawing.Point(196, 378)
        Me.cmdEnr.Name = "cmdEnr"
        Me.cmdEnr.Size = New System.Drawing.Size(75, 23)
        Me.cmdEnr.TabIndex = 11
        Me.cmdEnr.Text = "J'enregiste"
        Me.cmdEnr.UseVisualStyleBackColor = True
        '
        'cmdIntro
        '
        Me.cmdIntro.Location = New System.Drawing.Point(328, 377)
        Me.cmdIntro.Name = "cmdIntro"
        Me.cmdIntro.Size = New System.Drawing.Size(75, 23)
        Me.cmdIntro.TabIndex = 12
        Me.cmdIntro.Text = "Introduction"
        Me.cmdIntro.UseVisualStyleBackColor = True
        '
        'cmdCredit
        '
        Me.cmdCredit.Location = New System.Drawing.Point(471, 377)
        Me.cmdCredit.Name = "cmdCredit"
        Me.cmdCredit.Size = New System.Drawing.Size(75, 23)
        Me.cmdCredit.TabIndex = 13
        Me.cmdCredit.Text = "Credit"
        Me.cmdCredit.UseVisualStyleBackColor = True
        '
        'lblAncVeh
        '
        Me.lblAncVeh.AutoSize = True
        Me.lblAncVeh.Location = New System.Drawing.Point(58, 70)
        Me.lblAncVeh.Name = "lblAncVeh"
        Me.lblAncVeh.Size = New System.Drawing.Size(107, 13)
        Me.lblAncVeh.TabIndex = 14
        Me.lblAncVeh.Text = "mon Ancien Vehicule"
        '
        'gpbAge
        '
        Me.gpbAge.Controls.Add(Me.rdbOcc5)
        Me.gpbAge.Controls.Add(Me.rdbOcc3a5)
        Me.gpbAge.Controls.Add(Me.rdbOcc3)
        Me.gpbAge.Controls.Add(Me.rdbNeuf)
        Me.gpbAge.Location = New System.Drawing.Point(310, 70)
        Me.gpbAge.Name = "gpbAge"
        Me.gpbAge.Size = New System.Drawing.Size(163, 126)
        Me.gpbAge.TabIndex = 15
        Me.gpbAge.TabStop = False
        Me.gpbAge.Text = "Age du véhicule"
        '
        'rdbOcc5
        '
        Me.rdbOcc5.AutoSize = True
        Me.rdbOcc5.Location = New System.Drawing.Point(6, 92)
        Me.rdbOcc5.Name = "rdbOcc5"
        Me.rdbOcc5.Size = New System.Drawing.Size(132, 17)
        Me.rdbOcc5.TabIndex = 3
        Me.rdbOcc5.Text = "Occasion de 5ans et +"
        Me.rdbOcc5.UseVisualStyleBackColor = True
        '
        'rdbOcc3a5
        '
        Me.rdbOcc3a5.AutoSize = True
        Me.rdbOcc3a5.Location = New System.Drawing.Point(5, 65)
        Me.rdbOcc3a5.Name = "rdbOcc3a5"
        Me.rdbOcc3a5.Size = New System.Drawing.Size(129, 17)
        Me.rdbOcc3a5.TabIndex = 2
        Me.rdbOcc3a5.Text = "Occasion de 3 à 5ans"
        Me.rdbOcc3a5.UseVisualStyleBackColor = True
        '
        'rdbOcc3
        '
        Me.rdbOcc3.AutoSize = True
        Me.rdbOcc3.Location = New System.Drawing.Point(5, 42)
        Me.rdbOcc3.Name = "rdbOcc3"
        Me.rdbOcc3.Size = New System.Drawing.Size(117, 17)
        Me.rdbOcc3.TabIndex = 1
        Me.rdbOcc3.Text = "Occasion de - 3ans"
        Me.rdbOcc3.UseVisualStyleBackColor = True
        '
        'rdbNeuf
        '
        Me.rdbNeuf.AutoSize = True
        Me.rdbNeuf.Checked = True
        Me.rdbNeuf.Location = New System.Drawing.Point(6, 19)
        Me.rdbNeuf.Name = "rdbNeuf"
        Me.rdbNeuf.Size = New System.Drawing.Size(48, 17)
        Me.rdbNeuf.TabIndex = 0
        Me.rdbNeuf.TabStop = True
        Me.rdbNeuf.Text = "Neuf"
        Me.rdbNeuf.UseVisualStyleBackColor = True
        '
        'frmSaisieBien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gpbAge)
        Me.Controls.Add(Me.lblAncVeh)
        Me.Controls.Add(Me.cmdCredit)
        Me.Controls.Add(Me.cmdIntro)
        Me.Controls.Add(Me.cmdEnr)
        Me.Controls.Add(Me.txtPuiss)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNumSer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNumImm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAnnMod)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDate1Imm)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSaisieBien"
        Me.Text = "frmSaisieBien"
        Me.gpbAge.ResumeLayout(False)
        Me.gpbAge.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDate1Imm As TextBox
    Friend WithEvents txtAnnMod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumImm As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumSer As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPuiss As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdEnr As Button
    Friend WithEvents cmdIntro As Button
    Friend WithEvents cmdCredit As Button
    Friend WithEvents lblAncVeh As Label
    Friend WithEvents gpbAge As GroupBox
    Friend WithEvents rdbOcc5 As RadioButton
    Friend WithEvents rdbOcc3a5 As RadioButton
    Friend WithEvents rdbOcc3 As RadioButton
    Friend WithEvents rdbNeuf As RadioButton
End Class
