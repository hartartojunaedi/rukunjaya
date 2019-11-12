<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailTarif
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.btnBatalTarif = New System.Windows.Forms.Button()
        Me.btnSimpanTarif = New System.Windows.Forms.Button()
        Me.cmbJenisKendaraan = New System.Windows.Forms.ComboBox()
        Me.txtNamaBorongan = New System.Windows.Forms.TextBox()
        Me.txtKodeBorongan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmbAsalGudang = New System.Windows.Forms.ComboBox()
        Me.cmbTujuanGudang = New System.Windows.Forms.ComboBox()
        Me.numHargaBorongan = New System.Windows.Forms.NumericUpDown()
        Me.numHargaBoronganSopir = New System.Windows.Forms.NumericUpDown()
        Me.numSangu = New System.Windows.Forms.NumericUpDown()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbNamaBrg = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.numOngkos = New System.Windows.Forms.NumericUpDown()
        Me.numKuli = New System.Windows.Forms.NumericUpDown()
        Me.Label28 = New System.Windows.Forms.Label()
        CType(Me.numHargaBorongan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHargaBoronganSopir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSangu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numOngkos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numKuli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(258, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "(Kode Borongan Wajib Diisi)"
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Location = New System.Drawing.Point(366, 9)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(31, 13)
        Me.lblMode.TabIndex = 30
        Me.lblMode.Text = "ubah"
        Me.lblMode.Visible = False
        '
        'btnBatalTarif
        '
        Me.btnBatalTarif.Image = Global.RukunJaya.My.Resources.Resources.cancelbr1
        Me.btnBatalTarif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatalTarif.Location = New System.Drawing.Point(369, 392)
        Me.btnBatalTarif.Name = "btnBatalTarif"
        Me.btnBatalTarif.Size = New System.Drawing.Size(75, 31)
        Me.btnBatalTarif.TabIndex = 13
        Me.btnBatalTarif.Text = "&Batal"
        Me.btnBatalTarif.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatalTarif.UseVisualStyleBackColor = True
        '
        'btnSimpanTarif
        '
        Me.btnSimpanTarif.Image = Global.RukunJaya.My.Resources.Resources.savebr1
        Me.btnSimpanTarif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpanTarif.Location = New System.Drawing.Point(292, 392)
        Me.btnSimpanTarif.Name = "btnSimpanTarif"
        Me.btnSimpanTarif.Size = New System.Drawing.Size(75, 31)
        Me.btnSimpanTarif.TabIndex = 12
        Me.btnSimpanTarif.Text = "&Simpan"
        Me.btnSimpanTarif.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpanTarif.UseVisualStyleBackColor = True
        '
        'cmbJenisKendaraan
        '
        Me.cmbJenisKendaraan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJenisKendaraan.FormattingEnabled = True
        Me.cmbJenisKendaraan.Items.AddRange(New Object() {"Biaya Lain", "Kas Bon"})
        Me.cmbJenisKendaraan.Location = New System.Drawing.Point(152, 101)
        Me.cmbJenisKendaraan.Name = "cmbJenisKendaraan"
        Me.cmbJenisKendaraan.Size = New System.Drawing.Size(165, 21)
        Me.cmbJenisKendaraan.TabIndex = 3
        '
        'txtNamaBorongan
        '
        Me.txtNamaBorongan.Location = New System.Drawing.Point(152, 71)
        Me.txtNamaBorongan.MaxLength = 50
        Me.txtNamaBorongan.Name = "txtNamaBorongan"
        Me.txtNamaBorongan.Size = New System.Drawing.Size(246, 20)
        Me.txtNamaBorongan.TabIndex = 2
        '
        'txtKodeBorongan
        '
        Me.txtKodeBorongan.Location = New System.Drawing.Point(152, 39)
        Me.txtKodeBorongan.MaxLength = 10
        Me.txtKodeBorongan.Name = "txtKodeBorongan"
        Me.txtKodeBorongan.Size = New System.Drawing.Size(100, 20)
        Me.txtKodeBorongan.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(131, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(131, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(131, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(131, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Asal Gudang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Jenis Kendaraan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nama Borongan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Kode Borongan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(49, 193)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Tujuan Gudang"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(44, 225)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 13)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Harga Borongan"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 254)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Harga Borongan Sopir"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(65, 283)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Sangu Sopir"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(131, 193)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(10, 13)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(131, 225)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(10, 13)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = ":"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(131, 254)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(10, 13)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(131, 283)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(10, 13)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = ":"
        '
        'cmbAsalGudang
        '
        Me.cmbAsalGudang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAsalGudang.FormattingEnabled = True
        Me.cmbAsalGudang.Location = New System.Drawing.Point(152, 159)
        Me.cmbAsalGudang.Name = "cmbAsalGudang"
        Me.cmbAsalGudang.Size = New System.Drawing.Size(137, 21)
        Me.cmbAsalGudang.TabIndex = 5
        '
        'cmbTujuanGudang
        '
        Me.cmbTujuanGudang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTujuanGudang.FormattingEnabled = True
        Me.cmbTujuanGudang.Location = New System.Drawing.Point(152, 190)
        Me.cmbTujuanGudang.Name = "cmbTujuanGudang"
        Me.cmbTujuanGudang.Size = New System.Drawing.Size(137, 21)
        Me.cmbTujuanGudang.TabIndex = 6
        '
        'numHargaBorongan
        '
        Me.numHargaBorongan.Location = New System.Drawing.Point(176, 223)
        Me.numHargaBorongan.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.numHargaBorongan.Name = "numHargaBorongan"
        Me.numHargaBorongan.Size = New System.Drawing.Size(111, 20)
        Me.numHargaBorongan.TabIndex = 7
        Me.numHargaBorongan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numHargaBorongan.ThousandsSeparator = True
        '
        'numHargaBoronganSopir
        '
        Me.numHargaBoronganSopir.Location = New System.Drawing.Point(178, 252)
        Me.numHargaBoronganSopir.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.numHargaBoronganSopir.Name = "numHargaBoronganSopir"
        Me.numHargaBoronganSopir.Size = New System.Drawing.Size(111, 20)
        Me.numHargaBoronganSopir.TabIndex = 8
        Me.numHargaBoronganSopir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numHargaBoronganSopir.ThousandsSeparator = True
        '
        'numSangu
        '
        Me.numSangu.Location = New System.Drawing.Point(178, 281)
        Me.numSangu.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.numSangu.Name = "numSangu"
        Me.numSangu.Size = New System.Drawing.Size(111, 20)
        Me.numSangu.TabIndex = 9
        Me.numSangu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numSangu.ThousandsSeparator = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(58, 134)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 13)
        Me.Label18.TabIndex = 56
        Me.Label18.Text = "Nama Barang"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(131, 134)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(10, 13)
        Me.Label19.TabIndex = 57
        Me.Label19.Text = ":"
        '
        'cmbNamaBrg
        '
        Me.cmbNamaBrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNamaBrg.FormattingEnabled = True
        Me.cmbNamaBrg.Location = New System.Drawing.Point(152, 131)
        Me.cmbNamaBrg.Name = "cmbNamaBrg"
        Me.cmbNamaBrg.Size = New System.Drawing.Size(196, 21)
        Me.cmbNamaBrg.TabIndex = 4
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(149, 225)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(21, 13)
        Me.Label20.TabIndex = 58
        Me.Label20.Text = "Rp"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(149, 254)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(21, 13)
        Me.Label21.TabIndex = 59
        Me.Label21.Text = "Rp"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(149, 283)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(21, 13)
        Me.Label22.TabIndex = 60
        Me.Label22.Text = "Rp"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(86, 314)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(44, 13)
        Me.Label23.TabIndex = 61
        Me.Label23.Text = "Ongkos"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(131, 314)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(10, 13)
        Me.Label24.TabIndex = 62
        Me.Label24.Text = ":"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(131, 344)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(10, 13)
        Me.Label25.TabIndex = 63
        Me.Label25.Text = ":"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(66, 344)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(64, 13)
        Me.Label26.TabIndex = 64
        Me.Label26.Text = "Ongkos Kuli"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(149, 314)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(21, 13)
        Me.Label27.TabIndex = 65
        Me.Label27.Text = "Rp"
        '
        'numOngkos
        '
        Me.numOngkos.Location = New System.Drawing.Point(178, 312)
        Me.numOngkos.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.numOngkos.Name = "numOngkos"
        Me.numOngkos.Size = New System.Drawing.Size(111, 20)
        Me.numOngkos.TabIndex = 10
        Me.numOngkos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numOngkos.ThousandsSeparator = True
        '
        'numKuli
        '
        Me.numKuli.Location = New System.Drawing.Point(178, 342)
        Me.numKuli.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.numKuli.Name = "numKuli"
        Me.numKuli.Size = New System.Drawing.Size(111, 20)
        Me.numKuli.TabIndex = 11
        Me.numKuli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numKuli.ThousandsSeparator = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(151, 344)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(21, 13)
        Me.Label28.TabIndex = 68
        Me.Label28.Text = "Rp"
        '
        'frmDetailTarif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 444)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.numKuli)
        Me.Controls.Add(Me.numOngkos)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cmbNamaBrg)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.numSangu)
        Me.Controls.Add(Me.numHargaBoronganSopir)
        Me.Controls.Add(Me.numHargaBorongan)
        Me.Controls.Add(Me.cmbTujuanGudang)
        Me.Controls.Add(Me.cmbAsalGudang)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblMode)
        Me.Controls.Add(Me.btnBatalTarif)
        Me.Controls.Add(Me.btnSimpanTarif)
        Me.Controls.Add(Me.cmbJenisKendaraan)
        Me.Controls.Add(Me.txtNamaBorongan)
        Me.Controls.Add(Me.txtKodeBorongan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetailTarif"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Detail Tarif :."
        CType(Me.numHargaBorongan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numHargaBoronganSopir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSangu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numOngkos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numKuli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblMode As System.Windows.Forms.Label
    Friend WithEvents btnBatalTarif As System.Windows.Forms.Button
    Friend WithEvents btnSimpanTarif As System.Windows.Forms.Button
    Friend WithEvents cmbJenisKendaraan As System.Windows.Forms.ComboBox
    Friend WithEvents txtNamaBorongan As System.Windows.Forms.TextBox
    Friend WithEvents txtKodeBorongan As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmbAsalGudang As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTujuanGudang As System.Windows.Forms.ComboBox
    Friend WithEvents numHargaBorongan As System.Windows.Forms.NumericUpDown
    Friend WithEvents numHargaBoronganSopir As System.Windows.Forms.NumericUpDown
    Friend WithEvents numSangu As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmbNamaBrg As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents numOngkos As System.Windows.Forms.NumericUpDown
    Friend WithEvents numKuli As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label28 As System.Windows.Forms.Label
End Class
