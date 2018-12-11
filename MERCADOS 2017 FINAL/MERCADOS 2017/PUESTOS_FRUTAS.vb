Imports System.Data.OleDb
Public Class PUESTOS_FRUTAS
    Dim conexion As New OleDb.OleDbConnection
    Dim comandos As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim consulta As String
    Private Sub PUESTOS_FRUTAS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            conexion = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\MERCADOS 2017\MERCADOS 2017\Mercados 2017.accdb;Persist Security Info = False;")

            conexion.Open()
            MessageBox.Show("La Conexion a la base de datos ha sido exitosa", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox("Se ha producido un error al querer conectarse con la base de datos", vbExclamation, "Error")
            Exit Sub

        End Try
    End Sub
    Sub CargarPuestos()

        consulta = "SELECT * FROM puestos"
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "puestos")
        cbxCodPue.DataSource = ds.Tables(0)
        cbxCodPue.ValueMember = "CODPTO"
        cbxCodPue.DisplayMember = "CODPTO"


    End Sub
    Sub CargarFrutas()
        consulta = "SELECT * FROM FRUTAS"
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "frutas")
        cbxcodfrufp.DataSource = ds.Tables("frutas")
        cbxcodfrufp.ValueMember = "CODFRU"
        cbxcodfrufp.DisplayMember = "NOMFRU"
    End Sub
    Private Sub btnVolver_Click(sender As System.Object, e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub
    Private Sub btnAsociar_Click(sender As System.Object, e As System.EventArgs) Handles btnAsociar.Click
        If MessageBox.Show("Desea asociar el PUESTO: " & cbxCodPue.Text & "con la FRUTA: " & cbxcodfrufp.Text & " ?", "ALTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
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

                comandos = New OleDbCommand("insert INTO ptofru (CODPTO, CODFRU,PVEFRUPTO,STKPTO) VALUES (@cpto,@cfru,@pre,@stk)", conexion)
                comandos.Parameters.AddWithValue("@cpto", cbxCodPue.Text)
                comandos.Parameters.AddWithValue("@cfru", cbxcodfrufp.Text)
                comandos.Parameters.AddWithValue("@pre", txtpreciofp.Text)
                comandos.Parameters.AddWithValue("@stk", txtstockfp.Text)

                comandos.ExecuteNonQuery()

                MessageBox.Show("La nueva asociacion fue correcta", "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarFrutas()
                CargarPuestos()

                cbxcodfrufp.Text = Nothing
                cbxCodPue.Text = Nothing
                txtpreciofp.Text = ""
                txtstockfp.Text = ""
            Catch ex As Exception
                MsgBox("Ya se encuentran asociados")
                cbxcodfrufp.Text = Nothing
                cbxCodPue.Text = Nothing
                txtpreciofp.Text = ""
                txtstockfp.Text = ""
            End Try
        End If
    End Sub
    Private Sub cbxCodPue_Click(sender As Object, e As System.EventArgs) Handles cbxCodPue.Click
        CargarPuestos()
    End Sub
    Private Sub cbxcodfrufp_Click(sender As Object, e As System.EventArgs) Handles cbxcodfrufp.Click
        CargarFrutas()
    End Sub
End Class



