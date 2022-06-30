Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf
Imports PdfSharp.Pdf.IO
Public Class FormPasien

    Public BeingDragged As Boolean = False
    Public MouseDownX As Integer
    Public MouseDownY As Integer
    Public tambah As Boolean

    Private Sub setLocation()
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
        Label1.Left = (Me.Width - Label1.Width) / 2
        Label2.Left = (Me.Width - Label2.Width) / 2
        PictureBox2.Left = Me.Width - PictureBox2.Width - 80
        picClose.Left = Me.Width - 30
        PicMin.Left = Me.Width - 60
        Panel1.Width = Me.Width
        Title.Left = (Me.Width - Title.Width) / 2

        'pnlPasien
        pnlPasien.Width = Me.Width - 60
        pnlPasien.Height = Me.Height - 220

        'btn Atas
        btnPrint.Left = pnlPasien.Width - 120
        btnTambah.Left = pnlPasien.Width - 240
        btnRefresh.Left = pnlPasien.Width - 360

        'Data Grid
        DG.Width = pnlPasien.Width - 60
        DG.Height = pnlPasien.Height - 120

        'btn bawah
        btnEdit.Top = pnlPasien.Height - 45
        btnHapus.Top = pnlPasien.Height - 45
        btnEdit.Left = pnlPasien.Width / 3
        btnHapus.Left = (pnlPasien.Width / 3) * 2 - 90

    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FormMain.Show()
        Me.Close()
    End Sub

    Private Sub picMin_Click(sender As Object, e As EventArgs) Handles PicMin.Click
        Me.WindowState = WindowState.Minimized

    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Dim result As DialogResult = MessageBox.Show("Tutup Aplikasi?", "AppRekamMedis", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub



    Dim db As New Database
    Dim dtTableGrid As dbRekamMedisDataSet.PasienDataTable

    Private Sub FormPasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call setLocation()

        DG.DefaultCellStyle.ForeColor = Color.Black
        db.koneksi()
        Call TampilGrid()
        Call FormatGrid()

        btnEdit.Visible = False
        btnHapus.Visible = False



    End Sub

    Private Sub txtCri_TextChanged(sender As Object, e As EventArgs) Handles txtCri.TextChanged
        db.koneksi()
        Dim query = "select * from pasien where idPasien like '%" & txtCri.Text & "%' or nama like '%" & txtCri.Text & "%' or noKTP like '%" & txtCri.Text & "%' order by idPasien asc"
        Dim DA As New SqlDataAdapter(query, db.konek)
        Dim DS As New DataSet
        DA.Fill(DS)

        DG.DataSource = DS.Tables(0)
        DG.Refresh()
        'dtTableGrid.DefaultView.RowFilter = "idPasien like '%" & txtCri.Text & "%' or nama like '%" & txtCri.Text & "%' or noKTP like '%" & txtCri.Text & "%'"
        'DG.DataSource = dtTableGrid
        'DG.Refresh()
    End Sub


    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        tambah = True
        FormPaseinEdit.Show()
    End Sub

    Dim kd As String
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If DG.SelectedRows.Count > 0 Then
            tambah = False
            kd = DG.CurrentRow.Cells(0).Value
            FormPaseinEdit.lblNoPendaftaran.Text = kd
            FormPaseinEdit.TextBox2.Text = DG.CurrentRow.Cells(1).Value
            FormPaseinEdit.TextBox3.Text = DG.CurrentRow.Cells(2).Value
            FormPaseinEdit.TextBox4.Text = DG.CurrentRow.Cells(3).Value
            FormPaseinEdit.TextBox5.Text = DG.CurrentRow.Cells(4).Value
            FormPaseinEdit.ComboBox1.Text = DG.CurrentRow.Cells(5).Value
            FormPaseinEdit.TextBox7.Text = DG.CurrentRow.Cells(6).Value
            FormPaseinEdit.TextBox8.Text = DG.CurrentRow.Cells(7).Value
            FormPaseinEdit.Show()
        Else
            MessageBox.Show("Anda Belum Memilih", "Data Pasien", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Dim frmPesan As New FormPesan
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If DG.SelectedRows.Count > 0 Then
            FormPesan.Button1.Text = "Ya"
            FormPesan.lblpesan2.Text = "Anda Yakin Menghapus"
            FormPesan.lblJudul.Text = "Hapus Data Pasien"
            FormPesan.lblPesan.Text = "'" & DG.CurrentRow.Cells(0).Value & "' ?"
            FormPesan.Show()
        Else
            MessageBox.Show("Anda Belum Memilih", "Data Pasien", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Public Sub Pesan()
        Dim kd As String
        Try
            kd = DG.CurrentRow.Cells(0).Value
            db.koneksi()
            Dim query = "delete from Pasien where idPasien = '" & kd & "'"
            Dim CMD As New SqlCommand(query, db.konek)
            CMD.ExecuteNonQuery()
            MsgBox("Berhasil Menghapus")
            Call TampilGrid()
            FormPesan.lblpesan2.Text = ""
            FormPesan.Close()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Edit(str As String)
        Try
            db.koneksi()
            Dim CMD As New SqlCommand(str, db.konek)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Berhasil Menyimpan", "Data Pasien", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call TampilGrid()
            'MsgBox("Berhasil Menyimpan")

            FormPaseinEdit.Close()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub TampilGrid()
        Try
            DG.DataSource = Nothing
            DG.Refresh()
            db.koneksi()
            Dim query = "select * from pasien order by idPasien desc"
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

        Dim widthClm As Integer = Fix((widthDG - 50) / 20)

        DG.Columns(0).MinimumWidth = 100
        DG.Columns(1).MinimumWidth = 100
        DG.Columns(2).MinimumWidth = 100
        DG.Columns(3).MinimumWidth = 100
        DG.Columns(4).MinimumWidth = 100
        DG.Columns(5).MinimumWidth = 100
        DG.Columns(6).MinimumWidth = 100
        DG.Columns(7).MinimumWidth = 100


        DG.Columns(1).HeaderText = "No KTP"
        DG.Columns(2).HeaderText = "Nama Pemilik"
        DG.Columns(3).HeaderText = "Nama Hewan"
        DG.Columns(4).HeaderText = "Jenis Hewan"
        DG.Columns(5).HeaderText = "Jenis Kelamin Hewan"
        DG.Columns(6).HeaderText = "Alamat"
        DG.Columns(7).HeaderText = "No Telepon"

        DG.Columns(0).Width = widthClm * 2
        DG.Columns(1).Width = widthClm * 3
        DG.Columns(2).Width = widthClm * 4
        DG.Columns(3).Width = widthClm * 2
        DG.Columns(4).Width = widthClm
        DG.Columns(5).Width = widthClm
        DG.Columns(6).Width = widthClm * 5
        DG.Columns(7).Width = widthClm * 2

        'MsgBox("'" & widthDG & "'- '" & widthClm & "'")
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call TampilGrid()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If DG.RowCount > 0 Then

            Call ExportPdf()
        Else
            MessageBox.Show("Maaf Data Tidak Tersedia", "Data Pasien", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Dim x, y, q, w, h As Double

    Public graph As XGraphics
    Public pdf As PdfDocument
    Public page As PdfPage

    Public Sub createPage()
        page = pdf.AddPage
        page.Size = PageSize.A4
        page.Orientation = PageOrientation.Landscape
        graph = XGraphics.FromPdfPage(page)
    End Sub


    Public Sub ExportPdf()


        pdf = New PdfDocument
        Call createPage()


        Call pdfHeader()
        Call pdfBody()
        'Call pdfFooter()

        Try
            Dim pdfFilename As String = "DataPasien.pdf"


            Dim filePath As String
            Dim dir = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "/AppRekamMedis"

            If Not Directory.Exists(dir) Then
                Directory.CreateDirectory(dir)
            End If

            filePath = Path.Combine(dir, pdfFilename)

            pdf.Save(filePath)
            Process.Start(filePath)

        Catch ex As Exception
            Throw ex
        End Try




    End Sub

    Sub pdfHeader()
        Dim logoPath = db.appPath & "\logo.png"
        Dim image As XImage = XImage.FromFile(logoPath)
        q = XUnit.FromCentimeter(1)
        Dim font1 = New XFont("Times", 12)
        Dim fontH1 = New XFont("Times", 18, XFontStyle.Bold)
        Dim fontH2 = New XFont("Times", 9, XFontStyle.Bold)

        x = 0
        y = q * 3.6
        Dim l1 As Double = font1.Height
        Dim lH1 As Double = fontH1.Height
        Dim format = New XStringFormat()


        w = page.Width
        Dim c = (w - (q * 2)) / 2


        graph.DrawImage(image, c, q, q * 2, q * 2.4)

        format.Alignment = XStringAlignment.Center
        graph.DrawString("PEMERINTAH KOTA PALOPO",
                         font1, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
        y += l1
        graph.DrawString("DINAS PERTANIAN PETERNAKAN DAN PERKEBUMAN",
                         font1, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
        y += l1
        graph.DrawString("PUSKESWAN PALOPO",
                         fontH1, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
        y += lH1
        graph.DrawString("Jln. Veteran No. 39 Telp / Fax (0471)21019 Palopo",
                         fontH2, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
        y += lH1
        Dim pen = New XPen(XColors.Black, 4)
        Dim ujng = w - (q * 2)
        graph.DrawLine(pen, q * 2, y, ujng, y)
        y += 12
    End Sub
    Sub pdfBody()
        Dim q = 28.3
        Dim fontTitle = New XFont("Times", 12, XFontStyle.Bold Or XFontStyle.Underline)
        Dim fontParagraph = New XFont("Times", 12)
        Dim fontMini = New XFont("Times", 10.5)
        Dim l1 As Double = fontTitle.Height
        Dim format = New XStringFormat


        w = page.Width
        h = page.Height

        format.Alignment = XStringAlignment.Center
        graph.DrawString("DATA PASIEN",
                         fontTitle, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
        y += l1 + 10

        Dim mEl = (w - (q * 1.7)) / 70
        'row element
        Dim el1_width = mEl * 2
        Dim el2_width = mEl * 6
        Dim el3_width = mEl * 9
        Dim el4_width = mEl * 12
        Dim el5_width = mEl * 6
        Dim el6_width = mEl * 6
        Dim el7_width = mEl * 6
        Dim el8_width = mEl * 15
        Dim el9_width = mEl * 8

        'page structure options
        Dim lineHeight = 20
        Dim marginLeft = q * 0.85
        Dim marginTop = y

        Dim el_height = 20
        Dim rectH_height = 51 - 8
        Dim rect_height = 17 - 5

        Dim offSetX_1 = el1_width
        Dim offSetX_2 = el1_width + el2_width
        Dim offSetX_3 = offSetX_2 + el3_width
        Dim offSetX_4 = offSetX_3 + el4_width
        Dim offSetX_5 = offSetX_4 + el5_width
        Dim offSetX_6 = offSetX_5 + el6_width
        Dim offSetX_7 = offSetX_6 + el7_width
        Dim offSetX_8 = offSetX_7 + el8_width


        Dim rect_style1 = New XSolidBrush(XColors.White)
        Dim rect_style2 = New XSolidBrush(XColors.DarkGreen)
        Dim rect_style3 = New XSolidBrush(XColors.Red)
        Dim d = 0
        Dim i = 0
        Dim n As Boolean = False

        db.koneksi()
        Dim query = "SELECT * From Pasien"
        Dim DA As New SqlDataAdapter(query, db.konek)
        Dim DS As New DataSet
        DA.Fill(DS)

        Dim pen2 = New XPen(XColors.Black, 1)
        graph.DrawRectangle(rect_style2, marginLeft, marginTop, w - 2 * marginLeft, rectH_height)

        graph.DrawRectangle(pen2, marginLeft, marginTop, w - 2 * marginLeft, rectH_height)
        graph.DrawLine(pen2, marginLeft + offSetX_1, marginTop, marginLeft + offSetX_1, marginTop + rectH_height)
        graph.DrawLine(pen2, marginLeft + offSetX_2, marginTop, marginLeft + offSetX_2, marginTop + rectH_height)
        graph.DrawLine(pen2, marginLeft + offSetX_3, marginTop, marginLeft + offSetX_3, marginTop + rectH_height)
        graph.DrawLine(pen2, marginLeft + offSetX_4, marginTop, marginLeft + offSetX_4, marginTop + rectH_height)
        graph.DrawLine(pen2, marginLeft + offSetX_5, marginTop, marginLeft + offSetX_5, marginTop + rectH_height)
        graph.DrawLine(pen2, marginLeft + offSetX_6, marginTop, marginLeft + offSetX_6, marginTop + rectH_height)
        graph.DrawLine(pen2, marginLeft + offSetX_7, marginTop, marginLeft + offSetX_7, marginTop + rectH_height)
        graph.DrawLine(pen2, marginLeft + offSetX_8, marginTop, marginLeft + offSetX_8, marginTop + rectH_height)



        graph.DrawString("No", fontParagraph, XBrushes.White,
                              New XRect(marginLeft, marginTop + rect_height, el1_width, el_height), format)
        graph.DrawString("No", fontParagraph, XBrushes.White,
                              New XRect(marginLeft + offSetX_1, marginTop + (rect_height / 2), el2_width, el_height), format)
        graph.DrawString("Pendaftaran", fontParagraph, XBrushes.White,
                              New XRect(marginLeft + offSetX_1, marginTop + rect_height + (rect_height / 2), el2_width, el_height), format)
        graph.DrawString("No KTP", fontParagraph, XBrushes.White,
                              New XRect(marginLeft + offSetX_2, marginTop + rect_height, el3_width, el_height), format)
        graph.DrawString("Nama Pemilik", fontParagraph, XBrushes.White,
                              New XRect(marginLeft + offSetX_3, marginTop + rect_height, el4_width, el_height), format)
        graph.DrawString("Nama", fontParagraph, XBrushes.White,
                              New XRect(marginLeft + offSetX_4, marginTop + (rect_height / 2), el5_width, el_height), format)
        graph.DrawString("Hewan", fontParagraph, XBrushes.White,
                              New XRect(marginLeft + offSetX_4, marginTop + rect_height + (rect_height / 2), el5_width, el_height), format)
        graph.DrawString("Jenis", fontParagraph, XBrushes.White,
                              New XRect(marginLeft + offSetX_5, marginTop + (rect_height / 2), el6_width, el_height), format)
        graph.DrawString("Hewan", fontParagraph, XBrushes.White,
                              New XRect(marginLeft + offSetX_5, marginTop + rect_height + (rect_height / 2), el6_width, el_height), format)
        graph.DrawString("Jenis", fontParagraph, XBrushes.White,
                              New XRect(marginLeft + offSetX_6, marginTop, el7_width, el_height), format)
        graph.DrawString("Kelamin", fontParagraph, XBrushes.White,
                              New XRect(marginLeft + offSetX_6, marginTop + rect_height, el7_width, el_height), format)
        graph.DrawString("Hewan", fontParagraph, XBrushes.White,
                              New XRect(marginLeft + offSetX_6, marginTop + rect_height + rect_height, el7_width, el_height), format)
        graph.DrawString("Alamat", fontParagraph, XBrushes.White,
                              New XRect(marginLeft + offSetX_7, marginTop + rect_height, el8_width, el_height), format)
        graph.DrawString("No Telepon", fontParagraph, XBrushes.White,
                              New XRect(marginLeft + offSetX_8, marginTop + rect_height, el9_width, el_height), format)

        For Each row As DataRow In DS.Tables(0).Rows
            Dim dist_Y = lineHeight * (d)
            Dim dist_Y2 = dist_Y
            y = dist_Y2
            pen2 = New XPen(XColors.Black, 1)

            Dim tf = New Layout.XTextFormatter(graph)

            format.LineAlignment = XLineAlignment.Center

            'ELEMENT 1 - SMALL 80
            graph.DrawString(
                            " " & i & ".",
                            fontParagraph,
                            XBrushes.Black,
                            New XRect(marginLeft, marginTop + rectH_height + dist_Y, el1_width, el_height),
                            format)

            'ELEMENT 2 - BIG 380
            graph.DrawString(
                        row("idPasien").ToString,
                        fontParagraph,
                        XBrushes.Black,
                        New XRect(marginLeft + offSetX_1, marginTop + rectH_height + dist_Y, el2_width, el_height),
                        format)
            'ELEMENT 3 - SMALL 80
            graph.DrawString(
            row("noKTP").ToString,
                        fontParagraph,
                        XBrushes.Black,
                        New XRect(marginLeft + offSetX_2, marginTop + rectH_height + dist_Y, el3_width, el_height),
                        format)
            graph.DrawString(
            row("nama").ToString,
                        fontParagraph,
                        XBrushes.Black,
                        New XRect(marginLeft + offSetX_3, marginTop + rectH_height + dist_Y, el4_width, el_height),
                        format)
            graph.DrawString(
            row("namaHewan").ToString,
                        fontParagraph,
                        XBrushes.Black,
                        New XRect(marginLeft + offSetX_4, marginTop + rectH_height + dist_Y, el5_width, el_height),
                        format)
            graph.DrawString(
            row("jenisHewan").ToString,
                        fontParagraph,
                        XBrushes.Black,
                        New XRect(marginLeft + offSetX_5, marginTop + rectH_height + dist_Y, el6_width, el_height),
                        format)
            graph.DrawString(
            row("jkHewan").ToString,
                        fontParagraph,
                        XBrushes.Black,
                        New XRect(marginLeft + offSetX_6, marginTop + rectH_height + dist_Y, el7_width, el_height),
                        format)
            tf.DrawString(
                row("alamat").ToString,
                            fontMini,
                            XBrushes.Black,
                            New XRect(marginLeft + offSetX_7 + 2, marginTop + rectH_height + dist_Y, el8_width, el_height),
                            XStringFormat.TopLeft)
            graph.DrawString(
                row("noTelepon").ToString,
                            fontParagraph,
                            XBrushes.Black,
                            New XRect(marginLeft + offSetX_8, marginTop + rectH_height + dist_Y, el9_width, el_height),
                            format)

            pen2 = New XPen(XColors.Black, 1)
            graph.DrawLine(pen2, marginLeft, marginTop + rectH_height + dist_Y, marginLeft, marginTop + rectH_height + dist_Y + lineHeight)
            graph.DrawLine(pen2, marginLeft + offSetX_1, marginTop + rectH_height + dist_Y, marginLeft + offSetX_1, marginTop + rectH_height + dist_Y + lineHeight)
            graph.DrawLine(pen2, marginLeft + offSetX_2, marginTop + rectH_height + dist_Y, marginLeft + offSetX_2, marginTop + rectH_height + dist_Y + lineHeight)
            graph.DrawLine(pen2, marginLeft + offSetX_3, marginTop + rectH_height + dist_Y, marginLeft + offSetX_3, marginTop + rectH_height + dist_Y + lineHeight)
            graph.DrawLine(pen2, marginLeft + offSetX_4, marginTop + rectH_height + dist_Y, marginLeft + offSetX_4, marginTop + rectH_height + dist_Y + lineHeight)
            graph.DrawLine(pen2, marginLeft + offSetX_5, marginTop + rectH_height + dist_Y, marginLeft + offSetX_5, marginTop + rectH_height + dist_Y + lineHeight)
            graph.DrawLine(pen2, marginLeft + offSetX_6, marginTop + rectH_height + dist_Y, marginLeft + offSetX_6, marginTop + rectH_height + dist_Y + lineHeight)
            graph.DrawLine(pen2, marginLeft + offSetX_7, marginTop + rectH_height + dist_Y, marginLeft + offSetX_7, marginTop + rectH_height + dist_Y + lineHeight)
            graph.DrawLine(pen2, marginLeft + offSetX_8, marginTop + rectH_height + dist_Y, marginLeft + offSetX_8, marginTop + rectH_height + dist_Y + lineHeight)
            graph.DrawLine(pen2, marginLeft + offSetX_8 + el9_width, marginTop + rectH_height + dist_Y, marginLeft + offSetX_8 + el9_width, marginTop + rectH_height + dist_Y + lineHeight)
            graph.DrawLine(pen2, marginLeft, marginTop + rectH_height + dist_Y + lineHeight, marginLeft + offSetX_8 + el9_width, marginTop + rectH_height + dist_Y + lineHeight)

            If n = True Then
                n = False
                graph.DrawLine(pen2, marginLeft, marginTop + rectH_height + dist_Y, marginLeft + offSetX_8 + el9_width, marginTop + rectH_height + dist_Y)
            End If
            If (dist_Y + rectH_height + lineHeight + marginTop) > (h - q) Then
                Call createPage()
                d = 1
                marginTop = q - (lineHeight * 4)
                n = True
            Else
                d += 1
            End If

            i += 1
        Next

    End Sub

    Sub pdfFooter()
        q = XUnit.FromCentimeter(1)
        Dim font1 = New XFont("Times", 12)
        Dim fontH1 = New XFont("Times", 18, XFontStyle.Bold)
        Dim fontH2 = New XFont("Times", 9, XFontStyle.Bold)

        x = 0
        y = y + (q * 1.5)
        Dim l1 As Double = font1.Height
        Dim lH1 As Double = fontH1.Height
        Dim format = New XStringFormat()

        w = page.Width
    End Sub

    Private Sub DG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG.CellClick
        btnEdit.Visible = True
        btnHapus.Visible = True
    End Sub

End Class