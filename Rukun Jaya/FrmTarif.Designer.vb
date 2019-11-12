<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTarif
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTambahTarif = New System.Windows.Forms.Button()
        Me.lblJumlahDataOperational = New System.Windows.Forms.Label()
        Me.btnSeacrhTarif = New System.Windows.Forms.Button()
        Me.txtCariNamaBorongan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCariKendaraan = New System.Windows.Forms.ComboBox()
        Me.dgvMasterTarif = New System.Windows.Forms.DataGridView()
        Me.KodeBorongan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBorongan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisKendaraan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Asal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tujuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UbahData = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.HapusData = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbCariKota = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbCariNamaBarang = New System.Windows.Forms.ComboBox()
        CType(Me.dgvMasterTarif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(181, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nama Borongan :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(179, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Jenis Kendaraan :"
        '
        'btnTambahTarif
        '
        Me.btnTambahTarif.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon1
        Me.btnTambahTarif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambahTarif.Location = New System.Drawing.Point(31, 309)
        Me.btnTambahTarif.Name = "btnTambahTarif"
        Me.btnTambahTarif.Size = New System.Drawing.Size(80, 29)
        Me.btnTambahTarif.TabIndex = 17
        Me.btnTambahTarif.Text = "&Tambah"
        Me.btnTambahTarif.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambahTarif.UseVisualStyleBackColor = True
        '
        'lblJumlahDataOperational
        '
        'Me.lblJumlahDataOperational.AutoSize = True
        Me.lblJumlahDataOperational.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahDataOperational.Location = New System.Drawing.Point(805, 317)
        Me.lblJumlahDataOperational.Name = "lblJumlahDataOperational"
        Me.lblJumlahDataOperational.Size = New System.Drawing.Size(14, 13)
        Me.lblJumlahDataOperational.TabIndex = 16
        Me.lblJumlahDataOperational.Text = "0"
        '
        'btnSeacrhTarif
        '
        Me.btnSeacrhTarif.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnSeacrhTarif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeacrhTarif.Location = New System.Drawing.Point(768, 12)
        Me.btnSeacrhTarif.Name = "btnSeacrhTarif"
        Me.btnSeacrhTarif.Size = New System.Drawing.Size(75, 31)
        Me.btnSeacrhTarif.TabIndex = 13
        Me.btnSeacrhTarif.Text = "&Filter"
        Me.btnSeacrhTarif.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSeacrhTarif.UseVisualStyleBackColor = True
        '
        'txtCariNamaBorongan
        '
        Me.txtCariNamaBorongan.Location = New System.Drawing.Point(277, 18)
        Me.txtCariNamaBorongan.MaxLength = 100
        Me.txtCariNamaBorongan.Name = "txtCariNamaBorongan"
        Me.txtCariNamaBorongan.Size = New System.Drawing.Size(161, 20)
        Me.txtCariNamaBorongan.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(690, 317)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Jumlah Data:"
        '
        'cmbCariKendaraan
        '
        Me.cmbCariKendaraan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCariKendaraan.FormattingEnabled = True
        Me.cmbCariKendaraan.Items.AddRange(New Object() {"Biaya Lain", "Kas Bon"})
        Me.cmbCariKendaraan.Location = New System.Drawing.Point(277, 45)
        Me.cmbCariKendaraan.Name = "cmbCariKendaraan"
        Me.cmbCariKendaraan.Size = New System.Drawing.Size(161, 21)
        Me.cmbCariKendaraan.TabIndex = 11
        '
        'dgvMasterTarif
        '
        Me.dgvMasterTarif.AllowUserToAddRows = False
        Me.dgvMasterTarif.AllowUserToOrderColumns = True
        Me.dgvMasterTarif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMasterTarif.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeBorongan, Me.NamaBorongan, Me.NamaBarang, Me.JenisKendaraan, Me.Asal, Me.Tujuan, Me.UbahData, Me.HapusData})
        Me.dgvMasterTarif.Location = New System.Drawing.Point(31, 82)
        Me.dgvMasterTarif.Name = "dgvMasterTarif"
        Me.dgvMasterTarif.ReadOnly = True
        Me.dgvMasterTarif.Size = New System.Drawing.Size(812, 209)
        Me.dgvMasterTarif.TabIndex = 14
        '
        'KodeBorongan
        '
        Me.KodeBorongan.DataPropertyName = "idborongan"
        Me.KodeBorongan.Frozen = True
        Me.KodeBorongan.HeaderText = "Kode Borongan"
        Me.KodeBorongan.Name = "KodeBorongan"
        Me.KodeBorongan.ReadOnly = True
        Me.KodeBorongan.Width = 87
        '
        'NamaBorongan
        '
        Me.NamaBorongan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NamaBorongan.DataPropertyName = "namaborongan"
        Me.NamaBorongan.HeaderText = "Nama Borongan"
        Me.NamaBorongan.Name = "NamaBorongan"
        Me.NamaBorongan.ReadOnly = True
        '
        'NamaBarang
        '
        Me.NamaBarang.DataPropertyName = "namabarang"
        Me.NamaBarang.HeaderText = "Nama Barang"
        Me.NamaBarang.Name = "NamaBarang"
        Me.NamaBarang.ReadOnly = True
        '
        'JenisKendaraan
        '
        Me.JenisKendaraan.DataPropertyName = "namajenis"
        Me.JenisKendaraan.HeaderText = "Jenis Kendaraan"
        Me.JenisKendaraan.Name = "JenisKendaraan"
        Me.JenisKendaraan.ReadOnly = True
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
        'UbahData
        '
        Me.UbahData.HeaderText = "Ubah"
        Me.UbahData.Name = "UbahData"
        Me.UbahData.ReadOnly = True
        Me.UbahData.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UbahData.Text = "Ubah "
        Me.UbahData.UseColumnTextForButtonValue = True
        Me.UbahData.Width = 45
        '
        'HapusData
        '
        Me.HapusData.HeaderText = "Hapus"
        Me.HapusData.Name = "HapusData"
        Me.HapusData.ReadOnly = True
        Me.HapusData.Text = "Hapus"
        Me.HapusData.UseColumnTextForButtonValue = True
        Me.HapusData.Width = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(532, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Kota :"
        '
        'cmbCariKota
        '
        Me.cmbCariKota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCariKota.FormattingEnabled = True
        Me.cmbCariKota.Items.AddRange(New Object() {"Biaya Lain", "Kas Bon"})
        Me.cmbCariKota.Location = New System.Drawing.Point(573, 45)
        Me.cmbCariKota.Name = "cmbCariKota"
        Me.cmbCariKota.Size = New System.Drawing.Size(153, 21)
        Me.cmbCariKota.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(489, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Nama Barang :"
        '
        'cmbCariNamaBarang
        '
        Me.cmbCariNamaBarang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCariNamaBarang.FormattingEnabled = True
        Me.cmbCariNamaBarang.Items.AddRange(New Object() {"Biaya Lain", "Kas Bon"})
        Me.cmbCariNamaBarang.Location = New System.Drawing.Point(573, 18)
        Me.cmbCariNamaBarang.Name = "cmbCariNamaBarang"
        Me.cmbCariNamaBarang.Size = New System.Drawing.Size(153, 21)
        Me.cmbCariNamaBarang.TabIndex = 24
        '
        'FrmTarif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 353)
        Me.Controls.Add(Me.cmbCariNamaBarang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbCariKota)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTambahTarif)
        Me.Controls.Add(Me.lblJumlahDataOperational)
        Me.Controls.Add(Me.btnSeacrhTarif)
        Me.Controls.Add(Me.txtCariNamaBorongan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbCariKendaraan)
        Me.Controls.Add(Me.dgvMasterTarif)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTarif"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Tarif :."
        CType(Me.dgvMasterTarif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnTambahTarif As System.Windows.Forms.Button
    Friend WithEvents lblJumlahDataOperational As System.Windows.Forms.Label
    Friend WithEvents btnSeacrhTarif As System.Windows.Forms.Button
    Friend WithEvents txtCariNamaBorongan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbCariKendaraan As System.Windows.Forms.ComboBox
    Friend WithEvents dgvMasterTarif As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbCariKota As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbCariNamaBarang As System.Windows.Forms.ComboBox
    Friend WithEvents KodeBorongan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBorongan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JenisKendaraan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Asal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tujuan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UbahData As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents HapusData As System.Windows.Forms.DataGridViewButtonColumn
End Class
