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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao conexao = new Conexao();

            if ((string.IsNullOrWhiteSpace(txtNovaSenha.Text)) || (string.IsNullOrWhiteSpace(txtSenhaAtual.Text)) ||
                (string.IsNullOrWhiteSpace(txtConfirmarSenha.Text)))
            {
                Validacoes.mensagem("É necessário informar os campos!", ToolTipIcon.Error, "Campos não informados", txtConfirmarSenha);
                return;
            }
            try
            {
                cmd.CommandText = "SELECT senha FROM pessoa where idPessoa = " + UsuarioSession.idUsuario;
                cmd.Connection = conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr.GetString(0) == txtSenhaAtual.Text)
                    {
                        if (Validacoes.verificaUnico("senha", "pessoa", txtNovaSenha.Text, UsuarioSession.idUsuario, "idPessoa") == true)
                        {
                            Validacoes.mensagem("A senha informada já está em uso!", ToolTipIcon.Error, "Senha já Cadastrada", txtNovaSenha);
                            return;
                        }
                        if (txtNovaSenha.Text == txtConfirmarSenha.Text)
                        {
                            Pessoa pessoa = new Pessoa();
                            pessoa.updateSenha(txtNovaSenha.Text, UsuarioSession.idUsuario);
                        }
                        else
                            Validacoes.mensagem("A nova senha não corresponde!", ToolTipIcon.Error, "Senha Incorreta", txtConfirmarSenha);
                    }
                    else
                        Validacoes.mensagem("A senha atual está incorreta!", ToolTipIcon.Error, "Senha Incorreta", txtSenhaAtual);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            this.Close();
        }
    }
}
