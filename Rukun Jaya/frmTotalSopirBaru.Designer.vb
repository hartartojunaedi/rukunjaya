<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTotalSopirBaru
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btncari = New System.Windows.Forms.Button()
        Me.txtkodesopir = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblnamasopir = New System.Windows.Forms.Label()
        Me.dgvBM = New System.Windows.Forms.DataGridView()
        Me.NoBM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoLambung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nopolisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisKendaraan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalOngkos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dgvSuratJalan = New System.Windows.Forms.DataGridView()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtketerangan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtnototalan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblsolar = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtTambahan2 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTambahan1 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtpotongan = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txttambahan = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblpotongan = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbltambahan = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblditerima = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblsangu = New System.Windows.Forms.Label()
        Me.lblborongan = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblklaim = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblkuli = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbltotalbayarkasbon = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdetailbiaya = New System.Windows.Forms.TextBox()
        Me.NoSuratJalan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomorbm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Asal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tujuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Namasupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detilperwakilan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ubah = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblterima = New System.Windows.Forms.Label()
        Me.lblkredit = New System.Windows.Forms.Label()
        Me.lbldebit = New System.Windows.Forms.Label()
        CType(Me.dgvBM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSuratJalan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(180, 12)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(33, 23)
        Me.btncari.TabIndex = 5
        Me.btncari.Text = "..."
        Me.btncari.UseVisualStyleBackColor = True
        '
        'txtkodesopir
        '
        Me.txtkodesopir.Location = New System.Drawing.Point(95, 16)
        Me.txtkodesopir.MaxLength = 5
        Me.txtkodesopir.Name = "txtkodesopir"
        Me.txtkodesopir.Size = New System.Drawing.Size(78, 20)
        Me.txtkodesopir.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kode Sopir : "
        '
        'lblnamasopir
        '
        Me.lblnamasopir.AutoSize = True
        Me.lblnamasopir.Location = New System.Drawing.Point(219, 16)
        Me.lblnamasopir.Name = "lblnamasopir"
        Me.lblnamasopir.Size = New System.Drawing.Size(0, 13)
        Me.lblnamasopir.TabIndex = 6
        '
        'dgvBM
        '
        Me.dgvBM.AllowUserToAddRows = False
        Me.dgvBM.AllowUserToDeleteRows = False
        Me.dgvBM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoBM, Me.Tanggal, Me.NoLambung, Me.nopolisi, Me.JenisKendaraan, Me.TotalOngkos, Me.Total})
        Me.dgvBM.Location = New System.Drawing.Point(12, 42)
        Me.dgvBM.Name = "dgvBM"
        Me.dgvBM.ReadOnly = True
        Me.dgvBM.Size = New System.Drawing.Size(782, 101)
        Me.dgvBM.TabIndex = 13
        '
        'NoBM
        '
        Me.NoBM.DataPropertyName = "noBM"
        Me.NoBM.HeaderText = "No Bon Muat"
        Me.NoBM.Name = "NoBM"
        Me.NoBM.ReadOnly = True
        '
        'Tanggal
        '
        Me.Tanggal.DataPropertyName = "tgl"
        DataGridViewCellStyle1.Format = "dd-MM-yyyy"
        Me.Tanggal.DefaultCellStyle = DataGridViewCellStyle1
        Me.Tanggal.HeaderText = "Tanggal"
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.ReadOnly = True
        '
        'NoLambung
        '
        Me.NoLambung.DataPropertyName = "nolambung"
        Me.NoLambung.HeaderText = "No Lambung"
        Me.NoLambung.Name = "NoLambung"
        Me.NoLambung.ReadOnly = True
        '
        'nopolisi
        '
        Me.nopolisi.DataPropertyName = "nopol"
        Me.nopolisi.HeaderText = "No Polisi"
        Me.nopolisi.Name = "nopolisi"
        Me.nopolisi.ReadOnly = True
        '
        'JenisKendaraan
        '
        Me.JenisKendaraan.DataPropertyName = "namajenis"
        Me.JenisKendaraan.HeaderText = "Jenis Kendaraan"
        Me.JenisKendaraan.Name = "JenisKendaraan"
        Me.JenisKendaraan.ReadOnly = True
        '
        'TotalOngkos
        '
        Me.TotalOngkos.DataPropertyName = "total"
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.TotalOngkos.DefaultCellStyle = DataGridViewCellStyle2
        Me.TotalOngkos.HeaderText = "Total Ongkos"
        Me.TotalOngkos.Name = "TotalOngkos"
        Me.TotalOngkos.ReadOnly = True
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Text = "Total"
        '
        'dgvSuratJalan
        '
        Me.dgvSuratJalan.AllowUserToAddRows = False
        Me.dgvSuratJalan.AllowUserToDeleteRows = False
        Me.dgvSuratJalan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSuratJalan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoSuratJalan, Me.nomorbm, Me.DataGridViewTextBoxColumn1, Me.Asal, Me.Tujuan, Me.Namasupplier, Me.detilperwakilan, Me.Ubah})
        Me.dgvSuratJalan.Location = New System.Drawing.Point(12, 149)
        Me.dgvSuratJalan.Name = "dgvSuratJalan"
        Me.dgvSuratJalan.Size = New System.Drawing.Size(782, 152)
        Me.dgvSuratJalan.TabIndex = 14
        '
        'dtpTanggal
        '
        Me.dtpTanggal.CustomFormat = "dd-MM-yyyy"
        Me.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTanggal.Location = New System.Drawing.Point(270, 323)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(86, 20)
        Me.dtpTanggal.TabIndex = 113
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(208, 328)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 13)
        Me.Label15.TabIndex = 117
        Me.Label15.Text = "Tanggal : "
        '
        'txtketerangan
        '
        Me.txtketerangan.Location = New System.Drawing.Point(88, 352)
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.Size = New System.Drawing.Size(492, 20)
        Me.txtketerangan.TabIndex = 115
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 355)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 114
        Me.Label9.Text = "Keterangan : "
        '
        'txtnototalan
        '
        Me.txtnototalan.Location = New System.Drawing.Point(88, 325)
        Me.txtnototalan.Name = "txtnototalan"
        Me.txtnototalan.Size = New System.Drawing.Size(100, 20)
        Me.txtnototalan.TabIndex = 112
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 328)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "No Totalan : "
        '
        'lblsolar
        '
        Me.lblsolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsolar.Location = New System.Drawing.Point(879, 379)
        Me.lblsolar.Name = "lblsolar"
        Me.lblsolar.Size = New System.Drawing.Size(100, 17)
        Me.lblsolar.TabIndex = 138
        Me.lblsolar.Text = "0"
        Me.lblsolar.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblsolar.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(671, 379)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(36, 13)
        Me.Label18.TabIndex = 137
        Me.Label18.Text = "Solar"
        Me.Label18.Visible = False
        '
        'txtTambahan2
        '
        Me.txtTambahan2.Location = New System.Drawing.Point(739, 496)
        Me.txtTambahan2.Name = "txtTambahan2"
        Me.txtTambahan2.Size = New System.Drawing.Size(100, 20)
        Me.txtTambahan2.TabIndex = 136
        Me.txtTambahan2.Text = "0"
        Me.txtTambahan2.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(661, 496)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 13)
        Me.Label17.TabIndex = 135
        Me.Label17.Text = "Lain-Lain"
        Me.Label17.Visible = False
        '
        'txtTambahan1
        '
        Me.txtTambahan1.Location = New System.Drawing.Point(739, 472)
        Me.txtTambahan1.Name = "txtTambahan1"
        Me.txtTambahan1.Size = New System.Drawing.Size(100, 20)
        Me.txtTambahan1.TabIndex = 134
        Me.txtTambahan1.Text = "0"
        Me.txtTambahan1.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(633, 475)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 13)
        Me.Label16.TabIndex = 133
        Me.Label16.Text = "Bongkar + Tol"
        Me.Label16.Visible = False
        '
        'txtpotongan
        '
        Me.txtpotongan.Location = New System.Drawing.Point(881, 518)
        Me.txtpotongan.Name = "txtpotongan"
        Me.txtpotongan.Size = New System.Drawing.Size(100, 20)
        Me.txtpotongan.TabIndex = 126
        Me.txtpotongan.Text = "0"
        Me.txtpotongan.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(650, 521)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 13)
        Me.Label14.TabIndex = 132
        Me.Label14.Text = "Potongan : "
        Me.Label14.Visible = False
        '
        'txttambahan
        '
        Me.txttambahan.Location = New System.Drawing.Point(739, 447)
        Me.txttambahan.Name = "txttambahan"
        Me.txttambahan.Size = New System.Drawing.Size(100, 20)
        Me.txttambahan.TabIndex = 125
        Me.txttambahan.Text = "0"
        Me.txttambahan.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(625, 450)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 13)
        Me.Label10.TabIndex = 131
        Me.Label10.Text = "Tambahan (FM)"
        Me.Label10.Visible = False
        '
        'lblpotongan
        '
        Me.lblpotongan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpotongan.Location = New System.Drawing.Point(879, 426)
        Me.lblpotongan.Name = "lblpotongan"
        Me.lblpotongan.Size = New System.Drawing.Size(100, 17)
        Me.lblpotongan.TabIndex = 130
        Me.lblpotongan.Text = "Label4"
        Me.lblpotongan.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblpotongan.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(646, 426)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 13)
        Me.Label13.TabIndex = 129
        Me.Label13.Text = "Potongan"
        Me.Label13.Visible = False
        '
        'lbltambahan
        '
        Me.lbltambahan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltambahan.Location = New System.Drawing.Point(736, 404)
        Me.lbltambahan.Name = "lbltambahan"
        Me.lbltambahan.Size = New System.Drawing.Size(100, 17)
        Me.lbltambahan.TabIndex = 128
        Me.lbltambahan.Text = "Label4"
        Me.lbltambahan.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lbltambahan.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(641, 404)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 127
        Me.Label11.Text = "Tambahan"
        Me.Label11.Visible = False
        '
        'lblditerima
        '
        Me.lblditerima.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblditerima.Location = New System.Drawing.Point(736, 554)
        Me.lblditerima.Name = "lblditerima"
        Me.lblditerima.Size = New System.Drawing.Size(100, 17)
        Me.lblditerima.TabIndex = 124
        Me.lblditerima.Text = "Label4"
        Me.lblditerima.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblditerima.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(602, 357)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 13)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "Sangu + Kas Bon"
        Me.Label6.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(646, 338)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 122
        Me.Label4.Text = "Borongan"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(586, 554)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "Total Diterima"
        Me.Label5.Visible = False
        '
        'lblsangu
        '
        Me.lblsangu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsangu.Location = New System.Drawing.Point(879, 357)
        Me.lblsangu.Name = "lblsangu"
        Me.lblsangu.Size = New System.Drawing.Size(100, 17)
        Me.lblsangu.TabIndex = 120
        Me.lblsangu.Text = "Label4"
        Me.lblsangu.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblsangu.Visible = False
        '
        'lblborongan
        '
        Me.lblborongan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblborongan.Location = New System.Drawing.Point(736, 338)
        Me.lblborongan.Name = "lblborongan"
        Me.lblborongan.Size = New System.Drawing.Size(99, 13)
        Me.lblborongan.TabIndex = 119
        Me.lblborongan.Text = "Label3"
        Me.lblborongan.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblborongan.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(586, 316)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Total Borongan : "
        Me.Label2.Visible = False
        '
        'lblklaim
        '
        Me.lblklaim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblklaim.Location = New System.Drawing.Point(801, 168)
        Me.lblklaim.Name = "lblklaim"
        Me.lblklaim.Size = New System.Drawing.Size(100, 17)
        Me.lblklaim.TabIndex = 144
        Me.lblklaim.Text = "Label4"
        Me.lblklaim.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblklaim.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(592, 168)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 143
        Me.Label12.Text = "Klaim"
        Me.Label12.Visible = False
        '
        'lblkuli
        '
        Me.lblkuli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkuli.Location = New System.Drawing.Point(800, 126)
        Me.lblkuli.Name = "lblkuli"
        Me.lblkuli.Size = New System.Drawing.Size(100, 17)
        Me.lblkuli.TabIndex = 142
        Me.lblkuli.Text = "Label4"
        Me.lblkuli.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblkuli.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(601, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 141
        Me.Label7.Text = "Kuli"
        Me.Label7.Visible = False
        '
        'lbltotalbayarkasbon
        '
        Me.lbltotalbayarkasbon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalbayarkasbon.Location = New System.Drawing.Point(881, 151)
        Me.lbltotalbayarkasbon.Name = "lbltotalbayarkasbon"
        Me.lbltotalbayarkasbon.Size = New System.Drawing.Size(100, 17)
        Me.lbltotalbayarkasbon.TabIndex = 140
        Me.lbltotalbayarkasbon.Text = "Label4"
        Me.lbltotalbayarkasbon.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lbltotalbayarkasbon.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(588, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 13)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "Total Bayar Kas Bon : "
        Me.Label3.Visible = False
        '
        'txtdetailbiaya
        '
        Me.txtdetailbiaya.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdetailbiaya.Location = New System.Drawing.Point(15, 379)
        Me.txtdetailbiaya.Multiline = True
        Me.txtdetailbiaya.Name = "txtdetailbiaya"
        Me.txtdetailbiaya.ReadOnly = True
        Me.txtdetailbiaya.Size = New System.Drawing.Size(779, 192)
        Me.txtdetailbiaya.TabIndex = 145
        Me.txtdetailbiaya.WordWrap = False
        '
        'NoSuratJalan
        '
        Me.NoSuratJalan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NoSuratJalan.DataPropertyName = "NoSuratJalan"
        Me.NoSuratJalan.Frozen = True
        Me.NoSuratJalan.HeaderText = "No Surat Jalan"
        Me.NoSuratJalan.Name = "NoSuratJalan"
        Me.NoSuratJalan.ReadOnly = True
        Me.NoSuratJalan.Width = 50
        '
        'nomorbm
        '
        Me.nomorbm.DataPropertyName = "nobm"
        Me.nomorbm.HeaderText = "BM"
        Me.nomorbm.Name = "nomorbm"
        Me.nomorbm.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "tgl"
        DataGridViewCellStyle3.Format = "dd-MM-yyyy"
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tanggal"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 75
        '
        'Asal
        '
        Me.Asal.DataPropertyName = "asal"
        Me.Asal.HeaderText = "Asal"
        Me.Asal.Name = "Asal"
        Me.Asal.ReadOnly = True
        '
        'Tujuan
        '
        Me.Tujuan.DataPropertyName = "tujuan"
        Me.Tujuan.HeaderText = "Tujuan"
        Me.Tujuan.Name = "Tujuan"
        Me.Tujuan.ReadOnly = True
        '
        'Namasupplier
        '
        Me.Namasupplier.DataPropertyName = "NamaSupplier"
        Me.Namasupplier.HeaderText = "Nama Supplier"
        Me.Namasupplier.Name = "Namasupplier"
        Me.Namasupplier.ReadOnly = True
        '
        'detilperwakilan
        '
        Me.detilperwakilan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.detilperwakilan.DataPropertyName = "NamaPerwakilan"
        Me.detilperwakilan.HeaderText = "Nama Perwakilan"
        Me.detilperwakilan.Name = "detilperwakilan"
        Me.detilperwakilan.ReadOnly = True
        Me.detilperwakilan.Visible = False
        '
        'Ubah
        '
        Me.Ubah.HeaderText = "Ubah"
        Me.Ubah.Name = "Ubah"
        '
        'btnsimpan
        '
        Me.btnsimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnsimpan.Location = New System.Drawing.Point(500, 316)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(80, 29)
        Me.btnsimpan.TabIndex = 116
        Me.btnsimpan.Text = "&Simpan"
        Me.btnsimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(20, 574)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 13)
        Me.Label19.TabIndex = 146
        Me.Label19.Text = "Diterima"
        '
        'lblterima
        '
        Me.lblterima.AutoSize = True
        Me.lblterima.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblterima.Location = New System.Drawing.Point(497, 574)
        Me.lblterima.Name = "lblterima"
        Me.lblterima.Size = New System.Drawing.Size(53, 13)
        Me.lblterima.TabIndex = 147
        Me.lblterima.Text = "Diterima"
        '
        'lblkredit
        '
        Me.lblkredit.AutoSize = True
        Me.lblkredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkredit.Location = New System.Drawing.Point(128, 574)
        Me.lblkredit.Name = "lblkredit"
        Me.lblkredit.Size = New System.Drawing.Size(52, 13)
        Me.lblkredit.TabIndex = 148
        Me.lblkredit.Text = "Label21"
        '
        'lbldebit
        '
        Me.lbldebit.AutoSize = True
        Me.lbldebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldebit.Location = New System.Drawing.Point(311, 574)
        Me.lbldebit.Name = "lbldebit"
        Me.lbldebit.Size = New System.Drawing.Size(52, 13)
        Me.lbldebit.TabIndex = 149
        Me.lbldebit.Text = "Label21"
        '
        'frmTotalSopirBaru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 600)
        Me.Controls.Add(Me.lbldebit)
        Me.Controls.Add(Me.lblkredit)
        Me.Controls.Add(Me.lblterima)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtdetailbiaya)
        Me.Controls.Add(Me.lblklaim)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblkuli)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbltotalbayarkasbon)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblsolar)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtTambahan2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtTambahan1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtpotongan)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txttambahan)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblpotongan)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lbltambahan)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblditerima)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblsangu)
        Me.Controls.Add(Me.lblborongan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtketerangan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtnototalan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.dgvSuratJalan)
        Me.Controls.Add(Me.dgvBM)
        Me.Controls.Add(Me.lblnamasopir)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.txtkodesopir)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTotalSopirBaru"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Totalan Sopir :."
        CType(Me.dgvBM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSuratJalan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents txtkodesopir As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblnamasopir As System.Windows.Forms.Label
    Friend WithEvents dgvBM As System.Windows.Forms.DataGridView
    Friend WithEvents NoBM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tanggal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoLambung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nopolisi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JenisKendaraan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalOngkos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents dgvSuratJalan As System.Windows.Forms.DataGridView
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtketerangan As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtnototalan As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents lblsolar As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtTambahan2 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtTambahan1 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtpotongan As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txttambahan As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblpotongan As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbltambahan As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblditerima As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblsangu As System.Windows.Forms.Label
    Friend WithEvents lblborongan As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblklaim As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblkuli As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbltotalbayarkasbon As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdetailbiaya As System.Windows.Forms.TextBox
    Friend WithEvents NoSuratJalan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomorbm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Asal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tujuan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Namasupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents detilperwakilan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ubah As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblterima As System.Windows.Forms.Label
    Friend WithEvents lblkredit As System.Windows.Forms.Label
    Friend WithEvents lbldebit As System.Windows.Forms.Label
End Class
