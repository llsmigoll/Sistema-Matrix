﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabCadastraOrdem = New System.Windows.Forms.TabPage()
        Me.lblDescricaoOS = New System.Windows.Forms.Label()
        Me.txtDescricaoOS = New System.Windows.Forms.RichTextBox()
        Me.lblInserir = New System.Windows.Forms.Label()
        Me.grpServico = New System.Windows.Forms.GroupBox()
        Me.cboCodServico = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQtde = New System.Windows.Forms.TextBox()
        Me.botNovoServico = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescrição = New System.Windows.Forms.RichTextBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.cboServico = New System.Windows.Forms.ComboBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.mtxDataFechamento = New System.Windows.Forms.MaskedTextBox()
        Me.lblCadastrar = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.botModoNovo = New System.Windows.Forms.Button()
        Me.mtxDataAbertura = New System.Windows.Forms.MaskedTextBox()
        Me.lblAlterar = New System.Windows.Forms.Label()
        Me.lblDataAbertura = New System.Windows.Forms.Label()
        Me.lblExcluir = New System.Windows.Forms.Label()
        Me.grpFuncionario = New System.Windows.Forms.GroupBox()
        Me.cboCodFuncionario = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.cboFuncionario = New System.Windows.Forms.ComboBox()
        Me.botExcluir = New System.Windows.Forms.Button()
        Me.grpCliente = New System.Windows.Forms.GroupBox()
        Me.lblRazaoSocial = New System.Windows.Forms.Label()
        Me.txtRazaoSocial = New System.Windows.Forms.TextBox()
        Me.cboCodCliente = New System.Windows.Forms.ComboBox()
        Me.lblIM = New System.Windows.Forms.Label()
        Me.txtIM = New System.Windows.Forms.TextBox()
        Me.mtxTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.mtxCEP = New System.Windows.Forms.MaskedTextBox()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtUF = New System.Windows.Forms.TextBox()
        Me.txtNumEndereco = New System.Windows.Forms.TextBox()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.lblUF = New System.Windows.Forms.Label()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.lblCEP = New System.Windows.Forms.Label()
        Me.lblNumEndereco = New System.Windows.Forms.Label()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.lblSelecionar = New System.Windows.Forms.Label()
        Me.lblCPF = New System.Windows.Forms.Label()
        Me.mtxRG = New System.Windows.Forms.MaskedTextBox()
        Me.mtxCPF = New System.Windows.Forms.MaskedTextBox()
        Me.lblCNPJ = New System.Windows.Forms.Label()
        Me.mtxCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.lblIE = New System.Windows.Forms.Label()
        Me.mtxIE = New System.Windows.Forms.MaskedTextBox()
        Me.lblRG = New System.Windows.Forms.Label()
        Me.botLimpar = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.botAlterar = New System.Windows.Forms.Button()
        Me.botCadastrar = New System.Windows.Forms.Button()
        Me.lblLimpar = New System.Windows.Forms.Label()
        Me.tabConsultaOrdem = New System.Windows.Forms.TabPage()
        Me.dtgOrdemServico = New System.Windows.Forms.DataGridView()
        Me.colCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabOrdemServico = New System.Windows.Forms.TabControl()
        Me.tabCadastraOrdem.SuspendLayout()
        Me.grpServico.SuspendLayout()
        Me.grpFuncionario.SuspendLayout()
        Me.grpCliente.SuspendLayout()
        Me.tabConsultaOrdem.SuspendLayout()
        CType(Me.dtgOrdemServico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOrdemServico.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabCadastraOrdem
        '
        Me.tabCadastraOrdem.Controls.Add(Me.lblDescricaoOS)
        Me.tabCadastraOrdem.Controls.Add(Me.txtDescricaoOS)
        Me.tabCadastraOrdem.Controls.Add(Me.lblInserir)
        Me.tabCadastraOrdem.Controls.Add(Me.grpServico)
        Me.tabCadastraOrdem.Controls.Add(Me.mtxDataFechamento)
        Me.tabCadastraOrdem.Controls.Add(Me.lblCadastrar)
        Me.tabCadastraOrdem.Controls.Add(Me.Label3)
        Me.tabCadastraOrdem.Controls.Add(Me.botModoNovo)
        Me.tabCadastraOrdem.Controls.Add(Me.mtxDataAbertura)
        Me.tabCadastraOrdem.Controls.Add(Me.lblAlterar)
        Me.tabCadastraOrdem.Controls.Add(Me.lblDataAbertura)
        Me.tabCadastraOrdem.Controls.Add(Me.lblExcluir)
        Me.tabCadastraOrdem.Controls.Add(Me.grpFuncionario)
        Me.tabCadastraOrdem.Controls.Add(Me.botExcluir)
        Me.tabCadastraOrdem.Controls.Add(Me.grpCliente)
        Me.tabCadastraOrdem.Controls.Add(Me.botLimpar)
        Me.tabCadastraOrdem.Controls.Add(Me.txtCodigo)
        Me.tabCadastraOrdem.Controls.Add(Me.Label1)
        Me.tabCadastraOrdem.Controls.Add(Me.botAlterar)
        Me.tabCadastraOrdem.Controls.Add(Me.botCadastrar)
        Me.tabCadastraOrdem.Controls.Add(Me.lblLimpar)
        Me.tabCadastraOrdem.Location = New System.Drawing.Point(4, 22)
        Me.tabCadastraOrdem.Name = "tabCadastraOrdem"
        Me.tabCadastraOrdem.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCadastraOrdem.Size = New System.Drawing.Size(722, 633)
        Me.tabCadastraOrdem.TabIndex = 1
        Me.tabCadastraOrdem.Text = "Detalhe Ordem"
        Me.tabCadastraOrdem.UseVisualStyleBackColor = True
        '
        'lblDescricaoOS
        '
        Me.lblDescricaoOS.AutoSize = True
        Me.lblDescricaoOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescricaoOS.Location = New System.Drawing.Point(267, 68)
        Me.lblDescricaoOS.Name = "lblDescricaoOS"
        Me.lblDescricaoOS.Size = New System.Drawing.Size(183, 20)
        Me.lblDescricaoOS.TabIndex = 91
        Me.lblDescricaoOS.Text = "Descrição da Ocorrência"
        '
        'txtDescricaoOS
        '
        Me.txtDescricaoOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescricaoOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricaoOS.Location = New System.Drawing.Point(271, 91)
        Me.txtDescricaoOS.Name = "txtDescricaoOS"
        Me.txtDescricaoOS.Size = New System.Drawing.Size(421, 80)
        Me.txtDescricaoOS.TabIndex = 90
        Me.txtDescricaoOS.TabStop = False
        Me.txtDescricaoOS.Text = ""
        '
        'lblInserir
        '
        Me.lblInserir.AutoSize = True
        Me.lblInserir.Location = New System.Drawing.Point(193, 46)
        Me.lblInserir.Name = "lblInserir"
        Me.lblInserir.Size = New System.Drawing.Size(65, 13)
        Me.lblInserir.TabIndex = 88
        Me.lblInserir.Text = "Modo Inserir"
        Me.lblInserir.Visible = False
        '
        'grpServico
        '
        Me.grpServico.Controls.Add(Me.cboCodServico)
        Me.grpServico.Controls.Add(Me.Label5)
        Me.grpServico.Controls.Add(Me.txtQtde)
        Me.grpServico.Controls.Add(Me.botNovoServico)
        Me.grpServico.Controls.Add(Me.Label4)
        Me.grpServico.Controls.Add(Me.txtDescrição)
        Me.grpServico.Controls.Add(Me.lblValor)
        Me.grpServico.Controls.Add(Me.cboServico)
        Me.grpServico.Controls.Add(Me.txtValor)
        Me.grpServico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpServico.Location = New System.Drawing.Point(8, 507)
        Me.grpServico.Name = "grpServico"
        Me.grpServico.Size = New System.Drawing.Size(695, 114)
        Me.grpServico.TabIndex = 63
        Me.grpServico.TabStop = False
        Me.grpServico.Text = "Serviços"
        '
        'cboCodServico
        '
        Me.cboCodServico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCodServico.FormattingEnabled = True
        Me.cboCodServico.Location = New System.Drawing.Point(57, 67)
        Me.cboCodServico.Name = "cboCodServico"
        Me.cboCodServico.Size = New System.Drawing.Size(121, 21)
        Me.cboCodServico.TabIndex = 74
        Me.cboCodServico.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(415, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Qtde."
        '
        'txtQtde
        '
        Me.txtQtde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtde.Location = New System.Drawing.Point(419, 38)
        Me.txtQtde.Name = "txtQtde"
        Me.txtQtde.Size = New System.Drawing.Size(39, 20)
        Me.txtQtde.TabIndex = 3
        Me.txtQtde.Tag = ""
        '
        'botNovoServico
        '
        Me.botNovoServico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botNovoServico.Location = New System.Drawing.Point(4, 65)
        Me.botNovoServico.Name = "botNovoServico"
        Me.botNovoServico.Size = New System.Drawing.Size(42, 23)
        Me.botNovoServico.TabIndex = 73
        Me.botNovoServico.Text = "Novo"
        Me.botNovoServico.UseVisualStyleBackColor = True
        Me.botNovoServico.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(470, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Descrição"
        '
        'txtDescrição
        '
        Me.txtDescrição.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescrição.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescrição.Location = New System.Drawing.Point(468, 37)
        Me.txtDescrição.Name = "txtDescrição"
        Me.txtDescrição.Size = New System.Drawing.Size(216, 56)
        Me.txtDescrição.TabIndex = 77
        Me.txtDescrição.TabStop = False
        Me.txtDescrição.Tag = "Auto"
        Me.txtDescrição.Text = ""
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor.Location = New System.Drawing.Point(303, 15)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(46, 20)
        Me.lblValor.TabIndex = 73
        Me.lblValor.Text = "Valor"
        '
        'cboServico
        '
        Me.cboServico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboServico.FormattingEnabled = True
        Me.cboServico.Location = New System.Drawing.Point(6, 38)
        Me.cboServico.Name = "cboServico"
        Me.cboServico.Size = New System.Drawing.Size(289, 21)
        Me.cboServico.TabIndex = 2
        Me.cboServico.Tag = "Não"
        '
        'txtValor
        '
        Me.txtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(308, 39)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(95, 20)
        Me.txtValor.TabIndex = 74
        Me.txtValor.TabStop = False
        Me.txtValor.Tag = "Auto"
        '
        'mtxDataFechamento
        '
        Me.mtxDataFechamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxDataFechamento.Location = New System.Drawing.Point(95, 142)
        Me.mtxDataFechamento.Mask = "00/00/0000"
        Me.mtxDataFechamento.Name = "mtxDataFechamento"
        Me.mtxDataFechamento.Size = New System.Drawing.Size(76, 20)
        Me.mtxDataFechamento.TabIndex = 4
        '
        'lblCadastrar
        '
        Me.lblCadastrar.AutoSize = True
        Me.lblCadastrar.Location = New System.Drawing.Point(26, 46)
        Me.lblCadastrar.Name = "lblCadastrar"
        Me.lblCadastrar.Size = New System.Drawing.Size(52, 13)
        Me.lblCadastrar.TabIndex = 85
        Me.lblCadastrar.Text = "Cadastrar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(91, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 20)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Data de Fechamento"
        '
        'botModoNovo
        '
        Me.botModoNovo.Image = Global.Sistema_Matrix.My.Resources.Resources.adicionar
        Me.botModoNovo.Location = New System.Drawing.Point(201, 3)
        Me.botModoNovo.Name = "botModoNovo"
        Me.botModoNovo.Size = New System.Drawing.Size(40, 40)
        Me.botModoNovo.TabIndex = 84
        Me.botModoNovo.UseVisualStyleBackColor = True
        Me.botModoNovo.Visible = False
        '
        'mtxDataAbertura
        '
        Me.mtxDataAbertura.Enabled = False
        Me.mtxDataAbertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxDataAbertura.Location = New System.Drawing.Point(95, 91)
        Me.mtxDataAbertura.Mask = "00/00/0000"
        Me.mtxDataAbertura.Name = "mtxDataAbertura"
        Me.mtxDataAbertura.Size = New System.Drawing.Size(76, 20)
        Me.mtxDataAbertura.TabIndex = 60
        Me.mtxDataAbertura.Tag = "Auto"
        '
        'lblAlterar
        '
        Me.lblAlterar.AutoSize = True
        Me.lblAlterar.Location = New System.Drawing.Point(15, 46)
        Me.lblAlterar.Name = "lblAlterar"
        Me.lblAlterar.Size = New System.Drawing.Size(79, 13)
        Me.lblAlterar.TabIndex = 89
        Me.lblAlterar.Text = "Alterar Registro"
        Me.lblAlterar.Visible = False
        '
        'lblDataAbertura
        '
        Me.lblDataAbertura.AutoSize = True
        Me.lblDataAbertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataAbertura.Location = New System.Drawing.Point(91, 68)
        Me.lblDataAbertura.Name = "lblDataAbertura"
        Me.lblDataAbertura.Size = New System.Drawing.Size(132, 20)
        Me.lblDataAbertura.TabIndex = 59
        Me.lblDataAbertura.Text = "Data de Abertura"
        '
        'lblExcluir
        '
        Me.lblExcluir.AutoSize = True
        Me.lblExcluir.Location = New System.Drawing.Point(103, 46)
        Me.lblExcluir.Name = "lblExcluir"
        Me.lblExcluir.Size = New System.Drawing.Size(80, 13)
        Me.lblExcluir.TabIndex = 87
        Me.lblExcluir.Text = "Excluir Registro"
        Me.lblExcluir.Visible = False
        '
        'grpFuncionario
        '
        Me.grpFuncionario.Controls.Add(Me.cboCodFuncionario)
        Me.grpFuncionario.Controls.Add(Me.Label2)
        Me.grpFuncionario.Controls.Add(Me.txtCargo)
        Me.grpFuncionario.Controls.Add(Me.cboFuncionario)
        Me.grpFuncionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFuncionario.Location = New System.Drawing.Point(8, 419)
        Me.grpFuncionario.Name = "grpFuncionario"
        Me.grpFuncionario.Size = New System.Drawing.Size(695, 80)
        Me.grpFuncionario.TabIndex = 49
        Me.grpFuncionario.TabStop = False
        Me.grpFuncionario.Text = "Funcionário"
        '
        'cboCodFuncionario
        '
        Me.cboCodFuncionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCodFuncionario.FormattingEnabled = True
        Me.cboCodFuncionario.Location = New System.Drawing.Point(310, 13)
        Me.cboCodFuncionario.Name = "cboCodFuncionario"
        Me.cboCodFuncionario.Size = New System.Drawing.Size(121, 21)
        Me.cboCodFuncionario.TabIndex = 73
        Me.cboCodFuncionario.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(439, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Cargo"
        '
        'txtCargo
        '
        Me.txtCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargo.Location = New System.Drawing.Point(443, 38)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(246, 20)
        Me.txtCargo.TabIndex = 72
        Me.txtCargo.TabStop = False
        Me.txtCargo.Tag = "Auto"
        '
        'cboFuncionario
        '
        Me.cboFuncionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFuncionario.FormattingEnabled = True
        Me.cboFuncionario.Location = New System.Drawing.Point(6, 37)
        Me.cboFuncionario.Name = "cboFuncionario"
        Me.cboFuncionario.Size = New System.Drawing.Size(289, 21)
        Me.cboFuncionario.TabIndex = 1
        Me.cboFuncionario.Tag = "Não"
        '
        'botExcluir
        '
        Me.botExcluir.Enabled = False
        Me.botExcluir.Image = Global.Sistema_Matrix.My.Resources.Resources.excluir
        Me.botExcluir.Location = New System.Drawing.Point(115, 3)
        Me.botExcluir.Name = "botExcluir"
        Me.botExcluir.Size = New System.Drawing.Size(40, 40)
        Me.botExcluir.TabIndex = 83
        Me.botExcluir.UseVisualStyleBackColor = True
        Me.botExcluir.Visible = False
        '
        'grpCliente
        '
        Me.grpCliente.Controls.Add(Me.lblRazaoSocial)
        Me.grpCliente.Controls.Add(Me.txtRazaoSocial)
        Me.grpCliente.Controls.Add(Me.cboCodCliente)
        Me.grpCliente.Controls.Add(Me.lblIM)
        Me.grpCliente.Controls.Add(Me.txtIM)
        Me.grpCliente.Controls.Add(Me.mtxTelefone)
        Me.grpCliente.Controls.Add(Me.mtxCEP)
        Me.grpCliente.Controls.Add(Me.lblTelefone)
        Me.grpCliente.Controls.Add(Me.txtBairro)
        Me.grpCliente.Controls.Add(Me.lblComplemento)
        Me.grpCliente.Controls.Add(Me.txtCidade)
        Me.grpCliente.Controls.Add(Me.txtUF)
        Me.grpCliente.Controls.Add(Me.txtNumEndereco)
        Me.grpCliente.Controls.Add(Me.txtComplemento)
        Me.grpCliente.Controls.Add(Me.txtEndereco)
        Me.grpCliente.Controls.Add(Me.lblUF)
        Me.grpCliente.Controls.Add(Me.lblCidade)
        Me.grpCliente.Controls.Add(Me.lblCEP)
        Me.grpCliente.Controls.Add(Me.lblNumEndereco)
        Me.grpCliente.Controls.Add(Me.lblBairro)
        Me.grpCliente.Controls.Add(Me.lblEndereco)
        Me.grpCliente.Controls.Add(Me.cboCliente)
        Me.grpCliente.Controls.Add(Me.lblSelecionar)
        Me.grpCliente.Controls.Add(Me.lblCPF)
        Me.grpCliente.Controls.Add(Me.mtxRG)
        Me.grpCliente.Controls.Add(Me.mtxCPF)
        Me.grpCliente.Controls.Add(Me.lblCNPJ)
        Me.grpCliente.Controls.Add(Me.mtxCNPJ)
        Me.grpCliente.Controls.Add(Me.lblIE)
        Me.grpCliente.Controls.Add(Me.mtxIE)
        Me.grpCliente.Controls.Add(Me.lblRG)
        Me.grpCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCliente.Location = New System.Drawing.Point(8, 168)
        Me.grpCliente.Name = "grpCliente"
        Me.grpCliente.Size = New System.Drawing.Size(695, 240)
        Me.grpCliente.TabIndex = 48
        Me.grpCliente.TabStop = False
        Me.grpCliente.Text = "Cliente"
        '
        'lblRazaoSocial
        '
        Me.lblRazaoSocial.AutoSize = True
        Me.lblRazaoSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazaoSocial.Location = New System.Drawing.Point(465, 174)
        Me.lblRazaoSocial.Name = "lblRazaoSocial"
        Me.lblRazaoSocial.Size = New System.Drawing.Size(103, 20)
        Me.lblRazaoSocial.TabIndex = 72
        Me.lblRazaoSocial.Text = "Razão Social"
        Me.lblRazaoSocial.Visible = False
        '
        'txtRazaoSocial
        '
        Me.txtRazaoSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazaoSocial.Location = New System.Drawing.Point(468, 198)
        Me.txtRazaoSocial.Name = "txtRazaoSocial"
        Me.txtRazaoSocial.Size = New System.Drawing.Size(216, 20)
        Me.txtRazaoSocial.TabIndex = 71
        Me.txtRazaoSocial.TabStop = False
        Me.txtRazaoSocial.Tag = "Auto"
        Me.txtRazaoSocial.Visible = False
        '
        'cboCodCliente
        '
        Me.cboCodCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCodCliente.FormattingEnabled = True
        Me.cboCodCliente.Location = New System.Drawing.Point(443, 49)
        Me.cboCodCliente.Name = "cboCodCliente"
        Me.cboCodCliente.Size = New System.Drawing.Size(121, 21)
        Me.cboCodCliente.TabIndex = 70
        Me.cboCodCliente.Visible = False
        '
        'lblIM
        '
        Me.lblIM.AutoSize = True
        Me.lblIM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIM.Location = New System.Drawing.Point(307, 174)
        Me.lblIM.Name = "lblIM"
        Me.lblIM.Size = New System.Drawing.Size(27, 20)
        Me.lblIM.TabIndex = 68
        Me.lblIM.Text = "IM"
        Me.lblIM.Visible = False
        '
        'txtIM
        '
        Me.txtIM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIM.Location = New System.Drawing.Point(310, 198)
        Me.txtIM.Name = "txtIM"
        Me.txtIM.Size = New System.Drawing.Size(140, 20)
        Me.txtIM.TabIndex = 67
        Me.txtIM.TabStop = False
        Me.txtIM.Tag = "Auto"
        Me.txtIM.Visible = False
        '
        'mtxTelefone
        '
        Me.mtxTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxTelefone.Location = New System.Drawing.Point(486, 151)
        Me.mtxTelefone.Mask = "(00)0000-0000"
        Me.mtxTelefone.Name = "mtxTelefone"
        Me.mtxTelefone.Size = New System.Drawing.Size(100, 20)
        Me.mtxTelefone.TabIndex = 60
        Me.mtxTelefone.TabStop = False
        Me.mtxTelefone.Tag = "Auto"
        '
        'mtxCEP
        '
        Me.mtxCEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxCEP.Location = New System.Drawing.Point(485, 101)
        Me.mtxCEP.Mask = "00000-000"
        Me.mtxCEP.Name = "mtxCEP"
        Me.mtxCEP.Size = New System.Drawing.Size(100, 20)
        Me.mtxCEP.TabIndex = 59
        Me.mtxCEP.TabStop = False
        Me.mtxCEP.Tag = "Auto"
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefone.Location = New System.Drawing.Point(489, 128)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(71, 20)
        Me.lblTelefone.TabIndex = 58
        Me.lblTelefone.Text = "Telefone"
        '
        'txtBairro
        '
        Me.txtBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBairro.Location = New System.Drawing.Point(6, 151)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(172, 20)
        Me.txtBairro.TabIndex = 57
        Me.txtBairro.TabStop = False
        Me.txtBairro.Tag = "Auto"
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComplemento.Location = New System.Drawing.Point(359, 80)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(108, 20)
        Me.lblComplemento.TabIndex = 56
        Me.lblComplemento.Text = "Complemento"
        '
        'txtCidade
        '
        Me.txtCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCidade.Location = New System.Drawing.Point(184, 151)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(233, 20)
        Me.txtCidade.TabIndex = 55
        Me.txtCidade.TabStop = False
        Me.txtCidade.Tag = "Auto"
        '
        'txtUF
        '
        Me.txtUF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUF.Location = New System.Drawing.Point(423, 151)
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Size = New System.Drawing.Size(42, 20)
        Me.txtUF.TabIndex = 54
        Me.txtUF.TabStop = False
        Me.txtUF.Tag = "Auto"
        '
        'txtNumEndereco
        '
        Me.txtNumEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumEndereco.Location = New System.Drawing.Point(308, 103)
        Me.txtNumEndereco.Name = "txtNumEndereco"
        Me.txtNumEndereco.Size = New System.Drawing.Size(49, 20)
        Me.txtNumEndereco.TabIndex = 53
        Me.txtNumEndereco.TabStop = False
        Me.txtNumEndereco.Tag = "Auto"
        '
        'txtComplemento
        '
        Me.txtComplemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComplemento.Location = New System.Drawing.Point(363, 103)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(104, 20)
        Me.txtComplemento.TabIndex = 51
        Me.txtComplemento.TabStop = False
        Me.txtComplemento.Tag = "Auto"
        '
        'txtEndereco
        '
        Me.txtEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndereco.Location = New System.Drawing.Point(6, 103)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(296, 20)
        Me.txtEndereco.TabIndex = 50
        Me.txtEndereco.TabStop = False
        Me.txtEndereco.Tag = "Auto"
        '
        'lblUF
        '
        Me.lblUF.AutoSize = True
        Me.lblUF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUF.Location = New System.Drawing.Point(419, 128)
        Me.lblUF.Name = "lblUF"
        Me.lblUF.Size = New System.Drawing.Size(31, 20)
        Me.lblUF.TabIndex = 49
        Me.lblUF.Text = "UF"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCidade.Location = New System.Drawing.Point(180, 128)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(59, 20)
        Me.lblCidade.TabIndex = 48
        Me.lblCidade.Text = "Cidade"
        '
        'lblCEP
        '
        Me.lblCEP.AutoSize = True
        Me.lblCEP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCEP.Location = New System.Drawing.Point(489, 80)
        Me.lblCEP.Name = "lblCEP"
        Me.lblCEP.Size = New System.Drawing.Size(38, 20)
        Me.lblCEP.TabIndex = 47
        Me.lblCEP.Text = "Cep"
        '
        'lblNumEndereco
        '
        Me.lblNumEndereco.AutoSize = True
        Me.lblNumEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumEndereco.Location = New System.Drawing.Point(306, 80)
        Me.lblNumEndereco.Name = "lblNumEndereco"
        Me.lblNumEndereco.Size = New System.Drawing.Size(26, 20)
        Me.lblNumEndereco.TabIndex = 46
        Me.lblNumEndereco.Text = "Nº"
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBairro.Location = New System.Drawing.Point(10, 128)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(51, 20)
        Me.lblBairro.TabIndex = 45
        Me.lblBairro.Text = "Bairro"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndereco.Location = New System.Drawing.Point(6, 80)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(78, 20)
        Me.lblEndereco.TabIndex = 44
        Me.lblEndereco.Text = "Endereço"
        '
        'cboCliente
        '
        Me.cboCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(6, 49)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(289, 21)
        Me.cboCliente.TabIndex = 0
        Me.cboCliente.Tag = "Não"
        '
        'lblSelecionar
        '
        Me.lblSelecionar.AutoSize = True
        Me.lblSelecionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelecionar.Location = New System.Drawing.Point(6, 26)
        Me.lblSelecionar.Name = "lblSelecionar"
        Me.lblSelecionar.Size = New System.Drawing.Size(145, 20)
        Me.lblSelecionar.TabIndex = 1
        Me.lblSelecionar.Text = "Selecione o Cliente"
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPF.Location = New System.Drawing.Point(6, 178)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(40, 20)
        Me.lblCPF.TabIndex = 9
        Me.lblCPF.Text = "CPF"
        '
        'mtxRG
        '
        Me.mtxRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxRG.Location = New System.Drawing.Point(172, 198)
        Me.mtxRG.Mask = "00,000,000-0"
        Me.mtxRG.Name = "mtxRG"
        Me.mtxRG.Size = New System.Drawing.Size(130, 20)
        Me.mtxRG.TabIndex = 62
        Me.mtxRG.TabStop = False
        Me.mtxRG.Tag = "Auto"
        '
        'mtxCPF
        '
        Me.mtxCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxCPF.Location = New System.Drawing.Point(10, 198)
        Me.mtxCPF.Mask = "000,000,000-00"
        Me.mtxCPF.Name = "mtxCPF"
        Me.mtxCPF.Size = New System.Drawing.Size(130, 20)
        Me.mtxCPF.TabIndex = 61
        Me.mtxCPF.TabStop = False
        Me.mtxCPF.Tag = "Auto"
        '
        'lblCNPJ
        '
        Me.lblCNPJ.AutoSize = True
        Me.lblCNPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCNPJ.Location = New System.Drawing.Point(10, 175)
        Me.lblCNPJ.Name = "lblCNPJ"
        Me.lblCNPJ.Size = New System.Drawing.Size(49, 20)
        Me.lblCNPJ.TabIndex = 63
        Me.lblCNPJ.Text = "CNPJ"
        Me.lblCNPJ.Visible = False
        '
        'mtxCNPJ
        '
        Me.mtxCNPJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxCNPJ.Location = New System.Drawing.Point(10, 198)
        Me.mtxCNPJ.Mask = "00.000.000/0000-00"
        Me.mtxCNPJ.Name = "mtxCNPJ"
        Me.mtxCNPJ.Size = New System.Drawing.Size(130, 20)
        Me.mtxCNPJ.TabIndex = 65
        Me.mtxCNPJ.TabStop = False
        Me.mtxCNPJ.Visible = False
        '
        'lblIE
        '
        Me.lblIE.AutoSize = True
        Me.lblIE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIE.Location = New System.Drawing.Point(168, 174)
        Me.lblIE.Name = "lblIE"
        Me.lblIE.Size = New System.Drawing.Size(25, 20)
        Me.lblIE.TabIndex = 64
        Me.lblIE.Text = "IE"
        Me.lblIE.Visible = False
        '
        'mtxIE
        '
        Me.mtxIE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxIE.Location = New System.Drawing.Point(172, 198)
        Me.mtxIE.Mask = "000.000.000.000"
        Me.mtxIE.Name = "mtxIE"
        Me.mtxIE.Size = New System.Drawing.Size(130, 20)
        Me.mtxIE.TabIndex = 66
        Me.mtxIE.TabStop = False
        Me.mtxIE.Visible = False
        '
        'lblRG
        '
        Me.lblRG.AutoSize = True
        Me.lblRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRG.Location = New System.Drawing.Point(168, 174)
        Me.lblRG.Name = "lblRG"
        Me.lblRG.Size = New System.Drawing.Size(34, 20)
        Me.lblRG.TabIndex = 10
        Me.lblRG.Text = "RG"
        '
        'botLimpar
        '
        Me.botLimpar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.botLimpar.Image = Global.Sistema_Matrix.My.Resources.Resources.limpar
        Me.botLimpar.Location = New System.Drawing.Point(115, 3)
        Me.botLimpar.Name = "botLimpar"
        Me.botLimpar.Size = New System.Drawing.Size(40, 40)
        Me.botLimpar.TabIndex = 81
        Me.botLimpar.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(8, 91)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(63, 20)
        Me.txtCodigo.TabIndex = 21
        Me.txtCodigo.Tag = "Auto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'botAlterar
        '
        Me.botAlterar.Image = Global.Sistema_Matrix.My.Resources.Resources.alterar
        Me.botAlterar.Location = New System.Drawing.Point(31, 3)
        Me.botAlterar.Name = "botAlterar"
        Me.botAlterar.Size = New System.Drawing.Size(40, 40)
        Me.botAlterar.TabIndex = 82
        Me.botAlterar.UseVisualStyleBackColor = True
        Me.botAlterar.Visible = False
        '
        'botCadastrar
        '
        Me.botCadastrar.Image = Global.Sistema_Matrix.My.Resources.Resources.salvar
        Me.botCadastrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.botCadastrar.Location = New System.Drawing.Point(31, 3)
        Me.botCadastrar.Name = "botCadastrar"
        Me.botCadastrar.Size = New System.Drawing.Size(40, 40)
        Me.botCadastrar.TabIndex = 80
        Me.botCadastrar.UseVisualStyleBackColor = True
        '
        'lblLimpar
        '
        Me.lblLimpar.AutoSize = True
        Me.lblLimpar.Location = New System.Drawing.Point(103, 46)
        Me.lblLimpar.Name = "lblLimpar"
        Me.lblLimpar.Size = New System.Drawing.Size(66, 13)
        Me.lblLimpar.TabIndex = 86
        Me.lblLimpar.Text = "Limpar Tudo"
        '
        'tabConsultaOrdem
        '
        Me.tabConsultaOrdem.Controls.Add(Me.dtgOrdemServico)
        Me.tabConsultaOrdem.Location = New System.Drawing.Point(4, 22)
        Me.tabConsultaOrdem.Name = "tabConsultaOrdem"
        Me.tabConsultaOrdem.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConsultaOrdem.Size = New System.Drawing.Size(722, 633)
        Me.tabConsultaOrdem.TabIndex = 0
        Me.tabConsultaOrdem.Text = "Consulta"
        Me.tabConsultaOrdem.UseVisualStyleBackColor = True
        '
        'dtgOrdemServico
        '
        Me.dtgOrdemServico.AllowUserToAddRows = False
        Me.dtgOrdemServico.AllowUserToDeleteRows = False
        Me.dtgOrdemServico.AllowUserToOrderColumns = True
        Me.dtgOrdemServico.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dtgOrdemServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgOrdemServico.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCodigo, Me.colCliente, Me.colStatus, Me.colTipo})
        Me.dtgOrdemServico.Location = New System.Drawing.Point(6, 82)
        Me.dtgOrdemServico.Name = "dtgOrdemServico"
        Me.dtgOrdemServico.ReadOnly = True
        Me.dtgOrdemServico.Size = New System.Drawing.Size(696, 530)
        Me.dtgOrdemServico.TabIndex = 0
        '
        'colCodigo
        '
        Me.colCodigo.HeaderText = "Código"
        Me.colCodigo.MinimumWidth = 50
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.ReadOnly = True
        Me.colCodigo.Width = 50
        '
        'colCliente
        '
        Me.colCliente.HeaderText = "Cliente"
        Me.colCliente.MinimumWidth = 150
        Me.colCliente.Name = "colCliente"
        Me.colCliente.ReadOnly = True
        Me.colCliente.Width = 250
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.MinimumWidth = 70
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        Me.colStatus.Width = 150
        '
        'colTipo
        '
        Me.colTipo.HeaderText = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.ReadOnly = True
        Me.colTipo.Visible = False
        '
        'tabOrdemServico
        '
        Me.tabOrdemServico.Controls.Add(Me.tabCadastraOrdem)
        Me.tabOrdemServico.Controls.Add(Me.tabConsultaOrdem)
        Me.tabOrdemServico.Location = New System.Drawing.Point(12, 12)
        Me.tabOrdemServico.Name = "tabOrdemServico"
        Me.tabOrdemServico.SelectedIndex = 0
        Me.tabOrdemServico.Size = New System.Drawing.Size(730, 659)
        Me.tabOrdemServico.TabIndex = 1
        '
        'Form6
        '
        Me.AcceptButton = Me.botCadastrar
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.CancelButton = Me.botLimpar
        Me.ClientSize = New System.Drawing.Size(754, 683)
        Me.Controls.Add(Me.tabOrdemServico)
        Me.MaximumSize = New System.Drawing.Size(770, 721)
        Me.Name = "Form6"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordem Serviços"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tabCadastraOrdem.ResumeLayout(False)
        Me.tabCadastraOrdem.PerformLayout()
        Me.grpServico.ResumeLayout(False)
        Me.grpServico.PerformLayout()
        Me.grpFuncionario.ResumeLayout(False)
        Me.grpFuncionario.PerformLayout()
        Me.grpCliente.ResumeLayout(False)
        Me.grpCliente.PerformLayout()
        Me.tabConsultaOrdem.ResumeLayout(False)
        CType(Me.dtgOrdemServico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOrdemServico.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabCadastraOrdem As System.Windows.Forms.TabPage
    Friend WithEvents grpServico As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtQtde As System.Windows.Forms.TextBox
    Friend WithEvents botNovoServico As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDescrição As System.Windows.Forms.RichTextBox
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents cboServico As System.Windows.Forms.ComboBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents mtxDataFechamento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mtxDataAbertura As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblDataAbertura As System.Windows.Forms.Label
    Friend WithEvents grpFuncionario As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents cboFuncionario As System.Windows.Forms.ComboBox
    Friend WithEvents grpCliente As System.Windows.Forms.GroupBox
    Friend WithEvents lblIM As System.Windows.Forms.Label
    Friend WithEvents txtIM As System.Windows.Forms.TextBox
    Friend WithEvents lblIE As System.Windows.Forms.Label
    Friend WithEvents lblCNPJ As System.Windows.Forms.Label
    Friend WithEvents mtxTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxCEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblTelefone As System.Windows.Forms.Label
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents lblComplemento As System.Windows.Forms.Label
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents txtUF As System.Windows.Forms.TextBox
    Friend WithEvents txtNumEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtComplemento As System.Windows.Forms.TextBox
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents lblUF As System.Windows.Forms.Label
    Friend WithEvents lblCidade As System.Windows.Forms.Label
    Friend WithEvents lblCEP As System.Windows.Forms.Label
    Friend WithEvents lblNumEndereco As System.Windows.Forms.Label
    Friend WithEvents lblBairro As System.Windows.Forms.Label
    Friend WithEvents lblEndereco As System.Windows.Forms.Label
    Friend WithEvents lblRG As System.Windows.Forms.Label
    Friend WithEvents cboCliente As System.Windows.Forms.ComboBox
    Friend WithEvents lblSelecionar As System.Windows.Forms.Label
    Friend WithEvents lblCPF As System.Windows.Forms.Label
    Friend WithEvents mtxIE As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxCNPJ As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxRG As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabConsultaOrdem As System.Windows.Forms.TabPage
    Friend WithEvents tabOrdemServico As System.Windows.Forms.TabControl
    Friend WithEvents cboCodCliente As System.Windows.Forms.ComboBox
    Friend WithEvents lblRazaoSocial As System.Windows.Forms.Label
    Friend WithEvents txtRazaoSocial As System.Windows.Forms.TextBox
    Friend WithEvents cboCodFuncionario As System.Windows.Forms.ComboBox
    Friend WithEvents cboCodServico As System.Windows.Forms.ComboBox
    Friend WithEvents lblInserir As System.Windows.Forms.Label
    Friend WithEvents lblLimpar As System.Windows.Forms.Label
    Friend WithEvents lblCadastrar As System.Windows.Forms.Label
    Friend WithEvents botModoNovo As System.Windows.Forms.Button
    Friend WithEvents lblAlterar As System.Windows.Forms.Label
    Friend WithEvents lblExcluir As System.Windows.Forms.Label
    Friend WithEvents botExcluir As System.Windows.Forms.Button
    Friend WithEvents botLimpar As System.Windows.Forms.Button
    Friend WithEvents botCadastrar As System.Windows.Forms.Button
    Friend WithEvents botAlterar As System.Windows.Forms.Button
    Friend WithEvents lblDescricaoOS As System.Windows.Forms.Label
    Friend WithEvents txtDescricaoOS As System.Windows.Forms.RichTextBox
    Friend WithEvents dtgOrdemServico As System.Windows.Forms.DataGridView
    Friend WithEvents colCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
