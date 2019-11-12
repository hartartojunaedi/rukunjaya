<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperationalKendaraan
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmbKendaraan = New System.Windows.Forms.ComboBox()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpToTglTransaksi = New System.Windows.Forms.DateTimePicker()
        Me.dtpFromTglTransaksi = New System.Windows.Forms.DateTimePicker()
        Me.lblCariTanggalTransaksi = New System.Windows.Forms.Label()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.dgvBiayaOperationalKendaraan = New System.Windows.Forms.DataGridView()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.lblTotalBiaya = New System.Windows.Forms.Label()
        Me.lblCaptionTotalBiaya = New System.Windows.Forms.Label()
        Me.lblJumlahData = New System.Windows.Forms.Label()
        Me.lblCaptionJumlahData = New System.Windows.Forms.Label()
        Me.txtKodeTransaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTanggalTransaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtnopol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtKeterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtJumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnUbah = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnhapus = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvBiayaOperationalKendaraan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbKendaraan
        '
        Me.cmbKendaraan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbKendaraan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbKendaraan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKendaraan.FormattingEnabled = True
        Me.cmbKendaraan.Location = New System.Drawing.Point(182, 38)
        Me.cmbKendaraan.Name = "cmbKendaraan"
        Me.cmbKendaraan.Size = New System.Drawing.Size(126, 21)
        Me.cmbKendaraan.TabIndex = 35
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Location = New System.Drawing.Point(49, 38)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(41, 13)
        Me.lblJenis.TabIndex = 39
        Me.lblJenis.Text = "Nopol :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(274, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "-"
        '
        'dtpToTglTransaksi
        '
        Me.dtpToTglTransaksi.CustomFormat = "dd-MM-yyyy"
        Me.dtpToTglTransaksi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpToTglTransaksi.Location = New System.Drawing.Point(290, 12)
        Me.dtpToTglTransaksi.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtpToTglTransaksi.Name = "dtpToTglTransaksi"
        Me.dtpToTglTransaksi.Size = New System.Drawing.Size(86, 20)
        Me.dtpToTglTransaksi.TabIndex = 34
        '
        'dtpFromTglTransaksi
        '
        Me.dtpFromTglTransaksi.CustomFormat = "dd-MM-yyyy"
        Me.dtpFromTglTransaksi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFromTglTransaksi.Location = New System.Drawing.Point(182, 12)
        Me.dtpFromTglTransaksi.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtpFromTglTransaksi.Name = "dtpFromTglTransaksi"
        Me.dtpFromTglTransaksi.Size = New System.Drawing.Size(86, 20)
        Me.dtpFromTglTransaksi.TabIndex = 33
        '
        'lblCariTanggalTransaksi
        '
        Me.lblCariTanggalTransaksi.AutoSize = True
        Me.lblCariTanggalTransaksi.Location = New System.Drawing.Point(49, 15)
        Me.lblCariTanggalTransaksi.Name = "lblCariTanggalTransaksi"
        Me.lblCariTanggalTransaksi.Size = New System.Drawing.Size(122, 13)
        Me.lblCariTanggalTransaksi.TabIndex = 37
        Me.lblCariTanggalTransaksi.Text = "Cari Tanggal Transaksi :"
        '
        'btnFilter
        '
        Me.btnFilter.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFilter.Location = New System.Drawing.Point(418, 30)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(80, 29)
        Me.btnFilter.TabIndex = 36
        Me.btnFilter.Text = "&Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'dgvBiayaOperationalKendaraan
        '
        Me.dgvBiayaOperationalKendaraan.AllowUserToAddRows = False
        Me.dgvBiayaOperationalKendaraan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBiayaOperationalKendaraan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txtKodeTransaksi, Me.txtTanggalTransaksi, Me.txtnopol, Me.txtKeterangan, Me.txtHarga, Me.txtJumlah, Me.SubTotal, Me.btnUbah, Me.btnhapus})
        Me.dgvBiayaOperationalKendaraan.Location = New System.Drawing.Point(12, 65)
        Me.dgvBiayaOperationalKendaraan.Name = "dgvBiayaOperationalKendaraan"
        Me.dgvBiayaOperationalKendaraan.Size = New System.Drawing.Size(841, 181)
        Me.dgvBiayaOperationalKendaraan.TabIndex = 40
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(12, 252)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(80, 29)
        Me.btnTambah.TabIndex = 41
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'lblTotalBiaya
        '
        Me.lblTotalBiaya.Location = New System.Drawing.Point(515, 260)
        Me.lblTotalBiaya.Name = "lblTotalBiaya"
        Me.lblTotalBiaya.Size = New System.Drawing.Size(126, 13)
        Me.lblTotalBiaya.TabIndex = 45
        Me.lblTotalBiaya.Text = "0"
        Me.lblTotalBiaya.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCaptionTotalBiaya
        '
        Me.lblCaptionTotalBiaya.AutoSize = True
        Me.lblCaptionTotalBiaya.Location = New System.Drawing.Point(443, 260)
        Me.lblCaptionTotalBiaya.Name = "lblCaptionTotalBiaya"
        Me.lblCaptionTotalBiaya.Size = New System.Drawing.Size(66, 13)
        Me.lblCaptionTotalBiaya.TabIndex = 44
        Me.lblCaptionTotalBiaya.Text = "Total Biaya :"
        '
        'lblJumlahData
        '
        Me.lblJumlahData.Location = New System.Drawing.Point(386, 260)
        Me.lblJumlahData.Name = "lblJumlahData"
        Me.lblJumlahData.Size = New System.Drawing.Size(39, 13)
        Me.lblJumlahData.TabIndex = 43
        Me.lblJumlahData.Text = "0"
        Me.lblJumlahData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCaptionJumlahData
        '
        Me.lblCaptionJumlahData.AutoSize = True
        Me.lblCaptionJumlahData.Location = New System.Drawing.Point(308, 260)
        Me.lblCaptionJumlahData.Name = "lblCaptionJumlahData"
        Me.lblCaptionJumlahData.Size = New System.Drawing.Size(72, 13)
        Me.lblCaptionJumlahData.TabIndex = 42
        Me.lblCaptionJumlahData.Text = "Jumlah Data :"
        '
        'txtKodeTransaksi
        '
        Me.txtKodeTransaksi.DataPropertyName = "kodetransaksi"
        Me.txtKodeTransaksi.HeaderText = "Kode"
        Me.txtKodeTransaksi.Name = "txtKodeTransaksi"
        Me.txtKodeTransaksi.Width = 50
        '
        'txtTanggalTransaksi
        '
        Me.txtTanggalTransaksi.DataPropertyName = "tgltransaksi"
        DataGridViewCellStyle4.Format = "dd-MM-yyyy"
        Me.txtTanggalTransaksi.DefaultCellStyle = DataGridViewCellStyle4
        Me.txtTanggalTransaksi.HeaderText = "Tanggal Transaksi"
        Me.txtTanggalTransaksi.Name = "txtTanggalTransaksi"
        '
        'txtnopol
        '
        Me.txtnopol.DataPropertyName = "nopol"
        Me.txtnopol.HeaderText = "Nopol"
        Me.txtnopol.Name = "txtnopol"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.DataPropertyName = "keterangan"
        Me.txtKeterangan.HeaderText = "Keterangan"
        Me.txtKeterangan.Name = "txtKeterangan"
        '
        'txtHarga
        '
        Me.txtHarga.DataPropertyName = "harga"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.txtHarga.DefaultCellStyle = DataGridViewCellStyle5
        Me.txtHarga.HeaderText = "Biaya"
        Me.txtHarga.Name = "txtHarga"
        '
        'txtJumlah
        '
        Me.txtJumlah.DataPropertyName = "jumlah"
        Me.txtJumlah.HeaderText = "Jumlah"
        Me.txtJumlah.Name = "txtJumlah"
        '
        'SubTotal
        '
        Me.SubTotal.DataPropertyName = "subtotal"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.SubTotal.DefaultCellStyle = DataGridViewCellStyle6
        Me.SubTotal.HeaderText = "SubTotal"
        Me.SubTotal.Name = "SubTotal"
        '
        'btnUbah
        '
        Me.btnUbah.DataPropertyName = "btn"
        Me.btnUbah.FillWeight = 50.0!
        Me.btnUbah.HeaderText = "Ubah"
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btnUbah.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.ToolTipText = "Ubah"
        Me.btnUbah.Width = 50
        '
        'btnhapus
        '
        Me.btnhapus.DataPropertyName = "btn2"
        Me.btnhapus.FillWeight = 50.0!
        Me.btnhapus.HeaderText = "Hapus"
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.Width = 50
        '
        'frmOperationalKendaraan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 289)
        Me.Controls.Add(Me.lblTotalBiaya)
        Me.Controls.Add(Me.lblCaptionTotalBiaya)
        Me.Controls.Add(Me.lblJumlahData)
        Me.Controls.Add(Me.lblCaptionJumlahData)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.dgvBiayaOperationalKendaraan)
        Me.Controls.Add(Me.cmbKendaraan)
        Me.Controls.Add(Me.lblJenis)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpToTglTransaksi)
        Me.Controls.Add(Me.dtpFromTglTransaksi)
        Me.Controls.Add(Me.lblCariTanggalTransaksi)
        Me.Controls.Add(Me.btnFilter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOperationalKendaraan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Operational Kendaraan :."
        CType(Me.dgvBiayaOperationalKendaraan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbKendaraan As System.Windows.Forms.ComboBox
    Friend WithEvents lblJenis As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpToTglTransaksi As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFromTglTransaksi As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCariTanggalTransaksi As System.Windows.Forms.Label
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents dgvBiayaOperationalKendaraan As System.Windows.Forms.DataGridView
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents lblTotalBiaya As System.Windows.Forms.Label
    Friend WithEvents lblCaptionTotalBiaya As System.Windows.Forms.Label
    Friend WithEvents lblJumlahData As System.Windows.Forms.Label
    Friend WithEvents lblCaptionJumlahData As System.Windows.Forms.Label
    Friend WithEvents txtKodeTransaksi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTanggalTransaksi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtnopol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtKeterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtHarga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtJumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnUbah As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnhapus As System.Windows.Forms.DataGridViewButtonColumn
End Class
