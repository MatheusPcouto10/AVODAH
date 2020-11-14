using EscalasMetodista.Conexão;
using EscalasMetodista.Model;
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
    public partial class FormGerenciarUsuario : Form
    {
        Pessoa pessoa = new Pessoa();
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public Boolean temFuncaoSecundaria = false;
        public int idPessoa;

        public FormGerenciarUsuario()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "")
            {
                this.CarregarDataGrid();
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conexao.Conectar();

                    cmd.CommandText = @"SELECT p.idPessoa, p.nome, p.sobrenome, p.email, p.senha, t.descricao, 
                                  f1.descricaoFuncao AS 'Função Principal', s1.descricao AS 'Sub-Função Principal', 
                                  f2.descricaoFuncao AS 'Função Secundária', s2.descricao AS 'Sub-Função Secundária', p.dataCadastro, p.status
                                  FROM pessoa AS p 
	                              LEFT JOIN SubFuncao AS s1 ON s1.idSubFuncao = p.funcaoPrincipal_fk 
	                              LEFT JOIN Funcao AS f1 ON f1.idFuncao = s1.idFuncao_fk 
	                              LEFT JOIN SubFuncao AS s2 ON s2.idSubFuncao = p.funcaoSecundaria_fk 
	                              LEFT JOIN Funcao AS f2 ON f2.idFuncao = s2.idFuncao_fk 
                                  LEFT JOIN TipoUsuario AS t ON t.idTipoUsuario = p.tipoUsuario_fk AND p.nome = " + txtPesquisa.Text;

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows == true)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(dr);
                        dgUsuarios.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("Nenhuma Pessoa Encontrada");
                    }
                }
                catch (Exception erro)
                {
                    // Exibe a mensagem de erro
                    MessageBox.Show("Erro: " +
                        erro.Message);
                }
                conexao.Desconectar();
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

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
            pessoa.Nome = txtNome.Text;
            pessoa.Sobrenome = txtSobrenome.Text;
            pessoa.Email = txtEmail.Text;
            pessoa.Senha = txtSenha.Text;
            pessoa.dataCadastro = dtCadastro.Value;
            pessoa.funcaoPrincipal.idSubFuncao = (int)cbSubFuncaoPrincipal.SelectedValue;
            if (cbSubFuncaoSecundaria.Text != "Selecione...")
            {
                pessoa.funcaoSecundaria.idSubFuncao = (int)cbSubFuncaoSecundaria.SelectedValue;
                temFuncaoSecundaria = true;
            }
            pessoa.tipoUsuario.idTipoUsuario = (int)cbTipoUsuario.SelectedValue;
            pessoa.Status = cbStatus.Text;

            try
            {
                if (Validacoes.verificaUnico("email", "pessoa", txtEmail.Text) == true && Validacoes.verificaUnico("senha", "pessoa", txtSenha.Text) == true)
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

                        if (Validacoes.ValidarObjeto(pessoa) == true)
                        {
                            pessoa.update(pessoa, idPessoa, temFuncaoSecundaria);
                            tabControl1.SelectedIndex = 0;
                            btnSalvarUsuario.Enabled = false;
                            this.CarregarDataGrid();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex);
            }
        }

        private void FormGerenciarUsuario_Load(object sender, EventArgs e)
        {
            this.preencheComboBoxFuncaoPrincipal();
            this.preencheComboBoxFuncaoSecundaria();
            this.preencheComboBoxTipoUsuario();
            this.CarregarDataGrid();
            btnSalvarUsuario.Enabled = false;
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

        private void dgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // pegar o id para editar
            idPessoa = Convert.ToInt32(dgUsuarios.Rows[e.RowIndex].Cells["idPessoa"].Value.ToString());

            //verificar qual a coluna clicada é a de editar
            if (dgUsuarios.Columns[e.ColumnIndex] == dgUsuarios.Columns["editar"])
            {
                txtNome.Text = dgUsuarios.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                txtSobrenome.Text = dgUsuarios.Rows[e.RowIndex].Cells["sobrenome"].Value.ToString();
                txtEmail.Text = dgUsuarios.Rows[e.RowIndex].Cells["email"].Value.ToString();
                txtSenha.Text = dgUsuarios.Rows[e.RowIndex].Cells["senha"].Value.ToString();
                cbTipoUsuario.Text = dgUsuarios.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
                cbStatus.Text = dgUsuarios.Rows[e.RowIndex].Cells["status"].Value.ToString();
                cbFuncaoPrincipal.Text = dgUsuarios.Rows[e.RowIndex].Cells["funcaoPrincipal"].Value.ToString();
                cbSubFuncaoPrincipal.Text = dgUsuarios.Rows[e.RowIndex].Cells["subFuncaoPrincipal"].Value.ToString();
                cbFuncaoSecundaria.Text = dgUsuarios.Rows[e.RowIndex].Cells["funcaoSecundaria"].Value.ToString();
                cbSubFuncaoSecundaria.Text = dgUsuarios.Rows[e.RowIndex].Cells["subFuncaoSecundaria"].Value.ToString();
                dtCadastro.Text = dgUsuarios.Rows[e.RowIndex].Cells["dtCadastro"].Value.ToString();

                tabControl1.SelectedIndex = 1;
                btnSalvarUsuario.Enabled = true;
            }
        }

        private void dgUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgUsuarios.Rows[e.RowIndex].Cells["editar"].ToolTipText = "Clique aqui para editar";
        }

        private void dgUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgUsuarios.Columns)
            {
                switch (coluna.Name)
                {
                    case "idPessoa":
                        coluna.Width = 50;
                        coluna.HeaderText = "ID";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "nome":
                        coluna.Width = 80;
                        coluna.HeaderText = "Nome";
                        break;
                    case "sobrenome":
                        coluna.Width = 80;
                        coluna.HeaderText = "Sobrenome";
                        break;
                    case "email":
                        coluna.Width = 100;
                        coluna.HeaderText = "E-mail";
                        break;
                    case "senha":
                        coluna.Width = 70;
                        coluna.HeaderText = "Senha";
                        break;
                    case "descricao":
                        coluna.Width = 80;
                        coluna.HeaderText = "Tipo de Usuário";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "Função Principal":
                        coluna.Width = 70;
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "Sub-Função Principal":
                        coluna.Width = 70;
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "Função Secundária":
                        coluna.Width = 70;
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "Sub-Função Secundária":
                        coluna.Width = 70;
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "dataCadastro":
                        coluna.Width = 80;
                        coluna.HeaderText = "Data de Nascimento";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "status":
                        coluna.Width = 60;
                        coluna.HeaderText = "Status";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "editar":
                        coluna.Width = 40;
                        coluna.DisplayIndex = 12;
                        break;
                    default:
                        break;
                }
            }
        }
        private void CarregarDataGrid()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conectar();

                cmd.Connection = conexao.Conectar();
                cmd.CommandText = @"SELECT p.idPessoa, p.nome, p.sobrenome, p.email, p.senha, t.descricao, 
                                  f1.descricaoFuncao AS 'Função Principal', s1.descricao AS 'Sub-Função Principal', 
                                  f2.descricaoFuncao AS 'Função Secundária', s2.descricao AS 'Sub-Função Secundária', p.dataCadastro, p.status
                                  FROM pessoa AS p 
	                              LEFT JOIN SubFuncao AS s1 ON s1.idSubFuncao = p.funcaoPrincipal_fk 
	                              LEFT JOIN Funcao AS f1 ON f1.idFuncao = s1.idFuncao_fk 
	                              LEFT JOIN SubFuncao AS s2 ON s2.idSubFuncao = p.funcaoSecundaria_fk 
	                              LEFT JOIN Funcao AS f2 ON f2.idFuncao = s2.idFuncao_fk 
                                  LEFT JOIN TipoUsuario AS t ON t.idTipoUsuario = p.tipoUsuario_fk";


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    // Cria uma tabela genérica
                    DataTable dt = new DataTable();
                    dt.Load(dr); // Carrega os dados para o DataTable
                    dgUsuarios.DataSource = dt; // Preenche o DataGridView
                }
                else
                {
                    MessageBox.Show("erro");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
            conexao.Desconectar();
        }
    }
}
