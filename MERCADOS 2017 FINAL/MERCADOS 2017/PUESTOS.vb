Imports System.Data.OleDb
Public Class PUESTOS
    Dim conexion As New OleDb.OleDbConnection
    Dim comandos As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim consulta, IDPUE As String
    Dim lista As Byte
    Dim cds, id As Integer
    Dim cellselect As Boolean
    Private Sub PUESTOS_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        INICIO.Show()
    End Sub
    Private Sub PUESTOS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            conexion = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\MERCADOS 2017\MERCADOS 2017\Mercados 2017.accdb;Persist Security Info = False;")

            conexion.Open()
            Cargar_CBXcodpues()
            Cargar_CBXcodprop()
            txtCodPue.Visible = False
            cbxcodppu.Visible = True
            btnaltapu.Enabled = False
            cellselect = True

            MessageBox.Show("La Conexion a la base de datos ha sido exitosa", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox("Se ha producido un error al querer conectarse con la base de datos", vbExclamation, "Error")
            Exit Sub

        End Try
    End Sub
    Sub Cargar_CBXcodpues()

        consulta = "SELECT* FROM puestos CODPTO order by CODPTO"
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "puestos")
        lista = CByte(ds.Tables("puestos").Rows.Count)
        cds = CInt(lista)
        If lista <> 0 Then
            For cont = 0 To cds - 1
                cbxcodppu.Items.Add(ds.Tables("puestos").Rows(cont).Item("CODPTO"))
            Next cont
            cbxcodppu.Items.Insert(cds, "Nuevo")
        Else
            MessageBox.Show("No ha sido exitosa la carga del combobox")
            Exit Sub

        End If
        DataGridView1.DataSource = ds.Tables(0)
        cbxcodppu.Text = ""
    End Sub
    Sub Cargar_CBXcodprop()
        consulta = "SELECT* FROM propietarios CODPRO order by CODPRO"
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "propietarios")
        cbxcodprop.DataSource = ds.Tables(0)
        cbxcodprop.DisplayMember = "CODPRO"
        cbxcodprop.ValueMember = "CODPRO"
        cbxcodprop.Text = ""
    End Sub
    Sub Cargar_ID()
        Dim Nid, Num As String

        consulta = "Select Top 1 CODPTO FROM puestos ORDER BY CODPTO desc"
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "puestos")
        Nid = CStr(ds.Tables("puestos").Rows(0).Item(0))

        Num = Microsoft.VisualBasic.Right(Nid, 2)
        id = CInt(Num) + 1

        If id < 10 Then
            IDPUE = "0" + CStr(id)
        Else
            IDPUE = CStr(id)
        End If
        IDPUE = "00" + IDPUE

    End Sub
    Private Sub btnIniMer_Click(sender As System.Object, e As System.EventArgs) Handles btnIniMer.Click
        cbxcodppu.Text = ""
        txtcifpu.Text = ""
        txtCodPue.Text = ""
        txtnomppu.Text = ""
        If MessageBox.Show("Seguro desea volver al Inicio?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            INICIO.Show()
        End If
    End Sub
    Private Sub cbxcodppu_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbxcodppu.SelectedIndexChanged


        If Not CStr(cbxcodppu.SelectedItem) = "Nuevo" Then
            consulta = "SELECT * FROM puestos CODPTO where CODPTO ='" & cbxcodppu.Text & "'"
            da = New OleDb.OleDbDataAdapter(consulta, conexion)
            ds = New DataSet
            da.Fill(ds, "puestos")

            txtcifpu.Text = CStr(ds.Tables("puestos").Rows(0).Item("CIFPTO"))
            txtnomppu.Text = CStr(ds.Tables("puestos").Rows(0).Item("NOMTO"))
            cbxcodprop.Text = CStr(ds.Tables("puestos").Rows(0).Item("CODPRO"))
            txtNomPropie.Text = CStr(ds.Tables("puestos").Rows(0).Item("NPRPTO"))
            btnmodpu.Enabled = True
            btnbajapu.Enabled = True
            btnaltapu.Enabled = False

        Else

            cellselect = False
            Cargar_ID()
            Cargar_CBXcodprop()
            txtCodPue.Visible = True
            txtCodPue.Text = IDPUE.ToString()
            cbxcodppu.Visible = False
            txtnomppu.Text = "PUESTO " + CStr(id)
            txtNomPropie.Clear()
            txtcifpu.Clear()
            btnmodpu.Enabled = False
            btnbajapu.Enabled = False
            btnaltapu.Enabled = True
            btnStock.Enabled = False
            btnPuestosFrutas.Enabled = False
            cbxcodprop.Text = ""
            txtcifpu.Focus()

        End If
    End Sub
    Private Sub DataGridView1_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        Dim i As Integer
        If cellselect = True Then
            i = DataGridView1.CurrentRow.Index
            cbxcodppu.Text = (DataGridView1.Item(0, i).Value()).ToString
            txtnomppu.Text = (DataGridView1.Item(2, i).Value()).ToString
            txtcifpu.Text = (DataGridView1.Item(1, i).Value()).ToString
            cbxcodprop.Text = (DataGridView1.Item(3, i).Value()).ToString
            txtNomPropie.Text = (DataGridView1.Item(4, i).Value()).ToString

            If cbxcodppu.Text = "" Then
                cbxcodppu.Text = ""
                txtcifpu.Text = ""
                txtCodPue.Text = ""
                txtnomppu.Text = ""
                cbxcodprop.Text = ""
                txtNomPropie.Clear()
            End If
        End If
    End Sub
    Private Sub btnaltapu_Click(sender As System.Object, e As System.EventArgs) Handles btnaltapu.Click

        If MessageBox.Show("Desea dar ALTA a este Puesto?", "ALTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Try
                If txtCodPue.Text = "" Then
                    MsgBox("Codigo del Puesto no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                    txtCodPue.Focus()
                    Exit Sub
                ElseIf txtnomppu.Text = "" Then
                    MsgBox("El Nombre del Puesto no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                    txtnomppu.Focus()
                    Exit Sub
                ElseIf txtcifpu.Text = "" Then
                    MsgBox("El Codigo Fiscal no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                    txtnomppu.Focus()
                    Exit Sub
                ElseIf IsNumeric(txtcifpu.Text) = False Then
                    MsgBox("CODIGO FISCAL ingrese solamente numeros", CType(vbYes, MsgBoxStyle), "ERROR")
                    txtcifpu.Focus()
                    txtcifpu.Clear()
                    Exit Sub
                ElseIf cbxcodprop.Text = "" Then
                    MsgBox("El Codigo del Propietario no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                    cbxcodprop.Focus()
                    Exit Sub
                ElseIf txtNomPropie.Text = "" Then
                    MsgBox("El Nombre del Propietario no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                    cbxcodprop.Focus()
                    Exit Sub

                End If

                comandos = New OleDbCommand("insert INTO puestos (CODPTO, NOMTO, CIFPTO, NPRPTO, CODPRO) VALUES (@cpo,@nom,@cif,@nop,@cpr)", conexion)

                comandos.Parameters.AddWithValue("@cpo", txtCodPue.Text)
                comandos.Parameters.AddWithValue("@nom", txtnomppu.Text)
                comandos.Parameters.AddWithValue("@cif", txtcifpu.Text)
                comandos.Parameters.AddWithValue("@nop", txtNomPropie.Text)
                comandos.Parameters.AddWithValue("@cpr", cbxcodprop.Text)


                comandos.ExecuteNonQuery()

                MessageBox.Show("Alta de Nuevo Propietario Correcto", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information)

                cbxcodprop.Text = ""
                cbxcodppu.Text = ""
                txtCodPue.Visible = False
                cbxcodppu.Visible = True
                cbxcodppu.Items.Clear()
                Cargar_CBXcodpues()
                txtcifpu.Clear()
                txtnomppu.Clear()
                txtNomPropie.Clear()
                btnmodpu.Enabled = True
                btnbajapu.Enabled = True
                btnaltapu.Enabled = False
                cellselect = True
                btnStock.Enabled = True
                btnPuestosFrutas.Enabled = True
                cbxcodprop.Text = ""
                txtNomPropie.Text = ""
                btnaltapu.Focus()

            Catch ex As Exception
                MsgBox("Error: No se pudo realizar el alta", CType(vbYes, MsgBoxStyle), "ERROR")
                MsgBox(ex.ToString)
            End Try

        Else
            cellselect = True
            cbxcodprop.Text = ""
            txtNomPropie.Text = ""
            cbxcodppu.Text = ""
            txtCodPue.Visible = False
            cbxcodppu.Visible = True
            cbxcodppu.Items.Clear()
            Cargar_CBXcodpues()
            txtcifpu.Clear()
            txtnomppu.Clear()
            btnmodpu.Enabled = True
            btnbajapu.Enabled = True
            btnaltapu.Enabled = False
            btnStock.Enabled = True
            btnPuestosFrutas.Enabled = True
            cbxcodprop.Text = ""
            txtNomPropie.Text = ""
            btnaltapu.Focus()

        End If
    End Sub
    Private Sub btnbajapu_Click(sender As System.Object, e As System.EventArgs) Handles btnbajapu.Click
        If MessageBox.Show("Desea eliminar este registro?", "BAJA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            
            Try
                comandos = New OleDb.OleDbCommand("DELETE FROM puestos WHERE CODPTO='" & cbxcodppu.Text & "'", conexion)
                comandos.ExecuteNonQuery()

                comandos = New OleDb.OleDbCommand("DELETE FROM merpue WHERE CODPTO='" & cbxcodppu.Text & "'", conexion)
                comandos.ExecuteNonQuery()

                comandos = New OleDb.OleDbCommand("DELETE * FROM ptofru WHERE CODPTO='" & cbxcodppu.Text & "'", conexion) 'Se eliminan las frutas asociadas
                comandos.ExecuteNonQuery()

                MessageBox.Show("Puesto eliminado exitosamente, se elimino la relacion con su mercado y las frutas asociadas", "BAJA", MessageBoxButtons.OK, MessageBoxIcon.Information)

                cbxcodprop.Text = ""
                cbxcodppu.Text = ""
                txtCodPue.Visible = False
                cbxcodppu.Visible = True
                cbxcodppu.Items.Clear()
                Cargar_CBXcodpues()
                txtcifpu.Clear()
                txtnomppu.Clear()
                cbxcodprop.Text = ""
                txtNomPropie.Text = ""
                btnmodpu.Enabled = True
                btnbajapu.Enabled = True
                btnaltapu.Enabled = False

            Catch ex As Exception
                MsgBox("Error: No se pudo realizar la baja del Puesto ", CType(vbYes, MsgBoxStyle), "ERROR")
            End Try
        End If
    End Sub
    Private Sub btnmodpu_Click(sender As System.Object, e As System.EventArgs) Handles btnmodpu.Click

        Dim modificar As String
        Dim puestonew As String = cbxcodppu.Text
        If MessageBox.Show("Esta seguro que desea modificar el Registro?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then

            If cbxcodppu.Text = "" Then
                MsgBox("Error: Codigo del Puesto no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                cbxcodppu.Focus()
                Exit Sub
            ElseIf txtnomppu.Text = "" Then
                MsgBox("Error: El Nombre del Puesto no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                txtnomppu.Focus()
                Exit Sub
            ElseIf txtcifpu.Text = "" Then
                MsgBox("Error: El Codigo Fiscal no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                txtnomppu.Focus()
                Exit Sub
            ElseIf IsNumeric(txtcifpu.Text) = False Then
                MsgBox("CODIGO FISCAL: Ingrese solamente numeros", CType(vbYes, MsgBoxStyle), "ERROR")
                txtcifpu.Focus()
                Exit Sub
            ElseIf cbxcodprop.Text = "" Then
                MsgBox("Error: El Nombre del Propietario no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                cbxcodprop.Focus()
                Exit Sub
            End If

            modificar = "UPDATE puestos SET CODPTO ='" & puestonew & "' , NOMTO ='" & txtnomppu.Text & "' , CIFPTO ='" & txtcifpu.Text & "', NPRPTO ='" & txtNomPropie.Text & "', CODPRO ='" & cbxcodprop.Text & "' WHERE CODPTO ='" & cbxcodppu.Text & "'"

            comandos = New OleDb.OleDbCommand(modificar, conexion)

            comandos.ExecuteNonQuery()

            MessageBox.Show("Registro Modificado", "Accion Realizada")
            txtnomppu.Clear()
            cbxcodprop.Text = ""
            cbxcodppu.Text = ""
            txtCodPue.Visible = False
            cbxcodppu.Visible = True
            cbxcodppu.Items.Clear()
            Cargar_CBXcodpues()
            txtcifpu.Clear()
            txtnomppu.Clear()
            btnmodpu.Enabled = True
            btnbajapu.Enabled = True
            btnaltapu.Enabled = False
            cbxcodprop.Text = ""
            txtNomPropie.Text = ""

        Else

            txtNomPropie.Text = ""
            cbxcodppu.Text = ""
            txtCodPue.Visible = False
            cbxcodppu.Visible = True
            cbxcodppu.Items.Clear()
            Cargar_CBXcodpues()
            txtcifpu.Clear()
            txtnomppu.Clear()
            btnmodpu.Enabled = True
            btnbajapu.Enabled = True
            btnaltapu.Enabled = False
            cbxcodprop.Text = ""
            txtNomPropie.Text = ""

        End If
    End Sub
    Private Sub cbxcodprop_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles cbxcodprop.SelectionChangeCommitted

        consulta = "SELECT* FROM propietarios ORDER BY CODPRO"
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "propietarios")
        lista = CByte(ds.Tables("propietarios").Rows.Count)
        txtNomPropie.Text = CStr(ds.Tables("propietarios").Rows(cbxcodprop.SelectedIndex).Item("NPRPTO"))

    End Sub
    Private Sub btnPuestosFrutas_Click(sender As System.Object, e As System.EventArgs) Handles btnPuestosFrutas.Click
        If MessageBox.Show("Desea asociar un Puesto con una Fruta", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            PUESTOS_FRUTAS.Show()
        End If
    End Sub
    Private Sub btnStock_Click(sender As System.Object, e As System.EventArgs) Handles btnStock.Click
        If MessageBox.Show("Desea consultar el stock de las Frutas", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            STOCK_PUESTOS.Show()
        End If
    End Sub
End Class
