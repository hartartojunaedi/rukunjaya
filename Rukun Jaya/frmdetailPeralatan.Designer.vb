<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdetailPeralatan
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
        Me.txtSatuan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.txtnamaAlat = New System.Windows.Forms.TextBox()
        Me.txtIDAlat = New System.Windows.Forms.TextBox()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.lblNamaBank = New System.Windows.Forms.Label()
        Me.lblkodebank = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSatuan
        '
        Me.txtSatuan.Location = New System.Drawing.Point(88, 91)
        Me.txtSatuan.MaxLength = 20
        Me.txtSatuan.Name = "txtSatuan"
        Me.txtSatuan.Size = New System.Drawing.Size(110, 20)
        Me.txtSatuan.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Satuan"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(88, 117)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(151, 65)
        Me.txtKeterangan.TabIndex = 19
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(88, 65)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(128, 20)
        Me.txtjumlah.TabIndex = 15
        Me.txtjumlah.Text = "0"
        '
        'txtnamaAlat
        '
        Me.txtnamaAlat.Location = New System.Drawing.Point(88, 39)
        Me.txtnamaAlat.Name = "txtnamaAlat"
        Me.txtnamaAlat.Size = New System.Drawing.Size(138, 20)
        Me.txtnamaAlat.TabIndex = 14
        '
        'txtIDAlat
        '
        Me.txtIDAlat.Location = New System.Drawing.Point(88, 13)
        Me.txtIDAlat.Name = "txtIDAlat"
        Me.txtIDAlat.Size = New System.Drawing.Size(92, 20)
        Me.txtIDAlat.TabIndex = 12
        '
        'lblKeterangan
        '
        Me.lblKeterangan.AutoSize = True
        Me.lblKeterangan.Location = New System.Drawing.Point(19, 120)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(62, 13)
        Me.lblKeterangan.TabIndex = 17
        Me.lblKeterangan.Text = "Keterangan"
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Location = New System.Drawing.Point(47, 68)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(40, 13)
        Me.lblSaldo.TabIndex = 15
        Me.lblSaldo.Text = "Jumlah"
        '
        'lblNamaBank
        '
        Me.lblNamaBank.AutoSize = True
        Me.lblNamaBank.Location = New System.Drawing.Point(25, 42)
        Me.lblNamaBank.Name = "lblNamaBank"
        Me.lblNamaBank.Size = New System.Drawing.Size(56, 13)
        Me.lblNamaBank.TabIndex = 13
        Me.lblNamaBank.Text = "Nama Alat"
        '
        'lblkodebank
        '
        Me.lblkodebank.AutoSize = True
        Me.lblkodebank.Location = New System.Drawing.Point(44, 16)
        Me.lblkodebank.Name = "lblkodebank"
        Me.lblkodebank.Size = New System.Drawing.Size(37, 13)
        Me.lblkodebank.TabIndex = 11
        Me.lblkodebank.Text = "Id Alat"
        '
        'btnBatal
        '
        Me.btnBatal.Image = Global.RukunJaya.My.Resources.Resources.cancelbr
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(164, 188)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 31)
        Me.btnBatal.TabIndex = 21
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(74, 188)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 31)
        Me.btnSimpan.TabIndex = 20
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'frmdetailPeralatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 234)
        Me.Controls.Add(Me.txtSatuan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.txtnamaAlat)
        Me.Controls.Add(Me.txtIDAlat)
        Me.Controls.Add(Me.lblKeterangan)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.lblNamaBank)
        Me.Controls.Add(Me.lblkodebank)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmdetailPeralatan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Detail Peralatan :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSatuan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents txtjumlah As System.Windows.Forms.TextBox
    Friend WithEvents txtnamaAlat As System.Windows.Forms.TextBox
    Friend WithEvents txtIDAlat As System.Windows.Forms.TextBox
    Friend WithEvents lblKeterangan As System.Windows.Forms.Label
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents lblNamaBank As System.Windows.Forms.Label
    Friend WithEvents lblkodebank As System.Windows.Forms.Label
End Class
