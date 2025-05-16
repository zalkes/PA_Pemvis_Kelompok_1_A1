Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FormUserPlaylist
    Public idUserAktif As Integer
    Public usernameAktif As String
    Private Sub FormUserPlaylist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilPlaylist()
    End Sub
    Sub TampilPlaylist()
        flowPlaylist.Controls.Clear()
        KoneksiDatabase()

        Dim query As String = "
            SELECT m.*
            FROM tbplaylist p
            JOIN tbmusik m ON p.id_musik = m.id_musik
            WHERE p.id_user = @user
        "

        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@user", idUserAktif)
        dr = cmd.ExecuteReader()
        If Not dr.HasRows Then
            Label3.Text = "Playlist Anda Kosong"
        End If

        While dr.Read()
            Dim card As New Panel
            card.Width = 250
            card.Height = 370
            card.Margin = New Padding(20)
            card.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "Resources", "cardbg2.png"))
            card.BackgroundImageLayout = ImageLayout.Stretch
            card.Padding = New Padding(30)

            Dim pic As New PictureBox
            pic.Width = 200
            pic.Height = 200
            pic.SizeMode = PictureBoxSizeMode.StretchImage
            pic.Dock = DockStyle.Top
            pic.Padding = New Padding(15)

            Dim imgPath As String = Path.Combine(Application.StartupPath, dr("gambar").ToString())
            If File.Exists(imgPath) Then
                pic.Image = Image.FromFile(imgPath)
            End If

            Dim infoPanel As New Panel
            infoPanel.Dock = DockStyle.Top
            infoPanel.Height = 58
            infoPanel.BackColor = Color.Transparent

            Dim lblJudul As New Label
            lblJudul.Text = dr("judul").ToString()
            lblJudul.Font = New Font("Segoe UI", 11, FontStyle.Bold)
            lblJudul.ForeColor = Color.White
            lblJudul.Dock = DockStyle.Top
            lblJudul.TextAlign = ContentAlignment.BottomCenter
            lblJudul.Height = 20

            Dim lblGenre As New Label
            lblGenre.Text = dr("genre").ToString()
            lblGenre.Font = New Font("Segoe UI", 8)
            lblGenre.ForeColor = Color.White
            lblGenre.AutoSize = False
            lblGenre.Dock = DockStyle.Top
            lblGenre.TextAlign = ContentAlignment.TopCenter

            Dim panelBaris As New Panel
            panelBaris.Dock = DockStyle.Bottom
            panelBaris.Height = 20

            Dim lblTahun As New Label
            lblTahun.Text = dr("tahun_rilis").ToString()
            lblTahun.Font = New Font("Segoe UI", 9)
            lblTahun.ForeColor = Color.White
            lblTahun.AutoSize = True
            lblTahun.Dock = DockStyle.Right

            Dim lblArtist As New Label
            lblArtist.Text = dr("artist").ToString()
            lblArtist.Font = New Font("Segoe UI", 9)
            lblArtist.ForeColor = Color.White
            lblArtist.AutoSize = True
            lblArtist.Dock = DockStyle.Left

            infoPanel.Controls.Add(panelBaris)
            panelBaris.Controls.Add(lblTahun)
            panelBaris.Controls.Add(lblArtist)
            infoPanel.Controls.Add(lblGenre)
            infoPanel.Controls.Add(lblJudul)

            Dim panelBottom As New Panel
            panelBottom.Dock = DockStyle.Bottom
            panelBottom.Height = 40
            panelBottom.BackColor = Color.Transparent

            Dim picHapus As New PictureBox
            picHapus.Width = 30
            picHapus.Height = 30
            picHapus.SizeMode = PictureBoxSizeMode.StretchImage
            picHapus.Cursor = Cursors.Hand
            picHapus.Anchor = AnchorStyles.None
            picHapus.Location = New Point((panelBottom.Width - picHapus.Width) \ 2, 5)
            picHapus.Tag = dr("id_musik")

            picHapus.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Resources", "min.png")) ' Pastikan file ada


            AddHandler picHapus.Click, AddressOf HapusDariPlaylist

            panelBottom.Controls.Add(picHapus)

            card.Controls.Add(panelBottom)
            card.Controls.Add(infoPanel)
            card.Controls.Add(pic)

            flowPlaylist.Controls.Add(card)
        End While

        dr.Close()
        conn.Close()
    End Sub

    Sub HapusDariPlaylist(sender As Object, e As EventArgs)
        Dim pic As PictureBox = CType(sender, PictureBox)
        Dim idMusik As Integer = pic.Tag

        Dim result = MessageBox.Show("Hapus musik ini dari playlist?", "Konfirmasi", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            KoneksiDatabase()
            cmd = New MySqlCommand("DELETE FROM tbplaylist WHERE id_musik=@musik AND id_user=@user", conn)
            cmd.Parameters.AddWithValue("@musik", idMusik)
            cmd.Parameters.AddWithValue("@user", idUserAktif)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Musik dihapus dari playlist!")
            TampilPlaylist()
        End If
    End Sub

    Private Sub LihatMusik_Click(sender As Object, e As EventArgs) Handles LihatMusik.Click
        FormUser.idUserAktif = idUserAktif
        FormUser.usernameAktif = usernameAktif
        FormUser.Show()
        Me.Close()
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Dim result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FormProfileUser.idUserAktif = idUserAktif
        FormProfileUser.usernameAktif = usernameAktif
        FormProfileUser.Show()
        Me.Close()
    End Sub
End Class
