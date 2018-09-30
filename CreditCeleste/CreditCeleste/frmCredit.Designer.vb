<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCredit
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
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mensualite = New System.Windows.Forms.TextBox()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.duree = New System.Windows.Forms.TextBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.montant = New System.Windows.Forms.TextBox()
        Me.taux = New System.Windows.Forms.TextBox()
        Me.Btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(334, 153)
        Me.lbl2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(85, 17)
        Me.lbl2.TabIndex = 19
        Me.lbl2.Text = "MONTANT :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(338, 89)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "TAUX :"
        '
        'mensualite
        '
        Me.mensualite.Location = New System.Drawing.Point(334, 302)
        Me.mensualite.Margin = New System.Windows.Forms.Padding(4)
        Me.mensualite.Name = "mensualite"
        Me.mensualite.Size = New System.Drawing.Size(132, 22)
        Me.mensualite.TabIndex = 17
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(334, 281)
        Me.lbl4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(103, 17)
        Me.lbl4.TabIndex = 16
        Me.lbl4.Text = "MENSUALITE :"
        '
        'duree
        '
        Me.duree.Location = New System.Drawing.Point(334, 237)
        Me.duree.Margin = New System.Windows.Forms.Padding(4)
        Me.duree.Name = "duree"
        Me.duree.Size = New System.Drawing.Size(132, 22)
        Me.duree.TabIndex = 15
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(334, 217)
        Me.lbl3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(64, 17)
        Me.lbl3.TabIndex = 14
        Me.lbl3.Text = "DUREE :"
        '
        'montant
        '
        Me.montant.Location = New System.Drawing.Point(334, 177)
        Me.montant.Margin = New System.Windows.Forms.Padding(4)
        Me.montant.Name = "montant"
        Me.montant.Size = New System.Drawing.Size(132, 22)
        Me.montant.TabIndex = 13
        '
        'taux
        '
        Me.taux.Location = New System.Drawing.Point(334, 113)
        Me.taux.Margin = New System.Windows.Forms.Padding(4)
        Me.taux.Name = "taux"
        Me.taux.Size = New System.Drawing.Size(132, 22)
        Me.taux.TabIndex = 12
        '
        'Btn
        '
        Me.Btn.Location = New System.Drawing.Point(338, 334)
        Me.Btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn.Name = "Btn"
        Me.Btn.Size = New System.Drawing.Size(100, 28)
        Me.Btn.TabIndex = 11
        Me.Btn.Text = "Validez"
        Me.Btn.UseVisualStyleBackColor = True
        '
        'frmCredit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mensualite)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.duree)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.montant)
        Me.Controls.Add(Me.taux)
        Me.Controls.Add(Me.Btn)
        Me.Name = "frmCredit"
        Me.Text = "frmCredit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents mensualite As TextBox
    Friend WithEvents lbl4 As Label
    Friend WithEvents duree As TextBox
    Friend WithEvents lbl3 As Label
    Friend WithEvents montant As TextBox
    Friend WithEvents taux As TextBox
    Friend WithEvents Btn As Button
End Class
