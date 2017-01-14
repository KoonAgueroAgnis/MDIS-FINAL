<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMnu
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMnu))
        Me.mnMenu = New System.Windows.Forms.MenuStrip()
        Me.mnAccount = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniManageUA = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupAndRestoreDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnPatientMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniRegisterPatient = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniManagePatient = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnExamination = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniMinorComplaint = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniHealthExamination = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniDentalExamination = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniDailyRecords = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniHealthExamRecords = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniDentalExamRecords = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniMDISinfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemDocumentationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDate = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblTime = New System.Windows.Forms.TextBox()
        Me.mniViewAllPatients = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnMenu
        '
        Me.mnMenu.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.mnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.mnMenu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnMenu.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.mnMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnAccount, Me.mnPatientMenu, Me.mnExamination, Me.mnReports, Me.mnAbout})
        Me.mnMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.mnMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnMenu.Name = "mnMenu"
        Me.mnMenu.Size = New System.Drawing.Size(800, 38)
        Me.mnMenu.TabIndex = 1
        Me.mnMenu.Text = "Menu"
        '
        'mnAccount
        '
        Me.mnAccount.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniLogin, Me.mniManageUA, Me.BackupAndRestoreDatabaseToolStripMenuItem})
        Me.mnAccount.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnAccount.Image = CType(resources.GetObject("mnAccount.Image"), System.Drawing.Image)
        Me.mnAccount.Name = "mnAccount"
        Me.mnAccount.Size = New System.Drawing.Size(105, 34)
        Me.mnAccount.Text = "&Account"
        '
        'mniLogin
        '
        Me.mniLogin.BackColor = System.Drawing.SystemColors.Control
        Me.mniLogin.Image = CType(resources.GetObject("mniLogin.Image"), System.Drawing.Image)
        Me.mniLogin.Name = "mniLogin"
        Me.mniLogin.Size = New System.Drawing.Size(276, 24)
        Me.mniLogin.Text = "&Login"
        '
        'mniManageUA
        '
        Me.mniManageUA.Image = Global.MDIS_DESIGN.My.Resources.Resources.nurse
        Me.mniManageUA.Name = "mniManageUA"
        Me.mniManageUA.Size = New System.Drawing.Size(276, 24)
        Me.mniManageUA.Text = "Manage &User Accounts"
        '
        'BackupAndRestoreDatabaseToolStripMenuItem
        '
        Me.BackupAndRestoreDatabaseToolStripMenuItem.Image = CType(resources.GetObject("BackupAndRestoreDatabaseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BackupAndRestoreDatabaseToolStripMenuItem.Name = "BackupAndRestoreDatabaseToolStripMenuItem"
        Me.BackupAndRestoreDatabaseToolStripMenuItem.Size = New System.Drawing.Size(276, 24)
        Me.BackupAndRestoreDatabaseToolStripMenuItem.Text = "&Backup and Restore Database"
        '
        'mnPatientMenu
        '
        Me.mnPatientMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniRegisterPatient, Me.mniManagePatient})
        Me.mnPatientMenu.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnPatientMenu.Image = CType(resources.GetObject("mnPatientMenu.Image"), System.Drawing.Image)
        Me.mnPatientMenu.Name = "mnPatientMenu"
        Me.mnPatientMenu.Size = New System.Drawing.Size(137, 34)
        Me.mnPatientMenu.Text = "&Patient Menu"
        '
        'mniRegisterPatient
        '
        Me.mniRegisterPatient.Image = CType(resources.GetObject("mniRegisterPatient.Image"), System.Drawing.Image)
        Me.mniRegisterPatient.Name = "mniRegisterPatient"
        Me.mniRegisterPatient.Size = New System.Drawing.Size(193, 24)
        Me.mniRegisterPatient.Text = "&Register a Patient"
        '
        'mniManagePatient
        '
        Me.mniManagePatient.Image = CType(resources.GetObject("mniManagePatient.Image"), System.Drawing.Image)
        Me.mniManagePatient.Name = "mniManagePatient"
        Me.mniManagePatient.Size = New System.Drawing.Size(193, 24)
        Me.mniManagePatient.Text = "&Manage a Patient"
        '
        'mnExamination
        '
        Me.mnExamination.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniMinorComplaint, Me.mniHealthExamination, Me.mniDentalExamination})
        Me.mnExamination.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnExamination.Image = CType(resources.GetObject("mnExamination.Image"), System.Drawing.Image)
        Me.mnExamination.Name = "mnExamination"
        Me.mnExamination.Size = New System.Drawing.Size(133, 34)
        Me.mnExamination.Text = "&Examination"
        '
        'mniMinorComplaint
        '
        Me.mniMinorComplaint.Image = CType(resources.GetObject("mniMinorComplaint.Image"), System.Drawing.Image)
        Me.mniMinorComplaint.Name = "mniMinorComplaint"
        Me.mniMinorComplaint.Size = New System.Drawing.Size(222, 36)
        Me.mniMinorComplaint.Text = "Minor &Complaint"
        '
        'mniHealthExamination
        '
        Me.mniHealthExamination.Image = CType(resources.GetObject("mniHealthExamination.Image"), System.Drawing.Image)
        Me.mniHealthExamination.Name = "mniHealthExamination"
        Me.mniHealthExamination.Size = New System.Drawing.Size(222, 36)
        Me.mniHealthExamination.Text = "&Health Examination"
        '
        'mniDentalExamination
        '
        Me.mniDentalExamination.Image = CType(resources.GetObject("mniDentalExamination.Image"), System.Drawing.Image)
        Me.mniDentalExamination.Name = "mniDentalExamination"
        Me.mniDentalExamination.Size = New System.Drawing.Size(222, 36)
        Me.mniDentalExamination.Text = "&Dental Examination"
        '
        'mnReports
        '
        Me.mnReports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniViewAllPatients, Me.mniDailyRecords, Me.mniHealthExamRecords, Me.mniDentalExamRecords})
        Me.mnReports.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnReports.Image = CType(resources.GetObject("mnReports.Image"), System.Drawing.Image)
        Me.mnReports.Name = "mnReports"
        Me.mnReports.Size = New System.Drawing.Size(102, 34)
        Me.mnReports.Text = "Repor&ts"
        '
        'mniDailyRecords
        '
        Me.mniDailyRecords.Image = CType(resources.GetObject("mniDailyRecords.Image"), System.Drawing.Image)
        Me.mniDailyRecords.Name = "mniDailyRecords"
        Me.mniDailyRecords.Size = New System.Drawing.Size(227, 36)
        Me.mniDailyRecords.Text = "View Daily Reports"
        '
        'mniHealthExamRecords
        '
        Me.mniHealthExamRecords.Image = CType(resources.GetObject("mniHealthExamRecords.Image"), System.Drawing.Image)
        Me.mniHealthExamRecords.Name = "mniHealthExamRecords"
        Me.mniHealthExamRecords.Size = New System.Drawing.Size(227, 36)
        Me.mniHealthExamRecords.Text = "View Health Reports"
        '
        'mniDentalExamRecords
        '
        Me.mniDentalExamRecords.Image = CType(resources.GetObject("mniDentalExamRecords.Image"), System.Drawing.Image)
        Me.mniDentalExamRecords.Name = "mniDentalExamRecords"
        Me.mniDentalExamRecords.Size = New System.Drawing.Size(227, 36)
        Me.mniDentalExamRecords.Text = "View Dental Reports"
        '
        'mnAbout
        '
        Me.mnAbout.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniMDISinfo, Me.SystemDocumentationToolStripMenuItem, Me.SystemHelpToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.mnAbout.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnAbout.Image = CType(resources.GetObject("mnAbout.Image"), System.Drawing.Image)
        Me.mnAbout.Name = "mnAbout"
        Me.mnAbout.Size = New System.Drawing.Size(92, 34)
        Me.mnAbout.Text = "About"
        '
        'mniMDISinfo
        '
        Me.mniMDISinfo.Image = CType(resources.GetObject("mniMDISinfo.Image"), System.Drawing.Image)
        Me.mniMDISinfo.Name = "mniMDISinfo"
        Me.mniMDISinfo.Size = New System.Drawing.Size(341, 24)
        Me.mniMDISinfo.Text = "Medical and Dental Information System"
        '
        'SystemDocumentationToolStripMenuItem
        '
        Me.SystemDocumentationToolStripMenuItem.Image = Global.MDIS_DESIGN.My.Resources.Resources.dna
        Me.SystemDocumentationToolStripMenuItem.Name = "SystemDocumentationToolStripMenuItem"
        Me.SystemDocumentationToolStripMenuItem.Size = New System.Drawing.Size(341, 24)
        Me.SystemDocumentationToolStripMenuItem.Text = "System Documentation"
        '
        'SystemHelpToolStripMenuItem
        '
        Me.SystemHelpToolStripMenuItem.Image = Global.MDIS_DESIGN.My.Resources.Resources.placeholder
        Me.SystemHelpToolStripMenuItem.Name = "SystemHelpToolStripMenuItem"
        Me.SystemHelpToolStripMenuItem.Size = New System.Drawing.Size(341, 24)
        Me.SystemHelpToolStripMenuItem.Text = "System Help"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.MDIS_DESIGN.My.Resources.Resources.aids
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(341, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MenuTimer
        '
        Me.MenuTimer.Enabled = True
        Me.MenuTimer.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Location = New System.Drawing.Point(621, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(179, 38)
        Me.Panel1.TabIndex = 7
        '
        'lblDate
        '
        Me.lblDate.Depth = 0
        Me.lblDate.Enabled = False
        Me.lblDate.Hint = ""
        Me.lblDate.Location = New System.Drawing.Point(0, 18)
        Me.lblDate.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblDate.Name = "lblDate"
        Me.lblDate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblDate.SelectedText = ""
        Me.lblDate.SelectionLength = 0
        Me.lblDate.SelectionStart = 0
        Me.lblDate.Size = New System.Drawing.Size(172, 23)
        Me.lblDate.TabIndex = 8
        Me.lblDate.Text = "DateoftheDay"
        Me.lblDate.UseSystemPasswordChar = False
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblTime.Enabled = False
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(0, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.ReadOnly = True
        Me.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTime.Size = New System.Drawing.Size(173, 20)
        Me.lblTime.TabIndex = 8
        Me.lblTime.Text = "TimeoftheDay"
        '
        'mniViewAllPatients
        '
        Me.mniViewAllPatients.Image = Global.MDIS_DESIGN.My.Resources.Resources.nurse_1
        Me.mniViewAllPatients.Name = "mniViewAllPatients"
        Me.mniViewAllPatients.Size = New System.Drawing.Size(227, 36)
        Me.mniViewAllPatients.Text = "View All Patients"
        '
        'frmMnu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = Global.MDIS_DESIGN.My.Resources.Resources.banner_bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.mnMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnMenu
        Me.MaximizeBox = False
        Me.Name = "frmMnu"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medical and Dental Information System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnMenu.ResumeLayout(False)
        Me.mnMenu.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnMenu As MenuStrip
    Friend WithEvents mnAccount As ToolStripMenuItem
    Friend WithEvents mniLogin As ToolStripMenuItem
    Friend WithEvents mniManageUA As ToolStripMenuItem
    Friend WithEvents mnPatientMenu As ToolStripMenuItem
    Friend WithEvents mniRegisterPatient As ToolStripMenuItem
    Friend WithEvents mniManagePatient As ToolStripMenuItem
    Friend WithEvents mnExamination As ToolStripMenuItem
    Friend WithEvents mniMinorComplaint As ToolStripMenuItem
    Friend WithEvents mniHealthExamination As ToolStripMenuItem
    Friend WithEvents mniDentalExamination As ToolStripMenuItem
    Friend WithEvents mnReports As ToolStripMenuItem
    Friend WithEvents mniDailyRecords As ToolStripMenuItem
    Friend WithEvents mniHealthExamRecords As ToolStripMenuItem
    Friend WithEvents mniDentalExamRecords As ToolStripMenuItem
    Friend WithEvents mnAbout As ToolStripMenuItem
    Friend WithEvents mniMDISinfo As ToolStripMenuItem
    Friend WithEvents BackupAndRestoreDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuTimer As Timer
    Friend WithEvents SystemDocumentationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SystemHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblDate As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblTime As TextBox
    Friend WithEvents mniViewAllPatients As ToolStripMenuItem
End Class
