<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailSopir
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
        Me.lblKodeSopir = New System.Windows.Forms.Label()
        Me.lblPanggilan = New System.Windows.Forms.Label()
        Me.lblNamaSopir = New System.Windows.Forms.Label()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.lblKota = New System.Windows.Forms.Label()
        Me.lblHp = New System.Windows.Forms.Label()
        Me.lblNoID = New System.Windows.Forms.Label()
        Me.txtKodeSopir = New System.Windows.Forms.TextBox()
        Me.txtPanggilan = New System.Windows.Forms.TextBox()
        Me.txtNamaSopir = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtKota = New System.Windows.Forms.TextBox()
        Me.txtHP = New System.Windows.Forms.TextBox()
        Me.txtNoID = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblTglMasuk = New System.Windows.Forms.Label()
        Me.cmbstatus = New System.Windows.Forms.ComboBox()
        Me.dtpsopir = New System.Windows.Forms.DateTimePicker()
        Me.txtrtrw = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKelurahan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKecamatan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblnamafile = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTempatLahir = New System.Windows.Forms.TextBox()
        Me.dtpTglLahir = New System.Windows.Forms.DateTimePicker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblKodeSopir
        '
        Me.lblKodeSopir.AutoSize = True
        Me.lblKodeSopir.Location = New System.Drawing.Point(23, 23)
        Me.lblKodeSopir.Name = "lblKodeSopir"
        Me.lblKodeSopir.Size = New System.Drawing.Size(82, 13)
        Me.lblKodeSopir.TabIndex = 4
        Me.lblKodeSopir.Text = "Kode Karyawan"
        '
        'lblPanggilan
        '
        Me.lblPanggilan.AutoSize = True
        Me.lblPanggilan.Location = New System.Drawing.Point(51, 54)
        Me.lblPanggilan.Name = "lblPanggilan"
        Me.lblPanggilan.Size = New System.Drawing.Size(54, 13)
        Me.lblPanggilan.TabIndex = 5
        Me.lblPanggilan.Text = "Panggilan"
        '
        'lblNamaSopir
        '
        Me.lblNamaSopir.AutoSize = True
        Me.lblNamaSopir.Location = New System.Drawing.Point(20, 87)
        Me.lblNamaSopir.Name = "lblNamaSopir"
        Me.lblNamaSopir.Size = New System.Drawing.Size(85, 13)
        Me.lblNamaSopir.TabIndex = 6
        Me.lblNamaSopir.Text = "Nama Karyawan"
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Location = New System.Drawing.Point(66, 146)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(39, 13)
        Me.lblAlamat.TabIndex = 7
        Me.lblAlamat.Text = "Alamat"
        '
        'lblKota
        '
        Me.lblKota.AutoSize = True
        Me.lblKota.Location = New System.Drawing.Point(76, 286)
        Me.lblKota.Name = "lblKota"
        Me.lblKota.Size = New System.Drawing.Size(29, 13)
        Me.lblKota.TabIndex = 9
        Me.lblKota.Text = "Kota"
        '
        'lblHp
        '
        Me.lblHp.AutoSize = True
        Me.lblHp.Location = New System.Drawing.Point(49, 319)
        Me.lblHp.Name = "lblHp"
        Me.lblHp.Size = New System.Drawing.Size(56, 13)
        Me.lblHp.TabIndex = 10
        Me.lblHp.Text = "Nomor HP"
        '
        'lblNoID
        '
        Me.lblNoID.AutoSize = True
        Me.lblNoID.Location = New System.Drawing.Point(60, 351)
        Me.lblNoID.Name = "lblNoID"
        Me.lblNoID.Size = New System.Drawing.Size(45, 13)
        Me.lblNoID.TabIndex = 11
        Me.lblNoID.Text = "No KTP"
        '
        'txtKodeSopir
        '
        Me.txtKodeSopir.Location = New System.Drawing.Point(132, 20)
        Me.txtKodeSopir.Name = "txtKodeSopir"
        Me.txtKodeSopir.Size = New System.Drawing.Size(165, 20)
        Me.txtKodeSopir.TabIndex = 1
        '
        'txtPanggilan
        '
        Me.txtPanggilan.Location = New System.Drawing.Point(132, 51)
        Me.txtPanggilan.Name = "txtPanggilan"
        Me.txtPanggilan.Size = New System.Drawing.Size(187, 20)
        Me.txtPanggilan.TabIndex = 2
        '
        'txtNamaSopir
        '
        Me.txtNamaSopir.Location = New System.Drawing.Point(132, 84)
        Me.txtNamaSopir.Name = "txtNamaSopir"
        Me.txtNamaSopir.Size = New System.Drawing.Size(187, 20)
        Me.txtNamaSopir.TabIndex = 3
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(132, 143)
        Me.txtAlamat.MaxLength = 50
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(187, 20)
        Me.txtAlamat.TabIndex = 6
        '
        'txtKota
        '
        Me.txtKota.Location = New System.Drawing.Point(132, 283)
        Me.txtKota.Name = "txtKota"
        Me.txtKota.Size = New System.Drawing.Size(187, 20)
        Me.txtKota.TabIndex = 10
        '
        'txtHP
        '
        Me.txtHP.Location = New System.Drawing.Point(132, 316)
        Me.txtHP.Name = "txtHP"
        Me.txtHP.Size = New System.Drawing.Size(165, 20)
        Me.txtHP.TabIndex = 11
        '
        'txtNoID
        '
        Me.txtNoID.Location = New System.Drawing.Point(132, 348)
        Me.txtNoID.Name = "txtNoID"
        Me.txtNoID.Size = New System.Drawing.Size(165, 20)
        Me.txtNoID.TabIndex = 12
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(68, 382)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 20
        Me.lblStatus.Text = "Status"
        '
        'lblTglMasuk
        '
        Me.lblTglMasuk.AutoSize = True
        Me.lblTglMasuk.Location = New System.Drawing.Point(24, 415)
        Me.lblTglMasuk.Name = "lblTglMasuk"
        Me.lblTglMasuk.Size = New System.Drawing.Size(81, 13)
        Me.lblTglMasuk.TabIndex = 21
        Me.lblTglMasuk.Text = "Tanggal Masuk"
        '
        'cmbstatus
        '
        Me.cmbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbstatus.FormattingEnabled = True
        Me.cmbstatus.ItemHeight = 13
        Me.cmbstatus.Items.AddRange(New Object() {"Sopir Aktif", "Karyawan Aktif", "Tidak Aktif"})
        Me.cmbstatus.Location = New System.Drawing.Point(132, 379)
        Me.cmbstatus.Name = "cmbstatus"
        Me.cmbstatus.Size = New System.Drawing.Size(165, 21)
        Me.cmbstatus.TabIndex = 22
        '
        'dtpsopir
        '
        Me.dtpsopir.CustomFormat = "dd-MM-yyyy"
        Me.dtpsopir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpsopir.Location = New System.Drawing.Point(132, 412)
        Me.dtpsopir.Name = "dtpsopir"
        Me.dtpsopir.Size = New System.Drawing.Size(96, 20)
        Me.dtpsopir.TabIndex = 23
        '
        'txtrtrw
        '
        Me.txtrtrw.Location = New System.Drawing.Point(132, 179)
        Me.txtrtrw.MaxLength = 10
        Me.txtrtrw.Name = "txtrtrw"
        Me.txtrtrw.Size = New System.Drawing.Size(54, 20)
        Me.txtrtrw.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "RT / RW"
        '
        'txtKelurahan
        '
        Me.txtKelurahan.Location = New System.Drawing.Point(132, 212)
        Me.txtKelurahan.MaxLength = 50
        Me.txtKelurahan.Name = "txtKelurahan"
        Me.txtKelurahan.Size = New System.Drawing.Size(187, 20)
        Me.txtKelurahan.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Kelurahan"
        '
        'txtKecamatan
        '
        Me.txtKecamatan.Location = New System.Drawing.Point(132, 251)
        Me.txtKecamatan.MaxLength = 50
        Me.txtKecamatan.Name = "txtKecamatan"
        Me.txtKecamatan.Size = New System.Drawing.Size(187, 20)
        Me.txtKecamatan.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Kecamatan"
        '
        'lblnamafile
        '
        Me.lblnamafile.AutoSize = True
        Me.lblnamafile.Location = New System.Drawing.Point(424, 289)
        Me.lblnamafile.Name = "lblnamafile"
        Me.lblnamafile.Size = New System.Drawing.Size(0, 13)
        Me.lblnamafile.TabIndex = 30
        Me.lblnamafile.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Picture Files | *.jpg"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = Global.RukunJaya.My.Resources.Resources.nophoto
        Me.PictureBox1.Location = New System.Drawing.Point(405, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 225)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(185, 440)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 31)
        Me.btnTambah.TabIndex = 0
        Me.btnTambah.Text = "&Simpan"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(185, 440)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 31)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "&Simpan"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.Image = Global.RukunJaya.My.Resources.Resources.cancelbr
        Me.btnbatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbatal.Location = New System.Drawing.Point(349, 440)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(75, 31)
        Me.btnbatal.TabIndex = 3
        Me.btnbatal.Text = "&Batal"
        Me.btnbatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(405, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Click Photo To Change"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Tempat / Tgl Lahir"
        '
        'txtTempatLahir
        '
        Me.txtTempatLahir.Location = New System.Drawing.Point(132, 114)
        Me.txtTempatLahir.Name = "txtTempatLahir"
        Me.txtTempatLahir.Size = New System.Drawing.Size(114, 20)
        Me.txtTempatLahir.TabIndex = 4
        '
        'dtpTglLahir
        '
        Me.dtpTglLahir.CustomFormat = "dd-MM-yyyy"
        Me.dtpTglLahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTglLahir.Location = New System.Drawing.Point(252, 114)
        Me.dtpTglLahir.Name = "dtpTglLahir"
        Me.dtpTglLahir.Size = New System.Drawing.Size(96, 20)
        Me.dtpTglLahir.TabIndex = 5
        '
        'frmDetailSopir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 483)
        Me.Controls.Add(Me.dtpTglLahir)
        Me.Controls.Add(Me.txtTempatLahir)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblnamafile)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtKecamatan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtKelurahan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtrtrw)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.dtpsopir)
        Me.Controls.Add(Me.cmbstatus)
        Me.Controls.Add(Me.lblTglMasuk)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtNoID)
        Me.Controls.Add(Me.txtHP)
        Me.Controls.Add(Me.txtKota)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtNamaSopir)
        Me.Controls.Add(Me.txtPanggilan)
        Me.Controls.Add(Me.txtKodeSopir)
        Me.Controls.Add(Me.lblNoID)
        Me.Controls.Add(Me.lblHp)
        Me.Controls.Add(Me.lblKota)
        Me.Controls.Add(Me.lblAlamat)
        Me.Controls.Add(Me.lblNamaSopir)
        Me.Controls.Add(Me.lblPanggilan)
        Me.Controls.Add(Me.lblKodeSopir)
        Me.Controls.Add(Me.btnbatal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetailSopir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Detail Karyawan :."
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents lblKodeSopir As System.Windows.Forms.Label
    Friend WithEvents lblPanggilan As System.Windows.Forms.Label
    Friend WithEvents lblNamaSopir As System.Windows.Forms.Label
    Friend WithEvents lblAlamat As System.Windows.Forms.Label
    Friend WithEvents lblKota As System.Windows.Forms.Label
    Friend WithEvents lblHp As System.Windows.Forms.Label
    Friend WithEvents lblNoID As System.Windows.Forms.Label
    Friend WithEvents txtKodeSopir As System.Windows.Forms.TextBox
    Friend WithEvents txtPanggilan As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaSopir As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtKota As System.Windows.Forms.TextBox
    Friend WithEvents txtHP As System.Windows.Forms.TextBox
    Friend WithEvents txtNoID As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblTglMasuk As System.Windows.Forms.Label
    Friend WithEvents cmbstatus As System.Windows.Forms.ComboBox
    Friend WithEvents dtpsopir As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtrtrw As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKelurahan As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKecamatan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblnamafile As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTempatLahir As System.Windows.Forms.TextBox
    Friend WithEvents dtpTglLahir As System.Windows.Forms.DateTimePicker
End Class
