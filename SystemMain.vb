﻿Imports Microsoft.VisualBasic
Imports System.Data.SQLite

Public Module SystemMain
    Public Structure user_setting
        Public id As Integer
        Public login_id As String
        Public name As String
        Public password As String
        Sub New(ByVal id As Integer, ByVal login_id As String, ByVal name As String, ByVal password As String)
            Me.id = id
            Me.login_id = login_id
            Me.name = name
            Me.password = password
        End Sub
    End Structure

    Public init_user_data As New user_setting(0, "0", "Admin", "0")

    Public user_data As user_setting

    Sub New()
        'init_user_data.id = 0
        'init_user_data.login_id = "0"
        'init_user_data.name = "Admin"
        'init_user_data.password = "0"
    End Sub

    Public Function sqlExecute(ByVal strQuery) As DataTable
        Using con = New SQLiteConnection(GetConnectionString())
            con.Open()
            Using cmd = con.CreateCommand()
                cmd.CommandText = strQuery
                Using dr = cmd.ExecuteReader()
                    sqlExecute = New DataTable()
                    sqlExecute.Load(dr)
                End Using
            End Using
        End Using


    End Function
    ''' <summary>
    ''' 接続文字列を取得します。
    ''' </summary>
    Private Function GetConnectionString() As String        ' 
        Return New SQLiteConnectionStringBuilder() With {.DataSource = "C:\SQLite3\testFile\sqlite3.db"}.ToString()
    End Function

End Module
