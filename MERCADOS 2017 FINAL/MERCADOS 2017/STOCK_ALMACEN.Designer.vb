<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class STOCK_ALMACEN
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
        Me.txtnomedfp = New System.Windows.Forms.TextBox()
        Me.lblnomedfp = New System.Windows.Forms.Label()
        Me.lblnomfrufp = New System.Windows.Forms.Label()
        Me.lblpreciofp = New System.Windows.Forms.Label()
        Me.cbxCodAlm = New System.Windows.Forms.ComboBox()
        Me.lblstockf = New System.Windows.Forms.Label()
        Me.lblCodAlm = New System.Windows.Forms.Label()
        Me.cbxcodfru = New System.Windows.Forms.ComboBox()
        Me.txtpreciofp = New System.Windows.Forms.TextBox()
        Me.txtstockfp = New System.Windows.Forms.TextBox()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtnomedfp
        '
        Me.txtnomedfp.Location = New System.Drawing.Point(106, 121)
        Me.txtnomedfp.Name = "txtnomedfp"
        Me.txtnomedfp.ReadOnly = True
        Me.txtnomedfp.Size = New System.Drawing.Size(146, 20)
        Me.txtnomedfp.TabIndex = 2
        '
        'lblnomedfp
        '
        Me.lblnomedfp.AutoSize = True
        Me.lblnomedfp.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomedfp.Location = New System.Drawing.Point(40, 124)
        Me.lblnomedfp.Name = "lblnomedfp"
        Me.lblnomedfp.Size = New System.Drawing.Size(54, 17)
        Me.lblnomedfp.TabIndex = 110
        Me.lblnomedfp.Text = "Medida"
        '
        'lblnomfrufp
        '
        Me.lblnomfrufp.AutoSize = True
        Me.lblnomfrufp.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomfrufp.Location = New System.Drawing.Point(52, 82)
        Me.lblnomfrufp.Name = "lblnomfrufp"
        Me.lblnomfrufp.Size = New System.Drawing.Size(42, 17)
        Me.lblnomfrufp.TabIndex = 108
        Me.lblnomfrufp.Text = "Fruta"
        '
        'lblpreciofp
        '
        Me.lblpreciofp.AutoSize = True
        Me.lblpreciofp.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpreciofp.Location = New System.Drawing.Point(44, 156)
        Me.lblpreciofp.Name = "lblpreciofp"
        Me.lblpreciofp.Size = New System.Drawing.Size(50, 17)
        Me.lblpreciofp.TabIndex = 101
        Me.lblpreciofp.Text = "Precio"
        '
        'cbxCodAlm
        '
        Me.cbxCodAlm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCodAlm.FormattingEnabled = True
        Me.cbxCodAlm.Location = New System.Drawing.Point(106, 42)
        Me.cbxCodAlm.Name = "cbxCodAlm"
        Me.cbxCodAlm.Size = New System.Drawing.Size(146, 21)
        Me.cbxCodAlm.TabIndex = 0
        '
        'lblstockf
        '
        Me.lblstockf.AutoSize = True
        Me.lblstockf.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstockf.Location = New System.Drawing.Point(49, 186)
        Me.lblstockf.Name = "lblstockf"
        Me.lblstockf.Size = New System.Drawing.Size(45, 17)
        Me.lblstockf.TabIndex = 102
        Me.lblstockf.Text = "Stock"
        '
        'lblCodAlm
        '
        Me.lblCodAlm.AutoSize = True
        Me.lblCodAlm.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodAlm.Location = New System.Drawing.Point(29, 46)
        Me.lblCodAlm.Name = "lblCodAlm"
        Me.lblCodAlm.Size = New System.Drawing.Size(65, 17)
        Me.lblCodAlm.TabIndex = 106
        Me.lblCodAlm.Text = "Almacen"
        '
        'cbxcodfru
        '
        Me.cbxcodfru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxcodfru.FormattingEnabled = True
        Me.cbxcodfru.Location = New System.Drawing.Point(106, 82)
        Me.cbxcodfru.Name = "cbxcodfru"
        Me.cbxcodfru.Size = New System.Drawing.Size(146, 21)
        Me.cbxcodfru.TabIndex = 1
        '
        'txtpreciofp
        '
        Me.txtpreciofp.Location = New System.Drawing.Point(106, 156)
        Me.txtpreciofp.Name = "txtpreciofp"
        Me.txtpreciofp.Size = New System.Drawing.Size(146, 20)
        Me.txtpreciofp.TabIndex = 3
        Me.txtpreciofp.Tag = ""
        '
        'txtstockfp
        '
        Me.txtstockfp.Location = New System.Drawing.Point(106, 186)
        Me.txtstockfp.Name = "txtstockfp"
        Me.txtstockfp.Size = New System.Drawing.Size(146, 20)
        Me.txtstockfp.TabIndex = 4
        '
        'btnActualizar
        '
        Me.btnActualizar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnActualizar.ForeColor = System.Drawing.Color.Blue
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.Location = New System.Drawing.Point(63, 235)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(164, 55)
        Me.btnActualizar.TabIndex = 5
        Me.btnActualizar.Text = "ACTUALIZAR"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnVolver.ForeColor = System.Drawing.Color.Blue
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.Location = New System.Drawing.Point(221, 318)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(70, 24)
        Me.btnVolver.TabIndex = 6
        Me.btnVolver.Text = "VOLVER"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'STOCK_ALMACEN
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
        Me.Controls.Add(Me.cbxCodAlm)
        Me.Controls.Add(Me.lblstockf)
        Me.Controls.Add(Me.lblCodAlm)
        Me.Controls.Add(Me.cbxcodfru)
        Me.Controls.Add(Me.txtpreciofp)
        Me.Controls.Add(Me.txtstockfp)
        Me.Name = "STOCK_ALMACEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STOCK DEL ALMACEN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnomedfp As System.Windows.Forms.TextBox
    Friend WithEvents lblnomedfp As System.Windows.Forms.Label
    Friend WithEvents lblnomfrufp As System.Windows.Forms.Label
    Friend WithEvents lblpreciofp As System.Windows.Forms.Label
    Friend WithEvents lblstockf As System.Windows.Forms.Label
    Friend WithEvents lblCodAlm As System.Windows.Forms.Label
    Friend WithEvents txtpreciofp As System.Windows.Forms.TextBox
    Friend WithEvents txtstockfp As System.Windows.Forms.TextBox
    Private WithEvents cbxCodAlm As System.Windows.Forms.ComboBox
    Private WithEvents cbxcodfru As System.Windows.Forms.ComboBox
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
