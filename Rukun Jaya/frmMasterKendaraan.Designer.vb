<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterKendaraan
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
        Me.txtnopol = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvKendaraan = New System.Windows.Forms.DataGridView()
        Me.nolambung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nopol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.merek = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomesin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pemilik = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kodeperusahaan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tahun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namajenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.norangka = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nobpkb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ubah = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Hapus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblJumData = New System.Windows.Forms.Label()
        Me.txtnomesin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnfilter = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvKendaraan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnopol
        '
        Me.txtnopol.Location = New System.Drawing.Point(441, 40)
        Me.txtnopol.Name = "txtnopol"
        Me.txtnopol.Size = New System.Drawing.Size(173, 20)
        Me.txtnopol.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(358, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cari No Polisi :"
        '
        'dgvKendaraan
        '
        Me.dgvKendaraan.AllowUserToAddRows = False
        Me.dgvKendaraan.AllowUserToOrderColumns = True
        Me.dgvKendaraan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKendaraan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nolambung, Me.nopol, Me.merek, Me.nomesin, Me.pemilik, Me.kodeperusahaan, Me.tahun, Me.namajenis, Me.norangka, Me.nobpkb, Me.Ubah, Me.Hapus})
        Me.dgvKendaraan.Location = New System.Drawing.Point(12, 69)
        Me.dgvKendaraan.Name = "dgvKendaraan"
        Me.dgvKendaraan.ReadOnly = True
        Me.dgvKendaraan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvKendaraan.Size = New System.Drawing.Size(701, 303)
        Me.dgvKendaraan.TabIndex = 6
        '
        'nolambung
        '
        Me.nolambung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.nolambung.DataPropertyName = "nolambung"
        Me.nolambung.Frozen = True
        Me.nolambung.HeaderText = "No Lambung"
        Me.nolambung.Name = "nolambung"
        Me.nolambung.ReadOnly = True
        Me.nolambung.Width = 93
        '
        'nopol
        '
        Me.nopol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.nopol.DataPropertyName = "nopol"
        Me.nopol.Frozen = True
        Me.nopol.HeaderText = "No Polisi"
        Me.nopol.Name = "nopol"
        Me.nopol.ReadOnly = True
        Me.nopol.ToolTipText = "No Polisi"
        Me.nopol.Width = 73
        '
        'merek
        '
        Me.merek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.merek.DataPropertyName = "merek"
        Me.merek.HeaderText = "Merek"
        Me.merek.Name = "merek"
        Me.merek.ReadOnly = True
        Me.merek.ToolTipText = "Merek"
        Me.merek.Width = 62
        '
        'nomesin
        '
        Me.nomesin.DataPropertyName = "nomesin"
        Me.nomesin.HeaderText = "No Mesin"
        Me.nomesin.Name = "nomesin"
        Me.nomesin.ReadOnly = True
        Me.nomesin.ToolTipText = "No Mesin"
        '
        'pemilik
        '
        Me.pemilik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.pemilik.DataPropertyName = "pemilik"
        Me.pemilik.HeaderText = "Pemilik"
        Me.pemilik.Name = "pemilik"
        Me.pemilik.ReadOnly = True
        Me.pemilik.ToolTipText = "Pemilik"
        Me.pemilik.Width = 65
        '
        'kodeperusahaan
        '
        Me.kodeperusahaan.DataPropertyName = "kodeperusahaan"
        Me.kodeperusahaan.HeaderText = "Kode Perusahaan"
        Me.kodeperusahaan.Name = "kodeperusahaan"
        Me.kodeperusahaan.ReadOnly = True
        Me.kodeperusahaan.Visible = False
        '
        'tahun
        '
        Me.tahun.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.tahun.DataPropertyName = "tahun"
        Me.tahun.HeaderText = "Tahun"
        Me.tahun.MinimumWidth = 4
        Me.tahun.Name = "tahun"
        Me.tahun.ReadOnly = True
        Me.tahun.Width = 63
        '
        'namajenis
        '
        Me.namajenis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.namajenis.DataPropertyName = "namajenis"
        Me.namajenis.HeaderText = "Jenis"
        Me.namajenis.Name = "namajenis"
        Me.namajenis.ReadOnly = True
        Me.namajenis.Width = 56
        '
        'norangka
        '
        Me.norangka.DataPropertyName = "norangka"
        Me.norangka.HeaderText = "No Rangka"
        Me.norangka.Name = "norangka"
        Me.norangka.ReadOnly = True
        Me.norangka.Visible = False
        '
        'nobpkb
        '
        Me.nobpkb.DataPropertyName = "nobpkb"
        Me.nobpkb.HeaderText = "No BPKB"
        Me.nobpkb.Name = "nobpkb"
        Me.nobpkb.ReadOnly = True
        Me.nobpkb.Visible = False
        '
        'Ubah
        '
        Me.Ubah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = "Ubah"
        Me.Ubah.DefaultCellStyle = DataGridViewCellStyle1
        Me.Ubah.HeaderText = "Ubah"
        Me.Ubah.Name = "Ubah"
        Me.Ubah.ReadOnly = True
        Me.Ubah.Text = "Ubah"
        Me.Ubah.ToolTipText = "Ubah Data"
        Me.Ubah.UseColumnTextForButtonValue = True
        Me.Ubah.Width = 45
        '
        'Hapus
        '
        Me.Hapus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = "Hapus"
        Me.Hapus.DefaultCellStyle = DataGridViewCellStyle2
        Me.Hapus.HeaderText = "Hapus"
        Me.Hapus.Name = "Hapus"
        Me.Hapus.ReadOnly = True
        Me.Hapus.Text = "Hapus"
        Me.Hapus.ToolTipText = "Hapus Data"
        Me.Hapus.UseColumnTextForButtonValue = True
        Me.Hapus.Width = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(613, 403)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Jumlah data :"
        '
        'lblJumData
        '
        Me.lblJumData.AutoSize = True
        Me.lblJumData.Location = New System.Drawing.Point(677, 403)
        Me.lblJumData.Name = "lblJumData"
        Me.lblJumData.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblJumData.Size = New System.Drawing.Size(39, 13)
        Me.lblJumData.TabIndex = 11
        Me.lblJumData.Text = "Label4"
        Me.lblJumData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtnomesin
        '
        Me.txtnomesin.Location = New System.Drawing.Point(441, 14)
        Me.txtnomesin.Name = "txtnomesin"
        Me.txtnomesin.Size = New System.Drawing.Size(173, 20)
        Me.txtnomesin.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(354, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Cari No Mesin :"
        '
        'btnfilter
        '
        Me.btnfilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnfilter.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnfilter.Location = New System.Drawing.Point(631, 12)
        Me.btnfilter.Name = "btnfilter"
        Me.btnfilter.Size = New System.Drawing.Size(80, 29)
        Me.btnfilter.TabIndex = 14
        Me.btnfilter.Text = "&Filter"
        Me.btnfilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnfilter.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.btnTambah.Location = New System.Drawing.Point(12, 395)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(80, 29)
        Me.btnTambah.TabIndex = 7
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "xls"
        Me.SaveFileDialog1.Filter = """Excell File|.xls|All Files|*.*"""
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(185, 395)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 16
        Me.TextBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.Image = Global.RukunJaya.My.Resources.Resources.xls
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(98, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 29)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "&Excell"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMasterKendaraan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 442)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnfilter)
        Me.Controls.Add(Me.txtnomesin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblJumData)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.dgvKendaraan)
        Me.Controls.Add(Me.txtnopol)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMasterKendaraan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Master Kendaraan :."
        CType(Me.dgvKendaraan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnopol As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvKendaraan As System.Windows.Forms.DataGridView
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblJumData As System.Windows.Forms.Label
    'Friend WithEvents DataSet1 As RukunJaya.DataSet1
    'Friend WithEvents KendaraanTableAdapter As RukunJaya.DataSet1TableAdapters.kendaraanTableAdapter
    Friend WithEvents NolambungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NopolDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PemilikDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodeperusahaanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MerekDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TahunDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NorangkaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomesinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoBPKBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JatuhtempoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JenisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreatedateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UpdatedateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtnomesin As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnfilter As System.Windows.Forms.Button
    Friend WithEvents nolambung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nopol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents merek As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomesin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pemilik As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kodeperusahaan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tahun As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namajenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents norangka As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nobpkb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ubah As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Hapus As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
