<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PUESTOS_FRUTAS
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
        Me.cbxCodPue = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxcodfrufp = New System.Windows.Forms.ComboBox()
        Me.lblcodfrufp = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnAsociar = New System.Windows.Forms.Button()
        Me.lblpreciofp = New System.Windows.Forms.Label()
        Me.lblstockf = New System.Windows.Forms.Label()
        Me.txtpreciofp = New System.Windows.Forms.TextBox()
        Me.txtstockfp = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cbxCodPue
        '
        Me.cbxCodPue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCodPue.FormattingEnabled = True
        Me.cbxCodPue.Location = New System.Drawing.Point(121, 62)
        Me.cbxCodPue.Name = "cbxCodPue"
        Me.cbxCodPue.Size = New System.Drawing.Size(158, 21)
        Me.cbxCodPue.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(17, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 16)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Codigo Puesto:"
        '
        'cbxcodfrufp
        '
        Me.cbxcodfrufp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxcodfrufp.FormattingEnabled = True
        Me.cbxcodfrufp.Location = New System.Drawing.Point(121, 106)
        Me.cbxcodfrufp.Name = "cbxcodfrufp"
        Me.cbxcodfrufp.Size = New System.Drawing.Size(158, 21)
        Me.cbxcodfrufp.TabIndex = 1
        '
        'lblcodfrufp
        '
        Me.lblcodfrufp.AutoSize = True
        Me.lblcodfrufp.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblcodfrufp.Location = New System.Drawing.Point(27, 108)
        Me.lblcodfrufp.Name = "lblcodfrufp"
        Me.lblcodfrufp.Size = New System.Drawing.Size(95, 16)
        Me.lblcodfrufp.TabIndex = 88
        Me.lblcodfrufp.Text = "Codigo Fruta:"
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnVolver.ForeColor = System.Drawing.Color.Blue
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.Location = New System.Drawing.Point(224, 287)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(70, 24)
        Me.btnVolver.TabIndex = 5
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnAsociar
        '
        Me.btnAsociar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnAsociar.ForeColor = System.Drawing.Color.Blue
        Me.btnAsociar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAsociar.Location = New System.Drawing.Point(30, 256)
        Me.btnAsociar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAsociar.Name = "btnAsociar"
        Me.btnAsociar.Size = New System.Drawing.Size(164, 55)
        Me.btnAsociar.TabIndex = 4
        Me.btnAsociar.Text = "ASOCIAR"
        Me.btnAsociar.UseVisualStyleBackColor = True
        '
        'lblpreciofp
        '
        Me.lblpreciofp.AutoSize = True
        Me.lblpreciofp.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpreciofp.Location = New System.Drawing.Point(59, 147)
        Me.lblpreciofp.Name = "lblpreciofp"
        Me.lblpreciofp.Size = New System.Drawing.Size(50, 17)
        Me.lblpreciofp.TabIndex = 119
        Me.lblpreciofp.Text = "Precio"
        '
        'lblstockf
        '
        Me.lblstockf.AutoSize = True
        Me.lblstockf.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstockf.Location = New System.Drawing.Point(64, 190)
        Me.lblstockf.Name = "lblstockf"
        Me.lblstockf.Size = New System.Drawing.Size(45, 17)
        Me.lblstockf.TabIndex = 120
        Me.lblstockf.Text = "Stock"
        '
        'txtpreciofp
        '
        Me.txtpreciofp.Location = New System.Drawing.Point(121, 147)
        Me.txtpreciofp.Name = "txtpreciofp"
        Me.txtpreciofp.Size = New System.Drawing.Size(158, 20)
        Me.txtpreciofp.TabIndex = 2
        Me.txtpreciofp.Tag = ""
        '
        'txtstockfp
        '
        Me.txtstockfp.Location = New System.Drawing.Point(121, 190)
        Me.txtstockfp.Name = "txtstockfp"
        Me.txtstockfp.Size = New System.Drawing.Size(158, 20)
        Me.txtstockfp.TabIndex = 3
        '
        'PUESTOS_FRUTAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 332)
        Me.Controls.Add(Me.lblpreciofp)
        Me.Controls.Add(Me.lblstockf)
        Me.Controls.Add(Me.txtpreciofp)
        Me.Controls.Add(Me.txtstockfp)
        Me.Controls.Add(Me.btnAsociar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.cbxCodPue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxcodfrufp)
        Me.Controls.Add(Me.lblcodfrufp)
        Me.Name = "PUESTOS_FRUTAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PUESTOS_FRUTAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxCodPue As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbxcodfrufp As System.Windows.Forms.ComboBox
    Friend WithEvents lblcodfrufp As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnAsociar As System.Windows.Forms.Button
    Friend WithEvents lblpreciofp As System.Windows.Forms.Label
    Friend WithEvents lblstockf As System.Windows.Forms.Label
    Friend WithEvents txtpreciofp As System.Windows.Forms.TextBox
    Friend WithEvents txtstockfp As System.Windows.Forms.TextBox
End Class
