<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetilSetOngkos
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
        Me.dgvSetOngkos = New System.Windows.Forms.DataGridView()
        Me.NoSuratJalan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Asal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tujuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Namasupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detilperwakilan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ongkos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoBM = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        CType(Me.dgvSetOngkos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSetOngkos
        '
        Me.dgvSetOngkos.AllowUserToAddRows = False
        Me.dgvSetOngkos.AllowUserToDeleteRows = False
        Me.dgvSetOngkos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSetOngkos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoSuratJalan, Me.tanggal, Me.Asal, Me.Tujuan, Me.Namasupplier, Me.detilperwakilan, Me.Ongkos})
        Me.dgvSetOngkos.Location = New System.Drawing.Point(13, 48)
        Me.dgvSetOngkos.Name = "dgvSetOngkos"
        Me.dgvSetOngkos.Size = New System.Drawing.Size(715, 208)
        Me.dgvSetOngkos.TabIndex = 0
        '
        'NoSuratJalan
        '
        Me.NoSuratJalan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NoSuratJalan.DataPropertyName = "NoSuratJalan"
        Me.NoSuratJalan.HeaderText = "No Surat Jalan"
        Me.NoSuratJalan.Name = "NoSuratJalan"
        Me.NoSuratJalan.ReadOnly = True
        '
        'tanggal
        '
        Me.tanggal.DataPropertyName = "tgl"
        Me.tanggal.HeaderText = "Tanggal"
        Me.tanggal.Name = "tanggal"
        '
        'Asal
        '
        Me.Asal.DataPropertyName = "asal"
        Me.Asal.HeaderText = "Asal"
        Me.Asal.Name = "Asal"
        Me.Asal.ReadOnly = True
        '
        'Tujuan
        '
        Me.Tujuan.DataPropertyName = "tujuan"
        Me.Tujuan.HeaderText = "Tujuan"
        Me.Tujuan.Name = "Tujuan"
        Me.Tujuan.ReadOnly = True
        '
        'Namasupplier
        '
        Me.Namasupplier.DataPropertyName = "NamaSupplier"
        Me.Namasupplier.HeaderText = "Nama Supplier"
        Me.Namasupplier.Name = "Namasupplier"
        '
        'detilperwakilan
        '
        Me.detilperwakilan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.detilperwakilan.DataPropertyName = "NamaPerwakilan"
        Me.detilperwakilan.HeaderText = "Nama Perwakilan"
        Me.detilperwakilan.Name = "detilperwakilan"
        Me.detilperwakilan.ReadOnly = True
        '
        'Ongkos
        '
        Me.Ongkos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Ongkos.DataPropertyName = "Ongkos"
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Ongkos.DefaultCellStyle = DataGridViewCellStyle1
        Me.Ongkos.HeaderText = "Ongkos"
        Me.Ongkos.Name = "Ongkos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No BM : "
        '
        'txtNoBM
        '
        Me.txtNoBM.AutoSize = True
        Me.txtNoBM.Location = New System.Drawing.Point(74, 12)
        Me.txtNoBM.Name = "txtNoBM"
        Me.txtNoBM.Size = New System.Drawing.Size(40, 13)
        Me.txtNoBM.TabIndex = 2
        Me.txtNoBM.Text = "No BM"
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(30, 263)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 31)
        Me.btnSimpan.TabIndex = 3
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'frmDetilSetOngkos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 301)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.txtNoBM)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvSetOngkos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetilSetOngkos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Detil Set Ongkos :."
        CType(Me.dgvSetOngkos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSetOngkos As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoBM As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents NoSuratJalan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tanggal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Asal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tujuan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Namasupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents detilperwakilan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ongkos As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
