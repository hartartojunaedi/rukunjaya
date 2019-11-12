<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailOperationalKendaraan
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
        Me.txtKodeTrans = New System.Windows.Forms.TextBox()
        Me.lblKodeTrans = New System.Windows.Forms.Label()
        Me.lblKaryawan = New System.Windows.Forms.Label()
        Me.numBiaya = New System.Windows.Forms.NumericUpDown()
        Me.lblBiaya = New System.Windows.Forms.Label()
        Me.cmbKendaraan = New System.Windows.Forms.ComboBox()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.dtpTanggalTransaksi = New System.Windows.Forms.DateTimePicker()
        Me.lblTanggalTransaksi = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.numJumlah = New System.Windows.Forms.NumericUpDown()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.cmbsopir = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.numBiaya, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numJumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtKodeTrans
        '
        Me.txtKodeTrans.Location = New System.Drawing.Point(86, 9)
        Me.txtKodeTrans.MaxLength = 10
        Me.txtKodeTrans.Name = "txtKodeTrans"
        Me.txtKodeTrans.Size = New System.Drawing.Size(200, 20)
        Me.txtKodeTrans.TabIndex = 31
        '
        'lblKodeTrans
        '
        Me.lblKodeTrans.AutoSize = True
        Me.lblKodeTrans.Location = New System.Drawing.Point(9, 11)
        Me.lblKodeTrans.Name = "lblKodeTrans"
        Me.lblKodeTrans.Size = New System.Drawing.Size(71, 13)
        Me.lblKodeTrans.TabIndex = 44
        Me.lblKodeTrans.Text = "Kode Trans. :"
        '
        'lblKaryawan
        '
        Me.lblKaryawan.AutoSize = True
        Me.lblKaryawan.Location = New System.Drawing.Point(9, 144)
        Me.lblKaryawan.Name = "lblKaryawan"
        Me.lblKaryawan.Size = New System.Drawing.Size(49, 13)
        Me.lblKaryawan.TabIndex = 43
        Me.lblKaryawan.Text = "Jumlah : "
        '
        'numBiaya
        '
        Me.numBiaya.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numBiaya.Location = New System.Drawing.Point(86, 114)
        Me.numBiaya.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.numBiaya.Name = "numBiaya"
        Me.numBiaya.Size = New System.Drawing.Size(200, 20)
        Me.numBiaya.TabIndex = 34
        Me.numBiaya.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numBiaya.ThousandsSeparator = True
        '
        'lblBiaya
        '
        Me.lblBiaya.AutoSize = True
        Me.lblBiaya.Location = New System.Drawing.Point(9, 116)
        Me.lblBiaya.Name = "lblBiaya"
        Me.lblBiaya.Size = New System.Drawing.Size(39, 13)
        Me.lblBiaya.TabIndex = 42
        Me.lblBiaya.Text = "Biaya :"
        '
        'cmbKendaraan
        '
        Me.cmbKendaraan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbKendaraan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbKendaraan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKendaraan.FormattingEnabled = True
        Me.cmbKendaraan.Location = New System.Drawing.Point(86, 60)
        Me.cmbKendaraan.Name = "cmbKendaraan"
        Me.cmbKendaraan.Size = New System.Drawing.Size(200, 21)
        Me.cmbKendaraan.TabIndex = 33
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Location = New System.Drawing.Point(9, 63)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(41, 13)
        Me.lblJenis.TabIndex = 41
        Me.lblJenis.Text = "Nopol :"
        '
        'dtpTanggalTransaksi
        '
        Me.dtpTanggalTransaksi.CustomFormat = "dd-MM-yyyy"
        Me.dtpTanggalTransaksi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTanggalTransaksi.Location = New System.Drawing.Point(86, 35)
        Me.dtpTanggalTransaksi.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtpTanggalTransaksi.Name = "dtpTanggalTransaksi"
        Me.dtpTanggalTransaksi.Size = New System.Drawing.Size(200, 20)
        Me.dtpTanggalTransaksi.TabIndex = 32
        '
        'lblTanggalTransaksi
        '
        Me.lblTanggalTransaksi.AutoSize = True
        Me.lblTanggalTransaksi.Location = New System.Drawing.Point(9, 38)
        Me.lblTanggalTransaksi.Name = "lblTanggalTransaksi"
        Me.lblTanggalTransaksi.Size = New System.Drawing.Size(52, 13)
        Me.lblTanggalTransaksi.TabIndex = 40
        Me.lblTanggalTransaksi.Text = "Tanggal :"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(12, 204)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(274, 85)
        Me.txtKeterangan.TabIndex = 36
        '
        'lblKeterangan
        '
        Me.lblKeterangan.AutoSize = True
        Me.lblKeterangan.Location = New System.Drawing.Point(9, 187)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(65, 13)
        Me.lblKeterangan.TabIndex = 39
        Me.lblKeterangan.Text = "Keterangan:"
        '
        'numJumlah
        '
        Me.numJumlah.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numJumlah.Location = New System.Drawing.Point(86, 142)
        Me.numJumlah.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 0})
        Me.numJumlah.Name = "numJumlah"
        Me.numJumlah.Size = New System.Drawing.Size(200, 20)
        Me.numJumlah.TabIndex = 35
        Me.numJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numJumlah.ThousandsSeparator = True
        '
        'btnBatal
        '
        Me.btnBatal.Image = Global.RukunJaya.My.Resources.Resources.cancelbr
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(181, 301)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 31)
        Me.btnBatal.TabIndex = 38
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(28, 301)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 31)
        Me.btnSimpan.TabIndex = 37
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'cmbsopir
        '
        Me.cmbsopir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbsopir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbsopir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsopir.FormattingEnabled = True
        Me.cmbsopir.Location = New System.Drawing.Point(86, 87)
        Me.cmbsopir.Name = "cmbsopir"
        Me.cmbsopir.Size = New System.Drawing.Size(200, 21)
        Me.cmbsopir.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Sopir : "
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(86, 169)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(134, 17)
        Me.CheckBox1.TabIndex = 47
        Me.CheckBox1.Text = "Bukti Kas Keluar (BKK)"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'frmDetailOperationalKendaraan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 341)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.cmbsopir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numJumlah)
        Me.Controls.Add(Me.txtKodeTrans)
        Me.Controls.Add(Me.lblKodeTrans)
        Me.Controls.Add(Me.lblKaryawan)
        Me.Controls.Add(Me.numBiaya)
        Me.Controls.Add(Me.lblBiaya)
        Me.Controls.Add(Me.cmbKendaraan)
        Me.Controls.Add(Me.lblJenis)
        Me.Controls.Add(Me.dtpTanggalTransaksi)
        Me.Controls.Add(Me.lblTanggalTransaksi)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.lblKeterangan)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetailOperationalKendaraan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Detail Operational Kendaraan :."
        CType(Me.numBiaya, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numJumlah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtKodeTrans As System.Windows.Forms.TextBox
    Friend WithEvents lblKodeTrans As System.Windows.Forms.Label
    Friend WithEvents lblKaryawan As System.Windows.Forms.Label
    Friend WithEvents numBiaya As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblBiaya As System.Windows.Forms.Label
    Friend WithEvents cmbKendaraan As System.Windows.Forms.ComboBox
    Friend WithEvents lblJenis As System.Windows.Forms.Label
    Friend WithEvents dtpTanggalTransaksi As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTanggalTransaksi As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents lblKeterangan As System.Windows.Forms.Label
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents numJumlah As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbsopir As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
