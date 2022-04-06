Public Class CAD_CLIENTE
#Region " PROPRIEDADES"
    Public Property CODIGO As String
    Public Property NOME As String
    Public Property CEP As String
    Public Property ENDERECO As String
    Public Property BAIRRO As String
    Public Property COMPLEMENTO As String
    Public Property UF As String
    Public Property TELEFONE As String
    Public Property CEL As String
    Public Property NUMERO As String
#End Region



#Region " variáveis"
    Private DBCon As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; DATA SOURCE=AGENDA.ACCDB")
    Private DBCmd As OleDb.OleDbCommand
    Private DBDa As OleDb.OleDbDataAdapter
    Private objDR As OleDb.OleDbDataReader
    Private Paramns As New List(Of OleDb.OleDbParameter)

#End Region
#Region "funcções e SubRotinas"
    ''' <summary>
    ''' função para consulta e retorno dos dados nas propriedades.
    ''' </summary>
    ''' <param name="Query">Passa o comando sql</param>
    ''' <returns></returns>
    Public Function ExecutaQueryReader(ByVal Query As String) As Boolean
        Dim blnOk As Boolean = False

        Try
            'Abre Conexao
            DBCon.Open()

            'Cria Comando
            DBCmd = New OleDb.OleDbCommand(Query, DBCon)

            'Adiciona os parametros no comando

            Paramns.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            'Limpar lista de parametros

            Paramns.Clear()

            'Executa

            objDR = DBCmd.ExecuteReader

            'Preenche propriedades
            While objDR.Read()
                If Not IsDBNull(objDR("NOME")) Then Me.NOME = objDR("NOME").ToString
                If Not IsDBNull(objDR("CODIGO")) Then Me.CODIGO = objDR("CODIGO").ToString
                If Not IsDBNull(objDR("ENEDERECO")) Then Me.ENDERECO = objDR("ENDERECO").ToString
                If Not IsDBNull(objDR("NUMERO")) Then Me.NUMERO = objDR("NUMERO").ToString
                If Not IsDBNull(objDR("BAIRRO")) Then Me.BAIRRO = objDR("BAIRRO").ToString
                If Not IsDBNull(objDR("COMPLEMENTO")) Then Me.COMPLEMENTO = objDR("COMPLEMENTO").ToString
                If Not IsDBNull(objDR("UF")) Then Me.UF = objDR("UF").ToString
                If Not IsDBNull(objDR("TELEFONE")) Then Me.TELEFONE = objDR("TELEFONE").ToString
                If Not IsDBNull(objDR("CEL")) Then Me.CEL = objDR("CEL").ToString
                If Not IsDBNull(objDR("CEP")) Then Me.CEP = objDR("CEP").ToString
                blnOk = True






            End While
        Catch ex As Exception
            Throw ex
        Finally
            If DBCon.State = ConnectionState.Open Then
                DBCon.Close()
            End If
        End Try


        Return blnOk
    End Function
    ''' <summary>
    ''' função para executar Insert, Update e Delete.
    ''' </summary>
    ''' <param name="sql">Passa o comando SQL</param>
    ''' <returns></returns>
    Public Function ExecutaQuery(ByVal sql As String) As Boolean
        Dim blnOk As Boolean = False

        Try
            'Abre Conexao
            DBCon.Open()

            'Cria Comando
            DBCmd = New OleDb.OleDbCommand(sql, DBCon)

            'Adiciona os parametros no comando

            Paramns.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            'Limpar lista de parametros

            Paramns.Clear()

            'Executa

            blnOk = DBCmd.ExecuteNonQuery




        Catch ex As Exception
            Throw ex
        Finally
            If DBCon.State = ConnectionState.Open Then
                DBCon.Close()
            End If
        End Try


        Return blnOk


    End Function
    ''' <summary>
    ''' Função para executar select com retorno de mais de um resultado 
    ''' </summary>
    ''' <param name="sql">Passa o comando sql.</param>
    ''' <returns></returns>
    Public Function ExecutaQueryDataTable(ByVal sql As String) As DataTable
        Dim dt As New DataTable

        Try
            'Abre Conexao
            DBCon.Open()

            'Cria Comando
            DBCmd = New OleDb.OleDbCommand(sql, DBCon)

            'Adiciona os parametros no comando

            Paramns.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            'Limpar lista de parametros

            Paramns.Clear()

            'Executa

            DBDa = New OleDb.OleDbDataAdapter(DBCmd)

            DBDa.Fill(dt)

        Catch ex As Exception
            Throw ex
        Finally
            If DBCon.State = ConnectionState.Open Then
                DBCon.Close()
            End If
        End Try


        Return dt
    End Function

    Public Sub AddParam(ByVal Nome As String, ByVal valor As Object)
        Dim Novo As New OleDb.OleDbParameter(Nome, valor)
        Paramns.Add(Novo)
    End Sub
#End Region
End Class
