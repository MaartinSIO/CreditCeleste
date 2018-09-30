Imports ClscCalcul

Public Class frmCredit
    Private taux1 As Double
    Private duree1 As Double
    Private mensualite1 As Double
    Private montant1 As Double
    Private Sub frmCredit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub taux_TextChanged(sender As System.Object, e As System.EventArgs) Handles taux.TextChanged
        taux1 = Convert.ToDouble(taux.Text)

    End Sub

    Private Sub montant_TextChanged(sender As System.Object, e As System.EventArgs) Handles montant.TextChanged
        montant1 = Convert.ToDouble(montant.Text)
    End Sub

    Private Sub duree_TextChanged(sender As System.Object, e As System.EventArgs) Handles duree.TextChanged
        duree1 = Convert.ToDouble(duree.Text)

    End Sub

    Private Sub mensualite_TextChanged(sender As System.Object, e As System.EventArgs) Handles mensualite.TextChanged

    End Sub

    Private Sub Btn_Click(sender As System.Object, e As System.EventArgs) Handles Btn.Click
        Dim Credit = New ClscCalcul.Calcul(taux1, montant1, duree1)

        mensualite1 = Credit.calcmensualite()
        mensualite.Text = mensualite1






    End Sub

End Class