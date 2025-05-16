Imports MySql.Data.MySqlClient

Public Class FormRegis
    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        Dim username As String = txtUsername.Text.Trim
        Dim password As String = txtPassword.Text.Trim

        If username = "" Or password = "" Then
            MessageBox.Show("Username dan Password wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        KoneksiDatabase()
        cmd = New MySqlCommand("SELECT * FROM tbuser WHERE username=@username", conn)
        cmd.Parameters.AddWithValue("@username", username)
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            MessageBox.Show("Username sudah terdaftar, pilih username lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dr.Close()
            Exit Sub
        End If
        dr.Close()

        cmd = New MySqlCommand("INSERT INTO tbuser (username, password) VALUES (@username, @password)", conn)
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@password", password)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Registrasi berhasil! Silakan login.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtUsername.Clear()
        txtPassword.Clear()
        Form1.Show()
        Me.Hide()
    End Sub
    Private Sub txtMasuk_Click(sender As Object, e As EventArgs) Handles txtMasuk.Click
        Form1.Show()
        Me.Close()
    End Sub

End Class