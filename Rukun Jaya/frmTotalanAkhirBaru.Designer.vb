<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTotalanAkhirBaru
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
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btncari = New System.Windows.Forms.Button()
        Me.txtkodesopir = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNamaSopir = New System.Windows.Forms.Label()
        Me.dgtotalan = New System.Windows.Forms.DataGridView()
        Me.ntotalan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.terima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTotalan = New System.Windows.Forms.DataGridView()
        Me.nototalan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diterima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sangusolar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dgvBiayaLain = New System.Windows.Forms.DataGridView()
        Me.kodetransaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTanggalTransaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtJenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBiaya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sisa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bayarkasbon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtnototalan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbltotalterima = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.txtketerangan = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txttambahan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbltotalbayarkasbon = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtpotongan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgtotalan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTotalan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBiayaLain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(172, 5)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(33, 23)
        Me.btncari.TabIndex = 8
        Me.btncari.Text = "..."
        Me.btncari.UseVisualStyleBackColor = True
        '
        'txtkodesopir
        '
        Me.txtkodesopir.Location = New System.Drawing.Point(87, 9)
        Me.txtkodesopir.MaxLength = 5
        Me.txtkodesopir.Name = "txtkodesopir"
        Me.txtkodesopir.Size = New System.Drawing.Size(78, 20)
        Me.txtkodesopir.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Kode Sopir : "
        '
        'lblNamaSopir
        '
        Me.lblNamaSopir.AutoSize = True
        Me.lblNamaSopir.Location = New System.Drawing.Point(212, 9)
        Me.lblNamaSopir.Name = "lblNamaSopir"
        Me.lblNamaSopir.Size = New System.Drawing.Size(0, 13)
        Me.lblNamaSopir.TabIndex = 9
        '
        'dgtotalan
        '
        Me.dgtotalan.AllowUserToAddRows = False
        Me.dgtotalan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtotalan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ntotalan, Me.terima})
        Me.dgtotalan.Location = New System.Drawing.Point(478, 35)
        Me.dgtotalan.Name = "dgtotalan"
        Me.dgtotalan.ReadOnly = True
        Me.dgtotalan.Size = New System.Drawing.Size(289, 150)
        Me.dgtotalan.TabIndex = 10
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
        DataGridViewCellStyle28.Format = "N0"
        DataGridViewCellStyle28.NullValue = "0"
        Me.terima.DefaultCellStyle = DataGridViewCellStyle28
        Me.terima.HeaderText = "Terima"
        Me.terima.Name = "terima"
        Me.terima.ReadOnly = True
        '
        'dgvTotalan
        '
        Me.dgvTotalan.AllowUserToAddRows = False
        Me.dgvTotalan.AllowUserToDeleteRows = False
        Me.dgvTotalan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTotalan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nototalan, Me.diterima, Me.sangusolar, Me.total})
        Me.dgvTotalan.Location = New System.Drawing.Point(15, 35)
        Me.dgvTotalan.Name = "dgvTotalan"
        Me.dgvTotalan.ReadOnly = True
        Me.dgvTotalan.Size = New System.Drawing.Size(457, 150)
        Me.dgvTotalan.TabIndex = 11
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
        'sangusolar
        '
        Me.sangusolar.DataPropertyName = "diterima"
        DataGridViewCellStyle29.Format = "N2"
        DataGridViewCellStyle29.NullValue = "0"
        Me.sangusolar.DefaultCellStyle = DataGridViewCellStyle29
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
        'dgvBiayaLain
        '
        Me.dgvBiayaLain.AllowUserToAddRows = False
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBiayaLain.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle30
        Me.dgvBiayaLain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBiayaLain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodetransaksi, Me.txtTanggalTransaksi, Me.txtJenis, Me.txtBiaya, Me.Sisa, Me.Bayarkasbon})
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBiayaLain.DefaultCellStyle = DataGridViewCellStyle35
        Me.dgvBiayaLain.Location = New System.Drawing.Point(12, 191)
        Me.dgvBiayaLain.Name = "dgvBiayaLain"
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBiayaLain.RowHeadersDefaultCellStyle = DataGridViewCellStyle36
        Me.dgvBiayaLain.Size = New System.Drawing.Size(755, 150)
        Me.dgvBiayaLain.TabIndex = 90
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
        DataGridViewCellStyle31.Format = "dd-MM-yyyy"
        DataGridViewCellStyle31.NullValue = Nothing
        Me.txtTanggalTransaksi.DefaultCellStyle = DataGridViewCellStyle31
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
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle32.Format = "N"
        DataGridViewCellStyle32.NullValue = Nothing
        Me.txtBiaya.DefaultCellStyle = DataGridViewCellStyle32
        Me.txtBiaya.HeaderText = "Harga"
        Me.txtBiaya.Name = "txtBiaya"
        Me.txtBiaya.ReadOnly = True
        '
        'Sisa
        '
        Me.Sisa.DataPropertyName = "sisa"
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle33.Format = "N"
        Me.Sisa.DefaultCellStyle = DataGridViewCellStyle33
        Me.Sisa.HeaderText = "Sisa"
        Me.Sisa.Name = "Sisa"
        Me.Sisa.ReadOnly = True
        '
        'Bayarkasbon
        '
        Me.Bayarkasbon.DataPropertyName = "bayarkasbon"
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle34.Format = "N"
        Me.Bayarkasbon.DefaultCellStyle = DataGridViewCellStyle34
        Me.Bayarkasbon.HeaderText = "Bayar"
        Me.Bayarkasbon.Name = "Bayarkasbon"
        '
        'txtnototalan
        '
        Me.txtnototalan.Location = New System.Drawing.Point(478, 356)
        Me.txtnototalan.Name = "txtnototalan"
        Me.txtnototalan.Size = New System.Drawing.Size(100, 20)
        Me.txtnototalan.TabIndex = 110
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(618, 356)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "Tanggal "
        '
        'dtpTanggal
        '
        Me.dtpTanggal.CustomFormat = "dd-MM-yyyy"
        Me.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTanggal.Location = New System.Drawing.Point(681, 356)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(86, 20)
        Me.dtpTanggal.TabIndex = 108
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(356, 359)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 13)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "No Grand Totalan :"
        '
        'lbltotalterima
        '
        Me.lbltotalterima.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalterima.Location = New System.Drawing.Point(162, 359)
        Me.lbltotalterima.Name = "lbltotalterima"
        Me.lbltotalterima.Size = New System.Drawing.Size(100, 17)
        Me.lbltotalterima.TabIndex = 106
        Me.lbltotalterima.Text = "0"
        Me.lbltotalterima.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 359)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Total Terima"
        '
        'btnsimpan
        '
        Me.btnsimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnsimpan.Location = New System.Drawing.Point(478, 413)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(80, 29)
        Me.btnsimpan.TabIndex = 117
        Me.btnsimpan.Text = "&Simpan"
        Me.btnsimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'txtketerangan
        '
        Me.txtketerangan.Location = New System.Drawing.Point(478, 387)
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.Size = New System.Drawing.Size(310, 20)
        Me.txtketerangan.TabIndex = 116
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(357, 387)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 115
        Me.Label9.Text = "Keterangan"
        '
        'txttambahan
        '
        Me.txttambahan.Location = New System.Drawing.Point(165, 411)
        Me.txttambahan.Name = "txttambahan"
        Me.txttambahan.Size = New System.Drawing.Size(100, 20)
        Me.txttambahan.TabIndex = 114
        Me.txttambahan.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 418)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "Tambahan"
        '
        'lbltotalbayarkasbon
        '
        Me.lbltotalbayarkasbon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalbayarkasbon.Location = New System.Drawing.Point(251, 387)
        Me.lbltotalbayarkasbon.Name = "lbltotalbayarkasbon"
        Me.lbltotalbayarkasbon.Size = New System.Drawing.Size(100, 17)
        Me.lbltotalbayarkasbon.TabIndex = 112
        Me.lbltotalbayarkasbon.Text = "Label4"
        Me.lbltotalbayarkasbon.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 387)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 13)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "Total Bayar Kas Bon : "
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandTotal.Location = New System.Drawing.Point(196, 491)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(100, 17)
        Me.lblGrandTotal.TabIndex = 121
        Me.lblGrandTotal.Text = "0"
        Me.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 491)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 120
        Me.Label6.Text = "Grand Total"
        '
        'txtpotongan
        '
        Me.txtpotongan.Location = New System.Drawing.Point(251, 445)
        Me.txtpotongan.Name = "txtpotongan"
        Me.txtpotongan.Size = New System.Drawing.Size(100, 20)
        Me.txtpotongan.TabIndex = 119
        Me.txtpotongan.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 452)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Potongan"
        '
        'frmTotalanAkhirBaru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 513)
        Me.Controls.Add(Me.lblGrandTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtpotongan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.txtketerangan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txttambahan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbltotalbayarkasbon)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnototalan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbltotalterima)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvBiayaLain)
        Me.Controls.Add(Me.dgvTotalan)
        Me.Controls.Add(Me.dgtotalan)
        Me.Controls.Add(Me.lblNamaSopir)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.txtkodesopir)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTotalanAkhirBaru"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Totalan Akhir :."
        CType(Me.dgtotalan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTotalan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBiayaLain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents txtkodesopir As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNamaSopir As System.Windows.Forms.Label
    Friend WithEvents dgtotalan As System.Windows.Forms.DataGridView
    Friend WithEvents ntotalan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents terima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvTotalan As System.Windows.Forms.DataGridView
    Friend WithEvents nototalan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents diterima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sangusolar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents dgvBiayaLain As System.Windows.Forms.DataGridView
    Friend WithEvents kodetransaksi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTanggalTransaksi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtJenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtBiaya As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sisa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bayarkasbon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtnototalan As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbltotalterima As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents txtketerangan As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txttambahan As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbltotalbayarkasbon As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblGrandTotal As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtpotongan As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
