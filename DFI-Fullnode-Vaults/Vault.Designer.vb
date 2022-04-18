<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vault
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lnklbl_vaultID = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_ratio = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_loan = New System.Windows.Forms.Button()
        Me.lbl_loanValue = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_collateralValue = New System.Windows.Forms.Label()
        Me.btn_collateral = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 226.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lnklbl_vaultID, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_ratio, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_status, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(734, 332)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 25)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Collateral (USD):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 25)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Status:"
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Location = New System.Drawing.Point(235, 75)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(74, 25)
        Me.lbl_status.TabIndex = 10
        Me.lbl_status.Text = "Ready"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "VaulID:"
        '
        'lnklbl_vaultID
        '
        Me.lnklbl_vaultID.AutoSize = True
        Me.lnklbl_vaultID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklbl_vaultID.Location = New System.Drawing.Point(235, 3)
        Me.lnklbl_vaultID.Name = "lnklbl_vaultID"
        Me.lnklbl_vaultID.Size = New System.Drawing.Size(130, 29)
        Me.lnklbl_vaultID.TabIndex = 12
        Me.lnklbl_vaultID.TabStop = True
        Me.lnklbl_vaultID.Text = "LinkLabel1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Besicherungsquote:"
        '
        'lbl_ratio
        '
        Me.lbl_ratio.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_ratio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ratio.Location = New System.Drawing.Point(235, 123)
        Me.lbl_ratio.Name = "lbl_ratio"
        Me.lbl_ratio.Size = New System.Drawing.Size(219, 80)
        Me.lbl_ratio.TabIndex = 14
        Me.lbl_ratio.Text = "0%" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "next: 0%"
        Me.lbl_ratio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 25)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Loan (USD):"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.18725!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.81275!))
        Me.TableLayoutPanel3.Controls.Add(Me.btn_loan, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_loanValue, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(235, 209)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(493, 54)
        Me.TableLayoutPanel3.TabIndex = 18
        '
        'btn_loan
        '
        Me.btn_loan.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_loan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_loan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_loan.Location = New System.Drawing.Point(265, 3)
        Me.btn_loan.Name = "btn_loan"
        Me.btn_loan.Size = New System.Drawing.Size(225, 48)
        Me.btn_loan.TabIndex = 7
        Me.btn_loan.Text = "Darlehen"
        Me.btn_loan.UseVisualStyleBackColor = False
        '
        'lbl_loanValue
        '
        Me.lbl_loanValue.AutoSize = True
        Me.lbl_loanValue.Location = New System.Drawing.Point(3, 0)
        Me.lbl_loanValue.Name = "lbl_loanValue"
        Me.lbl_loanValue.Size = New System.Drawing.Size(66, 25)
        Me.lbl_loanValue.TabIndex = 6
        Me.lbl_loanValue.Text = "$0.00"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.58964!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.41036!))
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_collateralValue, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_collateral, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(235, 272)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(493, 54)
        Me.TableLayoutPanel2.TabIndex = 19
        '
        'lbl_collateralValue
        '
        Me.lbl_collateralValue.AutoSize = True
        Me.lbl_collateralValue.Location = New System.Drawing.Point(3, 0)
        Me.lbl_collateralValue.Name = "lbl_collateralValue"
        Me.lbl_collateralValue.Size = New System.Drawing.Size(66, 25)
        Me.lbl_collateralValue.TabIndex = 7
        Me.lbl_collateralValue.Text = "$0.00"
        '
        'btn_collateral
        '
        Me.btn_collateral.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_collateral.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_collateral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_collateral.Location = New System.Drawing.Point(262, 3)
        Me.btn_collateral.Name = "btn_collateral"
        Me.btn_collateral.Size = New System.Drawing.Size(228, 48)
        Me.btn_collateral.TabIndex = 8
        Me.btn_collateral.Text = "Sicherheiten"
        Me.btn_collateral.UseVisualStyleBackColor = False
        '
        'Vault
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Vault"
        Me.Size = New System.Drawing.Size(734, 332)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_status As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lnklbl_vaultID As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_ratio As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btn_loan As Button
    Friend WithEvents lbl_loanValue As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lbl_collateralValue As Label
    Friend WithEvents btn_collateral As Button
End Class
