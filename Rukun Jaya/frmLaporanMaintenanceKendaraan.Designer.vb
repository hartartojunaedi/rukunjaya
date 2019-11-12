<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaporanMaintenanceKendaraan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbNopol = New System.Windows.Forms.ComboBox()
        Me.cbkTanggal = New System.Windows.Forms.CheckBox()
        Me.dtpTanggalAwal = New System.Windows.Forms.DateTimePicker()
        Me.dtpTanggalAkhir = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LihatLaporanBtn = New System.Windows.Forms.Button()
        Me.LaporanExcelButton = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.dgvLaporanMaintenanceKendaraan = New System.Windows.Forms.DataGridView()
        Me.kodemaintance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nolambung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kodejenismaintance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tukang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rutin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Biaya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.km = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namasopir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tindakan1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tindakan2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tindakan3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tindakan4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tindakan5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kerusakan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.dgvLaporanMaintenanceKendaraan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Polisi"
        '
        'cbNopol
        '
        Me.cbNopol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNopol.FormattingEnabled = True
        Me.cbNopol.Location = New System.Drawing.Point(211, 32)
        Me.cbNopol.Name = "cbNopol"
        Me.cbNopol.Size = New System.Drawing.Size(234, 21)
        Me.cbNopol.TabIndex = 1
        '
        'cbkTanggal
        '
        Me.cbkTanggal.AccessibleDescription = ""
        Me.cbkTanggal.AutoSize = True
        Me.cbkTanggal.Location = New System.Drawing.Point(38, 84)
        Me.cbkTanggal.Name = "cbkTanggal"
        Me.cbkTanggal.Size = New System.Drawing.Size(65, 17)
        Me.cbkTanggal.TabIndex = 2
        Me.cbkTanggal.Text = "Tanggal"
        Me.cbkTanggal.UseVisualStyleBackColor = True
        '
        'dtpTanggalAwal
        '
        Me.dtpTanggalAwal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTanggalAwal.Location = New System.Drawing.Point(102, 83)
        Me.dtpTanggalAwal.Name = "dtpTanggalAwal"
        Me.dtpTanggalAwal.Size = New System.Drawing.Size(181, 20)
        Me.dtpTanggalAwal.TabIndex = 3
        '
        'dtpTanggalAkhir
        '
        Me.dtpTanggalAkhir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTanggalAkhir.Location = New System.Drawing.Point(317, 83)
        Me.dtpTanggalAkhir.Name = "dtpTanggalAkhir"
        Me.dtpTanggalAkhir.Size = New System.Drawing.Size(181, 20)
        Me.dtpTanggalAkhir.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(290, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "s/d"
        '
        'LihatLaporanBtn
        '
        Me.LihatLaporanBtn.Location = New System.Drawing.Point(33, 123)
        Me.LihatLaporanBtn.Name = "LihatLaporanBtn"
        Me.LihatLaporanBtn.Size = New System.Drawing.Size(476, 45)
        Me.LihatLaporanBtn.TabIndex = 6
        Me.LihatLaporanBtn.Text = "Lihat Laporan"
        Me.LihatLaporanBtn.UseVisualStyleBackColor = True
        '
        'LaporanExcelButton
        '
        Me.LaporanExcelButton.Image = Global.RukunJaya.My.Resources.Resources.xls
        Me.LaporanExcelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LaporanExcelButton.Location = New System.Drawing.Point(233, 184)
        Me.LaporanExcelButton.Name = "LaporanExcelButton"
        Me.LaporanExcelButton.Size = New System.Drawing.Size(80, 29)
        Me.LaporanExcelButton.TabIndex = 37
        Me.LaporanExcelButton.Text = "&Excell"
        Me.LaporanExcelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LaporanExcelButton.UseVisualStyleBackColor = True
        '
        'dgvLaporanMaintenanceKendaraan
        '
        Me.dgvLaporanMaintenanceKendaraan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLaporanMaintenanceKendaraan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodemaintance, Me.nolambung, Me.kodejenismaintance, Me.tukang, Me.keterangan, Me.Rutin, Me.Biaya, Me.tgl, Me.km, Me.namasopir, Me.tindakan1, Me.tindakan2, Me.tindakan3, Me.tindakan4, Me.tindakan5, Me.kerusakan})
        Me.dgvLaporanMaintenanceKendaraan.Location = New System.Drawing.Point(504, 12)
        Me.dgvLaporanMaintenanceKendaraan.Name = "dgvLaporanMaintenanceKendaraan"
        Me.dgvLaporanMaintenanceKendaraan.Size = New System.Drawing.Size(488, 215)
        Me.dgvLaporanMaintenanceKendaraan.TabIndex = 38
        Me.dgvLaporanMaintenanceKendaraan.Visible = False
        '
        'kodemaintance
        '
        Me.kodemaintance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.kodemaintance.DataPropertyName = "kodemaintance"
        Me.kodemaintance.HeaderText = "Kode Maintenance"
        Me.kodemaintance.Name = "kodemaintance"
        Me.kodemaintance.Width = 112
        '
        'nolambung
        '
        Me.nolambung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.nolambung.DataPropertyName = "nolambung"
        Me.nolambung.HeaderText = "No Lambung"
        Me.nolambung.Name = "nolambung"
        Me.nolambung.Width = 86
        '
        'kodejenismaintance
        '
        Me.kodejenismaintance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.kodejenismaintance.DataPropertyName = "kodejenismaintance"
        Me.kodejenismaintance.HeaderText = "Kode Jenis Maintenance"
        Me.kodejenismaintance.Name = "kodejenismaintance"
        Me.kodejenismaintance.Width = 136
        '
        'tukang
        '
        Me.tukang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.tukang.DataPropertyName = "tukang"
        Me.tukang.HeaderText = "Tukang"
        Me.tukang.Name = "tukang"
        Me.tukang.Width = 69
        '
        'keterangan
        '
        Me.keterangan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.keterangan.DataPropertyName = "keterangan"
        Me.keterangan.HeaderText = "Keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Width = 87
        '
        'Rutin
        '
        Me.Rutin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Rutin.DataPropertyName = "rutin"
        Me.Rutin.HeaderText = "Rutin"
        Me.Rutin.Name = "Rutin"
        Me.Rutin.Width = 57
        '
        'Biaya
        '
        Me.Biaya.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Biaya.DataPropertyName = "biaya"
        Me.Biaya.HeaderText = "Biaya"
        Me.Biaya.Name = "Biaya"
        Me.Biaya.Width = 58
        '
        'tgl
        '
        Me.tgl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.tgl.DataPropertyName = "tgl"
        Me.tgl.HeaderText = "Tgl"
        Me.tgl.Name = "tgl"
        Me.tgl.Width = 47
        '
        'km
        '
        Me.km.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.km.DataPropertyName = "km"
        Me.km.HeaderText = "KM"
        Me.km.Name = "km"
        Me.km.Width = 48
        '
        'namasopir
        '
        Me.namasopir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.namasopir.DataPropertyName = "namasopir"
        Me.namasopir.HeaderText = "Nama Sopir"
        Me.namasopir.Name = "namasopir"
        Me.namasopir.Width = 80
        '
        'tindakan1
        '
        Me.tindakan1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.tindakan1.DataPropertyName = "tindakan1"
        Me.tindakan1.HeaderText = "Tindakan 1"
        Me.tindakan1.Name = "tindakan1"
        Me.tindakan1.Width = 79
        '
        'tindakan2
        '
        Me.tindakan2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.tindakan2.DataPropertyName = "tindakan2"
        Me.tindakan2.HeaderText = "Tindakan 2"
        Me.tindakan2.Name = "tindakan2"
        Me.tindakan2.Width = 79
        '
        'tindakan3
        '
        Me.tindakan3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.tindakan3.DataPropertyName = "tindakan3"
        Me.tindakan3.HeaderText = "Tindakan 3"
        Me.tindakan3.Name = "tindakan3"
        Me.tindakan3.Width = 79
        '
        'tindakan4
        '
        Me.tindakan4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.tindakan4.DataPropertyName = "tindakan4"
        Me.tindakan4.HeaderText = "Tindakan 4"
        Me.tindakan4.Name = "tindakan4"
        Me.tindakan4.Width = 79
        '
        'tindakan5
        '
        Me.tindakan5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.tindakan5.DataPropertyName = "tindakan5"
        Me.tindakan5.HeaderText = "Tindakan 5"
        Me.tindakan5.Name = "tindakan5"
        Me.tindakan5.Width = 79
        '
        'kerusakan
        '
        Me.kerusakan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.kerusakan.DataPropertyName = "kerusakan"
        Me.kerusakan.HeaderText = "Kerusakan"
        Me.kerusakan.Name = "kerusakan"
        Me.kerusakan.Width = 83
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(223, 219)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 39
        Me.TextBox1.Visible = False
        '
        'frmLaporanMaintenanceKendaraan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 221)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dgvLaporanMaintenanceKendaraan)
        Me.Controls.Add(Me.LaporanExcelButton)
        Me.Controls.Add(Me.LihatLaporanBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpTanggalAkhir)
        Me.Controls.Add(Me.dtpTanggalAwal)
        Me.Controls.Add(Me.cbkTanggal)
        Me.Controls.Add(Me.cbNopol)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLaporanMaintenanceKendaraan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Laporan Maintenance Kendaraan"
        CType(Me.dgvLaporanMaintenanceKendaraan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbNopol As System.Windows.Forms.ComboBox
    Friend WithEvents cbkTanggal As System.Windows.Forms.CheckBox
    Friend WithEvents dtpTanggalAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTanggalAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LihatLaporanBtn As System.Windows.Forms.Button
    Friend WithEvents LaporanExcelButton As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dgvLaporanMaintenanceKendaraan As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents kodemaintance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nolambung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kodejenismaintance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tukang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rutin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Biaya As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tgl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents km As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namasopir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tindakan1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tindakan2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tindakan3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tindakan4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tindakan5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kerusakan As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
