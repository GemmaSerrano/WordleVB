<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FWordle
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DictionaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FLPLetters = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HistoricoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.FLPLetters.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DictionaryToolStripMenuItem, Me.RecordsToolStripMenuItem, Me.HistoricoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(898, 42)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.NewGameToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(72, 38)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.NewGameToolStripMenuItem.Text = "&New Game"
        '
        'DictionaryToolStripMenuItem
        '
        Me.DictionaryToolStripMenuItem.Name = "DictionaryToolStripMenuItem"
        Me.DictionaryToolStripMenuItem.Size = New System.Drawing.Size(143, 38)
        Me.DictionaryToolStripMenuItem.Text = "&Dictionary"
        '
        'RecordsToolStripMenuItem
        '
        Me.RecordsToolStripMenuItem.Name = "RecordsToolStripMenuItem"
        Me.RecordsToolStripMenuItem.Size = New System.Drawing.Size(118, 38)
        Me.RecordsToolStripMenuItem.Text = "&Records"
        '
        'FLPLetters
        '
        Me.FLPLetters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FLPLetters.Controls.Add(Me.Button1)
        Me.FLPLetters.Controls.Add(Me.Button2)
        Me.FLPLetters.Controls.Add(Me.Button3)
        Me.FLPLetters.Controls.Add(Me.Button4)
        Me.FLPLetters.Controls.Add(Me.Button5)
        Me.FLPLetters.Controls.Add(Me.Button6)
        Me.FLPLetters.Controls.Add(Me.Button7)
        Me.FLPLetters.Controls.Add(Me.Button8)
        Me.FLPLetters.Controls.Add(Me.Button9)
        Me.FLPLetters.Controls.Add(Me.Button10)
        Me.FLPLetters.Controls.Add(Me.Button11)
        Me.FLPLetters.Controls.Add(Me.Button12)
        Me.FLPLetters.Controls.Add(Me.Button13)
        Me.FLPLetters.Controls.Add(Me.Button14)
        Me.FLPLetters.Controls.Add(Me.Button15)
        Me.FLPLetters.Controls.Add(Me.Button16)
        Me.FLPLetters.Controls.Add(Me.Button17)
        Me.FLPLetters.Controls.Add(Me.Button18)
        Me.FLPLetters.Controls.Add(Me.Button19)
        Me.FLPLetters.Controls.Add(Me.Button20)
        Me.FLPLetters.Controls.Add(Me.Button29)
        Me.FLPLetters.Controls.Add(Me.Button21)
        Me.FLPLetters.Controls.Add(Me.Button22)
        Me.FLPLetters.Controls.Add(Me.Button23)
        Me.FLPLetters.Controls.Add(Me.Button24)
        Me.FLPLetters.Controls.Add(Me.Button25)
        Me.FLPLetters.Controls.Add(Me.Button26)
        Me.FLPLetters.Controls.Add(Me.Button27)
        Me.FLPLetters.Controls.Add(Me.Button28)
        Me.FLPLetters.Location = New System.Drawing.Point(35, 555)
        Me.FLPLetters.Name = "FLPLetters"
        Me.FLPLetters.Size = New System.Drawing.Size(828, 259)
        Me.FLPLetters.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 71)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Q"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(80, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 71)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "W"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(157, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(71, 71)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "E"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(234, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(71, 71)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "R"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(311, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(71, 71)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "T"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(388, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(71, 71)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Y"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(465, 3)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(71, 71)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "U"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(542, 3)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(71, 71)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "I"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(619, 3)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(71, 71)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "O"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(696, 3)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(71, 71)
        Me.Button10.TabIndex = 9
        Me.Button10.Text = "P"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(3, 80)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(71, 71)
        Me.Button11.TabIndex = 10
        Me.Button11.Text = "A"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(80, 80)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(71, 71)
        Me.Button12.TabIndex = 11
        Me.Button12.Text = "S"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(157, 80)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(71, 71)
        Me.Button13.TabIndex = 12
        Me.Button13.Text = "D"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(234, 80)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(71, 71)
        Me.Button14.TabIndex = 13
        Me.Button14.Text = "F"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(311, 80)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(71, 71)
        Me.Button15.TabIndex = 14
        Me.Button15.Text = "G"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(388, 80)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(71, 71)
        Me.Button16.TabIndex = 15
        Me.Button16.Text = "H"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(465, 80)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(71, 71)
        Me.Button17.TabIndex = 16
        Me.Button17.Text = "J"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(542, 80)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(71, 71)
        Me.Button18.TabIndex = 17
        Me.Button18.Text = "K"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(619, 80)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(71, 71)
        Me.Button19.TabIndex = 18
        Me.Button19.Text = "L"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(696, 80)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(71, 71)
        Me.Button20.TabIndex = 19
        Me.Button20.Text = "Ñ"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button29
        '
        Me.Button29.Location = New System.Drawing.Point(3, 157)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(109, 71)
        Me.Button29.TabIndex = 28
        Me.Button29.Text = "ENTER"
        Me.Button29.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.Location = New System.Drawing.Point(118, 157)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(71, 71)
        Me.Button21.TabIndex = 29
        Me.Button21.Text = "Z"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button22
        '
        Me.Button22.Location = New System.Drawing.Point(195, 157)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(71, 71)
        Me.Button22.TabIndex = 30
        Me.Button22.Text = "X"
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Button23
        '
        Me.Button23.Location = New System.Drawing.Point(272, 157)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(71, 71)
        Me.Button23.TabIndex = 31
        Me.Button23.Text = "C"
        Me.Button23.UseVisualStyleBackColor = True
        '
        'Button24
        '
        Me.Button24.Location = New System.Drawing.Point(349, 157)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(71, 71)
        Me.Button24.TabIndex = 32
        Me.Button24.Text = "V"
        Me.Button24.UseVisualStyleBackColor = True
        '
        'Button25
        '
        Me.Button25.Location = New System.Drawing.Point(426, 157)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(71, 71)
        Me.Button25.TabIndex = 33
        Me.Button25.Text = "B"
        Me.Button25.UseVisualStyleBackColor = True
        '
        'Button26
        '
        Me.Button26.Location = New System.Drawing.Point(503, 157)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(71, 71)
        Me.Button26.TabIndex = 34
        Me.Button26.Text = "N"
        Me.Button26.UseVisualStyleBackColor = True
        '
        'Button27
        '
        Me.Button27.Location = New System.Drawing.Point(580, 157)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(71, 71)
        Me.Button27.TabIndex = 35
        Me.Button27.Text = "M"
        Me.Button27.UseVisualStyleBackColor = True
        '
        'Button28
        '
        Me.Button28.Location = New System.Drawing.Point(657, 157)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(109, 71)
        Me.Button28.TabIndex = 36
        Me.Button28.Text = "<X"
        Me.Button28.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'HistoricoToolStripMenuItem
        '
        Me.HistoricoToolStripMenuItem.Name = "HistoricoToolStripMenuItem"
        Me.HistoricoToolStripMenuItem.Size = New System.Drawing.Size(129, 38)
        Me.HistoricoToolStripMenuItem.Text = "&Historico"
        '
        'FWordle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 852)
        Me.Controls.Add(Me.FLPLetters)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FWordle"
        Me.Text = "WORDLE"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.FLPLetters.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DictionaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FLPLetters As FlowLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button29 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents Button22 As Button
    Friend WithEvents Button23 As Button
    Friend WithEvents Button24 As Button
    Friend WithEvents Button25 As Button
    Friend WithEvents Button26 As Button
    Friend WithEvents Button27 As Button
    Friend WithEvents Button28 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents HistoricoToolStripMenuItem As ToolStripMenuItem
End Class
