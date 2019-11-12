<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUjiKir
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
        Me.dgvujikir = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpKirBerikutnya2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpkir2 = New System.Windows.Forms.DateTimePicker()
        Me.cbktglkirberikutnya = New System.Windows.Forms.CheckBox()
        Me.cbktglkir = New System.Windows.Forms.CheckBox()
        Me.btncari = New System.Windows.Forms.Button()
        Me.dtpKirBerikutnya = New System.Windows.Forms.DateTimePicker()
        Me.dtpKir = New System.Windows.Forms.DateTimePicker()
        Me.txtcarinokir = New System.Windows.Forms.TextBox()
        Me.lblcaritglkirberikut = New System.Windows.Forms.Label()
        Me.lblcarinokir = New System.Windows.Forms.Label()
        Me.txtcarinolambung = New System.Windows.Forms.TextBox()
        Me.lblcaritglkir = New System.Windows.Forms.Label()
        Me.lblnolambung = New System.Windows.Forms.Label()
        Me.nokir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nopol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tglmasuk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvujikir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvujikir
        '
        Me.dgvujikir.AllowUserToAddRows = False
        Me.dgvujikir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvujikir.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nokir, Me.nopol, Me.tglmasuk, Me.status, Me.keterangan})
        Me.dgvujikir.Location = New System.Drawing.Point(12, 156)
        Me.dgvujikir.Name = "dgvujikir"
        Me.dgvujikir.ReadOnly = True
        Me.dgvujikir.Size = New System.Drawing.Size(773, 274)
        Me.dgvujikir.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpKirBerikutnya2)
        Me.GroupBox1.Controls.Add(Me.dtpkir2)
        Me.GroupBox1.Controls.Add(Me.cbktglkirberikutnya)
        Me.GroupBox1.Controls.Add(Me.cbktglkir)
        Me.GroupBox1.Controls.Add(Me.btncari)
        Me.GroupBox1.Controls.Add(Me.dtpKirBerikutnya)
        Me.GroupBox1.Controls.Add(Me.dtpKir)
        Me.GroupBox1.Controls.Add(Me.txtcarinokir)
        Me.GroupBox1.Controls.Add(Me.lblcaritglkirberikut)
        Me.GroupBox1.Controls.Add(Me.lblcarinokir)
        Me.GroupBox1.Controls.Add(Me.txtcarinolambung)
        Me.GroupBox1.Controls.Add(Me.lblcaritglkir)
        Me.GroupBox1.Controls.Add(Me.lblnolambung)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(773, 126)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(531, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "s/d"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(531, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "s/d"
        '
        'dtpKirBerikutnya2
        '
        Me.dtpKirBerikutnya2.Location = New System.Drawing.Point(555, 60)
        Me.dtpKirBerikutnya2.Name = "dtpKirBerikutnya2"
        Me.dtpKirBerikutnya2.Size = New System.Drawing.Size(182, 20)
        Me.dtpKirBerikutnya2.TabIndex = 52
        '
        'dtpkir2
        '
        Me.dtpkir2.Location = New System.Drawing.Point(555, 28)
        Me.dtpkir2.Name = "dtpkir2"
        Me.dtpkir2.Size = New System.Drawing.Size(182, 20)
        Me.dtpkir2.TabIndex = 51
        '
        'cbktglkirberikutnya
        '
        Me.cbktglkirberikutnya.AutoSize = True
        Me.cbktglkirberikutnya.Location = New System.Drawing.Point(743, 63)
        Me.cbktglkirberikutnya.Name = "cbktglkirberikutnya"
        Me.cbktglkirberikutnya.Size = New System.Drawing.Size(15, 14)
        Me.cbktglkirberikutnya.TabIndex = 50
        Me.cbktglkirberikutnya.UseVisualStyleBackColor = True
        '
        'cbktglkir
        '
        Me.cbktglkir.AutoSize = True
        Me.cbktglkir.Location = New System.Drawing.Point(743, 31)
        Me.cbktglkir.Name = "cbktglkir"
        Me.cbktglkir.Size = New System.Drawing.Size(15, 14)
        Me.cbktglkir.TabIndex = 49
        Me.cbktglkir.UseVisualStyleBackColor = True
        '
        'btncari
        '
        Me.btncari.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btncari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncari.Location = New System.Drawing.Point(692, 93)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(75, 31)
        Me.btncari.TabIndex = 14
        Me.btncari.Text = "&Filter"
        Me.btncari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncari.UseVisualStyleBackColor = True
        '
        'dtpKirBerikutnya
        '
        Me.dtpKirBerikutnya.Location = New System.Drawing.Point(349, 60)
        Me.dtpKirBerikutnya.Name = "dtpKirBerikutnya"
        Me.dtpKirBerikutnya.Size = New System.Drawing.Size(182, 20)
        Me.dtpKirBerikutnya.TabIndex = 48
        '
        'dtpKir
        '
        Me.dtpKir.Location = New System.Drawing.Point(349, 28)
        Me.dtpKir.Name = "dtpKir"
        Me.dtpKir.Size = New System.Drawing.Size(182, 20)
        Me.dtpKir.TabIndex = 47
        '
        'txtcarinokir
        '
        Me.txtcarinokir.Location = New System.Drawing.Point(68, 28)
        Me.txtcarinokir.Name = "txtcarinokir"
        Me.txtcarinokir.Size = New System.Drawing.Size(146, 20)
        Me.txtcarinokir.TabIndex = 3
        '
        'lblcaritglkirberikut
        '
        Me.lblcaritglkirberikut.AutoSize = True
        Me.lblcaritglkirberikut.Location = New System.Drawing.Point(236, 63)
        Me.lblcaritglkirberikut.Name = "lblcaritglkirberikut"
        Me.lblcaritglkirberikut.Size = New System.Drawing.Size(113, 13)
        Me.lblcaritglkirberikut.TabIndex = 11
        Me.lblcaritglkirberikut.Text = "Tanggal Kir berikutnya"
        '
        'lblcarinokir
        '
        Me.lblcarinokir.AutoSize = True
        Me.lblcarinokir.Location = New System.Drawing.Point(26, 31)
        Me.lblcarinokir.Name = "lblcarinokir"
        Me.lblcarinokir.Size = New System.Drawing.Size(36, 13)
        Me.lblcarinokir.TabIndex = 5
        Me.lblcarinokir.Text = "No Kir"
        '
        'txtcarinolambung
        '
        Me.txtcarinolambung.Location = New System.Drawing.Point(68, 60)
        Me.txtcarinolambung.Name = "txtcarinolambung"
        Me.txtcarinolambung.Size = New System.Drawing.Size(146, 20)
        Me.txtcarinolambung.TabIndex = 6
        '
        'lblcaritglkir
        '
        Me.lblcaritglkir.AutoSize = True
        Me.lblcaritglkir.Location = New System.Drawing.Point(284, 31)
        Me.lblcaritglkir.Name = "lblcaritglkir"
        Me.lblcaritglkir.Size = New System.Drawing.Size(61, 13)
        Me.lblcaritglkir.TabIndex = 9
        Me.lblcaritglkir.Text = "Tanggal Kir"
        '
        'lblnolambung
        '
        Me.lblnolambung.AutoSize = True
        Me.lblnolambung.Location = New System.Drawing.Point(14, 63)
        Me.lblnolambung.Name = "lblnolambung"
        Me.lblnolambung.Size = New System.Drawing.Size(48, 13)
        Me.lblnolambung.TabIndex = 7
        Me.lblnolambung.Text = "No Polisi"
        '
        'nokir
        '
        Me.nokir.DataPropertyName = "nokir"
        Me.nokir.HeaderText = "No Kir"
        Me.nokir.Name = "nokir"
        Me.nokir.ReadOnly = True
        '
        'nopol
        '
        Me.nopol.DataPropertyName = "nopol"
        Me.nopol.HeaderText = "No Pol"
        Me.nopol.Name = "nopol"
        Me.nopol.ReadOnly = True
        '
        'tglmasuk
        '
        Me.tglmasuk.DataPropertyName = "tglkir"
        Me.tglmasuk.HeaderText = "Tanggal Kir"
        Me.tglmasuk.Name = "tglmasuk"
        Me.tglmasuk.ReadOnly = True
        '
        'status
        '
        Me.status.DataPropertyName = "tglkirberikutnya"
        Me.status.HeaderText = "Tanggal Kir Berikutnya "
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'keterangan
        '
        Me.keterangan.DataPropertyName = "keterangan"
        Me.keterangan.HeaderText = "Keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.ReadOnly = True
        '
        'frmUjiKir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 442)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvujikir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUjiKir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Uji Kir :."
        CType(Me.dgvujikir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvujikir As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcarinokir As System.Windows.Forms.TextBox
    Friend WithEvents lblcaritglkirberikut As System.Windows.Forms.Label
    Friend WithEvents lblcarinokir As System.Windows.Forms.Label
    Friend WithEvents txtcarinolambung As System.Windows.Forms.TextBox
    Friend WithEvents lblcaritglkir As System.Windows.Forms.Label
    Friend WithEvents lblnolambung As System.Windows.Forms.Label
    Friend WithEvents dtpKirBerikutnya As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpKir As System.Windows.Forms.DateTimePicker
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents cbktglkirberikutnya As System.Windows.Forms.CheckBox
    Friend WithEvents cbktglkir As System.Windows.Forms.CheckBox
    Friend WithEvents dtpKirBerikutnya2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpkir2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nokir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nopol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tglmasuk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
