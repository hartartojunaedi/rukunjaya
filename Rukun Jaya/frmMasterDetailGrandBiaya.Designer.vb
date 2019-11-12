<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterDetailGrandBiaya
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
        Me.rbkredit = New System.Windows.Forms.RadioButton()
        Me.rbDebit = New System.Windows.Forms.RadioButton()
        Me.txtnamabiaya = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtKodeBiaya = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rbkredit
        '
        Me.rbkredit.AutoSize = True
        Me.rbkredit.Location = New System.Drawing.Point(183, 109)
        Me.rbkredit.Name = "rbkredit"
        Me.rbkredit.Size = New System.Drawing.Size(76, 17)
        Me.rbkredit.TabIndex = 48
        Me.rbkredit.Text = "Tambahan"
        Me.rbkredit.UseVisualStyleBackColor = True
        '
        'rbDebit
        '
        Me.rbDebit.AutoSize = True
        Me.rbDebit.Checked = True
        Me.rbDebit.Location = New System.Drawing.Point(106, 109)
        Me.rbDebit.Name = "rbDebit"
        Me.rbDebit.Size = New System.Drawing.Size(71, 17)
        Me.rbDebit.TabIndex = 47
        Me.rbDebit.TabStop = True
        Me.rbDebit.Text = "Potongan"
        Me.rbDebit.UseVisualStyleBackColor = True
        '
        'txtnamabiaya
        '
        Me.txtnamabiaya.Location = New System.Drawing.Point(106, 82)
        Me.txtnamabiaya.Name = "txtnamabiaya"
        Me.txtnamabiaya.Size = New System.Drawing.Size(125, 20)
        Me.txtnamabiaya.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Nama :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Location = New System.Drawing.Point(238, 16)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(22, 13)
        Me.lblMode.TabIndex = 44
        Me.lblMode.Text = "xxx"
        Me.lblMode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(192, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Mode :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtKodeBiaya
        '
        Me.txtKodeBiaya.AcceptsTab = True
        Me.txtKodeBiaya.Location = New System.Drawing.Point(106, 56)
        Me.txtKodeBiaya.Name = "txtKodeBiaya"
        Me.txtKodeBiaya.Size = New System.Drawing.Size(125, 20)
        Me.txtKodeBiaya.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Kode Biaya :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnBatal
        '
        Me.btnBatal.Image = Global.RukunJaya.My.Resources.Resources.cancelbr
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(157, 145)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 31)
        Me.btnBatal.TabIndex = 50
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(44, 146)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 31)
        Me.btnSimpan.TabIndex = 49
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'frmMasterDetailGrandBiaya
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 202)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.rbkredit)
        Me.Controls.Add(Me.rbDebit)
        Me.Controls.Add(Me.txtnamabiaya)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblMode)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtKodeBiaya)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMasterDetailGrandBiaya"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Detail Master Biaya Totalan :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents rbkredit As System.Windows.Forms.RadioButton
    Friend WithEvents rbDebit As System.Windows.Forms.RadioButton
    Friend WithEvents txtnamabiaya As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblMode As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtKodeBiaya As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
