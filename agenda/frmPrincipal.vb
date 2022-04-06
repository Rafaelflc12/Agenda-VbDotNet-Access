Public Class frmPrincipal
#Region "Variáveis"
    Private frmCliente As CadCliente = Nothing
    Private frmConsult As frmConsulta = Nothing
#End Region
    Private Sub mnuCadastro_Click(sender As Object, e As EventArgs) Handles mnuCadastro.Click
        If frmCliente Is Nothing Then
            frmCliente = New CadCliente
            frmCliente.Show()
        Else
            If frmCliente.IsHandleCreated = True Then
                frmCliente.Activate()
            Else
                frmCliente = New CadCliente
                frmCliente.Show()
            End If
        End If
    End Sub

    Private Sub tsbCliente_Click(sender As Object, e As EventArgs) Handles tsbCliente.Click
        mnuCadastro_Click(Nothing, Nothing)
    End Sub

    Private Sub mnuConsulta_Click(sender As Object, e As EventArgs) Handles mnuConsulta.Click
        If frmConsult Is Nothing Then
            frmConsult = New frmConsulta
            frmConsulta.Show()
        Else
            If frmConsulta.IsHandleCreated Then
                frmConsulta.Activate()
            Else
                frmConsult = New frmConsulta
                frmConsult.Show()
            End If
        End If
    End Sub

    Private Sub tsbConsultar_Click(sender As Object, e As EventArgs) Handles tsbIncluir.Click
        mnuConsulta_Click(Nothing, Nothing)
    End Sub
End Class