Imports System.ComponentModel
Imports Newtonsoft.Json.Linq

Public Class FullNode_Wallet

    Dim rpc As New fullNodeClientDFI
    Public vaultEdit As Vault_Bearbeiten
    Private blockHeight As Integer
    Public Const text_Vaults = "deine Vaults"
    Public Const text_Sicherheiten = "Sicherheiten bearbeiten"
    Public Const text_addremoveCollateral = "Sicherheiten hinzufügen/entfernen"
    Public Const text_Darlehen = "Darlehen bearbeiten"
    Public Const text_addremoveLoan = "Kredit ausleihen/rückzahlen"
    Public Const text_FutureSwaps = "pending FutureSwaps"
    Public Const text_addFutureSwap = "FutureSwap hinzufügen"
    Public Const text_Guthaben = "Guthaben"

    Private Sub FullNode_Wallet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_Settings(Me)
        Try
            rpc.get_blockHeight()
            TableLayoutPanel9.RowStyles(TableLayoutPanel9.RowCount - 1).Height = 0
            width_stockCalulator = TableLayoutPanel23.ColumnStyles(TableLayoutPanel23.ColumnCount - 1).Width
            lbl_guthaben.Text = text_Guthaben
            lbl_vaults.Text = text_Vaults
            lbl_futureSwap.Text = text_FutureSwaps
            Me.Text = "Wallet " & TabControl1.SelectedTab.Text
            timer_refresh.Start()
        Catch ex As Exception
            If ex.Message = "Die Verbindung mit dem Remoteserver kann nicht hergestellt werden." Then
                MsgBox("FullNodeWallet nicht online!", MsgBoxStyle.Critical)
            Else
                MsgBox("Login fehlerhaft:" & vbCrLf _
                   & ex.Message, MsgBoxStyle.Critical)
            End If
            End
        End Try
    End Sub

    Private Sub cmb_addresses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_addresses.SelectedIndexChanged
        walletaddress = cmb_addresses.SelectedItem
        pb_lnkDfiIncome.Tag = "https://defichain-income.com/address/" & walletaddress
        timer_refresh.Interval = 1
        If Not rpc.isAddress_Mine(walletaddress) Then
            MsgBox("Die Walletaddresse " & walletaddress & " ist nicht DEINE eigene!" & vbCrLf & "- du kannst keine Transaktionen damit durchführen (onlyView)", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub pb_lnkDfiIncome_Click(sender As Object, e As EventArgs) Handles pb_lnkDfiIncome.Click
        Process.Start(pb_lnkDfiIncome.Tag)
    End Sub

    Private Sub lbl_overview_TextChanged(sender As Object, e As EventArgs) Handles lbl_vaults.TextChanged
        If lbl_vaults.Text = text_Vaults Then
            btn_newVault.Visible = True
            btn_backtoVaults.Visible = False
        Else
            btn_newVault.Visible = False
            btn_backtoVaults.Visible = True
        End If
    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_backtoVaults.Click
        pnl_x.Controls.Clear()
        lbl_vaults.Text = text_Vaults
        timer_refresh.Interval = 1
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        pnl_futureSwaps.Controls.Clear()
        pnl_guthaben.Controls.Clear()
        pnl_x.Controls.Clear()
        btn_backtoVaults.PerformClick()
        lbl_futureSwap.Text = text_FutureSwaps
        TableLayoutPanel23.ColumnStyles(TableLayoutPanel23.ColumnCount - 1).Width = width_stockCalulator
        btn_addFutureSwap.Enabled = True
        Me.Text = "Wallet " & TabControl1.SelectedTab.Text
        timer_refresh.Interval = 1
    End Sub

    Private Sub timer_refresh_Tick(sender As Object, e As EventArgs) Handles timer_refresh.Tick
        Me.Cursor = Cursors.WaitCursor
        Dim info = rpc.get_getblockchaininfo
        If CInt(info("blocks")) + 2 <= CInt(info("headers")) Then
            lbl_notSynced.Text = "FullNode not synced! - Blocks remaining=" & (CInt(info("headers")) - CInt(info("blocks")))
            lbl_notSynced.Visible = True
            timer_refresh.Interval = 60000
        Else
            lbl_notSynced.Visible = False
            Dim currentblock As Integer = rpc.get_blockHeight
            If currentblock <> blockHeight Or timer_refresh.Interval = 1 Then
                timer_refresh.Interval = 10000
                If currentblock <> blockHeight Then
                    blockHeight = currentblock
                    lbl_currentblock.Text = currentblock
                    lbl_currentblock.BackColor = Color.LimeGreen
                    lbl_currentblock.Update()
                    If waitforTransaktion Then
                        If CInt(rpc.get_transaction(lnk_transaction.Tag)("confirmations")) > 0 Then
                            waitforTransaktion = False
                        End If
                    End If
                    Dim remainingBlocksfor_nextPrice = rpc.get_nextPriceBlock - currentblock
                    Dim nextPriceBlcok_inMin = remainingBlocksfor_nextPrice * 0.5
                    lbl_nextPrice.Text = "nextPrice in:" & vbCrLf _
                            & remainingBlocksfor_nextPrice & " Blocks" & vbCrLf _
                            & "≈ " & nextPriceBlcok_inMin & "min"
                    Dim remainingBlocksfor_futureSwap = rpc.get_futureSwapBlock - currentblock
                    Dim futureSwapBlcok_inMin = remainingBlocksfor_futureSwap * 0.5
                    Dim ts As New TimeSpan(0, futureSwapBlcok_inMin, 0)
                    Dim futureswapDate = DateAdd(DateInterval.Minute, ts.TotalMinutes, Now)
                    lbl_nextfutureSwap.Text = "nextFutureSwap in:" & vbCrLf _
                            & remainingBlocksfor_futureSwap & " Blocks" & vbCrLf _
                            & "≈ " & ts.Days & "t-" & ts.Hours & "h-" & ts.Minutes & "min" & vbCrLf _
                            & WeekdayName(Weekday(futureswapDate, FirstDayOfWeek.Monday),, FirstDayOfWeek.Monday) & " " & futureswapDate
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
                    'Guthaben
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
                    If lbl_vaults.Text = text_Vaults Then
                        Dim vaults = rpc.get_listVaults()
                        If vaults.Count <> pnl_x.Controls.Count Then
                            pnl_x.Controls.Clear()
                        End If
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
                            If CDbl(vault("nextRatio")) <= 151 Then
                                newVault.lbl_ratio.BackColor = Color.OrangeRed
                            End If
                            newVault.lbl_ratio.Text = vault("collateralRatio").ToString & "%" & vbCrLf & "next " & vault("nextRatio").ToString & "%"
                            newVault.lbl_collateralValue.Text = "$" & Math.Round(CDbl(vault("collateralValue")), 2)
                            newVault.lbl_loanValue.Text = "$" & Math.Round(CDbl(vault("loanValue")), 2)
                            newVault.lnklbl_vaultID.Tag = "https://defiscan.live/vaults/" & vaultID
                            newVault.lnklbl_vaultID.Text = vaultID
                            If CDbl(vault("collateralValue")) > 0 Then
                                newVault.btn_loan.Enabled = True
                                newVault.btn_closeVault.Enabled = False
                            Else
                                newVault.btn_loan.Enabled = False
                                newVault.btn_closeVault.Enabled = True
                            End If
                            If Not updateVault Then
                                newVault.Top = pnl_x.Controls.Count * (newVault.Height + 2)
                                newVault.Left = 5
                                pnl_x.Controls.Add(newVault)
                            End If
                        Next
                    ElseIf lbl_vaults.Text = text_Sicherheiten Or lbl_vaults.Text = text_Darlehen Then
                        Dim vault = rpc.get_vault(vaultEdit.Tag)
                        vaultEdit.lnklbl_vaultID.Text = vault("vaultId")
                        vaultEdit.lnklbl_vaultID.Tag = "https://defiscan.live/vaults/" & vault("vaultId").ToString
                        vaultEdit.lbl_ratio.Text = vault("collateralRatio").ToString & "%" & vbCrLf & vault("nextRatio").ToString & "%"
                        vaultEdit.lbl_collateralValue.Text = "$" & Math.Round(CDbl(vault("collateralValue")), 2)
                        vaultEdit.lbl_loanValue.Text = "$" & Math.Round(CDbl(vault("loanValue")), 2)
                        vaultEdit.pnl_edit.Controls.Clear()
                        If lbl_vaults.Text = text_Sicherheiten Then
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
                        ElseIf lbl_vaults.Text = text_Darlehen Then
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
                ElseIf TabControl1.SelectedIndex = 2 Then
                    'FutureSwaps
                    If lbl_futureSwap.Text = text_FutureSwaps Then
                        Dim pendingSwaps As New JArray
                        If chk_allFutureswaps.Checked Then
                            pendingSwaps = rpc.get_allPendingFutureSwaps()
                        Else
                            pendingSwaps = rpc.get_myPendingFutureSwaps()
                        End If
                        If pendingSwaps.Count <> pnl_futureSwaps.Controls.Count Then
                            pnl_futureSwaps.Controls.Clear()
                        End If
                        For i = 0 To pendingSwaps.Count - 1
                            Dim newSwap As FutureSwap = Nothing
                            Dim update As Boolean = False
                            For c = 0 To pnl_futureSwaps.Controls.Count - 1
                                If i = c Then
                                    update = True
                                    newSwap = pnl_futureSwaps.Controls(c)
                                End If
                            Next
                            If Not update Then
                                newSwap = New FutureSwap
                            End If
                            If chk_allFutureswaps.Checked Then
                                newSwap.btn_withdrawFutereSwap.Enabled = False
                            End If
                            newSwap.lbl_returnAsset.Text = pendingSwaps(i)("destination")
                            newSwap.lbl_locked.Text = pendingSwaps(i)("source")
                            If My.Settings.FutureSwaps <> "" Then
                                Dim swaps = Split(My.Settings.FutureSwaps, ";")
                                For s = 0 To swaps.Count - 1
                                    Dim source = Split(swaps(s), "#")(0)
                                    Dim destination = Split(swaps(s), "#")(1)
                                    If pendingSwaps(i)("source") = source And pendingSwaps(i)("destination") = destination Then
                                        Dim mintedAmount = Split(swaps(s), "#")(2)
                                        newSwap.lbl_amountMinted.Text = mintedAmount
                                        Exit For
                                    End If
                                Next
                            End If
                            If Not update Then
                                newSwap.Top = pnl_futureSwaps.Controls.Count * (newSwap.Height + 2)
                                newSwap.Left = 5
                                pnl_futureSwaps.Controls.Add(newSwap)
                            End If
                        Next
                        Dim list = rpc.get_listLoanTokens
                        list.RemoveAt(0) 'remove DUSD
                        For i = 0 To list.Count - 1
                            Dim ticker = Split(list(i)("fixedIntervalPriceId"), "/")(0)
                            Dim price = rpc.get_oraclePrice(ticker)
                            Dim pair = rpc.get_poolPair(ticker, "DUSD")
                            Dim activePrice = Math.Round(CDbl(price("activePrice")), 2)
                            Dim nextPrice = Math.Round(CDbl(price("nextPrice")), 2)
                            Dim dexPrice = Math.Round(CDbl(pair("reserveB/reserveA")), 2)
                            Dim diff = Math.Round((1 - (nextPrice / dexPrice)) * 100, 2).ToString("0.00")
                            If i >= lv_stockPremium.Items.Count Then
                                Dim newItem = New ListViewItem({ticker, activePrice, nextPrice, dexPrice, diff})
                                lv_stockPremium.Items.Add(newItem)
                            Else
                                lv_stockPremium.Items(i).SubItems(0).Text = ticker
                                lv_stockPremium.Items(i).SubItems(1).Text = activePrice
                                lv_stockPremium.Items(i).SubItems(2).Text = nextPrice
                                lv_stockPremium.Items(i).SubItems(3).Text = dexPrice
                                lv_stockPremium.Items(i).SubItems(4).Text = diff
                            End If
                            If diff > 0 Then

                            End If
                        Next


                    End If
                End If
            End If
        End If
        Me.Cursor = Cursors.Default
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
        save_Settings(Me)
    End Sub

    Public width_stockCalulator As Integer
    Private Sub btn_addFutureSwap_Click(sender As Object, e As EventArgs) Handles btn_addFutureSwap.Click
        btn_addFutureSwap.Enabled = False
        lbl_futureSwap.Text = text_addFutureSwap
        TableLayoutPanel23.ColumnStyles(TableLayoutPanel23.ColumnCount - 1).Width = 0
        pnl_futureSwaps.Controls.Clear()
        Dim newEl As New FutureSwap_Erstellen
        newEl.Dock = DockStyle.Bottom
        Dim loanTokens = rpc.get_listLoanTokens()
        For i = 0 To loanTokens.Count - 1
            newEl.cmb_lockedAsset.Items.Add(Split(loanTokens(i)("fixedIntervalPriceId"), "/")(0))
            newEl.cmb_returnAsset.Items.Add(Split(loanTokens(i)("fixedIntervalPriceId"), "/")(0))
        Next
        pnl_futureSwaps.Controls.Add(newEl)
    End Sub
    Private Sub chk_allFutureswaps_CheckedChanged(sender As Object, e As EventArgs) Handles chk_allFutureswaps.CheckedChanged
        timer_refresh.Interval = 1
    End Sub


End Class