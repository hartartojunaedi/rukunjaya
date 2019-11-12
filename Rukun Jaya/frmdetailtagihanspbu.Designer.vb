<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdetailtagihanspbu
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtnotagihan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtptgl = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnonota = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvdetail = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblmode = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblkasbon = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblgrandtotal = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbltotalliter = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtketerangan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txthargaperliter = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.lblrupiah = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cbspbu = New System.Windows.Forms.ComboBox()
        Me.cbbank = New System.Windows.Forms.ComboBox()
        Me.kodevoucher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoBM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuratJalan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.liter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sisa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tagih = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rupiahsatuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rupiah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglVoucher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kasbon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnotagihan
        '
        Me.txtnotagihan.Location = New System.Drawing.Point(102, 43)
        Me.txtnotagihan.Name = "txtnotagihan"
        Me.txtnotagihan.Size = New System.Drawing.Size(150, 20)
        Me.txtnotagihan.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "No. tagihan"
        '
        'dtptgl
        '
        Me.dtptgl.CustomFormat = "dd-MM-yyyy"
        Me.dtptgl.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptgl.Location = New System.Drawing.Point(527, 44)
        Me.dtptgl.Name = "dtptgl"
        Me.dtptgl.Size = New System.Drawing.Size(108, 20)
        Me.dtptgl.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(511, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(461, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "SPBU"
        '
        'txtnonota
        '
        Me.txtnonota.Location = New System.Drawing.Point(102, 96)
        Me.txtnonota.Name = "txtnonota"
        Me.txtnonota.Size = New System.Drawing.Size(135, 20)
        Me.txtnonota.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(85, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "No. Nota"
        '
        'dgvdetail
        '
        Me.dgvdetail.AllowUserToAddRows = False
        Me.dgvdetail.AllowUserToDeleteRows = False
        Me.dgvdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodevoucher, Me.NoBM, Me.SuratJalan, Me.liter, Me.Sisa, Me.tagih, Me.rupiahsatuan, Me.Rupiah, Me.TglVoucher, Me.Kasbon})
        Me.dgvdetail.Location = New System.Drawing.Point(15, 179)
        Me.dgvdetail.Name = "dgvdetail"
        Me.dgvdetail.Size = New System.Drawing.Size(793, 322)
        Me.dgvdetail.TabIndex = 44
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(711, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(675, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Mode "
        '
        'lblmode
        '
        Me.lblmode.AutoSize = True
        Me.lblmode.Location = New System.Drawing.Point(727, 9)
        Me.lblmode.Name = "lblmode"
        Me.lblmode.Size = New System.Drawing.Size(62, 13)
        Me.lblmode.TabIndex = 47
        Me.lblmode.Text = "No. tagihan"
        '
        'Button2
        '
        Me.Button2.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(12, 507)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 29)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "&Simpan"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblkasbon
        '
        Me.lblkasbon.AutoSize = True
        Me.lblkasbon.Location = New System.Drawing.Point(575, 521)
        Me.lblkasbon.Name = "lblkasbon"
        Me.lblkasbon.Size = New System.Drawing.Size(62, 13)
        Me.lblkasbon.TabIndex = 53
        Me.lblkasbon.Text = "No. tagihan"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(503, 521)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 13)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Total Kasbon :"
        '
        'lblgrandtotal
        '
        Me.lblgrandtotal.AutoSize = True
        Me.lblgrandtotal.Location = New System.Drawing.Point(718, 521)
        Me.lblgrandtotal.Name = "lblgrandtotal"
        Me.lblgrandtotal.Size = New System.Drawing.Size(62, 13)
        Me.lblgrandtotal.TabIndex = 55
        Me.lblgrandtotal.Text = "No. tagihan"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(653, 521)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 13)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "Grand Total :"
        '
        'lbltotalliter
        '
        Me.lbltotalliter.AutoSize = True
        Me.lbltotalliter.Location = New System.Drawing.Point(280, 521)
        Me.lbltotalliter.Name = "lbltotalliter"
        Me.lbltotalliter.Size = New System.Drawing.Size(62, 13)
        Me.lbltotalliter.TabIndex = 57
        Me.lbltotalliter.Text = "No. tagihan"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(217, 521)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 13)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "Total liter :"
        '
        'txtketerangan
        '
        Me.txtketerangan.Location = New System.Drawing.Point(102, 122)
        Me.txtketerangan.Multiline = True
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.Size = New System.Drawing.Size(281, 51)
        Me.txtketerangan.TabIndex = 61
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(84, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = ":"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(25, 125)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 13)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "Keterangan"
        '
        'txthargaperliter
        '
        Me.txthargaperliter.Location = New System.Drawing.Point(527, 97)
        Me.txthargaperliter.Name = "txthargaperliter"
        Me.txthargaperliter.Size = New System.Drawing.Size(108, 20)
        Me.txthargaperliter.TabIndex = 64
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(513, 100)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(10, 13)
        Me.Label27.TabIndex = 63
        Me.Label27.Text = ":"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(449, 100)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(57, 13)
        Me.Label28.TabIndex = 62
        Me.Label28.Text = "Harga/liter"
        '
        'lblrupiah
        '
        Me.lblrupiah.AutoSize = True
        Me.lblrupiah.Location = New System.Drawing.Point(425, 521)
        Me.lblrupiah.Name = "lblrupiah"
        Me.lblrupiah.Size = New System.Drawing.Size(62, 13)
        Me.lblrupiah.TabIndex = 66
        Me.lblrupiah.Text = "No. tagihan"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(362, 521)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(66, 13)
        Me.Label30.TabIndex = 65
        Me.Label30.Text = "Total pakai :"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(513, 77)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(10, 13)
        Me.Label29.TabIndex = 69
        Me.Label29.Text = ":"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(475, 78)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(32, 13)
        Me.Label31.TabIndex = 68
        Me.Label31.Text = "Bank"
        '
        'cbspbu
        '
        Me.cbspbu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbspbu.FormattingEnabled = True
        Me.cbspbu.Location = New System.Drawing.Point(102, 68)
        Me.cbspbu.Name = "cbspbu"
        Me.cbspbu.Size = New System.Drawing.Size(257, 21)
        Me.cbspbu.TabIndex = 70
        '
        'cbbank
        '
        Me.cbbank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbank.FormattingEnabled = True
        Me.cbbank.Location = New System.Drawing.Point(527, 70)
        Me.cbbank.Name = "cbbank"
        Me.cbbank.Size = New System.Drawing.Size(162, 21)
        Me.cbbank.TabIndex = 71
        '
        'kodevoucher
        '
        Me.kodevoucher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.kodevoucher.DataPropertyName = "kodevoucher"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.kodevoucher.DefaultCellStyle = DataGridViewCellStyle1
        Me.kodevoucher.HeaderText = "Voucher"
        Me.kodevoucher.Name = "kodevoucher"
        Me.kodevoucher.ReadOnly = True
        Me.kodevoucher.Width = 72
        '
        'NoBM
        '
        Me.NoBM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NoBM.DataPropertyName = "nobm"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NoBM.DefaultCellStyle = DataGridViewCellStyle2
        Me.NoBM.HeaderText = "BM"
        Me.NoBM.Name = "NoBM"
        Me.NoBM.ReadOnly = True
        Me.NoBM.Width = 48
        '
        'SuratJalan
        '
        Me.SuratJalan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.SuratJalan.DataPropertyName = "nosuratjalan"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SuratJalan.DefaultCellStyle = DataGridViewCellStyle3
        Me.SuratJalan.HeaderText = "No. SJ"
        Me.SuratJalan.Name = "SuratJalan"
        Me.SuratJalan.ReadOnly = True
        Me.SuratJalan.Width = 64
        '
        'liter
        '
        Me.liter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.liter.DataPropertyName = "liter"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Format = "N2"
        Me.liter.DefaultCellStyle = DataGridViewCellStyle4
        Me.liter.HeaderText = "Liter"
        Me.liter.Name = "liter"
        Me.liter.ReadOnly = True
        Me.liter.Width = 52
        '
        'Sisa
        '
        Me.Sisa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Sisa.DataPropertyName = "sisa"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.Format = "N2"
        Me.Sisa.DefaultCellStyle = DataGridViewCellStyle5
        Me.Sisa.HeaderText = "sisa"
        Me.Sisa.Name = "Sisa"
        Me.Sisa.ReadOnly = True
        Me.Sisa.Width = 50
        '
        'tagih
        '
        Me.tagih.DataPropertyName = "tagih"
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.tagih.DefaultCellStyle = DataGridViewCellStyle6
        Me.tagih.HeaderText = "Tagih"
        Me.tagih.Name = "tagih"
        '
        'rupiahsatuan
        '
        Me.rupiahsatuan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.rupiahsatuan.DataPropertyName = "rupiahsatuan"
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = Nothing
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.rupiahsatuan.DefaultCellStyle = DataGridViewCellStyle7
        Me.rupiahsatuan.HeaderText = "Harga/liter"
        Me.rupiahsatuan.Name = "rupiahsatuan"
        Me.rupiahsatuan.ReadOnly = True
        Me.rupiahsatuan.Visible = False
        Me.rupiahsatuan.Width = 82
        '
        'Rupiah
        '
        Me.Rupiah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Rupiah.DataPropertyName = "rupiah"
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle8.Format = "N0"
        DataGridViewCellStyle8.NullValue = Nothing
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Rupiah.DefaultCellStyle = DataGridViewCellStyle8
        Me.Rupiah.HeaderText = "Grand Total"
        Me.Rupiah.Name = "Rupiah"
        Me.Rupiah.ReadOnly = True
        Me.Rupiah.Width = 88
        '
        'TglVoucher
        '
        Me.TglVoucher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.TglVoucher.DataPropertyName = "tglvoucher"
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TglVoucher.DefaultCellStyle = DataGridViewCellStyle9
        Me.TglVoucher.HeaderText = "Tgl Voucher"
        Me.TglVoucher.Name = "TglVoucher"
        Me.TglVoucher.ReadOnly = True
        Me.TglVoucher.Width = 90
        '
        'Kasbon
        '
        Me.Kasbon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Kasbon.DataPropertyName = "kasbon"
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle10.Format = "N0"
        Me.Kasbon.DefaultCellStyle = DataGridViewCellStyle10
        Me.Kasbon.HeaderText = "Kasbon"
        Me.Kasbon.Name = "Kasbon"
        Me.Kasbon.ReadOnly = True
        Me.Kasbon.Width = 68
        '
        'frmdetailtagihanspbu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 543)
        Me.Controls.Add(Me.cbbank)
        Me.Controls.Add(Me.cbspbu)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.lblrupiah)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.txthargaperliter)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtketerangan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lbltotalliter)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblgrandtotal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblkasbon)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblmode)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dgvdetail)
        Me.Controls.Add(Me.txtnonota)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnotagihan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtptgl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmdetailtagihanspbu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Detail Tagihan SPBU :."
        CType(Me.dgvdetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnotagihan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtptgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtnonota As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dgvdetail As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblmode As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblkasbon As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblgrandtotal As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbltotalliter As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtketerangan As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txthargaperliter As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lblrupiah As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents cbspbu As System.Windows.Forms.ComboBox
    Friend WithEvents cbbank As System.Windows.Forms.ComboBox
    Friend WithEvents kodevoucher As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoBM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SuratJalan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents liter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sisa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tagih As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rupiahsatuan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rupiah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TglVoucher As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kasbon As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
