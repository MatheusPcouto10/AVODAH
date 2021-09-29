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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panel_rodape = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_principal = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelData = new System.Windows.Forms.Label();
            this.labelIdUsuarioLogado = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnPerfil = new FontAwesome.Sharp.IconButton();
            this.btnSair = new FontAwesome.Sharp.IconButton();
            this.btnSobreMenu = new FontAwesome.Sharp.IconButton();
            this.btnAjudaMenu = new FontAwesome.Sharp.IconButton();
            this.btnFuncoesMenu = new FontAwesome.Sharp.IconButton();
            this.btnUsuariosMenu = new FontAwesome.Sharp.IconButton();
            this.btnEscalaMenu = new FontAwesome.Sharp.IconButton();
            this.dropBtnPerfil = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnEditarPerfil = new FontAwesome.Sharp.IconMenuItem();
            this.btnAlterarSenha = new FontAwesome.Sharp.IconMenuItem();
            this.dropBtnFuncoes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnFuncoes = new FontAwesome.Sharp.IconMenuItem();
            this.btnSubFuncoes = new FontAwesome.Sharp.IconMenuItem();
            this.panel_botoes = new System.Windows.Forms.Panel();
            this.dgEscalas = new System.Windows.Forms.DataGridView();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAlteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtPesquisaEscala = new System.Windows.Forms.TextBox();
            this.logo_metodista = new System.Windows.Forms.PictureBox();
            this.panel_rodape.SuspendLayout();
            this.panel_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.dropBtnPerfil.SuspendLayout();
            this.dropBtnFuncoes.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(245, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyright © 2021 — Desenvolvido por Matheus Pimentel Do Couto";
            // 
            // panel_principal
            // 
            this.panel_principal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_principal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_principal.Controls.Add(this.pictureBox1);
            this.panel_principal.Controls.Add(this.labelData);
            this.panel_principal.Controls.Add(this.labelIdUsuarioLogado);
            this.panel_principal.Controls.Add(this.panel_rodape);
            this.panel_principal.Location = new System.Drawing.Point(443, 0);
            this.panel_principal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(925, 692);
            this.panel_principal.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::EscalasMetodista.Properties.Resources.Avodah_B_W;
            this.pictureBox1.Location = new System.Drawing.Point(232, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 608);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labelData
            // 
            this.labelData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.Color.Black;
            this.labelData.Location = new System.Drawing.Point(525, 618);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(0, 13);
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
            this.labelIdUsuarioLogado.Size = new System.Drawing.Size(0, 13);
            this.labelIdUsuarioLogado.TabIndex = 6;
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.BackColor = System.Drawing.SystemColors.Control;
            this.panelMenu.Controls.Add(this.btnPerfil);
            this.panelMenu.Controls.Add(this.btnSair);
            this.panelMenu.Controls.Add(this.btnSobreMenu);
            this.panelMenu.Controls.Add(this.btnAjudaMenu);
            this.panelMenu.Controls.Add(this.btnFuncoesMenu);
            this.panelMenu.Controls.Add(this.btnUsuariosMenu);
            this.panelMenu.Controls.Add(this.btnEscalaMenu);
            this.panelMenu.Location = new System.Drawing.Point(443, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(925, 36);
            this.panelMenu.TabIndex = 8;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnPerfil.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnPerfil.IconColor = System.Drawing.Color.SeaGreen;
            this.btnPerfil.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnPerfil.IconSize = 30;
            this.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.Location = new System.Drawing.Point(686, 0);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(187, 36);
            this.btnPerfil.TabIndex = 12;
            this.btnPerfil.Text = "Meu Perfil";
            this.btnPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnSair.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSair.IconColor = System.Drawing.Color.Black;
            this.btnSair.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSair.IconSize = 25;
            this.btnSair.Location = new System.Drawing.Point(879, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(44, 36);
            this.btnSair.TabIndex = 12;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSobreMenu
            // 
            this.btnSobreMenu.FlatAppearance.BorderSize = 0;
            this.btnSobreMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobreMenu.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnSobreMenu.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.btnSobreMenu.IconColor = System.Drawing.Color.Black;
            this.btnSobreMenu.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSobreMenu.IconSize = 30;
            this.btnSobreMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSobreMenu.Location = new System.Drawing.Point(410, 0);
            this.btnSobreMenu.Name = "btnSobreMenu";
            this.btnSobreMenu.Size = new System.Drawing.Size(90, 36);
            this.btnSobreMenu.TabIndex = 11;
            this.btnSobreMenu.Text = "Sobre";
            this.btnSobreMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSobreMenu.UseVisualStyleBackColor = true;
            this.btnSobreMenu.Click += new System.EventHandler(this.btnSobreMenu_Click);
            // 
            // btnAjudaMenu
            // 
            this.btnAjudaMenu.FlatAppearance.BorderSize = 0;
            this.btnAjudaMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjudaMenu.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnAjudaMenu.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnAjudaMenu.IconColor = System.Drawing.SystemColors.GrayText;
            this.btnAjudaMenu.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAjudaMenu.IconSize = 25;
            this.btnAjudaMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjudaMenu.Location = new System.Drawing.Point(322, 0);
            this.btnAjudaMenu.Name = "btnAjudaMenu";
            this.btnAjudaMenu.Size = new System.Drawing.Size(82, 36);
            this.btnAjudaMenu.TabIndex = 10;
            this.btnAjudaMenu.Text = "Ajuda";
            this.btnAjudaMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAjudaMenu.UseVisualStyleBackColor = true;
            this.btnAjudaMenu.Click += new System.EventHandler(this.btnAjudaMenu_Click);
            // 
            // btnFuncoesMenu
            // 
            this.btnFuncoesMenu.FlatAppearance.BorderSize = 0;
            this.btnFuncoesMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncoesMenu.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnFuncoesMenu.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnFuncoesMenu.IconColor = System.Drawing.Color.DarkSlateGray;
            this.btnFuncoesMenu.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnFuncoesMenu.IconSize = 25;
            this.btnFuncoesMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncoesMenu.Location = new System.Drawing.Point(213, 0);
            this.btnFuncoesMenu.Name = "btnFuncoesMenu";
            this.btnFuncoesMenu.Size = new System.Drawing.Size(103, 36);
            this.btnFuncoesMenu.TabIndex = 9;
            this.btnFuncoesMenu.Text = "Funções";
            this.btnFuncoesMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFuncoesMenu.UseVisualStyleBackColor = true;
            this.btnFuncoesMenu.Click += new System.EventHandler(this.btnFuncoesMenu_Click);
            // 
            // btnUsuariosMenu
            // 
            this.btnUsuariosMenu.FlatAppearance.BorderSize = 0;
            this.btnUsuariosMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuariosMenu.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnUsuariosMenu.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnUsuariosMenu.IconColor = System.Drawing.Color.DarkMagenta;
            this.btnUsuariosMenu.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnUsuariosMenu.IconSize = 30;
            this.btnUsuariosMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuariosMenu.Location = new System.Drawing.Point(104, 0);
            this.btnUsuariosMenu.Name = "btnUsuariosMenu";
            this.btnUsuariosMenu.Size = new System.Drawing.Size(103, 36);
            this.btnUsuariosMenu.TabIndex = 8;
            this.btnUsuariosMenu.Text = "Usuários";
            this.btnUsuariosMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuariosMenu.UseVisualStyleBackColor = true;
            this.btnUsuariosMenu.Click += new System.EventHandler(this.btnUsuariosMenu_Click);
            // 
            // btnEscalaMenu
            // 
            this.btnEscalaMenu.FlatAppearance.BorderSize = 0;
            this.btnEscalaMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscalaMenu.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnEscalaMenu.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnEscalaMenu.IconColor = System.Drawing.SystemColors.HotTrack;
            this.btnEscalaMenu.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEscalaMenu.IconSize = 30;
            this.btnEscalaMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEscalaMenu.Location = new System.Drawing.Point(2, 0);
            this.btnEscalaMenu.Name = "btnEscalaMenu";
            this.btnEscalaMenu.Size = new System.Drawing.Size(96, 36);
            this.btnEscalaMenu.TabIndex = 0;
            this.btnEscalaMenu.Text = "Escalas";
            this.btnEscalaMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEscalaMenu.UseVisualStyleBackColor = true;
            this.btnEscalaMenu.Click += new System.EventHandler(this.btnEscalaMenu_Click);
            // 
            // dropBtnPerfil
            // 
            this.dropBtnPerfil.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dropBtnPerfil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditarPerfil,
            this.btnAlterarSenha});
            this.dropBtnPerfil.Name = "dropBtnPerfil";
            this.dropBtnPerfil.Size = new System.Drawing.Size(165, 48);
            // 
            // btnEditarPerfil
            // 
            this.btnEditarPerfil.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPerfil.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEditarPerfil.IconColor = System.Drawing.Color.SeaGreen;
            this.btnEditarPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarPerfil.IconSize = 30;
            this.btnEditarPerfil.Name = "btnEditarPerfil";
            this.btnEditarPerfil.Size = new System.Drawing.Size(164, 22);
            this.btnEditarPerfil.Text = "Editar Perfil";
            this.btnEditarPerfil.Click += new System.EventHandler(this.btnEditarPerfil_Click);
            // 
            // btnAlterarSenha
            // 
            this.btnAlterarSenha.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAlterarSenha.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnAlterarSenha.IconColor = System.Drawing.Color.SeaGreen;
            this.btnAlterarSenha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlterarSenha.IconSize = 30;
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(164, 22);
            this.btnAlterarSenha.Text = "Alterar Senha";
            this.btnAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_Click);
            // 
            // dropBtnFuncoes
            // 
            this.dropBtnFuncoes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dropBtnFuncoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFuncoes,
            this.btnSubFuncoes});
            this.dropBtnFuncoes.Name = "dropBtnPerfil";
            this.dropBtnFuncoes.Size = new System.Drawing.Size(150, 48);
            // 
            // btnFuncoes
            // 
            this.btnFuncoes.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncoes.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.btnFuncoes.IconColor = System.Drawing.Color.DarkSlateGray;
            this.btnFuncoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFuncoes.IconSize = 30;
            this.btnFuncoes.Name = "btnFuncoes";
            this.btnFuncoes.Size = new System.Drawing.Size(149, 22);
            this.btnFuncoes.Text = "Funções";
            this.btnFuncoes.Click += new System.EventHandler(this.btnFuncoes_Click);
            // 
            // btnSubFuncoes
            // 
            this.btnSubFuncoes.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSubFuncoes.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.btnSubFuncoes.IconColor = System.Drawing.Color.DarkSlateGray;
            this.btnSubFuncoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubFuncoes.IconSize = 30;
            this.btnSubFuncoes.Name = "btnSubFuncoes";
            this.btnSubFuncoes.Size = new System.Drawing.Size(149, 22);
            this.btnSubFuncoes.Text = "Subfunções";
            this.btnSubFuncoes.Click += new System.EventHandler(this.btnSubFuncoes_Click);
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
            this.dgEscalas.BackgroundColor = System.Drawing.Color.Black;
            this.dgEscalas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgEscalas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEscalas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgEscalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEscalas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descricao,
            this.dataAlteracao});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEscalas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgEscalas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgEscalas.Location = new System.Drawing.Point(10, 90);
            this.dgEscalas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgEscalas.Name = "dgEscalas";
            this.dgEscalas.ReadOnly = true;
            this.dgEscalas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgEscalas.RowHeadersVisible = false;
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
            this.btnPesquisa.Size = new System.Drawing.Size(47, 21);
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
            this.txtPesquisaEscala.Size = new System.Drawing.Size(335, 20);
            this.txtPesquisaEscala.TabIndex = 0;
            // 
            // logo_metodista
            // 
            this.logo_metodista.BackColor = System.Drawing.Color.Transparent;
            this.logo_metodista.Image = global::EscalasMetodista.Properties.Resources.Avodah_Line_White;
            this.logo_metodista.Location = new System.Drawing.Point(9, 12);
            this.logo_metodista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo_metodista.Name = "logo_metodista";
            this.logo_metodista.Size = new System.Drawing.Size(424, 158);
            this.logo_metodista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_metodista.TabIndex = 0;
            this.logo_metodista.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1370, 692);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel_botoes);
            this.Controls.Add(this.panel_principal);
            this.Controls.Add(this.logo_metodista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1386, 731);
            this.Name = "FormMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenu_FormClosed);
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.Shown += new System.EventHandler(this.FormMenu_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMenu_KeyDown);
            this.panel_rodape.ResumeLayout(false);
            this.panel_rodape.PerformLayout();
            this.panel_principal.ResumeLayout(false);
            this.panel_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.dropBtnPerfil.ResumeLayout(false);
            this.dropBtnFuncoes.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel_rodape;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_principal;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAlteracao;
        private System.Windows.Forms.Label labelIdUsuarioLogado;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnPerfil;
        private FontAwesome.Sharp.IconButton btnSair;
        private FontAwesome.Sharp.IconButton btnSobreMenu;
        private FontAwesome.Sharp.IconButton btnAjudaMenu;
        private FontAwesome.Sharp.IconButton btnFuncoesMenu;
        private FontAwesome.Sharp.IconButton btnUsuariosMenu;
        private FontAwesome.Sharp.IconButton btnEscalaMenu;
        private System.Windows.Forms.ContextMenuStrip dropBtnPerfil;
        private FontAwesome.Sharp.IconMenuItem btnEditarPerfil;
        private FontAwesome.Sharp.IconMenuItem btnAlterarSenha;
        private System.Windows.Forms.ContextMenuStrip dropBtnFuncoes;
        private FontAwesome.Sharp.IconMenuItem btnFuncoes;
        private FontAwesome.Sharp.IconMenuItem btnSubFuncoes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

