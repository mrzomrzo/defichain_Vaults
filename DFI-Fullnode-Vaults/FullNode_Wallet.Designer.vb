<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FullNode_Wallet
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FullNode_Wallet))
        Me.timer_refresh = New System.Windows.Forms.Timer(Me.components)
        Me.pnl_x = New System.Windows.Forms.Panel()
        Me.btn_newVault = New System.Windows.Forms.Button()
        Me.lbl_currentblock = New System.Windows.Forms.Label()
        Me.lbl_nextPrice = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_overview = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_futureSwap = New System.Windows.Forms.Label()
        Me.TableLayoutPanel18 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_statusTransaktion = New System.Windows.Forms.Label()
        Me.btn_transaktionOK = New System.Windows.Forms.Button()
        Me.pgb_statusTransaktion = New System.Windows.Forms.ProgressBar()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_openSwap = New System.Windows.Forms.Button()
        Me.pnl_guthaben = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel16 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel13 = New System.Windows.Forms.TableLayoutPanel()
        Me.pb_swapToken = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel14 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_guthabentoAsset = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_toAmount = New System.Windows.Forms.TextBox()
        Me.cmb_toAsset = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_maxAmount = New System.Windows.Forms.Button()
        Me.cmb_fromAsset = New System.Windows.Forms.ComboBox()
        Me.txt_fromAmount = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_guthabenfromAsset = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel15 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_cancelSwap = New System.Windows.Forms.Button()
        Me.TableLayoutPanel17 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_confirmDEXswap = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lnk_walletDefiIncome = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel18.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel16.SuspendLayout()
        Me.TableLayoutPanel13.SuspendLayout()
        CType(Me.pb_swapToken, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel12.SuspendLayout()
        Me.TableLayoutPanel14.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.TableLayoutPanel15.SuspendLayout()
        Me.TableLayoutPanel17.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'timer_refresh
        '
        '
        'pnl_x
        '
        Me.pnl_x.AutoScroll = True
        Me.pnl_x.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_x.Location = New System.Drawing.Point(4, 67)
        Me.pnl_x.Name = "pnl_x"
        Me.pnl_x.Size = New System.Drawing.Size(1434, 1168)
        Me.pnl_x.TabIndex = 1
        '
        'btn_newVault
        '
        Me.btn_newVault.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_newVault.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_newVault.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_newVault.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_newVault.Location = New System.Drawing.Point(1208, 6)
        Me.btn_newVault.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_newVault.Name = "btn_newVault"
        Me.btn_newVault.Size = New System.Drawing.Size(220, 44)
        Me.btn_newVault.TabIndex = 2
        Me.btn_newVault.Text = "newVault"
        Me.btn_newVault.UseVisualStyleBackColor = False
        '
        'lbl_currentblock
        '
        Me.lbl_currentblock.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_currentblock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_currentblock.Location = New System.Drawing.Point(179, 0)
        Me.lbl_currentblock.Name = "lbl_currentblock"
        Me.lbl_currentblock.Size = New System.Drawing.Size(152, 37)
        Me.lbl_currentblock.TabIndex = 3
        Me.lbl_currentblock.Text = "00000000"
        Me.lbl_currentblock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_nextPrice
        '
        Me.lbl_nextPrice.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_nextPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nextPrice.Location = New System.Drawing.Point(4, 116)
        Me.lbl_nextPrice.Name = "lbl_nextPrice"
        Me.lbl_nextPrice.Size = New System.Drawing.Size(334, 142)
        Me.lbl_nextPrice.TabIndex = 4
        Me.lbl_nextPrice.Text = "nextPrice in:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0 Blocks" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "≈ 0min"
        Me.lbl_nextPrice.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnl_x, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1442, 1239)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 232.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_overview, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_newVault, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_back, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1434, 56)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'lbl_overview
        '
        Me.lbl_overview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_overview.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_overview.Location = New System.Drawing.Point(59, 0)
        Me.lbl_overview.Name = "lbl_overview"
        Me.lbl_overview.Size = New System.Drawing.Size(1140, 56)
        Me.lbl_overview.TabIndex = 0
        Me.lbl_overview.Text = "overView-Text"
        Me.lbl_overview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_back
        '
        Me.btn_back.BackgroundImage = CType(resources.GetObject("btn_back.BackgroundImage"), System.Drawing.Image)
        Me.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_back.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_back.Location = New System.Drawing.Point(3, 3)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(50, 50)
        Me.btn_back.TabIndex = 3
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 1, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1874, 1429)
        Me.TableLayoutPanel3.TabIndex = 7
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 348.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel7, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(23, 23)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1828, 1383)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.lbl_futureSwap, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel18, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.lbl_nextPrice, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.pgb_statusTransaktion, 0, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(1483, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 5
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(342, 1377)
        Me.TableLayoutPanel5.TabIndex = 7
        '
        'lbl_futureSwap
        '
        Me.lbl_futureSwap.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_futureSwap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_futureSwap.Location = New System.Drawing.Point(4, 267)
        Me.lbl_futureSwap.Name = "lbl_futureSwap"
        Me.lbl_futureSwap.Size = New System.Drawing.Size(334, 183)
        Me.lbl_futureSwap.TabIndex = 8
        Me.lbl_futureSwap.Text = "nextFutureSwap in:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0 Blocks " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "≈ 0t-0h-0min"
        Me.lbl_futureSwap.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TableLayoutPanel18
        '
        Me.TableLayoutPanel18.ColumnCount = 2
        Me.TableLayoutPanel18.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 246.0!))
        Me.TableLayoutPanel18.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel18.Controls.Add(Me.lbl_statusTransaktion, 0, 0)
        Me.TableLayoutPanel18.Controls.Add(Me.btn_transaktionOK, 1, 0)
        Me.TableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel18.Location = New System.Drawing.Point(4, 1258)
        Me.TableLayoutPanel18.Name = "TableLayoutPanel18"
        Me.TableLayoutPanel18.RowCount = 1
        Me.TableLayoutPanel18.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel18.Size = New System.Drawing.Size(334, 82)
        Me.TableLayoutPanel18.TabIndex = 4
        '
        'lbl_statusTransaktion
        '
        Me.lbl_statusTransaktion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_statusTransaktion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_statusTransaktion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_statusTransaktion.Location = New System.Drawing.Point(3, 0)
        Me.lbl_statusTransaktion.Name = "lbl_statusTransaktion"
        Me.lbl_statusTransaktion.Size = New System.Drawing.Size(240, 82)
        Me.lbl_statusTransaktion.TabIndex = 12
        Me.lbl_statusTransaktion.Text = "Status Transaktion"
        Me.lbl_statusTransaktion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_statusTransaktion.Visible = False
        '
        'btn_transaktionOK
        '
        Me.btn_transaktionOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_transaktionOK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_transaktionOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_transaktionOK.Location = New System.Drawing.Point(249, 3)
        Me.btn_transaktionOK.Name = "btn_transaktionOK"
        Me.btn_transaktionOK.Size = New System.Drawing.Size(82, 76)
        Me.btn_transaktionOK.TabIndex = 13
        Me.btn_transaktionOK.Text = "OK"
        Me.btn_transaktionOK.UseVisualStyleBackColor = True
        Me.btn_transaktionOK.Visible = False
        '
        'pgb_statusTransaktion
        '
        Me.pgb_statusTransaktion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pgb_statusTransaktion.Location = New System.Drawing.Point(4, 1347)
        Me.pgb_statusTransaktion.Name = "pgb_statusTransaktion"
        Me.pgb_statusTransaktion.Size = New System.Drawing.Size(334, 26)
        Me.pgb_statusTransaktion.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pgb_statusTransaktion.TabIndex = 9
        Me.pgb_statusTransaktion.Visible = False
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.lbl_currentblock, 1, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(334, 108)
        Me.TableLayoutPanel6.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "BlockHöhe:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.TabControl1, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.lnk_walletDefiIncome, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(1474, 1377)
        Me.TableLayoutPanel7.TabIndex = 10
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(5, 71)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1464, 1301)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel9)
        Me.TabPage1.Location = New System.Drawing.Point(8, 48)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1448, 1245)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "-Guthaben"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel9.ColumnCount = 1
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.TableLayoutPanel8, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.pnl_guthaben, 0, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.TableLayoutPanel16, 0, 2)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 3
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 226.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(1442, 1239)
        Me.TableLayoutPanel9.TabIndex = 1
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 502.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.btn_openSwap, 1, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(1434, 60)
        Me.TableLayoutPanel8.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(926, 60)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Wallet - Guthaben"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_openSwap
        '
        Me.btn_openSwap.BackgroundImage = CType(resources.GetObject("btn_openSwap.BackgroundImage"), System.Drawing.Image)
        Me.btn_openSwap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_openSwap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_openSwap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_openSwap.Font = New System.Drawing.Font("Rockwell", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_openSwap.Location = New System.Drawing.Point(935, 3)
        Me.btn_openSwap.Name = "btn_openSwap"
        Me.btn_openSwap.Size = New System.Drawing.Size(496, 54)
        Me.btn_openSwap.TabIndex = 2
        Me.btn_openSwap.Text = "DEX - Tausch"
        Me.btn_openSwap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_openSwap.UseVisualStyleBackColor = False
        '
        'pnl_guthaben
        '
        Me.pnl_guthaben.AutoScroll = True
        Me.pnl_guthaben.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_guthaben.Location = New System.Drawing.Point(4, 71)
        Me.pnl_guthaben.Name = "pnl_guthaben"
        Me.pnl_guthaben.Size = New System.Drawing.Size(1434, 937)
        Me.pnl_guthaben.TabIndex = 1
        '
        'TableLayoutPanel16
        '
        Me.TableLayoutPanel16.ColumnCount = 1
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel16.Controls.Add(Me.TableLayoutPanel13, 0, 0)
        Me.TableLayoutPanel16.Controls.Add(Me.TableLayoutPanel17, 0, 1)
        Me.TableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel16.Location = New System.Drawing.Point(4, 1015)
        Me.TableLayoutPanel16.Name = "TableLayoutPanel16"
        Me.TableLayoutPanel16.RowCount = 2
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155.0!))
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel16.Size = New System.Drawing.Size(1434, 220)
        Me.TableLayoutPanel16.TabIndex = 2
        '
        'TableLayoutPanel13
        '
        Me.TableLayoutPanel13.ColumnCount = 5
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600.0!))
        Me.TableLayoutPanel13.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel13.Controls.Add(Me.pb_swapToken, 2, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.GroupBox1, 3, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.GroupBox2, 1, 0)
        Me.TableLayoutPanel13.Controls.Add(Me.TableLayoutPanel15, 4, 0)
        Me.TableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 1
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(1428, 149)
        Me.TableLayoutPanel13.TabIndex = 18
        '
        'pb_swapToken
        '
        Me.pb_swapToken.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_swapToken.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pb_swapToken.Image = CType(resources.GetObject("pb_swapToken.Image"), System.Drawing.Image)
        Me.pb_swapToken.Location = New System.Drawing.Point(687, 3)
        Me.pb_swapToken.Name = "pb_swapToken"
        Me.pb_swapToken.Size = New System.Drawing.Size(54, 143)
        Me.pb_swapToken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_swapToken.TabIndex = 0
        Me.pb_swapToken.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel12)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(747, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(594, 143)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "to"
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel12.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel12.ColumnCount = 2
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 366.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel12.Controls.Add(Me.TableLayoutPanel14, 0, 1)
        Me.TableLayoutPanel12.Controls.Add(Me.txt_toAmount, 0, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.cmb_toAsset, 1, 0)
        Me.TableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(3, 36)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 2
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(588, 104)
        Me.TableLayoutPanel12.TabIndex = 16
        '
        'TableLayoutPanel14
        '
        Me.TableLayoutPanel14.ColumnCount = 2
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168.0!))
        Me.TableLayoutPanel14.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel14.Controls.Add(Me.lbl_guthabentoAsset, 1, 0)
        Me.TableLayoutPanel14.Controls.Add(Me.Label10, 0, 0)
        Me.TableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel14.Location = New System.Drawing.Point(4, 59)
        Me.TableLayoutPanel14.Name = "TableLayoutPanel14"
        Me.TableLayoutPanel14.RowCount = 1
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel14.Size = New System.Drawing.Size(360, 41)
        Me.TableLayoutPanel14.TabIndex = 18
        '
        'lbl_guthabentoAsset
        '
        Me.lbl_guthabentoAsset.AutoSize = True
        Me.lbl_guthabentoAsset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_guthabentoAsset.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_guthabentoAsset.Location = New System.Drawing.Point(171, 0)
        Me.lbl_guthabentoAsset.Name = "lbl_guthabentoAsset"
        Me.lbl_guthabentoAsset.Size = New System.Drawing.Size(186, 41)
        Me.lbl_guthabentoAsset.TabIndex = 12
        Me.lbl_guthabentoAsset.Text = "0.00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(162, 41)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Guthaben:"
        '
        'txt_toAmount
        '
        Me.txt_toAmount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_toAmount.Enabled = False
        Me.txt_toAmount.Location = New System.Drawing.Point(4, 4)
        Me.txt_toAmount.Name = "txt_toAmount"
        Me.txt_toAmount.Size = New System.Drawing.Size(360, 40)
        Me.txt_toAmount.TabIndex = 15
        '
        'cmb_toAsset
        '
        Me.cmb_toAsset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_toAsset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_toAsset.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_toAsset.FormattingEnabled = True
        Me.cmb_toAsset.Location = New System.Drawing.Point(371, 4)
        Me.cmb_toAsset.Name = "cmb_toAsset"
        Me.cmb_toAsset.Size = New System.Drawing.Size(213, 48)
        Me.cmb_toAsset.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel10)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(87, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(594, 143)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "from"
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel10.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel10.ColumnCount = 2
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 362.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.btn_maxAmount, 1, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.cmb_fromAsset, 1, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.txt_fromAmount, 0, 0)
        Me.TableLayoutPanel10.Controls.Add(Me.TableLayoutPanel11, 0, 1)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(3, 36)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 2
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(588, 104)
        Me.TableLayoutPanel10.TabIndex = 0
        '
        'btn_maxAmount
        '
        Me.btn_maxAmount.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_maxAmount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_maxAmount.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_maxAmount.Location = New System.Drawing.Point(367, 55)
        Me.btn_maxAmount.Name = "btn_maxAmount"
        Me.btn_maxAmount.Size = New System.Drawing.Size(102, 45)
        Me.btn_maxAmount.TabIndex = 11
        Me.btn_maxAmount.Text = "MAX"
        Me.btn_maxAmount.UseVisualStyleBackColor = False
        '
        'cmb_fromAsset
        '
        Me.cmb_fromAsset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_fromAsset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_fromAsset.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_fromAsset.FormattingEnabled = True
        Me.cmb_fromAsset.Location = New System.Drawing.Point(367, 4)
        Me.cmb_fromAsset.Name = "cmb_fromAsset"
        Me.cmb_fromAsset.Size = New System.Drawing.Size(217, 48)
        Me.cmb_fromAsset.TabIndex = 6
        '
        'txt_fromAmount
        '
        Me.txt_fromAmount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_fromAmount.Location = New System.Drawing.Point(4, 4)
        Me.txt_fromAmount.Name = "txt_fromAmount"
        Me.txt_fromAmount.Size = New System.Drawing.Size(356, 40)
        Me.txt_fromAmount.TabIndex = 14
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.ColumnCount = 2
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Controls.Add(Me.lbl_guthabenfromAsset, 1, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(4, 55)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 1
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(356, 45)
        Me.TableLayoutPanel11.TabIndex = 12
        '
        'lbl_guthabenfromAsset
        '
        Me.lbl_guthabenfromAsset.AutoSize = True
        Me.lbl_guthabenfromAsset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_guthabenfromAsset.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_guthabenfromAsset.Location = New System.Drawing.Point(171, 0)
        Me.lbl_guthabenfromAsset.Name = "lbl_guthabenfromAsset"
        Me.lbl_guthabenfromAsset.Size = New System.Drawing.Size(182, 45)
        Me.lbl_guthabenfromAsset.TabIndex = 12
        Me.lbl_guthabenfromAsset.Text = "0.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 45)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Guthaben:"
        '
        'TableLayoutPanel15
        '
        Me.TableLayoutPanel15.ColumnCount = 2
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69.0!))
        Me.TableLayoutPanel15.Controls.Add(Me.btn_cancelSwap, 1, 0)
        Me.TableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel15.Location = New System.Drawing.Point(1347, 3)
        Me.TableLayoutPanel15.Name = "TableLayoutPanel15"
        Me.TableLayoutPanel15.RowCount = 2
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel15.Size = New System.Drawing.Size(78, 143)
        Me.TableLayoutPanel15.TabIndex = 4
        '
        'btn_cancelSwap
        '
        Me.btn_cancelSwap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelSwap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_cancelSwap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelSwap.ForeColor = System.Drawing.Color.Red
        Me.btn_cancelSwap.Location = New System.Drawing.Point(12, 3)
        Me.btn_cancelSwap.Name = "btn_cancelSwap"
        Me.btn_cancelSwap.Size = New System.Drawing.Size(63, 49)
        Me.btn_cancelSwap.TabIndex = 3
        Me.btn_cancelSwap.Text = "X"
        Me.btn_cancelSwap.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel17
        '
        Me.TableLayoutPanel17.ColumnCount = 3
        Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 342.0!))
        Me.TableLayoutPanel17.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel17.Controls.Add(Me.btn_confirmDEXswap, 1, 0)
        Me.TableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel17.Location = New System.Drawing.Point(3, 158)
        Me.TableLayoutPanel17.Name = "TableLayoutPanel17"
        Me.TableLayoutPanel17.RowCount = 1
        Me.TableLayoutPanel17.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel17.Size = New System.Drawing.Size(1428, 59)
        Me.TableLayoutPanel17.TabIndex = 19
        '
        'btn_confirmDEXswap
        '
        Me.btn_confirmDEXswap.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_confirmDEXswap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_confirmDEXswap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_confirmDEXswap.Location = New System.Drawing.Point(546, 3)
        Me.btn_confirmDEXswap.Name = "btn_confirmDEXswap"
        Me.btn_confirmDEXswap.Size = New System.Drawing.Size(336, 53)
        Me.btn_confirmDEXswap.TabIndex = 0
        Me.btn_confirmDEXswap.Text = "Tausch"
        Me.btn_confirmDEXswap.UseVisualStyleBackColor = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage3.Location = New System.Drawing.Point(8, 48)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1448, 1245)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "-Vaults"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lnk_walletDefiIncome
        '
        Me.lnk_walletDefiIncome.AutoSize = True
        Me.lnk_walletDefiIncome.Dock = System.Windows.Forms.DockStyle.Left
        Me.lnk_walletDefiIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnk_walletDefiIncome.Location = New System.Drawing.Point(5, 2)
        Me.lnk_walletDefiIncome.Name = "lnk_walletDefiIncome"
        Me.lnk_walletDefiIncome.Size = New System.Drawing.Size(84, 64)
        Me.lnk_walletDefiIncome.TabIndex = 8
        Me.lnk_walletDefiIncome.TabStop = True
        Me.lnk_walletDefiIncome.Text = "wallet"
        Me.lnk_walletDefiIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(721, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 34)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "to"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label4.Visible = False
        '
        'FullNode_Wallet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1874, 1429)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MinimumSize = New System.Drawing.Size(1900, 1500)
        Me.Name = "FullNode_Wallet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FullNode-Wallet - Vaults"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel18.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel16.ResumeLayout(False)
        Me.TableLayoutPanel13.ResumeLayout(False)
        CType(Me.pb_swapToken, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.TableLayoutPanel12.PerformLayout()
        Me.TableLayoutPanel14.ResumeLayout(False)
        Me.TableLayoutPanel14.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel11.PerformLayout()
        Me.TableLayoutPanel15.ResumeLayout(False)
        Me.TableLayoutPanel17.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents timer_refresh As Timer
    Friend WithEvents pnl_x As Panel
    Friend WithEvents btn_newVault As Button
    Friend WithEvents lbl_currentblock As Label
    Friend WithEvents lbl_nextPrice As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_overview As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents lbl_futureSwap As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents pgb_statusTransaktion As ProgressBar
    Friend WithEvents lbl_statusTransaktion As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents lnk_walletDefiIncome As LinkLabel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents pnl_guthaben As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TableLayoutPanel13 As TableLayoutPanel
    Friend WithEvents pb_swapToken As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel14 As TableLayoutPanel
    Friend WithEvents lbl_guthabentoAsset As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_toAmount As TextBox
    Friend WithEvents cmb_toAsset As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents btn_maxAmount As Button
    Friend WithEvents cmb_fromAsset As ComboBox
    Friend WithEvents txt_fromAmount As TextBox
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents lbl_guthabenfromAsset As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_openSwap As Button
    Friend WithEvents btn_cancelSwap As Button
    Friend WithEvents TableLayoutPanel15 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel16 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel17 As TableLayoutPanel
    Friend WithEvents btn_confirmDEXswap As Button
    Friend WithEvents TableLayoutPanel18 As TableLayoutPanel
    Friend WithEvents btn_transaktionOK As Button
End Class
