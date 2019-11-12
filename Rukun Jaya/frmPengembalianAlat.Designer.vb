<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPengembalianAlat
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
        Me.lbljumlahrow = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblnamapeminjam = New System.Windows.Forms.Label()
        Me.LblNonota = New System.Windows.Forms.Label()
        Me.txtsearchnama = New System.Windows.Forms.TextBox()
        Me.txtsearchno = New System.Windows.Forms.TextBox()
        Me.dgvPeminjaman = New System.Windows.Forms.DataGridView()
        Me.nopeminjaman = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaToko = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggalpinjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pengembalian = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnCari = New System.Windows.Forms.Button()
        CType(Me.dgvPeminjaman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbljumlahrow
        '
        Me.lbljumlahrow.AutoSize = True
        Me.lbljumlahrow.Location = New System.Drawing.Point(664, 331)
        Me.lbljumlahrow.Name = "lbljumlahrow"
        Me.lbljumlahrow.Size = New System.Drawing.Size(13, 13)
        Me.lbljumlahrow.TabIndex = 40
        Me.lbljumlahrow.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(583, 331)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Jumlah Data : "
        '
        'lblnamapeminjam
        '
        Me.lblnamapeminjam.AutoSize = True
        Me.lblnamapeminjam.Location = New System.Drawing.Point(508, 48)
        Me.lblnamapeminjam.Name = "lblnamapeminjam"
        Me.lblnamapeminjam.Size = New System.Drawing.Size(83, 13)
        Me.lblnamapeminjam.TabIndex = 38
        Me.lblnamapeminjam.Text = "Nama Peminjam"
        '
        'LblNonota
        '
        Me.LblNonota.AutoSize = True
        Me.LblNonota.Location = New System.Drawing.Point(510, 19)
        Me.LblNonota.Name = "LblNonota"
        Me.LblNonota.Size = New System.Drawing.Size(81, 13)
        Me.LblNonota.TabIndex = 37
        Me.LblNonota.Text = "No Peminjaman"
        '
        'txtsearchnama
        '
        Me.txtsearchnama.Location = New System.Drawing.Point(597, 43)
        Me.txtsearchnama.Name = "txtsearchnama"
        Me.txtsearchnama.Size = New System.Drawing.Size(150, 20)
        Me.txtsearchnama.TabIndex = 35
        '
        'txtsearchno
        '
        Me.txtsearchno.Location = New System.Drawing.Point(597, 16)
        Me.txtsearchno.Name = "txtsearchno"
        Me.txtsearchno.Size = New System.Drawing.Size(126, 20)
        Me.txtsearchno.TabIndex = 34
        '
        'dgvPeminjaman
        '
        Me.dgvPeminjaman.AllowUserToAddRows = False
        Me.dgvPeminjaman.AllowUserToDeleteRows = False
        Me.dgvPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPeminjaman.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nopeminjaman, Me.NamaToko, Me.tanggalpinjam, Me.Pengembalian})
        Me.dgvPeminjaman.Location = New System.Drawing.Point(12, 79)
        Me.dgvPeminjaman.Name = "dgvPeminjaman"
        Me.dgvPeminjaman.ReadOnly = True
        Me.dgvPeminjaman.Size = New System.Drawing.Size(826, 227)
        Me.dgvPeminjaman.TabIndex = 32
        '
        'nopeminjaman
        '
        Me.nopeminjaman.DataPropertyName = "nopeminjaman"
        Me.nopeminjaman.HeaderText = "No Peminjaman"
        Me.nopeminjaman.Name = "nopeminjaman"
        Me.nopeminjaman.ReadOnly = True
        '
        'NamaToko
        '
        Me.NamaToko.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NamaToko.DataPropertyName = "NamaSopir"
        Me.NamaToko.HeaderText = "Nama Peminjam"
        Me.NamaToko.Name = "NamaToko"
        Me.NamaToko.ReadOnly = True
        '
        'tanggalpinjam
        '
        Me.tanggalpinjam.DataPropertyName = "tanggalpinjam"
        Me.tanggalpinjam.HeaderText = "Tanggal Pinjam"
        Me.tanggalpinjam.Name = "tanggalpinjam"
        Me.tanggalpinjam.ReadOnly = True
        '
        'Pengembalian
        '
        Me.Pengembalian.HeaderText = "Pengembalian Alat"
        Me.Pengembalian.Name = "Pengembalian"
        Me.Pengembalian.ReadOnly = True
        Me.Pengembalian.Text = "Kembalikan Alat"
        Me.Pengembalian.UseColumnTextForButtonValue = True
        '
        'btnCari
        '
        Me.btnCari.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCari.Location = New System.Drawing.Point(753, 15)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(64, 46)
        Me.btnCari.TabIndex = 36
        Me.btnCari.Text = "Cari"
        Me.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'frmPengembalianAlat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 365)
        Me.Controls.Add(Me.lbljumlahrow)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblnamapeminjam)
        Me.Controls.Add(Me.LblNonota)
        Me.Controls.Add(Me.txtsearchnama)
        Me.Controls.Add(Me.txtsearchno)
        Me.Controls.Add(Me.dgvPeminjaman)
        Me.Controls.Add(Me.btnCari)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPengembalianAlat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Pengembalian Alat :."
        CType(Me.dgvPeminjaman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbljumlahrow As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblnamapeminjam As System.Windows.Forms.Label
    Friend WithEvents LblNonota As System.Windows.Forms.Label
    Friend WithEvents txtsearchnama As System.Windows.Forms.TextBox
    Friend WithEvents txtsearchno As System.Windows.Forms.TextBox
    Friend WithEvents dgvPeminjaman As System.Windows.Forms.DataGridView
    Friend WithEvents nopeminjaman As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaToko As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tanggalpinjam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pengembalian As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents btnCari As System.Windows.Forms.Button
End Class
