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

namespace EscalasMetodista.Views.Usuarios
{
    public partial class FormCadastrarUsuario : Form
    {
        Pessoa pessoa = new Pessoa();
        SqlCommand cmd = new SqlCommand();
        public Boolean temFuncaoSecundaria = false;
        public FormCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
            pessoa.Nome = txtNome.Text;
            pessoa.Sobrenome = txtSobrenome.Text;
            pessoa.Email = txtEmail.Text;
            pessoa.Senha = txtSenha.Text;
            pessoa.dataCadastro = dtCadastro.Value;
            pessoa.tipoUsuario.idTipoUsuario = (int)cbTipoUsuario.SelectedValue;
            pessoa.Status = "Ativo";

            if (cbFuncaoPrincipal.Text != "Selecione...")
            {
                pessoa.funcaoPrincipal.idSubFuncao = (int)cbSubFuncaoPrincipal.SelectedValue;


                if (cbSubFuncaoSecundaria.Text != "Selecione...")
                {
                    pessoa.funcaoSecundaria.idSubFuncao = (int)cbSubFuncaoSecundaria.SelectedValue;
                    temFuncaoSecundaria = true;
                }
                else if (cbSubFuncaoSecundaria.Text == "Selecione...")
                {
                    temFuncaoSecundaria = false;
                }

                try
                {
                    if (Validacoes.verificaUnico("email", "pessoa", txtEmail.Text, false, 0, null) == true ||
                        Validacoes.verificaUnico("senha", "pessoa", txtSenha.Text, false, 0, null) == true)
                    {
                        MessageBox.Show("O e-mail e/ou senha já está em uso!", "E-mail/Senha já Cadastrado ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (cbSubFuncaoPrincipal.Text == cbSubFuncaoSecundaria.Text)
                        {
                            MessageBox.Show("As sub-funções não podem ser iguais!", "Sub-Função Cadastrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (txtConfirmarSenha.Text == txtSenha.Text)
                            {
                                if (Validacoes.ValidarObjeto(pessoa) == true)
                                {
                                    pessoa.create(pessoa, temFuncaoSecundaria);
                                    this.btnLimpar_Click(null, null);
                                }
                            }
                            else
                            {
                                MessageBox.Show("As senhas informadas não são iguais!", "Senha não Correspondente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro: " + ex);
                }
            }
            else
            {
                MessageBox.Show("É Necessário ter uma Função Principal!", "Função Principal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void preencheComboBoxTipoUsuario()
        {
            cmd.CommandText = "SELECT * FROM tipoUsuario";
            Conexao conexao = new Conexao();
            try
            {
                cmd.Connection = conexao.Conectar();
                DataTable dt = new DataTable();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

                cbTipoUsuario.DisplayMember = "descricao";
                cbTipoUsuario.ValueMember = "idTipoUsuario";
                cbTipoUsuario.DataSource = dt;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        private void preencheComboBoxFuncaoPrincipal()
        {
            cmd.CommandText = "SELECT * FROM funcao";
            Conexao conexao = new Conexao();
            try
            {
                cmd.Connection = conexao.Conectar();
                DataTable dt = new DataTable();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

                cbFuncaoPrincipal.DisplayMember = "descricaoFuncao";
                cbFuncaoPrincipal.ValueMember = "idFuncao";
                cbFuncaoPrincipal.DataSource = dt;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        private void preencheComboBoxFuncaoSecundaria()
        {
            cmd.CommandText = "SELECT * FROM funcao";
            Conexao conexao = new Conexao();
            try
            {
                cmd.Connection = conexao.Conectar();
                DataTable dt = new DataTable();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

                cbFuncaoSecundaria.DisplayMember = "descricaoFuncao";
                cbFuncaoSecundaria.ValueMember = "idFuncao";
                cbFuncaoSecundaria.DataSource = dt;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }
        private void preencheComboBoxSubFuncaoPrincipal()
        {
            cmd.CommandText = "SELECT * FROM subfuncao WHERE idFuncao_fk = " + (int)cbFuncaoPrincipal.SelectedValue;
            Conexao conexao = new Conexao();
            try
            {
                cmd.Connection = conexao.Conectar();
                DataTable dt = new DataTable();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

                cbSubFuncaoPrincipal.DisplayMember = "descricao";
                cbSubFuncaoPrincipal.ValueMember = "idSubfuncao";
                cbSubFuncaoPrincipal.DataSource = dt;

                dr.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        private void preencheComboboxSubFuncaoSecundaria()
        {
            cmd.CommandText = "SELECT * FROM subfuncao WHERE idFuncao_fk = " + (int)cbFuncaoSecundaria.SelectedValue;
            Conexao conexao = new Conexao();
            try
            {
                cmd.Connection = conexao.Conectar();
                DataTable dt = new DataTable();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

                cbSubFuncaoSecundaria.DisplayMember = "descricao";
                cbSubFuncaoSecundaria.ValueMember = "idSubfuncao";
                cbSubFuncaoSecundaria.DataSource = dt;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = null;
            txtSobrenome.Text = null;
            txtEmail.Text = null;
            txtSenha.Text = null;
            txtConfirmarSenha.Text = null;
            cbTipoUsuario.Text = "Selecione...";
            cbFuncaoPrincipal.Text = "Selecione...";
            cbFuncaoSecundaria.Text = "Selecione...";
            cbSubFuncaoPrincipal.Text = "Selecione...";
            cbSubFuncaoSecundaria.Text = "Selecione...";
        }

        private void FormCadastrarUsuario_Load(object sender, EventArgs e)
        {
            this.preencheComboBoxFuncaoPrincipal();
            this.preencheComboBoxFuncaoSecundaria();
            this.preencheComboBoxTipoUsuario();
            cbTipoUsuario.Text = "Selecione...";
            cbFuncaoPrincipal.Text = "Selecione...";
            cbFuncaoSecundaria.Text = "Selecione...";
            cbSubFuncaoPrincipal.Text = "Selecione...";
            cbSubFuncaoSecundaria.Text = "Selecione...";
        }

        private void cbFuncaoPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.preencheComboBoxSubFuncaoPrincipal();
        }

        private void cbFuncaoSecundaria_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.preencheComboboxSubFuncaoSecundaria();
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

        private void btnLimparFuncaoPrincipal_Click(object sender, EventArgs e)
        {
            cbFuncaoPrincipal.Text = "Selecione...";
            cbSubFuncaoPrincipal.Text = "Selecione...";
        }

        private void btnLimparFuncaoSecundaria_Click(object sender, EventArgs e)
        {
            cbFuncaoSecundaria.Text = "Selecione...";
            cbSubFuncaoSecundaria.Text = "Selecione...";
        }
    }
}
