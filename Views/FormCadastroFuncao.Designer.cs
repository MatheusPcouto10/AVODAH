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
            this.btnCadastrarFuncao = new System.Windows.Forms.Button();
            this.labelNomeProduto = new System.Windows.Forms.Label();
            this.txtdescricaoFuncao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadastrarFuncao
            // 
            this.btnCadastrarFuncao.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastrarFuncao.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadastrarFuncao.FlatAppearance.BorderSize = 2;
            this.btnCadastrarFuncao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFuncao.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnCadastrarFuncao.Location = new System.Drawing.Point(124, 158);
            this.btnCadastrarFuncao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrarFuncao.Name = "btnCadastrarFuncao";
            this.btnCadastrarFuncao.Size = new System.Drawing.Size(165, 40);
            this.btnCadastrarFuncao.TabIndex = 36;
            this.btnCadastrarFuncao.Text = "CADASTRAR";
            this.btnCadastrarFuncao.UseVisualStyleBackColor = false;
            this.btnCadastrarFuncao.Click += new System.EventHandler(this.btnCadastrarFuncao_Click);
            // 
            // labelNomeProduto
            // 
            this.labelNomeProduto.AutoSize = true;
            this.labelNomeProduto.BackColor = System.Drawing.Color.Transparent;
            this.labelNomeProduto.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.labelNomeProduto.Location = new System.Drawing.Point(82, 42);
            this.labelNomeProduto.Name = "labelNomeProduto";
            this.labelNomeProduto.Size = new System.Drawing.Size(84, 20);
            this.labelNomeProduto.TabIndex = 38;
            this.labelNomeProduto.Text = "Função:";
            // 
            // txtdescricaoFuncao
            // 
            this.txtdescricaoFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricaoFuncao.Location = new System.Drawing.Point(82, 67);
            this.txtdescricaoFuncao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdescricaoFuncao.Name = "txtdescricaoFuncao";
            this.txtdescricaoFuncao.Size = new System.Drawing.Size(267, 26);
            this.txtdescricaoFuncao.TabIndex = 37;
            // 
            // FormCadastroFuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(418, 209);
            this.Controls.Add(this.labelNomeProduto);
            this.Controls.Add(this.txtdescricaoFuncao);
            this.Controls.Add(this.btnCadastrarFuncao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCadastroFuncao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Função";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroFuncao_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarFuncao;
        private System.Windows.Forms.Label labelNomeProduto;
        public System.Windows.Forms.TextBox txtdescricaoFuncao;
    }
}