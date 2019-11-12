<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailBM
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.noSJ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.perwakilan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.asal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tujuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detail = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblKodeBM = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTgl = New System.Windows.Forms.Label()
        Me.lblPanggilan = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblNamaSopir = New System.Windows.Forms.Label()
        Me.lblNopol = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblNoLambung = New System.Windows.Forms.Label()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblMerek = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.noSJ, Me.supplier, Me.perwakilan, Me.asal, Me.tujuan, Me.detail})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 139)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(766, 300)
        Me.DataGridView1.TabIndex = 0
        '
        'noSJ
        '
        Me.noSJ.DataPropertyName = "noSuratJalan"
        Me.noSJ.HeaderText = "No SJ"
        Me.noSJ.Name = "noSJ"
        Me.noSJ.ReadOnly = True
        '
        'supplier
        '
        Me.supplier.DataPropertyName = "namasupplier"
        Me.supplier.HeaderText = "Supplier"
        Me.supplier.Name = "supplier"
        Me.supplier.ReadOnly = True
        '
        'perwakilan
        '
        Me.perwakilan.DataPropertyName = "namaperwakilan"
        Me.perwakilan.HeaderText = "Perwakilan"
        Me.perwakilan.Name = "perwakilan"
        Me.perwakilan.ReadOnly = True
        '
        'asal
        '
        Me.asal.DataPropertyName = "asal"
        Me.asal.HeaderText = "Asal"
        Me.asal.Name = "asal"
        Me.asal.ReadOnly = True
        '
        'tujuan
        '
        Me.tujuan.DataPropertyName = "tujuan"
        Me.tujuan.HeaderText = "Tujuan"
        Me.tujuan.Name = "tujuan"
        Me.tujuan.ReadOnly = True
        '
        'detail
        '
        Me.detail.HeaderText = "Detail"
        Me.detail.Name = "detail"
        Me.detail.ReadOnly = True
        Me.detail.Text = "Detail"
        Me.detail.UseColumnTextForButtonValue = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data Bon Muat"
        '
        'lblKodeBM
        '
        Me.lblKodeBM.AutoSize = True
        Me.lblKodeBM.Location = New System.Drawing.Point(105, 32)
        Me.lblKodeBM.Name = "lblKodeBM"
        Me.lblKodeBM.Size = New System.Drawing.Size(31, 13)
        Me.lblKodeBM.TabIndex = 2
        Me.lblKodeBM.Text = "kode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Kode Bon Muat :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tanggal :"
        '
        'lblTgl
        '
        Me.lblTgl.AutoSize = True
        Me.lblTgl.Location = New System.Drawing.Point(105, 54)
        Me.lblTgl.Name = "lblTgl"
        Me.lblTgl.Size = New System.Drawing.Size(18, 13)
        Me.lblTgl.TabIndex = 5
        Me.lblTgl.Text = "tgl"
        '
        'lblPanggilan
        '
        Me.lblPanggilan.AutoSize = True
        Me.lblPanggilan.Location = New System.Drawing.Point(323, 101)
        Me.lblPanggilan.Name = "lblPanggilan"
        Me.lblPanggilan.Size = New System.Drawing.Size(53, 13)
        Me.lblPanggilan.TabIndex = 9
        Me.lblPanggilan.Text = "panggilan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(257, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Panggilan :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(249, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Nama Sopir :"
        '
        'lblNamaSopir
        '
        Me.lblNamaSopir.AutoSize = True
        Me.lblNamaSopir.Location = New System.Drawing.Point(323, 79)
        Me.lblNamaSopir.Name = "lblNamaSopir"
        Me.lblNamaSopir.Size = New System.Drawing.Size(33, 13)
        Me.lblNamaSopir.TabIndex = 6
        Me.lblNamaSopir.Text = "nama"
        '
        'lblNopol
        '
        Me.lblNopol.AutoSize = True
        Me.lblNopol.Location = New System.Drawing.Point(105, 101)
        Me.lblNopol.Name = "lblNopol"
        Me.lblNopol.Size = New System.Drawing.Size(33, 13)
        Me.lblNopol.TabIndex = 13
        Me.lblNopol.Text = "nopol"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(47, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "No polisi :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "No Lambung :"
        '
        'lblNoLambung
        '
        Me.lblNoLambung.AutoSize = True
        Me.lblNoLambung.Location = New System.Drawing.Point(105, 79)
        Me.lblNoLambung.Name = "lblNoLambung"
        Me.lblNoLambung.Size = New System.Drawing.Size(59, 13)
        Me.lblNoLambung.TabIndex = 10
        Me.lblNoLambung.Text = "nolambung"
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Location = New System.Drawing.Point(323, 54)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(28, 13)
        Me.lblJenis.TabIndex = 17
        Me.lblJenis.Text = "jenis"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(280, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Jenis :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(274, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Merek :"
        '
        'lblMerek
        '
        Me.lblMerek.AutoSize = True
        Me.lblMerek.Location = New System.Drawing.Point(323, 32)
        Me.lblMerek.Name = "lblMerek"
        Me.lblMerek.Size = New System.Drawing.Size(36, 13)
        Me.lblMerek.TabIndex = 14
        Me.lblMerek.Text = "merek"
        '
        'frmDetailBM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 453)
        Me.Controls.Add(Me.lblJenis)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblMerek)
        Me.Controls.Add(Me.lblNopol)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblNoLambung)
        Me.Controls.Add(Me.lblPanggilan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblNamaSopir)
        Me.Controls.Add(Me.lblTgl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblKodeBM)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetailBM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Detail Bon Muat :."
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblKodeBM As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTgl As System.Windows.Forms.Label
    Friend WithEvents lblPanggilan As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblNamaSopir As System.Windows.Forms.Label
    Friend WithEvents lblNopol As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblNoLambung As System.Windows.Forms.Label
    Friend WithEvents lblJenis As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblMerek As System.Windows.Forms.Label
    Friend WithEvents noSJ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents perwakilan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents asal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tujuan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents detail As System.Windows.Forms.DataGridViewButtonColumn
End Class
