<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowseBarang
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
        Me.txtnamabarang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvKendaraan = New System.Windows.Forms.DataGridView()
        Me.kodebarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namabarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.satuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblJumData = New System.Windows.Forms.Label()
        Me.txtkodebarang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnfilter = New System.Windows.Forms.Button()
        CType(Me.dgvKendaraan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnamabarang
        '
        Me.txtnamabarang.Location = New System.Drawing.Point(369, 35)
        Me.txtnamabarang.Name = "txtnamabarang"
        Me.txtnamabarang.Size = New System.Drawing.Size(173, 20)
        Me.txtnamabarang.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(264, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cari Nama Barang :"
        '
        'dgvKendaraan
        '
        Me.dgvKendaraan.AllowUserToAddRows = False
        Me.dgvKendaraan.AllowUserToDeleteRows = False
        Me.dgvKendaraan.AllowUserToOrderColumns = True
        Me.dgvKendaraan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKendaraan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodebarang, Me.namabarang, Me.satuan})
        Me.dgvKendaraan.Location = New System.Drawing.Point(12, 61)
        Me.dgvKendaraan.Name = "dgvKendaraan"
        Me.dgvKendaraan.ReadOnly = True
        Me.dgvKendaraan.Size = New System.Drawing.Size(633, 303)
        Me.dgvKendaraan.TabIndex = 6
        '
        'kodebarang
        '
        Me.kodebarang.DataPropertyName = "kodebarang"
        Me.kodebarang.Frozen = True
        Me.kodebarang.HeaderText = "Kode Barang"
        Me.kodebarang.Name = "kodebarang"
        Me.kodebarang.ReadOnly = True
        '
        'namabarang
        '
        Me.namabarang.DataPropertyName = "namabarang"
        Me.namabarang.HeaderText = "Nama Barang"
        Me.namabarang.Name = "namabarang"
        Me.namabarang.ReadOnly = True
        Me.namabarang.ToolTipText = "Nama Barang"
        '
        'satuan
        '
        Me.satuan.DataPropertyName = "satuan"
        Me.satuan.HeaderText = "Satuan"
        Me.satuan.Name = "satuan"
        Me.satuan.ReadOnly = True
        Me.satuan.ToolTipText = "Satuan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(528, 376)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Jumlah data :"
        '
        'lblJumData
        '
        Me.lblJumData.AutoSize = True
        Me.lblJumData.Location = New System.Drawing.Point(605, 376)
        Me.lblJumData.Name = "lblJumData"
        Me.lblJumData.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblJumData.Size = New System.Drawing.Size(39, 13)
        Me.lblJumData.TabIndex = 11
        Me.lblJumData.Text = "Label4"
        Me.lblJumData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtkodebarang
        '
        Me.txtkodebarang.Location = New System.Drawing.Point(369, 9)
        Me.txtkodebarang.Name = "txtkodebarang"
        Me.txtkodebarang.Size = New System.Drawing.Size(173, 20)
        Me.txtkodebarang.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(267, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Cari Kode Barang :"
        '
        'btnfilter
        '
        Me.btnfilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnfilter.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnfilter.Location = New System.Drawing.Point(548, 9)
        Me.btnfilter.Name = "btnfilter"
        Me.btnfilter.Size = New System.Drawing.Size(97, 46)
        Me.btnfilter.TabIndex = 14
        Me.btnfilter.Text = "&Filter"
        Me.btnfilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnfilter.UseVisualStyleBackColor = True
        '
        'frmBrowseBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 396)
        Me.Controls.Add(Me.btnfilter)
        Me.Controls.Add(Me.txtkodebarang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblJumData)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvKendaraan)
        Me.Controls.Add(Me.txtnamabarang)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBrowseBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Browse Barang :."
        CType(Me.dgvKendaraan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnamabarang As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvKendaraan As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblJumData As System.Windows.Forms.Label
    'Friend WithEvents DataSet1 As RukunJaya.DataSet1
    'Friend WithEvents KendaraanTableAdapter As RukunJaya.DataSet1TableAdapters.kendaraanTableAdapter
    Friend WithEvents NolambungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NopolDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PemilikDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodeperusahaanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MerekDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TahunDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NorangkaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomesinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoBPKBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JatuhtempoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JenisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreatedateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UpdatedateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtkodebarang As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnfilter As System.Windows.Forms.Button
    Friend WithEvents kodebarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namabarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents satuan As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
