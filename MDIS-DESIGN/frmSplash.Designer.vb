<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplash))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.LoadingBar = New MetroFramework.Controls.MetroProgressBar()
        Me.tmrLoading = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblLoading = New MetroFramework.Controls.MetroLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MDIS_DESIGN.My.Resources.Resources.mpcLogo
        Me.PictureBox1.Location = New System.Drawing.Point(4, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(81, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(84, 59)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(325, 25)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Medical and Dental Information System"
        '
        'LoadingBar
        '
        Me.LoadingBar.HideProgressText = False
        Me.LoadingBar.Location = New System.Drawing.Point(23, 139)
        Me.LoadingBar.Name = "LoadingBar"
        Me.LoadingBar.Size = New System.Drawing.Size(444, 21)
        Me.LoadingBar.Step = 100
        Me.LoadingBar.Style = MetroFramework.MetroColorStyle.Teal
        Me.LoadingBar.TabIndex = 2
        Me.LoadingBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(405, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(81, 83)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'lblLoading
        '
        Me.lblLoading.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoading.AutoSize = True
        Me.lblLoading.Location = New System.Drawing.Point(210, 117)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(64, 19)
        Me.lblLoading.TabIndex = 3
        Me.lblLoading.Text = "Starting..."
        Me.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 171)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblLoading)
        Me.Controls.Add(Me.LoadingBar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmSplash"
        Me.Resizable = False
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Mallig Plains Colleges"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents LoadingBar As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents tmrLoading As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblLoading As MetroFramework.Controls.MetroLabel
End Class
