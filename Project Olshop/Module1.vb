Imports System.Data.Odbc
Module Module1
    Public conn As OdbcConnection
    Public dr As OdbcDataReader
    Public da As OdbcDataAdapter
    Public cmd As OdbcCommand
    Public ds As DataSet

    Sub koneksi()
        Try
            conn = New OdbcConnection("Dsn=db_olshop;")
            If conn.State = New ConnectionState Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("koneksi gagal")
        End Try
    End Sub
End Module
