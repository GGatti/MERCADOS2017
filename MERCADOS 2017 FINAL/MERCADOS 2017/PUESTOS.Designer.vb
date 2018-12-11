<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PUESTOS
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
        Me.txtCodPue = New System.Windows.Forms.TextBox()
        Me.btnmodpu = New System.Windows.Forms.Button()
        Me.btnbajapu = New System.Windows.Forms.Button()
        Me.btnaltapu = New System.Windows.Forms.Button()
        Me.cbxcodppu = New System.Windows.Forms.ComboBox()
        Me.lblcodppu = New System.Windows.Forms.Label()
        Me.txtcifpu = New System.Windows.Forms.TextBox()
        Me.txtnomppu = New System.Windows.Forms.TextBox()
        Me.lblcifpu = New System.Windows.Forms.Label()
        Me.lblnomppu = New System.Windows.Forms.Label()
        Me.btnIniMer = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cbxcodprop = New System.Windows.Forms.ComboBox()
        Me.lblcodmeraym = New System.Windows.Forms.Label()
        Me.txtNomPropie = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPuestosFrutas = New System.Windows.Forms.Button()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCodPue
        '
        Me.txtCodPue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodPue.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPue.Location = New System.Drawing.Point(156, 22)
        Me.txtCodPue.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCodPue.MaxLength = 4
        Me.txtCodPue.Name = "txtCodPue"
        Me.txtCodPue.ReadOnly = True
        Me.txtCodPue.Size = New System.Drawing.Size(225, 29)
        Me.txtCodPue.TabIndex = 1
        '
        'btnmodpu
        '
        Me.btnmodpu.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnmodpu.ForeColor = System.Drawing.Color.Blue
        Me.btnmodpu.Location = New System.Drawing.Point(288, 334)
        Me.btnmodpu.Margin = New System.Windows.Forms.Padding(5)
        Me.btnmodpu.Name = "btnmodpu"
        Me.btnmodpu.Size = New System.Drawing.Size(213, 49)
        Me.btnmodpu.TabIndex = 7
        Me.btnmodpu.Text = "MODIFICACIÓN"
        Me.btnmodpu.UseVisualStyleBackColor = True
        '
        'btnbajapu
        '
        Me.btnbajapu.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnbajapu.ForeColor = System.Drawing.Color.Blue
        Me.btnbajapu.Location = New System.Drawing.Point(152, 334)
        Me.btnbajapu.Margin = New System.Windows.Forms.Padding(5)
        Me.btnbajapu.Name = "btnbajapu"
        Me.btnbajapu.Size = New System.Drawing.Size(102, 49)
        Me.btnbajapu.TabIndex = 6
        Me.btnbajapu.Text = "BAJA"
        Me.btnbajapu.UseVisualStyleBackColor = True
        '
        'btnaltapu
        '
        Me.btnaltapu.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnaltapu.ForeColor = System.Drawing.Color.Blue
        Me.btnaltapu.Location = New System.Drawing.Point(41, 334)
        Me.btnaltapu.Margin = New System.Windows.Forms.Padding(5)
        Me.btnaltapu.Name = "btnaltapu"
        Me.btnaltapu.Size = New System.Drawing.Size(101, 49)
        Me.btnaltapu.TabIndex = 5
        Me.btnaltapu.Text = "ALTA"
        Me.btnaltapu.UseVisualStyleBackColor = True
        '
        'cbxcodppu
        '
        Me.cbxcodppu.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxcodppu.FormattingEnabled = True
        Me.cbxcodppu.Location = New System.Drawing.Point(156, 22)
        Me.cbxcodppu.Margin = New System.Windows.Forms.Padding(5)
        Me.cbxcodppu.MaxLength = 4
        Me.cbxcodppu.Name = "cbxcodppu"
        Me.cbxcodppu.Size = New System.Drawing.Size(225, 31)
        Me.cbxcodppu.TabIndex = 0
        '
        'lblcodppu
        '
        Me.lblcodppu.AutoSize = True
        Me.lblcodppu.Font = New System.Drawing.Font("Arial", 10.75!)
        Me.lblcodppu.Location = New System.Drawing.Point(34, 28)
        Me.lblcodppu.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblcodppu.Name = "lblcodppu"
        Me.lblcodppu.Size = New System.Drawing.Size(108, 17)
        Me.lblcodppu.TabIndex = 82
        Me.lblcodppu.Text = "Codigo Puesto:"
        '
        'txtcifpu
        '
        Me.txtcifpu.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcifpu.Location = New System.Drawing.Point(139, 143)
        Me.txtcifpu.Margin = New System.Windows.Forms.Padding(5)
        Me.txtcifpu.MaxLength = 15
        Me.txtcifpu.Name = "txtcifpu"
        Me.txtcifpu.Size = New System.Drawing.Size(242, 29)
        Me.txtcifpu.TabIndex = 2
        '
        'txtnomppu
        '
        Me.txtnomppu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnomppu.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomppu.Location = New System.Drawing.Point(152, 83)
        Me.txtnomppu.Margin = New System.Windows.Forms.Padding(5)
        Me.txtnomppu.MaxLength = 35
        Me.txtnomppu.Name = "txtnomppu"
        Me.txtnomppu.Size = New System.Drawing.Size(229, 29)
        Me.txtnomppu.TabIndex = 1
        '
        'lblcifpu
        '
        Me.lblcifpu.AutoSize = True
        Me.lblcifpu.Font = New System.Drawing.Font("Arial", 10.75!)
        Me.lblcifpu.Location = New System.Drawing.Point(34, 146)
        Me.lblcifpu.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblcifpu.Name = "lblcifpu"
        Me.lblcifpu.Size = New System.Drawing.Size(101, 17)
        Me.lblcifpu.TabIndex = 76
        Me.lblcifpu.Text = "Codigo Fiscal:"
        '
        'lblnomppu
        '
        Me.lblnomppu.AutoSize = True
        Me.lblnomppu.Font = New System.Drawing.Font("Arial", 10.75!)
        Me.lblnomppu.Location = New System.Drawing.Point(34, 89)
        Me.lblnomppu.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblnomppu.Name = "lblnomppu"
        Me.lblnomppu.Size = New System.Drawing.Size(114, 17)
        Me.lblnomppu.TabIndex = 75
        Me.lblnomppu.Text = "Nombre Puesto:"
        '
        'btnIniMer
        '
        Me.btnIniMer.FlatAppearance.BorderSize = 0
        Me.btnIniMer.Font = New System.Drawing.Font("Arial", 10.75!, System.Drawing.FontStyle.Bold)
        Me.btnIniMer.ForeColor = System.Drawing.Color.Blue
        Me.btnIniMer.Location = New System.Drawing.Point(921, 413)
        Me.btnIniMer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnIniMer.Name = "btnIniMer"
        Me.btnIniMer.Size = New System.Drawing.Size(80, 24)
        Me.btnIniMer.TabIndex = 10
        Me.btnIniMer.Text = "INICIO"
        Me.btnIniMer.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(408, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(575, 278)
        Me.DataGridView1.TabIndex = 93
        '
        'cbxcodprop
        '
        Me.cbxcodprop.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.cbxcodprop.FormattingEnabled = True
        Me.cbxcodprop.Location = New System.Drawing.Point(189, 200)
        Me.cbxcodprop.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbxcodprop.MaxDropDownItems = 20
        Me.cbxcodprop.MaxLength = 4
        Me.cbxcodprop.Name = "cbxcodprop"
        Me.cbxcodprop.Size = New System.Drawing.Size(192, 28)
        Me.cbxcodprop.TabIndex = 3
        '
        'lblcodmeraym
        '
        Me.lblcodmeraym.AutoSize = True
        Me.lblcodmeraym.Font = New System.Drawing.Font("Arial", 10.75!)
        Me.lblcodmeraym.Location = New System.Drawing.Point(41, 209)
        Me.lblcodmeraym.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcodmeraym.Name = "lblcodmeraym"
        Me.lblcodmeraym.Size = New System.Drawing.Size(132, 17)
        Me.lblcodmeraym.TabIndex = 94
        Me.lblcodmeraym.Text = "Codigo Propietario:"
        '
        'txtNomPropie
        '
        Me.txtNomPropie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomPropie.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomPropie.Location = New System.Drawing.Point(189, 251)
        Me.txtNomPropie.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNomPropie.MaxLength = 35
        Me.txtNomPropie.Name = "txtNomPropie"
        Me.txtNomPropie.ReadOnly = True
        Me.txtNomPropie.Size = New System.Drawing.Size(192, 29)
        Me.txtNomPropie.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.75!)
        Me.Label1.Location = New System.Drawing.Point(34, 257)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 17)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "Nombre Propietario:"
        '
        'btnPuestosFrutas
        '
        Me.btnPuestosFrutas.Font = New System.Drawing.Font("Arial", 10.75!, System.Drawing.FontStyle.Bold)
        Me.btnPuestosFrutas.ForeColor = System.Drawing.Color.Gold
        Me.btnPuestosFrutas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPuestosFrutas.Location = New System.Drawing.Point(23, 21)
        Me.btnPuestosFrutas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPuestosFrutas.Name = "btnPuestosFrutas"
        Me.btnPuestosFrutas.Size = New System.Drawing.Size(184, 29)
        Me.btnPuestosFrutas.TabIndex = 8
        Me.btnPuestosFrutas.Text = "ASOCIAR FRUTAS"
        Me.btnPuestosFrutas.UseVisualStyleBackColor = True
        '
        'btnStock
        '
        Me.btnStock.Font = New System.Drawing.Font("Arial", 10.75!, System.Drawing.FontStyle.Bold)
        Me.btnStock.ForeColor = System.Drawing.Color.Gold
        Me.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStock.Location = New System.Drawing.Point(226, 21)
        Me.btnStock.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(184, 29)
        Me.btnStock.TabIndex = 9
        Me.btnStock.Text = "STOCK"
        Me.btnStock.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnStock)
        Me.GroupBox1.Controls.Add(Me.btnPuestosFrutas)
        Me.GroupBox1.Location = New System.Drawing.Point(558, 321)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 62)
        Me.GroupBox1.TabIndex = 97
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FRUTAS"
        '
        'PUESTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 441)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNomPropie)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblcodmeraym)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnIniMer)
        Me.Controls.Add(Me.btnmodpu)
        Me.Controls.Add(Me.btnbajapu)
        Me.Controls.Add(Me.btnaltapu)
        Me.Controls.Add(Me.lblcodppu)
        Me.Controls.Add(Me.txtcifpu)
        Me.Controls.Add(Me.txtnomppu)
        Me.Controls.Add(Me.lblcifpu)
        Me.Controls.Add(Me.lblnomppu)
        Me.Controls.Add(Me.cbxcodprop)
        Me.Controls.Add(Me.cbxcodppu)
        Me.Controls.Add(Me.txtCodPue)
        Me.Name = "PUESTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PUESTOS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodPue As System.Windows.Forms.TextBox
    Friend WithEvents btnmodpu As System.Windows.Forms.Button
    Friend WithEvents btnbajapu As System.Windows.Forms.Button
    Friend WithEvents btnaltapu As System.Windows.Forms.Button
    Friend WithEvents cbxcodppu As System.Windows.Forms.ComboBox
    Friend WithEvents lblcodppu As System.Windows.Forms.Label
    Friend WithEvents txtcifpu As System.Windows.Forms.TextBox
    Friend WithEvents txtnomppu As System.Windows.Forms.TextBox
    Friend WithEvents lblcifpu As System.Windows.Forms.Label
    Friend WithEvents lblnomppu As System.Windows.Forms.Label
    Friend WithEvents btnIniMer As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblcodmeraym As System.Windows.Forms.Label
    Friend WithEvents txtNomPropie As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents cbxcodprop As System.Windows.Forms.ComboBox
    Friend WithEvents btnPuestosFrutas As System.Windows.Forms.Button
    Friend WithEvents btnStock As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
