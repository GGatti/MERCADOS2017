<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ALMACEN_FRUTAS
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxCodAlm = New System.Windows.Forms.ComboBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnAsociar = New System.Windows.Forms.Button()
        Me.lblcodfrufa = New System.Windows.Forms.Label()
        Me.cbxcodfru = New System.Windows.Forms.ComboBox()
        Me.lblpreciofp = New System.Windows.Forms.Label()
        Me.lblstockf = New System.Windows.Forms.Label()
        Me.txtpreciofp = New System.Windows.Forms.TextBox()
        Me.txtstockfp = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(45, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Codigo de Almacen:"
        '
        'cbxCodAlm
        '
        Me.cbxCodAlm.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbxCodAlm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCodAlm.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCodAlm.FormattingEnabled = True
        Me.cbxCodAlm.ItemHeight = 20
        Me.cbxCodAlm.Location = New System.Drawing.Point(183, 44)
        Me.cbxCodAlm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxCodAlm.Name = "cbxCodAlm"
        Me.cbxCodAlm.Size = New System.Drawing.Size(127, 28)
        Me.cbxCodAlm.TabIndex = 0
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnVolver.ForeColor = System.Drawing.Color.Blue
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.Location = New System.Drawing.Point(240, 301)
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
        Me.btnAsociar.Location = New System.Drawing.Point(37, 264)
        Me.btnAsociar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAsociar.Name = "btnAsociar"
        Me.btnAsociar.Size = New System.Drawing.Size(174, 57)
        Me.btnAsociar.TabIndex = 4
        Me.btnAsociar.Text = "ASOCIAR"
        Me.btnAsociar.UseVisualStyleBackColor = True
        '
        'lblcodfrufa
        '
        Me.lblcodfrufa.AutoSize = True
        Me.lblcodfrufa.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblcodfrufa.Location = New System.Drawing.Point(45, 93)
        Me.lblcodfrufa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcodfrufa.Name = "lblcodfrufa"
        Me.lblcodfrufa.Size = New System.Drawing.Size(130, 16)
        Me.lblcodfrufa.TabIndex = 36
        Me.lblcodfrufa.Text = "Codigo de la Fruta:"
        '
        'cbxcodfru
        '
        Me.cbxcodfru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxcodfru.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxcodfru.FormattingEnabled = True
        Me.cbxcodfru.Location = New System.Drawing.Point(184, 89)
        Me.cbxcodfru.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxcodfru.Name = "cbxcodfru"
        Me.cbxcodfru.Size = New System.Drawing.Size(127, 28)
        Me.cbxcodfru.TabIndex = 1
        '
        'lblpreciofp
        '
        Me.lblpreciofp.AutoSize = True
        Me.lblpreciofp.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpreciofp.Location = New System.Drawing.Point(105, 140)
        Me.lblpreciofp.Name = "lblpreciofp"
        Me.lblpreciofp.Size = New System.Drawing.Size(50, 17)
        Me.lblpreciofp.TabIndex = 106
        Me.lblpreciofp.Text = "Precio"
        '
        'lblstockf
        '
        Me.lblstockf.AutoSize = True
        Me.lblstockf.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstockf.Location = New System.Drawing.Point(110, 181)
        Me.lblstockf.Name = "lblstockf"
        Me.lblstockf.Size = New System.Drawing.Size(45, 17)
        Me.lblstockf.TabIndex = 107
        Me.lblstockf.Text = "Stock"
        '
        'txtpreciofp
        '
        Me.txtpreciofp.Location = New System.Drawing.Point(183, 140)
        Me.txtpreciofp.Name = "txtpreciofp"
        Me.txtpreciofp.Size = New System.Drawing.Size(127, 20)
        Me.txtpreciofp.TabIndex = 2
        Me.txtpreciofp.Tag = ""
        '
        'txtstockfp
        '
        Me.txtstockfp.Location = New System.Drawing.Point(183, 181)
        Me.txtstockfp.Name = "txtstockfp"
        Me.txtstockfp.Size = New System.Drawing.Size(127, 20)
        Me.txtstockfp.TabIndex = 3
        '
        'ALMACEN_FRUTAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 356)
        Me.Controls.Add(Me.lblpreciofp)
        Me.Controls.Add(Me.lblstockf)
        Me.Controls.Add(Me.txtpreciofp)
        Me.Controls.Add(Me.txtstockfp)
        Me.Controls.Add(Me.lblcodfrufa)
        Me.Controls.Add(Me.cbxcodfru)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAsociar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxCodAlm)
        Me.Name = "ALMACEN_FRUTAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ALMACEN_FRUTAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxCodAlm As System.Windows.Forms.ComboBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnAsociar As System.Windows.Forms.Button
    Friend WithEvents lblcodfrufa As System.Windows.Forms.Label
    Friend WithEvents cbxcodfru As System.Windows.Forms.ComboBox
    Friend WithEvents lblpreciofp As System.Windows.Forms.Label
    Friend WithEvents lblstockf As System.Windows.Forms.Label
    Friend WithEvents txtpreciofp As System.Windows.Forms.TextBox
    Friend WithEvents txtstockfp As System.Windows.Forms.TextBox
End Class
