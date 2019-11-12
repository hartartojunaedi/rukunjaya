<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchSparePart
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnoseri = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbSparePart = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpawal = New System.Windows.Forms.DateTimePicker()
        Me.dtpakhir = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.kodemaintance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kodesparepart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.noseri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namasparepart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tukang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detail = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodemaintance, Me.tgl, Me.kodesparepart, Me.noseri, Me.namasparepart, Me.tukang, Me.detail})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 43)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(822, 383)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No Spare Part : "
        '
        'txtnoseri
        '
        Me.txtnoseri.Location = New System.Drawing.Point(103, 13)
        Me.txtnoseri.MaxLength = 50
        Me.txtnoseri.Name = "txtnoseri"
        Me.txtnoseri.Size = New System.Drawing.Size(132, 20)
        Me.txtnoseri.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(241, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Spare Part : "
        '
        'cbSparePart
        '
        Me.cbSparePart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSparePart.FormattingEnabled = True
        Me.cbSparePart.Location = New System.Drawing.Point(314, 13)
        Me.cbSparePart.Name = "cbSparePart"
        Me.cbSparePart.Size = New System.Drawing.Size(156, 21)
        Me.cbSparePart.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(476, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Periode : "
        '
        'dtpawal
        '
        Me.dtpawal.CustomFormat = "dd-MM-yyyy"
        Me.dtpawal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpawal.Location = New System.Drawing.Point(526, 13)
        Me.dtpawal.Name = "dtpawal"
        Me.dtpawal.Size = New System.Drawing.Size(80, 20)
        Me.dtpawal.TabIndex = 12
        '
        'dtpakhir
        '
        Me.dtpakhir.CustomFormat = "dd-MM-yyyy"
        Me.dtpakhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpakhir.Location = New System.Drawing.Point(627, 13)
        Me.dtpakhir.Name = "dtpakhir"
        Me.dtpakhir.Size = New System.Drawing.Size(80, 20)
        Me.dtpakhir.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(612, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "-"
        '
        'btnFilter
        '
        Me.btnFilter.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFilter.Location = New System.Drawing.Point(754, 8)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(80, 29)
        Me.btnFilter.TabIndex = 10
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'kodemaintance
        '
        Me.kodemaintance.DataPropertyName = "kodemaintance"
        Me.kodemaintance.HeaderText = "Kode Maintance"
        Me.kodemaintance.Name = "kodemaintance"
        Me.kodemaintance.ReadOnly = True
        '
        'tgl
        '
        Me.tgl.DataPropertyName = "tgl"
        DataGridViewCellStyle1.Format = "dd-MM-yyyy"
        Me.tgl.DefaultCellStyle = DataGridViewCellStyle1
        Me.tgl.HeaderText = "Tanggal"
        Me.tgl.Name = "tgl"
        Me.tgl.ReadOnly = True
        '
        'kodesparepart
        '
        Me.kodesparepart.DataPropertyName = "kodesparepart"
        Me.kodesparepart.HeaderText = "Kode Spare Part"
        Me.kodesparepart.Name = "kodesparepart"
        Me.kodesparepart.ReadOnly = True
        '
        'noseri
        '
        Me.noseri.DataPropertyName = "noseri"
        Me.noseri.HeaderText = "No Seri"
        Me.noseri.Name = "noseri"
        Me.noseri.ReadOnly = True
        '
        'namasparepart
        '
        Me.namasparepart.DataPropertyName = "namasparepart"
        Me.namasparepart.HeaderText = "Nama Spare Part"
        Me.namasparepart.Name = "namasparepart"
        Me.namasparepart.ReadOnly = True
        '
        'tukang
        '
        Me.tukang.DataPropertyName = "tukang"
        Me.tukang.HeaderText = "Tukang"
        Me.tukang.Name = "tukang"
        Me.tukang.ReadOnly = True
        '
        'detail
        '
        Me.detail.HeaderText = "Detail"
        Me.detail.Name = "detail"
        Me.detail.ReadOnly = True
        Me.detail.Text = "Detail"
        Me.detail.UseColumnTextForButtonValue = True
        '
        'frmSearchSparePart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 438)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpakhir)
        Me.Controls.Add(Me.dtpawal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.cbSparePart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnoseri)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearchSparePart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Search Spare Part :."
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnoseri As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbSparePart As System.Windows.Forms.ComboBox
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpawal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpakhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents kodemaintance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tgl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kodesparepart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents noseri As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namasparepart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tukang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents detail As System.Windows.Forms.DataGridViewButtonColumn
End Class
