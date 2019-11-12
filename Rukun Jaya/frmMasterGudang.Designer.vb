<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterGudang
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.kodegudang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namagudang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamatgudang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kotagudang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kepalagudang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telpgudang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ubah = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.hapus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodegudang, Me.namagudang, Me.alamatgudang, Me.kotagudang, Me.kepalagudang, Me.telpgudang, Me.keterangan, Me.ubah, Me.hapus})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(795, 239)
        Me.DataGridView1.TabIndex = 0
        '
        'kodegudang
        '
        Me.kodegudang.DataPropertyName = "kodegudang"
        Me.kodegudang.HeaderText = "Kode"
        Me.kodegudang.Name = "kodegudang"
        Me.kodegudang.ReadOnly = True
        Me.kodegudang.Width = 50
        '
        'namagudang
        '
        Me.namagudang.DataPropertyName = "namagudang"
        Me.namagudang.HeaderText = "Nama"
        Me.namagudang.Name = "namagudang"
        Me.namagudang.ReadOnly = True
        '
        'alamatgudang
        '
        Me.alamatgudang.DataPropertyName = "alamatGudang"
        Me.alamatgudang.HeaderText = "Alamat"
        Me.alamatgudang.Name = "alamatgudang"
        Me.alamatgudang.ReadOnly = True
        '
        'kotagudang
        '
        Me.kotagudang.DataPropertyName = "kotagudang"
        Me.kotagudang.HeaderText = "Kota"
        Me.kotagudang.Name = "kotagudang"
        Me.kotagudang.ReadOnly = True
        '
        'kepalagudang
        '
        Me.kepalagudang.DataPropertyName = "kepalagudang"
        Me.kepalagudang.HeaderText = "Contact Person"
        Me.kepalagudang.Name = "kepalagudang"
        Me.kepalagudang.ReadOnly = True
        '
        'telpgudang
        '
        Me.telpgudang.DataPropertyName = "telpgudang"
        Me.telpgudang.HeaderText = "Telp"
        Me.telpgudang.Name = "telpgudang"
        Me.telpgudang.ReadOnly = True
        '
        'keterangan
        '
        Me.keterangan.DataPropertyName = "keterangan"
        Me.keterangan.HeaderText = "Keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.ReadOnly = True
        '
        'ubah
        '
        Me.ubah.HeaderText = "Ubah"
        Me.ubah.Name = "ubah"
        Me.ubah.ReadOnly = True
        Me.ubah.Text = "Ubah"
        Me.ubah.UseColumnTextForButtonValue = True
        Me.ubah.Width = 45
        '
        'hapus
        '
        Me.hapus.HeaderText = "Hapus"
        Me.hapus.Name = "hapus"
        Me.hapus.ReadOnly = True
        Me.hapus.Text = "Hapus"
        Me.hapus.UseColumnTextForButtonValue = True
        Me.hapus.Width = 45
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(629, 263)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnTambah.Location = New System.Drawing.Point(13, 263)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(80, 29)
        Me.btnTambah.TabIndex = 2
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'frmMasterGudang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 300)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMasterGudang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Master Gudang :."
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents kodegudang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namagudang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents alamatgudang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kotagudang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kepalagudang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telpgudang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ubah As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents hapus As System.Windows.Forms.DataGridViewButtonColumn
End Class
