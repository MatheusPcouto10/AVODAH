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

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            if (txtNomePesquisa.Text == "" && txtIdPesquisa.Text == "")
            {
                FormPesquisaUsuario form = new FormPesquisaUsuario();
                form.Show();
                this.CarregarDataGrid(true, null, null, 0);
            }
            else
            {
                if (txtNomePesquisa.Text == "")
                {
                    this.CarregarDataGrid(false, "p.idPessoa", null, Int32.Parse(txtIdPesquisa.Text));
                }
                else if (txtIdPesquisa.Text != "" && txtNomePesquisa.Text != "")
                {
                    this.CarregarDataGrid(false, "p.idPessoa", null, Int32.Parse(txtIdPesquisa.Text));
                }
                else if (txtIdPesquisa.Text == "")
                {
                    this.CarregarDataGrid(false, "p.nome", txtNomePesquisa.Text, 0);
                }
            }
        }
        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
            pessoa.Nome = txtNome.Text;
            pessoa.Sobrenome = txtSobrenome.Text;
            pessoa.Email = txtEmail.Text;
            pessoa.Senha = txtSenha.Text;
            pessoa.dataCadastro = dtCadastro.Value;
            pessoa.tipoUsuario.idTipoUsuario = (int)cbTipoUsuario.SelectedValue;
            pessoa.Status = cbStatus.Text;

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
                    if (Validacoes.verificaUnico("email", "pessoa", txtEmail.Text, true, idPessoa, "idPessoa") == true ||
                        Validacoes.verificaUnico("senha", "pessoa", txtSenha.Text, true, idPessoa, "idPessoa") == true)
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
                                txtNomePesquisa.Text = "";
                                this.CarregarDataGrid(true, null, null, 0);
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
        private void FormGerenciarUsuario_Load(object sender, EventArgs e)
        {
            this.preencheComboBoxTipoUsuario();
            this.CarregarDataGrid(true, null, null, 0);
            btnSalvarUsuario.Enabled = false;
        }
        private void dgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // pegar o id para editar
            idPessoa = Convert.ToInt32(dgUsuarios.Rows[e.RowIndex].Cells["idPessoa"].Value.ToString());

            //verificar qual a coluna clicada é a de editar
            if (dgUsuarios.Columns[e.ColumnIndex] == dgUsuarios.Columns["editar"])
            {
                this.preencheComboBoxFuncaoPrincipal();
                this.preencheComboBoxFuncaoSecundaria();

                if (dgUsuarios.Rows[e.RowIndex].Cells["Sub-Função Secundária"].Value.ToString() == DBNull.Value.ToString())
                {
                    cbFuncaoSecundaria.Text = "Selecione...";
                    cbSubFuncaoSecundaria.Text = "Selecione...";
                }
                else
                {
                    cbFuncaoSecundaria.Text = dgUsuarios.Rows[e.RowIndex].Cells["Função Secundária"].Value.ToString();
                    cbSubFuncaoSecundaria.Text = dgUsuarios.Rows[e.RowIndex].Cells["Sub-Função Secundária"].Value.ToString();
                }

                txtNome.Text = dgUsuarios.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                txtSobrenome.Text = dgUsuarios.Rows[e.RowIndex].Cells["sobrenome"].Value.ToString();
                txtEmail.Text = dgUsuarios.Rows[e.RowIndex].Cells["email"].Value.ToString();
                txtSenha.Text = dgUsuarios.Rows[e.RowIndex].Cells["senha"].Value.ToString();
                cbTipoUsuario.Text = dgUsuarios.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
                cbStatus.Text = dgUsuarios.Rows[e.RowIndex].Cells["status"].Value.ToString();
                cbFuncaoPrincipal.Text = dgUsuarios.Rows[e.RowIndex].Cells["Função Principal"].Value.ToString();
                cbSubFuncaoPrincipal.Text = dgUsuarios.Rows[e.RowIndex].Cells["Sub-Função Principal"].Value.ToString();
                dtCadastro.Text = dgUsuarios.Rows[e.RowIndex].Cells["dataCadastro"].Value.ToString();

                tabControl1.SelectedIndex = 1;
                btnSalvarUsuario.Enabled = true;
            }
        }
        private void dgUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.preencheComboBoxFuncaoPrincipal();
            this.preencheComboBoxFuncaoSecundaria();

            if (dgUsuarios.Rows[e.RowIndex].Cells["Sub-Função Secundária"].Value.ToString() == DBNull.Value.ToString())
            {
                cbFuncaoSecundaria.Text = "Selecione...";
                cbSubFuncaoSecundaria.Text = "Selecione...";
            }
            else
            {
                cbFuncaoSecundaria.Text = dgUsuarios.Rows[e.RowIndex].Cells["Função Secundária"].Value.ToString();
                cbSubFuncaoSecundaria.Text = dgUsuarios.Rows[e.RowIndex].Cells["Sub-Função Secundária"].Value.ToString();
            }

            txtNome.Text = dgUsuarios.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtSobrenome.Text = dgUsuarios.Rows[e.RowIndex].Cells["sobrenome"].Value.ToString();
            txtEmail.Text = dgUsuarios.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtSenha.Text = dgUsuarios.Rows[e.RowIndex].Cells["senha"].Value.ToString();
            cbTipoUsuario.Text = dgUsuarios.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
            cbStatus.Text = dgUsuarios.Rows[e.RowIndex].Cells["status"].Value.ToString();
            cbFuncaoPrincipal.Text = dgUsuarios.Rows[e.RowIndex].Cells["Função Principal"].Value.ToString();
            cbSubFuncaoPrincipal.Text = dgUsuarios.Rows[e.RowIndex].Cells["Sub-Função Principal"].Value.ToString();
            dtCadastro.Text = dgUsuarios.Rows[e.RowIndex].Cells["dataCadastro"].Value.ToString();

            tabControl1.SelectedIndex = 1;
            btnSalvarUsuario.Enabled = true;
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
                        coluna.Width = 90;
                        coluna.HeaderText = "Nome";
                        break;
                    case "sobrenome":
                        coluna.Width = 90;
                        coluna.HeaderText = "Sobrenome";
                        break;
                    case "email":
                        coluna.Width = 140;
                        coluna.HeaderText = "E-mail";
                        break;
                    case "senha":
                        coluna.Visible = false;
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
        private void CarregarDataGrid(Boolean atualizacao, String campo, String valor, int id)
        {
            SqlCommand cmd = new SqlCommand();

            if (atualizacao == true)
            {
                try
                {
                    cmd.Connection = conexao.Conectar();
                    cmd.CommandText = @"SELECT p.idPessoa, p.nome, p.sobrenome, p.email, p.senha, t.descricao, 
                                  f1.descricaoFuncao AS 'Função Principal', s1.descricao AS 'Sub-Função Principal', 
                                  f2.descricaoFuncao AS 'Função Secundária', s2.descricao AS 'Sub-Função Secundária', p.dataCadastro, p.status
                                  FROM pessoa AS p 
	                              LEFT JOIN SubFuncao AS s1 ON s1.idSubFuncao = p.funcaoPrincipal_fk 
	                              LEFT JOIN Funcao AS f1 ON f1.idFuncao = s1.idFuncao_fk 
	                              LEFT JOIN SubFuncao AS s2 ON s2.idSubFuncao = p.funcaoSecundaria_fk 
	                              LEFT JOIN Funcao AS f2 ON f2.idFuncao = s2.idFuncao_fk 
                                  INNER JOIN TipoUsuario AS t ON t.idTipoUsuario = p.tipoUsuario_fk";


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
                        MessageBox.Show("Nenhum Usuário foi encontrado!", "Usuário Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message);
                }
                conexao.Desconectar();
            }
            else if (valor != null)
            {

                try
                {
                    cmd.Connection = conexao.Conectar();
                    cmd.CommandText = @"SELECT p.idPessoa, p.nome, p.sobrenome, p.email, p.senha, t.descricao, 
                                  f1.descricaoFuncao AS 'Função Principal', s1.descricao AS 'Sub-Função Principal', 
                                  f2.descricaoFuncao AS 'Função Secundária', s2.descricao AS 'Sub-Função Secundária', p.dataCadastro, p.status
                                  FROM pessoa AS p 
	                              LEFT JOIN SubFuncao AS s1 ON s1.idSubFuncao = p.funcaoPrincipal_fk 
	                              LEFT JOIN Funcao AS f1 ON f1.idFuncao = s1.idFuncao_fk 
	                              LEFT JOIN SubFuncao AS s2 ON s2.idSubFuncao = p.funcaoSecundaria_fk 
	                              LEFT JOIN Funcao AS f2 ON f2.idFuncao = s2.idFuncao_fk 
                                  INNER JOIN TipoUsuario AS t ON t.idTipoUsuario = p.tipoUsuario_fk AND " + campo + " LIKE '" + valor + "'";


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
                        MessageBox.Show("Nenhum Usuário foi encontrado!", "Usuário Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message);
                }
                conexao.Desconectar();

            }
            else if (valor == null)
            {

                try
                {
                    cmd.Connection = conexao.Conectar();
                    cmd.CommandText = @"SELECT p.idPessoa, p.nome, p.sobrenome, p.email, p.senha, t.descricao, 
                                  f1.descricaoFuncao AS 'Função Principal', s1.descricao AS 'Sub-Função Principal', 
                                  f2.descricaoFuncao AS 'Função Secundária', s2.descricao AS 'Sub-Função Secundária', p.dataCadastro, p.status
                                  FROM pessoa AS p 
	                              LEFT JOIN SubFuncao AS s1 ON s1.idSubFuncao = p.funcaoPrincipal_fk 
	                              LEFT JOIN Funcao AS f1 ON f1.idFuncao = s1.idFuncao_fk 
	                              LEFT JOIN SubFuncao AS s2 ON s2.idSubFuncao = p.funcaoSecundaria_fk 
	                              LEFT JOIN Funcao AS f2 ON f2.idFuncao = s2.idFuncao_fk 
                                  INNER JOIN TipoUsuario AS t ON t.idTipoUsuario = p.tipoUsuario_fk AND " + campo + " = '" + id + "'";


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
                        MessageBox.Show("Nenhum Usuário foi encontrado!", "Usuário Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message);
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
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void FormGerenciarUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    this.btnPesquisa_Click(null, null);
                    break;
                default:
                    break;
            }
        }
    }
}
