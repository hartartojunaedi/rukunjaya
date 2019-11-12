<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterPerusahaan
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
        Me.dgvPerusahaan = New System.Windows.Forms.DataGridView()
        Me.KodePerusahaan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaPerusahaan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Holding = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Prosentase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblProsentase = New System.Windows.Forms.Label()
        CType(Me.dgvPerusahaan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPerusahaan
        '
        Me.dgvPerusahaan.AllowUserToAddRows = False
        Me.dgvPerusahaan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPerusahaan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodePerusahaan, Me.NamaPerusahaan, Me.Keterangan, Me.Holding, Me.Prosentase})
        Me.dgvPerusahaan.Location = New System.Drawing.Point(12, 21)
        Me.dgvPerusahaan.Name = "dgvPerusahaan"
        Me.dgvPerusahaan.Size = New System.Drawing.Size(857, 279)
        Me.dgvPerusahaan.TabIndex = 0
        '
        'KodePerusahaan
        '
        Me.KodePerusahaan.DataPropertyName = "kodeperusahaan"
        Me.KodePerusahaan.HeaderText = "Kode Perusahaan"
        Me.KodePerusahaan.Name = "KodePerusahaan"
        '
        'NamaPerusahaan
        '
        Me.NamaPerusahaan.DataPropertyName = "namaperusahaan"
        Me.NamaPerusahaan.HeaderText = "Nama Perusahaan"
        Me.NamaPerusahaan.Name = "NamaPerusahaan"
        Me.NamaPerusahaan.Width = 200
        '
        'Keterangan
        '
        Me.Keterangan.DataPropertyName = "keterangan"
        Me.Keterangan.HeaderText = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Width = 300
        '
        'Holding
        '
        Me.Holding.DataPropertyName = "holding"
        Me.Holding.HeaderText = "Holding"
        Me.Holding.Name = "Holding"
        Me.Holding.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Holding.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Holding.Width = 50
        '
        'Prosentase
        '
        Me.Prosentase.DataPropertyName = "prosentase"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Prosentase.DefaultCellStyle = DataGridViewCellStyle1
        Me.Prosentase.HeaderText = "%"
        Me.Prosentase.Name = "Prosentase"
        Me.Prosentase.Width = 50
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(12, 318)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(80, 29)
        Me.btnTambah.TabIndex = 3
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(636, 318)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total Prosentase:            %"
        '
        'lblProsentase
        '
        Me.lblProsentase.AutoSize = True
        Me.lblProsentase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProsentase.Location = New System.Drawing.Point(790, 318)
        Me.lblProsentase.Name = "lblProsentase"
        Me.lblProsentase.Size = New System.Drawing.Size(39, 20)
        Me.lblProsentase.TabIndex = 5
        Me.lblProsentase.Text = "100"
        '
        'frmMasterPerusahaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 365)
        Me.Controls.Add(Me.lblProsentase)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.dgvPerusahaan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMasterPerusahaan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Master Perusahaan :."
        CType(Me.dgvPerusahaan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvPerusahaan As System.Windows.Forms.DataGridView
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblProsentase As System.Windows.Forms.Label
    Friend WithEvents KodePerusahaan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaPerusahaan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Holding As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Prosentase As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
