
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEscala));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_botoes = new System.Windows.Forms.Panel();
            this.menuEscala = new System.Windows.Forms.ToolStrip();
            this.btnSalvarEscala = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalvarEscalaComo = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnExportarXls = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPreencherEscala = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnPreencherEscalaLinha = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPreencherColuna = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPreencherTudo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnVoltar = new System.Windows.Forms.ToolStripButton();
            this.btnLimparEscala = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnLimparLinha = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLimparColuna = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLimparTudo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdicionar = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.txtNomeEscala = new System.Windows.Forms.TextBox();
            this.lbNomeEscala = new System.Windows.Forms.Label();
            this.logo_metodista = new System.Windows.Forms.PictureBox();
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
            this.panel_botoes.SuspendLayout();
            this.menuEscala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_metodista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEscala)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_botoes
            // 
            this.panel_botoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_botoes.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel_botoes.BackgroundImage = global::EscalasMetodista.Properties.Resources._2741104;
            this.panel_botoes.Controls.Add(this.menuEscala);
            this.panel_botoes.Controls.Add(this.txtNomeEscala);
            this.panel_botoes.Controls.Add(this.lbNomeEscala);
            this.panel_botoes.Controls.Add(this.logo_metodista);
            this.panel_botoes.Location = new System.Drawing.Point(0, 0);
            this.panel_botoes.Margin = new System.Windows.Forms.Padding(2);
            this.panel_botoes.Name = "panel_botoes";
            this.panel_botoes.Size = new System.Drawing.Size(1123, 120);
            this.panel_botoes.TabIndex = 3;
            // 
            // menuEscala
            // 
            this.menuEscala.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuEscala.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuEscala.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menuEscala.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuEscala.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalvarEscala,
            this.toolStripSeparator3,
            this.btnSalvarEscalaComo,
            this.toolStripSeparator2,
            this.btnImprimir,
            this.toolStripSeparator1,
            this.btnPreencherEscala,
            this.toolStripSeparator6,
            this.btnVoltar,
            this.btnLimparEscala,
            this.toolStripSeparator4,
            this.btnAdicionar,
            this.toolStripSeparator5});
            this.menuEscala.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuEscala.Location = new System.Drawing.Point(0, 95);
            this.menuEscala.Name = "menuEscala";
            this.menuEscala.Size = new System.Drawing.Size(1123, 25);
            this.menuEscala.Stretch = true;
            this.menuEscala.TabIndex = 8;
            // 
            // btnSalvarEscala
            // 
            this.btnSalvarEscala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSalvarEscala.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSalvarEscala.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarEscala.Image")));
            this.btnSalvarEscala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvarEscala.Name = "btnSalvarEscala";
            this.btnSalvarEscala.Size = new System.Drawing.Size(57, 22);
            this.btnSalvarEscala.Text = "Salvar ";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSalvarEscalaComo
            // 
            this.btnSalvarEscalaComo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExportarXls,
            this.pDFToolStripMenuItem});
            this.btnSalvarEscalaComo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSalvarEscalaComo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvarEscalaComo.Name = "btnSalvarEscalaComo";
            this.btnSalvarEscalaComo.Size = new System.Drawing.Size(102, 22);
            this.btnSalvarEscalaComo.Text = "Salvar Como";
            // 
            // btnExportarXls
            // 
            this.btnExportarXls.Name = "btnExportarXls";
            this.btnExportarXls.Size = new System.Drawing.Size(180, 22);
            this.btnExportarXls.Text = "Excel ";
            this.btnExportarXls.Click += new System.EventHandler(this.btnExportarXls_Click);
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pDFToolStripMenuItem.Text = "PDF";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnImprimir
            // 
            this.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnImprimir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(69, 22);
            this.btnImprimir.Text = "Imprimir";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPreencherEscala
            // 
            this.btnPreencherEscala.BackColor = System.Drawing.Color.Transparent;
            this.btnPreencherEscala.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPreencherEscalaLinha,
            this.btnPreencherColuna,
            this.btnPreencherTudo});
            this.btnPreencherEscala.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPreencherEscala.Name = "btnPreencherEscala";
            this.btnPreencherEscala.Size = new System.Drawing.Size(133, 22);
            this.btnPreencherEscala.Text = "Preencher Escala";
            // 
            // btnPreencherEscalaLinha
            // 
            this.btnPreencherEscalaLinha.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPreencherEscalaLinha.Name = "btnPreencherEscalaLinha";
            this.btnPreencherEscalaLinha.Size = new System.Drawing.Size(196, 22);
            this.btnPreencherEscalaLinha.Text = "Preencher Linhas";
            this.btnPreencherEscalaLinha.Click += new System.EventHandler(this.btnPreencherEscalaLinha_Click);
            // 
            // btnPreencherColuna
            // 
            this.btnPreencherColuna.Name = "btnPreencherColuna";
            this.btnPreencherColuna.Size = new System.Drawing.Size(196, 22);
            this.btnPreencherColuna.Text = "Preencher Colunas";
            this.btnPreencherColuna.Click += new System.EventHandler(this.btnPreencherColuna_Click);
            // 
            // btnPreencherTudo
            // 
            this.btnPreencherTudo.Name = "btnPreencherTudo";
            this.btnPreencherTudo.Size = new System.Drawing.Size(196, 22);
            this.btnPreencherTudo.Text = "Preencher Tudo";
            this.btnPreencherTudo.Click += new System.EventHandler(this.btnPreencherTudo_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnVoltar.Font = new System.Drawing.Font("Verdana", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = global::EscalasMetodista.Properties.Resources.sair;
            this.btnVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(70, 25);
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimparEscala
            // 
            this.btnLimparEscala.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLimparLinha,
            this.btnLimparColuna,
            this.btnLimparTudo});
            this.btnLimparEscala.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLimparEscala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimparEscala.Name = "btnLimparEscala";
            this.btnLimparEscala.Size = new System.Drawing.Size(111, 22);
            this.btnLimparEscala.Text = "Limpar Escala";
            // 
            // btnLimparLinha
            // 
            this.btnLimparLinha.Name = "btnLimparLinha";
            this.btnLimparLinha.Size = new System.Drawing.Size(167, 22);
            this.btnLimparLinha.Text = "Limpar Linha";
            this.btnLimparLinha.Click += new System.EventHandler(this.btnLimparLinha_Click);
            // 
            // btnLimparColuna
            // 
            this.btnLimparColuna.Name = "btnLimparColuna";
            this.btnLimparColuna.Size = new System.Drawing.Size(167, 22);
            this.btnLimparColuna.Text = "Limpar Coluna";
            this.btnLimparColuna.Click += new System.EventHandler(this.btnLimparColuna_Click);
            // 
            // btnLimparTudo
            // 
            this.btnLimparTudo.Name = "btnLimparTudo";
            this.btnLimparTudo.Size = new System.Drawing.Size(167, 22);
            this.btnLimparTudo.Text = "Limpar Tudo";
            this.btnLimparTudo.Click += new System.EventHandler(this.btnLimparTudo_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.btnAdicionar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(82, 22);
            this.btnAdicionar.Text = "Adicionar";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItem1.Text = "Adicionar Linha";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItem2.Text = "Adicionar Coluna";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
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
            this.logo_metodista.Image = global::EscalasMetodista.Properties.Resources._006;
            this.logo_metodista.Location = new System.Drawing.Point(9, 9);
            this.logo_metodista.Margin = new System.Windows.Forms.Padding(2);
            this.logo_metodista.Name = "logo_metodista";
            this.logo_metodista.Size = new System.Drawing.Size(126, 70);
            this.logo_metodista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_metodista.TabIndex = 4;
            this.logo_metodista.TabStop = false;
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
            this.tbEscala.Location = new System.Drawing.Point(0, 117);
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
            this.tbEscala.Size = new System.Drawing.Size(1123, 459);
            this.tbEscala.TabIndex = 4;
            this.tbEscala.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbEscala_CellClick);
            // 
            // dates
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dates.DefaultCellStyle = dataGridViewCellStyle2;
            this.dates.Frozen = true;
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
            this.Controls.Add(this.tbEscala);
            this.Controls.Add(this.panel_botoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEscala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormEscalaLouvor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormEscalaLouvor_KeyDown);
            this.panel_botoes.ResumeLayout(false);
            this.panel_botoes.PerformLayout();
            this.menuEscala.ResumeLayout(false);
            this.menuEscala.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_metodista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEscala)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_botoes;
        private System.Windows.Forms.PictureBox logo_metodista;
        private System.Windows.Forms.TextBox txtNomeEscala;
        public System.Windows.Forms.Label lbNomeEscala;
        private System.Windows.Forms.ToolStrip menuEscala;
        private System.Windows.Forms.ToolStripButton btnSalvarEscala;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton btnSalvarEscalaComo;
        private System.Windows.Forms.ToolStripMenuItem btnExportarXls;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton btnPreencherEscala;
        private System.Windows.Forms.ToolStripMenuItem btnPreencherEscalaLinha;
        private System.Windows.Forms.ToolStripMenuItem btnPreencherColuna;
        private System.Windows.Forms.ToolStripMenuItem btnPreencherTudo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnVoltar;
        private System.Windows.Forms.ToolStripDropDownButton btnLimparEscala;
        private System.Windows.Forms.ToolStripMenuItem btnLimparLinha;
        private System.Windows.Forms.ToolStripMenuItem btnLimparColuna;
        private System.Windows.Forms.ToolStripMenuItem btnLimparTudo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton btnAdicionar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.DataGridView tbEscala;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
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
    }
}