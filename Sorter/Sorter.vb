Public Class Sorter
    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Main.Show()
    End Sub
    Private Sub Main_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Sorter_Dir_Selected.Text = ""
        Start_Button.Enabled = False
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sorter_Type.SelectedIndexChanged
        If Sorter_Object.SelectedIndex = 0 Then
            If Sorter_Type.SelectedIndex = 0 Then
                Sorter_Type_Info.Text = "Информация: сортировка с полным изменением папок (удалением предыдущих и созданием новых)."
            ElseIf Sorter_Type.SelectedIndex = 1 Then
                Sorter_Type_Info.Text = "Информация: сортировка по имеющимся папкам с возможностью создания новых."
            ElseIf Sorter_Type.SelectedIndex = 2 Then
                Sorter_Type_Info.Text = "Информация: сортировка только по имеющимся папкам."
            End If
        Else
            If Sorter_Type.SelectedIndex = 0 Then
                Sorter_Type_Info.Text = "Информация: сортировка всех имеющихся папок по новым."
            ElseIf Sorter_Type.SelectedIndex = 1 Then
                Sorter_Type_Info.Text = "Информация: сортировка имеющихся папок по другим имеющимся папкам с возможностью создания новых. (Иерархическая сортировка)"
            End If
        End If
    End Sub
    Private Sub КопироватьToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles КопироватьToolStripMenuItem.Click
        If Sorter_Dir_Selected.SelectedText <> "" Then My.Computer.Clipboard.SetText(Sorter_Dir_Selected.SelectedText)
    End Sub
    Private Sub КопироватьВсёToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles КопироватьВсёToolStripMenuItem.Click
        If Sorter_Dir_Selected.Text <> "" Then My.Computer.Clipboard.SetText(Sorter_Dir_Selected.Text)
    End Sub
    Private Sub Sorter_Dir_Browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sorter_Dir_Browse.Click
        Dim result As DialogResult = FolderBrowser.ShowDialog()
        If result = DialogResult.OK Then
            Sorter_Dir_toSelect.Text = FolderBrowser.SelectedPath
        End If
    End Sub
    Private Sub ОчиститьToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ОчиститьToolStripMenuItem.Click
        Sorter_Dir_Selected.Text = ""
        Start_Button.Enabled = False
    End Sub
    Private Sub Sorter_Dir_Select_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sorter_Dir_Select.Click
        Sorter_Dir_Select.Enabled = False
        Sorter_Dir_IsTesting.Text = "Тестирование папки..."
        Sorter_Dir_IsTesting.Visible = True
        Me.UseWaitCursor = True
        Wait_Test.Start()
    End Sub
    Private Sub Wait_Load_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Wait_Test.Tick
        Wait_Test.Stop()
        Test_Dir()
    End Sub
    Private Sub Test_Dir()
        Try
            If My.Computer.FileSystem.DirectoryExists(Sorter_Dir_toSelect.Text) = False Then
                Main.SetMessenge("Указанная папка не существует!", 0, "Поиск папки")
                Exit Try
            End If
            Dim dir() As String = IO.Directory.GetDirectories(Sorter_Dir_toSelect.Text, "*", IO.SearchOption.AllDirectories)
            Dim files() As String = IO.Directory.GetFiles(Sorter_Dir_toSelect.Text, "*", IO.SearchOption.AllDirectories)
            My.Computer.FileSystem.CreateDirectory(Sorter_Dir_toSelect.Text & "Test_Dir")
            My.Computer.FileSystem.DeleteDirectory(Sorter_Dir_toSelect.Text & "Test_Dir", FileIO.DeleteDirectoryOption.DeleteAllContents)
            My.Computer.FileSystem.WriteAllText(Sorter_Dir_toSelect.Text & "\Test_File.txt", "Test Data", False)
            My.Computer.FileSystem.DeleteFile(Sorter_Dir_toSelect.Text & "\Test_File.txt")
            Dim file_info As FileAttribute = My.Computer.FileSystem.GetDirectoryInfo(Sorter_Dir_toSelect.Text).Attributes
            If file_info = FileAttribute.Hidden Or file_info = FileAttribute.ReadOnly Or file_info = FileAttribute.System Then Error 1
            Dim number As Integer = 0
            While dir.Length > number
                file_info = My.Computer.FileSystem.GetDirectoryInfo(dir(number)).Attributes
                If file_info = FileAttribute.Hidden Or file_info = FileAttribute.ReadOnly Or file_info = FileAttribute.System Then
                    Error 1
                Else
                    number += 1
                End If
            End While
            number = 0
            While files.Length > number
                file_info = My.Computer.FileSystem.GetFileInfo(files(number)).Attributes
                If file_info = FileAttribute.Hidden Or file_info = FileAttribute.System Then
                    Error 1
                Else
                    number += 1
                End If
            End While
            Sorter_Dir_IsTesting.Text = "Проверка папки на наличие файла-ограничителя..."
            number = 0
            While files.Length > number
                If My.Computer.FileSystem.GetFileInfo(files(number)).Name = "No Sorting.txt" Then
                    If My.Computer.FileSystem.ReadAllText(files(number)) = "Command: sorter to sort should not be here" Then
                        number = files.Length
                        Main.SetMessenge("В указанной папке найден файл-ограничитель, защищающий её от сортировки. Убедитесь, что в этой папке можно производить сортировку.", 1, "Проверка доступа к папке")
                        Exit Try
                    Else
                        number += 1
                    End If
                Else
                    number += 1
                End If
            End While
            Sorter_Dir_Selected.Text = Sorter_Dir_toSelect.Text
            Start_Button.Enabled = True
        Catch
            Main.SetMessenge("Не удалось получить доступ к папке. Возможно, папка защищена от просмотра и(или) записи.", 1, "Проверка доступа к папке")
        End Try
        Me.UseWaitCursor = False
        Sorter_Dir_IsTesting.Visible = False
        Sorter_Dir_Select.Enabled = True
    End Sub
    Private Sub Sorter_Object_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sorter_Object.SelectedIndexChanged
        If Sorter_Object.SelectedIndex = 0 Then
            Sorter_Mode.Items.Clear()
            Sorter_Mode.Items.Add("Имя")
            Sorter_Mode.Items.Add("Тип файла")
            Sorter_Mode.Items.Add("Дата создания")
            Sorter_Mode.Items.Add("Дата изменения")
            Sorter_Mode.Items.Add("Размер")
            Sorter_Mode.SelectedIndex = 0
            Sorter_Type.Items.Clear()
            Sorter_Type.Items.Add("Полная сортировка")
            Sorter_Type.Items.Add("Сортировка 1")
            Sorter_Type.Items.Add("Сортировка 2")
            Sorter_Type.SelectedIndex = 0
        Else
            Sorter_Mode.Items.Clear()
            Sorter_Mode.Items.Add("Имя")
            Sorter_Mode.Items.Add("Дата создания")
            Sorter_Mode.SelectedIndex = 0
            Sorter_Type.Items.Clear()
            Sorter_Type.Items.Add("Полная сортировка")
            Sorter_Type.Items.Add("Сортировка 1")
            Sorter_Type.SelectedIndex = 0
        End If
    End Sub
    Private Sub Sorter_Mode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sorter_Mode.SelectedIndexChanged
        If Sorter_Mode.SelectedIndex = 0 Then
            Sorting_DirFile.Enabled = True
            Sorting_FileDir.Enabled = True
            Sorting_Shrift.Enabled = True
        Else
            Sorting_DirFile.Enabled = False
            Sorting_FileDir.Enabled = False
            Sorting_Shrift.Enabled = False
        End If
    End Sub
    Private Sub Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start_Button.Click
        Sorting.ShowDialog()
    End Sub
End Class
