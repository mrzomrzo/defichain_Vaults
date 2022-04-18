Imports FullNode_Wallet.Vault_interact
Public Class Vault_Sicherheiten


    Public sicherheiten As Vault_Bearbeiten
    Private Sub btn_addCollateral_Click(sender As Object, e As EventArgs) Handles btn_addCollateral.Click
        sicherheiten.interact_Collateral(interact.addCollateral, lbl_tickerName.Text)
    End Sub
    Private Sub btn_removeCollateral_Click(sender As Object, e As EventArgs) Handles btn_removeCollateral.Click
        sicherheiten.interact_Collateral(interact.removeCollateral, lbl_tickerName.Text)
    End Sub


End Class
