﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSerachSJBuatPenagihan
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtNoBM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpAwalPeriode = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpAkhirPeriode = New System.Windows.Forms.DateTimePicker()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSuratJalan = New System.Windows.Forms.TextBox()
        Me.dgvBM = New System.Windows.Forms.DataGridView()
        Me.nosuratjalan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoBM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TGL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoLambung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOPOL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMAJENIS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMAPEKERJAAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalOngkos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SetOngkos = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.NamaPanggilan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BORONGANSOPIR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCariNopol = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvBM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNoBM
        '
        Me.txtNoBM.Location = New System.Drawing.Point(227, 11)
        Me.txtNoBM.Name = "txtNoBM"
        Me.txtNoBM.Size = New System.Drawing.Size(122, 20)
        Me.txtNoBM.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(181, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No BM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(355, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Periode"
        '
        'dtpAwalPeriode
        '
        Me.dtpAwalPeriode.CustomFormat = "dd-MM-yyyy"
        Me.dtpAwalPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAwalPeriode.Location = New System.Drawing.Point(405, 10)
        Me.dtpAwalPeriode.Name = "dtpAwalPeriode"
        Me.dtpAwalPeriode.Size = New System.Drawing.Size(97, 20)
        Me.dtpAwalPeriode.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(508, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "s/d"
        '
        'dtpAkhirPeriode
        '
        Me.dtpAkhirPeriode.CustomFormat = "dd-MM-yyyy"
        Me.dtpAkhirPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAkhirPeriode.Location = New System.Drawing.Point(537, 8)
        Me.dtpAkhirPeriode.Name = "dtpAkhirPeriode"
        Me.dtpAkhirPeriode.Size = New System.Drawing.Size(97, 20)
        Me.dtpAkhirPeriode.TabIndex = 5
        '
        'btnFilter
        '
        Me.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFilter.Location = New System.Drawing.Point(787, 2)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(66, 36)
        Me.btnFilter.TabIndex = 10
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "No Surat Jalan"
        '
        'txtSuratJalan
        '
        Me.txtSuratJalan.Location = New System.Drawing.Point(83, 10)
        Me.txtSuratJalan.Name = "txtSuratJalan"
        Me.txtSuratJalan.Size = New System.Drawing.Size(92, 20)
        Me.txtSuratJalan.TabIndex = 14
        '
        'dgvBM
        '
        Me.dgvBM.AllowUserToAddRows = False
        Me.dgvBM.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBM.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nosuratjalan, Me.NoBM, Me.TGL, Me.NoLambung, Me.NOPOL, Me.NAMAJENIS, Me.NamaSupplier, Me.NAMAPEKERJAAN, Me.TotalOngkos, Me.SetOngkos, Me.NamaPanggilan, Me.BORONGANSOPIR})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBM.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvBM.Location = New System.Drawing.Point(7, 41)
        Me.dgvBM.MultiSelect = False
        Me.dgvBM.Name = "dgvBM"
        Me.dgvBM.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBM.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvBM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBM.Size = New System.Drawing.Size(1016, 283)
        Me.dgvBM.TabIndex = 16
        '
        'nosuratjalan
        '
        Me.nosuratjalan.DataPropertyName = "NOSURATJALAN"
        Me.nosuratjalan.HeaderText = "No Surat Jalan"
        Me.nosuratjalan.Name = "nosuratjalan"
        Me.nosuratjalan.ReadOnly = True
        '
        'NoBM
        '
        Me.NoBM.DataPropertyName = "NOBM"
        Me.NoBM.HeaderText = "No Bon Muat"
        Me.NoBM.Name = "NoBM"
        Me.NoBM.ReadOnly = True
        '
        'TGL
        '
        Me.TGL.DataPropertyName = "TGL"
        DataGridViewCellStyle2.Format = "dd-MM-yyyy"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.TGL.DefaultCellStyle = DataGridViewCellStyle2
        Me.TGL.HeaderText = "Tanggal (dd-mm-yyyy)"
        Me.TGL.Name = "TGL"
        Me.TGL.ReadOnly = True
        '
        'NoLambung
        '
        Me.NoLambung.DataPropertyName = "NOLAMBUNG"
        Me.NoLambung.HeaderText = "No Lambung"
        Me.NoLambung.Name = "NoLambung"
        Me.NoLambung.ReadOnly = True
        '
        'NOPOL
        '
        Me.NOPOL.DataPropertyName = "nopol"
        Me.NOPOL.HeaderText = "No Polisi"
        Me.NOPOL.Name = "NOPOL"
        Me.NOPOL.ReadOnly = True
        '
        'NAMAJENIS
        '
        Me.NAMAJENIS.DataPropertyName = "NAMAjenis"
        Me.NAMAJENIS.HeaderText = "Jenis Kendaraan"
        Me.NAMAJENIS.Name = "NAMAJENIS"
        Me.NAMAJENIS.ReadOnly = True
        '
        'NamaSupplier
        '
        Me.NamaSupplier.DataPropertyName = "namasupplier"
        Me.NamaSupplier.HeaderText = "Nama Supplier"
        Me.NamaSupplier.Name = "NamaSupplier"
        Me.NamaSupplier.ReadOnly = True
        Me.NamaSupplier.Width = 145
        '
        'NAMAPEKERJAAN
        '
        Me.NAMAPEKERJAAN.DataPropertyName = "namapekerjaan"
        Me.NAMAPEKERJAAN.HeaderText = "Jenis Pekerjaan"
        Me.NAMAPEKERJAAN.Name = "NAMAPEKERJAAN"
        Me.NAMAPEKERJAAN.ReadOnly = True
        Me.NAMAPEKERJAAN.Width = 125
        '
        'TotalOngkos
        '
        Me.TotalOngkos.DataPropertyName = "TOTALBORONGANSUPPLIER"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.TotalOngkos.DefaultCellStyle = DataGridViewCellStyle3
        Me.TotalOngkos.HeaderText = "Total Ongkos"
        Me.TotalOngkos.Name = "TotalOngkos"
        Me.TotalOngkos.ReadOnly = True
        '
        'SetOngkos
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.SetOngkos.DefaultCellStyle = DataGridViewCellStyle4
        Me.SetOngkos.HeaderText = ""
        Me.SetOngkos.Name = "SetOngkos"
        Me.SetOngkos.ReadOnly = True
        Me.SetOngkos.Text = "Set Ongkos"
        Me.SetOngkos.UseColumnTextForButtonValue = True
        Me.SetOngkos.Visible = False
        '
        'NamaPanggilan
        '
        Me.NamaPanggilan.DataPropertyName = "alamatsupplier"
        Me.NamaPanggilan.HeaderText = "Alamat Supplier"
        Me.NamaPanggilan.Name = "NamaPanggilan"
        Me.NamaPanggilan.ReadOnly = True
        Me.NamaPanggilan.Visible = False
        Me.NamaPanggilan.Width = 170
        '
        'BORONGANSOPIR
        '
        Me.BORONGANSOPIR.DataPropertyName = "BORONGANSOPIR"
        Me.BORONGANSOPIR.HeaderText = "Ongkos Sopir"
        Me.BORONGANSOPIR.Name = "BORONGANSOPIR"
        Me.BORONGANSOPIR.ReadOnly = True
        Me.BORONGANSOPIR.Visible = False
        '
        'txtCariNopol
        '
        Me.txtCariNopol.Location = New System.Drawing.Point(681, 10)
        Me.txtCariNopol.Name = "txtCariNopol"
        Me.txtCariNopol.Size = New System.Drawing.Size(100, 20)
        Me.txtCariNopol.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(640, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Nopol"
        '
        'frmSerachSJBuatPenagihan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 368)
        Me.Controls.Add(Me.txtCariNopol)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvBM)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSuratJalan)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.dtpAkhirPeriode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpAwalPeriode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNoBM)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSerachSJBuatPenagihan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Search Buat Penagihan :."
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
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSuratJalan As System.Windows.Forms.TextBox
    Friend WithEvents dgvBM As System.Windows.Forms.DataGridView
    Friend WithEvents txtCariNopol As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nosuratjalan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoBM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TGL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoLambung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOPOL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAMAJENIS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaSupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAMAPEKERJAAN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalOngkos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SetOngkos As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents NamaPanggilan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BORONGANSOPIR As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
