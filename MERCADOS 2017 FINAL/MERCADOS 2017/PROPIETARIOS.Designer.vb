<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PROPIETARIOS
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
        Me.btnIniprop = New System.Windows.Forms.Button()
        Me.txtcodpprop = New System.Windows.Forms.TextBox()
        Me.lblciuprop = New System.Windows.Forms.Label()
        Me.btnpuestosprop = New System.Windows.Forms.Button()
        Me.btnmodprop = New System.Windows.Forms.Button()
        Me.btnbajaprop = New System.Windows.Forms.Button()
        Me.btnaltaprop = New System.Windows.Forms.Button()
        Me.txttelprop = New System.Windows.Forms.TextBox()
        Me.txtdireccprop = New System.Windows.Forms.TextBox()
        Me.txtnoprop = New System.Windows.Forms.TextBox()
        Me.cbxcodprop = New System.Windows.Forms.ComboBox()
        Me.lbltelprop = New System.Windows.Forms.Label()
        Me.lblcodpprop = New System.Windows.Forms.Label()
        Me.lbldireccprop = New System.Windows.Forms.Label()
        Me.lblnoprop = New System.Windows.Forms.Label()
        Me.lblcodprop = New System.Windows.Forms.Label()
        Me.txtCodprop = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxCiudad = New System.Windows.Forms.ComboBox()
        Me.cbxProv = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnIniprop
        '
        Me.btnIniprop.FlatAppearance.BorderSize = 0
        Me.btnIniprop.Font = New System.Drawing.Font("Arial", 10.75!, System.Drawing.FontStyle.Bold)
        Me.btnIniprop.ForeColor = System.Drawing.Color.Blue
        Me.btnIniprop.Location = New System.Drawing.Point(952, 384)
        Me.btnIniprop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnIniprop.Name = "btnIniprop"
        Me.btnIniprop.Size = New System.Drawing.Size(64, 24)
        Me.btnIniprop.TabIndex = 14
        Me.btnIniprop.Text = "INICIO"
        Me.btnIniprop.UseVisualStyleBackColor = True
        '
        'txtcodpprop
        '
        Me.txtcodpprop.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodpprop.Location = New System.Drawing.Point(129, 306)
        Me.txtcodpprop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcodpprop.MaxLength = 9
        Me.txtcodpprop.Name = "txtcodpprop"
        Me.txtcodpprop.Size = New System.Drawing.Size(144, 29)
        Me.txtcodpprop.TabIndex = 5
        '
        'lblciuprop
        '
        Me.lblciuprop.AutoSize = True
        Me.lblciuprop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblciuprop.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblciuprop.Location = New System.Drawing.Point(22, 267)
        Me.lblciuprop.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblciuprop.Name = "lblciuprop"
        Me.lblciuprop.Size = New System.Drawing.Size(57, 16)
        Me.lblciuprop.TabIndex = 85
        Me.lblciuprop.Text = "Ciudad:"
        Me.lblciuprop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnpuestosprop
        '
        Me.btnpuestosprop.Font = New System.Drawing.Font("Arial", 10.75!, System.Drawing.FontStyle.Bold)
        Me.btnpuestosprop.ForeColor = System.Drawing.Color.Red
        Me.btnpuestosprop.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnpuestosprop.Location = New System.Drawing.Point(735, 373)
        Me.btnpuestosprop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnpuestosprop.Name = "btnpuestosprop"
        Me.btnpuestosprop.Size = New System.Drawing.Size(123, 31)
        Me.btnpuestosprop.TabIndex = 13
        Me.btnpuestosprop.Text = "PUESTOS"
        Me.btnpuestosprop.UseVisualStyleBackColor = True
        '
        'btnmodprop
        '
        Me.btnmodprop.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnmodprop.ForeColor = System.Drawing.Color.Blue
        Me.btnmodprop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmodprop.Location = New System.Drawing.Point(458, 359)
        Me.btnmodprop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnmodprop.Name = "btnmodprop"
        Me.btnmodprop.Size = New System.Drawing.Size(178, 49)
        Me.btnmodprop.TabIndex = 12
        Me.btnmodprop.Text = "MODIFICACIÓN"
        Me.btnmodprop.UseVisualStyleBackColor = True
        '
        'btnbajaprop
        '
        Me.btnbajaprop.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnbajaprop.ForeColor = System.Drawing.Color.Blue
        Me.btnbajaprop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbajaprop.Location = New System.Drawing.Point(241, 359)
        Me.btnbajaprop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnbajaprop.Name = "btnbajaprop"
        Me.btnbajaprop.Size = New System.Drawing.Size(178, 49)
        Me.btnbajaprop.TabIndex = 11
        Me.btnbajaprop.Text = "BAJA"
        Me.btnbajaprop.UseVisualStyleBackColor = True
        '
        'btnaltaprop
        '
        Me.btnaltaprop.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnaltaprop.ForeColor = System.Drawing.Color.Blue
        Me.btnaltaprop.Location = New System.Drawing.Point(26, 359)
        Me.btnaltaprop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnaltaprop.Name = "btnaltaprop"
        Me.btnaltaprop.Size = New System.Drawing.Size(178, 49)
        Me.btnaltaprop.TabIndex = 10
        Me.btnaltaprop.Text = "ALTA"
        Me.btnaltaprop.UseVisualStyleBackColor = True
        '
        'txttelprop
        '
        Me.txttelprop.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelprop.Location = New System.Drawing.Point(93, 165)
        Me.txttelprop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txttelprop.MaxLength = 9
        Me.txttelprop.Name = "txttelprop"
        Me.txttelprop.Size = New System.Drawing.Size(180, 29)
        Me.txttelprop.TabIndex = 4
        '
        'txtdireccprop
        '
        Me.txtdireccprop.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdireccprop.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdireccprop.Location = New System.Drawing.Point(93, 118)
        Me.txtdireccprop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtdireccprop.MaxLength = 30
        Me.txtdireccprop.Name = "txtdireccprop"
        Me.txtdireccprop.Size = New System.Drawing.Size(180, 29)
        Me.txtdireccprop.TabIndex = 3
        '
        'txtnoprop
        '
        Me.txtnoprop.BackColor = System.Drawing.SystemColors.Window
        Me.txtnoprop.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnoprop.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnoprop.Location = New System.Drawing.Point(93, 73)
        Me.txtnoprop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtnoprop.MaxLength = 35
        Me.txtnoprop.Name = "txtnoprop"
        Me.txtnoprop.Size = New System.Drawing.Size(180, 29)
        Me.txtnoprop.TabIndex = 2
        '
        'cbxcodprop
        '
        Me.cbxcodprop.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxcodprop.FormattingEnabled = True
        Me.cbxcodprop.Location = New System.Drawing.Point(93, 30)
        Me.cbxcodprop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxcodprop.MaxLength = 4
        Me.cbxcodprop.Name = "cbxcodprop"
        Me.cbxcodprop.Size = New System.Drawing.Size(180, 31)
        Me.cbxcodprop.TabIndex = 0
        '
        'lbltelprop
        '
        Me.lbltelprop.AutoSize = True
        Me.lbltelprop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lbltelprop.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lbltelprop.Location = New System.Drawing.Point(22, 168)
        Me.lbltelprop.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltelprop.Name = "lbltelprop"
        Me.lbltelprop.Size = New System.Drawing.Size(66, 16)
        Me.lbltelprop.TabIndex = 74
        Me.lbltelprop.Text = "Telefono:"
        Me.lbltelprop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblcodpprop
        '
        Me.lblcodpprop.AutoSize = True
        Me.lblcodpprop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblcodpprop.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblcodpprop.Location = New System.Drawing.Point(22, 310)
        Me.lblcodpprop.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcodpprop.Name = "lblcodpprop"
        Me.lblcodpprop.Size = New System.Drawing.Size(100, 16)
        Me.lblcodpprop.TabIndex = 73
        Me.lblcodpprop.Text = "Codigo Postal:"
        Me.lblcodpprop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbldireccprop
        '
        Me.lbldireccprop.AutoSize = True
        Me.lbldireccprop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lbldireccprop.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lbldireccprop.Location = New System.Drawing.Point(22, 122)
        Me.lbldireccprop.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldireccprop.Name = "lbldireccprop"
        Me.lbldireccprop.Size = New System.Drawing.Size(71, 16)
        Me.lbldireccprop.TabIndex = 72
        Me.lbldireccprop.Text = "Direccion:"
        Me.lbldireccprop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblnoprop
        '
        Me.lblnoprop.AutoSize = True
        Me.lblnoprop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblnoprop.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblnoprop.Location = New System.Drawing.Point(22, 78)
        Me.lblnoprop.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnoprop.Name = "lblnoprop"
        Me.lblnoprop.Size = New System.Drawing.Size(61, 16)
        Me.lblnoprop.TabIndex = 71
        Me.lblnoprop.Text = "Nombre:"
        Me.lblnoprop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblcodprop
        '
        Me.lblcodprop.AutoSize = True
        Me.lblcodprop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblcodprop.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblcodprop.Location = New System.Drawing.Point(22, 35)
        Me.lblcodprop.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcodprop.Name = "lblcodprop"
        Me.lblcodprop.Size = New System.Drawing.Size(57, 16)
        Me.lblcodprop.TabIndex = 70
        Me.lblcodprop.Text = "Codigo:"
        Me.lblcodprop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodprop
        '
        Me.txtCodprop.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodprop.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodprop.Enabled = False
        Me.txtCodprop.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodprop.Location = New System.Drawing.Point(93, 31)
        Me.txtCodprop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCodprop.MaxLength = 4
        Me.txtCodprop.Name = "txtCodprop"
        Me.txtCodprop.ReadOnly = True
        Me.txtCodprop.Size = New System.Drawing.Size(180, 29)
        Me.txtCodprop.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(298, 30)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(722, 305)
        Me.DataGridView1.TabIndex = 93
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label1.Location = New System.Drawing.Point(22, 222)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Provincia:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbxCiudad
        '
        Me.cbxCiudad.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.cbxCiudad.FormattingEnabled = True
        Me.cbxCiudad.IntegralHeight = False
        Me.cbxCiudad.Location = New System.Drawing.Point(93, 259)
        Me.cbxCiudad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxCiudad.MaxLength = 4
        Me.cbxCiudad.Name = "cbxCiudad"
        Me.cbxCiudad.Size = New System.Drawing.Size(180, 28)
        Me.cbxCiudad.TabIndex = 8
        '
        'cbxProv
        '
        Me.cbxProv.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.cbxProv.FormattingEnabled = True
        Me.cbxProv.Location = New System.Drawing.Point(93, 212)
        Me.cbxProv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxProv.MaxLength = 4
        Me.cbxProv.Name = "cbxProv"
        Me.cbxProv.Size = New System.Drawing.Size(180, 28)
        Me.cbxProv.TabIndex = 6
        '
        'PROPIETARIOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 422)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnIniprop)
        Me.Controls.Add(Me.txtcodpprop)
        Me.Controls.Add(Me.lblciuprop)
        Me.Controls.Add(Me.btnpuestosprop)
        Me.Controls.Add(Me.btnmodprop)
        Me.Controls.Add(Me.btnbajaprop)
        Me.Controls.Add(Me.btnaltaprop)
        Me.Controls.Add(Me.txttelprop)
        Me.Controls.Add(Me.txtdireccprop)
        Me.Controls.Add(Me.lbltelprop)
        Me.Controls.Add(Me.lblcodpprop)
        Me.Controls.Add(Me.lbldireccprop)
        Me.Controls.Add(Me.lblnoprop)
        Me.Controls.Add(Me.lblcodprop)
        Me.Controls.Add(Me.txtnoprop)
        Me.Controls.Add(Me.txtCodprop)
        Me.Controls.Add(Me.cbxcodprop)
        Me.Controls.Add(Me.cbxProv)
        Me.Controls.Add(Me.cbxCiudad)
        Me.Name = "PROPIETARIOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PROPIETARIOS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnIniprop As System.Windows.Forms.Button
    Friend WithEvents txtcodpprop As System.Windows.Forms.TextBox
    Friend WithEvents lblciuprop As System.Windows.Forms.Label
    Friend WithEvents btnpuestosprop As System.Windows.Forms.Button
    Friend WithEvents btnmodprop As System.Windows.Forms.Button
    Friend WithEvents btnbajaprop As System.Windows.Forms.Button
    Friend WithEvents btnaltaprop As System.Windows.Forms.Button
    Friend WithEvents txttelprop As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccprop As System.Windows.Forms.TextBox
    Friend WithEvents txtnoprop As System.Windows.Forms.TextBox
    Friend WithEvents cbxcodprop As System.Windows.Forms.ComboBox
    Friend WithEvents lbltelprop As System.Windows.Forms.Label
    Friend WithEvents lblcodpprop As System.Windows.Forms.Label
    Friend WithEvents lbldireccprop As System.Windows.Forms.Label
    Friend WithEvents lblnoprop As System.Windows.Forms.Label
    Friend WithEvents lblcodprop As System.Windows.Forms.Label
    Friend WithEvents txtCodprop As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxCiudad As System.Windows.Forms.ComboBox
    Friend WithEvents cbxProv As System.Windows.Forms.ComboBox
End Class
