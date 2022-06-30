Imports System.IO
Imports System.Data.SqlClient
Public Class FormPengaturan
    Dim BeingDragged As Boolean = False
    Dim MouseDownX As Integer
    Dim MouseDownY As Integer
    Dim db As New Database
    Dim kd As String
    Public tambah As Boolean = False

    Private Sub FormPengaturan_Load(sender As Object, e As EventArgs) Handles MyBase.Load












        'TODO: This line of code loads data into the 'DbRekamMedisDataSet.users' table. You can move, or remove it, as needed.
        'Me.UsersTableAdapter.Fill(Me.DbRekamMedisDataSet.users)
        DG.DefaultCellStyle.ForeColor = Color.Black
        db.koneksi()
        Call FormatGrid()
        Call TampilGrid()
        btnEdit.Visible = False
        btnHapus.Visible = False
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        tambah = True
        FormPengaturanOlah.Show()
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If DG.SelectedRows.Count > 0 Then
            tambah = False
            kd = DG.CurrentRow.Cells(0).Value
            FormPengaturanOlah.lblID.Text = kd
            FormPengaturanOlah.TextBox2.Text = DG.CurrentRow.Cells(1).Value
            FormPengaturanOlah.TextBox3.Text = DG.CurrentRow.Cells(2).Value
            FormPengaturanOlah.TextBox4.Text = DG.CurrentRow.Cells(3).Value
            FormPengaturanOlah.TextBox1.Text = DG.CurrentRow.Cells(3).Value
            FormPengaturanOlah.Show()
        Else
            MessageBox.Show("Anda Belum Memilih", "Data User", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If DG.SelectedRows.Count > 0 Then
            FormPesan.Button1.Text = "Ya"
            FormPesan.lblpesan2.Text = "Anda Yakin Menghapus"
            FormPesan.lblJudul.Text = "Hapus Data Rekam"
            FormPesan.lblPesan.Text = "'" & DG.CurrentRow.Cells(0).Value & "' ?"
            FormPesan.Show()
        Else
            MessageBox.Show("Anda Belum Memilih", "Data User", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Public Sub Pesan()
        Try
            kd = DG.CurrentRow.Cells(0).Value
            db.koneksi()
            Dim query = "delete from users where id = '" & kd & "'"
            Dim CMD As New SqlCommand(query, db.konek)
            CMD.ExecuteNonQuery()
            MsgBox("Berhasil Menghapus")
            Call TampilGrid()
            FormPesan.lblpesan2.Text = ""
            FormPesan.Close()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Olah(str As String)
        Try
            db.koneksi()
            Dim CMD As New SqlCommand(str, db.konek)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Berhasil Menyimpan", "Data User", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call TampilGrid()
            'MsgBox("Berhasil Menyimpan")

            FormPengaturanOlah.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub TampilGrid()
        Try
            DG.DataSource = Nothing
            DG.Refresh()
            db.koneksi()
            Dim query = "select * from users"
            Dim DA As New SqlDataAdapter(query, db.konek)
            Dim DS As New DataSet
            DA.Fill(DS)


            DG.DataSource = DS.Tables(0)
            DG.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Sub FormatGrid()
        Dim widthDG = DG.Width

        Dim widthClm As Integer = Fix((widthDG - 50) / 8)

        DG.Columns(0).Width = widthClm * 2
        DG.Columns(1).Width = widthClm * 3
        DG.Columns(2).Width = widthClm * 3
        'MsgBox("'" & widthDG & "'- '" & widthClm & "'")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call TampilGrid()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FormMain.Show()
        Me.Close()
    End Sub
    Private Sub picMin_Click(sender As Object, e As EventArgs) Handles picMin.Click
        Me.WindowState = WindowState.Minimized
        picClose.Left = Me.Width - picClose.Width - pnlLeft.Width - 8
        picMin.Left = Me.Width - picMin.Width - pnlLeft.Width - 36
        lblKasir.Left = (Me.Width / 2) - (lblKasir.Width / 2) - 28
    End Sub
    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Application.Exit()
    End Sub

    Private Sub pnlTop_Paint(sender As Object, e As PaintEventArgs) Handles pnlTop.Paint
        picClose.Left = Me.Width - picClose.Width - pnlLeft.Width - 8
        picMin.Left = Me.Width - picMin.Width - pnlLeft.Width - 36
        lblKasir.Left = (Me.Width / 2) - (lblKasir.Width / 2) - 28
    End Sub

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

    Private Sub DG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG.CellClick
        btnEdit.Visible = True
        btnHapus.Visible = True
    End Sub
End Class