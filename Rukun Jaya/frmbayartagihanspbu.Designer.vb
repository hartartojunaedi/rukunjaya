<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbayartagihanspbu
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtptglawal = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtptglakhir = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnotagihan = New System.Windows.Forms.TextBox()
        Me.dgvtagihanspbu = New System.Windows.Forms.DataGridView()
        Me.notagihan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kodespbu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaSPBU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalliter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalrupiah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalbayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kasbontunai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grandtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bayar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.lbljumdata = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btncari = New System.Windows.Forms.Button()
        CType(Me.dgvtagihanspbu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(333, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Tanggal"
        '
        'dtptglawal
        '
        Me.dtptglawal.CustomFormat = "dd-MM-yyyy"
        Me.dtptglawal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptglawal.Location = New System.Drawing.Point(349, 12)
        Me.dtptglawal.Name = "dtptglawal"
        Me.dtptglawal.Size = New System.Drawing.Size(108, 20)
        Me.dtptglawal.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(475, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "s/d"
        '
        'dtptglakhir
        '
        Me.dtptglakhir.CustomFormat = "dd-MM-yyyy"
        Me.dtptglakhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptglakhir.Location = New System.Drawing.Point(517, 11)
        Me.dtptglakhir.Name = "dtptglakhir"
        Me.dtptglakhir.Size = New System.Drawing.Size(108, 20)
        Me.dtptglakhir.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(333, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(272, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "No. tagihan"
        '
        'txtnotagihan
        '
        Me.txtnotagihan.Location = New System.Drawing.Point(350, 40)
        Me.txtnotagihan.Name = "txtnotagihan"
        Me.txtnotagihan.Size = New System.Drawing.Size(100, 20)
        Me.txtnotagihan.TabIndex = 29
        '
        'dgvtagihanspbu
        '
        Me.dgvtagihanspbu.AllowUserToAddRows = False
        Me.dgvtagihanspbu.AllowUserToDeleteRows = False
        Me.dgvtagihanspbu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtagihanspbu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.notagihan, Me.kodespbu, Me.NamaSPBU, Me.tgl, Me.Nota, Me.totalliter, Me.totalrupiah, Me.totalbayar, Me.kasbontunai, Me.grandtotal, Me.status, Me.Bayar})
        Me.dgvtagihanspbu.Location = New System.Drawing.Point(12, 78)
        Me.dgvtagihanspbu.Name = "dgvtagihanspbu"
        Me.dgvtagihanspbu.ReadOnly = True
        Me.dgvtagihanspbu.Size = New System.Drawing.Size(750, 319)
        Me.dgvtagihanspbu.TabIndex = 31
        '
        'notagihan
        '
        Me.notagihan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.notagihan.DataPropertyName = "notagihan"
        Me.notagihan.HeaderText = "No. Tagihan"
        Me.notagihan.Name = "notagihan"
        Me.notagihan.ReadOnly = True
        Me.notagihan.Width = 91
        '
        'kodespbu
        '
        Me.kodespbu.DataPropertyName = "kodespbu"
        Me.kodespbu.HeaderText = "Column1"
        Me.kodespbu.Name = "kodespbu"
        Me.kodespbu.ReadOnly = True
        Me.kodespbu.Visible = False
        '
        'NamaSPBU
        '
        Me.NamaSPBU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NamaSPBU.DataPropertyName = "namaspbu"
        Me.NamaSPBU.HeaderText = "SPBU"
        Me.NamaSPBU.Name = "NamaSPBU"
        Me.NamaSPBU.ReadOnly = True
        Me.NamaSPBU.Width = 61
        '
        'tgl
        '
        Me.tgl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.tgl.DataPropertyName = "tgl"
        Me.tgl.HeaderText = "Tanggal"
        Me.tgl.Name = "tgl"
        Me.tgl.ReadOnly = True
        Me.tgl.Width = 71
        '
        'Nota
        '
        Me.Nota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Nota.DataPropertyName = "nota"
        Me.Nota.HeaderText = "Nota"
        Me.Nota.Name = "Nota"
        Me.Nota.ReadOnly = True
        Me.Nota.Width = 55
        '
        'totalliter
        '
        Me.totalliter.DataPropertyName = "totalliter"
        Me.totalliter.HeaderText = "Column1"
        Me.totalliter.Name = "totalliter"
        Me.totalliter.ReadOnly = True
        Me.totalliter.Visible = False
        '
        'totalrupiah
        '
        Me.totalrupiah.DataPropertyName = "totalrupiah"
        Me.totalrupiah.HeaderText = "Column1"
        Me.totalrupiah.Name = "totalrupiah"
        Me.totalrupiah.ReadOnly = True
        Me.totalrupiah.Visible = False
        '
        'totalbayar
        '
        Me.totalbayar.DataPropertyName = "totalbayar"
        Me.totalbayar.HeaderText = "Column1"
        Me.totalbayar.Name = "totalbayar"
        Me.totalbayar.ReadOnly = True
        Me.totalbayar.Visible = False
        '
        'kasbontunai
        '
        Me.kasbontunai.DataPropertyName = "kasbontunai"
        Me.kasbontunai.HeaderText = "Column1"
        Me.kasbontunai.Name = "kasbontunai"
        Me.kasbontunai.ReadOnly = True
        Me.kasbontunai.Visible = False
        '
        'grandtotal
        '
        Me.grandtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.grandtotal.DataPropertyName = "grandtotal"
        DataGridViewCellStyle2.Format = "N0"
        Me.grandtotal.DefaultCellStyle = DataGridViewCellStyle2
        Me.grandtotal.HeaderText = "Grand Total"
        Me.grandtotal.Name = "grandtotal"
        Me.grandtotal.ReadOnly = True
        Me.grandtotal.Width = 88
        '
        'status
        '
        Me.status.DataPropertyName = "status"
        Me.status.HeaderText = "Status Bayar"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Visible = False
        '
        'Bayar
        '
        Me.Bayar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Bayar.HeaderText = "Bayar"
        Me.Bayar.Name = "Bayar"
        Me.Bayar.ReadOnly = True
        Me.Bayar.Text = "Bayar"
        Me.Bayar.UseColumnTextForButtonValue = True
        Me.Bayar.Width = 40
        '
        'lbljumdata
        '
        Me.lbljumdata.AutoSize = True
        Me.lbljumdata.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljumdata.Location = New System.Drawing.Point(748, 417)
        Me.lbljumdata.Name = "lbljumdata"
        Me.lbljumdata.Size = New System.Drawing.Size(14, 13)
        Me.lbljumdata.TabIndex = 33
        Me.lbljumdata.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(646, 417)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Jumlah Data:"
        '
        'btncari
        '
        Me.btncari.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btncari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncari.Location = New System.Drawing.Point(680, 37)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(80, 29)
        Me.btncari.TabIndex = 30
        Me.btncari.Text = "Cari"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'frmbayartagihanspbu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 437)
        Me.Controls.Add(Me.lbljumdata)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvtagihanspbu)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.txtnotagihan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtptglakhir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtptglawal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmbayartagihanspbu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Bayar Tagihan SPBU :."
        CType(Me.dgvtagihanspbu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtptglawal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtptglakhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnotagihan As System.Windows.Forms.TextBox
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents dgvtagihanspbu As System.Windows.Forms.DataGridView
    Friend WithEvents lbljumdata As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents notagihan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kodespbu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaSPBU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tgl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalliter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalrupiah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalbayar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kasbontunai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grandtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bayar As System.Windows.Forms.DataGridViewButtonColumn
End Class
