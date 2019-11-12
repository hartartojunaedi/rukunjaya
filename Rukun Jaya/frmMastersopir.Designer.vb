<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMastersopir
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
        Me.dgvsopir = New System.Windows.Forms.DataGridView()
        Me.txtcaripanggil = New System.Windows.Forms.TextBox()
        Me.lblcaripanggil = New System.Windows.Forms.Label()
        Me.lblnama = New System.Windows.Forms.Label()
        Me.txtcarinama = New System.Windows.Forms.TextBox()
        Me.lblcarialamat = New System.Windows.Forms.Label()
        Me.txtcarialamat = New System.Windows.Forms.TextBox()
        Me.lblkota = New System.Windows.Forms.Label()
        Me.txtcarikota = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btncari = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.kodesopir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rtrw = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kelurahan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kecamatan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panggilan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namasopir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.noid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tglmasuk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglLahir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TempatLahir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvsopir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvsopir
        '
        Me.dgvsopir.AllowUserToAddRows = False
        Me.dgvsopir.AllowUserToDeleteRows = False
        Me.dgvsopir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsopir.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodesopir, Me.rtrw, Me.kelurahan, Me.kecamatan, Me.panggilan, Me.namasopir, Me.alamat, Me.kota, Me.hp, Me.noid, Me.status, Me.tglmasuk, Me.TglLahir, Me.TempatLahir})
        Me.dgvsopir.Location = New System.Drawing.Point(12, 71)
        Me.dgvsopir.Name = "dgvsopir"
        Me.dgvsopir.ReadOnly = True
        Me.dgvsopir.Size = New System.Drawing.Size(1028, 274)
        Me.dgvsopir.TabIndex = 2
        '
        'txtcaripanggil
        '
        Me.txtcaripanggil.Location = New System.Drawing.Point(77, 28)
        Me.txtcaripanggil.Name = "txtcaripanggil"
        Me.txtcaripanggil.Size = New System.Drawing.Size(146, 20)
        Me.txtcaripanggil.TabIndex = 3
        '
        'lblcaripanggil
        '
        Me.lblcaripanggil.AutoSize = True
        Me.lblcaripanggil.Location = New System.Drawing.Point(17, 31)
        Me.lblcaripanggil.Name = "lblcaripanggil"
        Me.lblcaripanggil.Size = New System.Drawing.Size(54, 13)
        Me.lblcaripanggil.TabIndex = 5
        Me.lblcaripanggil.Text = "Panggilan"
        '
        'lblnama
        '
        Me.lblnama.AutoSize = True
        Me.lblnama.Location = New System.Drawing.Point(415, 31)
        Me.lblnama.Name = "lblnama"
        Me.lblnama.Size = New System.Drawing.Size(35, 13)
        Me.lblnama.TabIndex = 7
        Me.lblnama.Text = "Nama"
        '
        'txtcarinama
        '
        Me.txtcarinama.Location = New System.Drawing.Point(456, 28)
        Me.txtcarinama.Name = "txtcarinama"
        Me.txtcarinama.Size = New System.Drawing.Size(146, 20)
        Me.txtcarinama.TabIndex = 6
        '
        'lblcarialamat
        '
        Me.lblcarialamat.AutoSize = True
        Me.lblcarialamat.Location = New System.Drawing.Point(238, 31)
        Me.lblcarialamat.Name = "lblcarialamat"
        Me.lblcarialamat.Size = New System.Drawing.Size(39, 13)
        Me.lblcarialamat.TabIndex = 9
        Me.lblcarialamat.Text = "Alamat"
        '
        'txtcarialamat
        '
        Me.txtcarialamat.Location = New System.Drawing.Point(279, 28)
        Me.txtcarialamat.Name = "txtcarialamat"
        Me.txtcarialamat.Size = New System.Drawing.Size(129, 20)
        Me.txtcarialamat.TabIndex = 8
        '
        'lblkota
        '
        Me.lblkota.AutoSize = True
        Me.lblkota.Location = New System.Drawing.Point(609, 27)
        Me.lblkota.Name = "lblkota"
        Me.lblkota.Size = New System.Drawing.Size(29, 13)
        Me.lblkota.TabIndex = 11
        Me.lblkota.Text = "Kota"
        '
        'txtcarikota
        '
        Me.txtcarikota.Location = New System.Drawing.Point(640, 24)
        Me.txtcarikota.Name = "txtcarikota"
        Me.txtcarikota.Size = New System.Drawing.Size(146, 20)
        Me.txtcarikota.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.btncari)
        Me.GroupBox1.Controls.Add(Me.txtcaripanggil)
        Me.GroupBox1.Controls.Add(Me.lblkota)
        Me.GroupBox1.Controls.Add(Me.lblcaripanggil)
        Me.GroupBox1.Controls.Add(Me.txtcarikota)
        Me.GroupBox1.Controls.Add(Me.txtcarinama)
        Me.GroupBox1.Controls.Add(Me.lblcarialamat)
        Me.GroupBox1.Controls.Add(Me.lblnama)
        Me.GroupBox1.Controls.Add(Me.txtcarialamat)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1105, 62)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "0"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Semua", "Sopir Aktif", "Karyawan Aktif", "Tidak Aktif"})
        Me.ComboBox1.Location = New System.Drawing.Point(792, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 13
        Me.ComboBox1.ValueMember = "0"
        '
        'btncari
        '
        Me.btncari.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btncari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncari.Location = New System.Drawing.Point(919, 19)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(80, 29)
        Me.btncari.TabIndex = 12
        Me.btncari.Text = "&Filter"
        Me.btncari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncari.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.RukunJaya.My.Resources.Resources.xls
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(98, 351)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 29)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "&Excell"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.btntambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntambah.Location = New System.Drawing.Point(12, 351)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(80, 29)
        Me.btntambah.TabIndex = 4
        Me.btntambah.Text = "&Tambah"
        Me.btntambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(185, 351)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 14
        Me.TextBox1.Visible = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "xls"
        Me.SaveFileDialog1.Filter = """Excell File|.xls|All Files|*.*"""
        '
        'kodesopir
        '
        Me.kodesopir.DataPropertyName = "kodesopir"
        Me.kodesopir.HeaderText = "Kode Karyawan"
        Me.kodesopir.Name = "kodesopir"
        Me.kodesopir.ReadOnly = True
        Me.kodesopir.Width = 80
        '
        'rtrw
        '
        Me.rtrw.DataPropertyName = "rtrw"
        Me.rtrw.HeaderText = "RT/RW"
        Me.rtrw.Name = "rtrw"
        Me.rtrw.ReadOnly = True
        Me.rtrw.Visible = False
        Me.rtrw.Width = 50
        '
        'kelurahan
        '
        Me.kelurahan.DataPropertyName = "kelurahan"
        Me.kelurahan.HeaderText = "Kelurahan"
        Me.kelurahan.Name = "kelurahan"
        Me.kelurahan.ReadOnly = True
        Me.kelurahan.Visible = False
        Me.kelurahan.Width = 60
        '
        'kecamatan
        '
        Me.kecamatan.DataPropertyName = "kecamatan"
        Me.kecamatan.HeaderText = "Kecamatan"
        Me.kecamatan.Name = "kecamatan"
        Me.kecamatan.ReadOnly = True
        Me.kecamatan.Visible = False
        Me.kecamatan.Width = 60
        '
        'panggilan
        '
        Me.panggilan.DataPropertyName = "panggilan"
        Me.panggilan.HeaderText = "Panggilan"
        Me.panggilan.Name = "panggilan"
        Me.panggilan.ReadOnly = True
        Me.panggilan.Width = 70
        '
        'namasopir
        '
        Me.namasopir.DataPropertyName = "namasopir"
        Me.namasopir.HeaderText = "Nama Karyawan"
        Me.namasopir.Name = "namasopir"
        Me.namasopir.ReadOnly = True
        '
        'alamat
        '
        Me.alamat.DataPropertyName = "alamat"
        Me.alamat.HeaderText = "Alamat"
        Me.alamat.Name = "alamat"
        Me.alamat.ReadOnly = True
        '
        'kota
        '
        Me.kota.DataPropertyName = "kota"
        Me.kota.HeaderText = "Kota"
        Me.kota.Name = "kota"
        Me.kota.ReadOnly = True
        Me.kota.Width = 75
        '
        'hp
        '
        Me.hp.DataPropertyName = "hp"
        Me.hp.HeaderText = "HP"
        Me.hp.Name = "hp"
        Me.hp.ReadOnly = True
        Me.hp.Width = 75
        '
        'noid
        '
        Me.noid.DataPropertyName = "noid"
        Me.noid.HeaderText = "No ID"
        Me.noid.Name = "noid"
        Me.noid.ReadOnly = True
        '
        'status
        '
        Me.status.DataPropertyName = "newstatus"
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Width = 75
        '
        'tglmasuk
        '
        Me.tglmasuk.DataPropertyName = "tglmasuk"
        Me.tglmasuk.HeaderText = "Tanggal Masuk"
        Me.tglmasuk.Name = "tglmasuk"
        Me.tglmasuk.ReadOnly = True
        Me.tglmasuk.Width = 75
        '
        'TglLahir
        '
        Me.TglLahir.DataPropertyName = "tgllahir"
        Me.TglLahir.HeaderText = "Tanggal Lahir"
        Me.TglLahir.Name = "TglLahir"
        Me.TglLahir.ReadOnly = True
        Me.TglLahir.Width = 75
        '
        'TempatLahir
        '
        Me.TempatLahir.DataPropertyName = "TempatLahir"
        Me.TempatLahir.HeaderText = "Tempat Lahir"
        Me.TempatLahir.Name = "TempatLahir"
        Me.TempatLahir.ReadOnly = True
        Me.TempatLahir.Width = 50
        '
        'frmMastersopir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 390)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.dgvsopir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMastersopir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Master Karyawan :."
        CType(Me.dgvsopir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvsopir As System.Windows.Forms.DataGridView
    Friend WithEvents txtcaripanggil As System.Windows.Forms.TextBox
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents lblcaripanggil As System.Windows.Forms.Label
    Friend WithEvents lblnama As System.Windows.Forms.Label
    Friend WithEvents txtcarinama As System.Windows.Forms.TextBox
    Friend WithEvents lblcarialamat As System.Windows.Forms.Label
    Friend WithEvents txtcarialamat As System.Windows.Forms.TextBox
    Friend WithEvents lblkota As System.Windows.Forms.Label
    Friend WithEvents txtcarikota As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents kodesopir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rtrw As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kelurahan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kecamatan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents panggilan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namasopir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents alamat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents noid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tglmasuk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TglLahir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TempatLahir As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
