namespace EscalasMetodista.Views
{
    partial class FormCadastroSubFuncao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroSubFuncao));
            this.label1 = new System.Windows.Forms.Label();
            this.cbFuncoes = new System.Windows.Forms.ComboBox();
            this.labelNomeProduto = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnSalvar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(79, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Selecione a Função:";
            // 
            // cbFuncoes
            // 
            this.cbFuncoes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbFuncoes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.cbFuncoes.FormattingEnabled = true;
            this.cbFuncoes.Location = new System.Drawing.Point(82, 128);
            this.cbFuncoes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFuncoes.Name = "cbFuncoes";
            this.cbFuncoes.Size = new System.Drawing.Size(201, 22);
            this.cbFuncoes.TabIndex = 36;
            this.cbFuncoes.Text = "Selecione";
            this.cbFuncoes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbFuncoes_KeyDown);
            // 
            // labelNomeProduto
            // 
            this.labelNomeProduto.AutoSize = true;
            this.labelNomeProduto.BackColor = System.Drawing.Color.Transparent;
            this.labelNomeProduto.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.labelNomeProduto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNomeProduto.Location = new System.Drawing.Point(79, 43);
            this.labelNomeProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomeProduto.Name = "labelNomeProduto";
            this.labelNomeProduto.Size = new System.Drawing.Size(107, 17);
            this.labelNomeProduto.TabIndex = 35;
            this.labelNomeProduto.Text = "Sub-Função:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(82, 70);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(201, 22);
            this.txtDescricao.TabIndex = 34;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalvar.FlatAppearance.BorderSize = 2;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnSalvar.IconColor = System.Drawing.Color.Black;
            this.btnSalvar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalvar.IconSize = 22;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSalvar.Location = new System.Drawing.Point(119, 202);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(124, 31);
            this.btnSalvar.TabIndex = 70;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormCadastroSubFuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::EscalasMetodista.Properties.Resources.ocLJYEKLE1aHAy9jGKX_2g_store_banner_image;
            this.ClientSize = new System.Drawing.Size(363, 245);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFuncoes);
            this.Controls.Add(this.labelNomeProduto);
            this.Controls.Add(this.txtDescricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroSubFuncao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Sub-Função";
            this.Load += new System.EventHandler(this.FormCadastroSubFuncao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbFuncoes;
        private System.Windows.Forms.Label labelNomeProduto;
        public System.Windows.Forms.TextBox txtDescricao;
        private FontAwesome.Sharp.IconButton btnSalvar;
    }
}