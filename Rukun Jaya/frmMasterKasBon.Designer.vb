<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterKasBon
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
        Me.cmbKaryawan = New System.Windows.Forms.ComboBox()
        Me.lblKaryawan = New System.Windows.Forms.Label()
        Me.cmbJenis = New System.Windows.Forms.ComboBox()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpToTglTransaksi = New System.Windows.Forms.DateTimePicker()
        Me.lblTotalBiaya = New System.Windows.Forms.Label()
        Me.lblCaptionTotalBiaya = New System.Windows.Forms.Label()
        Me.lblJumlahData = New System.Windows.Forms.Label()
        Me.lblCaptionJumlahData = New System.Windows.Forms.Label()
        Me.dtpFromTglTransaksi = New System.Windows.Forms.DateTimePicker()
        Me.lblCariTanggalTransaksi = New System.Windows.Forms.Label()
        Me.dgvBiayaLain = New System.Windows.Forms.DataGridView()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.txtKodeTransaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTanggalTransaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBiaya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtJenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSopir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtKeterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnUbah = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnHapus = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvBiayaLain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbKaryawan
        '
        Me.cmbKaryawan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKaryawan.FormattingEnabled = True
        Me.cmbKaryawan.Location = New System.Drawing.Point(253, 63)
        Me.cmbKaryawan.Name = "cmbKaryawan"
        Me.cmbKaryawan.Size = New System.Drawing.Size(126, 21)
        Me.cmbKaryawan.TabIndex = 38
        '
        'lblKaryawan
        '
        Me.lblKaryawan.AutoSize = True
        Me.lblKaryawan.Location = New System.Drawing.Point(120, 66)
        Me.lblKaryawan.Name = "lblKaryawan"
        Me.lblKaryawan.Size = New System.Drawing.Size(37, 13)
        Me.lblKaryawan.TabIndex = 48
        Me.lblKaryawan.Text = "Sopir :"
        '
        'cmbJenis
        '
        Me.cmbJenis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbJenis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJenis.FormattingEnabled = True
        Me.cmbJenis.Location = New System.Drawing.Point(253, 36)
        Me.cmbJenis.Name = "cmbJenis"
        Me.cmbJenis.Size = New System.Drawing.Size(126, 21)
        Me.cmbJenis.TabIndex = 36
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Location = New System.Drawing.Point(120, 36)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(37, 13)
        Me.lblJenis.TabIndex = 47
        Me.lblJenis.Text = "Jenis :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(345, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "-"
        '
        'dtpToTglTransaksi
        '
        Me.dtpToTglTransaksi.CustomFormat = "dd-MM-yyyy"
        Me.dtpToTglTransaksi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpToTglTransaksi.Location = New System.Drawing.Point(361, 10)
        Me.dtpToTglTransaksi.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtpToTglTransaksi.Name = "dtpToTglTransaksi"
        Me.dtpToTglTransaksi.Size = New System.Drawing.Size(86, 20)
        Me.dtpToTglTransaksi.TabIndex = 35
        '
        'lblTotalBiaya
        '
        Me.lblTotalBiaya.Location = New System.Drawing.Point(518, 292)
        Me.lblTotalBiaya.Name = "lblTotalBiaya"
        Me.lblTotalBiaya.Size = New System.Drawing.Size(126, 13)
        Me.lblTotalBiaya.TabIndex = 45
        Me.lblTotalBiaya.Text = "0"
        Me.lblTotalBiaya.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCaptionTotalBiaya
        '
        Me.lblCaptionTotalBiaya.AutoSize = True
        Me.lblCaptionTotalBiaya.Location = New System.Drawing.Point(446, 292)
        Me.lblCaptionTotalBiaya.Name = "lblCaptionTotalBiaya"
        Me.lblCaptionTotalBiaya.Size = New System.Drawing.Size(66, 13)
        Me.lblCaptionTotalBiaya.TabIndex = 44
        Me.lblCaptionTotalBiaya.Text = "Total Biaya :"
        '
        'lblJumlahData
        '
        Me.lblJumlahData.Location = New System.Drawing.Point(389, 292)
        Me.lblJumlahData.Name = "lblJumlahData"
        Me.lblJumlahData.Size = New System.Drawing.Size(39, 13)
        Me.lblJumlahData.TabIndex = 43
        Me.lblJumlahData.Text = "0"
        Me.lblJumlahData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCaptionJumlahData
        '
        Me.lblCaptionJumlahData.AutoSize = True
        Me.lblCaptionJumlahData.Location = New System.Drawing.Point(311, 292)
        Me.lblCaptionJumlahData.Name = "lblCaptionJumlahData"
        Me.lblCaptionJumlahData.Size = New System.Drawing.Size(72, 13)
        Me.lblCaptionJumlahData.TabIndex = 42
        Me.lblCaptionJumlahData.Text = "Jumlah Data :"
        '
        'dtpFromTglTransaksi
        '
        Me.dtpFromTglTransaksi.CustomFormat = "dd-MM-yyyy"
        Me.dtpFromTglTransaksi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFromTglTransaksi.Location = New System.Drawing.Point(253, 10)
        Me.dtpFromTglTransaksi.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtpFromTglTransaksi.Name = "dtpFromTglTransaksi"
        Me.dtpFromTglTransaksi.Size = New System.Drawing.Size(86, 20)
        Me.dtpFromTglTransaksi.TabIndex = 34
        '
        'lblCariTanggalTransaksi
        '
        Me.lblCariTanggalTransaksi.AutoSize = True
        Me.lblCariTanggalTransaksi.Location = New System.Drawing.Point(120, 13)
        Me.lblCariTanggalTransaksi.Name = "lblCariTanggalTransaksi"
        Me.lblCariTanggalTransaksi.Size = New System.Drawing.Size(122, 13)
        Me.lblCariTanggalTransaksi.TabIndex = 41
        Me.lblCariTanggalTransaksi.Text = "Cari Tanggal Transaksi :"
        '
        'dgvBiayaLain
        '
        Me.dgvBiayaLain.AllowUserToAddRows = False
        Me.dgvBiayaLain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBiayaLain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txtKodeTransaksi, Me.txtTanggalTransaksi, Me.txtBiaya, Me.txtJenis, Me.txtSopir, Me.txtKeterangan, Me.btnUbah, Me.btnHapus})
        Me.dgvBiayaLain.Location = New System.Drawing.Point(12, 95)
        Me.dgvBiayaLain.Name = "dgvBiayaLain"
        Me.dgvBiayaLain.Size = New System.Drawing.Size(843, 181)
        Me.dgvBiayaLain.TabIndex = 37
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(12, 282)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(80, 29)
        Me.btnTambah.TabIndex = 40
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnFilter
        '
        Me.btnFilter.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFilter.Location = New System.Drawing.Point(533, 48)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(80, 29)
        Me.btnFilter.TabIndex = 39
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'txtKodeTransaksi
        '
        Me.txtKodeTransaksi.DataPropertyName = "kodetransaksi"
        Me.txtKodeTransaksi.HeaderText = "kodeTransaksi"
        Me.txtKodeTransaksi.Name = "txtKodeTransaksi"
        Me.txtKodeTransaksi.ReadOnly = True
        Me.txtKodeTransaksi.Width = 150
        '
        'txtTanggalTransaksi
        '
        Me.txtTanggalTransaksi.DataPropertyName = "tgltransaksi"
        DataGridViewCellStyle1.Format = "dd-MM-yyyy"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.txtTanggalTransaksi.DefaultCellStyle = DataGridViewCellStyle1
        Me.txtTanggalTransaksi.HeaderText = "Tanggal Transaksi"
        Me.txtTanggalTransaksi.Name = "txtTanggalTransaksi"
        Me.txtTanggalTransaksi.ReadOnly = True
        '
        'txtBiaya
        '
        Me.txtBiaya.DataPropertyName = "biaya"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.txtBiaya.DefaultCellStyle = DataGridViewCellStyle2
        Me.txtBiaya.HeaderText = "Biaya"
        Me.txtBiaya.Name = "txtBiaya"
        Me.txtBiaya.ReadOnly = True
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
        'txtSopir
        '
        Me.txtSopir.DataPropertyName = "namasopir"
        Me.txtSopir.HeaderText = "Sopir"
        Me.txtSopir.Name = "txtSopir"
        Me.txtSopir.ReadOnly = True
        '
        'txtKeterangan
        '
        Me.txtKeterangan.DataPropertyName = "keterangan"
        Me.txtKeterangan.HeaderText = "Keterangan"
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.ReadOnly = True
        '
        'btnUbah
        '
        Me.btnUbah.FillWeight = 50.0!
        Me.btnUbah.HeaderText = "Ubah"
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseColumnTextForButtonValue = True
        Me.btnUbah.Width = 50
        '
        'btnHapus
        '
        Me.btnHapus.FillWeight = 50.0!
        Me.btnHapus.HeaderText = "Hapus"
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseColumnTextForButtonValue = True
        Me.btnHapus.Width = 50
        '
        'frmMasterKasBon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 325)
        Me.Controls.Add(Me.cmbKaryawan)
        Me.Controls.Add(Me.lblKaryawan)
        Me.Controls.Add(Me.cmbJenis)
        Me.Controls.Add(Me.lblJenis)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpToTglTransaksi)
        Me.Controls.Add(Me.lblTotalBiaya)
        Me.Controls.Add(Me.lblCaptionTotalBiaya)
        Me.Controls.Add(Me.lblJumlahData)
        Me.Controls.Add(Me.lblCaptionJumlahData)
        Me.Controls.Add(Me.dtpFromTglTransaksi)
        Me.Controls.Add(Me.lblCariTanggalTransaksi)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.dgvBiayaLain)
        Me.Controls.Add(Me.btnFilter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMasterKasBon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Kas Bon :."
        CType(Me.dgvBiayaLain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbKaryawan As System.Windows.Forms.ComboBox
    Friend WithEvents lblKaryawan As System.Windows.Forms.Label
    Friend WithEvents cmbJenis As System.Windows.Forms.ComboBox
    Friend WithEvents lblJenis As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpToTglTransaksi As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTotalBiaya As System.Windows.Forms.Label
    Friend WithEvents lblCaptionTotalBiaya As System.Windows.Forms.Label
    Friend WithEvents lblJumlahData As System.Windows.Forms.Label
    Friend WithEvents lblCaptionJumlahData As System.Windows.Forms.Label
    Friend WithEvents dtpFromTglTransaksi As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCariTanggalTransaksi As System.Windows.Forms.Label
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents dgvBiayaLain As System.Windows.Forms.DataGridView
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents txtKodeTransaksi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTanggalTransaksi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtBiaya As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtJenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtSopir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtKeterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnUbah As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnHapus As System.Windows.Forms.DataGridViewButtonColumn
End Class
