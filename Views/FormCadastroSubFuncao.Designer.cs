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
            this.btnCadastrarSubFuncao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(76, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Selecione a Função:";
            // 
            // cbFuncoes
            // 
            this.cbFuncoes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbFuncoes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.cbFuncoes.FormattingEnabled = true;
            this.cbFuncoes.Location = new System.Drawing.Point(79, 128);
            this.cbFuncoes.Margin = new System.Windows.Forms.Padding(2);
            this.cbFuncoes.Name = "cbFuncoes";
            this.cbFuncoes.Size = new System.Drawing.Size(201, 26);
            this.cbFuncoes.TabIndex = 36;
            this.cbFuncoes.Text = "Selecione...";
            // 
            // labelNomeProduto
            // 
            this.labelNomeProduto.AutoSize = true;
            this.labelNomeProduto.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.labelNomeProduto.Location = new System.Drawing.Point(76, 42);
            this.labelNomeProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomeProduto.Name = "labelNomeProduto";
            this.labelNomeProduto.Size = new System.Drawing.Size(128, 20);
            this.labelNomeProduto.TabIndex = 35;
            this.labelNomeProduto.Text = "Sub-Função:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(79, 70);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(201, 26);
            this.txtDescricao.TabIndex = 34;
            // 
            // btnCadastrarSubFuncao
            // 
            this.btnCadastrarSubFuncao.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastrarSubFuncao.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCadastrarSubFuncao.FlatAppearance.BorderSize = 2;
            this.btnCadastrarSubFuncao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarSubFuncao.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnCadastrarSubFuncao.Location = new System.Drawing.Point(116, 206);
            this.btnCadastrarSubFuncao.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrarSubFuncao.Name = "btnCadastrarSubFuncao";
            this.btnCadastrarSubFuncao.Size = new System.Drawing.Size(124, 31);
            this.btnCadastrarSubFuncao.TabIndex = 38;
            this.btnCadastrarSubFuncao.Text = "ADICIONAR";
            this.btnCadastrarSubFuncao.UseVisualStyleBackColor = false;
            this.btnCadastrarSubFuncao.Click += new System.EventHandler(this.btnCadastrarSubFuncao_Click);
            // 
            // FormCadastroSubFuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(363, 245);
            this.Controls.Add(this.btnCadastrarSubFuncao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFuncoes);
            this.Controls.Add(this.labelNomeProduto);
            this.Controls.Add(this.txtDescricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormCadastroSubFuncao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Sub-Função";
            this.Load += new System.EventHandler(this.FormCadastroSubFuncao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCadastroSubFuncao_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbFuncoes;
        private System.Windows.Forms.Label labelNomeProduto;
        public System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnCadastrarSubFuncao;
    }
}