Imports System.Data.OleDb
Public Class PROPIETARIOS
    Dim conexion As New OleDb.OleDbConnection
    Dim comandos As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim consulta, IDPROP, modypropiet, Buscar As String
    Dim lista As Byte
    Dim cds, id As Integer
    Dim cellselect As Boolean
    Private Sub PROPIETARIOS_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        INICIO.Show()
    End Sub
    Private Sub PROPIETARIOS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            conexion = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\MERCADOS 2017\MERCADOS 2017\Mercados 2017.accdb;Persist Security Info = False;")

            conexion.Open()
            CargarPropietarios()
            Cargar_PROVINCIAS()
            cbxProv.Text = ""
            btnaltaprop.Enabled = False
            cellselect = True
            txtCodprop.Visible = False
            MessageBox.Show("La Conexion a la base de datos ha sido exitosa", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox("Se ha producido un error al querer conectarse con la base de datos", vbExclamation, "Error")
            Exit Sub

        End Try
    End Sub
    Sub CargarPropietarios()

        consulta = "SELECT* FROM propietarios CODPRO order by CODPRO"
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "propietarios")
        lista = CByte(ds.Tables("propietarios").Rows.Count)
        cds = CInt(lista)
        If lista <> 0 Then
            For cont = 0 To cds - 1
                cbxcodprop.Items.Add(ds.Tables("propietarios").Rows(cont).Item("CODPRO"))
            Next cont
            cbxcodprop.Items.Insert(cds, "Nuevo")
        Else
            MessageBox.Show("No ha sido exitosa la carga del combobox")
            Exit Sub
        End If
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
    Sub Cargar_ID()
        Dim Nid, Num As String

        consulta = "Select Top 1 CODPRO FROM propietarios ORDER BY CODPRO desc"
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "propietarios")
        Nid = CStr(ds.Tables("propietarios").Rows(0).Item(0))

        Num = Microsoft.VisualBasic.Right(Nid, 2)
        id = CInt(Num) + 1

        If id < 10 Then
            IDPROP = "0" + CStr(id)
        Else
            IDPROP = CStr(id)
        End If
        IDPROP = "00" + IDPROP
       
    End Sub
    Sub Cargar_PROVINCIAS()
        consulta = "SELECT* FROM provincias"
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "provincias")
        cbxProv.DataSource = ds.Tables(0)
        cbxProv.DisplayMember = "NOMPROV"
        cbxProv.ValueMember = "CODPROV"

    End Sub
    Private Sub cbxProv_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles cbxProv.SelectionChangeCommitted
        Dim consul As String = "SELECT nomciu FROM ciudades WHERE codprov = " + cbxProv.SelectedValue.ToString
        Dim cmd As New OleDbCommand(consul, conexion)
        Dim da As New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "ciudades")

        cbxCiudad.DataSource = ds.Tables(0)
        cbxCiudad.DisplayMember = "NOMCIU"
        cbxCiudad.ValueMember = "NOMCIU"
        cbxCiudad.Text = ""
    End Sub
    Private Sub cbxcodpro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxcodprop.SelectedIndexChanged
        modypropiet = CStr(cbxcodprop.SelectedItem)

        If Not CStr(cbxcodprop.SelectedItem) = "Nuevo" Then
            consulta = "SELECT * FROM propietarios CODPRO where CODPRO ='" & cbxcodprop.Text & "'"
            da = New OleDb.OleDbDataAdapter(consulta, conexion)
            ds = New DataSet
            da.Fill(ds, "propietarios")
            lista = CByte(ds.Tables("propietarios").Rows.Count)
            txtnoprop.Text = CStr(ds.Tables("propietarios").Rows(0).Item("NPRPTO"))
            txtdireccprop.Text = CStr(ds.Tables("propietarios").Rows(0).Item("DIRPRO"))
            txtcodpprop.Text = CStr(ds.Tables("propietarios").Rows(0).Item("CODPOST"))
            txttelprop.Text = CStr(ds.Tables("propietarios").Rows(0).Item("TELPRO"))
            cbxCiudad.Text = CStr(ds.Tables("propietarios").Rows(0).Item("NOMCIU"))
            cbxProv.Text = CStr(ds.Tables("propietarios").Rows(0).Item("NOMPROV"))
            btnmodprop.Enabled = True
            btnbajaprop.Enabled = True
            btnaltaprop.Enabled = False
            DataGridView1.ClearSelection()
        Else
            cellselect = False
            Cargar_ID()
            Cargar_PROVINCIAS()
            cbxProv.Visible = True
            cbxCiudad.Visible = True
            txtCodprop.Text = IDPROP.ToString()
            txtnoprop.Visible = True
            txtnoprop.Text = ""
            txtCodprop.Visible = True
            txtCodprop.Enabled = True
            cbxcodprop.Visible = False
            cbxCiudad.Text = ""
            cbxProv.Text = ""
            txtnoprop.Text = ""
            txtcodpprop.Clear()
            txttelprop.Clear()
            txtdireccprop.Clear()
            btnmodprop.Enabled = False
            btnbajaprop.Enabled = False
            btnaltaprop.Enabled = True
            cellselect = False
            btnpuestosprop.Enabled = False

        End If
    End Sub
    Private Sub btnaltapro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaltaprop.Click
        If MessageBox.Show("Desea dar ALTA a este Propietario?", "ALTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Try
                If txtCodprop.Text = "" Then
                    MsgBox("El Codigo de Propietario no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                    txtCodprop.Focus()
                    Exit Sub
                ElseIf txtnoprop.Text = "" Then
                    MsgBox("El Nombre del Propietario no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                    txtnoprop.Focus()
                    Exit Sub
                ElseIf txtdireccprop.Text = "" Then
                    MsgBox("La direccion del Propietario no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                    txtdireccprop.Focus()
                    Exit Sub
                ElseIf txttelprop.Text = "" Then
                    MsgBox("El Telefono del Propietario no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                    txttelprop.Focus()
                    Exit Sub
                ElseIf IsNumeric(txttelprop.Text) = False Then
                    MsgBox("TELEFONO ingrese solamente numeros", CType(vbYes, MsgBoxStyle), "ERROR")
                    txttelprop.Focus()
                    txttelprop.Clear()
                    Exit Sub
                ElseIf txtcodpprop.Text = "" Then
                    MsgBox("El codigo postal del Propietario no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                    txtcodpprop.Focus()
                    Exit Sub
                ElseIf IsNumeric(txtcodpprop.Text) = False Then
                    MsgBox("CODIGO POSTAL ingrese solamente numeros", CType(vbYes, MsgBoxStyle), "ERROR")
                    txtcodpprop.Focus()
                    txtcodpprop.Clear()
                    Exit Sub
                ElseIf cbxProv.Text = "" Then
                    MsgBox("La PROVINCIA no puede estar vacia", CType(vbYes, MsgBoxStyle), "ERROR")
                    cbxProv.Focus()
                    Exit Sub
                ElseIf cbxCiudad.Text = "" Then
                    MsgBox("La CIUDAD no puede estar vacia", CType(vbYes, MsgBoxStyle), "ERROR")
                    cbxCiudad.Focus()
                    Exit Sub
                End If

                Dim ds As New DataSet
                ds.Tables.Add("propietarios")
                comandos = New OleDbCommand("insert INTO propietarios (CODPRO, NPRPTO, DIRPRO, CODPOST, TELPRO, NOMCIU, NOMPROV) VALUES (@cam,@nom,@dir,@cpo,@tel,@ciu,@pro)", conexion)

                comandos.Parameters.AddWithValue("@cam", txtCodprop.Text)
                comandos.Parameters.AddWithValue("@nom", txtnoprop.Text)
                comandos.Parameters.AddWithValue("@dir", txtdireccprop.Text)
                comandos.Parameters.AddWithValue("@cpo", txtcodpprop.Text)
                comandos.Parameters.AddWithValue("@tel", txttelprop.Text)
                comandos.Parameters.AddWithValue("@ciu", cbxCiudad.Text)
                comandos.Parameters.AddWithValue("@pro", cbxProv.Text)

                comandos.ExecuteNonQuery()

                MessageBox.Show("Alta de Nuevo Propietario Correcto", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtdireccprop.Clear()
                txtcodpprop.Clear()
                txttelprop.Clear()
                cbxcodprop.Items.Clear()
                cbxCiudad.Text = ""
                cbxcodprop.Text = ""
                cbxProv.Text = ""
                cbxcodprop.Visible = True
                txtCodprop.Visible = False
                CargarPropietarios()
                txtnoprop.Text = ""
                btnaltaprop.Enabled = False
                btnbajaprop.Enabled = True
                btnmodprop.Enabled = True
                cellselect = True
                btnpuestosprop.Enabled = True

                If MessageBox.Show("El propietario tiene que tener un puesto. Desea dar el alta del puesto?", "Alta", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    PUESTOS.Show()
                End If

            Catch ex As Exception
                MsgBox("Error: No se pudo realizar el alta", CType(vbYes, MsgBoxStyle), "ERROR")
            End Try
        Else
            txtdireccprop.Clear()
            txtcodpprop.Clear()
            txttelprop.Clear()
            cbxcodprop.Items.Clear()
            cbxCiudad.Text = ""
            cbxcodprop.Text = ""
            cbxProv.Text = ""
            cbxcodprop.Visible = True
            txtCodprop.Visible = False
            CargarPropietarios()
            txtnoprop.Text = ""
            btnaltaprop.Enabled = False
            btnbajaprop.Enabled = True
            btnmodprop.Enabled = True
            cellselect = True
            btnpuestosprop.Enabled = True
        End If
    End Sub
    Private Sub btnmodpro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodprop.Click

        Dim modificar As String
        Dim propietarionew As String = cbxcodprop.Text
        If MessageBox.Show("Esta seguro que desea modificar el Registro?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            If cbxcodprop.Text = "" Then
                MsgBox("Error: El Codigo del Propietario no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                cbxcodprop.Focus()
                Exit Sub
            ElseIf txtnoprop.Text = "" Then
                MsgBox("Error: El Nombre del Propietario no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                txtnoprop.Focus()
                Exit Sub
            ElseIf txtdireccprop.Text = "" Then
                MsgBox("Error: La direccion del Propietario no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                txtdireccprop.Focus()
                Exit Sub
            ElseIf txtcodpprop.Text = "" Then
                MsgBox("Error: El codigo postal del Propietario no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                txtcodpprop.Focus()
                Exit Sub
            ElseIf IsNumeric(txtcodpprop.Text) = False Then
                MsgBox("CODIGO POSTAL: Ingrese solamente numeros", CType(vbYes, MsgBoxStyle), "ERROR")
                txtcodpprop.Focus()
                Exit Sub
            ElseIf txttelprop.Text = "" Then
                MsgBox("Error: El Telefono del Propietario no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                txttelprop.Focus()
                Exit Sub
            ElseIf IsNumeric(txttelprop.Text) = False Then
                MsgBox("TELEFONO: Ingrese solamente numeros", CType(vbYes, MsgBoxStyle), "ERROR")
                txttelprop.Focus()
                Exit Sub
            ElseIf cbxCiudad.Text = "" Then
                MsgBox("Error: La Ciudad no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                cbxCiudad.Focus()
                Exit Sub
            ElseIf cbxprov.Text = "" Then
                MsgBox("Error: La Provincia no puede estar vacia", CType(vbYes, MsgBoxStyle), "ERROR")
                cbxProv.Focus()

                Exit Sub
            End If


            modificar = "UPDATE propietarios SET CODPRO ='" & propietarionew & "' , NPRPTO ='" & txtnoprop.Text & "' , DIRPRO ='" & txtdireccprop.Text & "', CODPOST ='" & txtcodpprop.Text & "', TELPRO ='" & txttelprop.Text & "',  NOMCIU ='" & cbxCiudad.Text & "', NOMPROV ='" & cbxProv.Text & "' WHERE CODPRO ='" & modypropiet & "'"

            comandos = New OleDb.OleDbCommand(modificar, conexion)

            comandos.ExecuteNonQuery()

            MessageBox.Show("Registro Modificado", "Accion Realizada")
            txtcodpprop.Clear()
            txtdireccprop.Clear()
            txttelprop.Clear()
            cbxCiudad.Text = ""
            txtnoprop.Text = ""
            cbxcodprop.Text = ""
            cbxcodprop.Items.Clear()
            CargarPropietarios()
        Else
            txtcodpprop.Clear()
            txtdireccprop.Clear()
            txttelprop.Clear()
            cbxCiudad.Text = ""
            cbxProv.Text = ""
            txtnoprop.Text = ""
            cbxcodprop.Text = ""
            cbxcodprop.Items.Clear()
            CargarPropietarios()

        End If
    End Sub
    Private Sub btnbajapro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbajaprop.Click
        modypropiet = CStr(cbxcodprop.SelectedItem)
        If MessageBox.Show("Desea eliminar este registro?", "BAJA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
          
            Try
                comandos = New OleDb.OleDbCommand("DELETE FROM propietarios WHERE CODPRO='" & modypropiet & "'", conexion)
                comandos.ExecuteNonQuery()

                comandos = New OleDb.OleDbCommand("DELETE FROM puestos WHERE CODPRO='" & modypropiet & "'", conexion)
                comandos.ExecuteNonQuery()

                MessageBox.Show("Propietario eliminado exitosamente, se eliminaron los puestos de este Propietario", "BAJA", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MsgBox("Error: No se pudo realizar la baja del Propietario", CType(vbYes, MsgBoxStyle), "ERROR")
            End Try
            txtcodpprop.Clear()
            txtdireccprop.Clear()
            txttelprop.Clear()
            cbxCiudad.Text = ""
            txtnoprop.Text = ""
            cbxcodprop.Text = ""
            cbxcodprop.Items.Clear()
            CargarPropietarios()
        Else
            txtcodpprop.Clear()
            txtdireccprop.Clear()
            txttelprop.Clear()
            cbxCiudad.Text = ""
            txtnoprop.Text = ""
            cbxcodprop.Text = ""
            cbxcodprop.Items.Clear()
            CargarPropietarios()

        End If
    End Sub
    Private Sub btnpuestospro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpuestosprop.Click
        If MessageBox.Show("Desea gestionar Puestos?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            PUESTOS.Show()
        End If
    End Sub
    Private Sub btninipro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniprop.Click
        If MessageBox.Show("Seguro desea volver al Inicio?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            INICIO.Show()
        End If
    End Sub
    Private Sub DataGridView1_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        cbxCiudad.DataSource = Nothing
        Dim i As Integer
        If cellselect = True Then
            i = DataGridView1.CurrentRow.Index
            cbxcodprop.Text = (DataGridView1.Item(0, i).Value()).ToString
            txtnoprop.Text = (DataGridView1.Item(1, i).Value()).ToString
            txtdireccprop.Text = (DataGridView1.Item(2, i).Value()).ToString
            txttelprop.Text = (DataGridView1.Item(6, i).Value()).ToString
            txtcodpprop.Text = (DataGridView1.Item(5, i).Value()).ToString
            cbxCiudad.Text = (DataGridView1.Item(4, i).Value()).ToString
            cbxProv.Text = (DataGridView1.Item(3, i).Value()).ToString

            If cbxcodprop.Text = "" Then
                txtcodpprop.Clear()
                txtdireccprop.Clear()
                txttelprop.Clear()
                cbxCiudad.Text = ""
                txtnoprop.Text = ""
                cbxcodprop.Text = ""
                cbxProv.Text = ""
            End If
        End If
    End Sub
End Class

