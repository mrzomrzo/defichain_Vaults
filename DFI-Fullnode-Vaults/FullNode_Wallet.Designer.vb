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
        Me.lbl_vaults = New System.Windows.Forms.Label()
        Me.btn_backtoVaults = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_nextfutureSwap = New System.Windows.Forms.Label()
        Me.TableLayoutPanel18 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_transaktionOK = New System.Windows.Forms.Button()
        Me.TableLayoutPanel19 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_statusTransaktion = New System.Windows.Forms.Label()
        Me.lnk_transaction = New System.Windows.Forms.LinkLabel()
        Me.pgb_statusTransaktion = New System.Windows.Forms.ProgressBar()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_guthaben = New System.Windows.Forms.Label()
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel21 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel20 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_futureSwap = New System.Windows.Forms.Label()
        Me.btn_addFutureSwap = New System.Windows.Forms.Button()
        Me.TableLayoutPanel23 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnl_futureSwaps = New System.Windows.Forms.Panel()
        Me.lv_stockPremium = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel22 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_notSynced = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_addresses = New System.Windows.Forms.ComboBox()
        Me.pb_lnkDfiIncome = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chk_allFutureswaps = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel18.SuspendLayout()
        Me.TableLayoutPanel19.SuspendLayout()
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
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel21.SuspendLayout()
        Me.TableLayoutPanel20.SuspendLayout()
        Me.TableLayoutPanel23.SuspendLayout()
        Me.TableLayoutPanel22.SuspendLayout()
        CType(Me.pb_lnkDfiIncome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timer_refresh
        '
        '
        'pnl_x
        '
        Me.pnl_x.AutoScroll = True
        Me.pnl_x.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_x.Location = New System.Drawing.Point(6, 85)
        Me.pnl_x.Margin = New System.Windows.Forms.Padding(4)
        Me.pnl_x.Name = "pnl_x"
        Me.pnl_x.Size = New System.Drawing.Size(2522, 1372)
        Me.pnl_x.TabIndex = 1
        '
        'btn_newVault
        '
        Me.btn_newVault.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_newVault.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_newVault.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_newVault.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_newVault.Location = New System.Drawing.Point(2296, 6)
        Me.btn_newVault.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_newVault.Name = "btn_newVault"
        Me.btn_newVault.Size = New System.Drawing.Size(220, 57)
        Me.btn_newVault.TabIndex = 2
        Me.btn_newVault.Text = "+"
        Me.ToolTip1.SetToolTip(Me.btn_newVault, "create new Vault")
        Me.btn_newVault.UseVisualStyleBackColor = False
        '
        'lbl_currentblock
        '
        Me.lbl_currentblock.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_currentblock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_currentblock.Location = New System.Drawing.Point(176, 0)
        Me.lbl_currentblock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_currentblock.Name = "lbl_currentblock"
        Me.lbl_currentblock.Size = New System.Drawing.Size(150, 37)
        Me.lbl_currentblock.TabIndex = 3
        Me.lbl_currentblock.Text = "00000000"
        Me.lbl_currentblock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_nextPrice
        '
        Me.lbl_nextPrice.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_nextPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nextPrice.Location = New System.Drawing.Point(5, 115)
        Me.lbl_nextPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nextPrice.Name = "lbl_nextPrice"
        Me.lbl_nextPrice.Size = New System.Drawing.Size(330, 142)
        Me.lbl_nextPrice.TabIndex = 4
        Me.lbl_nextPrice.Text = "nextPrice in:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0 Blocks" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "≈ 0min"
        Me.lbl_nextPrice.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnl_x, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(2534, 1463)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 232.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_vaults, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_newVault, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_backtoVaults, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(2522, 69)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'lbl_vaults
        '
        Me.lbl_vaults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_vaults.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vaults.Location = New System.Drawing.Point(64, 0)
        Me.lbl_vaults.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_vaults.Name = "lbl_vaults"
        Me.lbl_vaults.Size = New System.Drawing.Size(2222, 69)
        Me.lbl_vaults.TabIndex = 0
        Me.lbl_vaults.Text = "overViewText"
        Me.lbl_vaults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_backtoVaults
        '
        Me.btn_backtoVaults.BackgroundImage = CType(resources.GetObject("btn_backtoVaults.BackgroundImage"), System.Drawing.Image)
        Me.btn_backtoVaults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_backtoVaults.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_backtoVaults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_backtoVaults.Location = New System.Drawing.Point(4, 4)
        Me.btn_backtoVaults.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_backtoVaults.Name = "btn_backtoVaults"
        Me.btn_backtoVaults.Size = New System.Drawing.Size(52, 61)
        Me.btn_backtoVaults.TabIndex = 3
        Me.btn_backtoVaults.UseVisualStyleBackColor = True
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
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(2974, 1658)
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
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(24, 23)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(2926, 1612)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.lbl_nextfutureSwap, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel18, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.lbl_nextPrice, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.pgb_statusTransaktion, 0, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(2582, 4)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 5
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(340, 1604)
        Me.TableLayoutPanel5.TabIndex = 7
        '
        'lbl_nextfutureSwap
        '
        Me.lbl_nextfutureSwap.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_nextfutureSwap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nextfutureSwap.Location = New System.Drawing.Point(5, 266)
        Me.lbl_nextfutureSwap.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nextfutureSwap.Name = "lbl_nextfutureSwap"
        Me.lbl_nextfutureSwap.Size = New System.Drawing.Size(330, 183)
        Me.lbl_nextfutureSwap.TabIndex = 8
        Me.lbl_nextfutureSwap.Text = "nextFutureSwap in:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0 Blocks " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "≈ 0t-0h-0min"
        Me.lbl_nextfutureSwap.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TableLayoutPanel18
        '
        Me.TableLayoutPanel18.ColumnCount = 2
        Me.TableLayoutPanel18.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 246.0!))
        Me.TableLayoutPanel18.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel18.Controls.Add(Me.btn_transaktionOK, 1, 0)
        Me.TableLayoutPanel18.Controls.Add(Me.TableLayoutPanel19, 0, 0)
        Me.TableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel18.Location = New System.Drawing.Point(5, 1419)
        Me.TableLayoutPanel18.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel18.Name = "TableLayoutPanel18"
        Me.TableLayoutPanel18.RowCount = 1
        Me.TableLayoutPanel18.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel18.Size = New System.Drawing.Size(330, 146)
        Me.TableLayoutPanel18.TabIndex = 4
        '
        'btn_transaktionOK
        '
        Me.btn_transaktionOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_transaktionOK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_transaktionOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_transaktionOK.Location = New System.Drawing.Point(250, 4)
        Me.btn_transaktionOK.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_transaktionOK.Name = "btn_transaktionOK"
        Me.btn_transaktionOK.Size = New System.Drawing.Size(76, 138)
        Me.btn_transaktionOK.TabIndex = 13
        Me.btn_transaktionOK.Text = "OK"
        Me.btn_transaktionOK.UseVisualStyleBackColor = True
        Me.btn_transaktionOK.Visible = False
        '
        'TableLayoutPanel19
        '
        Me.TableLayoutPanel19.ColumnCount = 1
        Me.TableLayoutPanel19.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel19.Controls.Add(Me.lbl_statusTransaktion, 0, 0)
        Me.TableLayoutPanel19.Controls.Add(Me.lnk_transaction, 0, 1)
        Me.TableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel19.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel19.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel19.Name = "TableLayoutPanel19"
        Me.TableLayoutPanel19.RowCount = 2
        Me.TableLayoutPanel19.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel19.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel19.Size = New System.Drawing.Size(234, 134)
        Me.TableLayoutPanel19.TabIndex = 14
        '
        'lbl_statusTransaktion
        '
        Me.lbl_statusTransaktion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_statusTransaktion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_statusTransaktion.Location = New System.Drawing.Point(4, 0)
        Me.lbl_statusTransaktion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_statusTransaktion.Name = "lbl_statusTransaktion"
        Me.lbl_statusTransaktion.Size = New System.Drawing.Size(226, 85)
        Me.lbl_statusTransaktion.TabIndex = 12
        Me.lbl_statusTransaktion.Text = "Status Transaktion"
        Me.lbl_statusTransaktion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_statusTransaktion.Visible = False
        '
        'lnk_transaction
        '
        Me.lnk_transaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lnk_transaction.Location = New System.Drawing.Point(6, 85)
        Me.lnk_transaction.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lnk_transaction.Name = "lnk_transaction"
        Me.lnk_transaction.Size = New System.Drawing.Size(222, 49)
        Me.lnk_transaction.TabIndex = 13
        Me.lnk_transaction.TabStop = True
        Me.lnk_transaction.Text = "xxxxxxxxxxxxxx"
        Me.lnk_transaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnk_transaction.Visible = False
        '
        'pgb_statusTransaktion
        '
        Me.pgb_statusTransaktion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pgb_statusTransaktion.Location = New System.Drawing.Point(5, 1574)
        Me.pgb_statusTransaktion.Margin = New System.Windows.Forms.Padding(4)
        Me.pgb_statusTransaktion.Name = "pgb_statusTransaktion"
        Me.pgb_statusTransaktion.Size = New System.Drawing.Size(330, 25)
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
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(5, 5)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(330, 105)
        Me.TableLayoutPanel6.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 37)
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
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel22, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(2570, 1604)
        Me.TableLayoutPanel7.TabIndex = 10
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(6, 71)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(2558, 1527)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel9)
        Me.TabPage1.Location = New System.Drawing.Point(8, 48)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(2542, 1471)
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
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel9.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 3
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 227.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(2534, 1463)
        Me.TableLayoutPanel9.TabIndex = 1
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 3
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 556.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.lbl_guthaben, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.btn_openSwap, 2, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(5, 5)
        Me.TableLayoutPanel8.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(2524, 69)
        Me.TableLayoutPanel8.TabIndex = 0
        '
        'lbl_guthaben
        '
        Me.lbl_guthaben.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_guthaben.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_guthaben.Location = New System.Drawing.Point(64, 0)
        Me.lbl_guthaben.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_guthaben.Name = "lbl_guthaben"
        Me.lbl_guthaben.Size = New System.Drawing.Size(1900, 69)
        Me.lbl_guthaben.TabIndex = 1
        Me.lbl_guthaben.Text = "overViewText"
        Me.lbl_guthaben.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_openSwap
        '
        Me.btn_openSwap.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_openSwap.BackgroundImage = CType(resources.GetObject("btn_openSwap.BackgroundImage"), System.Drawing.Image)
        Me.btn_openSwap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_openSwap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_openSwap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_openSwap.Enabled = False
        Me.btn_openSwap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_openSwap.Location = New System.Drawing.Point(1972, 4)
        Me.btn_openSwap.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_openSwap.Name = "btn_openSwap"
        Me.btn_openSwap.Size = New System.Drawing.Size(548, 61)
        Me.btn_openSwap.TabIndex = 2
        Me.btn_openSwap.Text = "DEX - Tausch"
        Me.btn_openSwap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_openSwap.UseVisualStyleBackColor = False
        '
        'pnl_guthaben
        '
        Me.pnl_guthaben.AutoScroll = True
        Me.pnl_guthaben.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_guthaben.Location = New System.Drawing.Point(5, 83)
        Me.pnl_guthaben.Margin = New System.Windows.Forms.Padding(4)
        Me.pnl_guthaben.Name = "pnl_guthaben"
        Me.pnl_guthaben.Size = New System.Drawing.Size(2524, 1147)
        Me.pnl_guthaben.TabIndex = 1
        '
        'TableLayoutPanel16
        '
        Me.TableLayoutPanel16.ColumnCount = 1
        Me.TableLayoutPanel16.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel16.Controls.Add(Me.TableLayoutPanel13, 0, 0)
        Me.TableLayoutPanel16.Controls.Add(Me.TableLayoutPanel17, 0, 1)
        Me.TableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel16.Location = New System.Drawing.Point(5, 1239)
        Me.TableLayoutPanel16.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel16.Name = "TableLayoutPanel16"
        Me.TableLayoutPanel16.RowCount = 2
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 156.0!))
        Me.TableLayoutPanel16.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel16.Size = New System.Drawing.Size(2524, 219)
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
        Me.TableLayoutPanel13.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel13.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel13.Name = "TableLayoutPanel13"
        Me.TableLayoutPanel13.RowCount = 1
        Me.TableLayoutPanel13.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel13.Size = New System.Drawing.Size(2516, 148)
        Me.TableLayoutPanel13.TabIndex = 18
        '
        'pb_swapToken
        '
        Me.pb_swapToken.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_swapToken.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pb_swapToken.Image = CType(resources.GetObject("pb_swapToken.Image"), System.Drawing.Image)
        Me.pb_swapToken.Location = New System.Drawing.Point(1232, 4)
        Me.pb_swapToken.Margin = New System.Windows.Forms.Padding(4)
        Me.pb_swapToken.Name = "pb_swapToken"
        Me.pb_swapToken.Size = New System.Drawing.Size(52, 140)
        Me.pb_swapToken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_swapToken.TabIndex = 0
        Me.pb_swapToken.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel12)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(1292, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(592, 140)
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
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(4, 37)
        Me.TableLayoutPanel12.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 2
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54.0!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(584, 99)
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
        Me.TableLayoutPanel14.Location = New System.Drawing.Point(5, 60)
        Me.TableLayoutPanel14.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel14.Name = "TableLayoutPanel14"
        Me.TableLayoutPanel14.RowCount = 1
        Me.TableLayoutPanel14.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel14.Size = New System.Drawing.Size(358, 34)
        Me.TableLayoutPanel14.TabIndex = 18
        '
        'lbl_guthabentoAsset
        '
        Me.lbl_guthabentoAsset.AutoSize = True
        Me.lbl_guthabentoAsset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_guthabentoAsset.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_guthabentoAsset.Location = New System.Drawing.Point(172, 0)
        Me.lbl_guthabentoAsset.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_guthabentoAsset.Name = "lbl_guthabentoAsset"
        Me.lbl_guthabentoAsset.Size = New System.Drawing.Size(182, 34)
        Me.lbl_guthabentoAsset.TabIndex = 12
        Me.lbl_guthabentoAsset.Text = "0.00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 0)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(160, 34)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Guthaben:"
        '
        'txt_toAmount
        '
        Me.txt_toAmount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_toAmount.Enabled = False
        Me.txt_toAmount.Location = New System.Drawing.Point(5, 5)
        Me.txt_toAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_toAmount.Name = "txt_toAmount"
        Me.txt_toAmount.Size = New System.Drawing.Size(358, 40)
        Me.txt_toAmount.TabIndex = 15
        '
        'cmb_toAsset
        '
        Me.cmb_toAsset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_toAsset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_toAsset.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_toAsset.FormattingEnabled = True
        Me.cmb_toAsset.Location = New System.Drawing.Point(372, 5)
        Me.cmb_toAsset.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_toAsset.Name = "cmb_toAsset"
        Me.cmb_toAsset.Size = New System.Drawing.Size(207, 48)
        Me.cmb_toAsset.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel10)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(632, 4)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(592, 140)
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
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(4, 37)
        Me.TableLayoutPanel10.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 2
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(584, 99)
        Me.TableLayoutPanel10.TabIndex = 0
        '
        'btn_maxAmount
        '
        Me.btn_maxAmount.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_maxAmount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_maxAmount.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_maxAmount.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_maxAmount.Location = New System.Drawing.Point(368, 56)
        Me.btn_maxAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_maxAmount.Name = "btn_maxAmount"
        Me.btn_maxAmount.Size = New System.Drawing.Size(102, 38)
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
        Me.cmb_fromAsset.Location = New System.Drawing.Point(368, 5)
        Me.cmb_fromAsset.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_fromAsset.Name = "cmb_fromAsset"
        Me.cmb_fromAsset.Size = New System.Drawing.Size(211, 48)
        Me.cmb_fromAsset.TabIndex = 6
        '
        'txt_fromAmount
        '
        Me.txt_fromAmount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_fromAmount.Location = New System.Drawing.Point(5, 5)
        Me.txt_fromAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_fromAmount.Name = "txt_fromAmount"
        Me.txt_fromAmount.Size = New System.Drawing.Size(354, 40)
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
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(5, 56)
        Me.TableLayoutPanel11.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 1
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(354, 38)
        Me.TableLayoutPanel11.TabIndex = 12
        '
        'lbl_guthabenfromAsset
        '
        Me.lbl_guthabenfromAsset.AutoSize = True
        Me.lbl_guthabenfromAsset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_guthabenfromAsset.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_guthabenfromAsset.Location = New System.Drawing.Point(172, 0)
        Me.lbl_guthabenfromAsset.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_guthabenfromAsset.Name = "lbl_guthabenfromAsset"
        Me.lbl_guthabenfromAsset.Size = New System.Drawing.Size(178, 38)
        Me.lbl_guthabenfromAsset.TabIndex = 12
        Me.lbl_guthabenfromAsset.Text = "0.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 38)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Guthaben:"
        '
        'TableLayoutPanel15
        '
        Me.TableLayoutPanel15.ColumnCount = 2
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel15.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TableLayoutPanel15.Controls.Add(Me.btn_cancelSwap, 1, 0)
        Me.TableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel15.Location = New System.Drawing.Point(1892, 4)
        Me.TableLayoutPanel15.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel15.Name = "TableLayoutPanel15"
        Me.TableLayoutPanel15.RowCount = 2
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel15.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel15.Size = New System.Drawing.Size(620, 140)
        Me.TableLayoutPanel15.TabIndex = 4
        '
        'btn_cancelSwap
        '
        Me.btn_cancelSwap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelSwap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_cancelSwap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelSwap.ForeColor = System.Drawing.Color.Red
        Me.btn_cancelSwap.Location = New System.Drawing.Point(556, 4)
        Me.btn_cancelSwap.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cancelSwap.Name = "btn_cancelSwap"
        Me.btn_cancelSwap.Size = New System.Drawing.Size(60, 48)
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
        Me.TableLayoutPanel17.Location = New System.Drawing.Point(4, 160)
        Me.TableLayoutPanel17.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel17.Name = "TableLayoutPanel17"
        Me.TableLayoutPanel17.RowCount = 1
        Me.TableLayoutPanel17.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel17.Size = New System.Drawing.Size(2516, 55)
        Me.TableLayoutPanel17.TabIndex = 19
        '
        'btn_confirmDEXswap
        '
        Me.btn_confirmDEXswap.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_confirmDEXswap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_confirmDEXswap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_confirmDEXswap.Location = New System.Drawing.Point(1091, 4)
        Me.btn_confirmDEXswap.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_confirmDEXswap.Name = "btn_confirmDEXswap"
        Me.btn_confirmDEXswap.Size = New System.Drawing.Size(334, 47)
        Me.btn_confirmDEXswap.TabIndex = 0
        Me.btn_confirmDEXswap.Text = "Tausch"
        Me.btn_confirmDEXswap.UseVisualStyleBackColor = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage3.Location = New System.Drawing.Point(8, 48)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Size = New System.Drawing.Size(2542, 1471)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "-Vaults"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel21)
        Me.TabPage2.Location = New System.Drawing.Point(8, 48)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(6)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(6)
        Me.TabPage2.Size = New System.Drawing.Size(2542, 1471)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "-FutureSwap"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel21
        '
        Me.TableLayoutPanel21.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel21.ColumnCount = 1
        Me.TableLayoutPanel21.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel21.Controls.Add(Me.TableLayoutPanel20, 0, 0)
        Me.TableLayoutPanel21.Controls.Add(Me.TableLayoutPanel23, 0, 1)
        Me.TableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel21.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel21.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel21.Name = "TableLayoutPanel21"
        Me.TableLayoutPanel21.RowCount = 2
        Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77.0!))
        Me.TableLayoutPanel21.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel21.Size = New System.Drawing.Size(2530, 1459)
        Me.TableLayoutPanel21.TabIndex = 3
        '
        'TableLayoutPanel20
        '
        Me.TableLayoutPanel20.ColumnCount = 4
        Me.TableLayoutPanel20.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel20.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel20.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 504.0!))
        Me.TableLayoutPanel20.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228.0!))
        Me.TableLayoutPanel20.Controls.Add(Me.lbl_futureSwap, 1, 0)
        Me.TableLayoutPanel20.Controls.Add(Me.btn_addFutureSwap, 3, 0)
        Me.TableLayoutPanel20.Controls.Add(Me.chk_allFutureswaps, 2, 0)
        Me.TableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel20.Location = New System.Drawing.Point(8, 8)
        Me.TableLayoutPanel20.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel20.Name = "TableLayoutPanel20"
        Me.TableLayoutPanel20.RowCount = 1
        Me.TableLayoutPanel20.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel20.Size = New System.Drawing.Size(2514, 65)
        Me.TableLayoutPanel20.TabIndex = 2
        '
        'lbl_futureSwap
        '
        Me.lbl_futureSwap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_futureSwap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_futureSwap.Location = New System.Drawing.Point(66, 0)
        Me.lbl_futureSwap.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_futureSwap.Name = "lbl_futureSwap"
        Me.lbl_futureSwap.Size = New System.Drawing.Size(1710, 65)
        Me.lbl_futureSwap.TabIndex = 1
        Me.lbl_futureSwap.Text = "overViewText"
        Me.lbl_futureSwap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_addFutureSwap
        '
        Me.btn_addFutureSwap.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_addFutureSwap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addFutureSwap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_addFutureSwap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addFutureSwap.Location = New System.Drawing.Point(2292, 6)
        Me.btn_addFutureSwap.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_addFutureSwap.Name = "btn_addFutureSwap"
        Me.btn_addFutureSwap.Size = New System.Drawing.Size(216, 53)
        Me.btn_addFutureSwap.TabIndex = 0
        Me.btn_addFutureSwap.Text = "+"
        Me.ToolTip1.SetToolTip(Me.btn_addFutureSwap, "create new FutureSwap")
        Me.btn_addFutureSwap.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel23
        '
        Me.TableLayoutPanel23.ColumnCount = 2
        Me.TableLayoutPanel23.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel23.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 874.0!))
        Me.TableLayoutPanel23.Controls.Add(Me.pnl_futureSwaps, 0, 0)
        Me.TableLayoutPanel23.Controls.Add(Me.lv_stockPremium, 1, 0)
        Me.TableLayoutPanel23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel23.Location = New System.Drawing.Point(8, 87)
        Me.TableLayoutPanel23.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel23.Name = "TableLayoutPanel23"
        Me.TableLayoutPanel23.RowCount = 1
        Me.TableLayoutPanel23.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel23.Size = New System.Drawing.Size(2514, 1364)
        Me.TableLayoutPanel23.TabIndex = 3
        '
        'pnl_futureSwaps
        '
        Me.pnl_futureSwaps.AutoScroll = True
        Me.pnl_futureSwaps.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_futureSwaps.Location = New System.Drawing.Point(6, 6)
        Me.pnl_futureSwaps.Margin = New System.Windows.Forms.Padding(6)
        Me.pnl_futureSwaps.Name = "pnl_futureSwaps"
        Me.pnl_futureSwaps.Size = New System.Drawing.Size(1628, 1352)
        Me.pnl_futureSwaps.TabIndex = 3
        '
        'lv_stockPremium
        '
        Me.lv_stockPremium.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lv_stockPremium.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_stockPremium.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_stockPremium.FullRowSelect = True
        Me.lv_stockPremium.GridLines = True
        Me.lv_stockPremium.HideSelection = False
        Me.lv_stockPremium.Location = New System.Drawing.Point(1646, 6)
        Me.lv_stockPremium.Margin = New System.Windows.Forms.Padding(6)
        Me.lv_stockPremium.Name = "lv_stockPremium"
        Me.lv_stockPremium.Size = New System.Drawing.Size(862, 1352)
        Me.lv_stockPremium.TabIndex = 4
        Me.lv_stockPremium.UseCompatibleStateImageBehavior = False
        Me.lv_stockPremium.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Ticker"
        Me.ColumnHeader5.Width = 76
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Active"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader1.Width = 89
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Next"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 85
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "DEX"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 82
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Diff%"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 89
        '
        'TableLayoutPanel22
        '
        Me.TableLayoutPanel22.ColumnCount = 5
        Me.TableLayoutPanel22.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel22.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 734.0!))
        Me.TableLayoutPanel22.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.TableLayoutPanel22.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel22.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 578.0!))
        Me.TableLayoutPanel22.Controls.Add(Me.lbl_notSynced, 4, 0)
        Me.TableLayoutPanel22.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel22.Controls.Add(Me.cmb_addresses, 1, 0)
        Me.TableLayoutPanel22.Controls.Add(Me.pb_lnkDfiIncome, 2, 0)
        Me.TableLayoutPanel22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel22.Location = New System.Drawing.Point(8, 8)
        Me.TableLayoutPanel22.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel22.Name = "TableLayoutPanel22"
        Me.TableLayoutPanel22.RowCount = 1
        Me.TableLayoutPanel22.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel22.Size = New System.Drawing.Size(2554, 51)
        Me.TableLayoutPanel22.TabIndex = 10
        '
        'lbl_notSynced
        '
        Me.lbl_notSynced.BackColor = System.Drawing.Color.OrangeRed
        Me.lbl_notSynced.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_notSynced.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_notSynced.Location = New System.Drawing.Point(1982, 0)
        Me.lbl_notSynced.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_notSynced.Name = "lbl_notSynced"
        Me.lbl_notSynced.Size = New System.Drawing.Size(566, 51)
        Me.lbl_notSynced.TabIndex = 9
        Me.lbl_notSynced.Text = "FullNode not synced 0 Blocks remaining"
        Me.lbl_notSynced.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_notSynced.Visible = False
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 51)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Wallet"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_addresses
        '
        Me.cmb_addresses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_addresses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_addresses.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_addresses.FormattingEnabled = True
        Me.cmb_addresses.Location = New System.Drawing.Point(113, 3)
        Me.cmb_addresses.Name = "cmb_addresses"
        Me.cmb_addresses.Size = New System.Drawing.Size(728, 39)
        Me.cmb_addresses.TabIndex = 10
        '
        'pb_lnkDfiIncome
        '
        Me.pb_lnkDfiIncome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_lnkDfiIncome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pb_lnkDfiIncome.Image = CType(resources.GetObject("pb_lnkDfiIncome.Image"), System.Drawing.Image)
        Me.pb_lnkDfiIncome.Location = New System.Drawing.Point(847, 3)
        Me.pb_lnkDfiIncome.Name = "pb_lnkDfiIncome"
        Me.pb_lnkDfiIncome.Size = New System.Drawing.Size(70, 45)
        Me.pb_lnkDfiIncome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_lnkDfiIncome.TabIndex = 12
        Me.pb_lnkDfiIncome.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pb_lnkDfiIncome, "Defichain-Income")
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
        'chk_allFutureswaps
        '
        Me.chk_allFutureswaps.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chk_allFutureswaps.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_allFutureswaps.Location = New System.Drawing.Point(1785, 3)
        Me.chk_allFutureswaps.Name = "chk_allFutureswaps"
        Me.chk_allFutureswaps.Size = New System.Drawing.Size(498, 59)
        Me.chk_allFutureswaps.TabIndex = 2
        Me.chk_allFutureswaps.Text = "showAll-FutureSwaps"
        Me.chk_allFutureswaps.UseVisualStyleBackColor = True
        '
        'FullNode_Wallet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2974, 1658)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MinimumSize = New System.Drawing.Size(3000, 1700)
        Me.Name = "FullNode_Wallet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FullNode-Wallet - Vaults"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel18.ResumeLayout(False)
        Me.TableLayoutPanel19.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
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
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel21.ResumeLayout(False)
        Me.TableLayoutPanel20.ResumeLayout(False)
        Me.TableLayoutPanel23.ResumeLayout(False)
        Me.TableLayoutPanel22.ResumeLayout(False)
        CType(Me.pb_lnkDfiIncome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents timer_refresh As Timer
    Friend WithEvents pnl_x As Panel
    Friend WithEvents btn_newVault As Button
    Friend WithEvents lbl_currentblock As Label
    Friend WithEvents lbl_nextPrice As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_vaults As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents lbl_nextfutureSwap As Label
    Friend WithEvents btn_backtoVaults As Button
    Friend WithEvents pgb_statusTransaktion As ProgressBar
    Friend WithEvents lbl_statusTransaktion As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents lbl_guthaben As Label
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
    Friend WithEvents TableLayoutPanel19 As TableLayoutPanel
    Friend WithEvents lnk_transaction As LinkLabel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lbl_futureSwap As Label
    Friend WithEvents btn_addFutureSwap As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TableLayoutPanel21 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel20 As TableLayoutPanel
    Friend WithEvents pnl_futureSwaps As Panel
    Friend WithEvents TableLayoutPanel22 As TableLayoutPanel
    Friend WithEvents lbl_notSynced As Label
    Friend WithEvents TableLayoutPanel23 As TableLayoutPanel
    Friend WithEvents lv_stockPremium As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents cmb_addresses As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pb_lnkDfiIncome As PictureBox
    Friend WithEvents chk_allFutureswaps As CheckBox
End Class
