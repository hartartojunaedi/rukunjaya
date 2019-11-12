<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLog
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Login = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.logout = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lamaakses = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.computername = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Login, Me.logout, Me.lamaakses, Me.IP, Me.computername})
        Me.DataGridView1.Location = New System.Drawing.Point(25, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(588, 334)
        Me.DataGridView1.TabIndex = 5
        '
        'Login
        '
        Me.Login.DataPropertyName = "datelogin"
        Me.Login.HeaderText = "Login"
        Me.Login.Name = "Login"
        Me.Login.ReadOnly = True
        '
        'logout
        '
        Me.logout.DataPropertyName = "datelogout"
        Me.logout.HeaderText = "Logout"
        Me.logout.Name = "logout"
        Me.logout.ReadOnly = True
        '
        'lamaakses
        '
        Me.lamaakses.DataPropertyName = "detik"
        Me.lamaakses.HeaderText = "Lama Akses"
        Me.lamaakses.Name = "lamaakses"
        Me.lamaakses.ReadOnly = True
        '
        'IP
        '
        Me.IP.DataPropertyName = "ip"
        Me.IP.HeaderText = "IP Address"
        Me.IP.Name = "IP"
        Me.IP.ReadOnly = True
        '
        'computername
        '
        Me.computername.DataPropertyName = "namacomputer"
        Me.computername.HeaderText = "Computer Name"
        Me.computername.Name = "computername"
        Me.computername.ReadOnly = True
        '
        'frmLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 375)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Form Log :."
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Login As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents logout As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lamaakses As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents computername As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
