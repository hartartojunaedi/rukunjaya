<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailPerusahaan
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
        Me.lblKodePerusahaan = New System.Windows.Forms.Label()
        Me.lblNamaPerusahaan = New System.Windows.Forms.Label()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.txtKodePerusahaan = New System.Windows.Forms.TextBox()
        Me.txtNamaPerusahaan = New System.Windows.Forms.TextBox()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.cbkHolding = New System.Windows.Forms.CheckBox()
        Me.lblProsentase = New System.Windows.Forms.Label()
        Me.nudProsentase = New System.Windows.Forms.NumericUpDown()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        CType(Me.nudProsentase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblKodePerusahaan
        '
        Me.lblKodePerusahaan.AutoSize = True
        Me.lblKodePerusahaan.Location = New System.Drawing.Point(12, 9)
        Me.lblKodePerusahaan.Name = "lblKodePerusahaan"
        Me.lblKodePerusahaan.Size = New System.Drawing.Size(95, 13)
        Me.lblKodePerusahaan.TabIndex = 0
        Me.lblKodePerusahaan.Text = "Kode Perusahaan:"
        '
        'lblNamaPerusahaan
        '
        Me.lblNamaPerusahaan.AutoSize = True
        Me.lblNamaPerusahaan.Location = New System.Drawing.Point(13, 35)
        Me.lblNamaPerusahaan.Name = "lblNamaPerusahaan"
        Me.lblNamaPerusahaan.Size = New System.Drawing.Size(98, 13)
        Me.lblNamaPerusahaan.TabIndex = 1
        Me.lblNamaPerusahaan.Text = "Nama Perusahaan:"
        '
        'lblKeterangan
        '
        Me.lblKeterangan.AutoSize = True
        Me.lblKeterangan.Location = New System.Drawing.Point(13, 61)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(65, 13)
        Me.lblKeterangan.TabIndex = 2
        Me.lblKeterangan.Text = "Keterangan:"
        '
        'txtKodePerusahaan
        '
        Me.txtKodePerusahaan.Location = New System.Drawing.Point(127, 9)
        Me.txtKodePerusahaan.Name = "txtKodePerusahaan"
        Me.txtKodePerusahaan.Size = New System.Drawing.Size(145, 20)
        Me.txtKodePerusahaan.TabIndex = 3
        '
        'txtNamaPerusahaan
        '
        Me.txtNamaPerusahaan.Location = New System.Drawing.Point(127, 32)
        Me.txtNamaPerusahaan.Name = "txtNamaPerusahaan"
        Me.txtNamaPerusahaan.Size = New System.Drawing.Size(145, 20)
        Me.txtNamaPerusahaan.TabIndex = 4
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(16, 78)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(256, 85)
        Me.txtKeterangan.TabIndex = 5
        '
        'cbkHolding
        '
        Me.cbkHolding.AutoSize = True
        Me.cbkHolding.Location = New System.Drawing.Point(19, 169)
        Me.cbkHolding.Name = "cbkHolding"
        Me.cbkHolding.Size = New System.Drawing.Size(62, 17)
        Me.cbkHolding.TabIndex = 6
        Me.cbkHolding.Text = "Holding"
        Me.cbkHolding.UseVisualStyleBackColor = True
        '
        'lblProsentase
        '
        Me.lblProsentase.AutoSize = True
        Me.lblProsentase.Location = New System.Drawing.Point(148, 170)
        Me.lblProsentase.Name = "lblProsentase"
        Me.lblProsentase.Size = New System.Drawing.Size(63, 13)
        Me.lblProsentase.TabIndex = 10
        Me.lblProsentase.Text = "Prosentase:"
        '
        'nudProsentase
        '
        Me.nudProsentase.Location = New System.Drawing.Point(219, 166)
        Me.nudProsentase.Name = "nudProsentase"
        Me.nudProsentase.Size = New System.Drawing.Size(53, 20)
        Me.nudProsentase.TabIndex = 7
        '
        'btnBatal
        '
        Me.btnBatal.Image = Global.RukunJaya.My.Resources.Resources.cancelbr
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(172, 204)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 31)
        Me.btnBatal.TabIndex = 9
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(36, 204)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 31)
        Me.btnSimpan.TabIndex = 8
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'frmDetailPerusahaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.nudProsentase)
        Me.Controls.Add(Me.lblProsentase)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.cbkHolding)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.txtNamaPerusahaan)
        Me.Controls.Add(Me.txtKodePerusahaan)
        Me.Controls.Add(Me.lblKeterangan)
        Me.Controls.Add(Me.lblNamaPerusahaan)
        Me.Controls.Add(Me.lblKodePerusahaan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetailPerusahaan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Detail Perusahaan :."
        CType(Me.nudProsentase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblKodePerusahaan As System.Windows.Forms.Label
    Friend WithEvents lblNamaPerusahaan As System.Windows.Forms.Label
    Friend WithEvents lblKeterangan As System.Windows.Forms.Label
    Friend WithEvents txtKodePerusahaan As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaPerusahaan As System.Windows.Forms.TextBox
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents cbkHolding As System.Windows.Forms.CheckBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents lblProsentase As System.Windows.Forms.Label
    Friend WithEvents nudProsentase As System.Windows.Forms.NumericUpDown
End Class
