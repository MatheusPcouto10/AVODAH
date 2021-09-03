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
using FontAwesome.Sharp;

namespace EscalasMetodista.Views.Usuarios
{
    public partial class FormCadastrarUsuario : Form
    {
        Pessoa pessoa = new Pessoa();
        SqlCommand cmd = new SqlCommand();
        private bool temFuncaoSecundaria = false;
        private bool update = false;
        private int idPessoaPesquisa { get; set; }
        public FormCadastrarUsuario()
        {
            InitializeComponent();
        }

        public FormCadastrarUsuario(int id)
        {
            InitializeComponent();
            idPessoaPesquisa = id;
            update = true;
            btnSalvar.IconChar = IconChar.Pen;
        }

        private string gerarSenha()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ023456789";
            string senha = "";
            Random random = new Random();
            for (int f = 0; f < 6; f++)
            {
                senha = senha + chars.Substring(random.Next(0, chars.Length - 1), 1);
            }

            return senha;
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

        private void FormCadastrarUsuario_Load(object sender, EventArgs e)
        {
            this.preencheComboBoxFuncaoPrincipal();
            this.preencheComboBoxFuncaoSecundaria();
            this.preencheComboBoxTipoUsuario();

            if (!btnDeletar.Enabled)
            {
                btnDeletar.ForeColor = Color.DarkGray;
            }
            else
                btnDeletar.ForeColor = Color.Black;

            if (update)
            {
                pessoa = pessoa.find(idPessoaPesquisa);

                if (pessoa != null)
                {
                    txtNome.Text = pessoa.Nome;
                    txtSobrenome.Text = pessoa.Sobrenome;
                    txtEmail.Text = pessoa.Email;
                    cbFuncaoPrincipal.SelectedValue = pessoa.funcaoPrincipal.funcao.idFuncao;
                    cbSubFuncaoPrincipal.SelectedValue = pessoa.funcaoPrincipal.idSubFuncao;

                    if (pessoa.funcaoSecundaria != null)
                    {
                        cbFuncaoSecundaria.SelectedValue = pessoa.funcaoSecundaria.funcao.idFuncao;
                        cbSubFuncaoSecundaria.SelectedValue = pessoa.funcaoSecundaria.idSubFuncao;
                    }
                    else
                    {
                        cbFuncaoSecundaria.Text = "Selecione...";
                        cbSubFuncaoSecundaria.Text = "Selecione...";
                    }
                    
                    cbTipoUsuario.SelectedValue = pessoa.tipoUsuario.idTipoUsuario;
                    btnDeletar.Enabled = true;
                }
            }
            else
            {
                cbTipoUsuario.Text = "Selecione...";
                cbFuncaoPrincipal.Text = "Selecione...";
                cbFuncaoSecundaria.Text = "Selecione...";
                cbSubFuncaoPrincipal.Text = "Selecione...";
                cbSubFuncaoSecundaria.Text = "Selecione...";
            }
        }

        private void cbFuncaoPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.preencheComboBoxSubFuncaoPrincipal();
        }

        private void cbFuncaoSecundaria_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.preencheComboboxSubFuncaoSecundaria();
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

        private void cbFuncaoPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cbSubFuncaoPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cbFuncaoSecundaria_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cbSubFuncaoSecundaria_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cbTipoUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pessoa.delete(pessoa.idPessoa);
                btnLimparForm_Click(null, null);
            }
        }

        private void btnLimparForm_Click(object sender, EventArgs e)
        {
            txtNome.Text = null;
            txtSobrenome.Text = null;
            txtEmail.Text = null;
            cbTipoUsuario.Text = "Selecione...";
            cbFuncaoPrincipal.Text = "Selecione...";
            cbFuncaoSecundaria.Text = "Selecione...";
            cbSubFuncaoPrincipal.Text = "Selecione...";
            cbSubFuncaoSecundaria.Text = "Selecione...";
            update = false;
            btnSalvar.IconChar = IconChar.Plus;
            pessoa = new Pessoa();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            pessoa.Nome = txtNome.Text;
            pessoa.Sobrenome = txtSobrenome.Text;
            pessoa.Email = txtEmail.Text;

            if (!update)
            {
                pessoa.idPessoa = pessoa.getId();
                pessoa.Senha = gerarSenha();
                pessoa.dataCadastro = DateTime.Today;
                pessoa.Status = "Ativo";
            }

            pessoa.tipoUsuario.idTipoUsuario = (int)cbTipoUsuario.SelectedValue;

            if (cbFuncaoPrincipal.Text != "Selecione...")
            {
                SubFuncao sub = new SubFuncao();
                pessoa.funcaoPrincipal = sub.find((int)cbSubFuncaoPrincipal.SelectedValue);


                if (cbSubFuncaoSecundaria.Text != "Selecione...")
                {
                    pessoa.funcaoSecundaria = sub.find((int) cbSubFuncaoSecundaria.SelectedValue);
                    temFuncaoSecundaria = true;
                }
                else 
                    temFuncaoSecundaria = false;

                try
                {
                    if (Validacoes.verificaUnico("email", "pessoa", txtEmail.Text, pessoa.idPessoa, "idPessoa") == true)
                    {
                        Validacoes.mensagem("O e-mail já está em uso!", ToolTipIcon.Error, "Dados já cadastrados", txtEmail);
                        return;
                    }
                    if (cbSubFuncaoPrincipal.Text == cbSubFuncaoSecundaria.Text)
                    {
                        Validacoes.mensagem("As sub-funções não podem ser iguais!", ToolTipIcon.Error, "Sub-Função Cadastrada", groupBox1);
                        Validacoes.mensagem("As sub-funções não podem ser iguais!", ToolTipIcon.Error, "Sub-Função Cadastrada", groupBox2);
                        return;
                    }
                    if (Validacoes.ValidarObjeto(pessoa) == true)
                    {
                        if (update)
                        {
                            pessoa.update(pessoa, pessoa.idPessoa, temFuncaoSecundaria);
                        }
                        else
                            pessoa.create(pessoa, temFuncaoSecundaria);

                        //this.btnLimpar_Click(null, null);
                        pessoa = pessoa.find(pessoa.idPessoa);

                        if (pessoa != null)
                        {
                            txtNome.Text = pessoa.Nome;
                            txtSobrenome.Text = pessoa.Sobrenome;
                            txtEmail.Text = pessoa.Email;
                            cbFuncaoPrincipal.SelectedValue = pessoa.funcaoPrincipal.funcao.idFuncao;
                            cbSubFuncaoPrincipal.SelectedValue = pessoa.funcaoPrincipal.idSubFuncao;

                            if (pessoa.funcaoSecundaria != null)
                            {
                                cbFuncaoSecundaria.SelectedValue = pessoa.funcaoSecundaria.funcao.idFuncao;
                                cbSubFuncaoSecundaria.SelectedValue = pessoa.funcaoSecundaria.idSubFuncao;
                            }
                            else
                            {
                                cbFuncaoSecundaria.Text = "Selecione...";
                                cbSubFuncaoSecundaria.Text = "Selecione...";
                            }

                            cbTipoUsuario.SelectedValue = pessoa.tipoUsuario.idTipoUsuario;
                            btnDeletar.Enabled = true;
                            btnSalvar.IconChar = IconChar.Pen;
                            update = true;
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
                Validacoes.mensagem("É Necessário ter uma Função Principal!", ToolTipIcon.Error, "Função Principal", cbFuncaoPrincipal);
            }
        }

        private void btnConsultarUsuario_Click(object sender, EventArgs e)
        {
            FormPesquisaUsuario form = new FormPesquisaUsuario();
            form.ShowDialog();
        }

        private void btnLimparForm_MouseHover(object sender, EventArgs e)
        {
            btnLimparForm.BackColor = Color.LightGray;
            btnLimparForm.ForeColor = Color.Black;
            btnLimparForm.IconColor = Color.Black;
            btnLimparForm.FlatAppearance.BorderColor = Color.Black;
        }

        private void btnLimparForm_MouseLeave(object sender, EventArgs e)
        {
            btnLimparForm.BackColor = Color.Transparent;
            btnLimparForm.ForeColor = Color.LightGray;
            btnLimparForm.IconColor = Color.LightGray;
            btnLimparForm.FlatAppearance.BorderColor = Color.LightGray;
        }

        private void btnDeletar_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnDeletar.Enabled)
            {
                btnDeletar.ForeColor = Color.DarkGray;
            }
            else
                btnDeletar.ForeColor = Color.Black;
        }
    }
}
