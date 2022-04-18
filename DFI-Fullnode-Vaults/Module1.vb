Imports System.Net
Imports System.Threading
Imports System.Security.Permissions
Imports Newtonsoft.Json.Linq

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

End Module

