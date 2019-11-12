<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaptotalan
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.nototalan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namasopir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cetak = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.dtpakhir = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpawal = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.P = New System.Windows.Forms.Label()
        Me.cbsopir = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnototalan = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nototalan, Me.tgl, Me.namasopir, Me.cetak})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 53)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(825, 261)
        Me.DataGridView1.TabIndex = 42
        '
        'nototalan
        '
        Me.nototalan.DataPropertyName = "nototalan"
        Me.nototalan.Frozen = True
        Me.nototalan.HeaderText = "No. Totalan"
        Me.nototalan.Name = "nototalan"
        Me.nototalan.ReadOnly = True
        '
        'tgl
        '
        Me.tgl.DataPropertyName = "tanggal"
        DataGridViewCellStyle1.Format = "dd-MM-yyyy"
        Me.tgl.DefaultCellStyle = DataGridViewCellStyle1
        Me.tgl.Frozen = True
        Me.tgl.HeaderText = "Tanggal"
        Me.tgl.Name = "tgl"
        Me.tgl.ReadOnly = True
        '
        'namasopir
        '
        Me.namasopir.DataPropertyName = "namasopir"
        Me.namasopir.Frozen = True
        Me.namasopir.HeaderText = "Sopir"
        Me.namasopir.Name = "namasopir"
        Me.namasopir.ReadOnly = True
        '
        'cetak
        '
        Me.cetak.Frozen = True
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
        Me.btnCari.Location = New System.Drawing.Point(771, 6)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(66, 28)
        Me.btnCari.TabIndex = 39
        Me.btnCari.Text = "Filter"
        Me.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'dtpakhir
        '
        Me.dtpakhir.CustomFormat = "dd-MM-yyyy"
        Me.dtpakhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpakhir.Location = New System.Drawing.Point(662, 14)
        Me.dtpakhir.Name = "dtpakhir"
        Me.dtpakhir.Size = New System.Drawing.Size(91, 20)
        Me.dtpakhir.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(646, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "-"
        '
        'dtpawal
        '
        Me.dtpawal.CustomFormat = "dd-MM-yyyy"
        Me.dtpawal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpawal.Location = New System.Drawing.Point(549, 15)
        Me.dtpawal.Name = "dtpawal"
        Me.dtpawal.Size = New System.Drawing.Size(91, 20)
        Me.dtpawal.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Nama Sopir :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-171, -43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Voucher"
        '
        'P
        '
        Me.P.AutoSize = True
        Me.P.Location = New System.Drawing.Point(491, 17)
        Me.P.Name = "P"
        Me.P.Size = New System.Drawing.Size(52, 13)
        Me.P.TabIndex = 38
        Me.P.Text = "Periode : "
        '
        'cbsopir
        '
        Me.cbsopir.FormattingEnabled = True
        Me.cbsopir.Location = New System.Drawing.Point(91, 14)
        Me.cbsopir.Name = "cbsopir"
        Me.cbsopir.Size = New System.Drawing.Size(216, 21)
        Me.cbsopir.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(315, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "No. Totalan :"
        '
        'txtnototalan
        '
        Me.txtnototalan.Location = New System.Drawing.Point(382, 14)
        Me.txtnototalan.Name = "txtnototalan"
        Me.txtnototalan.Size = New System.Drawing.Size(100, 20)
        Me.txtnototalan.TabIndex = 46
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(4, 302)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(285, 114)
        Me.DataGridView2.TabIndex = 47
        Me.DataGridView2.Visible = False
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(295, 302)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(542, 114)
        Me.DataGridView3.TabIndex = 48
        Me.DataGridView3.Visible = False
        '
        'frmLaptotalan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 326)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.txtnototalan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbsopir)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.dtpakhir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpawal)
        Me.Controls.Add(Me.P)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLaptotalan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Laporan Totalan Sopir :."
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents dtpakhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpawal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents P As System.Windows.Forms.Label
    Friend WithEvents cbsopir As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnototalan As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents nototalan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tgl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namasopir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cetak As System.Windows.Forms.DataGridViewButtonColumn
End Class
