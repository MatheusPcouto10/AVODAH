﻿using EscalasMetodista.Conexão;
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

namespace EscalasMetodista
{
    public partial class FormLogin : Form
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT idPessoa, nome, sobrenome, email, senha, tipoUsuario_fk FROM pessoa " +
                              "WHERE email = '" + txtEmail.Text +
                              "' AND senha = '" + txtSenha.Text + "' AND status = 'Ativo'";

            try
            {
                cmd.Connection = conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    FormMenu formMenu = new FormMenu();

                    UsuarioSession.tipoUsuario = Convert.ToInt32(dr[5].ToString());
                    UsuarioSession.idUsuario = Convert.ToInt32(dr[0].ToString());
                    UsuarioSession.nomeUsuario = dr[1].ToString();
                    UsuarioSession.sobrenomeUsuario = dr[2].ToString();

                    formMenu.Show();
                    this.Hide();
                }
                else
                {
                    Validacoes.mensagem("Usuário e/ou senha incorretos!", ToolTipIcon.Error, "Dados incorretos", txtSenha);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtSenha.Text = "";
        }

        private void checkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMostrarSenha.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    this.btnEntrar_Click(null, null);
                    break;
                default:
                    break;
            }
        }

        private void btnLimpar_MouseHover(object sender, EventArgs e)
        {
            btnLimpar.BackColor = Color.White;
            btnLimpar.ForeColor = Color.Black;
        }

        private void btnLimpar_MouseLeave(object sender, EventArgs e)
        {
            btnLimpar.BackColor = Color.Transparent;
            btnLimpar.ForeColor = Color.White;
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
