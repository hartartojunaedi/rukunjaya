<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCetakVoucher
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnovoucher = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnoBm = New System.Windows.Forms.TextBox()
        Me.txtnosuratjalan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.P = New System.Windows.Forms.Label()
        Me.dtpawal = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpakhir = New System.Windows.Forms.DateTimePicker()
        Me.txtnopol = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cbspbu = New System.Windows.Forms.ComboBox()
        Me.kodevoucher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nobm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nosuratjalan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namaspbu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.liter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kasbon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nopol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cetak = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnCari = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Voucher"
        '
        'txtnovoucher
        '
        Me.txtnovoucher.Location = New System.Drawing.Point(66, 10)
        Me.txtnovoucher.Name = "txtnovoucher"
        Me.txtnovoucher.Size = New System.Drawing.Size(82, 20)
        Me.txtnovoucher.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "BM"
        '
        'txtnoBm
        '
        Me.txtnoBm.Location = New System.Drawing.Point(183, 10)
        Me.txtnoBm.Name = "txtnoBm"
        Me.txtnoBm.Size = New System.Drawing.Size(90, 20)
        Me.txtnoBm.TabIndex = 2
        '
        'txtnosuratjalan
        '
        Me.txtnosuratjalan.Location = New System.Drawing.Point(343, 10)
        Me.txtnosuratjalan.Name = "txtnosuratjalan"
        Me.txtnosuratjalan.Size = New System.Drawing.Size(100, 20)
        Me.txtnosuratjalan.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(279, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Surat Jalan "
        '
        'P
        '
        Me.P.AutoSize = True
        Me.P.Location = New System.Drawing.Point(563, 13)
        Me.P.Name = "P"
        Me.P.Size = New System.Drawing.Size(52, 13)
        Me.P.TabIndex = 6
        Me.P.Text = "Periode : "
        '
        'dtpawal
        '
        Me.dtpawal.CustomFormat = "dd-MM-yyyy"
        Me.dtpawal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpawal.Location = New System.Drawing.Point(621, 11)
        Me.dtpawal.Name = "dtpawal"
        Me.dtpawal.Size = New System.Drawing.Size(91, 20)
        Me.dtpawal.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(718, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "-"
        '
        'dtpakhir
        '
        Me.dtpakhir.CustomFormat = "dd-MM-yyyy"
        Me.dtpakhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpakhir.Location = New System.Drawing.Point(734, 11)
        Me.dtpakhir.Name = "dtpakhir"
        Me.dtpakhir.Size = New System.Drawing.Size(91, 20)
        Me.dtpakhir.TabIndex = 6
        '
        'txtnopol
        '
        Me.txtnopol.Location = New System.Drawing.Point(490, 11)
        Me.txtnopol.Name = "txtnopol"
        Me.txtnopol.Size = New System.Drawing.Size(67, 20)
        Me.txtnopol.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(449, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Nopol"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodevoucher, Me.nobm, Me.nosuratjalan, Me.namaspbu, Me.liter, Me.kasbon, Me.tgl, Me.nopol, Me.cetak})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 51)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1027, 312)
        Me.DataGridView1.TabIndex = 27
        '
        'cbspbu
        '
        Me.cbspbu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbspbu.FormattingEnabled = True
        Me.cbspbu.Location = New System.Drawing.Point(832, 9)
        Me.cbspbu.Name = "cbspbu"
        Me.cbspbu.Size = New System.Drawing.Size(135, 21)
        Me.cbspbu.TabIndex = 28
        '
        'kodevoucher
        '
        Me.kodevoucher.DataPropertyName = "kodevoucher"
        Me.kodevoucher.HeaderText = "No Voucher"
        Me.kodevoucher.Name = "kodevoucher"
        Me.kodevoucher.ReadOnly = True
        '
        'nobm
        '
        Me.nobm.DataPropertyName = "nobm"
        Me.nobm.HeaderText = "No BM"
        Me.nobm.Name = "nobm"
        Me.nobm.ReadOnly = True
        '
        'nosuratjalan
        '
        Me.nosuratjalan.DataPropertyName = "nosuratjalan"
        Me.nosuratjalan.HeaderText = "No Surat Jalan"
        Me.nosuratjalan.Name = "nosuratjalan"
        Me.nosuratjalan.ReadOnly = True
        '
        'namaspbu
        '
        Me.namaspbu.DataPropertyName = "namaspbu"
        Me.namaspbu.HeaderText = "Nama SPBU"
        Me.namaspbu.Name = "namaspbu"
        Me.namaspbu.ReadOnly = True
        '
        'liter
        '
        Me.liter.DataPropertyName = "liter"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "N2"
        Me.liter.DefaultCellStyle = DataGridViewCellStyle1
        Me.liter.HeaderText = "Liter"
        Me.liter.Name = "liter"
        Me.liter.ReadOnly = True
        '
        'kasbon
        '
        Me.kasbon.DataPropertyName = "kasbon"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "N"
        Me.kasbon.DefaultCellStyle = DataGridViewCellStyle2
        Me.kasbon.HeaderText = "Kas Bon"
        Me.kasbon.Name = "kasbon"
        Me.kasbon.ReadOnly = True
        '
        'tgl
        '
        Me.tgl.DataPropertyName = "tgl"
        DataGridViewCellStyle3.Format = "dd-MM-yyyy"
        Me.tgl.DefaultCellStyle = DataGridViewCellStyle3
        Me.tgl.HeaderText = "Tanggal"
        Me.tgl.Name = "tgl"
        Me.tgl.ReadOnly = True
        '
        'nopol
        '
        Me.nopol.DataPropertyName = "nopol"
        Me.nopol.HeaderText = "Nopol"
        Me.nopol.Name = "nopol"
        Me.nopol.ReadOnly = True
        '
        'cetak
        '
        Me.cetak.HeaderText = "Cetak"
        Me.cetak.Name = "cetak"
        Me.cetak.ReadOnly = True
        Me.cetak.Text = "Cetak"
        Me.cetak.UseColumnTextForButtonValue = True
        '
        'btnCari
        '
        Me.btnCari.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCari.Location = New System.Drawing.Point(973, 9)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(66, 28)
        Me.btnCari.TabIndex = 7
        Me.btnCari.Text = "Filter"
        Me.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'frmCetakVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 375)
        Me.Controls.Add(Me.cbspbu)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtnopol)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.dtpakhir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpawal)
        Me.Controls.Add(Me.P)
        Me.Controls.Add(Me.txtnosuratjalan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnoBm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnovoucher)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCetakVoucher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Cetak Voucher :."
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnovoucher As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnoBm As System.Windows.Forms.TextBox
    Friend WithEvents txtnosuratjalan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents P As System.Windows.Forms.Label
    Friend WithEvents dtpawal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpakhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents txtnopol As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cbspbu As System.Windows.Forms.ComboBox
    Friend WithEvents kodevoucher As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nobm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nosuratjalan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namaspbu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents liter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kasbon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tgl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nopol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cetak As System.Windows.Forms.DataGridViewButtonColumn
End Class
