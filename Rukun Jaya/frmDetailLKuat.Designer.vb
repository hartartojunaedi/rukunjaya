<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailLKuat
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
        Me.btnCari = New System.Windows.Forms.Button()
        Me.lblNoBM = New System.Windows.Forms.Label()
        Me.lblNoSuratJalan = New System.Windows.Forms.Label()
        Me.LblKodeBarang = New System.Windows.Forms.Label()
        Me.lblNoDo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblnourut = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNoFrame = New System.Windows.Forms.TextBox()
        Me.txtNoEngine = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.txtkerusakan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblNamaBarang = New System.Windows.Forms.Label()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No BM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No Surat Jalan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(244, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kode Barang"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No DO"
        '
        'btnCari
        '
        Me.btnCari.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCari.Location = New System.Drawing.Point(247, 9)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(67, 28)
        Me.btnCari.TabIndex = 4
        Me.btnCari.Text = "Search"
        Me.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'lblNoBM
        '
        Me.lblNoBM.AutoSize = True
        Me.lblNoBM.Location = New System.Drawing.Point(96, 9)
        Me.lblNoBM.Name = "lblNoBM"
        Me.lblNoBM.Size = New System.Drawing.Size(0, 13)
        Me.lblNoBM.TabIndex = 5
        '
        'lblNoSuratJalan
        '
        Me.lblNoSuratJalan.AutoSize = True
        Me.lblNoSuratJalan.Location = New System.Drawing.Point(99, 35)
        Me.lblNoSuratJalan.Name = "lblNoSuratJalan"
        Me.lblNoSuratJalan.Size = New System.Drawing.Size(0, 13)
        Me.lblNoSuratJalan.TabIndex = 6
        '
        'LblKodeBarang
        '
        Me.LblKodeBarang.AutoSize = True
        Me.LblKodeBarang.Location = New System.Drawing.Point(320, 40)
        Me.LblKodeBarang.Name = "LblKodeBarang"
        Me.LblKodeBarang.Size = New System.Drawing.Size(0, 13)
        Me.LblKodeBarang.TabIndex = 7
        Me.LblKodeBarang.Visible = False
        '
        'lblNoDo
        '
        Me.lblNoDo.AutoSize = True
        Me.lblNoDo.Location = New System.Drawing.Point(99, 85)
        Me.lblNoDo.Name = "lblNoDo"
        Me.lblNoDo.Size = New System.Drawing.Size(0, 13)
        Me.lblNoDo.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "No Urut"
        '
        'lblnourut
        '
        Me.lblnourut.AutoSize = True
        Me.lblnourut.Location = New System.Drawing.Point(99, 112)
        Me.lblnourut.Name = "lblnourut"
        Me.lblnourut.Size = New System.Drawing.Size(0, 13)
        Me.lblnourut.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "No Frame"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "No Engine"
        '
        'txtNoFrame
        '
        Me.txtNoFrame.Location = New System.Drawing.Point(102, 165)
        Me.txtNoFrame.Name = "txtNoFrame"
        Me.txtNoFrame.Size = New System.Drawing.Size(118, 20)
        Me.txtNoFrame.TabIndex = 13
        '
        'txtNoEngine
        '
        Me.txtNoEngine.Location = New System.Drawing.Point(102, 191)
        Me.txtNoEngine.Name = "txtNoEngine"
        Me.txtNoEngine.Size = New System.Drawing.Size(159, 20)
        Me.txtNoEngine.TabIndex = 14
        '
        'btnTambah
        '
        Me.btnTambah.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(113, 326)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(86, 27)
        Me.btnTambah.TabIndex = 16
        Me.btnTambah.Text = "&Simpan"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'txtkerusakan
        '
        Me.txtkerusakan.Location = New System.Drawing.Point(102, 218)
        Me.txtkerusakan.Multiline = True
        Me.txtkerusakan.Name = "txtkerusakan"
        Me.txtkerusakan.Size = New System.Drawing.Size(139, 102)
        Me.txtkerusakan.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Kerusakan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Nama Barang"
        '
        'lblNamaBarang
        '
        Me.lblNamaBarang.AutoSize = True
        Me.lblNamaBarang.Location = New System.Drawing.Point(99, 60)
        Me.lblNamaBarang.Name = "lblNamaBarang"
        Me.lblNamaBarang.Size = New System.Drawing.Size(0, 13)
        Me.lblNamaBarang.TabIndex = 19
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(102, 139)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(118, 20)
        Me.txtjumlah.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(46, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Jumlah "
        '
        'frmDetailLKuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 376)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblNamaBarang)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtkerusakan)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.txtNoEngine)
        Me.Controls.Add(Me.txtNoFrame)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblnourut)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblNoDo)
        Me.Controls.Add(Me.LblKodeBarang)
        Me.Controls.Add(Me.lblNoSuratJalan)
        Me.Controls.Add(Me.lblNoBM)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetailLKuat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Detail LKuat :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents lblNoBM As System.Windows.Forms.Label
    Friend WithEvents lblNoSuratJalan As System.Windows.Forms.Label
    Friend WithEvents LblKodeBarang As System.Windows.Forms.Label
    Friend WithEvents lblNoDo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblnourut As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNoFrame As System.Windows.Forms.TextBox
    Friend WithEvents txtNoEngine As System.Windows.Forms.TextBox
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents txtkerusakan As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblNamaBarang As System.Windows.Forms.Label
    Friend WithEvents txtjumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
