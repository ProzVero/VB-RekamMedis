Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf
Imports PdfSharp.Pdf.IO
Public Class FormRekam
    Dim BeingDragged As Boolean = False
    Dim MouseDownX As Integer
    Dim MouseDownY As Integer
    Dim db As New Database
    Dim dtTableGrid As dbRekamMedisDataSet1.rekamDataTable
    Dim kd As String
    Public tambah As Boolean = False

    Private Sub setLocation()
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        WindowState = FormWindowState.Maximized
        Label1.Left = (Me.Width - Label1.Width) / 2
        Label2.Left = (Me.Width - Label2.Width) / 2
        PictureBox2.Left = Me.Width - PictureBox2.Width - 100
        picClose.Left = Me.Width - 30
        PicMin.Left = Me.Width - 60
        Panel1.Width = Me.Width
        Title.Left = (Me.Width - Title.Width) / 2

        'pnlRekam
        pnlRekam.Width = Me.Width - 60
        pnlRekam.Height = Me.Height - 220

        'btn Atas
        btnPrint.Left = pnlRekam.Width - 120
        btnTambah.Left = pnlRekam.Width - 240
        btnRefresh.Left = pnlRekam.Width - 360

        'Data Grid
        DG.Width = pnlRekam.Width - 60
        DG.Height = pnlRekam.Height - 120

        'btn bawah
        btnEdit.Top = pnlRekam.Height - 45
        btnHapus.Top = pnlRekam.Height - 45
        btnEdit.Left = pnlRekam.Width / 3
        btnHapus.Left = (pnlRekam.Width / 3) * 2 - 90

    End Sub
    Private Sub FormRekam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbRekamMedisDataSet1.rekam' table. You can move, or remove it, as needed.
        'Me.RekamTableAdapter1.Fill(Me.DbRekamMedisDataSet1.rekam)
        'TODO: This line of code loads data into the 'DbRekamMedisDataSet1.rekam' table. You can move, or remove it, as needed.
        'Me.RekamTableAdapter.Fill(Me.DbRekamMedisDataSet1.rekam)
        Call setLocation()
        dtTableGrid = Me.DbRekamMedisDataSet1.rekam
        DG.DefaultCellStyle.ForeColor = Color.Black
        db.koneksi()
        Call FormatGrid()
        Call TampilGrid()
        btnEdit.Visible = False
        btnHapus.Visible = False
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        tambah = True
        FormRekamOlah.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        tambah = False
        If DG.SelectedRows.Count > 0 Then
            tambah = False
            kd = DG.CurrentRow.Cells(0).Value
            FormRekamOlah.lblNoRekam.Text = kd
            FormRekamOlah.TextBox2.Text = DG.CurrentRow.Cells(1).Value
            FormRekamOlah.TextBox3.Text = DG.CurrentRow.Cells(2).Value
            FormRekamOlah.TextBox4.Text = DG.CurrentRow.Cells(3).Value
            FormRekamOlah.TextBox5.Text = DG.CurrentRow.Cells(4).Value
            FormRekamOlah.TextBox6.Text = DG.CurrentRow.Cells(5).Value
            FormRekamOlah.TextBox7.Text = DG.CurrentRow.Cells(6).Value
            FormRekamOlah.Show()
        Else
            MessageBox.Show("Anda Belum Memilih", "Data Pasien", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

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
        Try
            kd = DG.CurrentRow.Cells(0).Value
            db.koneksi()
            Dim query = "delete from Rekam where idRekam = '" & kd & "'"
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
            MessageBox.Show("Berhasil Menyimpan", "Data Rekam", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call TampilGrid()
            'MsgBox("Berhasil Menyimpan")

            FormRekamOlah.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TampilGrid()
        Try

            DG.DataSource = Nothing
            DG.Refresh()
            db.koneksi()
            Dim query = "select * from Rekam order by idRekam desc"
            Dim DA As New SqlDataAdapter(query, db.konek)
            Dim DS As New DataSet
            DA.Fill(DS)


            DG.DataSource = DS.Tables(0)
            DG.Refresh()

            dtTableGrid = Me.DbRekamMedisDataSet1.rekam
        Catch ex As Exception

        End Try
    End Sub

    Sub FormatGrid()
        Dim widthDG = DG.Width

        Dim widthClm As Integer = Fix((widthDG - 50) / 22)

        DG.Columns(0).MinimumWidth = 100
        DG.Columns(1).MinimumWidth = 100
        DG.Columns(2).MinimumWidth = 100
        DG.Columns(3).MinimumWidth = 100
        DG.Columns(4).MinimumWidth = 100
        DG.Columns(5).MinimumWidth = 100
        DG.Columns(6).MinimumWidth = 100

        DG.Columns(3).HeaderText = "Gejala"
        DG.Columns(4).HeaderText = "Diagnosa"
        DG.Columns(5).HeaderText = "Pengobatan"
        DG.Columns(6).HeaderText = "Ket.(Drh./Paravet)"

        DG.Columns(0).Width = widthClm * 2
        DG.Columns(1).Width = widthClm * 2
        DG.Columns(2).Width = widthClm * 4
        DG.Columns(3).Width = widthClm * 4
        DG.Columns(4).Width = widthClm * 4
        DG.Columns(5).Width = widthClm * 4
        DG.Columns(6).Width = widthClm * 3
        'MsgBox("'" & widthDG & "'- '" & widthClm & "'")
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call TampilGrid()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If DG.ColumnCount > 0 Then

            Call ExportPdf()
        Else
            MessageBox.Show("Maaf data tidak tersedia", "Data Rekam", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txtCri_TextChanged(sender As Object, e As EventArgs) Handles txtCri.TextChanged
        dtTableGrid.DefaultView.RowFilter = "idRekam like '%" & txtCri.Text & "%' or idPasien like '%" & txtCri.Text & "%'"
        DG.DataSource = dtTableGrid
        DG.Refresh()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FormMain.Show()
        Me.Close()
    End Sub

    Private Sub picMin_Click(sender As Object, e As EventArgs) Handles PicMin.Click
        Me.WindowState = WindowState.Minimized
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
        Call pdfFooter()

        Try
            Dim pdfFilename As String = "DataRekamMedis.pdf"


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

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Dim result As DialogResult = MessageBox.Show("Tutup Aplikasi?", "AppRekamMedis", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
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
        graph.DrawString("DATA REKAM MEDIS",
                         fontTitle, XBrushes.Black, New XRect(x, y, page.Width, page.Height), format)
        y += l1 + 10

        Dim mEl = (w - (q * 1.7)) / 56
        'row element
        Dim el1_width = mEl * 2
        Dim el2_width = mEl * 5
        Dim el3_width = mEl * 5
        Dim el4_width = mEl * 6
        Dim el5_width = mEl * 6
        Dim el6_width = mEl * 6
        Dim el7_width = mEl * 6
        Dim el8_width = mEl * 13
        Dim el9_width = mEl * 7

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
        Dim offSetX_9 = offSetX_8 + el9_width


        Dim rect_style1 = New XSolidBrush(XColors.White)
        Dim rect_style2 = New XSolidBrush(XColors.DarkGreen)
        Dim rect_style3 = New XSolidBrush(XColors.Red)
        Dim d = 0
        Dim i = 1
        Dim n As Boolean = False

        db.koneksi()
        Dim query = "SELECT * From Rekam"
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
        graph.DrawString("No Rekam", fontParagraph, XBrushes.White,
                              New XRect(marginLeft + offSetX_1, marginTop + rect_height, el2_width, el_height), format)
        graph.DrawString("No ", fontParagraph, XBrushes.White,
                              New XRect(marginLeft + offSetX_2, marginTop + (rect_height / 2), el3_width, el_height), format)
        graph.DrawString("Pendaftaran", fontParagraph, XBrushes.White,
                              New XRect(marginLeft + offSetX_2, marginTop + rect_height + (rect_height / 2), el3_width, el_height), format)
        graph.DrawString("Anamnesa", fontParagraph, XBrushes.White,
                              New XRect(marginLeft + offSetX_3, marginTop + rect_height, el4_width, el_height), format)
        graph.DrawString("Gejala", fontParagraph, XBrushes.White,
                              New XRect(marginLeft + offSetX_4, marginTop + rect_height, el5_width, el_height), format)
        graph.DrawString("Diagnosa", fontParagraph, XBrushes.White,
                              New XRect(marginLeft + offSetX_5, marginTop + rect_height, el6_width, el_height), format)
        graph.DrawString("Pengobatan", fontParagraph, XBrushes.White,
                              New XRect(marginLeft + offSetX_6, marginTop + rect_height, el7_width, el_height), format)
        graph.DrawString("Ket", fontParagraph, XBrushes.White,
                              New XRect(marginLeft + offSetX_7, marginTop + rect_height, el8_width, el_height), format)
        graph.DrawString("Tanggal", fontParagraph, XBrushes.White,
                              New XRect(marginLeft + offSetX_8, marginTop + rect_height, el9_width, el_height), format)
        Dim dist_Y As Double = 0.0
        For Each row As DataRow In DS.Tables(0).Rows
            pen2 = New XPen(XColors.Black, 1)

            Dim tf = New Layout.XTextFormatter(graph)

            Dim txt = row("ket").ToString
            Dim tfHeight = MeasureHeight(graph, txt, fontMini, el8_width)

            Dim txtAnamnesa = row("anamnesa").ToString
            Dim txtGejala = row("gejala").ToString
            Dim txtDiagnosa = row("diagnosa").ToString
            Dim txtPengobatan = row("pengobatan").ToString

            Dim htAnamnesa = MeasureHeight(graph, txtAnamnesa, fontMini, el4_width)
            Dim htGejala = MeasureHeight(graph, txtGejala, fontMini, el5_width)
            Dim htDiagnosa = MeasureHeight(graph, txtDiagnosa, fontMini, el6_width)
            Dim htPengobatan = MeasureHeight(graph, txtPengobatan, fontMini, el7_width)

            format.LineAlignment = XLineAlignment.Center

            If htAnamnesa > htGejala And htAnamnesa > htDiagnosa And htAnamnesa > htPengobatan Then
                el_height = htAnamnesa + 5
            End If

            If htAnamnesa < htGejala And htGejala > htDiagnosa And htGejala > htPengobatan Then
                el_height = htGejala + 5
            End If

            If htDiagnosa > htGejala And htAnamnesa < htDiagnosa And htDiagnosa > htPengobatan Then
                el_height = htDiagnosa + 5
            End If

            If htPengobatan > htGejala And htPengobatan > htDiagnosa And htAnamnesa < htPengobatan Then
                el_height = htPengobatan + 5
            End If

            Dim tdAli = New Layout.XParagraphAlignment
            tf.Alignment = tdAli.Left

            graph.DrawString(
                            " " & i & ".",
                            fontMini,
                            XBrushes.Black,
                            New XRect(marginLeft, marginTop + rectH_height + dist_Y, el1_width, el_height),
                            format)


            graph.DrawString(
                        row("idRekam").ToString,
                        fontMini,
                        XBrushes.Black,
                        New XRect(marginLeft + offSetX_1, marginTop + rectH_height + dist_Y, el2_width, el_height),
                        format)

            graph.DrawString(
                        row("idPasien").ToString,
                        fontMini,
                        XBrushes.Black,
                        New XRect(marginLeft + offSetX_2, marginTop + rectH_height + dist_Y, el3_width, el_height),
                        format)
            tf.DrawString(
                row("anamnesa").ToString,
                         fontMini,
                XBrushes.Black,
                New XRect(marginLeft + offSetX_3 + 2, marginTop + rectH_height + dist_Y + 2, el4_width, el_height), XStringFormat.TopLeft)
            tf.DrawString(
                row("gejala").ToString,
                         fontMini,
                XBrushes.Black,
                New XRect(marginLeft + offSetX_4 + 2, marginTop + rectH_height + dist_Y + 2, el5_width, el_height), XStringFormat.TopLeft)
            tf.DrawString(
                row("diagnosa").ToString,
                         fontMini,
                XBrushes.Black,
                New XRect(marginLeft + offSetX_5 + 2, marginTop + rectH_height + dist_Y + 2, el6_width, el_height), XStringFormat.TopLeft)
            tf.DrawString(
                row("pengobatan").ToString,
                         fontMini,
                XBrushes.Black,
                New XRect(marginLeft + offSetX_6 + 2, marginTop + rectH_height + dist_Y + 2, el7_width, el_height), XStringFormat.TopLeft)

            tf.DrawString(
                    row("ket").ToString,
                            fontMini,
                            XBrushes.Black,
                            New XRect(marginLeft + offSetX_7 + 2, marginTop + rectH_height + dist_Y, el8_width - 4, el_height),
                            XStringFormat.TopLeft)

            'Dim dtDateTime As DateTime = New DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc)
            'Dim value As Long
            'value = Convert.ToInt64((row("tgl").ToString))
            'dtDateTime = dtDateTime.AddMilliseconds(value).ToLocalTime()

            'graph.DrawString(
            'dtDateTime.ToString("dd/MM/yyyy HH:mm"),
            'fontMini,
            'XBrushes.Black,
            ' New XRect(marginLeft + offSetX_8, marginTop + rectH_height + dist_Y, el9_width, el_height),
            'format)
            graph.DrawString(
            row("tgl").ToString,
                        fontMini,
                        XBrushes.Black,
                        New XRect(marginLeft + offSetX_8, marginTop + rectH_height + dist_Y, el9_width, el_height),
                        format)


            pen2 = New XPen(XColors.Black, 1)
            graph.DrawLine(pen2, marginLeft, marginTop + rectH_height + dist_Y, marginLeft, marginTop + rectH_height + dist_Y + el_height)
            graph.DrawLine(pen2, marginLeft + offSetX_1, marginTop + rectH_height + dist_Y, marginLeft + offSetX_1, marginTop + rectH_height + dist_Y + el_height)
            graph.DrawLine(pen2, marginLeft + offSetX_2, marginTop + rectH_height + dist_Y, marginLeft + offSetX_2, marginTop + rectH_height + dist_Y + el_height)
            graph.DrawLine(pen2, marginLeft + offSetX_3, marginTop + rectH_height + dist_Y, marginLeft + offSetX_3, marginTop + rectH_height + dist_Y + el_height)
            graph.DrawLine(pen2, marginLeft + offSetX_4, marginTop + rectH_height + dist_Y, marginLeft + offSetX_4, marginTop + rectH_height + dist_Y + el_height)
            graph.DrawLine(pen2, marginLeft + offSetX_5, marginTop + rectH_height + dist_Y, marginLeft + offSetX_5, marginTop + rectH_height + dist_Y + el_height)
            graph.DrawLine(pen2, marginLeft + offSetX_6, marginTop + rectH_height + dist_Y, marginLeft + offSetX_6, marginTop + rectH_height + dist_Y + el_height)
            graph.DrawLine(pen2, marginLeft + offSetX_7, marginTop + rectH_height + dist_Y, marginLeft + offSetX_7, marginTop + rectH_height + dist_Y + el_height)
            graph.DrawLine(pen2, marginLeft + offSetX_8, marginTop + rectH_height + dist_Y, marginLeft + offSetX_8, marginTop + rectH_height + dist_Y + el_height)
            graph.DrawLine(pen2, marginLeft + offSetX_8 + el9_width, marginTop + rectH_height + dist_Y, marginLeft + offSetX_8 + el9_width, marginTop + rectH_height + dist_Y + el_height)
            graph.DrawLine(pen2, marginLeft, marginTop + rectH_height + dist_Y + el_height, marginLeft + offSetX_8 + el9_width, marginTop + rectH_height + dist_Y + el_height)

            If n = True Then
                n = False
                graph.DrawLine(pen2, marginLeft, marginTop + rectH_height + dist_Y, marginLeft + offSetX_8 + el9_width, marginTop + rectH_height + dist_Y)
            End If
            If (dist_Y + rectH_height + el_height + marginTop) > (h - q) Then
                Call createPage()
                d = 1
                dist_Y = 0
                marginTop = -14 ' - (lineHeight * 4)
                n = True
            Else
                d += 1
            End If

            i += 1
            dist_Y += el_height
            y = dist_Y + rectH_height + el_height + marginTop
            'Console.WriteLine(dist_Y)
            'Console.WriteLine(y)
        Next

    End Sub

    Sub pdfFooter()
        q = XUnit.FromCentimeter(1)
        Dim c = q * 4
        Dim a = y + c
        Dim b = h - q
        If a > b Then
            Call createPage()
            y = q * 1
        End If
        w = page.Width
        h = page.Height
        Dim width = w / 5
        Dim format = New XStringFormat

        Dim f1 = New XFont("Times", 12)
        Dim f2 = New XFont("Times", 12, XFontStyle.Bold Or XFontStyle.Underline)
        Dim txtTTD = "Kepala Seksi Pengendalian dan pencegahan penyakit hewan,"
        Dim txtNama = "Drh. RAHMI, S.KH."
        Dim txtNIP = "NIP. 19830410 201101 2 041"

        Dim htTTD = MeasureHeight(graph, txtTTD, f1, width)

        x = 0
        Dim lf1 As Double = f1.Height
        Dim lf2 As Double = f2.Height



        Dim tf = New Layout.XTextFormatter(graph)
        Dim tdAli = New Layout.XParagraphAlignment
        tf.Alignment = tdAli.Justify


        tf.DrawString(txtTTD, f1, XBrushes.Black, New XRect(w - width - (q * 1), y, width, htTTD + 5), XStringFormat.TopLeft)
        y += htTTD * 3
        format.Alignment = XStringAlignment.Near
        graph.DrawString(txtNama,
                         f2, XBrushes.Black, New XRect(w - width - (q * 1), y, width, lf2 + 5), format)
        y += lf2
        graph.DrawString(txtNIP,
                         f1, XBrushes.Black, New XRect(w - width - (q * 1), y, width, lf1 + 5), format)
    End Sub

    Private Function MeasureHeight(gfx As XGraphics, text As String, font As XFont, width As Integer) As Double
        Dim lines = text.Split(vbLf)
        Dim totalHeight As Double = 0
        Dim x = 0
        For Each line As String In lines
            ' Console.WriteLine(line)
            Dim size = gfx.MeasureString(line, font)
            Dim height As Double = size.Height + (size.Height * Math.Floor(size.Width / width))
            totalHeight += height

            'Console.WriteLine(size.Height & "*" & size.Width & "/" & width & "=" & height & "-" & totalHeight)
        Next
        Return totalHeight
    End Function

    Private Sub DG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG.CellClick
        btnEdit.Visible = True
        btnHapus.Visible = True
    End Sub

End Class