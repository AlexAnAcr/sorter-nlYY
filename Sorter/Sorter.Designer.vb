<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sorter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sorter))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Sorter_Dir_toSelect = New System.Windows.Forms.TextBox()
        Me.Sorter_Dir_Browse = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Sorter_Object = New System.Windows.Forms.ComboBox()
        Me.Start_Button = New System.Windows.Forms.Button()
        Me.FolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Sorter_Mode = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Sorter_Type = New System.Windows.Forms.ComboBox()
        Me.Tip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Sorter_Dir_Selected = New System.Windows.Forms.TextBox()
        Me.ContextMenu_Dir_Select = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.КопироватьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КопироватьВсёToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОчиститьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sorter_Dir_Select = New System.Windows.Forms.Button()
        Me.Sorter_Dir_IsTesting = New System.Windows.Forms.Label()
        Me.Sorting_DirFile = New System.Windows.Forms.CheckBox()
        Me.Sorting_FileDir = New System.Windows.Forms.CheckBox()
        Me.Sorting_Reserve = New System.Windows.Forms.CheckBox()
        Me.Sorting_Shrift = New System.Windows.Forms.CheckBox()
        Me.Sorter_Type_Info = New System.Windows.Forms.Label()
        Me.Wait_Test = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenu_Dir_Select.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Выберите папку для сортировки:"
        '
        'Sorter_Dir_toSelect
        '
        Me.Sorter_Dir_toSelect.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Sorter_Dir_toSelect.Location = New System.Drawing.Point(12, 32)
        Me.Sorter_Dir_toSelect.MaxLength = 10000
        Me.Sorter_Dir_toSelect.Name = "Sorter_Dir_toSelect"
        Me.Sorter_Dir_toSelect.Size = New System.Drawing.Size(394, 20)
        Me.Sorter_Dir_toSelect.TabIndex = 1
        Me.Tip.SetToolTip(Me.Sorter_Dir_toSelect, "Здесь можно ввести от руки или вставить кнопкой ""Обзор"" путь к папке, в которой н" & _
                "адо произвести сортировку.")
        '
        'Sorter_Dir_Browse
        '
        Me.Sorter_Dir_Browse.Location = New System.Drawing.Point(412, 30)
        Me.Sorter_Dir_Browse.Name = "Sorter_Dir_Browse"
        Me.Sorter_Dir_Browse.Size = New System.Drawing.Size(86, 23)
        Me.Sorter_Dir_Browse.TabIndex = 2
        Me.Sorter_Dir_Browse.Text = "Обзор"
        Me.Tip.SetToolTip(Me.Sorter_Dir_Browse, "Нажмите на эту кнопку для выбора папки.")
        Me.Sorter_Dir_Browse.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 105)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Объект сортировки:"
        '
        'Sorter_Object
        '
        Me.Sorter_Object.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Sorter_Object.FormattingEnabled = True
        Me.Sorter_Object.Items.AddRange(New Object() {"Файлы", "Папки"})
        Me.Sorter_Object.Location = New System.Drawing.Point(172, 107)
        Me.Sorter_Object.Name = "Sorter_Object"
        Me.Sorter_Object.Size = New System.Drawing.Size(70, 21)
        Me.Sorter_Object.TabIndex = 4
        Me.Tip.SetToolTip(Me.Sorter_Object, "Выберите оъект сортировки: Папку или Файл.")
        '
        'Start_Button
        '
        Me.Start_Button.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Start_Button.Location = New System.Drawing.Point(13, 342)
        Me.Start_Button.Name = "Start_Button"
        Me.Start_Button.Size = New System.Drawing.Size(486, 28)
        Me.Start_Button.TabIndex = 5
        Me.Start_Button.Text = "Начать сортировку"
        Me.Start_Button.UseVisualStyleBackColor = True
        '
        'FolderBrowser
        '
        Me.FolderBrowser.Description = "Выберите папку, в которой хотите произвести сортировку."
        Me.FolderBrowser.ShowNewFolderButton = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 201)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Способ сортировки:"
        '
        'Sorter_Mode
        '
        Me.Sorter_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Sorter_Mode.FormattingEnabled = True
        Me.Sorter_Mode.Items.AddRange(New Object() {"Имя", "Тип файла", "Дата создания", "Дата изменения", "Размер"})
        Me.Sorter_Mode.Location = New System.Drawing.Point(172, 201)
        Me.Sorter_Mode.Name = "Sorter_Mode"
        Me.Sorter_Mode.Size = New System.Drawing.Size(144, 21)
        Me.Sorter_Mode.TabIndex = 7
        Me.Tip.SetToolTip(Me.Sorter_Mode, "Здесь задаётся способ сортировки.")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 227)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Параметры сортировки:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 137)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Тип сортировки:"
        '
        'Sorter_Type
        '
        Me.Sorter_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Sorter_Type.FormattingEnabled = True
        Me.Sorter_Type.Items.AddRange(New Object() {"Полная сортировка", "Сортировка 1", "Сортировка 2"})
        Me.Sorter_Type.Location = New System.Drawing.Point(145, 134)
        Me.Sorter_Type.Name = "Sorter_Type"
        Me.Sorter_Type.Size = New System.Drawing.Size(171, 21)
        Me.Sorter_Type.TabIndex = 10
        Me.Tip.SetToolTip(Me.Sorter_Type, "\/ Информация выведена ниже. \/")
        '
        'Tip
        '
        Me.Tip.AutoPopDelay = 10000
        Me.Tip.InitialDelay = 500
        Me.Tip.ReshowDelay = 100
        '
        'Sorter_Dir_Selected
        '
        Me.Sorter_Dir_Selected.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Sorter_Dir_Selected.ContextMenuStrip = Me.ContextMenu_Dir_Select
        Me.Sorter_Dir_Selected.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Sorter_Dir_Selected.Location = New System.Drawing.Point(12, 72)
        Me.Sorter_Dir_Selected.MaxLength = 10000
        Me.Sorter_Dir_Selected.Name = "Sorter_Dir_Selected"
        Me.Sorter_Dir_Selected.ReadOnly = True
        Me.Sorter_Dir_Selected.Size = New System.Drawing.Size(372, 20)
        Me.Sorter_Dir_Selected.TabIndex = 12
        Me.Tip.SetToolTip(Me.Sorter_Dir_Selected, "Здесь отображается путь к выбранной папке, прошедшей тестирование." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Сортировка бу" & _
                "дет произведена именно в этой папке!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Для тестирования папки, выбранной выше, на" & _
                "жмите кнопку ""Выбрать"".")
        '
        'ContextMenu_Dir_Select
        '
        Me.ContextMenu_Dir_Select.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenu_Dir_Select.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.КопироватьToolStripMenuItem, Me.КопироватьВсёToolStripMenuItem, Me.ОчиститьToolStripMenuItem})
        Me.ContextMenu_Dir_Select.Name = "ContextMenu_Dir_Select"
        Me.ContextMenu_Dir_Select.ShowImageMargin = False
        Me.ContextMenu_Dir_Select.Size = New System.Drawing.Size(162, 70)
        '
        'КопироватьToolStripMenuItem
        '
        Me.КопироватьToolStripMenuItem.Name = "КопироватьToolStripMenuItem"
        Me.КопироватьToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.КопироватьToolStripMenuItem.Text = "Копировать"
        '
        'КопироватьВсёToolStripMenuItem
        '
        Me.КопироватьВсёToolStripMenuItem.Name = "КопироватьВсёToolStripMenuItem"
        Me.КопироватьВсёToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.КопироватьВсёToolStripMenuItem.Text = "Копировать всё"
        '
        'ОчиститьToolStripMenuItem
        '
        Me.ОчиститьToolStripMenuItem.Name = "ОчиститьToolStripMenuItem"
        Me.ОчиститьToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ОчиститьToolStripMenuItem.Text = "Очистить"
        '
        'Sorter_Dir_Select
        '
        Me.Sorter_Dir_Select.Location = New System.Drawing.Point(390, 70)
        Me.Sorter_Dir_Select.Name = "Sorter_Dir_Select"
        Me.Sorter_Dir_Select.Size = New System.Drawing.Size(109, 23)
        Me.Sorter_Dir_Select.TabIndex = 13
        Me.Sorter_Dir_Select.Text = "Выбрать"
        Me.Tip.SetToolTip(Me.Sorter_Dir_Select, "Нажмите эту кнопку для выбора папки, путь к которой введён выше.")
        Me.Sorter_Dir_Select.UseVisualStyleBackColor = True
        '
        'Sorter_Dir_IsTesting
        '
        Me.Sorter_Dir_IsTesting.AutoSize = True
        Me.Sorter_Dir_IsTesting.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Sorter_Dir_IsTesting.Location = New System.Drawing.Point(14, 55)
        Me.Sorter_Dir_IsTesting.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Sorter_Dir_IsTesting.Name = "Sorter_Dir_IsTesting"
        Me.Sorter_Dir_IsTesting.Size = New System.Drawing.Size(154, 16)
        Me.Sorter_Dir_IsTesting.TabIndex = 14
        Me.Sorter_Dir_IsTesting.Text = "Тестирование папки..."
        Me.Tip.SetToolTip(Me.Sorter_Dir_IsTesting, "Производится тестирование папки. Не закрывайте программу!")
        Me.Sorter_Dir_IsTesting.Visible = False
        '
        'Sorting_DirFile
        '
        Me.Sorting_DirFile.AutoSize = True
        Me.Sorting_DirFile.Location = New System.Drawing.Point(32, 273)
        Me.Sorting_DirFile.Name = "Sorting_DirFile"
        Me.Sorting_DirFile.Size = New System.Drawing.Size(330, 17)
        Me.Sorting_DirFile.TabIndex = 15
        Me.Sorting_DirFile.Text = "Папка может содержать часть имени С.О."
        Me.Tip.SetToolTip(Me.Sorting_DirFile, resources.GetString("Sorting_DirFile.ToolTip"))
        Me.Sorting_DirFile.UseVisualStyleBackColor = True
        '
        'Sorting_FileDir
        '
        Me.Sorting_FileDir.AutoSize = True
        Me.Sorting_FileDir.Location = New System.Drawing.Point(32, 296)
        Me.Sorting_FileDir.Name = "Sorting_FileDir"
        Me.Sorting_FileDir.Size = New System.Drawing.Size(330, 17)
        Me.Sorting_FileDir.TabIndex = 16
        Me.Sorting_FileDir.Text = "С.О. может содержать часть имени папки"
        Me.Tip.SetToolTip(Me.Sorting_FileDir, resources.GetString("Sorting_FileDir.ToolTip"))
        Me.Sorting_FileDir.UseVisualStyleBackColor = True
        '
        'Sorting_Reserve
        '
        Me.Sorting_Reserve.AutoSize = True
        Me.Sorting_Reserve.Location = New System.Drawing.Point(32, 250)
        Me.Sorting_Reserve.Name = "Sorting_Reserve"
        Me.Sorting_Reserve.Size = New System.Drawing.Size(354, 17)
        Me.Sorting_Reserve.TabIndex = 17
        Me.Sorting_Reserve.Text = "Создать резервную копию перед сортировкой"
        Me.Tip.SetToolTip(Me.Sorting_Reserve, "Выберите это для создания резервной копии перед сортировкой." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "После сортировки, е" & _
                "сли вас что-либо не устраивает, вы сможете восстановить прежнее состояние.")
        Me.Sorting_Reserve.UseVisualStyleBackColor = True
        '
        'Sorting_Shrift
        '
        Me.Sorting_Shrift.AutoSize = True
        Me.Sorting_Shrift.Location = New System.Drawing.Point(32, 319)
        Me.Sorting_Shrift.Name = "Sorting_Shrift"
        Me.Sorting_Shrift.Size = New System.Drawing.Size(210, 17)
        Me.Sorting_Shrift.TabIndex = 18
        Me.Sorting_Shrift.Text = "Регистр не утчитывается"
        Me.Tip.SetToolTip(Me.Sorting_Shrift, resources.GetString("Sorting_Shrift.ToolTip"))
        Me.Sorting_Shrift.UseVisualStyleBackColor = True
        '
        'Sorter_Type_Info
        '
        Me.Sorter_Type_Info.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Sorter_Type_Info.Location = New System.Drawing.Point(16, 158)
        Me.Sorter_Type_Info.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Sorter_Type_Info.Name = "Sorter_Type_Info"
        Me.Sorter_Type_Info.Size = New System.Drawing.Size(485, 42)
        Me.Sorter_Type_Info.TabIndex = 11
        Me.Sorter_Type_Info.Text = "Информация: -"
        '
        'Wait_Test
        '
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(510, 382)
        Me.Controls.Add(Me.Sorting_Shrift)
        Me.Controls.Add(Me.Sorting_Reserve)
        Me.Controls.Add(Me.Sorting_FileDir)
        Me.Controls.Add(Me.Sorting_DirFile)
        Me.Controls.Add(Me.Sorter_Dir_IsTesting)
        Me.Controls.Add(Me.Sorter_Type_Info)
        Me.Controls.Add(Me.Sorter_Dir_Select)
        Me.Controls.Add(Me.Sorter_Dir_Selected)
        Me.Controls.Add(Me.Sorter_Type)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Sorter_Mode)
        Me.Controls.Add(Me.Start_Button)
        Me.Controls.Add(Me.Sorter_Object)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Sorter_Dir_Browse)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Sorter_Dir_toSelect)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "Настройки сортировки"
        Me.ContextMenu_Dir_Select.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Sorter_Dir_toSelect As System.Windows.Forms.TextBox
    Friend WithEvents Sorter_Dir_Browse As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Sorter_Object As System.Windows.Forms.ComboBox
    Friend WithEvents Start_Button As System.Windows.Forms.Button
    Friend WithEvents FolderBrowser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Sorter_Mode As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Sorter_Type As System.Windows.Forms.ComboBox
    Friend WithEvents Tip As System.Windows.Forms.ToolTip
    Friend WithEvents Sorter_Type_Info As System.Windows.Forms.Label
    Friend WithEvents Sorter_Dir_Selected As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenu_Dir_Select As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents КопироватьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Sorter_Dir_Select As System.Windows.Forms.Button
    Friend WithEvents КопироватьВсёToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ОчиститьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Sorter_Dir_IsTesting As System.Windows.Forms.Label
    Friend WithEvents Wait_Test As System.Windows.Forms.Timer
    Friend WithEvents Sorting_DirFile As System.Windows.Forms.CheckBox
    Friend WithEvents Sorting_FileDir As System.Windows.Forms.CheckBox
    Friend WithEvents Sorting_Reserve As System.Windows.Forms.CheckBox
    Friend WithEvents Sorting_Shrift As System.Windows.Forms.CheckBox

End Class
