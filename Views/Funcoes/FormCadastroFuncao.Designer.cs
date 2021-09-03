namespace EscalasMetodista.Views
{
    partial class FormCadastroFuncao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroFuncao));
            this.labelDescricaoFuncao = new System.Windows.Forms.Label();
            this.txtDescricaoFuncao = new System.Windows.Forms.TextBox();
            this.btnSalvar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // labelDescricaoFuncao
            // 
            this.labelDescricaoFuncao.AutoSize = true;
            this.labelDescricaoFuncao.BackColor = System.Drawing.Color.Transparent;
            this.labelDescricaoFuncao.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.labelDescricaoFuncao.Location = new System.Drawing.Point(56, 26);
            this.labelDescricaoFuncao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescricaoFuncao.Name = "labelDescricaoFuncao";
            this.labelDescricaoFuncao.Size = new System.Drawing.Size(70, 17);
            this.labelDescricaoFuncao.TabIndex = 38;
            this.labelDescricaoFuncao.Text = "Função:";
            // 
            // txtDescricaoFuncao
            // 
            this.txtDescricaoFuncao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricaoFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoFuncao.Location = new System.Drawing.Point(57, 54);
            this.txtDescricaoFuncao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescricaoFuncao.Name = "txtDescricaoFuncao";
            this.txtDescricaoFuncao.Size = new System.Drawing.Size(201, 22);
            this.txtDescricaoFuncao.TabIndex = 37;
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
            this.btnSalvar.Location = new System.Drawing.Point(95, 127);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(124, 31);
            this.btnSalvar.TabIndex = 69;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormCadastroFuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::EscalasMetodista.Properties.Resources.dark_material_design_wallpaper__1_in_4k_by_tgs266_d9j7yts;
            this.ClientSize = new System.Drawing.Size(314, 170);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.labelDescricaoFuncao);
            this.Controls.Add(this.txtDescricaoFuncao);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastroFuncao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Função";
            this.Load += new System.EventHandler(this.FormCadastroFuncao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDescricaoFuncao;
        public System.Windows.Forms.TextBox txtDescricaoFuncao;
        private FontAwesome.Sharp.IconButton btnSalvar;
    }
}