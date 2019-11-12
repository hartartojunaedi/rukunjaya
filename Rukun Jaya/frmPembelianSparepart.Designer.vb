<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPembelianSparepart
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvPembelianSparepart = New System.Windows.Forms.DataGridView()
        Me.Nonota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaToko = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgltransaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Diskon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grandtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ubahdata = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.HapusData = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txtsearchnonota = New System.Windows.Forms.TextBox()
        Me.txtsearchnamatoko = New System.Windows.Forms.TextBox()
        Me.LblNonota = New System.Windows.Forms.Label()
        Me.lblNamaToko = New System.Windows.Forms.Label()
        Me.lbljumlahrow = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvPembelianSparepart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.dgvPembelianSparepart.Size = New System.Drawing.Size(826, 287)
        Me.dgvPembelianSparepart.TabIndex = 14
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Total.DefaultCellStyle = DataGridViewCellStyle4
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'Diskon
        '
        Me.Diskon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Diskon.DataPropertyName = "diskon"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Diskon.DefaultCellStyle = DataGridViewCellStyle5
        Me.Diskon.HeaderText = "Diskon"
        Me.Diskon.Name = "Diskon"
        Me.Diskon.ReadOnly = True
        Me.Diskon.Width = 65
        '
        'grandtotal
        '
        Me.grandtotal.DataPropertyName = "grandtotal"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.grandtotal.DefaultCellStyle = DataGridViewCellStyle6
        Me.grandtotal.HeaderText = "Grand Total"
        Me.grandtotal.Name = "grandtotal"
        Me.grandtotal.ReadOnly = True
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
        '
        'txtsearchnonota
        '
        Me.txtsearchnonota.Location = New System.Drawing.Point(257, 11)
        Me.txtsearchnonota.Name = "txtsearchnonota"
        Me.txtsearchnonota.Size = New System.Drawing.Size(126, 20)
        Me.txtsearchnonota.TabIndex = 16
        '
        'txtsearchnamatoko
        '
        Me.txtsearchnamatoko.Location = New System.Drawing.Point(257, 38)
        Me.txtsearchnamatoko.Name = "txtsearchnamatoko"
        Me.txtsearchnamatoko.Size = New System.Drawing.Size(150, 20)
        Me.txtsearchnamatoko.TabIndex = 17
        '
        'LblNonota
        '
        Me.LblNonota.AutoSize = True
        Me.LblNonota.Location = New System.Drawing.Point(204, 14)
        Me.LblNonota.Name = "LblNonota"
        Me.LblNonota.Size = New System.Drawing.Size(47, 13)
        Me.LblNonota.TabIndex = 19
        Me.LblNonota.Text = "No Nota"
        '
        'lblNamaToko
        '
        Me.lblNamaToko.AutoSize = True
        Me.lblNamaToko.Location = New System.Drawing.Point(188, 43)
        Me.lblNamaToko.Name = "lblNamaToko"
        Me.lblNamaToko.Size = New System.Drawing.Size(63, 13)
        Me.lblNamaToko.TabIndex = 20
        Me.lblNamaToko.Text = "Nama Toko"
        '
        'lbljumlahrow
        '
        Me.lbljumlahrow.AutoSize = True
        Me.lbljumlahrow.Location = New System.Drawing.Point(661, 379)
        Me.lbljumlahrow.Name = "lbljumlahrow"
        Me.lbljumlahrow.Size = New System.Drawing.Size(13, 13)
        Me.lbljumlahrow.TabIndex = 22
        Me.lbljumlahrow.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(580, 379)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Jumlah Data : "
        '
        'btnCari
        '
        Me.btnCari.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCari.Location = New System.Drawing.Point(753, 12)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(64, 46)
        Me.btnCari.TabIndex = 18
        Me.btnCari.Text = "Cari"
        Me.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(29, 369)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(81, 33)
        Me.btnTambah.TabIndex = 15
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(415, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Periode"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(464, 14)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(87, 20)
        Me.DateTimePicker1.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(557, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "-"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(573, 14)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(87, 20)
        Me.DateTimePicker2.TabIndex = 26
        '
        'frmPembelianSparepart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 414)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbljumlahrow)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblNamaToko)
        Me.Controls.Add(Me.LblNonota)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtsearchnamatoko)
        Me.Controls.Add(Me.txtsearchnonota)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.dgvPembelianSparepart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPembelianSparepart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Pembelian Spare Part :. "
        CType(Me.dgvPembelianSparepart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvPembelianSparepart As System.Windows.Forms.DataGridView
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents txtsearchnonota As System.Windows.Forms.TextBox
    Friend WithEvents txtsearchnamatoko As System.Windows.Forms.TextBox
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents LblNonota As System.Windows.Forms.Label
    Friend WithEvents lblNamaToko As System.Windows.Forms.Label
    Friend WithEvents lbljumlahrow As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Nonota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaToko As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tgltransaksi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Diskon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grandtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ubahdata As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents HapusData As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
End Class
