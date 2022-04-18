Imports FullNode_Wallet.Vault_interact
Imports FullNode_Wallet.FullNode_Wallet
Public Class Vault_Bearbeiten

    Dim rpc As New fullNodeClientDFI

    Private Sub lnklbl_vaultID_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklbl_vaultID.LinkClicked
        Process.Start(lnklbl_vaultID.Tag)
    End Sub

    Private Sub btn_addCollateralToken_Click(sender As Object, e As EventArgs) Handles btn_xToken.Click
        If FullNode_Wallet.lbl_overview.Text = textSicherheiten Then
            interact_Collateral(interact.addCollateral)
        ElseIf FullNode_Wallet.lbl_overview.Text = textDarlehen Then
            interact_Loan(interact.moreLoan)
        End If
    End Sub


    Public Sub interact_Collateral(x As interact, Optional asset As String = "")
        FullNode_Wallet.lbl_overview.Text = textaddremoveCollateral
        pnl_edit.Controls.Clear()
        btn_xToken.Enabled = False
        Dim userControl As New Vault_interact
        userControl.Tag = Me.Tag
        userControl.vault = rpc.get_vault(Me.Tag)
        userControl.vaultedit = Me
        userControl.AKtion = x
        Dim colTokens = rpc.get_listCollateralTokens()
        For i = 0 To colTokens.Count - 1
            userControl.cmb_ticker.Items.Add(colTokens(i)("token"))
        Next
        If x = interact.addCollateral Then
            userControl.lbl_icon_add_remove.Text = "+"
            userControl.lbl_icon_add_remove.BackColor = Color.LimeGreen
            userControl.btn_confirm.Text = "Collateral hinzufügen"
        ElseIf x = interact.removeCollateral Then
            userControl.lbl_icon_add_remove.Text = "-"
            userControl.lbl_icon_add_remove.BackColor = Color.OrangeRed
            userControl.btn_confirm.Text = "Collateral entfernen"
            userControl.cmb_ticker.Enabled = False
        End If
        userControl.Top = pnl_edit.Height - userControl.Height
        userControl.Dock = DockStyle.Bottom
        pnl_edit.Controls.Add(userControl)
        If asset <> "" Then
            userControl.cmb_ticker.SelectedIndex = userControl.cmb_ticker.FindStringExact(asset)
        End If
    End Sub

    Public Sub interact_Loan(ByVal x As interact, Optional asset As String = "")
        FullNode_Wallet.lbl_overview.Text = textaddremoveLoan
        pnl_edit.Controls.Clear()
        btn_xToken.Enabled = False
        Dim userControl As New Vault_interact
        userControl.Tag = Me.Tag
        userControl.vault = rpc.get_vault(Me.Tag)
        userControl.vaultedit = Me
        userControl.AKtion = x
        Dim loanTokens = rpc.get_listLoanTokens()
        For i = 0 To loanTokens.Count - 1
            userControl.cmb_ticker.Items.Add(Split(loanTokens(i)("fixedIntervalPriceId"), "/")(0))
        Next
        userControl.tlp_loan.Visible = True
        If x = interact.moreLoan Then
            userControl.lbl_icon_add_remove.Text = "+"
            userControl.lbl_icon_add_remove.BackColor = Color.LimeGreen
            userControl.btn_confirm.Text = "mehr Ausleihen"
            userControl.btn_maxAmount.Visible = False
            userControl.lbl_textSaldo.Text = "Wert:"
        ElseIf x = interact.reduceLoan Then
            userControl.lbl_icon_add_remove.Text = "-"
            userControl.lbl_icon_add_remove.BackColor = Color.OrangeRed
            userControl.btn_confirm.Text = "Rückzahlung tätigen"
            userControl.cmb_ticker.Enabled = False
            userControl.lbl_textSaldo.Text = "Saldo:"
            userControl.btn_maxTilgen.Visible = True
        End If
        userControl.Top = pnl_edit.Height - userControl.Height
        userControl.Dock = DockStyle.Bottom
        pnl_edit.Controls.Add(userControl)
        If asset <> "" Then
            userControl.cmb_ticker.SelectedIndex = userControl.cmb_ticker.FindStringExact(asset)
        End If
    End Sub


End Class
