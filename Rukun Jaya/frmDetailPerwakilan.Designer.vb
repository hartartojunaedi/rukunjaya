<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailPerwakilan
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
        Me.txtKode = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtPengurus = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtKota = New System.Windows.Forms.TextBox()
        Me.txtTelp = New System.Windows.Forms.TextBox()
        Me.txtHp = New System.Windows.Forms.TextBox()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.lblKode = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblPengurus = New System.Windows.Forms.Label()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.lblKota = New System.Windows.Forms.Label()
        Me.lblTelp = New System.Windows.Forms.Label()
        Me.lblHP = New System.Windows.Forms.Label()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtKode
        '
        Me.txtKode.Location = New System.Drawing.Point(94, 37)
        Me.txtKode.MaxLength = 4
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(98, 20)
        Me.txtKode.TabIndex = 0
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(94, 68)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(208, 20)
        Me.txtNama.TabIndex = 1
        '
        'txtPengurus
        '
        Me.txtPengurus.Location = New System.Drawing.Point(94, 100)
        Me.txtPengurus.Name = "txtPengurus"
        Me.txtPengurus.Size = New System.Drawing.Size(144, 20)
        Me.txtPengurus.TabIndex = 2
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(94, 131)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(270, 20)
        Me.txtAlamat.TabIndex = 3
        '
        'txtKota
        '
        Me.txtKota.Location = New System.Drawing.Point(94, 162)
        Me.txtKota.Name = "txtKota"
        Me.txtKota.Size = New System.Drawing.Size(132, 20)
        Me.txtKota.TabIndex = 4
        '
        'txtTelp
        '
        Me.txtTelp.Location = New System.Drawing.Point(94, 194)
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.Size = New System.Drawing.Size(124, 20)
        Me.txtTelp.TabIndex = 5
        '
        'txtHp
        '
        Me.txtHp.Location = New System.Drawing.Point(94, 228)
        Me.txtHp.Name = "txtHp"
        Me.txtHp.Size = New System.Drawing.Size(124, 20)
        Me.txtHp.TabIndex = 6
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Location = New System.Drawing.Point(282, 9)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(102, 13)
        Me.lblMode.TabIndex = 7
        Me.lblMode.Text = "Mode: Tambah/Edit"
        '
        'btnBatal
        '
        Me.btnBatal.AutoEllipsis = True
        Me.btnBatal.Image = Global.RukunJaya.My.Resources.Resources.cancelbr
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(250, 302)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 31)
        Me.btnBatal.TabIndex = 9
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'lblKode
        '
        Me.lblKode.AutoSize = True
        Me.lblKode.Location = New System.Drawing.Point(42, 40)
        Me.lblKode.Name = "lblKode"
        Me.lblKode.Size = New System.Drawing.Size(38, 13)
        Me.lblKode.TabIndex = 10
        Me.lblKode.Text = "Kode :"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(39, 71)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(41, 13)
        Me.lblNama.TabIndex = 11
        Me.lblNama.Text = "Nama :"
        '
        'lblPengurus
        '
        Me.lblPengurus.AutoSize = True
        Me.lblPengurus.Location = New System.Drawing.Point(22, 103)
        Me.lblPengurus.Name = "lblPengurus"
        Me.lblPengurus.Size = New System.Drawing.Size(58, 13)
        Me.lblPengurus.TabIndex = 12
        Me.lblPengurus.Text = "Pengurus :"
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Location = New System.Drawing.Point(35, 134)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(45, 13)
        Me.lblAlamat.TabIndex = 10
        Me.lblAlamat.Text = "Alamat :"
        '
        'lblKota
        '
        Me.lblKota.AutoSize = True
        Me.lblKota.Location = New System.Drawing.Point(45, 165)
        Me.lblKota.Name = "lblKota"
        Me.lblKota.Size = New System.Drawing.Size(35, 13)
        Me.lblKota.TabIndex = 11
        Me.lblKota.Text = "Kota :"
        '
        'lblTelp
        '
        Me.lblTelp.AutoSize = True
        Me.lblTelp.Location = New System.Drawing.Point(46, 197)
        Me.lblTelp.Name = "lblTelp"
        Me.lblTelp.Size = New System.Drawing.Size(34, 13)
        Me.lblTelp.TabIndex = 12
        Me.lblTelp.Text = "Telp :"
        '
        'lblHP
        '
        Me.lblHP.AutoSize = True
        Me.lblHP.Location = New System.Drawing.Point(52, 231)
        Me.lblHP.Name = "lblHP"
        Me.lblHP.Size = New System.Drawing.Size(28, 13)
        Me.lblHP.TabIndex = 12
        Me.lblHP.Text = "HP :"
        '
        'lblKeterangan
        '
        Me.lblKeterangan.AutoSize = True
        Me.lblKeterangan.Location = New System.Drawing.Point(12, 261)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(68, 13)
        Me.lblKeterangan.TabIndex = 13
        Me.lblKeterangan.Text = "Keterangan :"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(94, 258)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(215, 20)
        Me.txtKeterangan.TabIndex = 7
        '
        'btnSimpan
        '
        Me.btnSimpan.AutoEllipsis = True
        Me.btnSimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(145, 302)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSimpan.Size = New System.Drawing.Size(75, 31)
        Me.btnSimpan.TabIndex = 8
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'frmDetailPerwakilan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 345)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.lblKeterangan)
        Me.Controls.Add(Me.lblHP)
        Me.Controls.Add(Me.lblTelp)
        Me.Controls.Add(Me.lblKota)
        Me.Controls.Add(Me.lblPengurus)
        Me.Controls.Add(Me.lblAlamat)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.lblKode)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.lblMode)
        Me.Controls.Add(Me.txtHp)
        Me.Controls.Add(Me.txtTelp)
        Me.Controls.Add(Me.txtKota)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtPengurus)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtKode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetailPerwakilan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Edit Perwakilan :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtKode As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtPengurus As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtKota As System.Windows.Forms.TextBox
    Friend WithEvents txtTelp As System.Windows.Forms.TextBox
    Friend WithEvents txtHp As System.Windows.Forms.TextBox
    Friend WithEvents lblMode As System.Windows.Forms.Label
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents lblKode As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblPengurus As System.Windows.Forms.Label
    Friend WithEvents lblAlamat As System.Windows.Forms.Label
    Friend WithEvents lblKota As System.Windows.Forms.Label
    Friend WithEvents lblTelp As System.Windows.Forms.Label
    Friend WithEvents lblHP As System.Windows.Forms.Label
    Friend WithEvents lblKeterangan As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
End Class
