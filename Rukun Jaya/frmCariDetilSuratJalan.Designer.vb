<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCariDetilSuratJalan
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
        Me.dgvDetilSuratJalan = New System.Windows.Forms.DataGridView()
        Me.NoBM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoSuratJalan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaSopir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nopol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNoBM = New System.Windows.Forms.TextBox()
        Me.txtNoSuratJalan = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgvDetilBarang = New System.Windows.Forms.DataGridView()
        Me.Namabrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kodebarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nodeliveryorder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoDeSuratJalan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoBonMuat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNamaSopir = New System.Windows.Forms.TextBox()
        CType(Me.dgvDetilSuratJalan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetilBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDetilSuratJalan
        '
        Me.dgvDetilSuratJalan.AllowUserToAddRows = False
        Me.dgvDetilSuratJalan.AllowUserToDeleteRows = False
        Me.dgvDetilSuratJalan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetilSuratJalan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoBM, Me.NoSuratJalan, Me.NoDO, Me.NamaSopir, Me.Nopol})
        Me.dgvDetilSuratJalan.Location = New System.Drawing.Point(12, 69)
        Me.dgvDetilSuratJalan.Name = "dgvDetilSuratJalan"
        Me.dgvDetilSuratJalan.ReadOnly = True
        Me.dgvDetilSuratJalan.Size = New System.Drawing.Size(639, 148)
        Me.dgvDetilSuratJalan.TabIndex = 0
        '
        'NoBM
        '
        Me.NoBM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NoBM.DataPropertyName = "NoBM"
        Me.NoBM.HeaderText = "No BM"
        Me.NoBM.Name = "NoBM"
        Me.NoBM.ReadOnly = True
        '
        'NoSuratJalan
        '
        Me.NoSuratJalan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NoSuratJalan.DataPropertyName = "NoSuratJalan"
        Me.NoSuratJalan.HeaderText = "No Surat Jalan"
        Me.NoSuratJalan.Name = "NoSuratJalan"
        Me.NoSuratJalan.ReadOnly = True
        '
        'NoDO
        '
        Me.NoDO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NoDO.DataPropertyName = "NoDO"
        Me.NoDO.HeaderText = "No DO"
        Me.NoDO.Name = "NoDO"
        Me.NoDO.ReadOnly = True
        '
        'NamaSopir
        '
        Me.NamaSopir.DataPropertyName = "NamaSopir"
        Me.NamaSopir.HeaderText = "Nama Sopir"
        Me.NamaSopir.Name = "NamaSopir"
        Me.NamaSopir.ReadOnly = True
        '
        'Nopol
        '
        Me.Nopol.DataPropertyName = "Nopol"
        Me.Nopol.HeaderText = "No Polisi"
        Me.Nopol.Name = "Nopol"
        Me.Nopol.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(223, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No BM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "No Surat Jalan"
        '
        'txtNoBM
        '
        Me.txtNoBM.Location = New System.Drawing.Point(269, 27)
        Me.txtNoBM.Name = "txtNoBM"
        Me.txtNoBM.Size = New System.Drawing.Size(104, 20)
        Me.txtNoBM.TabIndex = 3
        '
        'txtNoSuratJalan
        '
        Me.txtNoSuratJalan.Location = New System.Drawing.Point(112, 27)
        Me.txtNoSuratJalan.Name = "txtNoSuratJalan"
        Me.txtNoSuratJalan.Size = New System.Drawing.Size(103, 20)
        Me.txtNoSuratJalan.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(574, 22)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 28)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Filter"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dgvDetilBarang
        '
        Me.dgvDetilBarang.AllowUserToAddRows = False
        Me.dgvDetilBarang.AllowUserToDeleteRows = False
        Me.dgvDetilBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetilBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Namabrg, Me.Jumlah, Me.kodebarang, Me.nodeliveryorder, Me.NoDeSuratJalan, Me.NoBonMuat})
        Me.dgvDetilBarang.Location = New System.Drawing.Point(13, 223)
        Me.dgvDetilBarang.Name = "dgvDetilBarang"
        Me.dgvDetilBarang.ReadOnly = True
        Me.dgvDetilBarang.Size = New System.Drawing.Size(638, 150)
        Me.dgvDetilBarang.TabIndex = 6
        '
        'Namabrg
        '
        Me.Namabrg.DataPropertyName = "NamaBarang"
        Me.Namabrg.HeaderText = "Nama Barang"
        Me.Namabrg.Name = "Namabrg"
        Me.Namabrg.ReadOnly = True
        '
        'Jumlah
        '
        Me.Jumlah.DataPropertyName = "Jumlah"
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.ReadOnly = True
        '
        'kodebarang
        '
        Me.kodebarang.DataPropertyName = "Kodebarang"
        Me.kodebarang.HeaderText = "Kodebarang"
        Me.kodebarang.Name = "kodebarang"
        Me.kodebarang.ReadOnly = True
        Me.kodebarang.Visible = False
        '
        'nodeliveryorder
        '
        Me.nodeliveryorder.DataPropertyName = "NoDo"
        Me.nodeliveryorder.HeaderText = "DO"
        Me.nodeliveryorder.Name = "nodeliveryorder"
        Me.nodeliveryorder.ReadOnly = True
        Me.nodeliveryorder.Visible = False
        '
        'NoDeSuratJalan
        '
        Me.NoDeSuratJalan.DataPropertyName = "NoSuratJalan"
        Me.NoDeSuratJalan.HeaderText = "SuratJalan"
        Me.NoDeSuratJalan.Name = "NoDeSuratJalan"
        Me.NoDeSuratJalan.ReadOnly = True
        Me.NoDeSuratJalan.Visible = False
        '
        'NoBonMuat
        '
        Me.NoBonMuat.DataPropertyName = "NoBM"
        Me.NoBonMuat.HeaderText = "Bon Muat"
        Me.NoBonMuat.Name = "NoBonMuat"
        Me.NoBonMuat.ReadOnly = True
        Me.NoBonMuat.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(383, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nama Sopir"
        '
        'txtNamaSopir
        '
        Me.txtNamaSopir.Location = New System.Drawing.Point(451, 27)
        Me.txtNamaSopir.Name = "txtNamaSopir"
        Me.txtNamaSopir.Size = New System.Drawing.Size(108, 20)
        Me.txtNamaSopir.TabIndex = 8
        '
        'frmCariDetilSuratJalan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 397)
        Me.Controls.Add(Me.txtNamaSopir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvDetilBarang)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtNoSuratJalan)
        Me.Controls.Add(Me.txtNoBM)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDetilSuratJalan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCariDetilSuratJalan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Cari Surat Jalan :."
        CType(Me.dgvDetilSuratJalan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetilBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDetilSuratJalan As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNoBM As System.Windows.Forms.TextBox
    Friend WithEvents txtNoSuratJalan As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents dgvDetilBarang As System.Windows.Forms.DataGridView
    Friend WithEvents NoBM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoSuratJalan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaSopir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nopol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Namabrg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kodebarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nodeliveryorder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoDeSuratJalan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoBonMuat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNamaSopir As System.Windows.Forms.TextBox
End Class
