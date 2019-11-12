<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailKas
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
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.txtnamakas = New System.Windows.Forms.TextBox()
        Me.lblNamaPerusahaan = New System.Windows.Forms.Label()
        Me.lblKodePerusahaan = New System.Windows.Forms.Label()
        Me.dtpTgl = New System.Windows.Forms.DateTimePicker()
        Me.lblTglKir = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(118, 35)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(145, 20)
        Me.txtjumlah.TabIndex = 8
        '
        'txtnamakas
        '
        Me.txtnamakas.Location = New System.Drawing.Point(118, 12)
        Me.txtnamakas.Name = "txtnamakas"
        Me.txtnamakas.Size = New System.Drawing.Size(145, 20)
        Me.txtnamakas.TabIndex = 7
        '
        'lblNamaPerusahaan
        '
        Me.lblNamaPerusahaan.AutoSize = True
        Me.lblNamaPerusahaan.Location = New System.Drawing.Point(61, 38)
        Me.lblNamaPerusahaan.Name = "lblNamaPerusahaan"
        Me.lblNamaPerusahaan.Size = New System.Drawing.Size(40, 13)
        Me.lblNamaPerusahaan.TabIndex = 6
        Me.lblNamaPerusahaan.Text = "Jumlah"
        '
        'lblKodePerusahaan
        '
        Me.lblKodePerusahaan.AutoSize = True
        Me.lblKodePerusahaan.Location = New System.Drawing.Point(45, 12)
        Me.lblKodePerusahaan.Name = "lblKodePerusahaan"
        Me.lblKodePerusahaan.Size = New System.Drawing.Size(56, 13)
        Me.lblKodePerusahaan.TabIndex = 5
        Me.lblKodePerusahaan.Text = "Nama Kas"
        '
        'dtpTgl
        '
        Me.dtpTgl.CustomFormat = "dd-MM-yyyy"
        Me.dtpTgl.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTgl.Location = New System.Drawing.Point(118, 61)
        Me.dtpTgl.Name = "dtpTgl"
        Me.dtpTgl.Size = New System.Drawing.Size(101, 20)
        Me.dtpTgl.TabIndex = 46
        '
        'lblTglKir
        '
        Me.lblTglKir.AutoSize = True
        Me.lblTglKir.Location = New System.Drawing.Point(55, 67)
        Me.lblTglKir.Name = "lblTglKir"
        Me.lblTglKir.Size = New System.Drawing.Size(46, 13)
        Me.lblTglKir.TabIndex = 45
        Me.lblTglKir.Text = "Tanggal"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(118, 87)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtKeterangan.Size = New System.Drawing.Size(145, 93)
        Me.txtKeterangan.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Keterangan"
        '
        'btntambah
        '
        Me.btntambah.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btntambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntambah.Location = New System.Drawing.Point(52, 199)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 31)
        Me.btntambah.TabIndex = 51
        Me.btntambah.Text = "Simpan"
        Me.btntambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.Image = Global.RukunJaya.My.Resources.Resources.cancelbr
        Me.btnbatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbatal.Location = New System.Drawing.Point(133, 199)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(75, 31)
        Me.btnbatal.TabIndex = 50
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'frmDetailKas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpTgl)
        Me.Controls.Add(Me.lblTglKir)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.txtnamakas)
        Me.Controls.Add(Me.lblNamaPerusahaan)
        Me.Controls.Add(Me.lblKodePerusahaan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetailKas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Detail Kas :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtjumlah As System.Windows.Forms.TextBox
    Friend WithEvents txtnamakas As System.Windows.Forms.TextBox
    Friend WithEvents lblNamaPerusahaan As System.Windows.Forms.Label
    Friend WithEvents lblKodePerusahaan As System.Windows.Forms.Label
    Friend WithEvents dtpTgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTglKir As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents btnbatal As System.Windows.Forms.Button
End Class
