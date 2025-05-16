Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FormProfileUser
    Public idUserAktif As Integer
    Public usernameAktif As String

    Private Sub FormProfileUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = usernameAktif

        KoneksiDatabase()
        Dim cmd As New MySqlCommand("SELECT gender FROM tbuser WHERE id=@id", conn)
        cmd.Parameters.AddWithValue("@id", idUserAktif)
        Dim dr = cmd.ExecuteReader()
        If dr.Read() Then
            Dim gender As String = dr("gender").ToString().ToLower()
            If gender = "pria" Then
                pria.Checked = True
            ElseIf gender = "wanita" Then
                wanita.Checked = True
            Else
                na.Checked = True
            End If
        Else
            na.Checked = True
        End If
        dr.Close()
        conn.Close()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim newUsername As String = txtUsername.Text.Trim()
        Dim genderValue As String = ""
        If pria.Checked Then
            genderValue = "pria"
        ElseIf wanita.Checked Then
            genderValue = "wanita"
        ElseIf na.Checked Then
            genderValue = ""
        End If
        If newUsername = "" Then
            MessageBox.Show("Username tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        KoneksiDatabase()
        Dim cekCmd As New MySqlCommand("SELECT COUNT(*) FROM tbuser WHERE username=@username AND id<>@id", conn)
        cekCmd.Parameters.AddWithValue("@username", newUsername)
        cekCmd.Parameters.AddWithValue("@id", idUserAktif)
        Dim count As Integer = Convert.ToInt32(cekCmd.ExecuteScalar())
        If count > 0 Then
            MessageBox.Show("Username sudah digunakan oleh user lain. Silakan pilih username lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            conn.Close()
            Exit Sub
        End If

        KoneksiDatabase()
        Dim cmd As New MySqlCommand("UPDATE tbuser SET username=@username, gender=@gender WHERE id=@id", conn)
        cmd.Parameters.AddWithValue("@username", newUsername)
        cmd.Parameters.AddWithValue("@gender", genderValue)
        cmd.Parameters.AddWithValue("@id", idUserAktif)
        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Perubahan profil berhasil disimpan!")
        usernameAktif = newUsername
    End Sub

    Private Sub LiatPlay_Click(sender As Object, e As EventArgs) Handles LiatPlay.Click
        FormUserPlaylist.idUserAktif = idUserAktif
        FormUserPlaylist.usernameAktif = usernameAktif
        FormUserPlaylist.Show()
        Me.Close()
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


End Class