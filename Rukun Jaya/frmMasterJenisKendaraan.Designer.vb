<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterJenisKendaraan
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
        Me.dgvMasterJenisKendaraan = New System.Windows.Forms.DataGridView()
        Me.KodeJenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namajenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblCari = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.BtnFilter = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        CType(Me.dgvMasterJenisKendaraan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMasterJenisKendaraan
        '
        Me.dgvMasterJenisKendaraan.AllowUserToAddRows = False
        Me.dgvMasterJenisKendaraan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMasterJenisKendaraan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMasterJenisKendaraan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeJenis, Me.namajenis, Me.keterangan})
        Me.dgvMasterJenisKendaraan.Location = New System.Drawing.Point(12, 59)
        Me.dgvMasterJenisKendaraan.Name = "dgvMasterJenisKendaraan"
        Me.dgvMasterJenisKendaraan.ReadOnly = True
        Me.dgvMasterJenisKendaraan.Size = New System.Drawing.Size(559, 258)
        Me.dgvMasterJenisKendaraan.TabIndex = 0
        '
        'KodeJenis
        '
        Me.KodeJenis.HeaderText = "Kode Jenis"
        Me.KodeJenis.Name = "KodeJenis"
        Me.KodeJenis.ReadOnly = True
        '
        'namajenis
        '
        Me.namajenis.HeaderText = "Nama Jenis"
        Me.namajenis.Name = "namajenis"
        Me.namajenis.ReadOnly = True
        '
        'keterangan
        '
        Me.keterangan.HeaderText = "Keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.ReadOnly = True
        '
        'LblCari
        '
        Me.LblCari.AutoSize = True
        Me.LblCari.Location = New System.Drawing.Point(131, 23)
        Me.LblCari.Name = "LblCari"
        Me.LblCari.Size = New System.Drawing.Size(110, 13)
        Me.LblCari.TabIndex = 2
        Me.LblCari.Text = "Cari Jenis Kendaraan:"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(247, 20)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(188, 20)
        Me.txtCari.TabIndex = 0
        '
        'BtnFilter
        '
        Me.BtnFilter.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.BtnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFilter.Location = New System.Drawing.Point(454, 9)
        Me.BtnFilter.Name = "BtnFilter"
        Me.BtnFilter.Size = New System.Drawing.Size(80, 29)
        Me.BtnFilter.TabIndex = 3
        Me.BtnFilter.Text = "Filter"
        Me.BtnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFilter.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(12, 340)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(80, 29)
        Me.btnTambah.TabIndex = 1
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'frmMasterJenisKendaraan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 393)
        Me.Controls.Add(Me.BtnFilter)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.LblCari)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.dgvMasterJenisKendaraan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMasterJenisKendaraan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Master Jenis Kendaraan :."
        CType(Me.dgvMasterJenisKendaraan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvMasterJenisKendaraan As System.Windows.Forms.DataGridView
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents KodeJenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namajenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LblCari As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents BtnFilter As System.Windows.Forms.Button
End Class
