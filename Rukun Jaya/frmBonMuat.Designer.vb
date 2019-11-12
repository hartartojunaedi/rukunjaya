<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBonMuat
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoBM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtTglAwal = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtTglAkhir = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSopir = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNopol = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblJumlahData = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.nobm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nolambung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nopol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namajenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namasopir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panggilan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hapus = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No BM : "
        '
        'txtNoBM
        '
        Me.txtNoBM.Location = New System.Drawing.Point(68, 13)
        Me.txtNoBM.Name = "txtNoBM"
        Me.txtNoBM.Size = New System.Drawing.Size(75, 20)
        Me.txtNoBM.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(150, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Periode : "
        '
        'dtTglAwal
        '
        Me.dtTglAwal.CustomFormat = "dd-MM-yyyy"
        Me.dtTglAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTglAwal.Location = New System.Drawing.Point(208, 9)
        Me.dtTglAwal.Name = "dtTglAwal"
        Me.dtTglAwal.Size = New System.Drawing.Size(96, 20)
        Me.dtTglAwal.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(310, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "s/d"
        '
        'dtTglAkhir
        '
        Me.dtTglAkhir.CustomFormat = "dd-MM-yyyy"
        Me.dtTglAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTglAkhir.Location = New System.Drawing.Point(339, 8)
        Me.dtTglAkhir.Name = "dtTglAkhir"
        Me.dtTglAkhir.Size = New System.Drawing.Size(96, 20)
        Me.dtTglAkhir.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(443, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Sopir : "
        '
        'txtSopir
        '
        Me.txtSopir.Location = New System.Drawing.Point(489, 9)
        Me.txtSopir.Name = "txtSopir"
        Me.txtSopir.Size = New System.Drawing.Size(100, 20)
        Me.txtSopir.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(598, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nopol : "
        '
        'txtNopol
        '
        Me.txtNopol.Location = New System.Drawing.Point(648, 9)
        Me.txtNopol.Name = "txtNopol"
        Me.txtNopol.Size = New System.Drawing.Size(68, 20)
        Me.txtNopol.TabIndex = 9
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nobm, Me.tgl, Me.nolambung, Me.nopol, Me.namajenis, Me.namasopir, Me.panggilan, Me.Hapus})
        Me.DataGridView1.Location = New System.Drawing.Point(16, 51)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(798, 277)
        Me.DataGridView1.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(695, 343)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Jumlah Data : "
        '
        'lblJumlahData
        '
        Me.lblJumlahData.AutoSize = True
        Me.lblJumlahData.Location = New System.Drawing.Point(777, 343)
        Me.lblJumlahData.Name = "lblJumlahData"
        Me.lblJumlahData.Size = New System.Drawing.Size(13, 13)
        Me.lblJumlahData.TabIndex = 14
        Me.lblJumlahData.Text = "0"
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon1
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(16, 343)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(80, 29)
        Me.btnTambah.TabIndex = 12
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnFilter
        '
        Me.btnFilter.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFilter.Location = New System.Drawing.Point(726, 7)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(80, 29)
        Me.btnFilter.TabIndex = 10
        Me.btnFilter.Text = "&Filter"
        Me.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'nobm
        '
        Me.nobm.DataPropertyName = "noBM"
        Me.nobm.HeaderText = "No Bon Muat"
        Me.nobm.Name = "nobm"
        Me.nobm.ReadOnly = True
        '
        'tgl
        '
        Me.tgl.DataPropertyName = "tgl"
        DataGridViewCellStyle1.Format = "dd-MM-yyyy"
        Me.tgl.DefaultCellStyle = DataGridViewCellStyle1
        Me.tgl.HeaderText = "Tanggal"
        Me.tgl.Name = "tgl"
        Me.tgl.ReadOnly = True
        '
        'nolambung
        '
        Me.nolambung.DataPropertyName = "nolambung"
        Me.nolambung.HeaderText = "No Lambung"
        Me.nolambung.Name = "nolambung"
        Me.nolambung.ReadOnly = True
        '
        'nopol
        '
        Me.nopol.DataPropertyName = "nopol"
        Me.nopol.HeaderText = "No. Polisi"
        Me.nopol.Name = "nopol"
        Me.nopol.ReadOnly = True
        '
        'namajenis
        '
        Me.namajenis.DataPropertyName = "namajenis"
        Me.namajenis.HeaderText = "Jenis Kendaraan"
        Me.namajenis.Name = "namajenis"
        Me.namajenis.ReadOnly = True
        '
        'namasopir
        '
        Me.namasopir.DataPropertyName = "namasopir"
        Me.namasopir.HeaderText = "Nama Sopir"
        Me.namasopir.Name = "namasopir"
        Me.namasopir.ReadOnly = True
        '
        'panggilan
        '
        Me.panggilan.DataPropertyName = "panggilan"
        Me.panggilan.HeaderText = "Nama Panggilan"
        Me.panggilan.Name = "panggilan"
        Me.panggilan.ReadOnly = True
        '
        'Hapus
        '
        Me.Hapus.HeaderText = "Hapus"
        Me.Hapus.Name = "Hapus"
        Me.Hapus.ReadOnly = True
        Me.Hapus.Text = "Hapus"
        Me.Hapus.Visible = False
        Me.Hapus.Width = 45
        '
        'frmBonMuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 378)
        Me.Controls.Add(Me.lblJumlahData)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.txtNopol)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSopir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtTglAkhir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtTglAwal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNoBM)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBonMuat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Bon Muat :."
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoBM As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtTglAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtTglAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSopir As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNopol As System.Windows.Forms.TextBox
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblJumlahData As System.Windows.Forms.Label
    Friend WithEvents nobm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tgl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nolambung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nopol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namajenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namasopir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents panggilan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hapus As System.Windows.Forms.DataGridViewButtonColumn
End Class
