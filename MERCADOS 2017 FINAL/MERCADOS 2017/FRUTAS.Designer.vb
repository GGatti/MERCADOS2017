<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRUTAS
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
        Me.txtNomMedFA = New System.Windows.Forms.TextBox()
        Me.txtNomFruFA = New System.Windows.Forms.TextBox()
        Me.btnmodalm = New System.Windows.Forms.Button()
        Me.btnbajafa = New System.Windows.Forms.Button()
        Me.btnaltafa = New System.Windows.Forms.Button()
        Me.lblnomedfa = New System.Windows.Forms.Label()
        Me.cbxmedidafa = New System.Windows.Forms.ComboBox()
        Me.lblcodmedfa = New System.Windows.Forms.Label()
        Me.lblnomfrufa = New System.Windows.Forms.Label()
        Me.cbxcodfru = New System.Windows.Forms.ComboBox()
        Me.lblcodfrufa = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtCodFru = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNomMedFA
        '
        Me.txtNomMedFA.Font = New System.Drawing.Font("Arial Narrow", 14.25!)
        Me.txtNomMedFA.Location = New System.Drawing.Point(159, 157)
        Me.txtNomMedFA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNomMedFA.MaxLength = 0
        Me.txtNomMedFA.Name = "txtNomMedFA"
        Me.txtNomMedFA.ReadOnly = True
        Me.txtNomMedFA.Size = New System.Drawing.Size(203, 29)
        Me.txtNomMedFA.TabIndex = 3
        '
        'txtNomFruFA
        '
        Me.txtNomFruFA.Font = New System.Drawing.Font("Arial Narrow", 14.25!)
        Me.txtNomFruFA.Location = New System.Drawing.Point(159, 60)
        Me.txtNomFruFA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNomFruFA.MaxLength = 0
        Me.txtNomFruFA.Name = "txtNomFruFA"
        Me.txtNomFruFA.Size = New System.Drawing.Size(203, 29)
        Me.txtNomFruFA.TabIndex = 1
        '
        'btnmodalm
        '
        Me.btnmodalm.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnmodalm.ForeColor = System.Drawing.Color.Blue
        Me.btnmodalm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmodalm.Location = New System.Drawing.Point(54, 284)
        Me.btnmodalm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnmodalm.Name = "btnmodalm"
        Me.btnmodalm.Size = New System.Drawing.Size(307, 57)
        Me.btnmodalm.TabIndex = 6
        Me.btnmodalm.Text = "MODIFICACIÓN"
        Me.btnmodalm.UseVisualStyleBackColor = True
        '
        'btnbajafa
        '
        Me.btnbajafa.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnbajafa.ForeColor = System.Drawing.Color.Blue
        Me.btnbajafa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbajafa.Location = New System.Drawing.Point(221, 217)
        Me.btnbajafa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnbajafa.Name = "btnbajafa"
        Me.btnbajafa.Size = New System.Drawing.Size(140, 57)
        Me.btnbajafa.TabIndex = 5
        Me.btnbajafa.Text = "BAJA"
        Me.btnbajafa.UseVisualStyleBackColor = True
        '
        'btnaltafa
        '
        Me.btnaltafa.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnaltafa.ForeColor = System.Drawing.Color.Blue
        Me.btnaltafa.Location = New System.Drawing.Point(54, 217)
        Me.btnaltafa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnaltafa.Name = "btnaltafa"
        Me.btnaltafa.Size = New System.Drawing.Size(145, 57)
        Me.btnaltafa.TabIndex = 4
        Me.btnaltafa.Text = "ALTA"
        Me.btnaltafa.UseVisualStyleBackColor = True
        '
        'lblnomedfa
        '
        Me.lblnomedfa.AutoSize = True
        Me.lblnomedfa.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblnomedfa.Location = New System.Drawing.Point(18, 163)
        Me.lblnomedfa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnomedfa.Name = "lblnomedfa"
        Me.lblnomedfa.Size = New System.Drawing.Size(131, 16)
        Me.lblnomedfa.TabIndex = 23
        Me.lblnomedfa.Text = "Nombre de Medida:"
        '
        'cbxmedidafa
        '
        Me.cbxmedidafa.Font = New System.Drawing.Font("Arial Narrow", 14.25!)
        Me.cbxmedidafa.FormattingEnabled = True
        Me.cbxmedidafa.Location = New System.Drawing.Point(159, 110)
        Me.cbxmedidafa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxmedidafa.Name = "cbxmedidafa"
        Me.cbxmedidafa.Size = New System.Drawing.Size(203, 31)
        Me.cbxmedidafa.TabIndex = 2
        '
        'lblcodmedfa
        '
        Me.lblcodmedfa.AutoSize = True
        Me.lblcodmedfa.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblcodmedfa.Location = New System.Drawing.Point(20, 114)
        Me.lblcodmedfa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcodmedfa.Name = "lblcodmedfa"
        Me.lblcodmedfa.Size = New System.Drawing.Size(127, 16)
        Me.lblcodmedfa.TabIndex = 22
        Me.lblcodmedfa.Text = "Codigo de Medida:"
        '
        'lblnomfrufa
        '
        Me.lblnomfrufa.AutoSize = True
        Me.lblnomfrufa.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblnomfrufa.Location = New System.Drawing.Point(16, 68)
        Me.lblnomfrufa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnomfrufa.Name = "lblnomfrufa"
        Me.lblnomfrufa.Size = New System.Drawing.Size(134, 16)
        Me.lblnomfrufa.TabIndex = 21
        Me.lblnomfrufa.Text = "Nombre de la Fruta:"
        '
        'cbxcodfru
        '
        Me.cbxcodfru.Font = New System.Drawing.Font("Arial Narrow", 14.25!)
        Me.cbxcodfru.Location = New System.Drawing.Point(159, 19)
        Me.cbxcodfru.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxcodfru.Name = "cbxcodfru"
        Me.cbxcodfru.Size = New System.Drawing.Size(202, 31)
        Me.cbxcodfru.TabIndex = 0
        '
        'lblcodfrufa
        '
        Me.lblcodfrufa.AutoSize = True
        Me.lblcodfrufa.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblcodfrufa.Location = New System.Drawing.Point(20, 23)
        Me.lblcodfrufa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcodfrufa.Name = "lblcodfrufa"
        Me.lblcodfrufa.Size = New System.Drawing.Size(130, 16)
        Me.lblcodfrufa.TabIndex = 20
        Me.lblcodfrufa.Text = "Codigo de la Fruta:"
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnVolver.ForeColor = System.Drawing.Color.Blue
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.Location = New System.Drawing.Point(193, 356)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(70, 24)
        Me.btnVolver.TabIndex = 7
        Me.btnVolver.Text = "INICIO"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(397, 14)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(488, 360)
        Me.DataGridView1.TabIndex = 11
        '
        'txtCodFru
        '
        Me.txtCodFru.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodFru.Font = New System.Drawing.Font("Arial Narrow", 14.25!)
        Me.txtCodFru.Location = New System.Drawing.Point(159, 21)
        Me.txtCodFru.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCodFru.MaxLength = 0
        Me.txtCodFru.Name = "txtCodFru"
        Me.txtCodFru.ReadOnly = True
        Me.txtCodFru.Size = New System.Drawing.Size(203, 29)
        Me.txtCodFru.TabIndex = 1
        '
        'FRUTAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 392)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnmodalm)
        Me.Controls.Add(Me.btnbajafa)
        Me.Controls.Add(Me.btnaltafa)
        Me.Controls.Add(Me.lblnomedfa)
        Me.Controls.Add(Me.lblcodmedfa)
        Me.Controls.Add(Me.lblnomfrufa)
        Me.Controls.Add(Me.lblcodfrufa)
        Me.Controls.Add(Me.txtNomMedFA)
        Me.Controls.Add(Me.txtNomFruFA)
        Me.Controls.Add(Me.cbxcodfru)
        Me.Controls.Add(Me.txtCodFru)
        Me.Controls.Add(Me.cbxmedidafa)
        Me.Name = "FRUTAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRUTAS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNomMedFA As System.Windows.Forms.TextBox
    Friend WithEvents txtNomFruFA As System.Windows.Forms.TextBox
    Friend WithEvents btnmodalm As System.Windows.Forms.Button
    Friend WithEvents btnbajafa As System.Windows.Forms.Button
    Friend WithEvents btnaltafa As System.Windows.Forms.Button
    Friend WithEvents lblnomedfa As System.Windows.Forms.Label
    Friend WithEvents cbxmedidafa As System.Windows.Forms.ComboBox
    Friend WithEvents lblcodmedfa As System.Windows.Forms.Label
    Friend WithEvents lblnomfrufa As System.Windows.Forms.Label
    Friend WithEvents lblcodfrufa As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtCodFru As System.Windows.Forms.TextBox
    Private WithEvents cbxcodfru As System.Windows.Forms.ComboBox
End Class
