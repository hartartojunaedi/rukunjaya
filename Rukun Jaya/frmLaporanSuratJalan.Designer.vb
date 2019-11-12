<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaporanSuratJalan
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(202, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Periode "
        '
        'dtpAKhirPeriode
        '
        Me.dtpAKhirPeriode.CustomFormat = "dd-MM-yyyy"
        Me.dtpAKhirPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAKhirPeriode.Location = New System.Drawing.Point(218, 16)
        Me.dtpAKhirPeriode.Name = "dtpAKhirPeriode"
        Me.dtpAKhirPeriode.Size = New System.Drawing.Size(93, 20)
        Me.dtpAKhirPeriode.TabIndex = 8
        '
        'dtpAwalPeriode
        '
        Me.dtpAwalPeriode.CustomFormat = "dd-MM-yyyy"
        Me.dtpAwalPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAwalPeriode.Location = New System.Drawing.Point(104, 16)
        Me.dtpAwalPeriode.Name = "dtpAwalPeriode"
        Me.dtpAwalPeriode.Size = New System.Drawing.Size(92, 20)
        Me.dtpAwalPeriode.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 77)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(299, 44)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Lihat Laporan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbStatus
        '
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Sudah Setor", "Belum Setor"})
        Me.cbStatus.Location = New System.Drawing.Point(104, 44)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(207, 21)
        Me.cbStatus.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Status Surat Jalan"
        '
        'frmLaporanSuratJalan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 133)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpAKhirPeriode)
        Me.Controls.Add(Me.dtpAwalPeriode)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLaporanSuratJalan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Laporan Surat Jalan :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpAKhirPeriode As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpAwalPeriode As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
