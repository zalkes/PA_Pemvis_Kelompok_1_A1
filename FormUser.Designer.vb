<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUser))
        flowMusic = New FlowLayoutPanel()
        LogoutFU = New Label()
        LihatMusik = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        LiatPlay = New Label()
        LiatMusik = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' flowMusic
        ' 
        flowMusic.AutoScroll = True
        flowMusic.BackColor = Color.Transparent
        flowMusic.Location = New Point(46, 155)
        flowMusic.Name = "flowMusic"
        flowMusic.Size = New Size(1163, 491)
        flowMusic.TabIndex = 0
        ' 
        ' LogoutFU
        ' 
        LogoutFU.AutoSize = True
        LogoutFU.BackColor = Color.Transparent
        LogoutFU.Cursor = Cursors.Hand
        LogoutFU.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LogoutFU.ForeColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        LogoutFU.Location = New Point(1047, 35)
        LogoutFU.Name = "LogoutFU"
        LogoutFU.Size = New Size(72, 25)
        LogoutFU.TabIndex = 2
        LogoutFU.Text = "Logout"
        ' 
        ' LihatMusik
        ' 
        LihatMusik.AutoSize = True
        LihatMusik.BackColor = Color.Transparent
        LihatMusik.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LihatMusik.ForeColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        LihatMusik.Location = New Point(1408, 524)
        LihatMusik.Name = "LihatMusik"
        LihatMusik.Size = New Size(182, 25)
        LihatMusik.TabIndex = 2
        LihatMusik.Text = "Rekomendasi Musik"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Label2.Location = New Point(462, 107)
        Label2.Name = "Label2"
        Label2.Size = New Size(382, 46)
        Label2.TabIndex = 2
        Label2.Text = "REKOMENDASI MUSIK"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(46, 21)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(64, 53)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' LiatPlay
        ' 
        LiatPlay.AutoSize = True
        LiatPlay.BackColor = Color.Transparent
        LiatPlay.Cursor = Cursors.Hand
        LiatPlay.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LiatPlay.ForeColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        LiatPlay.Location = New Point(334, 35)
        LiatPlay.Name = "LiatPlay"
        LiatPlay.Size = New Size(118, 25)
        LiatPlay.TabIndex = 2
        LiatPlay.Text = "Playlist Saya"
        ' 
        ' LiatMusik
        ' 
        LiatMusik.AutoSize = True
        LiatMusik.BackColor = Color.Transparent
        LiatMusik.Cursor = Cursors.Hand
        LiatMusik.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LiatMusik.ForeColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        LiatMusik.Location = New Point(637, 35)
        LiatMusik.Name = "LiatMusik"
        LiatMusik.Size = New Size(182, 25)
        LiatMusik.TabIndex = 2
        LiatMusik.Text = "Rekomendasi Musik"
        ' 
        ' FormUser
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1262, 673)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(LihatMusik)
        Controls.Add(LiatPlay)
        Controls.Add(LiatMusik)
        Controls.Add(LogoutFU)
        Controls.Add(flowMusic)
        Name = "FormUser"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormUser"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents flowMusic As FlowLayoutPanel
    Friend WithEvents LogoutFU As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LihatMusik As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LiatPlay As Label
    Friend WithEvents LiatMusik As Label
End Class
