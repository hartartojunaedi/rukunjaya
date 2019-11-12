<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIsiDetailBiaya
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblnoBM = New System.Windows.Forms.Label()
        Me.lblNoSuratJalan = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbbiaya = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtketerangan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbiaya = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.kodebiaya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBiaya = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kredit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Debit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Haous = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No BM : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(269, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No. Surat Jalan : "
        '
        'lblnoBM
        '
        Me.lblnoBM.AutoSize = True
        Me.lblnoBM.Location = New System.Drawing.Point(81, 13)
        Me.lblnoBM.Name = "lblnoBM"
        Me.lblnoBM.Size = New System.Drawing.Size(39, 13)
        Me.lblnoBM.TabIndex = 2
        Me.lblnoBM.Text = "Label3"
        '
        'lblNoSuratJalan
        '
        Me.lblNoSuratJalan.AutoSize = True
        Me.lblNoSuratJalan.Location = New System.Drawing.Point(364, 13)
        Me.lblNoSuratJalan.Name = "lblNoSuratJalan"
        Me.lblNoSuratJalan.Size = New System.Drawing.Size(39, 13)
        Me.lblNoSuratJalan.TabIndex = 3
        Me.lblNoSuratJalan.Text = "Label4"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodebiaya, Me.NamaBiaya, Me.Keterangan, Me.Kredit, Me.Debit, Me.Haous})
        Me.DataGridView1.Location = New System.Drawing.Point(16, 146)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(657, 222)
        Me.DataGridView1.TabIndex = 4
        '
        'btnsimpan
        '
        Me.btnsimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnsimpan.Location = New System.Drawing.Point(16, 374)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(80, 29)
        Me.btnsimpan.TabIndex = 117
        Me.btnsimpan.Text = "&Simpan"
        Me.btnsimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Biaya : "
        '
        'cmbbiaya
        '
        Me.cmbbiaya.FormattingEnabled = True
        Me.cmbbiaya.Location = New System.Drawing.Point(84, 42)
        Me.cmbbiaya.Name = "cmbbiaya"
        Me.cmbbiaya.Size = New System.Drawing.Size(167, 21)
        Me.cmbbiaya.TabIndex = 119
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "Keterangan : "
        '
        'txtketerangan
        '
        Me.txtketerangan.Location = New System.Drawing.Point(84, 70)
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.Size = New System.Drawing.Size(216, 20)
        Me.txtketerangan.TabIndex = 121
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 122
        Me.Label5.Text = "Biaya "
        '
        'txtbiaya
        '
        Me.txtbiaya.Location = New System.Drawing.Point(84, 103)
        Me.txtbiaya.Name = "txtbiaya"
        Me.txtbiaya.Size = New System.Drawing.Size(216, 20)
        Me.txtbiaya.TabIndex = 123
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Image = Global.RukunJaya.My.Resources.Resources.tambah_gadget_icon1
        Me.Button1.Location = New System.Drawing.Point(323, 94)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 29)
        Me.Button1.TabIndex = 124
        Me.Button1.Text = "&Biaya"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'kodebiaya
        '
        Me.kodebiaya.DataPropertyName = "kodebiaya"
        Me.kodebiaya.HeaderText = "Kode Biaya"
        Me.kodebiaya.Name = "kodebiaya"
        Me.kodebiaya.ReadOnly = True
        '
        'NamaBiaya
        '
        Me.NamaBiaya.DataPropertyName = "namabiaya"
        Me.NamaBiaya.HeaderText = "Nama Biaya"
        Me.NamaBiaya.Name = "NamaBiaya"
        Me.NamaBiaya.ReadOnly = True
        '
        'Keterangan
        '
        Me.Keterangan.DataPropertyName = "keterangan"
        Me.Keterangan.HeaderText = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.ReadOnly = True
        '
        'Kredit
        '
        Me.Kredit.DataPropertyName = "kredit"
        DataGridViewCellStyle3.Format = "N0"
        Me.Kredit.DefaultCellStyle = DataGridViewCellStyle3
        Me.Kredit.HeaderText = "Kredit"
        Me.Kredit.Name = "Kredit"
        Me.Kredit.ReadOnly = True
        '
        'Debit
        '
        Me.Debit.DataPropertyName = "debit"
        DataGridViewCellStyle4.Format = "N0"
        Me.Debit.DefaultCellStyle = DataGridViewCellStyle4
        Me.Debit.HeaderText = "Debit"
        Me.Debit.Name = "Debit"
        Me.Debit.ReadOnly = True
        '
        'Haous
        '
        Me.Haous.HeaderText = "Hapus"
        Me.Haous.Name = "Haous"
        Me.Haous.ReadOnly = True
        '
        'frmIsiDetailBiaya
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 415)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtbiaya)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtketerangan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbbiaya)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblNoSuratJalan)
        Me.Controls.Add(Me.lblnoBM)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIsiDetailBiaya"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Detail Biaya :."
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblnoBM As System.Windows.Forms.Label
    Friend WithEvents lblNoSuratJalan As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbbiaya As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtketerangan As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtbiaya As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents kodebiaya As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBiaya As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kredit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Debit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Haous As System.Windows.Forms.DataGridViewButtonColumn
End Class
