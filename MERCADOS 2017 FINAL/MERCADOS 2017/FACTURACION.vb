Imports System.Data.OleDb
Public Class FACTURACION
    Dim conexion As New OleDb.OleDbConnection
    Dim comandos As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim consulta As String
    Dim lista As Byte
    Dim id, CFrut, CodMed, cds As Integer
    Dim FPre As Decimal
    Dim linea, SubTotal As Integer
    Private Sub FACTURACION_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Se perderan los datos de facturacion que no haya finalizado, Continuar con la accion?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = Windows.Forms.DialogResult.Yes Then
            Me.Hide()
            INICIO.Show()
            consulta = "DELETE * FROM tmpLINFAC"
            comandos = New OleDbCommand(consulta, conexion)
            comandos.ExecuteNonQuery()
        End If
        e.Cancel = True

    End Sub
    Private Sub FACTURACION_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            'Carga el label con la fecha
            lblfechafac.Text = DateTime.Now().ToString("dd/MM/yyyy")

            conexion = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\MERCADOS 2017\MERCADOS 2017\Mercados 2017.accdb;Persist Security Info = False;")

            conexion.Open()
            Cargar_Almacenes()
            cbxcodalmfac.Text = ""
            btnfinfac.Enabled = False
            'Carga el numero de factura nueva
            lblnumfacfac.Text = NumFact()
            MessageBox.Show("La Conexion a la base de datos ha sido exitosa", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox("Se ha producido un error al querer conectarse con la base de datos", vbExclamation, "Error")
            Exit Sub

        End Try
        lblsubtotfac.Text = ""
        lblivafac.Text = ""
        lbldescfac.Text = ""
        lbltotfac.Text = ""
    End Sub
    Sub Cargar_Almacenes()
        'se carga el combo almacenes
        consulta = "SELECT* FROM almacenes "
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "almacenes")
        cbxcodalmfac.DataSource = ds.Tables(0)
        cbxcodalmfac.DisplayMember = "NOMALM"
        cbxcodalmfac.ValueMember = "codalm"
    End Sub
    Private Sub cbxcodalmfac_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxcodalmfac.SelectionChangeCommitted
        cbxcodfrufac.Text = ""
        cbxcodpuefac.Text = ""
        txtMedida.Text = ""
        txtcantfac.Text = ""
        txtdescfac.Text = ""

        'Se cargan los Mercados del Almacen seleccionado en el combo almacen 
        Dim consul As String = "SELECT A.codalm, M.codmer, M.nommer" & _
" FROM mercados AS M INNER JOIN (almacenes AS A INNER JOIN almmer AS AM ON A.codalm = AM.codalm) ON M.codmer = AM.codmer" & _
" WHERE A.codalm = '" & cbxcodalmfac.SelectedValue.ToString & "'" & _
" ORDER BY M.codmer "
        Dim cmd As New OleDbCommand(consul, conexion)

        Dim da As New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "MERCADOS")

        cbxcodmerfac.DataSource = ds.Tables(0)
        cbxcodmerfac.DisplayMember = "NOMMER"
        cbxcodmerfac.ValueMember = "CODMER"
        cbxcodmerfac.Text = ""
    End Sub
    Private Sub cbxcodmerfac_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxcodmerfac.SelectionChangeCommitted
        'Se cargan los puestos del mercado seleccionado
       
        Dim consul As String = "SELECT M.CODMER, P.CODPTO, P.NOMTO" & _
   " FROM (MERCADOS AS M INNER JOIN MERPUE AS MP ON M.CODMER = MP.CODMER) INNER JOIN PUESTOS AS P ON MP.CODPTO = P.CODPTO" & _
" WHERE M.CODMER ='" & cbxcodmerfac.SelectedValue.ToString & "'" & _
" ORDER BY P.CODPTO"

        Dim cmd As New OleDbCommand(consul, conexion)
        Dim da As New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "PUESTOS")

        cbxcodpuefac.DataSource = ds.Tables(0)
        cbxcodpuefac.DisplayMember = "NOMTO"
        cbxcodpuefac.ValueMember = "CODPTO"

        cbxcodpuefac.Text = ""
        cbxcodfrufac.Text = ""
        txtMedida.Text = ""
        txtcantfac.Text = ""
        txtdescfac.Text = ""
    End Sub
    Private Sub cbxcodfrufac_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxcodfrufac.SelectionChangeCommitted
        'Se carga el nombre de la medida de la fruta seleccionada
        Dim consul As String = "spNOMMED"
        Dim cmd As New OleDbCommand(consul, conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim p1 As New OleDbParameter
        p1.Direction = ParameterDirection.Input
        p1.ParameterName = "CODFRU"
        p1.Value = cbxcodfrufac.SelectedValue
        p1.OleDbType = OleDbType.Char

        cmd.Parameters.Add(p1)

        Dim da As New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "STOCK")
        Dim filasTotal As Byte
        filasTotal = CByte(ds.Tables("STOCK").Rows.Count)
        txtMedida.Text = CStr(ds.Tables("STOCK").Rows(0).Item("NMEFRU"))

        CFrut = CInt(ds.Tables("STOCK").Rows(0).Item("CODFRU"))
        CodMed = CInt(ds.Tables("STOCK").Rows(0).Item("CMEFRU"))
        FPre = CDec(ds.Tables("STOCK").Rows(0).Item("PVEFRUPTO"))
        txtcantfac.Text = ""
        txtdescfac.Text = ""

    End Sub
    Private Sub cbxcodpuefac_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles cbxcodpuefac.SelectionChangeCommitted
        'se cargan las frutas del puesto seleccionado
        Dim consul As String = "SELECT PF.CODPTO, F.CODFRU, F.NOMFRU" & _
" FROM FRUTAS AS F INNER JOIN PTOFRU AS PF ON F.CODFRU = PF.CODFRU" & _
" WHERE PF.CODPTO = '" & cbxcodpuefac.SelectedValue.ToString & "'"

        Dim cmd As New OleDbCommand(consul, conexion)
        Dim da As New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "FRUTAS")
        cbxcodfrufac.DataSource = ds.Tables(0)
        cbxcodfrufac.DisplayMember = "NOMFRU"
        cbxcodfrufac.ValueMember = "CODFRU"
        cbxcodfrufac.Text = ""
        txtMedida.Text = ""

    End Sub
    Private Sub btningrefac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningrefac.Click

        Dim Total As Decimal
        Dim Sub_Iva As Decimal = 0
        Dim Descu As Decimal = 0
        Dim var As String
        'se validan los datos ingresados por el usuario
        If cbxcodalmfac.Text = "" Then
            MsgBox("Codigo del Almacen no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
            cbxcodalmfac.Focus()
            Exit Sub
        ElseIf cbxcodmerfac.Text = "" Then
            MsgBox("El CODIGO DE MERCADO no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
            cbxcodmerfac.Focus()
            Exit Sub
        ElseIf cbxcodpuefac.Text = "" Then
            MsgBox("El codigo del puesto no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
            cbxcodpuefac.Focus()
            Exit Sub
        ElseIf cbxcodfrufac.Text = "" Then
            MsgBox("La fruta no puede estar vacia", CType(vbYes, MsgBoxStyle), "ERROR")
            cbxcodfrufac.Focus()
            Exit Sub
        ElseIf txtMedida.Text = "" Then
            MsgBox("La media no puede estar vacia", CType(vbYes, MsgBoxStyle), "ERROR")
            txtMedida.Focus()
            Exit Sub
        ElseIf txtcantfac.Text = "" Then
            MsgBox("La cantidad no puede estar vacia", CType(vbYes, MsgBoxStyle), "ERROR")
            txtcantfac.Focus()
            Exit Sub
        ElseIf IsNumeric(txtcantfac.Text) = False Then
            MsgBox("CANTIDAD ingrese solamente numeros", CType(vbYes, MsgBoxStyle), "ERROR")
            txtcantfac.Focus()
            txtcantfac.Clear()
            Exit Sub
        ElseIf txtdescfac.Text = "" Then
            MsgBox("El DESCUENTO no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
            txtdescfac.Focus()
            Exit Sub
        ElseIf IsNumeric(txtdescfac.Text) = False Then
            MsgBox("DESCUENTO ingrese solamente numeros", CType(vbYes, MsgBoxStyle), "ERROR")
            txtdescfac.Focus()
            txtdescfac.Clear()
            Exit Sub
        ElseIf CDbl(txtdescfac.Text) < 0 Then
            MsgBox("DESCUENTO el descuento debe ser mayor a 0%", CType(vbYes, MsgBoxStyle), "ERROR")
            txtdescfac.Focus()
            txtdescfac.Clear()
            Exit Sub
        ElseIf CDbl(txtdescfac.Text) > 99 Then
            MsgBox("DESCUENTO: el descuento debe ser menor a 99%", CType(vbYes, MsgBoxStyle), "ERROR")
            txtdescfac.Focus()
            txtdescfac.Clear()
            Exit Sub
        End If

        Total = FPre * CInt(txtcantfac.Text)


        consulta = "SELECT * FROM PTOFRU WHERE CODPTO ='" & cbxcodpuefac.SelectedValue.ToString & "' " & _
            " and CODFRU ='" & cbxcodfrufac.SelectedValue.ToString & "' "

        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "stock")
        lista = CByte(ds.Tables("stock").Rows.Count)
        var = ""
        var = CStr(ds.Tables("stock").Rows(0).Item("STKPTO"))
        'se evalua si la cantidad requerida esta disponible 
        If txtcantfac.Text > var Then
            MsgBox("Stock insuficiente", CType(vbYes, MsgBoxStyle), "ERROR")
            txtcantfac.Clear()
            txtcantfac.Focus()
            Exit Sub
        End If


        'Se guardan los datos en la tabla temporal
        consulta = "Insert Into tmpLINFAC (NUMFAC, NUMLIN, CODFRU, NOMFRU, CMEFRU, NMEFRU, PVEFRUPTO, UMEFRU, PRTOTFRU) " & _
                   "Values('" & NumFact() & "'," & linea + 1 & ",'" & CFrut & "','" & cbxcodfrufac.Text & "'," & _
                   "'" & CodMed & "','" & txtMedida.Text & "'," & CDec(FPre) & "," & CInt(txtcantfac.Text) & "," & Total & ")"

        comandos = New OleDbCommand(consulta, conexion)
        comandos.ExecuteNonQuery()

        'Se calculan los atributos derivados
        SubTotal = CInt(SubTotal + Total)
        lblsubtotfac.Text = CStr(SubTotal)
        lblivafac.Text = CStr(SubTotal * 0.21)
        Sub_Iva = CDec(SubTotal * 1.21)
        Descu = (Sub_Iva * CInt(txtdescfac.Text)) / 100
        lbldescfac.Text = CStr(Descu)
        lbltotfac.Text = CStr(Sub_Iva - Descu)
        Total = 0
        linea = linea + 1

        'Carga la temporal con los datos hasta el momento y la carga en el dataGrid
        consulta = "Select NUMFAC AS FACTURA, NUMLIN AS LINEA, CODFRU AS [CODIGO FRUTA], NOMFRU AS [NOMBRE FRUTA], " & _
                    "CMEFRU AS [CODIGO MEDIDA], NMEFRU AS [NOMBRE MEDIDA], PVEFRUPTO AS PRECIO, UMEFRU AS CANTIDAD, " & _
                    " PRTOTFRU AS [PRECIO TOTAL] from tmpLINFAC"

        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds.Tables.Add("tmpLINFAC")
        da.Fill(ds.Tables("tmpLINFAC"))
        dtgfac.DataSource = ds.Tables("tmpLINFAC")
        '´No permite modificar las columnas del data gread
        dtgfac.Columns(2).ReadOnly = True
        btnfinfac.Enabled = True


    End Sub
    Function NumFact() As String
        ' Busca la ultima factura realizada y crea la siguiente
        Dim FacN As String = ""
        Dim NF As Integer

        consulta = "Select Top 1 NUMFAC from Factura order by NUMFAC desc"
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "Factura")
        lista = CByte(ds.Tables("Factura").Rows.Count)
        cds = CInt(lista)
        If lista <> 0 Then ' Aca se evalua si se encontro el ds- PRESTA ATENCION
            FacN = CStr(ds.Tables("Factura").Rows(0).Item(0))
            NF = CInt(Microsoft.VisualBasic.Right(FacN, 5)) + 1
        Else
            NF = 1
        End If

        NumFact = "001-000" & CStr(NF)


    End Function
    Private Sub btnfinfac_Click(sender As System.Object, e As System.EventArgs) Handles btnfinfac.Click
        Dim IVA, Descuento, Total As Decimal
        Dim codFruta As String
        Dim ADP As New OleDb.OleDbDataAdapter
        Dim RGT As New DataSet
        Dim CR, STK As Integer
        Dim LST As Byte

        'se calculan los campos 
        IVA = CDec(SubTotal * 0.21)
        Descuento = ((SubTotal + IVA) * CInt(txtdescfac.Text) / 100)
        Total = (SubTotal + IVA) - Descuento

        'pone lo de la tabla temporal en la tabla real
        consulta = "INSERT INTO LINFAC (NUMFAC, NUMLIN, CODFRU, NOMFRU, CMEFRU, NMEFRU, PVEFRUPTO, UMEFRU, TOTFAC) " & "SELECT * FROM tmpLINFAC"

        comandos = New OleDbCommand(consulta, conexion)
        comandos.ExecuteNonQuery()

        'graba los datos a la tabla factura
        consulta = "Insert Into FACTURA (NUMFAC, FECFAC, CODALM, CODMER, CODPTO, SUBTOT, IVAFAC, DESCUENTO, TOTFAC) " & "Values(@numfac,@fec,@cam,@mer,@pue,@sub,@iva,@desc,@tot)"

        comandos = New OleDbCommand(consulta, conexion)
        comandos.Parameters.AddWithValue("@numfac", lblnumfacfac.Text)
        comandos.Parameters.AddWithValue("@fec", Format(CDate(lblfechafac.Text), "MM/dd/yyyy"))
        comandos.Parameters.AddWithValue("@cam", cbxcodalmfac.SelectedValue.ToString)
        comandos.Parameters.AddWithValue("@mer", cbxcodmerfac.SelectedValue.ToString)
        comandos.Parameters.AddWithValue("@pue", cbxcodpuefac.SelectedValue.ToString)
        comandos.Parameters.AddWithValue("@sub", SubTotal)
        comandos.Parameters.AddWithValue("@iva", IVA)
        comandos.Parameters.AddWithValue("@desc", Descuento)
        comandos.Parameters.AddWithValue("@tot", Total)
        comandos.ExecuteNonQuery()

        'Carga los datos de LINFAC de la factura que se esta realizando
        consulta = "Select CODFRU, NOMFRU, CMEFRU, NMEFRU, PVEFRUPTO, UMEFRU FROM LINFAC WHERE NUMFAC ='" & lblnumfacfac.Text & "'"
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "Actualizar")

        'Carga los datos necesarios de la tabla cargada
        For Each row As DataRow In ds.Tables(0).Rows
            codFruta = CStr(row("CODFRU"))
            STK = CInt(row("UMEFRU"))

            'A partir de aca va a realizar una consulta por cada fila dentro de la tabla cargada

            'Carga los datos de la tabla PTOFRU dependiendo del puesto y la fruta 
            consulta = "Select * From PTOFRU where CODPTO ='" & cbxcodpuefac.SelectedValue.ToString & "' and CODFRU ='" & codFruta & "'"
            ADP = New OleDb.OleDbDataAdapter(consulta, conexion)
            RGT = New DataSet
            ADP.Fill(RGT, "Control")
            LST = CByte(RGT.Tables("Control").Rows.Count)
            CR = CInt(LST)

            'Se actualiza el stock 
            consulta = "UPDATE PTOFRU SET STKPTO = STKPTO - " & STK & " WHERE CODPTO ='" & cbxcodpuefac.SelectedValue.ToString & "' and CODFRU ='" & cbxcodfrufac.SelectedValue.ToString & "'"
            comandos = New OleDbCommand(consulta, conexion)
            comandos.ExecuteNonQuery()

        Next
        'se limpian todos los controles, el datagrid y la tabla temporal
        cbxcodalmfac.Text = ""
        cbxcodmerfac.Text = ""
        cbxcodpuefac.Text = ""
        cbxcodfrufac.Text = ""
        txtMedida.Text = ""
        txtcantfac.Text = ""
        txtdescfac.Text = ""
        lblsubtotfac.Text = ""
        lblivafac.Text = ""
        lbldescfac.Text = ""
        lbltotfac.Text = ""
        dtgfac.DataSource = Nothing
        consulta = "DELETE * FROM tmpLINFAC"
        comandos = New OleDbCommand(consulta, conexion)
        comandos.ExecuteNonQuery()
        lblnumfacfac.Text = NumFact()
        btnfinfac.Enabled = False
        linea = 0
    End Sub
    Private Sub btnIniprop_Click(sender As System.Object, e As System.EventArgs) Handles btnIniprop.Click
        If MessageBox.Show("Se perderan los datos de facturacion que no haya finalizado, seguro desea volver al Inicio?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = Windows.Forms.DialogResult.Yes Then
            Me.Hide()
            INICIO.Show()
            consulta = "DELETE * FROM tmpLINFAC"
            comandos = New OleDbCommand(consulta, conexion)
            comandos.ExecuteNonQuery()
        End If
    End Sub
End Class
