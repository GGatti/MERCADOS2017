Imports System.Data.OleDb
Public Class ALMACENES
    Dim conexion As New OleDb.OleDbConnection
    Dim comandos As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim consulta, Buscar, cboxtext, IDnuevo As String
    Dim filasTotal As Byte
    Dim id As Integer
    Dim cellSelect As Boolean
    Private Sub ALMACENES_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        INICIO.Show()
    End Sub
    Private Sub frmALMACENES_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'se conecta con la base de datos
        Try
            conexion = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\MERCADOS 2017\MERCADOS 2017\Mercados 2017.accdb;Persist Security Info = False;")

            conexion.Open()
            Cargar_Combobox()
            txtCODALMALM.Visible = False
            CBOXALMACEN.Visible = True
            txtcifalm.Text = ""
            CBOXALMACEN.Text = ""
            txtnomalm.Text = ""

            MessageBox.Show("La Conexion a la base de datos ha sido exitosa", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox("Se ha producido un error al querer conectarse con la base de datos", vbExclamation, "Error")
            Exit Sub

        End Try
    End Sub
    Sub Cargar_Combobox()
        'se cargan los almacenes
        consulta = "SELECT* FROM almacenes CODALM order by CODALM"
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "almacenes")
        filasTotal = CByte(ds.Tables("almacenes").Rows.Count)
        cellSelect = True
        If filasTotal <> 0 Then
            For contador = 0 To filasTotal - 1 'Aca Cargamos el combobox
                CBOXALMACEN.Items.Add(ds.Tables("almacenes").Rows(contador).Item("CODALM"))
            Next contador
            CBOXALMACEN.Items.Insert(filasTotal, "Nuevo") ' Agregamos el item "NUEVO" por si se desea cargar uno nuevo
        Else
            MessageBox.Show("No ha sido exitosa la carga del combobox")
            Exit Sub

        End If
        DataGridView1.DataSource = ds.Tables(0)


    End Sub
    Sub Cargar_ID()
        'se va a cargar el codigo para el nuevo almacen
        Dim NumeroId, Num As String
        consulta = "Select Top 1 CODALM FROM almacenes ORDER BY CODALM desc"
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "almacenes")
        'se guarda el ultimo codigo de la bd
        NumeroId = CStr(ds.Tables("almacenes").Rows(0).Item(0))
        'se extraen los utimos dos caracteres del registro
        Num = Microsoft.VisualBasic.Right(NumeroId, 2)
        id = CInt(Num) + 1

        IDnuevo = "AL" + CStr(id)

    End Sub
    Sub estadoInicial()
        'pone todos los controles en el estado inicial
        txtnomalm.Clear()
        txtcifalm.Clear()
        txtCODALMALM.Visible = False
        CBOXALMACEN.Visible = True
        CBOXALMACEN.Text = ""
        CBOXALMACEN.Items.Clear()
        Cargar_Combobox()
        btnaltalm.Enabled = False
        btnbajalm.Enabled = True
        btnmodificacionalm.Enabled = True
    End Sub

    Private Sub CBOXALMACEN_Click(sender As Object, e As System.EventArgs) Handles CBOXALMACEN.Click
        CBOXALMACEN.Items.Clear()
        Cargar_Combobox()
        cellSelect = True
        DataGridView1.ClearSelection()
        DataGridView1.BackgroundColor = Color.Gray
    End Sub
    Private Sub CBOXALMACEN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBOXALMACEN.SelectedIndexChanged
        'carga los textos del almacen seleccionado 
        If Not CStr(CBOXALMACEN.SelectedItem) = "Nuevo" Then
            consulta = "SELECT* FROM almacenes CODALM where CODALM = '" & CBOXALMACEN.Text & "'"
            da = New OleDb.OleDbDataAdapter(consulta, conexion)
            ds = New DataSet
            da.Fill(ds, "almacenes")
            filasTotal = CByte(ds.Tables("almacenes").Rows.Count)
            txtnomalm.Text = CStr(ds.Tables("almacenes").Rows(0).Item("NOMALM"))
            txtcifalm.Text = CStr(ds.Tables("almacenes").Rows(0).Item("CIFALM"))
            btnmodificacionalm.Enabled = True
            btnbajalm.Enabled = True
            btnaltalm.Enabled = False
            DataGridView1.ClearSelection()

        Else
            'si se elige nuevo se carga el codigo del almacen y se deshabilitan los botones mod y baja
            Cargar_ID()
            cellSelect = False
            txtnomalm.Text = "ALMACEN " + CStr(id)
            txtCODALMALM.Text = IDnuevo.ToString()
            txtCODALMALM.Visible = True
            CBOXALMACEN.Visible = False
            txtcifalm.Clear()
            txtcifalm.Focus()
            txtnomalm.Enabled = True
            txtcifalm.Enabled = True
            btnmodificacionalm.Enabled = False
            btnbajalm.Enabled = False
            btnaltalm.Enabled = True
            DataGridView1.ClearSelection()
        End If

    End Sub
    Private Sub btnaltalm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaltalm.Click
        'se realiza el alta del almacen
        If MessageBox.Show("Desea dar ALTA a este almacen?", "ALTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Try
                Dim AlmDs As DataSet

                AlmDs = New DataSet
                AlmDs.Tables.Add("ALMACENES")

                comandos = New OleDbCommand("insert INTO almacenes (CODALM, NOMALM, CIFALM) VALUES (@cam,@nom,@cif)", conexion)
                'se validan los datos que ingresa el usuario
                If txtCODALMALM.Text = "" Then
                    MsgBox("CODIGO DE ALMACEN: No puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                    txtCODALMALM.Focus()
                    Exit Sub
                ElseIf txtnomalm.Text = "" Then
                    MsgBox("NOMBRE: No puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                    txtnomalm.Focus()
                    Exit Sub
                ElseIf txtcifalm.Text = "" Then
                    MsgBox("CODIGO FISCAL: No puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                    txtcifalm.Focus()
                    Exit Sub
                ElseIf IsNumeric(txtcifalm.Text) = False Then

                    MsgBox("CODIGO FISCAL: El CIF es Numerico", CType(vbYes, MsgBoxStyle), "ERROR")
                    txtcifalm.Clear()
                    txtcifalm.Focus()
                    Exit Sub
                Else
                    comandos.Parameters.AddWithValue("@cam", txtCODALMALM.Text)
                    comandos.Parameters.AddWithValue("@nom", txtnomalm.Text)
                    comandos.Parameters.AddWithValue("@cif", txtcifalm.Text)
                    'se ejecuta el alta
                    comandos.ExecuteNonQuery()

                    MessageBox.Show("Alta de Nuevo Almacen Correcto", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If MessageBox.Show(" El Nuevo Almacen debe tener un Mercado asociado, desea realizar la asociacion ahora", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        ALMACENES_MERCADOS.Show()
                    Else
                        estadoInicial()
                    End If

                End If



            Catch ex As Exception
                MsgBox("Error: No se pudo realizar el alta", CType(vbYes, MsgBoxStyle), "ERROR")
            End Try
        Else
            estadoInicial()
        End If


    End Sub
    Private Sub btnbajalm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbajalm.Click
        'se elimina el almacen
        cboxtext = CStr(CBOXALMACEN.SelectedItem) 'se guarda el almacen seleccionado
        If MessageBox.Show("Desea eliminar a este registro?", "BAJA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then

            Try
                comandos = New OleDb.OleDbCommand("DELETE * FROM ALMACENES WHERE CODALM='" & cboxtext & "'", conexion)
                comandos.ExecuteNonQuery()

                comandos = New OleDb.OleDbCommand("DELETE * FROM almmer WHERE CODALM='" & cboxtext & "'", conexion) 'Se realiza este paso para eliminar los mercados asociados
                comandos.ExecuteNonQuery()

                comandos = New OleDb.OleDbCommand("DELETE * FROM almfru WHERE CODALM='" & cboxtext & "'", conexion) 'Se realiza este paso para eliminar las frutas asociadas
                comandos.ExecuteNonQuery()

                MessageBox.Show("Almacen eliminado exitosamente, se elimino la relacion con sus mercados y con sus frutas", "BAJA", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MsgBox("Error: No se pudo realizar la baja del almacen", CType(vbYes, MsgBoxStyle), "ERROR")
            End Try

            estadoInicial()
        Else
            estadoInicial()
        End If

    End Sub
    Private Sub btnmodificacionalm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificacionalm.Click
        'se modifica el almacen seleccionado
        Dim modificar As String
        cboxtext = CStr(CBOXALMACEN.SelectedItem)
        Dim almacenew As String = CBOXALMACEN.Text
        'se validan los datos ingresados por el usuario
        If MessageBox.Show("Esta seguro que desea modificar el Registro?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            If CBOXALMACEN.Text = "" Then
                MsgBox("El codigo del almacen no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                CBOXALMACEN.Focus()
                Exit Sub
            ElseIf txtnomalm.Text = "" Then
                MsgBox("El nombre no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                txtnomalm.Focus()
                Exit Sub
            ElseIf txtcifalm.Text = "" Then
                MsgBox("El codigo fiscal no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                txtcifalm.Focus()
                Exit Sub
            ElseIf IsNumeric(txtcifalm.Text) = False Then
                MsgBox("El codigo fiscal es Numerico", CType(vbYes, MsgBoxStyle), "ERROR")
                txtcifalm.Focus()
                Exit Sub
            Else
                'se ejecuta la modificacion
                modificar = "UPDATE Almacenes SET CODALM ='" & almacenew & "' , NOMALM ='" & txtnomalm.Text & "' , CIFALM ='" & txtcifalm.Text & "'WHERE CODALM ='" & cboxtext & "'"
                comandos = New OleDb.OleDbCommand(modificar, conexion)
                comandos.ExecuteNonQuery()

                MessageBox.Show("Registro Modificado", "Accion Realizada")
                CBOXALMACEN.Items.Clear()
                Cargar_Combobox()
                estadoInicial()
            End If

        Else
            estadoInicial()
        End If
    End Sub
    Private Sub btninialm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninialm.Click
        CBOXALMACEN.Text = ""
        txtnomalm.Clear()
        txtcifalm.Clear()
        Me.Close()
        INICIO.Show()
    End Sub
    Private Sub btnmeralm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmeralm.Click
        
        If MessageBox.Show("Desea asociar Almacen con un mercado existente?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ALMACENES_MERCADOS.Show()
        End If

    End Sub
    Private Sub DataGridView1_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        'se cargan los textos con la seleccion realizada en el datagrid
        Dim i As Integer
        If cellSelect = True Then
            i = DataGridView1.CurrentRow.Index
            CBOXALMACEN.Text = (DataGridView1.Item(0, i).Value()).ToString
            txtnomalm.Text = (DataGridView1.Item(1, i).Value()).ToString
            txtcifalm.Text = (DataGridView1.Item(2, i).Value()).ToString
            If CBOXALMACEN.Text = "" Then
                txtcifalm.Clear()
                txtnomalm.Clear()
            End If
        End If
    End Sub
    Private Sub btnAlmFrutas_Click(sender As System.Object, e As System.EventArgs) Handles btnAlmFrutas.Click
        If MessageBox.Show("Desea asociar un Almacen con una Fruta", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ALMACEN_FRUTAS.Show()
        End If
    End Sub
    Private Sub btnStock_Click(sender As System.Object, e As System.EventArgs) Handles btnStock.Click
        If MessageBox.Show("Desea consultar el stock de las Frutas", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            STOCK_ALMACEN.Show()
        End If
    End Sub
    Private Sub btnMerdelAlm_Click(sender As System.Object, e As System.EventArgs) Handles btnMerdelAlm.Click
        If CBOXALMACEN.Text = "" Then
            MsgBox("Seleccione un almacen.")
            Exit Sub
        End If
        cellSelect = False
        Try
            Dim conexion As New OleDbConnection
            conexion = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\MERCADOS 2017\MERCADOS 2017\Mercados 2017.accdb;Persist Security Info = False;")
            conexion.Open()
            Dim consul As String = "SELECT A.CODALM AS ALMACEN , M.CODMER AS MER_ASOCIADO , M.NOMMER AS NOMBRE " & _
       " FROM (ALMACENES AS A INNER JOIN ALMMER AS ALMR ON A.CODALM = ALMR.CODALM) INNER JOIN MERCADOS AS M ON M.CODMER = ALMR.CODMER " & _
    " WHERE A.CODALM ='" & CBOXALMACEN.Text & "'" & _
    " ORDER BY M.CODMER"

            DataGridView1.BackgroundColor = Color.Red

            Dim da As New OleDbDataAdapter(consul, conexion)
            Dim ds As New DataSet
            da.Fill(ds, "ALMACENES")

            DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox("Se ha producido un error al querer conectarse con la base de datos", vbExclamation, "Error")
            Exit Sub

        End Try
    End Sub
End Class
