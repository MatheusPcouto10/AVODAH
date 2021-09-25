using EscalasMetodista.Model;
using EscalasMetodista.Views.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscalasMetodista.Views.Outros
{
    public partial class Mensagem : Form
    {
        private int x, y;
        public bool clicouLink = false;

        public enum enmAction
        {
            wait,
            start,
            close
        }

        private Mensagem.enmAction action;

        public enum tipo
        {
            Sucesso, Erro, Warning, Info
        }
        public Mensagem(String mensagem, tipo tipo, bool desfazer)
        {
            InitializeComponent();

            switch (tipo)
            {
                case tipo.Sucesso:
                    BackColor = Color.LimeGreen;
                    iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                    break;
                case tipo.Erro:
                    BackColor = Color.Maroon;
                    iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
                    break;
                case tipo.Warning:
                    BackColor = Color.DarkOrange;
                    iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
                    break;
                case tipo.Info:
                    BackColor = Color.DodgerBlue;
                    iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Exclamation;
                    break;
                default:
                    break;
            }

            if (desfazer)
                linkDesfazer.Visible = true;

            labelDescricao.Text = mensagem;
            Width = Width + labelDescricao.Text.Length;
            x = Screen.PrimaryScreen.WorkingArea.Width - (Width + 15);
            y = Screen.PrimaryScreen.WorkingArea.Height - Height * 12;
            Location = new Point(x, y);

            this.action = enmAction.start;
            this.Opacity = 0.0;
            this.timerClose.Interval = 1;
            this.timerClose.Start();
        }

        private void Mensagem_Load(object sender, EventArgs e)
        {
            timerClose.Start();
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timerClose.Interval = BackColor == Color.Maroon || BackColor == Color.DodgerBlue ? 5000 : 3000;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    this.timerClose.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timerClose.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void linkDesfazer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCadastrarUsuario form = (FormCadastrarUsuario) Application.OpenForms["FormCadastrarUsuario"];

            if (form.WindowState == FormWindowState.Normal)
            {
                Pessoa pessoa = new Pessoa();
                pessoa.reativa(form.idPessoaExcluida);

                form.Hide();

                FormCadastrarUsuario form2 = new FormCadastrarUsuario(form.idPessoaExcluida);
                form2.Show();

                form.Close();

                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
