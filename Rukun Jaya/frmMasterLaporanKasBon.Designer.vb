<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterLaporanKasBon
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
        Me.cmbJenis = New System.Windows.Forms.ComboBox()
        Me.cmbSopir = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpToPeriode = New System.Windows.Forms.DateTimePicker()
        Me.dtpFromPeriode = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLihatLaporan
        '
        Me.btnLihatLaporan.Location = New System.Drawing.Point(10, 89)
        Me.btnLihatLaporan.Name = "btnLihatLaporan"
        Me.btnLihatLaporan.Size = New System.Drawing.Size(247, 43)
        Me.btnLihatLaporan.TabIndex = 5
        Me.btnLihatLaporan.Text = "&Lihat Laporan"
        Me.btnLihatLaporan.UseVisualStyleBackColor = True
        '
        'cmbJenis
        '
        Me.cmbJenis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbJenis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbJenis.FormattingEnabled = True
        Me.cmbJenis.Location = New System.Drawing.Point(65, 35)
        Me.cmbJenis.Name = "cmbJenis"
        Me.cmbJenis.Size = New System.Drawing.Size(192, 21)
        Me.cmbJenis.TabIndex = 3
        '
        'cmbSopir
        '
        Me.cmbSopir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSopir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSopir.FormattingEnabled = True
        Me.cmbSopir.Location = New System.Drawing.Point(65, 62)
        Me.cmbSopir.Name = "cmbSopir"
        Me.cmbSopir.Size = New System.Drawing.Size(192, 21)
        Me.cmbSopir.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Jenis :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Sopir :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "-"
        '
        'dtpToPeriode
        '
        Me.dtpToPeriode.CustomFormat = "dd-MM-yyyy"
        Me.dtpToPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpToPeriode.Location = New System.Drawing.Point(172, 9)
        Me.dtpToPeriode.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtpToPeriode.Name = "dtpToPeriode"
        Me.dtpToPeriode.Size = New System.Drawing.Size(85, 20)
        Me.dtpToPeriode.TabIndex = 2
        '
        'dtpFromPeriode
        '
        Me.dtpFromPeriode.CustomFormat = "dd-MM-yyyy"
        Me.dtpFromPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFromPeriode.Location = New System.Drawing.Point(65, 9)
        Me.dtpFromPeriode.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtpFromPeriode.Name = "dtpFromPeriode"
        Me.dtpFromPeriode.Size = New System.Drawing.Size(85, 20)
        Me.dtpFromPeriode.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Periode :"
        '
        'frmMasterLaporanKasBon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 139)
        Me.Controls.Add(Me.btnLihatLaporan)
        Me.Controls.Add(Me.cmbJenis)
        Me.Controls.Add(Me.cmbSopir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpToPeriode)
        Me.Controls.Add(Me.dtpFromPeriode)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMasterLaporanKasBon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Laporan Kas Bon :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLihatLaporan As System.Windows.Forms.Button
    Friend WithEvents cmbJenis As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSopir As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpToPeriode As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFromPeriode As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
