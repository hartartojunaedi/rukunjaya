<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaporanBukuMuatan
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpAKhirPeriode = New System.Windows.Forms.DateTimePicker()
        Me.dtpAwalPeriode = New System.Windows.Forms.DateTimePicker()
        Me.btnLihatLaporan = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNopol = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNamaSupir = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(178, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Periode "
        '
        'dtpAKhirPeriode
        '
        Me.dtpAKhirPeriode.CustomFormat = "dd-MM-yyyy"
        Me.dtpAKhirPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAKhirPeriode.Location = New System.Drawing.Point(194, 16)
        Me.dtpAKhirPeriode.Name = "dtpAKhirPeriode"
        Me.dtpAKhirPeriode.Size = New System.Drawing.Size(93, 20)
        Me.dtpAKhirPeriode.TabIndex = 13
        '
        'dtpAwalPeriode
        '
        Me.dtpAwalPeriode.CustomFormat = "dd-MM-yyyy"
        Me.dtpAwalPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAwalPeriode.Location = New System.Drawing.Point(80, 16)
        Me.dtpAwalPeriode.Name = "dtpAwalPeriode"
        Me.dtpAwalPeriode.Size = New System.Drawing.Size(92, 20)
        Me.dtpAwalPeriode.TabIndex = 12
        '
        'btnLihatLaporan
        '
        Me.btnLihatLaporan.Location = New System.Drawing.Point(80, 112)
        Me.btnLihatLaporan.Name = "btnLihatLaporan"
        Me.btnLihatLaporan.Size = New System.Drawing.Size(176, 44)
        Me.btnLihatLaporan.TabIndex = 11
        Me.btnLihatLaporan.Text = "Lihat Laporan"
        Me.btnLihatLaporan.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "No. Pol"
        '
        'txtNopol
        '
        Me.txtNopol.Location = New System.Drawing.Point(80, 45)
        Me.txtNopol.Name = "txtNopol"
        Me.txtNopol.Size = New System.Drawing.Size(108, 20)
        Me.txtNopol.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Nama Supir"
        '
        'txtNamaSupir
        '
        Me.txtNamaSupir.Location = New System.Drawing.Point(81, 76)
        Me.txtNamaSupir.Name = "txtNamaSupir"
        Me.txtNamaSupir.Size = New System.Drawing.Size(127, 20)
        Me.txtNamaSupir.TabIndex = 19
        '
        'frmLaporanBukuMuatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 174)
        Me.Controls.Add(Me.txtNamaSupir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNopol)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpAKhirPeriode)
        Me.Controls.Add(Me.dtpAwalPeriode)
        Me.Controls.Add(Me.btnLihatLaporan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLaporanBukuMuatan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Laporan Buku Muatan :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpAKhirPeriode As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpAwalPeriode As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnLihatLaporan As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNopol As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNamaSupir As System.Windows.Forms.TextBox
End Class
