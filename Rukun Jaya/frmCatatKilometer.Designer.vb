<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatatKilometer
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.nolambung = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nopol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Merek = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namajenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KmLast = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.km = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kodejenismaintance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNopol = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbMerek = New System.Windows.Forms.ComboBox()
        Me.cbJenis = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nolambung, Me.nopol, Me.Merek, Me.namajenis, Me.KmLast, Me.km, Me.kodejenismaintance})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 56)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(795, 239)
        Me.DataGridView1.TabIndex = 1
        '
        'nolambung
        '
        Me.nolambung.DataPropertyName = "nolambung"
        Me.nolambung.Frozen = True
        Me.nolambung.HeaderText = "No Lambung"
        Me.nolambung.Name = "nolambung"
        Me.nolambung.ReadOnly = True
        Me.nolambung.Width = 60
        '
        'nopol
        '
        Me.nopol.DataPropertyName = "nopol"
        Me.nopol.HeaderText = "Nopol"
        Me.nopol.Name = "nopol"
        Me.nopol.ReadOnly = True
        '
        'Merek
        '
        Me.Merek.DataPropertyName = "Merek"
        Me.Merek.HeaderText = "Merek"
        Me.Merek.Name = "Merek"
        Me.Merek.ReadOnly = True
        '
        'namajenis
        '
        Me.namajenis.DataPropertyName = "namajenis"
        Me.namajenis.HeaderText = "Nama Jenis"
        Me.namajenis.Name = "namajenis"
        Me.namajenis.ReadOnly = True
        '
        'KmLast
        '
        Me.KmLast.DataPropertyName = "kmlast"
        Me.KmLast.HeaderText = "Km Last"
        Me.KmLast.Name = "KmLast"
        Me.KmLast.ReadOnly = True
        '
        'km
        '
        Me.km.DataPropertyName = "kmlastforkm"
        Me.km.HeaderText = "Km"
        Me.km.Name = "km"
        '
        'kodejenismaintance
        '
        Me.kodejenismaintance.DataPropertyName = "kodejenismaintance"
        Me.kodejenismaintance.HeaderText = "kjm"
        Me.kodejenismaintance.Name = "kodejenismaintance"
        Me.kodejenismaintance.Visible = False
        '
        'txtNopol
        '
        Me.txtNopol.Location = New System.Drawing.Point(606, 22)
        Me.txtNopol.Name = "txtNopol"
        Me.txtNopol.Size = New System.Drawing.Size(121, 20)
        Me.txtNopol.TabIndex = 6
        '
        'btnCari
        '
        Me.btnCari.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCari.Location = New System.Drawing.Point(741, 10)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(66, 40)
        Me.btnCari.TabIndex = 12
        Me.btnCari.Text = "Cari"
        Me.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Image = Global.RukunJaya.My.Resources.Resources.cancelbr
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnBatal.Location = New System.Drawing.Point(98, 310)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(80, 29)
        Me.btnBatal.TabIndex = 4
        Me.btnBatal.Text = "&Batal"
        Me.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBatal.UseVisualStyleBackColor = True
        Me.btnBatal.Visible = False
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = Global.RukunJaya.My.Resources.Resources.savebr
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnSimpan.Location = New System.Drawing.Point(12, 310)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(80, 29)
        Me.btnSimpan.TabIndex = 3
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(564, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nopol"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(388, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Merek"
        '
        'cbMerek
        '
        Me.cbMerek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMerek.FormattingEnabled = True
        Me.cbMerek.Location = New System.Drawing.Point(431, 21)
        Me.cbMerek.Name = "cbMerek"
        Me.cbMerek.Size = New System.Drawing.Size(121, 21)
        Me.cbMerek.TabIndex = 15
        '
        'cbJenis
        '
        Me.cbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbJenis.FormattingEnabled = True
        Me.cbJenis.Location = New System.Drawing.Point(253, 21)
        Me.cbJenis.Name = "cbJenis"
        Me.cbJenis.Size = New System.Drawing.Size(121, 21)
        Me.cbJenis.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(161, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Jenis Kendaraan"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 40)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "cari jenis kendaraan"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(93, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 40)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "cari merek"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'frmCatatKilometer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 349)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbJenis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbMerek)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtNopol)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCatatKilometer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Catat Kilometer :."
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents nolambung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nopol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Merek As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namajenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KmLast As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents km As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kodejenismaintance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtNopol As System.Windows.Forms.TextBox
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbMerek As System.Windows.Forms.ComboBox
    Friend WithEvents cbJenis As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
