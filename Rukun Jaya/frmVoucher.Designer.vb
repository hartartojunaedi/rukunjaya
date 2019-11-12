<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoucher
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtMulai = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVoucher = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.kodeVoucher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.spbu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.liter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rupiahLiter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kasbon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detail = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dtSampai = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbSPBU = New System.Windows.Forms.ComboBox()
        Me.btnCari = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(525, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "SPBU :"
        '
        'dtMulai
        '
        Me.dtMulai.CustomFormat = "dd-MM-yyyy"
        Me.dtMulai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtMulai.Location = New System.Drawing.Point(299, 18)
        Me.dtMulai.Name = "dtMulai"
        Me.dtMulai.Size = New System.Drawing.Size(94, 20)
        Me.dtMulai.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Tanggal Voucher :"
        '
        'txtVoucher
        '
        Me.txtVoucher.Location = New System.Drawing.Point(85, 18)
        Me.txtVoucher.Name = "txtVoucher"
        Me.txtVoucher.Size = New System.Drawing.Size(100, 20)
        Me.txtVoucher.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "No Voucher :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodeVoucher, Me.spbu, Me.liter, Me.rupiahLiter, Me.subTotal, Me.kasbon, Me.detail})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(807, 272)
        Me.DataGridView1.TabIndex = 25
        '
        'kodeVoucher
        '
        Me.kodeVoucher.DataPropertyName = "kodevoucher"
        Me.kodeVoucher.HeaderText = "Kode Voucher"
        Me.kodeVoucher.Name = "kodeVoucher"
        Me.kodeVoucher.ReadOnly = True
        '
        'spbu
        '
        Me.spbu.DataPropertyName = "namaspbu"
        Me.spbu.HeaderText = "SPBU"
        Me.spbu.Name = "spbu"
        Me.spbu.ReadOnly = True
        '
        'liter
        '
        Me.liter.DataPropertyName = "liter"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle1.Format = "N2"
        Me.liter.DefaultCellStyle = DataGridViewCellStyle1
        Me.liter.HeaderText = "liter"
        Me.liter.Name = "liter"
        Me.liter.ReadOnly = True
        '
        'rupiahLiter
        '
        Me.rupiahLiter.DataPropertyName = "rupiahsatuan"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle2.Format = "N2"
        Me.rupiahLiter.DefaultCellStyle = DataGridViewCellStyle2
        Me.rupiahLiter.HeaderText = "Rupiah/Liter"
        Me.rupiahLiter.Name = "rupiahLiter"
        Me.rupiahLiter.ReadOnly = True
        '
        'subTotal
        '
        Me.subTotal.DataPropertyName = "rupiah"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Format = "N2"
        Me.subTotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.subTotal.HeaderText = "Sub Total"
        Me.subTotal.Name = "subTotal"
        Me.subTotal.ReadOnly = True
        '
        'kasbon
        '
        Me.kasbon.DataPropertyName = "kasbon"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "N2"
        Me.kasbon.DefaultCellStyle = DataGridViewCellStyle4
        Me.kasbon.HeaderText = "KasBon"
        Me.kasbon.Name = "kasbon"
        Me.kasbon.ReadOnly = True
        '
        'detail
        '
        Me.detail.HeaderText = "Detail"
        Me.detail.Name = "detail"
        Me.detail.ReadOnly = True
        Me.detail.Text = "Detail"
        Me.detail.UseColumnTextForButtonValue = True
        '
        'dtSampai
        '
        Me.dtSampai.CustomFormat = "dd-MM-yyyy"
        Me.dtSampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtSampai.Location = New System.Drawing.Point(428, 18)
        Me.dtSampai.Name = "dtSampai"
        Me.dtSampai.Size = New System.Drawing.Size(91, 20)
        Me.dtSampai.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(399, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "s/d"
        '
        'cbSPBU
        '
        Me.cbSPBU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSPBU.FormattingEnabled = True
        Me.cbSPBU.Location = New System.Drawing.Point(573, 17)
        Me.cbSPBU.Name = "cbSPBU"
        Me.cbSPBU.Size = New System.Drawing.Size(168, 21)
        Me.cbSPBU.TabIndex = 28
        '
        'btnCari
        '
        Me.btnCari.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCari.Location = New System.Drawing.Point(747, 12)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(66, 28)
        Me.btnCari.TabIndex = 24
        Me.btnCari.Text = "Filter"
        Me.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'frmVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 364)
        Me.Controls.Add(Me.cbSPBU)
        Me.Controls.Add(Me.dtSampai)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtMulai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtVoucher)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVoucher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Voucher :."
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtMulai As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtVoucher As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents dtSampai As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbSPBU As System.Windows.Forms.ComboBox
    Friend WithEvents kodeVoucher As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents spbu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents liter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rupiahLiter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kasbon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents detail As System.Windows.Forms.DataGridViewButtonColumn
End Class
