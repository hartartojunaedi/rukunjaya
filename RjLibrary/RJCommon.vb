Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Net
Imports System.Net.Sockets
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Net.Mail

Public Class RJCommon
    Dim mysecurity As New RJSecurity
    Public Function replacestringpetik(s As String) As String
        s.Replace("'", "''")
        Return s
    End Function
    Public Sub updatesaldo(kodebank As String, saldo As Double, kredit As Boolean)
        Dim connstr = getconnstr()
        Dim conn As New SqlConnection(connstr)
        Dim command As New SqlCommand
        Dim query As String
        If kredit Then
            query = "update tbank set saldo=saldo+@saldo where kodebank=@kodebank"
        Else
            query = "update tbank set saldo=saldo-@saldo where kodebank=@kodebank"
        End If
        command.Connection = conn
        command.CommandText = query
        command.Parameters.AddWithValue("@saldo", saldo)
        command.Parameters.AddWithValue("@kodebank", kodebank)
        Try
            conn.Open()
            command.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub
    Public Function cekvoucherbbm(nobm As String, nosuratjalan As String) As Integer
        Dim connstr = getconnstr()
        Dim conn As New SqlConnection(connstr)
        Dim command As New SqlCommand
        Dim query As String = ""
        Dim status As Integer = 0
        query = "select isnull(sum(status),0) as total from tvoucherspbu where nosuratjalan=@nosuratjalan and nobm=@nobm"
        command.CommandText = query
        command.Parameters.AddWithValue("@nosuratjalan", nosuratjalan)
        command.Parameters.AddWithValue("@nobm", nobm)
        command.Connection = conn
        conn.Open()
        Try
            status = command.ExecuteScalar()
        Catch ex As Exception
            status = 0
        End Try

        conn.Close()
        Return status
    End Function
    Public Function cekstatusvoucherbbm(nobm As String, nosuratjalan As String) As Integer
        Dim connstr = getconnstr()
        Dim conn As New SqlConnection(connstr)
        Dim command As New SqlCommand
        Dim query As String = ""
        Dim status As Integer = 0
        query = "select count(*) as total from tvoucherspbu where nosuratjalan=@nosuratjalan and nobm=@nobm"
        command.CommandText = query
        command.Parameters.AddWithValue("@nosuratjalan", nosuratjalan)
        command.Parameters.AddWithValue("@nobm", nobm)
        command.Connection = conn
        conn.Open()
        Try
            status = command.ExecuteScalar()
        Catch ex As Exception
            status = 0
        End Try

        conn.Close()
        Return status
    End Function
    Public Function cekstatussuratjalan(nosuratjalan As String) As Integer
        Dim connstr = getconnstr()
        Dim conn As New SqlConnection(connstr)
        Dim command As New SqlCommand
        Dim query As String = ""
        Dim status As Integer = 0
        query = "select status+tagih from tsuratjalan where nosuratjalan=@nosuratjalan "
        command.CommandText = query
        command.Parameters.AddWithValue("@nosuratjalan", nosuratjalan)
        command.Connection = conn
        conn.Open()
        Try
            status = command.ExecuteScalar()
        Catch ex As Exception
            status = 0
        End Try

        conn.Close()
        Return status
    End Function
    Public Function cekstatussuratjalan(nosuratjalan As String, nobm As String) As Integer
        Dim connstr = getconnstr()
        Dim conn As New SqlConnection(connstr)
        Dim command As New SqlCommand
        Dim query As String = ""
        Dim status As Integer = 0
        query = "select status+tagih from tsuratjalan where nosuratjalan=@nosuratjalan and nobm=@nobm"
        command.CommandText = query
        command.Parameters.AddWithValue("@nosuratjalan", nosuratjalan)
        command.Parameters.AddWithValue("@nobm", nobm)
        command.Connection = conn
        conn.Open()
        Try
            status = command.ExecuteScalar()
        Catch ex As Exception
            status = 0
        End Try

        conn.Close()
        Return status
    End Function
    Public Sub increaseritase(nobm As String)
        Dim connstr = getconnstr()
        Dim conn As New SqlConnection(connstr)
        Dim command As New SqlCommand
        Dim query As String = ""
        query = "update tKendaraanMaintance set jumlah=jumlah+0.5 where nolambung=(select nolambung from tbm where nobm=@nobm) "
        command.CommandText = query
        command.Parameters.AddWithValue("@nobm", nobm)
        command.Connection = conn
        conn.Open()
        command.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Sub decreaseritase(nobm As String)
        Dim connstr = getconnstr()
        Dim conn As New SqlConnection(connstr)
        Dim command As New SqlCommand
        Dim query As String = ""
        query = "update tKendaraanMaintance set jumlah=jumlah-0.5 where nolambung=(select nolambung from tbm where nobm=@nobm) "
        command.CommandText = query
        command.Parameters.AddWithValue("@nobm", nobm)
        command.Connection = conn
        conn.Open()
        command.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Sub resetmaintance(nolambung As String, kodejenismaintance As String, km As Integer)
        '27 desember 2014
        'reset maintance
        Dim connstr = getconnstr()
        Dim conn As New SqlConnection(connstr)
        Dim command As New SqlCommand
        Dim query As String = ""
        query = "select count(*) from tkendaraanmaintance where nolambung=@nolambung and kodejenismaintance=@kodejenismaintance"
        command.CommandText = query
        command.Parameters.Add(New SqlParameter("@nolambung", nolambung))
        command.Parameters.Add(New SqlParameter("@kodejenismaintance", kodejenismaintance))
        command.Connection = conn
        conn.Open()
        Dim jum As Integer = command.ExecuteScalar
        conn.Close()
        If jum > 0 Then
            'update
            query = "update tkendaraanmaintance set lastmaintance=@lastmaintance,km=@km-kmlast,kmlast=@km,jumlah=0 where nolambung=@nolambung and kodejenismaintance=@kodejenismaintance"
        Else
            'insert
            query = "insert into tkendaraanmaintance (nolambung,kodejenismaintance,jumlah,km,kmlast,lastmaintance) values (@nolambung,@kodejenismaintance,0,0,@km,@lastmaintance)"
        End If
        command.CommandText = query
        command.Parameters.Add(New SqlParameter("@km", km))
        command.Parameters.Add(New SqlParameter("@lastmaintance", Now))
        conn.Open()
        command.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Function appendspasi(s As String, n As Integer) As String
        Dim temp As String = ""
        Dim i As Integer = 0
        temp = s
        For i = 1 To n - s.Length
            temp &= " "
        Next
        Return temp
    End Function
    Public Sub shownotifyerror(Message As String)
        Dim nf As New NotifyIcon
        nf.Icon = SystemIcons.Error
        nf.BalloonTipTitle = "Error Message"
        nf.BalloonTipText = Message
        nf.BalloonTipIcon = ToolTipIcon.Error
        nf.Visible = True
        nf.ShowBalloonTip(5000)
    End Sub

    Public Sub shownotify(message As String)
        Dim nf As New NotifyIcon
        nf.Icon = SystemIcons.Information
        nf.BalloonTipTitle = "Information"
        nf.BalloonTipText = message
        nf.BalloonTipIcon = ToolTipIcon.Info
        nf.Visible = True
        nf.ShowBalloonTip(5000)
    End Sub
    Public Function getconnstr() As String
        Return System.Configuration.ConfigurationManager.ConnectionStrings("RjConnStr").ConnectionString
    End Function
    Private Function dekrip(ByVal password As String) As String
        Dim temp As String
        temp = mysecurity.enkripsi(password, "rukunjaya")
        Return temp
    End Function
    Public Function enkripsi(str As String) As String
        Return mysecurity.enkripsi(str, "rukunjaya")
    End Function
    Public Function cekusername(ByVal username As String, ByVal password As String) As Boolean
        Dim flag As Boolean = False

        Dim connstr As String = getconnstr()
        Dim conn As New SqlConnection(connstr)

        Dim command As New SqlCommand
        Dim param1 As New SqlParameter("@username", username)
        Dim param2 As New SqlParameter("@password", mysecurity.enkripsi(password, "rukunjaya"))
        Dim dr As SqlDataReader

        command.Connection = conn
        command.CommandType = CommandType.Text
        command.CommandText = "select *  from tlogin where username=@username and password=@password"
        command.Parameters.Add(param1)
        command.Parameters.Add(param2)

        conn.Open()
        dr = command.ExecuteReader
        If dr.HasRows Then
            flag = True
        End If
        conn.Close()
        Return flag
    End Function
    Public Sub isilogout(ByVal username As String)
        Dim connstr As String = getconnstr()
        Dim conn As New SqlConnection(connstr)
        Dim command As New SqlCommand

        command.Connection = conn
        command.CommandType = CommandType.Text
        command.CommandText = "update tlogLogin set datelogout={fn NOW()} where username=@username and datelogin=(select max(datelogin) from tloglogin where username=@username1)"
        command.Parameters.Add(New SqlParameter("@username", username))
        command.Parameters.Add(New SqlParameter("@username1", username))
        Try
            conn.Open()
            command.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Function getipaddress() As String
        Dim stripAddress As String = ""
        Dim entry = Dns.GetHostEntry(System.Net.Dns.GetHostName())
        For Each address In entry.AddressList
            If address.AddressFamily = AddressFamily.InterNetwork Then
                '//IPv4 (you are used to this format)
                stripAddress = address.ToString()
                Exit For
            End If
        Next
        Return stripAddress
    End Function
    Private Function getcomputername() As String
        Return (System.Net.Dns.GetHostName())
    End Function
    Public Sub isilogin(ByVal username As String)
        Dim connstr As String = getconnstr()
        Dim conn As New SqlConnection(connstr)
        Dim command As New SqlCommand

        command.Connection = conn
        command.CommandType = CommandType.Text
        command.CommandText = "insert into tloglogin(username,datelogin,ip,namacomputer) values (@username,{fn NOW()},@ip,@namacomputer)"
        command.Parameters.Add(New SqlParameter("@username", username))
        command.Parameters.Add(New SqlParameter("@ip", getipaddress))
        command.Parameters.Add(New SqlParameter("@namacomputer", getcomputername))
        Try
            conn.Open()
            command.ExecuteNonQuery()
            conn.Close()
            setusername(username)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Function gethargabbm() As String
        Dim temp As String = ""
        Dim _appConfig As New AppConfig
        temp = _appConfig.GetProperty("bbm")
        Return temp
    End Function
    Public Function getusername()
        Dim temp As String = ""
        Dim _appConfig As New AppConfig
        temp = _appConfig.GetProperty("namauser")
        Return temp
    End Function
    Public Function gethakakses(username As String) As String
        Dim temp As String = ""
        Dim connstr As String = getconnstr()
        Dim conn As New SqlConnection(connstr)
        Dim command As New SqlCommand

        command.Connection = conn
        command.CommandType = CommandType.Text
        command.CommandText = "Select hak from tlogin where username=@username"
        command.Parameters.AddWithValue("@username", username)
        conn.Open()
        temp = command.ExecuteScalar
        conn.Close()
        Return temp
    End Function
    Public Sub sethargabbm(harga As String)
        Dim _appConfig As New AppConfig
        _appConfig.SetProperty("bbm", harga)
    End Sub
    Private Sub setusername(username As String)
        Dim _appConfig As New AppConfig
        _appConfig.SetProperty("namauser", username)
    End Sub

    Public Sub isilog(ByVal username As String, ByVal kodetrans As String, ByVal tipetrans As String, ByVal tipeact As String, ByVal keterangan As String)
        Dim connstr As String = getconnstr()
        Dim conn As New SqlConnection(connstr)
        Dim command As New SqlCommand
        Dim act As Integer = 0
        If tipeact = "Tambah Data" Then
            act = 1
        Else
            If tipeact = "Update Data" Then
                act = 2
            Else
                If tipeact = "Hapus Data" Then
                    act = 3
                End If
            End If
        End If
        command.Connection = conn
        command.CommandType = CommandType.Text
        command.CommandText = "insert into thistory(kodetrans,tgl,username,tipetrans,tipeact,keterangan) values (@kodetrans,{fn NOW()},@username,@tipetrans,@tipeact,@keterangan)"
        command.Parameters.Add(New SqlParameter("@kodetrans", kodetrans))
        command.Parameters.Add(New SqlParameter("@username", username))
        command.Parameters.Add(New SqlParameter("@tipetrans", tipetrans))
        command.Parameters.Add(New SqlParameter("@tipeact", act))
        command.Parameters.Add(New SqlParameter("@keterangan", keterangan))

        Try
            conn.Open()
            command.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub isiErrorlog(ByVal username As String, ByVal kodetrans As String, ByVal tipetrans As String, ByVal tipeact As String, ByVal keterangan As String)
        Dim connstr As String = getconnstr()
        Dim conn As New SqlConnection(connstr)
        Dim command As New SqlCommand
        Dim act As Integer = 0
        If tipeact = "Tambah Data" Then
            act = 1
        Else
            If tipeact = "Update Data" Then
                act = 2
            Else
                If tipeact = "Hapus Data" Then
                    act = 3
                End If
            End If
        End If
        command.Connection = conn
        command.CommandType = CommandType.Text
        command.CommandText = "insert into thistoryError(kodetrans,tgl,username,tipetrans,tipeact,keterangan) values (@kodetrans,{fn NOW()},@username,@tipetrans,@tipeact,@keterangan)"
        command.Parameters.Add(New SqlParameter("@kodetrans", kodetrans))
        command.Parameters.Add(New SqlParameter("@username", username))
        command.Parameters.Add(New SqlParameter("@tipetrans", tipetrans))
        command.Parameters.Add(New SqlParameter("@tipeact", act))
        command.Parameters.Add(New SqlParameter("@keterangan", keterangan))

        Try
            conn.Open()
            command.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception

        End Try

    End Sub
    Public Function changedatestr(s As String) As String
        Dim str As String() = s.Trim().Split("-")
        Dim dt As Date = New System.DateTime(CInt(str(2)), CInt(str(1)), CInt(str(0)))
        Return String.Format("{0:dd-MMM-yyyy}", dt)
    End Function
    Public Function gettgl() As String
        Return String.Format("{0:dd-MM-yyyy}", Now.Date)
    End Function
    Public Function gettgltime() As String
        Return String.Format("{0:dd-MM-yyyy hh:mm:ss}", Now)
    End Function
    Public Function changedate(s As String) As Date
        Dim str As String() = s.Trim().Split("-")
        Dim dt As Date = New System.DateTime(CInt(str(2)), CInt(str(1)), CInt(str(0)))
        Return dt
    End Function
    Public Function getnoTagihanSPBU() As String
        Dim temp As String = ""
        Dim i As Integer
        temp = "BBM" + Left(getusername(), 1).ToUpper
        Dim connstr As String = getconnstr()
        Dim conn As New SqlConnection(connstr)
        Dim command As New SqlCommand
        command.Connection = conn
        command.CommandType = CommandType.Text
        command.CommandText = "select isnull(max(substring(notagihan,5,6)),'0') as notagihan from tHTagihanSPBU where substring(notagihan,1,4)=@temp"
        command.Parameters.Add(New SqlParameter("@temp", temp))
        Try
            conn.Open()
            Dim dr As SqlDataReader = command.ExecuteReader()
            If dr.Read Then
                Dim s As String = dr.Item(0)
                s = (CInt(s) + 1).ToString
                For i = 1 To 6 - Len(s)
                    temp &= "0"
                Next
                temp &= s
            Else
                temp &= "000001"
            End If
            conn.Close()
        Catch ex As Exception
            temp &= "000001"
        End Try

        Return temp

    End Function
End Class
