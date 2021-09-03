namespace EscalasMetodista.Views.Funcoes
{
    partial class FormGerenciarSubfuncoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerenciarSubfuncoes));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.telaPesquisa = new System.Windows.Forms.TabPage();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dgSubFuncoes = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel_rodape = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCadastrarNovo = new FontAwesome.Sharp.IconButton();
            this.tabControl1.SuspendLayout();
            this.telaPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubFuncoes)).BeginInit();
            this.panel_rodape.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.telaPesquisa);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-5, 41);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(740, 405);
            this.tabControl1.TabIndex = 6;
            // 
            // telaPesquisa
            // 
            this.telaPesquisa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.telaPesquisa.BackgroundImage = global::EscalasMetodista.Properties.Resources.sobreposicao_de_rotulo_vermelho_sobre_fundo_metalico_cinzento_escuro_33869_1241;
            this.telaPesquisa.Controls.Add(this.btnCadastrarNovo);
            this.telaPesquisa.Controls.Add(this.btnPesquisa);
            this.telaPesquisa.Controls.Add(this.txtPesquisa);
            this.telaPesquisa.Controls.Add(this.dgSubFuncoes);
            this.telaPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telaPesquisa.Location = new System.Drawing.Point(4, 22);
            this.telaPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.telaPesquisa.Name = "telaPesquisa";
            this.telaPesquisa.Padding = new System.Windows.Forms.Padding(2);
            this.telaPesquisa.Size = new System.Drawing.Size(732, 379);
            this.telaPesquisa.TabIndex = 0;
            this.telaPesquisa.Text = "Pesquisa";
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
            this.btnPesquisa.Location = new System.Drawing.Point(457, 60);
            this.btnPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(33, 21);
            this.btnPesquisa.TabIndex = 17;
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.BackColor = System.Drawing.Color.White;
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtPesquisa.Location = new System.Drawing.Point(246, 61);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(207, 18);
            this.txtPesquisa.TabIndex = 16;
            // 
            // dgSubFuncoes
            // 
            this.dgSubFuncoes.AllowUserToAddRows = false;
            this.dgSubFuncoes.AllowUserToDeleteRows = false;
            this.dgSubFuncoes.AllowUserToOrderColumns = true;
            this.dgSubFuncoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSubFuncoes.BackgroundColor = System.Drawing.Color.Black;
            this.dgSubFuncoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSubFuncoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar});
            this.dgSubFuncoes.GridColor = System.Drawing.Color.Black;
            this.dgSubFuncoes.Location = new System.Drawing.Point(10, 104);
            this.dgSubFuncoes.Margin = new System.Windows.Forms.Padding(2);
            this.dgSubFuncoes.Name = "dgSubFuncoes";
            this.dgSubFuncoes.ReadOnly = true;
            this.dgSubFuncoes.RowHeadersVisible = false;
            this.dgSubFuncoes.RowHeadersWidth = 51;
            this.dgSubFuncoes.RowTemplate.Height = 24;
            this.dgSubFuncoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSubFuncoes.Size = new System.Drawing.Size(715, 257);
            this.dgSubFuncoes.TabIndex = 5;
            this.dgSubFuncoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFuncoes_CellContentClick);
            this.dgSubFuncoes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSubFuncoes_CellDoubleClick);
            this.dgSubFuncoes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgFuncoes_CellFormatting);
            this.dgSubFuncoes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgSubFuncoes_DataBindingComplete);
            // 
            // editar
            // 
            this.editar.HeaderText = "";
            this.editar.Image = global::EscalasMetodista.Properties.Resources.editar;
            this.editar.MinimumWidth = 6;
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editar.Width = 1099;
            // 
            // panel_rodape
            // 
            this.panel_rodape.BackColor = System.Drawing.Color.Black;
            this.panel_rodape.BackgroundImage = global::EscalasMetodista.Properties.Resources._2741104;
            this.panel_rodape.Controls.Add(this.btnVoltar);
            this.panel_rodape.Controls.Add(this.label1);
            this.panel_rodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_rodape.Location = new System.Drawing.Point(0, 446);
            this.panel_rodape.Margin = new System.Windows.Forms.Padding(2);
            this.panel_rodape.Name = "panel_rodape";
            this.panel_rodape.Size = new System.Drawing.Size(730, 37);
            this.panel_rodape.TabIndex = 7;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVoltar.Location = new System.Drawing.Point(9, 9);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(71, 24);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(148, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyright © 2021 — Desenvolvido por Matheus Pimentel Do Couto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::EscalasMetodista.Properties.Resources._2741104;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 37);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(242, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "GERENCIAR SUB-FUNÇÕES";
            // 
            // btnCadastrarNovo
            // 
            this.btnCadastrarNovo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastrarNovo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadastrarNovo.FlatAppearance.BorderSize = 2;
            this.btnCadastrarNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarNovo.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.btnCadastrarNovo.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrarNovo.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnCadastrarNovo.IconColor = System.Drawing.Color.Black;
            this.btnCadastrarNovo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastrarNovo.IconSize = 20;
            this.btnCadastrarNovo.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCadastrarNovo.Location = new System.Drawing.Point(566, 22);
            this.btnCadastrarNovo.Name = "btnCadastrarNovo";
            this.btnCadastrarNovo.Size = new System.Drawing.Size(159, 31);
            this.btnCadastrarNovo.TabIndex = 71;
            this.btnCadastrarNovo.Text = "Nova Sub-Função";
            this.btnCadastrarNovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCadastrarNovo.UseVisualStyleBackColor = false;
            this.btnCadastrarNovo.Click += new System.EventHandler(this.btnCadastrarNovo_Click);
            // 
            // FormGerenciarSubfuncoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(730, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_rodape);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormGerenciarSubfuncoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Sub-Funções";
            this.Activated += new System.EventHandler(this.FormGerenciarSubfuncoes_Activated);
            this.Load += new System.EventHandler(this.FormGerenciarSubfuncoes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGerenciarSubfuncoes_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.telaPesquisa.ResumeLayout(false);
            this.telaPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubFuncoes)).EndInit();
            this.panel_rodape.ResumeLayout(false);
            this.panel_rodape.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage telaPesquisa;
        public System.Windows.Forms.DataGridView dgSubFuncoes;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.Panel panel_rodape;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private FontAwesome.Sharp.IconButton btnCadastrarNovo;
    }
}