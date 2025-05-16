<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUserPlaylist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUserPlaylist))
        Logout = New Label()
        LihatPlaylist = New Label()
        LihatMusik = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        flowPlaylist = New FlowLayoutPanel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        Logout.TabIndex = 3
        Logout.Text = "Logout"
        ' 
        ' LihatPlaylist
        ' 
        LihatPlaylist.AutoSize = True
        LihatPlaylist.BackColor = Color.Transparent
        LihatPlaylist.Cursor = Cursors.Hand
        LihatPlaylist.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LihatPlaylist.ForeColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        LihatPlaylist.Location = New Point(275, 49)
        LihatPlaylist.Name = "LihatPlaylist"
        LihatPlaylist.Size = New Size(118, 25)
        LihatPlaylist.TabIndex = 3
        LihatPlaylist.Text = "Playlist Saya"
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
        LihatMusik.TabIndex = 3
        LihatMusik.Text = "Rekomendasi Musik"
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
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Label3.Location = New Point(523, 99)
        Label3.Name = "Label3"
        Label3.Size = New Size(259, 46)
        Label3.TabIndex = 6
        Label3.Text = "PLAYLIST SAYA"
        ' 
        ' flowPlaylist
        ' 
        flowPlaylist.AutoScroll = True
        flowPlaylist.BackColor = Color.Transparent
        flowPlaylist.Location = New Point(40, 147)
        flowPlaylist.Name = "flowPlaylist"
        flowPlaylist.Size = New Size(1163, 491)
        flowPlaylist.TabIndex = 5
        ' 
        ' FormUserPlaylist
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1262, 673)
        Controls.Add(Label3)
        Controls.Add(flowPlaylist)
        Controls.Add(PictureBox1)
        Controls.Add(LihatPlaylist)
        Controls.Add(LihatMusik)
        Controls.Add(Logout)
        Name = "FormUserPlaylist"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormUserPlaylist"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Logout As Label
    Friend WithEvents LihatPlaylist As Label
    Friend WithEvents LihatMusik As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents flowPlaylist As FlowLayoutPanel
End Class
