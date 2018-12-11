Imports System.Data.OleDb
Public Class FRUTAS
    Dim conexion As New OleDb.OleDbConnection
    Dim comandos As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim consulta As String
    Dim lista As Byte
    Dim cds As Integer
    Dim modycodalm, modymedida As String
    Dim id As Integer
    Dim cellselect, altaHabilitada As Boolean
    Private Sub FRUTAS_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        INICIO.Show()
    End Sub
    Private Sub ALMACENES_FRUTAS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'se conecta con la bd
        Try
            conexion = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\MERCADOS 2017\MERCADOS 2017\Mercados 2017.accdb;Persist Security Info = False;")

            conexion.Open()
            Cargar_Frutas()
            Cargar_CbxMedida()
            txtCodFru.Visible = False
            btnaltafa.Enabled = False
            cellselect = True
            altaHabilitada = False

            MessageBox.Show("La Conexion a la base de datos ha sido exitosa", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox("Se ha producido un error al querer conectarse con la base de datos", vbExclamation, "Error")
            Exit Sub

        End Try
    End Sub
    Sub Cargar_Frutas()
        'se carga el combo de las frutas y se agrega el item nuevo
        consulta = "SELECT* FROM frutas CODFRU order by CODFRU"
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "frutas")
        lista = CByte(ds.Tables("frutas").Rows.Count)
        cds = CInt(lista)
        If lista <> 0 Then
            For cont = 0 To cds - 1
                cbxcodfru.Items.Add(ds.Tables("frutas").Rows(cont).Item("CODFRU"))
            Next cont
            cbxcodfru.Items.Insert(lista, "Nuevo")
        Else
            MessageBox.Show("No ha sido exitosa la carga del combobox")
            Exit Sub

        End If
        DataGridView1.DataSource = ds.Tables(0)

    End Sub
    Sub Cargar_ID()
        'se carga un codigo nuevo para la fruta nueva
        consulta = "Select Top 1 CODFRU FROM frutas ORDER BY CODFRU desc"
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "idNuevo")
        id = CInt(ds.Tables("idNuevo").Rows(0).Item(0)) + 1
    End Sub
    Sub Cargar_CbxMedida()
        'se carga el combo con todas las medidas
        consulta = "SELECT* FROM medidas"
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "medidas")
        cbxmedidafa.DataSource = ds.Tables(0)
        cbxmedidafa.DisplayMember = "CMEFRU"
        cbxmedidafa.ValueMember = "CMEFRU"
        cbxmedidafa.Text = ""
    End Sub
    Private Sub btnvolfa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        If MessageBox.Show("Seguro desea volver al Inicio?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            INICIO.Show()
        End If
    End Sub
    Private Sub btnaltafa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaltafa.Click
        'se realiza el alta de un propietario
        If MessageBox.Show("Desea dar ALTA a este Propietario?", "ALTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            'se validan los datos ingresados por el usuario
            If txtNomFruFA.Text = "" Then
                MsgBox("El campo nombre de la fruta no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                txtNomFruFA.Focus()
                Exit Sub
            ElseIf cbxmedidafa.Text = "" Then
                MsgBox("El codigo de la medida no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                cbxmedidafa.Focus()
                Exit Sub
            ElseIf txtNomMedFA.Text = "" Then
                MsgBox("El nombre medida no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                cbxmedidafa.Focus()
                Exit Sub
            End If
            'se ejecuta el alta
            Try
                comandos = New OleDbCommand("insert INTO frutas (CODFRU, NOMFRU, CMEFRU, NMEFRU) VALUES (@cfr,@nfu,@cmd,@Nme)", conexion)

                comandos.Parameters.AddWithValue("@cfr", txtCodFru.Text)
                comandos.Parameters.AddWithValue("@nfu", txtNomFruFA.Text)
                comandos.Parameters.AddWithValue("@cmd", cbxmedidafa.Text)
                comandos.Parameters.AddWithValue("@Nme", txtNomMedFA.Text)

                comandos.ExecuteNonQuery()

                MessageBox.Show("Alta Correcto", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'se limpian todos los controles luego de realizar el alta
                cbxcodfru.Visible = True
                cbxcodfru.Text = ""
                cbxmedidafa.Text = ""
                txtNomFruFA.Visible = True
                txtNomFruFA.Text = ""
                txtNomMedFA.Visible = True
                txtNomMedFA.Text = ""
                txtCodFru.Visible = False
                txtCodFru.Clear()
                cellselect = True
                altaHabilitada = False
                cbxcodfru.Items.Clear()
                Cargar_Frutas()
                cbxcodfru.Items.Clear()
                Cargar_Frutas()

                btnaltafa.Enabled = False
                btnmodalm.Enabled = True
                btnbajafa.Enabled = True




            Catch ex As Exception
                MsgBox("Error: No se pudo realizar el alta", CType(vbYes, MsgBoxStyle), "ERROR")
            End Try
        Else
            cbxcodfru.Visible = True
            cbxcodfru.Text = ""
            cbxmedidafa.Visible = True
            cbxmedidafa.Text = ""
            txtNomFruFA.Visible = True
            txtNomFruFA.Text = ""
            txtNomMedFA.Visible = True
            txtNomMedFA.Text = ""
            btnaltafa.Enabled = False
            btnmodalm.Enabled = True
            btnbajafa.Enabled = True
        End If
    End Sub
    Private Sub btnbajafa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbajafa.Click
        'se elimina una fruta
        If cbxcodfru.Text = "" Then
            MsgBox("Seleccione la fruta que quiera eliminar", CType(vbYes, MsgBoxStyle), "ERROR")
            cbxcodfru.Focus()
        Else
            If MessageBox.Show("Desea dar de BAJA " & txtNomFruFA.Text & " ?", "BAJA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                'se ejecuta la baja
                Try
                    comandos = New OleDbCommand("DELETE * FROM frutas WHERE CODFRU ='" & cbxcodfru.Text & "'", conexion)
                    comandos.ExecuteNonQuery()

                    comandos = New OleDb.OleDbCommand("DELETE * FROM almfru WHERE CODFRU ='" & cbxcodfru.Text & "'", conexion) 'Se elimina la fruta del almacen
                    comandos.ExecuteNonQuery()

                    comandos = New OleDb.OleDbCommand("DELETE * FROM ptofru WHERE CODFRU ='" & cbxcodfru.Text & "'", conexion) 'Se elimina la fruta del puesto
                    comandos.ExecuteNonQuery()

                    MessageBox.Show("Fruta eliminada exitosamente, se elimino del almacen y del puesto asociado", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtNomFruFA.Text = ""
                    cbxcodfru.Text = ""
                    cbxcodfru.Text = ""
                    cbxmedidafa.Text = ""
                    txtNomMedFA.Text = ""
                    cbxcodfru.Items.Clear()
                    Cargar_Frutas()

                Catch ex As Exception
                    MsgBox("No se pudo realizar la Baja", CType(vbYes, MsgBoxStyle), "ERROR")
                    MsgBox(ex.ToString)
                End Try
            End If
        End If
    End Sub
    Private Sub btnmodalm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodalm.Click
        'se modifica una fruta 
        Dim modificar As String

        'se ejecuta la modificacion
        If MessageBox.Show("Esta seguro que desea modificar el registro?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then

            If cbxcodfru.Text = "" Then
                MsgBox("El Codigo de la fruta no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                cbxcodfru.Focus()
                Exit Sub
            ElseIf txtNomFruFA.Text = "" Then
                MsgBox("El Nombre de la fruta no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                cbxcodfru.Focus()
                Exit Sub
            ElseIf cbxmedidafa.Text = "" Then
                MsgBox("La medida de la fruta no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                cbxmedidafa.Focus()
                Exit Sub

            End If
            Try
                modificar = "UPDATE frutas SET  CODFRU ='" & cbxcodfru.Text & "', NOMFRU ='" & txtNomFruFA.Text & "', CMEFRU ='" & cbxmedidafa.Text & "', NMEFRU ='" & txtNomMedFA.Text & "' WHERE CODFRU ='" & cbxcodfru.Text & "'"

                comandos = New OleDb.OleDbCommand(modificar, conexion)

                comandos.ExecuteNonQuery()

                MessageBox.Show("Registro Modificado", "Accion Realizada")
                cbxcodfru.Items.Clear()
                Cargar_Frutas()
                cbxcodfru.Text = ""
                cbxmedidafa.Text = ""
                txtNomFruFA.Clear()
                txtNomMedFA.Clear()
            Catch ex As Exception
                MsgBox("No se pudo realizar la modificacion", CType(vbYes, MsgBoxStyle), "ERROR")
                MsgBox(ex.ToString)

            End Try
        Else
            txtNomFruFA.Text = ""
            cbxcodfru.Text = ""
            cbxmedidafa.Text = ""
            txtNomMedFA.Text = ""

        End If
       
    End Sub
    Private Sub DataGridView1_Cellenter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        'se cargan los textos con lo que se selecciona en el datagrid
        Dim i As Integer
        If cellselect = True Then
            i = DataGridView1.CurrentRow.Index

            cbxcodfru.Text = (DataGridView1.Item(0, i).Value()).ToString
            txtNomFruFA.Text = (DataGridView1.Item(1, i).Value()).ToString
            cbxmedidafa.Text = (DataGridView1.Item(2, i).Value()).ToString
            txtNomMedFA.Text = (DataGridView1.Item(3, i).Value()).ToString

            If cbxcodfru.Text = "" Then
                cbxcodfru.Text = ""
                txtNomMedFA.Clear()
                cbxmedidafa.Text = ""
                txtNomFruFA.Clear()

            End If
        End If
    End Sub
    Private Sub cbxcodfru_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxcodfru.SelectedIndexChanged
        'se cargan los textos con el codigo de la fruta seleccionado en el combo
        If Not CStr(cbxcodfru.SelectedItem) = "Nuevo" Then

            consulta = "SELECT * FROM frutas CODFRU where CODFRU ='" & cbxcodfru.Text & "'"
            da = New OleDb.OleDbDataAdapter(consulta, conexion)
            ds = New DataSet
            da.Fill(ds, "frutas")

            txtNomFruFA.Text = CStr(ds.Tables("frutas").Rows(0).Item("NOMFRU"))
            cbxmedidafa.Text = CStr(ds.Tables("frutas").Rows(0).Item("CMEFRU"))
            txtNomMedFA.Text = CStr(ds.Tables("frutas").Rows(0).Item("NMEFRU"))

        Else
            'se preparan los controles para realizar el alta
            DataGridView1.ClearSelection()
            cellselect = False
            Cargar_ID()
            cbxcodfru.Visible = False
            txtCodFru.Visible = True
            txtCodFru.Text = id.ToString
            txtNomMedFA.Text = ""
            txtNomFruFA.Text = ""
            cbxmedidafa.Text = ""
            btnaltafa.Enabled = True
            btnmodalm.Enabled = False
            btnbajafa.Enabled = False
        End If
    End Sub
    Private Sub cbxmedidafa_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles cbxmedidafa.SelectionChangeCommitted
        'se carga el combo con todas las medidas
        consulta = "SELECT* FROM medidas"
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "medidas")
        lista = CByte(ds.Tables("medidas").Rows.Count)
        txtNomMedFA.Text = CStr(ds.Tables("medidas").Rows(cbxmedidafa.SelectedIndex).Item("NMEFRU"))
    End Sub
End Class
