<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterJenisMaintance
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
        Me.lblCari = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.dgvJenisMaintenance = New System.Windows.Forms.DataGridView()
        Me.kodejenismaintance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namapekerjaan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rutin = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        CType(Me.dgvJenisMaintenance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCari
        '
        Me.lblCari.AutoSize = True
        Me.lblCari.Location = New System.Drawing.Point(203, 20)
        Me.lblCari.Name = "lblCari"
        Me.lblCari.Size = New System.Drawing.Size(110, 13)
        Me.lblCari.TabIndex = 0
        Me.lblCari.Text = "Cari Nama Pekerjaan:"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(319, 17)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(169, 20)
        Me.txtCari.TabIndex = 1
        '
        'dgvJenisMaintenance
        '
        Me.dgvJenisMaintenance.AllowUserToAddRows = False
        Me.dgvJenisMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJenisMaintenance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodejenismaintance, Me.namapekerjaan, Me.rutin, Me.Keterangan})
        Me.dgvJenisMaintenance.Location = New System.Drawing.Point(11, 66)
        Me.dgvJenisMaintenance.Name = "dgvJenisMaintenance"
        Me.dgvJenisMaintenance.Size = New System.Drawing.Size(563, 181)
        Me.dgvJenisMaintenance.TabIndex = 2
        '
        'kodejenismaintance
        '
        Me.kodejenismaintance.DataPropertyName = "kodejenismaintance"
        Me.kodejenismaintance.HeaderText = "Kode jenis"
        Me.kodejenismaintance.Name = "kodejenismaintance"
        '
        'namapekerjaan
        '
        Me.namapekerjaan.DataPropertyName = "namapekerjaan"
        Me.namapekerjaan.HeaderText = "Nama Pekerjaan"
        Me.namapekerjaan.Name = "namapekerjaan"
        '
        'rutin
        '
        Me.rutin.DataPropertyName = "rutin"
        Me.rutin.HeaderText = "Rutin"
        Me.rutin.Name = "rutin"
        '
        'Keterangan
        '
        Me.Keterangan.DataPropertyName = "keterangan"
        Me.Keterangan.HeaderText = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        '
        'btnFilter
        '
        Me.btnFilter.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFilter.Location = New System.Drawing.Point(494, 12)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(80, 29)
        Me.btnFilter.TabIndex = 4
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(12, 254)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(80, 29)
        Me.btnTambah.TabIndex = 3
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'frmMasterJenisMaintance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 302)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.dgvJenisMaintenance)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.lblCari)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMasterJenisMaintance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Master Jenis Maintenance :."
        CType(Me.dgvJenisMaintenance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCari As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents dgvJenisMaintenance As System.Windows.Forms.DataGridView
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents kodejenismaintance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namapekerjaan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rutin As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnFilter As System.Windows.Forms.Button
End Class
