Public Class FutureSwap

    Dim rpc As New fullNodeClientDFI
    Private Sub btn_withdrawFutereSwap_Click(sender As Object, e As EventArgs) Handles btn_withdrawFutereSwap.Click
        Dim res = MsgBox("Soll der FutureSwap ausgezahlt werden?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question)
        If res = MsgBoxResult.Yes Then
            rpc.withdrawfutureSwap(Split(lbl_locked.Text, "@")(0), Split(lbl_locked.Text, "@")(1), lbl_returnAsset.Text)
        End If
    End Sub

    Private Sub btn_addFutureswapInfo_Click(sender As Object, e As EventArgs) Handles btn_addFutureswapInfo.Click
        Dim res = InputBox("Wie viele """ & lbl_returnAsset.Text & """ hast du gemintet?" & vbCrLf _
                           & "mit dieser Info kann der aktuellen Profit berechnet werden")
        If IsNumeric(res) And Not res.Contains(",") Then
            lbl_amountMinted.Text = CDec(res)
            'lbl_amountMinted.Visible = True
            'Dim oracle = rpc.get_oraclePrice(lbl_returnAsset.Text)
            'Dim price_plus5 As Double = CDbl(oracle("nextPrice")) + CDbl(oracle("nextPrice")) * 0.05
            'Dim amoundDUSD As Double = Split(lbl_locked.Text, "@")(0)
            'Dim theoReturn As Double = amoundDUSD / price_plus5
            'Dim profit_Asset As Double = theoReturn - lbl_amountMinted.Text
            'Dim profit_Dollar As Double = CDbl(oracle("nextPrice")) * profit_Asset
            'Dim profit_Prozent = 100 * theoReturn / lbl_amountMinted.Text - 100
            'If profit_Asset > 0 Then
            '    lbl_profit.BackColor = Color.LawnGreen
            'Else
            '    lbl_profit.BackColor = Color.OrangeRed
            'End If
            'lbl_profit.Text = profit_Asset.ToString("0.000000") & "_" & lbl_returnAsset.Text & " (" & profit_Prozent.ToString("0.00") & "%)" & vbCrLf _
            '            & "≈ " & profit_Dollar.ToString("0.00") & "$"
            'lbl_profit.Visible = True
            'If My.Settings.FutureSwaps <> "" Then
            '    My.Settings.FutureSwaps &= ";"
            'End If
            'My.Settings.FutureSwaps &= lbl_locked.Text & "#" & lbl_returnAsset.Text & "#" & lbl_amountMinted.Text
            'My.Settings.Save()
        ElseIf res <> "" Then
            MsgBox("Nur Zahlen erlaubt!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub lbl_amountMinted_TextChanged(sender As Object, e As EventArgs) Handles lbl_amountMinted.TextChanged
        If lbl_amountMinted.Text > 0 Then
            lbl_amountMinted.Visible = True
            Dim oracle = rpc.get_oraclePrice(lbl_returnAsset.Text)
            Dim price_plus5 As Double = CDbl(oracle("nextPrice")) + CDbl(oracle("nextPrice")) * 0.05
            Dim amoundDUSD As Double = Split(lbl_locked.Text, "@")(0)
            Dim theoReturn As Double = amoundDUSD / price_plus5
            Dim profit_Asset As Double = theoReturn - lbl_amountMinted.Text
            Dim profit_Dollar As Double = CDbl(oracle("nextPrice")) * profit_Asset
            Dim profit_Prozent = 100 * theoReturn / lbl_amountMinted.Text - 100
            If profit_Asset > 0 Then
                lbl_profit.BackColor = Color.LawnGreen
            Else
                lbl_profit.BackColor = Color.OrangeRed
            End If
            lbl_profit.Text = profit_Asset.ToString("0.000000") & "_" & lbl_returnAsset.Text & " (" & profit_Prozent.ToString("0.00") & "%)" & vbCrLf _
                        & "≈ " & profit_Dollar.ToString("0.00") & "$"
            lbl_profit.Visible = True
            Dim newItem As Boolean = True
            If My.Settings.FutureSwaps <> "" Then
                Dim swaps = Split(My.Settings.FutureSwaps, ";")
                For s = 0 To swaps.Count - 1
                    Dim source = Split(swaps(s), "#")(0)
                    Dim destination = Split(swaps(s), "#")(1)
                    If lbl_locked.Text = source And lbl_returnAsset.Text = destination Then
                        My.Settings.FutureSwaps = Replace(My.Settings.FutureSwaps, swaps(s), lbl_locked.Text & "#" & lbl_returnAsset.Text & "#" & lbl_amountMinted.Text)
                        My.Settings.Save()
                        newItem = False
                        Exit For
                    End If
                Next
                If newItem Then
                    My.Settings.FutureSwaps &= ";"
                End If
            End If
            If newItem Then
                My.Settings.FutureSwaps &= lbl_locked.Text & "#" & lbl_returnAsset.Text & "#" & lbl_amountMinted.Text
                My.Settings.Save()
            End If
        End If
    End Sub
End Class
