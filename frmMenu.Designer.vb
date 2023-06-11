<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
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
        btnLogin = New Button()
        txtLogin_id = New TextBox()
        txtPassword = New TextBox()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(210, 172)
        btnLogin.Margin = New Padding(4, 5, 4, 5)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(107, 38)
        btnLogin.TabIndex = 2
        btnLogin.Text = "ログイン(&S)"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtLogin_id
        ' 
        txtLogin_id.Location = New Point(210, 58)
        txtLogin_id.Margin = New Padding(4, 5, 4, 5)
        txtLogin_id.Name = "txtLogin_id"
        txtLogin_id.Size = New Size(221, 31)
        txtLogin_id.TabIndex = 0
        txtLogin_id.Text = "user"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(210, 107)
        txtPassword.Margin = New Padding(4, 5, 4, 5)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(221, 31)
        txtPassword.TabIndex = 1
        txtPassword.Text = "ログイン画面"
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(326, 172)
        btnClose.Margin = New Padding(4, 5, 4, 5)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(107, 38)
        btnClose.TabIndex = 3
        btnClose.Text = "閉じる(&C)"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' frmMenu
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnClose
        ClientSize = New Size(473, 248)
        Controls.Add(btnClose)
        Controls.Add(txtPassword)
        Controls.Add(txtLogin_id)
        Controls.Add(btnLogin)
        Margin = New Padding(4, 5, 4, 5)
        Name = "frmMenu"
        Text = "ログイン画面"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents txtLogin_id As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnClose As Button
End Class
