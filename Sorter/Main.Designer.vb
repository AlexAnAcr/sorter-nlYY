<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Tip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(323, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Полная сортировка"
        Me.Tip.SetToolTip(Me.Button1, "Сортировка без предварительного анализа, копирует все сортируемые объекты во врем" & _
                "енное хранилище, а затем сортирует их в папке назначения.")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 45)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(323, 27)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Анализ + сортировка"
        Me.Tip.SetToolTip(Me.Button2, resources.GetString("Button2.ToolTip"))
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 78)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(323, 27)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Сортировка из источника"
        Me.Tip.SetToolTip(Me.Button3, "Сортировка без предварительного анализа, копирует объекты из исходной папки в пап" & _
                "ку назначения (при этом сортирует их).")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(128, 128)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(207, 27)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Настройки"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 128)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(110, 27)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Выход"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Tip
        '
        Me.Tip.AutoPopDelay = 10000
        Me.Tip.InitialDelay = 500
        Me.Tip.ReshowDelay = 100
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(347, 167)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "Start"
        Me.Text = "Сортировщик файлов и папок"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Tip As System.Windows.Forms.ToolTip
End Class
