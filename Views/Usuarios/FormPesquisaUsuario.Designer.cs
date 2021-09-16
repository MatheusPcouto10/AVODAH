namespace EscalasMetodista.Views.Usuarios
{
    partial class FormPesquisaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisaUsuario));
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoNome = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimparFuncao = new System.Windows.Forms.Button();
            this.cbSubFuncao = new System.Windows.Forms.ComboBox();
            this.cbFuncao = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.dgUsuariosPesquisa = new System.Windows.Forms.DataGridView();
            this.btnLimparForm = new FontAwesome.Sharp.IconButton();
            this.btnPesquisar = new FontAwesome.Sharp.IconButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuariosPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(47, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Informe o Código ou Nome:";
            // 
            // txtCodigoNome
            // 
            this.txtCodigoNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoNome.Location = new System.Drawing.Point(46, 54);
            this.txtCodigoNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoNome.Name = "txtCodigoNome";
            this.txtCodigoNome.Size = new System.Drawing.Size(396, 22);
            this.txtCodigoNome.TabIndex = 41;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnLimparFuncao);
            this.groupBox2.Controls.Add(this.cbSubFuncao);
            this.groupBox2.Controls.Add(this.cbFuncao);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(487, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(407, 73);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Função ";
            // 
            // btnLimparFuncao
            // 
            this.btnLimparFuncao.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimparFuncao.BackgroundImage = global::EscalasMetodista.Properties.Resources.seo_social_web_network_internet_322_icon_icons_com_61532;
            this.btnLimparFuncao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimparFuncao.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimparFuncao.FlatAppearance.BorderSize = 2;
            this.btnLimparFuncao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparFuncao.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimparFuncao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimparFuncao.Location = new System.Drawing.Point(392, 7);
            this.btnLimparFuncao.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimparFuncao.Name = "btnLimparFuncao";
            this.btnLimparFuncao.Size = new System.Drawing.Size(15, 16);
            this.btnLimparFuncao.TabIndex = 65;
            this.btnLimparFuncao.UseVisualStyleBackColor = false;
            this.btnLimparFuncao.Click += new System.EventHandler(this.btnLimparFuncao_Click);
            // 
            // cbSubFuncao
            // 
            this.cbSubFuncao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbSubFuncao.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cbSubFuncao.FormattingEnabled = true;
            this.cbSubFuncao.Location = new System.Drawing.Point(210, 37);
            this.cbSubFuncao.Margin = new System.Windows.Forms.Padding(2);
            this.cbSubFuncao.Name = "cbSubFuncao";
            this.cbSubFuncao.Size = new System.Drawing.Size(193, 24);
            this.cbSubFuncao.TabIndex = 38;
            this.cbSubFuncao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbSubFuncao_KeyDown);
            // 
            // cbFuncao
            // 
            this.cbFuncao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbFuncao.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cbFuncao.FormattingEnabled = true;
            this.cbFuncao.Location = new System.Drawing.Point(4, 37);
            this.cbFuncao.Margin = new System.Windows.Forms.Padding(2);
            this.cbFuncao.Name = "cbFuncao";
            this.cbFuncao.Size = new System.Drawing.Size(202, 24);
            this.cbFuncao.TabIndex = 31;
            this.cbFuncao.SelectedIndexChanged += new System.EventHandler(this.cbFuncao_SelectedIndexChanged);
            this.cbFuncao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbFuncao_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(47, 105);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 17);
            this.label9.TabIndex = 77;
            this.label9.Text = "Tipo de Usuário:";
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTipoUsuario.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.Location = new System.Drawing.Point(50, 138);
            this.cbTipoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(224, 24);
            this.cbTipoUsuario.TabIndex = 76;
            this.cbTipoUsuario.Text = "Selecione...";
            this.cbTipoUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbTipoUsuario_KeyDown);
            // 
            // dgUsuariosPesquisa
            // 
            this.dgUsuariosPesquisa.AllowUserToAddRows = false;
            this.dgUsuariosPesquisa.AllowUserToDeleteRows = false;
            this.dgUsuariosPesquisa.AllowUserToOrderColumns = true;
            this.dgUsuariosPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgUsuariosPesquisa.BackgroundColor = System.Drawing.Color.Black;
            this.dgUsuariosPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuariosPesquisa.GridColor = System.Drawing.Color.Black;
            this.dgUsuariosPesquisa.Location = new System.Drawing.Point(7, 185);
            this.dgUsuariosPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.dgUsuariosPesquisa.Name = "dgUsuariosPesquisa";
            this.dgUsuariosPesquisa.ReadOnly = true;
            this.dgUsuariosPesquisa.RowHeadersWidth = 51;
            this.dgUsuariosPesquisa.RowTemplate.Height = 24;
            this.dgUsuariosPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsuariosPesquisa.Size = new System.Drawing.Size(981, 214);
            this.dgUsuariosPesquisa.TabIndex = 78;
            this.dgUsuariosPesquisa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsuariosPesquisa_CellClick);
            this.dgUsuariosPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsuariosPesquisa_CellDoubleClick);
            this.dgUsuariosPesquisa.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgUsuariosPesquisa_DataBindingComplete);
            // 
            // btnLimparForm
            // 
            this.btnLimparForm.BackColor = System.Drawing.Color.Transparent;
            this.btnLimparForm.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnLimparForm.FlatAppearance.BorderSize = 2;
            this.btnLimparForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparForm.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimparForm.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimparForm.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimparForm.IconColor = System.Drawing.Color.LightGray;
            this.btnLimparForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimparForm.IconSize = 22;
            this.btnLimparForm.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLimparForm.Location = new System.Drawing.Point(673, 138);
            this.btnLimparForm.Name = "btnLimparForm";
            this.btnLimparForm.Size = new System.Drawing.Size(142, 29);
            this.btnLimparForm.TabIndex = 80;
            this.btnLimparForm.Text = "LIMPAR";
            this.btnLimparForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparForm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimparForm.UseVisualStyleBackColor = true;
            this.btnLimparForm.Click += new System.EventHandler(this.btnLimparForm_Click);
            this.btnLimparForm.MouseLeave += new System.EventHandler(this.btnLimparForm_MouseLeave);
            this.btnLimparForm.MouseHover += new System.EventHandler(this.btnLimparForm_MouseHover);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPesquisar.FlatAppearance.BorderSize = 2;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnPesquisar.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnPesquisar.IconColor = System.Drawing.Color.Black;
            this.btnPesquisar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPesquisar.IconSize = 22;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnPesquisar.Location = new System.Drawing.Point(841, 138);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(142, 31);
            this.btnPesquisar.TabIndex = 81;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // FormPesquisaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::EscalasMetodista.Properties.Resources.dark_material_design_wallpaper__1_in_4k_by_tgs266_d9j7yts;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(995, 413);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnLimparForm);
            this.Controls.Add(this.dgUsuariosPesquisa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbTipoUsuario);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigoNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPesquisaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Usuário";
            this.Load += new System.EventHandler(this.FormPesquisaUsuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPesquisaUsuario_KeyDown);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuariosPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLimparFuncao;
        public System.Windows.Forms.ComboBox cbSubFuncao;
        public System.Windows.Forms.ComboBox cbFuncao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbTipoUsuario;
        public System.Windows.Forms.DataGridView dgUsuariosPesquisa;
        private FontAwesome.Sharp.IconButton btnLimparForm;
        private FontAwesome.Sharp.IconButton btnPesquisar;
    }
}