<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdetilhistorymutasi
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
        Me.dgvmutasi = New System.Windows.Forms.DataGridView()
        Me.kodesparepart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaSparePart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahSebelum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahSesudah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.lbltglmutasi = New System.Windows.Forms.Label()
        CType(Me.dgvmutasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvmutasi
        '
        Me.dgvmutasi.AllowUserToAddRows = False
        Me.dgvmutasi.AllowUserToDeleteRows = False
        Me.dgvmutasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmutasi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodesparepart, Me.NamaSparePart, Me.JumlahSebelum, Me.JumlahSesudah})
        Me.dgvmutasi.Location = New System.Drawing.Point(12, 63)
        Me.dgvmutasi.Name = "dgvmutasi"
        Me.dgvmutasi.ReadOnly = True
        Me.dgvmutasi.Size = New System.Drawing.Size(617, 150)
        Me.dgvmutasi.TabIndex = 77
        '
        'kodesparepart
        '
        Me.kodesparepart.DataPropertyName = "kodesparepart"
        Me.kodesparepart.HeaderText = "kodesparepart"
        Me.kodesparepart.Name = "kodesparepart"
        Me.kodesparepart.ReadOnly = True
        Me.kodesparepart.Visible = False
        '
        'NamaSparePart
        '
        Me.NamaSparePart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NamaSparePart.DataPropertyName = "NamaSparePart"
        Me.NamaSparePart.HeaderText = "Nama SparePart"
        Me.NamaSparePart.Name = "NamaSparePart"
        Me.NamaSparePart.ReadOnly = True
        '
        'JumlahSebelum
        '
        Me.JumlahSebelum.DataPropertyName = "JumlahSebelum"
        Me.JumlahSebelum.HeaderText = "Jumlah Sebelum"
        Me.JumlahSebelum.Name = "JumlahSebelum"
        Me.JumlahSebelum.ReadOnly = True
        '
        'JumlahSesudah
        '
        Me.JumlahSesudah.DataPropertyName = "JumlahSesudah"
        Me.JumlahSesudah.HeaderText = "JumlahSesudah"
        Me.JumlahSesudah.Name = "JumlahSesudah"
        Me.JumlahSesudah.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Tanggal Mutasi : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Di Mutasi oleh :"
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Location = New System.Drawing.Point(118, 9)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(0, 13)
        Me.lblusername.TabIndex = 80
        '
        'lbltglmutasi
        '
        Me.lbltglmutasi.AutoSize = True
        Me.lbltglmutasi.Location = New System.Drawing.Point(121, 30)
        Me.lbltglmutasi.Name = "lbltglmutasi"
        Me.lbltglmutasi.Size = New System.Drawing.Size(0, 13)
        Me.lbltglmutasi.TabIndex = 81
        '
        'frmdetilhistorymutasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 239)
        Me.Controls.Add(Me.lbltglmutasi)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvmutasi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmdetilhistorymutasi"
        Me.Text = ".: Form History Mutasi :."
        CType(Me.dgvmutasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvmutasi As System.Windows.Forms.DataGridView
    Friend WithEvents kodesparepart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaSparePart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JumlahSebelum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JumlahSesudah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblusername As System.Windows.Forms.Label
    Friend WithEvents lbltglmutasi As System.Windows.Forms.Label
End Class
