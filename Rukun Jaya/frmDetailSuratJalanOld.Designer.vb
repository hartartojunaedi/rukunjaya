<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailSuratJalanOld
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetailSuratJalanOld))
        Me.txtnosuratjalan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtketerangan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtptgldatang = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.cbnamaperwakilan = New System.Windows.Forms.ComboBox()
        Me.dtptglmuat = New System.Windows.Forms.DateTimePicker()
        Me.dtptglbongkar = New System.Windows.Forms.DateTimePicker()
        Me.cbnamasupplier = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtkodebarang = New System.Windows.Forms.TextBox()
        Me.btnbrowse = New System.Windows.Forms.Button()
        Me.lblnamabarang = New System.Windows.Forms.Label()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtnodo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtnoshippinglist = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtsangu = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtbon = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtbonlain = New System.Windows.Forms.TextBox()
        Me.txtketeranganbon = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dtptanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cbgudangasal = New System.Windows.Forms.ComboBox()
        Me.cbgudangtujuan = New System.Windows.Forms.ComboBox()
        Me.cbjenispekerjaan = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.gbvoucher = New System.Windows.Forms.GroupBox()
        Me.lblliter = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.btntambahvoucher = New System.Windows.Forms.Button()
        Me.cbspbu = New System.Windows.Forms.ComboBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.dgvvoucher = New System.Windows.Forms.DataGridView()
        Me.kodevoucher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.voucher_nobm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.voucher_nosuratjalan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kodespbu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.voucher_Nama_SPBU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kodeperwakilan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.liter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sisa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rupiahsatuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rupiah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tglvoucher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kasbon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.voucher_Hapus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtkasbon = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtliter = New System.Windows.Forms.TextBox()
        Me.txthrgsatuan = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtkodevoucher = New System.Windows.Forms.TextBox()
        Me.gbdetail = New System.Windows.Forms.GroupBox()
        Me.dgvdetailsuratjalan = New System.Windows.Forms.DataGridView()
        Me.nobm1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nosuratjalan1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kodebarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namabarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.noshippinglist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hapus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.pbsent = New System.Windows.Forms.PictureBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblJumlah = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtbeban = New System.Windows.Forms.TextBox()
        Me.txtketbeban = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtUM = New System.Windows.Forms.TextBox()
        Me.dtpTglJadwal = New System.Windows.Forms.DateTimePicker()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.gbvoucher.SuspendLayout()
        CType(Me.dgvvoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbdetail.SuspendLayout()
        CType(Me.dgvdetailsuratjalan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbsent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnosuratjalan
        '
        Me.txtnosuratjalan.AcceptsTab = True
        Me.txtnosuratjalan.Location = New System.Drawing.Point(117, 13)
        Me.txtnosuratjalan.Name = "txtnosuratjalan"
        Me.txtnosuratjalan.Size = New System.Drawing.Size(125, 20)
        Me.txtnosuratjalan.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "No Surat Jalan : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nama Supplier :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nama Perwakilan:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Asal :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(388, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Tujuan :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Tgl Datang :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Tgl Muat :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Tgl Bongkar:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtketerangan
        '
        Me.txtketerangan.Location = New System.Drawing.Point(440, 85)
        Me.txtketerangan.Multiline = True
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.Size = New System.Drawing.Size(240, 63)
        Me.txtketerangan.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(360, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Keterangan :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dtptgldatang
        '
        Me.dtptgldatang.CustomFormat = "dd-MM-yyyy"
        Me.dtptgldatang.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptgldatang.Location = New System.Drawing.Point(117, 106)
        Me.dtptgldatang.Name = "dtptgldatang"
        Me.dtptgldatang.Size = New System.Drawing.Size(97, 20)
        Me.dtptgldatang.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(807, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Mode :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Location = New System.Drawing.Point(853, 9)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(22, 13)
        Me.lblMode.TabIndex = 30
        Me.lblMode.Text = "xxx"
        Me.lblMode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbnamaperwakilan
        '
        Me.cbnamaperwakilan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbnamaperwakilan.FormattingEnabled = True
        Me.cbnamaperwakilan.Location = New System.Drawing.Point(116, 59)
        Me.cbnamaperwakilan.Name = "cbnamaperwakilan"
        Me.cbnamaperwakilan.Size = New System.Drawing.Size(159, 21)
        Me.cbnamaperwakilan.TabIndex = 5
        '
        'dtptglmuat
        '
        Me.dtptglmuat.CustomFormat = "dd-MM-yyyy"
        Me.dtptglmuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptglmuat.Location = New System.Drawing.Point(116, 128)
        Me.dtptglmuat.Name = "dtptglmuat"
        Me.dtptglmuat.Size = New System.Drawing.Size(97, 20)
        Me.dtptglmuat.TabIndex = 9
        '
        'dtptglbongkar
        '
        Me.dtptglbongkar.CustomFormat = "dd-MM-yyyy"
        Me.dtptglbongkar.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptglbongkar.Location = New System.Drawing.Point(116, 150)
        Me.dtptglbongkar.Name = "dtptglbongkar"
        Me.dtptglbongkar.Size = New System.Drawing.Size(97, 20)
        Me.dtptglbongkar.TabIndex = 10
        '
        'cbnamasupplier
        '
        Me.cbnamasupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbnamasupplier.FormattingEnabled = True
        Me.cbnamasupplier.Location = New System.Drawing.Point(116, 35)
        Me.cbnamasupplier.Name = "cbnamasupplier"
        Me.cbnamasupplier.Size = New System.Drawing.Size(159, 21)
        Me.cbnamasupplier.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 371)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(183, 24)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Detail Surat Jalan :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 13)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Kode Barang :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(236, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 13)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Nama Barang :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtkodebarang
        '
        Me.txtkodebarang.Enabled = False
        Me.txtkodebarang.Location = New System.Drawing.Point(93, 15)
        Me.txtkodebarang.Name = "txtkodebarang"
        Me.txtkodebarang.Size = New System.Drawing.Size(100, 20)
        Me.txtkodebarang.TabIndex = 16
        Me.txtkodebarang.Text = " "
        '
        'btnbrowse
        '
        Me.btnbrowse.Location = New System.Drawing.Point(198, 13)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.Size = New System.Drawing.Size(30, 23)
        Me.btnbrowse.TabIndex = 17
        Me.btnbrowse.Text = "..."
        Me.btnbrowse.UseVisualStyleBackColor = True
        '
        'lblnamabarang
        '
        Me.lblnamabarang.AutoSize = True
        Me.lblnamabarang.Location = New System.Drawing.Point(315, 22)
        Me.lblnamabarang.Name = "lblnamabarang"
        Me.lblnamabarang.Size = New System.Drawing.Size(76, 13)
        Me.lblnamabarang.TabIndex = 58
        Me.lblnamabarang.Text = "lblnamabarang"
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(464, 19)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(42, 20)
        Me.txtjumlah.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(414, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "Jumlah :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtnodo
        '
        Me.txtnodo.Location = New System.Drawing.Point(93, 41)
        Me.txtnodo.Name = "txtnodo"
        Me.txtnodo.Size = New System.Drawing.Size(78, 20)
        Me.txtnodo.TabIndex = 19
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(41, 45)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 13)
        Me.Label16.TabIndex = 61
        Me.Label16.Text = "No DO :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtnoshippinglist
        '
        Me.txtnoshippinglist.Location = New System.Drawing.Point(318, 42)
        Me.txtnoshippinglist.Name = "txtnoshippinglist"
        Me.txtnoshippinglist.Size = New System.Drawing.Size(78, 20)
        Me.txtnoshippinglist.TabIndex = 20
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(223, 47)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 13)
        Me.Label17.TabIndex = 63
        Me.Label17.Text = "No Shipping List :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(62, 179)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 13)
        Me.Label14.TabIndex = 67
        Me.Label14.Text = "Sangu :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtsangu
        '
        Me.txtsangu.Location = New System.Drawing.Point(117, 174)
        Me.txtsangu.Name = "txtsangu"
        Me.txtsangu.Size = New System.Drawing.Size(104, 20)
        Me.txtsangu.TabIndex = 11
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(74, 199)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(32, 13)
        Me.Label18.TabIndex = 69
        Me.Label18.Text = "Bon :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtbon
        '
        Me.txtbon.Location = New System.Drawing.Point(117, 196)
        Me.txtbon.Name = "txtbon"
        Me.txtbon.Size = New System.Drawing.Size(105, 20)
        Me.txtbon.TabIndex = 12
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(55, 242)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(50, 13)
        Me.Label19.TabIndex = 71
        Me.Label19.Text = "bon lain :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtbonlain
        '
        Me.txtbonlain.Location = New System.Drawing.Point(116, 239)
        Me.txtbonlain.Name = "txtbonlain"
        Me.txtbonlain.Size = New System.Drawing.Size(105, 20)
        Me.txtbonlain.TabIndex = 14
        '
        'txtketeranganbon
        '
        Me.txtketeranganbon.Location = New System.Drawing.Point(116, 262)
        Me.txtketeranganbon.Multiline = True
        Me.txtketeranganbon.Name = "txtketeranganbon"
        Me.txtketeranganbon.Size = New System.Drawing.Size(201, 44)
        Me.txtketeranganbon.TabIndex = 15
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(18, 265)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(89, 13)
        Me.Label20.TabIndex = 72
        Me.Label20.Text = "Keterangan bon :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dtptanggal
        '
        Me.dtptanggal.CustomFormat = "dd-MM-yyyy"
        Me.dtptanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptanggal.Location = New System.Drawing.Point(440, 12)
        Me.dtptanggal.Name = "dtptanggal"
        Me.dtptanggal.Size = New System.Drawing.Size(91, 20)
        Me.dtptanggal.TabIndex = 2
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(389, 19)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 13)
        Me.Label21.TabIndex = 74
        Me.Label21.Text = "Tgl SJ :"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbgudangasal
        '
        Me.cbgudangasal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbgudangasal.FormattingEnabled = True
        Me.cbgudangasal.Location = New System.Drawing.Point(116, 83)
        Me.cbgudangasal.Name = "cbgudangasal"
        Me.cbgudangasal.Size = New System.Drawing.Size(202, 21)
        Me.cbgudangasal.TabIndex = 7
        '
        'cbgudangtujuan
        '
        Me.cbgudangtujuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbgudangtujuan.FormattingEnabled = True
        Me.cbgudangtujuan.Location = New System.Drawing.Point(440, 58)
        Me.cbgudangtujuan.Name = "cbgudangtujuan"
        Me.cbgudangtujuan.Size = New System.Drawing.Size(171, 21)
        Me.cbgudangtujuan.TabIndex = 6
        '
        'cbjenispekerjaan
        '
        Me.cbjenispekerjaan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbjenispekerjaan.FormattingEnabled = True
        Me.cbjenispekerjaan.Location = New System.Drawing.Point(440, 34)
        Me.cbjenispekerjaan.Name = "cbjenispekerjaan"
        Me.cbjenispekerjaan.Size = New System.Drawing.Size(171, 21)
        Me.cbjenispekerjaan.TabIndex = 4
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(344, 38)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(91, 13)
        Me.Label22.TabIndex = 76
        Me.Label22.Text = "Jenis Pekerjaan : "
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'gbvoucher
        '
        Me.gbvoucher.Controls.Add(Me.lblliter)
        Me.gbvoucher.Controls.Add(Me.Label30)
        Me.gbvoucher.Controls.Add(Me.btntambahvoucher)
        Me.gbvoucher.Controls.Add(Me.cbspbu)
        Me.gbvoucher.Controls.Add(Me.lbltotal)
        Me.gbvoucher.Controls.Add(Me.Label28)
        Me.gbvoucher.Controls.Add(Me.dgvvoucher)
        Me.gbvoucher.Controls.Add(Me.Label27)
        Me.gbvoucher.Controls.Add(Me.txtkasbon)
        Me.gbvoucher.Controls.Add(Me.Label26)
        Me.gbvoucher.Controls.Add(Me.Label25)
        Me.gbvoucher.Controls.Add(Me.txtliter)
        Me.gbvoucher.Controls.Add(Me.txthrgsatuan)
        Me.gbvoucher.Controls.Add(Me.Label24)
        Me.gbvoucher.Controls.Add(Me.Label23)
        Me.gbvoucher.Controls.Add(Me.txtkodevoucher)
        Me.gbvoucher.Location = New System.Drawing.Point(323, 149)
        Me.gbvoucher.Name = "gbvoucher"
        Me.gbvoucher.Size = New System.Drawing.Size(641, 240)
        Me.gbvoucher.TabIndex = 77
        Me.gbvoucher.TabStop = False
        Me.gbvoucher.Text = "Voucher SPBU"
        '
        'lblliter
        '
        Me.lblliter.AutoSize = True
        Me.lblliter.Location = New System.Drawing.Point(252, 218)
        Me.lblliter.Name = "lblliter"
        Me.lblliter.Size = New System.Drawing.Size(37, 13)
        Me.lblliter.TabIndex = 88
        Me.lblliter.Text = "Total :"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(190, 218)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(60, 13)
        Me.Label30.TabIndex = 87
        Me.Label30.Text = "Total Liter :"
        '
        'btntambahvoucher
        '
        Me.btntambahvoucher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btntambahvoucher.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon1
        Me.btntambahvoucher.Location = New System.Drawing.Point(494, 29)
        Me.btntambahvoucher.Name = "btntambahvoucher"
        Me.btntambahvoucher.Size = New System.Drawing.Size(80, 29)
        Me.btntambahvoucher.TabIndex = 86
        Me.btntambahvoucher.Text = "&Voucher"
        Me.btntambahvoucher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btntambahvoucher.UseVisualStyleBackColor = True
        '
        'cbspbu
        '
        Me.cbspbu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbspbu.FormattingEnabled = True
        Me.cbspbu.Location = New System.Drawing.Point(255, 22)
        Me.cbspbu.Name = "cbspbu"
        Me.cbspbu.Size = New System.Drawing.Size(233, 21)
        Me.cbspbu.TabIndex = 20
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(506, 218)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(37, 13)
        Me.lbltotal.TabIndex = 84
        Me.lbltotal.Text = "Total :"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(463, 218)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(37, 13)
        Me.Label28.TabIndex = 83
        Me.Label28.Text = "Total :"
        '
        'dgvvoucher
        '
        Me.dgvvoucher.AllowUserToAddRows = False
        Me.dgvvoucher.AllowUserToOrderColumns = True
        Me.dgvvoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvvoucher.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodevoucher, Me.voucher_nobm, Me.voucher_nosuratjalan, Me.kodespbu, Me.voucher_Nama_SPBU, Me.kodeperwakilan, Me.liter, Me.sisa, Me.rupiahsatuan, Me.rupiah, Me.tglvoucher, Me.kasbon, Me.voucher_Hapus})
        Me.dgvvoucher.Location = New System.Drawing.Point(11, 72)
        Me.dgvvoucher.Name = "dgvvoucher"
        Me.dgvvoucher.ReadOnly = True
        Me.dgvvoucher.Size = New System.Drawing.Size(621, 143)
        Me.dgvvoucher.TabIndex = 82
        '
        'kodevoucher
        '
        Me.kodevoucher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.kodevoucher.DataPropertyName = "kodevoucher"
        Me.kodevoucher.HeaderText = "Kode Voucher"
        Me.kodevoucher.Name = "kodevoucher"
        Me.kodevoucher.ReadOnly = True
        '
        'voucher_nobm
        '
        Me.voucher_nobm.DataPropertyName = "nobm"
        Me.voucher_nobm.HeaderText = "No BM"
        Me.voucher_nobm.Name = "voucher_nobm"
        Me.voucher_nobm.ReadOnly = True
        Me.voucher_nobm.Visible = False
        '
        'voucher_nosuratjalan
        '
        Me.voucher_nosuratjalan.DataPropertyName = "nosuratjalan"
        Me.voucher_nosuratjalan.HeaderText = "No Surat Jalan"
        Me.voucher_nosuratjalan.Name = "voucher_nosuratjalan"
        Me.voucher_nosuratjalan.ReadOnly = True
        Me.voucher_nosuratjalan.Visible = False
        '
        'kodespbu
        '
        Me.kodespbu.DataPropertyName = "kodespbu"
        Me.kodespbu.HeaderText = "Kode SPBU"
        Me.kodespbu.Name = "kodespbu"
        Me.kodespbu.ReadOnly = True
        Me.kodespbu.Visible = False
        '
        'voucher_Nama_SPBU
        '
        Me.voucher_Nama_SPBU.DataPropertyName = "namaspbu"
        Me.voucher_Nama_SPBU.HeaderText = "SPBU"
        Me.voucher_Nama_SPBU.Name = "voucher_Nama_SPBU"
        Me.voucher_Nama_SPBU.ReadOnly = True
        '
        'kodeperwakilan
        '
        Me.kodeperwakilan.DataPropertyName = "kodeperwakilan"
        Me.kodeperwakilan.HeaderText = "Kode Perwakilan"
        Me.kodeperwakilan.Name = "kodeperwakilan"
        Me.kodeperwakilan.ReadOnly = True
        Me.kodeperwakilan.Visible = False
        '
        'liter
        '
        Me.liter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.liter.DataPropertyName = "liter"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.liter.DefaultCellStyle = DataGridViewCellStyle1
        Me.liter.HeaderText = "liter"
        Me.liter.Name = "liter"
        Me.liter.ReadOnly = True
        Me.liter.Width = 48
        '
        'sisa
        '
        Me.sisa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.sisa.DataPropertyName = "sisa"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.sisa.DefaultCellStyle = DataGridViewCellStyle2
        Me.sisa.HeaderText = "sisa"
        Me.sisa.Name = "sisa"
        Me.sisa.ReadOnly = True
        Me.sisa.Visible = False
        '
        'rupiahsatuan
        '
        Me.rupiahsatuan.DataPropertyName = "rupiahsatuan"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.rupiahsatuan.DefaultCellStyle = DataGridViewCellStyle3
        Me.rupiahsatuan.HeaderText = "Rupiah/Liter"
        Me.rupiahsatuan.Name = "rupiahsatuan"
        Me.rupiahsatuan.ReadOnly = True
        Me.rupiahsatuan.Width = 80
        '
        'rupiah
        '
        Me.rupiah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.rupiah.DataPropertyName = "rupiah"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.rupiah.DefaultCellStyle = DataGridViewCellStyle4
        Me.rupiah.HeaderText = "Sub Total"
        Me.rupiah.Name = "rupiah"
        Me.rupiah.ReadOnly = True
        Me.rupiah.Width = 78
        '
        'tglvoucher
        '
        Me.tglvoucher.DataPropertyName = "tglvoucher"
        Me.tglvoucher.HeaderText = "Tgl voucher"
        Me.tglvoucher.Name = "tglvoucher"
        Me.tglvoucher.ReadOnly = True
        Me.tglvoucher.Visible = False
        '
        'kasbon
        '
        Me.kasbon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.kasbon.DataPropertyName = "kasbon"
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.kasbon.DefaultCellStyle = DataGridViewCellStyle5
        Me.kasbon.HeaderText = "Kasbon"
        Me.kasbon.Name = "kasbon"
        Me.kasbon.ReadOnly = True
        Me.kasbon.Width = 68
        '
        'voucher_Hapus
        '
        Me.voucher_Hapus.HeaderText = "Hapus"
        Me.voucher_Hapus.Name = "voucher_Hapus"
        Me.voucher_Hapus.ReadOnly = True
        Me.voucher_Hapus.Text = "Hapus"
        Me.voucher_Hapus.UseColumnTextForButtonValue = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(331, 49)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(51, 13)
        Me.Label27.TabIndex = 81
        Me.Label27.Text = "kas bon :"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtkasbon
        '
        Me.txtkasbon.Location = New System.Drawing.Point(383, 46)
        Me.txtkasbon.Name = "txtkasbon"
        Me.txtkasbon.Size = New System.Drawing.Size(105, 20)
        Me.txtkasbon.TabIndex = 23
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(178, 50)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(75, 13)
        Me.Label26.TabIndex = 79
        Me.Label26.Text = "harga satuan :"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(87, 51)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(29, 13)
        Me.Label25.TabIndex = 77
        Me.Label25.Text = "liter :"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtliter
        '
        Me.txtliter.Location = New System.Drawing.Point(117, 46)
        Me.txtliter.Name = "txtliter"
        Me.txtliter.Size = New System.Drawing.Size(45, 20)
        Me.txtliter.TabIndex = 21
        '
        'txthrgsatuan
        '
        Me.txthrgsatuan.Location = New System.Drawing.Point(255, 46)
        Me.txthrgsatuan.Name = "txthrgsatuan"
        Me.txthrgsatuan.Size = New System.Drawing.Size(55, 20)
        Me.txthrgsatuan.TabIndex = 22
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(212, 28)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(42, 13)
        Me.Label24.TabIndex = 75
        Me.Label24.Text = "SPBU :"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(35, 29)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(81, 13)
        Me.Label23.TabIndex = 73
        Me.Label23.Text = "Kode Voucher :"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtkodevoucher
        '
        Me.txtkodevoucher.Location = New System.Drawing.Point(117, 22)
        Me.txtkodevoucher.Name = "txtkodevoucher"
        Me.txtkodevoucher.Size = New System.Drawing.Size(81, 20)
        Me.txtkodevoucher.TabIndex = 19
        '
        'gbdetail
        '
        Me.gbdetail.Controls.Add(Me.dgvdetailsuratjalan)
        Me.gbdetail.Controls.Add(Me.btntambah)
        Me.gbdetail.Controls.Add(Me.Label11)
        Me.gbdetail.Controls.Add(Me.Label13)
        Me.gbdetail.Controls.Add(Me.txtkodebarang)
        Me.gbdetail.Controls.Add(Me.btnbrowse)
        Me.gbdetail.Controls.Add(Me.lblnamabarang)
        Me.gbdetail.Controls.Add(Me.Label15)
        Me.gbdetail.Controls.Add(Me.txtjumlah)
        Me.gbdetail.Controls.Add(Me.Label16)
        Me.gbdetail.Controls.Add(Me.txtnodo)
        Me.gbdetail.Controls.Add(Me.Label17)
        Me.gbdetail.Controls.Add(Me.txtnoshippinglist)
        Me.gbdetail.Location = New System.Drawing.Point(9, 395)
        Me.gbdetail.Name = "gbdetail"
        Me.gbdetail.Size = New System.Drawing.Size(955, 247)
        Me.gbdetail.TabIndex = 78
        Me.gbdetail.TabStop = False
        '
        'dgvdetailsuratjalan
        '
        Me.dgvdetailsuratjalan.AllowUserToAddRows = False
        Me.dgvdetailsuratjalan.AllowUserToOrderColumns = True
        Me.dgvdetailsuratjalan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetailsuratjalan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nobm1, Me.nosuratjalan1, Me.kodebarang, Me.namabarang, Me.jumlah, Me.nodo, Me.noshippinglist, Me.hapus})
        Me.dgvdetailsuratjalan.Location = New System.Drawing.Point(6, 65)
        Me.dgvdetailsuratjalan.Name = "dgvdetailsuratjalan"
        Me.dgvdetailsuratjalan.ReadOnly = True
        Me.dgvdetailsuratjalan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvdetailsuratjalan.Size = New System.Drawing.Size(940, 176)
        Me.dgvdetailsuratjalan.TabIndex = 64
        '
        'nobm1
        '
        Me.nobm1.DataPropertyName = "nobm"
        Me.nobm1.HeaderText = "No BM"
        Me.nobm1.Name = "nobm1"
        Me.nobm1.ReadOnly = True
        Me.nobm1.Visible = False
        '
        'nosuratjalan1
        '
        Me.nosuratjalan1.DataPropertyName = "nosuratjalan"
        Me.nosuratjalan1.HeaderText = "No SJ"
        Me.nosuratjalan1.Name = "nosuratjalan1"
        Me.nosuratjalan1.ReadOnly = True
        Me.nosuratjalan1.Visible = False
        '
        'kodebarang
        '
        Me.kodebarang.DataPropertyName = "kodebarang"
        Me.kodebarang.HeaderText = "Kode Barang"
        Me.kodebarang.Name = "kodebarang"
        Me.kodebarang.ReadOnly = True
        '
        'namabarang
        '
        Me.namabarang.DataPropertyName = "namabarang"
        Me.namabarang.HeaderText = "Nama Barang"
        Me.namabarang.Name = "namabarang"
        Me.namabarang.ReadOnly = True
        Me.namabarang.Width = 150
        '
        'jumlah
        '
        Me.jumlah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.jumlah.DataPropertyName = "jumlah"
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.ReadOnly = True
        Me.jumlah.Width = 65
        '
        'nodo
        '
        Me.nodo.DataPropertyName = "nodo"
        Me.nodo.HeaderText = "No DO"
        Me.nodo.Name = "nodo"
        Me.nodo.ReadOnly = True
        Me.nodo.Width = 65
        '
        'noshippinglist
        '
        Me.noshippinglist.DataPropertyName = "noshippinglist"
        Me.noshippinglist.HeaderText = "No Shipping List"
        Me.noshippinglist.Name = "noshippinglist"
        Me.noshippinglist.ReadOnly = True
        '
        'hapus
        '
        Me.hapus.HeaderText = "Hapus"
        Me.hapus.Name = "hapus"
        Me.hapus.ReadOnly = True
        Me.hapus.Text = "Hapus"
        Me.hapus.UseColumnTextForButtonValue = True
        Me.hapus.Width = 45
        '
        'btntambah
        '
        Me.btntambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btntambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.btntambah.Location = New System.Drawing.Point(524, 15)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(80, 29)
        Me.btntambah.TabIndex = 21
        Me.btntambah.Text = "&Tambah"
        Me.btntambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'pbsent
        '
        Me.pbsent.Image = CType(resources.GetObject("pbsent.Image"), System.Drawing.Image)
        Me.pbsent.Location = New System.Drawing.Point(697, 25)
        Me.pbsent.Name = "pbsent"
        Me.pbsent.Size = New System.Drawing.Size(178, 127)
        Me.pbsent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbsent.TabIndex = 79
        Me.pbsent.TabStop = False
        '
        'btnBatal
        '
        Me.btnBatal.Image = Global.RukunJaya.My.Resources.Resources.cancelbr
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(553, 642)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(80, 29)
        Me.btnBatal.TabIndex = 32
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(452, 642)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(80, 29)
        Me.btnSimpan.TabIndex = 31
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(245, 650)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(40, 13)
        Me.Label29.TabIndex = 80
        Me.Label29.Text = "Total : "
        '
        'lblJumlah
        '
        Me.lblJumlah.Location = New System.Drawing.Point(280, 646)
        Me.lblJumlah.Name = "lblJumlah"
        Me.lblJumlah.Size = New System.Drawing.Size(100, 23)
        Me.lblJumlah.TabIndex = 81
        Me.lblJumlah.Text = "0"
        Me.lblJumlah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(-3, 308)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(103, 45)
        Me.Label31.TabIndex = 82
        Me.Label31.Text = "Biaya Operasional (Beban Perusahaan)"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtbeban
        '
        Me.txtbeban.Location = New System.Drawing.Point(116, 305)
        Me.txtbeban.Name = "txtbeban"
        Me.txtbeban.Size = New System.Drawing.Size(105, 20)
        Me.txtbeban.TabIndex = 16
        '
        'txtketbeban
        '
        Me.txtketbeban.Location = New System.Drawing.Point(116, 328)
        Me.txtketbeban.Multiline = True
        Me.txtketbeban.Name = "txtketbeban"
        Me.txtketbeban.Size = New System.Drawing.Size(201, 44)
        Me.txtketbeban.TabIndex = 17
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(30, 225)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(75, 13)
        Me.Label32.TabIndex = 86
        Me.Label32.Text = "Uang Makan :"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtUM
        '
        Me.txtUM.Location = New System.Drawing.Point(116, 219)
        Me.txtUM.Name = "txtUM"
        Me.txtUM.Size = New System.Drawing.Size(105, 20)
        Me.txtUM.TabIndex = 13
        '
        'dtpTglJadwal
        '
        Me.dtpTglJadwal.CustomFormat = "dd-MM-yyyy"
        Me.dtpTglJadwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTglJadwal.Location = New System.Drawing.Point(283, 105)
        Me.dtpTglJadwal.Name = "dtpTglJadwal"
        Me.dtpTglJadwal.Size = New System.Drawing.Size(97, 20)
        Me.dtpTglJadwal.TabIndex = 9
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(220, 110)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(64, 13)
        Me.Label33.TabIndex = 88
        Me.Label33.Text = "Tgl Jadwal :"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmDetailSuratJalanOld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 678)
        Me.Controls.Add(Me.dtpTglJadwal)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.txtUM)
        Me.Controls.Add(Me.txtketbeban)
        Me.Controls.Add(Me.txtbeban)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.lblJumlah)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.pbsent)
        Me.Controls.Add(Me.gbdetail)
        Me.Controls.Add(Me.gbvoucher)
        Me.Controls.Add(Me.cbjenispekerjaan)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cbgudangtujuan)
        Me.Controls.Add(Me.cbgudangasal)
        Me.Controls.Add(Me.dtptanggal)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtketeranganbon)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtbonlain)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtbon)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtsangu)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbnamasupplier)
        Me.Controls.Add(Me.dtptglbongkar)
        Me.Controls.Add(Me.dtptglmuat)
        Me.Controls.Add(Me.cbnamaperwakilan)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.lblMode)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dtptgldatang)
        Me.Controls.Add(Me.txtketerangan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnosuratjalan)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetailSuratJalanOld"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Tambah Surat Jalan :."
        Me.gbvoucher.ResumeLayout(False)
        Me.gbvoucher.PerformLayout()
        CType(Me.dgvvoucher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbdetail.ResumeLayout(False)
        Me.gbdetail.PerformLayout()
        CType(Me.dgvdetailsuratjalan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbsent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnosuratjalan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtketerangan As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtptgldatang As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblMode As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents cbnamaperwakilan As System.Windows.Forms.ComboBox
    Friend WithEvents dtptglmuat As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtptglbongkar As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbnamasupplier As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtkodebarang As System.Windows.Forms.TextBox
    Friend WithEvents btnbrowse As System.Windows.Forms.Button
    Friend WithEvents lblnamabarang As System.Windows.Forms.Label
    Friend WithEvents txtjumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtnodo As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtnoshippinglist As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtsangu As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtbon As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtbonlain As System.Windows.Forms.TextBox
    Friend WithEvents txtketeranganbon As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents dtptanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cbgudangasal As System.Windows.Forms.ComboBox
    Friend WithEvents cbgudangtujuan As System.Windows.Forms.ComboBox
    Friend WithEvents cbjenispekerjaan As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents gbvoucher As System.Windows.Forms.GroupBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtliter As System.Windows.Forms.TextBox
    Friend WithEvents txthrgsatuan As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtkodevoucher As System.Windows.Forms.TextBox
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents dgvvoucher As System.Windows.Forms.DataGridView
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtkasbon As System.Windows.Forms.TextBox
    Friend WithEvents btntambahvoucher As System.Windows.Forms.Button
    Friend WithEvents cbspbu As System.Windows.Forms.ComboBox
    Friend WithEvents lblliter As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents gbdetail As System.Windows.Forms.GroupBox
    Friend WithEvents dgvdetailsuratjalan As System.Windows.Forms.DataGridView
    Friend WithEvents nobm1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nosuratjalan1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kodebarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namabarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nodo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents noshippinglist As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hapus As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents pbsent As System.Windows.Forms.PictureBox
    Friend WithEvents kodevoucher As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents voucher_nobm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents voucher_nosuratjalan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kodespbu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents voucher_Nama_SPBU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kodeperwakilan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents liter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sisa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rupiahsatuan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rupiah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tglvoucher As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kasbon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents voucher_Hapus As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents lblJumlah As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtbeban As System.Windows.Forms.TextBox
    Friend WithEvents txtketbeban As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtUM As System.Windows.Forms.TextBox
    Friend WithEvents dtpTglJadwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label33 As System.Windows.Forms.Label
End Class
