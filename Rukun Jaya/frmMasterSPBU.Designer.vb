<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterSPBU
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvSPBU = New System.Windows.Forms.DataGridView()
        Me.Kodespbu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namaspbu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamatspbu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kotaspbu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telpspbu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kontakspbu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.limit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ubah = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Hapus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblJumData = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        CType(Me.dgvSPBU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSPBU
        '
        Me.dgvSPBU.AllowUserToAddRows = False
        Me.dgvSPBU.AllowUserToDeleteRows = False
        Me.dgvSPBU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSPBU.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kodespbu, Me.namaspbu, Me.alamatspbu, Me.kotaspbu, Me.telpspbu, Me.kontakspbu, Me.limit, Me.saldo, Me.Ubah, Me.Hapus})
        Me.dgvSPBU.Location = New System.Drawing.Point(12, 12)
        Me.dgvSPBU.Name = "dgvSPBU"
        Me.dgvSPBU.ReadOnly = True
        Me.dgvSPBU.Size = New System.Drawing.Size(633, 381)
        Me.dgvSPBU.TabIndex = 6
        '
        'Kodespbu
        '
        Me.Kodespbu.DataPropertyName = "kodespbu"
        Me.Kodespbu.HeaderText = "Kode SPBU"
        Me.Kodespbu.Name = "Kodespbu"
        Me.Kodespbu.ReadOnly = True
        Me.Kodespbu.ToolTipText = "Kode SPBU"
        '
        'namaspbu
        '
        Me.namaspbu.DataPropertyName = "namaspbu"
        Me.namaspbu.HeaderText = "Nama SPBU"
        Me.namaspbu.Name = "namaspbu"
        Me.namaspbu.ReadOnly = True
        Me.namaspbu.ToolTipText = "Nama SPBU"
        '
        'alamatspbu
        '
        Me.alamatspbu.DataPropertyName = "alamatspbu"
        Me.alamatspbu.HeaderText = "Alamat"
        Me.alamatspbu.Name = "alamatspbu"
        Me.alamatspbu.ReadOnly = True
        Me.alamatspbu.ToolTipText = "Alamat"
        '
        'kotaspbu
        '
        Me.kotaspbu.DataPropertyName = "kotaspbu"
        Me.kotaspbu.HeaderText = "Kota"
        Me.kotaspbu.Name = "kotaspbu"
        Me.kotaspbu.ReadOnly = True
        Me.kotaspbu.ToolTipText = "Kota"
        '
        'telpspbu
        '
        Me.telpspbu.DataPropertyName = "telpspbu"
        Me.telpspbu.HeaderText = "Telp"
        Me.telpspbu.Name = "telpspbu"
        Me.telpspbu.ReadOnly = True
        Me.telpspbu.ToolTipText = "Telp"
        Me.telpspbu.Visible = False
        '
        'kontakspbu
        '
        Me.kontakspbu.DataPropertyName = "kontakspbu"
        Me.kontakspbu.HeaderText = "Kontak"
        Me.kontakspbu.Name = "kontakspbu"
        Me.kontakspbu.ReadOnly = True
        Me.kontakspbu.ToolTipText = "Kontak"
        Me.kontakspbu.Visible = False
        '
        'limit
        '
        Me.limit.DataPropertyName = "limit"
        DataGridViewCellStyle1.Format = "C0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.limit.DefaultCellStyle = DataGridViewCellStyle1
        Me.limit.HeaderText = "Limit"
        Me.limit.Name = "limit"
        Me.limit.ReadOnly = True
        Me.limit.ToolTipText = "Limit"
        Me.limit.Visible = False
        '
        'saldo
        '
        Me.saldo.DataPropertyName = "saldo"
        DataGridViewCellStyle2.Format = "C0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.saldo.DefaultCellStyle = DataGridViewCellStyle2
        Me.saldo.HeaderText = "Saldo"
        Me.saldo.Name = "saldo"
        Me.saldo.ReadOnly = True
        Me.saldo.ToolTipText = "Saldo"
        Me.saldo.Visible = False
        '
        'Ubah
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = "Ubah"
        Me.Ubah.DefaultCellStyle = DataGridViewCellStyle3
        Me.Ubah.HeaderText = "Ubah"
        Me.Ubah.Name = "Ubah"
        Me.Ubah.ReadOnly = True
        Me.Ubah.Text = "Ubah"
        Me.Ubah.ToolTipText = "Ubah Data"
        Me.Ubah.UseColumnTextForButtonValue = True
        Me.Ubah.Width = 45
        '
        'Hapus
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.NullValue = "Hapus"
        Me.Hapus.DefaultCellStyle = DataGridViewCellStyle4
        Me.Hapus.HeaderText = "Hapus"
        Me.Hapus.Name = "Hapus"
        Me.Hapus.ReadOnly = True
        Me.Hapus.Text = "Hapus"
        Me.Hapus.ToolTipText = "Hapus"
        Me.Hapus.UseColumnTextForButtonValue = True
        Me.Hapus.Width = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(532, 409)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Jumlah data :"
        '
        'lblJumData
        '
        Me.lblJumData.AutoSize = True
        Me.lblJumData.Location = New System.Drawing.Point(609, 409)
        Me.lblJumData.Name = "lblJumData"
        Me.lblJumData.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblJumData.Size = New System.Drawing.Size(39, 13)
        Me.lblJumData.TabIndex = 11
        Me.lblJumData.Text = "Label4"
        Me.lblJumData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnTambah
        '
        Me.btnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.btnTambah.Location = New System.Drawing.Point(10, 401)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(80, 29)
        Me.btnTambah.TabIndex = 7
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'frmMasterSPBU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 448)
        Me.Controls.Add(Me.lblJumData)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.dgvSPBU)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMasterSPBU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Master SPBU :."
        CType(Me.dgvSPBU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSPBU As System.Windows.Forms.DataGridView
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblJumData As System.Windows.Forms.Label
    'Friend WithEvents DataSet1 As RukunJaya.DataSet1
    'Friend WithEvents KendaraanTableAdapter As RukunJaya.DataSet1TableAdapters.kendaraanTableAdapter
    Friend WithEvents NolambungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NopolDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PemilikDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodeperusahaanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MerekDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TahunDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NorangkaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomesinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoBPKBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JatuhtempoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JenisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreatedateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UpdatedateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kodespbu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namaspbu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents alamatspbu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kotaspbu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telpspbu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kontakspbu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents limit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents saldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ubah As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Hapus As System.Windows.Forms.DataGridViewButtonColumn
End Class
