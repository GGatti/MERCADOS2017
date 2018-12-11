Imports System.Data.OleDb
Public Class PUESTOSdelMERCADO
    Private Sub PUESTOSdelMERCADO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Dim conexion As New OleDbConnection
            conexion = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\MERCADOS 2017\MERCADOS 2017\Mercados 2017.accdb;Persist Security Info = False;")
            conexion.Open()
            Dim consul As String = "SELECT M.CODMER AS MERCADO , P.CODPTO AS CODIGO_PUESTO , P.NOMTO AS NOMBRE_PUESTO " & _
       " FROM (MERCADOS AS M INNER JOIN MERPUE AS MP ON M.CODMER = MP.CODMER) INNER JOIN PUESTOS AS P ON MP.CODPTO = P.CODPTO" & _
    " WHERE M.CODMER ='" & MERCADOS.cbxcodmer.Text & "'" & _
    " ORDER BY P.CODPTO"

            Dim da As New OleDbDataAdapter(consul, conexion)
            Dim ds As New DataSet
            da.Fill(ds, "PUESTOS")

            dtgvPuestos.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox("Se ha producido un error al querer conectarse con la base de datos", vbExclamation, "Error")
            Exit Sub

        End Try

    End Sub
End Class