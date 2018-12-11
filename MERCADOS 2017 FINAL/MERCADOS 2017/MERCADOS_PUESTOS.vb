Imports System.Data.OleDb
Public Class MERCADOS_PUESTOS
    Dim conexion As New OleDb.OleDbConnection
    Dim comandos As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim consulta As String
    Private Sub MERCADOS_PUESTOS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            conexion = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\MERCADOS 2017\MERCADOS 2017\Mercados 2017.accdb;Persist Security Info = False;")

            conexion.Open()

            MessageBox.Show("La Conexion a la base de datos ha sido exitosa", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox("Se ha producido un error al querer conectarse con la base de datos", vbExclamation, "Error")
            Exit Sub

        End Try
    End Sub
    Sub Cargar_Puestos()
        consulta = "SELECT* FROM puestos CODPTO order by CODPTO"
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "puestos")
        cbxcodPuesto.DataSource = ds.Tables(0)
        cbxcodPuesto.DisplayMember = "CODPTO"
        cbxcodPuesto.ValueMember = "CODPTO"

    End Sub
    Sub Cargar_Mercados()
        consulta = "SELECT* FROM mercados"
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "mercados")
        cbxcodMercado.DataSource = ds.Tables(0)
        cbxcodMercado.DisplayMember = "CODMER"
        cbxcodMercado.ValueMember = "CODMER"

    End Sub
    Private Sub btnVolver_Click(sender As System.Object, e As System.EventArgs) Handles btnVolver.Click
        MERCADOS.txtnomer.Clear()
        MERCADOS.txttelmer.Clear()
        MERCADOS.txtcodpmer.Clear()
        MERCADOS.txtdireccmer.Clear()
        MERCADOS.cbxcodmer.Text = ""
        Me.Close()
    End Sub
    Private Sub btnMer_Pue_Click(sender As System.Object, e As System.EventArgs) Handles btnMer_Pue.Click
        If MessageBox.Show("Desea asociar el MERCADO: " & cbxcodMercado.Text & " con el PUESTO: " & cbxcodPuesto.Text & " ?", "ALTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Try
                Dim DataSet As DataSet

                DataSet = New DataSet
                DataSet.Tables.Add("MERPUE")

                comandos = New OleDbCommand("insert INTO MERPUE (CODMER, CODPTO) VALUES (@cme,@cpu)", conexion)
                comandos.Parameters.AddWithValue("@cme", cbxcodMercado.Text)
                comandos.Parameters.AddWithValue("@cpu", cbxcodPuesto.Text)

                comandos.ExecuteNonQuery()

                MessageBox.Show("La nueva asociacion fue correcta", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cbxcodPuesto.Text = Nothing
                cbxcodMercado.Text = Nothing
            Catch ex As Exception
                MsgBox("Ya se encuentran asociados")
                cbxcodPuesto.Text = Nothing
                cbxcodMercado.Text = Nothing
            End Try
        End If
    End Sub
    Private Sub cbxcodMercado_Click(sender As Object, e As System.EventArgs) Handles cbxcodMercado.Click
        Cargar_Mercados()
    End Sub
    Private Sub cbxcodPuesto_Click(sender As Object, e As System.EventArgs) Handles cbxcodPuesto.Click
        Cargar_Puestos()
    End Sub
End Class
