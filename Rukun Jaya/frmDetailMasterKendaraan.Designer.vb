<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailMasterKendaraan
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
        Me.txtNoLambung = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoPolisi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPemilik = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMerek = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTahun = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNoRangka = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNoMesin = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNoBPKB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpJatuhTempo = New System.Windows.Forms.DateTimePicker()
        Me.cbJenis = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.cbKodePerusahaan = New System.Windows.Forms.ComboBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpBPKB = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbJenisBuku = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtNoLambung
        '
        Me.txtNoLambung.AcceptsTab = True
        Me.txtNoLambung.Location = New System.Drawing.Point(116, 56)
        Me.txtNoLambung.Name = "txtNoLambung"
        Me.txtNoLambung.Size = New System.Drawing.Size(125, 20)
        Me.txtNoLambung.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "No Lambung : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNoPolisi
        '
        Me.txtNoPolisi.Location = New System.Drawing.Point(116, 82)
        Me.txtNoPolisi.Name = "txtNoPolisi"
        Me.txtNoPolisi.Size = New System.Drawing.Size(125, 20)
        Me.txtNoPolisi.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "No Polisi :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPemilik
        '
        Me.txtPemilik.Location = New System.Drawing.Point(116, 108)
        Me.txtPemilik.Name = "txtPemilik"
        Me.txtPemilik.Size = New System.Drawing.Size(189, 20)
        Me.txtPemilik.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Pemilik :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Kode Perusahaan :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtMerek
        '
        Me.txtMerek.Location = New System.Drawing.Point(115, 161)
        Me.txtMerek.Name = "txtMerek"
        Me.txtMerek.Size = New System.Drawing.Size(125, 20)
        Me.txtMerek.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Merk :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTahun
        '
        Me.txtTahun.Location = New System.Drawing.Point(116, 187)
        Me.txtTahun.MaxLength = 4
        Me.txtTahun.Name = "txtTahun"
        Me.txtTahun.Size = New System.Drawing.Size(67, 20)
        Me.txtTahun.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(64, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Tahun :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNoRangka
        '
        Me.txtNoRangka.Location = New System.Drawing.Point(116, 213)
        Me.txtNoRangka.Name = "txtNoRangka"
        Me.txtNoRangka.Size = New System.Drawing.Size(158, 20)
        Me.txtNoRangka.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "No Rangka :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNoMesin
        '
        Me.txtNoMesin.Location = New System.Drawing.Point(116, 239)
        Me.txtNoMesin.Name = "txtNoMesin"
        Me.txtNoMesin.Size = New System.Drawing.Size(223, 20)
        Me.txtNoMesin.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(50, 242)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "No Mesin :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNoBPKB
        '
        Me.txtNoBPKB.Location = New System.Drawing.Point(116, 265)
        Me.txtNoBPKB.Name = "txtNoBPKB"
        Me.txtNoBPKB.Size = New System.Drawing.Size(175, 20)
        Me.txtNoBPKB.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(50, 268)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "No BPKB :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 294)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Jatuh Tempo :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(71, 355)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Jenis :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dtpJatuhTempo
        '
        Me.dtpJatuhTempo.CustomFormat = "dd-MM-yyyy"
        Me.dtpJatuhTempo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpJatuhTempo.Location = New System.Drawing.Point(172, 291)
        Me.dtpJatuhTempo.Name = "dtpJatuhTempo"
        Me.dtpJatuhTempo.Size = New System.Drawing.Size(91, 20)
        Me.dtpJatuhTempo.TabIndex = 27
        '
        'cbJenis
        '
        Me.cbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbJenis.FormattingEnabled = True
        Me.cbJenis.Location = New System.Drawing.Point(116, 355)
        Me.cbJenis.Name = "cbJenis"
        Me.cbJenis.Size = New System.Drawing.Size(147, 21)
        Me.cbJenis.TabIndex = 29
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(286, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Mode :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Location = New System.Drawing.Point(332, 22)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(22, 13)
        Me.lblMode.TabIndex = 30
        Me.lblMode.Text = "xxx"
        Me.lblMode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbKodePerusahaan
        '
        Me.cbKodePerusahaan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbKodePerusahaan.FormattingEnabled = True
        Me.cbKodePerusahaan.Location = New System.Drawing.Point(115, 133)
        Me.cbKodePerusahaan.Name = "cbKodePerusahaan"
        Me.cbKodePerusahaan.Size = New System.Drawing.Size(159, 21)
        Me.cbKodePerusahaan.TabIndex = 11
        '
        'btnBatal
        '
        Me.btnBatal.Image = Global.RukunJaya.My.Resources.Resources.cancelbr
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(199, 409)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 31)
        Me.btnBatal.TabIndex = 32
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(86, 410)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 31)
        Me.btnSimpan.TabIndex = 31
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(115, 294)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 13)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "STNK"
        '
        'dtpBPKB
        '
        Me.dtpBPKB.CustomFormat = "dd-MM-yyyy"
        Me.dtpBPKB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBPKB.Location = New System.Drawing.Point(172, 317)
        Me.dtpBPKB.Name = "dtpBPKB"
        Me.dtpBPKB.Size = New System.Drawing.Size(91, 20)
        Me.dtpBPKB.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(115, 323)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 13)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "BPKB"
        '
        'cbJenisBuku
        '
        Me.cbJenisBuku.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbJenisBuku.FormattingEnabled = True
        Me.cbJenisBuku.Location = New System.Drawing.Point(115, 383)
        Me.cbJenisBuku.Name = "cbJenisBuku"
        Me.cbJenisBuku.Size = New System.Drawing.Size(148, 21)
        Me.cbJenisBuku.TabIndex = 36
        '
        'frmDetailMasterKendaraan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 452)
        Me.Controls.Add(Me.cbJenisBuku)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dtpBPKB)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cbKodePerusahaan)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.lblMode)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbJenis)
        Me.Controls.Add(Me.dtpJatuhTempo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtNoBPKB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNoMesin)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNoRangka)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTahun)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMerek)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPemilik)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNoPolisi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNoLambung)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetailMasterKendaraan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Master Kendaraan :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNoLambung As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoPolisi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPemilik As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMerek As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTahun As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNoRangka As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNoMesin As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNoBPKB As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpJatuhTempo As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbJenis As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblMode As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents cbKodePerusahaan As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpBPKB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbJenisBuku As System.Windows.Forms.ComboBox
End Class
