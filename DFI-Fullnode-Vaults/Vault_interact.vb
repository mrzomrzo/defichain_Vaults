Imports System.Windows
Imports Newtonsoft.Json.Linq
Imports FullNode_Wallet.FullNode_Wallet

Public Class Vault_interact

    Dim rpc As New fullNodeClientDFI
    Public AKtion As interact
    Public vault As JObject
    Public assetPrice As Double
    Public vaultedit As Vault_Bearbeiten

    Public Enum interact
        addCollateral
        removeCollateral
        moreLoan
        reduceLoan
    End Enum


    Private Sub cmb_ticker_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ticker.SelectedIndexChanged
        If cmb_ticker.SelectedIndex <> -1 Then
            txt_amount.Text = 0
            txt_amount.Enabled = True
            lbl_assetName.Text = cmb_ticker.SelectedItem
            assetPrice = rpc.get_oraclePrice(cmb_ticker.SelectedItem)("activePrice")
            If AKtion = interact.addCollateral Or AKtion = interact.reduceLoan Then
                lbl_amountVerfügbar.Text = rpc.get_balance(cmb_ticker.SelectedItem)
                If AKtion = interact.reduceLoan Then
                    For i = 0 To vault("loanAmounts").Count - 1
                        If cmb_ticker.SelectedItem = Split(vault("loanAmounts")(i), "@")(1) Then
                            lbl_Saldo.Text = CDec(Split(vault("loanAmounts")(i), "@")(0))
                        End If
                    Next
                End If
            ElseIf AKtion = interact.removeCollateral Then
                For i = 0 To vault("collateralAmounts").Count - 1
                    If cmb_ticker.SelectedItem = Split(vault("collateralAmounts")(i), "@")(1) Then
                        lbl_amountVerfügbar.Text = CDec(Split(vault("collateralAmounts")(i), "@")(0))
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub btn_maxAmount_Click(sender As Object, e As EventArgs) Handles btn_maxAmount.Click
        txt_amount.Text = CDec(lbl_amountVerfügbar.Text)
    End Sub
    Private Sub btn_maxTilgen_Click(sender As Object, e As EventArgs) Handles btn_maxTilgen.Click
        txt_amount.Text = CDec(lbl_Saldo.Text)
    End Sub

    Private Sub txt_amount_TextChanged(sender As Object, e As EventArgs) Handles txt_amount.TextChanged
        btn_confirm.Enabled = False
        lbl_resultierendeQuote.BackColor = lbl_resultierendeQuote.Parent.BackColor
        lbl_resultierendeQuote.Text = "resultierende Besicherungsquote N/A"
        If IsNumeric(txt_amount.Text) And Not txt_amount.Text.Contains(",") Then
            Dim loanScheme As Integer = Replace(vault("loanSchemeId"), "MIN", "")
            Dim amount As Decimal = txt_amount.Text
            Dim new_collateralRatio As Double = 100000
            Dim new_nextRatio As Double = 100000
            If AKtion = interact.addCollateral Or AKtion = interact.removeCollateral Then
                Dim newCollateralValue As Double = 0
                Dim newNextCollateralValue As Double = 0
                If AKtion = interact.addCollateral Then
                    newCollateralValue = CDbl(vault("collateralValue")) + amount * assetPrice
                    newNextCollateralValue = CDbl(vault("nextcollateralValue")) + amount * assetPrice
                ElseIf AKtion = interact.removeCollateral Then
                    newCollateralValue = CDbl(vault("collateralValue")) - amount * assetPrice
                    newNextCollateralValue = CDbl(vault("nextcollateralValue")) - amount * assetPrice
                End If
                If CDbl(vault("loanValue")) > 0 Then
                    new_collateralRatio = newCollateralValue / CDbl(vault("loanValue")) * 100
                    new_nextRatio = newNextCollateralValue / CDbl(vault("nextloanValue")) * 100
                    lbl_resultierendeQuote.Text = "resultierende collateralRatio: " & Math.Round(new_collateralRatio, 2) & "%" & vbCrLf _
                                                & "resultierende nextRatio: " & Math.Round(new_nextRatio, 2) & "%"
                    If new_nextRatio > loanScheme Then
                        If new_nextRatio < 180 Then
                            lbl_resultierendeQuote.BackColor = Color.Fuchsia
                        End If
                    Else
                        lbl_resultierendeQuote.BackColor = Color.OrangeRed
                    End If
                End If
                If amount > 0 And lbl_amountVerfügbar.Text >= amount And new_collateralRatio > loanScheme And new_nextRatio > loanScheme Then
                    btn_confirm.Enabled = True
                End If
            ElseIf AKtion = interact.moreLoan Or AKtion = interact.reduceLoan Then
                If AKtion = interact.moreLoan Then
                    lbl_Saldo.Text = Math.Round(amount * assetPrice, 2)
                End If
                Dim newLoanValue As Double = 0
                Dim newNextLoanValue As Double = 0
                If AKtion = interact.moreLoan Then
                    newLoanValue = CDbl(vault("loanValue")) + amount * assetPrice
                    newNextLoanValue = CDbl(vault("nextloanValue")) + amount * assetPrice
                ElseIf AKtion = interact.reduceLoan Then
                    newLoanValue = CDbl(vault("loanValue")) - amount * assetPrice
                    newNextLoanValue = CDbl(vault("nextloanValue")) - amount * assetPrice
                End If
                If CDbl(vault("loanValue")) > 0 Then
                    new_collateralRatio = CDbl(vault("collateralValue")) / newLoanValue * 100
                    new_nextRatio = CDbl(vault("nextcollateralValue")) / newNextLoanValue * 100
                    lbl_resultierendeQuote.Text = "resultierende collateralRatio: " & Math.Round(new_collateralRatio, 2) & "%" & vbCrLf _
                                                & "resultierende nextRatio: " & Math.Round(new_nextRatio, 2) & "%"
                    If new_nextRatio > loanScheme Then
                        If new_nextRatio < 180 Then
                            lbl_resultierendeQuote.BackColor = Color.Fuchsia
                        End If
                    Else
                        lbl_resultierendeQuote.BackColor = Color.OrangeRed
                    End If
                End If
                If amount > 0 And new_collateralRatio > loanScheme And new_nextRatio > loanScheme Then
                    If (lbl_amountVerfügbar.Text >= amount And AKtion = interact.reduceLoan) Or AKtion = interact.moreLoan Then
                        btn_confirm.Enabled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        Dim result As Boolean
        If AKtion = interact.addCollateral Then
            result = rpc.deposit_toVault(vault("vaultId"), txt_amount.Text, cmb_ticker.SelectedItem)
        ElseIf AKtion = interact.removeCollateral Then
            result = rpc.withdraw_fromVault(vault("vaultId"), txt_amount.Text, cmb_ticker.SelectedItem)
        ElseIf AKtion = interact.moreLoan Then
            result = rpc.take_Loan(vault("vaultId"), txt_amount.Text, cmb_ticker.SelectedItem)
        ElseIf AKtion = interact.reduceLoan Then
            result = rpc.payback_Loan(vault("vaultId"), txt_amount.Text, cmb_ticker.SelectedItem)
        End If
        If result Then
            FullNode_Wallet.btn_back.PerformClick()
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        vaultedit.pnl_edit.Controls.Clear()
        If AKtion = interact.addCollateral Or AKtion = interact.removeCollateral Then
            FullNode_Wallet.lbl_overview.Text = textSicherheiten
        ElseIf AKtion = interact.moreLoan Or AKtion = interact.reduceLoan Then
            FullNode_Wallet.lbl_overview.Text = textDarlehen
        End If
        vaultedit.btn_xToken.Enabled = True
        FullNode_Wallet.timer_refresh.Interval = 1
    End Sub


End Class
