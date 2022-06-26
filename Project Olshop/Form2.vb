Imports System.Data.Odbc
Public Class FormHu
    Sub tampildata()
        Call koneksi()
        da = New OdbcDataAdapter("Select * from users", conn)
        ds = New DataSet
        da.Fill(ds, "users")
        DVUser.DataSource = ds.Tables("users")
        DVUser.ReadOnly = True
    End Sub
    Private Sub FormHu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampildata()
    End Sub

    Private Sub BtnlogOut_Click(sender As Object, e As EventArgs) Handles BtnlogOut.Click
        FormLogin.Show()
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        FormCaribrg.ShowDialog()
    End Sub
End Class