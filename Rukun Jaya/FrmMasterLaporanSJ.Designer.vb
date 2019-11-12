<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMasterLaporanSJ
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
        Me.cmbSupp = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpToPeriode = New System.Windows.Forms.DateTimePicker()
        Me.dtpFromPeriode = New System.Windows.Forms.DateTimePicker()
        Me.txtNopol = New System.Windows.Forms.TextBox()
        Me.cbkPeriode = New System.Windows.Forms.CheckBox()
        Me.cbkSupp = New System.Windows.Forms.CheckBox()
        Me.cbkNopol = New System.Windows.Forms.CheckBox()
        Me.cbkStatus = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnLihatLaporan
        '
        Me.btnLihatLaporan.Location = New System.Drawing.Point(12, 120)
        Me.btnLihatLaporan.Name = "btnLihatLaporan"
        Me.btnLihatLaporan.Size = New System.Drawing.Size(271, 43)
        Me.btnLihatLaporan.TabIndex = 28
        Me.btnLihatLaporan.Text = "&Lihat Laporan"
        Me.btnLihatLaporan.UseVisualStyleBackColor = True
        '
        'cmbSupp
        '
        Me.cmbSupp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSupp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSupp.FormattingEnabled = True
        Me.cmbSupp.Location = New System.Drawing.Point(91, 36)
        Me.cmbSupp.Name = "cmbSupp"
        Me.cmbSupp.Size = New System.Drawing.Size(192, 21)
        Me.cmbSupp.TabIndex = 26
        '
        'cmbStatus
        '
        Me.cmbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(91, 93)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(192, 21)
        Me.cmbStatus.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "-"
        '
        'dtpToPeriode
        '
        Me.dtpToPeriode.CustomFormat = "dd-MM-yyyy"
        Me.dtpToPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpToPeriode.Location = New System.Drawing.Point(198, 10)
        Me.dtpToPeriode.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtpToPeriode.Name = "dtpToPeriode"
        Me.dtpToPeriode.Size = New System.Drawing.Size(85, 20)
        Me.dtpToPeriode.TabIndex = 25
        '
        'dtpFromPeriode
        '
        Me.dtpFromPeriode.CustomFormat = "dd-MM-yyyy"
        Me.dtpFromPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFromPeriode.Location = New System.Drawing.Point(91, 10)
        Me.dtpFromPeriode.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtpFromPeriode.Name = "dtpFromPeriode"
        Me.dtpFromPeriode.Size = New System.Drawing.Size(85, 20)
        Me.dtpFromPeriode.TabIndex = 24
        '
        'txtNopol
        '
        Me.txtNopol.Location = New System.Drawing.Point(91, 64)
        Me.txtNopol.Name = "txtNopol"
        Me.txtNopol.Size = New System.Drawing.Size(192, 20)
        Me.txtNopol.TabIndex = 34
        '
        'cbkPeriode
        '
        Me.cbkPeriode.AutoSize = True
        Me.cbkPeriode.Location = New System.Drawing.Point(12, 12)
        Me.cbkPeriode.Name = "cbkPeriode"
        Me.cbkPeriode.Size = New System.Drawing.Size(62, 17)
        Me.cbkPeriode.TabIndex = 35
        Me.cbkPeriode.Text = "Periode"
        Me.cbkPeriode.UseVisualStyleBackColor = True
        '
        'cbkSupp
        '
        Me.cbkSupp.AutoSize = True
        Me.cbkSupp.Location = New System.Drawing.Point(12, 40)
        Me.cbkSupp.Name = "cbkSupp"
        Me.cbkSupp.Size = New System.Drawing.Size(64, 17)
        Me.cbkSupp.TabIndex = 36
        Me.cbkSupp.Text = "Supplier"
        Me.cbkSupp.UseVisualStyleBackColor = True
        '
        'cbkNopol
        '
        Me.cbkNopol.AutoSize = True
        Me.cbkNopol.Location = New System.Drawing.Point(12, 67)
        Me.cbkNopol.Name = "cbkNopol"
        Me.cbkNopol.Size = New System.Drawing.Size(70, 17)
        Me.cbkNopol.TabIndex = 37
        Me.cbkNopol.Text = "No. Polisi"
        Me.cbkNopol.UseVisualStyleBackColor = True
        '
        'cbkStatus
        '
        Me.cbkStatus.AutoSize = True
        Me.cbkStatus.Location = New System.Drawing.Point(12, 95)
        Me.cbkStatus.Name = "cbkStatus"
        Me.cbkStatus.Size = New System.Drawing.Size(56, 17)
        Me.cbkStatus.TabIndex = 38
        Me.cbkStatus.Text = "Status"
        Me.cbkStatus.UseVisualStyleBackColor = True
        '
        'FrmMasterLaporanSJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 175)
        Me.Controls.Add(Me.cbkStatus)
        Me.Controls.Add(Me.cbkNopol)
        Me.Controls.Add(Me.cbkSupp)
        Me.Controls.Add(Me.cbkPeriode)
        Me.Controls.Add(Me.txtNopol)
        Me.Controls.Add(Me.btnLihatLaporan)
        Me.Controls.Add(Me.cmbSupp)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpToPeriode)
        Me.Controls.Add(Me.dtpFromPeriode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMasterLaporanSJ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Master Laporan Surat Jalan :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLihatLaporan As System.Windows.Forms.Button
    Friend WithEvents cmbSupp As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpToPeriode As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFromPeriode As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNopol As System.Windows.Forms.TextBox
    Friend WithEvents cbkPeriode As System.Windows.Forms.CheckBox
    Friend WithEvents cbkSupp As System.Windows.Forms.CheckBox
    Friend WithEvents cbkNopol As System.Windows.Forms.CheckBox
    Friend WithEvents cbkStatus As System.Windows.Forms.CheckBox
End Class
