<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStokBarang
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtkodesparepart = New System.Windows.Forms.TextBox()
        Me.txtnamasparepart = New System.Windows.Forms.TextBox()
        Me.txtkartustok = New System.Windows.Forms.TextBox()
        Me.btncari = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbljumlahdata = New System.Windows.Forms.Label()
        Me.kodesparepart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namasparepart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kartustok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(571, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kartu Stok"
        '
        'txtkodesparepart
        '
        Me.txtkodesparepart.Location = New System.Drawing.Point(75, 13)
        Me.txtkodesparepart.Name = "txtkodesparepart"
        Me.txtkodesparepart.Size = New System.Drawing.Size(100, 20)
        Me.txtkodesparepart.TabIndex = 3
        '
        'txtnamasparepart
        '
        Me.txtnamasparepart.Location = New System.Drawing.Point(292, 13)
        Me.txtnamasparepart.Name = "txtnamasparepart"
        Me.txtnamasparepart.Size = New System.Drawing.Size(241, 20)
        Me.txtnamasparepart.TabIndex = 4
        '
        'txtkartustok
        '
        Me.txtkartustok.Location = New System.Drawing.Point(634, 10)
        Me.txtkartustok.Name = "txtkartustok"
        Me.txtkartustok.Size = New System.Drawing.Size(100, 20)
        Me.txtkartustok.TabIndex = 5
        '
        'btncari
        '
        Me.btncari.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btncari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncari.Location = New System.Drawing.Point(761, 8)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(80, 29)
        Me.btncari.TabIndex = 6
        Me.btncari.Text = "&Filter"
        Me.btncari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncari.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodesparepart, Me.namasparepart, Me.Kartustok, Me.stock, Me.Keterangan})
        Me.DataGridView1.Location = New System.Drawing.Point(28, 43)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(844, 260)
        Me.DataGridView1.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 310)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "&Cetak"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(682, 315)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Jumlah Data : "
        '
        'lbljumlahdata
        '
        Me.lbljumlahdata.AutoSize = True
        Me.lbljumlahdata.Location = New System.Drawing.Point(814, 315)
        Me.lbljumlahdata.Name = "lbljumlahdata"
        Me.lbljumlahdata.Size = New System.Drawing.Size(13, 13)
        Me.lbljumlahdata.TabIndex = 10
        Me.lbljumlahdata.Text = "0"
        '
        'kodesparepart
        '
        Me.kodesparepart.DataPropertyName = "kodesparepart"
        Me.kodesparepart.HeaderText = "Kode"
        Me.kodesparepart.Name = "kodesparepart"
        '
        'namasparepart
        '
        Me.namasparepart.DataPropertyName = "namasparepart"
        Me.namasparepart.HeaderText = "Nama Spare Part"
        Me.namasparepart.Name = "namasparepart"
        Me.namasparepart.Width = 250
        '
        'Kartustok
        '
        Me.Kartustok.DataPropertyName = "kartustok"
        Me.Kartustok.HeaderText = "Kartu Stok"
        Me.Kartustok.Name = "Kartustok"
        '
        'stock
        '
        Me.stock.DataPropertyName = "stock"
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.stock.DefaultCellStyle = DataGridViewCellStyle5
        Me.stock.HeaderText = "Jumlah"
        Me.stock.Name = "stock"
        Me.stock.ReadOnly = True
        '
        'Keterangan
        '
        Me.Keterangan.DataPropertyName = "keterangan"
        Me.Keterangan.HeaderText = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        '
        'frmStokBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 350)
        Me.Controls.Add(Me.lbljumlahdata)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.txtkartustok)
        Me.Controls.Add(Me.txtnamasparepart)
        Me.Controls.Add(Me.txtkodesparepart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStokBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Stok Barang :."
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtkodesparepart As System.Windows.Forms.TextBox
    Friend WithEvents txtnamasparepart As System.Windows.Forms.TextBox
    Friend WithEvents txtkartustok As System.Windows.Forms.TextBox
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbljumlahdata As System.Windows.Forms.Label
    Friend WithEvents kodesparepart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namasparepart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kartustok As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
