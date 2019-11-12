<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCariSparepart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtSearchKode = New System.Windows.Forms.TextBox()
        Me.LblNamaSP = New System.Windows.Forms.Label()
        Me.txtSearchNamaSP = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.dgvCariInventory = New System.Windows.Forms.DataGridView()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.kodeSparepart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaSparePart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaTerakhir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvCariInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearchKode
        '
        Me.txtSearchKode.Location = New System.Drawing.Point(586, 11)
        Me.txtSearchKode.Name = "txtSearchKode"
        Me.txtSearchKode.Size = New System.Drawing.Size(104, 20)
        Me.txtSearchKode.TabIndex = 6
        '
        'LblNamaSP
        '
        Me.LblNamaSP.AutoSize = True
        Me.LblNamaSP.Location = New System.Drawing.Point(471, 39)
        Me.LblNamaSP.Name = "LblNamaSP"
        Me.LblNamaSP.Size = New System.Drawing.Size(109, 13)
        Me.LblNamaSP.TabIndex = 10
        Me.LblNamaSP.Text = "Cari Nama Spare Part"
        '
        'txtSearchNamaSP
        '
        Me.txtSearchNamaSP.Location = New System.Drawing.Point(586, 36)
        Me.txtSearchNamaSP.Name = "txtSearchNamaSP"
        Me.txtSearchNamaSP.Size = New System.Drawing.Size(104, 20)
        Me.txtSearchNamaSP.TabIndex = 7
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(527, 14)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(53, 13)
        Me.lblSearch.TabIndex = 8
        Me.lblSearch.Text = "Cari Kode"
        '
        'dgvCariInventory
        '
        Me.dgvCariInventory.AllowUserToAddRows = False
        Me.dgvCariInventory.AllowUserToDeleteRows = False
        Me.dgvCariInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCariInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodeSparepart, Me.NamaSparePart, Me.HargaTerakhir, Me.Stock, Me.Keterangan})
        Me.dgvCariInventory.Location = New System.Drawing.Point(12, 62)
        Me.dgvCariInventory.Name = "dgvCariInventory"
        Me.dgvCariInventory.ReadOnly = True
        Me.dgvCariInventory.Size = New System.Drawing.Size(752, 232)
        Me.dgvCariInventory.TabIndex = 9
        '
        'btnCari
        '
        Me.btnCari.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCari.Location = New System.Drawing.Point(697, 12)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(66, 40)
        Me.btnCari.TabIndex = 11
        Me.btnCari.Text = "Cari"
        Me.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'kodeSparepart
        '
        Me.kodeSparepart.DataPropertyName = "KodeSparepart"
        Me.kodeSparepart.HeaderText = "Kode SparePart"
        Me.kodeSparepart.Name = "kodeSparepart"
        Me.kodeSparepart.ReadOnly = True
        '
        'NamaSparePart
        '
        Me.NamaSparePart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NamaSparePart.DataPropertyName = "NamaSparePart"
        Me.NamaSparePart.HeaderText = "Nama Spare Part"
        Me.NamaSparePart.Name = "NamaSparePart"
        Me.NamaSparePart.ReadOnly = True
        '
        'HargaTerakhir
        '
        Me.HargaTerakhir.DataPropertyName = "HargaTerakhir"
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.HargaTerakhir.DefaultCellStyle = DataGridViewCellStyle1
        Me.HargaTerakhir.HeaderText = "Harga Terakhir"
        Me.HargaTerakhir.Name = "HargaTerakhir"
        Me.HargaTerakhir.ReadOnly = True
        Me.HargaTerakhir.Visible = False
        '
        'Stock
        '
        Me.Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Stock.DataPropertyName = "Stock"
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        Me.Stock.ReadOnly = True
        Me.Stock.Width = 60
        '
        'Keterangan
        '
        Me.Keterangan.DataPropertyName = "Keterangan"
        Me.Keterangan.HeaderText = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.ReadOnly = True
        '
        'frmCariSparepart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 307)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtSearchKode)
        Me.Controls.Add(Me.LblNamaSP)
        Me.Controls.Add(Me.txtSearchNamaSP)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.dgvCariInventory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCariSparepart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Cari Spare Part :."
        CType(Me.dgvCariInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearchKode As System.Windows.Forms.TextBox
    Friend WithEvents LblNamaSP As System.Windows.Forms.Label
    Friend WithEvents txtSearchNamaSP As System.Windows.Forms.TextBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents dgvCariInventory As System.Windows.Forms.DataGridView
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents kodeSparepart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaSparePart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargaTerakhir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
