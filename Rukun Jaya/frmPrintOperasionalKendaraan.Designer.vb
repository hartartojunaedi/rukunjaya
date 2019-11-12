<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintOperasionalKendaraan
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
        Me.dtpTanggalAwal = New System.Windows.Forms.DateTimePicker()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanggal : "
        '
        'dtpTanggalAwal
        '
        Me.dtpTanggalAwal.CustomFormat = "dd-MM-yyyy"
        Me.dtpTanggalAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTanggalAwal.Location = New System.Drawing.Point(74, 12)
        Me.dtpTanggalAwal.Name = "dtpTanggalAwal"
        Me.dtpTanggalAwal.Size = New System.Drawing.Size(96, 20)
        Me.dtpTanggalAwal.TabIndex = 25
        '
        'btnLaporan
        '
        Me.btnLaporan.Location = New System.Drawing.Point(12, 47)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(212, 49)
        Me.btnLaporan.TabIndex = 31
        Me.btnLaporan.Text = "Print"
        Me.btnLaporan.UseVisualStyleBackColor = True
        '
        'frmPrintOperasionalKendaraan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 108)
        Me.Controls.Add(Me.btnLaporan)
        Me.Controls.Add(Me.dtpTanggalAwal)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrintOperasionalKendaraan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Cetak Operasional Kendaraan :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpTanggalAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnLaporan As System.Windows.Forms.Button
End Class
