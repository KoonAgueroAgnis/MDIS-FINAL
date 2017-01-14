<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.msMenu = New System.Windows.Forms.MenuStrip()
        Me.mnAccount = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniManageAccounts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniBackupRestore = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mniRegisterPatient = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniManagePatient = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnExam = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnMinorComplaint = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnHealth = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniDental = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniDailyRecords = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniHealthReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniDentalReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniTeamMDIS = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniMDIS = New System.Windows.Forms.ToolStripMenuItem()
        Me.msMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMenu
        '
        Me.msMenu.BackColor = System.Drawing.Color.White
        Me.msMenu.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnAccount, Me.mnHome, Me.mnExam, Me.mnReports, Me.mnAbout})
        Me.msMenu.Location = New System.Drawing.Point(20, 60)
        Me.msMenu.Name = "msMenu"
        Me.msMenu.Size = New System.Drawing.Size(760, 28)
        Me.msMenu.TabIndex = 2
        Me.msMenu.Text = "Menu"
        '
        'mnAccount
        '
        Me.mnAccount.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniLogin, Me.mniManageAccounts, Me.mniBackupRestore})
        Me.mnAccount.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnAccount.Image = Global.MDIS_DESIGN.My.Resources.Resources.mpcLogo
        Me.mnAccount.Name = "mnAccount"
        Me.mnAccount.Size = New System.Drawing.Size(91, 24)
        Me.mnAccount.Text = "Account"
        Me.mnAccount.ToolTipText = "Login Account"
        '
        'mniLogin
        '
        Me.mniLogin.Name = "mniLogin"
        Me.mniLogin.Size = New System.Drawing.Size(276, 24)
        Me.mniLogin.Text = "&Login"
        '
        'mniManageAccounts
        '
        Me.mniManageAccounts.Name = "mniManageAccounts"
        Me.mniManageAccounts.Size = New System.Drawing.Size(276, 24)
        Me.mniManageAccounts.Text = "Manage &Accounts"
        '
        'mniBackupRestore
        '
        Me.mniBackupRestore.Name = "mniBackupRestore"
        Me.mniBackupRestore.Size = New System.Drawing.Size(276, 24)
        Me.mniBackupRestore.Text = "&Backup and Restore Database"
        '
        'mnHome
        '
        Me.mnHome.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.mniRegisterPatient, Me.mniManagePatient})
        Me.mnHome.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnHome.Name = "mnHome"
        Me.mnHome.Size = New System.Drawing.Size(62, 24)
        Me.mnHome.Text = "Home"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(190, 6)
        '
        'mniRegisterPatient
        '
        Me.mniRegisterPatient.Name = "mniRegisterPatient"
        Me.mniRegisterPatient.Size = New System.Drawing.Size(193, 24)
        Me.mniRegisterPatient.Text = "&Register a Patient"
        '
        'mniManagePatient
        '
        Me.mniManagePatient.Name = "mniManagePatient"
        Me.mniManagePatient.Size = New System.Drawing.Size(193, 24)
        Me.mniManagePatient.Text = "&Manage a Patient"
        '
        'mnExam
        '
        Me.mnExam.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnMinorComplaint, Me.mnHealth, Me.mniDental})
        Me.mnExam.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnExam.Name = "mnExam"
        Me.mnExam.Size = New System.Drawing.Size(103, 24)
        Me.mnExam.Text = "Examination"
        '
        'mnMinorComplaint
        '
        Me.mnMinorComplaint.Name = "mnMinorComplaint"
        Me.mnMinorComplaint.Size = New System.Drawing.Size(208, 24)
        Me.mnMinorComplaint.Text = "Minor &Complaint"
        '
        'mnHealth
        '
        Me.mnHealth.Name = "mnHealth"
        Me.mnHealth.Size = New System.Drawing.Size(208, 24)
        Me.mnHealth.Text = "&Health Examination"
        '
        'mniDental
        '
        Me.mniDental.Name = "mniDental"
        Me.mniDental.Size = New System.Drawing.Size(208, 24)
        Me.mniDental.Text = "&Dental Examination"
        '
        'mnReports
        '
        Me.mnReports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniDailyRecords, Me.mniHealthReports, Me.mniDentalReports})
        Me.mnReports.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnReports.Name = "mnReports"
        Me.mnReports.Size = New System.Drawing.Size(72, 24)
        Me.mnReports.Text = "Reports"
        '
        'mniDailyRecords
        '
        Me.mniDailyRecords.Name = "mniDailyRecords"
        Me.mniDailyRecords.Size = New System.Drawing.Size(299, 24)
        Me.mniDailyRecords.Text = "View Daily Records"
        '
        'mniHealthReports
        '
        Me.mniHealthReports.Name = "mniHealthReports"
        Me.mniHealthReports.Size = New System.Drawing.Size(299, 24)
        Me.mniHealthReports.Text = "View Health Examination Reports"
        '
        'mniDentalReports
        '
        Me.mniDentalReports.Name = "mniDentalReports"
        Me.mniDentalReports.Size = New System.Drawing.Size(299, 24)
        Me.mniDentalReports.Text = "View Dental Examination Reports"
        '
        'mnAbout
        '
        Me.mnAbout.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniTeamMDIS, Me.mniMDIS})
        Me.mnAbout.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnAbout.Name = "mnAbout"
        Me.mnAbout.Size = New System.Drawing.Size(62, 24)
        Me.mnAbout.Text = "About"
        '
        'mniTeamMDIS
        '
        Me.mniTeamMDIS.Name = "mniTeamMDIS"
        Me.mniTeamMDIS.Size = New System.Drawing.Size(154, 24)
        Me.mniTeamMDIS.Text = "Team MDIS"
        '
        'mniMDIS
        '
        Me.mniMDIS.Name = "mniMDIS"
        Me.mniMDIS.Size = New System.Drawing.Size(154, 24)
        Me.mniMDIS.Text = "MDIS"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.msMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Movable = False
        Me.Name = "frmMenu"
        Me.Resizable = False
        Me.Text = "Medical and Dental Information System"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Empty
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.msMenu.ResumeLayout(False)
        Me.msMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msMenu As MenuStrip
    Friend WithEvents mnAccount As ToolStripMenuItem
    Friend WithEvents mniLogin As ToolStripMenuItem
    Friend WithEvents mniManageAccounts As ToolStripMenuItem
    Friend WithEvents mnHome As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mniRegisterPatient As ToolStripMenuItem
    Friend WithEvents mniManagePatient As ToolStripMenuItem
    Friend WithEvents mnExam As ToolStripMenuItem
    Friend WithEvents mnMinorComplaint As ToolStripMenuItem
    Friend WithEvents mnHealth As ToolStripMenuItem
    Friend WithEvents mniDental As ToolStripMenuItem
    Friend WithEvents mnReports As ToolStripMenuItem
    Friend WithEvents mniBackupRestore As ToolStripMenuItem
    Friend WithEvents mniDailyRecords As ToolStripMenuItem
    Friend WithEvents mniHealthReports As ToolStripMenuItem
    Friend WithEvents mniDentalReports As ToolStripMenuItem
    Friend WithEvents mnAbout As ToolStripMenuItem
    Friend WithEvents mniTeamMDIS As ToolStripMenuItem
    Friend WithEvents mniMDIS As ToolStripMenuItem
End Class
