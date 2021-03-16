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
            this.btnSalvarFuncao = new System.Windows.Forms.Button();
            this.labelDescricaoFuncao = new System.Windows.Forms.Label();
            this.txtDescricaoFuncao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvarFuncao
            // 
            this.btnSalvarFuncao.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvarFuncao.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalvarFuncao.FlatAppearance.BorderSize = 2;
            this.btnSalvarFuncao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarFuncao.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalvarFuncao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalvarFuncao.Location = new System.Drawing.Point(127, 158);
            this.btnSalvarFuncao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvarFuncao.Name = "btnSalvarFuncao";
            this.btnSalvarFuncao.Size = new System.Drawing.Size(165, 39);
            this.btnSalvarFuncao.TabIndex = 36;
            this.btnSalvarFuncao.Text = "SALVAR";
            this.btnSalvarFuncao.UseVisualStyleBackColor = false;
            this.btnSalvarFuncao.Click += new System.EventHandler(this.btnSalvarFuncao_Click);
            // 
            // labelDescricaoFuncao
            // 
            this.labelDescricaoFuncao.AutoSize = true;
            this.labelDescricaoFuncao.BackColor = System.Drawing.Color.Transparent;
            this.labelDescricaoFuncao.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.labelDescricaoFuncao.Location = new System.Drawing.Point(74, 32);
            this.labelDescricaoFuncao.Name = "labelDescricaoFuncao";
            this.labelDescricaoFuncao.Size = new System.Drawing.Size(84, 20);
            this.labelDescricaoFuncao.TabIndex = 38;
            this.labelDescricaoFuncao.Text = "Função:";
            // 
            // txtDescricaoFuncao
            // 
            this.txtDescricaoFuncao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricaoFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoFuncao.Location = new System.Drawing.Point(76, 66);
            this.txtDescricaoFuncao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescricaoFuncao.Name = "txtDescricaoFuncao";
            this.txtDescricaoFuncao.Size = new System.Drawing.Size(267, 26);
            this.txtDescricaoFuncao.TabIndex = 37;
            // 
            // FormCadastroFuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::EscalasMetodista.Properties.Resources.dark_material_design_wallpaper__1_in_4k_by_tgs266_d9j7yts;
            this.ClientSize = new System.Drawing.Size(419, 209);
            this.Controls.Add(this.labelDescricaoFuncao);
            this.Controls.Add(this.txtDescricaoFuncao);
            this.Controls.Add(this.btnSalvarFuncao);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormCadastroFuncao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Função";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarFuncao;
        private System.Windows.Forms.Label labelDescricaoFuncao;
        public System.Windows.Forms.TextBox txtDescricaoFuncao;
    }
}