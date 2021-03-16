namespace EscalasMetodista
{
    partial class FormMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_rodape = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btnPerfil = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnAlterarSenha = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEscalas = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnNovaEscala = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNovaEscalaPersonalizada = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUsuarios = new System.Windows.Forms.ToolStripDropDownButton();
            this.novoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFuncoes = new System.Windows.Forms.ToolStripDropDownButton();
            this.novaFunçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaSubFunçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarFunçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarSubFunçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRelatorios = new System.Windows.Forms.ToolStripDropDownButton();
            this.relatórioDePessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSobre = new System.Windows.Forms.ToolStripButton();
            this.panel_principal = new System.Windows.Forms.Panel();
            this.labelData = new System.Windows.Forms.Label();
            this.labelIdUsuarioLogado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_botoes = new System.Windows.Forms.Panel();
            this.dgEscalas = new System.Windows.Forms.DataGridView();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAlteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtPesquisaEscala = new System.Windows.Forms.TextBox();
            this.logo_metodista = new System.Windows.Forms.PictureBox();
            this.panel_rodape.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.panel_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_botoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEscalas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_metodista)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_rodape
            // 
            this.panel_rodape.BackColor = System.Drawing.Color.Maroon;
            this.panel_rodape.Controls.Add(this.label1);
            this.panel_rodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_rodape.Location = new System.Drawing.Point(0, 653);
            this.panel_rodape.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_rodape.Name = "panel_rodape";
            this.panel_rodape.Size = new System.Drawing.Size(925, 39);
            this.panel_rodape.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(292, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desenvolvido por Matheus Pimentel - 2021";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPerfil,
            this.toolStripSeparator2,
            this.btnEscalas,
            this.toolStripSeparator3,
            this.btnUsuarios,
            this.toolStripSeparator6,
            this.btnFuncoes,
            this.btnSair,
            this.toolStripSeparator4,
            this.btnRelatorios,
            this.toolStripSeparator5,
            this.btnSobre});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(925, 27);
            this.toolStripMenu.TabIndex = 5;
            // 
            // btnPerfil
            // 
            this.btnPerfil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAlterarSenha});
            this.btnPerfil.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPerfil.Image = global::EscalasMetodista.Properties.Resources._1486564400_account_81513;
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(160, 24);
            this.btnPerfil.Text = "Bem vindo(a) !";
            // 
            // btnAlterarSenha
            // 
            this.btnAlterarSenha.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(186, 26);
            this.btnAlterarSenha.Text = "Alterar Senha";
            this.btnAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnEscalas
            // 
            this.btnEscalas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovaEscala,
            this.btnNovaEscalaPersonalizada,
            this.abrirArquivoToolStripMenuItem});
            this.btnEscalas.Image = global::EscalasMetodista.Properties.Resources._1486504829_clipboard_tasks_report_business_checking_verification_list_81387;
            this.btnEscalas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEscalas.Name = "btnEscalas";
            this.btnEscalas.Size = new System.Drawing.Size(90, 24);
            this.btnEscalas.Text = "Escalas";
            // 
            // btnNovaEscala
            // 
            this.btnNovaEscala.Name = "btnNovaEscala";
            this.btnNovaEscala.Size = new System.Drawing.Size(267, 26);
            this.btnNovaEscala.Text = "Nova Escala";
            // 
            // btnNovaEscalaPersonalizada
            // 
            this.btnNovaEscalaPersonalizada.Name = "btnNovaEscalaPersonalizada";
            this.btnNovaEscalaPersonalizada.Size = new System.Drawing.Size(267, 26);
            this.btnNovaEscalaPersonalizada.Text = "Nova Escala Personalizada";
            this.btnNovaEscalaPersonalizada.Click += new System.EventHandler(this.btnNovaEscalaPersonalizada_Click);
            // 
            // abrirArquivoToolStripMenuItem
            // 
            this.abrirArquivoToolStripMenuItem.Name = "abrirArquivoToolStripMenuItem";
            this.abrirArquivoToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.abrirArquivoToolStripMenuItem.Text = "Abrir Arquivo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoUsuárioToolStripMenuItem,
            this.gerenciarUsuárioToolStripMenuItem});
            this.btnUsuarios.Image = global::EscalasMetodista.Properties.Resources._1486504843_collaboration_group_people_men_user_team_users_81379;
            this.btnUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(99, 24);
            this.btnUsuarios.Text = "Usuários";
            // 
            // novoUsuárioToolStripMenuItem
            // 
            this.novoUsuárioToolStripMenuItem.Name = "novoUsuárioToolStripMenuItem";
            this.novoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.novoUsuárioToolStripMenuItem.Text = "Novo Usuário";
            this.novoUsuárioToolStripMenuItem.Click += new System.EventHandler(this.novoUsuarioToolStripMenuItem_Click);
            // 
            // gerenciarUsuárioToolStripMenuItem
            // 
            this.gerenciarUsuárioToolStripMenuItem.Name = "gerenciarUsuárioToolStripMenuItem";
            this.gerenciarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.gerenciarUsuárioToolStripMenuItem.Text = "Gerenciar Usuário";
            this.gerenciarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.gerenciarUsuarioToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // btnFuncoes
            // 
            this.btnFuncoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaFunçãoToolStripMenuItem,
            this.novaSubFunçãoToolStripMenuItem,
            this.gerenciarFunçõesToolStripMenuItem,
            this.gerenciarSubFunçõesToolStripMenuItem});
            this.btnFuncoes.Image = global::EscalasMetodista.Properties.Resources.System_preferences_46991;
            this.btnFuncoes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFuncoes.Name = "btnFuncoes";
            this.btnFuncoes.Size = new System.Drawing.Size(96, 24);
            this.btnFuncoes.Text = "Funções";
            // 
            // novaFunçãoToolStripMenuItem
            // 
            this.novaFunçãoToolStripMenuItem.Name = "novaFunçãoToolStripMenuItem";
            this.novaFunçãoToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.novaFunçãoToolStripMenuItem.Text = "Nova Função";
            this.novaFunçãoToolStripMenuItem.Click += new System.EventHandler(this.novaFunçaoToolStripMenuItem_Click);
            // 
            // novaSubFunçãoToolStripMenuItem
            // 
            this.novaSubFunçãoToolStripMenuItem.Name = "novaSubFunçãoToolStripMenuItem";
            this.novaSubFunçãoToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.novaSubFunçãoToolStripMenuItem.Text = "Nova Sub-Função";
            this.novaSubFunçãoToolStripMenuItem.Click += new System.EventHandler(this.novaSubFunçaoToolStripMenuItem_Click);
            // 
            // gerenciarFunçõesToolStripMenuItem
            // 
            this.gerenciarFunçõesToolStripMenuItem.Name = "gerenciarFunçõesToolStripMenuItem";
            this.gerenciarFunçõesToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.gerenciarFunçõesToolStripMenuItem.Text = "Gerenciar Funções";
            this.gerenciarFunçõesToolStripMenuItem.Click += new System.EventHandler(this.gerenciarFunçoesToolStripMenuItem_Click);
            // 
            // gerenciarSubFunçõesToolStripMenuItem
            // 
            this.gerenciarSubFunçõesToolStripMenuItem.Name = "gerenciarSubFunçõesToolStripMenuItem";
            this.gerenciarSubFunçõesToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.gerenciarSubFunçõesToolStripMenuItem.Text = "Gerenciar Sub-Funções";
            this.gerenciarSubFunçõesToolStripMenuItem.Click += new System.EventHandler(this.gerenciarSubFunçoesToolStripMenuItem_Click);
            // 
            // btnSair
            // 
            this.btnSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSair.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic);
            this.btnSair.Image = global::EscalasMetodista.Properties.Resources.sair;
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(59, 27);
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioDePessoasToolStripMenuItem});
            this.btnRelatorios.Image = global::EscalasMetodista.Properties.Resources._1486504846_clipboard_tasks_report_business_checking_verification_document_81354;
            this.btnRelatorios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(110, 24);
            this.btnRelatorios.Text = "Relatórios";
            // 
            // relatórioDePessoasToolStripMenuItem
            // 
            this.relatórioDePessoasToolStripMenuItem.Name = "relatórioDePessoasToolStripMenuItem";
            this.relatórioDePessoasToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.relatórioDePessoasToolStripMenuItem.Text = "Relatório de Pessoas";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // btnSobre
            // 
            this.btnSobre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSobre.Image = ((System.Drawing.Image)(resources.GetObject("btnSobre.Image")));
            this.btnSobre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(52, 24);
            this.btnSobre.Text = "Sobre";
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // panel_principal
            // 
            this.panel_principal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_principal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_principal.Controls.Add(this.labelData);
            this.panel_principal.Controls.Add(this.labelIdUsuarioLogado);
            this.panel_principal.Controls.Add(this.toolStripMenu);
            this.panel_principal.Controls.Add(this.pictureBox1);
            this.panel_principal.Controls.Add(this.panel_rodape);
            this.panel_principal.Location = new System.Drawing.Point(443, 0);
            this.panel_principal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(925, 692);
            this.panel_principal.TabIndex = 1;
            // 
            // labelData
            // 
            this.labelData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.Color.Black;
            this.labelData.Location = new System.Drawing.Point(525, 618);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(0, 17);
            this.labelData.TabIndex = 7;
            // 
            // labelIdUsuarioLogado
            // 
            this.labelIdUsuarioLogado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIdUsuarioLogado.AutoSize = true;
            this.labelIdUsuarioLogado.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdUsuarioLogado.ForeColor = System.Drawing.Color.Black;
            this.labelIdUsuarioLogado.Location = new System.Drawing.Point(525, 589);
            this.labelIdUsuarioLogado.Name = "labelIdUsuarioLogado";
            this.labelIdUsuarioLogado.Size = new System.Drawing.Size(0, 17);
            this.labelIdUsuarioLogado.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::EscalasMetodista.Properties.Resources.cruz_chama_metodista;
            this.pictureBox1.Location = new System.Drawing.Point(216, 91);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 558);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel_botoes
            // 
            this.panel_botoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_botoes.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel_botoes.BackgroundImage = global::EscalasMetodista.Properties.Resources.sobreposicao_de_rotulo_vermelho_sobre_fundo_metalico_cinzento_escuro_33869_1241;
            this.panel_botoes.Controls.Add(this.dgEscalas);
            this.panel_botoes.Controls.Add(this.btnPesquisa);
            this.panel_botoes.Controls.Add(this.txtPesquisaEscala);
            this.panel_botoes.Location = new System.Drawing.Point(-1, 187);
            this.panel_botoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_botoes.Name = "panel_botoes";
            this.panel_botoes.Size = new System.Drawing.Size(445, 508);
            this.panel_botoes.TabIndex = 2;
            // 
            // dgEscalas
            // 
            this.dgEscalas.AllowUserToAddRows = false;
            this.dgEscalas.AllowUserToDeleteRows = false;
            this.dgEscalas.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgEscalas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgEscalas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEscalas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgEscalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEscalas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descricao,
            this.dataAlteracao});
            this.dgEscalas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgEscalas.Location = new System.Drawing.Point(10, 90);
            this.dgEscalas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgEscalas.Name = "dgEscalas";
            this.dgEscalas.ReadOnly = true;
            this.dgEscalas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgEscalas.RowHeadersWidth = 51;
            this.dgEscalas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgEscalas.RowTemplate.Height = 24;
            this.dgEscalas.Size = new System.Drawing.Size(424, 46);
            this.dgEscalas.TabIndex = 0;
            this.dgEscalas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgEscalas_DataBindingComplete);
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Arquivo";
            this.descricao.MinimumWidth = 6;
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 125;
            // 
            // dataAlteracao
            // 
            this.dataAlteracao.HeaderText = "Última Alteração";
            this.dataAlteracao.MinimumWidth = 6;
            this.dataAlteracao.Name = "dataAlteracao";
            this.dataAlteracao.ReadOnly = true;
            this.dataAlteracao.Width = 125;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisa.BackgroundImage = global::EscalasMetodista.Properties.Resources.kisspng_forest_lake_computer_icons_inspection_white_wine_search_bar_5addbd8c2df2a6_8041717315244814201882;
            this.btnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisa.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnPesquisa.FlatAppearance.BorderSize = 0;
            this.btnPesquisa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPesquisa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnPesquisa.ForeColor = System.Drawing.Color.Transparent;
            this.btnPesquisa.Location = new System.Drawing.Point(372, 39);
            this.btnPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(47, 26);
            this.btnPesquisa.TabIndex = 1;
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtPesquisaEscala
            // 
            this.txtPesquisaEscala.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisaEscala.BackColor = System.Drawing.Color.White;
            this.txtPesquisaEscala.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisaEscala.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtPesquisaEscala.Location = new System.Drawing.Point(55, 40);
            this.txtPesquisaEscala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesquisaEscala.Name = "txtPesquisaEscala";
            this.txtPesquisaEscala.Size = new System.Drawing.Size(335, 25);
            this.txtPesquisaEscala.TabIndex = 0;
            // 
            // logo_metodista
            // 
            this.logo_metodista.BackColor = System.Drawing.Color.Transparent;
            this.logo_metodista.Image = ((System.Drawing.Image)(resources.GetObject("logo_metodista.Image")));
            this.logo_metodista.Location = new System.Drawing.Point(91, 12);
            this.logo_metodista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo_metodista.Name = "logo_metodista";
            this.logo_metodista.Size = new System.Drawing.Size(265, 158);
            this.logo_metodista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_metodista.TabIndex = 0;
            this.logo_metodista.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1368, 684);
            this.Controls.Add(this.panel_botoes);
            this.Controls.Add(this.panel_principal);
            this.Controls.Add(this.logo_metodista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1386, 731);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escalas Metodista";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenu_FormClosed);
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMenu_KeyDown);
            this.panel_rodape.ResumeLayout(false);
            this.panel_rodape.PerformLayout();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.panel_principal.ResumeLayout(false);
            this.panel_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_botoes.ResumeLayout(false);
            this.panel_botoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEscalas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_metodista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo_metodista;
        private System.Windows.Forms.Panel panel_botoes;
        private System.Windows.Forms.DataGridView dgEscalas;
        private System.Windows.Forms.TextBox txtPesquisaEscala;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Panel panel_rodape;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton btnSobre;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.Panel panel_principal;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAlteracao;
        private System.Windows.Forms.ToolStripDropDownButton btnPerfil;
        private System.Windows.Forms.ToolStripMenuItem btnAlterarSenha;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton btnEscalas;
        private System.Windows.Forms.ToolStripMenuItem btnNovaEscala;
        private System.Windows.Forms.ToolStripMenuItem abrirArquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Label labelIdUsuarioLogado;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.ToolStripDropDownButton btnUsuarios;
        private System.Windows.Forms.ToolStripMenuItem novoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton btnFuncoes;
        private System.Windows.Forms.ToolStripMenuItem novaFunçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaSubFunçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarFunçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarSubFunçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton btnRelatorios;
        private System.Windows.Forms.ToolStripMenuItem relatórioDePessoasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnNovaEscalaPersonalizada;
    }
}

