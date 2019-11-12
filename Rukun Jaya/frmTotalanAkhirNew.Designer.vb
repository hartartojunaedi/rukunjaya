<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTotalanAkhirNew
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
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle44 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle49 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle50 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle45 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle46 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle47 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle48 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle51 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle52 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btncari = New System.Windows.Forms.Button()
        Me.txtkodesopir = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblnamasopir = New System.Windows.Forms.Label()
        Me.dgvTotalan = New System.Windows.Forms.DataGridView()
        Me.nototalan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diterima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.borongan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sangusolar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dgtotalan = New System.Windows.Forms.DataGridView()
        Me.ntotalan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.terima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvBiayaLain = New System.Windows.Forms.DataGridView()
        Me.kodetransaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTanggalTransaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtJenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBiaya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sisa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bayarkasbon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbltotalbayarkasbon = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbltotalterima = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txttambahan = New System.Windows.Forms.TextBox()
        Me.txtpotongan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnototalan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtketerangan = New System.Windows.Forms.TextBox()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.cmbgrandbiaya = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtgrandket = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtGrandbiaya = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.kodebiaya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBiaya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kredit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Debit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Haous = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvTotalan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgtotalan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBiayaLain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(174, 8)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(33, 23)
        Me.btncari.TabIndex = 5
        Me.btncari.Text = "..."
        Me.btncari.UseVisualStyleBackColor = True
        '
        'txtkodesopir
        '
        Me.txtkodesopir.Location = New System.Drawing.Point(89, 12)
        Me.txtkodesopir.MaxLength = 5
        Me.txtkodesopir.Name = "txtkodesopir"
        Me.txtkodesopir.Size = New System.Drawing.Size(78, 20)
        Me.txtkodesopir.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kode Sopir : "
        '
        'lblnamasopir
        '
        Me.lblnamasopir.AutoSize = True
        Me.lblnamasopir.Location = New System.Drawing.Point(213, 15)
        Me.lblnamasopir.Name = "lblnamasopir"
        Me.lblnamasopir.Size = New System.Drawing.Size(0, 13)
        Me.lblnamasopir.TabIndex = 6
        '
        'dgvTotalan
        '
        Me.dgvTotalan.AllowUserToAddRows = False
        Me.dgvTotalan.AllowUserToDeleteRows = False
        Me.dgvTotalan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTotalan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nototalan, Me.diterima, Me.tanggal, Me.borongan, Me.sangusolar, Me.total})
        Me.dgvTotalan.Location = New System.Drawing.Point(17, 44)
        Me.dgvTotalan.Name = "dgvTotalan"
        Me.dgvTotalan.ReadOnly = True
        Me.dgvTotalan.Size = New System.Drawing.Size(873, 96)
        Me.dgvTotalan.TabIndex = 7
        '
        'nototalan
        '
        Me.nototalan.DataPropertyName = "nototalan"
        Me.nototalan.HeaderText = "No Totalan"
        Me.nototalan.Name = "nototalan"
        Me.nototalan.ReadOnly = True
        '
        'diterima
        '
        Me.diterima.DataPropertyName = "tanggal"
        Me.diterima.HeaderText = "Tanggal"
        Me.diterima.Name = "diterima"
        Me.diterima.ReadOnly = True
        '
        'tanggal
        '
        Me.tanggal.DataPropertyName = "totalborongan"
        DataGridViewCellStyle40.Format = "N2"
        DataGridViewCellStyle40.NullValue = "0"
        Me.tanggal.DefaultCellStyle = DataGridViewCellStyle40
        Me.tanggal.HeaderText = "Borongan"
        Me.tanggal.Name = "tanggal"
        Me.tanggal.ReadOnly = True
        Me.tanggal.Visible = False
        '
        'borongan
        '
        Me.borongan.DataPropertyName = "solarsangu"
        DataGridViewCellStyle41.Format = "N2"
        DataGridViewCellStyle41.NullValue = "0"
        Me.borongan.DefaultCellStyle = DataGridViewCellStyle41
        Me.borongan.HeaderText = "Solar+Sangu"
        Me.borongan.Name = "borongan"
        Me.borongan.ReadOnly = True
        Me.borongan.Visible = False
        '
        'sangusolar
        '
        Me.sangusolar.DataPropertyName = "diterima"
        DataGridViewCellStyle42.Format = "N2"
        DataGridViewCellStyle42.NullValue = "0"
        Me.sangusolar.DefaultCellStyle = DataGridViewCellStyle42
        Me.sangusolar.HeaderText = "Terima"
        Me.sangusolar.Name = "sangusolar"
        Me.sangusolar.ReadOnly = True
        '
        'total
        '
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'dgtotalan
        '
        Me.dgtotalan.AllowUserToAddRows = False
        Me.dgtotalan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtotalan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ntotalan, Me.terima})
        Me.dgtotalan.Location = New System.Drawing.Point(17, 146)
        Me.dgtotalan.Name = "dgtotalan"
        Me.dgtotalan.ReadOnly = True
        Me.dgtotalan.Size = New System.Drawing.Size(289, 131)
        Me.dgtotalan.TabIndex = 8
        '
        'ntotalan
        '
        Me.ntotalan.DataPropertyName = "nototalan"
        Me.ntotalan.HeaderText = "No Totalan"
        Me.ntotalan.Name = "ntotalan"
        Me.ntotalan.ReadOnly = True
        '
        'terima
        '
        Me.terima.DataPropertyName = "diterima"
        DataGridViewCellStyle43.Format = "N0"
        DataGridViewCellStyle43.NullValue = "0"
        Me.terima.DefaultCellStyle = DataGridViewCellStyle43
        Me.terima.HeaderText = "Terima"
        Me.terima.Name = "terima"
        Me.terima.ReadOnly = True
        '
        'dgvBiayaLain
        '
        Me.dgvBiayaLain.AllowUserToAddRows = False
        DataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle44.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBiayaLain.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle44
        Me.dgvBiayaLain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBiayaLain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodetransaksi, Me.txtTanggalTransaksi, Me.txtJenis, Me.txtBiaya, Me.Sisa, Me.Bayarkasbon})
        DataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle49.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle49.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle49.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle49.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle49.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBiayaLain.DefaultCellStyle = DataGridViewCellStyle49
        Me.dgvBiayaLain.Location = New System.Drawing.Point(322, 146)
        Me.dgvBiayaLain.Name = "dgvBiayaLain"
        DataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle50.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle50.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle50.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle50.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle50.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBiayaLain.RowHeadersDefaultCellStyle = DataGridViewCellStyle50
        Me.dgvBiayaLain.Size = New System.Drawing.Size(568, 131)
        Me.dgvBiayaLain.TabIndex = 89
        '
        'kodetransaksi
        '
        Me.kodetransaksi.DataPropertyName = "kodetransaksi"
        Me.kodetransaksi.HeaderText = "kodeTransaksi"
        Me.kodetransaksi.Name = "kodetransaksi"
        Me.kodetransaksi.ReadOnly = True
        Me.kodetransaksi.Visible = False
        Me.kodetransaksi.Width = 5
        '
        'txtTanggalTransaksi
        '
        Me.txtTanggalTransaksi.DataPropertyName = "tgltransaksi"
        DataGridViewCellStyle45.Format = "dd-MM-yyyy"
        DataGridViewCellStyle45.NullValue = Nothing
        Me.txtTanggalTransaksi.DefaultCellStyle = DataGridViewCellStyle45
        Me.txtTanggalTransaksi.HeaderText = "Tanggal Transaksi"
        Me.txtTanggalTransaksi.Name = "txtTanggalTransaksi"
        Me.txtTanggalTransaksi.ReadOnly = True
        '
        'txtJenis
        '
        Me.txtJenis.DataPropertyName = "namajenis"
        Me.txtJenis.HeaderText = "Jenis"
        Me.txtJenis.Name = "txtJenis"
        Me.txtJenis.ReadOnly = True
        Me.txtJenis.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.txtJenis.Width = 80
        '
        'txtBiaya
        '
        Me.txtBiaya.DataPropertyName = "harga"
        DataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle46.Format = "N"
        DataGridViewCellStyle46.NullValue = Nothing
        Me.txtBiaya.DefaultCellStyle = DataGridViewCellStyle46
        Me.txtBiaya.HeaderText = "Harga"
        Me.txtBiaya.Name = "txtBiaya"
        Me.txtBiaya.ReadOnly = True
        '
        'Sisa
        '
        Me.Sisa.DataPropertyName = "sisa"
        DataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle47.Format = "N"
        Me.Sisa.DefaultCellStyle = DataGridViewCellStyle47
        Me.Sisa.HeaderText = "Sisa"
        Me.Sisa.Name = "Sisa"
        Me.Sisa.ReadOnly = True
        '
        'Bayarkasbon
        '
        Me.Bayarkasbon.DataPropertyName = "bayarkasbon"
        DataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle48.Format = "N"
        Me.Bayarkasbon.DefaultCellStyle = DataGridViewCellStyle48
        Me.Bayarkasbon.HeaderText = "Bayar"
        Me.Bayarkasbon.Name = "Bayarkasbon"
        '
        'lbltotalbayarkasbon
        '
        Me.lbltotalbayarkasbon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalbayarkasbon.Location = New System.Drawing.Point(802, 374)
        Me.lbltotalbayarkasbon.Name = "lbltotalbayarkasbon"
        Me.lbltotalbayarkasbon.Size = New System.Drawing.Size(80, 17)
        Me.lbltotalbayarkasbon.TabIndex = 92
        Me.lbltotalbayarkasbon.Text = "Label4"
        Me.lbltotalbayarkasbon.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(675, 374)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 13)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Total Bayar Kas Bon : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(687, 347)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Total Terima"
        '
        'lbltotalterima
        '
        Me.lbltotalterima.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalterima.Location = New System.Drawing.Point(782, 343)
        Me.lbltotalterima.Name = "lbltotalterima"
        Me.lbltotalterima.Size = New System.Drawing.Size(100, 17)
        Me.lbltotalterima.TabIndex = 94
        Me.lbltotalterima.Text = "0"
        Me.lbltotalterima.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 383)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Tambahan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 378)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "Potongan"
        '
        'txttambahan
        '
        Me.txttambahan.Location = New System.Drawing.Point(199, 375)
        Me.txttambahan.Name = "txttambahan"
        Me.txttambahan.Size = New System.Drawing.Size(100, 20)
        Me.txttambahan.TabIndex = 97
        Me.txttambahan.Text = "0"
        '
        'txtpotongan
        '
        Me.txtpotongan.Location = New System.Drawing.Point(310, 371)
        Me.txtpotongan.Name = "txtpotongan"
        Me.txtpotongan.Size = New System.Drawing.Size(100, 20)
        Me.txtpotongan.TabIndex = 98
        Me.txtpotongan.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(702, 404)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "Grand Total"
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandTotal.Location = New System.Drawing.Point(782, 404)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(100, 17)
        Me.lblGrandTotal.TabIndex = 100
        Me.lblGrandTotal.Text = "0"
        Me.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(430, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 13)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "No Grand Totalan :"
        '
        'dtpTanggal
        '
        Me.dtpTanggal.CustomFormat = "dd-MM-yyyy"
        Me.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTanggal.Location = New System.Drawing.Point(802, 283)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(86, 20)
        Me.dtpTanggal.TabIndex = 102
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(739, 283)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "Tanggal "
        '
        'txtnototalan
        '
        Me.txtnototalan.Location = New System.Drawing.Point(578, 283)
        Me.txtnototalan.Name = "txtnototalan"
        Me.txtnototalan.Size = New System.Drawing.Size(100, 20)
        Me.txtnototalan.TabIndex = 104
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(430, 314)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "Keterangan"
        '
        'txtketerangan
        '
        Me.txtketerangan.Location = New System.Drawing.Point(578, 314)
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.Size = New System.Drawing.Size(310, 20)
        Me.txtketerangan.TabIndex = 106
        '
        'btnsimpan
        '
        Me.btnsimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnsimpan.Location = New System.Drawing.Point(802, 440)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(80, 29)
        Me.btnsimpan.TabIndex = 107
        Me.btnsimpan.Text = "&Simpan"
        Me.btnsimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'cmbgrandbiaya
        '
        Me.cmbgrandbiaya.FormattingEnabled = True
        Me.cmbgrandbiaya.Location = New System.Drawing.Point(89, 280)
        Me.cmbgrandbiaya.Name = "cmbgrandbiaya"
        Me.cmbgrandbiaya.Size = New System.Drawing.Size(210, 21)
        Me.cmbgrandbiaya.TabIndex = 109
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 283)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 110
        Me.Label10.Text = "Nama"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 305)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 111
        Me.Label11.Text = "Keterangan"
        '
        'txtgrandket
        '
        Me.txtgrandket.Location = New System.Drawing.Point(89, 305)
        Me.txtgrandket.Name = "txtgrandket"
        Me.txtgrandket.Size = New System.Drawing.Size(258, 20)
        Me.txtgrandket.TabIndex = 112
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(20, 332)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 113
        Me.Label12.Text = "Biaya"
        '
        'txtGrandbiaya
        '
        Me.txtGrandbiaya.Location = New System.Drawing.Point(89, 332)
        Me.txtGrandbiaya.Name = "txtGrandbiaya"
        Me.txtGrandbiaya.Size = New System.Drawing.Size(144, 20)
        Me.txtGrandbiaya.TabIndex = 114
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon1
        Me.Button1.Location = New System.Drawing.Point(239, 326)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 29)
        Me.Button1.TabIndex = 125
        Me.Button1.Text = "&Biaya"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodebiaya, Me.NamaBiaya, Me.Keterangan, Me.Kredit, Me.Debit, Me.Haous})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 358)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(657, 138)
        Me.DataGridView1.TabIndex = 126
        '
        'kodebiaya
        '
        Me.kodebiaya.DataPropertyName = "kodegrandbiaya"
        Me.kodebiaya.HeaderText = "Kode Biaya"
        Me.kodebiaya.Name = "kodebiaya"
        Me.kodebiaya.ReadOnly = True
        '
        'NamaBiaya
        '
        Me.NamaBiaya.DataPropertyName = "namagrandbiaya"
        Me.NamaBiaya.HeaderText = "Nama Biaya"
        Me.NamaBiaya.Name = "NamaBiaya"
        Me.NamaBiaya.ReadOnly = True
        '
        'Keterangan
        '
        Me.Keterangan.DataPropertyName = "keterangan"
        Me.Keterangan.HeaderText = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.ReadOnly = True
        '
        'Kredit
        '
        Me.Kredit.DataPropertyName = "kredit"
        DataGridViewCellStyle51.Format = "N0"
        Me.Kredit.DefaultCellStyle = DataGridViewCellStyle51
        Me.Kredit.HeaderText = "Kredit"
        Me.Kredit.Name = "Kredit"
        Me.Kredit.ReadOnly = True
        '
        'Debit
        '
        Me.Debit.DataPropertyName = "debit"
        DataGridViewCellStyle52.Format = "N0"
        Me.Debit.DefaultCellStyle = DataGridViewCellStyle52
        Me.Debit.HeaderText = "Debit"
        Me.Debit.Name = "Debit"
        Me.Debit.ReadOnly = True
        '
        'Haous
        '
        Me.Haous.HeaderText = "Hapus"
        Me.Haous.Name = "Haous"
        Me.Haous.ReadOnly = True
        '
        'frmTotalanAkhirNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 500)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtGrandbiaya)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtgrandket)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbgrandbiaya)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.txtketerangan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtnototalan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblGrandTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtpotongan)
        Me.Controls.Add(Me.txttambahan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbltotalterima)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbltotalbayarkasbon)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvBiayaLain)
        Me.Controls.Add(Me.dgtotalan)
        Me.Controls.Add(Me.dgvTotalan)
        Me.Controls.Add(Me.lblnamasopir)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.txtkodesopir)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTotalanAkhirNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Totalan Final :."
        CType(Me.dgvTotalan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgtotalan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBiayaLain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents txtkodesopir As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblnamasopir As System.Windows.Forms.Label
    Friend WithEvents dgvTotalan As System.Windows.Forms.DataGridView
    Friend WithEvents dgtotalan As System.Windows.Forms.DataGridView
    Friend WithEvents dgvBiayaLain As System.Windows.Forms.DataGridView
    Friend WithEvents kodetransaksi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTanggalTransaksi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtJenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtBiaya As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sisa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bayarkasbon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbltotalbayarkasbon As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ntotalan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents terima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbltotalterima As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txttambahan As System.Windows.Forms.TextBox
    Friend WithEvents txtpotongan As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblGrandTotal As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtnototalan As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtketerangan As System.Windows.Forms.TextBox
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents nototalan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents diterima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tanggal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents borongan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sangusolar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cmbgrandbiaya As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtgrandket As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtGrandbiaya As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents kodebiaya As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBiaya As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kredit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Debit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Haous As System.Windows.Forms.DataGridViewButtonColumn
End Class
