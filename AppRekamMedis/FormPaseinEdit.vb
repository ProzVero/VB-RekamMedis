Imports System.Data.SqlClient
Public Class FormPaseinEdit
    Dim BeingDragged As Boolean = False
    Dim MouseDownX As Integer
    Dim MouseDownY As Integer
    Dim tambah As Boolean

    Private Sub pnlTop_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTop.MouseDown
        If e.Button = MouseButtons.Left Then
            BeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub pnlTop_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlTop.MouseUp
        If e.Button = MouseButtons.Left Then
            BeingDragged = False
        End If
    End Sub

    Private Sub pnlTop_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTop.MouseMove
        If BeingDragged = True Then
            Dim tmp As Point = New Point()

            tmp.X = Me.Location.X + (e.X - MouseDownX)
            tmp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = tmp
            tmp = Nothing
        End If
    End Sub

    Dim db As New Database

    Sub KodeOtomatis()
        db.koneksi()
        Dim query = "SELECT idPasien From Pasien order by idPasien desc"
        Dim CMD As New SqlCommand(query, db.konek)

        Dim DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            lblNoPendaftaran.Text = "PSN000001"
        Else
            lblNoPendaftaran.Text = "PSN" + Format(Microsoft.VisualBasic.Right(DR.Item("idPasien"), 6) + 1, "000000")
        End If
        DR.Close()
    End Sub

    Private Sub FormPaseinEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tambah = FormPasien.tambah
        If tambah Then
            Call KodeOtomatis()
        End If
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
    End Sub

    Private Sub btnSimpanPasien_Click(sender As Object, e As EventArgs) Handles btnSimpanPasien.Click
        Try
            If lblNoPendaftaran.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And ComboBox1.Text <> "" And TextBox7.Text <> "" And TextBox8.Text <> "" Then
                If tambah Then
                    Dim query = "INSERT INTO Pasien (idPasien, noKtP, nama, namaHewan, jenisHewan, jkHewan, alamat, noTelepon) values
                ('" & lblNoPendaftaran.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & ComboBox1.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "')"
                    Call FormPasien.Edit(query)

                Else
                    Dim query = "UPDATE Pasien set noKtP='" & TextBox2.Text & "', nama='" & TextBox3.Text & "', 
                namaHewan='" & TextBox4.Text & "', jenisHewan='" & TextBox5.Text & "', jkHewan='" & ComboBox1.Text & "', 
                alamat='" & TextBox7.Text & "', noTelepon='" & TextBox8.Text & "' where idPasien='" & lblNoPendaftaran.Text & "'"
                    Call FormPasien.Edit(query)
                End If
            Else
                MessageBox.Show("Data Belum Lengkap", "Data Pasien", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Data Pasien", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then TextBox3.Focus()
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = Chr(13) Then TextBox4.Focus()
    End Sub
    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If e.KeyChar = Chr(13) Then TextBox5.Focus()
    End Sub
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If e.KeyChar = Chr(13) Then ComboBox1.Focus()
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        If e.KeyChar = Chr(13) Then TextBox8.Focus()
    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        If e.KeyChar = Chr(13) Then btnSimpanPasien_Click(Me, EventArgs.Empty)
    End Sub
End Class