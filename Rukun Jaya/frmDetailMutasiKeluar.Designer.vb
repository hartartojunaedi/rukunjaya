<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailMutasiKeluar
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.lblNamaSparepart = New System.Windows.Forms.Label()
        Me.cmbNamaSparepart = New System.Windows.Forms.ComboBox()
        Me.lblsisastock = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.txtDetailKeterangan = New System.Windows.Forms.TextBox()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.txtNoSeri = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.kodesparepart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Namasparepart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.noseri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.dgvstock = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvstock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No SPK"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(91, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(91, 38)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Karyawan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tanggal"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(91, 67)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(91, 96)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Keterangan "
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(91, 122)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(208, 79)
        Me.TextBox4.TabIndex = 9
        '
        'lblNamaSparepart
        '
        Me.lblNamaSparepart.AutoSize = True
        Me.lblNamaSparepart.Location = New System.Drawing.Point(412, 16)
        Me.lblNamaSparepart.Name = "lblNamaSparepart"
        Me.lblNamaSparepart.Size = New System.Drawing.Size(84, 13)
        Me.lblNamaSparepart.TabIndex = 61
        Me.lblNamaSparepart.Text = "Nama Sparepart"
        '
        'cmbNamaSparepart
        '
        Me.cmbNamaSparepart.FormattingEnabled = True
        Me.cmbNamaSparepart.Location = New System.Drawing.Point(500, 13)
        Me.cmbNamaSparepart.Name = "cmbNamaSparepart"
        Me.cmbNamaSparepart.Size = New System.Drawing.Size(150, 21)
        Me.cmbNamaSparepart.TabIndex = 62
        '
        'lblsisastock
        '
        Me.lblsisastock.AutoSize = True
        Me.lblsisastock.Location = New System.Drawing.Point(500, 43)
        Me.lblsisastock.Name = "lblsisastock"
        Me.lblsisastock.Size = New System.Drawing.Size(13, 13)
        Me.lblsisastock.TabIndex = 88
        Me.lblsisastock.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(438, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Sisa Stock"
        '
        'btntambah
        '
        Me.btntambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.btntambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntambah.Location = New System.Drawing.Point(629, 170)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 31)
        Me.btntambah.TabIndex = 86
        Me.btntambah.Text = "Tambah"
        Me.btntambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'txtDetailKeterangan
        '
        Me.txtDetailKeterangan.Location = New System.Drawing.Point(497, 122)
        Me.txtDetailKeterangan.Multiline = True
        Me.txtDetailKeterangan.Name = "txtDetailKeterangan"
        Me.txtDetailKeterangan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetailKeterangan.Size = New System.Drawing.Size(207, 42)
        Me.txtDetailKeterangan.TabIndex = 85
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(497, 96)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(105, 20)
        Me.txtJumlah.TabIndex = 84
        '
        'txtNoSeri
        '
        Me.txtNoSeri.Location = New System.Drawing.Point(497, 70)
        Me.txtNoSeri.Name = "txtNoSeri"
        Me.txtNoSeri.Size = New System.Drawing.Size(146, 20)
        Me.txtNoSeri.TabIndex = 82
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(428, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "Keterangan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(453, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Jumlah"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(451, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 80
        Me.Label9.Text = "No Seri"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodesparepart, Me.Namasparepart, Me.noseri, Me.Jumlah, Me.keterangan})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 207)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(723, 150)
        Me.DataGridView1.TabIndex = 89
        '
        'kodesparepart
        '
        Me.kodesparepart.DataPropertyName = "kodesparepart"
        Me.kodesparepart.HeaderText = "Kode"
        Me.kodesparepart.Name = "kodesparepart"
        '
        'Namasparepart
        '
        Me.Namasparepart.DataPropertyName = "namasparepart"
        Me.Namasparepart.HeaderText = "Nama Spare Part"
        Me.Namasparepart.Name = "Namasparepart"
        '
        'noseri
        '
        Me.noseri.DataPropertyName = "noseri"
        Me.noseri.HeaderText = "No Seri"
        Me.noseri.Name = "noseri"
        '
        'Jumlah
        '
        Me.Jumlah.DataPropertyName = "jumlah"
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.Name = "Jumlah"
        '
        'keterangan
        '
        Me.keterangan.DataPropertyName = "keterangan"
        Me.keterangan.HeaderText = "keterangan"
        Me.keterangan.Name = "keterangan"
        '
        'btnBatal
        '
        Me.btnBatal.Image = Global.RukunJaya.My.Resources.Resources.cancelbr
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(99, 370)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 31)
        Me.btnBatal.TabIndex = 91
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnsimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsimpan.Location = New System.Drawing.Point(20, 370)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 31)
        Me.btnsimpan.TabIndex = 90
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'dgvstock
        '
        Me.dgvstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvstock.Location = New System.Drawing.Point(333, 148)
        Me.dgvstock.Name = "dgvstock"
        Me.dgvstock.Size = New System.Drawing.Size(129, 59)
        Me.dgvstock.TabIndex = 92
        Me.dgvstock.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(197, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Nopol"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(238, 38)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 94
        '
        'frmDetailMutasiKeluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 407)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dgvstock)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblsisastock)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.txtDetailKeterangan)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.txtNoSeri)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblNamaSparepart)
        Me.Controls.Add(Me.cmbNamaSparepart)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetailMutasiKeluar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Detail Mutasi Keluar :."
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvstock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents lblNamaSparepart As System.Windows.Forms.Label
    Friend WithEvents cmbNamaSparepart As System.Windows.Forms.ComboBox
    Friend WithEvents lblsisastock As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents txtDetailKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents txtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents txtNoSeri As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents dgvstock As System.Windows.Forms.DataGridView
    Friend WithEvents kodesparepart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Namasparepart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents noseri As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
