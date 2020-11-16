using EscalasMetodista.Conexão;
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

            try
            {
                cmd.CommandText = "SELECT senha FROM pessoa where idPessoa = " + UsuarioSession.idUsuario;
                cmd.Connection = conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (dr.GetString(0) == txtSenhaAtual.Text)
                    {
                        if (txtNovaSenha.Text == txtConfirmarSenha.Text)
                        {
                            conexao.Desconectar();
                            cmd.CommandText = "UPDATE pessoa SET senha = '" + txtNovaSenha.Text +
                                              "' WHERE idPessoa = " + UsuarioSession.idUsuario;

                            cmd.Connection = conexao.Conectar();
                            cmd.ExecuteNonQuery();
                            conexao.Desconectar();
                            MessageBox.Show("Senha alterada com sucesso!");
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("A nova senha não corresponde!", "Senha Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void FormAlterarSenha_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    this.btnAlterarSenha_Click(null, null);
                    break;
                default:
                    break;
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
