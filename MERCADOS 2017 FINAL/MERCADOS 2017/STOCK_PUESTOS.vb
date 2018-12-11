Imports System.Data.OleDb
Public Class STOCK_PUESTOS
    Dim conexion As New OleDb.OleDbConnection
    Dim consulta As String
    Dim ds As New DataSet
    Dim da As OleDbDataAdapter
    Dim comandos As New OleDbCommand
    Private Sub STOCK_PUESTOS_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            conexion = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\MERCADOS 2017\MERCADOS 2017\Mercados 2017.accdb;Persist Security Info = False;")
            conexion.Open()
            txtpreciofp.Enabled = False
            txtstockfp.Enabled = False
        Catch ex As Exception
            MsgBox("Se ha producido un error al querer conectarse con la base de datos", vbExclamation, "Error")
            Exit Sub

        End Try
    End Sub
    Private Sub cbxCodPue_Click(sender As Object, e As System.EventArgs) Handles cbxCodPue.Click
        consulta = "SELECT* FROM puestos CODPTO order by CODPTO"
        da = New OleDb.OleDbDataAdapter(consulta, conexion)
        ds = New DataSet
        da.Fill(ds, "puestos")
        cbxCodPue.DataSource = ds.Tables(0)
        cbxCodPue.ValueMember = "CODPTO"
        cbxCodPue.DisplayMember = "NOMTO"
    End Sub
    Private Sub cbxCodPue_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cbxCodPue.SelectedValueChanged
        cbxcodfru.Text = ""
        txtnomedfp.Text = ""
        txtpreciofp.Text = ""
        txtstockfp.Text = ""
    End Sub
    Private Sub cbxCodPue_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles cbxCodPue.SelectionChangeCommitted
        Dim consul As String = "spPUESTOFRU"
        Dim cmd As New OleDbCommand(consul, conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim p1 As New OleDbParameter
        p1.Direction = ParameterDirection.Input
        p1.ParameterName = "CODPTO"
        p1.Value = cbxCodPue.SelectedValue
        p1.OleDbType = OleDbType.Char

        cmd.Parameters.Add(p1)

        Dim da As New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "FRUTAS")

        cbxcodfru.DataSource = ds.Tables("FRUTAS")
        cbxcodfru.DisplayMember = "NOMFRU"
        cbxcodfru.ValueMember = "CODFRU"

    End Sub
    Private Sub cbxcodfru_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles cbxcodfru.SelectionChangeCommitted
        Dim consul As String = "spNOMFRUPTO"
        Dim cmd As New OleDbCommand(consul, conexion)
        cmd.CommandType = CommandType.StoredProcedure
        Dim p1 As New OleDbParameter
        p1.Direction = ParameterDirection.Input
        p1.ParameterName = "CODFRU"
        p1.Value = cbxcodfru.SelectedValue
        p1.OleDbType = OleDbType.Char

        cmd.Parameters.Add(p1)

        Dim da As New OleDbDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "STOCK")
        Dim filasTotal As Byte
        filasTotal = CByte(ds.Tables("STOCK").Rows.Count)
        txtnomedfp.Text = CStr(ds.Tables("STOCK").Rows(0).Item("NMEFRU"))
        txtpreciofp.Text = CStr(ds.Tables("STOCK").Rows(0).Item("PVEFRUPTO"))
        txtstockfp.Text = CStr(ds.Tables("STOCK").Rows(0).Item("STKPTO"))
    End Sub
    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        Dim actualizar As String

        If MessageBox.Show("Esta seguro que desea modificar el Registro?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            If cbxCodPue.Text = "" Then
                MsgBox("El codigo del puesto no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                cbxCodPue.Focus()
                Exit Sub
            ElseIf cbxcodfru.Text = "" Then
                MsgBox("El codigo de la fruta no puede estar vacio", CType(vbYes, MsgBoxStyle), "ERROR")
                cbxcodfru.Focus()
                Exit Sub
            ElseIf IsNumeric(txtpreciofp.Text) = False Then
                MsgBox("Precio debe ser numerico", CType(vbYes, MsgBoxStyle), "ERROR")
                txtpreciofp.Clear()
                txtpreciofp.Focus()
                Exit Sub
            ElseIf IsNumeric(txtstockfp.Text) = False Then
                MsgBox("Stock debe ser numerico", CType(vbYes, MsgBoxStyle), "ERROR")
                txtstockfp.Clear()
                txtstockfp.Focus()
            End If

            actualizar = "UPDATE PTOFRU SET PVEFRUPTO ='" & txtpreciofp.Text & "' , STKPTO ='" & txtstockfp.Text & "'WHERE CODFRU ='" & cbxcodfru.SelectedValue.ToString & "' and CODPTO ='" & cbxCodPue.SelectedValue.ToString & "'"
            comandos = New OleDb.OleDbCommand(actualizar, conexion)
            comandos.ExecuteNonQuery()

            MessageBox.Show("Registro Modificado", "Accion Realizada")

            txtpreciofp.Enabled = False
            txtstockfp.Enabled = False
            txtpreciofp.Text = ""
            txtstockfp.Text = ""
            cbxCodPue.Text = Nothing
            cbxcodfru.Text = Nothing
            txtnomedfp.Text = ""

        Else
            txtpreciofp.Enabled = False
            txtstockfp.Enabled = False
            txtpreciofp.Text = ""
            txtstockfp.Text = ""
            cbxCodPue.Text = Nothing
            cbxcodfru.Text = Nothing
            txtnomedfp.Text = ""
        End If
    End Sub
    Private Sub txtnomedfp_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtnomedfp.TextChanged

        If txtnomedfp.Text <> "" Then
            txtpreciofp.Enabled = True
            txtstockfp.Enabled = True
        Else
            txtpreciofp.Enabled = False
            txtstockfp.Enabled = False
        End If
    End Sub
    Private Sub btnVolver_Click(sender As System.Object, e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
    End Sub
End Class