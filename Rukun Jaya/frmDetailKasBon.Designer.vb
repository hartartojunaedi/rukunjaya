<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailKasBon
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
        Me.cmbKaryawan = New System.Windows.Forms.ComboBox()
        Me.lblSopir = New System.Windows.Forms.Label()
        Me.numBiaya = New System.Windows.Forms.NumericUpDown()
        Me.lblBiaya = New System.Windows.Forms.Label()
        Me.cmbJenis = New System.Windows.Forms.ComboBox()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.dtpTanggalTransaksi = New System.Windows.Forms.DateTimePicker()
        Me.lblTanggalTransaksi = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        CType(Me.numBiaya, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtKodeTrans
        '
        Me.txtKodeTrans.Location = New System.Drawing.Point(95, 8)
        Me.txtKodeTrans.MaxLength = 10
        Me.txtKodeTrans.Name = "txtKodeTrans"
        Me.txtKodeTrans.Size = New System.Drawing.Size(200, 20)
        Me.txtKodeTrans.TabIndex = 31
        '
        'lblKodeTrans
        '
        Me.lblKodeTrans.AutoSize = True
        Me.lblKodeTrans.Location = New System.Drawing.Point(18, 10)
        Me.lblKodeTrans.Name = "lblKodeTrans"
        Me.lblKodeTrans.Size = New System.Drawing.Size(71, 13)
        Me.lblKodeTrans.TabIndex = 44
        Me.lblKodeTrans.Text = "Kode Trans. :"
        '
        'cmbKaryawan
        '
        Me.cmbKaryawan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKaryawan.FormattingEnabled = True
        Me.cmbKaryawan.Location = New System.Drawing.Point(95, 111)
        Me.cmbKaryawan.Name = "cmbKaryawan"
        Me.cmbKaryawan.Size = New System.Drawing.Size(200, 21)
        Me.cmbKaryawan.TabIndex = 35
        '
        'lblSopir
        '
        Me.lblSopir.AutoSize = True
        Me.lblSopir.Location = New System.Drawing.Point(18, 115)
        Me.lblSopir.Name = "lblSopir"
        Me.lblSopir.Size = New System.Drawing.Size(37, 13)
        Me.lblSopir.TabIndex = 43
        Me.lblSopir.Text = "Sopir :"
        '
        'numBiaya
        '
        Me.numBiaya.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numBiaya.Location = New System.Drawing.Point(95, 85)
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
        Me.lblBiaya.Location = New System.Drawing.Point(18, 87)
        Me.lblBiaya.Name = "lblBiaya"
        Me.lblBiaya.Size = New System.Drawing.Size(39, 13)
        Me.lblBiaya.TabIndex = 42
        Me.lblBiaya.Text = "Biaya :"
        '
        'cmbJenis
        '
        Me.cmbJenis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbJenis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJenis.FormattingEnabled = True
        Me.cmbJenis.Location = New System.Drawing.Point(95, 59)
        Me.cmbJenis.Name = "cmbJenis"
        Me.cmbJenis.Size = New System.Drawing.Size(200, 21)
        Me.cmbJenis.TabIndex = 33
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Location = New System.Drawing.Point(18, 62)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(37, 13)
        Me.lblJenis.TabIndex = 41
        Me.lblJenis.Text = "Jenis :"
        '
        'dtpTanggalTransaksi
        '
        Me.dtpTanggalTransaksi.CustomFormat = "dd-MM-yyyy"
        Me.dtpTanggalTransaksi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTanggalTransaksi.Location = New System.Drawing.Point(95, 34)
        Me.dtpTanggalTransaksi.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtpTanggalTransaksi.Name = "dtpTanggalTransaksi"
        Me.dtpTanggalTransaksi.Size = New System.Drawing.Size(200, 20)
        Me.dtpTanggalTransaksi.TabIndex = 32
        '
        'lblTanggalTransaksi
        '
        Me.lblTanggalTransaksi.AutoSize = True
        Me.lblTanggalTransaksi.Location = New System.Drawing.Point(18, 37)
        Me.lblTanggalTransaksi.Name = "lblTanggalTransaksi"
        Me.lblTanggalTransaksi.Size = New System.Drawing.Size(52, 13)
        Me.lblTanggalTransaksi.TabIndex = 40
        Me.lblTanggalTransaksi.Text = "Tanggal :"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(21, 157)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(274, 85)
        Me.txtKeterangan.TabIndex = 36
        '
        'lblKeterangan
        '
        Me.lblKeterangan.AutoSize = True
        Me.lblKeterangan.Location = New System.Drawing.Point(18, 140)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(65, 13)
        Me.lblKeterangan.TabIndex = 39
        Me.lblKeterangan.Text = "Keterangan:"
        '
        'btnBatal
        '
        Me.btnBatal.Image = Global.RukunJaya.My.Resources.Resources.cancelbr
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(174, 254)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 31)
        Me.btnBatal.TabIndex = 38
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(21, 254)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 31)
        Me.btnSimpan.TabIndex = 37
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'frmDetailKasBon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 309)
        Me.Controls.Add(Me.txtKodeTrans)
        Me.Controls.Add(Me.lblKodeTrans)
        Me.Controls.Add(Me.cmbKaryawan)
        Me.Controls.Add(Me.lblSopir)
        Me.Controls.Add(Me.numBiaya)
        Me.Controls.Add(Me.lblBiaya)
        Me.Controls.Add(Me.cmbJenis)
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
        Me.Name = "frmDetailKasBon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Detail Kas Bon :."
        CType(Me.numBiaya, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtKodeTrans As System.Windows.Forms.TextBox
    Friend WithEvents lblKodeTrans As System.Windows.Forms.Label
    Friend WithEvents cmbKaryawan As System.Windows.Forms.ComboBox
    Friend WithEvents lblSopir As System.Windows.Forms.Label
    Friend WithEvents numBiaya As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblBiaya As System.Windows.Forms.Label
    Friend WithEvents cmbJenis As System.Windows.Forms.ComboBox
    Friend WithEvents lblJenis As System.Windows.Forms.Label
    Friend WithEvents dtpTanggalTransaksi As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTanggalTransaksi As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents lblKeterangan As System.Windows.Forms.Label
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
End Class
