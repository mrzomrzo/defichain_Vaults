Imports System.ComponentModel
Imports Newtonsoft.Json.Linq

Public Class FullNode_Wallet

    Dim rpc As New fullNodeClientDFI
    Public vaultEdit As Vault_Bearbeiten
    Private blockHeight As Integer
    Public Const textVaults = "Vaults"
    Public Const textSicherheiten = "Sicherheiten bearbeiten"
    Public Const textaddremoveCollateral = "Sicherheiten hinzufügen/entfernen"
    Public Const textDarlehen = "Darlehen bearbeiten"
    Public Const textaddremoveLoan = "Kredit ausleihen/rückzahlen"

    Private Sub FullNode_Wallet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Settings()
        Try
            Dim info = rpc.get_getblockchaininfo
            If CInt(info("blocks")) = CInt(info("headers")) Then
                TableLayoutPanel9.RowStyles(TableLayoutPanel9.RowCount - 1).Height = 0
                lnk_walletDefiIncome.Text = "defiIncome - " & walletaddress
                lnk_walletDefiIncome.Tag = "https://defichain-income.com/address/" & walletaddress
                lbl_overview.Text = textVaults
                timer_refresh.Start()
            Else
                MsgBox("Deine Wallet ist nicht syncronisiert!" & vbCrLf _
                       & (CInt(info("headers")) - CInt(info("blocks"))) & " Blocks verbleibend", MsgBoxStyle.Critical)
                End
            End If
        Catch ex As Exception
            If ex.Message = "Die Verbindung mit dem Remoteserver kann nicht hergestellt werden." Then
                MsgBox("Wallet nicht online!", MsgBoxStyle.Critical)
            Else
                MsgBox("Login fehlerhaft:" & vbCrLf _
                   & vbCrLf _
                   & "prüfe die Einstellungen in der settings.json" & vbCrLf _
                   & "Node_URL Node_User oder Node_PW", MsgBoxStyle.Critical)
            End If
            End
        End Try
    End Sub
    Private Sub lnk_walletDefiIncome_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_walletDefiIncome.LinkClicked
        Process.Start(lnk_walletDefiIncome.Tag)
    End Sub
    Private Sub lbl_overview_TextChanged(sender As Object, e As EventArgs) Handles lbl_overview.TextChanged
        If lbl_overview.Text = textVaults Then
            btn_newVault.Visible = True
            btn_back.Visible = False
        Else
            btn_newVault.Visible = False
            btn_back.Visible = True
        End If
    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        pnl_x.Controls.Clear()
        lbl_overview.Text = textVaults
        timer_refresh.Interval = 1
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        timer_refresh.Interval = 1
    End Sub

    Private Sub timer_refresh_Tick(sender As Object, e As EventArgs) Handles timer_refresh.Tick
        Dim currentblock As Integer = rpc.get_blockHeight
        If currentblock <> blockHeight Or timer_refresh.Interval = 1 Then
            timer_refresh.Interval = 10000
            Me.Cursor = Cursors.WaitCursor
            If currentblock <> blockHeight Then
                blockHeight = currentblock
                lbl_currentblock.Text = currentblock
                lbl_currentblock.BackColor = Color.LimeGreen
                lbl_currentblock.Update()
                Dim remainingBlocksfor_nextPrice = rpc.get_nextPriceBlock - currentblock
                Dim nextPriceBlcok_inMin = remainingBlocksfor_nextPrice * 0.5
                lbl_nextPrice.Text = "nextPrice in:" & vbCrLf _
                        & remainingBlocksfor_nextPrice & " Blocks" & vbCrLf _
                        & "≈ " & nextPriceBlcok_inMin & "min"
                Dim remainingBlocksfor_futureSwap = rpc.get_furureSwapBlock - currentblock
                Dim futureSwapBlcok_inMin = remainingBlocksfor_futureSwap * 0.5
                Dim ts As New TimeSpan(0, futureSwapBlcok_inMin, 0)
                Dim futureswapDate = DateAdd(DateInterval.Minute, ts.TotalMinutes, Now)
                lbl_futureSwap.Text = "nextFutureSwap in:" & vbCrLf _
                        & remainingBlocksfor_futureSwap & " Blocks" & vbCrLf _
                        & "≈ " & ts.Days & "t-" & ts.Hours & "h-" & ts.Minutes & "min" & vbCrLf _
                        & WeekdayName(Weekday(futureswapDate, FirstDayOfWeek.Monday)) & " " & futureswapDate
                Dim t As New Threading.Thread(Sub()
                                                  Threading.Thread.Sleep(2000)
                                                  Try
                                                      Me.Invoke(Sub()
                                                                    lbl_currentblock.BackColor = lbl_currentblock.Parent.BackColor
                                                                End Sub)
                                                  Catch ex As Exception
                                                  End Try
                                              End Sub)
                t.Start()
            End If
            If TabControl1.SelectedIndex = 0 Then
                'Wallet-Guthaben
                Dim guthaben = rpc.get_walletBalance()
                If guthaben.Count <> pnl_guthaben.Controls.Count Then
                    pnl_guthaben.Controls.Clear()
                End If
                For i = 0 To guthaben.Count - 1
                    Dim amount As Decimal = Split(guthaben(i), "@")(0)
                    Dim asset = Split(guthaben(i), "@")(1)
                    Dim newGuthaben As GuthabenAsset = Nothing
                    Dim updateGuthaben As Boolean = False
                    For Each c As GuthabenAsset In pnl_guthaben.Controls
                        If c.lbl_assetName.Text = asset Then
                            updateGuthaben = True
                            newGuthaben = c
                        End If
                    Next
                    If Not updateGuthaben Then
                        newGuthaben = New GuthabenAsset
                    End If
                    newGuthaben.lbl_assetName.Text = asset
                    newGuthaben.lbl_amount.Text = amount
                    If asset.Contains("-") Then
                        'wenn Liqititypool-Guthaben
                        newGuthaben.pb_swap.Visible = False
                    Else
                        Dim price = rpc.get_xPrice(asset)
                        newGuthaben.lbl_wert.Text = "≈ $" & Math.Round(amount * price, 2)
                    End If
                    If Not updateGuthaben Then
                        newGuthaben.Top = pnl_guthaben.Controls.Count * (newGuthaben.Height + 2)
                        newGuthaben.Left = 5
                        pnl_guthaben.Controls.Add(newGuthaben)
                    End If
                Next
            ElseIf TabControl1.SelectedIndex = 1 Then
                'Vaults
                If lbl_overview.Text = textVaults Then
                    Dim vaults = rpc.get_listVaults()
                    For i = 0 To vaults.Count - 1
                        Dim vault = rpc.get_vault(vaults(i)("vaultId"))
                        Dim vaultID = vaults(i)("vaultId").ToString
                        Dim newVault As Vault = Nothing
                        Dim updateVault As Boolean = False
                        For Each c As Vault In pnl_x.Controls
                            If c.Tag = vaultID Then
                                updateVault = True
                                newVault = c
                            End If
                        Next
                        If Not updateVault Then
                            newVault = New Vault
                        End If
                        newVault.Tag = vaultID
                        newVault.lbl_status.Text = vault("state")
                        If vault("state") = "active" Then
                            newVault.lbl_status.BackColor = Color.LawnGreen
                        Else
                            newVault.lbl_status.BackColor = Color.OrangeRed
                        End If
                        newVault.lbl_ratio.Text = vault("collateralRatio").ToString & "%" & vbCrLf & vault("nextRatio").ToString & "%"
                        newVault.lbl_collateralValue.Text = "$" & Math.Round(CDbl(vault("collateralValue")), 2)
                        newVault.lbl_loanValue.Text = "$" & Math.Round(CDbl(vault("loanValue")), 2)
                        newVault.lnklbl_vaultID.Tag = "https://defiscan.live/vaults/" & vaultID
                        newVault.lnklbl_vaultID.Text = vaultID
                        If CDbl(vault("collateralValue")) > 0 Then
                            newVault.btn_loan.Enabled = True
                        Else
                            newVault.btn_loan.Enabled = False
                        End If
                        If Not updateVault Then
                            newVault.Top = pnl_x.Controls.Count * (newVault.Height + 2)
                            newVault.Left = 5
                            pnl_x.Controls.Add(newVault)
                        End If
                    Next
                ElseIf lbl_overview.Text = textSicherheiten Or lbl_overview.Text = textDarlehen Then
                    Dim vault = rpc.get_vault(vaultEdit.Tag)
                    vaultEdit.lnklbl_vaultID.Text = vault("vaultId")
                    vaultEdit.lnklbl_vaultID.Tag = "https://defiscan.live/vaults/" & vault("vaultId").ToString
                    vaultEdit.lbl_ratio.Text = vault("collateralRatio").ToString & "%" & vbCrLf & vault("nextRatio").ToString & "%"
                    vaultEdit.lbl_collateralValue.Text = "$" & Math.Round(CDbl(vault("collateralValue")), 2)
                    vaultEdit.lbl_loanValue.Text = "$" & Math.Round(CDbl(vault("loanValue")), 2)
                    vaultEdit.pnl_edit.Controls.Clear()
                    If lbl_overview.Text = textSicherheiten Then
                        For i = 0 To vault("collateralAmounts").Count - 1
                            Dim amount As Decimal = Split(vault("collateralAmounts")(i), "@")(0)
                            Dim ticker = Split(vault("collateralAmounts")(i), "@")(1)
                            Dim activePrice As Double = rpc.get_oraclePrice(ticker)("activePrice")
                            Dim userContol As New Vault_Sicherheiten
                            userContol.Tag = Me.Tag
                            userContol.sicherheiten = vaultEdit
                            userContol.lbl_tickerName.Text = ticker
                            userContol.lbl_amount.Text = amount & " " & ticker
                            userContol.lbl_wertDollar.Text = "$" & Math.Round(amount * activePrice, 2)
                            userContol.lbl_prozentAnteil.Text = Math.Round(100 * amount * activePrice / CDbl(vault("collateralValue")), 2) & "%"
                            userContol.Top = vaultEdit.pnl_edit.Controls.Count * (userContol.Height + 2)
                            vaultEdit.pnl_edit.Controls.Add(userContol)
                        Next
                    ElseIf lbl_overview.Text = textDarlehen Then
                        For i = 0 To vault("loanAmounts").Count - 1
                            Dim amount As Decimal = Split(vault("loanAmounts")(i), "@")(0)
                            Dim ticker = Split(vault("loanAmounts")(i), "@")(1)
                            Dim activePrice As Double = rpc.get_oraclePrice(ticker)("activePrice")
                            Dim userContol As New Vault_Darlehen
                            userContol.Tag = Me.Tag
                            userContol.darlehen = vaultEdit
                            userContol.lbl_tickerName.Text = ticker
                            userContol.lbl_amount.Text = amount & " " & ticker
                            userContol.lbl_wertDollar.Text = "$" & Math.Round(amount * activePrice, 2)
                            userContol.Top = vaultEdit.pnl_edit.Controls.Count * (userContol.Height + 2)
                            vaultEdit.pnl_edit.Controls.Add(userContol)
                        Next
                    End If
                End If
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btn_newVault_Click(sender As Object, e As EventArgs) Handles btn_newVault.Click
        Dim UTXOs = rpc.get_utxos
        If UTXOs < 2 Then
            MsgBox("nicht genügend UTXOs min 2UTXOs" & vbCrLf & "aktuelle UTXOs: " & UTXOs, MsgBoxStyle.Critical)
        Else
            Dim res = MsgBox("Willst du wirklich ein neuen Vault erstellen?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo)
            If res = MsgBoxResult.Yes Then
                rpc.create_newVault()
            End If
        End If
    End Sub


    Private _StateBool As Boolean = False
    Property waitforTransaktion As Boolean
        Get
            Return _StateBool
        End Get
        Set(value As Boolean)
            If value <> _StateBool Then
                If value Then
                    lbl_currentblock.Text = rpc.get_blockHeight()
                    pgb_statusTransaktion.Visible = True
                    lbl_statusTransaktion.Visible = True
                    lbl_statusTransaktion.Text = "Warten auf Transaktion..."
                    lbl_statusTransaktion.BackColor = Color.Peru
                    lnk_transaction.Visible = False
                    btn_transaktionOK.Visible = False
                Else
                    pgb_statusTransaktion.Visible = False
                    lbl_statusTransaktion.Text = "Transaktion abgeschlossen"
                    lbl_statusTransaktion.BackColor = Color.LimeGreen
                    lnk_transaction.Text = lnk_transaction.Tag
                    lnk_transaction.Visible = True
                    btn_transaktionOK.Visible = True
                End If
                _StateBool = value
            End If
        End Set
    End Property

    Private Sub lbl_currentblock_TextChanged(sender As Object, e As EventArgs) Handles lbl_currentblock.TextChanged
        If waitforTransaktion Then
            waitforTransaktion = False
        End If
    End Sub
    Private Sub lnk_transaction_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_transaction.LinkClicked
        Process.Start("https://defiscan.live/transactions/" & lnk_transaction.Tag)
    End Sub
    Private Sub btn_transaktionOK_Click(sender As Object, e As EventArgs) Handles btn_transaktionOK.Click
        lbl_statusTransaktion.Visible = False
        btn_transaktionOK.Visible = False
        lnk_transaction.Visible = False
    End Sub


#Region "########### Dex-Swap"
    Private Sub btn_dexSwap_Click(sender As Object, e As EventArgs) Handles btn_openSwap.Click
        openDEXswap()
    End Sub
    Public Sub openDEXswap(Optional assetFrom As String = "")
        btn_confirmDEXswap.Enabled = False
        pb_swapToken.Enabled = False
        cmb_fromAsset.Items.Clear()
        cmb_toAsset.Items.Clear()
        Dim tokens = rpc.get_listTokens
        For i = 0 To tokens.Count - 1
            If Not IsNothing(tokens.SelectToken(i)) Then
                If Not tokens.SelectToken(i)("symbol").ToString.Contains("-") And CBool(tokens.SelectToken(i)("isDAT")) = True Then
                    cmb_fromAsset.Items.Add(tokens.SelectToken(i)("symbol").ToString)
                    cmb_toAsset.Items.Add(tokens.SelectToken(i)("symbol").ToString)
                End If
            End If
        Next
        txt_fromAmount.Text = ""
        txt_toAmount.Text = ""
        lbl_guthabenfromAsset.Text = "0.00"
        lbl_guthabentoAsset.Text = "0.00"
        If assetFrom <> "" Then
            cmb_fromAsset.SelectedIndex = cmb_fromAsset.FindStringExact(assetFrom)
        End If
        TableLayoutPanel9.RowStyles(TableLayoutPanel9.RowCount - 1).Height = 120
        MsgBox("it's Beta phase!", MsgBoxStyle.Exclamation, "CompositeSwap")
    End Sub
    Private Sub btn_cancelSwap_Click(sender As Object, e As EventArgs) Handles btn_cancelSwap.Click
        TableLayoutPanel9.RowStyles(TableLayoutPanel9.RowCount - 1).Height = 0
    End Sub
    Private Sub pb_swapToken_Click(sender As Object, e As EventArgs) Handles pb_swapToken.Click
        Dim savefromToken = cmb_fromAsset.SelectedItem.ToString
        Dim savetoToken = cmb_toAsset.SelectedItem.ToString
        Dim fromItems = cmb_fromAsset.Items.Cast(Of String).ToArray()
        Dim toItems = cmb_toAsset.Items.Cast(Of String).ToArray()
        Dim guthabenA = lbl_guthabenfromAsset.Text
        Dim guthabenB = lbl_guthabentoAsset.Text
        lbl_guthabenfromAsset.Text = guthabenB
        lbl_guthabentoAsset.Text = guthabenA
        cmb_fromAsset.Items.Clear()
        cmb_toAsset.Items.Clear()
        cmb_fromAsset.Items.AddRange(toItems)
        cmb_toAsset.Items.AddRange(fromItems)
        cmb_fromAsset.SelectedIndex = cmb_toAsset.FindStringExact(savetoToken)
        cmb_toAsset.SelectedIndex = cmb_fromAsset.FindStringExact(savefromToken)
        txt_fromAmount.Text = ""
        txt_toAmount.Text = ""
    End Sub

    Private Sub btn_maxAmount_Click(sender As Object, e As EventArgs) Handles btn_maxAmount.Click
        txt_fromAmount.Text = CDec(lbl_guthabenfromAsset.Text)
    End Sub

    Private Sub cmb_fromAsset_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_fromAsset.SelectedIndexChanged
        If cmb_fromAsset.SelectedIndex <> -1 And cmb_toAsset.SelectedIndex <> -1 Then
            pb_swapToken.Enabled = True
        Else
            pb_swapToken.Enabled = False
        End If
        txt_fromAmount.Text = ""
        txt_toAmount.Text = ""
        lbl_guthabenfromAsset.Text = rpc.get_balance(cmb_fromAsset.SelectedItem)
    End Sub

    Private Sub cmb_toAsset_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_toAsset.SelectedIndexChanged
        If cmb_fromAsset.SelectedIndex <> -1 And cmb_toAsset.SelectedIndex <> -1 Then
            pb_swapToken.Enabled = True
        Else
            pb_swapToken.Enabled = False
        End If
        txt_fromAmount.Text = ""
        txt_toAmount.Text = ""
        lbl_guthabentoAsset.Text = rpc.get_balance(cmb_toAsset.SelectedItem)
    End Sub

    Private Sub txt_fromAmount_TextChanged(sender As Object, e As EventArgs) Handles txt_fromAmount.TextChanged
        txt_toAmount.Text = 0
        btn_confirmDEXswap.Enabled = False
        If IsNumeric(txt_fromAmount.Text) And Not txt_fromAmount.Text.Contains(",") Then
            If txt_fromAmount.Text <= lbl_guthabenfromAsset.Text Then
                If cmb_fromAsset.SelectedIndex <> -1 And cmb_toAsset.SelectedIndex <> -1 Then
                    txt_toAmount.Text = Math.Round(getamount_TokenB(txt_fromAmount.Text, cmb_fromAsset.SelectedItem, cmb_toAsset.SelectedItem), 8)
                    btn_confirmDEXswap.Enabled = True
                End If
            End If
        End If
    End Sub
    Private Function getamount_TokenB(amountFromToken As Decimal, fromToken As String, toToken As String) As Decimal
        Dim tokenA = rpc.get_getToken(fromToken)
        Dim tokenB = rpc.get_getToken(toToken)
        If CBool(tokenA("isLoanToken")) And CBool(tokenB("isLoanToken")) Then
            If tokenA("symbol") = "DUSD" Or tokenB("symbol") = "DUSD" Then
                If tokenA("symbol") = "DUSD" Then
                    Dim pair = rpc.get_poolPair(tokenB("symbol").ToString, tokenA("symbol").ToString)
                    Dim dexPrice As Decimal = pair("reserveB/reserveA")
                    Return amountFromToken / dexPrice
                Else
                    Dim pair = rpc.get_poolPair(tokenA("symbol").ToString, tokenB("symbol").ToString)
                    Dim dexPrice As Decimal = pair("reserveB/reserveA")
                    Return amountFromToken * dexPrice
                End If
            Else
                Dim pairA = rpc.get_poolPair(tokenA("symbol").ToString, "DUSD")
                Dim dexPriceA As Decimal = pairA("reserveB/reserveA")
                Dim amountDUSD = amountFromToken * dexPriceA
                Dim pairB = rpc.get_poolPair(tokenB("symbol").ToString, "DUSD")
                Dim dexPriceB As Decimal = pairB("reserveB/reserveA")
                Return amountDUSD / dexPriceB
            End If
        Else
            If (CBool(tokenA("isLoanToken")) And Not tokenA("symbol") = "DUSD") Or
               (CBool(tokenB("isLoanToken")) And Not tokenB("symbol") = "DUSD") Then
                If tokenA("symbol") = "DFI" Or tokenB("symbol") = "DFI" Then
                    If CBool(tokenA("isLoanToken")) Then
                        Dim pair2 = rpc.get_poolPair(tokenA("symbol").ToString, "DUSD")
                        Dim dexPrice As Decimal = pair2("reserveB/reserveA")
                        Dim amountDUSD = amountFromToken * dexPrice
                        Dim pair = rpc.get_poolPair("DUSD", "DFI")
                        Dim dexPriceDFI As Decimal = pair("reserveA/reserveB")
                        Return amountDUSD / dexPriceDFI
                    Else
                        Dim pair = rpc.get_poolPair("DUSD", "DFI")
                        Dim dexPriceDFI As Decimal = pair("reserveA/reserveB")
                        Dim amountDUSD = amountFromToken * dexPriceDFI
                        Dim pair2 = rpc.get_poolPair(tokenB("symbol").ToString, "DUSD")
                        Dim dexPrice As Decimal = pair2("reserveB/reserveA")
                        Return amountDUSD / dexPrice
                    End If
                Else
                    Dim pair = rpc.get_poolPair(tokenA("symbol").ToString, "DUSD")
                    Dim dexPrice As Decimal = pair("reserveB/reserveA")
                    Dim amountDUSD = amountFromToken * dexPrice
                    Dim pair2 = rpc.get_poolPair("DUSD", "DFI")
                    Dim dexPriceDFI As Decimal = pair2("reserveA/reserveB")
                    Dim DFI = amountDUSD / dexPriceDFI
                    If CBool(tokenA("isLoanToken")) Then
                        If tokenB("symbol") = "DFI" Then
                            Return amountDUSD / DFI
                        Else
                            Dim pair3 = rpc.get_poolPair(tokenB("symbol").ToString, "DFI")
                            Dim dexPriceX As Decimal = pair3("reserveA/reserveB")
                            Return DFI * dexPriceX
                        End If
                    Else
                        If tokenA("symbol") = "DFI" Then
                            Return amountDUSD / DFI
                        Else
                            Dim pair3 = rpc.get_poolPair(tokenA("symbol").ToString, "DFI")
                            Dim dexPriceX As Decimal = pair3("reserveA/reserveB")
                            Return DFI * dexPriceX
                        End If
                    End If
                End If
            Else
                If tokenA("symbol") = "DFI" Then
                    Dim pair = rpc.get_poolPair(tokenB("symbol").ToString, tokenA("symbol").ToString)
                    Dim dexPrice As Decimal = pair("reserveA/reserveB")
                    Return amountFromToken * dexPrice
                Else
                    Dim pair = rpc.get_poolPair(tokenA("symbol").ToString, tokenB("symbol").ToString)
                    Dim dexPrice As Decimal = pair("reserveA/reserveB")
                    Return amountFromToken / dexPrice
                End If
            End If
        End If
    End Function

    Private Sub btn_tauschDEX_Click(sender As Object, e As EventArgs) Handles btn_confirmDEXswap.Click
        If rpc.compositeSwap(cmb_fromAsset.SelectedItem, txt_fromAmount.Text, cmb_toAsset.SelectedItem) Then
            btn_cancelSwap.PerformClick()
        End If
    End Sub
#End Region



    Private Sub FullNode_Wallet_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        save_mySettings()
    End Sub
    Private Sub save_mySettings()
        My.Settings.Point = Me.Location
        My.Settings.Size = Me.Size
        My.Settings.Save()
    End Sub
    Private Sub load_Settings()
        If Not My.Settings.Point.IsEmpty Then
            Me.Location = My.Settings.Point
            Me.Size = My.Settings.Size
        End If
        If IO.File.Exists(Application.StartupPath & "\" & "settings.json") Then
            Dim json = IO.File.ReadAllText(Application.StartupPath & "\" & "settings.json")
            walletaddress = JObject.Parse(json)("address")
            rpcUser = JObject.Parse(json)("node_User")
            rpcPW = JObject.Parse(json)("node_Password")
            rpcURL = JObject.Parse(json)("node_URL")
        Else
            MsgBox("settings.json Datei nicht vorhanden!", MsgBoxStyle.Critical)
            End
        End If
    End Sub

End Class