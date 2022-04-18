<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vault_Sicherheiten
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
        Me.btn_addCollateral = New System.Windows.Forms.Button()
        Me.btn_removeCollateral = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_amount = New System.Windows.Forms.Label()
        Me.lbl_wertDollar = New System.Windows.Forms.Label()
        Me.lbl_prozentAnteil = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_tickerName, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_addCollateral, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_removeCollateral, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(5, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(636, 52)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lbl_tickerName
        '
        Me.lbl_tickerName.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_tickerName.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tickerName.Location = New System.Drawing.Point(3, 0)
        Me.lbl_tickerName.Name = "lbl_tickerName"
        Me.lbl_tickerName.Size = New System.Drawing.Size(254, 52)
        Me.lbl_tickerName.TabIndex = 0
        Me.lbl_tickerName.Text = "TICKER"
        Me.lbl_tickerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_addCollateral
        '
        Me.btn_addCollateral.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_addCollateral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_addCollateral.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addCollateral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_addCollateral.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addCollateral.Location = New System.Drawing.Point(519, 3)
        Me.btn_addCollateral.Name = "btn_addCollateral"
        Me.btn_addCollateral.Size = New System.Drawing.Size(54, 46)
        Me.btn_addCollateral.TabIndex = 1
        Me.btn_addCollateral.Text = "+"
        Me.btn_addCollateral.UseVisualStyleBackColor = False
        '
        'btn_removeCollateral
        '
        Me.btn_removeCollateral.BackColor = System.Drawing.Color.OrangeRed
        Me.btn_removeCollateral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_removeCollateral.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_removeCollateral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_removeCollateral.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_removeCollateral.Location = New System.Drawing.Point(579, 3)
        Me.btn_removeCollateral.Name = "btn_removeCollateral"
        Me.btn_removeCollateral.Size = New System.Drawing.Size(54, 46)
        Me.btn_removeCollateral.TabIndex = 2
        Me.btn_removeCollateral.Text = "-"
        Me.btn_removeCollateral.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(646, 138)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_prozentAnteil, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(5, 65)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(636, 68)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_amount, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_wertDollar, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(478, 62)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'lbl_amount
        '
        Me.lbl_amount.AutoSize = True
        Me.lbl_amount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_amount.Location = New System.Drawing.Point(3, 0)
        Me.lbl_amount.Name = "lbl_amount"
        Me.lbl_amount.Size = New System.Drawing.Size(472, 31)
        Me.lbl_amount.TabIndex = 0
        Me.lbl_amount.Text = "0000.00 XXX"
        Me.lbl_amount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_wertDollar
        '
        Me.lbl_wertDollar.AutoSize = True
        Me.lbl_wertDollar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_wertDollar.Location = New System.Drawing.Point(3, 31)
        Me.lbl_wertDollar.Name = "lbl_wertDollar"
        Me.lbl_wertDollar.Size = New System.Drawing.Size(472, 31)
        Me.lbl_wertDollar.TabIndex = 1
        Me.lbl_wertDollar.Text = "≈ $00000.00"
        Me.lbl_wertDollar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_prozentAnteil
        '
        Me.lbl_prozentAnteil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_prozentAnteil.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prozentAnteil.Location = New System.Drawing.Point(487, 0)
        Me.lbl_prozentAnteil.Name = "lbl_prozentAnteil"
        Me.lbl_prozentAnteil.Size = New System.Drawing.Size(146, 68)
        Me.lbl_prozentAnteil.TabIndex = 1
        Me.lbl_prozentAnteil.Text = "000%"
        Me.lbl_prozentAnteil.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Vault_Sicherheiten
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Name = "Vault_Sicherheiten"
        Me.Size = New System.Drawing.Size(646, 138)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_tickerName As Label
    Friend WithEvents btn_addCollateral As Button
    Friend WithEvents btn_removeCollateral As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lbl_amount As Label
    Friend WithEvents lbl_wertDollar As Label
    Friend WithEvents lbl_prozentAnteil As Label
End Class
