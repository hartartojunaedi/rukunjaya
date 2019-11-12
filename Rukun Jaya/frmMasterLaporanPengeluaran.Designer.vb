<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterLaporanPengeluaran
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
        Me.btnLihatLaporan = New System.Windows.Forms.Button()
        Me.cmbJenis = New System.Windows.Forms.ComboBox()
        Me.cmbKaryawan = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpToPeriode = New System.Windows.Forms.DateTimePicker()
        Me.dtpFromPeriode = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.dgvKasHarian = New System.Windows.Forms.DataGridView()
        Me.kodetransaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgltransaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvKasHarian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLihatLaporan
        '
        Me.btnLihatLaporan.Location = New System.Drawing.Point(9, 86)
        Me.btnLihatLaporan.Name = "btnLihatLaporan"
        Me.btnLihatLaporan.Size = New System.Drawing.Size(180, 43)
        Me.btnLihatLaporan.TabIndex = 5
        Me.btnLihatLaporan.Text = "&Lihat Laporan"
        Me.btnLihatLaporan.UseVisualStyleBackColor = True
        '
        'cmbJenis
        '
        Me.cmbJenis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbJenis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbJenis.FormattingEnabled = True
        Me.cmbJenis.Location = New System.Drawing.Point(88, 32)
        Me.cmbJenis.Name = "cmbJenis"
        Me.cmbJenis.Size = New System.Drawing.Size(192, 21)
        Me.cmbJenis.TabIndex = 3
        '
        'cmbKaryawan
        '
        Me.cmbKaryawan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbKaryawan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbKaryawan.FormattingEnabled = True
        Me.cmbKaryawan.Location = New System.Drawing.Point(88, 59)
        Me.cmbKaryawan.Name = "cmbKaryawan"
        Me.cmbKaryawan.Size = New System.Drawing.Size(192, 21)
        Me.cmbKaryawan.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Jenis :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Karyawan :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(179, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "-"
        '
        'dtpToPeriode
        '
        Me.dtpToPeriode.CustomFormat = "dd-MM-yyyy"
        Me.dtpToPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpToPeriode.Location = New System.Drawing.Point(195, 6)
        Me.dtpToPeriode.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtpToPeriode.Name = "dtpToPeriode"
        Me.dtpToPeriode.Size = New System.Drawing.Size(85, 20)
        Me.dtpToPeriode.TabIndex = 2
        '
        'dtpFromPeriode
        '
        Me.dtpFromPeriode.CustomFormat = "dd-MM-yyyy"
        Me.dtpFromPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFromPeriode.Location = New System.Drawing.Point(88, 6)
        Me.dtpFromPeriode.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtpFromPeriode.Name = "dtpFromPeriode"
        Me.dtpFromPeriode.Size = New System.Drawing.Size(85, 20)
        Me.dtpFromPeriode.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Periode :"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(114, 109)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(120, 20)
        Me.TextBox2.TabIndex = 40
        Me.TextBox2.Visible = False
        '
        'Button1
        '
        Me.Button1.Image = Global.RukunJaya.My.Resources.Resources.xls
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(200, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 43)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "&Excell"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "xls"
        Me.SaveFileDialog1.Filter = """Excell File|.xls|All Files|*.*"""
        '
        'dgvKasHarian
        '
        Me.dgvKasHarian.AllowUserToAddRows = False
        Me.dgvKasHarian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKasHarian.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodetransaksi, Me.tgltransaksi, Me.jenis, Me.kode, Me.harga, Me.keterangan})
        Me.dgvKasHarian.Location = New System.Drawing.Point(151, -9)
        Me.dgvKasHarian.Name = "dgvKasHarian"
        Me.dgvKasHarian.Size = New System.Drawing.Size(245, 215)
        Me.dgvKasHarian.TabIndex = 41
        Me.dgvKasHarian.Visible = False
        '
        'kodetransaksi
        '
        Me.kodetransaksi.DataPropertyName = "kodetransaksi"
        Me.kodetransaksi.HeaderText = "Column1"
        Me.kodetransaksi.Name = "kodetransaksi"
        '
        'tgltransaksi
        '
        Me.tgltransaksi.DataPropertyName = "tgltransaksi"
        Me.tgltransaksi.HeaderText = "Column1"
        Me.tgltransaksi.Name = "tgltransaksi"
        '
        'jenis
        '
        Me.jenis.DataPropertyName = "jenis"
        Me.jenis.HeaderText = "Column1"
        Me.jenis.Name = "jenis"
        '
        'kode
        '
        Me.kode.DataPropertyName = "kode"
        Me.kode.HeaderText = "Column1"
        Me.kode.Name = "kode"
        '
        'harga
        '
        Me.harga.DataPropertyName = "harga"
        Me.harga.HeaderText = "Column1"
        Me.harga.Name = "harga"
        '
        'keterangan
        '
        Me.keterangan.DataPropertyName = "keterangan"
        Me.keterangan.HeaderText = "Column1"
        Me.keterangan.Name = "keterangan"
        '
        'frmMasterLaporanPengeluaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 140)
        Me.Controls.Add(Me.dgvKasHarian)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLihatLaporan)
        Me.Controls.Add(Me.cmbJenis)
        Me.Controls.Add(Me.cmbKaryawan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpToPeriode)
        Me.Controls.Add(Me.dtpFromPeriode)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMasterLaporanPengeluaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Laporan Pengeluaran :."
        CType(Me.dgvKasHarian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLihatLaporan As System.Windows.Forms.Button
    Friend WithEvents cmbJenis As System.Windows.Forms.ComboBox
    Friend WithEvents cmbKaryawan As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpToPeriode As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFromPeriode As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dgvKasHarian As System.Windows.Forms.DataGridView
    Friend WithEvents kodetransaksi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tgltransaksi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
