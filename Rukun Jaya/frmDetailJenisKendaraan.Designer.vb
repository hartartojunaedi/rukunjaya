<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailJenisKendaraan
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
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.txtNamaJenisKendaraan = New System.Windows.Forms.TextBox()
        Me.txtKodeJenisKendaraan = New System.Windows.Forms.TextBox()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.lblNamaJenis = New System.Windows.Forms.Label()
        Me.lblKodeJenis = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBatal
        '
        Me.btnBatal.Image = Global.RukunJaya.My.Resources.Resources.cancelbr
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(163, 209)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 31)
        Me.btnBatal.TabIndex = 4
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(16, 103)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(268, 100)
        Me.txtKeterangan.TabIndex = 2
        '
        'txtNamaJenisKendaraan
        '
        Me.txtNamaJenisKendaraan.Location = New System.Drawing.Point(139, 53)
        Me.txtNamaJenisKendaraan.Name = "txtNamaJenisKendaraan"
        Me.txtNamaJenisKendaraan.Size = New System.Drawing.Size(145, 20)
        Me.txtNamaJenisKendaraan.TabIndex = 1
        '
        'txtKodeJenisKendaraan
        '
        Me.txtKodeJenisKendaraan.Location = New System.Drawing.Point(139, 27)
        Me.txtKodeJenisKendaraan.Name = "txtKodeJenisKendaraan"
        Me.txtKodeJenisKendaraan.Size = New System.Drawing.Size(145, 20)
        Me.txtKodeJenisKendaraan.TabIndex = 0
        '
        'lblKeterangan
        '
        Me.lblKeterangan.AutoSize = True
        Me.lblKeterangan.Location = New System.Drawing.Point(13, 87)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(65, 13)
        Me.lblKeterangan.TabIndex = 13
        Me.lblKeterangan.Text = "Keterangan:"
        '
        'lblNamaJenis
        '
        Me.lblNamaJenis.AutoSize = True
        Me.lblNamaJenis.Location = New System.Drawing.Point(13, 56)
        Me.lblNamaJenis.Name = "lblNamaJenis"
        Me.lblNamaJenis.Size = New System.Drawing.Size(120, 13)
        Me.lblNamaJenis.TabIndex = 12
        Me.lblNamaJenis.Text = "Nama Jenis Kendaraan:"
        '
        'lblKodeJenis
        '
        Me.lblKodeJenis.AutoSize = True
        Me.lblKodeJenis.Location = New System.Drawing.Point(16, 27)
        Me.lblKodeJenis.Name = "lblKodeJenis"
        Me.lblKodeJenis.Size = New System.Drawing.Size(117, 13)
        Me.lblKodeJenis.TabIndex = 11
        Me.lblKodeJenis.Text = "Kode Jenis Kendaraan:"
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(46, 209)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 31)
        Me.btnSimpan.TabIndex = 3
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'frmDetailJenisKendaraan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 262)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.txtNamaJenisKendaraan)
        Me.Controls.Add(Me.txtKodeJenisKendaraan)
        Me.Controls.Add(Me.lblKeterangan)
        Me.Controls.Add(Me.lblNamaJenis)
        Me.Controls.Add(Me.lblKodeJenis)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetailJenisKendaraan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Detail Jenis Kendaraan :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaJenisKendaraan As System.Windows.Forms.TextBox
    Friend WithEvents txtKodeJenisKendaraan As System.Windows.Forms.TextBox
    Friend WithEvents lblKeterangan As System.Windows.Forms.Label
    Friend WithEvents lblNamaJenis As System.Windows.Forms.Label
    Friend WithEvents lblKodeJenis As System.Windows.Forms.Label
End Class
