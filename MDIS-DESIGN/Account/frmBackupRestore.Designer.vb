<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackupRestore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBackupRestore))
        Me.btnBackup = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnRestore = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.lblBackupStatus = New MaterialSkin.Controls.MaterialLabel()
        Me.lblRestoreStatus = New MaterialSkin.Controls.MaterialLabel()
        Me.btnClose = New MaterialSkin.Controls.MaterialFlatButton()
        Me.SuspendLayout()
        '
        'btnBackup
        '
        Me.btnBackup.Depth = 0
        Me.btnBackup.Location = New System.Drawing.Point(23, 63)
        Me.btnBackup.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Primary = True
        Me.btnBackup.Size = New System.Drawing.Size(257, 46)
        Me.btnBackup.TabIndex = 0
        Me.btnBackup.Text = "Backup Database"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'btnRestore
        '
        Me.btnRestore.Depth = 0
        Me.btnRestore.Location = New System.Drawing.Point(23, 134)
        Me.btnRestore.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Primary = True
        Me.btnRestore.Size = New System.Drawing.Size(257, 46)
        Me.btnRestore.TabIndex = 1
        Me.btnRestore.Text = "Restore Database"
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'lblBackupStatus
        '
        Me.lblBackupStatus.AutoSize = True
        Me.lblBackupStatus.Depth = 0
        Me.lblBackupStatus.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblBackupStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBackupStatus.Location = New System.Drawing.Point(23, 112)
        Me.lblBackupStatus.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblBackupStatus.Name = "lblBackupStatus"
        Me.lblBackupStatus.Size = New System.Drawing.Size(95, 19)
        Me.lblBackupStatus.TabIndex = 2
        Me.lblBackupStatus.Text = "Last Backup:"
        '
        'lblRestoreStatus
        '
        Me.lblRestoreStatus.AutoSize = True
        Me.lblRestoreStatus.Depth = 0
        Me.lblRestoreStatus.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblRestoreStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblRestoreStatus.Location = New System.Drawing.Point(23, 183)
        Me.lblRestoreStatus.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblRestoreStatus.Name = "lblRestoreStatus"
        Me.lblRestoreStatus.Size = New System.Drawing.Size(98, 19)
        Me.lblRestoreStatus.TabIndex = 3
        Me.lblRestoreStatus.Text = "Last Restore:"
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnClose.Depth = 0
        Me.btnClose.Location = New System.Drawing.Point(244, 9)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnClose.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Primary = False
        Me.btnClose.Size = New System.Drawing.Size(54, 36)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmBackupRestore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 215)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblRestoreStatus)
        Me.Controls.Add(Me.lblBackupStatus)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.btnBackup)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Movable = False
        Me.Name = "frmBackupRestore"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Backup and Restore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBackup As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnRestore As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents lblBackupStatus As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblRestoreStatus As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnClose As MaterialSkin.Controls.MaterialFlatButton
End Class
