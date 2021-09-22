using EscalasMetodista.Session;
using EscalasMetodista.Views;
using EscalasMetodista.Views.Escalas;
using EscalasMetodista.Views.Funcoes;
using EscalasMetodista.Views.Outros;
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
                this.btnFuncoes.Visible = false;
                this.btnUsuarios.Visible = false;
                toolStripSeparator4.Visible = false;
                toolStripSeparator6.Visible = false;
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
            DateTime dataHoje = DateTime.Today;
            this.btnPerfil.Text = "Bem vindo(a) " + UsuarioSession.nomeUsuario + " " + UsuarioSession.sobrenomeUsuario + " !";
            this.labelIdUsuarioLogado.Text = "Código: " + UsuarioSession.idUsuario;
            this.labelData.Text = "Data: " + dataHoje.ToString("D");
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

        private void gerenciarSubFunçoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGerenciarSubfuncoes form = new FormGerenciarSubfuncoes();
            form.Show();
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            FormAlterarSenha form = new FormAlterarSenha();
            form.ShowDialog();
        }

        private void gerenciarFunçoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGerenciarFuncao form = new FormGerenciarFuncao();
            form.Show();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            FormSobre form = new FormSobre();
            form.ShowDialog();
        }

        private void FormMenu_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    //this.btnPesquisa(null, null);
                    break;
                case Keys.Escape:
                    this.btnSair_Click(null, null);
                    break;
                default:
                    break;
            }
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            FormCadastrarUsuario form = new FormCadastrarUsuario(UsuarioSession.idUsuario);
            form.cbFuncaoPrincipal.Enabled = false;
            form.cbFuncaoSecundaria.Enabled = false;
            form.cbSubFuncaoPrincipal.Enabled = false;
            form.cbSubFuncaoSecundaria.Enabled = false;
            form.cbTipoUsuario.Enabled = false;
            form.btnDeletar.Visible = false;
            form.btnLimparForm.Visible = false;
            form.btnConsultarUsuario.Visible = false;
            form.btnSalvar.Left = (form.Width - form.btnSalvar.Width) / 2;
            form.lbTitulo.Text = "EDITAR PERFIL";
            form.Text = "Editar Perfil";
            form.lbTitulo.Left = (form.Width - form.lbTitulo.Width) / 2;
            form.btnLimparFuncaoPrincipal.Visible = false;
            form.btnLimparFuncaoSecundaria.Visible = false;
            form.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormCadastrarUsuario form = new FormCadastrarUsuario();
            form.Show();
        }

        private void btnEscalas_Click(object sender, EventArgs e)
        {
            FormPersonalizarEscala form = new FormPersonalizarEscala();
            form.Show();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            FormAjuda form = new FormAjuda();
            form.ShowDialog();
        }
    }
}
