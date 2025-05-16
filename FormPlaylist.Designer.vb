<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdmin))
        txtJudul = New TextBox()
        Label1 = New Label()
        txtArtist = New TextBox()
        Label2 = New Label()
        txtTahun = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        btnTambah = New Button()
        PictureBox1 = New PictureBox()
        txtSearch = New TextBox()
        dgvMusik = New DataGridView()
        PictureBox2 = New PictureBox()
        btnUbah = New Button()
        btnHapus = New Button()
        btnLogout = New Button()
        btnBatal = New Button()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        Label3 = New Label()
        picGambar = New PictureBox()
        btnPilihGambar = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        cbgenre = New ComboBox()
        Label6 = New Label()
        btnPrint = New Button()
        btnPreview = New Button()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        PrintDialog1 = New PrintDialog()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvMusik, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(picGambar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtJudul
        ' 
        txtJudul.BackColor = Color.Black
        txtJudul.ForeColor = Color.White
        txtJudul.Location = New Point(371, 149)
        txtJudul.MaxLength = 15
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(229, 27)
        txtJudul.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(279, 152)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 20)
        Label1.TabIndex = 1
        Label1.Text = "Judul"
        ' 
        ' txtArtist
        ' 
        txtArtist.BackColor = Color.Black
        txtArtist.ForeColor = Color.White
        txtArtist.Location = New Point(371, 196)
        txtArtist.MaxLength = 15
        txtArtist.Name = "txtArtist"
        txtArtist.Size = New Size(229, 27)
        txtArtist.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(279, 200)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 1
        Label2.Text = "Artist"
        ' 
        ' txtTahun
        ' 
        txtTahun.BackColor = Color.Black
        txtTahun.ForeColor = Color.White
        txtTahun.Location = New Point(371, 242)
        txtTahun.MaxLength = 4
        txtTahun.Name = "txtTahun"
        txtTahun.Size = New Size(229, 27)
        txtTahun.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(279, 245)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 20)
        Label4.TabIndex = 1
        Label4.Text = "Tahun Rilis"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(483, 76)
        Label5.Name = "Label5"
        Label5.Size = New Size(317, 41)
        Label5.TabIndex = 2
        Label5.Text = "MANAJEMEN MUSIK"
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnTambah.Cursor = Cursors.Hand
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTambah.Location = New Point(279, 340)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 44)
        btnTambah.TabIndex = 3
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(279, 408)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(26, 32)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.Black
        txtSearch.ForeColor = Color.White
        txtSearch.Location = New Point(322, 408)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(684, 32)
        txtSearch.TabIndex = 0
        ' 
        ' dgvMusik
        ' 
        dgvMusik.BackgroundColor = Color.Gray
        dgvMusik.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMusik.GridColor = Color.Black
        dgvMusik.Location = New Point(279, 458)
        dgvMusik.Name = "dgvMusik"
        dgvMusik.ReadOnly = True
        dgvMusik.RowHeadersWidth = 51
        dgvMusik.Size = New Size(727, 203)
        dgvMusik.TabIndex = 5
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(608, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(59, 61)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnUbah.Cursor = Cursors.Hand
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUbah.Location = New Point(360, 340)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(73, 44)
        btnUbah.TabIndex = 3
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnHapus.Cursor = Cursors.Hand
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHapus.Location = New Point(439, 340)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(73, 44)
        btnHapus.TabIndex = 3
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnLogout.Cursor = Cursors.Hand
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(933, 63)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(73, 44)
        btnLogout.TabIndex = 3
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.White
        btnBatal.Cursor = Cursors.Hand
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBatal.ForeColor = Color.Black
        btnBatal.Location = New Point(518, 340)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(75, 44)
        btnBatal.TabIndex = 3
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(12, 31)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(229, 212)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(1000, 31)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(229, 200)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 7
        PictureBox4.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(693, 223)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 20)
        Label3.TabIndex = 1
        Label3.Text = "Sampul Musik"
        ' 
        ' picGambar
        ' 
        picGambar.BorderStyle = BorderStyle.FixedSingle
        picGambar.Location = New Point(815, 149)
        picGambar.Name = "picGambar"
        picGambar.Size = New Size(191, 169)
        picGambar.SizeMode = PictureBoxSizeMode.StretchImage
        picGambar.TabIndex = 8
        picGambar.TabStop = False
        ' 
        ' btnPilihGambar
        ' 
        btnPilihGambar.FlatStyle = FlatStyle.Flat
        btnPilihGambar.ForeColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        btnPilihGambar.Location = New Point(855, 324)
        btnPilihGambar.Name = "btnPilihGambar"
        btnPilihGambar.Size = New Size(126, 29)
        btnPilihGambar.TabIndex = 9
        btnPilihGambar.Text = "Pilih Gambar"
        btnPilihGambar.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' cbgenre
        ' 
        cbgenre.BackColor = Color.Black
        cbgenre.ForeColor = Color.White
        cbgenre.FormattingEnabled = True
        cbgenre.Items.AddRange(New Object() {"R&B", "Clasic", "Rap"})
        cbgenre.Location = New Point(371, 290)
        cbgenre.Margin = New Padding(3, 4, 3, 4)
        cbgenre.Name = "cbgenre"
        cbgenre.Size = New Size(229, 28)
        cbgenre.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(279, 294)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 20)
        Label6.TabIndex = 1
        Label6.Text = "Genre"
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.Tomato
        btnPrint.Cursor = Cursors.Hand
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPrint.ForeColor = Color.Black
        btnPrint.Location = New Point(680, 340)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(75, 44)
        btnPrint.TabIndex = 3
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' btnPreview
        ' 
        btnPreview.BackColor = Color.DarkSalmon
        btnPreview.Cursor = Cursors.Hand
        btnPreview.FlatStyle = FlatStyle.Flat
        btnPreview.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPreview.ForeColor = Color.Black
        btnPreview.Location = New Point(599, 340)
        btnPreview.Name = "btnPreview"
        btnPreview.Size = New Size(75, 44)
        btnPreview.TabIndex = 3
        btnPreview.Text = "Preview"
        btnPreview.UseVisualStyleBackColor = False
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' FormAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1262, 673)
        Controls.Add(cbgenre)
        Controls.Add(btnPilihGambar)
        Controls.Add(picGambar)
        Controls.Add(PictureBox2)
        Controls.Add(dgvMusik)
        Controls.Add(PictureBox1)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnPreview)
        Controls.Add(btnPrint)
        Controls.Add(btnBatal)
        Controls.Add(btnLogout)
        Controls.Add(btnTambah)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtSearch)
        Controls.Add(txtTahun)
        Controls.Add(txtArtist)
        Controls.Add(txtJudul)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        DoubleBuffered = True
        Name = "FormAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormAdmin"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvMusik, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(picGambar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtJudul As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtArtist As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvMusik As DataGridView
    Friend WithEvents PictureBox2 As PictureBox

    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents picGambar As PictureBox
    Friend WithEvents btnPilihGambar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents cbgenre As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnPreview As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
