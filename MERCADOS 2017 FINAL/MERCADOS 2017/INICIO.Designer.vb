<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INICIO
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
        Me.btnfruini = New System.Windows.Forms.Button()
        Me.btnpueini = New System.Windows.Forms.Button()
        Me.btnpropini = New System.Windows.Forms.Button()
        Me.btnalmini = New System.Windows.Forms.Button()
        Me.btnmerini = New System.Windows.Forms.Button()
        Me.btnfacini = New System.Windows.Forms.Button()
        Me.btnsalirini = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnfruini
        '
        Me.btnfruini.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnfruini.ForeColor = System.Drawing.Color.Blue
        Me.btnfruini.Location = New System.Drawing.Point(234, 96)
        Me.btnfruini.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnfruini.Name = "btnfruini"
        Me.btnfruini.Size = New System.Drawing.Size(188, 57)
        Me.btnfruini.TabIndex = 5
        Me.btnfruini.Text = "FRUTAS"
        Me.btnfruini.UseVisualStyleBackColor = True
        '
        'btnpueini
        '
        Me.btnpueini.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnpueini.ForeColor = System.Drawing.Color.Blue
        Me.btnpueini.Location = New System.Drawing.Point(234, 30)
        Me.btnpueini.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnpueini.Name = "btnpueini"
        Me.btnpueini.Size = New System.Drawing.Size(188, 57)
        Me.btnpueini.TabIndex = 4
        Me.btnpueini.Text = "PUESTOS"
        Me.btnpueini.UseVisualStyleBackColor = True
        '
        'btnpropini
        '
        Me.btnpropini.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnpropini.ForeColor = System.Drawing.Color.Blue
        Me.btnpropini.Location = New System.Drawing.Point(24, 162)
        Me.btnpropini.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnpropini.Name = "btnpropini"
        Me.btnpropini.Size = New System.Drawing.Size(188, 57)
        Me.btnpropini.TabIndex = 3
        Me.btnpropini.Text = "PROPIETARIOS"
        Me.btnpropini.UseVisualStyleBackColor = True
        '
        'btnalmini
        '
        Me.btnalmini.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnalmini.ForeColor = System.Drawing.Color.Blue
        Me.btnalmini.Location = New System.Drawing.Point(24, 30)
        Me.btnalmini.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnalmini.Name = "btnalmini"
        Me.btnalmini.Size = New System.Drawing.Size(188, 57)
        Me.btnalmini.TabIndex = 1
        Me.btnalmini.Text = "ALMACENES"
        Me.btnalmini.UseVisualStyleBackColor = True
        '
        'btnmerini
        '
        Me.btnmerini.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnmerini.ForeColor = System.Drawing.Color.Blue
        Me.btnmerini.Location = New System.Drawing.Point(24, 96)
        Me.btnmerini.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnmerini.Name = "btnmerini"
        Me.btnmerini.Size = New System.Drawing.Size(188, 57)
        Me.btnmerini.TabIndex = 2
        Me.btnmerini.Text = "MERCADOS"
        Me.btnmerini.UseVisualStyleBackColor = True
        '
        'btnfacini
        '
        Me.btnfacini.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnfacini.ForeColor = System.Drawing.Color.Blue
        Me.btnfacini.Location = New System.Drawing.Point(234, 163)
        Me.btnfacini.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnfacini.Name = "btnfacini"
        Me.btnfacini.Size = New System.Drawing.Size(188, 57)
        Me.btnfacini.TabIndex = 6
        Me.btnfacini.Text = "FACTURAS"
        Me.btnfacini.UseVisualStyleBackColor = True
        '
        'btnsalirini
        '
        Me.btnsalirini.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnsalirini.ForeColor = System.Drawing.Color.Blue
        Me.btnsalirini.Location = New System.Drawing.Point(354, 243)
        Me.btnsalirini.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnsalirini.Name = "btnsalirini"
        Me.btnsalirini.Size = New System.Drawing.Size(68, 30)
        Me.btnsalirini.TabIndex = 0
        Me.btnsalirini.Text = "Salir"
        Me.btnsalirini.UseVisualStyleBackColor = True
        '
        'INICIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 297)
        Me.Controls.Add(Me.btnsalirini)
        Me.Controls.Add(Me.btnfacini)
        Me.Controls.Add(Me.btnfruini)
        Me.Controls.Add(Me.btnpueini)
        Me.Controls.Add(Me.btnpropini)
        Me.Controls.Add(Me.btnalmini)
        Me.Controls.Add(Me.btnmerini)
        Me.Name = "INICIO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INICIO"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnfruini As System.Windows.Forms.Button
    Friend WithEvents btnpueini As System.Windows.Forms.Button
    Friend WithEvents btnpropini As System.Windows.Forms.Button
    Friend WithEvents btnalmini As System.Windows.Forms.Button
    Friend WithEvents btnmerini As System.Windows.Forms.Button
    Friend WithEvents btnfacini As System.Windows.Forms.Button
    Friend WithEvents btnsalirini As System.Windows.Forms.Button
End Class
