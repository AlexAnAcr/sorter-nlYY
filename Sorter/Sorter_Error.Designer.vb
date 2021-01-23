<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sorter_Error
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sorter_Error))
        Me.Error_Image = New System.Windows.Forms.PictureBox()
        Me.Error_Text = New System.Windows.Forms.Label()
        Me.Button_OK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Error_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Error_Image
        '
        Me.Error_Image.Image = CType(resources.GetObject("Error_Image.Image"), System.Drawing.Image)
        Me.Error_Image.Location = New System.Drawing.Point(16, 12)
        Me.Error_Image.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Error_Image.Name = "Error_Image"
        Me.Error_Image.Size = New System.Drawing.Size(284, 183)
        Me.Error_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Error_Image.TabIndex = 0
        Me.Error_Image.TabStop = False
        '
        'Error_Text
        '
        Me.Error_Text.Location = New System.Drawing.Point(13, 202)
        Me.Error_Text.Name = "Error_Text"
        Me.Error_Text.Size = New System.Drawing.Size(290, 72)
        Me.Error_Text.TabIndex = 1
        Me.Error_Text.Text = "Ошибка: -"
        '
        'Button_OK
        '
        Me.Button_OK.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button_OK.Location = New System.Drawing.Point(228, 281)
        Me.Button_OK.Name = "Button_OK"
        Me.Button_OK.Size = New System.Drawing.Size(75, 26)
        Me.Button_OK.TabIndex = 0
        Me.Button_OK.Text = "ОК"
        Me.Button_OK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(-7, 274)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 46)
        Me.Label1.TabIndex = 2
        '
        'Sorter_Error
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(315, 315)
        Me.Controls.Add(Me.Button_OK)
        Me.Controls.Add(Me.Error_Text)
        Me.Controls.Add(Me.Error_Image)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Sorter_Error"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ошибка"
        CType(Me.Error_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Error_Image As System.Windows.Forms.PictureBox
    Friend WithEvents Error_Text As System.Windows.Forms.Label
    Friend WithEvents Button_OK As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
