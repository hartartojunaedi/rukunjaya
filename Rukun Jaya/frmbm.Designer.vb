<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbm
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
        Me.txtNoBM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoLambung = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKodeSopir = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblNoPolisi = New System.Windows.Forms.Label()
        Me.lblNamaSopir = New System.Windows.Forms.Label()
        Me.dtptanggal = New System.Windows.Forms.DateTimePicker()
        Me.btnsearchlambung = New System.Windows.Forms.Button()
        Me.btnsearchsopir = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNoBM
        '
        Me.txtNoBM.Location = New System.Drawing.Point(104, 24)
        Me.txtNoBM.Name = "txtNoBM"
        Me.txtNoBM.Size = New System.Drawing.Size(125, 20)
        Me.txtNoBM.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "No BM : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNoLambung
        '
        Me.txtNoLambung.Location = New System.Drawing.Point(104, 50)
        Me.txtNoLambung.Name = "txtNoLambung"
        Me.txtNoLambung.Size = New System.Drawing.Size(82, 20)
        Me.txtNoLambung.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "No Lambung : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtKodeSopir
        '
        Me.txtKodeSopir.Location = New System.Drawing.Point(104, 76)
        Me.txtKodeSopir.Name = "txtKodeSopir"
        Me.txtKodeSopir.Size = New System.Drawing.Size(82, 20)
        Me.txtKodeSopir.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Kode Sopir : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(247, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Tanggal : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(104, 105)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(277, 82)
        Me.txtKeterangan.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Keterangan : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblNoPolisi
        '
        Me.lblNoPolisi.AutoSize = True
        Me.lblNoPolisi.Location = New System.Drawing.Point(238, 57)
        Me.lblNoPolisi.Name = "lblNoPolisi"
        Me.lblNoPolisi.Size = New System.Drawing.Size(40, 13)
        Me.lblNoPolisi.TabIndex = 25
        Me.lblNoPolisi.Text = "Total : "
        Me.lblNoPolisi.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblNamaSopir
        '
        Me.lblNamaSopir.AutoSize = True
        Me.lblNamaSopir.Location = New System.Drawing.Point(238, 81)
        Me.lblNamaSopir.Name = "lblNamaSopir"
        Me.lblNamaSopir.Size = New System.Drawing.Size(40, 13)
        Me.lblNamaSopir.TabIndex = 26
        Me.lblNamaSopir.Text = "Total : "
        Me.lblNamaSopir.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dtptanggal
        '
        Me.dtptanggal.CustomFormat = "dd-MM-yyyy"
        Me.dtptanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptanggal.Location = New System.Drawing.Point(306, 24)
        Me.dtptanggal.Name = "dtptanggal"
        Me.dtptanggal.Size = New System.Drawing.Size(102, 20)
        Me.dtptanggal.TabIndex = 2
        '
        'btnsearchlambung
        '
        Me.btnsearchlambung.Location = New System.Drawing.Point(192, 50)
        Me.btnsearchlambung.Name = "btnsearchlambung"
        Me.btnsearchlambung.Size = New System.Drawing.Size(37, 23)
        Me.btnsearchlambung.TabIndex = 4
        Me.btnsearchlambung.Text = "..."
        Me.btnsearchlambung.UseVisualStyleBackColor = True
        '
        'btnsearchsopir
        '
        Me.btnsearchsopir.Location = New System.Drawing.Point(192, 76)
        Me.btnsearchsopir.Name = "btnsearchsopir"
        Me.btnsearchsopir.Size = New System.Drawing.Size(37, 23)
        Me.btnsearchsopir.TabIndex = 6
        Me.btnsearchsopir.Text = "..."
        Me.btnsearchsopir.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Image = Global.RukunJaya.My.Resources.Resources.cancelbr
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(217, 193)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(80, 29)
        Me.btnBatal.TabIndex = 9
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(121, 193)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(80, 29)
        Me.btnSimpan.TabIndex = 8
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'frmbm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 237)
        Me.Controls.Add(Me.btnsearchsopir)
        Me.Controls.Add(Me.btnsearchlambung)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.dtptanggal)
        Me.Controls.Add(Me.lblNamaSopir)
        Me.Controls.Add(Me.lblNoPolisi)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtKodeSopir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNoLambung)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNoBM)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmbm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Bon Muat :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNoBM As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoLambung As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKodeSopir As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblNoPolisi As System.Windows.Forms.Label
    Friend WithEvents lblNamaSopir As System.Windows.Forms.Label
    Friend WithEvents dtptanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnsearchlambung As System.Windows.Forms.Button
    Friend WithEvents btnsearchsopir As System.Windows.Forms.Button
End Class
