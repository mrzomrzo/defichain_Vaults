Imports System.Net
Imports System.Threading
Imports Newtonsoft.Json.Linq
Imports FullNode_Wallet

Public Class fullNodeClientDFI

    Private Function rpc(method As String, Optional params As String = Nothing) As JObject
        Dim json =
        "{
        ""jsonrpc"": ""2.0"",
        ""id"": ""meBe"",
        ""method"": """ & method & """,
        ""params"": [" & params & "]
        }"
        Dim postBytes = System.Text.Encoding.UTF8.GetBytes(json)
        Dim webRequest = Net.WebRequest.Create(rpcURL)
        webRequest.Credentials = New NetworkCredential(rpcUser, rpcPW)
        webRequest.ContentType = "application/json"
        webRequest.Method = "POST"
        Dim requestStream = webRequest.GetRequestStream()
        requestStream.Write(postBytes, 0, postBytes.Length)
        requestStream.Close()
        Dim response As HttpWebResponse
        Try
            response = CType(webRequest.GetResponse, HttpWebResponse)
        Catch ex As WebException
            response = ex.Response
        End Try
        Dim jsonresult = New IO.StreamReader(response.GetResponseStream).ReadToEnd
        Dim jO = JObject.Parse(jsonresult)
        If response.StatusCode >= 300 Then
            If CInt(jO("error")("code")) = -25 Then
                If Not FullNode_Wallet.waitforTransaktion Then
                    Dim pw = InputBox("Passwort eingeben...", "Transaktion freigeben")
                    If rpc("walletpassphrase", """" & pw & """, 5")("error").ToString = "" Then
                        Return rpc(method, params)
                    End If
                End If
            Else
                MsgBox("rpc-Fehler Message: " & vbCrLf & jO("error")("message").ToString, MsgBoxStyle.Critical)
            End If
        End If
        Return jO
    End Function
    Public Function get_blockHeight() As Integer
        Return rpc("getblockcount")("result")
    End Function
    Public Function get_furureSwapBlock() As Integer
        Return rpc("getfutureswapblock")("result")
    End Function
    Public Function get_nextPriceBlock() As Integer
        Return rpc("getloaninfo")("result")("nextPriceBlock")
    End Function
    Public Function get_poolPair(assetA As String, assetB As String) As JObject
        Return rpc("getpoolpair", """" & assetA & "-" & assetB & """")("result").First.First
    End Function
    Public Function get_getToken(tokenName As String) As JObject
        Return rpc("gettoken", """" & tokenName & """")("result").First.First
    End Function
    Public Function get_listTokens() As JObject
        Return rpc("listtokens")("result")
    End Function
    Public Function get_listVaults() As JArray
        Return rpc("listvaults", "{""ownerAddress"" : """ & walletaddress & """}")("result")
    End Function
    Public Function get_listCollateralTokens() As JArray
        Return rpc("listcollateraltokens")("result")
    End Function
    Public Function get_listLoanTokens() As JArray
        Return rpc("listloantokens")("result")
    End Function
    Public Function get_vault(vaultID As String) As JObject
        Dim vault = CType(rpc("getvault", """" & vaultID & """")("result"), JObject)
        For i = 1 To 2
            If i = 1 Then
                Dim nextValue As Decimal = 0
                For a = 0 To vault("collateralAmounts").Count - 1
                    Dim assetprice = get_oraclePrice(Split(vault("collateralAmounts")(a), "@")(1))
                    nextValue += CDbl(Split(vault("collateralAmounts")(a), "@")(0)) * CDbl(assetprice("nextPrice"))
                Next
                vault.Add("nextcollateralValue", nextValue)
            ElseIf i = 2 Then
                Dim nextValue As Decimal = 0
                For a = 0 To vault("loanAmounts").Count - 1
                    Dim assetprice = get_oraclePrice(Split(vault("loanAmounts")(a), "@")(1))
                    nextValue += CDbl(Split(vault("loanAmounts")(a), "@")(0)) * CDbl(assetprice("nextPrice"))
                Next
                vault.Add("nextloanValue", nextValue)
            End If
        Next
        vault.Add("nextRatio", Math.Round(CDbl(vault("nextcollateralValue")) / CDbl(vault("nextloanValue")) * 100, 2))
        Return vault
    End Function
    Public Function get_oraclePrice(asset As String) As JObject
        Return rpc("getfixedintervalprice", """" & asset & "/USD""")("result")
    End Function
    Public Function get_utxos() As Decimal
        Return rpc("getbalances")("result")("mine")("trusted")
    End Function
    Public Function get_walletBalance() As JArray
        Return rpc("getaccount", """" & walletaddress & """")("result")
    End Function
    Public Function get_balance(asset As String) As Decimal
        Dim tokenBalances = get_walletBalance()
        For i = 0 To tokenBalances.Count - 1
            If asset = Split(tokenBalances(i), "@")(1) Then
                Return Split(tokenBalances(i), "@")(0)
            End If
        Next
        Return 0
    End Function


    '#####################################################################################
    '#######    AKTIONEN MIT BESÄTIGUNG MIT WALLET-PASSWORD   ############################
    '#####################################################################################
    Public Function compositeSwap(fromToken As String, amount As Decimal, toToken As String) As Boolean
        Dim hash = rpc("compositeswap", "{""from"":""" & walletaddress & """,""tokenFrom"":""" & fromToken & """,""amountFrom"":" & amount & ",""To"":""" & walletaddress & """,""tokenTo"":""" & toToken & """}")("result")
        If hash.ToString.Length = 64 Then
            FullNode_Wallet.waitforTransaktion = True
            FullNode_Wallet.lbl_statusTransaktion.Tag = "https://defiscan.live/transactions/" & hash.ToString
            Return True
        End If
        Return False
    End Function
    Public Function create_newVault() As Boolean
        Dim hash = rpc("createvault", """" & walletaddress & """ , ""MIN150""")("result")
        If hash.ToString.Length = 64 Then
            FullNode_Wallet.waitforTransaktion = True
            FullNode_Wallet.lbl_statusTransaktion.Tag = "https://defiscan.live/transactions/" & hash.ToString
            Return True
        End If
        Return False
    End Function
    Public Function deposit_toVault(vaultID As String, amount As Decimal, asset As String) As Boolean
        Dim hash = rpc("deposittovault", """" & vaultID & """,""" & walletaddress & """,""" & amount & "@" & asset & """")("result")
        If hash.ToString.Length = 64 Then
            FullNode_Wallet.waitforTransaktion = True
            FullNode_Wallet.lbl_statusTransaktion.Tag = "https://defiscan.live/transactions/" & hash.ToString
            Return True
        End If
        Return False
    End Function
    Public Function withdraw_fromVault(vaultID As String, amount As Decimal, asset As String) As Boolean
        Dim hash = rpc("withdrawfromvault", """" & vaultID & """,""" & walletaddress & """,""" & amount & "@" & asset & """")("result")
        If hash.ToString.Length = 64 Then
            FullNode_Wallet.waitforTransaktion = True
            FullNode_Wallet.lbl_statusTransaktion.Tag = "https://defiscan.live/transactions/" & hash.ToString
            Return True
        End If
        Return False
    End Function
    Public Function payback_Loan(vaultID As String, amount As Decimal, asset As String) As Boolean
        Dim hash = rpc("paybackloan", "{""vaultId"":""" & vaultID & """,""from"":""" & walletaddress & """,""amounts"":""" & amount & "@" & asset & """}")("result")
        If hash.ToString.Length = 64 Then
            FullNode_Wallet.waitforTransaktion = True
            FullNode_Wallet.lbl_statusTransaktion.Tag = "https://defiscan.live/transactions/" & hash.ToString
            Return True
        End If
        Return False
    End Function
    Public Function take_Loan(vaultID As String, amount As Decimal, asset As String) As Boolean
        Dim hash = rpc("takeloan", "{""vaultId"":""" & vaultID & """,""to"":""" & walletaddress & """,""amounts"":""" & amount & "@" & asset & """}")("result")
        If hash.ToString.Length = 64 Then
            FullNode_Wallet.waitforTransaktion = True
            FullNode_Wallet.lbl_statusTransaktion.Tag = "https://defiscan.live/transactions/" & hash.ToString
            Return True
        End If
        Return False
    End Function
    '#####################################################################################


End Class
