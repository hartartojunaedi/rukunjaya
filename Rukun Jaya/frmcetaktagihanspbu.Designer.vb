<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCetaktagihanspbu
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpawal = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpakhir = New System.Windows.Forms.DateTimePicker()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.P = New System.Windows.Forms.Label()
        Me.chktagihan = New System.Windows.Forms.CheckBox()
        Me.chkperiode = New System.Windows.Forms.CheckBox()
        Me.txtnotagihan = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "No tagihan        :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'dtpawal
        '
        Me.dtpawal.CustomFormat = "dd-MM-yyyy"
        Me.dtpawal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpawal.Location = New System.Drawing.Point(131, 60)
        Me.dtpawal.Name = "dtpawal"
        Me.dtpawal.Size = New System.Drawing.Size(91, 20)
        Me.dtpawal.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(228, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "-"
        '
        'dtpakhir
        '
        Me.dtpakhir.CustomFormat = "dd-MM-yyyy"
        Me.dtpakhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpakhir.Location = New System.Drawing.Point(244, 60)
        Me.dtpakhir.Name = "dtpakhir"
        Me.dtpakhir.Size = New System.Drawing.Size(91, 20)
        Me.dtpakhir.TabIndex = 6
        '
        'btnCari
        '
        Me.btnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCari.Location = New System.Drawing.Point(12, 86)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(323, 47)
        Me.btnCari.TabIndex = 7
        Me.btnCari.Text = "&Lihat Laporan"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'P
        '
        Me.P.AutoSize = True
        Me.P.Location = New System.Drawing.Point(41, 60)
        Me.P.Name = "P"
        Me.P.Size = New System.Drawing.Size(85, 13)
        Me.P.TabIndex = 6
        Me.P.Text = "Periode            : "
        '
        'chktagihan
        '
        Me.chktagihan.AutoSize = True
        Me.chktagihan.Location = New System.Drawing.Point(19, 22)
        Me.chktagihan.Name = "chktagihan"
        Me.chktagihan.Size = New System.Drawing.Size(15, 14)
        Me.chktagihan.TabIndex = 29
        Me.chktagihan.UseVisualStyleBackColor = True
        '
        'chkperiode
        '
        Me.chkperiode.AutoSize = True
        Me.chkperiode.Location = New System.Drawing.Point(20, 62)
        Me.chkperiode.Name = "chkperiode"
        Me.chkperiode.Size = New System.Drawing.Size(15, 14)
        Me.chkperiode.TabIndex = 30
        Me.chkperiode.UseVisualStyleBackColor = True
        '
        'txtnotagihan
        '
        Me.txtnotagihan.Location = New System.Drawing.Point(131, 16)
        Me.txtnotagihan.Name = "txtnotagihan"
        Me.txtnotagihan.Size = New System.Drawing.Size(204, 20)
        Me.txtnotagihan.TabIndex = 31
        '
        'frmCetaktagihanspbu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 145)
        Me.Controls.Add(Me.txtnotagihan)
        Me.Controls.Add(Me.chkperiode)
        Me.Controls.Add(Me.chktagihan)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.dtpakhir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpawal)
        Me.Controls.Add(Me.P)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCetaktagihanspbu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Cetak Tagihan SPBU :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpawal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpakhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents P As System.Windows.Forms.Label
    Friend WithEvents chktagihan As System.Windows.Forms.CheckBox
    Friend WithEvents chkperiode As System.Windows.Forms.CheckBox
    Friend WithEvents txtnotagihan As System.Windows.Forms.TextBox
End Class
