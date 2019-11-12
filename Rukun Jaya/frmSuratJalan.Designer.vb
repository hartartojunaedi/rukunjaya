<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuratJalan
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
        Me.noBM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.perwakilan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.asal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tujuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detail = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtPerwakilan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSupp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNoSJ = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtSampai = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtMulai = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.noSJ, Me.noBM, Me.supplier, Me.perwakilan, Me.tgl, Me.asal, Me.tujuan, Me.detail})
        Me.DataGridView1.Location = New System.Drawing.Point(10, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1026, 300)
        Me.DataGridView1.TabIndex = 1
        '
        'noSJ
        '
        Me.noSJ.DataPropertyName = "noSuratJalan"
        Me.noSJ.HeaderText = "No SJ"
        Me.noSJ.Name = "noSJ"
        Me.noSJ.ReadOnly = True
        '
        'noBM
        '
        Me.noBM.DataPropertyName = "noBM"
        Me.noBM.HeaderText = "No BM"
        Me.noBM.Name = "noBM"
        Me.noBM.ReadOnly = True
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
        'tgl
        '
        Me.tgl.DataPropertyName = "tgl"
        Me.tgl.HeaderText = "Tanggal"
        Me.tgl.Name = "tgl"
        Me.tgl.ReadOnly = True
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
        'btnCari
        '
        Me.btnCari.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCari.Location = New System.Drawing.Point(970, 7)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(66, 28)
        Me.btnCari.TabIndex = 23
        Me.btnCari.Text = "Filter"
        Me.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'txtPerwakilan
        '
        Me.txtPerwakilan.Location = New System.Drawing.Point(838, 12)
        Me.txtPerwakilan.Name = "txtPerwakilan"
        Me.txtPerwakilan.Size = New System.Drawing.Size(122, 20)
        Me.txtPerwakilan.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(767, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Perwakilan :"
        '
        'txtSupp
        '
        Me.txtSupp.Location = New System.Drawing.Point(624, 12)
        Me.txtSupp.Name = "txtSupp"
        Me.txtSupp.Size = New System.Drawing.Size(136, 20)
        Me.txtSupp.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(567, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Supplier :"
        '
        'txtNoSJ
        '
        Me.txtNoSJ.Location = New System.Drawing.Point(96, 12)
        Me.txtNoSJ.Name = "txtNoSJ"
        Me.txtNoSJ.Size = New System.Drawing.Size(98, 20)
        Me.txtNoSJ.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "No Surat Jalan :"
        '
        'dtSampai
        '
        Me.dtSampai.CustomFormat = "dd-MM-yyyy"
        Me.dtSampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtSampai.Location = New System.Drawing.Point(419, 12)
        Me.dtSampai.Name = "dtSampai"
        Me.dtSampai.Size = New System.Drawing.Size(139, 20)
        Me.dtSampai.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(390, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "s/d"
        '
        'dtMulai
        '
        Me.dtMulai.CustomFormat = "dd-MM-yyyy"
        Me.dtMulai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtMulai.Location = New System.Drawing.Point(256, 12)
        Me.dtMulai.Name = "dtMulai"
        Me.dtMulai.Size = New System.Drawing.Size(128, 20)
        Me.dtMulai.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(201, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Periode :"
        '
        'frmSuratJalan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 367)
        Me.Controls.Add(Me.dtSampai)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtMulai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtPerwakilan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSupp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNoSJ)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSuratJalan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Surat Jalan :."
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents txtPerwakilan As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSupp As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNoSJ As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtSampai As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtMulai As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents noSJ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents noBM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents perwakilan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tgl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents asal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tujuan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents detail As System.Windows.Forms.DataGridViewButtonColumn
End Class
