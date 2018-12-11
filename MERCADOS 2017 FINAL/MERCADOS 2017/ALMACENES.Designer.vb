<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ALMACENES
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtCODALMALM = New System.Windows.Forms.TextBox()
        Me.CBOXALMACEN = New System.Windows.Forms.ComboBox()
        Me.btninialm = New System.Windows.Forms.Button()
        Me.btnmeralm = New System.Windows.Forms.Button()
        Me.btnmodificacionalm = New System.Windows.Forms.Button()
        Me.btnbajalm = New System.Windows.Forms.Button()
        Me.btnaltalm = New System.Windows.Forms.Button()
        Me.txtnomalm = New System.Windows.Forms.TextBox()
        Me.txtcifalm = New System.Windows.Forms.TextBox()
        Me.lblcifalm = New System.Windows.Forms.Label()
        Me.lblnombrealm = New System.Windows.Forms.Label()
        Me.lblcodalm = New System.Windows.Forms.Label()
        Me.btnAlmFrutas = New System.Windows.Forms.Button()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.btnMerdelAlm = New System.Windows.Forms.Button()
        Me.ADMINISTRAR = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ADMINISTRAR.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(315, 34)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(376, 162)
        Me.DataGridView1.TabIndex = 68
        '
        'txtCODALMALM
        '
        Me.txtCODALMALM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCODALMALM.Font = New System.Drawing.Font("Arial Narrow", 14.25!)
        Me.txtCODALMALM.Location = New System.Drawing.Point(141, 34)
        Me.txtCODALMALM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCODALMALM.MaxLength = 35
        Me.txtCODALMALM.Name = "txtCODALMALM"
        Me.txtCODALMALM.ReadOnly = True
        Me.txtCODALMALM.Size = New System.Drawing.Size(144, 29)
        Me.txtCODALMALM.TabIndex = 1
        Me.txtCODALMALM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBOXALMACEN
        '
        Me.CBOXALMACEN.Font = New System.Drawing.Font("Arial Narrow", 14.25!)
        Me.CBOXALMACEN.FormattingEnabled = True
        Me.CBOXALMACEN.Location = New System.Drawing.Point(141, 34)
        Me.CBOXALMACEN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CBOXALMACEN.MaxDropDownItems = 20
        Me.CBOXALMACEN.MaxLength = 4
        Me.CBOXALMACEN.Name = "CBOXALMACEN"
        Me.CBOXALMACEN.Size = New System.Drawing.Size(144, 31)
        Me.CBOXALMACEN.Sorted = True
        Me.CBOXALMACEN.TabIndex = 0
        '
        'btninialm
        '
        Me.btninialm.FlatAppearance.BorderSize = 0
        Me.btninialm.Font = New System.Drawing.Font("Arial", 10.75!, System.Drawing.FontStyle.Bold)
        Me.btninialm.ForeColor = System.Drawing.Color.Blue
        Me.btninialm.Location = New System.Drawing.Point(650, 414)
        Me.btninialm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btninialm.Name = "btninialm"
        Me.btninialm.Size = New System.Drawing.Size(64, 24)
        Me.btninialm.TabIndex = 10
        Me.btninialm.Text = "INICIO"
        Me.btninialm.UseVisualStyleBackColor = True
        '
        'btnmeralm
        '
        Me.btnmeralm.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnmeralm.ForeColor = System.Drawing.Color.Red
        Me.btnmeralm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnmeralm.Location = New System.Drawing.Point(25, 23)
        Me.btnmeralm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnmeralm.Name = "btnmeralm"
        Me.btnmeralm.Size = New System.Drawing.Size(184, 29)
        Me.btnmeralm.TabIndex = 7
        Me.btnmeralm.Text = "ASOCIAR MERCADO"
        Me.btnmeralm.UseVisualStyleBackColor = True
        '
        'btnmodificacionalm
        '
        Me.btnmodificacionalm.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnmodificacionalm.ForeColor = System.Drawing.Color.Blue
        Me.btnmodificacionalm.Location = New System.Drawing.Point(484, 232)
        Me.btnmodificacionalm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnmodificacionalm.Name = "btnmodificacionalm"
        Me.btnmodificacionalm.Size = New System.Drawing.Size(207, 51)
        Me.btnmodificacionalm.TabIndex = 6
        Me.btnmodificacionalm.Text = "MODIFICACIÓN"
        Me.btnmodificacionalm.UseVisualStyleBackColor = True
        '
        'btnbajalm
        '
        Me.btnbajalm.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnbajalm.ForeColor = System.Drawing.Color.Blue
        Me.btnbajalm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbajalm.Location = New System.Drawing.Point(252, 232)
        Me.btnbajalm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnbajalm.Name = "btnbajalm"
        Me.btnbajalm.Size = New System.Drawing.Size(207, 51)
        Me.btnbajalm.TabIndex = 5
        Me.btnbajalm.Text = "BAJA"
        Me.btnbajalm.UseVisualStyleBackColor = True
        '
        'btnaltalm
        '
        Me.btnaltalm.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnaltalm.ForeColor = System.Drawing.Color.Blue
        Me.btnaltalm.Location = New System.Drawing.Point(21, 232)
        Me.btnaltalm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnaltalm.Name = "btnaltalm"
        Me.btnaltalm.Size = New System.Drawing.Size(207, 51)
        Me.btnaltalm.TabIndex = 4
        Me.btnaltalm.TabStop = False
        Me.btnaltalm.Text = "ALTA"
        Me.btnaltalm.UseVisualStyleBackColor = True
        '
        'txtnomalm
        '
        Me.txtnomalm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnomalm.Font = New System.Drawing.Font("Arial Narrow", 14.25!)
        Me.txtnomalm.Location = New System.Drawing.Point(103, 101)
        Me.txtnomalm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtnomalm.MaxLength = 20
        Me.txtnomalm.Name = "txtnomalm"
        Me.txtnomalm.Size = New System.Drawing.Size(182, 29)
        Me.txtnomalm.TabIndex = 2
        '
        'txtcifalm
        '
        Me.txtcifalm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcifalm.Font = New System.Drawing.Font("Arial Narrow", 14.25!)
        Me.txtcifalm.Location = New System.Drawing.Point(103, 167)
        Me.txtcifalm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcifalm.MaxLength = 15
        Me.txtcifalm.Name = "txtcifalm"
        Me.txtcifalm.Size = New System.Drawing.Size(182, 29)
        Me.txtcifalm.TabIndex = 3
        '
        'lblcifalm
        '
        Me.lblcifalm.AutoSize = True
        Me.lblcifalm.Font = New System.Drawing.Font("Arial", 10.75!)
        Me.lblcifalm.Location = New System.Drawing.Point(21, 176)
        Me.lblcifalm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcifalm.Name = "lblcifalm"
        Me.lblcifalm.Size = New System.Drawing.Size(86, 17)
        Me.lblcifalm.TabIndex = 58
        Me.lblcifalm.Text = "Cod. Fiscal:"
        '
        'lblnombrealm
        '
        Me.lblnombrealm.AutoSize = True
        Me.lblnombrealm.Font = New System.Drawing.Font("Arial", 10.75!)
        Me.lblnombrealm.Location = New System.Drawing.Point(43, 109)
        Me.lblnombrealm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnombrealm.Name = "lblnombrealm"
        Me.lblnombrealm.Size = New System.Drawing.Size(64, 17)
        Me.lblnombrealm.TabIndex = 55
        Me.lblnombrealm.Text = "Nombre:"
        '
        'lblcodalm
        '
        Me.lblcodalm.AutoSize = True
        Me.lblcodalm.Font = New System.Drawing.Font("Arial", 10.75!)
        Me.lblcodalm.Location = New System.Drawing.Point(21, 42)
        Me.lblcodalm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcodalm.Name = "lblcodalm"
        Me.lblcodalm.Size = New System.Drawing.Size(118, 17)
        Me.lblcodalm.TabIndex = 54
        Me.lblcodalm.Text = "Codigo Almacen:"
        '
        'btnAlmFrutas
        '
        Me.btnAlmFrutas.Font = New System.Drawing.Font("Arial", 10.75!, System.Drawing.FontStyle.Bold)
        Me.btnAlmFrutas.ForeColor = System.Drawing.Color.Gold
        Me.btnAlmFrutas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAlmFrutas.Location = New System.Drawing.Point(25, 18)
        Me.btnAlmFrutas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAlmFrutas.Name = "btnAlmFrutas"
        Me.btnAlmFrutas.Size = New System.Drawing.Size(184, 29)
        Me.btnAlmFrutas.TabIndex = 8
        Me.btnAlmFrutas.Text = "ASOCIAR FRUTAS"
        Me.btnAlmFrutas.UseVisualStyleBackColor = True
        '
        'btnStock
        '
        Me.btnStock.Font = New System.Drawing.Font("Arial", 10.75!, System.Drawing.FontStyle.Bold)
        Me.btnStock.ForeColor = System.Drawing.Color.Gold
        Me.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStock.Location = New System.Drawing.Point(88, 57)
        Me.btnStock.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(75, 29)
        Me.btnStock.TabIndex = 9
        Me.btnStock.Text = "STOCK"
        Me.btnStock.UseVisualStyleBackColor = True
        '
        'btnMerdelAlm
        '
        Me.btnMerdelAlm.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnMerdelAlm.ForeColor = System.Drawing.Color.Red
        Me.btnMerdelAlm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMerdelAlm.Location = New System.Drawing.Point(25, 62)
        Me.btnMerdelAlm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMerdelAlm.Name = "btnMerdelAlm"
        Me.btnMerdelAlm.Size = New System.Drawing.Size(184, 29)
        Me.btnMerdelAlm.TabIndex = 69
        Me.btnMerdelAlm.Text = "MERCADOS ASOCIADOS"
        Me.btnMerdelAlm.UseVisualStyleBackColor = True
        '
        'ADMINISTRAR
        '
        Me.ADMINISTRAR.Controls.Add(Me.btnMerdelAlm)
        Me.ADMINISTRAR.Controls.Add(Me.btnmeralm)
        Me.ADMINISTRAR.Location = New System.Drawing.Point(56, 316)
        Me.ADMINISTRAR.Name = "ADMINISTRAR"
        Me.ADMINISTRAR.Size = New System.Drawing.Size(229, 103)
        Me.ADMINISTRAR.TabIndex = 70
        Me.ADMINISTRAR.TabStop = False
        Me.ADMINISTRAR.Text = "MERCADOS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnStock)
        Me.GroupBox1.Controls.Add(Me.btnAlmFrutas)
        Me.GroupBox1.Location = New System.Drawing.Point(361, 316)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 98)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FRUTAS"
        '
        'ALMACENES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 439)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ADMINISTRAR)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btninialm)
        Me.Controls.Add(Me.btnmodificacionalm)
        Me.Controls.Add(Me.btnbajalm)
        Me.Controls.Add(Me.txtnomalm)
        Me.Controls.Add(Me.txtcifalm)
        Me.Controls.Add(Me.lblcifalm)
        Me.Controls.Add(Me.lblnombrealm)
        Me.Controls.Add(Me.lblcodalm)
        Me.Controls.Add(Me.btnaltalm)
        Me.Controls.Add(Me.CBOXALMACEN)
        Me.Controls.Add(Me.txtCODALMALM)
        Me.Name = "ALMACENES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ALMACENES"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ADMINISTRAR.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtCODALMALM As System.Windows.Forms.TextBox
    Friend WithEvents CBOXALMACEN As System.Windows.Forms.ComboBox
    Friend WithEvents btninialm As System.Windows.Forms.Button
    Friend WithEvents btnmeralm As System.Windows.Forms.Button
    Friend WithEvents btnmodificacionalm As System.Windows.Forms.Button
    Friend WithEvents btnbajalm As System.Windows.Forms.Button
    Friend WithEvents btnaltalm As System.Windows.Forms.Button
    Friend WithEvents txtnomalm As System.Windows.Forms.TextBox
    Friend WithEvents txtcifalm As System.Windows.Forms.TextBox
    Friend WithEvents lblcifalm As System.Windows.Forms.Label
    Friend WithEvents lblnombrealm As System.Windows.Forms.Label
    Friend WithEvents lblcodalm As System.Windows.Forms.Label
    Friend WithEvents btnAlmFrutas As System.Windows.Forms.Button
    Friend WithEvents btnStock As System.Windows.Forms.Button
    Friend WithEvents btnMerdelAlm As System.Windows.Forms.Button
    Friend WithEvents ADMINISTRAR As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
