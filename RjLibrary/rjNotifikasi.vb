Imports RjLibrary.RJCommon
Imports System.Data
Imports System.Data.SqlClient

Public Class rjNotifikasi
    Dim _rjcommon As New RJCommon
    Public Function getrutinmaintance() As DataTable
        Dim dt As New DataTable
        Dim connstr As String = _rjcommon.getconnstr()
        Dim conn As New SqlConnection(connstr)
        Dim command As New SqlCommand("Select * from tjenismaintance where rutin=1 order by kodejenismaintance", conn)
        conn.Open()
        dt.Load(command.ExecuteReader)
        conn.Close()
        Return dt
    End Function
    Public Function jatuhtempomaintance(kodejenismaintance As String, jenis As String, batas As Date) As DataTable
        Dim dt As New DataTable
        Dim connstr As String = _rjcommon.getconnstr()
        Dim conn As New SqlConnection(connstr)
        Dim command As New SqlCommand
        Dim query As String = ""
        query = "select k.nolambung,k.nopol,k.merek,m.jumlah,m.km,m.kmlast,m.lastmaintance "
        query &= " from tkendaraan k,tkendaraanmaintance m where k.nolambung=m.nolambung"
        If jenis = 0 Then
            'pp
            query &= " and jumlah>=@batas"
        Else
            If jenis = 1 Then
                'km
                query &= " and km>=@batas"
            Else
                query &= " and lastmaintance<=@batas"
            End If
        End If
        query &= " and kodejenismaintance=@kodejenismaintance order by k.nopol"
        command.Connection = conn
        command.CommandText = query
        command.Parameters.Add(New SqlParameter("@kodejenismaintance", kodejenismaintance))
        command.Parameters.Add(New SqlParameter("@batas", batas))
        conn.Open()
        dt.Load(command.ExecuteReader)
        conn.Close()
        Return dt
    End Function
    Public Function jatuhtempomaintance(kodejenismaintance As String, jenis As String, batas As String) As DataTable
        Dim dt As New DataTable
        Dim connstr As String = _rjcommon.getconnstr()
        Dim conn As New SqlConnection(connstr)
        Dim command As New SqlCommand
        Dim query As String = ""
        query = "select k.nolambung,k.nopol,k.merek,m.jumlah,m.km,m.kmlast,m.lastmaintance "
        query &= " from tkendaraan k,tkendaraanmaintance m where k.nolambung=m.nolambung"

        If jenis = 0 Then
            'pp
            query &= " and jumlah>=@batas"
        Else
            If jenis = 1 Then
                'km
                query &= " and km>=@batas"
            Else
                query &= " and lastmaintance<=@batas"
            End If
        End If
        query &= " and kodejenismaintance=@kodejenismaintance order by k.nopol"
        command.Connection = conn
        command.CommandText = query
        command.Parameters.Add(New SqlParameter("@kodejenismaintance", kodejenismaintance))
        command.Parameters.Add(New SqlParameter("@batas", batas))
        conn.Open()
        dt.Load(command.ExecuteReader)
        conn.Close()
        Return dt
    End Function
    Public Function jatuhtempostnk(tgl As Date) As DataTable
        Dim dt As New DataTable
        Dim connstr As String = _rjcommon.getconnstr()
        Dim conn As New SqlConnection(connstr)
        Dim command As New SqlCommand
        Dim param As New SqlParameter
        command.CommandText = "select nolambung,nopol,merek,jatuhtempo from tkendaraan where jatuhtempo<=@jatuhtempo order by jatuhtempo"
        command.Connection = conn
        param.ParameterName = "@jatuhtempo"
        param.Value = tgl
        command.Parameters.Add(param)
        conn.Open()
        dt.Load(command.ExecuteReader)
        conn.Close()
        Return dt
    End Function

    Public Function jatuhtempobpkb(tgl As Date) As DataTable
        Dim dt As New DataTable
        Dim connstr As String = _rjcommon.getconnstr()
        Dim conn As New SqlConnection(connstr)
        Dim command As New SqlCommand
        Dim param As New SqlParameter
        command.CommandText = "select nolambung,nopol,merek,jatuhtempobpkb from tkendaraan where jatuhtempobpkb<=@jatuhtempobpkb order by jatuhtempobpkb"
        command.Connection = conn
        param.ParameterName = "@jatuhtempobpkb"
        param.Value = tgl
        command.Parameters.Add(param)
        conn.Open()
        dt.Load(command.ExecuteReader)
        conn.Close()
        Return dt
    End Function
    Public Function jatuhtempokir(tgl As Date) As DataTable
        Dim dt As New DataTable
        Dim connstr As String = _rjcommon.getconnstr()
        Dim conn As New SqlConnection(connstr)
        Dim command As New SqlCommand
        Dim param As New SqlParameter
        command.CommandText = "select  u.tglkirberikutnya,u.nolambung,k.nopol,k.merek from tujikir u,tkendaraan k where u.nolambung=k.nolambung and tglkirberikutnya<=@jatuhtempo order by tglkirberikutnya"
        command.Connection = conn
        param.ParameterName = "@jatuhtempo"
        param.Value = tgl
        command.Parameters.Add(param)
        conn.Open()
        dt.Load(command.ExecuteReader)
        conn.Close()
        Return dt
    End Function
End Class
