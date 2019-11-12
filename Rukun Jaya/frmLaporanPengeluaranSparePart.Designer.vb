<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaporanPengeluaranSparePart
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
        Me.dtpAwalPeriode = New System.Windows.Forms.DateTimePicker()
        Me.btnLihatLaporan = New System.Windows.Forms.Button()
        Me.dtpAKhirPeriode = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Periode "
        '
        'dtpAwalPeriode
        '
        Me.dtpAwalPeriode.CustomFormat = "dd-MM-yyyy"
        Me.dtpAwalPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAwalPeriode.Location = New System.Drawing.Point(91, 11)
        Me.dtpAwalPeriode.Name = "dtpAwalPeriode"
        Me.dtpAwalPeriode.Size = New System.Drawing.Size(125, 20)
        Me.dtpAwalPeriode.TabIndex = 7
        '
        'btnLihatLaporan
        '
        Me.btnLihatLaporan.Location = New System.Drawing.Point(91, 38)
        Me.btnLihatLaporan.Name = "btnLihatLaporan"
        Me.btnLihatLaporan.Size = New System.Drawing.Size(217, 44)
        Me.btnLihatLaporan.TabIndex = 6
        Me.btnLihatLaporan.Text = "Lihat Laporan"
        Me.btnLihatLaporan.UseVisualStyleBackColor = True
        '
        'dtpAKhirPeriode
        '
        Me.dtpAKhirPeriode.CustomFormat = "dd-MM-yyyy"
        Me.dtpAKhirPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAKhirPeriode.Location = New System.Drawing.Point(238, 12)
        Me.dtpAKhirPeriode.Name = "dtpAKhirPeriode"
        Me.dtpAKhirPeriode.Size = New System.Drawing.Size(125, 20)
        Me.dtpAKhirPeriode.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(222, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "-"
        '
        'frmLaporanPengeluaranSparePart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 94)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpAKhirPeriode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpAwalPeriode)
        Me.Controls.Add(Me.btnLihatLaporan)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLaporanPengeluaranSparePart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLaporanPengeluaranSparePart"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpAwalPeriode As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnLihatLaporan As System.Windows.Forms.Button
    Friend WithEvents dtpAKhirPeriode As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
