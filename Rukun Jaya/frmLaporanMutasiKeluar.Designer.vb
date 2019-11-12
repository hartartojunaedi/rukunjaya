<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaporanMutasiKeluar
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
        Me.dtpAKhirPeriode = New System.Windows.Forms.DateTimePicker()
        Me.dtpAwalPeriode = New System.Windows.Forms.DateTimePicker()
        Me.btnLihatLaporan = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvMutasiKeluar = New System.Windows.Forms.DataGridView()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Tgl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nopol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoSPk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaSparepart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Noseri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaKaryawan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvMutasiKeluar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Periode "
        '
        'dtpAKhirPeriode
        '
        Me.dtpAKhirPeriode.CustomFormat = "dd-MM-yyyy"
        Me.dtpAKhirPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAKhirPeriode.Location = New System.Drawing.Point(177, 15)
        Me.dtpAKhirPeriode.Name = "dtpAKhirPeriode"
        Me.dtpAKhirPeriode.Size = New System.Drawing.Size(93, 20)
        Me.dtpAKhirPeriode.TabIndex = 13
        '
        'dtpAwalPeriode
        '
        Me.dtpAwalPeriode.CustomFormat = "dd-MM-yyyy"
        Me.dtpAwalPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAwalPeriode.Location = New System.Drawing.Point(63, 15)
        Me.dtpAwalPeriode.Name = "dtpAwalPeriode"
        Me.dtpAwalPeriode.Size = New System.Drawing.Size(92, 20)
        Me.dtpAwalPeriode.TabIndex = 12
        '
        'btnLihatLaporan
        '
        Me.btnLihatLaporan.Location = New System.Drawing.Point(12, 41)
        Me.btnLihatLaporan.Name = "btnLihatLaporan"
        Me.btnLihatLaporan.Size = New System.Drawing.Size(176, 44)
        Me.btnLihatLaporan.TabIndex = 11
        Me.btnLihatLaporan.Text = "Lihat Laporan"
        Me.btnLihatLaporan.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(122, 65)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(120, 20)
        Me.TextBox2.TabIndex = 40
        Me.TextBox2.Visible = False
        '
        'Button1
        '
        Me.Button1.Image = Global.RukunJaya.My.Resources.Resources.xls
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(194, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 44)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "&Excell"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvMutasiKeluar
        '
        Me.dgvMutasiKeluar.AllowUserToAddRows = False
        Me.dgvMutasiKeluar.AllowUserToDeleteRows = False
        Me.dgvMutasiKeluar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMutasiKeluar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tgl, Me.nopol, Me.id, Me.NoSPk, Me.NamaSparepart, Me.Jumlah, Me.Noseri, Me.NamaKaryawan})
        Me.dgvMutasiKeluar.Location = New System.Drawing.Point(269, 59)
        Me.dgvMutasiKeluar.Name = "dgvMutasiKeluar"
        Me.dgvMutasiKeluar.ReadOnly = True
        Me.dgvMutasiKeluar.Size = New System.Drawing.Size(498, 150)
        Me.dgvMutasiKeluar.TabIndex = 41
        Me.dgvMutasiKeluar.Visible = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "xls"
        Me.SaveFileDialog1.Filter = """Excell File|.xls|All Files|*.*"""
        '
        'Tgl
        '
        Me.Tgl.DataPropertyName = "tgl"
        Me.Tgl.HeaderText = "Tanggal"
        Me.Tgl.Name = "Tgl"
        Me.Tgl.ReadOnly = True
        '
        'nopol
        '
        Me.nopol.DataPropertyName = "nopol"
        Me.nopol.HeaderText = "nopol"
        Me.nopol.Name = "nopol"
        Me.nopol.ReadOnly = True
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'NoSPk
        '
        Me.NoSPk.DataPropertyName = "nospk"
        Me.NoSPk.HeaderText = "NoSPK"
        Me.NoSPk.Name = "NoSPk"
        Me.NoSPk.ReadOnly = True
        '
        'NamaSparepart
        '
        Me.NamaSparepart.DataPropertyName = "Namasparepart"
        Me.NamaSparepart.HeaderText = "NamaSparepart"
        Me.NamaSparepart.Name = "NamaSparepart"
        Me.NamaSparepart.ReadOnly = True
        '
        'Jumlah
        '
        Me.Jumlah.DataPropertyName = "Jumlah"
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.ReadOnly = True
        '
        'Noseri
        '
        Me.Noseri.DataPropertyName = "Noseri"
        Me.Noseri.HeaderText = "NoSeri"
        Me.Noseri.Name = "Noseri"
        Me.Noseri.ReadOnly = True
        '
        'NamaKaryawan
        '
        Me.NamaKaryawan.DataPropertyName = "NamaKaryawan"
        Me.NamaKaryawan.HeaderText = "NamaKaryawan"
        Me.NamaKaryawan.Name = "NamaKaryawan"
        Me.NamaKaryawan.ReadOnly = True
        '
        'frmLaporanMutasiKeluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 91)
        Me.Controls.Add(Me.dgvMutasiKeluar)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpAKhirPeriode)
        Me.Controls.Add(Me.dtpAwalPeriode)
        Me.Controls.Add(Me.btnLihatLaporan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLaporanMutasiKeluar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Laporan Mutasi Keluar :."
        CType(Me.dgvMutasiKeluar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpAKhirPeriode As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpAwalPeriode As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnLihatLaporan As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgvMutasiKeluar As System.Windows.Forms.DataGridView
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Tgl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nopol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoSPk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaSparepart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Noseri As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaKaryawan As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
