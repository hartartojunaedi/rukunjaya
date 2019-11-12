<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTotalanAkhir
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btncari = New System.Windows.Forms.Button()
        Me.txtkodesopir = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblnamasopir = New System.Windows.Forms.Label()
        Me.dgvTotalan = New System.Windows.Forms.DataGridView()
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
        Me.nototalan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diterima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.borongan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sangusolar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvTotalan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgtotalan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBiayaLain, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgvTotalan.Size = New System.Drawing.Size(873, 118)
        Me.dgvTotalan.TabIndex = 7
        '
        'dgtotalan
        '
        Me.dgtotalan.AllowUserToAddRows = False
        Me.dgtotalan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtotalan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ntotalan, Me.terima})
        Me.dgtotalan.Location = New System.Drawing.Point(17, 169)
        Me.dgtotalan.Name = "dgtotalan"
        Me.dgtotalan.ReadOnly = True
        Me.dgtotalan.Size = New System.Drawing.Size(289, 150)
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
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = "0"
        Me.terima.DefaultCellStyle = DataGridViewCellStyle4
        Me.terima.HeaderText = "Terima"
        Me.terima.Name = "terima"
        Me.terima.ReadOnly = True
        '
        'dgvBiayaLain
        '
        Me.dgvBiayaLain.AllowUserToAddRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBiayaLain.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvBiayaLain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBiayaLain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodetransaksi, Me.txtTanggalTransaksi, Me.txtJenis, Me.txtBiaya, Me.Sisa, Me.Bayarkasbon})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBiayaLain.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvBiayaLain.Location = New System.Drawing.Point(322, 169)
        Me.dgvBiayaLain.Name = "dgvBiayaLain"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBiayaLain.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvBiayaLain.Size = New System.Drawing.Size(568, 150)
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
        DataGridViewCellStyle6.Format = "dd-MM-yyyy"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.txtTanggalTransaksi.DefaultCellStyle = DataGridViewCellStyle6
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.txtBiaya.DefaultCellStyle = DataGridViewCellStyle7
        Me.txtBiaya.HeaderText = "Harga"
        Me.txtBiaya.Name = "txtBiaya"
        Me.txtBiaya.ReadOnly = True
        '
        'Sisa
        '
        Me.Sisa.DataPropertyName = "sisa"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle8.Format = "N"
        Me.Sisa.DefaultCellStyle = DataGridViewCellStyle8
        Me.Sisa.HeaderText = "Sisa"
        Me.Sisa.Name = "Sisa"
        Me.Sisa.ReadOnly = True
        '
        'Bayarkasbon
        '
        Me.Bayarkasbon.DataPropertyName = "bayarkasbon"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle9.Format = "N"
        Me.Bayarkasbon.DefaultCellStyle = DataGridViewCellStyle9
        Me.Bayarkasbon.HeaderText = "Bayar"
        Me.Bayarkasbon.Name = "Bayarkasbon"
        '
        'lbltotalbayarkasbon
        '
        Me.lbltotalbayarkasbon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalbayarkasbon.Location = New System.Drawing.Point(309, 366)
        Me.lbltotalbayarkasbon.Name = "lbltotalbayarkasbon"
        Me.lbltotalbayarkasbon.Size = New System.Drawing.Size(100, 17)
        Me.lbltotalbayarkasbon.TabIndex = 92
        Me.lbltotalbayarkasbon.Text = "Label4"
        Me.lbltotalbayarkasbon.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 366)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 13)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Total Bayar Kas Bon : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 335)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Total Terima"
        '
        'lbltotalterima
        '
        Me.lbltotalterima.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalterima.Location = New System.Drawing.Point(206, 335)
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
        Me.Label4.Location = New System.Drawing.Point(16, 397)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Tambahan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 430)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "Potongan"
        '
        'txttambahan
        '
        Me.txttambahan.Location = New System.Drawing.Point(205, 389)
        Me.txttambahan.Name = "txttambahan"
        Me.txttambahan.Size = New System.Drawing.Size(100, 20)
        Me.txttambahan.TabIndex = 97
        Me.txttambahan.Text = "0"
        '
        'txtpotongan
        '
        Me.txtpotongan.Location = New System.Drawing.Point(312, 423)
        Me.txtpotongan.Name = "txtpotongan"
        Me.txtpotongan.Size = New System.Drawing.Size(100, 20)
        Me.txtpotongan.TabIndex = 98
        Me.txtpotongan.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 469)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "Grand Total"
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandTotal.Location = New System.Drawing.Point(202, 469)
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
        Me.Label7.Location = New System.Drawing.Point(432, 335)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 13)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "No Grand Totalan :"
        '
        'dtpTanggal
        '
        Me.dtpTanggal.CustomFormat = "dd-MM-yyyy"
        Me.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTanggal.Location = New System.Drawing.Point(804, 335)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(86, 20)
        Me.dtpTanggal.TabIndex = 102
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(741, 335)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "Tanggal "
        '
        'txtnototalan
        '
        Me.txtnototalan.Location = New System.Drawing.Point(580, 335)
        Me.txtnototalan.Name = "txtnototalan"
        Me.txtnototalan.Size = New System.Drawing.Size(100, 20)
        Me.txtnototalan.TabIndex = 104
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(432, 366)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "Keterangan"
        '
        'txtketerangan
        '
        Me.txtketerangan.Location = New System.Drawing.Point(580, 366)
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.Size = New System.Drawing.Size(310, 20)
        Me.txtketerangan.TabIndex = 106
        '
        'btnsimpan
        '
        Me.btnsimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnsimpan.Location = New System.Drawing.Point(580, 397)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(80, 29)
        Me.btnsimpan.TabIndex = 107
        Me.btnsimpan.Text = "&Simpan"
        Me.btnsimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsimpan.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.tanggal.DefaultCellStyle = DataGridViewCellStyle1
        Me.tanggal.HeaderText = "Borongan"
        Me.tanggal.Name = "tanggal"
        Me.tanggal.ReadOnly = True
        Me.tanggal.Visible = False
        '
        'borongan
        '
        Me.borongan.DataPropertyName = "solarsangu"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.borongan.DefaultCellStyle = DataGridViewCellStyle2
        Me.borongan.HeaderText = "Solar+Sangu"
        Me.borongan.Name = "borongan"
        Me.borongan.ReadOnly = True
        Me.borongan.Visible = False
        '
        'sangusolar
        '
        Me.sangusolar.DataPropertyName = "diterima"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.sangusolar.DefaultCellStyle = DataGridViewCellStyle3
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
        'frmTotalanAkhir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 491)
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
        Me.Name = "frmTotalanAkhir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Totalan Final :."
        CType(Me.dgvTotalan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgtotalan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBiayaLain, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
