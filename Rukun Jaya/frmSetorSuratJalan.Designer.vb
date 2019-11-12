<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetorSuratJalan
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
        Me.dgvSetorSuratJalan = New System.Windows.Forms.DataGridView()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.noBM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nopol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoSJ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Supir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Asal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tujuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Supplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Setor = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.txtCariNopol = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCariSopir = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpAkhirPeriode = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpAwalPeriode = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoBM = New System.Windows.Forms.TextBox()
        CType(Me.dgvSetorSuratJalan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSetorSuratJalan
        '
        Me.dgvSetorSuratJalan.AllowUserToAddRows = False
        Me.dgvSetorSuratJalan.AllowUserToDeleteRows = False
        Me.dgvSetorSuratJalan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSetorSuratJalan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.noBM, Me.nopol, Me.NoSJ, Me.Supir, Me.Asal, Me.Tujuan, Me.Supplier, Me.tanggal, Me.Setor})
        Me.dgvSetorSuratJalan.Location = New System.Drawing.Point(13, 52)
        Me.dgvSetorSuratJalan.Name = "dgvSetorSuratJalan"
        Me.dgvSetorSuratJalan.Size = New System.Drawing.Size(943, 264)
        Me.dgvSetorSuratJalan.TabIndex = 0
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(13, 322)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 31)
        Me.btnSimpan.TabIndex = 1
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'noBM
        '
        Me.noBM.DataPropertyName = "nobm"
        Me.noBM.HeaderText = "No BM"
        Me.noBM.Name = "noBM"
        Me.noBM.ReadOnly = True
        '
        'nopol
        '
        Me.nopol.DataPropertyName = "nopol"
        Me.nopol.HeaderText = "No Polisi"
        Me.nopol.Name = "nopol"
        Me.nopol.ReadOnly = True
        '
        'NoSJ
        '
        Me.NoSJ.DataPropertyName = "nosuratjalan"
        Me.NoSJ.HeaderText = "No Surat Jalan"
        Me.NoSJ.Name = "NoSJ"
        Me.NoSJ.ReadOnly = True
        '
        'Supir
        '
        Me.Supir.DataPropertyName = "namasopir"
        Me.Supir.HeaderText = "Supir"
        Me.Supir.Name = "Supir"
        Me.Supir.ReadOnly = True
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
        'Supplier
        '
        Me.Supplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Supplier.DataPropertyName = "namasupplier"
        Me.Supplier.HeaderText = "Supplier"
        Me.Supplier.Name = "Supplier"
        Me.Supplier.ReadOnly = True
        '
        'tanggal
        '
        Me.tanggal.DataPropertyName = "tgl"
        Me.tanggal.HeaderText = "Tanggal"
        Me.tanggal.Name = "tanggal"
        Me.tanggal.ReadOnly = True
        '
        'Setor
        '
        Me.Setor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Setor.HeaderText = "Setor"
        Me.Setor.Name = "Setor"
        Me.Setor.Width = 38
        '
        'btnFilter
        '
        Me.btnFilter.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFilter.Location = New System.Drawing.Point(784, 7)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(66, 36)
        Me.btnFilter.TabIndex = 21
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'txtCariNopol
        '
        Me.txtCariNopol.Location = New System.Drawing.Point(678, 15)
        Me.txtCariNopol.Name = "txtCariNopol"
        Me.txtCariNopol.Size = New System.Drawing.Size(100, 20)
        Me.txtCariNopol.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(636, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Nopol"
        '
        'txtCariSopir
        '
        Me.txtCariSopir.Location = New System.Drawing.Point(529, 15)
        Me.txtCariSopir.Name = "txtCariSopir"
        Me.txtCariSopir.Size = New System.Drawing.Size(100, 20)
        Me.txtCariSopir.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(491, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Sopir"
        '
        'dtpAkhirPeriode
        '
        Me.dtpAkhirPeriode.CustomFormat = "dd-MM-yyyy"
        Me.dtpAkhirPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAkhirPeriode.Location = New System.Drawing.Point(385, 16)
        Me.dtpAkhirPeriode.Name = "dtpAkhirPeriode"
        Me.dtpAkhirPeriode.Size = New System.Drawing.Size(97, 20)
        Me.dtpAkhirPeriode.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(356, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "s/d"
        '
        'dtpAwalPeriode
        '
        Me.dtpAwalPeriode.CustomFormat = "dd-MM-yyyy"
        Me.dtpAwalPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAwalPeriode.Location = New System.Drawing.Point(248, 15)
        Me.dtpAwalPeriode.Name = "dtpAwalPeriode"
        Me.dtpAwalPeriode.Size = New System.Drawing.Size(97, 20)
        Me.dtpAwalPeriode.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Periode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "No BM"
        '
        'txtNoBM
        '
        Me.txtNoBM.Location = New System.Drawing.Point(58, 16)
        Me.txtNoBM.Name = "txtNoBM"
        Me.txtNoBM.Size = New System.Drawing.Size(122, 20)
        Me.txtNoBM.TabIndex = 11
        '
        'frmSetorSuratJalan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 366)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.txtCariNopol)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCariSopir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpAkhirPeriode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpAwalPeriode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNoBM)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.dgvSetorSuratJalan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetorSuratJalan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Setor Surat Jalan :."
        CType(Me.dgvSetorSuratJalan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSetorSuratJalan As System.Windows.Forms.DataGridView
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents noBM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nopol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoSJ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Supir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Asal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tujuan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Supplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tanggal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Setor As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents txtCariNopol As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCariSopir As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpAkhirPeriode As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpAwalPeriode As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoBM As System.Windows.Forms.TextBox
End Class
