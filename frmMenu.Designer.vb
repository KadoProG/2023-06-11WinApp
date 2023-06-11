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
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtLogin_id = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(147, 103)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "ログイン(&S)"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtLogin_id
        '
        Me.txtLogin_id.Location = New System.Drawing.Point(147, 35)
        Me.txtLogin_id.Name = "txtLogin_id"
        Me.txtLogin_id.Size = New System.Drawing.Size(156, 23)
        Me.txtLogin_id.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(147, 64)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(156, 23)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.Text = "ログイン画面"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(228, 103)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "閉じる(&C)"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(331, 149)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtLogin_id)
        Me.Controls.Add(Me.btnLogin)
        Me.Name = "frmMenu"
        Me.Text = "ログイン画面"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents txtLogin_id As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnClose As Button
End Class
