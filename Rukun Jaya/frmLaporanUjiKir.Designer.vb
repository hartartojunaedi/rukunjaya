<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaporanUjiKir
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
        Me.dtpTglAwal = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpTglAkhir = New System.Windows.Forms.DateTimePicker()
        Me.btnLihatLaporan = New System.Windows.Forms.Button()
        Me.rdbKir = New System.Windows.Forms.RadioButton()
        Me.rdbKirBerikut = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Periode :"
        '
        'dtpTglAwal
        '
        Me.dtpTglAwal.Location = New System.Drawing.Point(66, 47)
        Me.dtpTglAwal.Name = "dtpTglAwal"
        Me.dtpTglAwal.Size = New System.Drawing.Size(119, 20)
        Me.dtpTglAwal.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(193, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "-"
        '
        'dtpTglAkhir
        '
        Me.dtpTglAkhir.Location = New System.Drawing.Point(211, 47)
        Me.dtpTglAkhir.Name = "dtpTglAkhir"
        Me.dtpTglAkhir.Size = New System.Drawing.Size(126, 20)
        Me.dtpTglAkhir.TabIndex = 3
        '
        'btnLihatLaporan
        '
        Me.btnLihatLaporan.Location = New System.Drawing.Point(12, 76)
        Me.btnLihatLaporan.Name = "btnLihatLaporan"
        Me.btnLihatLaporan.Size = New System.Drawing.Size(327, 47)
        Me.btnLihatLaporan.TabIndex = 4
        Me.btnLihatLaporan.Text = "Lihat Laporan"
        Me.btnLihatLaporan.UseVisualStyleBackColor = True
        '
        'rdbKir
        '
        Me.rdbKir.AutoSize = True
        Me.rdbKir.Checked = True
        Me.rdbKir.Location = New System.Drawing.Point(6, 11)
        Me.rdbKir.Name = "rdbKir"
        Me.rdbKir.Size = New System.Drawing.Size(79, 17)
        Me.rdbKir.TabIndex = 5
        Me.rdbKir.TabStop = True
        Me.rdbKir.Text = "Tanggal Kir"
        Me.rdbKir.UseVisualStyleBackColor = True
        '
        'rdbKirBerikut
        '
        Me.rdbKirBerikut.AutoSize = True
        Me.rdbKirBerikut.Location = New System.Drawing.Point(106, 11)
        Me.rdbKirBerikut.Name = "rdbKirBerikut"
        Me.rdbKirBerikut.Size = New System.Drawing.Size(132, 17)
        Me.rdbKirBerikut.TabIndex = 6
        Me.rdbKirBerikut.Text = "Tanggal Kir Berikutnya"
        Me.rdbKirBerikut.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbKirBerikut)
        Me.GroupBox1.Controls.Add(Me.rdbKir)
        Me.GroupBox1.Location = New System.Drawing.Point(67, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(245, 34)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'frmLaporanUjiKir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 134)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLihatLaporan)
        Me.Controls.Add(Me.dtpTglAkhir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpTglAwal)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLaporanUjiKir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Laporan Uji Kir :."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpTglAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpTglAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnLihatLaporan As System.Windows.Forms.Button
    Friend WithEvents rdbKir As System.Windows.Forms.RadioButton
    Friend WithEvents rdbKirBerikut As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
