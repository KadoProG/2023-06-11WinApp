Public Class frmMenu
    '▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼
    '                                           LOADイベント
    '▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "ようこそ、" & user_data.name & "さん"
        Dim test = sqlExecute("select name from sqlite_master where type='table';")
        Dim text As String = ""
        For Each aaa As DataRow In test.Rows
            text &= aaa("name") & " "

        Next
        Label9.Text = text
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

End Class