Public Class Vault
    Public vaultEl As Vault_Bearbeiten
    Private Sub lnklbl_vaultID_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklbl_vaultID.LinkClicked
        Process.Start(lnklbl_vaultID.Tag)
    End Sub
    Private Sub btn_collateral_Click(sender As Object, e As EventArgs) Handles btn_collateral.Click
        FullNode_Wallet.lbl_overview.Text = FullNode_Wallet.textSicherheiten
        FullNode_Wallet.pnl_x.Controls.Clear()
        open_Vaultedit()
    End Sub
    Private Sub btn_loan_Click(sender As Object, e As EventArgs) Handles btn_loan.Click
        FullNode_Wallet.lbl_overview.Text = FullNode_Wallet.textDarlehen
        FullNode_Wallet.pnl_x.Controls.Clear()
        open_Vaultedit()
    End Sub
    Private Sub open_Vaultedit()
        vaultEl = New Vault_Bearbeiten
        vaultEl.Tag = Me.Tag
        If FullNode_Wallet.lbl_overview.Text = FullNode_Wallet.textSicherheiten Then
            vaultEl.btn_xToken.Text = "+ neuer CollateralToken hinzufügen"
        ElseIf FullNode_Wallet.lbl_overview.Text = FullNode_Wallet.textDarlehen Then
            vaultEl.btn_xToken.Text = "+ neuer DarlehensToken aufnehmen"
        End If
        vaultEl.Dock = DockStyle.Fill
        FullNode_Wallet.pnl_x.Controls.Add(vaultEl)
        FullNode_Wallet.vaultEdit = vaultEl
        FullNode_Wallet.timer_refresh.Interval = 1
    End Sub
End Class
