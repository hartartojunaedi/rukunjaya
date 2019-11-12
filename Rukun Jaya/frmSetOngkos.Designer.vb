<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransaksiSetOngkos
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
        Me.txtNoBM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpAwalPeriode = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpAkhirPeriode = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCariSopir = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCariNopol = New System.Windows.Forms.TextBox()
        Me.dgvBM = New System.Windows.Forms.DataGridView()
        Me.NoBM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoLambung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nopolisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisKendaraan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Namasopir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaPanggilan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalOngkos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SetOngkos = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnFilter = New System.Windows.Forms.Button()
        CType(Me.dgvBM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNoBM
        '
        Me.txtNoBM.Location = New System.Drawing.Point(58, 6)
        Me.txtNoBM.Name = "txtNoBM"
        Me.txtNoBM.Size = New System.Drawing.Size(122, 20)
        Me.txtNoBM.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No BM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Periode"
        '
        'dtpAwalPeriode
        '
        Me.dtpAwalPeriode.CustomFormat = "dd-MM-yyyy"
        Me.dtpAwalPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAwalPeriode.Location = New System.Drawing.Point(248, 5)
        Me.dtpAwalPeriode.Name = "dtpAwalPeriode"
        Me.dtpAwalPeriode.Size = New System.Drawing.Size(97, 20)
        Me.dtpAwalPeriode.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(356, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "s/d"
        '
        'dtpAkhirPeriode
        '
        Me.dtpAkhirPeriode.CustomFormat = "dd-MM-yyyy"
        Me.dtpAkhirPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAkhirPeriode.Location = New System.Drawing.Point(385, 6)
        Me.dtpAkhirPeriode.Name = "dtpAkhirPeriode"
        Me.dtpAkhirPeriode.Size = New System.Drawing.Size(97, 20)
        Me.dtpAkhirPeriode.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(491, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Sopir"
        '
        'txtCariSopir
        '
        Me.txtCariSopir.Location = New System.Drawing.Point(529, 5)
        Me.txtCariSopir.Name = "txtCariSopir"
        Me.txtCariSopir.Size = New System.Drawing.Size(100, 20)
        Me.txtCariSopir.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(636, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nopol"
        '
        'txtCariNopol
        '
        Me.txtCariNopol.Location = New System.Drawing.Point(678, 5)
        Me.txtCariNopol.Name = "txtCariNopol"
        Me.txtCariNopol.Size = New System.Drawing.Size(100, 20)
        Me.txtCariNopol.TabIndex = 9
        '
        'dgvBM
        '
        Me.dgvBM.AllowUserToAddRows = False
        Me.dgvBM.AllowUserToDeleteRows = False
        Me.dgvBM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoBM, Me.Tanggal, Me.NoLambung, Me.nopolisi, Me.JenisKendaraan, Me.Namasopir, Me.NamaPanggilan, Me.TotalOngkos, Me.SetOngkos})
        Me.dgvBM.Location = New System.Drawing.Point(13, 46)
        Me.dgvBM.Name = "dgvBM"
        Me.dgvBM.ReadOnly = True
        Me.dgvBM.Size = New System.Drawing.Size(944, 283)
        Me.dgvBM.TabIndex = 11
        '
        'NoBM
        '
        Me.NoBM.DataPropertyName = "noBM"
        Me.NoBM.HeaderText = "No Bon Muat"
        Me.NoBM.Name = "NoBM"
        Me.NoBM.ReadOnly = True
        '
        'Tanggal
        '
        Me.Tanggal.DataPropertyName = "tgl"
        DataGridViewCellStyle1.Format = "dd-MM-yyyy"
        Me.Tanggal.DefaultCellStyle = DataGridViewCellStyle1
        Me.Tanggal.HeaderText = "Tanggal"
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.ReadOnly = True
        '
        'NoLambung
        '
        Me.NoLambung.DataPropertyName = "nolambung"
        Me.NoLambung.HeaderText = "No Lambung"
        Me.NoLambung.Name = "NoLambung"
        Me.NoLambung.ReadOnly = True
        '
        'nopolisi
        '
        Me.nopolisi.DataPropertyName = "nopol"
        Me.nopolisi.HeaderText = "No Polisi"
        Me.nopolisi.Name = "nopolisi"
        Me.nopolisi.ReadOnly = True
        '
        'JenisKendaraan
        '
        Me.JenisKendaraan.DataPropertyName = "namajenis"
        Me.JenisKendaraan.HeaderText = "Jenis Kendaraan"
        Me.JenisKendaraan.Name = "JenisKendaraan"
        Me.JenisKendaraan.ReadOnly = True
        '
        'Namasopir
        '
        Me.Namasopir.DataPropertyName = "namasopir"
        Me.Namasopir.HeaderText = "Nama Sopir"
        Me.Namasopir.Name = "Namasopir"
        Me.Namasopir.ReadOnly = True
        '
        'NamaPanggilan
        '
        Me.NamaPanggilan.DataPropertyName = "panggilan"
        Me.NamaPanggilan.HeaderText = "Nama Panggilan"
        Me.NamaPanggilan.Name = "NamaPanggilan"
        Me.NamaPanggilan.ReadOnly = True
        '
        'TotalOngkos
        '
        Me.TotalOngkos.DataPropertyName = "total"
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.TotalOngkos.DefaultCellStyle = DataGridViewCellStyle2
        Me.TotalOngkos.HeaderText = "Total Ongkos"
        Me.TotalOngkos.Name = "TotalOngkos"
        Me.TotalOngkos.ReadOnly = True
        '
        'SetOngkos
        '
        Me.SetOngkos.HeaderText = ""
        Me.SetOngkos.Name = "SetOngkos"
        Me.SetOngkos.ReadOnly = True
        Me.SetOngkos.Text = "Set Ongkos"
        Me.SetOngkos.UseColumnTextForButtonValue = True
        '
        'btnFilter
        '
        Me.btnFilter.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFilter.Location = New System.Drawing.Point(784, 4)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(66, 36)
        Me.btnFilter.TabIndex = 10
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'frmTransaksiSetOngkos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 368)
        Me.Controls.Add(Me.dgvBM)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTransaksiSetOngkos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Transaksi Set Ongkos :."
        CType(Me.dgvBM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNoBM As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpAwalPeriode As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpAkhirPeriode As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCariSopir As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCariNopol As System.Windows.Forms.TextBox
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents dgvBM As System.Windows.Forms.DataGridView
    Friend WithEvents NoBM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tanggal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoLambung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nopolisi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JenisKendaraan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Namasopir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaPanggilan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalOngkos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SetOngkos As System.Windows.Forms.DataGridViewButtonColumn
End Class
