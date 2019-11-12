<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLKuat
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
        Me.dgvDetailSuratJalan = New System.Windows.Forms.DataGridView()
        Me.NoBM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoSuratJalan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoDo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDUrutan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kerusakan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HapusData = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.kodebarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbljumlahrow = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtCariNoBM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNoSuratJalan = New System.Windows.Forms.TextBox()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvDetailSuratJalan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDetailSuratJalan
        '
        Me.dgvDetailSuratJalan.AllowUserToAddRows = False
        Me.dgvDetailSuratJalan.AllowUserToDeleteRows = False
        Me.dgvDetailSuratJalan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetailSuratJalan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoBM, Me.NoSuratJalan, Me.NamaBarang, Me.NoDo, Me.IDUrutan, Me.Kerusakan, Me.HapusData, Me.kodebarang})
        Me.dgvDetailSuratJalan.Location = New System.Drawing.Point(12, 65)
        Me.dgvDetailSuratJalan.Name = "dgvDetailSuratJalan"
        Me.dgvDetailSuratJalan.ReadOnly = True
        Me.dgvDetailSuratJalan.Size = New System.Drawing.Size(743, 204)
        Me.dgvDetailSuratJalan.TabIndex = 0
        '
        'NoBM
        '
        Me.NoBM.DataPropertyName = "nobm"
        Me.NoBM.HeaderText = "No BM"
        Me.NoBM.Name = "NoBM"
        Me.NoBM.ReadOnly = True
        '
        'NoSuratJalan
        '
        Me.NoSuratJalan.DataPropertyName = "noSuratJalan"
        Me.NoSuratJalan.HeaderText = "No Surat Jalan"
        Me.NoSuratJalan.Name = "NoSuratJalan"
        Me.NoSuratJalan.ReadOnly = True
        '
        'NamaBarang
        '
        Me.NamaBarang.DataPropertyName = "NamaBarang"
        Me.NamaBarang.HeaderText = "Nama Barang"
        Me.NamaBarang.Name = "NamaBarang"
        Me.NamaBarang.ReadOnly = True
        '
        'NoDo
        '
        Me.NoDo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NoDo.DataPropertyName = "noDO"
        Me.NoDo.HeaderText = "No DO"
        Me.NoDo.Name = "NoDo"
        Me.NoDo.ReadOnly = True
        '
        'IDUrutan
        '
        Me.IDUrutan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IDUrutan.DataPropertyName = "IDUrutan"
        Me.IDUrutan.HeaderText = "No Urut"
        Me.IDUrutan.Name = "IDUrutan"
        Me.IDUrutan.ReadOnly = True
        '
        'Kerusakan
        '
        Me.Kerusakan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Kerusakan.DataPropertyName = "Kerusakan"
        Me.Kerusakan.HeaderText = "Kerusakan"
        Me.Kerusakan.Name = "Kerusakan"
        Me.Kerusakan.ReadOnly = True
        '
        'HapusData
        '
        Me.HapusData.HeaderText = "Hapus Data"
        Me.HapusData.Name = "HapusData"
        Me.HapusData.ReadOnly = True
        Me.HapusData.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HapusData.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.HapusData.Text = "Hapus Data"
        Me.HapusData.UseColumnTextForButtonValue = True
        '
        'kodebarang
        '
        Me.kodebarang.DataPropertyName = "kodebarang"
        Me.kodebarang.HeaderText = "Kodebarang"
        Me.kodebarang.Name = "kodebarang"
        Me.kodebarang.ReadOnly = True
        Me.kodebarang.Visible = False
        '
        'lbljumlahrow
        '
        Me.lbljumlahrow.AutoSize = True
        Me.lbljumlahrow.Location = New System.Drawing.Point(641, 277)
        Me.lbljumlahrow.Name = "lbljumlahrow"
        Me.lbljumlahrow.Size = New System.Drawing.Size(13, 13)
        Me.lbljumlahrow.TabIndex = 11
        Me.lbljumlahrow.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(571, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Jumlah Data : "
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(12, 277)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(86, 31)
        Me.btnTambah.TabIndex = 12
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'txtCariNoBM
        '
        Me.txtCariNoBM.Location = New System.Drawing.Point(87, 16)
        Me.txtCariNoBM.Name = "txtCariNoBM"
        Me.txtCariNoBM.Size = New System.Drawing.Size(109, 20)
        Me.txtCariNoBM.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Cari No BM"
        '
        'btnCari
        '
        Me.btnCari.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCari.Location = New System.Drawing.Point(651, 11)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(66, 29)
        Me.btnCari.TabIndex = 15
        Me.btnCari.Text = "Filter"
        Me.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(202, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Cari No Surat Jalan"
        '
        'txtNoSuratJalan
        '
        Me.txtNoSuratJalan.Location = New System.Drawing.Point(302, 16)
        Me.txtNoSuratJalan.Name = "txtNoSuratJalan"
        Me.txtNoSuratJalan.Size = New System.Drawing.Size(133, 20)
        Me.txtNoSuratJalan.TabIndex = 16
        '
        'txtNamaBarang
        '
        Me.txtNamaBarang.Location = New System.Drawing.Point(519, 16)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Size = New System.Drawing.Size(126, 20)
        Me.txtNamaBarang.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(441, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Nama Barang"
        '
        'frmLKuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 317)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNamaBarang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNoSuratJalan)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCariNoBM)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.lbljumlahrow)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvDetailSuratJalan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLKuat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form LKuat :."
        CType(Me.dgvDetailSuratJalan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDetailSuratJalan As System.Windows.Forms.DataGridView
    Friend WithEvents lbljumlahrow As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents txtCariNoBM As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNoSuratJalan As System.Windows.Forms.TextBox
    Friend WithEvents NoBM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoSuratJalan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoDo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDUrutan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kerusakan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HapusData As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents kodebarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtNamaBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
