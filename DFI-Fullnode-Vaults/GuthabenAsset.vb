Public Class GuthabenAsset

    Private Sub pb_swap_Click(sender As Object, e As EventArgs) Handles pb_swap.Click
        FullNode_Wallet.openDEXswap(lbl_assetName.Text)
    End Sub

End Class
