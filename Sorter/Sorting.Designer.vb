<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sorting
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Sorting_Progress = New System.Windows.Forms.ProgressBar()
        Me.Sorting_Cancel = New System.Windows.Forms.Button()
        Me.Sorting_Page = New System.Windows.Forms.PictureBox()
        Me.Sorting_FileToDir = New System.Windows.Forms.ListBox()
        Me.Sorting_Info = New System.Windows.Forms.Label()
        Me.Load_Me = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Sorting_Page, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sorting_Progress
        '
        Me.Sorting_Progress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sorting_Progress.Location = New System.Drawing.Point(12, 251)
        Me.Sorting_Progress.Name = "Sorting_Progress"
        Me.Sorting_Progress.Size = New System.Drawing.Size(430, 23)
        Me.Sorting_Progress.TabIndex = 0
        '
        'Sorting_Cancel
        '
        Me.Sorting_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sorting_Cancel.Location = New System.Drawing.Point(371, 280)
        Me.Sorting_Cancel.Name = "Sorting_Cancel"
        Me.Sorting_Cancel.Size = New System.Drawing.Size(70, 23)
        Me.Sorting_Cancel.TabIndex = 1
        Me.Sorting_Cancel.Text = "Отмена"
        Me.Sorting_Cancel.UseVisualStyleBackColor = True
        '
        'Sorting_Page
        '
        Me.Sorting_Page.BackColor = System.Drawing.SystemColors.Window
        Me.Sorting_Page.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Sorting_Page.Image = Global.Sorter.My.Resources.Resources.CopuToDir
        Me.Sorting_Page.Location = New System.Drawing.Point(12, 12)
        Me.Sorting_Page.Name = "Sorting_Page"
        Me.Sorting_Page.Size = New System.Drawing.Size(178, 123)
        Me.Sorting_Page.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Sorting_Page.TabIndex = 2
        Me.Sorting_Page.TabStop = False
        '
        'Sorting_FileToDir
        '
        Me.Sorting_FileToDir.FormattingEnabled = True
        Me.Sorting_FileToDir.HorizontalScrollbar = True
        Me.Sorting_FileToDir.Location = New System.Drawing.Point(196, 12)
        Me.Sorting_FileToDir.Name = "Sorting_FileToDir"
        Me.Sorting_FileToDir.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.Sorting_FileToDir.Size = New System.Drawing.Size(246, 225)
        Me.Sorting_FileToDir.TabIndex = 3
        '
        'Sorting_Info
        '
        Me.Sorting_Info.Location = New System.Drawing.Point(13, 142)
        Me.Sorting_Info.Name = "Sorting_Info"
        Me.Sorting_Info.Size = New System.Drawing.Size(177, 95)
        Me.Sorting_Info.TabIndex = 4
        Me.Sorting_Info.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Load_Me
        '
        '
        'Sorting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(454, 315)
        Me.Controls.Add(Me.Sorting_Info)
        Me.Controls.Add(Me.Sorting_FileToDir)
        Me.Controls.Add(Me.Sorting_Page)
        Me.Controls.Add(Me.Sorting_Cancel)
        Me.Controls.Add(Me.Sorting_Progress)
        Me.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Sorting"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Сортировка..."
        CType(Me.Sorting_Page, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Sorting_Progress As System.Windows.Forms.ProgressBar
    Friend WithEvents Sorting_Cancel As System.Windows.Forms.Button
    Friend WithEvents Sorting_Page As System.Windows.Forms.PictureBox
    Friend WithEvents Sorting_FileToDir As System.Windows.Forms.ListBox
    Friend WithEvents Sorting_Info As System.Windows.Forms.Label
    Friend WithEvents Load_Me As System.Windows.Forms.Timer

End Class
