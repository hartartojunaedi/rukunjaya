<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintance
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbkrutin = New System.Windows.Forms.CheckBox()
        Me.cmbrutin = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttukang = New System.Windows.Forms.TextBox()
        Me.txtnamapekerjaan = New System.Windows.Forms.TextBox()
        Me.btncari = New System.Windows.Forms.Button()
        Me.lblcaritglkirberikut = New System.Windows.Forms.Label()
        Me.txtcarinolambung = New System.Windows.Forms.TextBox()
        Me.lblcaritglkir = New System.Windows.Forms.Label()
        Me.lblnolambung = New System.Windows.Forms.Label()
        Me.dgvmastermaintance = New System.Windows.Forms.DataGridView()
        Me.kodemaintance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nolambung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namapekerjaan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tukang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rutin = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.biaya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.km = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvmastermaintance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbkrutin)
        Me.GroupBox1.Controls.Add(Me.cmbrutin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txttukang)
        Me.GroupBox1.Controls.Add(Me.txtnamapekerjaan)
        Me.GroupBox1.Controls.Add(Me.btncari)
        Me.GroupBox1.Controls.Add(Me.lblcaritglkirberikut)
        Me.GroupBox1.Controls.Add(Me.txtcarinolambung)
        Me.GroupBox1.Controls.Add(Me.lblcaritglkir)
        Me.GroupBox1.Controls.Add(Me.lblnolambung)
        Me.GroupBox1.Location = New System.Drawing.Point(597, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(599, 126)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'cbkrutin
        '
        Me.cbkrutin.AutoSize = True
        Me.cbkrutin.Location = New System.Drawing.Point(498, 65)
        Me.cbkrutin.Name = "cbkrutin"
        Me.cbkrutin.Size = New System.Drawing.Size(15, 14)
        Me.cbkrutin.TabIndex = 55
        Me.cbkrutin.UseVisualStyleBackColor = True
        '
        'cmbrutin
        '
        Me.cmbrutin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbrutin.FormattingEnabled = True
        Me.cmbrutin.Items.AddRange(New Object() {"Rutin", "Tidak Rutin"})
        Me.cmbrutin.Location = New System.Drawing.Point(367, 62)
        Me.cmbrutin.Name = "cmbrutin"
        Me.cmbrutin.Size = New System.Drawing.Size(125, 21)
        Me.cmbrutin.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(329, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Rutin"
        '
        'txttukang
        '
        Me.txttukang.Location = New System.Drawing.Point(367, 28)
        Me.txttukang.Name = "txttukang"
        Me.txttukang.Size = New System.Drawing.Size(146, 20)
        Me.txttukang.TabIndex = 52
        '
        'txtnamapekerjaan
        '
        Me.txtnamapekerjaan.Location = New System.Drawing.Point(120, 63)
        Me.txtnamapekerjaan.Name = "txtnamapekerjaan"
        Me.txtnamapekerjaan.Size = New System.Drawing.Size(146, 20)
        Me.txtnamapekerjaan.TabIndex = 51
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(511, 94)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(75, 23)
        Me.btncari.TabIndex = 14
        Me.btncari.Text = "Cari"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'lblcaritglkirberikut
        '
        Me.lblcaritglkirberikut.AutoSize = True
        Me.lblcaritglkirberikut.Location = New System.Drawing.Point(317, 31)
        Me.lblcaritglkirberikut.Name = "lblcaritglkirberikut"
        Me.lblcaritglkirberikut.Size = New System.Drawing.Size(44, 13)
        Me.lblcaritglkirberikut.TabIndex = 11
        Me.lblcaritglkirberikut.Text = "Tukang"
        '
        'txtcarinolambung
        '
        Me.txtcarinolambung.Location = New System.Drawing.Point(120, 31)
        Me.txtcarinolambung.Name = "txtcarinolambung"
        Me.txtcarinolambung.Size = New System.Drawing.Size(146, 20)
        Me.txtcarinolambung.TabIndex = 6
        '
        'lblcaritglkir
        '
        Me.lblcaritglkir.AutoSize = True
        Me.lblcaritglkir.Location = New System.Drawing.Point(28, 66)
        Me.lblcaritglkir.Name = "lblcaritglkir"
        Me.lblcaritglkir.Size = New System.Drawing.Size(86, 13)
        Me.lblcaritglkir.TabIndex = 9
        Me.lblcaritglkir.Text = "Nama Pekerjaan"
        '
        'lblnolambung
        '
        Me.lblnolambung.AutoSize = True
        Me.lblnolambung.Location = New System.Drawing.Point(46, 34)
        Me.lblnolambung.Name = "lblnolambung"
        Me.lblnolambung.Size = New System.Drawing.Size(68, 13)
        Me.lblnolambung.TabIndex = 7
        Me.lblnolambung.Text = "No Lambung"
        '
        'dgvmastermaintance
        '
        Me.dgvmastermaintance.AllowUserToAddRows = False
        Me.dgvmastermaintance.AllowUserToDeleteRows = False
        Me.dgvmastermaintance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmastermaintance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodemaintance, Me.nolambung, Me.namapekerjaan, Me.tukang, Me.keterangan, Me.rutin, Me.biaya, Me.tgl, Me.km})
        Me.dgvmastermaintance.Location = New System.Drawing.Point(17, 162)
        Me.dgvmastermaintance.Name = "dgvmastermaintance"
        Me.dgvmastermaintance.ReadOnly = True
        Me.dgvmastermaintance.Size = New System.Drawing.Size(1179, 274)
        Me.dgvmastermaintance.TabIndex = 14
        '
        'kodemaintance
        '
        Me.kodemaintance.DataPropertyName = "kodemaintance"
        Me.kodemaintance.HeaderText = "Kode Maintance"
        Me.kodemaintance.Name = "kodemaintance"
        Me.kodemaintance.ReadOnly = True
        '
        'nolambung
        '
        Me.nolambung.DataPropertyName = "nolambung"
        Me.nolambung.HeaderText = "No Lambung"
        Me.nolambung.Name = "nolambung"
        Me.nolambung.ReadOnly = True
        '
        'namapekerjaan
        '
        Me.namapekerjaan.DataPropertyName = "namapekerjaan"
        Me.namapekerjaan.HeaderText = "Nama Pekerjaan"
        Me.namapekerjaan.Name = "namapekerjaan"
        Me.namapekerjaan.ReadOnly = True
        '
        'tukang
        '
        Me.tukang.DataPropertyName = "tukang"
        Me.tukang.HeaderText = "Tukang"
        Me.tukang.Name = "tukang"
        Me.tukang.ReadOnly = True
        '
        'keterangan
        '
        Me.keterangan.DataPropertyName = "keterangan"
        Me.keterangan.HeaderText = "Keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.ReadOnly = True
        '
        'rutin
        '
        Me.rutin.DataPropertyName = "rutin"
        Me.rutin.HeaderText = "Rutin"
        Me.rutin.Name = "rutin"
        Me.rutin.ReadOnly = True
        Me.rutin.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.rutin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'biaya
        '
        Me.biaya.DataPropertyName = "biaya"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.biaya.DefaultCellStyle = DataGridViewCellStyle1
        Me.biaya.HeaderText = "Biaya"
        Me.biaya.Name = "biaya"
        Me.biaya.ReadOnly = True
        Me.biaya.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.biaya.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'tgl
        '
        Me.tgl.DataPropertyName = "tgl"
        Me.tgl.HeaderText = "Tanggal"
        Me.tgl.Name = "tgl"
        Me.tgl.ReadOnly = True
        Me.tgl.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tgl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'km
        '
        Me.km.DataPropertyName = "km"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.km.DefaultCellStyle = DataGridViewCellStyle2
        Me.km.HeaderText = "Km"
        Me.km.Name = "km"
        Me.km.ReadOnly = True
        Me.km.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.km.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'frmMaintance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 454)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvmastermaintance)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMaintance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Maintance :."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvmastermaintance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents lblcaritglkirberikut As System.Windows.Forms.Label
    Friend WithEvents txtcarinolambung As System.Windows.Forms.TextBox
    Friend WithEvents lblnolambung As System.Windows.Forms.Label
    Friend WithEvents dgvmastermaintance As System.Windows.Forms.DataGridView
    Friend WithEvents lblcaritglkir As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txttukang As System.Windows.Forms.TextBox
    Friend WithEvents txtnamapekerjaan As System.Windows.Forms.TextBox
    Friend WithEvents cmbrutin As System.Windows.Forms.ComboBox
    Friend WithEvents cbkrutin As System.Windows.Forms.CheckBox
    Friend WithEvents kodemaintance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nolambung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namapekerjaan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tukang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rutin As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents biaya As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tgl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents km As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
