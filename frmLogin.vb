Public Class frmLogin
    'Private sysMain As New SystemMain

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                AddHandler ctrl.Enter, AddressOf txtControl_Enter
                AddHandler ctrl.KeyDown, AddressOf txtControl_KeyDown
                AddHandler ctrl.KeyPress, AddressOf txtControl_KeyPress
                'MsgBox("テキストボックスです")
            End If
        Next

        'ログインIDにフォーカス
        txtLogin_id.Text = ""
        txtPassword.Text = ""
        txtLogin_id.Select()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Console.WriteLine(txtLogin_id.Text & SystemMain.init_user_data.login_id)
        'ボタン押下時の処理
        If txtLogin_id.Text = SystemMain.init_user_data.login_id And txtPassword.Text = SystemMain.init_user_data.password Then
            MsgBox("ログイン成功")
        Else
            MsgBox("ログイン失敗" & txtPassword.Text & SystemMain.init_user_data.password)
        End If


    End Sub




    '▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼
    ' ここから、テキストボックス（txtControl）のイベント
    '▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲

    Private Sub txtControl_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtControl_KeyDown(sender As Object, e As EventArgs)

    End Sub
    Private Sub txtControl_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case True

        End Select
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
