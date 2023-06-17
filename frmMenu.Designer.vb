<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        Label3 = New Label()
        Label4 = New Label()
        GroupBox3 = New GroupBox()
        Label5 = New Label()
        Label6 = New Label()
        GroupBox4 = New GroupBox()
        Label7 = New Label()
        Label8 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        btnClose = New Button()
        Panel1 = New Panel()
        lblWelcome = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(62, 56)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(140, 100)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "タンパク質"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(97, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(14, 15)
        Label2.TabIndex = 2
        Label2.Text = "g"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(20, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 45)
        Label1.TabIndex = 1
        Label1.Text = "999"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Location = New Point(219, 56)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(140, 100)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "脂質"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(97, 54)
        Label3.Name = "Label3"
        Label3.Size = New Size(14, 15)
        Label3.TabIndex = 2
        Label3.Text = "g"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(20, 30)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 45)
        Label4.TabIndex = 1
        Label4.Text = "999"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Location = New Point(374, 56)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(140, 100)
        GroupBox3.TabIndex = 4
        GroupBox3.TabStop = False
        GroupBox3.Text = "炭水化物"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(97, 54)
        Label5.Name = "Label5"
        Label5.Size = New Size(14, 15)
        Label5.TabIndex = 2
        Label5.Text = "g"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(20, 30)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 45)
        Label6.TabIndex = 1
        Label6.Text = "999"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(Label7)
        GroupBox4.Controls.Add(Label8)
        GroupBox4.Location = New Point(62, 178)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(452, 43)
        GroupBox4.TabIndex = 3
        GroupBox4.TabStop = False
        GroupBox4.Text = "PFCバランス、カロリー"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(97, 54)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 15)
        Label7.TabIndex = 2
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(20, 30)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 45)
        Label8.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(3, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(140, 40)
        Button1.TabIndex = 5
        Button1.Text = "食事の記録"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(149, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(140, 40)
        Button2.TabIndex = 6
        Button2.Text = "メンテナンス"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(497, 415)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 23)
        btnClose.TabIndex = 7
        btnClose.Text = "終了(&C)"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button2)
        Panel1.Location = New Point(12, 271)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(560, 100)
        Panel1.TabIndex = 8
        ' 
        ' lblWelcome
        ' 
        lblWelcome.Location = New Point(272, 9)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(300, 15)
        lblWelcome.TabIndex = 9
        lblWelcome.Text = "ようこそ、ゲストさん"
        lblWelcome.TextAlign = ContentAlignment.TopRight
        ' 
        ' frmMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnClose
        ClientSize = New Size(584, 450)
        Controls.Add(lblWelcome)
        Controls.Add(Panel1)
        Controls.Add(btnClose)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "frmMenu"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblWelcome As Label
End Class
