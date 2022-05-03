<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FutureSwap_Erstellen
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
        Me.cmb_lockedAsset = New System.Windows.Forms.ComboBox()
        Me.txt_lockedAmount = New System.Windows.Forms.TextBox()
        Me.cmb_returnAsset = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_assetGuthaben = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_maxAmount = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_createFutureSwap = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel11.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmb_lockedAsset
        '
        Me.cmb_lockedAsset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_lockedAsset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_lockedAsset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_lockedAsset.FormattingEnabled = True
        Me.cmb_lockedAsset.Location = New System.Drawing.Point(419, 3)
        Me.cmb_lockedAsset.Name = "cmb_lockedAsset"
        Me.cmb_lockedAsset.Size = New System.Drawing.Size(224, 41)
        Me.cmb_lockedAsset.TabIndex = 1
        '
        'txt_lockedAmount
        '
        Me.txt_lockedAmount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_lockedAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lockedAmount.Location = New System.Drawing.Point(3, 3)
        Me.txt_lockedAmount.Name = "txt_lockedAmount"
        Me.txt_lockedAmount.Size = New System.Drawing.Size(410, 40)
        Me.txt_lockedAmount.TabIndex = 2
        '
        'cmb_returnAsset
        '
        Me.cmb_returnAsset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmb_returnAsset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_returnAsset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_returnAsset.FormattingEnabled = True
        Me.cmb_returnAsset.Location = New System.Drawing.Point(3, 3)
        Me.cmb_returnAsset.Name = "cmb_returnAsset"
        Me.cmb_returnAsset.Size = New System.Drawing.Size(260, 41)
        Me.cmb_returnAsset.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(652, 148)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Asset to Locked"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel11, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_lockedAmount, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_lockedAsset, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_maxAmount, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 34)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(646, 111)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel11
        '
        Me.TableLayoutPanel11.ColumnCount = 2
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168.0!))
        Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Controls.Add(Me.lbl_assetGuthaben, 1, 0)
        Me.TableLayoutPanel11.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel11.Location = New System.Drawing.Point(4, 64)
        Me.TableLayoutPanel11.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
        Me.TableLayoutPanel11.RowCount = 1
        Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel11.Size = New System.Drawing.Size(408, 43)
        Me.TableLayoutPanel11.TabIndex = 13
        '
        'lbl_assetGuthaben
        '
        Me.lbl_assetGuthaben.AutoSize = True
        Me.lbl_assetGuthaben.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_assetGuthaben.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_assetGuthaben.Location = New System.Drawing.Point(172, 0)
        Me.lbl_assetGuthaben.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_assetGuthaben.Name = "lbl_assetGuthaben"
        Me.lbl_assetGuthaben.Size = New System.Drawing.Size(232, 43)
        Me.lbl_assetGuthaben.TabIndex = 12
        Me.lbl_assetGuthaben.Text = "0.00000000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 43)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Guthaben:"
        '
        'btn_maxAmount
        '
        Me.btn_maxAmount.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_maxAmount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_maxAmount.Location = New System.Drawing.Point(419, 63)
        Me.btn_maxAmount.Name = "btn_maxAmount"
        Me.btn_maxAmount.Size = New System.Drawing.Size(102, 41)
        Me.btn_maxAmount.TabIndex = 3
        Me.btn_maxAmount.Text = "MAX"
        Me.btn_maxAmount.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel4)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(699, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(272, 148)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Return SwapAsset"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.cmb_returnAsset, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 34)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(266, 111)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'btn_createFutureSwap
        '
        Me.btn_createFutureSwap.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_createFutureSwap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_createFutureSwap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_createFutureSwap.Enabled = False
        Me.btn_createFutureSwap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_createFutureSwap.Location = New System.Drawing.Point(5, 167)
        Me.btn_createFutureSwap.Name = "btn_createFutureSwap"
        Me.btn_createFutureSwap.Size = New System.Drawing.Size(1078, 64)
        Me.btn_createFutureSwap.TabIndex = 6
        Me.btn_createFutureSwap.Text = "Erstelle FutureSwap"
        Me.btn_createFutureSwap.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 658.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 278.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox2, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_cancel, 4, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(5, 5)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1078, 154)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.Red
        Me.btn_cancel.Location = New System.Drawing.Point(1001, 3)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(74, 48)
        Me.btn_cancel.TabIndex = 6
        Me.btn_cancel.Text = "X"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_createFutureSwap, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1088, 236)
        Me.TableLayoutPanel3.TabIndex = 8
        '
        'FutureSwap_Erstellen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Name = "FutureSwap_Erstellen"
        Me.Size = New System.Drawing.Size(1088, 236)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel11.ResumeLayout(False)
        Me.TableLayoutPanel11.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmb_lockedAsset As ComboBox
    Friend WithEvents txt_lockedAmount As TextBox
    Friend WithEvents cmb_returnAsset As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_createFutureSwap As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_maxAmount As Button
    Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
    Friend WithEvents lbl_assetGuthaben As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
End Class
