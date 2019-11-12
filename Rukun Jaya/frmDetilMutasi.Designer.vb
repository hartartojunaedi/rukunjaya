<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetilMutasi
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
        Me.cmbNamaSparepart = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblJumlah = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvmutasi = New System.Windows.Forms.DataGridView()
        Me.kodesparepart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaSparePart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahSebelum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahSesudah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Selisih = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hapus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.nmJumlahbaru = New System.Windows.Forms.NumericUpDown()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtketerangan = New System.Windows.Forms.TextBox()
        CType(Me.dgvmutasi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmJumlahbaru, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama SparePart :"
        '
        'cmbNamaSparepart
        '
        Me.cmbNamaSparepart.FormattingEnabled = True
        Me.cmbNamaSparepart.Location = New System.Drawing.Point(110, 10)
        Me.cmbNamaSparepart.Name = "cmbNamaSparepart"
        Me.cmbNamaSparepart.Size = New System.Drawing.Size(150, 21)
        Me.cmbNamaSparepart.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Jumlah Awal :"
        '
        'lblJumlah
        '
        Me.lblJumlah.AutoSize = True
        Me.lblJumlah.Location = New System.Drawing.Point(107, 45)
        Me.lblJumlah.Name = "lblJumlah"
        Me.lblJumlah.Size = New System.Drawing.Size(0, 13)
        Me.lblJumlah.TabIndex = 73
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Jumlah Baru :"
        '
        'dgvmutasi
        '
        Me.dgvmutasi.AllowUserToAddRows = False
        Me.dgvmutasi.AllowUserToDeleteRows = False
        Me.dgvmutasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmutasi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodesparepart, Me.NamaSparePart, Me.JumlahSebelum, Me.JumlahSesudah, Me.Selisih, Me.Keterangan, Me.Hapus})
        Me.dgvmutasi.Location = New System.Drawing.Point(22, 189)
        Me.dgvmutasi.Name = "dgvmutasi"
        Me.dgvmutasi.ReadOnly = True
        Me.dgvmutasi.Size = New System.Drawing.Size(617, 150)
        Me.dgvmutasi.TabIndex = 76
        '
        'kodesparepart
        '
        Me.kodesparepart.HeaderText = "kodesparepart"
        Me.kodesparepart.Name = "kodesparepart"
        Me.kodesparepart.ReadOnly = True
        Me.kodesparepart.Visible = False
        '
        'NamaSparePart
        '
        Me.NamaSparePart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NamaSparePart.HeaderText = "Nama SparePart"
        Me.NamaSparePart.Name = "NamaSparePart"
        Me.NamaSparePart.ReadOnly = True
        '
        'JumlahSebelum
        '
        Me.JumlahSebelum.HeaderText = "Jumlah Sebelum"
        Me.JumlahSebelum.Name = "JumlahSebelum"
        Me.JumlahSebelum.ReadOnly = True
        '
        'JumlahSesudah
        '
        Me.JumlahSesudah.HeaderText = "JumlahSesudah"
        Me.JumlahSesudah.Name = "JumlahSesudah"
        Me.JumlahSesudah.ReadOnly = True
        '
        'Selisih
        '
        Me.Selisih.HeaderText = "Selisih"
        Me.Selisih.Name = "Selisih"
        Me.Selisih.ReadOnly = True
        '
        'Keterangan
        '
        Me.Keterangan.HeaderText = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.ReadOnly = True
        '
        'Hapus
        '
        Me.Hapus.HeaderText = "Hapus"
        Me.Hapus.Name = "Hapus"
        Me.Hapus.ReadOnly = True
        Me.Hapus.Text = "Hapus"
        Me.Hapus.ToolTipText = "Hapus"
        Me.Hapus.UseColumnTextForButtonValue = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(264, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 57)
        Me.Button1.TabIndex = 77
        Me.Button1.Text = "Ubah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'nmJumlahbaru
        '
        Me.nmJumlahbaru.DecimalPlaces = 2
        Me.nmJumlahbaru.Location = New System.Drawing.Point(111, 71)
        Me.nmJumlahbaru.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.nmJumlahbaru.Name = "nmJumlahbaru"
        Me.nmJumlahbaru.Size = New System.Drawing.Size(120, 20)
        Me.nmJumlahbaru.TabIndex = 78
        '
        'Button2
        '
        Me.Button2.Image = Global.RukunJaya.My.Resources.Resources.save
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(495, 346)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 43)
        Me.Button2.TabIndex = 79
        Me.Button2.Text = "Simpan Perubahan"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Keterangan  :"
        '
        'txtketerangan
        '
        Me.txtketerangan.Location = New System.Drawing.Point(110, 105)
        Me.txtketerangan.Multiline = True
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.Size = New System.Drawing.Size(148, 69)
        Me.txtketerangan.TabIndex = 81
        '
        'frmDetilMutasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 399)
        Me.Controls.Add(Me.txtketerangan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.nmJumlahbaru)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvmutasi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblJumlah)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbNamaSparepart)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetilMutasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Mutasi Sparepart :."
        CType(Me.dgvmutasi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmJumlahbaru, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbNamaSparepart As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblJumlah As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgvmutasi As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents nmJumlahbaru As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents kodesparepart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaSparePart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JumlahSebelum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JumlahSesudah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Selisih As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hapus As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtketerangan As System.Windows.Forms.TextBox
End Class
