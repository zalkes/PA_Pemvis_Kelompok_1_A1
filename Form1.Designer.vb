<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        txtUsername = New TextBox()
        PictureBox2 = New PictureBox()
        txtPassword = New TextBox()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        btnMasuk = New Button()
        Label2 = New Label()
        txtDaftar = New Label()
        BackgroundWorker2 = New ComponentModel.BackgroundWorker()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(421, 246)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(43, 43)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Blue
        Label1.Location = New Point(554, 134)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 62)
        Label1.TabIndex = 1
        Label1.Text = "MASUK"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.Black
        txtUsername.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.ForeColor = Color.White
        txtUsername.Location = New Point(487, 246)
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(341, 43)
        txtUsername.TabIndex = 2
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(414, 313)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(60, 41)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.Black
        txtPassword.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.ForeColor = Color.White
        txtPassword.Location = New Point(487, 313)
        txtPassword.Multiline = True
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(341, 41)
        txtPassword.TabIndex = 2
        ' 
        ' btnMasuk
        ' 
        btnMasuk.BackColor = Color.Blue
        btnMasuk.Cursor = Cursors.Hand
        btnMasuk.FlatStyle = FlatStyle.Flat
        btnMasuk.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMasuk.Location = New Point(603, 391)
        btnMasuk.Name = "btnMasuk"
        btnMasuk.Size = New Size(106, 37)
        btnMasuk.TabIndex = 3
        btnMasuk.Text = "Login"
        btnMasuk.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(539, 446)
        Label2.Name = "Label2"
        Label2.Size = New Size(160, 23)
        Label2.TabIndex = 1
        Label2.Text = "Belum punya akun?"
        ' 
        ' txtDaftar
        ' 
        txtDaftar.AutoSize = True
        txtDaftar.Cursor = Cursors.Hand
        txtDaftar.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtDaftar.ForeColor = Color.Blue
        txtDaftar.Location = New Point(700, 446)
        txtDaftar.Name = "txtDaftar"
        txtDaftar.Size = New Size(58, 23)
        txtDaftar.TabIndex = 1
        txtDaftar.Text = "Daftar"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(1029, 200)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(255, 288)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(-16, 200)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(255, 288)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 7
        PictureBox4.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(1262, 673)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(btnMasuk)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(PictureBox2)
        Controls.Add(txtDaftar)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormMasuk"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnMasuk As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDaftar As Label
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox

End Class
