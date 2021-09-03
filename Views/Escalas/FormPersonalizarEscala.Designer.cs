
namespace EscalasMetodista.Views.Escalas
{
    partial class FormPersonalizarEscala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonalizarEscala));
            this.label9 = new System.Windows.Forms.Label();
            this.cbIntervalo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeEscala = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtInicioEscala = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFimEscala = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoEscala = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clDiasSemanaEscala = new System.Windows.Forms.CheckedListBox();
            this.checkTodos = new System.Windows.Forms.CheckBox();
            this.btnLimpar = new FontAwesome.Sharp.IconButton();
            this.btnCriarEscala = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(445, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 79;
            this.label9.Text = "Intervalo:";
            // 
            // cbIntervalo
            // 
            this.cbIntervalo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbIntervalo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbIntervalo.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cbIntervalo.FormattingEnabled = true;
            this.cbIntervalo.Location = new System.Drawing.Point(448, 57);
            this.cbIntervalo.Margin = new System.Windows.Forms.Padding(2);
            this.cbIntervalo.Name = "cbIntervalo";
            this.cbIntervalo.Size = new System.Drawing.Size(126, 24);
            this.cbIntervalo.TabIndex = 78;
            this.cbIntervalo.SelectedIndexChanged += new System.EventHandler(this.cbIntervalo_SelectedIndexChanged);
            this.cbIntervalo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbIntervalo_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(28, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 84;
            this.label3.Text = "Nome:";
            // 
            // txtNomeEscala
            // 
            this.txtNomeEscala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEscala.Location = new System.Drawing.Point(31, 58);
            this.txtNomeEscala.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeEscala.Name = "txtNomeEscala";
            this.txtNomeEscala.Size = new System.Drawing.Size(263, 24);
            this.txtNomeEscala.TabIndex = 83;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(28, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 86;
            this.label8.Text = "Data de Início:";
            // 
            // dtInicioEscala
            // 
            this.dtInicioEscala.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtInicioEscala.CalendarFont = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.dtInicioEscala.CalendarMonthBackground = System.Drawing.Color.Gray;
            this.dtInicioEscala.CustomFormat = "";
            this.dtInicioEscala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicioEscala.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicioEscala.Location = new System.Drawing.Point(31, 146);
            this.dtInicioEscala.Margin = new System.Windows.Forms.Padding(2);
            this.dtInicioEscala.Name = "dtInicioEscala";
            this.dtInicioEscala.Size = new System.Drawing.Size(170, 21);
            this.dtInicioEscala.TabIndex = 85;
            this.dtInicioEscala.ValueChanged += new System.EventHandler(this.dtInicioEscala_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(224, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 88;
            this.label1.Text = "Data Fim:";
            // 
            // dtFimEscala
            // 
            this.dtFimEscala.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtFimEscala.CalendarFont = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.dtFimEscala.CalendarMonthBackground = System.Drawing.Color.Gray;
            this.dtFimEscala.CustomFormat = "";
            this.dtFimEscala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFimEscala.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFimEscala.Location = new System.Drawing.Point(226, 146);
            this.dtFimEscala.Margin = new System.Windows.Forms.Padding(2);
            this.dtFimEscala.Name = "dtFimEscala";
            this.dtFimEscala.Size = new System.Drawing.Size(170, 21);
            this.dtFimEscala.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(311, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 90;
            this.label2.Text = "Tipo de Escala:";
            // 
            // cbTipoEscala
            // 
            this.cbTipoEscala.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTipoEscala.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTipoEscala.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.cbTipoEscala.FormattingEnabled = true;
            this.cbTipoEscala.Location = new System.Drawing.Point(314, 57);
            this.cbTipoEscala.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipoEscala.Name = "cbTipoEscala";
            this.cbTipoEscala.Size = new System.Drawing.Size(126, 24);
            this.cbTipoEscala.TabIndex = 89;
            this.cbTipoEscala.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbTipoEscala_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(445, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 91;
            this.label4.Text = "Dias da Escala:";
            // 
            // clDiasSemanaEscala
            // 
            this.clDiasSemanaEscala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clDiasSemanaEscala.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clDiasSemanaEscala.CheckOnClick = true;
            this.clDiasSemanaEscala.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.clDiasSemanaEscala.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.clDiasSemanaEscala.FormattingEnabled = true;
            this.clDiasSemanaEscala.Items.AddRange(new object[] {
            "segunda-feira",
            "terça-feira",
            "quarta-feira",
            "quinta-feira",
            "sexta-feira",
            "sábado",
            "domingo"});
            this.clDiasSemanaEscala.Location = new System.Drawing.Point(448, 146);
            this.clDiasSemanaEscala.Margin = new System.Windows.Forms.Padding(2);
            this.clDiasSemanaEscala.Name = "clDiasSemanaEscala";
            this.clDiasSemanaEscala.Size = new System.Drawing.Size(138, 105);
            this.clDiasSemanaEscala.TabIndex = 92;
            this.clDiasSemanaEscala.SelectedValueChanged += new System.EventHandler(this.clDiasSemanaEscala_SelectedValueChanged);
            // 
            // checkTodos
            // 
            this.checkTodos.AutoSize = true;
            this.checkTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkTodos.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.checkTodos.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.checkTodos.Location = new System.Drawing.Point(448, 259);
            this.checkTodos.Margin = new System.Windows.Forms.Padding(2);
            this.checkTodos.Name = "checkTodos";
            this.checkTodos.Size = new System.Drawing.Size(138, 17);
            this.checkTodos.TabIndex = 93;
            this.checkTodos.Text = "Selecionar Todos";
            this.checkTodos.UseVisualStyleBackColor = false;
            this.checkTodos.CheckedChanged += new System.EventHandler(this.checkTodos_CheckedChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnLimpar.FlatAppearance.BorderSize = 2;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpar.IconColor = System.Drawing.Color.LightGray;
            this.btnLimpar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpar.IconSize = 22;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLimpar.Location = new System.Drawing.Point(354, 314);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(122, 31);
            this.btnLimpar.TabIndex = 94;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            this.btnLimpar.MouseLeave += new System.EventHandler(this.btnLimpar_MouseLeave);
            this.btnLimpar.MouseHover += new System.EventHandler(this.btnLimpar_MouseHover);
            // 
            // btnCriarEscala
            // 
            this.btnCriarEscala.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCriarEscala.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCriarEscala.FlatAppearance.BorderSize = 2;
            this.btnCriarEscala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarEscala.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnCriarEscala.ForeColor = System.Drawing.Color.Black;
            this.btnCriarEscala.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.btnCriarEscala.IconColor = System.Drawing.Color.Black;
            this.btnCriarEscala.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCriarEscala.IconSize = 24;
            this.btnCriarEscala.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCriarEscala.Location = new System.Drawing.Point(495, 314);
            this.btnCriarEscala.Name = "btnCriarEscala";
            this.btnCriarEscala.Size = new System.Drawing.Size(124, 31);
            this.btnCriarEscala.TabIndex = 95;
            this.btnCriarEscala.Text = "CRIAR";
            this.btnCriarEscala.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCriarEscala.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCriarEscala.UseVisualStyleBackColor = false;
            this.btnCriarEscala.Click += new System.EventHandler(this.btnCriarEscala_Click);
            // 
            // FormPersonalizarEscala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EscalasMetodista.Properties.Resources.dark_material_design_wallpaper__1_in_4k_by_tgs266_d9j7yts;
            this.ClientSize = new System.Drawing.Size(648, 366);
            this.Controls.Add(this.btnCriarEscala);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.checkTodos);
            this.Controls.Add(this.clDiasSemanaEscala);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTipoEscala);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFimEscala);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtInicioEscala);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeEscala);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbIntervalo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPersonalizarEscala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personalizar Escala";
            this.Load += new System.EventHandler(this.FormPersonalizarEscala_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbIntervalo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeEscala;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipoEscala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox clDiasSemanaEscala;
        private System.Windows.Forms.DateTimePicker dtInicioEscala;
        private System.Windows.Forms.DateTimePicker dtFimEscala;
        private System.Windows.Forms.CheckBox checkTodos;
        private FontAwesome.Sharp.IconButton btnLimpar;
        private FontAwesome.Sharp.IconButton btnCriarEscala;
    }
}