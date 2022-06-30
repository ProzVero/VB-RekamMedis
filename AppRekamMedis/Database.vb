Imports System.Data.SqlClient
Imports System.IO

Public Class Database
    Public cmd As SqlCommand
    Public query As String
    Public konek As SqlConnection
    Public appPath As String = Path.GetDirectoryName(Application.ExecutablePath)

    Public Sub koneksi()
        Try
            'konek = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DataApp\vs\Rekam-Medis\AppRekamMedis\AppRekamMedis\dbRekamMedis.mdf;Integrated Security=True")
            konek = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & appPath & "\dbRekamMedis.mdf;Integrated Security=True")
            konek.Open()

            'MsgBox("Database berhasil terkoneksi in" & appPath & "--" & appDataPath, MsgBoxStyle.Information, "Konfirmasi")
        Catch ex As Exception
            MsgBox("Koneksi database gagal" + ex.Message, MsgBoxStyle.Critical, "error")
        End Try
    End Sub

End Class
