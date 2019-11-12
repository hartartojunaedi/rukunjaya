<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetailUjiKir
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
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.dtpKir = New System.Windows.Forms.DateTimePicker()
        Me.cmbnolambung = New System.Windows.Forms.ComboBox()
        Me.lblTglKir = New System.Windows.Forms.Label()
        Me.lblNolambung = New System.Windows.Forms.Label()
        Me.txtNoKir = New System.Windows.Forms.TextBox()
        Me.lblNoKir = New System.Windows.Forms.Label()
        Me.dtpKirBerikutnya = New System.Windows.Forms.DateTimePicker()
        Me.lblTglKirBerikut = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.lblketerangan = New System.Windows.Forms.Label()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnbatal
        '
        Me.btnbatal.Image = Global.RukunJaya.My.Resources.Resources.cancelbr
        Me.btnbatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbatal.Location = New System.Drawing.Point(181, 256)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(75, 31)
        Me.btnbatal.TabIndex = 24
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(330, 23)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(32, 23)
        Me.btnUpdate.TabIndex = 25
        Me.btnUpdate.Text = "..."
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'dtpKir
        '
        Me.dtpKir.CustomFormat = "dd-MM-yyyy"
        Me.dtpKir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpKir.Location = New System.Drawing.Point(155, 109)
        Me.dtpKir.Name = "dtpKir"
        Me.dtpKir.Size = New System.Drawing.Size(101, 20)
        Me.dtpKir.TabIndex = 44
        '
        'cmbnolambung
        '
        Me.cmbnolambung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbnolambung.FormattingEnabled = True
        Me.cmbnolambung.Location = New System.Drawing.Point(155, 66)
        Me.cmbnolambung.Name = "cmbnolambung"
        Me.cmbnolambung.Size = New System.Drawing.Size(169, 21)
        Me.cmbnolambung.TabIndex = 43
        '
        'lblTglKir
        '
        Me.lblTglKir.AutoSize = True
        Me.lblTglKir.Location = New System.Drawing.Point(74, 115)
        Me.lblTglKir.Name = "lblTglKir"
        Me.lblTglKir.Size = New System.Drawing.Size(64, 13)
        Me.lblTglKir.TabIndex = 42
        Me.lblTglKir.Text = "Tanggal Kir "
        '
        'lblNolambung
        '
        Me.lblNolambung.AutoSize = True
        Me.lblNolambung.Location = New System.Drawing.Point(99, 69)
        Me.lblNolambung.Name = "lblNolambung"
        Me.lblNolambung.Size = New System.Drawing.Size(39, 13)
        Me.lblNolambung.TabIndex = 41
        Me.lblNolambung.Text = "No Pol"
        '
        'txtNoKir
        '
        Me.txtNoKir.Location = New System.Drawing.Point(155, 25)
        Me.txtNoKir.Name = "txtNoKir"
        Me.txtNoKir.Size = New System.Drawing.Size(169, 20)
        Me.txtNoKir.TabIndex = 34
        '
        'lblNoKir
        '
        Me.lblNoKir.AutoSize = True
        Me.lblNoKir.Location = New System.Drawing.Point(102, 28)
        Me.lblNoKir.Name = "lblNoKir"
        Me.lblNoKir.Size = New System.Drawing.Size(36, 13)
        Me.lblNoKir.TabIndex = 27
        Me.lblNoKir.Text = "No Kir"
        '
        'dtpKirBerikutnya
        '
        Me.dtpKirBerikutnya.CustomFormat = "dd-MM-yyyy"
        Me.dtpKirBerikutnya.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpKirBerikutnya.Location = New System.Drawing.Point(155, 150)
        Me.dtpKirBerikutnya.Name = "dtpKirBerikutnya"
        Me.dtpKirBerikutnya.Size = New System.Drawing.Size(101, 20)
        Me.dtpKirBerikutnya.TabIndex = 46
        '
        'lblTglKirBerikut
        '
        Me.lblTglKirBerikut.AutoSize = True
        Me.lblTglKirBerikut.Location = New System.Drawing.Point(24, 153)
        Me.lblTglKirBerikut.Name = "lblTglKirBerikut"
        Me.lblTglKirBerikut.Size = New System.Drawing.Size(114, 13)
        Me.lblTglKirBerikut.TabIndex = 45
        Me.lblTglKirBerikut.Text = "Tanggal Kir Berikutnya"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(155, 191)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtKeterangan.Size = New System.Drawing.Size(207, 58)
        Me.txtKeterangan.TabIndex = 48
        '
        'lblketerangan
        '
        Me.lblketerangan.AutoSize = True
        Me.lblketerangan.Location = New System.Drawing.Point(76, 194)
        Me.lblketerangan.Name = "lblketerangan"
        Me.lblketerangan.Size = New System.Drawing.Size(62, 13)
        Me.lblketerangan.TabIndex = 47
        Me.lblketerangan.Text = "Keterangan"
        '
        'btntambah
        '
        Me.btntambah.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btntambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntambah.Location = New System.Drawing.Point(100, 256)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 31)
        Me.btntambah.TabIndex = 49
        Me.btntambah.Text = "Simpan"
        Me.btntambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'frmDetailUjiKir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 299)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.lblketerangan)
        Me.Controls.Add(Me.dtpKirBerikutnya)
        Me.Controls.Add(Me.lblTglKirBerikut)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.dtpKir)
        Me.Controls.Add(Me.cmbnolambung)
        Me.Controls.Add(Me.lblTglKir)
        Me.Controls.Add(Me.lblNolambung)
        Me.Controls.Add(Me.txtNoKir)
        Me.Controls.Add(Me.lblNoKir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetailUjiKir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Detail Uji Kir :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents dtpKir As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbnolambung As System.Windows.Forms.ComboBox
    Friend WithEvents lblTglKir As System.Windows.Forms.Label
    Friend WithEvents lblNolambung As System.Windows.Forms.Label
    Friend WithEvents txtNoKir As System.Windows.Forms.TextBox
    Friend WithEvents lblNoKir As System.Windows.Forms.Label
    Friend WithEvents dtpKirBerikutnya As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTglKirBerikut As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents lblketerangan As System.Windows.Forms.Label
    Friend WithEvents btntambah As System.Windows.Forms.Button
End Class
