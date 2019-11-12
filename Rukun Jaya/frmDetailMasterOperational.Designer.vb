<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailMasterOperational
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtKodeJenisOperational = New System.Windows.Forms.TextBox()
        Me.txtNamaJenisOperational = New System.Windows.Forms.TextBox()
        Me.cmbJenisOperational = New System.Windows.Forms.ComboBox()
        Me.txtKetOperational = New System.Windows.Forms.TextBox()
        Me.btnSimpanOperational = New System.Windows.Forms.Button()
        Me.btnBatalOperational = New System.Windows.Forms.Button()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Jenis"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Jenis"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Keterangan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(93, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(93, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(93, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(93, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = ":"
        '
        'txtKodeJenisOperational
        '
        Me.txtKodeJenisOperational.Location = New System.Drawing.Point(109, 32)
        Me.txtKodeJenisOperational.MaxLength = 10
        Me.txtKodeJenisOperational.Name = "txtKodeJenisOperational"
        Me.txtKodeJenisOperational.Size = New System.Drawing.Size(100, 20)
        Me.txtKodeJenisOperational.TabIndex = 8
        '
        'txtNamaJenisOperational
        '
        Me.txtNamaJenisOperational.Location = New System.Drawing.Point(109, 67)
        Me.txtNamaJenisOperational.MaxLength = 50
        Me.txtNamaJenisOperational.Name = "txtNamaJenisOperational"
        Me.txtNamaJenisOperational.Size = New System.Drawing.Size(246, 20)
        Me.txtNamaJenisOperational.TabIndex = 9
        '
        'cmbJenisOperational
        '
        Me.cmbJenisOperational.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJenisOperational.FormattingEnabled = True
        Me.cmbJenisOperational.Items.AddRange(New Object() {"Biaya Lain", "Kas Bon"})
        Me.cmbJenisOperational.Location = New System.Drawing.Point(109, 97)
        Me.cmbJenisOperational.Name = "cmbJenisOperational"
        Me.cmbJenisOperational.Size = New System.Drawing.Size(121, 21)
        Me.cmbJenisOperational.TabIndex = 10
        '
        'txtKetOperational
        '
        Me.txtKetOperational.Location = New System.Drawing.Point(109, 127)
        Me.txtKetOperational.MaxLength = 100
        Me.txtKetOperational.Multiline = True
        Me.txtKetOperational.Name = "txtKetOperational"
        Me.txtKetOperational.Size = New System.Drawing.Size(246, 59)
        Me.txtKetOperational.TabIndex = 11
        '
        'btnSimpanOperational
        '
        Me.btnSimpanOperational.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnSimpanOperational.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpanOperational.Location = New System.Drawing.Point(109, 202)
        Me.btnSimpanOperational.Name = "btnSimpanOperational"
        Me.btnSimpanOperational.Size = New System.Drawing.Size(75, 31)
        Me.btnSimpanOperational.TabIndex = 12
        Me.btnSimpanOperational.Text = "&Simpan"
        Me.btnSimpanOperational.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpanOperational.UseVisualStyleBackColor = True
        '
        'btnBatalOperational
        '
        Me.btnBatalOperational.Image = Global.RukunJaya.My.Resources.Resources.cancelbr
        Me.btnBatalOperational.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatalOperational.Location = New System.Drawing.Point(190, 202)
        Me.btnBatalOperational.Name = "btnBatalOperational"
        Me.btnBatalOperational.Size = New System.Drawing.Size(75, 31)
        Me.btnBatalOperational.TabIndex = 13
        Me.btnBatalOperational.Text = "&Batal"
        Me.btnBatalOperational.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatalOperational.UseVisualStyleBackColor = True
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Location = New System.Drawing.Point(313, 9)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(31, 13)
        Me.lblMode.TabIndex = 14
        Me.lblMode.Text = "ubah"
        Me.lblMode.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(215, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "(Kode Jenis Wajib Diisi)"
        '
        'frmDetailMasterOperational
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 254)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblMode)
        Me.Controls.Add(Me.btnBatalOperational)
        Me.Controls.Add(Me.btnSimpanOperational)
        Me.Controls.Add(Me.txtKetOperational)
        Me.Controls.Add(Me.cmbJenisOperational)
        Me.Controls.Add(Me.txtNamaJenisOperational)
        Me.Controls.Add(Me.txtKodeJenisOperational)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetailMasterOperational"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Detail Master Operasional :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtKodeJenisOperational As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaJenisOperational As System.Windows.Forms.TextBox
    Friend WithEvents cmbJenisOperational As System.Windows.Forms.ComboBox
    Friend WithEvents txtKetOperational As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpanOperational As System.Windows.Forms.Button
    Friend WithEvents btnBatalOperational As System.Windows.Forms.Button
    Friend WithEvents lblMode As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
