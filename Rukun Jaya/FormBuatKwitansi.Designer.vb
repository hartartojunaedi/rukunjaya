<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuatKwitansi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBuat = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.txtPengirim = New System.Windows.Forms.TextBox()
        Me.txtPenerima = New System.Windows.Forms.TextBox()
        Me.txtNominal = New System.Windows.Forms.TextBox()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtheader = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pengirim"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nominal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Keterangan"
        '
        'btnBuat
        '
        Me.btnBuat.Image = Global.RukunJaya.My.Resources.Resources.printbr1
        Me.btnBuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuat.Location = New System.Drawing.Point(96, 242)
        Me.btnBuat.Name = "btnBuat"
        Me.btnBuat.Size = New System.Drawing.Size(75, 30)
        Me.btnBuat.TabIndex = 7
        Me.btnBuat.Text = "&Cetak"
        Me.btnBuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuat.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Penerima"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(69, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "No"
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(96, 51)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(234, 20)
        Me.txtNo.TabIndex = 2
        '
        'txtPengirim
        '
        Me.txtPengirim.Location = New System.Drawing.Point(96, 77)
        Me.txtPengirim.Name = "txtPengirim"
        Me.txtPengirim.Size = New System.Drawing.Size(234, 20)
        Me.txtPengirim.TabIndex = 3
        '
        'txtPenerima
        '
        Me.txtPenerima.Location = New System.Drawing.Point(96, 103)
        Me.txtPenerima.Name = "txtPenerima"
        Me.txtPenerima.Size = New System.Drawing.Size(234, 20)
        Me.txtPenerima.TabIndex = 4
        '
        'txtNominal
        '
        Me.txtNominal.Location = New System.Drawing.Point(96, 129)
        Me.txtNominal.Name = "txtNominal"
        Me.txtNominal.Size = New System.Drawing.Size(234, 20)
        Me.txtNominal.TabIndex = 5
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(96, 155)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(234, 72)
        Me.txtKeterangan.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Header"
        '
        'txtheader
        '
        Me.txtheader.Location = New System.Drawing.Point(96, 27)
        Me.txtheader.Name = "txtheader"
        Me.txtheader.Size = New System.Drawing.Size(234, 20)
        Me.txtheader.TabIndex = 1
        '
        'FormBuatKwitansi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 278)
        Me.Controls.Add(Me.txtheader)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.txtNominal)
        Me.Controls.Add(Me.txtPenerima)
        Me.Controls.Add(Me.txtPengirim)
        Me.Controls.Add(Me.txtNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnBuat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormBuatKwitansi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Buat Kwitansi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBuat As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents txtPengirim As System.Windows.Forms.TextBox
    Friend WithEvents txtPenerima As System.Windows.Forms.TextBox
    Friend WithEvents txtNominal As System.Windows.Forms.TextBox
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtheader As System.Windows.Forms.TextBox

End Class
