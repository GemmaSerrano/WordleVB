<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FDictionary
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
        Me.DGVDiccionario = New System.Windows.Forms.DataGridView()
        CType(Me.DGVDiccionario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVDiccionario
        '
        Me.DGVDiccionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDiccionario.Location = New System.Drawing.Point(81, 65)
        Me.DGVDiccionario.Name = "DGVDiccionario"
        Me.DGVDiccionario.RowHeadersWidth = 82
        Me.DGVDiccionario.RowTemplate.Height = 33
        Me.DGVDiccionario.Size = New System.Drawing.Size(355, 639)
        Me.DGVDiccionario.TabIndex = 0
        '
        'FDictionary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 776)
        Me.Controls.Add(Me.DGVDiccionario)
        Me.Name = "FDictionary"
        Me.Text = "FDictionary"
        CType(Me.DGVDiccionario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVDiccionario As DataGridView
End Class
