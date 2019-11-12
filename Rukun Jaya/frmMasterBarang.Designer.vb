<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterBarang
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
        Me.dgvBarang = New System.Windows.Forms.DataGridView()
        Me.kodejenismaintance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namapekerjaan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.lblCari = New System.Windows.Forms.Label()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBarang
        '
        Me.dgvBarang.AllowUserToAddRows = False
        Me.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodejenismaintance, Me.namapekerjaan, Me.Keterangan, Me.nama})
        Me.dgvBarang.Location = New System.Drawing.Point(12, 61)
        Me.dgvBarang.Name = "dgvBarang"
        Me.dgvBarang.Size = New System.Drawing.Size(556, 181)
        Me.dgvBarang.TabIndex = 7
        '
        'kodejenismaintance
        '
        Me.kodejenismaintance.DataPropertyName = "kodebarang"
        Me.kodejenismaintance.HeaderText = "Kode Barang"
        Me.kodejenismaintance.Name = "kodejenismaintance"
        '
        'namapekerjaan
        '
        Me.namapekerjaan.DataPropertyName = "namabarang"
        Me.namapekerjaan.HeaderText = "Nama Barang"
        Me.namapekerjaan.Name = "namapekerjaan"
        '
        'Keterangan
        '
        Me.Keterangan.DataPropertyName = "satuan"
        Me.Keterangan.HeaderText = "Satuan"
        Me.Keterangan.Name = "Keterangan"
        '
        'nama
        '
        Me.nama.DataPropertyName = "namapekerjaan"
        Me.nama.HeaderText = "Jenis Pekerjaan"
        Me.nama.Name = "nama"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(313, 17)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(169, 20)
        Me.txtCari.TabIndex = 6
        '
        'lblCari
        '
        Me.lblCari.AutoSize = True
        Me.lblCari.Location = New System.Drawing.Point(197, 20)
        Me.lblCari.Name = "lblCari"
        Me.lblCari.Size = New System.Drawing.Size(96, 13)
        Me.lblCari.TabIndex = 5
        Me.lblCari.Text = "Cari Nama Barang:"
        '
        'btnFilter
        '
        Me.btnFilter.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFilter.Location = New System.Drawing.Point(488, 12)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(80, 29)
        Me.btnFilter.TabIndex = 9
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(13, 249)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(80, 29)
        Me.btnTambah.TabIndex = 8
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'frmMasterBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 284)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.dgvBarang)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.lblCari)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMasterBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Master Barang :."
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents dgvBarang As System.Windows.Forms.DataGridView
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents lblCari As System.Windows.Forms.Label
    Friend WithEvents kodejenismaintance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namapekerjaan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
