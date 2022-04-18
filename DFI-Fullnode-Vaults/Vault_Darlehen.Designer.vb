<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vault_Darlehen
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_tickerName = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_moreLoan = New System.Windows.Forms.Button()
        Me.btn_reduceLoan = New System.Windows.Forms.Button()
        Me.lbl_amount = New System.Windows.Forms.Label()
        Me.lbl_wertDollar = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_tickerName, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(678, 172)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lbl_tickerName
        '
        Me.lbl_tickerName.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_tickerName.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tickerName.Location = New System.Drawing.Point(5, 2)
        Me.lbl_tickerName.Name = "lbl_tickerName"
        Me.lbl_tickerName.Size = New System.Drawing.Size(254, 52)
        Me.lbl_tickerName.TabIndex = 1
        Me.lbl_tickerName.Text = "TICKER"
        Me.lbl_tickerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.89222!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.10778!))
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_wertDollar, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_moreLoan, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_reduceLoan, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_amount, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(5, 59)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(668, 108)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'btn_moreLoan
        '
        Me.btn_moreLoan.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_moreLoan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_moreLoan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_moreLoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_moreLoan.Location = New System.Drawing.Point(363, 3)
        Me.btn_moreLoan.Name = "btn_moreLoan"
        Me.btn_moreLoan.Size = New System.Drawing.Size(302, 46)
        Me.btn_moreLoan.TabIndex = 0
        Me.btn_moreLoan.Text = "+ Mehr Ausleihen"
        Me.btn_moreLoan.UseVisualStyleBackColor = False
        '
        'btn_reduceLoan
        '
        Me.btn_reduceLoan.BackColor = System.Drawing.Color.OrangeRed
        Me.btn_reduceLoan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_reduceLoan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_reduceLoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reduceLoan.Location = New System.Drawing.Point(363, 58)
        Me.btn_reduceLoan.Name = "btn_reduceLoan"
        Me.btn_reduceLoan.Size = New System.Drawing.Size(302, 47)
        Me.btn_reduceLoan.TabIndex = 1
        Me.btn_reduceLoan.Text = "- Rückzahlung"
        Me.btn_reduceLoan.UseVisualStyleBackColor = False
        '
        'lbl_amount
        '
        Me.lbl_amount.AutoSize = True
        Me.lbl_amount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_amount.Location = New System.Drawing.Point(3, 0)
        Me.lbl_amount.Name = "lbl_amount"
        Me.lbl_amount.Size = New System.Drawing.Size(354, 52)
        Me.lbl_amount.TabIndex = 4
        Me.lbl_amount.Text = "0000.00 XXX"
        Me.lbl_amount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_wertDollar
        '
        Me.lbl_wertDollar.AutoSize = True
        Me.lbl_wertDollar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_wertDollar.Location = New System.Drawing.Point(3, 55)
        Me.lbl_wertDollar.Name = "lbl_wertDollar"
        Me.lbl_wertDollar.Size = New System.Drawing.Size(354, 53)
        Me.lbl_wertDollar.TabIndex = 5
        Me.lbl_wertDollar.Text = "≈ $00000.00"
        Me.lbl_wertDollar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Vault_Darlehen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Vault_Darlehen"
        Me.Size = New System.Drawing.Size(678, 172)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_tickerName As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btn_moreLoan As Button
    Friend WithEvents btn_reduceLoan As Button
    Friend WithEvents lbl_amount As Label
    Friend WithEvents lbl_wertDollar As Label
End Class
