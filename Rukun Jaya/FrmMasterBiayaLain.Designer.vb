<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMasterBiayaLain
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
        Me.lblCariTanggalTransaksi = New System.Windows.Forms.Label()
        Me.dtpFromTglTransaksi = New System.Windows.Forms.DateTimePicker()
        Me.lblCaptionJumlahData = New System.Windows.Forms.Label()
        Me.lblJumlahData = New System.Windows.Forms.Label()
        Me.lblCaptionTotalBiaya = New System.Windows.Forms.Label()
        Me.lblTotalBiaya = New System.Windows.Forms.Label()
        Me.dtpToTglTransaksi = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbKaryawan = New System.Windows.Forms.ComboBox()
        Me.lblKaryawan = New System.Windows.Forms.Label()
        Me.cmbJenis = New System.Windows.Forms.ComboBox()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnUbah = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txtKeterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtKaryawan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtJenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBiaya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTanggalTransaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtKodeTransaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvBiayaLain = New System.Windows.Forms.DataGridView()
        CType(Me.dgvBiayaLain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCariTanggalTransaksi
        '
        Me.lblCariTanggalTransaksi.AutoSize = True
        Me.lblCariTanggalTransaksi.Location = New System.Drawing.Point(120, 15)
        Me.lblCariTanggalTransaksi.Name = "lblCariTanggalTransaksi"
        Me.lblCariTanggalTransaksi.Size = New System.Drawing.Size(122, 13)
        Me.lblCariTanggalTransaksi.TabIndex = 8
        Me.lblCariTanggalTransaksi.Text = "Cari Tanggal Transaksi :"
        '
        'dtpFromTglTransaksi
        '
        Me.dtpFromTglTransaksi.CustomFormat = "dd-MM-yyyy"
        Me.dtpFromTglTransaksi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFromTglTransaksi.Location = New System.Drawing.Point(253, 12)
        Me.dtpFromTglTransaksi.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtpFromTglTransaksi.Name = "dtpFromTglTransaksi"
        Me.dtpFromTglTransaksi.Size = New System.Drawing.Size(86, 20)
        Me.dtpFromTglTransaksi.TabIndex = 1
        '
        'lblCaptionJumlahData
        '
        Me.lblCaptionJumlahData.AutoSize = True
        Me.lblCaptionJumlahData.Location = New System.Drawing.Point(311, 294)
        Me.lblCaptionJumlahData.Name = "lblCaptionJumlahData"
        Me.lblCaptionJumlahData.Size = New System.Drawing.Size(72, 13)
        Me.lblCaptionJumlahData.TabIndex = 9
        Me.lblCaptionJumlahData.Text = "Jumlah Data :"
        '
        'lblJumlahData
        '
        Me.lblJumlahData.Location = New System.Drawing.Point(389, 294)
        Me.lblJumlahData.Name = "lblJumlahData"
        Me.lblJumlahData.Size = New System.Drawing.Size(39, 13)
        Me.lblJumlahData.TabIndex = 10
        Me.lblJumlahData.Text = "0"
        Me.lblJumlahData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCaptionTotalBiaya
        '
        Me.lblCaptionTotalBiaya.AutoSize = True
        Me.lblCaptionTotalBiaya.Location = New System.Drawing.Point(446, 294)
        Me.lblCaptionTotalBiaya.Name = "lblCaptionTotalBiaya"
        Me.lblCaptionTotalBiaya.Size = New System.Drawing.Size(66, 13)
        Me.lblCaptionTotalBiaya.TabIndex = 11
        Me.lblCaptionTotalBiaya.Text = "Total Biaya :"
        '
        'lblTotalBiaya
        '
        Me.lblTotalBiaya.Location = New System.Drawing.Point(518, 294)
        Me.lblTotalBiaya.Name = "lblTotalBiaya"
        Me.lblTotalBiaya.Size = New System.Drawing.Size(126, 13)
        Me.lblTotalBiaya.TabIndex = 12
        Me.lblTotalBiaya.Text = "0"
        Me.lblTotalBiaya.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpToTglTransaksi
        '
        Me.dtpToTglTransaksi.CustomFormat = "dd-MM-yyyy"
        Me.dtpToTglTransaksi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpToTglTransaksi.Location = New System.Drawing.Point(361, 12)
        Me.dtpToTglTransaksi.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtpToTglTransaksi.Name = "dtpToTglTransaksi"
        Me.dtpToTglTransaksi.Size = New System.Drawing.Size(86, 20)
        Me.dtpToTglTransaksi.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(345, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "-"
        '
        'cmbKaryawan
        '
        Me.cmbKaryawan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKaryawan.FormattingEnabled = True
        Me.cmbKaryawan.Location = New System.Drawing.Point(253, 65)
        Me.cmbKaryawan.Name = "cmbKaryawan"
        Me.cmbKaryawan.Size = New System.Drawing.Size(126, 21)
        Me.cmbKaryawan.TabIndex = 4
        '
        'lblKaryawan
        '
        Me.lblKaryawan.AutoSize = True
        Me.lblKaryawan.Location = New System.Drawing.Point(120, 68)
        Me.lblKaryawan.Name = "lblKaryawan"
        Me.lblKaryawan.Size = New System.Drawing.Size(60, 13)
        Me.lblKaryawan.TabIndex = 33
        Me.lblKaryawan.Text = "Karyawan :"
        '
        'cmbJenis
        '
        Me.cmbJenis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbJenis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJenis.FormattingEnabled = True
        Me.cmbJenis.Location = New System.Drawing.Point(253, 38)
        Me.cmbJenis.Name = "cmbJenis"
        Me.cmbJenis.Size = New System.Drawing.Size(126, 21)
        Me.cmbJenis.TabIndex = 3
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Location = New System.Drawing.Point(120, 38)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(37, 13)
        Me.lblJenis.TabIndex = 32
        Me.lblJenis.Text = "Jenis :"
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(12, 284)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(80, 29)
        Me.btnTambah.TabIndex = 6
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnFilter
        '
        Me.btnFilter.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFilter.Location = New System.Drawing.Point(533, 50)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(80, 29)
        Me.btnFilter.TabIndex = 5
        Me.btnFilter.Text = "&Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.FillWeight = 50.0!
        Me.btnHapus.HeaderText = "Hapus"
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseColumnTextForButtonValue = True
        Me.btnHapus.Width = 45
        '
        'btnUbah
        '
        Me.btnUbah.FillWeight = 50.0!
        Me.btnUbah.HeaderText = "Ubah"
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseColumnTextForButtonValue = True
        Me.btnUbah.Width = 45
        '
        'txtKeterangan
        '
        Me.txtKeterangan.DataPropertyName = "keterangan"
        Me.txtKeterangan.HeaderText = "Keterangan"
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.ReadOnly = True
        '
        'txtKaryawan
        '
        Me.txtKaryawan.DataPropertyName = "namasopir"
        Me.txtKaryawan.HeaderText = "Karyawan"
        Me.txtKaryawan.Name = "txtKaryawan"
        Me.txtKaryawan.ReadOnly = True
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
        Me.txtBiaya.DataPropertyName = "biaya"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.txtBiaya.DefaultCellStyle = DataGridViewCellStyle1
        Me.txtBiaya.HeaderText = "Biaya"
        Me.txtBiaya.Name = "txtBiaya"
        Me.txtBiaya.ReadOnly = True
        '
        'txtTanggalTransaksi
        '
        Me.txtTanggalTransaksi.DataPropertyName = "tgltransaksi"
        DataGridViewCellStyle2.Format = "dd-MM-yyyy"
        Me.txtTanggalTransaksi.DefaultCellStyle = DataGridViewCellStyle2
        Me.txtTanggalTransaksi.HeaderText = "Tanggal Transaksi"
        Me.txtTanggalTransaksi.Name = "txtTanggalTransaksi"
        Me.txtTanggalTransaksi.ReadOnly = True
        '
        'txtKodeTransaksi
        '
        Me.txtKodeTransaksi.DataPropertyName = "kodetransaksi"
        Me.txtKodeTransaksi.HeaderText = "kodeTransaksi"
        Me.txtKodeTransaksi.Name = "txtKodeTransaksi"
        Me.txtKodeTransaksi.ReadOnly = True
        Me.txtKodeTransaksi.Visible = False
        Me.txtKodeTransaksi.Width = 5
        '
        'dgvBiayaLain
        '
        Me.dgvBiayaLain.AllowUserToAddRows = False
        Me.dgvBiayaLain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBiayaLain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txtKodeTransaksi, Me.txtTanggalTransaksi, Me.txtBiaya, Me.txtJenis, Me.txtKaryawan, Me.txtKeterangan, Me.btnUbah, Me.btnHapus})
        Me.dgvBiayaLain.Location = New System.Drawing.Point(12, 97)
        Me.dgvBiayaLain.Name = "dgvBiayaLain"
        Me.dgvBiayaLain.Size = New System.Drawing.Size(632, 181)
        Me.dgvBiayaLain.TabIndex = 3
        '
        'FrmMasterBiayaLain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 325)
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
        Me.Name = "FrmMasterBiayaLain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Biaya Lain :."
        CType(Me.dgvBiayaLain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents lblCariTanggalTransaksi As System.Windows.Forms.Label
    Friend WithEvents dtpFromTglTransaksi As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCaptionJumlahData As System.Windows.Forms.Label
    Friend WithEvents lblJumlahData As System.Windows.Forms.Label
    Friend WithEvents lblCaptionTotalBiaya As System.Windows.Forms.Label
    Friend WithEvents lblTotalBiaya As System.Windows.Forms.Label
    Friend WithEvents dtpToTglTransaksi As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbKaryawan As System.Windows.Forms.ComboBox
    Friend WithEvents lblKaryawan As System.Windows.Forms.Label
    Friend WithEvents cmbJenis As System.Windows.Forms.ComboBox
    Friend WithEvents lblJenis As System.Windows.Forms.Label
    Friend WithEvents btnHapus As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnUbah As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents txtKeterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtKaryawan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtJenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtBiaya As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTanggalTransaksi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtKodeTransaksi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvBiayaLain As System.Windows.Forms.DataGridView
End Class
