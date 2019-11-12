<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailMaintance
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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cmbnolambung = New System.Windows.Forms.ComboBox()
        Me.lblNolambung = New System.Windows.Forms.Label()
        Me.txtKodeMaintance = New System.Windows.Forms.TextBox()
        Me.lblNoMaintance = New System.Windows.Forms.Label()
        Me.cmbNamaPekerjaan = New System.Windows.Forms.ComboBox()
        Me.lblNamaPekerjaan = New System.Windows.Forms.Label()
        Me.lbltukang = New System.Windows.Forms.Label()
        Me.txttukang = New System.Windows.Forms.TextBox()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.txtketerangan = New System.Windows.Forms.TextBox()
        Me.cbkrutin = New System.Windows.Forms.CheckBox()
        Me.cbktidakrutin = New System.Windows.Forms.CheckBox()
        Me.lblbiaya = New System.Windows.Forms.Label()
        Me.lbltgl = New System.Windows.Forms.Label()
        Me.txtbiaya = New System.Windows.Forms.TextBox()
        Me.dtptglmaintance = New System.Windows.Forms.DateTimePicker()
        Me.lblkilometer = New System.Windows.Forms.Label()
        Me.txtkilometer = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbsopir = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpTglAmbil = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblsisastock = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.txtDetailKeterangan = New System.Windows.Forms.TextBox()
        Me.txtBiayadetail = New System.Windows.Forms.TextBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.txtNoSeri = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNamaSparepart = New System.Windows.Forms.Label()
        Me.cmbNamaSparepart = New System.Windows.Forms.ComboBox()
        Me.dgvdetailmaintance = New System.Windows.Forms.DataGridView()
        Me.namasparepart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.noseri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.biaya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tglambil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.dgvstock = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvdetailmaintance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvstock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(297, 17)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(32, 23)
        Me.btnUpdate.TabIndex = 51
        Me.btnUpdate.Text = "..."
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'cmbnolambung
        '
        Me.cmbnolambung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbnolambung.FormattingEnabled = True
        Me.cmbnolambung.Location = New System.Drawing.Point(114, 47)
        Me.cmbnolambung.Name = "cmbnolambung"
        Me.cmbnolambung.Size = New System.Drawing.Size(178, 21)
        Me.cmbnolambung.TabIndex = 56
        '
        'lblNolambung
        '
        Me.lblNolambung.AutoSize = True
        Me.lblNolambung.Location = New System.Drawing.Point(62, 50)
        Me.lblNolambung.Name = "lblNolambung"
        Me.lblNolambung.Size = New System.Drawing.Size(39, 13)
        Me.lblNolambung.TabIndex = 54
        Me.lblNolambung.Text = "No Pol"
        '
        'txtKodeMaintance
        '
        Me.txtKodeMaintance.Location = New System.Drawing.Point(114, 19)
        Me.txtKodeMaintance.Name = "txtKodeMaintance"
        Me.txtKodeMaintance.Size = New System.Drawing.Size(178, 20)
        Me.txtKodeMaintance.TabIndex = 53
        '
        'lblNoMaintance
        '
        Me.lblNoMaintance.AutoSize = True
        Me.lblNoMaintance.Location = New System.Drawing.Point(16, 22)
        Me.lblNoMaintance.Name = "lblNoMaintance"
        Me.lblNoMaintance.Size = New System.Drawing.Size(85, 13)
        Me.lblNoMaintance.TabIndex = 52
        Me.lblNoMaintance.Text = "Kode Maintance"
        '
        'cmbNamaPekerjaan
        '
        Me.cmbNamaPekerjaan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNamaPekerjaan.FormattingEnabled = True
        Me.cmbNamaPekerjaan.Location = New System.Drawing.Point(114, 75)
        Me.cmbNamaPekerjaan.Name = "cmbNamaPekerjaan"
        Me.cmbNamaPekerjaan.Size = New System.Drawing.Size(178, 21)
        Me.cmbNamaPekerjaan.TabIndex = 58
        '
        'lblNamaPekerjaan
        '
        Me.lblNamaPekerjaan.AutoSize = True
        Me.lblNamaPekerjaan.Location = New System.Drawing.Point(20, 78)
        Me.lblNamaPekerjaan.Name = "lblNamaPekerjaan"
        Me.lblNamaPekerjaan.Size = New System.Drawing.Size(86, 13)
        Me.lblNamaPekerjaan.TabIndex = 57
        Me.lblNamaPekerjaan.Text = "Nama Pekerjaan"
        '
        'lbltukang
        '
        Me.lbltukang.AutoSize = True
        Me.lbltukang.Location = New System.Drawing.Point(62, 132)
        Me.lbltukang.Name = "lbltukang"
        Me.lbltukang.Size = New System.Drawing.Size(44, 13)
        Me.lbltukang.TabIndex = 59
        Me.lbltukang.Text = "Tukang"
        '
        'txttukang
        '
        Me.txttukang.Location = New System.Drawing.Point(114, 132)
        Me.txttukang.Name = "txttukang"
        Me.txttukang.Size = New System.Drawing.Size(216, 20)
        Me.txttukang.TabIndex = 60
        '
        'lblKeterangan
        '
        Me.lblKeterangan.AutoSize = True
        Me.lblKeterangan.Location = New System.Drawing.Point(44, 159)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(62, 13)
        Me.lblKeterangan.TabIndex = 62
        Me.lblKeterangan.Text = "Keterangan"
        '
        'txtketerangan
        '
        Me.txtketerangan.Location = New System.Drawing.Point(114, 159)
        Me.txtketerangan.Multiline = True
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtketerangan.Size = New System.Drawing.Size(216, 72)
        Me.txtketerangan.TabIndex = 63
        '
        'cbkrutin
        '
        Me.cbkrutin.AutoSize = True
        Me.cbkrutin.Location = New System.Drawing.Point(198, 237)
        Me.cbkrutin.Name = "cbkrutin"
        Me.cbkrutin.Size = New System.Drawing.Size(51, 17)
        Me.cbkrutin.TabIndex = 64
        Me.cbkrutin.Text = "Rutin"
        Me.cbkrutin.UseVisualStyleBackColor = True
        '
        'cbktidakrutin
        '
        Me.cbktidakrutin.AutoSize = True
        Me.cbktidakrutin.Location = New System.Drawing.Point(254, 237)
        Me.cbktidakrutin.Name = "cbktidakrutin"
        Me.cbktidakrutin.Size = New System.Drawing.Size(81, 17)
        Me.cbktidakrutin.TabIndex = 65
        Me.cbktidakrutin.Text = "Tidak Rutin"
        Me.cbktidakrutin.UseVisualStyleBackColor = True
        '
        'lblbiaya
        '
        Me.lblbiaya.AutoSize = True
        Me.lblbiaya.Location = New System.Drawing.Point(73, 261)
        Me.lblbiaya.Name = "lblbiaya"
        Me.lblbiaya.Size = New System.Drawing.Size(33, 13)
        Me.lblbiaya.TabIndex = 61
        Me.lblbiaya.Text = "Biaya"
        '
        'lbltgl
        '
        Me.lbltgl.AutoSize = True
        Me.lbltgl.Location = New System.Drawing.Point(7, 290)
        Me.lbltgl.Name = "lbltgl"
        Me.lbltgl.Size = New System.Drawing.Size(99, 13)
        Me.lbltgl.TabIndex = 67
        Me.lbltgl.Text = "Tanggal Maintance"
        '
        'txtbiaya
        '
        Me.txtbiaya.Location = New System.Drawing.Point(114, 258)
        Me.txtbiaya.Name = "txtbiaya"
        Me.txtbiaya.Size = New System.Drawing.Size(142, 20)
        Me.txtbiaya.TabIndex = 68
        '
        'dtptglmaintance
        '
        Me.dtptglmaintance.CustomFormat = "dd-MM-yyyy"
        Me.dtptglmaintance.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptglmaintance.Location = New System.Drawing.Point(114, 287)
        Me.dtptglmaintance.Name = "dtptglmaintance"
        Me.dtptglmaintance.Size = New System.Drawing.Size(90, 20)
        Me.dtptglmaintance.TabIndex = 69
        '
        'lblkilometer
        '
        Me.lblkilometer.AutoSize = True
        Me.lblkilometer.Location = New System.Drawing.Point(51, 320)
        Me.lblkilometer.Name = "lblkilometer"
        Me.lblkilometer.Size = New System.Drawing.Size(50, 13)
        Me.lblkilometer.TabIndex = 70
        Me.lblkilometer.Text = "Kilometer"
        '
        'txtkilometer
        '
        Me.txtkilometer.Location = New System.Drawing.Point(114, 317)
        Me.txtkilometer.Name = "txtkilometer"
        Me.txtkilometer.Size = New System.Drawing.Size(142, 20)
        Me.txtkilometer.TabIndex = 71
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbsopir)
        Me.GroupBox1.Controls.Add(Me.txtketerangan)
        Me.GroupBox1.Controls.Add(Me.txtkilometer)
        Me.GroupBox1.Controls.Add(Me.lblNoMaintance)
        Me.GroupBox1.Controls.Add(Me.lblkilometer)
        Me.GroupBox1.Controls.Add(Me.txtKodeMaintance)
        Me.GroupBox1.Controls.Add(Me.dtptglmaintance)
        Me.GroupBox1.Controls.Add(Me.lblNolambung)
        Me.GroupBox1.Controls.Add(Me.txtbiaya)
        Me.GroupBox1.Controls.Add(Me.cmbnolambung)
        Me.GroupBox1.Controls.Add(Me.lbltgl)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.cbktidakrutin)
        Me.GroupBox1.Controls.Add(Me.lblNamaPekerjaan)
        Me.GroupBox1.Controls.Add(Me.cbkrutin)
        Me.GroupBox1.Controls.Add(Me.cmbNamaPekerjaan)
        Me.GroupBox1.Controls.Add(Me.lbltukang)
        Me.GroupBox1.Controls.Add(Me.lblKeterangan)
        Me.GroupBox1.Controls.Add(Me.txttukang)
        Me.GroupBox1.Controls.Add(Me.lblbiaya)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 346)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Master"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(73, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Sopir"
        '
        'cmbsopir
        '
        Me.cmbsopir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsopir.FormattingEnabled = True
        Me.cmbsopir.Location = New System.Drawing.Point(114, 102)
        Me.cmbsopir.Name = "cmbsopir"
        Me.cmbsopir.Size = New System.Drawing.Size(178, 21)
        Me.cmbsopir.TabIndex = 73
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpTglAmbil)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblsisastock)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btntambah)
        Me.GroupBox2.Controls.Add(Me.txtDetailKeterangan)
        Me.GroupBox2.Controls.Add(Me.txtBiayadetail)
        Me.GroupBox2.Controls.Add(Me.txtJumlah)
        Me.GroupBox2.Controls.Add(Me.txtNoSeri)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblNamaSparepart)
        Me.GroupBox2.Controls.Add(Me.cmbNamaSparepart)
        Me.GroupBox2.Location = New System.Drawing.Point(363, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(325, 345)
        Me.GroupBox2.TabIndex = 73
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail"
        '
        'dtpTglAmbil
        '
        Me.dtpTglAmbil.CustomFormat = "dd-MM-yyyy"
        Me.dtpTglAmbil.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTglAmbil.Location = New System.Drawing.Point(99, 196)
        Me.dtpTglAmbil.Name = "dtpTglAmbil"
        Me.dtpTglAmbil.Size = New System.Drawing.Size(102, 20)
        Me.dtpTglAmbil.TabIndex = 81
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Tanggal"
        '
        'lblsisastock
        '
        Me.lblsisastock.AutoSize = True
        Me.lblsisastock.Location = New System.Drawing.Point(96, 64)
        Me.lblsisastock.Name = "lblsisastock"
        Me.lblsisastock.Size = New System.Drawing.Size(13, 13)
        Me.lblsisastock.TabIndex = 79
        Me.lblsisastock.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Sisa Stock"
        '
        'btntambah
        '
        Me.btntambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.btntambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntambah.Location = New System.Drawing.Point(231, 283)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 31)
        Me.btntambah.TabIndex = 77
        Me.btntambah.Text = "Tambah"
        Me.btntambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'txtDetailKeterangan
        '
        Me.txtDetailKeterangan.Location = New System.Drawing.Point(99, 227)
        Me.txtDetailKeterangan.Multiline = True
        Me.txtDetailKeterangan.Name = "txtDetailKeterangan"
        Me.txtDetailKeterangan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetailKeterangan.Size = New System.Drawing.Size(207, 42)
        Me.txtDetailKeterangan.TabIndex = 76
        '
        'txtBiayadetail
        '
        Me.txtBiayadetail.Enabled = False
        Me.txtBiayadetail.Location = New System.Drawing.Point(96, 164)
        Me.txtBiayadetail.Name = "txtBiayadetail"
        Me.txtBiayadetail.Size = New System.Drawing.Size(178, 20)
        Me.txtBiayadetail.TabIndex = 74
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(96, 128)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(105, 20)
        Me.txtJumlah.TabIndex = 73
        '
        'txtNoSeri
        '
        Me.txtNoSeri.Location = New System.Drawing.Point(96, 94)
        Me.txtNoSeri.Name = "txtNoSeri"
        Me.txtNoSeri.Size = New System.Drawing.Size(146, 20)
        Me.txtNoSeri.TabIndex = 72
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Keterangan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Biaya"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Jumlah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "No Seri"
        '
        'lblNamaSparepart
        '
        Me.lblNamaSparepart.AutoSize = True
        Me.lblNamaSparepart.Location = New System.Drawing.Point(8, 34)
        Me.lblNamaSparepart.Name = "lblNamaSparepart"
        Me.lblNamaSparepart.Size = New System.Drawing.Size(84, 13)
        Me.lblNamaSparepart.TabIndex = 59
        Me.lblNamaSparepart.Text = "Nama Sparepart"
        '
        'cmbNamaSparepart
        '
        Me.cmbNamaSparepart.FormattingEnabled = True
        Me.cmbNamaSparepart.Location = New System.Drawing.Point(96, 31)
        Me.cmbNamaSparepart.Name = "cmbNamaSparepart"
        Me.cmbNamaSparepart.Size = New System.Drawing.Size(150, 21)
        Me.cmbNamaSparepart.TabIndex = 60
        '
        'dgvdetailmaintance
        '
        Me.dgvdetailmaintance.AllowUserToAddRows = False
        Me.dgvdetailmaintance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetailmaintance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.namasparepart, Me.noseri, Me.jumlah, Me.biaya, Me.keterangan, Me.tglambil})
        Me.dgvdetailmaintance.Location = New System.Drawing.Point(9, 364)
        Me.dgvdetailmaintance.Name = "dgvdetailmaintance"
        Me.dgvdetailmaintance.ReadOnly = True
        Me.dgvdetailmaintance.Size = New System.Drawing.Size(924, 211)
        Me.dgvdetailmaintance.TabIndex = 74
        '
        'namasparepart
        '
        Me.namasparepart.DataPropertyName = "namasparepart"
        Me.namasparepart.HeaderText = "Nama Sparepart"
        Me.namasparepart.Name = "namasparepart"
        Me.namasparepart.ReadOnly = True
        '
        'noseri
        '
        Me.noseri.DataPropertyName = "noseri"
        Me.noseri.HeaderText = "No Seri"
        Me.noseri.Name = "noseri"
        Me.noseri.ReadOnly = True
        '
        'jumlah
        '
        Me.jumlah.DataPropertyName = "jumlah"
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.ReadOnly = True
        '
        'biaya
        '
        Me.biaya.DataPropertyName = "biaya"
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.biaya.DefaultCellStyle = DataGridViewCellStyle1
        Me.biaya.HeaderText = "Biaya"
        Me.biaya.Name = "biaya"
        Me.biaya.ReadOnly = True
        '
        'keterangan
        '
        Me.keterangan.DataPropertyName = "keterangan"
        Me.keterangan.HeaderText = "Keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.ReadOnly = True
        '
        'tglambil
        '
        Me.tglambil.DataPropertyName = "tglambil"
        Me.tglambil.HeaderText = "Tanggal"
        Me.tglambil.Name = "tglambil"
        Me.tglambil.ReadOnly = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnsimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsimpan.Location = New System.Drawing.Point(779, 586)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 31)
        Me.btnsimpan.TabIndex = 76
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Image = Global.RukunJaya.My.Resources.Resources.cancelbr
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(858, 586)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 31)
        Me.btnBatal.TabIndex = 77
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'dgvstock
        '
        Me.dgvstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvstock.Location = New System.Drawing.Point(210, 463)
        Me.dgvstock.Name = "dgvstock"
        Me.dgvstock.Size = New System.Drawing.Size(310, 92)
        Me.dgvstock.TabIndex = 78
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox6)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(694, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(239, 338)
        Me.GroupBox3.TabIndex = 79
        Me.GroupBox3.TabStop = False
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(20, 200)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(213, 20)
        Me.TextBox6.TabIndex = 67
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(20, 174)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(213, 20)
        Me.TextBox5.TabIndex = 66
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(20, 148)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(213, 20)
        Me.TextBox4.TabIndex = 65
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(20, 124)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(213, 20)
        Me.TextBox3.TabIndex = 64
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(20, 97)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(213, 20)
        Me.TextBox2.TabIndex = 63
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Tindakan"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(20, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(213, 20)
        Me.TextBox1.TabIndex = 61
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Kerusakan : "
        '
        'frmDetailMaintance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 629)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.dgvdetailmaintance)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvstock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetailMaintance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Detail Maintance :."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvdetailmaintance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvstock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents cmbnolambung As System.Windows.Forms.ComboBox
    Friend WithEvents lblNolambung As System.Windows.Forms.Label
    Friend WithEvents txtKodeMaintance As System.Windows.Forms.TextBox
    Friend WithEvents lblNoMaintance As System.Windows.Forms.Label
    Friend WithEvents cmbNamaPekerjaan As System.Windows.Forms.ComboBox
    Friend WithEvents lblNamaPekerjaan As System.Windows.Forms.Label
    Friend WithEvents lbltukang As System.Windows.Forms.Label
    Friend WithEvents txttukang As System.Windows.Forms.TextBox
    Friend WithEvents lblKeterangan As System.Windows.Forms.Label
    Friend WithEvents txtketerangan As System.Windows.Forms.TextBox
    Friend WithEvents cbkrutin As System.Windows.Forms.CheckBox
    Friend WithEvents cbktidakrutin As System.Windows.Forms.CheckBox
    Friend WithEvents lblbiaya As System.Windows.Forms.Label
    Friend WithEvents lbltgl As System.Windows.Forms.Label
    Friend WithEvents txtbiaya As System.Windows.Forms.TextBox
    Friend WithEvents dtptglmaintance As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblkilometer As System.Windows.Forms.Label
    Friend WithEvents txtkilometer As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNamaSparepart As System.Windows.Forms.Label
    Friend WithEvents cmbNamaSparepart As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBiayadetail As System.Windows.Forms.TextBox
    Friend WithEvents txtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents txtNoSeri As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvdetailmaintance As System.Windows.Forms.DataGridView
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents txtDetailKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents dgvstock As System.Windows.Forms.DataGridView
    Friend WithEvents lblsisastock As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpTglAmbil As System.Windows.Forms.DateTimePicker
    Friend WithEvents namasparepart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents noseri As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents biaya As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tglambil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbsopir As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
