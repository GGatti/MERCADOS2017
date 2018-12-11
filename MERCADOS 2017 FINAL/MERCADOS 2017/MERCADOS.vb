Imports System.Data.OleDb
Public Class MERCADOS
    Dim conexion As New OleDb.OleDbConnection
    Dim comandos As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet '
    Dim consulta, IDMERCADO As String
    Dim filasTotal As Byte
    Dim id As Integer
    Dim cellselect As Boolean
    Private Sub MERCADOS_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        INICIO.Show()
    End Sub
    Private Sub MERCADOS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'se conecta con la bd
        Try
            conexion = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\MERCADOS 2017\MERCADOS 2017\Mercados 2017.accdb;Persist Security Info = False;")

            conexion.Open()
            Cargar_CBXmercados()
            Cargar_PROVINCIAS()
            txtCodMer.Visible = False
            cbxcodmer.Visible = True
            btnaltamer.Enabled = False
            cbxprovmer.Text = ""
            cellselect = True
            MessageBox.Show("La Conexion a la base de datos ha sido exitosa", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox("Se ha producido un error al querer conectarse con la base de datos", vbExclamation, "Error")
            Exit Sub

        End Try
    End Sub
    Sub Cargar_CBXmercados()
        'se carga el combo mercados y se agrega el item nuevo
        consulta = "SELECT* FROM mercados CODMER order by CODMER"
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "mercados")
        filasTotal = CByte(ds.Tables("mercados").Rows.Count)
        If filasTotal <> 0 Then
            For cont = 0 To filasTotal - 1
                cbxcodmer.Items.Add(ds.Tables("mercados").Rows(cont).Item("CODMER"))
            Next cont
            cbxcodmer.Items.Insert(filasTotal, "Nuevo")
        Else
            MessageBox.Show("No ha sido exitosa la carga del combobox")
            Exit Sub

        End If
        DataGridView1.DataSource = ds.Tables(0)

    End Sub
    Sub Cargar_ID()
        'se carga el codigo para el nuevo mercado
        Dim Nid, num As String

        consulta = "Select Top 1 CODMER FROM mercados ORDER BY CODMER desc"
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "mercados")
        Nid = CStr(ds.Tables("mercados").Rows(0).Item(0))
        num = Microsoft.VisualBasic.Right(Nid, 2)
        id = CInt(num) + 1

        If id < 10 Then
            IDMERCADO = "0" + CStr(id)
        Else
            IDMERCADO = CStr(id)
        End If

        IDMERCADO = "ME" + IDMERCADO

    End Sub
    Sub Cargar_PROVINCIAS()
        'se cargan las provincias 
        consulta = "SELECT* FROM provincias"
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "provincias")
        cbxprovmer.DataSource = ds.Tables(0)
        cbxprovmer.DisplayMember = "NOMPROV"
        cbxprovmer.ValueMember = "CODPROV"

    End Sub
    Private Sub cbxprovmer_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles cbxprovmer.SelectionChangeCommitted
        'se cargan las ciudades de la provincia seleccionada
        Dim consul As String = "SELECT nomciu FROM ciudades WHERE codprov = " + cbxprovmer.SelectedValue.ToString
        Dim cmd As New OleDbCommand(consul, conexion)
        Dim da As New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "ciudades")
        cbxciumer.DataSource = ds.Tables(0)
        cbxciumer.DisplayMember = "NOMCIU"
        cbxciumer.ValueMember = "NOMCIU"
        cbxciumer.Text = ""
    End Sub
    Private Sub cbxcodmer_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxcodmer.SelectedIndexChanged
        'se cargan los textos con la info del mercado seleccionado 
        If Not CStr(cbxcodmer.SelectedItem) = "Nuevo" Then
            cbxciumer.DataSource = Nothing
            consulta = "SELECT* FROM mercados CODMER where CODMER = '" & cbxcodmer.Text & "'"
            da = New OleDb.OleDbDataAdapter(consulta, conexion)
            ds = New DataSet
            da.Fill(ds, "mercados")
            filasTotal = CByte(ds.Tables("mercados").Rows.Count)
            txtnomer.Text = CStr(ds.Tables("mercados").Rows(0).Item("NOMMER"))
            txtdireccmer.Text = CStr(ds.Tables("mercados").Rows(0).Item("DIRMER"))
            txtcodpmer.Text = CStr(ds.Tables("mercados").Rows(0).Item("CODPOST"))
            txttelmer.Text = CStr(ds.Tables("mercados").Rows(0).Item("TELMER"))
            cbxprovmer.Text = CStr(ds.Tables("mercados").Rows(0).Item("NOMPRO"))
            cbxciumer.Text = CStr(ds.Tables("mercados").Rows(0).Item("NOMCIU"))
            btnmodmer.Enabled = True
            btnbajamer.Enabled = True
            btnaltamer.Enabled = False
            DataGridView1.ClearSelection()

        Else
            'se preparan los controles para realizar el alta
            cbxciumer.DataSource = Nothing
            Cargar_ID()
            btnAsociarMerPue.Enabled = False
            cellselect = False
            txtCodMer.Text = IDMERCADO.ToString()
            cbxcodmer.Visible = False
            txtCodMer.Visible = True
            txtnomer.Text = "MERCADO " + CStr(id)
            cbxciumer.Text = ""
            cbxprovmer.Text = ""
            txtdireccmer.Clear()
            txtcodpmer.Clear()
            txttelmer.Clear()
            btnmodmer.Enabled = False
            btnbajamer.Enabled = False
            btnaltamer.Enabled = True
            txtdireccmer.Focus()
            btnAsociarMerPue.Enabled = False

        End If


    End Sub
    Private Sub btnaltamer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaltamer.Click
        'se realiza el alta
        If MessageBox.Show("Desea dar ALTA a este Mercado?", "ALTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Try

                If txtCodMer.Text = "" Then
                    MsgBox("El Codigo de Mercado no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                    txtCodMer.Focus()
                    Exit Sub
                ElseIf txtnomer.Text = "" Then
                    MsgBox("El Nombre del Mercado no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                    txtnomer.Focus()
                    Exit Sub
                ElseIf txtdireccmer.Text = "" Then
                    MsgBox("La direccion del Mercado no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                    txtdireccmer.Focus()
                    Exit Sub
                ElseIf txttelmer.Text = "" Then
                    MsgBox("El Telefono del Mercado no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                    txttelmer.Focus()
                    Exit Sub
                ElseIf IsNumeric(txttelmer.Text) = False Then
                    MsgBox("TELEFONO: Ingrese solamente numeros", CType(vbYes, MsgBoxStyle), "ERROR")
                    txttelmer.Focus()
                    txttelmer.Clear()
                    Exit Sub
                ElseIf cbxprovmer.Text = "" Then
                    MsgBox("La Provincia no puede estar vacia", CType(vbYes, MsgBoxStyle), "ERROR")
                    cbxprovmer.Focus()
                    Exit Sub
                ElseIf txtcodpmer.Text = "" Then
                    MsgBox("El codigo postal del Mercado no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                    txtcodpmer.Focus()
                    Exit Sub
                ElseIf IsNumeric(txtcodpmer.Text) = False Then
                    MsgBox("CODIGO POSTAL: Ingrese solamente numeros", CType(vbYes, MsgBoxStyle), "ERROR")
                    txtcodpmer.Focus()
                    txtcodpmer.Clear()
                    Exit Sub
                ElseIf cbxciumer.Text = "" Then
                    MsgBox("La Ciudad no puede estar vacia", CType(vbYes, MsgBoxStyle), "ERROR")
                    cbxciumer.Focus()
                    Exit Sub
                End If

                Dim ds As New DataSet
                ds.Tables.Add("MERCADOS")

                comandos = New OleDbCommand("insert INTO mercados (CODMER, NOMMER, DIRMER, CODPOST, TELMER, NOMPRO, NOMCIU) VALUES (@cam,@nom,@dir,@cpo,@tel,@pro,@ciu)", conexion)
                comandos.Parameters.AddWithValue("@cam", txtCodMer.Text)
                comandos.Parameters.AddWithValue("@nom", txtnomer.Text)
                comandos.Parameters.AddWithValue("@dir", txtdireccmer.Text)
                comandos.Parameters.AddWithValue("@cpo", txtcodpmer.Text)
                comandos.Parameters.AddWithValue("@tel", txttelmer.Text)
                comandos.Parameters.AddWithValue("@pro", cbxprovmer.Text)
                comandos.Parameters.AddWithValue("@ciu", cbxciumer.Text)

                comandos.ExecuteNonQuery()

                MessageBox.Show("Alta de Nuevo Mercado Correcta", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cellselect = True

                Cargar_CBXmercados()
                txtnomer.Clear()
                txtdireccmer.Clear()
                txtcodpmer.Clear()
                txttelmer.Clear()
                cbxcodmer.Text = ""
                cbxcodmer.Visible = True
                txtCodMer.Visible = False
                cbxcodmer.Items.Clear()
                btnaltamer.Enabled = False
                btnbajamer.Enabled = True
                btnmodmer.Enabled = True
                btnAsociarMerPue.Enabled = True
                cbxciumer.Text = ""
                cbxprovmer.Text = ""
                btnAsociarMerPue.Enabled = True
            Catch ex As Exception
                MsgBox("Error: No se pudo realizar el alta", CType(vbYes, MsgBoxStyle), "ERROR")

            End Try
           
        Else
            Cargar_CBXmercados()
            txtnomer.Clear()
            txtdireccmer.Clear()
            txtcodpmer.Clear()
            txttelmer.Clear()
            cbxcodmer.Text = ""
            cbxcodmer.Visible = True
            txtCodMer.Visible = False
            cbxcodmer.Items.Clear()
            btnaltamer.Enabled = False
            btnbajamer.Enabled = True
            btnmodmer.Enabled = True
            btnAsociarMerPue.Enabled = True
            cbxciumer.Text = ""
            cbxprovmer.Text = ""
            btnAsociarMerPue.Enabled = True
        End If
    End Sub
    Private Sub btnbajamer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbajamer.Click

        If cbxcodmer.Text = "" Then
            MessageBox.Show("Seleccione el mercado que quiere eliminar")
            Exit Sub
        End If
        If MessageBox.Show("Desea eliminar el Mercado: " + txtnomer.Text + "?", "BAJA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            
            Try
                consulta = "DELETE FROM MERCADOS WHERE CODMER='" & CStr(cbxcodmer.SelectedItem) & "'"
                comandos = New OleDb.OleDbCommand(consulta, conexion)
                comandos.ExecuteNonQuery()

                consulta = "DELETE FROM almmer WHERE CODMER='" & CStr(cbxcodmer.SelectedItem) & "'"
                comandos = New OleDb.OleDbCommand(consulta, conexion)
                comandos.ExecuteNonQuery()

                consulta = "DELETE FROM merpue WHERE CODMER='" & CStr(cbxcodmer.SelectedItem) & "'"
                comandos = New OleDb.OleDbCommand(consulta, conexion)
                comandos.ExecuteNonQuery()
                MessageBox.Show("Mercado eliminado exitosamente, se elimino la relacion con sus almacenes y con sus puestos", "BAJA", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MsgBox("No se pudo realizar la baja del Mercado ", CType(vbYes, MsgBoxStyle), "ERROR")
            End Try

            txtnomer.Clear()
            txtdireccmer.Clear()
            txtcodpmer.Clear()
            txttelmer.Clear()
            cbxciumer.Text = ""
            cbxprovmer.Text = ""
            cbxcodmer.Text = ""
            cbxcodmer.Visible = True
            txtCodMer.Visible = False
            cbxcodmer.Items.Clear()
            Cargar_CBXmercados()
        Else
            txtnomer.Clear()
            txtdireccmer.Clear()
            txtcodpmer.Clear()
            txttelmer.Clear()
            cbxciumer.Text = ""
            cbxprovmer.Text = ""
            cbxcodmer.Text = ""
            cbxcodmer.Visible = True
            txtCodMer.Visible = False
            cbxcodmer.Items.Clear()
            Cargar_CBXmercados()
        End If

    End Sub
    Private Sub btnmodmer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodmer.Click


        If MessageBox.Show("Esta seguro que desea modificar el registro?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            If cbxcodmer.Text = "" Then
                MsgBox("Error: El Codigo de Mercado no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                txtCodMer.Focus()
                Exit Sub
            ElseIf txtnomer.Text = "" Then
                MsgBox("Error: El Nombre del Mercado no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                txtnomer.Focus()
                Exit Sub
            ElseIf txtdireccmer.Text = "" Then
                MsgBox("Error: La direccion del Mercado no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                txtdireccmer.Focus()
                Exit Sub
            ElseIf txtcodpmer.Text = "" Then
                MsgBox("Error: El codigo postal del Mercado no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                txtdireccmer.Focus()
                Exit Sub
            ElseIf IsNumeric(txtcodpmer.Text) = False Then
                MsgBox("Codigo postal debe ingresar solamente numeros", CType(vbYes, MsgBoxStyle), "ERROR")
                txtcodpmer.Focus()
                Exit Sub
            ElseIf txttelmer.Text = "" Then
                MsgBox("El Telefono del Mercado no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                txttelmer.Focus()
                Exit Sub
            ElseIf IsNumeric(txttelmer.Text) = False Then
                MsgBox("Telefono ingrese solamente numeros", CType(vbYes, MsgBoxStyle), "ERROR")
                txttelmer.Focus()
                Exit Sub
            ElseIf cbxprovmer.Text = "" Then
                MsgBox("La Provincia no puede estar vacia", CType(vbYes, MsgBoxStyle), "ERROR")
                cbxprovmer.Focus()
                Exit Sub
            ElseIf cbxciumer.Text = "" Then
                MsgBox("La Ciudad no puede estar vacia", CType(vbYes, MsgBoxStyle), "ERROR")
                cbxciumer.Focus()
                Exit Sub
            End If

            Dim modificar As String
            modificar = "UPDATE mercados SET CODMER ='" & cbxcodmer.Text & "' , NOMMER ='" & txtnomer.Text & "' , DIRMER ='" & txtdireccmer.Text & "', CODPOST ='" & txtcodpmer.Text & "', TELMER ='" & txttelmer.Text & "', NOMPRO ='" & cbxprovmer.Text & "', NOMCIU ='" & cbxciumer.Text & "' WHERE CODMER ='" & CStr(cbxcodmer.SelectedItem) & "'"
            comandos = New OleDb.OleDbCommand(modificar, conexion)
            comandos.ExecuteNonQuery()

            MessageBox.Show("Registro Modificado", "Accion Realizada")
            txtnomer.Clear()
            txtdireccmer.Clear()
            txtcodpmer.Clear()
            txttelmer.Clear()
            cbxciumer.Text = ""
            cbxprovmer.Text = ""
            cbxcodmer.Text = ""
            cbxcodmer.Visible = True
            txtCodMer.Visible = False
            cbxcodmer.Items.Clear()
            Cargar_CBXmercados()

        Else
            txtnomer.Clear()
            txtdireccmer.Clear()
            txtcodpmer.Clear()
            txttelmer.Clear()
            cbxciumer.Text = ""
            cbxprovmer.Text = ""
            cbxcodmer.Text = ""
            cbxcodmer.Visible = True
            txtCodMer.Visible = False
            cbxcodmer.Items.Clear()
            Cargar_CBXmercados()
        End If

    End Sub
    Private Sub btnpropmer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsociarMerPue.Click
        cbxcodmer.Text = ""
        cbxprovmer.Text = ""
        cbxciumer.Text = ""
        txtCodMer.Text = ""
        txtcodpmer.Text = ""
        txtdireccmer.Text = ""
        txtnomer.Text = ""
        txttelmer.Text = ""
        If MessageBox.Show("Desea asociar un MERCADO con un PUESTO?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            MERCADOS_PUESTOS.Show()
        End If
    End Sub
    Private Sub btnIniMer_Click(sender As System.Object, e As System.EventArgs) Handles btnIniMer.Click
        cbxcodmer.Text = ""
        cbxprovmer.Text = ""
        cbxciumer.Text = ""
        txtCodMer.Text = ""
        txtcodpmer.Text = ""
        txtdireccmer.Text = ""
        txtnomer.Text = ""
        txttelmer.Text = ""
        Me.Close()
        INICIO.Show()
    End Sub
    Private Sub DataGridView1_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        cbxciumer.DataSource = Nothing
        Dim i As Integer
        If cellselect = True Then
            i = DataGridView1.CurrentRow.Index
            cbxcodmer.Text = (DataGridView1.Item(0, i).Value()).ToString
            txtnomer.Text = (DataGridView1.Item(1, i).Value()).ToString
            txtdireccmer.Text = (DataGridView1.Item(2, i).Value()).ToString
            txtcodpmer.Text = (DataGridView1.Item(3, i).Value()).ToString
            cbxprovmer.Text = (DataGridView1.Item(5, i).Value()).ToString
            cbxciumer.Text = (DataGridView1.Item(6, i).Value()).ToString
            txttelmer.Text = (DataGridView1.Item(4, i).Value()).ToString
            If cbxcodmer.Text = "" Then
                cbxcodmer.Text = ""
                cbxprovmer.Text = ""
                cbxciumer.Text = ""
                txtCodMer.Text = ""
                txtcodpmer.Text = ""
                txtdireccmer.Text = ""
                txtnomer.Text = ""
                txttelmer.Text = ""
            End If
        End If
    End Sub

    Private Sub btnPuestos_Click(sender As System.Object, e As System.EventArgs) Handles btnPuestos.Click
        If cbxcodmer.Text = "" Then
            MsgBox("Seleccione un mercado.")
            Exit Sub
        End If
        PUESTOSdelMERCADO.Show()
    End Sub
End Class