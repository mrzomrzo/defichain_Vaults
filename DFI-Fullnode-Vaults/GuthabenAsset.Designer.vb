<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuthabenAsset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GuthabenAsset))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_amount = New System.Windows.Forms.Label()
        Me.lbl_assetName = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.pb_swap = New System.Windows.Forms.PictureBox()
        Me.lbl_wert = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.pb_swap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_amount, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_assetName, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_wert, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(452, 35)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lbl_amount
        '
        Me.lbl_amount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_amount.Location = New System.Drawing.Point(95, 3)
        Me.lbl_amount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_amount.Name = "lbl_amount"
        Me.lbl_amount.Size = New System.Drawing.Size(160, 29)
        Me.lbl_amount.TabIndex = 1
        Me.lbl_amount.Text = "0.00"
        Me.lbl_amount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_assetName
        '
        Me.lbl_assetName.AutoSize = True
        Me.lbl_assetName.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_assetName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_assetName.Location = New System.Drawing.Point(5, 3)
        Me.lbl_assetName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_assetName.Name = "lbl_assetName"
        Me.lbl_assetName.Size = New System.Drawing.Size(53, 29)
        Me.lbl_assetName.TabIndex = 0
        Me.lbl_assetName.Text = "Ticker"
        Me.lbl_assetName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.pb_swap, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(387, 5)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(60, 25)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'pb_swap
        '
        Me.pb_swap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_swap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pb_swap.Image = CType(resources.GetObject("pb_swap.Image"), System.Drawing.Image)
        Me.pb_swap.Location = New System.Drawing.Point(4, 5)
        Me.pb_swap.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pb_swap.Name = "pb_swap"
        Me.pb_swap.Size = New System.Drawing.Size(52, 15)
        Me.pb_swap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_swap.TabIndex = 2
        Me.pb_swap.TabStop = False
        '
        'lbl_wert
        '
        Me.lbl_wert.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_wert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_wert.Location = New System.Drawing.Point(263, 3)
        Me.lbl_wert.Name = "lbl_wert"
        Me.lbl_wert.Size = New System.Drawing.Size(116, 29)
        Me.lbl_wert.TabIndex = 4
        Me.lbl_wert.Text = "$0.00"
        Me.lbl_wert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GuthabenAsset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "GuthabenAsset"
        Me.Size = New System.Drawing.Size(452, 35)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.pb_swap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_amount As Label
    Friend WithEvents lbl_assetName As Label
    Friend WithEvents pb_swap As PictureBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lbl_wert As Label
End Class
