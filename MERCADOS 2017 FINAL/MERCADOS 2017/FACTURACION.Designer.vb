<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FACTURACION
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbldescfac = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnfinfac = New System.Windows.Forms.Button()
        Me.txtdescfac = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btningrefac = New System.Windows.Forms.Button()
        Me.dtgfac = New System.Windows.Forms.DataGridView()
        Me.txtcantfac = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbxcodfrufac = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbxcodpuefac = New System.Windows.Forms.ComboBox()
        Me.cbxcodmerfac = New System.Windows.Forms.ComboBox()
        Me.lblnomerfac = New System.Windows.Forms.Label()
        Me.lblnomalmfac = New System.Windows.Forms.Label()
        Me.cbxcodalmfac = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblsubtotfac = New System.Windows.Forms.Label()
        Me.lblivafac = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbltotfac = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblnumfacfac = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblfechafac = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnIniprop = New System.Windows.Forms.Button()
        Me.txtMedida = New System.Windows.Forms.TextBox()
        CType(Me.dtgfac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(531, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 16)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "%"
        '
        'lbldescfac
        '
        Me.lbldescfac.AutoSize = True
        Me.lbldescfac.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lbldescfac.Location = New System.Drawing.Point(751, 460)
        Me.lbldescfac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldescfac.Name = "lbldescfac"
        Me.lbldescfac.Size = New System.Drawing.Size(0, 16)
        Me.lbldescfac.TabIndex = 81
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label26.Location = New System.Drawing.Point(648, 461)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(80, 16)
        Me.Label26.TabIndex = 80
        Me.Label26.Text = "Descuento:"
        '
        'btnfinfac
        '
        Me.btnfinfac.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnfinfac.ForeColor = System.Drawing.Color.Blue
        Me.btnfinfac.Location = New System.Drawing.Point(914, 425)
        Me.btnfinfac.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnfinfac.Name = "btnfinfac"
        Me.btnfinfac.Size = New System.Drawing.Size(120, 35)
        Me.btnfinfac.TabIndex = 8
        Me.btnfinfac.Text = "FINALIZAR"
        Me.btnfinfac.UseVisualStyleBackColor = True
        '
        'txtdescfac
        '
        Me.txtdescfac.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescfac.Location = New System.Drawing.Point(470, 117)
        Me.txtdescfac.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtdescfac.MaxLength = 2
        Me.txtdescfac.Name = "txtdescfac"
        Me.txtdescfac.Size = New System.Drawing.Size(60, 22)
        Me.txtdescfac.TabIndex = 6
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label21.Location = New System.Drawing.Point(392, 120)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 16)
        Me.Label21.TabIndex = 76
        Me.Label21.Text = "Descuento:"
        '
        'btningrefac
        '
        Me.btningrefac.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btningrefac.ForeColor = System.Drawing.Color.Blue
        Me.btningrefac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btningrefac.Location = New System.Drawing.Point(606, 110)
        Me.btningrefac.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btningrefac.Name = "btningrefac"
        Me.btningrefac.Size = New System.Drawing.Size(121, 35)
        Me.btningrefac.TabIndex = 7
        Me.btningrefac.Text = "PROCESAR"
        Me.btningrefac.UseVisualStyleBackColor = True
        '
        'dtgfac
        '
        Me.dtgfac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgfac.DefaultCellStyle = DataGridViewCellStyle1
        Me.dtgfac.Location = New System.Drawing.Point(50, 166)
        Me.dtgfac.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtgfac.Name = "dtgfac"
        Me.dtgfac.Size = New System.Drawing.Size(966, 222)
        Me.dtgfac.TabIndex = 73
        '
        'txtcantfac
        '
        Me.txtcantfac.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantfac.Location = New System.Drawing.Point(299, 114)
        Me.txtcantfac.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcantfac.MaxLength = 4
        Me.txtcantfac.Multiline = True
        Me.txtcantfac.Name = "txtcantfac"
        Me.txtcantfac.Size = New System.Drawing.Size(69, 24)
        Me.txtcantfac.TabIndex = 5
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label23.Location = New System.Drawing.Point(232, 117)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(69, 16)
        Me.Label23.TabIndex = 71
        Me.Label23.Text = "Cantidad:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label22.Location = New System.Drawing.Point(882, 65)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(58, 16)
        Me.Label22.TabIndex = 69
        Me.Label22.Text = "Medida:"
        '
        'cbxcodfrufac
        '
        Me.cbxcodfrufac.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxcodfrufac.FormattingEnabled = True
        Me.cbxcodfrufac.Location = New System.Drawing.Point(747, 62)
        Me.cbxcodfrufac.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxcodfrufac.Name = "cbxcodfrufac"
        Me.cbxcodfrufac.Size = New System.Drawing.Size(122, 24)
        Me.cbxcodfrufac.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label20.Location = New System.Drawing.Point(704, 65)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(46, 16)
        Me.Label20.TabIndex = 67
        Me.Label20.Text = "Fruta:"
        '
        'cbxcodpuefac
        '
        Me.cbxcodpuefac.FormattingEnabled = True
        Me.cbxcodpuefac.Location = New System.Drawing.Point(542, 64)
        Me.cbxcodpuefac.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxcodpuefac.Name = "cbxcodpuefac"
        Me.cbxcodpuefac.Size = New System.Drawing.Size(122, 21)
        Me.cbxcodpuefac.TabIndex = 2
        '
        'cbxcodmerfac
        '
        Me.cbxcodmerfac.FormattingEnabled = True
        Me.cbxcodmerfac.Location = New System.Drawing.Point(330, 64)
        Me.cbxcodmerfac.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxcodmerfac.Name = "cbxcodmerfac"
        Me.cbxcodmerfac.Size = New System.Drawing.Size(122, 21)
        Me.cbxcodmerfac.TabIndex = 1
        '
        'lblnomerfac
        '
        Me.lblnomerfac.AutoSize = True
        Me.lblnomerfac.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblnomerfac.Location = New System.Drawing.Point(365, 103)
        Me.lblnomerfac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnomerfac.Name = "lblnomerfac"
        Me.lblnomerfac.Size = New System.Drawing.Size(0, 16)
        Me.lblnomerfac.TabIndex = 62
        '
        'lblnomalmfac
        '
        Me.lblnomalmfac.AutoSize = True
        Me.lblnomalmfac.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblnomalmfac.Location = New System.Drawing.Point(28, 110)
        Me.lblnomalmfac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnomalmfac.Name = "lblnomalmfac"
        Me.lblnomalmfac.Size = New System.Drawing.Size(0, 16)
        Me.lblnomalmfac.TabIndex = 60
        '
        'cbxcodalmfac
        '
        Me.cbxcodalmfac.FormattingEnabled = True
        Me.cbxcodalmfac.Location = New System.Drawing.Point(106, 64)
        Me.cbxcodalmfac.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxcodalmfac.Name = "cbxcodalmfac"
        Me.cbxcodalmfac.Size = New System.Drawing.Size(122, 21)
        Me.cbxcodalmfac.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(476, 65)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 16)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "PUESTO:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(253, 65)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 16)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "MERCADO:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(33, 66)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 16)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "ALMACEN:"
        '
        'lblsubtotfac
        '
        Me.lblsubtotfac.AutoSize = True
        Me.lblsubtotfac.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblsubtotfac.Location = New System.Drawing.Point(751, 411)
        Me.lblsubtotfac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsubtotfac.Name = "lblsubtotfac"
        Me.lblsubtotfac.Size = New System.Drawing.Size(0, 16)
        Me.lblsubtotfac.TabIndex = 54
        '
        'lblivafac
        '
        Me.lblivafac.AutoSize = True
        Me.lblivafac.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblivafac.Location = New System.Drawing.Point(751, 436)
        Me.lblivafac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblivafac.Name = "lblivafac"
        Me.lblivafac.Size = New System.Drawing.Size(0, 16)
        Me.lblivafac.TabIndex = 53
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(639, 411)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "SUB TOTAL:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(692, 436)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 16)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "IVA:"
        '
        'lbltotfac
        '
        Me.lbltotfac.AutoSize = True
        Me.lbltotfac.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lbltotfac.Location = New System.Drawing.Point(753, 491)
        Me.lbltotfac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltotfac.Name = "lbltotfac"
        Me.lbltotfac.Size = New System.Drawing.Size(0, 16)
        Me.lbltotfac.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(666, 491)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "TOTAL:"
        '
        'lblnumfacfac
        '
        Me.lblnumfacfac.AutoSize = True
        Me.lblnumfacfac.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblnumfacfac.Location = New System.Drawing.Point(459, 21)
        Me.lblnumfacfac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnumfacfac.Name = "lblnumfacfac"
        Me.lblnumfacfac.Size = New System.Drawing.Size(0, 16)
        Me.lblnumfacfac.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(352, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Nº FACTURA:"
        '
        'lblfechafac
        '
        Me.lblfechafac.AutoSize = True
        Me.lblfechafac.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblfechafac.Location = New System.Drawing.Point(603, 21)
        Me.lblfechafac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfechafac.Name = "lblfechafac"
        Me.lblfechafac.Size = New System.Drawing.Size(0, 16)
        Me.lblfechafac.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(539, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Fecha:"
        '
        'btnIniprop
        '
        Me.btnIniprop.FlatAppearance.BorderSize = 0
        Me.btnIniprop.Font = New System.Drawing.Font("Arial", 10.75!, System.Drawing.FontStyle.Bold)
        Me.btnIniprop.ForeColor = System.Drawing.Color.Blue
        Me.btnIniprop.Location = New System.Drawing.Point(989, 487)
        Me.btnIniprop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnIniprop.Name = "btnIniprop"
        Me.btnIniprop.Size = New System.Drawing.Size(64, 24)
        Me.btnIniprop.TabIndex = 9
        Me.btnIniprop.Text = "INICIO"
        Me.btnIniprop.UseVisualStyleBackColor = True
        '
        'txtMedida
        '
        Me.txtMedida.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedida.Location = New System.Drawing.Point(942, 62)
        Me.txtMedida.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMedida.MaxLength = 2
        Me.txtMedida.Multiline = True
        Me.txtMedida.Name = "txtMedida"
        Me.txtMedida.ReadOnly = True
        Me.txtMedida.Size = New System.Drawing.Size(102, 24)
        Me.txtMedida.TabIndex = 4
        '
        'FACTURACION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 521)
        Me.Controls.Add(Me.txtMedida)
        Me.Controls.Add(Me.btnIniprop)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbldescfac)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.btnfinfac)
        Me.Controls.Add(Me.txtdescfac)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.btningrefac)
        Me.Controls.Add(Me.dtgfac)
        Me.Controls.Add(Me.txtcantfac)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cbxcodfrufac)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cbxcodpuefac)
        Me.Controls.Add(Me.cbxcodmerfac)
        Me.Controls.Add(Me.lblnomerfac)
        Me.Controls.Add(Me.lblnomalmfac)
        Me.Controls.Add(Me.cbxcodalmfac)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblsubtotfac)
        Me.Controls.Add(Me.lblivafac)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbltotfac)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblnumfacfac)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblfechafac)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FACTURACION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FACTURACION"
        CType(Me.dtgfac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbldescfac As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents btnfinfac As System.Windows.Forms.Button
    Friend WithEvents txtdescfac As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btningrefac As System.Windows.Forms.Button
    Friend WithEvents dtgfac As System.Windows.Forms.DataGridView
    Friend WithEvents txtcantfac As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cbxcodfrufac As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cbxcodpuefac As System.Windows.Forms.ComboBox
    Friend WithEvents cbxcodmerfac As System.Windows.Forms.ComboBox
    Friend WithEvents lblnomerfac As System.Windows.Forms.Label
    Friend WithEvents lblnomalmfac As System.Windows.Forms.Label
    Friend WithEvents cbxcodalmfac As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblsubtotfac As System.Windows.Forms.Label
    Friend WithEvents lblivafac As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbltotfac As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblnumfacfac As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblfechafac As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnIniprop As System.Windows.Forms.Button
    Friend WithEvents txtMedida As System.Windows.Forms.TextBox
End Class
