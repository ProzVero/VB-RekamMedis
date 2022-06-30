<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLaporan))
        Me.DG2 = New System.Windows.Forms.DataGridView()
        Me.IdRekamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnamnesaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GejalaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiagnosaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PengobatanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RekamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbRekamMedisDataSet1 = New AppRekamMedis.dbRekamMedisDataSet1()
        Me.DG1 = New System.Windows.Forms.DataGridView()
        Me.IdPasienDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoKTPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaHewanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisHewanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JkHewanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoTeleponDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasienBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PasienTableAdapter = New AppRekamMedis.dbRekamMedisDataSet1TableAdapters.PasienTableAdapter()
        Me.RekamTableAdapter = New AppRekamMedis.dbRekamMedisDataSet1TableAdapters.rekamTableAdapter()
        Me.Title = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PicMin = New System.Windows.Forms.PictureBox()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlLaporan = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtCri = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.DG2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RekamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbRekamMedisDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasienBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLaporan.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'DG2
        '
        Me.DG2.AllowUserToAddRows = False
        Me.DG2.AllowUserToDeleteRows = False
        Me.DG2.AutoGenerateColumns = False
        Me.DG2.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DG2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdRekamDataGridViewTextBoxColumn, Me.AnamnesaDataGridViewTextBoxColumn, Me.GejalaDataGridViewTextBoxColumn, Me.DiagnosaDataGridViewTextBoxColumn, Me.PengobatanDataGridViewTextBoxColumn, Me.KetDataGridViewTextBoxColumn, Me.TglDataGridViewTextBoxColumn})
        Me.DG2.DataSource = Me.RekamBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DG2.EnableHeadersVisualStyles = False
        Me.DG2.Location = New System.Drawing.Point(30, 253)
        Me.DG2.Name = "DG2"
        Me.DG2.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG2.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DG2.Size = New System.Drawing.Size(780, 175)
        Me.DG2.TabIndex = 2
        '
        'IdRekamDataGridViewTextBoxColumn
        '
        Me.IdRekamDataGridViewTextBoxColumn.DataPropertyName = "IdRekam"
        Me.IdRekamDataGridViewTextBoxColumn.HeaderText = "No Rekam"
        Me.IdRekamDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.IdRekamDataGridViewTextBoxColumn.Name = "IdRekamDataGridViewTextBoxColumn"
        Me.IdRekamDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AnamnesaDataGridViewTextBoxColumn
        '
        Me.AnamnesaDataGridViewTextBoxColumn.DataPropertyName = "anamnesa"
        Me.AnamnesaDataGridViewTextBoxColumn.HeaderText = "Anamnesa"
        Me.AnamnesaDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.AnamnesaDataGridViewTextBoxColumn.Name = "AnamnesaDataGridViewTextBoxColumn"
        Me.AnamnesaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GejalaDataGridViewTextBoxColumn
        '
        Me.GejalaDataGridViewTextBoxColumn.DataPropertyName = "gejala"
        Me.GejalaDataGridViewTextBoxColumn.HeaderText = "Gejala"
        Me.GejalaDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.GejalaDataGridViewTextBoxColumn.Name = "GejalaDataGridViewTextBoxColumn"
        Me.GejalaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiagnosaDataGridViewTextBoxColumn
        '
        Me.DiagnosaDataGridViewTextBoxColumn.DataPropertyName = "diagnosa"
        Me.DiagnosaDataGridViewTextBoxColumn.HeaderText = "Diagnosa"
        Me.DiagnosaDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.DiagnosaDataGridViewTextBoxColumn.Name = "DiagnosaDataGridViewTextBoxColumn"
        Me.DiagnosaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PengobatanDataGridViewTextBoxColumn
        '
        Me.PengobatanDataGridViewTextBoxColumn.DataPropertyName = "pengobatan"
        Me.PengobatanDataGridViewTextBoxColumn.HeaderText = "Pengobatan"
        Me.PengobatanDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.PengobatanDataGridViewTextBoxColumn.Name = "PengobatanDataGridViewTextBoxColumn"
        Me.PengobatanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KetDataGridViewTextBoxColumn
        '
        Me.KetDataGridViewTextBoxColumn.DataPropertyName = "ket"
        Me.KetDataGridViewTextBoxColumn.HeaderText = "Ket"
        Me.KetDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.KetDataGridViewTextBoxColumn.Name = "KetDataGridViewTextBoxColumn"
        Me.KetDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TglDataGridViewTextBoxColumn
        '
        Me.TglDataGridViewTextBoxColumn.DataPropertyName = "tgl"
        Me.TglDataGridViewTextBoxColumn.HeaderText = "Tanggal"
        Me.TglDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.TglDataGridViewTextBoxColumn.Name = "TglDataGridViewTextBoxColumn"
        Me.TglDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RekamBindingSource
        '
        Me.RekamBindingSource.DataMember = "Rekam"
        Me.RekamBindingSource.DataSource = Me.DbRekamMedisDataSet1
        '
        'DbRekamMedisDataSet1
        '
        Me.DbRekamMedisDataSet1.DataSetName = "dbRekamMedisDataSet1"
        Me.DbRekamMedisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DG1
        '
        Me.DG1.AllowUserToAddRows = False
        Me.DG1.AllowUserToDeleteRows = False
        Me.DG1.AutoGenerateColumns = False
        Me.DG1.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPasienDataGridViewTextBoxColumn, Me.NoKTPDataGridViewTextBoxColumn, Me.NamaDataGridViewTextBoxColumn, Me.NamaHewanDataGridViewTextBoxColumn, Me.JenisHewanDataGridViewTextBoxColumn, Me.JkHewanDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.NoTeleponDataGridViewTextBoxColumn})
        Me.DG1.DataSource = Me.PasienBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DG1.EnableHeadersVisualStyles = False
        Me.DG1.Location = New System.Drawing.Point(30, 60)
        Me.DG1.Name = "DG1"
        Me.DG1.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DG1.Size = New System.Drawing.Size(780, 175)
        Me.DG1.TabIndex = 1
        '
        'IdPasienDataGridViewTextBoxColumn
        '
        Me.IdPasienDataGridViewTextBoxColumn.DataPropertyName = "IdPasien"
        Me.IdPasienDataGridViewTextBoxColumn.HeaderText = "No Pendaftaran"
        Me.IdPasienDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.IdPasienDataGridViewTextBoxColumn.Name = "IdPasienDataGridViewTextBoxColumn"
        Me.IdPasienDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoKTPDataGridViewTextBoxColumn
        '
        Me.NoKTPDataGridViewTextBoxColumn.DataPropertyName = "noKTP"
        Me.NoKTPDataGridViewTextBoxColumn.HeaderText = "No KTP"
        Me.NoKTPDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.NoKTPDataGridViewTextBoxColumn.Name = "NoKTPDataGridViewTextBoxColumn"
        Me.NoKTPDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamaDataGridViewTextBoxColumn
        '
        Me.NamaDataGridViewTextBoxColumn.DataPropertyName = "nama"
        Me.NamaDataGridViewTextBoxColumn.HeaderText = "Nama"
        Me.NamaDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.NamaDataGridViewTextBoxColumn.Name = "NamaDataGridViewTextBoxColumn"
        Me.NamaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamaHewanDataGridViewTextBoxColumn
        '
        Me.NamaHewanDataGridViewTextBoxColumn.DataPropertyName = "namaHewan"
        Me.NamaHewanDataGridViewTextBoxColumn.HeaderText = "Nama Hewan"
        Me.NamaHewanDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.NamaHewanDataGridViewTextBoxColumn.Name = "NamaHewanDataGridViewTextBoxColumn"
        Me.NamaHewanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JenisHewanDataGridViewTextBoxColumn
        '
        Me.JenisHewanDataGridViewTextBoxColumn.DataPropertyName = "jenisHewan"
        Me.JenisHewanDataGridViewTextBoxColumn.HeaderText = "Jenis Hewan"
        Me.JenisHewanDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.JenisHewanDataGridViewTextBoxColumn.Name = "JenisHewanDataGridViewTextBoxColumn"
        Me.JenisHewanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JkHewanDataGridViewTextBoxColumn
        '
        Me.JkHewanDataGridViewTextBoxColumn.DataPropertyName = "jkHewan"
        Me.JkHewanDataGridViewTextBoxColumn.HeaderText = "Jenis Kelamin Hewan"
        Me.JkHewanDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.JkHewanDataGridViewTextBoxColumn.Name = "JkHewanDataGridViewTextBoxColumn"
        Me.JkHewanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "Alamat"
        Me.AlamatDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        Me.AlamatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoTeleponDataGridViewTextBoxColumn
        '
        Me.NoTeleponDataGridViewTextBoxColumn.DataPropertyName = "noTelepon"
        Me.NoTeleponDataGridViewTextBoxColumn.HeaderText = "No Telepon"
        Me.NoTeleponDataGridViewTextBoxColumn.MinimumWidth = 90
        Me.NoTeleponDataGridViewTextBoxColumn.Name = "NoTeleponDataGridViewTextBoxColumn"
        Me.NoTeleponDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PasienBindingSource
        '
        Me.PasienBindingSource.DataMember = "Pasien"
        Me.PasienBindingSource.DataSource = Me.DbRekamMedisDataSet1
        '
        'PasienTableAdapter
        '
        Me.PasienTableAdapter.ClearBeforeFill = True
        '
        'RekamTableAdapter
        '
        Me.RekamTableAdapter.ClearBeforeFill = True
        '
        'Title
        '
        Me.Title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(380, 151)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(139, 31)
        Me.Title.TabIndex = 38
        Me.Title.Text = "LAPORAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(345, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 31)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "KOTA PALOPO"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Location = New System.Drawing.Point(0, 136)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 5)
        Me.Panel1.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(258, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 31)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "PUSAT KESEHATAN HEWAN"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.AppRekamMedis.My.Resources.Resources.RM2
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(689, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(120, 122)
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'PicMin
        '
        Me.PicMin.BackgroundImage = CType(resources.GetObject("PicMin.BackgroundImage"), System.Drawing.Image)
        Me.PicMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PicMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicMin.InitialImage = Nothing
        Me.PicMin.Location = New System.Drawing.Point(844, 8)
        Me.PicMin.Name = "PicMin"
        Me.PicMin.Size = New System.Drawing.Size(20, 20)
        Me.PicMin.TabIndex = 36
        Me.PicMin.TabStop = False
        '
        'picClose
        '
        Me.picClose.BackgroundImage = CType(resources.GetObject("picClose.BackgroundImage"), System.Drawing.Image)
        Me.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picClose.Location = New System.Drawing.Point(870, 8)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(20, 20)
        Me.picClose.TabIndex = 35
        Me.picClose.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(80, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'pnlLaporan
        '
        Me.pnlLaporan.BackColor = System.Drawing.Color.Sienna
        Me.pnlLaporan.Controls.Add(Me.DG2)
        Me.pnlLaporan.Controls.Add(Me.DG1)
        Me.pnlLaporan.Controls.Add(Me.btnPrint)
        Me.pnlLaporan.Controls.Add(Me.Panel8)
        Me.pnlLaporan.Controls.Add(Me.btnBack)
        Me.pnlLaporan.Location = New System.Drawing.Point(30, 190)
        Me.pnlLaporan.Name = "pnlLaporan"
        Me.pnlLaporan.Size = New System.Drawing.Size(840, 480)
        Me.pnlLaporan.TabIndex = 39
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.btnPrint.FlatAppearance.BorderSize = 2
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Black
        Me.btnPrint.Location = New System.Drawing.Point(714, 11)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(90, 35)
        Me.btnPrint.TabIndex = 9
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Controls.Add(Me.txtCri)
        Me.Panel8.Controls.Add(Me.Label5)
        Me.Panel8.Controls.Add(Me.Label15)
        Me.Panel8.Location = New System.Drawing.Point(86, 13)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(378, 30)
        Me.Panel8.TabIndex = 6
        '
        'txtCri
        '
        Me.txtCri.BackColor = System.Drawing.SystemColors.Control
        Me.txtCri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCri.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCri.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCri.ForeColor = System.Drawing.Color.Black
        Me.txtCri.Location = New System.Drawing.Point(76, 5)
        Me.txtCri.Name = "txtCri"
        Me.txtCri.Size = New System.Drawing.Size(287, 22)
        Me.txtCri.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(55, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(9, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 19)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Cari"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = Global.AppRekamMedis.My.Resources.Resources.back2
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.ForeColor = System.Drawing.Color.Transparent
        Me.btnBack.Location = New System.Drawing.Point(20, 15)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(60, 26)
        Me.btnBack.TabIndex = 1
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'FormLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 700)
        Me.Controls.Add(Me.pnlLaporan)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PicMin)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLaporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLaporan"
        CType(Me.DG2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RekamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbRekamMedisDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasienBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLaporan.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DG2 As DataGridView
    Friend WithEvents DG1 As DataGridView
    Friend WithEvents DbRekamMedisDataSet1 As dbRekamMedisDataSet1
    Friend WithEvents PasienBindingSource As BindingSource
    Friend WithEvents PasienTableAdapter As dbRekamMedisDataSet1TableAdapters.PasienTableAdapter
    Friend WithEvents RekamBindingSource As BindingSource
    Friend WithEvents RekamTableAdapter As dbRekamMedisDataSet1TableAdapters.rekamTableAdapter
    Friend WithEvents NoTeleponDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JkHewanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JenisHewanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaHewanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoKTPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdPasienDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TglDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PengobatanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiagnosaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GejalaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnamnesaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdRekamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Title As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PicMin As PictureBox
    Friend WithEvents picClose As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlLaporan As Panel
    Friend WithEvents btnPrint As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtCri As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnBack As Button
End Class
