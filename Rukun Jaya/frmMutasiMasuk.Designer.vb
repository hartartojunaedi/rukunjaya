<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMutasiMasuk
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbljumlahrow = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNamaToko = New System.Windows.Forms.Label()
        Me.LblNonota = New System.Windows.Forms.Label()
        Me.txtsearchnamatoko = New System.Windows.Forms.TextBox()
        Me.txtsearchnonota = New System.Windows.Forms.TextBox()
        Me.dgvPembelianSparepart = New System.Windows.Forms.DataGridView()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Nonota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaToko = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgltransaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Diskon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grandtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ubahdata = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.HapusData = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvPembelianSparepart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbljumlahrow
        '
        Me.lbljumlahrow.AutoSize = True
        Me.lbljumlahrow.Location = New System.Drawing.Point(664, 328)
        Me.lbljumlahrow.Name = "lbljumlahrow"
        Me.lbljumlahrow.Size = New System.Drawing.Size(13, 13)
        Me.lbljumlahrow.TabIndex = 31
        Me.lbljumlahrow.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(583, 328)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Jumlah Data : "
        '
        'lblNamaToko
        '
        Me.lblNamaToko.AutoSize = True
        Me.lblNamaToko.Location = New System.Drawing.Point(528, 45)
        Me.lblNamaToko.Name = "lblNamaToko"
        Me.lblNamaToko.Size = New System.Drawing.Size(63, 13)
        Me.lblNamaToko.TabIndex = 29
        Me.lblNamaToko.Text = "Nama Toko"
        '
        'LblNonota
        '
        Me.LblNonota.AutoSize = True
        Me.LblNonota.Location = New System.Drawing.Point(544, 16)
        Me.LblNonota.Name = "LblNonota"
        Me.LblNonota.Size = New System.Drawing.Size(47, 13)
        Me.LblNonota.TabIndex = 28
        Me.LblNonota.Text = "No Nota"
        '
        'txtsearchnamatoko
        '
        Me.txtsearchnamatoko.Location = New System.Drawing.Point(597, 40)
        Me.txtsearchnamatoko.Name = "txtsearchnamatoko"
        Me.txtsearchnamatoko.Size = New System.Drawing.Size(150, 20)
        Me.txtsearchnamatoko.TabIndex = 26
        '
        'txtsearchnonota
        '
        Me.txtsearchnonota.Location = New System.Drawing.Point(597, 13)
        Me.txtsearchnonota.Name = "txtsearchnonota"
        Me.txtsearchnonota.Size = New System.Drawing.Size(126, 20)
        Me.txtsearchnonota.TabIndex = 25
        '
        'dgvPembelianSparepart
        '
        Me.dgvPembelianSparepart.AllowUserToAddRows = False
        Me.dgvPembelianSparepart.AllowUserToDeleteRows = False
        Me.dgvPembelianSparepart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPembelianSparepart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nonota, Me.NamaToko, Me.tgltransaksi, Me.Total, Me.Diskon, Me.grandtotal, Me.ubahdata, Me.HapusData})
        Me.dgvPembelianSparepart.Location = New System.Drawing.Point(12, 76)
        Me.dgvPembelianSparepart.Name = "dgvPembelianSparepart"
        Me.dgvPembelianSparepart.ReadOnly = True
        Me.dgvPembelianSparepart.Size = New System.Drawing.Size(826, 227)
        Me.dgvPembelianSparepart.TabIndex = 23
        '
        'btnCari
        '
        Me.btnCari.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCari.Location = New System.Drawing.Point(753, 12)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(64, 46)
        Me.btnCari.TabIndex = 27
        Me.btnCari.Text = "Cari"
        Me.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(32, 318)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(81, 33)
        Me.btnTambah.TabIndex = 24
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Nonota
        '
        Me.Nonota.DataPropertyName = "nota"
        Me.Nonota.HeaderText = "No Nota"
        Me.Nonota.Name = "Nonota"
        Me.Nonota.ReadOnly = True
        '
        'NamaToko
        '
        Me.NamaToko.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NamaToko.DataPropertyName = "namatoko"
        Me.NamaToko.HeaderText = "Nama Toko"
        Me.NamaToko.Name = "NamaToko"
        Me.NamaToko.ReadOnly = True
        '
        'tgltransaksi
        '
        Me.tgltransaksi.DataPropertyName = "tgltransaksi"
        Me.tgltransaksi.HeaderText = "Tanggal Transaksi"
        Me.tgltransaksi.Name = "tgltransaksi"
        Me.tgltransaksi.ReadOnly = True
        '
        'Total
        '
        Me.Total.DataPropertyName = "total"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Total.DefaultCellStyle = DataGridViewCellStyle1
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Visible = False
        '
        'Diskon
        '
        Me.Diskon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Diskon.DataPropertyName = "diskon"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Diskon.DefaultCellStyle = DataGridViewCellStyle2
        Me.Diskon.HeaderText = "Diskon"
        Me.Diskon.Name = "Diskon"
        Me.Diskon.ReadOnly = True
        Me.Diskon.Visible = False
        Me.Diskon.Width = 65
        '
        'grandtotal
        '
        Me.grandtotal.DataPropertyName = "grandtotal"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.grandtotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.grandtotal.HeaderText = "Grand Total"
        Me.grandtotal.Name = "grandtotal"
        Me.grandtotal.ReadOnly = True
        Me.grandtotal.Visible = False
        '
        'ubahdata
        '
        Me.ubahdata.HeaderText = "Ubah"
        Me.ubahdata.Name = "ubahdata"
        Me.ubahdata.ReadOnly = True
        Me.ubahdata.Text = "Ubah"
        Me.ubahdata.UseColumnTextForButtonValue = True
        '
        'HapusData
        '
        Me.HapusData.HeaderText = "Hapus"
        Me.HapusData.Name = "HapusData"
        Me.HapusData.ReadOnly = True
        Me.HapusData.Text = "Hapus"
        Me.HapusData.UseColumnTextForButtonValue = True
        Me.HapusData.Visible = False
        '
        'frmMutasiMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 359)
        Me.Controls.Add(Me.lbljumlahrow)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblNamaToko)
        Me.Controls.Add(Me.LblNonota)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtsearchnamatoko)
        Me.Controls.Add(Me.txtsearchnonota)
        Me.Controls.Add(Me.dgvPembelianSparepart)
        Me.Controls.Add(Me.btnTambah)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMutasiMasuk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Mutasi Masuk :."
        CType(Me.dgvPembelianSparepart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbljumlahrow As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblNamaToko As System.Windows.Forms.Label
    Friend WithEvents LblNonota As System.Windows.Forms.Label
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents txtsearchnamatoko As System.Windows.Forms.TextBox
    Friend WithEvents txtsearchnonota As System.Windows.Forms.TextBox
    Friend WithEvents dgvPembelianSparepart As System.Windows.Forms.DataGridView
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents Nonota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaToko As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tgltransaksi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Diskon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grandtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ubahdata As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents HapusData As System.Windows.Forms.DataGridViewButtonColumn
End Class
