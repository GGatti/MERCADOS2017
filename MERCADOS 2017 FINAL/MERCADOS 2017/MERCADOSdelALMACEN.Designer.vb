<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MERCADOSdelALMACEN
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
        Me.dtgvMercados = New System.Windows.Forms.DataGridView()
        CType(Me.dtgvMercados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgvMercados
        '
        Me.dtgvMercados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvMercados.Location = New System.Drawing.Point(-4, -1)
        Me.dtgvMercados.Name = "dtgvMercados"
        Me.dtgvMercados.Size = New System.Drawing.Size(344, 142)
        Me.dtgvMercados.TabIndex = 62
        '
        'MERCADOSdelALMACEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 139)
        Me.Controls.Add(Me.dtgvMercados)
        Me.Name = "MERCADOSdelALMACEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MERCADOSdelALMACEN"
        CType(Me.dtgvMercados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtgvMercados As System.Windows.Forms.DataGridView
End Class
