<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmprintbonvoucher
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnosj = New System.Windows.Forms.TextBox()
        Me.btnlihat = New System.Windows.Forms.Button()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.dgvbon = New System.Windows.Forms.DataGridView()
        Me.KodeVoucher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaSPBU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.liter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rupiahsatuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rupiah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tglvoucher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namasopir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nopol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtnobm = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvbon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Surat Jalan :"
        '
        'txtnosj
        '
        Me.txtnosj.Location = New System.Drawing.Point(103, 36)
        Me.txtnosj.Name = "txtnosj"
        Me.txtnosj.Size = New System.Drawing.Size(110, 20)
        Me.txtnosj.TabIndex = 2
        '
        'btnlihat
        '
        Me.btnlihat.Location = New System.Drawing.Point(103, 62)
        Me.btnlihat.Name = "btnlihat"
        Me.btnlihat.Size = New System.Drawing.Size(75, 23)
        Me.btnlihat.TabIndex = 3
        Me.btnlihat.Text = "Lihat"
        Me.btnlihat.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(184, 62)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(75, 23)
        Me.btnprint.TabIndex = 4
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'dgvbon
        '
        Me.dgvbon.AllowUserToAddRows = False
        Me.dgvbon.AllowUserToDeleteRows = False
        Me.dgvbon.AllowUserToOrderColumns = True
        Me.dgvbon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeVoucher, Me.NamaSPBU, Me.liter, Me.rupiahsatuan, Me.rupiah, Me.tglvoucher, Me.namasopir, Me.nopol})
        Me.dgvbon.Location = New System.Drawing.Point(13, 91)
        Me.dgvbon.Name = "dgvbon"
        Me.dgvbon.ReadOnly = True
        Me.dgvbon.Size = New System.Drawing.Size(618, 167)
        Me.dgvbon.TabIndex = 4
        '
        'KodeVoucher
        '
        Me.KodeVoucher.DataPropertyName = "kodevoucher"
        Me.KodeVoucher.HeaderText = "Kode Voucher"
        Me.KodeVoucher.Name = "KodeVoucher"
        Me.KodeVoucher.ReadOnly = True
        Me.KodeVoucher.Width = 80
        '
        'NamaSPBU
        '
        Me.NamaSPBU.DataPropertyName = "NamaSPBU"
        Me.NamaSPBU.HeaderText = "SPBU"
        Me.NamaSPBU.Name = "NamaSPBU"
        Me.NamaSPBU.ReadOnly = True
        Me.NamaSPBU.Width = 90
        '
        'liter
        '
        Me.liter.DataPropertyName = "liter"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.liter.DefaultCellStyle = DataGridViewCellStyle1
        Me.liter.HeaderText = "liter"
        Me.liter.Name = "liter"
        Me.liter.ReadOnly = True
        Me.liter.Width = 50
        '
        'rupiahsatuan
        '
        Me.rupiahsatuan.DataPropertyName = "rupiahsatuan"
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = "0"
        Me.rupiahsatuan.DefaultCellStyle = DataGridViewCellStyle2
        Me.rupiahsatuan.HeaderText = "Harga/Liter"
        Me.rupiahsatuan.Name = "rupiahsatuan"
        Me.rupiahsatuan.ReadOnly = True
        Me.rupiahsatuan.Width = 65
        '
        'rupiah
        '
        Me.rupiah.DataPropertyName = "rupiah"
        DataGridViewCellStyle3.Format = "C0"
        DataGridViewCellStyle3.NullValue = "0"
        Me.rupiah.DefaultCellStyle = DataGridViewCellStyle3
        Me.rupiah.HeaderText = "Sub Total"
        Me.rupiah.Name = "rupiah"
        Me.rupiah.ReadOnly = True
        Me.rupiah.Width = 75
        '
        'tglvoucher
        '
        Me.tglvoucher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.tglvoucher.DataPropertyName = "tglvoucher"
        Me.tglvoucher.HeaderText = "Tanggal"
        Me.tglvoucher.Name = "tglvoucher"
        Me.tglvoucher.ReadOnly = True
        Me.tglvoucher.Width = 71
        '
        'namasopir
        '
        Me.namasopir.DataPropertyName = "namasopir"
        Me.namasopir.HeaderText = "Sopir"
        Me.namasopir.Name = "namasopir"
        Me.namasopir.ReadOnly = True
        Me.namasopir.Width = 70
        '
        'nopol
        '
        Me.nopol.DataPropertyName = "nopol"
        Me.nopol.HeaderText = "No. Polisi"
        Me.nopol.Name = "nopol"
        Me.nopol.ReadOnly = True
        Me.nopol.Width = 70
        '
        'txtnobm
        '
        Me.txtnobm.Location = New System.Drawing.Point(103, 12)
        Me.txtnobm.Name = "txtnobm"
        Me.txtnobm.Size = New System.Drawing.Size(110, 20)
        Me.txtnobm.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "No. BM :"
        '
        'frmprintbonvoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 261)
        Me.Controls.Add(Me.txtnobm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvbon)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btnlihat)
        Me.Controls.Add(Me.txtnosj)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmprintbonvoucher"
        Me.Text = ".: Print bon Voucher :."
        CType(Me.dgvbon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnosj As System.Windows.Forms.TextBox
    Friend WithEvents btnlihat As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents dgvbon As System.Windows.Forms.DataGridView
    Friend WithEvents txtnobm As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents KodeVoucher As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaSPBU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents liter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rupiahsatuan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rupiah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tglvoucher As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namasopir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nopol As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
