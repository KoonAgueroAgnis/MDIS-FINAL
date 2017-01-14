<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageUsers
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManageUsers))
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.tabManageUser = New MetroFramework.Controls.MetroTabPage()
        Me.chkShow = New MaterialSkin.Controls.MaterialCheckBox()
        Me.txtExtName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtJobTitle = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnLast = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnFirst = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnDelete = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnClear = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnNext = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnPrev = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnEdit = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnAdd = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtPassword = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtUsername = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtMobile = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtAddress = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtLName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtMName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtFName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel10 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtUserID = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.tabSearchUser = New MetroFramework.Controls.MetroTabPage()
        Me.dgvSearchUser = New MetroFramework.Controls.MetroGrid()
        Me.btnClearSearch = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtSearchUser = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnClose = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MetroTabControl1.SuspendLayout()
        Me.tabManageUser.SuspendLayout()
        Me.tabSearchUser.SuspendLayout()
        CType(Me.dgvSearchUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.tabManageUser)
        Me.MetroTabControl1.Controls.Add(Me.tabSearchUser)
        Me.MetroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall
        Me.MetroTabControl1.Location = New System.Drawing.Point(23, 63)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(583, 284)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'tabManageUser
        '
        Me.tabManageUser.Controls.Add(Me.chkShow)
        Me.tabManageUser.Controls.Add(Me.txtExtName)
        Me.tabManageUser.Controls.Add(Me.txtJobTitle)
        Me.tabManageUser.Controls.Add(Me.btnLast)
        Me.tabManageUser.Controls.Add(Me.btnFirst)
        Me.tabManageUser.Controls.Add(Me.btnDelete)
        Me.tabManageUser.Controls.Add(Me.btnClear)
        Me.tabManageUser.Controls.Add(Me.btnNext)
        Me.tabManageUser.Controls.Add(Me.btnPrev)
        Me.tabManageUser.Controls.Add(Me.btnEdit)
        Me.tabManageUser.Controls.Add(Me.btnAdd)
        Me.tabManageUser.Controls.Add(Me.txtPassword)
        Me.tabManageUser.Controls.Add(Me.txtUsername)
        Me.tabManageUser.Controls.Add(Me.txtMobile)
        Me.tabManageUser.Controls.Add(Me.txtAddress)
        Me.tabManageUser.Controls.Add(Me.txtLName)
        Me.tabManageUser.Controls.Add(Me.txtMName)
        Me.tabManageUser.Controls.Add(Me.txtFName)
        Me.tabManageUser.Controls.Add(Me.MaterialLabel8)
        Me.tabManageUser.Controls.Add(Me.MaterialLabel7)
        Me.tabManageUser.Controls.Add(Me.MaterialLabel6)
        Me.tabManageUser.Controls.Add(Me.MaterialLabel5)
        Me.tabManageUser.Controls.Add(Me.MaterialLabel10)
        Me.tabManageUser.Controls.Add(Me.MaterialLabel4)
        Me.tabManageUser.Controls.Add(Me.MaterialLabel3)
        Me.tabManageUser.Controls.Add(Me.MaterialLabel9)
        Me.tabManageUser.Controls.Add(Me.MaterialLabel2)
        Me.tabManageUser.Controls.Add(Me.MaterialLabel1)
        Me.tabManageUser.Controls.Add(Me.txtUserID)
        Me.tabManageUser.HorizontalScrollbarBarColor = True
        Me.tabManageUser.HorizontalScrollbarHighlightOnWheel = False
        Me.tabManageUser.HorizontalScrollbarSize = 10
        Me.tabManageUser.Location = New System.Drawing.Point(4, 44)
        Me.tabManageUser.Name = "tabManageUser"
        Me.tabManageUser.Size = New System.Drawing.Size(575, 236)
        Me.tabManageUser.TabIndex = 0
        Me.tabManageUser.Text = "                  Manage User                  "
        Me.tabManageUser.VerticalScrollbarBarColor = True
        Me.tabManageUser.VerticalScrollbarHighlightOnWheel = False
        Me.tabManageUser.VerticalScrollbarSize = 10
        '
        'chkShow
        '
        Me.chkShow.AutoSize = True
        Me.chkShow.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.chkShow.Checked = True
        Me.chkShow.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShow.Depth = 0
        Me.chkShow.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.chkShow.Location = New System.Drawing.Point(538, 144)
        Me.chkShow.Margin = New System.Windows.Forms.Padding(0)
        Me.chkShow.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkShow.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkShow.Name = "chkShow"
        Me.chkShow.Ripple = True
        Me.chkShow.Size = New System.Drawing.Size(26, 30)
        Me.chkShow.TabIndex = 26
        Me.chkShow.UseVisualStyleBackColor = True
        '
        'txtExtName
        '
        Me.txtExtName.Depth = 0
        Me.txtExtName.Hint = " Input Ext Name"
        Me.txtExtName.Location = New System.Drawing.Point(109, 144)
        Me.txtExtName.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtExtName.Name = "txtExtName"
        Me.txtExtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtExtName.SelectedText = ""
        Me.txtExtName.SelectionLength = 0
        Me.txtExtName.SelectionStart = 0
        Me.txtExtName.Size = New System.Drawing.Size(176, 23)
        Me.txtExtName.TabIndex = 25
        Me.txtExtName.UseSystemPasswordChar = False
        '
        'txtJobTitle
        '
        Me.txtJobTitle.Depth = 0
        Me.txtJobTitle.Hint = " Input Job Title"
        Me.txtJobTitle.Location = New System.Drawing.Point(386, 56)
        Me.txtJobTitle.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtJobTitle.Name = "txtJobTitle"
        Me.txtJobTitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJobTitle.SelectedText = ""
        Me.txtJobTitle.SelectionLength = 0
        Me.txtJobTitle.SelectionStart = 0
        Me.txtJobTitle.Size = New System.Drawing.Size(172, 23)
        Me.txtJobTitle.TabIndex = 24
        Me.txtJobTitle.UseSystemPasswordChar = False
        '
        'btnLast
        '
        Me.btnLast.AutoSize = True
        Me.btnLast.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLast.Depth = 0
        Me.btnLast.Location = New System.Drawing.Point(453, 195)
        Me.btnLast.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnLast.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Primary = False
        Me.btnLast.Size = New System.Drawing.Size(26, 36)
        Me.btnLast.TabIndex = 23
        Me.btnLast.Text = ">>"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.AutoSize = True
        Me.btnFirst.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnFirst.Depth = 0
        Me.btnFirst.Location = New System.Drawing.Point(87, 195)
        Me.btnFirst.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnFirst.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Primary = False
        Me.btnFirst.Size = New System.Drawing.Size(26, 36)
        Me.btnFirst.TabIndex = 22
        Me.btnFirst.Text = "<<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Depth = 0
        Me.btnDelete.Location = New System.Drawing.Point(285, 195)
        Me.btnDelete.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Primary = True
        Me.btnDelete.Size = New System.Drawing.Size(64, 36)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Depth = 0
        Me.btnClear.Location = New System.Drawing.Point(355, 195)
        Me.btnClear.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Primary = True
        Me.btnClear.Size = New System.Drawing.Size(64, 36)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.AutoSize = True
        Me.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNext.Depth = 0
        Me.btnNext.Location = New System.Drawing.Point(426, 195)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnNext.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Primary = False
        Me.btnNext.Size = New System.Drawing.Size(19, 36)
        Me.btnNext.TabIndex = 19
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.AutoSize = True
        Me.btnPrev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPrev.Depth = 0
        Me.btnPrev.Location = New System.Drawing.Point(121, 195)
        Me.btnPrev.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnPrev.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Primary = False
        Me.btnPrev.Size = New System.Drawing.Size(19, 36)
        Me.btnPrev.TabIndex = 16
        Me.btnPrev.Text = "<"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Depth = 0
        Me.btnEdit.Location = New System.Drawing.Point(217, 195)
        Me.btnEdit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Primary = True
        Me.btnEdit.Size = New System.Drawing.Size(64, 36)
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Depth = 0
        Me.btnAdd.Location = New System.Drawing.Point(147, 195)
        Me.btnAdd.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Primary = True
        Me.btnAdd.Size = New System.Drawing.Size(64, 36)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Depth = 0
        Me.txtPassword.Hint = " Input Password"
        Me.txtPassword.Location = New System.Drawing.Point(386, 148)
        Me.txtPassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.Size = New System.Drawing.Size(158, 23)
        Me.txtPassword.TabIndex = 10
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Depth = 0
        Me.txtUsername.Hint = " Input Username"
        Me.txtUsername.Location = New System.Drawing.Point(386, 114)
        Me.txtUsername.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.SelectionLength = 0
        Me.txtUsername.SelectionStart = 0
        Me.txtUsername.Size = New System.Drawing.Size(172, 23)
        Me.txtUsername.TabIndex = 9
        Me.txtUsername.UseSystemPasswordChar = False
        '
        'txtMobile
        '
        Me.txtMobile.Depth = 0
        Me.txtMobile.Hint = " Input Mobile Number"
        Me.txtMobile.Location = New System.Drawing.Point(386, 85)
        Me.txtMobile.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMobile.SelectedText = ""
        Me.txtMobile.SelectionLength = 0
        Me.txtMobile.SelectionStart = 0
        Me.txtMobile.Size = New System.Drawing.Size(172, 23)
        Me.txtMobile.TabIndex = 8
        Me.txtMobile.UseSystemPasswordChar = False
        '
        'txtAddress
        '
        Me.txtAddress.Depth = 0
        Me.txtAddress.Hint = " Input Home Address"
        Me.txtAddress.Location = New System.Drawing.Point(386, 27)
        Me.txtAddress.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.SelectionLength = 0
        Me.txtAddress.SelectionStart = 0
        Me.txtAddress.Size = New System.Drawing.Size(176, 23)
        Me.txtAddress.TabIndex = 7
        Me.txtAddress.UseSystemPasswordChar = False
        '
        'txtLName
        '
        Me.txtLName.Depth = 0
        Me.txtLName.Hint = " Input Last Name"
        Me.txtLName.Location = New System.Drawing.Point(109, 114)
        Me.txtLName.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtLName.Name = "txtLName"
        Me.txtLName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLName.SelectedText = ""
        Me.txtLName.SelectionLength = 0
        Me.txtLName.SelectionStart = 0
        Me.txtLName.Size = New System.Drawing.Size(176, 23)
        Me.txtLName.TabIndex = 6
        Me.txtLName.UseSystemPasswordChar = False
        '
        'txtMName
        '
        Me.txtMName.Depth = 0
        Me.txtMName.Hint = " Input Middle Name"
        Me.txtMName.Location = New System.Drawing.Point(109, 80)
        Me.txtMName.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtMName.Name = "txtMName"
        Me.txtMName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMName.SelectedText = ""
        Me.txtMName.SelectionLength = 0
        Me.txtMName.SelectionStart = 0
        Me.txtMName.Size = New System.Drawing.Size(176, 23)
        Me.txtMName.TabIndex = 5
        Me.txtMName.UseSystemPasswordChar = False
        '
        'txtFName
        '
        Me.txtFName.Depth = 0
        Me.txtFName.Hint = " Input First Name"
        Me.txtFName.Location = New System.Drawing.Point(109, 46)
        Me.txtFName.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtFName.Name = "txtFName"
        Me.txtFName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFName.SelectedText = ""
        Me.txtFName.SelectionLength = 0
        Me.txtFName.SelectionStart = 0
        Me.txtFName.Size = New System.Drawing.Size(176, 23)
        Me.txtFName.TabIndex = 4
        Me.txtFName.UseSystemPasswordChar = False
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.AutoSize = True
        Me.MaterialLabel8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel8.Location = New System.Drawing.Point(301, 152)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(79, 19)
        Me.MaterialLabel8.TabIndex = 3
        Me.MaterialLabel8.Text = "Password:"
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(299, 118)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(81, 19)
        Me.MaterialLabel7.TabIndex = 3
        Me.MaterialLabel7.Text = "Username:"
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(321, 89)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(59, 19)
        Me.MaterialLabel6.TabIndex = 3
        Me.MaterialLabel6.Text = "Mobile:"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(312, 31)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(68, 19)
        Me.MaterialLabel5.TabIndex = 3
        Me.MaterialLabel5.Text = "Address:"
        '
        'MaterialLabel10
        '
        Me.MaterialLabel10.AutoSize = True
        Me.MaterialLabel10.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MaterialLabel10.Depth = 0
        Me.MaterialLabel10.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel10.Location = New System.Drawing.Point(25, 148)
        Me.MaterialLabel10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel10.Name = "MaterialLabel10"
        Me.MaterialLabel10.Size = New System.Drawing.Size(78, 19)
        Me.MaterialLabel10.TabIndex = 3
        Me.MaterialLabel10.Text = "Ext Name:"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(17, 118)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(86, 19)
        Me.MaterialLabel4.TabIndex = 3
        Me.MaterialLabel4.Text = "Last Name:"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(1, 84)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(102, 19)
        Me.MaterialLabel3.TabIndex = 3
        Me.MaterialLabel3.Text = "Middle Name:"
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.AutoSize = True
        Me.MaterialLabel9.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel9.Location = New System.Drawing.Point(308, 60)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(72, 19)
        Me.MaterialLabel9.TabIndex = 3
        Me.MaterialLabel9.Text = "Job Title:"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(16, 50)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(87, 19)
        Me.MaterialLabel2.TabIndex = 3
        Me.MaterialLabel2.Text = "First Name:"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(41, 16)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(62, 19)
        Me.MaterialLabel1.TabIndex = 3
        Me.MaterialLabel1.Text = "User ID:"
        '
        'txtUserID
        '
        Me.txtUserID.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtUserID.Depth = 0
        Me.txtUserID.Hint = " Automatically Generated"
        Me.txtUserID.Location = New System.Drawing.Point(109, 12)
        Me.txtUserID.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUserID.SelectedText = ""
        Me.txtUserID.SelectionLength = 0
        Me.txtUserID.SelectionStart = 0
        Me.txtUserID.Size = New System.Drawing.Size(176, 23)
        Me.txtUserID.TabIndex = 2
        Me.txtUserID.UseSystemPasswordChar = False
        '
        'tabSearchUser
        '
        Me.tabSearchUser.Controls.Add(Me.dgvSearchUser)
        Me.tabSearchUser.Controls.Add(Me.btnClearSearch)
        Me.tabSearchUser.Controls.Add(Me.txtSearchUser)
        Me.tabSearchUser.HorizontalScrollbarBarColor = True
        Me.tabSearchUser.HorizontalScrollbarHighlightOnWheel = False
        Me.tabSearchUser.HorizontalScrollbarSize = 10
        Me.tabSearchUser.Location = New System.Drawing.Point(4, 44)
        Me.tabSearchUser.Name = "tabSearchUser"
        Me.tabSearchUser.Size = New System.Drawing.Size(575, 236)
        Me.tabSearchUser.TabIndex = 1
        Me.tabSearchUser.Text = "                  Search User                   "
        Me.tabSearchUser.VerticalScrollbarBarColor = True
        Me.tabSearchUser.VerticalScrollbarHighlightOnWheel = False
        Me.tabSearchUser.VerticalScrollbarSize = 10
        '
        'dgvSearchUser
        '
        Me.dgvSearchUser.AllowUserToOrderColumns = True
        Me.dgvSearchUser.AllowUserToResizeRows = False
        Me.dgvSearchUser.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSearchUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSearchUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvSearchUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSearchUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSearchUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSearchUser.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSearchUser.EnableHeadersVisualStyles = False
        Me.dgvSearchUser.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvSearchUser.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSearchUser.Location = New System.Drawing.Point(3, 3)
        Me.dgvSearchUser.Name = "dgvSearchUser"
        Me.dgvSearchUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSearchUser.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSearchUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvSearchUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSearchUser.Size = New System.Drawing.Size(576, 198)
        Me.dgvSearchUser.TabIndex = 4
        '
        'btnClearSearch
        '
        Me.btnClearSearch.Depth = 0
        Me.btnClearSearch.Location = New System.Drawing.Point(366, 207)
        Me.btnClearSearch.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnClearSearch.Name = "btnClearSearch"
        Me.btnClearSearch.Primary = True
        Me.btnClearSearch.Size = New System.Drawing.Size(78, 26)
        Me.btnClearSearch.TabIndex = 3
        Me.btnClearSearch.Text = "Clear"
        Me.btnClearSearch.UseVisualStyleBackColor = True
        '
        'txtSearchUser
        '
        Me.txtSearchUser.Depth = 0
        Me.txtSearchUser.Hint = "  Type to search"
        Me.txtSearchUser.Location = New System.Drawing.Point(116, 210)
        Me.txtSearchUser.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtSearchUser.Name = "txtSearchUser"
        Me.txtSearchUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchUser.SelectedText = ""
        Me.txtSearchUser.SelectionLength = 0
        Me.txtSearchUser.SelectionStart = 0
        Me.txtSearchUser.Size = New System.Drawing.Size(244, 23)
        Me.txtSearchUser.TabIndex = 2
        Me.txtSearchUser.UseSystemPasswordChar = False
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnClose.Depth = 0
        Me.btnClose.Location = New System.Drawing.Point(565, 7)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnClose.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Primary = False
        Me.btnClose.Size = New System.Drawing.Size(54, 36)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmManageUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 361)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "frmManageUsers"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "User Accounts"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.tabManageUser.ResumeLayout(False)
        Me.tabManageUser.PerformLayout()
        Me.tabSearchUser.ResumeLayout(False)
        CType(Me.dgvSearchUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabManageUser As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtUserID As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents tabSearchUser As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnAdd As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtPassword As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtUsername As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtMobile As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtAddress As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtLName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtMName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtFName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnPrev As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnEdit As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnClearSearch As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtSearchUser As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents dgvSearchUser As MetroFramework.Controls.MetroGrid
    Friend WithEvents btnClose As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnDelete As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnClear As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnNext As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txtJobTitle As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btnLast As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnFirst As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtExtName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel10 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents chkShow As MaterialSkin.Controls.MaterialCheckBox
End Class
