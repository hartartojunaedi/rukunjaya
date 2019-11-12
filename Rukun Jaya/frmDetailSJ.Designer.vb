<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailSJ
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblKodeSJ = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSupp = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPerwakilan = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAsal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTujuan = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblKodeBM = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTglSJ = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTglDatang = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblTglMuat = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblTglBongkar = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblPekerjaan = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblBonLain = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblBon = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblSangu = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblBoronganSopir = New System.Windows.Forms.Label()
        Me.barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.noDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.shippinglist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kodeVoucher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.spbu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.liter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rupiahLiter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kasbon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detail = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Kode Surat Jalan :"
        '
        'lblKodeSJ
        '
        Me.lblKodeSJ.AutoSize = True
        Me.lblKodeSJ.Location = New System.Drawing.Point(120, 35)
        Me.lblKodeSJ.Name = "lblKodeSJ"
        Me.lblKodeSJ.Size = New System.Drawing.Size(31, 13)
        Me.lblKodeSJ.TabIndex = 5
        Me.lblKodeSJ.Text = "kode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Data Surat Jalan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Kode Bon Muat :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Supplier :"
        '
        'lblSupp
        '
        Me.lblSupp.AutoSize = True
        Me.lblSupp.Location = New System.Drawing.Point(120, 81)
        Me.lblSupp.Name = "lblSupp"
        Me.lblSupp.Size = New System.Drawing.Size(30, 13)
        Me.lblSupp.TabIndex = 9
        Me.lblSupp.Text = "supp"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Perwakilan :"
        '
        'lblPerwakilan
        '
        Me.lblPerwakilan.AutoSize = True
        Me.lblPerwakilan.Location = New System.Drawing.Point(120, 105)
        Me.lblPerwakilan.Name = "lblPerwakilan"
        Me.lblPerwakilan.Size = New System.Drawing.Size(58, 13)
        Me.lblPerwakilan.TabIndex = 11
        Me.lblPerwakilan.Text = "perwakilan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(81, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Asal :"
        '
        'lblAsal
        '
        Me.lblAsal.AutoSize = True
        Me.lblAsal.Location = New System.Drawing.Point(120, 127)
        Me.lblAsal.Name = "lblAsal"
        Me.lblAsal.Size = New System.Drawing.Size(26, 13)
        Me.lblAsal.TabIndex = 13
        Me.lblAsal.Text = "asal"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(68, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Tujuan :"
        '
        'lblTujuan
        '
        Me.lblTujuan.AutoSize = True
        Me.lblTujuan.Location = New System.Drawing.Point(120, 150)
        Me.lblTujuan.Name = "lblTujuan"
        Me.lblTujuan.Size = New System.Drawing.Size(36, 13)
        Me.lblTujuan.TabIndex = 15
        Me.lblTujuan.Text = "tujuan"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodeVoucher, Me.spbu, Me.liter, Me.rupiahLiter, Me.subTotal, Me.kasbon, Me.detail})
        Me.DataGridView1.Location = New System.Drawing.Point(15, 393)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(776, 228)
        Me.DataGridView1.TabIndex = 18
        '
        'lblKodeBM
        '
        Me.lblKodeBM.AutoSize = True
        Me.lblKodeBM.Location = New System.Drawing.Point(120, 58)
        Me.lblKodeBM.Name = "lblKodeBM"
        Me.lblKodeBM.Size = New System.Drawing.Size(47, 13)
        Me.lblKodeBM.TabIndex = 19
        Me.lblKodeBM.TabStop = True
        Me.lblKodeBM.Text = "kodeBM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Tanggal Surat Jalan :"
        '
        'lblTglSJ
        '
        Me.lblTglSJ.AutoSize = True
        Me.lblTglSJ.Location = New System.Drawing.Point(121, 172)
        Me.lblTglSJ.Name = "lblTglSJ"
        Me.lblTglSJ.Size = New System.Drawing.Size(30, 13)
        Me.lblTglSJ.TabIndex = 20
        Me.lblTglSJ.Text = "tglSJ"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 195)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Tanggal Datang :"
        '
        'lblTglDatang
        '
        Me.lblTglDatang.AutoSize = True
        Me.lblTglDatang.Location = New System.Drawing.Point(120, 195)
        Me.lblTglDatang.Name = "lblTglDatang"
        Me.lblTglDatang.Size = New System.Drawing.Size(53, 13)
        Me.lblTglDatang.TabIndex = 22
        Me.lblTglDatang.Text = "tglDatang"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(35, 217)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Tanggal Muat :"
        '
        'lblTglMuat
        '
        Me.lblTglMuat.AutoSize = True
        Me.lblTglMuat.Location = New System.Drawing.Point(120, 217)
        Me.lblTglMuat.Name = "lblTglMuat"
        Me.lblTglMuat.Size = New System.Drawing.Size(42, 13)
        Me.lblTglMuat.TabIndex = 24
        Me.lblTglMuat.Text = "tglMuat"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(19, 240)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Tanggal Bongkar :"
        '
        'lblTglBongkar
        '
        Me.lblTglBongkar.AutoSize = True
        Me.lblTglBongkar.Location = New System.Drawing.Point(120, 240)
        Me.lblTglBongkar.Name = "lblTglBongkar"
        Me.lblTglBongkar.Size = New System.Drawing.Size(58, 13)
        Me.lblTglBongkar.TabIndex = 26
        Me.lblTglBongkar.Text = "tglBongkar"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.barang, Me.jumlah, Me.noDO, Me.shippinglist})
        Me.DataGridView2.Location = New System.Drawing.Point(218, 35)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(573, 335)
        Me.DataGridView2.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Jenis Pekerjaan :"
        '
        'lblPekerjaan
        '
        Me.lblPekerjaan.AutoSize = True
        Me.lblPekerjaan.Location = New System.Drawing.Point(120, 264)
        Me.lblPekerjaan.Name = "lblPekerjaan"
        Me.lblPekerjaan.Size = New System.Drawing.Size(54, 13)
        Me.lblPekerjaan.TabIndex = 29
        Me.lblPekerjaan.Text = "pekerjaan"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(58, 312)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 13)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Bon Lain :"
        '
        'lblBonLain
        '
        Me.lblBonLain.Location = New System.Drawing.Point(151, 312)
        Me.lblBonLain.Name = "lblBonLain"
        Me.lblBonLain.Size = New System.Drawing.Size(44, 13)
        Me.lblBonLain.TabIndex = 33
        Me.lblBonLain.Text = "bon lain"
        Me.lblBonLain.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(81, 288)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 13)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Bon :"
        '
        'lblBon
        '
        Me.lblBon.Location = New System.Drawing.Point(170, 288)
        Me.lblBon.Name = "lblBon"
        Me.lblBon.Size = New System.Drawing.Size(25, 13)
        Me.lblBon.TabIndex = 31
        Me.lblBon.Text = "bon"
        Me.lblBon.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(68, 334)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 13)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "Sangu :"
        '
        'lblSangu
        '
        Me.lblSangu.Location = New System.Drawing.Point(159, 334)
        Me.lblSangu.Name = "lblSangu"
        Me.lblSangu.Size = New System.Drawing.Size(36, 13)
        Me.lblSangu.TabIndex = 35
        Me.lblSangu.Text = "sangu"
        Me.lblSangu.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 357)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 13)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Borongan Sopir :"
        '
        'lblBoronganSopir
        '
        Me.lblBoronganSopir.Location = New System.Drawing.Point(121, 357)
        Me.lblBoronganSopir.Name = "lblBoronganSopir"
        Me.lblBoronganSopir.Size = New System.Drawing.Size(74, 13)
        Me.lblBoronganSopir.TabIndex = 37
        Me.lblBoronganSopir.Text = "borongansupir"
        Me.lblBoronganSopir.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'barang
        '
        Me.barang.DataPropertyName = "NamaBarang"
        Me.barang.HeaderText = "Nama Barang"
        Me.barang.Name = "barang"
        Me.barang.ReadOnly = True
        '
        'jumlah
        '
        Me.jumlah.DataPropertyName = "jumlah"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Format = "N0"
        Me.jumlah.DefaultCellStyle = DataGridViewCellStyle5
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.ReadOnly = True
        '
        'noDO
        '
        Me.noDO.DataPropertyName = "noDO"
        Me.noDO.HeaderText = "No DO"
        Me.noDO.Name = "noDO"
        Me.noDO.ReadOnly = True
        '
        'shippinglist
        '
        Me.shippinglist.DataPropertyName = "noShippingList"
        Me.shippinglist.HeaderText = "No Shipping List"
        Me.shippinglist.Name = "shippinglist"
        Me.shippinglist.ReadOnly = True
        '
        'kodeVoucher
        '
        Me.kodeVoucher.DataPropertyName = "kodevoucher"
        Me.kodeVoucher.HeaderText = "Kode Voucher"
        Me.kodeVoucher.Name = "kodeVoucher"
        Me.kodeVoucher.ReadOnly = True
        '
        'spbu
        '
        Me.spbu.DataPropertyName = "namaspbu"
        Me.spbu.HeaderText = "SPBU"
        Me.spbu.Name = "spbu"
        Me.spbu.ReadOnly = True
        '
        'liter
        '
        Me.liter.DataPropertyName = "liter"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.liter.DefaultCellStyle = DataGridViewCellStyle1
        Me.liter.HeaderText = "liter"
        Me.liter.Name = "liter"
        Me.liter.ReadOnly = True
        '
        'rupiahLiter
        '
        Me.rupiahLiter.DataPropertyName = "rupiahsatuan"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "n0"
        Me.rupiahLiter.DefaultCellStyle = DataGridViewCellStyle2
        Me.rupiahLiter.HeaderText = "Rupiah/Liter"
        Me.rupiahLiter.Name = "rupiahLiter"
        Me.rupiahLiter.ReadOnly = True
        '
        'subTotal
        '
        Me.subTotal.DataPropertyName = "rupiah"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "n0"
        Me.subTotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.subTotal.HeaderText = "Sub Total"
        Me.subTotal.Name = "subTotal"
        Me.subTotal.ReadOnly = True
        '
        'kasbon
        '
        Me.kasbon.DataPropertyName = "kasbon"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "n0"
        Me.kasbon.DefaultCellStyle = DataGridViewCellStyle4
        Me.kasbon.HeaderText = "KasBon"
        Me.kasbon.Name = "kasbon"
        Me.kasbon.ReadOnly = True
        '
        'detail
        '
        Me.detail.HeaderText = "Detail"
        Me.detail.Name = "detail"
        Me.detail.ReadOnly = True
        Me.detail.Text = "Detail"
        Me.detail.UseColumnTextForButtonValue = True
        '
        'frmDetailSJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 633)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblBoronganSopir)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lblSangu)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblBonLain)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblBon)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblPekerjaan)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblTglBongkar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblTglMuat)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblTglDatang)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTglSJ)
        Me.Controls.Add(Me.lblKodeBM)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblTujuan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblAsal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblPerwakilan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblSupp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblKodeSJ)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetailSJ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Detail Surat Jalan :."
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblKodeSJ As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSupp As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblPerwakilan As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblAsal As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblTujuan As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblKodeBM As System.Windows.Forms.LinkLabel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTglSJ As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblTglDatang As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblTglMuat As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblTglBongkar As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblPekerjaan As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblBonLain As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblBon As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblSangu As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblBoronganSopir As System.Windows.Forms.Label
    Friend WithEvents kodeVoucher As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents spbu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents liter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rupiahLiter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kasbon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents detail As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents barang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents noDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents shippinglist As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
