<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class STOCK_PUESTOS
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
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.txtnomedfp = New System.Windows.Forms.TextBox()
        Me.lblnomedfp = New System.Windows.Forms.Label()
        Me.lblnomfrufp = New System.Windows.Forms.Label()
        Me.lblpreciofp = New System.Windows.Forms.Label()
        Me.cbxCodPue = New System.Windows.Forms.ComboBox()
        Me.lblstockf = New System.Windows.Forms.Label()
        Me.lblCodPue = New System.Windows.Forms.Label()
        Me.cbxcodfru = New System.Windows.Forms.ComboBox()
        Me.txtpreciofp = New System.Windows.Forms.TextBox()
        Me.txtstockfp = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnVolver.ForeColor = System.Drawing.Color.Blue
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.Location = New System.Drawing.Point(212, 303)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(70, 24)
        Me.btnVolver.TabIndex = 6
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnActualizar.ForeColor = System.Drawing.Color.Blue
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.Location = New System.Drawing.Point(54, 220)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(164, 55)
        Me.btnActualizar.TabIndex = 5
        Me.btnActualizar.Text = "ACTUALIZAR"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'txtnomedfp
        '
        Me.txtnomedfp.Location = New System.Drawing.Point(97, 106)
        Me.txtnomedfp.Name = "txtnomedfp"
        Me.txtnomedfp.ReadOnly = True
        Me.txtnomedfp.Size = New System.Drawing.Size(156, 20)
        Me.txtnomedfp.TabIndex = 2
        '
        'lblnomedfp
        '
        Me.lblnomedfp.AutoSize = True
        Me.lblnomedfp.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomedfp.Location = New System.Drawing.Point(31, 109)
        Me.lblnomedfp.Name = "lblnomedfp"
        Me.lblnomedfp.Size = New System.Drawing.Size(54, 17)
        Me.lblnomedfp.TabIndex = 122
        Me.lblnomedfp.Text = "Medida"
        '
        'lblnomfrufp
        '
        Me.lblnomfrufp.AutoSize = True
        Me.lblnomfrufp.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomfrufp.Location = New System.Drawing.Point(43, 67)
        Me.lblnomfrufp.Name = "lblnomfrufp"
        Me.lblnomfrufp.Size = New System.Drawing.Size(42, 17)
        Me.lblnomfrufp.TabIndex = 121
        Me.lblnomfrufp.Text = "Fruta"
        '
        'lblpreciofp
        '
        Me.lblpreciofp.AutoSize = True
        Me.lblpreciofp.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpreciofp.Location = New System.Drawing.Point(35, 141)
        Me.lblpreciofp.Name = "lblpreciofp"
        Me.lblpreciofp.Size = New System.Drawing.Size(50, 17)
        Me.lblpreciofp.TabIndex = 114
        Me.lblpreciofp.Text = "Precio"
        '
        'cbxCodPue
        '
        Me.cbxCodPue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCodPue.FormattingEnabled = True
        Me.cbxCodPue.Location = New System.Drawing.Point(97, 27)
        Me.cbxCodPue.Name = "cbxCodPue"
        Me.cbxCodPue.Size = New System.Drawing.Size(156, 21)
        Me.cbxCodPue.TabIndex = 0
        '
        'lblstockf
        '
        Me.lblstockf.AutoSize = True
        Me.lblstockf.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstockf.Location = New System.Drawing.Point(40, 171)
        Me.lblstockf.Name = "lblstockf"
        Me.lblstockf.Size = New System.Drawing.Size(45, 17)
        Me.lblstockf.TabIndex = 115
        Me.lblstockf.Text = "Stock"
        '
        'lblCodPue
        '
        Me.lblCodPue.AutoSize = True
        Me.lblCodPue.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodPue.Location = New System.Drawing.Point(20, 31)
        Me.lblCodPue.Name = "lblCodPue"
        Me.lblCodPue.Size = New System.Drawing.Size(62, 17)
        Me.lblCodPue.TabIndex = 119
        Me.lblCodPue.Text = "Puestos"
        '
        'cbxcodfru
        '
        Me.cbxcodfru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxcodfru.FormattingEnabled = True
        Me.cbxcodfru.Location = New System.Drawing.Point(97, 67)
        Me.cbxcodfru.Name = "cbxcodfru"
        Me.cbxcodfru.Size = New System.Drawing.Size(156, 21)
        Me.cbxcodfru.TabIndex = 1
        '
        'txtpreciofp
        '
        Me.txtpreciofp.Location = New System.Drawing.Point(97, 141)
        Me.txtpreciofp.Name = "txtpreciofp"
        Me.txtpreciofp.Size = New System.Drawing.Size(156, 20)
        Me.txtpreciofp.TabIndex = 3
        Me.txtpreciofp.Tag = ""
        '
        'txtstockfp
        '
        Me.txtstockfp.Location = New System.Drawing.Point(97, 171)
        Me.txtstockfp.Name = "txtstockfp"
        Me.txtstockfp.Size = New System.Drawing.Size(156, 20)
        Me.txtstockfp.TabIndex = 4
        '
        'STOCK_PUESTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 354)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.txtnomedfp)
        Me.Controls.Add(Me.lblnomedfp)
        Me.Controls.Add(Me.lblnomfrufp)
        Me.Controls.Add(Me.lblpreciofp)
        Me.Controls.Add(Me.cbxCodPue)
        Me.Controls.Add(Me.lblstockf)
        Me.Controls.Add(Me.lblCodPue)
        Me.Controls.Add(Me.cbxcodfru)
        Me.Controls.Add(Me.txtpreciofp)
        Me.Controls.Add(Me.txtstockfp)
        Me.Name = "STOCK_PUESTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STOCK_PUESTOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents txtnomedfp As System.Windows.Forms.TextBox
    Friend WithEvents lblnomedfp As System.Windows.Forms.Label
    Friend WithEvents lblnomfrufp As System.Windows.Forms.Label
    Friend WithEvents lblpreciofp As System.Windows.Forms.Label
    Private WithEvents cbxCodPue As System.Windows.Forms.ComboBox
    Friend WithEvents lblstockf As System.Windows.Forms.Label
    Friend WithEvents lblCodPue As System.Windows.Forms.Label
    Private WithEvents cbxcodfru As System.Windows.Forms.ComboBox
    Friend WithEvents txtpreciofp As System.Windows.Forms.TextBox
    Friend WithEvents txtstockfp As System.Windows.Forms.TextBox
End Class
