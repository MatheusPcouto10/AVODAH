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
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvarUsuario = new System.Windows.Forms.Button();
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dtCadastro = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimparFuncaoPrincipal = new System.Windows.Forms.Button();
            this.cbSubFuncaoPrincipal = new System.Windows.Forms.ComboBox();
            this.cbFuncaoPrincipal = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimparFuncaoSecundaria = new System.Windows.Forms.Button();
            this.cbSubFuncaoSecundaria = new System.Windows.Forms.ComboBox();
            this.cbFuncaoSecundaria = new System.Windows.Forms.ComboBox();
            this.checkMostrarSenha = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.panel_rodape.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_rodape
            // 
            this.panel_rodape.BackColor = System.Drawing.Color.Transparent;
            this.panel_rodape.BackgroundImage = global::EscalasMetodista.Properties.Resources._2741104;
            this.panel_rodape.Controls.Add(this.btnVoltar);
            this.panel_rodape.Controls.Add(this.label1);
            this.panel_rodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_rodape.Location = new System.Drawing.Point(0, 654);
            this.panel_rodape.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_rodape.Name = "panel_rodape";
            this.panel_rodape.Size = new System.Drawing.Size(1113, 45);
            this.panel_rodape.TabIndex = 5;
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
            this.label1.Location = new System.Drawing.Point(391, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desenvolvido por Matheus Pimentel - 2020";
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
            this.panel1.Size = new System.Drawing.Size(1113, 70);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(420, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "CADASTRAR USUÁRIO";
            // 
            // btnSalvarUsuario
            // 
            this.btnSalvarUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalvarUsuario.FlatAppearance.BorderSize = 2;
            this.btnSalvarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarUsuario.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalvarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalvarUsuario.Location = new System.Drawing.Point(394, 601);
            this.btnSalvarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvarUsuario.Name = "btnSalvarUsuario";
            this.btnSalvarUsuario.Size = new System.Drawing.Size(165, 39);
            this.btnSalvarUsuario.TabIndex = 47;
            this.btnSalvarUsuario.Text = "SALVAR";
            this.btnSalvarUsuario.UseVisualStyleBackColor = false;
            this.btnSalvarUsuario.Click += new System.EventHandler(this.btnSalvarUsuario_Click);
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTipoUsuario.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.Location = new System.Drawing.Point(603, 409);
            this.cbTipoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(167, 28);
            this.cbTipoUsuario.TabIndex = 48;
            this.cbTipoUsuario.Text = "Selecione...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(599, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 20);
            this.label7.TabIndex = 54;
            this.label7.Text = "Tipo de Usuário:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.LightGray;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatAppearance.BorderSize = 2;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpar.Location = new System.Drawing.Point(567, 601);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(165, 39);
            this.btnLimpar.TabIndex = 59;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dtCadastro
            // 
            this.dtCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtCadastro.CalendarFont = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.dtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCadastro.Location = new System.Drawing.Point(798, 409);
            this.dtCadastro.Name = "dtCadastro";
            this.dtCadastro.Size = new System.Drawing.Size(225, 24);
            this.dtCadastro.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(794, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 20);
            this.label8.TabIndex = 61;
            this.label8.Text = "Data de Cadastro:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnLimparFuncaoPrincipal);
            this.groupBox1.Controls.Add(this.cbSubFuncaoPrincipal);
            this.groupBox1.Controls.Add(this.cbFuncaoPrincipal);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(603, 115);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(420, 107);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Função Principal";
            // 
            // btnLimparFuncaoPrincipal
            // 
            this.btnLimparFuncaoPrincipal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimparFuncaoPrincipal.BackgroundImage = global::EscalasMetodista.Properties.Resources.seo_social_web_network_internet_322_icon_icons_com_61532;
            this.btnLimparFuncaoPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimparFuncaoPrincipal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimparFuncaoPrincipal.FlatAppearance.BorderSize = 2;
            this.btnLimparFuncaoPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparFuncaoPrincipal.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimparFuncaoPrincipal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimparFuncaoPrincipal.Location = new System.Drawing.Point(400, 10);
            this.btnLimparFuncaoPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimparFuncaoPrincipal.Name = "btnLimparFuncaoPrincipal";
            this.btnLimparFuncaoPrincipal.Size = new System.Drawing.Size(20, 20);
            this.btnLimparFuncaoPrincipal.TabIndex = 66;
            this.btnLimparFuncaoPrincipal.UseVisualStyleBackColor = false;
            this.btnLimparFuncaoPrincipal.Click += new System.EventHandler(this.btnLimparFuncaoPrincipal_Click);
            // 
            // cbSubFuncaoPrincipal
            // 
            this.cbSubFuncaoPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbSubFuncaoPrincipal.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cbSubFuncaoPrincipal.FormattingEnabled = true;
            this.cbSubFuncaoPrincipal.Location = new System.Drawing.Point(195, 45);
            this.cbSubFuncaoPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSubFuncaoPrincipal.Name = "cbSubFuncaoPrincipal";
            this.cbSubFuncaoPrincipal.Size = new System.Drawing.Size(202, 28);
            this.cbSubFuncaoPrincipal.TabIndex = 38;
            this.cbSubFuncaoPrincipal.Text = "Selecione...";
            // 
            // cbFuncaoPrincipal
            // 
            this.cbFuncaoPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbFuncaoPrincipal.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cbFuncaoPrincipal.FormattingEnabled = true;
            this.cbFuncaoPrincipal.Location = new System.Drawing.Point(6, 45);
            this.cbFuncaoPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFuncaoPrincipal.Name = "cbFuncaoPrincipal";
            this.cbFuncaoPrincipal.Size = new System.Drawing.Size(169, 28);
            this.cbFuncaoPrincipal.TabIndex = 31;
            this.cbFuncaoPrincipal.Text = "Selecione...";
            this.cbFuncaoPrincipal.SelectedIndexChanged += new System.EventHandler(this.cbFuncaoPrincipal_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnLimparFuncaoSecundaria);
            this.groupBox2.Controls.Add(this.cbSubFuncaoSecundaria);
            this.groupBox2.Controls.Add(this.cbFuncaoSecundaria);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(603, 242);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(420, 107);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Função Secundária";
            // 
            // btnLimparFuncaoSecundaria
            // 
            this.btnLimparFuncaoSecundaria.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimparFuncaoSecundaria.BackgroundImage = global::EscalasMetodista.Properties.Resources.seo_social_web_network_internet_322_icon_icons_com_61532;
            this.btnLimparFuncaoSecundaria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimparFuncaoSecundaria.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimparFuncaoSecundaria.FlatAppearance.BorderSize = 2;
            this.btnLimparFuncaoSecundaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparFuncaoSecundaria.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimparFuncaoSecundaria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimparFuncaoSecundaria.Location = new System.Drawing.Point(400, 8);
            this.btnLimparFuncaoSecundaria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimparFuncaoSecundaria.Name = "btnLimparFuncaoSecundaria";
            this.btnLimparFuncaoSecundaria.Size = new System.Drawing.Size(20, 20);
            this.btnLimparFuncaoSecundaria.TabIndex = 65;
            this.btnLimparFuncaoSecundaria.UseVisualStyleBackColor = false;
            this.btnLimparFuncaoSecundaria.Click += new System.EventHandler(this.btnLimparFuncaoSecundaria_Click);
            // 
            // cbSubFuncaoSecundaria
            // 
            this.cbSubFuncaoSecundaria.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbSubFuncaoSecundaria.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cbSubFuncaoSecundaria.FormattingEnabled = true;
            this.cbSubFuncaoSecundaria.Location = new System.Drawing.Point(195, 45);
            this.cbSubFuncaoSecundaria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSubFuncaoSecundaria.Name = "cbSubFuncaoSecundaria";
            this.cbSubFuncaoSecundaria.Size = new System.Drawing.Size(202, 28);
            this.cbSubFuncaoSecundaria.TabIndex = 38;
            this.cbSubFuncaoSecundaria.Text = "Selecione...";
            // 
            // cbFuncaoSecundaria
            // 
            this.cbFuncaoSecundaria.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbFuncaoSecundaria.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cbFuncaoSecundaria.FormattingEnabled = true;
            this.cbFuncaoSecundaria.Location = new System.Drawing.Point(6, 45);
            this.cbFuncaoSecundaria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFuncaoSecundaria.Name = "cbFuncaoSecundaria";
            this.cbFuncaoSecundaria.Size = new System.Drawing.Size(169, 28);
            this.cbFuncaoSecundaria.TabIndex = 31;
            this.cbFuncaoSecundaria.Text = "Selecione...";
            this.cbFuncaoSecundaria.SelectedIndexChanged += new System.EventHandler(this.cbFuncaoSecundaria_SelectedIndexChanged);
            // 
            // checkMostrarSenha
            // 
            this.checkMostrarSenha.AutoSize = true;
            this.checkMostrarSenha.BackColor = System.Drawing.Color.Transparent;
            this.checkMostrarSenha.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.checkMostrarSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.checkMostrarSenha.Location = new System.Drawing.Point(223, 382);
            this.checkMostrarSenha.Name = "checkMostrarSenha";
            this.checkMostrarSenha.Size = new System.Drawing.Size(141, 21);
            this.checkMostrarSenha.TabIndex = 64;
            this.checkMostrarSenha.Text = "Mostrar senha";
            this.checkMostrarSenha.UseVisualStyleBackColor = false;
            this.checkMostrarSenha.CheckedChanged += new System.EventHandler(this.checkMostrarSenha_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(143, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Confirmar Senha:";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarSenha.Location = new System.Drawing.Point(147, 508);
            this.txtConfirmarSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(267, 26);
            this.txtConfirmarSenha.TabIndex = 52;
            this.txtConfirmarSenha.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(143, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(147, 420);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(267, 26);
            this.txtSenha.TabIndex = 45;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(143, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(147, 332);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(267, 26);
            this.txtEmail.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(143, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Sobrenome:";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenome.Location = new System.Drawing.Point(147, 244);
            this.txtSobrenome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(267, 26);
            this.txtSobrenome.TabIndex = 41;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(147, 156);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(267, 26);
            this.txtNome.TabIndex = 39;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.Color.Transparent;
            this.labelNome.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.labelNome.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNome.Location = new System.Drawing.Point(143, 115);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(71, 20);
            this.labelNome.TabIndex = 40;
            this.labelNome.Text = "Nome:";
            // 
            // FormCadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::EscalasMetodista.Properties.Resources.sobreposicao_de_rotulo_vermelho_sobre_fundo_metalico_cinzento_escuro_33869_1241;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1113, 699);
            this.Controls.Add(this.checkMostrarSenha);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtCadastro);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.cbTipoUsuario);
            this.Controls.Add(this.btnSalvarUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSenha);
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
            this.Name = "FormCadastrarUsuario";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvarUsuario;
        private System.Windows.Forms.ComboBox cbTipoUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DateTimePicker dtCadastro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cbSubFuncaoPrincipal;
        public System.Windows.Forms.ComboBox cbFuncaoPrincipal;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ComboBox cbSubFuncaoSecundaria;
        public System.Windows.Forms.ComboBox cbFuncaoSecundaria;
        private System.Windows.Forms.Button btnLimparFuncaoSecundaria;
        private System.Windows.Forms.Button btnLimparFuncaoPrincipal;
        private System.Windows.Forms.CheckBox checkMostrarSenha;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtSobrenome;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelNome;
    }
}