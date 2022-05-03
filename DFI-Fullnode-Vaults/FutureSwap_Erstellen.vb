Public Class FutureSwap_Erstellen

    Dim rpc As New fullNodeClientDFI
    Private Sub btn_createFutureSwap_Click(sender As Object, e As EventArgs) Handles btn_createFutureSwap.Click
        If rpc.setfutureSwap(txt_lockedAmount.Text, cmb_lockedAsset.SelectedItem, cmb_returnAsset.SelectedItem) Then
            closeMe()
        End If
    End Sub
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        closeMe()
    End Sub
    Private Sub closeMe()
        FullNode_Wallet.pnl_futureSwaps.Controls.Clear()
        FullNode_Wallet.lbl_futureSwap.Text = FullNode_Wallet.text_FutureSwaps
        FullNode_Wallet.TableLayoutPanel23.ColumnStyles(FullNode_Wallet.TableLayoutPanel23.ColumnCount - 1).Width = FullNode_Wallet.width_stockCalulator
        FullNode_Wallet.btn_addFutureSwap.Enabled = True
        FullNode_Wallet.timer_refresh.Interval = 1
    End Sub

    Private Sub btn_maxAmount_Click(sender As Object, e As EventArgs) Handles btn_maxAmount.Click
        txt_lockedAmount.Text = CDec(lbl_assetGuthaben.Text)
    End Sub
    Private Sub cmb_lockedAsset_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_lockedAsset.SelectedIndexChanged
        If cmb_lockedAsset.SelectedIndex = 0 Then 'wenn select DUSD
            cmb_returnAsset.Enabled = True
            cmb_returnAsset.SelectedIndex = -1
        Else
            cmb_returnAsset.SelectedIndex = 0
            cmb_returnAsset.Enabled = False
        End If
        txt_lockedAmount.Text = ""
        lbl_assetGuthaben.Text = rpc.get_balance(cmb_lockedAsset.SelectedItem).ToString("0.00000000")
        checkValide()
    End Sub
    Private Sub cmb_returnAsset_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_returnAsset.SelectedIndexChanged
        checkValide()
    End Sub
    Private Sub txt_lockedAmount_TextChanged(sender As Object, e As EventArgs) Handles txt_lockedAmount.TextChanged
        checkValide()
    End Sub
    Private Sub checkValide()
        btn_createFutureSwap.Enabled = False
        If cmb_lockedAsset.SelectedIndex <> -1 And cmb_returnAsset.SelectedIndex <> -1 Then
            If IsNumeric(txt_lockedAmount.Text) And Not txt_lockedAmount.Text.Contains(",") Then
                If txt_lockedAmount.Text <= lbl_assetGuthaben.Text And txt_lockedAmount.Text > 0 Then
                    If (cmb_lockedAsset.SelectedIndex = 0 And cmb_returnAsset.SelectedIndex <> 0) Or
                       (cmb_returnAsset.SelectedIndex = 0 And cmb_lockedAsset.SelectedIndex <> 0) Then
                        btn_createFutureSwap.Enabled = True
                    End If
                End If
            End If
        End If
    End Sub


End Class
