<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProfileUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProfileUser))
        Label1 = New Label()
        txtUsername = New TextBox()
        GenderUser = New GroupBox()
        wanita = New RadioButton()
        pria = New RadioButton()
        na = New RadioButton()
        LabelUsername = New Label()
        btnSimpan = New Button()
        PictureBox1 = New PictureBox()
        LiatPlay = New Label()
        LihatMusik = New Label()
        Logout = New Label()
        GenderUser.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Label1.Location = New Point(165, 166)
        Label1.Name = "Label1"
        Label1.Size = New Size(363, 81)
        Label1.TabIndex = 0
        Label1.Text = "Profile User"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(190, 328)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(252, 30)
        txtUsername.TabIndex = 1
        ' 
        ' GenderUser
        ' 
        GenderUser.BackColor = Color.Transparent
        GenderUser.Controls.Add(wanita)
        GenderUser.Controls.Add(pria)
        GenderUser.Controls.Add(na)
        GenderUser.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GenderUser.ForeColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        GenderUser.Location = New Point(190, 392)
        GenderUser.Margin = New Padding(3, 4, 3, 4)
        GenderUser.Name = "GenderUser"
        GenderUser.Padding = New Padding(3, 4, 3, 4)
        GenderUser.Size = New Size(245, 75)
        GenderUser.TabIndex = 2
        GenderUser.TabStop = False
        GenderUser.Text = "Gender User"
        ' 
        ' wanita
        ' 
        wanita.AutoSize = True
        wanita.Font = New Font("Segoe UI", 12F)
        wanita.Location = New Point(157, 29)
        wanita.Margin = New Padding(3, 4, 3, 4)
        wanita.Name = "wanita"
        wanita.Size = New Size(94, 32)
        wanita.TabIndex = 0
        wanita.TabStop = True
        wanita.Text = "Wanita"
        wanita.UseVisualStyleBackColor = True
        ' 
        ' pria
        ' 
        pria.AutoSize = True
        pria.Font = New Font("Segoe UI", 12F)
        pria.Location = New Point(81, 29)
        pria.Margin = New Padding(3, 4, 3, 4)
        pria.Name = "pria"
        pria.Size = New Size(66, 32)
        pria.TabIndex = 0
        pria.TabStop = True
        pria.Text = "Pria"
        pria.UseVisualStyleBackColor = True
        ' 
        ' na
        ' 
        na.AutoSize = True
        na.Font = New Font("Segoe UI", 12F)
        na.Location = New Point(7, 29)
        na.Margin = New Padding(3, 4, 3, 4)
        na.Name = "na"
        na.Size = New Size(69, 32)
        na.TabIndex = 0
        na.TabStop = True
        na.Text = "N/A"
        na.UseVisualStyleBackColor = True
        ' 
        ' LabelUsername
        ' 
        LabelUsername.AutoSize = True
        LabelUsername.BackColor = Color.Transparent
        LabelUsername.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelUsername.ForeColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        LabelUsername.Location = New Point(190, 296)
        LabelUsername.Name = "LabelUsername"
        LabelUsername.Size = New Size(106, 28)
        LabelUsername.TabIndex = 3
        LabelUsername.Text = "Username"
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.Black
        btnSimpan.Cursor = Cursors.Hand
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.ForeColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        btnSimpan.Location = New Point(190, 506)
        btnSimpan.Margin = New Padding(3, 4, 3, 4)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(159, 31)
        btnSimpan.TabIndex = 4
        btnSimpan.Text = "Simpan Perubahan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(37, 35)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(64, 53)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' LiatPlay
        ' 
        LiatPlay.AutoSize = True
        LiatPlay.BackColor = Color.Transparent
        LiatPlay.Cursor = Cursors.Hand
        LiatPlay.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LiatPlay.ForeColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        LiatPlay.Location = New Point(275, 49)
        LiatPlay.Name = "LiatPlay"
        LiatPlay.Size = New Size(118, 25)
        LiatPlay.TabIndex = 5
        LiatPlay.Text = "Playlist Saya"
        ' 
        ' LihatMusik
        ' 
        LihatMusik.AutoSize = True
        LihatMusik.BackColor = Color.Transparent
        LihatMusik.Cursor = Cursors.Hand
        LihatMusik.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LihatMusik.ForeColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        LihatMusik.Location = New Point(601, 49)
        LihatMusik.Name = "LihatMusik"
        LihatMusik.Size = New Size(182, 25)
        LihatMusik.TabIndex = 6
        LihatMusik.Text = "Rekomendasi Musik"
        ' 
        ' Logout
        ' 
        Logout.AutoSize = True
        Logout.BackColor = Color.Transparent
        Logout.Cursor = Cursors.Hand
        Logout.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Logout.ForeColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Logout.Location = New Point(1026, 49)
        Logout.Name = "Logout"
        Logout.Size = New Size(72, 25)
        Logout.TabIndex = 7
        Logout.Text = "Logout"
        ' 
        ' FormProfileUser
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1262, 673)
        Controls.Add(PictureBox1)
        Controls.Add(LiatPlay)
        Controls.Add(LihatMusik)
        Controls.Add(Logout)
        Controls.Add(btnSimpan)
        Controls.Add(LabelUsername)
        Controls.Add(GenderUser)
        Controls.Add(txtUsername)
        Controls.Add(Label1)
        DoubleBuffered = True
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormProfileUser"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormProfileUser"
        GenderUser.ResumeLayout(False)
        GenderUser.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents GenderUser As GroupBox
    Friend WithEvents wanita As RadioButton
    Friend WithEvents pria As RadioButton
    Friend WithEvents na As RadioButton
    Friend WithEvents LabelUsername As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LiatPlay As Label
    Friend WithEvents LihatMusik As Label
    Friend WithEvents Logout As Label
End Class
