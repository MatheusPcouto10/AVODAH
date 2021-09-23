namespace EscalasMetodista.Views
{
    partial class FormAlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlterarSenha));
            this.labelNomeProduto = new System.Windows.Forms.Label();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.checkMostrarSenha = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // labelNomeProduto
            // 
            this.labelNomeProduto.AutoSize = true;
            this.labelNomeProduto.BackColor = System.Drawing.Color.Transparent;
            this.labelNomeProduto.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.labelNomeProduto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNomeProduto.Location = new System.Drawing.Point(53, 15);
            this.labelNomeProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomeProduto.Name = "labelNomeProduto";
            this.labelNomeProduto.Size = new System.Drawing.Size(107, 17);
            this.labelNomeProduto.TabIndex = 37;
            this.labelNomeProduto.Text = "Senha Atual:";
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaAtual.Location = new System.Drawing.Point(55, 41);
            this.txtSenhaAtual.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.Size = new System.Drawing.Size(201, 22);
            this.txtSenhaAtual.TabIndex = 36;
            this.txtSenhaAtual.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(53, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nova Senha:";
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSenha.Location = new System.Drawing.Point(55, 105);
            this.txtNovaSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(201, 22);
            this.txtNovaSenha.TabIndex = 38;
            this.txtNovaSenha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(53, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Confirmar Senha:";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarSenha.Location = new System.Drawing.Point(55, 168);
            this.txtConfirmarSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(201, 22);
            this.txtConfirmarSenha.TabIndex = 40;
            this.txtConfirmarSenha.UseSystemPasswordChar = true;
            // 
            // checkMostrarSenha
            // 
            this.checkMostrarSenha.AutoSize = true;
            this.checkMostrarSenha.BackColor = System.Drawing.Color.Transparent;
            this.checkMostrarSenha.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.checkMostrarSenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkMostrarSenha.Location = new System.Drawing.Point(56, 206);
            this.checkMostrarSenha.Margin = new System.Windows.Forms.Padding(2);
            this.checkMostrarSenha.Name = "checkMostrarSenha";
            this.checkMostrarSenha.Size = new System.Drawing.Size(119, 17);
            this.checkMostrarSenha.TabIndex = 43;
            this.checkMostrarSenha.Text = "Mostrar senha";
            this.checkMostrarSenha.UseVisualStyleBackColor = false;
            this.checkMostrarSenha.CheckedChanged += new System.EventHandler(this.checkMostrarSenha_CheckedChanged);
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
            this.btnSalvar.Location = new System.Drawing.Point(93, 245);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(124, 31);
            this.btnSalvar.TabIndex = 68;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::EscalasMetodista.Properties.Resources.dark_material_design_wallpaper__1_in_4k_by_tgs266_d9j7yts;
            this.ClientSize = new System.Drawing.Size(310, 288);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.checkMostrarSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.labelNomeProduto);
            this.Controls.Add(this.txtSenhaAtual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAlterarSenha";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeProduto;
        public System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.CheckBox checkMostrarSenha;
        private FontAwesome.Sharp.IconButton btnSalvar;
    }
}