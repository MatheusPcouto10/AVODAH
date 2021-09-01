using EscalasMetodista.Conexão;
using EscalasMetodista.Model;
using EscalasMetodista.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscalasMetodista.Views
{
    public partial class FormAlterarSenha : Form
    {
        public FormAlterarSenha()
        {
            InitializeComponent();
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();

            if ((string.IsNullOrWhiteSpace(txtNovaSenha.Text)) || (string.IsNullOrWhiteSpace(txtSenhaAtual.Text)) ||
                (string.IsNullOrWhiteSpace(txtConfirmarSenha.Text)))
            {
                MessageBox.Show("É necessário informar os campos!", "Campos não informados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    cmd.CommandText = "SELECT senha FROM pessoa where idPessoa = " + UsuarioSession.idUsuario;
                    cmd.Connection = conexao.Conectar();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {

                        if (dr.GetString(0) == txtSenhaAtual.Text)
                        {
                            if (Validacoes.verificaUnico("senha", "pessoa", txtNovaSenha.Text, 0, null) == true)
                            {
                                MessageBox.Show("A senha informada já está em uso!", "Senha já Cadastrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (txtNovaSenha.Text == txtConfirmarSenha.Text)
                                {
                                    Pessoa pessoa = new Pessoa();
                                    pessoa.updateSenha(txtNovaSenha.Text, UsuarioSession.idUsuario);
                                }
                                else
                                {
                                    MessageBox.Show("A nova senha não corresponde!", "Senha Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("A senha atual está incorreta!", "Senha Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex);
                }
            }
        }

        private void checkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMostrarSenha.Checked)
            {
                txtSenhaAtual.UseSystemPasswordChar = false;
                txtConfirmarSenha.UseSystemPasswordChar = false;
                txtNovaSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtNovaSenha.UseSystemPasswordChar = true;
                txtSenhaAtual.UseSystemPasswordChar = true;
                txtConfirmarSenha.UseSystemPasswordChar = true;
            }
        }
    }
}
