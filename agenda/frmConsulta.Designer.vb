<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsulta
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomePesq = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigoPesq = New System.Windows.Forms.TextBox()
        Me.gbResultPesq = New System.Windows.Forms.GroupBox()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        Me.colCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEndereco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBairro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colComp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTelefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.gbResultPesq.SuspendLayout()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCodigoPesq)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNomePesq)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(748, 84)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar por"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome:"
        '
        'txtNomePesq
        '
        Me.txtNomePesq.Location = New System.Drawing.Point(67, 28)
        Me.txtNomePesq.Name = "txtNomePesq"
        Me.txtNomePesq.Size = New System.Drawing.Size(431, 26)
        Me.txtNomePesq.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(504, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Código:"
        '
        'txtCodigoPesq
        '
        Me.txtCodigoPesq.Location = New System.Drawing.Point(573, 34)
        Me.txtCodigoPesq.Name = "txtCodigoPesq"
        Me.txtCodigoPesq.Size = New System.Drawing.Size(144, 26)
        Me.txtCodigoPesq.TabIndex = 1
        '
        'gbResultPesq
        '
        Me.gbResultPesq.Controls.Add(Me.dgvDados)
        Me.gbResultPesq.Location = New System.Drawing.Point(12, 124)
        Me.gbResultPesq.Name = "gbResultPesq"
        Me.gbResultPesq.Size = New System.Drawing.Size(748, 314)
        Me.gbResultPesq.TabIndex = 3
        Me.gbResultPesq.TabStop = False
        '
        'dgvDados
        '
        Me.dgvDados.AllowUserToAddRows = False
        Me.dgvDados.AllowUserToDeleteRows = False
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCodigo, Me.colNumero, Me.colNome, Me.colCep, Me.colEndereco, Me.colBairro, Me.colUf, Me.colComp, Me.colTelefone, Me.colCel})
        Me.dgvDados.Location = New System.Drawing.Point(12, 13)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.ReadOnly = True
        Me.dgvDados.RowHeadersWidth = 62
        Me.dgvDados.RowTemplate.Height = 28
        Me.dgvDados.Size = New System.Drawing.Size(736, 283)
        Me.dgvDados.TabIndex = 0
        '
        'colCodigo
        '
        Me.colCodigo.DataPropertyName = "Codigo"
        Me.colCodigo.HeaderText = "Código"
        Me.colCodigo.MinimumWidth = 8
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.ReadOnly = True
        Me.colCodigo.Width = 150
        '
        'colNumero
        '
        Me.colNumero.DataPropertyName = "Numero"
        Me.colNumero.HeaderText = "Número"
        Me.colNumero.MinimumWidth = 8
        Me.colNumero.Name = "colNumero"
        Me.colNumero.ReadOnly = True
        Me.colNumero.Width = 150
        '
        'colNome
        '
        Me.colNome.DataPropertyName = "Nome"
        Me.colNome.HeaderText = "Nome"
        Me.colNome.MinimumWidth = 8
        Me.colNome.Name = "colNome"
        Me.colNome.ReadOnly = True
        Me.colNome.Width = 150
        '
        'colCep
        '
        Me.colCep.DataPropertyName = "Cep"
        Me.colCep.HeaderText = "Cep"
        Me.colCep.MinimumWidth = 8
        Me.colCep.Name = "colCep"
        Me.colCep.ReadOnly = True
        Me.colCep.Width = 150
        '
        'colEndereco
        '
        Me.colEndereco.DataPropertyName = "Endereco"
        Me.colEndereco.HeaderText = "Endereço"
        Me.colEndereco.MinimumWidth = 8
        Me.colEndereco.Name = "colEndereco"
        Me.colEndereco.ReadOnly = True
        Me.colEndereco.Width = 150
        '
        'colBairro
        '
        Me.colBairro.DataPropertyName = "Bairro"
        Me.colBairro.HeaderText = "Bairro"
        Me.colBairro.MinimumWidth = 8
        Me.colBairro.Name = "colBairro"
        Me.colBairro.ReadOnly = True
        Me.colBairro.Width = 150
        '
        'colUf
        '
        Me.colUf.DataPropertyName = "UF"
        Me.colUf.HeaderText = "UF"
        Me.colUf.MinimumWidth = 8
        Me.colUf.Name = "colUf"
        Me.colUf.ReadOnly = True
        Me.colUf.Width = 150
        '
        'colComp
        '
        Me.colComp.DataPropertyName = "Complemento"
        Me.colComp.HeaderText = "Complemento"
        Me.colComp.MinimumWidth = 8
        Me.colComp.Name = "colComp"
        Me.colComp.ReadOnly = True
        Me.colComp.Width = 150
        '
        'colTelefone
        '
        Me.colTelefone.DataPropertyName = "Telefone"
        Me.colTelefone.HeaderText = "Telefone"
        Me.colTelefone.MinimumWidth = 8
        Me.colTelefone.Name = "colTelefone"
        Me.colTelefone.ReadOnly = True
        Me.colTelefone.Width = 150
        '
        'colCel
        '
        Me.colCel.DataPropertyName = "Cel"
        Me.colCel.HeaderText = "Cel"
        Me.colCel.MinimumWidth = 8
        Me.colCel.Name = "colCel"
        Me.colCel.ReadOnly = True
        Me.colCel.Width = 150
        '
        'frmConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gbResultPesq)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbResultPesq.ResumeLayout(False)
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCodigoPesq As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNomePesq As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gbResultPesq As GroupBox
    Friend WithEvents dgvDados As DataGridView
    Friend WithEvents colCodigo As DataGridViewTextBoxColumn
    Friend WithEvents colNumero As DataGridViewTextBoxColumn
    Friend WithEvents colNome As DataGridViewTextBoxColumn
    Friend WithEvents colCep As DataGridViewTextBoxColumn
    Friend WithEvents colEndereco As DataGridViewTextBoxColumn
    Friend WithEvents colBairro As DataGridViewTextBoxColumn
    Friend WithEvents colUf As DataGridViewTextBoxColumn
    Friend WithEvents colComp As DataGridViewTextBoxColumn
    Friend WithEvents colTelefone As DataGridViewTextBoxColumn
    Friend WithEvents colCel As DataGridViewTextBoxColumn
End Class
