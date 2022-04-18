Imports FullNode_Wallet.Vault_interact

Public Class Vault_Darlehen

    Public darlehen As Vault_Bearbeiten
    Private Sub btn_moreLoan_Click(sender As Object, e As EventArgs) Handles btn_moreLoan.Click
        darlehen.interact_Loan(interact.moreLoan, lbl_tickerName.Text)
    End Sub
    Private Sub btn_reduceLoan_Click(sender As Object, e As EventArgs) Handles btn_reduceLoan.Click
        darlehen.interact_Loan(interact.reduceLoan, lbl_tickerName.Text)
    End Sub
End Class
