Imports System.Data.OleDb
Public Class ALMACEN_FRUTAS
    Dim conexion As New OleDb.OleDbConnection
    Dim comandos, comandosp As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim consulta As String
    Private Sub ALMACEN_FRUTAS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'se conecta con la base de datos
        Try
            conexion = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\MERCADOS 2017\MERCADOS 2017\Mercados 2017.accdb;Persist Security Info = False;")

            conexion.Open()

            MessageBox.Show("La Conexion a la base de datos ha sido exitosa", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox("Se ha producido un error al querer conectarse con la base de datos", vbExclamation, "Error")
            Exit Sub

        End Try
    End Sub
    Sub cargarAlmacenes()
        'se cargan los almacenes
        consulta = "SELECT* FROM almacenes CODALM order by CODALM"
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "almacenes")
        cbxCodAlm.DataSource = ds.Tables(0)
        cbxCodAlm.ValueMember = "CODALM"
        cbxCodAlm.DisplayMember = "NOMALM"
    End Sub
    Sub Cargar_Frutas()
        'se cargan las frutas
        consulta = "SELECT* FROM frutas CODFRU order by CODFRU"
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "frutas")
        cbxcodfru.DataSource = ds.Tables(0)
        cbxcodfru.ValueMember = "CODFRU"
        cbxcodfru.DisplayMember = "NOMFRU"

    End Sub
    Private Sub btnAsociar_Click(sender As System.Object, e As System.EventArgs) Handles btnAsociar.Click
        'se asocia el almacen con la fruta
        If MessageBox.Show("Desea asociar: " & cbxCodAlm.Text & " con: " & cbxcodfru.Text & " ?", "ALTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Try
                If txtpreciofp.Text = "" Then
                    MsgBox("El precio no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                    txtpreciofp.Focus()
                    Exit Sub
                ElseIf IsNumeric(txtpreciofp.Text) = False Then
                    MsgBox("Ingrese un valor Numerico para el precio", CType(vbYes, MsgBoxStyle), "ERROR")
                    txtpreciofp.Clear()
                    txtpreciofp.Focus()
                    Exit Sub
                ElseIf txtstockfp.Text = "" Then
                    MsgBox("El stock no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                    txtstockfp.Focus()
                    Exit Sub
                ElseIf IsNumeric(txtstockfp.Text) = False Then
                    MsgBox("Ingrese un valor Numerico para el stock", CType(vbYes, MsgBoxStyle), "ERROR")
                    txtstockfp.Clear()
                    txtstockfp.Focus()
                    Exit Sub
                End If
                Dim DataSet As DataSet

                DataSet = New DataSet
                DataSet.Tables.Add("ALMFRU")

                comandos = New OleDbCommand("insert INTO almfru (CODALM, CODFRU,PVEFRUALM,STOCKALM) VALUES (@cam,@cfru,@pre,@stk)", conexion)
                comandos.Parameters.AddWithValue("@cam", cbxCodAlm.SelectedValue.ToString)
                comandos.Parameters.AddWithValue("@cfru", cbxcodfru.SelectedValue.ToString)
                comandos.Parameters.AddWithValue("@pre", txtpreciofp.Text)
                comandos.Parameters.AddWithValue("@stk", txtstockfp.Text)

                comandos.ExecuteNonQuery()

                MessageBox.Show("La nueva asociacion fue correcta", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information)

                cargarAlmacenes()
                Cargar_Frutas()
                cbxCodAlm.Text = Nothing
                cbxcodfru.Text = Nothing
                txtpreciofp.Text = ""
                txtstockfp.Text = ""
            Catch ex As Exception
                MsgBox("Ya se encuentran asociados")
                cbxCodAlm.Text = Nothing
                cbxcodfru.Text = Nothing
                txtpreciofp.Text = ""
                txtstockfp.Text = ""
            End Try
        End If
    End Sub
    Private Sub btnVolver_Click(sender As System.Object, e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
    End Sub
    Private Sub cbxCodAlm_Click(sender As Object, e As System.EventArgs) Handles cbxCodAlm.Click
        cargarAlmacenes()
    End Sub
    Private Sub cbxcodfru_Click(sender As Object, e As System.EventArgs) Handles cbxcodfru.Click
        Cargar_Frutas()
    End Sub
End Class

