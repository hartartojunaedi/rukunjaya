<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailMasterSPBU
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
        Me.txtKodeSPBU = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNamaSPBU = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAlamatSPBU = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKontakSPBU = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTelpSPBU = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtKotaSPBU = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.nupLimit = New System.Windows.Forms.NumericUpDown()
        Me.nupSaldo = New System.Windows.Forms.NumericUpDown()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.nupLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtKodeSPBU
        '
        Me.txtKodeSPBU.Location = New System.Drawing.Point(84, 57)
        Me.txtKodeSPBU.Name = "txtKodeSPBU"
        Me.txtKodeSPBU.Size = New System.Drawing.Size(125, 20)
        Me.txtKodeSPBU.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Kode SPBU: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNamaSPBU
        '
        Me.txtNamaSPBU.Location = New System.Drawing.Point(84, 83)
        Me.txtNamaSPBU.Name = "txtNamaSPBU"
        Me.txtNamaSPBU.Size = New System.Drawing.Size(210, 20)
        Me.txtNamaSPBU.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nama :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtAlamatSPBU
        '
        Me.txtAlamatSPBU.Location = New System.Drawing.Point(84, 109)
        Me.txtAlamatSPBU.Multiline = True
        Me.txtAlamatSPBU.Name = "txtAlamatSPBU"
        Me.txtAlamatSPBU.Size = New System.Drawing.Size(178, 69)
        Me.txtAlamatSPBU.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Alamat :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Kota :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtKontakSPBU
        '
        Me.txtKontakSPBU.Location = New System.Drawing.Point(83, 212)
        Me.txtKontakSPBU.Name = "txtKontakSPBU"
        Me.txtKontakSPBU.Size = New System.Drawing.Size(187, 20)
        Me.txtKontakSPBU.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Kontak :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtTelpSPBU
        '
        Me.txtTelpSPBU.Location = New System.Drawing.Point(84, 238)
        Me.txtTelpSPBU.Name = "txtTelpSPBU"
        Me.txtTelpSPBU.Size = New System.Drawing.Size(158, 20)
        Me.txtTelpSPBU.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Telepon :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 266)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Limit :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtKotaSPBU
        '
        Me.txtKotaSPBU.Location = New System.Drawing.Point(83, 184)
        Me.txtKotaSPBU.Name = "txtKotaSPBU"
        Me.txtKotaSPBU.Size = New System.Drawing.Size(141, 20)
        Me.txtKotaSPBU.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(38, 292)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Saldo :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(242, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Mode :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Location = New System.Drawing.Point(288, 24)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(22, 13)
        Me.lblMode.TabIndex = 30
        Me.lblMode.Text = "xxx"
        Me.lblMode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'nupLimit
        '
        Me.nupLimit.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nupLimit.Location = New System.Drawing.Point(84, 265)
        Me.nupLimit.Maximum = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.nupLimit.Name = "nupLimit"
        Me.nupLimit.Size = New System.Drawing.Size(120, 20)
        Me.nupLimit.TabIndex = 7
        '
        'nupSaldo
        '
        Me.nupSaldo.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nupSaldo.Location = New System.Drawing.Point(83, 293)
        Me.nupSaldo.Maximum = New Decimal(New Integer() {1316134911, 2328, 0, 0})
        Me.nupSaldo.Name = "nupSaldo"
        Me.nupSaldo.Size = New System.Drawing.Size(120, 20)
        Me.nupSaldo.TabIndex = 8
        '
        'btnBatal
        '
        Me.btnBatal.Image = Global.RukunJaya.My.Resources.Resources.cancelbr
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(178, 329)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 31)
        Me.btnBatal.TabIndex = 10
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(65, 330)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 31)
        Me.btnSimpan.TabIndex = 9
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(211, 265)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Limit Tagihan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(209, 292)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Saldo Hutang"
        '
        'frmDetailMasterSPBU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 372)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.nupSaldo)
        Me.Controls.Add(Me.nupLimit)
        Me.Controls.Add(Me.lblMode)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtKotaSPBU)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTelpSPBU)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtKontakSPBU)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAlamatSPBU)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNamaSPBU)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKodeSPBU)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetailMasterSPBU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Master SPBU :."
        CType(Me.nupLimit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtKodeSPBU As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNamaSPBU As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAlamatSPBU As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtKontakSPBU As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTelpSPBU As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtKotaSPBU As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblMode As System.Windows.Forms.Label
    Friend WithEvents nupLimit As System.Windows.Forms.NumericUpDown
    Friend WithEvents nupSaldo As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
