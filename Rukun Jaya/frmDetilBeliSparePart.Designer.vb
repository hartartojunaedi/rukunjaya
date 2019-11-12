<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetilBeliSparePart
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
        Me.txtDiskon = New System.Windows.Forms.TextBox()
        Me.lblDiskon = New System.Windows.Forms.Label()
        Me.lblNamaToko = New System.Windows.Forms.Label()
        Me.lblTglTransaksi = New System.Windows.Forms.Label()
        Me.dtpTanggalTransaksi = New System.Windows.Forms.DateTimePicker()
        Me.txtNamaToko = New System.Windows.Forms.TextBox()
        Me.txtNonota = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvdetilpembelian = New System.Windows.Forms.DataGridView()
        Me.KodeSparepart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaSparepart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hapus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.lbljumlah = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtKodebarang = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblgrandtotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbljumlahitem = New System.Windows.Forms.Label()
        Me.nmJumlah = New System.Windows.Forms.NumericUpDown()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        CType(Me.dgvdetilpembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmJumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDiskon
        '
        Me.txtDiskon.Location = New System.Drawing.Point(364, 322)
        Me.txtDiskon.Name = "txtDiskon"
        Me.txtDiskon.Size = New System.Drawing.Size(77, 20)
        Me.txtDiskon.TabIndex = 23
        Me.txtDiskon.Text = "0"
        '
        'lblDiskon
        '
        Me.lblDiskon.AutoSize = True
        Me.lblDiskon.Location = New System.Drawing.Point(318, 325)
        Me.lblDiskon.Name = "lblDiskon"
        Me.lblDiskon.Size = New System.Drawing.Size(40, 13)
        Me.lblDiskon.TabIndex = 22
        Me.lblDiskon.Text = "Diskon"
        '
        'lblNamaToko
        '
        Me.lblNamaToko.AutoSize = True
        Me.lblNamaToko.Location = New System.Drawing.Point(41, 67)
        Me.lblNamaToko.Name = "lblNamaToko"
        Me.lblNamaToko.Size = New System.Drawing.Size(63, 13)
        Me.lblNamaToko.TabIndex = 21
        Me.lblNamaToko.Text = "Nama Toko"
        '
        'lblTglTransaksi
        '
        Me.lblTglTransaksi.AutoSize = True
        Me.lblTglTransaksi.Location = New System.Drawing.Point(9, 44)
        Me.lblTglTransaksi.Name = "lblTglTransaksi"
        Me.lblTglTransaksi.Size = New System.Drawing.Size(95, 13)
        Me.lblTglTransaksi.TabIndex = 20
        Me.lblTglTransaksi.Text = "Tanggal Transaksi"
        '
        'dtpTanggalTransaksi
        '
        Me.dtpTanggalTransaksi.CustomFormat = "dd-MM-yyyy"
        Me.dtpTanggalTransaksi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTanggalTransaksi.Location = New System.Drawing.Point(110, 38)
        Me.dtpTanggalTransaksi.Name = "dtpTanggalTransaksi"
        Me.dtpTanggalTransaksi.Size = New System.Drawing.Size(84, 20)
        Me.dtpTanggalTransaksi.TabIndex = 2
        '
        'txtNamaToko
        '
        Me.txtNamaToko.Location = New System.Drawing.Point(110, 64)
        Me.txtNamaToko.Name = "txtNamaToko"
        Me.txtNamaToko.Size = New System.Drawing.Size(130, 20)
        Me.txtNamaToko.TabIndex = 3
        '
        'txtNonota
        '
        Me.txtNonota.Location = New System.Drawing.Point(110, 12)
        Me.txtNonota.Name = "txtNonota"
        Me.txtNonota.Size = New System.Drawing.Size(114, 20)
        Me.txtNonota.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "No. Nota"
        '
        'dgvdetilpembelian
        '
        Me.dgvdetilpembelian.AllowUserToAddRows = False
        Me.dgvdetilpembelian.AllowUserToDeleteRows = False
        Me.dgvdetilpembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetilpembelian.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeSparepart, Me.NamaSparepart, Me.Jumlah, Me.Harga, Me.Subtotal, Me.Hapus})
        Me.dgvdetilpembelian.Location = New System.Drawing.Point(25, 123)
        Me.dgvdetilpembelian.Name = "dgvdetilpembelian"
        Me.dgvdetilpembelian.ReadOnly = True
        Me.dgvdetilpembelian.Size = New System.Drawing.Size(583, 158)
        Me.dgvdetilpembelian.TabIndex = 26
        '
        'KodeSparepart
        '
        Me.KodeSparepart.DataPropertyName = "KodeSparepart"
        Me.KodeSparepart.HeaderText = "Kode Sparepart"
        Me.KodeSparepart.Name = "KodeSparepart"
        Me.KodeSparepart.ReadOnly = True
        Me.KodeSparepart.Visible = False
        '
        'NamaSparepart
        '
        Me.NamaSparepart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NamaSparepart.DataPropertyName = "namasparepart"
        Me.NamaSparepart.HeaderText = "Spare Part"
        Me.NamaSparepart.Name = "NamaSparepart"
        Me.NamaSparepart.ReadOnly = True
        '
        'Jumlah
        '
        Me.Jumlah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Jumlah.DataPropertyName = "jumlah"
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.ReadOnly = True
        Me.Jumlah.Width = 65
        '
        'Harga
        '
        Me.Harga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Harga.DataPropertyName = "harga"
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Harga.DefaultCellStyle = DataGridViewCellStyle1
        Me.Harga.HeaderText = "Harga"
        Me.Harga.Name = "Harga"
        Me.Harga.ReadOnly = True
        '
        'Subtotal
        '
        Me.Subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Subtotal.DataPropertyName = "total"
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Subtotal.DefaultCellStyle = DataGridViewCellStyle2
        Me.Subtotal.HeaderText = "Total"
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        '
        'Hapus
        '
        Me.Hapus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Hapus.HeaderText = "Hapus"
        Me.Hapus.Name = "Hapus"
        Me.Hapus.ReadOnly = True
        Me.Hapus.Text = "Hapus Data"
        Me.Hapus.UseColumnTextForButtonValue = True
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(439, 65)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(116, 20)
        Me.txtHarga.TabIndex = 6
        '
        'lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Location = New System.Drawing.Point(397, 68)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(36, 13)
        Me.lblHarga.TabIndex = 37
        Me.lblHarga.Text = "Harga"
        '
        'lbljumlah
        '
        Me.lbljumlah.AutoSize = True
        Me.lbljumlah.Location = New System.Drawing.Point(393, 41)
        Me.lbljumlah.Name = "lbljumlah"
        Me.lbljumlah.Size = New System.Drawing.Size(40, 13)
        Me.lbljumlah.TabIndex = 34
        Me.lbljumlah.Text = "Jumlah"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(364, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Nama Barang"
        '
        'txtKodebarang
        '
        Me.txtKodebarang.Location = New System.Drawing.Point(439, 12)
        Me.txtKodebarang.Name = "txtKodebarang"
        Me.txtKodebarang.ReadOnly = True
        Me.txtKodebarang.Size = New System.Drawing.Size(133, 20)
        Me.txtKodebarang.TabIndex = 32
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(578, 12)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(30, 20)
        Me.btnBrowse.TabIndex = 4
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(327, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Total"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(364, 300)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(13, 13)
        Me.lblTotal.TabIndex = 40
        Me.lblTotal.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(252, 348)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Total Setelah Diskon"
        '
        'lblgrandtotal
        '
        Me.lblgrandtotal.AutoSize = True
        Me.lblgrandtotal.Location = New System.Drawing.Point(364, 348)
        Me.lblgrandtotal.Name = "lblgrandtotal"
        Me.lblgrandtotal.Size = New System.Drawing.Size(13, 13)
        Me.lblgrandtotal.TabIndex = 42
        Me.lblgrandtotal.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(482, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Jumlah Item :"
        '
        'lbljumlahitem
        '
        Me.lbljumlahitem.AutoSize = True
        Me.lbljumlahitem.Location = New System.Drawing.Point(551, 300)
        Me.lbljumlahitem.Name = "lbljumlahitem"
        Me.lbljumlahitem.Size = New System.Drawing.Size(13, 13)
        Me.lbljumlahitem.TabIndex = 44
        Me.lbljumlahitem.Text = "0"
        '
        'nmJumlah
        '
        Me.nmJumlah.DecimalPlaces = 1
        Me.nmJumlah.Location = New System.Drawing.Point(439, 39)
        Me.nmJumlah.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nmJumlah.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmJumlah.Name = "nmJumlah"
        Me.nmJumlah.Size = New System.Drawing.Size(60, 20)
        Me.nmJumlah.TabIndex = 5
        Me.nmJumlah.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(439, 88)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(88, 29)
        Me.btnTambah.TabIndex = 7
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.RukunJaya.My.Resources.Resources.cancelbr
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(447, 374)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 27)
        Me.btnCancel.TabIndex = 25
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSimpan.Location = New System.Drawing.Point(355, 374)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(78, 27)
        Me.BtnSimpan.TabIndex = 24
        Me.BtnSimpan.Text = "&Simpan"
        Me.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'frmDetilBeliSparePart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 422)
        Me.Controls.Add(Me.lbljumlahitem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblgrandtotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.lblHarga)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.nmJumlah)
        Me.Controls.Add(Me.lbljumlah)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtKodebarang)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.dgvdetilpembelian)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.txtDiskon)
        Me.Controls.Add(Me.lblDiskon)
        Me.Controls.Add(Me.lblNamaToko)
        Me.Controls.Add(Me.lblTglTransaksi)
        Me.Controls.Add(Me.dtpTanggalTransaksi)
        Me.Controls.Add(Me.txtNamaToko)
        Me.Controls.Add(Me.txtNonota)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetilBeliSparePart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Detil Beli SparePart :."
        CType(Me.dgvdetilpembelian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmJumlah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents txtDiskon As System.Windows.Forms.TextBox
    Friend WithEvents lblDiskon As System.Windows.Forms.Label
    Friend WithEvents lblNamaToko As System.Windows.Forms.Label
    Friend WithEvents lblTglTransaksi As System.Windows.Forms.Label
    Friend WithEvents dtpTanggalTransaksi As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNamaToko As System.Windows.Forms.TextBox
    Friend WithEvents txtNonota As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvdetilpembelian As System.Windows.Forms.DataGridView
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents lblHarga As System.Windows.Forms.Label
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents lbljumlah As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtKodebarang As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblgrandtotal As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbljumlahitem As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents nmJumlah As System.Windows.Forms.NumericUpDown
    Friend WithEvents KodeSparepart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaSparepart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Harga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hapus As System.Windows.Forms.DataGridViewButtonColumn
End Class
