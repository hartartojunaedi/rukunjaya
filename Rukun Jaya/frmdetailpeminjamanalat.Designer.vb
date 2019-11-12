<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdetailpeminjamanalat
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
        Me.lbljumlahitem = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.nmJumlah = New System.Windows.Forms.NumericUpDown()
        Me.lbljumlah = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvdetilpeminjaman = New System.Windows.Forms.DataGridView()
        Me.IDAlat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaAlat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hapus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.lblNamaToko = New System.Windows.Forms.Label()
        Me.lblTglTransaksi = New System.Windows.Forms.Label()
        Me.dtpTanggalTransaksi = New System.Windows.Forms.DateTimePicker()
        Me.txtNonota = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbNamaalat = New System.Windows.Forms.ComboBox()
        Me.cmbnamasupir = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        CType(Me.nmJumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvdetilpeminjaman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbljumlahitem
        '
        Me.lbljumlahitem.AutoSize = True
        Me.lbljumlahitem.Location = New System.Drawing.Point(442, 319)
        Me.lbljumlahitem.Name = "lbljumlahitem"
        Me.lbljumlahitem.Size = New System.Drawing.Size(13, 13)
        Me.lbljumlahitem.TabIndex = 69
        Me.lbljumlahitem.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(373, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Jumlah Item :"
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(422, 117)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(88, 29)
        Me.btnTambah.TabIndex = 51
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'nmJumlah
        '
        Me.nmJumlah.Location = New System.Drawing.Point(376, 40)
        Me.nmJumlah.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nmJumlah.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmJumlah.Name = "nmJumlah"
        Me.nmJumlah.Size = New System.Drawing.Size(60, 20)
        Me.nmJumlah.TabIndex = 49
        Me.nmJumlah.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbljumlah
        '
        Me.lbljumlah.AutoSize = True
        Me.lbljumlah.Location = New System.Drawing.Point(330, 42)
        Me.lbljumlah.Name = "lbljumlah"
        Me.lbljumlah.Size = New System.Drawing.Size(40, 13)
        Me.lbljumlah.TabIndex = 62
        Me.lbljumlah.Text = "Jumlah"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(314, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Nama Alat"
        '
        'dgvdetilpeminjaman
        '
        Me.dgvdetilpeminjaman.AllowUserToAddRows = False
        Me.dgvdetilpeminjaman.AllowUserToDeleteRows = False
        Me.dgvdetilpeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetilpeminjaman.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDAlat, Me.NamaAlat, Me.Jumlah, Me.Hapus})
        Me.dgvdetilpeminjaman.Location = New System.Drawing.Point(37, 152)
        Me.dgvdetilpeminjaman.Name = "dgvdetilpeminjaman"
        Me.dgvdetilpeminjaman.ReadOnly = True
        Me.dgvdetilpeminjaman.Size = New System.Drawing.Size(486, 158)
        Me.dgvdetilpeminjaman.TabIndex = 59
        '
        'IDAlat
        '
        Me.IDAlat.DataPropertyName = "IDALat"
        Me.IDAlat.HeaderText = "Id Alat"
        Me.IDAlat.Name = "IDAlat"
        Me.IDAlat.ReadOnly = True
        Me.IDAlat.Visible = False
        '
        'NamaAlat
        '
        Me.NamaAlat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NamaAlat.HeaderText = "Nama Alat"
        Me.NamaAlat.Name = "NamaAlat"
        Me.NamaAlat.ReadOnly = True
        '
        'Jumlah
        '
        Me.Jumlah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Jumlah.DataPropertyName = "jumlah"
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.ReadOnly = True
        Me.Jumlah.Width = 65
        '
        'Hapus
        '
        Me.Hapus.HeaderText = "Hapus"
        Me.Hapus.Name = "Hapus"
        Me.Hapus.ReadOnly = True
        Me.Hapus.Text = "Hapus Data"
        Me.Hapus.UseColumnTextForButtonValue = True
        Me.Hapus.Width = 141
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.RukunJaya.My.Resources.Resources.cancelbr
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(443, 335)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 27)
        Me.btnCancel.TabIndex = 58
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSimpan.Location = New System.Drawing.Point(351, 335)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(78, 27)
        Me.BtnSimpan.TabIndex = 57
        Me.BtnSimpan.Text = "&Simpan"
        Me.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'lblNamaToko
        '
        Me.lblNamaToko.AutoSize = True
        Me.lblNamaToko.Location = New System.Drawing.Point(26, 69)
        Me.lblNamaToko.Name = "lblNamaToko"
        Me.lblNamaToko.Size = New System.Drawing.Size(83, 13)
        Me.lblNamaToko.TabIndex = 54
        Me.lblNamaToko.Text = "Nama Peminjam"
        '
        'lblTglTransaksi
        '
        Me.lblTglTransaksi.AutoSize = True
        Me.lblTglTransaksi.Location = New System.Drawing.Point(29, 42)
        Me.lblTglTransaksi.Name = "lblTglTransaksi"
        Me.lblTglTransaksi.Size = New System.Drawing.Size(80, 13)
        Me.lblTglTransaksi.TabIndex = 53
        Me.lblTglTransaksi.Text = "Tanggal Pinjam"
        '
        'dtpTanggalTransaksi
        '
        Me.dtpTanggalTransaksi.CustomFormat = "dd-MM-yyyy"
        Me.dtpTanggalTransaksi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTanggalTransaksi.Location = New System.Drawing.Point(115, 39)
        Me.dtpTanggalTransaksi.Name = "dtpTanggalTransaksi"
        Me.dtpTanggalTransaksi.Size = New System.Drawing.Size(84, 20)
        Me.dtpTanggalTransaksi.TabIndex = 46
        '
        'txtNonota
        '
        Me.txtNonota.Location = New System.Drawing.Point(115, 13)
        Me.txtNonota.Name = "txtNonota"
        Me.txtNonota.Size = New System.Drawing.Size(114, 20)
        Me.txtNonota.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "No. Peminjaman"
        '
        'cmbNamaalat
        '
        Me.cmbNamaalat.FormattingEnabled = True
        Me.cmbNamaalat.Location = New System.Drawing.Point(373, 13)
        Me.cmbNamaalat.Name = "cmbNamaalat"
        Me.cmbNamaalat.Size = New System.Drawing.Size(150, 21)
        Me.cmbNamaalat.TabIndex = 70
        '
        'cmbnamasupir
        '
        Me.cmbnamasupir.FormattingEnabled = True
        Me.cmbnamasupir.Location = New System.Drawing.Point(115, 66)
        Me.cmbnamasupir.Name = "cmbnamasupir"
        Me.cmbnamasupir.Size = New System.Drawing.Size(150, 21)
        Me.cmbnamasupir.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Keterangan"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(115, 93)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(150, 53)
        Me.txtKeterangan.TabIndex = 73
        '
        'frmdetailpeminjamanalat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 371)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbnamasupir)
        Me.Controls.Add(Me.cmbNamaalat)
        Me.Controls.Add(Me.lbljumlahitem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.nmJumlah)
        Me.Controls.Add(Me.lbljumlah)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvdetilpeminjaman)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.lblNamaToko)
        Me.Controls.Add(Me.lblTglTransaksi)
        Me.Controls.Add(Me.dtpTanggalTransaksi)
        Me.Controls.Add(Me.txtNonota)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmdetailpeminjamanalat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Detail Peminjaman :."
        CType(Me.nmJumlah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvdetilpeminjaman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbljumlahitem As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents nmJumlah As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbljumlah As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgvdetilpeminjaman As System.Windows.Forms.DataGridView
    Friend WithEvents IDAlat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaAlat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hapus As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents lblNamaToko As System.Windows.Forms.Label
    Friend WithEvents lblTglTransaksi As System.Windows.Forms.Label
    Friend WithEvents dtpTanggalTransaksi As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNonota As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbNamaalat As System.Windows.Forms.ComboBox
    Friend WithEvents cmbnamasupir As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
End Class
