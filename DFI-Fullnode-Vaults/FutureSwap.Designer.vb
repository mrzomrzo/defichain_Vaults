<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FutureSwap
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_withdrawFutereSwap = New System.Windows.Forms.Button()
        Me.lbl_returnAsset = New System.Windows.Forms.Label()
        Me.lbl_locked = New System.Windows.Forms.Label()
        Me.btn_addFutureswapInfo = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_amountMinted = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_profit = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 326.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_profit, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_withdrawFutereSwap, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_returnAsset, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_locked, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_addFutureswapInfo, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_amountMinted, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(938, 162)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(461, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 84)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ReturnAsset:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 3)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 84)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Locked:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_withdrawFutereSwap
        '
        Me.btn_withdrawFutereSwap.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_withdrawFutereSwap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_withdrawFutereSwap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_withdrawFutereSwap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_withdrawFutereSwap.Location = New System.Drawing.Point(771, 9)
        Me.btn_withdrawFutereSwap.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_withdrawFutereSwap.Name = "btn_withdrawFutereSwap"
        Me.btn_withdrawFutereSwap.Size = New System.Drawing.Size(158, 72)
        Me.btn_withdrawFutereSwap.TabIndex = 4
        Me.btn_withdrawFutereSwap.Text = "Auszahlen"
        Me.ToolTip1.SetToolTip(Me.btn_withdrawFutereSwap, "FutureSwap wieder auszahlen ")
        Me.btn_withdrawFutereSwap.UseVisualStyleBackColor = False
        '
        'lbl_returnAsset
        '
        Me.lbl_returnAsset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_returnAsset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_returnAsset.Location = New System.Drawing.Point(644, 3)
        Me.lbl_returnAsset.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_returnAsset.Name = "lbl_returnAsset"
        Me.lbl_returnAsset.Size = New System.Drawing.Size(112, 84)
        Me.lbl_returnAsset.TabIndex = 0
        Me.lbl_returnAsset.Text = "ASSET"
        Me.lbl_returnAsset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_locked
        '
        Me.lbl_locked.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_locked.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_locked.Location = New System.Drawing.Point(132, 3)
        Me.lbl_locked.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_locked.Name = "lbl_locked"
        Me.lbl_locked.Size = New System.Drawing.Size(314, 84)
        Me.lbl_locked.TabIndex = 1
        Me.lbl_locked.Text = "0.00@DUSD"
        Me.lbl_locked.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_addFutureswapInfo
        '
        Me.btn_addFutureswapInfo.BackColor = System.Drawing.Color.SandyBrown
        Me.btn_addFutureswapInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addFutureswapInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_addFutureswapInfo.Location = New System.Drawing.Point(768, 93)
        Me.btn_addFutureswapInfo.Name = "btn_addFutureswapInfo"
        Me.btn_addFutureswapInfo.Size = New System.Drawing.Size(164, 63)
        Me.btn_addFutureswapInfo.TabIndex = 6
        Me.btn_addFutureswapInfo.Text = "add INFO"
        Me.ToolTip1.SetToolTip(Me.btn_addFutureswapInfo, "Infos zur Gewinn/Verlust Rechnung hinzufügen")
        Me.btn_addFutureswapInfo.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(461, 90)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 69)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Minted amount:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_amountMinted
        '
        Me.lbl_amountMinted.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_amountMinted.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_amountMinted.Location = New System.Drawing.Point(644, 90)
        Me.lbl_amountMinted.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_amountMinted.Name = "lbl_amountMinted"
        Me.lbl_amountMinted.Size = New System.Drawing.Size(112, 69)
        Me.lbl_amountMinted.TabIndex = 8
        Me.lbl_amountMinted.Text = "0.00"
        Me.lbl_amountMinted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_amountMinted.Visible = False
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 90)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 69)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "current Profit:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_profit
        '
        Me.lbl_profit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_profit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_profit.Location = New System.Drawing.Point(132, 90)
        Me.lbl_profit.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_profit.Name = "lbl_profit"
        Me.lbl_profit.Size = New System.Drawing.Size(314, 69)
        Me.lbl_profit.TabIndex = 10
        Me.lbl_profit.Text = "-00.00000000Asset"
        Me.lbl_profit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_profit.Visible = False
        '
        'FutureSwap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FutureSwap"
        Me.Size = New System.Drawing.Size(938, 162)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_returnAsset As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_locked As Label
    Friend WithEvents btn_withdrawFutereSwap As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btn_addFutureswapInfo As Button
    Friend WithEvents lbl_profit As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_amountMinted As Label
    Friend WithEvents Label3 As Label
End Class
