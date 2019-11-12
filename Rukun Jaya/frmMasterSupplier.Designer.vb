<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterSupplier
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
        Me.dgvSupplier = New System.Windows.Forms.DataGridView()
        Me.kodesupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namasupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamatsupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kotasupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telpsupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.createdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.updatedate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.lblJumlahData = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtKota = New System.Windows.Forms.TextBox()
        Me.btnfilter = New System.Windows.Forms.Button()
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSupplier
        '
        Me.dgvSupplier.AllowUserToAddRows = False
        Me.dgvSupplier.AllowUserToDeleteRows = False
        Me.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSupplier.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodesupplier, Me.namasupplier, Me.alamatsupplier, Me.kotasupplier, Me.telpsupplier, Me.createdate, Me.updatedate})
        Me.dgvSupplier.Location = New System.Drawing.Point(12, 56)
        Me.dgvSupplier.Name = "dgvSupplier"
        Me.dgvSupplier.ReadOnly = True
        Me.dgvSupplier.Size = New System.Drawing.Size(765, 238)
        Me.dgvSupplier.TabIndex = 0
        '
        'kodesupplier
        '
        Me.kodesupplier.DataPropertyName = "kodesupplier"
        Me.kodesupplier.HeaderText = "Kode Supplier"
        Me.kodesupplier.Name = "kodesupplier"
        Me.kodesupplier.ReadOnly = True
        '
        'namasupplier
        '
        Me.namasupplier.DataPropertyName = "namasupplier"
        Me.namasupplier.HeaderText = "Nama Supplier"
        Me.namasupplier.Name = "namasupplier"
        Me.namasupplier.ReadOnly = True
        '
        'alamatsupplier
        '
        Me.alamatsupplier.DataPropertyName = "alamatsupplier"
        Me.alamatsupplier.HeaderText = "Alamat Supplier"
        Me.alamatsupplier.Name = "alamatsupplier"
        Me.alamatsupplier.ReadOnly = True
        '
        'kotasupplier
        '
        Me.kotasupplier.DataPropertyName = "kotasupplier"
        Me.kotasupplier.HeaderText = "Kota Supplier"
        Me.kotasupplier.Name = "kotasupplier"
        Me.kotasupplier.ReadOnly = True
        '
        'telpsupplier
        '
        Me.telpsupplier.DataPropertyName = "telpsupplier"
        Me.telpsupplier.HeaderText = "Telepon Supplier"
        Me.telpsupplier.Name = "telpsupplier"
        Me.telpsupplier.ReadOnly = True
        '
        'createdate
        '
        Me.createdate.DataPropertyName = "createdate"
        Me.createdate.HeaderText = "Create Date"
        Me.createdate.Name = "createdate"
        Me.createdate.ReadOnly = True
        Me.createdate.Visible = False
        '
        'updatedate
        '
        Me.updatedate.DataPropertyName = "updatedate"
        Me.updatedate.HeaderText = "Update Date"
        Me.updatedate.Name = "updatedate"
        Me.updatedate.ReadOnly = True
        Me.updatedate.Visible = False
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(21, 312)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(80, 29)
        Me.btnTambah.TabIndex = 1
        Me.btnTambah.Text = "&Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'lblJumlahData
        '
        Me.lblJumlahData.AutoSize = True
        Me.lblJumlahData.Location = New System.Drawing.Point(650, 320)
        Me.lblJumlahData.Name = "lblJumlahData"
        Me.lblJumlahData.Size = New System.Drawing.Size(69, 13)
        Me.lblJumlahData.TabIndex = 2
        Me.lblJumlahData.Text = "Jumlah Data:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(127, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cari Nama:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(388, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cari Kota:"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(204, 21)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(175, 20)
        Me.txtNama.TabIndex = 5
        '
        'txtKota
        '
        Me.txtKota.Location = New System.Drawing.Point(459, 21)
        Me.txtKota.Name = "txtKota"
        Me.txtKota.Size = New System.Drawing.Size(175, 20)
        Me.txtKota.TabIndex = 6
        '
        'btnfilter
        '
        Me.btnfilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnfilter.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnfilter.Location = New System.Drawing.Point(653, 21)
        Me.btnfilter.Name = "btnfilter"
        Me.btnfilter.Size = New System.Drawing.Size(80, 29)
        Me.btnfilter.TabIndex = 15
        Me.btnfilter.Text = "&Filter"
        Me.btnfilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnfilter.UseVisualStyleBackColor = True
        '
        'frmMasterSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 352)
        Me.Controls.Add(Me.btnfilter)
        Me.Controls.Add(Me.txtKota)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblJumlahData)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.dgvSupplier)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMasterSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Master Supplier :."
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSupplier As System.Windows.Forms.DataGridView
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents lblJumlahData As System.Windows.Forms.Label
    Friend WithEvents kodesupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namasupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents alamatsupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kotasupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telpsupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents createdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents updatedate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtKota As System.Windows.Forms.TextBox
    Friend WithEvents btnfilter As System.Windows.Forms.Button
End Class
