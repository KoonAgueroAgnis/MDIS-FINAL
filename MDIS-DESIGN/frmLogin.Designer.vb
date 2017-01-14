<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.txtUsername = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtPassword = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnLogin = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.Depth = 0
        Me.txtUsername.Hint = "Input Username"
        Me.txtUsername.Location = New System.Drawing.Point(137, 63)
        Me.txtUsername.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.SelectionLength = 0
        Me.txtUsername.SelectionStart = 0
        Me.txtUsername.Size = New System.Drawing.Size(181, 23)
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.UseSystemPasswordChar = False
        '
        'txtPassword
        '
        Me.txtPassword.Depth = 0
        Me.txtPassword.Hint = "Input Password"
        Me.txtPassword.Location = New System.Drawing.Point(137, 103)
        Me.txtPassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.Size = New System.Drawing.Size(181, 23)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.Depth = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Location = New System.Drawing.Point(324, 63)
        Me.btnLogin.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Primary = True
        Me.btnLogin.Size = New System.Drawing.Size(75, 63)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MDIS_DESIGN.My.Resources.Resources.mpcLogo
        Me.PictureBox1.Location = New System.Drawing.Point(10, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(393, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(22, 22)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 149)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmLogin"
        Me.Resizable = False
        Me.Text = " Medical and Dental Clinic"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtUsername As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtPassword As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btnLogin As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Button1 As Button
End Class
