<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUbahHarga
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
        Me.lbljumlahdata = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btncari = New System.Windows.Forms.Button()
        Me.txtkartustok = New System.Windows.Forms.TextBox()
        Me.txtnamasparepart = New System.Windows.Forms.TextBox()
        Me.txtkodesparepart = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.kodesparepart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namasparepart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kartustok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hargaterakhir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ubahharga = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbljumlahdata
        '
        Me.lbljumlahdata.AutoSize = True
        Me.lbljumlahdata.Location = New System.Drawing.Point(796, 314)
        Me.lbljumlahdata.Name = "lbljumlahdata"
        Me.lbljumlahdata.Size = New System.Drawing.Size(13, 13)
        Me.lbljumlahdata.TabIndex = 21
        Me.lbljumlahdata.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(664, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Jumlah Data : "
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodesparepart, Me.namasparepart, Me.Kartustok, Me.hargaterakhir, Me.stock, Me.Keterangan, Me.ubahharga})
        Me.DataGridView1.Location = New System.Drawing.Point(10, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(931, 260)
        Me.DataGridView1.TabIndex = 18
        '
        'btncari
        '
        Me.btncari.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btncari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncari.Location = New System.Drawing.Point(743, 7)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(80, 29)
        Me.btncari.TabIndex = 17
        Me.btncari.Text = "&Filter"
        Me.btncari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncari.UseVisualStyleBackColor = True
        '
        'txtkartustok
        '
        Me.txtkartustok.Location = New System.Drawing.Point(616, 9)
        Me.txtkartustok.Name = "txtkartustok"
        Me.txtkartustok.Size = New System.Drawing.Size(100, 20)
        Me.txtkartustok.TabIndex = 16
        '
        'txtnamasparepart
        '
        Me.txtnamasparepart.Location = New System.Drawing.Point(274, 12)
        Me.txtnamasparepart.Name = "txtnamasparepart"
        Me.txtnamasparepart.Size = New System.Drawing.Size(241, 20)
        Me.txtnamasparepart.TabIndex = 15
        '
        'txtkodesparepart
        '
        Me.txtkodesparepart.Location = New System.Drawing.Point(57, 12)
        Me.txtkodesparepart.Name = "txtkodesparepart"
        Me.txtkodesparepart.Size = New System.Drawing.Size(100, 20)
        Me.txtkodesparepart.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(553, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Kartu Stok"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(233, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Kode"
        '
        'kodesparepart
        '
        Me.kodesparepart.DataPropertyName = "kodesparepart"
        Me.kodesparepart.HeaderText = "Kode"
        Me.kodesparepart.Name = "kodesparepart"
        Me.kodesparepart.ReadOnly = True
        '
        'namasparepart
        '
        Me.namasparepart.DataPropertyName = "namasparepart"
        Me.namasparepart.HeaderText = "Nama Spare Part"
        Me.namasparepart.Name = "namasparepart"
        Me.namasparepart.ReadOnly = True
        Me.namasparepart.Width = 250
        '
        'Kartustok
        '
        Me.Kartustok.DataPropertyName = "kartustok"
        Me.Kartustok.HeaderText = "Kartu Stok"
        Me.Kartustok.Name = "Kartustok"
        Me.Kartustok.ReadOnly = True
        '
        'hargaterakhir
        '
        Me.hargaterakhir.DataPropertyName = "hargaterakhir"
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = "0"
        Me.hargaterakhir.DefaultCellStyle = DataGridViewCellStyle1
        Me.hargaterakhir.HeaderText = "Harga"
        Me.hargaterakhir.Name = "hargaterakhir"
        Me.hargaterakhir.ReadOnly = True
        '
        'stock
        '
        Me.stock.DataPropertyName = "stock"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.stock.DefaultCellStyle = DataGridViewCellStyle2
        Me.stock.HeaderText = "Jumlah"
        Me.stock.Name = "stock"
        Me.stock.ReadOnly = True
        '
        'Keterangan
        '
        Me.Keterangan.DataPropertyName = "keterangan"
        Me.Keterangan.HeaderText = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.ReadOnly = True
        '
        'ubahharga
        '
        Me.ubahharga.HeaderText = "Ubah Harga"
        Me.ubahharga.Name = "ubahharga"
        Me.ubahharga.ReadOnly = True
        '
        'frmUbahHarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 336)
        Me.Controls.Add(Me.lbljumlahdata)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.txtkartustok)
        Me.Controls.Add(Me.txtnamasparepart)
        Me.Controls.Add(Me.txtkodesparepart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUbahHarga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Ubah Harga :."
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbljumlahdata As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents txtkartustok As System.Windows.Forms.TextBox
    Friend WithEvents txtnamasparepart As System.Windows.Forms.TextBox
    Friend WithEvents txtkodesparepart As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents kodesparepart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namasparepart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kartustok As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hargaterakhir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ubahharga As System.Windows.Forms.DataGridViewButtonColumn
End Class
