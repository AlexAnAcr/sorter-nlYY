Public Class Main
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Sorter.Show()
        Me.Hide()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

    End Sub
    Private Sub Start_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "/config.dat") Then

        Else
            Dim settings(9) As String
            settings(0) = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            settings(1) = 1
            settings(2) = 1
            settings(3) = 1
            settings(4) = 1
            settings(5) = 1
            settings(6) = Application.StartupPath & "\User expectations"
            settings(7) = Application.StartupPath & "\Next step"
            settings(8) = Application.StartupPath & "\Error"
            settings(9) = Application.StartupPath & "\Folder is not available"

        End If
        Sorter.Sorter_Object.SelectedIndex = 0
        Sorter.Sorter_Mode.SelectedIndex = 0
        Sorter.Sorter_Type.SelectedIndex = 0
        Sorter.Start_Button.Enabled = False
    End Sub
    Public Sub SetMessenge(ByVal Text As String, ByVal MessengeType As UShort, Optional ByVal Title As String = "")
        Sorter_Error.Error_Text.Text = Text
        Sorter_Error.Text = "Ошибка " & Title
        If MessengeType = 2 Then
            Sorter_Error.Error_Image.Image = My.Resources.OK_Progress
        ElseIf MessengeType = 1 Then
            Sorter_Error.Error_Image.Image = My.Resources.UnCorrectFolder
        Else
            Sorter_Error.Error_Image.Image = My.Resources._Error
        End If
        Sorter_Error.ShowDialog()
    End Sub
End Class