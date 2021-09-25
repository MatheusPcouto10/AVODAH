namespace EscalasMetodista.Views.Usuarios
{
    partial class FormCadastrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrarUsuario));
            this.panel_rodape = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimparFuncaoPrincipal = new FontAwesome.Sharp.IconButton();
            this.cbSubFuncaoPrincipal = new System.Windows.Forms.ComboBox();
            this.cbFuncaoPrincipal = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimparFuncaoSecundaria = new FontAwesome.Sharp.IconButton();
            this.cbSubFuncaoSecundaria = new System.Windows.Forms.ComboBox();
            this.cbFuncaoSecundaria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.btnSalvar = new FontAwesome.Sharp.IconButton();
            this.btnDeletar = new FontAwesome.Sharp.IconButton();
            this.btnLimparForm = new FontAwesome.Sharp.IconButton();
            this.btnConsultarUsuario = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel_rodape.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_rodape
            // 
            this.panel_rodape.BackColor = System.Drawing.Color.Black;
            this.panel_rodape.BackgroundImage = global::EscalasMetodista.Properties.Resources._2741104;
            this.panel_rodape.Controls.Add(this.btnVoltar);
            this.panel_rodape.Controls.Add(this.label1);
            this.panel_rodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_rodape.Location = new System.Drawing.Point(0, 531);
            this.panel_rodape.Margin = new System.Windows.Forms.Padding(2);
            this.panel_rodape.Name = "panel_rodape";
            this.panel_rodape.Size = new System.Drawing.Size(835, 37);
            this.panel_rodape.TabIndex = 5;
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
            this.label1.Location = new System.Drawing.Point(200, 11);
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
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 57);
            this.panel1.TabIndex = 7;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Verdana", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(293, 17);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(249, 23);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "CADASTRAR USUÁRIO";
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTipoUsuario.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.Location = new System.Drawing.Point(57, 401);
            this.cbTipoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(178, 24);
            this.cbTipoUsuario.TabIndex = 48;
            this.cbTipoUsuario.SelectedValueChanged += new System.EventHandler(this.cbTipoUsuario_SelectedValueChanged);
            this.cbTipoUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbTipoUsuario_KeyDown);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(54, 369);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "Tipo de Usuário:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnLimparFuncaoPrincipal);
            this.groupBox1.Controls.Add(this.cbSubFuncaoPrincipal);
            this.groupBox1.Controls.Add(this.cbFuncaoPrincipal);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(403, 148);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(408, 87);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Função Principal";
            // 
            // btnLimparFuncaoPrincipal
            // 
            this.btnLimparFuncaoPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimparFuncaoPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparFuncaoPrincipal.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnLimparFuncaoPrincipal.IconColor = System.Drawing.Color.Black;
            this.btnLimparFuncaoPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimparFuncaoPrincipal.IconSize = 15;
            this.btnLimparFuncaoPrincipal.Location = new System.Drawing.Point(388, 8);
            this.btnLimparFuncaoPrincipal.Name = "btnLimparFuncaoPrincipal";
            this.btnLimparFuncaoPrincipal.Size = new System.Drawing.Size(20, 18);
            this.btnLimparFuncaoPrincipal.TabIndex = 39;
            this.btnLimparFuncaoPrincipal.UseVisualStyleBackColor = false;
            this.btnLimparFuncaoPrincipal.Click += new System.EventHandler(this.btnLimparFuncaoPrincipal_Click);
            // 
            // cbSubFuncaoPrincipal
            // 
            this.cbSubFuncaoPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbSubFuncaoPrincipal.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cbSubFuncaoPrincipal.FormattingEnabled = true;
            this.cbSubFuncaoPrincipal.Location = new System.Drawing.Point(209, 37);
            this.cbSubFuncaoPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.cbSubFuncaoPrincipal.Name = "cbSubFuncaoPrincipal";
            this.cbSubFuncaoPrincipal.Size = new System.Drawing.Size(181, 24);
            this.cbSubFuncaoPrincipal.TabIndex = 38;
            this.cbSubFuncaoPrincipal.SelectionChangeCommitted += new System.EventHandler(this.cbSubFuncaoPrincipal_SelectionChangeCommitted);
            this.cbSubFuncaoPrincipal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbSubFuncaoPrincipal_KeyDown);
            // 
            // cbFuncaoPrincipal
            // 
            this.cbFuncaoPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbFuncaoPrincipal.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cbFuncaoPrincipal.FormattingEnabled = true;
            this.cbFuncaoPrincipal.Location = new System.Drawing.Point(4, 37);
            this.cbFuncaoPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.cbFuncaoPrincipal.Name = "cbFuncaoPrincipal";
            this.cbFuncaoPrincipal.Size = new System.Drawing.Size(201, 24);
            this.cbFuncaoPrincipal.TabIndex = 31;
            this.cbFuncaoPrincipal.SelectedValueChanged += new System.EventHandler(this.cbFuncaoPrincipal_SelectedValueChanged);
            this.cbFuncaoPrincipal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbFuncaoPrincipal_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnLimparFuncaoSecundaria);
            this.groupBox2.Controls.Add(this.cbSubFuncaoSecundaria);
            this.groupBox2.Controls.Add(this.cbFuncaoSecundaria);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(403, 252);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(408, 87);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Função Secundária";
            // 
            // btnLimparFuncaoSecundaria
            // 
            this.btnLimparFuncaoSecundaria.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimparFuncaoSecundaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparFuncaoSecundaria.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnLimparFuncaoSecundaria.IconColor = System.Drawing.Color.Black;
            this.btnLimparFuncaoSecundaria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimparFuncaoSecundaria.IconSize = 15;
            this.btnLimparFuncaoSecundaria.Location = new System.Drawing.Point(388, 8);
            this.btnLimparFuncaoSecundaria.Name = "btnLimparFuncaoSecundaria";
            this.btnLimparFuncaoSecundaria.Size = new System.Drawing.Size(20, 18);
            this.btnLimparFuncaoSecundaria.TabIndex = 72;
            this.btnLimparFuncaoSecundaria.UseVisualStyleBackColor = false;
            this.btnLimparFuncaoSecundaria.Click += new System.EventHandler(this.btnLimparFuncaoSecundaria_Click);
            // 
            // cbSubFuncaoSecundaria
            // 
            this.cbSubFuncaoSecundaria.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbSubFuncaoSecundaria.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cbSubFuncaoSecundaria.FormattingEnabled = true;
            this.cbSubFuncaoSecundaria.Location = new System.Drawing.Point(209, 36);
            this.cbSubFuncaoSecundaria.Margin = new System.Windows.Forms.Padding(2);
            this.cbSubFuncaoSecundaria.Name = "cbSubFuncaoSecundaria";
            this.cbSubFuncaoSecundaria.Size = new System.Drawing.Size(181, 24);
            this.cbSubFuncaoSecundaria.TabIndex = 38;
            this.cbSubFuncaoSecundaria.SelectionChangeCommitted += new System.EventHandler(this.cbSubFuncaoSecundaria_SelectionChangeCommitted);
            this.cbSubFuncaoSecundaria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbSubFuncaoSecundaria_KeyDown);
            // 
            // cbFuncaoSecundaria
            // 
            this.cbFuncaoSecundaria.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbFuncaoSecundaria.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cbFuncaoSecundaria.FormattingEnabled = true;
            this.cbFuncaoSecundaria.Location = new System.Drawing.Point(4, 36);
            this.cbFuncaoSecundaria.Margin = new System.Windows.Forms.Padding(2);
            this.cbFuncaoSecundaria.Name = "cbFuncaoSecundaria";
            this.cbFuncaoSecundaria.Size = new System.Drawing.Size(201, 24);
            this.cbFuncaoSecundaria.TabIndex = 31;
            this.cbFuncaoSecundaria.SelectedValueChanged += new System.EventHandler(this.cbFuncaoSecundaria_SelectedValueChanged);
            this.cbFuncaoSecundaria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbFuncaoSecundaria_KeyDown);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(54, 291);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(57, 325);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(297, 22);
            this.txtEmail.TabIndex = 43;
            this.txtEmail.MouseLeave += new System.EventHandler(this.txtEmail_MouseLeave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(54, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Sobrenome:";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSobrenome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenome.Location = new System.Drawing.Point(57, 253);
            this.txtSobrenome.Margin = new System.Windows.Forms.Padding(2);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(297, 22);
            this.txtSobrenome.TabIndex = 41;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(57, 182);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(297, 22);
            this.txtNome.TabIndex = 39;
            // 
            // labelNome
            // 
            this.labelNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.Color.Transparent;
            this.labelNome.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.labelNome.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNome.Location = new System.Drawing.Point(54, 148);
            this.labelNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(58, 17);
            this.labelNome.TabIndex = 40;
            this.labelNome.Text = "Nome:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalvar.FlatAppearance.BorderSize = 2;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnSalvar.IconColor = System.Drawing.Color.Black;
            this.btnSalvar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalvar.IconSize = 22;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSalvar.Location = new System.Drawing.Point(226, 480);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(124, 31);
            this.btnSalvar.TabIndex = 67;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletar.BackColor = System.Drawing.Color.Maroon;
            this.btnDeletar.Enabled = false;
            this.btnDeletar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeletar.FlatAppearance.BorderSize = 2;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeletar.ForeColor = System.Drawing.Color.Black;
            this.btnDeletar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeletar.IconColor = System.Drawing.Color.Black;
            this.btnDeletar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeletar.IconSize = 22;
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDeletar.Location = new System.Drawing.Point(357, 480);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(122, 31);
            this.btnDeletar.TabIndex = 68;
            this.btnDeletar.Text = "EXCLUIR";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
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
            this.btnLimparForm.Location = new System.Drawing.Point(486, 480);
            this.btnLimparForm.Name = "btnLimparForm";
            this.btnLimparForm.Size = new System.Drawing.Size(122, 31);
            this.btnLimparForm.TabIndex = 69;
            this.btnLimparForm.Text = "LIMPAR";
            this.btnLimparForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparForm.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimparForm.UseVisualStyleBackColor = true;
            this.btnLimparForm.Click += new System.EventHandler(this.btnLimparForm_Click);
            this.btnLimparForm.MouseLeave += new System.EventHandler(this.btnLimparForm_MouseLeave);
            this.btnLimparForm.MouseHover += new System.EventHandler(this.btnLimparForm_MouseHover);
            // 
            // btnConsultarUsuario
            // 
            this.btnConsultarUsuario.BackColor = System.Drawing.Color.DarkOrange;
            this.btnConsultarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConsultarUsuario.FlatAppearance.BorderSize = 2;
            this.btnConsultarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarUsuario.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.btnConsultarUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnConsultarUsuario.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnConsultarUsuario.IconColor = System.Drawing.Color.Black;
            this.btnConsultarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsultarUsuario.IconSize = 22;
            this.btnConsultarUsuario.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnConsultarUsuario.Location = new System.Drawing.Point(637, 83);
            this.btnConsultarUsuario.Name = "btnConsultarUsuario";
            this.btnConsultarUsuario.Size = new System.Drawing.Size(174, 31);
            this.btnConsultarUsuario.TabIndex = 70;
            this.btnConsultarUsuario.Text = "Consultar Usuário";
            this.btnConsultarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConsultarUsuario.UseVisualStyleBackColor = false;
            this.btnConsultarUsuario.Click += new System.EventHandler(this.btnConsultarUsuario_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(111, 293);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 14);
            this.label2.TabIndex = 71;
            this.label2.Text = "(exemplo@exemplo.com)";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(54, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "(*) Campos Obrigatórios";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(109, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "*";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(185, 371);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 74;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(538, 144);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 75;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(152, 222);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 76;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(282, 293);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 77;
            this.label11.Text = "*";
            // 
            // FormCadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::EscalasMetodista.Properties.Resources.sobreposicao_de_rotulo_vermelho_sobre_fundo_metalico_cinzento_escuro_33869_1241;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 568);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsultarUsuario);
            this.Controls.Add(this.btnLimparForm);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbTipoUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_rodape);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormCadastrarUsuario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Usuário";
            this.Load += new System.EventHandler(this.FormCadastrarUsuario_Load);
            this.panel_rodape.ResumeLayout(false);
            this.panel_rodape.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_rodape;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cbSubFuncaoPrincipal;
        public System.Windows.Forms.ComboBox cbFuncaoPrincipal;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ComboBox cbSubFuncaoSecundaria;
        public System.Windows.Forms.ComboBox cbFuncaoSecundaria;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtSobrenome;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelNome;
        public System.Windows.Forms.ComboBox cbTipoUsuario;
        public FontAwesome.Sharp.IconButton btnDeletar;
        public FontAwesome.Sharp.IconButton btnLimparForm;
        public FontAwesome.Sharp.IconButton btnConsultarUsuario;
        public FontAwesome.Sharp.IconButton btnSalvar;
        public System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label label2;
        public FontAwesome.Sharp.IconButton btnLimparFuncaoPrincipal;
        public FontAwesome.Sharp.IconButton btnLimparFuncaoSecundaria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}