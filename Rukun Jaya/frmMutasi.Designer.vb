<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMutasi
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
        Me.dgvMutasi = New System.Windows.Forms.DataGridView()
        Me.Nomutasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalMutasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kodesparepart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaSparepart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlahsebelum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlahsesudah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Selisih = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetilMutasi = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbljumlahrow = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblnamapeminjam = New System.Windows.Forms.Label()
        Me.dtSampai = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtMulai = New System.Windows.Forms.DateTimePicker()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.dgvMutasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMutasi
        '
        Me.dgvMutasi.AllowUserToAddRows = False
        Me.dgvMutasi.AllowUserToDeleteRows = False
        Me.dgvMutasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMutasi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nomutasi, Me.TanggalMutasi, Me.kodesparepart, Me.NamaSparepart, Me.Jumlahsebelum, Me.Jumlahsesudah, Me.Selisih, Me.Keterangan, Me.DetilMutasi})
        Me.dgvMutasi.Location = New System.Drawing.Point(12, 38)
        Me.dgvMutasi.Name = "dgvMutasi"
        Me.dgvMutasi.ReadOnly = True
        Me.dgvMutasi.Size = New System.Drawing.Size(907, 227)
        Me.dgvMutasi.TabIndex = 33
        '
        'Nomutasi
        '
        Me.Nomutasi.DataPropertyName = "Nomutasi"
        Me.Nomutasi.HeaderText = "No Mutasi"
        Me.Nomutasi.Name = "Nomutasi"
        Me.Nomutasi.ReadOnly = True
        '
        'TanggalMutasi
        '
        Me.TanggalMutasi.DataPropertyName = "TanggalMutasi"
        DataGridViewCellStyle1.Format = "dd-MM-yyyy"
        Me.TanggalMutasi.DefaultCellStyle = DataGridViewCellStyle1
        Me.TanggalMutasi.HeaderText = "Tanggal Mutasi"
        Me.TanggalMutasi.Name = "TanggalMutasi"
        Me.TanggalMutasi.ReadOnly = True
        '
        'kodesparepart
        '
        Me.kodesparepart.DataPropertyName = "kodesparepart"
        Me.kodesparepart.HeaderText = "Kode Sparepart"
        Me.kodesparepart.Name = "kodesparepart"
        Me.kodesparepart.ReadOnly = True
        '
        'NamaSparepart
        '
        Me.NamaSparepart.DataPropertyName = "NamaSparepart"
        Me.NamaSparepart.HeaderText = "Nama Sparepart"
        Me.NamaSparepart.Name = "NamaSparepart"
        Me.NamaSparepart.ReadOnly = True
        '
        'Jumlahsebelum
        '
        Me.Jumlahsebelum.DataPropertyName = "Jumlahsebelum"
        Me.Jumlahsebelum.HeaderText = "Sebelum"
        Me.Jumlahsebelum.Name = "Jumlahsebelum"
        Me.Jumlahsebelum.ReadOnly = True
        '
        'Jumlahsesudah
        '
        Me.Jumlahsesudah.DataPropertyName = "Jumlahsesudah"
        Me.Jumlahsesudah.HeaderText = "Sesudah"
        Me.Jumlahsesudah.Name = "Jumlahsesudah"
        Me.Jumlahsesudah.ReadOnly = True
        '
        'Selisih
        '
        Me.Selisih.DataPropertyName = "Selisih"
        Me.Selisih.HeaderText = "Selisih"
        Me.Selisih.Name = "Selisih"
        Me.Selisih.ReadOnly = True
        '
        'Keterangan
        '
        Me.Keterangan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Keterangan.DataPropertyName = "Keterangan"
        Me.Keterangan.HeaderText = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.ReadOnly = True
        '
        'DetilMutasi
        '
        Me.DetilMutasi.HeaderText = "Detil"
        Me.DetilMutasi.Name = "DetilMutasi"
        Me.DetilMutasi.ReadOnly = True
        Me.DetilMutasi.Text = "Detil Mutasi"
        Me.DetilMutasi.UseColumnTextForButtonValue = True
        Me.DetilMutasi.Visible = False
        '
        'Button1
        '
        Me.Button1.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(23, 271)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 40)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "&Mutasi Barang"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbljumlahrow
        '
        Me.lbljumlahrow.AutoSize = True
        Me.lbljumlahrow.Location = New System.Drawing.Point(849, 276)
        Me.lbljumlahrow.Name = "lbljumlahrow"
        Me.lbljumlahrow.Size = New System.Drawing.Size(13, 13)
        Me.lbljumlahrow.TabIndex = 42
        Me.lbljumlahrow.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(768, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Jumlah Data : "
        '
        'lblnamapeminjam
        '
        Me.lblnamapeminjam.AutoSize = True
        Me.lblnamapeminjam.Location = New System.Drawing.Point(472, 18)
        Me.lblnamapeminjam.Name = "lblnamapeminjam"
        Me.lblnamapeminjam.Size = New System.Drawing.Size(46, 13)
        Me.lblnamapeminjam.TabIndex = 44
        Me.lblnamapeminjam.Text = "Tanggal"
        '
        'dtSampai
        '
        Me.dtSampai.CustomFormat = "dd-MM-yyyy"
        Me.dtSampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtSampai.Location = New System.Drawing.Point(691, 12)
        Me.dtSampai.Name = "dtSampai"
        Me.dtSampai.Size = New System.Drawing.Size(139, 20)
        Me.dtSampai.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(662, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "s/d"
        '
        'dtMulai
        '
        Me.dtMulai.CustomFormat = "dd-MM-yyyy"
        Me.dtMulai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtMulai.Location = New System.Drawing.Point(528, 12)
        Me.dtMulai.Name = "dtMulai"
        Me.dtMulai.Size = New System.Drawing.Size(128, 20)
        Me.dtMulai.TabIndex = 45
        '
        'btnCari
        '
        Me.btnCari.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCari.Location = New System.Drawing.Point(839, 4)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(66, 28)
        Me.btnCari.TabIndex = 48
        Me.btnCari.Text = "Filter"
        Me.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.RukunJaya.My.Resources.Resources.xls
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(140, 271)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 40)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "&Excel "
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(255, 282)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 50
        Me.TextBox1.Visible = False
        '
        'frmMutasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 314)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.dtSampai)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtMulai)
        Me.Controls.Add(Me.lblnamapeminjam)
        Me.Controls.Add(Me.lbljumlahrow)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvMutasi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMutasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Mutasi :."
        CType(Me.dgvMutasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvMutasi As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbljumlahrow As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblnamapeminjam As System.Windows.Forms.Label
    Friend WithEvents dtSampai As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtMulai As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Nomutasi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TanggalMutasi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kodesparepart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaSparepart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jumlahsebelum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jumlahsesudah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Selisih As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetilMutasi As System.Windows.Forms.DataGridViewButtonColumn
End Class
