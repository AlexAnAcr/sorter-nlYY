Public Class Sorting
    Dim main_dir As String = Sorter.Sorter_Dir_Selected.Text, me_way As String = Application.StartupPath, me_load_mode As Short = 0
    Private Sub Sorting_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        me_load_mode = 0
        Sorting_Page.Image = My.Resources.CopuToDir
        If Sorter.Sorter_Object.SelectedIndex = 0 Then
            Sorting_Info.Text = "Копирование файлов для сортировки... (это не создание резервной копии)"
        Else
            Sorting_Info.Text = "Копирование папок для сортировки... (это не создание резервной копии)"
        End If
        Load_Me.Start()
    End Sub
    Private Sub Sorting_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If My.Computer.FileSystem.DirectoryExists(me_way & "\SortingFiles") Then
            My.Computer.FileSystem.DeleteDirectory(me_way & "\SortingFiles", FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
        If My.Computer.FileSystem.DirectoryExists(me_way & "\BackUp") Then
            My.Computer.FileSystem.DeleteDirectory(me_way & "\BackUp", FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
    End Sub
    Private Sub Sorting_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sorting_Cancel.Click
        Me.Close()
    End Sub
    Private Sub Load_Me_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Load_Me.Tick
        Load_Me.Stop()
        If me_load_mode = 0 Then
            Intro_Sorting()
        End If
    End Sub
    Private Sub Intro_Sorting()
        If Sorter.Sorter_Object.SelectedIndex = 0 Then
            Dim files() As String = IO.Directory.GetFiles(main_dir, "*", IO.SearchOption.AllDirectories)
            Dim progress_mode(1) As Integer
            If files.Length > 10 Then
                progress_mode(0) = Math.Round(files.Length / 10)
                progress_mode(1) = 0
            Else
                progress_mode(0) = Math.Round(10 / files.Length)
                progress_mode(1) = 1
            End If
            Dim file_copy As Integer = 0
            For Each i As String In files
                My.Computer.FileSystem.CopyFile(i, me_way & "\SortingFiles\" & Mid(i, i.LastIndexOf("\") + 2))
                file_copy += 1
                If progress_mode(1) = 0 Then
                    If Math.IEEERemainder(file_copy, progress_mode(0)) = 0 Then
                        If Sorting_Progress.Value < 10 Then
                            Sorting_Progress.Value += 1
                        Else
                            Sorting_Progress.Value = 10
                        End If
                    End If
                Else
                    If Sorting_Progress.Value + progress_mode(0) <= 10 Then
                        Sorting_Progress.Value += 1
                    Else
                        Sorting_Progress.Value = 10
                    End If
                End If
            Next
            Sorting_Progress.Value = 10
        Else
            Dim dir() As String = IO.Directory.GetDirectories(main_dir, "*", IO.SearchOption.AllDirectories)
            Dim progress_mode(1) As Integer
            If dir.Length > 10 Then
                progress_mode(0) = Math.Round(dir.Length / 10)
                progress_mode(1) = 0
            Else
                progress_mode(0) = Math.Round(10 / dir.Length)
                progress_mode(1) = 1
            End If
            Dim file_copy As Integer = 0
            For Each i As String In dir
                My.Computer.FileSystem.CopyDirectory(i, me_way & "\SortingFiles\" & Mid(i, i.LastIndexOf("\") + 2))
                file_copy += 1
                If progress_mode(1) = 0 Then
                    If Math.IEEERemainder(file_copy, progress_mode(0)) = 0 Then
                        If Sorting_Progress.Value < 10 Then
                            Sorting_Progress.Value += 1
                        Else
                            Sorting_Progress.Value = 10
                        End If
                    End If
                Else
                    If Sorting_Progress.Value + progress_mode(0) <= 10 Then
                        Sorting_Progress.Value += 1
                    Else
                        Sorting_Progress.Value = 10
                    End If
                End If
            Next
            dir = IO.Directory.GetDirectories(me_way & "\SortingFiles", "*", IO.SearchOption.TopDirectoryOnly)
            For Each i As String In dir
                Dim dir_1() As String = IO.Directory.GetDirectories(i, "*", IO.SearchOption.TopDirectoryOnly)
                For Each i_2 As String In dir_1
                    My.Computer.FileSystem.DeleteDirectory(i_2, FileIO.DeleteDirectoryOption.DeleteAllContents)
                Next
            Next
            Sorting_Progress.Value = 10
        End If
    End Sub
End Class
