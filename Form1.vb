Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        Dim username As String = txtUsername.Text.Trim
        Dim password As String = txtPassword.Text.Trim

        If username = "" Or password = "" Then
            MessageBox.Show("Username dan Password wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If username = "admin" And password = "admin" Then
            MessageBox.Show("Login sebagai Admin berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FormAdmin.Show()
            Me.Hide()
        Else
            KoneksiDatabase()
            cmd = New MySqlCommand("SELECT * FROM tbuser WHERE username=@username AND password=@password", conn)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                dr.Read()
                MessageBox.Show("Login berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FormUser.idUserAktif = dr("id").ToString()
                FormUser.usernameAktif = dr("username").ToString()
                FormUser.Show()
                Me.Hide()
            Else
                MessageBox.Show("Username atau password salah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

    End Sub
    Private Sub txtDaftar_Click(sender As Object, e As EventArgs) Handles txtDaftar.Click
        FormRegis.Show()
        Me.Hide()
    End Sub
End Class
