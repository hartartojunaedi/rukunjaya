<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaporanMaintance
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
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.dtpTanggalAwal = New System.Windows.Forms.DateTimePicker()
        Me.dtpTanggalAkhir = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbRutin = New System.Windows.Forms.ComboBox()
        Me.cmbNamaPekerjaan = New System.Windows.Forms.ComboBox()
        Me.cmbnolambung = New System.Windows.Forms.ComboBox()
        Me.nmBiayaAwal = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nmBiayaAkhir = New System.Windows.Forms.NumericUpDown()
        Me.cbkTanggal = New System.Windows.Forms.CheckBox()
        Me.cbkNopol = New System.Windows.Forms.CheckBox()
        Me.cbkPekerjaan = New System.Windows.Forms.CheckBox()
        Me.cbkRutin = New System.Windows.Forms.CheckBox()
        Me.cbkBiaya = New System.Windows.Forms.CheckBox()
        Me.dgvLaporanMaintance = New System.Windows.Forms.DataGridView()
        Me.cbkTukang = New System.Windows.Forms.CheckBox()
        Me.txtTukang = New System.Windows.Forms.TextBox()
        CType(Me.nmBiayaAwal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmBiayaAkhir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLaporanMaintance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLaporan
        '
        Me.btnLaporan.Location = New System.Drawing.Point(20, 238)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(353, 43)
        Me.btnLaporan.TabIndex = 0
        Me.btnLaporan.Text = "Lihat Laporan"
        Me.btnLaporan.UseVisualStyleBackColor = True
        '
        'dtpTanggalAwal
        '
        Me.dtpTanggalAwal.CustomFormat = "dd-MM-yyyy"
        Me.dtpTanggalAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTanggalAwal.Location = New System.Drawing.Point(139, 22)
        Me.dtpTanggalAwal.Name = "dtpTanggalAwal"
        Me.dtpTanggalAwal.Size = New System.Drawing.Size(98, 20)
        Me.dtpTanggalAwal.TabIndex = 2
        '
        'dtpTanggalAkhir
        '
        Me.dtpTanggalAkhir.CustomFormat = "dd-MM-yyyy"
        Me.dtpTanggalAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTanggalAkhir.Location = New System.Drawing.Point(272, 21)
        Me.dtpTanggalAkhir.Name = "dtpTanggalAkhir"
        Me.dtpTanggalAkhir.Size = New System.Drawing.Size(101, 20)
        Me.dtpTanggalAkhir.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(243, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "s/d"
        '
        'cmbRutin
        '
        Me.cmbRutin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRutin.FormattingEnabled = True
        Me.cmbRutin.Items.AddRange(New Object() {"Rutin", "Tidak Rutin"})
        Me.cmbRutin.Location = New System.Drawing.Point(139, 169)
        Me.cmbRutin.Name = "cmbRutin"
        Me.cmbRutin.Size = New System.Drawing.Size(121, 21)
        Me.cmbRutin.TabIndex = 6
        '
        'cmbNamaPekerjaan
        '
        Me.cmbNamaPekerjaan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNamaPekerjaan.FormattingEnabled = True
        Me.cmbNamaPekerjaan.Items.AddRange(New Object() {"Rutin", "Tidak Rutin"})
        Me.cmbNamaPekerjaan.Location = New System.Drawing.Point(139, 132)
        Me.cmbNamaPekerjaan.Name = "cmbNamaPekerjaan"
        Me.cmbNamaPekerjaan.Size = New System.Drawing.Size(166, 21)
        Me.cmbNamaPekerjaan.TabIndex = 8
        '
        'cmbnolambung
        '
        Me.cmbnolambung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbnolambung.FormattingEnabled = True
        Me.cmbnolambung.Items.AddRange(New Object() {"Rutin", "Tidak Rutin"})
        Me.cmbnolambung.Location = New System.Drawing.Point(139, 58)
        Me.cmbnolambung.Name = "cmbnolambung"
        Me.cmbnolambung.Size = New System.Drawing.Size(144, 21)
        Me.cmbnolambung.TabIndex = 10
        '
        'nmBiayaAwal
        '
        Me.nmBiayaAwal.Location = New System.Drawing.Point(141, 204)
        Me.nmBiayaAwal.Maximum = New Decimal(New Integer() {-1530494977, 232830, 0, 0})
        Me.nmBiayaAwal.Name = "nmBiayaAwal"
        Me.nmBiayaAwal.Size = New System.Drawing.Size(100, 20)
        Me.nmBiayaAwal.TabIndex = 12
        Me.nmBiayaAwal.ThousandsSeparator = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(247, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "s/d"
        '
        'nmBiayaAkhir
        '
        Me.nmBiayaAkhir.Location = New System.Drawing.Point(273, 204)
        Me.nmBiayaAkhir.Maximum = New Decimal(New Integer() {-1530494977, 232830, 0, 0})
        Me.nmBiayaAkhir.Name = "nmBiayaAkhir"
        Me.nmBiayaAkhir.Size = New System.Drawing.Size(100, 20)
        Me.nmBiayaAkhir.TabIndex = 14
        Me.nmBiayaAkhir.ThousandsSeparator = True
        '
        'cbkTanggal
        '
        Me.cbkTanggal.AutoSize = True
        Me.cbkTanggal.Location = New System.Drawing.Point(21, 21)
        Me.cbkTanggal.Name = "cbkTanggal"
        Me.cbkTanggal.Size = New System.Drawing.Size(68, 17)
        Me.cbkTanggal.TabIndex = 15
        Me.cbkTanggal.Text = "Tanggal "
        Me.cbkTanggal.UseVisualStyleBackColor = True
        '
        'cbkNopol
        '
        Me.cbkNopol.AutoSize = True
        Me.cbkNopol.Location = New System.Drawing.Point(21, 58)
        Me.cbkNopol.Name = "cbkNopol"
        Me.cbkNopol.Size = New System.Drawing.Size(61, 17)
        Me.cbkNopol.TabIndex = 16
        Me.cbkNopol.Text = "No Pol "
        Me.cbkNopol.UseVisualStyleBackColor = True
        '
        'cbkPekerjaan
        '
        Me.cbkPekerjaan.AutoSize = True
        Me.cbkPekerjaan.Location = New System.Drawing.Point(21, 134)
        Me.cbkPekerjaan.Name = "cbkPekerjaan"
        Me.cbkPekerjaan.Size = New System.Drawing.Size(114, 17)
        Me.cbkPekerjaan.TabIndex = 17
        Me.cbkPekerjaan.Text = "Nama Pekerjaan : "
        Me.cbkPekerjaan.UseVisualStyleBackColor = True
        '
        'cbkRutin
        '
        Me.cbkRutin.AutoSize = True
        Me.cbkRutin.Location = New System.Drawing.Point(22, 173)
        Me.cbkRutin.Name = "cbkRutin"
        Me.cbkRutin.Size = New System.Drawing.Size(60, 17)
        Me.cbkRutin.TabIndex = 18
        Me.cbkRutin.Text = "Rutin : "
        Me.cbkRutin.UseVisualStyleBackColor = True
        '
        'cbkBiaya
        '
        Me.cbkBiaya.AutoSize = True
        Me.cbkBiaya.Location = New System.Drawing.Point(21, 204)
        Me.cbkBiaya.Name = "cbkBiaya"
        Me.cbkBiaya.Size = New System.Drawing.Size(61, 17)
        Me.cbkBiaya.TabIndex = 19
        Me.cbkBiaya.Text = "Biaya : "
        Me.cbkBiaya.UseVisualStyleBackColor = True
        '
        'dgvLaporanMaintance
        '
        Me.dgvLaporanMaintance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLaporanMaintance.Location = New System.Drawing.Point(12, 293)
        Me.dgvLaporanMaintance.Name = "dgvLaporanMaintance"
        Me.dgvLaporanMaintance.Size = New System.Drawing.Size(557, 103)
        Me.dgvLaporanMaintance.TabIndex = 20
        Me.dgvLaporanMaintance.Visible = False
        '
        'cbkTukang
        '
        Me.cbkTukang.AutoSize = True
        Me.cbkTukang.Location = New System.Drawing.Point(21, 97)
        Me.cbkTukang.Name = "cbkTukang"
        Me.cbkTukang.Size = New System.Drawing.Size(97, 17)
        Me.cbkTukang.TabIndex = 21
        Me.cbkTukang.Text = "Nama Tukang "
        Me.cbkTukang.UseVisualStyleBackColor = True
        '
        'txtTukang
        '
        Me.txtTukang.Location = New System.Drawing.Point(141, 97)
        Me.txtTukang.Name = "txtTukang"
        Me.txtTukang.Size = New System.Drawing.Size(210, 20)
        Me.txtTukang.TabIndex = 22
        '
        'frmLaporanMaintance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 293)
        Me.Controls.Add(Me.txtTukang)
        Me.Controls.Add(Me.cbkTukang)
        Me.Controls.Add(Me.dgvLaporanMaintance)
        Me.Controls.Add(Me.cbkBiaya)
        Me.Controls.Add(Me.cbkRutin)
        Me.Controls.Add(Me.cbkPekerjaan)
        Me.Controls.Add(Me.cbkNopol)
        Me.Controls.Add(Me.cbkTanggal)
        Me.Controls.Add(Me.nmBiayaAkhir)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.nmBiayaAwal)
        Me.Controls.Add(Me.cmbnolambung)
        Me.Controls.Add(Me.cmbNamaPekerjaan)
        Me.Controls.Add(Me.cmbRutin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpTanggalAkhir)
        Me.Controls.Add(Me.dtpTanggalAwal)
        Me.Controls.Add(Me.btnLaporan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLaporanMaintance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Laporan Maintenance :."
        CType(Me.nmBiayaAwal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmBiayaAkhir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLaporanMaintance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLaporan As System.Windows.Forms.Button
    Friend WithEvents dtpTanggalAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTanggalAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbRutin As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNamaPekerjaan As System.Windows.Forms.ComboBox
    Friend WithEvents cmbnolambung As System.Windows.Forms.ComboBox
    Friend WithEvents nmBiayaAwal As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nmBiayaAkhir As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbkTanggal As System.Windows.Forms.CheckBox
    Friend WithEvents cbkNopol As System.Windows.Forms.CheckBox
    Friend WithEvents cbkPekerjaan As System.Windows.Forms.CheckBox
    Friend WithEvents cbkRutin As System.Windows.Forms.CheckBox
    Friend WithEvents cbkBiaya As System.Windows.Forms.CheckBox
    Friend WithEvents dgvLaporanMaintance As System.Windows.Forms.DataGridView
    Friend WithEvents cbkTukang As System.Windows.Forms.CheckBox
    Friend WithEvents txtTukang As System.Windows.Forms.TextBox
End Class
