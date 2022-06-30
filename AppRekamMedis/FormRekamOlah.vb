Imports System.Data.SqlClient
Public Class FormRekamOlah
    Dim BeingDragged As Boolean = False
    Dim MouseDownX As Integer
    Dim MouseDownY As Integer
    Dim tambah As Boolean
    Dim db As New Database

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

    Private Sub FormRekamOlah_Load(sender As Object, e As EventArgs) Handles Me.Load
        db.koneksi()
        Dim query = "SELECT * FROM Pasien"
        Dim DA As New SqlDataAdapter(query, db.konek)
        Dim DT As New DataTable
        Dim col As New AutoCompleteStringCollection
        DA.Fill(DT)
        For i = 0 To DT.Rows.Count - 1
            col.Add(DT.Rows(i)("idPasien").ToString())
        Next
        TextBox2.AutoCompleteSource = AutoCompleteSource.CustomSource
        TextBox2.AutoCompleteCustomSource = col
        TextBox2.AutoCompleteMode = AutoCompleteMode.Suggest


        Dim milliseconds = CLng(DateTime.UtcNow.Subtract(New DateTime(1970, 1, 1)).TotalMilliseconds)
        tgl.Text = DateTime.Now.ToString("dd/MMMM/yyyy HH:mm")

        tambah = FormRekam.tambah
        If tambah Then
            Call KodeOtomatis()
        End If
    End Sub

    Sub KodeOtomatis()
        db.koneksi()
        Dim query = "SELECT idRekam From Rekam order by idRekam desc"
        Dim CMD As New SqlCommand(query, db.konek)

        Dim DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            lblNoRekam.Text = "RM000001"
        Else
            lblNoRekam.Text = "RM" + Format(Microsoft.VisualBasic.Right(DR.Item("idRekam"), 6) + 1, "000000")
        End If
        DR.Close()
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
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
        If e.KeyChar = Chr(13) Then TextBox6.Focus()
    End Sub
    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If e.KeyChar = Chr(13) Then TextBox7.Focus()
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        If e.KeyChar = Chr(13) Then btnSimpanRekam_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub btnSimpanRekam_Click(sender As Object, e As EventArgs) Handles btnSimpanRekam.Click
        Dim query As String
        Dim milliseconds = DateTime.Now.ToString("dd/MMMM/yyyy HH:mm")
        Try
            If lblNoRekam.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" Then
                If tambah Then
                    query = "INSERT INTO Rekam (IdRekam, idPasien, anamnesa, gejala, diagnosa, pengobatan, ket, tgl) values
                    ('" & lblNoRekam.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & milliseconds & "')"

                    Call FormRekam.Olah(query)

                Else
                    query = "UPDATE Rekam set idPasien='" & TextBox2.Text & "', anamnesa='" & TextBox3.Text & "', 
                            gejala='" & TextBox4.Text & "', diagnosa='" & TextBox5.Text & "', pengobatan='" & TextBox6.Text & "', 
                            ket='" & TextBox7.Text & "' where idRekam='" & lblNoRekam.Text & "'"
                    Call FormRekam.Olah(query)
                End If
            Else
                MessageBox.Show("Data Belum Lengkap", "Data Rekam", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class