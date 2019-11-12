<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetilSetOngkosSupplierBoronganUnit
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvSetOngkos = New System.Windows.Forms.DataGridView()
        Me.NAMABARANG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SATUAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JUMLAH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KODEBARANG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NODO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.lblJP = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblSupp = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblJK = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblNoPol = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblNoLambung = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTgl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblBM = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSJ = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblBorongan = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        CType(Me.dgvSetOngkos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSetOngkos
        '
        Me.dgvSetOngkos.AllowUserToAddRows = False
        Me.dgvSetOngkos.AllowUserToDeleteRows = False
        Me.dgvSetOngkos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSetOngkos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NAMABARANG, Me.SATUAN, Me.JUMLAH, Me.KODEBARANG, Me.NODO})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSetOngkos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSetOngkos.Location = New System.Drawing.Point(11, 244)
        Me.dgvSetOngkos.Name = "dgvSetOngkos"
        Me.dgvSetOngkos.ReadOnly = True
        Me.dgvSetOngkos.Size = New System.Drawing.Size(346, 208)
        Me.dgvSetOngkos.TabIndex = 10
        '
        'NAMABARANG
        '
        Me.NAMABARANG.DataPropertyName = "namabarang"
        Me.NAMABARANG.HeaderText = "Nama Barang"
        Me.NAMABARANG.Name = "NAMABARANG"
        Me.NAMABARANG.ReadOnly = True
        '
        'SATUAN
        '
        Me.SATUAN.DataPropertyName = "satuan"
        Me.SATUAN.HeaderText = "Satuan Unit"
        Me.SATUAN.Name = "SATUAN"
        Me.SATUAN.ReadOnly = True
        '
        'JUMLAH
        '
        Me.JUMLAH.DataPropertyName = "jumlah"
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.JUMLAH.DefaultCellStyle = DataGridViewCellStyle1
        Me.JUMLAH.HeaderText = "Jumlah Unit"
        Me.JUMLAH.Name = "JUMLAH"
        Me.JUMLAH.ReadOnly = True
        '
        'KODEBARANG
        '
        Me.KODEBARANG.DataPropertyName = "kodebarang"
        Me.KODEBARANG.HeaderText = "Kode Barang"
        Me.KODEBARANG.Name = "KODEBARANG"
        Me.KODEBARANG.ReadOnly = True
        Me.KODEBARANG.Visible = False
        '
        'NODO
        '
        Me.NODO.DataPropertyName = "nodo"
        Me.NODO.HeaderText = "No Do"
        Me.NODO.Name = "NODO"
        Me.NODO.ReadOnly = True
        Me.NODO.Visible = False
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(164, 542)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 31)
        Me.btnSimpan.TabIndex = 2
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'lblJP
        '
        Me.lblJP.AutoSize = True
        Me.lblJP.Location = New System.Drawing.Point(199, 210)
        Me.lblJP.Name = "lblJP"
        Me.lblJP.Size = New System.Drawing.Size(40, 13)
        Me.lblJP.TabIndex = 33
        Me.lblJP.Text = "No BM"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(107, 210)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Jenis Pekerjaan : "
        '
        'lblSupp
        '
        Me.lblSupp.AutoSize = True
        Me.lblSupp.Location = New System.Drawing.Point(199, 183)
        Me.lblSupp.Name = "lblSupp"
        Me.lblSupp.Size = New System.Drawing.Size(40, 13)
        Me.lblSupp.TabIndex = 31
        Me.lblSupp.Text = "No BM"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(144, 183)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Supplier : "
        '
        'lblJK
        '
        Me.lblJK.AutoSize = True
        Me.lblJK.Location = New System.Drawing.Point(199, 154)
        Me.lblJK.Name = "lblJK"
        Me.lblJK.Size = New System.Drawing.Size(40, 13)
        Me.lblJK.TabIndex = 29
        Me.lblJK.Text = "No BM"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(103, 154)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Jenis Kendaraan : "
        '
        'lblNoPol
        '
        Me.lblNoPol.AutoSize = True
        Me.lblNoPol.Location = New System.Drawing.Point(199, 123)
        Me.lblNoPol.Name = "lblNoPol"
        Me.lblNoPol.Size = New System.Drawing.Size(40, 13)
        Me.lblNoPol.TabIndex = 27
        Me.lblNoPol.Text = "No BM"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(141, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "No Polisi : "
        '
        'lblNoLambung
        '
        Me.lblNoLambung.AutoSize = True
        Me.lblNoLambung.Location = New System.Drawing.Point(199, 94)
        Me.lblNoLambung.Name = "lblNoLambung"
        Me.lblNoLambung.Size = New System.Drawing.Size(40, 13)
        Me.lblNoLambung.TabIndex = 25
        Me.lblNoLambung.Text = "No BM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(121, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "No Lambung : "
        '
        'lblTgl
        '
        Me.lblTgl.AutoSize = True
        Me.lblTgl.Location = New System.Drawing.Point(199, 67)
        Me.lblTgl.Name = "lblTgl"
        Me.lblTgl.Size = New System.Drawing.Size(40, 13)
        Me.lblTgl.TabIndex = 23
        Me.lblTgl.Text = "No BM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(149, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Tangal : "
        '
        'lblBM
        '
        Me.lblBM.AutoSize = True
        Me.lblBM.Location = New System.Drawing.Point(199, 40)
        Me.lblBM.Name = "lblBM"
        Me.lblBM.Size = New System.Drawing.Size(40, 13)
        Me.lblBM.TabIndex = 21
        Me.lblBM.Text = "No BM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(119, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "No Bon Muat : "
        '
        'lblSJ
        '
        Me.lblSJ.AutoSize = True
        Me.lblSJ.Location = New System.Drawing.Point(199, 9)
        Me.lblSJ.Name = "lblSJ"
        Me.lblSJ.Size = New System.Drawing.Size(40, 13)
        Me.lblSJ.TabIndex = 19
        Me.lblSJ.Text = "No BM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "No Surat Jalan : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 466)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Total Jumlah Unit : "
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(253, 466)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(40, 13)
        Me.lblTotal.TabIndex = 35
        Me.lblTotal.Text = "No BM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(112, 492)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Harga Borongan Per Unit : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(126, 521)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Total Harga Borongan : "
        '
        'lblBorongan
        '
        Me.lblBorongan.AutoSize = True
        Me.lblBorongan.Location = New System.Drawing.Point(253, 521)
        Me.lblBorongan.Name = "lblBorongan"
        Me.lblBorongan.Size = New System.Drawing.Size(13, 13)
        Me.lblBorongan.TabIndex = 39
        Me.lblBorongan.Text = "0"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(253, 489)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(100, 20)
        Me.txtHarga.TabIndex = 1
        Me.txtHarga.Text = "0"
        '
        'btnBatal
        '
        Me.btnBatal.Image = Global.RukunJaya.My.Resources.Resources.cancelbr
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(253, 542)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 31)
        Me.btnBatal.TabIndex = 53
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'frmDetilSetOngkosSupplierBoronganUnit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 598)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.lblBorongan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblJP)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblSupp)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblJK)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblNoPol)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblNoLambung)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTgl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblBM)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSJ)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.dgvSetOngkos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetilSetOngkosSupplierBoronganUnit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Detil Set Ongkos Borongan Unit :."
        CType(Me.dgvSetOngkos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSetOngkos As System.Windows.Forms.DataGridView
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents lblJP As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblSupp As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblJK As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblNoPol As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblNoLambung As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTgl As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblBM As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSJ As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblBorongan As System.Windows.Forms.Label
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents NAMABARANG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SATUAN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JUMLAH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KODEBARANG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NODO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnBatal As System.Windows.Forms.Button
End Class
