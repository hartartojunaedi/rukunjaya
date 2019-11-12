<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetilMutasiMasuk
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
        Me.lbljumlahitem = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.nmJumlah = New System.Windows.Forms.NumericUpDown()
        Me.lbljumlah = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtKodebarang = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.dgvdetilpembelian = New System.Windows.Forms.DataGridView()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.lblNamaToko = New System.Windows.Forms.Label()
        Me.lblTglTransaksi = New System.Windows.Forms.Label()
        Me.dtpTanggalTransaksi = New System.Windows.Forms.DateTimePicker()
        Me.txtNamaToko = New System.Windows.Forms.TextBox()
        Me.txtNonota = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KodeSparepart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaSparepart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hapus = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.nmJumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvdetilpembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbljumlahitem
        '
        Me.lbljumlahitem.AutoSize = True
        Me.lbljumlahitem.Location = New System.Drawing.Point(485, 267)
        Me.lbljumlahitem.Name = "lbljumlahitem"
        Me.lbljumlahitem.Size = New System.Drawing.Size(13, 13)
        Me.lbljumlahitem.TabIndex = 69
        Me.lbljumlahitem.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(373, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Jumlah Item :"
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(309, 53)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(88, 29)
        Me.btnTambah.TabIndex = 51
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'nmJumlah
        '
        Me.nmJumlah.DecimalPlaces = 1
        Me.nmJumlah.Location = New System.Drawing.Point(309, 28)
        Me.nmJumlah.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nmJumlah.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmJumlah.Name = "nmJumlah"
        Me.nmJumlah.Size = New System.Drawing.Size(60, 20)
        Me.nmJumlah.TabIndex = 49
        Me.nmJumlah.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbljumlah
        '
        Me.lbljumlah.AutoSize = True
        Me.lbljumlah.Location = New System.Drawing.Point(263, 30)
        Me.lbljumlah.Name = "lbljumlah"
        Me.lbljumlah.Size = New System.Drawing.Size(40, 13)
        Me.lbljumlah.TabIndex = 62
        Me.lbljumlah.Text = "Jumlah"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(234, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Nama Barang"
        '
        'txtKodebarang
        '
        Me.txtKodebarang.Location = New System.Drawing.Point(309, 1)
        Me.txtKodebarang.Name = "txtKodebarang"
        Me.txtKodebarang.ReadOnly = True
        Me.txtKodebarang.Size = New System.Drawing.Size(133, 20)
        Me.txtKodebarang.TabIndex = 60
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(448, 1)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(30, 20)
        Me.btnBrowse.TabIndex = 48
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'dgvdetilpembelian
        '
        Me.dgvdetilpembelian.AllowUserToAddRows = False
        Me.dgvdetilpembelian.AllowUserToDeleteRows = False
        Me.dgvdetilpembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetilpembelian.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeSparepart, Me.NamaSparepart, Me.jumlah, Me.Hapus})
        Me.dgvdetilpembelian.Location = New System.Drawing.Point(19, 93)
        Me.dgvdetilpembelian.Name = "dgvdetilpembelian"
        Me.dgvdetilpembelian.ReadOnly = True
        Me.dgvdetilpembelian.Size = New System.Drawing.Size(479, 158)
        Me.dgvdetilpembelian.TabIndex = 59
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.RukunJaya.My.Resources.Resources.cancelbr
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(267, 267)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 27)
        Me.btnCancel.TabIndex = 58
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSimpan.Location = New System.Drawing.Point(175, 267)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(78, 27)
        Me.BtnSimpan.TabIndex = 57
        Me.BtnSimpan.Text = "&Simpan"
        Me.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'lblNamaToko
        '
        Me.lblNamaToko.AutoSize = True
        Me.lblNamaToko.Location = New System.Drawing.Point(37, 61)
        Me.lblNamaToko.Name = "lblNamaToko"
        Me.lblNamaToko.Size = New System.Drawing.Size(63, 13)
        Me.lblNamaToko.TabIndex = 54
        Me.lblNamaToko.Text = "Nama Toko"
        '
        'lblTglTransaksi
        '
        Me.lblTglTransaksi.AutoSize = True
        Me.lblTglTransaksi.Location = New System.Drawing.Point(5, 38)
        Me.lblTglTransaksi.Name = "lblTglTransaksi"
        Me.lblTglTransaksi.Size = New System.Drawing.Size(95, 13)
        Me.lblTglTransaksi.TabIndex = 53
        Me.lblTglTransaksi.Text = "Tanggal Transaksi"
        '
        'dtpTanggalTransaksi
        '
        Me.dtpTanggalTransaksi.CustomFormat = "dd-MM-yyyy"
        Me.dtpTanggalTransaksi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTanggalTransaksi.Location = New System.Drawing.Point(106, 32)
        Me.dtpTanggalTransaksi.Name = "dtpTanggalTransaksi"
        Me.dtpTanggalTransaksi.Size = New System.Drawing.Size(84, 20)
        Me.dtpTanggalTransaksi.TabIndex = 46
        '
        'txtNamaToko
        '
        Me.txtNamaToko.Location = New System.Drawing.Point(106, 58)
        Me.txtNamaToko.Name = "txtNamaToko"
        Me.txtNamaToko.Size = New System.Drawing.Size(130, 20)
        Me.txtNamaToko.TabIndex = 47
        '
        'txtNonota
        '
        Me.txtNonota.Location = New System.Drawing.Point(106, 6)
        Me.txtNonota.Name = "txtNonota"
        Me.txtNonota.Size = New System.Drawing.Size(114, 20)
        Me.txtNonota.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "No. Nota"
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
        'jumlah
        '
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.ReadOnly = True
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
        'frmDetilMutasiMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 304)
        Me.Controls.Add(Me.lbljumlahitem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.nmJumlah)
        Me.Controls.Add(Me.lbljumlah)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtKodebarang)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.dgvdetilpembelian)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.lblNamaToko)
        Me.Controls.Add(Me.lblTglTransaksi)
        Me.Controls.Add(Me.dtpTanggalTransaksi)
        Me.Controls.Add(Me.txtNamaToko)
        Me.Controls.Add(Me.txtNonota)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetilMutasiMasuk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Detail Mutasi Masuk :."
        CType(Me.nmJumlah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvdetilpembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbljumlahitem As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents nmJumlah As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbljumlah As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtKodebarang As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents dgvdetilpembelian As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents lblNamaToko As System.Windows.Forms.Label
    Friend WithEvents lblTglTransaksi As System.Windows.Forms.Label
    Friend WithEvents dtpTanggalTransaksi As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNamaToko As System.Windows.Forms.TextBox
    Friend WithEvents txtNonota As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents KodeSparepart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaSparepart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hapus As System.Windows.Forms.DataGridViewButtonColumn
End Class
