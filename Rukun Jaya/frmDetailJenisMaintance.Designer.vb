<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailJenisMaintance
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
        Me.cbkRutin = New System.Windows.Forms.CheckBox()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.txtNamaPekerjaan = New System.Windows.Forms.TextBox()
        Me.txtKodeJenisMaintance = New System.Windows.Forms.TextBox()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.lblNamaPekerjaan = New System.Windows.Forms.Label()
        Me.lblKodeJenisMaintance = New System.Windows.Forms.Label()
        Me.cbJenis = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nmJumlah = New System.Windows.Forms.NumericUpDown()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        CType(Me.nmJumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbkRutin
        '
        Me.cbkRutin.AutoSize = True
        Me.cbkRutin.Location = New System.Drawing.Point(41, 169)
        Me.cbkRutin.Name = "cbkRutin"
        Me.cbkRutin.Size = New System.Drawing.Size(51, 17)
        Me.cbkRutin.TabIndex = 16
        Me.cbkRutin.Text = "Rutin"
        Me.cbkRutin.UseVisualStyleBackColor = True
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(38, 78)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(256, 85)
        Me.txtKeterangan.TabIndex = 15
        '
        'txtNamaPekerjaan
        '
        Me.txtNamaPekerjaan.Location = New System.Drawing.Point(149, 33)
        Me.txtNamaPekerjaan.MaxLength = 50
        Me.txtNamaPekerjaan.Name = "txtNamaPekerjaan"
        Me.txtNamaPekerjaan.Size = New System.Drawing.Size(145, 20)
        Me.txtNamaPekerjaan.TabIndex = 14
        '
        'txtKodeJenisMaintance
        '
        Me.txtKodeJenisMaintance.Location = New System.Drawing.Point(149, 10)
        Me.txtKodeJenisMaintance.MaxLength = 5
        Me.txtKodeJenisMaintance.Name = "txtKodeJenisMaintance"
        Me.txtKodeJenisMaintance.Size = New System.Drawing.Size(145, 20)
        Me.txtKodeJenisMaintance.TabIndex = 13
        '
        'lblKeterangan
        '
        Me.lblKeterangan.AutoSize = True
        Me.lblKeterangan.Location = New System.Drawing.Point(35, 61)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(62, 13)
        Me.lblKeterangan.TabIndex = 12
        Me.lblKeterangan.Text = "Keterangan"
        '
        'lblNamaPekerjaan
        '
        Me.lblNamaPekerjaan.AutoSize = True
        Me.lblNamaPekerjaan.Location = New System.Drawing.Point(35, 36)
        Me.lblNamaPekerjaan.Name = "lblNamaPekerjaan"
        Me.lblNamaPekerjaan.Size = New System.Drawing.Size(86, 13)
        Me.lblNamaPekerjaan.TabIndex = 11
        Me.lblNamaPekerjaan.Text = "Nama Pekerjaan"
        '
        'lblKodeJenisMaintance
        '
        Me.lblKodeJenisMaintance.AutoSize = True
        Me.lblKodeJenisMaintance.Location = New System.Drawing.Point(34, 10)
        Me.lblKodeJenisMaintance.Name = "lblKodeJenisMaintance"
        Me.lblKodeJenisMaintance.Size = New System.Drawing.Size(112, 13)
        Me.lblKodeJenisMaintance.TabIndex = 10
        Me.lblKodeJenisMaintance.Text = "Kode Jenis Maintance"
        '
        'cbJenis
        '
        Me.cbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbJenis.FormattingEnabled = True
        Me.cbJenis.Items.AddRange(New Object() {"By Ritase (PP)", "By Km", "By Month"})
        Me.cbJenis.Location = New System.Drawing.Point(149, 169)
        Me.cbJenis.Name = "cbJenis"
        Me.cbJenis.Size = New System.Drawing.Size(145, 21)
        Me.cbJenis.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Setiap "
        '
        'nmJumlah
        '
        Me.nmJumlah.Location = New System.Drawing.Point(149, 196)
        Me.nmJumlah.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nmJumlah.Name = "nmJumlah"
        Me.nmJumlah.Size = New System.Drawing.Size(145, 20)
        Me.nmJumlah.TabIndex = 22
        Me.nmJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnBatal
        '
        Me.btnBatal.Image = Global.RukunJaya.My.Resources.Resources.cancelbr
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(179, 232)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 31)
        Me.btnBatal.TabIndex = 18
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(46, 232)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 31)
        Me.btnSimpan.TabIndex = 17
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'frmDetailJenisMaintance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 275)
        Me.Controls.Add(Me.nmJumlah)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbJenis)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.cbkRutin)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.txtNamaPekerjaan)
        Me.Controls.Add(Me.txtKodeJenisMaintance)
        Me.Controls.Add(Me.lblKeterangan)
        Me.Controls.Add(Me.lblNamaPekerjaan)
        Me.Controls.Add(Me.lblKodeJenisMaintance)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetailJenisMaintance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Detail Jenis Maintance :."
        CType(Me.nmJumlah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents cbkRutin As System.Windows.Forms.CheckBox
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaPekerjaan As System.Windows.Forms.TextBox
    Friend WithEvents txtKodeJenisMaintance As System.Windows.Forms.TextBox
    Friend WithEvents lblKeterangan As System.Windows.Forms.Label
    Friend WithEvents lblNamaPekerjaan As System.Windows.Forms.Label
    Friend WithEvents lblKodeJenisMaintance As System.Windows.Forms.Label
    Friend WithEvents cbJenis As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nmJumlah As System.Windows.Forms.NumericUpDown
End Class
