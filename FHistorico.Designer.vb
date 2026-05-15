<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FHistorico
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DTGHistorico = New System.Windows.Forms.DataGridView()
        CType(Me.DTGHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTGHistorico
        '
        Me.DTGHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGHistorico.Location = New System.Drawing.Point(73, 87)
        Me.DTGHistorico.Name = "DTGHistorico"
        Me.DTGHistorico.RowHeadersWidth = 82
        Me.DTGHistorico.RowTemplate.Height = 33
        Me.DTGHistorico.Size = New System.Drawing.Size(882, 303)
        Me.DTGHistorico.TabIndex = 0
        '
        'FHistorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 483)
        Me.Controls.Add(Me.DTGHistorico)
        Me.Name = "FHistorico"
        Me.Text = "FHistorico"
        CType(Me.DTGHistorico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DTGHistorico As DataGridView
End Class
