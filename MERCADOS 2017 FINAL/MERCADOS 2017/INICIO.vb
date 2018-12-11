
Public Class INICIO
    Private Sub INICIO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnmerini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmerini.Click
        Me.Hide()
        MERCADOS.Show()
    End Sub

    Private Sub btnalmini_Click(sender As System.Object, e As System.EventArgs) Handles btnalmini.Click
        Me.Hide()
        ALMACENES.Show()

    End Sub

    Private Sub btnpropini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpropini.Click
        Me.Hide()
        PROPIETARIOS.Show()

    End Sub

    Private Sub btnpueini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpueini.Click
        Me.Hide()
        PUESTOS.Show()

    End Sub

    Private Sub btnfruini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfruini.Click
        Me.Hide()
        FRUTAS.Show()

    End Sub

    Private Sub btnfacini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfacini.Click
        Me.Hide()
        FACTURACION.Show()

    End Sub
    Private Sub btnsalirini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalirini.Click
        If MessageBox.Show("Desea Cerrar el programa?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class