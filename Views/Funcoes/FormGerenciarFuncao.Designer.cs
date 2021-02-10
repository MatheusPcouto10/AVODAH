namespace EscalasMetodista.Views.Funcoes
{
    partial class FormGerenciarFuncao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerenciarFuncao));
            this.panel_rodape = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.telaPesquisa = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            this.dgFuncoes = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel_rodape.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.telaPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncoes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_rodape
            // 
            this.panel_rodape.BackColor = System.Drawing.Color.Maroon;
            this.panel_rodape.BackgroundImage = global::EscalasMetodista.Properties.Resources._2741104;
            this.panel_rodape.Controls.Add(this.btnVoltar);
            this.panel_rodape.Controls.Add(this.label1);
            this.panel_rodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_rodape.Location = new System.Drawing.Point(0, 549);
            this.panel_rodape.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_rodape.Name = "panel_rodape";
            this.panel_rodape.Size = new System.Drawing.Size(785, 45);
            this.panel_rodape.TabIndex = 4;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVoltar.Location = new System.Drawing.Point(12, 11);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 30);
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
            this.label1.Location = new System.Drawing.Point(232, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desenvolvido por Matheus Pimentel - 2020";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.telaPesquisa);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-3, 50);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 504);
            this.tabControl1.TabIndex = 5;
            // 
            // telaPesquisa
            // 
            this.telaPesquisa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.telaPesquisa.BackgroundImage = global::EscalasMetodista.Properties.Resources.sobreposicao_de_rotulo_vermelho_sobre_fundo_metalico_cinzento_escuro_33869_1241;
            this.telaPesquisa.Controls.Add(this.label11);
            this.telaPesquisa.Controls.Add(this.label7);
            this.telaPesquisa.Controls.Add(this.txtIdPesquisa);
            this.telaPesquisa.Controls.Add(this.btnPesquisa);
            this.telaPesquisa.Controls.Add(this.txtNomePesquisa);
            this.telaPesquisa.Controls.Add(this.dgFuncoes);
            this.telaPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telaPesquisa.Location = new System.Drawing.Point(4, 26);
            this.telaPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telaPesquisa.Name = "telaPesquisa";
            this.telaPesquisa.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telaPesquisa.Size = new System.Drawing.Size(789, 474);
            this.telaPesquisa.TabIndex = 0;
            this.telaPesquisa.Text = "Pesquisa";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(320, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Função";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(231, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID";
            // 
            // txtIdPesquisa
            // 
            this.txtIdPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdPesquisa.BackColor = System.Drawing.Color.White;
            this.txtIdPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdPesquisa.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtIdPesquisa.Location = new System.Drawing.Point(239, 77);
            this.txtIdPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdPesquisa.Name = "txtIdPesquisa";
            this.txtIdPesquisa.Size = new System.Drawing.Size(83, 23);
            this.txtIdPesquisa.TabIndex = 13;
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
            this.btnPesquisa.Location = new System.Drawing.Point(533, 73);
            this.btnPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(44, 26);
            this.btnPesquisa.TabIndex = 12;
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtNomePesquisa
            // 
            this.txtNomePesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomePesquisa.BackColor = System.Drawing.Color.White;
            this.txtNomePesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomePesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomePesquisa.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtNomePesquisa.Location = new System.Drawing.Point(328, 77);
            this.txtNomePesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomePesquisa.Name = "txtNomePesquisa";
            this.txtNomePesquisa.Size = new System.Drawing.Size(199, 23);
            this.txtNomePesquisa.TabIndex = 11;
            // 
            // dgFuncoes
            // 
            this.dgFuncoes.AllowUserToAddRows = false;
            this.dgFuncoes.AllowUserToDeleteRows = false;
            this.dgFuncoes.AllowUserToOrderColumns = true;
            this.dgFuncoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgFuncoes.BackgroundColor = System.Drawing.Color.Black;
            this.dgFuncoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFuncoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar});
            this.dgFuncoes.GridColor = System.Drawing.Color.Black;
            this.dgFuncoes.Location = new System.Drawing.Point(12, 128);
            this.dgFuncoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgFuncoes.Name = "dgFuncoes";
            this.dgFuncoes.ReadOnly = true;
            this.dgFuncoes.RowHeadersWidth = 51;
            this.dgFuncoes.RowTemplate.Height = 24;
            this.dgFuncoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFuncoes.Size = new System.Drawing.Size(760, 321);
            this.dgFuncoes.TabIndex = 5;
            this.dgFuncoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFuncoes_CellContentClick);
            this.dgFuncoes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFuncoes_CellDoubleClick);
            this.dgFuncoes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgFuncoes_CellFormatting);
            this.dgFuncoes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgFuncoes_DataBindingComplete);
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
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::EscalasMetodista.Properties.Resources._2741104;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 46);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(272, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "GERENCIAR FUNÇÕES";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::EscalasMetodista.Properties.Resources.editar;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 1099;
            // 
            // FormGerenciarFuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(785, 594);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel_rodape);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormGerenciarFuncao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Funções";
            this.Activated += new System.EventHandler(this.FormGerenciarFuncao_Activated);
            this.Load += new System.EventHandler(this.FormGerenciarFunção_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGerenciarFuncao_KeyDown);
            this.panel_rodape.ResumeLayout(false);
            this.panel_rodape.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.telaPesquisa.ResumeLayout(false);
            this.telaPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncoes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_rodape;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage telaPesquisa;
        public System.Windows.Forms.DataGridView dgFuncoes;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdPesquisa;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txtNomePesquisa;
    }
}