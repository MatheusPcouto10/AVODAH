
namespace EscalasMetodista.Views.Escalas
{
    partial class FormEscala
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEscala));
            this.tbEscala = new System.Windows.Forms.DataGridView();
            this.dates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_rodape = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_botoes = new System.Windows.Forms.Panel();
            this.txtNomeEscala = new System.Windows.Forms.TextBox();
            this.lbNomeEscala = new System.Windows.Forms.Label();
            this.logo_metodista = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnVoltar = new FontAwesome.Sharp.IconButton();
            this.btnLimparEscala = new FontAwesome.Sharp.IconButton();
            this.btnPreencherEscala = new FontAwesome.Sharp.IconButton();
            this.btnSalvarEscalaComo = new FontAwesome.Sharp.IconButton();
            this.dropBtnLimparEscala = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnLimparLinha = new FontAwesome.Sharp.IconMenuItem();
            this.btnLimparColuna = new FontAwesome.Sharp.IconMenuItem();
            this.limparTudoToolStripMenuItem = new FontAwesome.Sharp.IconMenuItem();
            this.dropPreencherEscala = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnPreencherLinha = new FontAwesome.Sharp.IconMenuItem();
            this.btnPreencherColuna = new FontAwesome.Sharp.IconMenuItem();
            this.btnPreencherTudo = new FontAwesome.Sharp.IconMenuItem();
            this.dropSalvarComo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnExportarXls = new FontAwesome.Sharp.IconMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tbEscala)).BeginInit();
            this.panel_rodape.SuspendLayout();
            this.panel_botoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_metodista)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.dropBtnLimparEscala.SuspendLayout();
            this.dropPreencherEscala.SuspendLayout();
            this.dropSalvarComo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbEscala
            // 
            this.tbEscala.AllowUserToAddRows = false;
            this.tbEscala.AllowUserToDeleteRows = false;
            this.tbEscala.AllowUserToOrderColumns = true;
            this.tbEscala.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEscala.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tbEscala.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbEscala.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tbEscala.ColumnHeadersHeight = 60;
            this.tbEscala.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dates,
            this.observacoes,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbEscala.DefaultCellStyle = dataGridViewCellStyle3;
            this.tbEscala.EnableHeadersVisualStyles = false;
            this.tbEscala.Location = new System.Drawing.Point(0, 132);
            this.tbEscala.Name = "tbEscala";
            this.tbEscala.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbEscala.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEscala.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tbEscala.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect;
            this.tbEscala.Size = new System.Drawing.Size(1123, 411);
            this.tbEscala.TabIndex = 4;
            this.tbEscala.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbEscala_CellClick);
            // 
            // dates
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dates.DefaultCellStyle = dataGridViewCellStyle2;
            this.dates.HeaderText = "";
            this.dates.Name = "dates";
            this.dates.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // observacoes
            // 
            this.observacoes.HeaderText = "";
            this.observacoes.Name = "observacoes";
            this.observacoes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "";
            this.Column6.Name = "Column6";
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "";
            this.Column7.Name = "Column7";
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "";
            this.Column8.Name = "Column8";
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "";
            this.Column9.Name = "Column9";
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "";
            this.Column10.Name = "Column10";
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "";
            this.Column11.Name = "Column11";
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "";
            this.Column12.Name = "Column12";
            this.Column12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "";
            this.Column13.Name = "Column13";
            this.Column13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "";
            this.Column14.Name = "Column14";
            this.Column14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel_rodape
            // 
            this.panel_rodape.BackColor = System.Drawing.Color.Black;
            this.panel_rodape.BackgroundImage = global::EscalasMetodista.Properties.Resources._2741104;
            this.panel_rodape.Controls.Add(this.label1);
            this.panel_rodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_rodape.Location = new System.Drawing.Point(0, 539);
            this.panel_rodape.Margin = new System.Windows.Forms.Padding(2);
            this.panel_rodape.Name = "panel_rodape";
            this.panel_rodape.Size = new System.Drawing.Size(1122, 37);
            this.panel_rodape.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(344, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyright © 2021 — Desenvolvido por Matheus Pimentel Do Couto";
            // 
            // panel_botoes
            // 
            this.panel_botoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_botoes.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel_botoes.BackgroundImage = global::EscalasMetodista.Properties.Resources._2741104;
            this.panel_botoes.Controls.Add(this.txtNomeEscala);
            this.panel_botoes.Controls.Add(this.lbNomeEscala);
            this.panel_botoes.Controls.Add(this.logo_metodista);
            this.panel_botoes.Controls.Add(this.panelMenu);
            this.panel_botoes.Location = new System.Drawing.Point(0, 0);
            this.panel_botoes.Margin = new System.Windows.Forms.Padding(2);
            this.panel_botoes.Name = "panel_botoes";
            this.panel_botoes.Size = new System.Drawing.Size(1123, 134);
            this.panel_botoes.TabIndex = 3;
            // 
            // txtNomeEscala
            // 
            this.txtNomeEscala.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomeEscala.BackColor = System.Drawing.Color.Black;
            this.txtNomeEscala.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeEscala.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtNomeEscala.ForeColor = System.Drawing.Color.White;
            this.txtNomeEscala.Location = new System.Drawing.Point(472, 28);
            this.txtNomeEscala.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeEscala.MaxLength = 40;
            this.txtNomeEscala.Name = "txtNomeEscala";
            this.txtNomeEscala.Size = new System.Drawing.Size(154, 23);
            this.txtNomeEscala.TabIndex = 5;
            this.txtNomeEscala.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeEscala.Visible = false;
            // 
            // lbNomeEscala
            // 
            this.lbNomeEscala.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNomeEscala.AutoSize = true;
            this.lbNomeEscala.BackColor = System.Drawing.Color.Transparent;
            this.lbNomeEscala.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeEscala.ForeColor = System.Drawing.Color.White;
            this.lbNomeEscala.Location = new System.Drawing.Point(468, 28);
            this.lbNomeEscala.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNomeEscala.Name = "lbNomeEscala";
            this.lbNomeEscala.Size = new System.Drawing.Size(163, 23);
            this.lbNomeEscala.TabIndex = 7;
            this.lbNomeEscala.Text = "NOME ESCALA";
            this.lbNomeEscala.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbNomeEscala.DoubleClick += new System.EventHandler(this.lbNomeEscala_DoubleClick);
            // 
            // logo_metodista
            // 
            this.logo_metodista.BackColor = System.Drawing.Color.Transparent;
            this.logo_metodista.Image = global::EscalasMetodista.Properties.Resources.Avodah_Line_Red_White;
            this.logo_metodista.Location = new System.Drawing.Point(9, 9);
            this.logo_metodista.Margin = new System.Windows.Forms.Padding(2);
            this.logo_metodista.Name = "logo_metodista";
            this.logo_metodista.Size = new System.Drawing.Size(208, 70);
            this.logo_metodista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_metodista.TabIndex = 4;
            this.logo_metodista.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.BackColor = System.Drawing.SystemColors.Control;
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.btnVoltar);
            this.panelMenu.Controls.Add(this.btnLimparEscala);
            this.panelMenu.Controls.Add(this.btnPreencherEscala);
            this.panelMenu.Controls.Add(this.btnSalvarEscalaComo);
            this.panelMenu.Location = new System.Drawing.Point(0, 99);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1123, 35);
            this.panelMenu.TabIndex = 9;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnVoltar.IconColor = System.Drawing.Color.Black;
            this.btnVoltar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnVoltar.IconSize = 25;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.Location = new System.Drawing.Point(1038, 1);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(89, 32);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimparEscala
            // 
            this.btnLimparEscala.FlatAppearance.BorderSize = 0;
            this.btnLimparEscala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparEscala.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnLimparEscala.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimparEscala.IconColor = System.Drawing.Color.Black;
            this.btnLimparEscala.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnLimparEscala.IconSize = 22;
            this.btnLimparEscala.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparEscala.Location = new System.Drawing.Point(311, 2);
            this.btnLimparEscala.Name = "btnLimparEscala";
            this.btnLimparEscala.Size = new System.Drawing.Size(137, 31);
            this.btnLimparEscala.TabIndex = 11;
            this.btnLimparEscala.Text = "Limpar Escala";
            this.btnLimparEscala.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparEscala.UseVisualStyleBackColor = true;
            this.btnLimparEscala.Click += new System.EventHandler(this.btnLimparEscala_Click);
            // 
            // btnPreencherEscala
            // 
            this.btnPreencherEscala.FlatAppearance.BorderSize = 0;
            this.btnPreencherEscala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreencherEscala.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnPreencherEscala.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnPreencherEscala.IconColor = System.Drawing.SystemColors.HotTrack;
            this.btnPreencherEscala.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnPreencherEscala.IconSize = 24;
            this.btnPreencherEscala.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreencherEscala.Location = new System.Drawing.Point(141, 1);
            this.btnPreencherEscala.Name = "btnPreencherEscala";
            this.btnPreencherEscala.Size = new System.Drawing.Size(162, 31);
            this.btnPreencherEscala.TabIndex = 8;
            this.btnPreencherEscala.Text = "Preencher Escala";
            this.btnPreencherEscala.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreencherEscala.UseVisualStyleBackColor = true;
            this.btnPreencherEscala.Click += new System.EventHandler(this.btnPreencherEscala_Click);
            // 
            // btnSalvarEscalaComo
            // 
            this.btnSalvarEscalaComo.FlatAppearance.BorderSize = 0;
            this.btnSalvarEscalaComo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarEscalaComo.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnSalvarEscalaComo.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSalvarEscalaComo.IconColor = System.Drawing.Color.DarkMagenta;
            this.btnSalvarEscalaComo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSalvarEscalaComo.IconSize = 22;
            this.btnSalvarEscalaComo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarEscalaComo.Location = new System.Drawing.Point(7, 1);
            this.btnSalvarEscalaComo.Name = "btnSalvarEscalaComo";
            this.btnSalvarEscalaComo.Size = new System.Drawing.Size(130, 32);
            this.btnSalvarEscalaComo.TabIndex = 0;
            this.btnSalvarEscalaComo.Text = "Salvar Como";
            this.btnSalvarEscalaComo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarEscalaComo.UseVisualStyleBackColor = true;
            this.btnSalvarEscalaComo.Click += new System.EventHandler(this.btnSalvarEscalaComo_Click);
            // 
            // dropBtnLimparEscala
            // 
            this.dropBtnLimparEscala.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dropBtnLimparEscala.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLimparLinha,
            this.btnLimparColuna,
            this.limparTudoToolStripMenuItem});
            this.dropBtnLimparEscala.Name = "dropBtnPerfil";
            this.dropBtnLimparEscala.Size = new System.Drawing.Size(168, 70);
            // 
            // btnLimparLinha
            // 
            this.btnLimparLinha.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparLinha.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimparLinha.IconColor = System.Drawing.Color.Black;
            this.btnLimparLinha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimparLinha.IconSize = 30;
            this.btnLimparLinha.Name = "btnLimparLinha";
            this.btnLimparLinha.Size = new System.Drawing.Size(167, 22);
            this.btnLimparLinha.Text = "Limpar Linha";
            this.btnLimparLinha.Click += new System.EventHandler(this.btnLimparLinha_Click);
            // 
            // btnLimparColuna
            // 
            this.btnLimparColuna.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLimparColuna.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimparColuna.IconColor = System.Drawing.Color.Black;
            this.btnLimparColuna.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimparColuna.IconSize = 30;
            this.btnLimparColuna.Name = "btnLimparColuna";
            this.btnLimparColuna.Size = new System.Drawing.Size(167, 22);
            this.btnLimparColuna.Text = "Limpar Coluna";
            this.btnLimparColuna.Click += new System.EventHandler(this.btnLimparColuna_Click);
            // 
            // limparTudoToolStripMenuItem
            // 
            this.limparTudoToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.limparTudoToolStripMenuItem.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.limparTudoToolStripMenuItem.IconColor = System.Drawing.Color.Black;
            this.limparTudoToolStripMenuItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.limparTudoToolStripMenuItem.Name = "limparTudoToolStripMenuItem";
            this.limparTudoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.limparTudoToolStripMenuItem.Text = "Limpar Tudo";
            this.limparTudoToolStripMenuItem.Click += new System.EventHandler(this.btnLimparTudo_Click);
            // 
            // dropPreencherEscala
            // 
            this.dropPreencherEscala.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dropPreencherEscala.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPreencherLinha,
            this.btnPreencherColuna,
            this.btnPreencherTudo});
            this.dropPreencherEscala.Name = "dropBtnPerfil";
            this.dropPreencherEscala.Size = new System.Drawing.Size(190, 70);
            // 
            // btnPreencherLinha
            // 
            this.btnPreencherLinha.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreencherLinha.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnPreencherLinha.IconColor = System.Drawing.SystemColors.HotTrack;
            this.btnPreencherLinha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPreencherLinha.IconSize = 30;
            this.btnPreencherLinha.Name = "btnPreencherLinha";
            this.btnPreencherLinha.Size = new System.Drawing.Size(189, 22);
            this.btnPreencherLinha.Text = "Preencher Linha";
            this.btnPreencherLinha.Click += new System.EventHandler(this.btnPreencherEscalaLinha_Click);
            // 
            // btnPreencherColuna
            // 
            this.btnPreencherColuna.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPreencherColuna.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnPreencherColuna.IconColor = System.Drawing.SystemColors.HotTrack;
            this.btnPreencherColuna.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPreencherColuna.IconSize = 30;
            this.btnPreencherColuna.Name = "btnPreencherColuna";
            this.btnPreencherColuna.Size = new System.Drawing.Size(189, 22);
            this.btnPreencherColuna.Text = "Preencher Coluna";
            this.btnPreencherColuna.Click += new System.EventHandler(this.btnPreencherColuna_Click);
            // 
            // btnPreencherTudo
            // 
            this.btnPreencherTudo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPreencherTudo.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnPreencherTudo.IconColor = System.Drawing.SystemColors.HotTrack;
            this.btnPreencherTudo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPreencherTudo.Name = "btnPreencherTudo";
            this.btnPreencherTudo.Size = new System.Drawing.Size(189, 22);
            this.btnPreencherTudo.Text = "Preencher Tudo";
            this.btnPreencherTudo.Click += new System.EventHandler(this.btnPreencherTudo_Click);
            // 
            // dropSalvarComo
            // 
            this.dropSalvarComo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dropSalvarComo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExportarXls});
            this.dropSalvarComo.Name = "dropBtnPerfil";
            this.dropSalvarComo.Size = new System.Drawing.Size(149, 26);
            // 
            // btnExportarXls
            // 
            this.btnExportarXls.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarXls.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExportarXls.IconColor = System.Drawing.Color.SeaGreen;
            this.btnExportarXls.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportarXls.IconSize = 30;
            this.btnExportarXls.Name = "btnExportarXls";
            this.btnExportarXls.Size = new System.Drawing.Size(148, 22);
            this.btnExportarXls.Text = "Excel (.xls)";
            this.btnExportarXls.Click += new System.EventHandler(this.btnExportarXls_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(138, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 30);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(308, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 30);
            this.panel2.TabIndex = 10;
            // 
            // FormEscala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(50, 0);
            this.AutoScrollMinSize = new System.Drawing.Size(5, 0);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1122, 576);
            this.Controls.Add(this.panel_rodape);
            this.Controls.Add(this.tbEscala);
            this.Controls.Add(this.panel_botoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormEscala";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormEscalaLouvor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormEscalaLouvor_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tbEscala)).EndInit();
            this.panel_rodape.ResumeLayout(false);
            this.panel_rodape.PerformLayout();
            this.panel_botoes.ResumeLayout(false);
            this.panel_botoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_metodista)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.dropBtnLimparEscala.ResumeLayout(false);
            this.dropPreencherEscala.ResumeLayout(false);
            this.dropSalvarComo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_botoes;
        private System.Windows.Forms.PictureBox logo_metodista;
        private System.Windows.Forms.TextBox txtNomeEscala;
        public System.Windows.Forms.Label lbNomeEscala;
        private System.Windows.Forms.DataGridView tbEscala;
        private System.Windows.Forms.Panel panel_rodape;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnVoltar;
        private FontAwesome.Sharp.IconButton btnLimparEscala;
        private FontAwesome.Sharp.IconButton btnPreencherEscala;
        private FontAwesome.Sharp.IconButton btnSalvarEscalaComo;
        private System.Windows.Forms.ContextMenuStrip dropBtnLimparEscala;
        private FontAwesome.Sharp.IconMenuItem btnLimparLinha;
        private FontAwesome.Sharp.IconMenuItem btnLimparColuna;
        private FontAwesome.Sharp.IconMenuItem limparTudoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip dropPreencherEscala;
        private FontAwesome.Sharp.IconMenuItem btnPreencherLinha;
        private FontAwesome.Sharp.IconMenuItem btnPreencherColuna;
        private FontAwesome.Sharp.IconMenuItem btnPreencherTudo;
        private System.Windows.Forms.ContextMenuStrip dropSalvarComo;
        private FontAwesome.Sharp.IconMenuItem btnExportarXls;
        private System.Windows.Forms.DataGridViewTextBoxColumn dates;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}