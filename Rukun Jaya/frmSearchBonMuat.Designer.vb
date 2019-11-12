<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchBonMuat
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoBM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtMulai = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtSampai = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSopir = New System.Windows.Forms.TextBox()
        Me.txtNopol = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.noBonMuat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.noLambung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nopol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jeniskendaraan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namaSopir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panggilan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detail = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnCari = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No BM :"
        '
        'txtNoBM
        '
        Me.txtNoBM.Location = New System.Drawing.Point(59, 10)
        Me.txtNoBM.Name = "txtNoBM"
        Me.txtNoBM.Size = New System.Drawing.Size(100, 20)
        Me.txtNoBM.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Periode :"
        '
        'dtMulai
        '
        Me.dtMulai.CustomFormat = "dd-MM-yyyy"
        Me.dtMulai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtMulai.Location = New System.Drawing.Point(224, 10)
        Me.dtMulai.Name = "dtMulai"
        Me.dtMulai.Size = New System.Drawing.Size(99, 20)
        Me.dtMulai.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(329, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "s/d"
        '
        'dtSampai
        '
        Me.dtSampai.CustomFormat = "dd-MM-yyyy"
        Me.dtSampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtSampai.Location = New System.Drawing.Point(358, 10)
        Me.dtSampai.Name = "dtSampai"
        Me.dtSampai.Size = New System.Drawing.Size(96, 20)
        Me.dtSampai.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(460, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Sopir :"
        '
        'txtSopir
        '
        Me.txtSopir.Location = New System.Drawing.Point(503, 10)
        Me.txtSopir.Name = "txtSopir"
        Me.txtSopir.Size = New System.Drawing.Size(136, 20)
        Me.txtSopir.TabIndex = 7
        '
        'txtNopol
        '
        Me.txtNopol.Location = New System.Drawing.Point(693, 10)
        Me.txtNopol.Name = "txtNopol"
        Me.txtNopol.Size = New System.Drawing.Size(83, 20)
        Me.txtNopol.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(650, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nopol :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.noBonMuat, Me.tanggal, Me.noLambung, Me.nopol, Me.jeniskendaraan, Me.namaSopir, Me.panggilan, Me.detail})
        Me.DataGridView1.Location = New System.Drawing.Point(10, 47)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(876, 268)
        Me.DataGridView1.TabIndex = 13
        '
        'noBonMuat
        '
        Me.noBonMuat.DataPropertyName = "noBM"
        Me.noBonMuat.HeaderText = "No Bon Muat"
        Me.noBonMuat.Name = "noBonMuat"
        Me.noBonMuat.ReadOnly = True
        '
        'tanggal
        '
        Me.tanggal.DataPropertyName = "tgl"
        Me.tanggal.HeaderText = "Tanggal"
        Me.tanggal.Name = "tanggal"
        Me.tanggal.ReadOnly = True
        '
        'noLambung
        '
        Me.noLambung.DataPropertyName = "nolambung"
        Me.noLambung.HeaderText = "No Lambung"
        Me.noLambung.Name = "noLambung"
        Me.noLambung.ReadOnly = True
        '
        'nopol
        '
        Me.nopol.DataPropertyName = "nopol"
        Me.nopol.HeaderText = "No. Polisi"
        Me.nopol.Name = "nopol"
        Me.nopol.ReadOnly = True
        '
        'jeniskendaraan
        '
        Me.jeniskendaraan.DataPropertyName = "namajenis"
        Me.jeniskendaraan.HeaderText = "Jenis Kendaraan"
        Me.jeniskendaraan.Name = "jeniskendaraan"
        Me.jeniskendaraan.ReadOnly = True
        '
        'namaSopir
        '
        Me.namaSopir.DataPropertyName = "namaSopir"
        Me.namaSopir.HeaderText = "Nama Sopir"
        Me.namaSopir.Name = "namaSopir"
        Me.namaSopir.ReadOnly = True
        '
        'panggilan
        '
        Me.panggilan.DataPropertyName = "panggilan"
        Me.panggilan.HeaderText = "Nama Panggilan"
        Me.panggilan.Name = "panggilan"
        Me.panggilan.ReadOnly = True
        '
        'detail
        '
        Me.detail.HeaderText = "Detail"
        Me.detail.Name = "detail"
        Me.detail.ReadOnly = True
        Me.detail.Text = "Detail"
        Me.detail.ToolTipText = "Detail"
        Me.detail.UseColumnTextForButtonValue = True
        '
        'btnCari
        '
        Me.btnCari.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCari.Location = New System.Drawing.Point(782, 8)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(66, 28)
        Me.btnCari.TabIndex = 12
        Me.btnCari.Text = "Filter"
        Me.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'frmSearchBonMuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 358)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtNopol)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSopir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtSampai)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtMulai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNoBM)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearchBonMuat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Bon Muat :."
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoBM As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtMulai As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtSampai As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSopir As System.Windows.Forms.TextBox
    Friend WithEvents txtNopol As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents noBonMuat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tanggal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents noLambung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nopol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jeniskendaraan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namaSopir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents panggilan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents detail As System.Windows.Forms.DataGridViewButtonColumn
End Class
