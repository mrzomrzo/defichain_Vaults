<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vault_interact
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
        Me.cmb_ticker = New System.Windows.Forms.ComboBox()
        Me.lbl_icon_add_remove = New System.Windows.Forms.Label()
        Me.btn_maxAmount = New System.Windows.Forms.Button()
        Me.txt_amount = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_resultierendeQuote = New System.Windows.Forms.Label()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_amountVerfügbar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_assetName = New System.Windows.Forms.Label()
        Me.tlp_loan = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_textSaldo = New System.Windows.Forms.Label()
        Me.lbl_Saldo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_maxTilgen = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.tlp_loan.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmb_ticker
        '
        Me.cmb_ticker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ticker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ticker.FormattingEnabled = True
        Me.cmb_ticker.Location = New System.Drawing.Point(53, 3)
        Me.cmb_ticker.Name = "cmb_ticker"
        Me.cmb_ticker.Size = New System.Drawing.Size(223, 41)
        Me.cmb_ticker.TabIndex = 0
        '
        'lbl_icon_add_remove
        '
        Me.lbl_icon_add_remove.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_icon_add_remove.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_icon_add_remove.Location = New System.Drawing.Point(3, 0)
        Me.lbl_icon_add_remove.Name = "lbl_icon_add_remove"
        Me.lbl_icon_add_remove.Size = New System.Drawing.Size(44, 54)
        Me.lbl_icon_add_remove.TabIndex = 1
        Me.lbl_icon_add_remove.Text = "?"
        '
        'btn_maxAmount
        '
        Me.btn_maxAmount.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_maxAmount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_maxAmount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_maxAmount.Location = New System.Drawing.Point(719, 3)
        Me.btn_maxAmount.Name = "btn_maxAmount"
        Me.btn_maxAmount.Size = New System.Drawing.Size(102, 48)
        Me.btn_maxAmount.TabIndex = 2
        Me.btn_maxAmount.Text = "MAX"
        Me.btn_maxAmount.UseVisualStyleBackColor = False
        '
        'txt_amount
        '
        Me.txt_amount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_amount.Enabled = False
        Me.txt_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amount.Location = New System.Drawing.Point(3, 3)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(710, 40)
        Me.txt_amount.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_ticker, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_icon_add_remove, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_cancel, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(5, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(824, 54)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'btn_cancel
        '
        Me.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.Red
        Me.btn_cancel.Location = New System.Drawing.Point(745, 3)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(76, 48)
        Me.btn_cancel.TabIndex = 2
        Me.btn_cancel.Text = "X"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btn_maxAmount, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_amount, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(5, 74)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(824, 54)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_resultierendeQuote, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_confirm, 0, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.tlp_loan, 0, 4)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 7
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(834, 410)
        Me.TableLayoutPanel3.TabIndex = 6
        '
        'lbl_resultierendeQuote
        '
        Me.lbl_resultierendeQuote.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbl_resultierendeQuote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_resultierendeQuote.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_resultierendeQuote.Location = New System.Drawing.Point(5, 231)
        Me.lbl_resultierendeQuote.Name = "lbl_resultierendeQuote"
        Me.lbl_resultierendeQuote.Size = New System.Drawing.Size(824, 93)
        Me.lbl_resultierendeQuote.TabIndex = 6
        Me.lbl_resultierendeQuote.Text = "resultierende Besicherungsquote: 0%"
        Me.lbl_resultierendeQuote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_confirm
        '
        Me.btn_confirm.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_confirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_confirm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_confirm.Enabled = False
        Me.btn_confirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirm.Location = New System.Drawing.Point(5, 329)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(824, 76)
        Me.btn_confirm.TabIndex = 8
        Me.btn_confirm.Text = "confirm"
        Me.btn_confirm.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_amountVerfügbar, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_assetName, 2, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(5, 136)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(824, 38)
        Me.TableLayoutPanel4.TabIndex = 9
        '
        'lbl_amountVerfügbar
        '
        Me.lbl_amountVerfügbar.AutoSize = True
        Me.lbl_amountVerfügbar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_amountVerfügbar.Location = New System.Drawing.Point(137, 0)
        Me.lbl_amountVerfügbar.Name = "lbl_amountVerfügbar"
        Me.lbl_amountVerfügbar.Size = New System.Drawing.Size(190, 38)
        Me.lbl_amountVerfügbar.TabIndex = 7
        Me.lbl_amountVerfügbar.Text = "0.00"
        Me.lbl_amountVerfügbar.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 38)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Verfügbar:"
        '
        'lbl_assetName
        '
        Me.lbl_assetName.AutoSize = True
        Me.lbl_assetName.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_assetName.Location = New System.Drawing.Point(333, 0)
        Me.lbl_assetName.Name = "lbl_assetName"
        Me.lbl_assetName.Size = New System.Drawing.Size(71, 38)
        Me.lbl_assetName.TabIndex = 9
        Me.lbl_assetName.Text = "Ticker"
        '
        'tlp_loan
        '
        Me.tlp_loan.ColumnCount = 4
        Me.tlp_loan.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134.0!))
        Me.tlp_loan.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196.0!))
        Me.tlp_loan.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78.0!))
        Me.tlp_loan.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_loan.Controls.Add(Me.lbl_textSaldo, 0, 0)
        Me.tlp_loan.Controls.Add(Me.lbl_Saldo, 1, 0)
        Me.tlp_loan.Controls.Add(Me.Label2, 2, 0)
        Me.tlp_loan.Controls.Add(Me.btn_maxTilgen, 3, 0)
        Me.tlp_loan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_loan.Location = New System.Drawing.Point(5, 182)
        Me.tlp_loan.Name = "tlp_loan"
        Me.tlp_loan.RowCount = 1
        Me.tlp_loan.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_loan.Size = New System.Drawing.Size(824, 44)
        Me.tlp_loan.TabIndex = 10
        Me.tlp_loan.Visible = False
        '
        'lbl_textSaldo
        '
        Me.lbl_textSaldo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_textSaldo.Location = New System.Drawing.Point(3, 0)
        Me.lbl_textSaldo.Name = "lbl_textSaldo"
        Me.lbl_textSaldo.Size = New System.Drawing.Size(128, 44)
        Me.lbl_textSaldo.TabIndex = 0
        Me.lbl_textSaldo.Text = "Text:"
        '
        'lbl_Saldo
        '
        Me.lbl_Saldo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Saldo.Location = New System.Drawing.Point(137, 0)
        Me.lbl_Saldo.Name = "lbl_Saldo"
        Me.lbl_Saldo.Size = New System.Drawing.Size(190, 44)
        Me.lbl_Saldo.TabIndex = 1
        Me.lbl_Saldo.Text = "0.00"
        Me.lbl_Saldo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(333, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "$"
        '
        'btn_maxTilgen
        '
        Me.btn_maxTilgen.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_maxTilgen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_maxTilgen.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_maxTilgen.Location = New System.Drawing.Point(411, 3)
        Me.btn_maxTilgen.Name = "btn_maxTilgen"
        Me.btn_maxTilgen.Size = New System.Drawing.Size(169, 38)
        Me.btn_maxTilgen.TabIndex = 3
        Me.btn_maxTilgen.Text = "max_Tilgen"
        Me.btn_maxTilgen.UseVisualStyleBackColor = False
        Me.btn_maxTilgen.Visible = False
        '
        'Vault_interact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Name = "Vault_interact"
        Me.Size = New System.Drawing.Size(834, 410)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.tlp_loan.ResumeLayout(False)
        Me.tlp_loan.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmb_ticker As ComboBox
    Friend WithEvents lbl_icon_add_remove As Label
    Friend WithEvents btn_maxAmount As Button
    Friend WithEvents txt_amount As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lbl_resultierendeQuote As Label
    Friend WithEvents lbl_amountVerfügbar As Label
    Friend WithEvents btn_confirm As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_assetName As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents tlp_loan As TableLayoutPanel
    Friend WithEvents lbl_textSaldo As Label
    Friend WithEvents lbl_Saldo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_maxTilgen As Button
End Class
