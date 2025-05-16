Imports MySql.Data.MySqlClient
Imports System.IO

Public Class FormAdmin
    Dim printFont As New Font("Arial", 10)
    Dim currentY As Integer = 0
    Dim dataMusik As DataTable
    Dim idMusikTerpilih As Integer = -1
    Private gambarPath As String = ""
    Private Sub FormAdminMusik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        IsiGenre()
        TampilData()
        AturGrid()
    End Sub
    Sub Bersihkan()
        txtJudul.Clear()
        txtArtist.Clear()
        txtTahun.Clear()
        cbgenre.Text = ""
        picGambar.Image = Nothing
        idMusikTerpilih = -1
    End Sub
    Sub TampilData()
        KoneksiDatabase()
        da = New MySqlDataAdapter("SELECT id_musik, judul, artist, tahun_rilis, genre, gambar FROM tbmusik", conn)
        ds = New DataSet()
        da.Fill(ds, "tbmusik")
        dgvMusik.DataSource = ds.Tables("tbmusik")
    End Sub
    Sub AturGrid()
        With dgvMusik
            .Columns("id_musik").Visible = False
            .Columns("judul").Width = 200
            .Columns("artist").Width = 200
            .Columns("tahun_rilis").Width = 110
            .Columns("genre").Width = 165
            .Columns("gambar").Visible = False
        End With
    End Sub
    Sub IsiGenre()
        cbgenre.Items.Clear()
        cbgenre.Items.AddRange(New String() {"Pop", "Rock", "Jazz", "Dangdut", "K-Pop", "Lainnya"})
    End Sub
    Private Sub btnPilihGambar_Click(sender As Object, e As EventArgs) Handles btnPilihGambar.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim fileName As String = Path.GetFileName(OpenFileDialog1.FileName)
            Dim destPath As String = Path.Combine(Application.StartupPath, "Gambar", fileName)

            If Not File.Exists(destPath) Then
                File.Copy(OpenFileDialog1.FileName, destPath)
            End If

            gambarPath = "Gambar\" & fileName
            picGambar.Image = Image.FromFile(destPath)
        End If
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtJudul.Text = "" Or txtArtist.Text = "" Or txtTahun.Text = "" Or picGambar.Image Is Nothing Or cbgenre.Text = "" Then
            MessageBox.Show("Semua field wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtTahun.Text.Length <> 4 Or Not IsNumeric(txtTahun.Text) Or CInt(txtTahun.Text) < 0 Then
            MessageBox.Show("Tahun rilis tidak valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTahun.Focus()
            Exit Sub
        End If

        KoneksiDatabase()
        cmd = New MySqlCommand("INSERT INTO tbmusik (judul, artist, genre, tahun_rilis, gambar) VALUES (@judul, @artist, @genre, @tahun, @gambar)", conn)
        cmd.Parameters.AddWithValue("@judul", txtJudul.Text)
        cmd.Parameters.AddWithValue("@artist", txtArtist.Text)
        cmd.Parameters.AddWithValue("@genre", cbgenre.Text)
        cmd.Parameters.AddWithValue("@tahun", txtTahun.Text)
        cmd.Parameters.AddWithValue("@gambar", gambarPath)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Data berhasil disimpan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Bersihkan()
        TampilData()
    End Sub
    Private Sub dgvMusik_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMusik.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvMusik.Rows(e.RowIndex)
            idMusikTerpilih = If(IsDBNull(row.Cells("id_musik").Value), -1, row.Cells("id_musik").Value)
            txtJudul.Text = If(IsDBNull(row.Cells("judul").Value), "", row.Cells("judul").Value)
            txtArtist.Text = If(IsDBNull(row.Cells("artist").Value), "", row.Cells("artist").Value)
            txtTahun.Text = If(IsDBNull(row.Cells("tahun_rilis").Value), "", row.Cells("tahun_rilis").Value)
            cbgenre.Text = If(IsDBNull(row.Cells("genre").Value), "", row.Cells("genre").Value)

            Dim gambarDB As String = If(IsDBNull(row.Cells("gambar").Value), "", row.Cells("gambar").Value)
            gambarPath = gambarDB
            Dim fullPath As String = Path.Combine(Application.StartupPath, gambarDB)

            If Not String.IsNullOrEmpty(gambarDB) AndAlso File.Exists(fullPath) Then
                picGambar.Image = Image.FromFile(fullPath)
            Else
                picGambar.Image = Nothing
            End If
        End If
    End Sub
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If idMusikTerpilih = -1 Then
            MessageBox.Show("Pilih data yang ingin diubah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtJudul.Text = "" Or txtArtist.Text = "" Or txtTahun.Text = "" Or cbgenre.Text = "" Then
            MessageBox.Show("Semua field wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrEmpty(gambarPath) Then
            Dim row As DataGridViewRow = dgvMusik.Rows.Cast(Of DataGridViewRow)().FirstOrDefault(Function(r) r.Cells("id_musik").Value = idMusikTerpilih)
            If row IsNot Nothing Then
                gambarPath = If(IsDBNull(row.Cells("gambar").Value), "", row.Cells("gambar").Value)
            End If
        End If

        If txtTahun.Text.Length <> 4 Or Not IsNumeric(txtTahun.Text) Or CInt(txtTahun.Text) < 0 Then
            MessageBox.Show("Tahun rilis tidak valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTahun.Focus()
            Exit Sub
        End If

        KoneksiDatabase()
        cmd = New MySqlCommand("UPDATE tbmusik SET judul=@judul, artist=@artist, tahun_rilis=@tahun, gambar=@gambar, genre=@genre WHERE id_musik=@id", conn)
        cmd.Parameters.AddWithValue("@judul", txtJudul.Text)
        cmd.Parameters.AddWithValue("@artist", txtArtist.Text)
        cmd.Parameters.AddWithValue("@tahun", txtTahun.Text)
        cmd.Parameters.AddWithValue("@gambar", gambarPath)
        cmd.Parameters.AddWithValue("@genre", cbgenre.Text)
        cmd.Parameters.AddWithValue("@id", idMusikTerpilih)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Data berhasil diubah.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Bersihkan()
        TampilData()
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If idMusikTerpilih = -1 Then
            MessageBox.Show("Pilih data yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim konfirmasi = MessageBox.Show("Yakin ingin hapus data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.Yes Then
            KoneksiDatabase()
            cmd = New MySqlCommand("DELETE FROM tbmusik WHERE id_musik=@id", conn)
            cmd.Parameters.AddWithValue("@id", idMusikTerpilih)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data berhasil dihapus.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Bersihkan()
            TampilData()
        End If
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click, btnPrint.Click, btnPreview.Click
        Bersihkan()
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim konfirmasi = MessageBox.Show("Yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.Yes Then
            Me.Close()
            Form1.Show()
        End If
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        KoneksiDatabase()
        da = New MySqlDataAdapter("SELECT id_musik, judul, artist, tahun_rilis, genre, gambar FROM tbmusik WHERE judul LIKE @cari OR artist LIKE @cari OR tahun_rilis LIKE @cari OR genre LIKE @cari", conn)
        da.SelectCommand.Parameters.AddWithValue("@cari", "%" & txtSearch.Text & "%")
        ds = New DataSet()
        da.Fill(ds, "tbmusik")
        dgvMusik.DataSource = ds.Tables("tbmusik")
    End Sub
    Sub AmbilDataUntukCetak()
        KoneksiDatabase()
        da = New MySqlDataAdapter("SELECT judul, artist, genre, tahun_rilis FROM tbmusik", conn)
        ds = New DataSet()
        da.Fill(ds, "tbmusik")
        dataMusik = ds.Tables("tbmusik")
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim marginLeft As Integer = e.MarginBounds.Left
        Dim marginTop As Integer = e.MarginBounds.Top
        currentY = marginTop

        Dim headerFont As New Font("Arial", 12, FontStyle.Bold)
        Dim boldFont As New Font("Arial", 10, FontStyle.Bold)

        e.Graphics.DrawString("Daftar Musik", headerFont, Brushes.Black, marginLeft, currentY)
        currentY += 30

        e.Graphics.DrawString("Judul", boldFont, Brushes.Black, marginLeft, currentY)
        e.Graphics.DrawString("Artist", boldFont, Brushes.Black, marginLeft + 200, currentY)
        e.Graphics.DrawString("Genre", boldFont, Brushes.Black, marginLeft + 400, currentY)
        e.Graphics.DrawString("Tahun", boldFont, Brushes.Black, marginLeft + 520, currentY)
        currentY += 25
        e.Graphics.DrawLine(Pens.Black, marginLeft, currentY, e.MarginBounds.Right, currentY)
        currentY += 5
        For Each row As DataRow In dataMusik.Rows
            If currentY > e.MarginBounds.Bottom - 30 Then
                e.HasMorePages = True
                Return
            End If

            e.Graphics.DrawString(row("judul").ToString(), printFont, Brushes.Black, marginLeft, currentY)
            e.Graphics.DrawString(row("artist").ToString(), printFont, Brushes.Black, marginLeft + 200, currentY)
            e.Graphics.DrawString(row("genre").ToString(), printFont, Brushes.Black, marginLeft + 400, currentY)
            e.Graphics.DrawString(row("tahun_rilis").ToString(), printFont, Brushes.Black, marginLeft + 520, currentY)
            currentY += 25
        Next

        e.HasMorePages = False
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        AmbilDataUntukCetak()
        If dataMusik.Rows.Count = 0 Then
            MessageBox.Show("Tidak ada data untuk ditampilkan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Width = 800
        PrintPreviewDialog1.Height = 600
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        AmbilDataUntukCetak()

        If dataMusik.Rows.Count = 0 Then
            MessageBox.Show("Tidak ada data untuk dicetak.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        PrintDialog1.Document = PrintDocument1

        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub
End Class