﻿Public Class frmLogin

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
        'ボタン押下時の処理
        If txtLogin_id.Text = init_user_data.login_id And txtPassword.Text = init_user_data.password Then
            user_data = init_user_data
            Dim frmMenu As frmMenu = New frmMenu
            frmMenu.Show(Me)
            Me.Hide()

            'MsgBox("ログイン成功" & txtPassword.Text & init_user_data.password)

        Else
            MsgBox("ログイン失敗" & txtPassword.Text & init_user_data.password)
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
