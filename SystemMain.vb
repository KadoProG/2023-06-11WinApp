Imports Microsoft.VisualBasic

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

End Module
