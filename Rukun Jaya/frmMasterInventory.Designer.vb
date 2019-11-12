<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterInventory
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvMasterInventory = New System.Windows.Forms.DataGridView()
        Me.kodeSparepart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KartuStok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaSparePart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaTerakhir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Update = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearchNamaSP = New System.Windows.Forms.TextBox()
        Me.LblNamaSP = New System.Windows.Forms.Label()
        Me.txtSearchKode = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btncari = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.dgvMasterInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMasterInventory
        '
        Me.dgvMasterInventory.AllowUserToAddRows = False
        Me.dgvMasterInventory.AllowUserToDeleteRows = False
        Me.dgvMasterInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMasterInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodeSparepart, Me.KartuStok, Me.NamaSparePart, Me.HargaTerakhir, Me.Stock, Me.Keterangan, Me.Update, Me.Column1})
        Me.dgvMasterInventory.Location = New System.Drawing.Point(12, 52)
        Me.dgvMasterInventory.Name = "dgvMasterInventory"
        Me.dgvMasterInventory.ReadOnly = True
        Me.dgvMasterInventory.Size = New System.Drawing.Size(752, 232)
        Me.dgvMasterInventory.TabIndex = 3
        '
        'kodeSparepart
        '
        Me.kodeSparepart.DataPropertyName = "KodeSparepart"
        Me.kodeSparepart.HeaderText = "Kode SparePart"
        Me.kodeSparepart.Name = "kodeSparepart"
        Me.kodeSparepart.ReadOnly = True
        '
        'KartuStok
        '
        Me.KartuStok.DataPropertyName = "kartustok"
        Me.KartuStok.HeaderText = "Kartu Stok"
        Me.KartuStok.Name = "KartuStok"
        Me.KartuStok.ReadOnly = True
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = "0"
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.Stock.DefaultCellStyle = DataGridViewCellStyle2
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
        'Update
        '
        Me.Update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Update.HeaderText = "Ubah Data"
        Me.Update.Name = "Update"
        Me.Update.ReadOnly = True
        Me.Update.Text = "Ubah"
        Me.Update.UseColumnTextForButtonValue = True
        Me.Update.Width = 59
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Hapus Data"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Text = "Hapus"
        Me.Column1.UseColumnTextForButtonValue = True
        Me.Column1.Width = 63
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(12, 299)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(80, 29)
        Me.btnTambah.TabIndex = 4
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(93, 15)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(53, 13)
        Me.lblSearch.TabIndex = 2
        Me.lblSearch.Text = "Cari Kode"
        '
        'txtSearchNamaSP
        '
        Me.txtSearchNamaSP.Location = New System.Drawing.Point(381, 12)
        Me.txtSearchNamaSP.Name = "txtSearchNamaSP"
        Me.txtSearchNamaSP.Size = New System.Drawing.Size(104, 20)
        Me.txtSearchNamaSP.TabIndex = 2
        '
        'LblNamaSP
        '
        Me.LblNamaSP.AutoSize = True
        Me.LblNamaSP.Location = New System.Drawing.Point(266, 15)
        Me.LblNamaSP.Name = "LblNamaSP"
        Me.LblNamaSP.Size = New System.Drawing.Size(109, 13)
        Me.LblNamaSP.TabIndex = 4
        Me.LblNamaSP.Text = "Cari Nama Spare Part"
        '
        'txtSearchKode
        '
        Me.txtSearchKode.Location = New System.Drawing.Point(152, 12)
        Me.txtSearchKode.Name = "txtSearchKode"
        Me.txtSearchKode.Size = New System.Drawing.Size(104, 20)
        Me.txtSearchKode.TabIndex = 1
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "xls"
        Me.SaveFileDialog1.Filter = """Excell File|.xls|All Files|*.*"""
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(185, 299)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 18
        Me.TextBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.Image = Global.RukunJaya.My.Resources.Resources.xls
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(98, 299)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 29)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "&Excell"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btncari
        '
        Me.btncari.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btncari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncari.Location = New System.Drawing.Point(676, 7)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(80, 29)
        Me.btncari.TabIndex = 5
        Me.btncari.Text = "&Filter"
        Me.btncari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncari.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(491, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Kartu Stok"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(554, 12)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(104, 20)
        Me.TextBox2.TabIndex = 19
        '
        'frmMasterInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 336)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.txtSearchKode)
        Me.Controls.Add(Me.LblNamaSP)
        Me.Controls.Add(Me.txtSearchNamaSP)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.dgvMasterInventory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMasterInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Master Inventory :."
        CType(Me.dgvMasterInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvMasterInventory As System.Windows.Forms.DataGridView
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearchNamaSP As System.Windows.Forms.TextBox
    Friend WithEvents LblNamaSP As System.Windows.Forms.Label
    Friend WithEvents txtSearchKode As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents kodeSparepart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KartuStok As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaSparePart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargaTerakhir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Update As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
End Class
