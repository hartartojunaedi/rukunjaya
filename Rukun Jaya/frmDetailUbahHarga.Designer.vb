<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailUbahHarga
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
        Me.txtHargaTerakhir = New System.Windows.Forms.TextBox()
        Me.TxtNamaSparepart = New System.Windows.Forms.TextBox()
        Me.TxtKodeSP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtHargaTerakhir
        '
        Me.txtHargaTerakhir.Location = New System.Drawing.Point(116, 75)
        Me.txtHargaTerakhir.Name = "txtHargaTerakhir"
        Me.txtHargaTerakhir.Size = New System.Drawing.Size(112, 20)
        Me.txtHargaTerakhir.TabIndex = 9
        '
        'TxtNamaSparepart
        '
        Me.TxtNamaSparepart.Enabled = False
        Me.TxtNamaSparepart.Location = New System.Drawing.Point(116, 49)
        Me.TxtNamaSparepart.Name = "TxtNamaSparepart"
        Me.TxtNamaSparepart.Size = New System.Drawing.Size(191, 20)
        Me.TxtNamaSparepart.TabIndex = 7
        '
        'TxtKodeSP
        '
        Me.TxtKodeSP.Enabled = False
        Me.TxtKodeSP.Location = New System.Drawing.Point(116, 23)
        Me.TxtKodeSP.Name = "TxtKodeSP"
        Me.TxtKodeSP.Size = New System.Drawing.Size(112, 20)
        Me.TxtKodeSP.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Harga Terakhir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nama Sparepart"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Kode SparePart"
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.RukunJaya.My.Resources.Resources.cancelbr
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(178, 115)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 31)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSimpan.Location = New System.Drawing.Point(79, 115)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 31)
        Me.BtnSimpan.TabIndex = 10
        Me.BtnSimpan.Text = "&Simpan"
        Me.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'frmDetailUbahHarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 172)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.txtHargaTerakhir)
        Me.Controls.Add(Me.TxtNamaSparepart)
        Me.Controls.Add(Me.TxtKodeSP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetailUbahHarga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Detail Ubah Harga :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHargaTerakhir As System.Windows.Forms.TextBox
    Friend WithEvents TxtNamaSparepart As System.Windows.Forms.TextBox
    Friend WithEvents TxtKodeSP As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
End Class
