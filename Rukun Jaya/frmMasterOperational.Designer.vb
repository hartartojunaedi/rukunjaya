<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterOperational
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
        Me.cmbCariJenisOp = New System.Windows.Forms.ComboBox()
        Me.btnSeacrhOperational = New System.Windows.Forms.Button()
        Me.dgvMasterOperational = New System.Windows.Forms.DataGridView()
        Me.KodeJenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaJenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UbahData = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.HapusData = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblJumlahDataOperational = New System.Windows.Forms.Label()
        Me.btnTambahOperational = New System.Windows.Forms.Button()
        Me.txtCariNamaOp = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvMasterOperational, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbCariJenisOp
        '
        Me.cmbCariJenisOp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCariJenisOp.FormattingEnabled = True
        Me.cmbCariJenisOp.Items.AddRange(New Object() {"Biaya Lain", "Kas Bon", "[SEMUA]"})
        Me.cmbCariJenisOp.Location = New System.Drawing.Point(492, 15)
        Me.cmbCariJenisOp.Name = "cmbCariJenisOp"
        Me.cmbCariJenisOp.Size = New System.Drawing.Size(161, 21)
        Me.cmbCariJenisOp.TabIndex = 2
        '
        'btnSeacrhOperational
        '
        Me.btnSeacrhOperational.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnSeacrhOperational.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeacrhOperational.Location = New System.Drawing.Point(675, 12)
        Me.btnSeacrhOperational.Name = "btnSeacrhOperational"
        Me.btnSeacrhOperational.Size = New System.Drawing.Size(80, 29)
        Me.btnSeacrhOperational.TabIndex = 4
        Me.btnSeacrhOperational.Text = "&Filter"
        Me.btnSeacrhOperational.UseVisualStyleBackColor = True
        '
        'dgvMasterOperational
        '
        Me.dgvMasterOperational.AllowUserToAddRows = False
        Me.dgvMasterOperational.AllowUserToDeleteRows = False
        Me.dgvMasterOperational.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMasterOperational.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeJenis, Me.NamaJenis, Me.Jenis, Me.Keterangan, Me.UbahData, Me.HapusData})
        Me.dgvMasterOperational.Location = New System.Drawing.Point(20, 83)
        Me.dgvMasterOperational.Name = "dgvMasterOperational"
        Me.dgvMasterOperational.ReadOnly = True
        Me.dgvMasterOperational.Size = New System.Drawing.Size(730, 209)
        Me.dgvMasterOperational.TabIndex = 5
        '
        'KodeJenis
        '
        Me.KodeJenis.DataPropertyName = "kodejenis"
        Me.KodeJenis.HeaderText = "Kode Jenis"
        Me.KodeJenis.Name = "KodeJenis"
        Me.KodeJenis.ReadOnly = True
        Me.KodeJenis.Width = 87
        '
        'NamaJenis
        '
        Me.NamaJenis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NamaJenis.DataPropertyName = "namajenis"
        Me.NamaJenis.HeaderText = "Nama Jenis"
        Me.NamaJenis.Name = "NamaJenis"
        Me.NamaJenis.ReadOnly = True
        '
        'Jenis
        '
        Me.Jenis.DataPropertyName = "jenis"
        Me.Jenis.HeaderText = "Jenis"
        Me.Jenis.Name = "Jenis"
        Me.Jenis.ReadOnly = True
        Me.Jenis.Width = 75
        '
        'Keterangan
        '
        Me.Keterangan.DataPropertyName = "keterangan"
        Me.Keterangan.HeaderText = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.ReadOnly = True
        Me.Keterangan.Width = 200
        '
        'UbahData
        '
        Me.UbahData.HeaderText = "Ubah"
        Me.UbahData.Name = "UbahData"
        Me.UbahData.ReadOnly = True
        Me.UbahData.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UbahData.Text = "Ubah"
        Me.UbahData.UseColumnTextForButtonValue = True
        Me.UbahData.Width = 45
        '
        'HapusData
        '
        Me.HapusData.HeaderText = "Hapus"
        Me.HapusData.Name = "HapusData"
        Me.HapusData.ReadOnly = True
        Me.HapusData.Text = "Hapus"
        Me.HapusData.UseColumnTextForButtonValue = True
        Me.HapusData.Width = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(608, 318)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Jumlah Data:"
        '
        'lblJumlahDataOperational
        '
        Me.lblJumlahDataOperational.AutoSize = True
        Me.lblJumlahDataOperational.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJumlahDataOperational.Location = New System.Drawing.Point(710, 318)
        Me.lblJumlahDataOperational.Name = "lblJumlahDataOperational"
        Me.lblJumlahDataOperational.Size = New System.Drawing.Size(14, 13)
        Me.lblJumlahDataOperational.TabIndex = 7
        Me.lblJumlahDataOperational.Text = "0"
        '
        'btnTambahOperational
        '
        Me.btnTambahOperational.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.btnTambahOperational.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambahOperational.Location = New System.Drawing.Point(20, 310)
        Me.btnTambahOperational.Name = "btnTambahOperational"
        Me.btnTambahOperational.Size = New System.Drawing.Size(80, 29)
        Me.btnTambahOperational.TabIndex = 8
        Me.btnTambahOperational.Text = "&Tambah"
        Me.btnTambahOperational.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambahOperational.UseVisualStyleBackColor = True
        '
        'txtCariNamaOp
        '
        Me.txtCariNamaOp.Location = New System.Drawing.Point(492, 42)
        Me.txtCariNamaOp.MaxLength = 100
        Me.txtCariNamaOp.Name = "txtCariNamaOp"
        Me.txtCariNamaOp.Size = New System.Drawing.Size(161, 20)
        Me.txtCariNamaOp.TabIndex = 3
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(41, 20)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Nama Jenis :"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(365, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Cari Berdasarkan Jenis :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(334, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Cari Berdasarkan Nama Jenis :"
        '
        'frmMasterOperational
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 365)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTambahOperational)
        Me.Controls.Add(Me.lblJumlahDataOperational)
        Me.Controls.Add(Me.btnSeacrhOperational)
        Me.Controls.Add(Me.txtCariNamaOp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbCariJenisOp)
        Me.Controls.Add(Me.dgvMasterOperational)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMasterOperational"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Master Operasional :."
        CType(Me.dgvMasterOperational, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbCariJenisOp As System.Windows.Forms.ComboBox
    Friend WithEvents btnSeacrhOperational As System.Windows.Forms.Button
    Friend WithEvents dgvMasterOperational As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblJumlahDataOperational As System.Windows.Forms.Label
    Friend WithEvents btnTambahOperational As System.Windows.Forms.Button
    Friend WithEvents txtCariNamaOp As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents KodeJenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaJenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UbahData As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents HapusData As System.Windows.Forms.DataGridViewButtonColumn
End Class
