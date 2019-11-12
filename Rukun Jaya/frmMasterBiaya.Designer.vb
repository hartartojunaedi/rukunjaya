<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterBiaya
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvBiaya = New System.Windows.Forms.DataGridView()
        Me.lblJumData = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.nopol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namabiaya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pengeluaran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ubah = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Hapus = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvBiaya, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBiaya
        '
        Me.dgvBiaya.AllowUserToAddRows = False
        Me.dgvBiaya.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBiaya.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBiaya.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBiaya.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nopol, Me.namabiaya, Me.pengeluaran, Me.Ubah, Me.Hapus})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBiaya.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvBiaya.Location = New System.Drawing.Point(22, 12)
        Me.dgvBiaya.Name = "dgvBiaya"
        Me.dgvBiaya.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBiaya.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvBiaya.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvBiaya.Size = New System.Drawing.Size(553, 238)
        Me.dgvBiaya.TabIndex = 7
        '
        'lblJumData
        '
        Me.lblJumData.AutoSize = True
        Me.lblJumData.Location = New System.Drawing.Point(418, 264)
        Me.lblJumData.Name = "lblJumData"
        Me.lblJumData.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblJumData.Size = New System.Drawing.Size(39, 13)
        Me.lblJumData.TabIndex = 13
        Me.lblJumData.Text = "Label4"
        Me.lblJumData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(354, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Jumlah data :"
        '
        'btnTambah
        '
        Me.btnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.btnTambah.Location = New System.Drawing.Point(22, 256)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(80, 29)
        Me.btnTambah.TabIndex = 8
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'nopol
        '
        Me.nopol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.nopol.DataPropertyName = "kodebiaya"
        Me.nopol.Frozen = True
        Me.nopol.HeaderText = "Kode Biaya"
        Me.nopol.Name = "nopol"
        Me.nopol.ReadOnly = True
        Me.nopol.ToolTipText = "Kode Biaya"
        Me.nopol.Width = 86
        '
        'namabiaya
        '
        Me.namabiaya.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.namabiaya.DataPropertyName = "namabiaya"
        Me.namabiaya.Frozen = True
        Me.namabiaya.HeaderText = "Nama Biaya"
        Me.namabiaya.Name = "namabiaya"
        Me.namabiaya.ReadOnly = True
        Me.namabiaya.ToolTipText = "Nama Biaya"
        Me.namabiaya.Width = 200
        '
        'pengeluaran
        '
        Me.pengeluaran.DataPropertyName = "kurang"
        Me.pengeluaran.Frozen = True
        Me.pengeluaran.HeaderText = "Pengeluaran"
        Me.pengeluaran.Name = "pengeluaran"
        Me.pengeluaran.ReadOnly = True
        Me.pengeluaran.ToolTipText = "Pengeluaran"
        '
        'Ubah
        '
        Me.Ubah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = "Ubah"
        Me.Ubah.DefaultCellStyle = DataGridViewCellStyle2
        Me.Ubah.Frozen = True
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
        Me.Hapus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = "Hapus"
        Me.Hapus.DefaultCellStyle = DataGridViewCellStyle3
        Me.Hapus.HeaderText = "Hapus"
        Me.Hapus.Name = "Hapus"
        Me.Hapus.ReadOnly = True
        Me.Hapus.Text = "Hapus"
        Me.Hapus.ToolTipText = "Hapus Data"
        Me.Hapus.UseColumnTextForButtonValue = True
        Me.Hapus.Width = 45
        '
        'frmMasterBiaya
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 292)
        Me.Controls.Add(Me.lblJumData)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.dgvBiaya)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMasterBiaya"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Master Biaya :."
        CType(Me.dgvBiaya, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvBiaya As System.Windows.Forms.DataGridView
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents lblJumData As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nopol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namabiaya As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pengeluaran As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ubah As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Hapus As System.Windows.Forms.DataGridViewButtonColumn
End Class
