<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailBank
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
        Me.lblkodebank = New System.Windows.Forms.Label()
        Me.lblNamaBank = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.txtkodebank = New System.Windows.Forms.TextBox()
        Me.txtnamabank = New System.Windows.Forms.TextBox()
        Me.txtsaldo = New System.Windows.Forms.TextBox()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoRekening = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblkodebank
        '
        Me.lblkodebank.AutoSize = True
        Me.lblkodebank.Location = New System.Drawing.Point(12, 9)
        Me.lblkodebank.Name = "lblkodebank"
        Me.lblkodebank.Size = New System.Drawing.Size(60, 13)
        Me.lblkodebank.TabIndex = 0
        Me.lblkodebank.Text = "Kode Bank"
        '
        'lblNamaBank
        '
        Me.lblNamaBank.AutoSize = True
        Me.lblNamaBank.Location = New System.Drawing.Point(9, 35)
        Me.lblNamaBank.Name = "lblNamaBank"
        Me.lblNamaBank.Size = New System.Drawing.Size(63, 13)
        Me.lblNamaBank.TabIndex = 1
        Me.lblNamaBank.Text = "Nama Bank"
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Location = New System.Drawing.Point(38, 90)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(34, 13)
        Me.lblSaldo.TabIndex = 2
        Me.lblSaldo.Text = "Saldo"
        '
        'lblKeterangan
        '
        Me.lblKeterangan.AutoSize = True
        Me.lblKeterangan.Location = New System.Drawing.Point(10, 116)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(62, 13)
        Me.lblKeterangan.TabIndex = 3
        Me.lblKeterangan.Text = "Keterangan"
        '
        'txtkodebank
        '
        Me.txtkodebank.Location = New System.Drawing.Point(79, 6)
        Me.txtkodebank.Name = "txtkodebank"
        Me.txtkodebank.Size = New System.Drawing.Size(92, 20)
        Me.txtkodebank.TabIndex = 1
        '
        'txtnamabank
        '
        Me.txtnamabank.Location = New System.Drawing.Point(79, 32)
        Me.txtnamabank.Name = "txtnamabank"
        Me.txtnamabank.Size = New System.Drawing.Size(138, 20)
        Me.txtnamabank.TabIndex = 2
        '
        'txtsaldo
        '
        Me.txtsaldo.Location = New System.Drawing.Point(79, 87)
        Me.txtsaldo.Name = "txtsaldo"
        Me.txtsaldo.Size = New System.Drawing.Size(128, 20)
        Me.txtsaldo.TabIndex = 4
        Me.txtsaldo.Text = "0"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(79, 113)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(151, 65)
        Me.txtKeterangan.TabIndex = 5
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(65, 184)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 31)
        Me.btnSimpan.TabIndex = 6
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Image = Global.RukunJaya.My.Resources.Resources.cancelbr
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(155, 184)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 31)
        Me.btnBatal.TabIndex = 7
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "No Rekening"
        '
        'txtNoRekening
        '
        Me.txtNoRekening.Location = New System.Drawing.Point(79, 59)
        Me.txtNoRekening.MaxLength = 20
        Me.txtNoRekening.Name = "txtNoRekening"
        Me.txtNoRekening.Size = New System.Drawing.Size(151, 20)
        Me.txtNoRekening.TabIndex = 3
        '
        'frmDetailBank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 230)
        Me.Controls.Add(Me.txtNoRekening)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.txtsaldo)
        Me.Controls.Add(Me.txtnamabank)
        Me.Controls.Add(Me.txtkodebank)
        Me.Controls.Add(Me.lblKeterangan)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.lblNamaBank)
        Me.Controls.Add(Me.lblkodebank)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetailBank"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Detail Bank :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblkodebank As System.Windows.Forms.Label
    Friend WithEvents lblNamaBank As System.Windows.Forms.Label
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents lblKeterangan As System.Windows.Forms.Label
    Friend WithEvents txtkodebank As System.Windows.Forms.TextBox
    Friend WithEvents txtnamabank As System.Windows.Forms.TextBox
    Friend WithEvents txtsaldo As System.Windows.Forms.TextBox
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoRekening As System.Windows.Forms.TextBox
End Class
