<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ALMACENES_MERCADOS
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
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnAlm_Mer = New System.Windows.Forms.Button()
        Me.cbxcodalm = New System.Windows.Forms.ComboBox()
        Me.cbxcodmer = New System.Windows.Forms.ComboBox()
        Me.lblcodmeraym = New System.Windows.Forms.Label()
        Me.lblcodalmaym = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnVolver.ForeColor = System.Drawing.Color.Blue
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.Location = New System.Drawing.Point(195, 146)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(70, 24)
        Me.btnVolver.TabIndex = 3
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnAlm_Mer
        '
        Me.btnAlm_Mer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlm_Mer.ForeColor = System.Drawing.Color.Blue
        Me.btnAlm_Mer.Location = New System.Drawing.Point(55, 123)
        Me.btnAlm_Mer.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAlm_Mer.Name = "btnAlm_Mer"
        Me.btnAlm_Mer.Size = New System.Drawing.Size(110, 47)
        Me.btnAlm_Mer.TabIndex = 2
        Me.btnAlm_Mer.Text = "ASOCIAR"
        Me.btnAlm_Mer.UseVisualStyleBackColor = True
        '
        'cbxcodalm
        '
        Me.cbxcodalm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxcodalm.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.cbxcodalm.FormattingEnabled = True
        Me.cbxcodalm.Location = New System.Drawing.Point(120, 38)
        Me.cbxcodalm.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbxcodalm.MaxDropDownItems = 20
        Me.cbxcodalm.MaxLength = 4
        Me.cbxcodalm.Name = "cbxcodalm"
        Me.cbxcodalm.Size = New System.Drawing.Size(151, 28)
        Me.cbxcodalm.TabIndex = 0
        '
        'cbxcodmer
        '
        Me.cbxcodmer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxcodmer.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.cbxcodmer.FormattingEnabled = True
        Me.cbxcodmer.Location = New System.Drawing.Point(120, 85)
        Me.cbxcodmer.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbxcodmer.MaxDropDownItems = 20
        Me.cbxcodmer.MaxLength = 4
        Me.cbxcodmer.Name = "cbxcodmer"
        Me.cbxcodmer.Size = New System.Drawing.Size(151, 28)
        Me.cbxcodmer.TabIndex = 1
        '
        'lblcodmeraym
        '
        Me.lblcodmeraym.AutoSize = True
        Me.lblcodmeraym.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblcodmeraym.Location = New System.Drawing.Point(53, 91)
        Me.lblcodmeraym.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodmeraym.Name = "lblcodmeraym"
        Me.lblcodmeraym.Size = New System.Drawing.Size(63, 16)
        Me.lblcodmeraym.TabIndex = 59
        Me.lblcodmeraym.Text = "Mercado"
        '
        'lblcodalmaym
        '
        Me.lblcodalmaym.AutoSize = True
        Me.lblcodalmaym.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblcodalmaym.Location = New System.Drawing.Point(52, 44)
        Me.lblcodalmaym.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodalmaym.Name = "lblcodalmaym"
        Me.lblcodalmaym.Size = New System.Drawing.Size(62, 16)
        Me.lblcodalmaym.TabIndex = 58
        Me.lblcodalmaym.Text = "Almacen"
        '
        'ALMACENES_MERCADOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 210)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAlm_Mer)
        Me.Controls.Add(Me.cbxcodalm)
        Me.Controls.Add(Me.cbxcodmer)
        Me.Controls.Add(Me.lblcodmeraym)
        Me.Controls.Add(Me.lblcodalmaym)
        Me.Name = "ALMACENES_MERCADOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ALMACENES_MERCADOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents cbxcodalm As System.Windows.Forms.ComboBox
    Friend WithEvents cbxcodmer As System.Windows.Forms.ComboBox
    Friend WithEvents lblcodmeraym As System.Windows.Forms.Label
    Friend WithEvents lblcodalmaym As System.Windows.Forms.Label
    Friend WithEvents btnAlm_Mer As System.Windows.Forms.Button
End Class
