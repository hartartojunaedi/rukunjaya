<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBayarTagihan
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvBM = New System.Windows.Forms.DataGridView()
        Me.SJ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Biaya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tambahan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Potongan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlSupp = New System.Windows.Forms.Panel()
        Me.cmbCaraBayar = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.RichTextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.lblGrand = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTagihan = New System.Windows.Forms.Label()
        Me.lblSupp = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblBiaya = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPotongan = New System.Windows.Forms.TextBox()
        Me.txtTambahan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblValidator = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpTgl = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvBM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSupp.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvBM
        '
        Me.dgvBM.AllowUserToAddRows = False
        Me.dgvBM.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBM.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SJ, Me.BM, Me.Biaya, Me.Tambahan, Me.Potongan, Me.subtotal, Me.keterangan})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBM.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvBM.Location = New System.Drawing.Point(360, 12)
        Me.dgvBM.Name = "dgvBM"
        Me.dgvBM.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBM.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvBM.Size = New System.Drawing.Size(744, 357)
        Me.dgvBM.TabIndex = 11
        '
        'SJ
        '
        Me.SJ.DataPropertyName = "SJ"
        Me.SJ.HeaderText = "No Surat Jalan"
        Me.SJ.Name = "SJ"
        Me.SJ.ReadOnly = True
        '
        'BM
        '
        Me.BM.DataPropertyName = "BM"
        Me.BM.HeaderText = "No Bon Muat"
        Me.BM.Name = "BM"
        Me.BM.ReadOnly = True
        '
        'Biaya
        '
        Me.Biaya.DataPropertyName = "TOTAL"
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = "0"
        Me.Biaya.DefaultCellStyle = DataGridViewCellStyle2
        Me.Biaya.HeaderText = "Biaya"
        Me.Biaya.Name = "Biaya"
        Me.Biaya.ReadOnly = True
        '
        'Tambahan
        '
        Me.Tambahan.DataPropertyName = "TAMBAHAN"
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = "0"
        Me.Tambahan.DefaultCellStyle = DataGridViewCellStyle3
        Me.Tambahan.HeaderText = "Tambahan"
        Me.Tambahan.Name = "Tambahan"
        Me.Tambahan.ReadOnly = True
        '
        'Potongan
        '
        Me.Potongan.DataPropertyName = "POTONGAN"
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = "0"
        Me.Potongan.DefaultCellStyle = DataGridViewCellStyle4
        Me.Potongan.HeaderText = "Potongan"
        Me.Potongan.Name = "Potongan"
        Me.Potongan.ReadOnly = True
        '
        'subtotal
        '
        Me.subtotal.DataPropertyName = "AKHIR"
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = "0"
        Me.subtotal.DefaultCellStyle = DataGridViewCellStyle5
        Me.subtotal.HeaderText = "Biaya Akhir"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        '
        'keterangan
        '
        Me.keterangan.DataPropertyName = "keterangan"
        Me.keterangan.HeaderText = "Keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.ReadOnly = True
        '
        'pnlSupp
        '
        Me.pnlSupp.Controls.Add(Me.cmbCaraBayar)
        Me.pnlSupp.Controls.Add(Me.Label4)
        Me.pnlSupp.Controls.Add(Me.txtKeterangan)
        Me.pnlSupp.Controls.Add(Me.btnSimpan)
        Me.pnlSupp.Controls.Add(Me.lblGrand)
        Me.pnlSupp.Controls.Add(Me.Label10)
        Me.pnlSupp.Controls.Add(Me.lblTagihan)
        Me.pnlSupp.Controls.Add(Me.lblSupp)
        Me.pnlSupp.Controls.Add(Me.btnCari)
        Me.pnlSupp.Controls.Add(Me.Label9)
        Me.pnlSupp.Controls.Add(Me.lblBiaya)
        Me.pnlSupp.Controls.Add(Me.Label8)
        Me.pnlSupp.Controls.Add(Me.txtPotongan)
        Me.pnlSupp.Controls.Add(Me.txtTambahan)
        Me.pnlSupp.Controls.Add(Me.Label6)
        Me.pnlSupp.Controls.Add(Me.Label5)
        Me.pnlSupp.Controls.Add(Me.LblValidator)
        Me.pnlSupp.Controls.Add(Me.Label3)
        Me.pnlSupp.Controls.Add(Me.dtpTgl)
        Me.pnlSupp.Controls.Add(Me.Label2)
        Me.pnlSupp.Controls.Add(Me.Label1)
        Me.pnlSupp.Location = New System.Drawing.Point(3, 12)
        Me.pnlSupp.Name = "pnlSupp"
        Me.pnlSupp.Size = New System.Drawing.Size(350, 357)
        Me.pnlSupp.TabIndex = 1
        '
        'cmbCaraBayar
        '
        Me.cmbCaraBayar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCaraBayar.FormattingEnabled = True
        Me.cmbCaraBayar.Items.AddRange(New Object() {"Cash", "Transfer", "Giro", "Cek", "Lain-lain"})
        Me.cmbCaraBayar.Location = New System.Drawing.Point(100, 179)
        Me.cmbCaraBayar.Name = "cmbCaraBayar"
        Me.cmbCaraBayar.Size = New System.Drawing.Size(140, 21)
        Me.cmbCaraBayar.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Cara Bayar :"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(100, 209)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(217, 61)
        Me.txtKeterangan.TabIndex = 5
        Me.txtKeterangan.Text = ""
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(103, 305)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 31)
        Me.btnSimpan.TabIndex = 6
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'lblGrand
        '
        Me.lblGrand.AutoSize = True
        Me.lblGrand.Location = New System.Drawing.Point(100, 283)
        Me.lblGrand.Name = "lblGrand"
        Me.lblGrand.Size = New System.Drawing.Size(66, 13)
        Me.lblGrand.TabIndex = 41
        Me.lblGrand.Text = "Total Biaya :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 283)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Total Biaya :"
        '
        'lblTagihan
        '
        Me.lblTagihan.AutoSize = True
        Me.lblTagihan.Location = New System.Drawing.Point(100, 56)
        Me.lblTagihan.Name = "lblTagihan"
        Me.lblTagihan.Size = New System.Drawing.Size(0, 13)
        Me.lblTagihan.TabIndex = 39
        '
        'lblSupp
        '
        Me.lblSupp.AutoSize = True
        Me.lblSupp.Location = New System.Drawing.Point(100, 80)
        Me.lblSupp.Name = "lblSupp"
        Me.lblSupp.Size = New System.Drawing.Size(0, 13)
        Me.lblSupp.TabIndex = 38
        '
        'btnCari
        '
        Me.btnCari.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCari.Location = New System.Drawing.Point(261, 56)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 31)
        Me.btnCari.TabIndex = 1
        Me.btnCari.Text = "&Cari"
        Me.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Keterangan :"
        '
        'lblBiaya
        '
        Me.lblBiaya.AutoSize = True
        Me.lblBiaya.Location = New System.Drawing.Point(102, 103)
        Me.lblBiaya.Name = "lblBiaya"
        Me.lblBiaya.Size = New System.Drawing.Size(0, 13)
        Me.lblBiaya.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(55, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Biaya :"
        '
        'txtPotongan
        '
        Me.txtPotongan.Location = New System.Drawing.Point(100, 149)
        Me.txtPotongan.Name = "txtPotongan"
        Me.txtPotongan.Size = New System.Drawing.Size(122, 20)
        Me.txtPotongan.TabIndex = 3
        Me.txtPotongan.Text = "0"
        '
        'txtTambahan
        '
        Me.txtTambahan.Location = New System.Drawing.Point(100, 123)
        Me.txtTambahan.Name = "txtTambahan"
        Me.txtTambahan.Size = New System.Drawing.Size(122, 20)
        Me.txtTambahan.TabIndex = 2
        Me.txtTambahan.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Potongan :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Tambahan :"
        '
        'LblValidator
        '
        Me.LblValidator.AutoSize = True
        Me.LblValidator.Location = New System.Drawing.Point(228, 55)
        Me.LblValidator.Name = "LblValidator"
        Me.LblValidator.Size = New System.Drawing.Size(0, 13)
        Me.LblValidator.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Supplier :"
        '
        'dtpTgl
        '
        Me.dtpTgl.CustomFormat = "dd-MMM-yyyy"
        Me.dtpTgl.Enabled = False
        Me.dtpTgl.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTgl.Location = New System.Drawing.Point(100, 28)
        Me.dtpTgl.Name = "dtpTgl"
        Me.dtpTgl.Size = New System.Drawing.Size(111, 20)
        Me.dtpTgl.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Tgl :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Kode Tagihan :"
        '
        'frmBayarTagihan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1111, 391)
        Me.Controls.Add(Me.pnlSupp)
        Me.Controls.Add(Me.dgvBM)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBayarTagihan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Transaksi Bayar Tagihan :."
        CType(Me.dgvBM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSupp.ResumeLayout(False)
        Me.pnlSupp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvBM As System.Windows.Forms.DataGridView
    Friend WithEvents pnlSupp As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpTgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblValidator As System.Windows.Forms.Label
    Friend WithEvents lblTagihan As System.Windows.Forms.Label
    Friend WithEvents lblSupp As System.Windows.Forms.Label
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblBiaya As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPotongan As System.Windows.Forms.TextBox
    Friend WithEvents txtTambahan As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SJ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Biaya As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tambahan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Potongan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents lblGrand As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbCaraBayar As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As System.Windows.Forms.RichTextBox
End Class
