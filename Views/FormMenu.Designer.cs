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
            this.txtPesquisaEscala = new System.Windows.Forms.TextBox();
            this.panel_rodape = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btnPerfil = new System.Windows.Forms.ToolStripDropDownButton();
            this.editarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAlterarSenha = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSobre = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRelatorios = new System.Windows.Forms.ToolStripSplitButton();
            this.relatórioDePessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUsuarios = new System.Windows.Forms.ToolStripSplitButton();
            this.novoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFuncoes = new System.Windows.Forms.ToolStripSplitButton();
            this.novaFunçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaSubFunçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarFunçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarSubFunçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.panel_principal = new System.Windows.Forms.Panel();
            this.linkNovaEscala = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.linkAbrirArquivo = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_botoes = new System.Windows.Forms.Panel();
            this.dgEscalas = new System.Windows.Forms.DataGridView();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAlteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.logo_metodista = new System.Windows.Forms.PictureBox();
            this.panel_rodape.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.panel_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_botoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEscalas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_metodista)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisaEscala
            // 
            this.txtPesquisaEscala.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisaEscala.BackColor = System.Drawing.Color.White;
            this.txtPesquisaEscala.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisaEscala.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtPesquisaEscala.Location = new System.Drawing.Point(77, 35);
            this.txtPesquisaEscala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesquisaEscala.Name = "txtPesquisaEscala";
            this.txtPesquisaEscala.Size = new System.Drawing.Size(335, 25);
            this.txtPesquisaEscala.TabIndex = 0;
            // 
            // panel_rodape
            // 
            this.panel_rodape.BackColor = System.Drawing.Color.Maroon;
            this.panel_rodape.Controls.Add(this.label1);
            this.panel_rodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_rodape.Location = new System.Drawing.Point(0, 654);
            this.panel_rodape.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_rodape.Name = "panel_rodape";
            this.panel_rodape.Size = new System.Drawing.Size(925, 38);
            this.panel_rodape.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(285, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desenvolvido por Matheus Pimentel - 2020";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPerfil,
            this.toolStripSeparator2,
            this.btnAlterarSenha,
            this.toolStripSeparator1,
            this.btnSobre,
            this.toolStripSeparator3,
            this.btnRelatorios,
            this.toolStripSeparator4,
            this.btnUsuarios,
            this.toolStripSeparator6,
            this.btnFuncoes,
            this.btnSair});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(925, 27);
            this.toolStripMenu.TabIndex = 5;
            // 
            // btnPerfil
            // 
            this.btnPerfil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarPerfilToolStripMenuItem});
            this.btnPerfil.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(185, 24);
            this.btnPerfil.Text = "Bem vindo Matheus !";
            // 
            // editarPerfilToolStripMenuItem
            // 
            this.editarPerfilToolStripMenuItem.Name = "editarPerfilToolStripMenuItem";
            this.editarPerfilToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.editarPerfilToolStripMenuItem.Text = "Editar Perfil";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnAlterarSenha
            // 
            this.btnAlterarSenha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAlterarSenha.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarSenha.Image")));
            this.btnAlterarSenha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(102, 24);
            this.btnAlterarSenha.Text = "Alterar Senha";
            this.btnAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnSobre
            // 
            this.btnSobre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSobre.Image = ((System.Drawing.Image)(resources.GetObject("btnSobre.Image")));
            this.btnSobre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(52, 24);
            this.btnSobre.Text = "Sobre";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioDePessoasToolStripMenuItem});
            this.btnRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorios.Image")));
            this.btnRelatorios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(95, 24);
            this.btnRelatorios.Text = "Relatórios";
            // 
            // relatórioDePessoasToolStripMenuItem
            // 
            this.relatórioDePessoasToolStripMenuItem.Name = "relatórioDePessoasToolStripMenuItem";
            this.relatórioDePessoasToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.relatórioDePessoasToolStripMenuItem.Text = "Relatório de Pessoas";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoUsuárioToolStripMenuItem,
            this.gerenciarUsuárioToolStripMenuItem});
            this.btnUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(84, 24);
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // novoUsuárioToolStripMenuItem
            // 
            this.novoUsuárioToolStripMenuItem.Name = "novoUsuárioToolStripMenuItem";
            this.novoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.novoUsuárioToolStripMenuItem.Text = "Novo Usuário";
            // 
            // gerenciarUsuárioToolStripMenuItem
            // 
            this.gerenciarUsuárioToolStripMenuItem.Name = "gerenciarUsuárioToolStripMenuItem";
            this.gerenciarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.gerenciarUsuárioToolStripMenuItem.Text = "Gerenciar Usuário";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // btnFuncoes
            // 
            this.btnFuncoes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFuncoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaFunçãoToolStripMenuItem,
            this.novaSubFunçãoToolStripMenuItem,
            this.gerenciarFunçõesToolStripMenuItem,
            this.gerenciarSubFunçõesToolStripMenuItem});
            this.btnFuncoes.Image = ((System.Drawing.Image)(resources.GetObject("btnFuncoes.Image")));
            this.btnFuncoes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFuncoes.Name = "btnFuncoes";
            this.btnFuncoes.Size = new System.Drawing.Size(81, 24);
            this.btnFuncoes.Text = "Funções";
            // 
            // novaFunçãoToolStripMenuItem
            // 
            this.novaFunçãoToolStripMenuItem.Name = "novaFunçãoToolStripMenuItem";
            this.novaFunçãoToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.novaFunçãoToolStripMenuItem.Text = "Nova Função";
            this.novaFunçãoToolStripMenuItem.Click += new System.EventHandler(this.novaFunçãoToolStripMenuItem_Click);
            // 
            // novaSubFunçãoToolStripMenuItem
            // 
            this.novaSubFunçãoToolStripMenuItem.Name = "novaSubFunçãoToolStripMenuItem";
            this.novaSubFunçãoToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.novaSubFunçãoToolStripMenuItem.Text = "Nova Sub-Função";
            this.novaSubFunçãoToolStripMenuItem.Click += new System.EventHandler(this.novaSubFunçãoToolStripMenuItem_Click);
            // 
            // gerenciarFunçõesToolStripMenuItem
            // 
            this.gerenciarFunçõesToolStripMenuItem.Name = "gerenciarFunçõesToolStripMenuItem";
            this.gerenciarFunçõesToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.gerenciarFunçõesToolStripMenuItem.Text = "Gerenciar Funções";
            this.gerenciarFunçõesToolStripMenuItem.Click += new System.EventHandler(this.gerenciarFunçõesToolStripMenuItem_Click);
            // 
            // gerenciarSubFunçõesToolStripMenuItem
            // 
            this.gerenciarSubFunçõesToolStripMenuItem.Name = "gerenciarSubFunçõesToolStripMenuItem";
            this.gerenciarSubFunçõesToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.gerenciarSubFunçõesToolStripMenuItem.Text = "Gerenciar Sub-Funções";
            this.gerenciarSubFunçõesToolStripMenuItem.Click += new System.EventHandler(this.gerenciarSubFunçõesToolStripMenuItem_Click);
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
            // panel_principal
            // 
            this.panel_principal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_principal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_principal.Controls.Add(this.linkNovaEscala);
            this.panel_principal.Controls.Add(this.pictureBox2);
            this.panel_principal.Controls.Add(this.pictureBox3);
            this.panel_principal.Controls.Add(this.linkAbrirArquivo);
            this.panel_principal.Controls.Add(this.toolStripMenu);
            this.panel_principal.Controls.Add(this.pictureBox1);
            this.panel_principal.Controls.Add(this.panel_rodape);
            this.panel_principal.Location = new System.Drawing.Point(443, 0);
            this.panel_principal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(925, 692);
            this.panel_principal.TabIndex = 1;
            // 
            // linkNovaEscala
            // 
            this.linkNovaEscala.AutoSize = true;
            this.linkNovaEscala.BackColor = System.Drawing.Color.Transparent;
            this.linkNovaEscala.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkNovaEscala.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.linkNovaEscala.ForeColor = System.Drawing.Color.Black;
            this.linkNovaEscala.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkNovaEscala.LinkArea = new System.Windows.Forms.LinkArea(0, 21);
            this.linkNovaEscala.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkNovaEscala.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkNovaEscala.Location = new System.Drawing.Point(48, 226);
            this.linkNovaEscala.Name = "linkNovaEscala";
            this.linkNovaEscala.Size = new System.Drawing.Size(141, 26);
            this.linkNovaEscala.TabIndex = 16;
            this.linkNovaEscala.TabStop = true;
            this.linkNovaEscala.Text = "NOVA ESCALA";
            this.linkNovaEscala.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkNovaEscala.UseCompatibleTextRendering = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EscalasMetodista.Properties.Resources._1485476000_artboard_1_78543;
            this.pictureBox2.Location = new System.Drawing.Point(69, 137);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::EscalasMetodista.Properties.Resources.iconfinder_folder_4341292_120540;
            this.pictureBox3.Location = new System.Drawing.Point(323, 137);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(101, 79);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // linkAbrirArquivo
            // 
            this.linkAbrirArquivo.AutoSize = true;
            this.linkAbrirArquivo.BackColor = System.Drawing.Color.Transparent;
            this.linkAbrirArquivo.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkAbrirArquivo.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.linkAbrirArquivo.ForeColor = System.Drawing.Color.Black;
            this.linkAbrirArquivo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkAbrirArquivo.LinkArea = new System.Windows.Forms.LinkArea(0, 21);
            this.linkAbrirArquivo.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkAbrirArquivo.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkAbrirArquivo.Location = new System.Drawing.Point(293, 226);
            this.linkAbrirArquivo.Name = "linkAbrirArquivo";
            this.linkAbrirArquivo.Size = new System.Drawing.Size(167, 26);
            this.linkAbrirArquivo.TabIndex = 13;
            this.linkAbrirArquivo.TabStop = true;
            this.linkAbrirArquivo.Text = "ABRIR ARQUIVO";
            this.linkAbrirArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkAbrirArquivo.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::EscalasMetodista.Properties.Resources.cruz_chama_metodista;
            this.pictureBox1.Location = new System.Drawing.Point(195, 91);
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
            this.dgEscalas.Location = new System.Drawing.Point(13, 90);
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
            this.btnPesquisa.Location = new System.Drawing.Point(13, 34);
            this.btnPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(58, 26);
            this.btnPesquisa.TabIndex = 1;
            this.btnPesquisa.UseVisualStyleBackColor = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnAlterarSenha;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSobre;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSplitButton btnRelatorios;
        private System.Windows.Forms.ToolStripMenuItem relatórioDePessoasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSplitButton btnUsuarios;
        private System.Windows.Forms.ToolStripMenuItem novoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSplitButton btnFuncoes;
        private System.Windows.Forms.ToolStripMenuItem novaFunçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaSubFunçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarFunçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarSubFunçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.Panel panel_principal;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.LinkLabel linkAbrirArquivo;
        public System.Windows.Forms.LinkLabel linkNovaEscala;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAlteracao;
        private System.Windows.Forms.ToolStripDropDownButton btnPerfil;
        private System.Windows.Forms.ToolStripMenuItem editarPerfilToolStripMenuItem;
    }
}

