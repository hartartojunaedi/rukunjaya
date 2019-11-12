<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterLaporanKendaraan
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
        Me.btnLihatLaporan = New System.Windows.Forms.Button()
        Me.cmbPer = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLihatLaporan
        '
        Me.btnLihatLaporan.Location = New System.Drawing.Point(12, 40)
        Me.btnLihatLaporan.Name = "btnLihatLaporan"
        Me.btnLihatLaporan.Size = New System.Drawing.Size(271, 43)
        Me.btnLihatLaporan.TabIndex = 43
        Me.btnLihatLaporan.Text = "&Lihat Laporan"
        Me.btnLihatLaporan.UseVisualStyleBackColor = True
        '
        'cmbPer
        '
        Me.cmbPer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPer.FormattingEnabled = True
        Me.cmbPer.Location = New System.Drawing.Point(91, 12)
        Me.cmbPer.Name = "cmbPer"
        Me.cmbPer.Size = New System.Drawing.Size(192, 21)
        Me.cmbPer.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Perusahaan"
        '
        'frmMasterLaporanKendaraan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 95)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLihatLaporan)
        Me.Controls.Add(Me.cmbPer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMasterLaporanKendaraan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Master Laporan Kendaraan :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLihatLaporan As System.Windows.Forms.Button
    Friend WithEvents cmbPer As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
