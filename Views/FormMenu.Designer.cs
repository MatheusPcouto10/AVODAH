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
            this.panel_principal = new System.Windows.Forms.Panel();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.labelUsuario = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRelatorios = new System.Windows.Forms.ToolStripDropDownButton();
            this.relatórioDePessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAlterarSenha = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSobre = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_rodape = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtPesquisaEscala = new System.Windows.Forms.TextBox();
            this.panel_botoes = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPesquisarPessoa = new System.Windows.Forms.Button();
            this.btnCadastrarPessoa = new System.Windows.Forms.Button();
            this.btnAbrirArquivo = new System.Windows.Forms.Button();
            this.btnNovaEscala = new System.Windows.Forms.Button();
            this.logo_metodista = new System.Windows.Forms.PictureBox();
            this.panel_principal.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_rodape.SuspendLayout();
            this.panel_botoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_metodista)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_principal
            // 
            this.panel_principal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_principal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_principal.Controls.Add(this.toolStripMenu);
            this.panel_principal.Controls.Add(this.pictureBox1);
            this.panel_principal.Controls.Add(this.panel_rodape);
            this.panel_principal.Controls.Add(this.panel1);
            this.panel_principal.Controls.Add(this.btnPesquisa);
            this.panel_principal.Controls.Add(this.txtPesquisaEscala);
            this.panel_principal.Location = new System.Drawing.Point(333, 0);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(908, 739);
            this.panel_principal.TabIndex = 1;
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelUsuario,
            this.toolStripSeparator2,
            this.btnRelatorios,
            this.toolStripSeparator1,
            this.btnAlterarSenha,
            this.toolStripSeparator3,
            this.btnSobre});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(908, 27);
            this.toolStripMenu.TabIndex = 5;
            // 
            // labelUsuario
            // 
            this.labelUsuario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(171, 24);
            this.labelUsuario.Text = "Bem vindo Matheus !";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioDePessoasToolStripMenuItem});
            this.btnRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorios.Image")));
            this.btnRelatorios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(90, 24);
            this.btnRelatorios.Text = "Relatórios";
            // 
            // relatórioDePessoasToolStripMenuItem
            // 
            this.relatórioDePessoasToolStripMenuItem.Name = "relatórioDePessoasToolStripMenuItem";
            this.relatórioDePessoasToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.relatórioDePessoasToolStripMenuItem.Text = "Relatório de Pessoas";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::EscalasMetodista.Properties.Resources.cruz_chama_metodista;
            this.pictureBox1.Location = new System.Drawing.Point(186, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 558);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel_rodape
            // 
            this.panel_rodape.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_rodape.BackColor = System.Drawing.Color.DarkRed;
            this.panel_rodape.Controls.Add(this.label1);
            this.panel_rodape.Location = new System.Drawing.Point(0, 701);
            this.panel_rodape.Name = "panel_rodape";
            this.panel_rodape.Size = new System.Drawing.Size(917, 38);
            this.panel_rodape.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(256, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desenvolvido por Matheus Pimentel - 2020";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(259, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 1);
            this.panel1.TabIndex = 3;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.BackgroundImage")));
            this.btnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisa.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnPesquisa.FlatAppearance.BorderSize = 0;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnPesquisa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPesquisa.Location = new System.Drawing.Point(603, 103);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(36, 26);
            this.btnPesquisa.TabIndex = 1;
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtPesquisaEscala
            // 
            this.txtPesquisaEscala.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPesquisaEscala.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPesquisaEscala.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisaEscala.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtPesquisaEscala.Location = new System.Drawing.Point(259, 101);
            this.txtPesquisaEscala.Name = "txtPesquisaEscala";
            this.txtPesquisaEscala.Size = new System.Drawing.Size(338, 21);
            this.txtPesquisaEscala.TabIndex = 0;
            // 
            // panel_botoes
            // 
            this.panel_botoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_botoes.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel_botoes.Controls.Add(this.btnSair);
            this.panel_botoes.Controls.Add(this.btnPesquisarPessoa);
            this.panel_botoes.Controls.Add(this.btnCadastrarPessoa);
            this.panel_botoes.Controls.Add(this.btnAbrirArquivo);
            this.panel_botoes.Controls.Add(this.btnNovaEscala);
            this.panel_botoes.Location = new System.Drawing.Point(-1, 187);
            this.panel_botoes.Name = "panel_botoes";
            this.panel_botoes.Size = new System.Drawing.Size(336, 555);
            this.panel_botoes.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.Location = new System.Drawing.Point(106, 514);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(104, 27);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPesquisarPessoa
            // 
            this.btnPesquisarPessoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPesquisarPessoa.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnPesquisarPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarPessoa.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.btnPesquisarPessoa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPesquisarPessoa.Location = new System.Drawing.Point(30, 275);
            this.btnPesquisarPessoa.Name = "btnPesquisarPessoa";
            this.btnPesquisarPessoa.Size = new System.Drawing.Size(265, 48);
            this.btnPesquisarPessoa.TabIndex = 3;
            this.btnPesquisarPessoa.Text = "PESQUISAR PESSOA";
            this.btnPesquisarPessoa.UseVisualStyleBackColor = false;
            this.btnPesquisarPessoa.Click += new System.EventHandler(this.btnPesquisarPessoa_Click);
            // 
            // btnCadastrarPessoa
            // 
            this.btnCadastrarPessoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCadastrarPessoa.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarPessoa.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.btnCadastrarPessoa.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarPessoa.Location = new System.Drawing.Point(30, 202);
            this.btnCadastrarPessoa.Name = "btnCadastrarPessoa";
            this.btnCadastrarPessoa.Size = new System.Drawing.Size(265, 48);
            this.btnCadastrarPessoa.TabIndex = 2;
            this.btnCadastrarPessoa.Text = "CADASTRAR PESSOA";
            this.btnCadastrarPessoa.UseVisualStyleBackColor = false;
            this.btnCadastrarPessoa.Click += new System.EventHandler(this.btnCadastrarPessoa_Click);
            // 
            // btnAbrirArquivo
            // 
            this.btnAbrirArquivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAbrirArquivo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAbrirArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirArquivo.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.btnAbrirArquivo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAbrirArquivo.Location = new System.Drawing.Point(30, 129);
            this.btnAbrirArquivo.Name = "btnAbrirArquivo";
            this.btnAbrirArquivo.Size = new System.Drawing.Size(265, 48);
            this.btnAbrirArquivo.TabIndex = 1;
            this.btnAbrirArquivo.Text = "ABRIR ARQUIVO";
            this.btnAbrirArquivo.UseVisualStyleBackColor = false;
            this.btnAbrirArquivo.Click += new System.EventHandler(this.btnAbrirArquivo_Click);
            // 
            // btnNovaEscala
            // 
            this.btnNovaEscala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNovaEscala.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnNovaEscala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaEscala.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.btnNovaEscala.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNovaEscala.Location = new System.Drawing.Point(30, 56);
            this.btnNovaEscala.Name = "btnNovaEscala";
            this.btnNovaEscala.Size = new System.Drawing.Size(265, 48);
            this.btnNovaEscala.TabIndex = 0;
            this.btnNovaEscala.Text = "NOVA ESCALA";
            this.btnNovaEscala.UseVisualStyleBackColor = false;
            this.btnNovaEscala.Click += new System.EventHandler(this.btnNovaEscala_Click);
            // 
            // logo_metodista
            // 
            this.logo_metodista.BackColor = System.Drawing.Color.Transparent;
            this.logo_metodista.Image = ((System.Drawing.Image)(resources.GetObject("logo_metodista.Image")));
            this.logo_metodista.Location = new System.Drawing.Point(29, 12);
            this.logo_metodista.Name = "logo_metodista";
            this.logo_metodista.Size = new System.Drawing.Size(265, 157);
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
            this.ClientSize = new System.Drawing.Size(1242, 731);
            this.Controls.Add(this.panel_botoes);
            this.Controls.Add(this.panel_principal);
            this.Controls.Add(this.logo_metodista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escalas Metodista";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMenu_KeyDown);
            this.panel_principal.ResumeLayout(false);
            this.panel_principal.PerformLayout();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_rodape.ResumeLayout(false);
            this.panel_rodape.PerformLayout();
            this.panel_botoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_metodista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo_metodista;
        private System.Windows.Forms.Panel panel_principal;
        private System.Windows.Forms.Panel panel_botoes;
        private System.Windows.Forms.Panel panel_rodape;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPesquisarPessoa;
        private System.Windows.Forms.Button btnCadastrarPessoa;
        private System.Windows.Forms.Button btnAbrirArquivo;
        private System.Windows.Forms.Button btnNovaEscala;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txtPesquisaEscala;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripDropDownButton btnRelatorios;
        private System.Windows.Forms.ToolStripMenuItem relatórioDePessoasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAlterarSenha;
        private System.Windows.Forms.ToolStripLabel labelUsuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnSobre;
    }
}

