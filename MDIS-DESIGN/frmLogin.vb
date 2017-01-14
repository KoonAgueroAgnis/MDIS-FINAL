Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmLogin
    Public DBCon As New MySqlConnection

#Region "CheckErrors"
    Private Access As New DBAccess
    Private CurrentRecord As Integer = 0
    Private Function NoErrors(Optional Report As Boolean = False) As Boolean
        If Not String.IsNullOrEmpty(Access.Exception) Then
            If Report = True Then MsgBox(Access.Exception) ' REPORT ERRORS
            Return False
        Else
            Return True
        End If
    End Function
#End Region

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If Len(Trim(txtUsername.Text)) = 0 Then
            MessageBox.Show("Please enter your username")
            txtUsername.Focus()
            Exit Sub
        End If
        If Len(Trim(txtPassword.Text)) = 0 Then
            MessageBox.Show("Please enter your password")
            txtPassword.Focus()
            Exit Sub
        End If
        Try
            Dim DA As New MySqlDataAdapter
            Dim sql As String = "SELECT * FROM tblAdmin"
            Dim DS As New DataSet
            DS.Clear()
            DA.SelectCommand = New MySqlCommand(sql, DBCon)
            DA.Fill(DS, "MDIS2")
            Dim mxRow As Integer = DS.Tables("MDIS2").Rows.Count
            Dim ctr As Integer
            Dim user As String = txtUsername.Text.ToString
            Dim pass As String = txtPassword.Text.ToString
            Dim ok As Boolean = False
            For ctr = 0 To mxRow

                If (DS.Tables("MDIS2").Rows(ctr).Item("Username").ToString = user) Then

                    If (DS.Tables("MDIS2").Rows(ctr).Item("Password").ToString = pass) Then

                        frmMnu.SuccessLogin()

                        Me.Hide()
                        frmMnu.mniLogin.Enabled = True
                        Exit Sub
                    End If

                End If

            Next

        Catch err As MySqlException
            MessageBox.Show("Error" & vbNewLine & err.Message)
        Catch
            MessageBox.Show("Invalid Username or Password")
        End Try
        ' REPORT & ABORT ON ERRORS
        If NoErrors(True) = False Then Exit Sub
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmMnu.mniLogin.Enabled = True
        Me.Hide()

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DBCon.ConnectionString = "server=localhost;user id = root; database = mdis2"
            DBCon.Open()
        Catch err As MySqlException
            MessageBox.Show("Error" & vbNewLine & err.Message)

        End Try

        ' REPORT & ABORT ON ERRORS
        If NoErrors(True) = False Then Exit Sub
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Tab Then
            e.Handled = True
            btnLogin.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress

        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            btnLogin_Click(sender, e)
        Else
            e.Handled = False

        End If
    End Sub

    Private Sub txtUsername_Click(sender As Object, e As EventArgs) Handles txtUsername.Click

    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Tab Then
            e.Handled = True
            txtPassword.Focus()
        End If
    End Sub
End Class