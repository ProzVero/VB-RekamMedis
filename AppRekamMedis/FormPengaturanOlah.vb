Imports System.Data.SqlClient
Public Class FormPengaturanOlah
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
        Dim query = "SELECT id From users order by id desc"
        Dim CMD As New SqlCommand(query, db.konek)

        Dim DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            lblID.Text = "USER001"
        Else
            lblID.Text = "USER" + Format(Microsoft.VisualBasic.Right(DR.Item("id"), 3) + 1, "000")
        End If
        DR.Close()
    End Sub

    Private Sub FormPengaturanOlah_Load(sender As Object, e As EventArgs) Handles Me.Load
        tambah = FormPengaturan.tambah
        If tambah Then
            Call KodeOtomatis()
        End If
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
    End Sub

    Private Sub btnSimpanPasien_Click(sender As Object, e As EventArgs) Handles btnSimpanPasien.Click
        Try
            If lblID.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox1.Text <> "" Then
                If tambah Then
                    If TextBox4.Text = TextBox1.Text Then
                        Dim query = "INSERT INTO users (id, nama, username, pass) values
                            ('" & lblID.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
                        Call FormPengaturan.Olah(query)
                    Else
                        MessageBox.Show("Password Tidak Sama", "Data User", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    End If
                Else
                    If TextBox4.Text = TextBox1.Text Then
                        Dim query = "UPDATE users set nama='" & TextBox2.Text & "', username='" & TextBox3.Text & "', 
                pass='" & TextBox4.Text & "'"
                        Call FormPengaturan.Olah(query)
                    Else
                        MessageBox.Show("Password Tidak Sama", "Data User", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    End If
                End If
                    Else
                MessageBox.Show("Data Belum Lengkap", "Data User", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then TextBox3.Focus()
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = Chr(13) Then TextBox4.Focus()
    End Sub
    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If e.KeyChar = Chr(13) Then TextBox1.Focus()
    End Sub
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then btnSimpanPasien_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub TextBox4_Click(sender As Object, e As EventArgs) Handles TextBox4.Click
        TextBox4.UseSystemPasswordChar = True
        TextBox4.Text = ""
        TextBox1.UseSystemPasswordChar = True
        TextBox1.Text = ""
    End Sub
End Class