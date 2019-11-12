<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInputBM
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
        Me.dgvKendaraan = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblJumData = New System.Windows.Forms.Label()
        Me.txtnobm = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnfilter = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtptanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblnolambung = New System.Windows.Forms.Label()
        Me.lblnamasopir = New System.Windows.Forms.Label()
        Me.lblketerangan = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblmerek = New System.Windows.Forms.Label()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbltotalmuatan = New System.Windows.Forms.Label()
        Me.nosuratjalan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namasup1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namaperwakilan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.asal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tujuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Detail = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Hapus = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvKendaraan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvKendaraan
        '
        Me.dgvKendaraan.AllowUserToAddRows = False
        Me.dgvKendaraan.AllowUserToOrderColumns = True
        Me.dgvKendaraan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKendaraan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nosuratjalan, Me.namasup1, Me.namaperwakilan, Me.asal, Me.tujuan, Me.Keterangan, Me.Detail, Me.Hapus})
        Me.dgvKendaraan.Location = New System.Drawing.Point(12, 171)
        Me.dgvKendaraan.Name = "dgvKendaraan"
        Me.dgvKendaraan.ReadOnly = True
        Me.dgvKendaraan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvKendaraan.Size = New System.Drawing.Size(699, 175)
        Me.dgvKendaraan.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(482, 361)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Jumlah data :"
        '
        'lblJumData
        '
        Me.lblJumData.AutoSize = True
        Me.lblJumData.Location = New System.Drawing.Point(559, 361)
        Me.lblJumData.Name = "lblJumData"
        Me.lblJumData.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblJumData.Size = New System.Drawing.Size(13, 13)
        Me.lblJumData.TabIndex = 11
        Me.lblJumData.Text = "0"
        Me.lblJumData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtnobm
        '
        Me.txtnobm.Location = New System.Drawing.Point(143, 14)
        Me.txtnobm.MaxLength = 10
        Me.txtnobm.Name = "txtnobm"
        Me.txtnobm.Size = New System.Drawing.Size(127, 20)
        Me.txtnobm.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "No BM : "
        '
        'btnfilter
        '
        Me.btnfilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnfilter.Location = New System.Drawing.Point(276, 14)
        Me.btnfilter.Name = "btnfilter"
        Me.btnfilter.Size = New System.Drawing.Size(28, 20)
        Me.btnfilter.TabIndex = 2
        Me.btnfilter.Text = "..."
        Me.btnfilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnfilter.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Keterangan : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Nama Sopir : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "No Lambung / Nopol : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dtptanggal
        '
        Me.dtptanggal.CustomFormat = "dd-MM-yyyy"
        Me.dtptanggal.Enabled = False
        Me.dtptanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptanggal.Location = New System.Drawing.Point(428, 69)
        Me.dtptanggal.Name = "dtptanggal"
        Me.dtptanggal.Size = New System.Drawing.Size(102, 20)
        Me.dtptanggal.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(364, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Tanggal : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblnolambung
        '
        Me.lblnolambung.AutoSize = True
        Me.lblnolambung.Location = New System.Drawing.Point(140, 50)
        Me.lblnolambung.Name = "lblnolambung"
        Me.lblnolambung.Size = New System.Drawing.Size(39, 13)
        Me.lblnolambung.TabIndex = 48
        Me.lblnolambung.Text = "Label7"
        '
        'lblnamasopir
        '
        Me.lblnamasopir.AutoSize = True
        Me.lblnamasopir.Location = New System.Drawing.Point(140, 76)
        Me.lblnamasopir.Name = "lblnamasopir"
        Me.lblnamasopir.Size = New System.Drawing.Size(39, 13)
        Me.lblnamasopir.TabIndex = 49
        Me.lblnamasopir.Text = "Label8"
        '
        'lblketerangan
        '
        Me.lblketerangan.AutoSize = True
        Me.lblketerangan.Location = New System.Drawing.Point(140, 102)
        Me.lblketerangan.Name = "lblketerangan"
        Me.lblketerangan.Size = New System.Drawing.Size(39, 13)
        Me.lblketerangan.TabIndex = 50
        Me.lblketerangan.Text = "Label9"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 24)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Daftar Surat Jalan :"
        '
        'btnTambah
        '
        Me.btnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.btnTambah.Location = New System.Drawing.Point(12, 361)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(80, 29)
        Me.btnTambah.TabIndex = 4
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(373, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Merek : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblmerek
        '
        Me.lblmerek.AutoSize = True
        Me.lblmerek.Location = New System.Drawing.Point(425, 50)
        Me.lblmerek.Name = "lblmerek"
        Me.lblmerek.Size = New System.Drawing.Size(39, 13)
        Me.lblmerek.TabIndex = 53
        Me.lblmerek.Text = "Label9"
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Location = New System.Drawing.Point(429, 102)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(0, 13)
        Me.lblstatus.TabIndex = 55
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(373, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Status : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(287, 361)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Total Muatan"
        '
        'lbltotalmuatan
        '
        Me.lbltotalmuatan.Location = New System.Drawing.Point(367, 361)
        Me.lbltotalmuatan.Name = "lbltotalmuatan"
        Me.lbltotalmuatan.Size = New System.Drawing.Size(97, 13)
        Me.lbltotalmuatan.TabIndex = 57
        Me.lbltotalmuatan.Text = "0"
        Me.lbltotalmuatan.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'nosuratjalan
        '
        Me.nosuratjalan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.nosuratjalan.DataPropertyName = "nosuratjalan"
        Me.nosuratjalan.Frozen = True
        Me.nosuratjalan.HeaderText = "No SJ"
        Me.nosuratjalan.Name = "nosuratjalan"
        Me.nosuratjalan.ReadOnly = True
        Me.nosuratjalan.Width = 61
        '
        'namasup1
        '
        Me.namasup1.DataPropertyName = "namasupplier"
        Me.namasup1.Frozen = True
        Me.namasup1.HeaderText = "Supplier"
        Me.namasup1.Name = "namasup1"
        Me.namasup1.ReadOnly = True
        '
        'namaperwakilan
        '
        Me.namaperwakilan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.namaperwakilan.DataPropertyName = "namaperwakilan"
        Me.namaperwakilan.Frozen = True
        Me.namaperwakilan.HeaderText = "Perwakilan"
        Me.namaperwakilan.Name = "namaperwakilan"
        Me.namaperwakilan.ReadOnly = True
        Me.namaperwakilan.ToolTipText = "Perwakilan"
        Me.namaperwakilan.Width = 84
        '
        'asal
        '
        Me.asal.DataPropertyName = "asal"
        Me.asal.Frozen = True
        Me.asal.HeaderText = "Asal"
        Me.asal.Name = "asal"
        Me.asal.ReadOnly = True
        Me.asal.ToolTipText = "Asal"
        Me.asal.Width = 52
        '
        'tujuan
        '
        Me.tujuan.DataPropertyName = "tujuan"
        Me.tujuan.Frozen = True
        Me.tujuan.HeaderText = "Tujuan"
        Me.tujuan.Name = "tujuan"
        Me.tujuan.ReadOnly = True
        Me.tujuan.ToolTipText = "Tujuan"
        Me.tujuan.Width = 65
        '
        'Keterangan
        '
        Me.Keterangan.DataPropertyName = "keterangan"
        Me.Keterangan.Frozen = True
        Me.Keterangan.HeaderText = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.ReadOnly = True
        '
        'Detail
        '
        Me.Detail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = "Ubah"
        Me.Detail.DefaultCellStyle = DataGridViewCellStyle1
        Me.Detail.HeaderText = "Detail Data"
        Me.Detail.Name = "Detail"
        Me.Detail.ReadOnly = True
        Me.Detail.Text = "Detail Data"
        Me.Detail.ToolTipText = "Detail Data"
        Me.Detail.UseColumnTextForButtonValue = True
        Me.Detail.Width = 66
        '
        'Hapus
        '
        Me.Hapus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = "Hapus"
        Me.Hapus.DefaultCellStyle = DataGridViewCellStyle2
        Me.Hapus.HeaderText = "Hapus Data"
        Me.Hapus.Name = "Hapus"
        Me.Hapus.ReadOnly = True
        Me.Hapus.Text = "Hapus"
        Me.Hapus.ToolTipText = "Hapus Data"
        Me.Hapus.UseColumnTextForButtonValue = True
        Me.Hapus.Width = 70
        '
        'frmInputBM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 412)
        Me.Controls.Add(Me.lbltotalmuatan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblstatus)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblmerek)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblketerangan)
        Me.Controls.Add(Me.lblnamasopir)
        Me.Controls.Add(Me.lblnolambung)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtptanggal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnfilter)
        Me.Controls.Add(Me.txtnobm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblJumData)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.dgvKendaraan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInputBM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Surat Jalan :."
        CType(Me.dgvKendaraan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents txtnobm As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnfilter As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtptanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblnolambung As System.Windows.Forms.Label
    Friend WithEvents lblnamasopir As System.Windows.Forms.Label
    Friend WithEvents lblketerangan As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblmerek As System.Windows.Forms.Label
    Friend WithEvents lblstatus As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbltotalmuatan As System.Windows.Forms.Label
    Friend WithEvents nosuratjalan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namasup1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namaperwakilan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents asal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tujuan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Detail As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Hapus As System.Windows.Forms.DataGridViewButtonColumn
End Class
