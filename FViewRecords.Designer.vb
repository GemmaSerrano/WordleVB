<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FViewRecors
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
        Me.DTGRecords = New System.Windows.Forms.DataGridView()
        CType(Me.DTGRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTGRecords
        '
        Me.DTGRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGRecords.Location = New System.Drawing.Point(48, 41)
        Me.DTGRecords.Name = "DTGRecords"
        Me.DTGRecords.RowHeadersWidth = 82
        Me.DTGRecords.RowTemplate.Height = 33
        Me.DTGRecords.Size = New System.Drawing.Size(700, 269)
        Me.DTGRecords.TabIndex = 0
        '
        'FViewRecors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DTGRecords)
        Me.Name = "FViewRecors"
        Me.Text = "FViewRecords"
        CType(Me.DTGRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DTGRecords As DataGridView
End Class
