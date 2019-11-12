<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailVoucher
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblKodeVoucher = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSPBU = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblLiter = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTgl = New System.Windows.Forms.Label()
        Me.lblKodeBM = New System.Windows.Forms.LinkLabel()
        Me.lblKodeSJ = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSisa = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Kode Voucher :"
        '
        'lblKodeVoucher
        '
        Me.lblKodeVoucher.AutoSize = True
        Me.lblKodeVoucher.Location = New System.Drawing.Point(117, 41)
        Me.lblKodeVoucher.Name = "lblKodeVoucher"
        Me.lblKodeVoucher.Size = New System.Drawing.Size(31, 13)
        Me.lblKodeVoucher.TabIndex = 15
        Me.lblKodeVoucher.Text = "kode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Data Voucher"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Kode Surat Jalan :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Kode Bon Muat :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(69, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "SPBU :"
        '
        'lblSPBU
        '
        Me.lblSPBU.AutoSize = True
        Me.lblSPBU.Location = New System.Drawing.Point(117, 132)
        Me.lblSPBU.Name = "lblSPBU"
        Me.lblSPBU.Size = New System.Drawing.Size(30, 13)
        Me.lblSPBU.TabIndex = 23
        Me.lblSPBU.Text = "spbu"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Liter / Sisa :"
        '
        'lblLiter
        '
        Me.lblLiter.AutoSize = True
        Me.lblLiter.Location = New System.Drawing.Point(117, 154)
        Me.lblLiter.Name = "lblLiter"
        Me.lblLiter.Size = New System.Drawing.Size(23, 13)
        Me.lblLiter.TabIndex = 25
        Me.lblLiter.Text = "liter"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Tanggal Voucher :"
        '
        'lblTgl
        '
        Me.lblTgl.AutoSize = True
        Me.lblTgl.Location = New System.Drawing.Point(117, 176)
        Me.lblTgl.Name = "lblTgl"
        Me.lblTgl.Size = New System.Drawing.Size(18, 13)
        Me.lblTgl.TabIndex = 27
        Me.lblTgl.Text = "tgl"
        '
        'lblKodeBM
        '
        Me.lblKodeBM.AutoSize = True
        Me.lblKodeBM.Location = New System.Drawing.Point(117, 66)
        Me.lblKodeBM.Name = "lblKodeBM"
        Me.lblKodeBM.Size = New System.Drawing.Size(47, 13)
        Me.lblKodeBM.TabIndex = 29
        Me.lblKodeBM.TabStop = True
        Me.lblKodeBM.Text = "kodeBM"
        '
        'lblKodeSJ
        '
        Me.lblKodeSJ.AutoSize = True
        Me.lblKodeSJ.Location = New System.Drawing.Point(117, 89)
        Me.lblKodeSJ.Name = "lblKodeSJ"
        Me.lblKodeSJ.Size = New System.Drawing.Size(43, 13)
        Me.lblKodeSJ.TabIndex = 30
        Me.lblKodeSJ.TabStop = True
        Me.lblKodeSJ.Text = "kodeSJ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(146, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(12, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "/"
        '
        'lblSisa
        '
        Me.lblSisa.AutoSize = True
        Me.lblSisa.Location = New System.Drawing.Point(164, 154)
        Me.lblSisa.Name = "lblSisa"
        Me.lblSisa.Size = New System.Drawing.Size(25, 13)
        Me.lblSisa.TabIndex = 32
        Me.lblSisa.Text = "sisa"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(69, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Status :"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(117, 199)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(35, 13)
        Me.lblStatus.TabIndex = 34
        Me.lblStatus.Text = "status"
        '
        'btnCetak
        '
        Me.btnCetak.Image = Global.RukunJaya.My.Resources.Resources.printbr1
        Me.btnCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCetak.Location = New System.Drawing.Point(241, 32)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(75, 31)
        Me.btnCetak.TabIndex = 35
        Me.btnCetak.Text = "&Cetak"
        Me.btnCetak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'frmDetailVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 247)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblSisa)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblKodeSJ)
        Me.Controls.Add(Me.lblKodeBM)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblTgl)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblLiter)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblSPBU)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblKodeVoucher)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetailVoucher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Detail Voucher :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblKodeVoucher As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSPBU As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblLiter As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblTgl As System.Windows.Forms.Label
    Friend WithEvents lblKodeBM As System.Windows.Forms.LinkLabel
    Friend WithEvents lblKodeSJ As System.Windows.Forms.LinkLabel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblSisa As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnCetak As System.Windows.Forms.Button
End Class
