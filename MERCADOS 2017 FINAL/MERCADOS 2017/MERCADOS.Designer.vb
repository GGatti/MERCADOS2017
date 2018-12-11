<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MERCADOS
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
        Me.txtCodMer = New System.Windows.Forms.TextBox()
        Me.cbxciumer = New System.Windows.Forms.ComboBox()
        Me.cbxprovmer = New System.Windows.Forms.ComboBox()
        Me.lblciumer = New System.Windows.Forms.Label()
        Me.lblprovmer = New System.Windows.Forms.Label()
        Me.btnAsociarMerPue = New System.Windows.Forms.Button()
        Me.btnmodmer = New System.Windows.Forms.Button()
        Me.btnbajamer = New System.Windows.Forms.Button()
        Me.btnaltamer = New System.Windows.Forms.Button()
        Me.txttelmer = New System.Windows.Forms.TextBox()
        Me.txtcodpmer = New System.Windows.Forms.TextBox()
        Me.txtdireccmer = New System.Windows.Forms.TextBox()
        Me.txtnomer = New System.Windows.Forms.TextBox()
        Me.cbxcodmer = New System.Windows.Forms.ComboBox()
        Me.lbltelmer = New System.Windows.Forms.Label()
        Me.lblcodpmer = New System.Windows.Forms.Label()
        Me.lbldireccmer = New System.Windows.Forms.Label()
        Me.lblnomer = New System.Windows.Forms.Label()
        Me.lblcodmer = New System.Windows.Forms.Label()
        Me.btnIniMer = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnPuestos = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCodMer
        '
        Me.txtCodMer.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodMer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodMer.Font = New System.Drawing.Font("Arial Narrow", 14.25!)
        Me.txtCodMer.Location = New System.Drawing.Point(109, 26)
        Me.txtCodMer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCodMer.MaxLength = 4
        Me.txtCodMer.Name = "txtCodMer"
        Me.txtCodMer.ReadOnly = True
        Me.txtCodMer.Size = New System.Drawing.Size(180, 29)
        Me.txtCodMer.TabIndex = 0
        '
        'cbxciumer
        '
        Me.cbxciumer.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.cbxciumer.FormattingEnabled = True
        Me.cbxciumer.IntegralHeight = False
        Me.cbxciumer.Location = New System.Drawing.Point(109, 288)
        Me.cbxciumer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxciumer.MaxLength = 25
        Me.cbxciumer.Name = "cbxciumer"
        Me.cbxciumer.Size = New System.Drawing.Size(180, 28)
        Me.cbxciumer.TabIndex = 9
        '
        'cbxprovmer
        '
        Me.cbxprovmer.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.cbxprovmer.FormattingEnabled = True
        Me.cbxprovmer.Location = New System.Drawing.Point(109, 236)
        Me.cbxprovmer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxprovmer.MaxLength = 25
        Me.cbxprovmer.Name = "cbxprovmer"
        Me.cbxprovmer.Size = New System.Drawing.Size(180, 28)
        Me.cbxprovmer.TabIndex = 6
        '
        'lblciumer
        '
        Me.lblciumer.AutoSize = True
        Me.lblciumer.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblciumer.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblciumer.Location = New System.Drawing.Point(12, 292)
        Me.lblciumer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblciumer.Name = "lblciumer"
        Me.lblciumer.Size = New System.Drawing.Size(75, 22)
        Me.lblciumer.TabIndex = 63
        Me.lblciumer.Text = "Ciudad:"
        Me.lblciumer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblprovmer
        '
        Me.lblprovmer.AutoSize = True
        Me.lblprovmer.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprovmer.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblprovmer.Location = New System.Drawing.Point(12, 240)
        Me.lblprovmer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblprovmer.Name = "lblprovmer"
        Me.lblprovmer.Size = New System.Drawing.Size(92, 22)
        Me.lblprovmer.TabIndex = 62
        Me.lblprovmer.Text = "Provincia:"
        Me.lblprovmer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAsociarMerPue
        '
        Me.btnAsociarMerPue.Font = New System.Drawing.Font("Arial", 10.75!, System.Drawing.FontStyle.Bold)
        Me.btnAsociarMerPue.ForeColor = System.Drawing.Color.Red
        Me.btnAsociarMerPue.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAsociarMerPue.Location = New System.Drawing.Point(24, 23)
        Me.btnAsociarMerPue.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAsociarMerPue.Name = "btnAsociarMerPue"
        Me.btnAsociarMerPue.Size = New System.Drawing.Size(178, 38)
        Me.btnAsociarMerPue.TabIndex = 13
        Me.btnAsociarMerPue.Text = "ASOCIAR PUESTO"
        Me.btnAsociarMerPue.UseVisualStyleBackColor = True
        '
        'btnmodmer
        '
        Me.btnmodmer.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnmodmer.ForeColor = System.Drawing.Color.Blue
        Me.btnmodmer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmodmer.Location = New System.Drawing.Point(449, 402)
        Me.btnmodmer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnmodmer.Name = "btnmodmer"
        Me.btnmodmer.Size = New System.Drawing.Size(178, 49)
        Me.btnmodmer.TabIndex = 12
        Me.btnmodmer.Text = "MODIFICACIÓN"
        Me.btnmodmer.UseVisualStyleBackColor = True
        '
        'btnbajamer
        '
        Me.btnbajamer.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnbajamer.ForeColor = System.Drawing.Color.Blue
        Me.btnbajamer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbajamer.Location = New System.Drawing.Point(233, 402)
        Me.btnbajamer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnbajamer.Name = "btnbajamer"
        Me.btnbajamer.Size = New System.Drawing.Size(178, 49)
        Me.btnbajamer.TabIndex = 11
        Me.btnbajamer.Text = "BAJA"
        Me.btnbajamer.UseVisualStyleBackColor = True
        '
        'btnaltamer
        '
        Me.btnaltamer.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnaltamer.ForeColor = System.Drawing.Color.Blue
        Me.btnaltamer.Location = New System.Drawing.Point(16, 402)
        Me.btnaltamer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnaltamer.Name = "btnaltamer"
        Me.btnaltamer.Size = New System.Drawing.Size(178, 49)
        Me.btnaltamer.TabIndex = 10
        Me.btnaltamer.Text = "ALTA"
        Me.btnaltamer.UseVisualStyleBackColor = True
        '
        'txttelmer
        '
        Me.txttelmer.Font = New System.Drawing.Font("Arial Narrow", 14.25!)
        Me.txttelmer.Location = New System.Drawing.Point(109, 182)
        Me.txttelmer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txttelmer.MaxLength = 9
        Me.txttelmer.Name = "txttelmer"
        Me.txttelmer.Size = New System.Drawing.Size(180, 29)
        Me.txttelmer.TabIndex = 4
        '
        'txtcodpmer
        '
        Me.txtcodpmer.Font = New System.Drawing.Font("Arial Narrow", 14.25!)
        Me.txtcodpmer.Location = New System.Drawing.Point(145, 339)
        Me.txtcodpmer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcodpmer.MaxLength = 9
        Me.txtcodpmer.Name = "txtcodpmer"
        Me.txtcodpmer.Size = New System.Drawing.Size(144, 29)
        Me.txtcodpmer.TabIndex = 7
        '
        'txtdireccmer
        '
        Me.txtdireccmer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdireccmer.Font = New System.Drawing.Font("Arial Narrow", 14.25!)
        Me.txtdireccmer.Location = New System.Drawing.Point(109, 130)
        Me.txtdireccmer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtdireccmer.MaxLength = 30
        Me.txtdireccmer.Name = "txtdireccmer"
        Me.txtdireccmer.Size = New System.Drawing.Size(180, 29)
        Me.txtdireccmer.TabIndex = 3
        '
        'txtnomer
        '
        Me.txtnomer.BackColor = System.Drawing.SystemColors.Window
        Me.txtnomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnomer.Font = New System.Drawing.Font("Arial Narrow", 14.25!)
        Me.txtnomer.Location = New System.Drawing.Point(109, 76)
        Me.txtnomer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtnomer.MaxLength = 35
        Me.txtnomer.Name = "txtnomer"
        Me.txtnomer.Size = New System.Drawing.Size(180, 29)
        Me.txtnomer.TabIndex = 2
        '
        'cbxcodmer
        '
        Me.cbxcodmer.Font = New System.Drawing.Font("Arial Narrow", 14.25!)
        Me.cbxcodmer.FormattingEnabled = True
        Me.cbxcodmer.Location = New System.Drawing.Point(109, 25)
        Me.cbxcodmer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxcodmer.MaxLength = 4
        Me.cbxcodmer.Name = "cbxcodmer"
        Me.cbxcodmer.Size = New System.Drawing.Size(180, 31)
        Me.cbxcodmer.TabIndex = 1
        '
        'lbltelmer
        '
        Me.lbltelmer.AutoSize = True
        Me.lbltelmer.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltelmer.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lbltelmer.Location = New System.Drawing.Point(12, 185)
        Me.lbltelmer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltelmer.Name = "lbltelmer"
        Me.lbltelmer.Size = New System.Drawing.Size(89, 22)
        Me.lbltelmer.TabIndex = 52
        Me.lbltelmer.Text = "Telefono:"
        Me.lbltelmer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblcodpmer
        '
        Me.lblcodpmer.AutoSize = True
        Me.lblcodpmer.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodpmer.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblcodpmer.Location = New System.Drawing.Point(12, 343)
        Me.lblcodpmer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcodpmer.Name = "lblcodpmer"
        Me.lblcodpmer.Size = New System.Drawing.Size(135, 22)
        Me.lblcodpmer.TabIndex = 51
        Me.lblcodpmer.Text = "Codigo Postal:"
        Me.lblcodpmer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbldireccmer
        '
        Me.lbldireccmer.AutoSize = True
        Me.lbldireccmer.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldireccmer.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lbldireccmer.Location = New System.Drawing.Point(12, 134)
        Me.lbldireccmer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldireccmer.Name = "lbldireccmer"
        Me.lbldireccmer.Size = New System.Drawing.Size(95, 22)
        Me.lbldireccmer.TabIndex = 50
        Me.lbldireccmer.Text = "Direccion:"
        Me.lbldireccmer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblnomer
        '
        Me.lblnomer.AutoSize = True
        Me.lblnomer.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomer.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblnomer.Location = New System.Drawing.Point(12, 81)
        Me.lblnomer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnomer.Name = "lblnomer"
        Me.lblnomer.Size = New System.Drawing.Size(83, 22)
        Me.lblnomer.TabIndex = 49
        Me.lblnomer.Text = "Nombre:"
        Me.lblnomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblcodmer
        '
        Me.lblcodmer.AutoSize = True
        Me.lblcodmer.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodmer.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblcodmer.Location = New System.Drawing.Point(12, 30)
        Me.lblcodmer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcodmer.Name = "lblcodmer"
        Me.lblcodmer.Size = New System.Drawing.Size(77, 22)
        Me.lblcodmer.TabIndex = 48
        Me.lblcodmer.Text = "Codigo:"
        Me.lblcodmer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnIniMer
        '
        Me.btnIniMer.FlatAppearance.BorderSize = 0
        Me.btnIniMer.Font = New System.Drawing.Font("Arial", 10.75!, System.Drawing.FontStyle.Bold)
        Me.btnIniMer.ForeColor = System.Drawing.Color.Blue
        Me.btnIniMer.Location = New System.Drawing.Point(1023, 487)
        Me.btnIniMer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnIniMer.Name = "btnIniMer"
        Me.btnIniMer.Size = New System.Drawing.Size(64, 24)
        Me.btnIniMer.TabIndex = 14
        Me.btnIniMer.Text = "INICIO"
        Me.btnIniMer.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(314, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(756, 343)
        Me.DataGridView1.TabIndex = 22
        '
        'btnPuestos
        '
        Me.btnPuestos.Font = New System.Drawing.Font("Arial", 10.75!, System.Drawing.FontStyle.Bold)
        Me.btnPuestos.ForeColor = System.Drawing.Color.Red
        Me.btnPuestos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPuestos.Location = New System.Drawing.Point(256, 21)
        Me.btnPuestos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPuestos.Name = "btnPuestos"
        Me.btnPuestos.Size = New System.Drawing.Size(105, 38)
        Me.btnPuestos.TabIndex = 64
        Me.btnPuestos.Text = "PUESTOS"
        Me.btnPuestos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPuestos)
        Me.GroupBox1.Controls.Add(Me.btnAsociarMerPue)
        Me.GroupBox1.Location = New System.Drawing.Point(682, 389)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 77)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PUESTOS"
        '
        'MERCADOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 518)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnIniMer)
        Me.Controls.Add(Me.txtcodpmer)
        Me.Controls.Add(Me.lblciumer)
        Me.Controls.Add(Me.lblprovmer)
        Me.Controls.Add(Me.btnmodmer)
        Me.Controls.Add(Me.btnbajamer)
        Me.Controls.Add(Me.btnaltamer)
        Me.Controls.Add(Me.txttelmer)
        Me.Controls.Add(Me.txtdireccmer)
        Me.Controls.Add(Me.txtnomer)
        Me.Controls.Add(Me.lbltelmer)
        Me.Controls.Add(Me.lblcodpmer)
        Me.Controls.Add(Me.lbldireccmer)
        Me.Controls.Add(Me.lblnomer)
        Me.Controls.Add(Me.lblcodmer)
        Me.Controls.Add(Me.cbxcodmer)
        Me.Controls.Add(Me.cbxprovmer)
        Me.Controls.Add(Me.cbxciumer)
        Me.Controls.Add(Me.txtCodMer)
        Me.Name = "MERCADOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MERCADOS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodMer As System.Windows.Forms.TextBox
    Friend WithEvents cbxciumer As System.Windows.Forms.ComboBox
    Friend WithEvents cbxprovmer As System.Windows.Forms.ComboBox
    Friend WithEvents lblciumer As System.Windows.Forms.Label
    Friend WithEvents lblprovmer As System.Windows.Forms.Label
    Friend WithEvents btnAsociarMerPue As System.Windows.Forms.Button
    Friend WithEvents btnmodmer As System.Windows.Forms.Button
    Friend WithEvents btnbajamer As System.Windows.Forms.Button
    Friend WithEvents btnaltamer As System.Windows.Forms.Button
    Friend WithEvents txttelmer As System.Windows.Forms.TextBox
    Friend WithEvents txtcodpmer As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccmer As System.Windows.Forms.TextBox
    Friend WithEvents txtnomer As System.Windows.Forms.TextBox
    Friend WithEvents cbxcodmer As System.Windows.Forms.ComboBox
    Friend WithEvents lbltelmer As System.Windows.Forms.Label
    Friend WithEvents lblcodpmer As System.Windows.Forms.Label
    Friend WithEvents lbldireccmer As System.Windows.Forms.Label
    Friend WithEvents lblnomer As System.Windows.Forms.Label
    Friend WithEvents lblcodmer As System.Windows.Forms.Label
    Friend WithEvents btnIniMer As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnPuestos As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
