Public Class frmMnu
    Public Sub SuccessLogin()
        mniManageUA.Visible = True
        mnPatientMenu.Visible = True
        mnExamination.Visible = True
        mnReports.Visible = True
        mniLogin.Text = "Logout"
    End Sub

    Private Sub BackupAndRestoreDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupAndRestoreDatabaseToolStripMenuItem.Click
        Dim BRDb As frmBackupRestore
        BRDb = New frmBackupRestore
        BRDb.MdiParent = Me
        BRDb.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub frmMnu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub frmMnu_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Startup()
    End Sub

    Private Sub lblTime_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuTimer_Tick(sender As Object, e As EventArgs) Handles MenuTimer.Tick
        lblTime.Text = TimeOfDay
        lblDate.Text = Format(Now, "Long Date")
    End Sub

    Private Sub mnAbout_Click(sender As Object, e As EventArgs) Handles mnAbout.Click

    End Sub

    Private Sub mniDailyRecords_Click(sender As Object, e As EventArgs) Handles mniDailyRecords.Click

    End Sub

    Private Sub mniDentalExamination_Click(sender As Object, e As EventArgs) Handles mniDentalExamination.Click
        Dim DentalExam As frmDentalExamination
        DentalExam = New frmDentalExamination
        DentalExam.MdiParent = Me
        DentalExam.Show()
    End Sub

    Private Sub mniDentalExamRecords_Click(sender As Object, e As EventArgs) Handles mniDentalExamRecords.Click

    End Sub

    Private Sub mniHealthExamination_Click(sender As Object, e As EventArgs) Handles mniHealthExamination.Click
        Dim HealthExam As frmHeathExamination
        HealthExam = New frmHeathExamination
        HealthExam.MdiParent = Me
        HealthExam.Show()
    End Sub

    Private Sub mniHealthExamRecords_Click(sender As Object, e As EventArgs) Handles mniHealthExamRecords.Click

    End Sub

    Private Sub mniManagePatient_Click(sender As Object, e As EventArgs) Handles mniManagePatient.Click
        Dim ManagePatient As frmManagePatient
        ManagePatient = New frmManagePatient
        ManagePatient.MdiParent = Me
        ManagePatient.Show()
    End Sub

    Private Sub mniManageUA_Click(sender As Object, e As EventArgs) Handles mniManageUA.Click
        Dim ManageUA As frmManageUsers
        ManageUA = New frmManageUsers
        ManageUA.MdiParent = Me
        ManageUA.Show()
    End Sub

    Private Sub mniMDISinfo_Click(sender As Object, e As EventArgs) Handles mniMDISinfo.Click
        'Dim MDISInfo As frmAbout
        'MDISInfo = New frmAbout
        'MDISInfo.MdiParent = Me
        'MDISInfo.Show()
    End Sub

    Private Sub mniMinorComplaint_Click(sender As Object, e As EventArgs) Handles mniMinorComplaint.Click
        Dim MinorComplaint As frmMinorComplaints
        MinorComplaint = New frmMinorComplaints
        MinorComplaint.MdiParent = Me
        MinorComplaint.Show()
    End Sub

    Private Sub mniRegisterPatient_Click(sender As Object, e As EventArgs) Handles mniRegisterPatient.Click
        Dim RegisterPatient As frmMenuTab
        RegisterPatient = New frmMenuTab
        RegisterPatient.MdiParent = Me
        RegisterPatient.Show()
    End Sub

    Private Sub mniViewAllPatients_Click(sender As Object, e As EventArgs) Handles mniViewAllPatients.Click

    End Sub

    Private Sub mnLogin_Click(sender As Object, e As EventArgs) Handles mniLogin.Click
        If mniLogin.Text = "Login" Then
            Dim Login As frmLogin
            Login = New frmLogin
            Login.MdiParent = Me
            Login.Show()
            mniLogin.Enabled = False
        ElseIf mniLogin.Text = "Logout" Then
            Startup()
            mniLogin.Enabled = True
        End If

    End Sub
    Private Sub Startup()
        mniLogin.Visible = True
        mniLogin.Text = "Login"
        mniManageUA.Visible = False
        mnPatientMenu.Visible = False
        mnExamination.Visible = False
        mnReports.Visible = False
    End Sub
End Class