Imports System.Data.OleDb
Public Class ALMACENES_MERCADOS
    Dim conexion As New OleDb.OleDbConnection
    Dim comandos As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim consulta As String
    Private Sub ALMACENES_MERCADOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'se conecta con la BD
        Try
            conexion = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\MERCADOS 2017\MERCADOS 2017\Mercados 2017.accdb;Persist Security Info = False;")

            conexion.Open()

            MessageBox.Show("La Conexion a la base de datos ha sido exitosa", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox("Se ha producido un error al querer conectarse con la base de datos", vbExclamation, "Error")
            Exit Sub

        End Try
    End Sub
    Sub Cargar_Almacenes()
        'se carga el combo almacen
        consulta = "SELECT* FROM almacenes"
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "almacenes")
        cbxcodalm.DataSource = ds.Tables(0)
        cbxcodalm.DisplayMember = "NOMALM"
        cbxcodalm.ValueMember = "CODALM"

    End Sub
    Sub Cargar_Mercados()
        'se carga el combo mercados
        consulta = "SELECT* FROM mercados ORDER BY codmer"
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "mercados")
        cbxcodmer.DataSource = ds.Tables(0)
        cbxcodmer.DisplayMember = "NOMMER"
        cbxcodmer.ValueMember = "CODMER"
    End Sub
    Private Sub btnAlm_Mer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlm_Mer.Click
        'se hace la asociacion
        If MessageBox.Show("Desea asociar el ALMACEN: " & cbxcodalm.Text & " con el MERCADO: " & cbxcodmer.Text & " ?", "ASOCIAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Try

                Dim DataSet As New DataSet
                DataSet.Tables.Add("ALMMER")

                comandos = New OleDbCommand("insert INTO almmer (CODALM, CODMER) VALUES (@cam,@cme)", conexion)
                comandos.Parameters.AddWithValue("@cam", cbxcodalm.SelectedValue.ToString)
                comandos.Parameters.AddWithValue("@cme", cbxcodmer.SelectedValue.ToString)

                comandos.ExecuteNonQuery()

                MessageBox.Show("La nueva asociacion fue correcta", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information)

                cbxcodalm.Text = Nothing
                cbxcodmer.Text = Nothing
            Catch ex As Exception
                MsgBox("Ya se encuentran asociados")
                cbxcodalm.Text = Nothing
                cbxcodmer.Text = Nothing
            End Try
        End If
    End Sub
    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        ALMACENES.txtnomalm.Text = ""
        ALMACENES.txtcifalm.Text = ""
        ALMACENES.CBOXALMACEN.Text = ""
        Me.Hide()

    End Sub
    Private Sub cbxcodalm_Click(sender As Object, e As System.EventArgs) Handles cbxcodalm.Click
        Cargar_Almacenes()
    End Sub
    Private Sub cbxcodmer_Click(sender As Object, e As System.EventArgs) Handles cbxcodmer.Click
        Cargar_Mercados()
    End Sub
End Class

