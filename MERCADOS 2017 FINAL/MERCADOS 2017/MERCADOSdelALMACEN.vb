Imports System.Data.OleDb
Public Class MERCADOSdelALMACEN

    Private Sub MERCADOSdelALMACEN_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Dim conexion As New OleDbConnection
            conexion = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\MERCADOS 2017\MERCADOS 2017\Mercados 2017.accdb;Persist Security Info = False;")
            conexion.Open()
            Dim consul As String = "SELECT A.CODALM AS ALMACEN , M.CODMER AS MERCADO , M.NOMMER AS NOMBRE " & _
       " FROM (ALMACENES AS A INNER JOIN ALMMER AS ALMR ON A.CODALM = ALMR.CODALM) INNER JOIN MERCADOS AS M ON M.CODMER = ALMR.CODMER " & _
    " WHERE A.CODALM ='" & ALMACENES.CBOXALMACEN.Text & "'" & _
    " ORDER BY M.CODMER"

            Dim da As New OleDbDataAdapter(consul, conexion)
            Dim ds As New DataSet
            da.Fill(ds, "ALMACENES")

            dtgvMercados.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox("Se ha producido un error al querer conectarse con la base de datos", vbExclamation, "Error")
            Exit Sub

        End Try
    End Sub
End Class