<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowseKendaraan
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
        Me.txtnopol = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvKendaraan = New System.Windows.Forms.DataGridView()
        Me.nolambung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nopol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.merek = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomesin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblJumData = New System.Windows.Forms.Label()
        Me.txtnomesin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnfilter = New System.Windows.Forms.Button()
        CType(Me.dgvKendaraan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnopol
        '
        Me.txtnopol.Location = New System.Drawing.Point(369, 35)
        Me.txtnopol.Name = "txtnopol"
        Me.txtnopol.Size = New System.Drawing.Size(173, 20)
        Me.txtnopol.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(286, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cari No Polisi :"
        '
        'dgvKendaraan
        '
        Me.dgvKendaraan.AllowUserToAddRows = False
        Me.dgvKendaraan.AllowUserToDeleteRows = False
        Me.dgvKendaraan.AllowUserToOrderColumns = True
        Me.dgvKendaraan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKendaraan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nolambung, Me.nopol, Me.merek, Me.nomesin})
        Me.dgvKendaraan.Location = New System.Drawing.Point(12, 61)
        Me.dgvKendaraan.Name = "dgvKendaraan"
        Me.dgvKendaraan.ReadOnly = True
        Me.dgvKendaraan.Size = New System.Drawing.Size(633, 303)
        Me.dgvKendaraan.TabIndex = 6
        '
        'nolambung
        '
        Me.nolambung.DataPropertyName = "nolambung"
        Me.nolambung.Frozen = True
        Me.nolambung.HeaderText = "No Lambung"
        Me.nolambung.Name = "nolambung"
        Me.nolambung.ReadOnly = True
        '
        'nopol
        '
        Me.nopol.DataPropertyName = "nopol"
        Me.nopol.HeaderText = "No Polisi"
        Me.nopol.Name = "nopol"
        Me.nopol.ReadOnly = True
        Me.nopol.ToolTipText = "No Polisi"
        '
        'merek
        '
        Me.merek.DataPropertyName = "merek"
        Me.merek.HeaderText = "Merek"
        Me.merek.Name = "merek"
        Me.merek.ReadOnly = True
        Me.merek.ToolTipText = "Merek"
        '
        'nomesin
        '
        Me.nomesin.DataPropertyName = "nomesin"
        Me.nomesin.HeaderText = "No Mesin"
        Me.nomesin.Name = "nomesin"
        Me.nomesin.ReadOnly = True
        Me.nomesin.ToolTipText = "No Mesin"
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
        'txtnomesin
        '
        Me.txtnomesin.Location = New System.Drawing.Point(369, 9)
        Me.txtnomesin.Name = "txtnomesin"
        Me.txtnomesin.Size = New System.Drawing.Size(173, 20)
        Me.txtnomesin.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(282, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Cari No Mesin :"
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
        'frmBrowseKendaraan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 410)
        Me.Controls.Add(Me.btnfilter)
        Me.Controls.Add(Me.txtnomesin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblJumData)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvKendaraan)
        Me.Controls.Add(Me.txtnopol)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBrowseKendaraan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Browse Kendaraan :."
        CType(Me.dgvKendaraan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnopol As System.Windows.Forms.TextBox
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
    Friend WithEvents txtnomesin As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnfilter As System.Windows.Forms.Button
    Friend WithEvents nolambung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nopol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents merek As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomesin As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
