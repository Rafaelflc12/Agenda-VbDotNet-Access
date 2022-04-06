Public Class CadCliente
#Region "VARIÁVEIS"
    Private Enum Opcao As Integer
        Cancelar = 0
        Incluir = 1
        Editar = 2
        Consultar = 3
    End Enum
    Private intOpcao As Opcao

#End Region
#Region "SubRotinas"

    Private Sub Pesq()

    End Sub
    ''' <summary>
    ''' SubRotina para ativar e desativar os componentes do formulário.
    ''' </summary>
    ''' <param name="Status">True: Ativa os Componentes. False: Desativa os componentes.</param>
    Private Sub AtivaDesativa(ByVal Status As Boolean)
        If Status = False Then
            txtCodigo.Enabled = Status
            btnPesquisa.Enabled = Status
        End If
        txtNome.Enabled = Status
        txtCep.Enabled = Status
        txtEndereco.Enabled = Status
        txtNumero.Enabled = Status
        txtBairro.Enabled = Status
        txtUf.Enabled = Status
        txtComp.Enabled = Status
        txtTelefone.Enabled = Status
        txtCel.Enabled = Status

    End Sub
    ''' <summary>
    ''' SubRotina para cancelar qualquer tipo de operação em execução.
    ''' </summary>
    Private Sub CancelaOperacao()
        If intOpcao = Opcao.Incluir And txtNome.TextLength > 0 Then
            If MessageBox.Show("Você tem certeza que deseja cancelar a inclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If
        ElseIf intOpcao = Opcao.Editar And txtCodigo.Enabled = False Then
            If MessageBox.Show("Você tem certeza que deseja cancelar a alteração?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If
        End If
        'seta tipo operação
        intOpcao = Opcao.Cancelar

            'limpa componenetes
            txtCodigo.Clear()
            txtComp.Clear()
            txtEndereco.Clear()
            txtBairro.Clear()
            txtCel.Clear()
            txtCep.Clear()
            txtNome.Clear()
            txtNumero.Clear()
            txtTelefone.Clear()
            txtUf.Clear()

            'chama subrotina para desativar
            AtivaDesativa(False)
            'configura barra de ferramentas
            tsbIncluir.Enabled = True
            tsbEditar.Enabled = True
            tsbConsultar.Enabled = True
            tsbGravar.Enabled = False
            tsbCancelar.Enabled = False

    End Sub
#End Region
    Private Sub tsbIncluir_Click(sender As Object, e As EventArgs) Handles tsbIncluir.Click
        'Seta tipo de operação  
        intOpcao = Opcao.Incluir

        'Chama subRotina para ativar os componentes
        AtivaDesativa(True)

        'Desativa os botões de controle
        tsbIncluir.Enabled = False
        tsbEditar.Enabled = False
        tsbConsultar.Enabled = False

        'Ativa os botões de controle
        tsbGravar.Enabled = True
        tsbCancelar.Enabled = True

        'Seta focus
        txtNome.Focus()
    End Sub

    Private Sub tsbConcultar_Click(sender As Object, e As EventArgs) Handles tsbConsultar.Click
        'Seta tipo de operação  
        intOpcao = Opcao.Consultar



        'Desativa os botões de controle
        tsbIncluir.Enabled = False
        tsbEditar.Enabled = False
        tsbConsultar.Enabled = False

        'Ativa os botões de controle
        tsbGravar.Enabled = True
        tsbCancelar.Enabled = True
        txtCodigo.Enabled = True
        btnPesquisa.Enabled = True

        'Seta focus
        txtNome.Focus()
    End Sub

    Private Sub tsbEditar_Click(sender As Object, e As EventArgs) Handles tsbEditar.Click
        'Seta tipo de operação  
        intOpcao = Opcao.Editar



        'Desativa os botões de controle
        tsbIncluir.Enabled = False
        tsbEditar.Enabled = False
        tsbConsultar.Enabled = False

        'Ativa os botões de controle
        txtCodigo.Enabled = True
        btnPesquisa.Enabled = True
        tsbCancelar.Enabled = True


        'Seta focus
        txtNome.Focus()
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        'chama subRotina para cancelar
        CancelaOperacao()
    End Sub


    Private Sub tsbSair_Click(sender As Object, e As EventArgs) Handles tsbSair.Click
        Me.Close()

    End Sub

    Private Sub CadCliente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If intOpcao = Opcao.Incluir And txtNome.TextLength > 0 Then
            If MessageBox.Show("Você tem certeza que deseja cancelar a inclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then

                e.Cancel = True
            End If
        ElseIf intOpcao = Opcao.Editar And txtCodigo.Enabled = False Then
            If MessageBox.Show("Você tem certeza que deseja cancelar a alteração?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub CadCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If tsbIncluir.Enabled = True And e.KeyCode = Keys.F2 Then
            tsbIncluir_Click(Nothing, Nothing)
        ElseIf tsbConsultar.Enabled = True And e.KeyCode = Keys.F3 Then
            tsbConcultar_Click(Nothing, Nothing)
        ElseIf tsbEditar.Enabled = True And e.KeyCode = keys.F4 Then
            tsbEditar_Click(Nothing, Nothing)
        ElseIf tsbGravar.Enabled = True And e.KeyCode = Keys.F5 Then
            tsbGravar_Click(Nothing, Nothing)
        ElseIf tsbCancelar.Enabled = True And e.KeyCode = Keys.Escape Then
            tsbCancelar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub tsbGravar_Click(sender As Object, e As EventArgs) Handles tsbGravar.Click
        'Declaração de classe
        Dim obj As New CAD_CLIENTE

        Dim strSQL As New Text.StringBuilder
        Try
            'Preenche dados
            If txtCodigo.TextLength > 0 Then obj.CODIGO = Convert.ToInt32(txtCodigo.Text)
            obj.NOME = txtNome.Text
            obj.CEP = txtCep.Text
            obj.ENDERECO = txtEndereco.Text
            obj.BAIRRO = txtBairro.Text
            obj.UF = txtUf.Text
            obj.NUMERO = txtNumero.Text
            obj.COMPLEMENTO = txtComp.Text
            obj.TELEFONE = txtTelefone.Text
            obj.CEL = txtCel.Text


            'ADICIONA PARAMETROS
            obj.AddParam("@nome", obj.NOME)
            obj.AddParam("@cep", obj.CEP)
            obj.AddParam("@endereco", obj.ENDERECO)
            obj.AddParam("@bairro", obj.BAIRRO)
            obj.AddParam("@uf", obj.UF)
            obj.AddParam("@numero", obj.NUMERO)
            obj.AddParam("@complemento", obj.COMPLEMENTO)
            obj.AddParam("@telefone", obj.TELEFONE)
            obj.AddParam("@cel", obj.CEL)
            Select Case intOpcao
                Case Opcao.Incluir
                    strSQL.Append("INSERT INTO CAD_CLIENTE (NOME, CEP, ENDERECO, BAIRRO, UF, NUMERO, COMPLEMENTO, TELEFONE, CEL) VALUES(")
                    strSQL.Append(" @nome, ")
                    strSQL.Append(" @cep, ")
                    strSQL.Append(" @endereco, ")
                    strSQL.Append(" @bairro, ")
                    strSQL.Append(" @uf, ")
                    strSQL.Append(" @numero, ")
                    strSQL.Append(" @complemento, ")
                    strSQL.Append(" @telefone, ")
                    strSQL.Append(" @cel) ")


                    'INCLUI NO BANCO
                    If obj.ExecutaQuery(strSQL.ToString) = True Then
                        If MessageBox.Show("Cliente incluido com sucesso!" & vbNewLine & "Deseja incluir outro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            'setar operação como cancelar
                            intOpcao = Opcao.Cancelar

                            'chama subrotina para cancelar
                            CancelaOperacao()

                            'chama subrotina para incluir
                            tsbIncluir_Click(Nothing, Nothing)
                        Else
                            'setar operação para como cancelar
                            intOpcao = Opcao.Cancelar

                            'chama subrotina para cancelar
                            CancelaOperacao()
                        End If
                    Else
                        MessageBox.Show("Problema ao tentar gravar dados, tente novamente mais tarde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                        Case Opcao.Editar
                    obj.AddParam("@codigo", obj.CODIGO)

                    'monto o comando update
                    strSQL.Append("UPDATE SET ")
                    strSQL.Append("nome = @nome, ")
                    strSQL.Append("nome = @cep, ")
                    strSQL.Append("endereco = @endereco, ")
                    strSQL.Append("bairro = @bairro, ")
                    strSQL.Append("uf = @uf, ")
                    strSQL.Append("numero = @numero, ")
                    strSQL.Append("complemento = @complemento, ")
                    strSQL.Append("telefone = @telefone, ")
                    strSQL.Append("cel = @cel ")
                    strSQL.Append("WHERE codigo = @codigo ")

                    'atualiza o registro

                    If obj.ExecutaQuery(strSQL.ToString) = True Then
                        If MessageBox.Show("Cliente alterado com sucesso!" & vbNewLine & "Deseja alterar outro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            'setar operação como cancelar
                            intOpcao = Opcao.Cancelar

                            'chama subrotina para cancelar
                            CancelaOperacao()

                            'chama subrotina para alterar
                            tsbEditar_Click(Nothing, Nothing)
                        Else
                            'setar operação para como cancelar
                            intOpcao = Opcao.Cancelar

                            'chama subrotina para cancelar
                            CancelaOperacao()
                        End If
                    Else
                        MessageBox.Show("Problema ao tentar gravar dados, tente novamente mais tarde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro: " & vbNewLine & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            obj = Nothing
        End Try
    End Sub

    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
        If txtCodigo.TextLength > 0 And e.KeyCode = Keys.Enter Then
            'cria a classe
            Dim obj As New CAD_CLIENTE
            Dim strSQL As New Text.StringBuilder
            Try

            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro: " & vbNewLine & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                obj = Nothing
            End Try
        ElseIf txtCodigo.TextLength = 0 Then
        End If
    End Sub
End Class