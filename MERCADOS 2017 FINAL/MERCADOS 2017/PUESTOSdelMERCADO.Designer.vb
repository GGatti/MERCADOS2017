<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PUESTOSdelMERCADO
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
        Me.dtgvPuestos = New System.Windows.Forms.DataGridView()
        CType(Me.dtgvPuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgvPuestos
        '
        Me.dtgvPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvPuestos.Location = New System.Drawing.Point(12, 32)
        Me.dtgvPuestos.Name = "dtgvPuestos"
        Me.dtgvPuestos.Size = New System.Drawing.Size(664, 263)
        Me.dtgvPuestos.TabIndex = 61
        '
        'PUESTOSdelMERCADO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 319)
        Me.Controls.Add(Me.dtgvPuestos)
        Me.Name = "PUESTOSdelMERCADO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PUESTOSdelMERCADO"
        CType(Me.dtgvPuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtgvPuestos As System.Windows.Forms.DataGridView
End Class
