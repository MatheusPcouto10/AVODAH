namespace EscalasMetodista.Views.Usuarios
{
    partial class FormGerenciarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerenciarUsuario));
            this.panel_rodape = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.telaPesquisa = new System.Windows.Forms.TabPage();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.telaEditar = new System.Windows.Forms.TabPage();
            this.btnSalvarUsuario = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimparFuncaoSecundaria = new System.Windows.Forms.Button();
            this.cbSubFuncaoSecundaria = new System.Windows.Forms.ComboBox();
            this.cbFuncaoSecundaria = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimparFuncaoPrincipal = new System.Windows.Forms.Button();
            this.cbSubFuncaoPrincipal = new System.Windows.Forms.ComboBox();
            this.cbFuncaoPrincipal = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtCadastro = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.checkMostrarSenha = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_rodape.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.telaPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            this.telaEditar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_rodape
            // 
            this.panel_rodape.BackColor = System.Drawing.Color.Transparent;
            this.panel_rodape.BackgroundImage = global::EscalasMetodista.Properties.Resources._2741104;
            this.panel_rodape.Controls.Add(this.btnVoltar);
            this.panel_rodape.Controls.Add(this.label1);
            this.panel_rodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_rodape.Location = new System.Drawing.Point(0, 676);
            this.panel_rodape.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_rodape.Name = "panel_rodape";
            this.panel_rodape.Size = new System.Drawing.Size(1283, 45);
            this.panel_rodape.TabIndex = 9;
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
            this.label1.Location = new System.Drawing.Point(476, 19);
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
            this.tabControl1.Controls.Add(this.telaEditar);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 74);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1283, 600);
            this.tabControl1.TabIndex = 9;
            // 
            // telaPesquisa
            // 
            this.telaPesquisa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.telaPesquisa.BackgroundImage = global::EscalasMetodista.Properties.Resources.sobreposicao_de_rotulo_vermelho_sobre_fundo_metalico_cinzento_escuro_33869_1241;
            this.telaPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.telaPesquisa.Controls.Add(this.btnPesquisa);
            this.telaPesquisa.Controls.Add(this.txtPesquisa);
            this.telaPesquisa.Controls.Add(this.dgUsuarios);
            this.telaPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telaPesquisa.Location = new System.Drawing.Point(4, 26);
            this.telaPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telaPesquisa.Name = "telaPesquisa";
            this.telaPesquisa.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telaPesquisa.Size = new System.Drawing.Size(1275, 570);
            this.telaPesquisa.TabIndex = 0;
            this.telaPesquisa.Text = "Pesquisa";
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
            this.btnPesquisa.Location = new System.Drawing.Point(798, 64);
            this.btnPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(44, 26);
            this.btnPesquisa.TabIndex = 7;
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.BackColor = System.Drawing.Color.White;
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisa.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtPesquisa.Location = new System.Drawing.Point(475, 65);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(317, 23);
            this.txtPesquisa.TabIndex = 6;
            // 
            // dgUsuarios
            // 
            this.dgUsuarios.AllowUserToAddRows = false;
            this.dgUsuarios.AllowUserToDeleteRows = false;
            this.dgUsuarios.AllowUserToOrderColumns = true;
            this.dgUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgUsuarios.BackgroundColor = System.Drawing.Color.Black;
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar});
            this.dgUsuarios.GridColor = System.Drawing.Color.Black;
            this.dgUsuarios.Location = new System.Drawing.Point(8, 149);
            this.dgUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.ReadOnly = true;
            this.dgUsuarios.RowHeadersWidth = 51;
            this.dgUsuarios.RowTemplate.Height = 24;
            this.dgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsuarios.Size = new System.Drawing.Size(1246, 417);
            this.dgUsuarios.TabIndex = 5;
            this.dgUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsuarios_CellContentClick);
            this.dgUsuarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgUsuarios_CellFormatting);
            this.dgUsuarios.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgUsuarios_DataBindingComplete);
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
            // telaEditar
            // 
            this.telaEditar.BackgroundImage = global::EscalasMetodista.Properties.Resources.sobreposicao_de_rotulo_vermelho_sobre_fundo_metalico_cinzento_escuro_33869_1241;
            this.telaEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.telaEditar.Controls.Add(this.btnSalvarUsuario);
            this.telaEditar.Controls.Add(this.label10);
            this.telaEditar.Controls.Add(this.cbStatus);
            this.telaEditar.Controls.Add(this.groupBox2);
            this.telaEditar.Controls.Add(this.groupBox1);
            this.telaEditar.Controls.Add(this.label8);
            this.telaEditar.Controls.Add(this.dtCadastro);
            this.telaEditar.Controls.Add(this.label9);
            this.telaEditar.Controls.Add(this.cbTipoUsuario);
            this.telaEditar.Controls.Add(this.checkMostrarSenha);
            this.telaEditar.Controls.Add(this.label3);
            this.telaEditar.Controls.Add(this.txtNome);
            this.telaEditar.Controls.Add(this.txtSobrenome);
            this.telaEditar.Controls.Add(this.label4);
            this.telaEditar.Controls.Add(this.txtEmail);
            this.telaEditar.Controls.Add(this.label5);
            this.telaEditar.Controls.Add(this.txtSenha);
            this.telaEditar.Controls.Add(this.label6);
            this.telaEditar.Location = new System.Drawing.Point(4, 26);
            this.telaEditar.Name = "telaEditar";
            this.telaEditar.Padding = new System.Windows.Forms.Padding(3);
            this.telaEditar.Size = new System.Drawing.Size(1275, 570);
            this.telaEditar.TabIndex = 1;
            this.telaEditar.Text = "Editar";
            this.telaEditar.UseVisualStyleBackColor = true;
            // 
            // btnSalvarUsuario
            // 
            this.btnSalvarUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalvarUsuario.FlatAppearance.BorderSize = 2;
            this.btnSalvarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarUsuario.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalvarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalvarUsuario.Location = new System.Drawing.Point(557, 509);
            this.btnSalvarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvarUsuario.Name = "btnSalvarUsuario";
            this.btnSalvarUsuario.Size = new System.Drawing.Size(165, 39);
            this.btnSalvarUsuario.TabIndex = 73;
            this.btnSalvarUsuario.Text = "SALVAR";
            this.btnSalvarUsuario.UseVisualStyleBackColor = false;
            this.btnSalvarUsuario.Click += new System.EventHandler(this.btnSalvarUsuario_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(189, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 72;
            this.label10.Text = "Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbStatus.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbStatus.Location = new System.Drawing.Point(193, 419);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(167, 28);
            this.cbStatus.TabIndex = 71;
            this.cbStatus.Text = "Selecione...";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnLimparFuncaoSecundaria);
            this.groupBox2.Controls.Add(this.cbSubFuncaoSecundaria);
            this.groupBox2.Controls.Add(this.cbFuncaoSecundaria);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(631, 157);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(452, 107);
            this.groupBox2.TabIndex = 70;
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
            this.btnLimparFuncaoSecundaria.Location = new System.Drawing.Point(432, 8);
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
            this.cbSubFuncaoSecundaria.Size = new System.Drawing.Size(225, 28);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnLimparFuncaoPrincipal);
            this.groupBox1.Controls.Add(this.cbSubFuncaoPrincipal);
            this.groupBox1.Controls.Add(this.cbFuncaoPrincipal);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(631, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(452, 107);
            this.groupBox1.TabIndex = 69;
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
            this.btnLimparFuncaoPrincipal.Location = new System.Drawing.Point(432, 9);
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
            this.cbSubFuncaoPrincipal.Size = new System.Drawing.Size(225, 28);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(822, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 20);
            this.label8.TabIndex = 68;
            this.label8.Text = "Data de Cadastro:";
            // 
            // dtCadastro
            // 
            this.dtCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtCadastro.CalendarFont = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.dtCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCadastro.Location = new System.Drawing.Point(826, 324);
            this.dtCadastro.Name = "dtCadastro";
            this.dtCadastro.Size = new System.Drawing.Size(225, 24);
            this.dtCadastro.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(627, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 20);
            this.label9.TabIndex = 66;
            this.label9.Text = "Tipo de Usuário:";
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTipoUsuario.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.Location = new System.Drawing.Point(631, 324);
            this.cbTipoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(167, 28);
            this.cbTipoUsuario.TabIndex = 65;
            this.cbTipoUsuario.Text = "Selecione...";
            // 
            // checkMostrarSenha
            // 
            this.checkMostrarSenha.AutoSize = true;
            this.checkMostrarSenha.BackColor = System.Drawing.Color.Transparent;
            this.checkMostrarSenha.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.checkMostrarSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.checkMostrarSenha.Location = new System.Drawing.Point(269, 297);
            this.checkMostrarSenha.Name = "checkMostrarSenha";
            this.checkMostrarSenha.Size = new System.Drawing.Size(141, 21);
            this.checkMostrarSenha.TabIndex = 64;
            this.checkMostrarSenha.Text = "Mostrar senha";
            this.checkMostrarSenha.UseVisualStyleBackColor = false;
            this.checkMostrarSenha.CheckedChanged += new System.EventHandler(this.checkMostrarSenha_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(189, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(193, 71);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(318, 26);
            this.txtNome.TabIndex = 39;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenome.Location = new System.Drawing.Point(193, 159);
            this.txtSobrenome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(318, 26);
            this.txtSobrenome.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(189, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Sobrenome:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(193, 247);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(318, 26);
            this.txtEmail.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(189, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "E-mail:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(193, 335);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(318, 26);
            this.txtSenha.TabIndex = 45;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(189, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(474, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "GERENCIAR USUÁRIOS";
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
            this.panel1.Size = new System.Drawing.Size(1283, 70);
            this.panel1.TabIndex = 8;
            // 
            // FormGerenciarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1283, 721);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel_rodape);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormGerenciarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Usuários";
            this.Load += new System.EventHandler(this.FormGerenciarUsuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGerenciarUsuario_KeyDown);
            this.panel_rodape.ResumeLayout(false);
            this.panel_rodape.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.telaPesquisa.ResumeLayout(false);
            this.telaPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            this.telaEditar.ResumeLayout(false);
            this.telaEditar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_rodape;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage telaPesquisa;
        public System.Windows.Forms.DataGridView dgUsuarios;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.TabPage telaEditar;
        private System.Windows.Forms.CheckBox checkMostrarSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLimparFuncaoSecundaria;
        public System.Windows.Forms.ComboBox cbSubFuncaoSecundaria;
        public System.Windows.Forms.ComboBox cbFuncaoSecundaria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimparFuncaoPrincipal;
        public System.Windows.Forms.ComboBox cbSubFuncaoPrincipal;
        public System.Windows.Forms.ComboBox cbFuncaoPrincipal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtCadastro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbTipoUsuario;
        private System.Windows.Forms.Button btnSalvarUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
    }
}