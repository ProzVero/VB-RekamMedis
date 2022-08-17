<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PasienBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbRekamMedisDataSet1 = New AppRekamMedis.dbRekamMedisDataSet1()
        Me.PasienTableAdapter = New AppRekamMedis.dbRekamMedisDataSet1TableAdapters.PasienTableAdapter()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PicMin = New System.Windows.Forms.PictureBox()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlLogin = New System.Windows.Forms.Panel()
        CType(Me.PasienBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbRekamMedisDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pnlLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Location = New System.Drawing.Point(0, 140)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 5)
        Me.Panel1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(346, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 31)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "KOTA PALOPO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(259, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 31)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "PUSAT KESEHATAN HEWAN"
        '
        'PasienBindingSource
        '
        Me.PasienBindingSource.DataMember = "Pasien"
        Me.PasienBindingSource.DataSource = Me.DbRekamMedisDataSet1
        '
        'DbRekamMedisDataSet1
        '
        Me.DbRekamMedisDataSet1.DataSetName = "dbRekamMedisDataSet1"
        Me.DbRekamMedisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PasienTableAdapter
        '
        Me.PasienTableAdapter.ClearBeforeFill = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.AppRekamMedis.My.Resources.Resources.logou
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(819, 10)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.AppRekamMedis.My.Resources.Resources.pdhi
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(702, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PicMin
        '
        Me.PicMin.BackgroundImage = CType(resources.GetObject("PicMin.BackgroundImage"), System.Drawing.Image)
        Me.PicMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PicMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicMin.InitialImage = Nothing
        Me.PicMin.Location = New System.Drawing.Point(845, 10)
        Me.PicMin.Name = "PicMin"
        Me.PicMin.Size = New System.Drawing.Size(20, 20)
        Me.PicMin.TabIndex = 16
        Me.PicMin.TabStop = False
        '
        'picClose
        '
        Me.picClose.BackgroundImage = CType(resources.GetObject("picClose.BackgroundImage"), System.Drawing.Image)
        Me.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picClose.Location = New System.Drawing.Point(871, 10)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(20, 20)
        Me.picClose.TabIndex = 15
        Me.picClose.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(100, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel7.Controls.Add(Me.Button4)
        Me.Panel7.Location = New System.Drawing.Point(513, 299)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(260, 260)
        Me.Panel7.TabIndex = 18
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.AppRekamMedis.My.Resources.Resources.D
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(5, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(250, 250)
        Me.Button4.TabIndex = 0
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel6.Controls.Add(Me.Button3)
        Me.Panel6.Location = New System.Drawing.Point(20, 299)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(260, 260)
        Me.Panel6.TabIndex = 17
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.AppRekamMedis.My.Resources.Resources.C
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(5, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(250, 250)
        Me.Button3.TabIndex = 0
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel5.Controls.Add(Me.Button2)
        Me.Panel5.Location = New System.Drawing.Point(542, 17)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(260, 260)
        Me.Panel5.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.AppRekamMedis.My.Resources.Resources.B
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Chocolate
        Me.Button2.Location = New System.Drawing.Point(5, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(250, 250)
        Me.Button2.TabIndex = 0
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel4.Location = New System.Drawing.Point(167, 17)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(260, 260)
        Me.Panel4.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.AppRekamMedis.My.Resources.Resources.A
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(5, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(250, 250)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'pnlLogin
        '
        Me.pnlLogin.BackgroundImage = Global.AppRekamMedis.My.Resources.Resources.WhatsApp_Image_2022_08_16_at_20_01_13
        Me.pnlLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlLogin.Controls.Add(Me.Panel4)
        Me.pnlLogin.Controls.Add(Me.Panel5)
        Me.pnlLogin.Controls.Add(Me.Panel6)
        Me.pnlLogin.Controls.Add(Me.Panel7)
        Me.pnlLogin.Location = New System.Drawing.Point(0, 145)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(900, 573)
        Me.pnlLogin.TabIndex = 20
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(900, 736)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.pnlLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PicMin)
        Me.Controls.Add(Me.picClose)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMain"
        CType(Me.PasienBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbRekamMedisDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.pnlLogin.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PicMin As PictureBox
    Friend WithEvents picClose As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DbRekamMedisDataSet1 As dbRekamMedisDataSet1
    Friend WithEvents PasienBindingSource As BindingSource
    Friend WithEvents PasienTableAdapter As dbRekamMedisDataSet1TableAdapters.PasienTableAdapter
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel7 As Panel
End Class
