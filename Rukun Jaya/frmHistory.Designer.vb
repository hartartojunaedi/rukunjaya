<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistory
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtTglAwal = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtTglAkhir = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbTransaksi = New System.Windows.Forms.ComboBox()
        Me.cbTipe = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tgl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kodetrans = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipetrans = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.act = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(195, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Periode : "
        '
        'dtTglAwal
        '
        Me.dtTglAwal.CustomFormat = "dd-MM-yyyy"
        Me.dtTglAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTglAwal.Location = New System.Drawing.Point(253, 13)
        Me.dtTglAwal.Name = "dtTglAwal"
        Me.dtTglAwal.Size = New System.Drawing.Size(91, 20)
        Me.dtTglAwal.TabIndex = 1
        Me.dtTglAwal.Value = New Date(2014, 10, 14, 0, 1, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(351, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "s/d"
        '
        'dtTglAkhir
        '
        Me.dtTglAkhir.CustomFormat = "dd-MM-yyyy"
        Me.dtTglAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTglAkhir.Location = New System.Drawing.Point(380, 13)
        Me.dtTglAkhir.Name = "dtTglAkhir"
        Me.dtTglAkhir.Size = New System.Drawing.Size(91, 20)
        Me.dtTglAkhir.TabIndex = 3
        Me.dtTglAkhir.Value = New Date(2014, 10, 14, 23, 59, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(185, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Transaksi : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(210, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tipe : "
        '
        'cbTransaksi
        '
        Me.cbTransaksi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTransaksi.FormattingEnabled = True
        Me.cbTransaksi.Items.AddRange(New Object() {"All", "Master Perusahaan", "Master Perwakilan", "Master Jenis Kendaraan", "Master Kendaraan", "Master Sopir", "Master Bank", "Master Inventory", "Master Maintance", "Master Operasional", "Master Gudang", "Master SPBU", "Master Supplier", "Master Barang", "Master Tarif", "-", "Transaksi Pembelian Sparepart ", "Transaksi Biaya Operasional", "Transaksi Kas Bon", "Transaksi Operational Kendaraan", "-", "Transaksi Uji Kir", "Transaksi Maintance", "Transaksi Catat Kilometer", "-", "Transaksi BM", "Transaksi Surat Jalan", "Transaksi LKuat", "Transaksi Set Ongkos", "Transaksi Setor Surat Jalan", "Transaksi Totalan Sopir", "-", "Tagihan SPBU", "Bayar Tagihan SPBU", "-", "Create User", "Set Hak Akses", "Parameter"})
        Me.cbTransaksi.Location = New System.Drawing.Point(253, 39)
        Me.cbTransaksi.Name = "cbTransaksi"
        Me.cbTransaksi.Size = New System.Drawing.Size(218, 21)
        Me.cbTransaksi.TabIndex = 6
        '
        'cbTipe
        '
        Me.cbTipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipe.FormattingEnabled = True
        Me.cbTipe.Items.AddRange(New Object() {"All", "Tambah", "Update", "Hapus"})
        Me.cbTipe.Location = New System.Drawing.Point(253, 69)
        Me.cbTipe.Name = "cbTipe"
        Me.cbTipe.Size = New System.Drawing.Size(218, 21)
        Me.cbTipe.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(312, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "&View"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tgl, Me.Kodetrans, Me.username, Me.tipetrans, Me.act})
        Me.DataGridView1.Location = New System.Drawing.Point(26, 134)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(673, 257)
        Me.DataGridView1.TabIndex = 9
        '
        'tgl
        '
        Me.tgl.DataPropertyName = "tgl"
        DataGridViewCellStyle1.Format = "dd-MM-yyyy HH:mm:ss"
        Me.tgl.DefaultCellStyle = DataGridViewCellStyle1
        Me.tgl.HeaderText = "Tanggal"
        Me.tgl.Name = "tgl"
        Me.tgl.ReadOnly = True
        Me.tgl.Width = 150
        '
        'Kodetrans
        '
        Me.Kodetrans.DataPropertyName = "kodetrans"
        Me.Kodetrans.HeaderText = "Kode Transaksi"
        Me.Kodetrans.Name = "Kodetrans"
        Me.Kodetrans.ReadOnly = True
        '
        'username
        '
        Me.username.DataPropertyName = "username"
        Me.username.HeaderText = "Username"
        Me.username.Name = "username"
        Me.username.ReadOnly = True
        '
        'tipetrans
        '
        Me.tipetrans.DataPropertyName = "tipetrans"
        Me.tipetrans.HeaderText = "Transaksi"
        Me.tipetrans.Name = "tipetrans"
        Me.tipetrans.ReadOnly = True
        Me.tipetrans.Width = 150
        '
        'act
        '
        Me.act.DataPropertyName = "act"
        Me.act.HeaderText = "Tipe"
        Me.act.Name = "act"
        Me.act.ReadOnly = True
        Me.act.Width = 120
        '
        'frmHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 403)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbTipe)
        Me.Controls.Add(Me.cbTransaksi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtTglAkhir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtTglAwal)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form History :."
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtTglAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtTglAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbTransaksi As System.Windows.Forms.ComboBox
    Friend WithEvents cbTipe As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents tgl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kodetrans As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents username As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipetrans As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents act As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
