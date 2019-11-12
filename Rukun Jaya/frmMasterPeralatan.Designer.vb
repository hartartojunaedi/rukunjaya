<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterPeralatan
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
        Me.dgvPeralatan = New System.Windows.Forms.DataGridView()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.lblCari = New System.Windows.Forms.Label()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.IDAlat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaAlat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Satuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ubah = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Hapus = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvPeralatan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPeralatan
        '
        Me.dgvPeralatan.AllowUserToAddRows = False
        Me.dgvPeralatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPeralatan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDAlat, Me.NamaAlat, Me.Jumlah, Me.Satuan, Me.Keterangan, Me.Ubah, Me.Hapus})
        Me.dgvPeralatan.Location = New System.Drawing.Point(12, 58)
        Me.dgvPeralatan.Name = "dgvPeralatan"
        Me.dgvPeralatan.Size = New System.Drawing.Size(556, 181)
        Me.dgvPeralatan.TabIndex = 12
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(313, 14)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(169, 20)
        Me.txtCari.TabIndex = 11
        '
        'lblCari
        '
        Me.lblCari.AutoSize = True
        Me.lblCari.Location = New System.Drawing.Point(197, 17)
        Me.lblCari.Name = "lblCari"
        Me.lblCari.Size = New System.Drawing.Size(96, 13)
        Me.lblCari.TabIndex = 10
        Me.lblCari.Text = "Cari Nama Barang:"
        '
        'btnFilter
        '
        Me.btnFilter.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFilter.Location = New System.Drawing.Point(488, 9)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(80, 29)
        Me.btnFilter.TabIndex = 14
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(13, 246)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(80, 29)
        Me.btnTambah.TabIndex = 13
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'IDAlat
        '
        Me.IDAlat.DataPropertyName = "IDAlat"
        Me.IDAlat.HeaderText = "ID"
        Me.IDAlat.Name = "IDAlat"
        '
        'NamaAlat
        '
        Me.NamaAlat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NamaAlat.DataPropertyName = "NamaAlat"
        Me.NamaAlat.HeaderText = "Nama Alat"
        Me.NamaAlat.Name = "NamaAlat"
        '
        'Jumlah
        '
        Me.Jumlah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Jumlah.DataPropertyName = "Jumlah"
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.Width = 65
        '
        'Satuan
        '
        Me.Satuan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Satuan.DataPropertyName = "Satuan"
        Me.Satuan.HeaderText = "Satuan"
        Me.Satuan.Name = "Satuan"
        Me.Satuan.Width = 66
        '
        'Keterangan
        '
        Me.Keterangan.DataPropertyName = "Keterangan"
        Me.Keterangan.HeaderText = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = False
        '
        'Ubah
        '
        Me.Ubah.HeaderText = "Ubah"
        Me.Ubah.Name = "Ubah"
        Me.Ubah.Text = "Ubah"
        Me.Ubah.UseColumnTextForButtonValue = True
        Me.Ubah.Width = 45
        '
        'Hapus
        '
        Me.Hapus.HeaderText = "Hapus"
        Me.Hapus.Name = "Hapus"
        Me.Hapus.Text = "Hapus"
        Me.Hapus.UseColumnTextForButtonValue = True
        Me.Hapus.Width = 45
        '
        'frmMasterPeralatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 278)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.dgvPeralatan)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.lblCari)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMasterPeralatan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Master Peralatan :."
        CType(Me.dgvPeralatan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents dgvPeralatan As System.Windows.Forms.DataGridView
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents lblCari As System.Windows.Forms.Label
    Friend WithEvents IDAlat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaAlat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Satuan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ubah As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Hapus As System.Windows.Forms.DataGridViewButtonColumn
End Class
