Public Class frmManageUsers
    Private Access As New DBAccess

    Private CurrentRecord As Integer = 0
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "Add" Then
            btnAdd.Text = "Save"
            btnClear.Enabled = True
            EnableInputs()
            ClearAll()
            btnDelete.Visible = False
            btnEdit.Text = "Cancel"
            EnableNavi(False)
        ElseIf btnAdd.Text = "Save"
            Access.AddParam("@fname", txtFName.Text)
            Access.AddParam("@mname", txtMName.Text)
            Access.AddParam("@lname", txtLName.Text)
            Access.AddParam("@extname", txtExtName.Text)
            Access.AddParam("@address", txtAddress.Text)
            Access.AddParam("@jobtitle", txtJobTitle.Text)
            Access.AddParam("@mobileno", txtMobile.Text)
            Access.AddParam("@username", txtUsername.Text)
            Access.AddParam("@password", txtPassword.Text)
            Access.AddParam("@uid", txtUserID.Text)

            ' RUN COMMAND
            Access.ExecQuery("INSERT INTO tblAdmin (AdmFName, AdmMname, AdmLName, AdmExtName, AdmAddress, JobTitle, Mobile, Username, Password) VALUES (@fname, @mname, @lname, @extname, @address, @jobtitle, @mobileno, @username, @password); ")

            ' REPORT & ABORT ON ERRORS
            If NoErrors(True) = False Then Exit Sub

            ' REFRESH THE USERS DATATABLE & FETCH CURRENT RECORD
            GetPatients()
            MessageBox.Show("User Information Updated")
            DisableInputs()
            ' EXECUTE INSERT COMMAND
            btnClear.Enabled = False
            btnDelete.Visible = True
            btnEdit.Text = "Edit"
            btnAdd.Text = "Add"
            EnableNavi(True)
        ElseIf btnAdd.Text = "Cancel" Then
            btnAdd.Text = "Add"
            EnableNavi(True)
            DisableInputs()
            btnEdit.Text = "Edit"
            btnDelete.Enabled = False
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearAll()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' CONFIRM DELETE
        If MsgBox("Are you sure that you want to delete the selected user?", MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.No Then Exit Sub

        ' DELETE SELECTED USER
        Access.AddParam("@uid", txtUserID.Text)
        Access.ExecQuery("DELETE FROM tblAdmin WHERE AdminID=@uid")

        ' REPORT & ABORT ON ERRORS
        If NoErrors(True) = False Then Exit Sub

        ' CLEANUP & REFRESH

        DisableInputs()
        btnClear.Enabled = False
        btnDelete.Visible = True
        btnEdit.Text = "Edit"
        btnAdd.Text = "Add"
        EnableNavi(True)
        ClearAll()
        GetPatients()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Edit" Then
            btnEdit.Text = "Update"
            EnableInputs()
            btnDelete.Enabled = True
            btnAdd.Text = "Cancel"
        ElseIf btnEdit.Text = "Update" Then
            ' FAIL IF NO USER SELECTED
            If String.IsNullOrEmpty(txtUserID.Text) Then Exit Sub

            ' ADD PARAMETERS
            Access.AddParam("@fname", txtFName.Text)
            Access.AddParam("@mname", txtMName.Text)
            Access.AddParam("@lname", txtLName.Text)
            Access.AddParam("@extname", txtExtName.Text)
            Access.AddParam("@address", txtAddress.Text)
            Access.AddParam("@jobtitle", txtJobTitle.Text)
            Access.AddParam("@mobileno", txtMobile.Text)
            Access.AddParam("@username", txtUsername.Text)
            Access.AddParam("@password", txtPassword.Text)
            Access.AddParam("@aid", txtUserID.Text)

            ' RUN COMMAND
            Access.ExecQuery("UPDATE tblAdmin SET AdmFName=@fname,AdmMName=@mname,AdmLName=@lname,AdmExtName=@extname,AdmAddress=@address,JobTitle=@jobtitle,Mobile=@mobileno,Username=@username,Password=@password WHERE AdminID=@aid")

            ' REPORT & ABORT ON ERRORS
            If NoErrors(True) = False Then Exit Sub

            ' REFRESH THE USERS DATATABLE & FETCH CURRENT RECORD
            GetPatients()
            MessageBox.Show("User Information Updated")
            DisableInputs()
            btnDelete.Enabled = False
            btnAdd.Text = "Add"
            btnEdit.Text = "Edit"
        ElseIf btnEdit.Text = "Cancel"
            btnAdd.Text = "Add"
            btnEdit.Text = "Edit"
            btnDelete.Visible = True
            btnClear.Enabled = False
            DisableInputs()
            EnableNavi(True)
            GetRecords()
        End If
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        CurrentRecord = 0
        GetPatients()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        CurrentRecord = Access.DBDT.Rows.Count - 1
        GetRecords()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        NextRecord(1)
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        NextRecord(-1)
    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        If chkShow.Checked = True Then
            txtPassword.UseSystemPasswordChar = True
        ElseIf chkShow.Checked = False Then
            txtPassword.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub ClearAll()
        txtUserID.Clear()
        txtFName.Clear()
        txtMName.Clear()
        txtLName.Clear()
        txtExtName.Clear()
        txtAddress.Clear()
        txtJobTitle.Clear()
        txtMobile.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub DisableInputs()
        txtUserID.Enabled = 0
        txtFName.Enabled = 0
        txtMName.Enabled = 0
        txtLName.Enabled = 0
        txtExtName.Enabled = 0
        txtAddress.Enabled = 0
        txtJobTitle.Enabled = 0
        txtMobile.Enabled = 0
        txtUsername.Enabled = 0
        txtPassword.Enabled = 0
        chkShow.Enabled = 0
    End Sub

    Private Sub EnableInputs()
        txtFName.Enabled = 1
        txtMName.Enabled = 1
        txtLName.Enabled = 1
        txtExtName.Enabled = 1
        txtAddress.Enabled = 1
        txtJobTitle.Enabled = 1
        txtMobile.Enabled = 1
        txtUsername.Enabled = 1
        txtPassword.Enabled = 1
        chkShow.Enabled = 1
    End Sub

    Private Sub EnableNavi(ByVal NavStatus As Boolean)
        btnFirst.Enabled = NavStatus
        btnNext.Enabled = NavStatus
        btnPrev.Enabled = NavStatus
        btnLast.Enabled = NavStatus

    End Sub

    Private Sub frmManageUsers_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        GetPatients()
        DisableInputs()
        btnClear.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub GetPatients()
        ' QUERY USERS TO FILL DATA TABLE
        Access.ExecQuery("SELECT * FROM tblAdmin")
        dgvSearchUser.DataSource = Access.DBDT
        ' REPORT & ABORT ON ERRORS
        If NoErrors(True) = False Then Exit Sub

        ' GET FIRST RECORD
        GetRecords()
    End Sub

    Private Sub GetRecords()
        ' FAIL IF NO RECORDS FOUND OR POSITION IS OUT OF RANGE
        If Access.DBDT.Rows.Count < 1 OrElse CurrentRecord > Access.DBDT.Rows.Count - 1 Then Exit Sub

        ' RETRN FIRST USER FOUND
        Dim r As DataRow = Access.DBDT.Rows(CurrentRecord)

        ' POPULATE FIELDS

        txtFName.Text = r("AdmFName").ToString
        txtMName.Text = r("AdmMName").ToString
        txtLName.Text = r("AdmLName").ToString
        txtExtName.Text = r("AdmExtName").ToString
        txtAddress.Text = r("AdmAddress").ToString
        txtJobTitle.Text = r("JobTitle").ToString
        txtMobile.Text = r("Mobile").ToString
        txtUsername.Text = r("Username").ToString
        txtPassword.Text = r("Password").ToString
        txtUserID.Text = r("AdminID").ToString

    End Sub

    Private Sub NextRecord(AddVal As Integer)
        CurrentRecord += AddVal ' Advance position by AddVal
        If CurrentRecord > Access.DBDT.Rows.Count - 1 Then CurrentRecord = 0 ' Loop to first record
        If CurrentRecord < 0 Then CurrentRecord = Access.DBDT.Rows.Count - 1 ' Loop to last record

        ' UPDATE FORM
        GetRecords()
    End Sub

    ' ERROR CHECKING & REPORTING
    Private Function NoErrors(Optional Report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(Access.Exception) Then
            If Report = True Then MsgBox(Access.Exception) ' REPORT ERRORS
            Return False
        Else
            Return True
        End If
    End Function
End Class