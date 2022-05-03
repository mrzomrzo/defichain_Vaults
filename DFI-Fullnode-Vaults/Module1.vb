Imports System.Net
Imports System.Threading
Imports System.Security.Permissions
Imports Newtonsoft.Json.Linq
Imports System.Globalization

Public Module Module1
    '#
    Public walletaddress As String
    Public rpcUser As String
    Public rpcPW As String
    Public rpcURL As String
    '#

    <SecurityPermission(SecurityAction.Demand, Flags:=SecurityPermissionFlag.ControlAppDomain)>
    Sub Main()
        AddHandler Application.ThreadException, AddressOf ErrHandlerMain
        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException)
        AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf ErrHandlerThreads
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 'für Telegram SSL-Protokoll
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US") 'decimaltrennzeichen zwingend Punkt
        Application.EnableVisualStyles()
        Application.Run(FullNode_Wallet)
    End Sub
    Private Sub ErrHandlerMain(sender As Object, e As ThreadExceptionEventArgs)
        showErrorMessage(e.Exception)
    End Sub
    Private Sub ErrHandlerThreads(sender As Object, e As UnhandledExceptionEventArgs)
        showErrorMessage(CType(e.ExceptionObject, Exception))
    End Sub
    Private Sub showErrorMessage(ex As Exception)
        MsgBox("Laufzeitfehler enstanden:" & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End
    End Sub
    Public Sub save_Settings(form As Form)
        If form.Location.X <> form.Location.Y Then
            My.Settings.Point = form.Location
        End If
        My.Settings.Size = form.Size
        My.Settings.Save()
    End Sub
    Public Sub load_Settings(form As Form)
        If Not My.Settings.Point.IsEmpty Then
            form.Location = My.Settings.Point
            form.Size = My.Settings.Size
        End If
        If IO.File.Exists(Application.StartupPath & "\" & "settings.json") Then
            Dim json = IO.File.ReadAllText(Application.StartupPath & "\" & "settings.json")
            Dim j = JObject.Parse(json)
            rpcUser = j("node_User")
            rpcPW = j("node_Password")
            rpcURL = j("node_URL")
            For i = 1 To 5
                If Not IsNothing(j.SelectToken("address" & i)) And j.SelectToken("address" & i) <> "" Then
                    FullNode_Wallet.cmb_addresses.Items.Add(j.SelectToken("address" & i))
                End If
            Next
            If FullNode_Wallet.cmb_addresses.Items.Count = 0 Then
                MsgBox("Bitte in der Datei settings.json  min. eine Walletaddresse einfügen!", MsgBoxStyle.Critical)
                End
            Else
                FullNode_Wallet.cmb_addresses.SelectedIndex = 0 'erste Wallet adresse als Hauptadresse verwenden
            End If
        Else
            MsgBox("settings.json Datei nicht vorhanden!", MsgBoxStyle.Critical)
            End
        End If
    End Sub

End Module

