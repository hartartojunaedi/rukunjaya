<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRealisasi
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
        Me.txtKodeRealisasi = New System.Windows.Forms.TextBox()
        Me.dtptanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNoBM = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblnamasopir = New System.Windows.Forms.Label()
        Me.lblnolambung = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtketerangan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdebet = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtkredit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Realisasi : "
        '
        'txtKodeRealisasi
        '
        Me.txtKodeRealisasi.Location = New System.Drawing.Point(104, 15)
        Me.txtKodeRealisasi.Name = "txtKodeRealisasi"
        Me.txtKodeRealisasi.Size = New System.Drawing.Size(100, 20)
        Me.txtKodeRealisasi.TabIndex = 1
        '
        'dtptanggal
        '
        Me.dtptanggal.CustomFormat = "dd-MM-yyyy"
        Me.dtptanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptanggal.Location = New System.Drawing.Point(104, 41)
        Me.dtptanggal.Name = "dtptanggal"
        Me.dtptanggal.Size = New System.Drawing.Size(91, 20)
        Me.dtptanggal.TabIndex = 75
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(43, 47)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(55, 13)
        Me.Label21.TabIndex = 76
        Me.Label21.Text = "Tanggal : "
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(357, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "No BM : "
        '
        'txtNoBM
        '
        Me.txtNoBM.Location = New System.Drawing.Point(412, 15)
        Me.txtNoBM.Name = "txtNoBM"
        Me.txtNoBM.Size = New System.Drawing.Size(100, 20)
        Me.txtNoBM.TabIndex = 78
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(519, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 23)
        Me.Button1.TabIndex = 79
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblnamasopir
        '
        Me.lblnamasopir.AutoSize = True
        Me.lblnamasopir.Location = New System.Drawing.Point(420, 70)
        Me.lblnamasopir.Name = "lblnamasopir"
        Me.lblnamasopir.Size = New System.Drawing.Size(0, 13)
        Me.lblnamasopir.TabIndex = 83
        '
        'lblnolambung
        '
        Me.lblnolambung.AutoSize = True
        Me.lblnolambung.Location = New System.Drawing.Point(420, 48)
        Me.lblnolambung.Name = "lblnolambung"
        Me.lblnolambung.Size = New System.Drawing.Size(0, 13)
        Me.lblnolambung.TabIndex = 82
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(339, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Nama Sopir : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(294, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "No Lambung / Nopol : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtketerangan
        '
        Me.txtketerangan.Location = New System.Drawing.Point(104, 67)
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.Size = New System.Drawing.Size(229, 20)
        Me.txtketerangan.TabIndex = 85
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Keterangan : "
        '
        'txtdebet
        '
        Me.txtdebet.Location = New System.Drawing.Point(104, 95)
        Me.txtdebet.Name = "txtdebet"
        Me.txtdebet.Size = New System.Drawing.Size(100, 20)
        Me.txtdebet.TabIndex = 87
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Debit : "
        '
        'txtkredit
        '
        Me.txtkredit.Location = New System.Drawing.Point(104, 121)
        Me.txtkredit.Name = "txtkredit"
        Me.txtkredit.Size = New System.Drawing.Size(100, 20)
        Me.txtkredit.TabIndex = 89
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(57, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "Kredit : "
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.RukunJaya.My.Resources.Resources.cancelbr
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(319, 161)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 27)
        Me.btnCancel.TabIndex = 91
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSimpan.Location = New System.Drawing.Point(227, 161)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(78, 27)
        Me.BtnSimpan.TabIndex = 90
        Me.BtnSimpan.Text = "&Simpan"
        Me.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'frmRealisasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 197)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.txtkredit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtdebet)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtketerangan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblnamasopir)
        Me.Controls.Add(Me.lblnolambung)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtNoBM)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtptanggal)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtKodeRealisasi)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRealisasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Transaksi Realisasi :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKodeRealisasi As System.Windows.Forms.TextBox
    Friend WithEvents dtptanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNoBM As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblnamasopir As System.Windows.Forms.Label
    Friend WithEvents lblnolambung As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtketerangan As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtdebet As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtkredit As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
End Class
