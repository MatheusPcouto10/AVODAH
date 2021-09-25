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
                Validacoes.exibeMensagem("É necessário informar os campos!", Outros.Mensagem.tipo.Erro, false);
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
                            Validacoes.exibeMensagem("A senha informada já está em uso", Outros.Mensagem.tipo.Erro, false);
                            return;
                        }
                        if (txtNovaSenha.Text == txtConfirmarSenha.Text)
                        {
                            Pessoa pessoa = new Pessoa();
                            pessoa.updateSenha(txtNovaSenha.Text, UsuarioSession.idUsuario);
                            //this.Close();
                        }
                        else
                            Validacoes.exibeMensagem("A nova senha não corresponde", Outros.Mensagem.tipo.Erro, false);
                    }
                    else
                        Validacoes.exibeMensagem("A senha atual está incorreta", Outros.Mensagem.tipo.Erro, false);
                }
            }

            catch (Exception ex)
            {
                Validacoes.exibeMensagem("Erro: " + ex.Message, Outros.Mensagem.tipo.Erro, false);
            }
        }
    }
}
