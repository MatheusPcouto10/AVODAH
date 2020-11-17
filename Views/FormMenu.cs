using EscalasMetodista.Session;
using EscalasMetodista.Views;
using EscalasMetodista.Views.Funcoes;
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

namespace EscalasMetodista
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {

        }

        private void controleAcesso()
        {
            if (UsuarioSession.tipoUsuario.Equals(2))
            {
                this.btnFuncoes.Enabled = false;
                this.btnUsuarios.Enabled = false;
                this.btnRelatorios.Enabled = false;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormLogin form = new FormLogin();
                form.Show();
                this.Hide();
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.btnPerfil.Text = "Bem vindo " + UsuarioSession.nomeUsuario + " !";
            this.controleAcesso();
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgEscalas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgEscalas.Columns)
            {
                switch (coluna.Name)
                {
                    case "descricao":
                        coluna.Width = 100;
                        coluna.HeaderText = "Arquivo";
                        break;
                    case "dataAlteracao":
                        coluna.Width = 50;
                        coluna.HeaderText = "Última Alteração";
                        break;
                    default:
                        break;
                }
            }
        }

        private void gerenciarSubFunçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGerenciarSubfuncoes form = new FormGerenciarSubfuncoes();
            form.Show();
        }

        private void novoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastrarUsuario form = new FormCadastrarUsuario();
            form.Show();
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            FormAlterarSenha form = new FormAlterarSenha();
            form.Show();
        }

        private void gerenciarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGerenciarUsuario form = new FormGerenciarUsuario();
            form.Show();
        }

        private void novaFunçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroFuncao form = new FormCadastroFuncao();
            form.Show();
        }

        private void novaSubFunçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroSubFuncao form = new FormCadastroSubFuncao();
            form.Show();
        }

        private void gerenciarFunçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGerenciarFuncao form = new FormGerenciarFuncao();
            form.Show();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            FormSobre form = new FormSobre();
            form.Show();
        }

        private void FormMenu_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    //this.btnPesquisa(null, null);
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
                default:
                    break;
            }
        }
    }
}
