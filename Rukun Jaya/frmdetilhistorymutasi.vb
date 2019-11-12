Imports System.Data.Sql
Imports System.Data.SqlClient
Imports RjLibrary
Public Class frmdetilhistorymutasi
    Public nomutasi As String
    Dim dataset As New DataSet
    Dim rj As New RJCommon
    Dim cn As New SqlConnection(rj.getconnstr)
    Dim adapter As New SqlDataAdapter

    Dim command As String = ""
    Dim transaction As SqlTransaction
    Private Sub frmdetilhistorymutasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panggil()
        panggilheader()

    End Sub
    Sub panggilheader()
        command = "Select nomutasi,tanggalmutasi, username from tmutasi  where  nomutasi='" & nomutasi & "'"
        cn.Open()
        Dim cmd As New SqlCommand(command)
        cmd.Connection = cn
        Dim reader As SqlDataReader = cmd.ExecuteReader
        If reader.HasRows Then
            While reader.Read
                lbltglmutasi.Text = reader("tanggalmutasi")
                lblusername.Text = reader("username")
            End While
        End If
        cn.Close()
    End Sub
    Sub panggil()

        command = "Select d.kodesparepart,namasparepart, jumlahsebelum,jumlahsesudah from tdmutasi d, tsparepart s where  nomutasi='" & nomutasi & "' and d.kodesparepart=s.kodesparepart order by nomutasi desc"


        dataset.Clear()
        Try
            cn.Open()
            isidataset(New SqlCommand(command, cn))
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub isidataset(ByVal cmd1 As SqlCommand)
        adapter.SelectCommand = cmd1
        Dim builder As New SqlCommandBuilder(adapter)
        adapter.Fill(dataset, "Mutasi")
        dgvmutasi.DataSource = dataset
        dgvmutasi.DataMember = "Mutasi"
    End Sub
End Class