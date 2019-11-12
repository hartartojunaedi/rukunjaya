<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuatPenagihan
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvBM = New System.Windows.Forms.DataGridView()
        Me.SJ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Biaya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tambahan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Potongan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hapus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlSupp = New System.Windows.Forms.Panel()
        Me.lblKwintasi = New System.Windows.Forms.Label()
        Me.txtKwintasi = New System.Windows.Forms.TextBox()
        Me.LblValidator = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpTgl = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTagihan = New System.Windows.Forms.TextBox()
        Me.pnlSJ = New System.Windows.Forms.Panel()
        Me.lblBiayaAkhir = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblBiaya = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtPotongan = New System.Windows.Forms.TextBox()
        Me.txtTambahan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.lblBM = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSJ = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblGrand = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        CType(Me.dgvBM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSupp.SuspendLayout()
        Me.pnlSJ.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvBM
        '
        Me.dgvBM.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBM.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SJ, Me.BM, Me.Biaya, Me.Tambahan, Me.Potongan, Me.subtotal, Me.keterangan, Me.hapus})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBM.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvBM.Location = New System.Drawing.Point(8, 260)
        Me.dgvBM.Name = "dgvBM"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBM.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvBM.Size = New System.Drawing.Size(848, 283)
        Me.dgvBM.TabIndex = 11
        '
        'SJ
        '
        Me.SJ.DataPropertyName = "SJ"
        Me.SJ.HeaderText = "No Surat Jalan"
        Me.SJ.Name = "SJ"
        Me.SJ.ReadOnly = True
        '
        'BM
        '
        Me.BM.DataPropertyName = "BM"
        Me.BM.HeaderText = "No Bon Muat"
        Me.BM.Name = "BM"
        Me.BM.ReadOnly = True
        '
        'Biaya
        '
        Me.Biaya.DataPropertyName = "TOTAL"
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = "0"
        Me.Biaya.DefaultCellStyle = DataGridViewCellStyle2
        Me.Biaya.HeaderText = "Biaya"
        Me.Biaya.Name = "Biaya"
        Me.Biaya.ReadOnly = True
        '
        'Tambahan
        '
        Me.Tambahan.DataPropertyName = "Tambahan"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = "0"
        Me.Tambahan.DefaultCellStyle = DataGridViewCellStyle3
        Me.Tambahan.HeaderText = "Tambahan"
        Me.Tambahan.Name = "Tambahan"
        '
        'Potongan
        '
        Me.Potongan.DataPropertyName = "POTONGAN"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = "0"
        Me.Potongan.DefaultCellStyle = DataGridViewCellStyle4
        Me.Potongan.HeaderText = "Potongan"
        Me.Potongan.Name = "Potongan"
        '
        'subtotal
        '
        Me.subtotal.DataPropertyName = "AKHIR"
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = "0"
        Me.subtotal.DefaultCellStyle = DataGridViewCellStyle5
        Me.subtotal.HeaderText = "Biaya Akhir"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        '
        'keterangan
        '
        Me.keterangan.DataPropertyName = "keterangan"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        Me.keterangan.DefaultCellStyle = DataGridViewCellStyle6
        Me.keterangan.HeaderText = "Keterangan"
        Me.keterangan.Name = "keterangan"
        '
        'hapus
        '
        Me.hapus.DataPropertyName = "hapus"
        Me.hapus.HeaderText = ""
        Me.hapus.Name = "hapus"
        Me.hapus.Text = "Hapus"
        Me.hapus.UseColumnTextForButtonValue = True
        '
        'pnlSupp
        '
        Me.pnlSupp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSupp.Controls.Add(Me.lblKwintasi)
        Me.pnlSupp.Controls.Add(Me.txtKwintasi)
        Me.pnlSupp.Controls.Add(Me.LblValidator)
        Me.pnlSupp.Controls.Add(Me.btnNext)
        Me.pnlSupp.Controls.Add(Me.cmbSupplier)
        Me.pnlSupp.Controls.Add(Me.Label3)
        Me.pnlSupp.Controls.Add(Me.dtpTgl)
        Me.pnlSupp.Controls.Add(Me.Label2)
        Me.pnlSupp.Controls.Add(Me.Label1)
        Me.pnlSupp.Controls.Add(Me.txtTagihan)
        Me.pnlSupp.Location = New System.Drawing.Point(9, 36)
        Me.pnlSupp.Name = "pnlSupp"
        Me.pnlSupp.Size = New System.Drawing.Size(434, 218)
        Me.pnlSupp.TabIndex = 1
        '
        'lblKwintasi
        '
        Me.lblKwintasi.AutoSize = True
        Me.lblKwintasi.Location = New System.Drawing.Point(37, 85)
        Me.lblKwintasi.Name = "lblKwintasi"
        Me.lblKwintasi.Size = New System.Drawing.Size(69, 13)
        Me.lblKwintasi.TabIndex = 24
        Me.lblKwintasi.Text = "No Kwintasi :"
        '
        'txtKwintasi
        '
        Me.txtKwintasi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKwintasi.Location = New System.Drawing.Point(112, 81)
        Me.txtKwintasi.MaxLength = 10
        Me.txtKwintasi.Name = "txtKwintasi"
        Me.txtKwintasi.Size = New System.Drawing.Size(128, 20)
        Me.txtKwintasi.TabIndex = 2
        '
        'LblValidator
        '
        Me.LblValidator.AutoSize = True
        Me.LblValidator.Location = New System.Drawing.Point(269, 57)
        Me.LblValidator.Name = "LblValidator"
        Me.LblValidator.Size = New System.Drawing.Size(0, 13)
        Me.LblValidator.TabIndex = 22
        '
        'btnNext
        '
        Me.btnNext.Image = Global.RukunJaya.My.Resources.Resources.Next_icon
        Me.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNext.Location = New System.Drawing.Point(316, 103)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 31)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "&Next"
        Me.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'cmbSupplier
        '
        Me.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(112, 109)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(189, 21)
        Me.cmbSupplier.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Supplier :"
        '
        'dtpTgl
        '
        Me.dtpTgl.CustomFormat = "dd-MMM-yyyy"
        Me.dtpTgl.Enabled = False
        Me.dtpTgl.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTgl.Location = New System.Drawing.Point(112, 24)
        Me.dtpTgl.Name = "dtpTgl"
        Me.dtpTgl.Size = New System.Drawing.Size(111, 20)
        Me.dtpTgl.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Tgl :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Kode Tagihan :"
        '
        'txtTagihan
        '
        Me.txtTagihan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTagihan.Location = New System.Drawing.Point(112, 54)
        Me.txtTagihan.MaxLength = 10
        Me.txtTagihan.Name = "txtTagihan"
        Me.txtTagihan.Size = New System.Drawing.Size(128, 20)
        Me.txtTagihan.TabIndex = 1
        '
        'pnlSJ
        '
        Me.pnlSJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSJ.Controls.Add(Me.lblBiayaAkhir)
        Me.pnlSJ.Controls.Add(Me.Label12)
        Me.pnlSJ.Controls.Add(Me.txtKeterangan)
        Me.pnlSJ.Controls.Add(Me.Label9)
        Me.pnlSJ.Controls.Add(Me.lblBiaya)
        Me.pnlSJ.Controls.Add(Me.Label8)
        Me.pnlSJ.Controls.Add(Me.btnTambah)
        Me.pnlSJ.Controls.Add(Me.txtPotongan)
        Me.pnlSJ.Controls.Add(Me.txtTambahan)
        Me.pnlSJ.Controls.Add(Me.Label6)
        Me.pnlSJ.Controls.Add(Me.Label5)
        Me.pnlSJ.Controls.Add(Me.btnCari)
        Me.pnlSJ.Controls.Add(Me.lblBM)
        Me.pnlSJ.Controls.Add(Me.Label7)
        Me.pnlSJ.Controls.Add(Me.lblSJ)
        Me.pnlSJ.Controls.Add(Me.Label4)
        Me.pnlSJ.Location = New System.Drawing.Point(459, 36)
        Me.pnlSJ.Name = "pnlSJ"
        Me.pnlSJ.Size = New System.Drawing.Size(398, 218)
        Me.pnlSJ.TabIndex = 2
        '
        'lblBiayaAkhir
        '
        Me.lblBiayaAkhir.AutoSize = True
        Me.lblBiayaAkhir.Location = New System.Drawing.Point(76, 111)
        Me.lblBiayaAkhir.Name = "lblBiayaAkhir"
        Me.lblBiayaAkhir.Size = New System.Drawing.Size(0, 13)
        Me.lblBiayaAkhir.TabIndex = 29
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Biaya Akhir:"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(76, 137)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(200, 61)
        Me.txtKeterangan.TabIndex = 8
        Me.txtKeterangan.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(2, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Keterangan :"
        '
        'lblBiaya
        '
        Me.lblBiaya.AutoSize = True
        Me.lblBiaya.Location = New System.Drawing.Point(78, 58)
        Me.lblBiaya.Name = "lblBiaya"
        Me.lblBiaya.Size = New System.Drawing.Size(0, 13)
        Me.lblBiaya.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Biaya :"
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon1
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(293, 139)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 31)
        Me.btnTambah.TabIndex = 9
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'txtPotongan
        '
        Me.txtPotongan.Location = New System.Drawing.Point(269, 82)
        Me.txtPotongan.Name = "txtPotongan"
        Me.txtPotongan.Size = New System.Drawing.Size(122, 20)
        Me.txtPotongan.TabIndex = 7
        '
        'txtTambahan
        '
        Me.txtTambahan.Location = New System.Drawing.Point(76, 82)
        Me.txtTambahan.Name = "txtTambahan"
        Me.txtTambahan.Size = New System.Drawing.Size(122, 20)
        Me.txtTambahan.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(204, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Potongan :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Tambahan :"
        '
        'btnCari
        '
        Me.btnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCari.Location = New System.Drawing.Point(212, 9)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 31)
        Me.btnCari.TabIndex = 5
        Me.btnCari.Text = "&Cari"
        Me.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'lblBM
        '
        Me.lblBM.AutoSize = True
        Me.lblBM.Location = New System.Drawing.Point(78, 33)
        Me.lblBM.Name = "lblBM"
        Me.lblBM.Size = New System.Drawing.Size(0, 13)
        Me.lblBM.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "No BM :"
        '
        'lblSJ
        '
        Me.lblSJ.AutoSize = True
        Me.lblSJ.Location = New System.Drawing.Point(78, 10)
        Me.lblSJ.Name = "lblSJ"
        Me.lblSJ.Size = New System.Drawing.Size(0, 13)
        Me.lblSJ.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Surat Jalan :"
        '
        'Button1
        '
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(9, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 31)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "&Reset Form"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(456, 550)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Total Biaya :"
        '
        'lblGrand
        '
        Me.lblGrand.AutoSize = True
        Me.lblGrand.Location = New System.Drawing.Point(528, 550)
        Me.lblGrand.Name = "lblGrand"
        Me.lblGrand.Size = New System.Drawing.Size(66, 13)
        Me.lblGrand.TabIndex = 29
        Me.lblGrand.Text = "Total Biaya :"
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(531, 572)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 31)
        Me.btnSimpan.TabIndex = 12
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'frmBuatPenagihan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 612)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.lblGrand)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pnlSJ)
        Me.Controls.Add(Me.pnlSupp)
        Me.Controls.Add(Me.dgvBM)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuatPenagihan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Transaksi Buat Penagihan :."
        CType(Me.dgvBM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSupp.ResumeLayout(False)
        Me.pnlSupp.PerformLayout()
        Me.pnlSJ.ResumeLayout(False)
        Me.pnlSJ.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvBM As System.Windows.Forms.DataGridView
    Friend WithEvents pnlSupp As System.Windows.Forms.Panel
    Friend WithEvents cmbSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpTgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTagihan As System.Windows.Forms.TextBox
    Friend WithEvents pnlSJ As System.Windows.Forms.Panel
    Friend WithEvents lblBM As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblSJ As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPotongan As System.Windows.Forms.TextBox
    Friend WithEvents txtTambahan As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblBiaya As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblGrand As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents LblValidator As System.Windows.Forms.Label
    Friend WithEvents lblKwintasi As System.Windows.Forms.Label
    Friend WithEvents txtKwintasi As System.Windows.Forms.TextBox
    Friend WithEvents txtKeterangan As System.Windows.Forms.RichTextBox
    Friend WithEvents lblBiayaAkhir As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SJ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Biaya As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tambahan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Potongan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hapus As System.Windows.Forms.DataGridViewButtonColumn
End Class
