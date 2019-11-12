<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowsesopir
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
        Me.dgvsopir = New System.Windows.Forms.DataGridView()
        Me.kodesopir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panggilan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namasopir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.lblcari = New System.Windows.Forms.Label()
        Me.btnfilter = New System.Windows.Forms.Button()
        CType(Me.dgvsopir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvsopir
        '
        Me.dgvsopir.AllowUserToAddRows = False
        Me.dgvsopir.AllowUserToDeleteRows = False
        Me.dgvsopir.AllowUserToOrderColumns = True
        Me.dgvsopir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsopir.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kodesopir, Me.panggilan, Me.namasopir, Me.alamat, Me.kota, Me.hp})
        Me.dgvsopir.Location = New System.Drawing.Point(12, 58)
        Me.dgvsopir.Name = "dgvsopir"
        Me.dgvsopir.ReadOnly = True
        Me.dgvsopir.Size = New System.Drawing.Size(645, 274)
        Me.dgvsopir.TabIndex = 2
        '
        'kodesopir
        '
        Me.kodesopir.DataPropertyName = "kodesopir"
        Me.kodesopir.HeaderText = "Kode Sopir"
        Me.kodesopir.Name = "kodesopir"
        Me.kodesopir.ReadOnly = True
        '
        'panggilan
        '
        Me.panggilan.DataPropertyName = "panggilan"
        Me.panggilan.HeaderText = "Panggilan"
        Me.panggilan.Name = "panggilan"
        Me.panggilan.ReadOnly = True
        '
        'namasopir
        '
        Me.namasopir.DataPropertyName = "namasopir"
        Me.namasopir.HeaderText = "Nama Sopir"
        Me.namasopir.Name = "namasopir"
        Me.namasopir.ReadOnly = True
        '
        'alamat
        '
        Me.alamat.DataPropertyName = "alamat"
        Me.alamat.HeaderText = "Alamat"
        Me.alamat.Name = "alamat"
        Me.alamat.ReadOnly = True
        '
        'kota
        '
        Me.kota.DataPropertyName = "kota"
        Me.kota.HeaderText = "Kota"
        Me.kota.Name = "kota"
        Me.kota.ReadOnly = True
        '
        'hp
        '
        Me.hp.DataPropertyName = "hp"
        Me.hp.HeaderText = "HP"
        Me.hp.Name = "hp"
        Me.hp.ReadOnly = True
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(411, 20)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(143, 20)
        Me.txtcari.TabIndex = 3
        '
        'lblcari
        '
        Me.lblcari.AutoSize = True
        Me.lblcari.Location = New System.Drawing.Point(316, 23)
        Me.lblcari.Name = "lblcari"
        Me.lblcari.Size = New System.Drawing.Size(89, 13)
        Me.lblcari.TabIndex = 5
        Me.lblcari.Text = "Cari Nama Sopir :"
        '
        'btnfilter
        '
        Me.btnfilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnfilter.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnfilter.Location = New System.Drawing.Point(560, 6)
        Me.btnfilter.Name = "btnfilter"
        Me.btnfilter.Size = New System.Drawing.Size(97, 46)
        Me.btnfilter.TabIndex = 15
        Me.btnfilter.Text = "&Filter"
        Me.btnfilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnfilter.UseVisualStyleBackColor = True
        '
        'frmBrowsesopir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 339)
        Me.Controls.Add(Me.btnfilter)
        Me.Controls.Add(Me.lblcari)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.dgvsopir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBrowsesopir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Sopir :."
        CType(Me.dgvsopir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvsopir As System.Windows.Forms.DataGridView
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents lblcari As System.Windows.Forms.Label
    Friend WithEvents kodesopir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents panggilan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namasopir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents alamat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnfilter As System.Windows.Forms.Button

End Class
