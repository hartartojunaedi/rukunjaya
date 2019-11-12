<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaporanMaintanceKendaraan
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
        Me.cbkNopol = New System.Windows.Forms.CheckBox()
        Me.cbkTanggal = New System.Windows.Forms.CheckBox()
        Me.cmbnolambung = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpTanggalAkhir = New System.Windows.Forms.DateTimePicker()
        Me.dtpTanggalAwal = New System.Windows.Forms.DateTimePicker()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbkNopol
        '
        Me.cbkNopol.AutoSize = True
        Me.cbkNopol.Location = New System.Drawing.Point(21, 36)
        Me.cbkNopol.Name = "cbkNopol"
        Me.cbkNopol.Size = New System.Drawing.Size(61, 17)
        Me.cbkNopol.TabIndex = 22
        Me.cbkNopol.Text = "No Pol "
        Me.cbkNopol.UseVisualStyleBackColor = True
        Me.cbkNopol.Visible = False
        '
        'cbkTanggal
        '
        Me.cbkTanggal.AutoSize = True
        Me.cbkTanggal.Location = New System.Drawing.Point(21, 73)
        Me.cbkTanggal.Name = "cbkTanggal"
        Me.cbkTanggal.Size = New System.Drawing.Size(65, 17)
        Me.cbkTanggal.TabIndex = 21
        Me.cbkTanggal.Text = "Tanggal"
        Me.cbkTanggal.UseVisualStyleBackColor = True
        '
        'cmbnolambung
        '
        Me.cmbnolambung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbnolambung.FormattingEnabled = True
        Me.cmbnolambung.Items.AddRange(New Object() {"Rutin", "Tidak Rutin"})
        Me.cmbnolambung.Location = New System.Drawing.Point(101, 34)
        Me.cmbnolambung.Name = "cmbnolambung"
        Me.cmbnolambung.Size = New System.Drawing.Size(226, 21)
        Me.cmbnolambung.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(203, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "s/d"
        '
        'dtpTanggalAkhir
        '
        Me.dtpTanggalAkhir.CustomFormat = "dd-MM-yyyy"
        Me.dtpTanggalAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTanggalAkhir.Location = New System.Drawing.Point(232, 73)
        Me.dtpTanggalAkhir.Name = "dtpTanggalAkhir"
        Me.dtpTanggalAkhir.Size = New System.Drawing.Size(95, 20)
        Me.dtpTanggalAkhir.TabIndex = 18
        '
        'dtpTanggalAwal
        '
        Me.dtpTanggalAwal.CustomFormat = "dd-MM-yyyy"
        Me.dtpTanggalAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTanggalAwal.Location = New System.Drawing.Point(101, 73)
        Me.dtpTanggalAwal.Name = "dtpTanggalAwal"
        Me.dtpTanggalAwal.Size = New System.Drawing.Size(96, 20)
        Me.dtpTanggalAwal.TabIndex = 17
        '
        'btnLaporan
        '
        Me.btnLaporan.Location = New System.Drawing.Point(12, 99)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(315, 49)
        Me.btnLaporan.TabIndex = 23
        Me.btnLaporan.Text = "Lihat Laporan"
        Me.btnLaporan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "No Pol"
        '
        'frmLaporanMaintanceKendaraan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 171)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLaporan)
        Me.Controls.Add(Me.cbkNopol)
        Me.Controls.Add(Me.cbkTanggal)
        Me.Controls.Add(Me.cmbnolambung)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpTanggalAkhir)
        Me.Controls.Add(Me.dtpTanggalAwal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLaporanMaintanceKendaraan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Laporan Maintance Kendaraan :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbkNopol As System.Windows.Forms.CheckBox
    Friend WithEvents cbkTanggal As System.Windows.Forms.CheckBox
    Friend WithEvents cmbnolambung As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpTanggalAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTanggalAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnLaporan As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
