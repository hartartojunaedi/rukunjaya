<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchPembelian
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
        Me.lbljumlahrow = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNamaToko = New System.Windows.Forms.Label()
        Me.LblNonota = New System.Windows.Forms.Label()
        Me.txtsearchnamatoko = New System.Windows.Forms.TextBox()
        Me.txtsearchnonota = New System.Windows.Forms.TextBox()
        Me.dgvPembelianSparepart = New System.Windows.Forms.DataGridView()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        CType(Me.dgvPembelianSparepart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbljumlahrow
        '
        Me.lbljumlahrow.AutoSize = True
        Me.lbljumlahrow.Location = New System.Drawing.Point(695, 419)
        Me.lbljumlahrow.Name = "lbljumlahrow"
        Me.lbljumlahrow.Size = New System.Drawing.Size(13, 13)
        Me.lbljumlahrow.TabIndex = 31
        Me.lbljumlahrow.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(614, 419)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Jumlah Data : "
        '
        'lblNamaToko
        '
        Me.lblNamaToko.AutoSize = True
        Me.lblNamaToko.Location = New System.Drawing.Point(26, 39)
        Me.lblNamaToko.Name = "lblNamaToko"
        Me.lblNamaToko.Size = New System.Drawing.Size(63, 13)
        Me.lblNamaToko.TabIndex = 29
        Me.lblNamaToko.Text = "Nama Toko"
        '
        'LblNonota
        '
        Me.LblNonota.AutoSize = True
        Me.LblNonota.Location = New System.Drawing.Point(42, 10)
        Me.LblNonota.Name = "LblNonota"
        Me.LblNonota.Size = New System.Drawing.Size(47, 13)
        Me.LblNonota.TabIndex = 28
        Me.LblNonota.Text = "No Nota"
        '
        'txtsearchnamatoko
        '
        Me.txtsearchnamatoko.Location = New System.Drawing.Point(95, 34)
        Me.txtsearchnamatoko.Name = "txtsearchnamatoko"
        Me.txtsearchnamatoko.Size = New System.Drawing.Size(150, 20)
        Me.txtsearchnamatoko.TabIndex = 26
        '
        'txtsearchnonota
        '
        Me.txtsearchnonota.Location = New System.Drawing.Point(95, 7)
        Me.txtsearchnonota.Name = "txtsearchnonota"
        Me.txtsearchnonota.Size = New System.Drawing.Size(126, 20)
        Me.txtsearchnonota.TabIndex = 25
        '
        'dgvPembelianSparepart
        '
        Me.dgvPembelianSparepart.AllowUserToAddRows = False
        Me.dgvPembelianSparepart.AllowUserToDeleteRows = False
        Me.dgvPembelianSparepart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPembelianSparepart.Location = New System.Drawing.Point(12, 72)
        Me.dgvPembelianSparepart.Name = "dgvPembelianSparepart"
        Me.dgvPembelianSparepart.ReadOnly = True
        Me.dgvPembelianSparepart.Size = New System.Drawing.Size(826, 321)
        Me.dgvPembelianSparepart.TabIndex = 23
        '
        'btnCari
        '
        Me.btnCari.Image = Global.RukunJaya.My.Resources.Resources.filterbr
        Me.btnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCari.Location = New System.Drawing.Point(774, 10)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(64, 46)
        Me.btnCari.TabIndex = 27
        Me.btnCari.Text = "Cari"
        Me.btnCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(510, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Kartu Stok"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(278, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Nama SparePart"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(617, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(150, 20)
        Me.TextBox1.TabIndex = 33
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(369, 10)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(126, 20)
        Me.TextBox2.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(278, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Kode Sparepart"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(369, 36)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(126, 20)
        Me.TextBox3.TabIndex = 37
        '
        'frmSearchPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 441)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lbljumlahrow)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblNamaToko)
        Me.Controls.Add(Me.LblNonota)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtsearchnamatoko)
        Me.Controls.Add(Me.txtsearchnonota)
        Me.Controls.Add(Me.dgvPembelianSparepart)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearchPembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Search Pembelian :."
        CType(Me.dgvPembelianSparepart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbljumlahrow As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblNamaToko As System.Windows.Forms.Label
    Friend WithEvents LblNonota As System.Windows.Forms.Label
    Friend WithEvents btnCari As System.Windows.Forms.Button
    Friend WithEvents txtsearchnamatoko As System.Windows.Forms.TextBox
    Friend WithEvents txtsearchnonota As System.Windows.Forms.TextBox
    Friend WithEvents dgvPembelianSparepart As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
End Class
