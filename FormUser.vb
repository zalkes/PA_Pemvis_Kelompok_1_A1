Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FormUser
    Public idUserAktif As Integer
    Public usernameAktif As String

    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilMusik()
    End Sub
    Sub TampilMusik()
        flowMusic.Controls.Clear()
        KoneksiDatabase()

        cmd = New MySqlCommand("SELECT * FROM tbmusik", conn)
        dr = cmd.ExecuteReader()
        If Not dr.HasRows Then
            Label2.Text = "Tidak Ada Musik yang Tersedia."
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

            Dim picTambah As New PictureBox
            picTambah.Width = 30
            picTambah.Height = 30
            picTambah.SizeMode = PictureBoxSizeMode.StretchImage
            picTambah.Cursor = Cursors.Hand
            picTambah.Anchor = AnchorStyles.None
            picTambah.Location = New Point((panelBottom.Width - picTambah.Width) \ 2, 5)
            picTambah.Tag = dr("id_musik")

            If MusikSudahAda(dr("id_musik")) Then
                picTambah.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Resources", "min.png"))
            Else
                picTambah.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Resources", "plus.png"))
            End If

            AddHandler picTambah.Click, AddressOf TambahHapusPlaylist
            panelBottom.Controls.Add(picTambah)
            card.Controls.Add(panelBottom)
            card.Controls.Add(infoPanel)
            card.Controls.Add(pic)

            flowMusic.Controls.Add(card)
        End While

        dr.Close()
        conn.Close()
    End Sub


    Function MusikSudahAda(idMusik As Integer) As Boolean
        Dim ada As Boolean = False
        KoneksiDatabase()
        Dim cekCmd As New MySqlCommand("SELECT * FROM tbplaylist WHERE id_musik=@musik AND id_user=@user", conn)
        cekCmd.Parameters.AddWithValue("@musik", idMusik)
        cekCmd.Parameters.AddWithValue("@user", idUserAktif)
        Dim cekDr = cekCmd.ExecuteReader()
        ada = cekDr.HasRows
        cekDr.Close()
        conn.Close()
        Return ada
    End Function

    Sub TambahHapusPlaylist(sender As Object, e As EventArgs)
        Dim pic As PictureBox = CType(sender, PictureBox)
        Dim idMusik As Integer = pic.Tag

        If MusikSudahAda(idMusik) Then
            KoneksiDatabase()
            cmd = New MySqlCommand("DELETE FROM tbplaylist WHERE id_musik=@musik AND id_user=@user", conn)
            cmd.Parameters.AddWithValue("@musik", idMusik)
            cmd.Parameters.AddWithValue("@user", idUserAktif)
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Musik dihapus dari playlist!")
        Else
            KoneksiDatabase()
            cmd = New MySqlCommand("INSERT INTO tbplaylist (id_musik, id_user) VALUES (@musik, @user)", conn)
            cmd.Parameters.AddWithValue("@musik", idMusik)
            cmd.Parameters.AddWithValue("@user", idUserAktif)
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Musik ditambahkan ke playlist!")
        End If

        TampilMusik()
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        Dim result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Form1.Show()
            Me.Close()
        End If
    End Sub
    Private Sub LiatPlay_Click(sender As Object, e As EventArgs) Handles LiatPlay.Click
        FormUserPlaylist.idUserAktif = idUserAktif
        FormUserPlaylist.usernameAktif = usernameAktif
        FormUserPlaylist.Show()
        Me.Close()
    End Sub
    Private Sub LogoutFU_Click(sender As Object, e As EventArgs) Handles LogoutFU.Click
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
