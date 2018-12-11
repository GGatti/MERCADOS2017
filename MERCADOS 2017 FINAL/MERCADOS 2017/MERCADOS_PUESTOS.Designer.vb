<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MERCADOS_PUESTOS
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
        Me.cbxcodPuesto = New System.Windows.Forms.ComboBox()
        Me.cbxcodMercado = New System.Windows.Forms.ComboBox()
        Me.lblcodmeraym = New System.Windows.Forms.Label()
        Me.lblcodMerPues = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnMer_Pue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbxcodPuesto
        '
        Me.cbxcodPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxcodPuesto.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.cbxcodPuesto.FormattingEnabled = True
        Me.cbxcodPuesto.Location = New System.Drawing.Point(176, 72)
        Me.cbxcodPuesto.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbxcodPuesto.MaxDropDownItems = 20
        Me.cbxcodPuesto.MaxLength = 4
        Me.cbxcodPuesto.Name = "cbxcodPuesto"
        Me.cbxcodPuesto.Size = New System.Drawing.Size(137, 28)
        Me.cbxcodPuesto.Sorted = True
        Me.cbxcodPuesto.TabIndex = 1
        '
        'cbxcodMercado
        '
        Me.cbxcodMercado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxcodMercado.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.cbxcodMercado.FormattingEnabled = True
        Me.cbxcodMercado.Location = New System.Drawing.Point(176, 24)
        Me.cbxcodMercado.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbxcodMercado.MaxDropDownItems = 20
        Me.cbxcodMercado.MaxLength = 4
        Me.cbxcodMercado.Name = "cbxcodMercado"
        Me.cbxcodMercado.Size = New System.Drawing.Size(137, 28)
        Me.cbxcodMercado.Sorted = True
        Me.cbxcodMercado.TabIndex = 0
        '
        'lblcodmeraym
        '
        Me.lblcodmeraym.AutoSize = True
        Me.lblcodmeraym.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblcodmeraym.Location = New System.Drawing.Point(25, 30)
        Me.lblcodmeraym.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodmeraym.Name = "lblcodmeraym"
        Me.lblcodmeraym.Size = New System.Drawing.Size(135, 16)
        Me.lblcodmeraym.TabIndex = 59
        Me.lblcodmeraym.Text = "Codigo del Mercado"
        '
        'lblcodMerPues
        '
        Me.lblcodMerPues.AutoSize = True
        Me.lblcodMerPues.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblcodMerPues.Location = New System.Drawing.Point(24, 78)
        Me.lblcodMerPues.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodMerPues.Name = "lblcodMerPues"
        Me.lblcodMerPues.Size = New System.Drawing.Size(124, 16)
        Me.lblcodMerPues.TabIndex = 58
        Me.lblcodMerPues.Text = "Codigo del Puesto"
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnVolver.ForeColor = System.Drawing.Color.Blue
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.Location = New System.Drawing.Point(272, 178)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(70, 24)
        Me.btnVolver.TabIndex = 3
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnMer_Pue
        '
        Me.btnMer_Pue.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMer_Pue.ForeColor = System.Drawing.Color.Blue
        Me.btnMer_Pue.Location = New System.Drawing.Point(113, 137)
        Me.btnMer_Pue.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnMer_Pue.Name = "btnMer_Pue"
        Me.btnMer_Pue.Size = New System.Drawing.Size(110, 47)
        Me.btnMer_Pue.TabIndex = 2
        Me.btnMer_Pue.Text = "ASOCIAR"
        Me.btnMer_Pue.UseVisualStyleBackColor = True
        '
        'MERCADOS_PUESTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 214)
        Me.Controls.Add(Me.btnMer_Pue)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.cbxcodPuesto)
        Me.Controls.Add(Me.cbxcodMercado)
        Me.Controls.Add(Me.lblcodmeraym)
        Me.Controls.Add(Me.lblcodMerPues)
        Me.Name = "MERCADOS_PUESTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MERCADOS_PUESTOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxcodPuesto As System.Windows.Forms.ComboBox
    Friend WithEvents cbxcodMercado As System.Windows.Forms.ComboBox
    Friend WithEvents lblcodmeraym As System.Windows.Forms.Label
    Friend WithEvents lblcodMerPues As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnMer_Pue As System.Windows.Forms.Button
End Class
