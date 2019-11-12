<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdetilpengembalianAlat
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
        Me.lbljumlahitem = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvdetilpeminjaman = New System.Windows.Forms.DataGridView()
        Me.nopeminjaman = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDAlat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaAlat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblNamaToko = New System.Windows.Forms.Label()
        Me.lblTglTransaksi = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblnamapeminjam = New System.Windows.Forms.Label()
        Me.lblnopeminjaman = New System.Windows.Forms.Label()
        Me.lbltanggalpinjam = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvdetilpeminjaman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbljumlahitem
        '
        Me.lbljumlahitem.AutoSize = True
        Me.lbljumlahitem.Location = New System.Drawing.Point(477, 278)
        Me.lbljumlahitem.Name = "lbljumlahitem"
        Me.lbljumlahitem.Size = New System.Drawing.Size(13, 13)
        Me.lbljumlahitem.TabIndex = 85
        Me.lbljumlahitem.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(408, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Jumlah Item :"
        '
        'dgvdetilpeminjaman
        '
        Me.dgvdetilpeminjaman.AllowUserToAddRows = False
        Me.dgvdetilpeminjaman.AllowUserToDeleteRows = False
        Me.dgvdetilpeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetilpeminjaman.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nopeminjaman, Me.IDAlat, Me.NamaAlat, Me.Jumlah})
        Me.dgvdetilpeminjaman.Location = New System.Drawing.Point(12, 106)
        Me.dgvdetilpeminjaman.Name = "dgvdetilpeminjaman"
        Me.dgvdetilpeminjaman.ReadOnly = True
        Me.dgvdetilpeminjaman.Size = New System.Drawing.Size(486, 158)
        Me.dgvdetilpeminjaman.TabIndex = 81
        '
        'nopeminjaman
        '
        Me.nopeminjaman.DataPropertyName = "Nopeminjaman"
        Me.nopeminjaman.HeaderText = "nopeminjaman"
        Me.nopeminjaman.Name = "nopeminjaman"
        Me.nopeminjaman.ReadOnly = True
        Me.nopeminjaman.Visible = False
        '
        'IDAlat
        '
        Me.IDAlat.DataPropertyName = "IDALat"
        Me.IDAlat.HeaderText = "Id Alat"
        Me.IDAlat.Name = "IDAlat"
        Me.IDAlat.ReadOnly = True
        Me.IDAlat.Visible = False
        '
        'NamaAlat
        '
        Me.NamaAlat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NamaAlat.DataPropertyName = "NamaAlat"
        Me.NamaAlat.HeaderText = "Nama Alat"
        Me.NamaAlat.Name = "NamaAlat"
        Me.NamaAlat.ReadOnly = True
        '
        'Jumlah
        '
        Me.Jumlah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Jumlah.DataPropertyName = "jumlah"
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.ReadOnly = True
        Me.Jumlah.Width = 65
        '
        'lblNamaToko
        '
        Me.lblNamaToko.AutoSize = True
        Me.lblNamaToko.Location = New System.Drawing.Point(39, 71)
        Me.lblNamaToko.Name = "lblNamaToko"
        Me.lblNamaToko.Size = New System.Drawing.Size(83, 13)
        Me.lblNamaToko.TabIndex = 80
        Me.lblNamaToko.Text = "Nama Peminjam"
        '
        'lblTglTransaksi
        '
        Me.lblTglTransaksi.AutoSize = True
        Me.lblTglTransaksi.Location = New System.Drawing.Point(42, 44)
        Me.lblTglTransaksi.Name = "lblTglTransaksi"
        Me.lblTglTransaksi.Size = New System.Drawing.Size(80, 13)
        Me.lblTglTransaksi.TabIndex = 79
        Me.lblTglTransaksi.Text = "Tanggal Pinjam"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "No. Peminjaman"
        '
        'lblnamapeminjam
        '
        Me.lblnamapeminjam.AutoSize = True
        Me.lblnamapeminjam.Location = New System.Drawing.Point(129, 76)
        Me.lblnamapeminjam.Name = "lblnamapeminjam"
        Me.lblnamapeminjam.Size = New System.Drawing.Size(0, 13)
        Me.lblnamapeminjam.TabIndex = 90
        '
        'lblnopeminjaman
        '
        Me.lblnopeminjaman.AutoSize = True
        Me.lblnopeminjaman.Location = New System.Drawing.Point(128, 15)
        Me.lblnopeminjaman.Name = "lblnopeminjaman"
        Me.lblnopeminjaman.Size = New System.Drawing.Size(0, 13)
        Me.lblnopeminjaman.TabIndex = 91
        '
        'lbltanggalpinjam
        '
        Me.lbltanggalpinjam.AutoSize = True
        Me.lbltanggalpinjam.Location = New System.Drawing.Point(131, 43)
        Me.lbltanggalpinjam.Name = "lbltanggalpinjam"
        Me.lbltanggalpinjam.Size = New System.Drawing.Size(0, 13)
        Me.lbltanggalpinjam.TabIndex = 92
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(370, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 80)
        Me.Button1.TabIndex = 93
        Me.Button1.Text = "Kembalikan Barang"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 94
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(157, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 95
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(157, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 96
        '
        'frmdetilpengembalianAlat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 318)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbltanggalpinjam)
        Me.Controls.Add(Me.lblnopeminjaman)
        Me.Controls.Add(Me.lblnamapeminjam)
        Me.Controls.Add(Me.lbljumlahitem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvdetilpeminjaman)
        Me.Controls.Add(Me.lblNamaToko)
        Me.Controls.Add(Me.lblTglTransaksi)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmdetilpengembalianAlat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Detail Pengembalian Alat :."
        CType(Me.dgvdetilpeminjaman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbljumlahitem As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgvdetilpeminjaman As System.Windows.Forms.DataGridView
    Friend WithEvents lblNamaToko As System.Windows.Forms.Label
    Friend WithEvents lblTglTransaksi As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblnamapeminjam As System.Windows.Forms.Label
    Friend WithEvents lblnopeminjaman As System.Windows.Forms.Label
    Friend WithEvents lbltanggalpinjam As System.Windows.Forms.Label
    Friend WithEvents nopeminjaman As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDAlat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaAlat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
