<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterBank
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
        Me.dgvBank = New System.Windows.Forms.DataGridView()
        Me.KodeBank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBank = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoRekening = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UbahData = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.HapusData = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtSearchnama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsearchnorek = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        CType(Me.dgvBank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBank
        '
        Me.dgvBank.AllowUserToAddRows = False
        Me.dgvBank.AllowUserToDeleteRows = False
        Me.dgvBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBank.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeBank, Me.NamaBank, Me.NoRekening, Me.Saldo, Me.Keterangan, Me.UbahData, Me.HapusData})
        Me.dgvBank.Location = New System.Drawing.Point(12, 64)
        Me.dgvBank.Name = "dgvBank"
        Me.dgvBank.ReadOnly = True
        Me.dgvBank.Size = New System.Drawing.Size(736, 171)
        Me.dgvBank.TabIndex = 3
        '
        'KodeBank
        '
        Me.KodeBank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.KodeBank.DataPropertyName = "KodeBank"
        Me.KodeBank.HeaderText = "Kode Bank"
        Me.KodeBank.Name = "KodeBank"
        Me.KodeBank.ReadOnly = True
        Me.KodeBank.Width = 85
        '
        'NamaBank
        '
        Me.NamaBank.DataPropertyName = "NamaBank"
        Me.NamaBank.HeaderText = "Nama Bank"
        Me.NamaBank.Name = "NamaBank"
        Me.NamaBank.ReadOnly = True
        '
        'NoRekening
        '
        Me.NoRekening.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NoRekening.DataPropertyName = "NoRek"
        Me.NoRekening.HeaderText = "No Rekening"
        Me.NoRekening.Name = "NoRekening"
        Me.NoRekening.ReadOnly = True
        '
        'Saldo
        '
        Me.Saldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Saldo.DataPropertyName = "Saldo"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Saldo.DefaultCellStyle = DataGridViewCellStyle1
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.ReadOnly = True
        '
        'Keterangan
        '
        Me.Keterangan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Keterangan.DataPropertyName = "Keterangan"
        Me.Keterangan.HeaderText = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.ReadOnly = True
        '
        'UbahData
        '
        Me.UbahData.HeaderText = "Ubah"
        Me.UbahData.Name = "UbahData"
        Me.UbahData.ReadOnly = True
        Me.UbahData.Text = "Ubah"
        Me.UbahData.UseColumnTextForButtonValue = True
        Me.UbahData.Width = 45
        '
        'HapusData
        '
        Me.HapusData.HeaderText = "Hapus"
        Me.HapusData.Name = "HapusData"
        Me.HapusData.ReadOnly = True
        Me.HapusData.Text = "Hapus"
        Me.HapusData.UseColumnTextForButtonValue = True
        Me.HapusData.Width = 45
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(12, 241)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(80, 29)
        Me.btnTambah.TabIndex = 4
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'txtSearchnama
        '
        Me.txtSearchnama.Location = New System.Drawing.Point(532, 12)
        Me.txtSearchnama.Name = "txtSearchnama"
        Me.txtSearchnama.Size = New System.Drawing.Size(128, 20)
        Me.txtSearchnama.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(442, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cari Nama Bank"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(435, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cari No Rekening"
        '
        'txtsearchnorek
        '
        Me.txtsearchnorek.Location = New System.Drawing.Point(532, 38)
        Me.txtsearchnorek.Name = "txtsearchnorek"
        Me.txtsearchnorek.Size = New System.Drawing.Size(128, 20)
        Me.txtsearchnorek.TabIndex = 2
        '
        'btnCari
        '
        Me.btnCari.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCari.Location = New System.Drawing.Point(667, 12)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(80, 29)
        Me.btnCari.TabIndex = 7
        Me.btnCari.Text = "&Filter"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'frmMasterBank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 277)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtsearchnorek)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearchnama)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.dgvBank)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMasterBank"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Master Bank :."
        CType(Me.dgvBank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvBank As System.Windows.Forms.DataGridView
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents txtSearchnama As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtsearchnorek As System.Windows.Forms.TextBox
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents KodeBank As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBank As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoRekening As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Saldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UbahData As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents HapusData As System.Windows.Forms.DataGridViewButtonColumn
End Class
