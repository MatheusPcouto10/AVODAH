using EscalasMetodista.Conexão;
using EscalasMetodista.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscalasMetodista.Views.Usuarios
{
    public partial class FormPesquisaUsuario : Form
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public FormPesquisaUsuario()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            // Atualização
            if ((txtIdPessoa.Text == "") && (txtNome.Text == "") && (cbSubFuncao.Text == "Selecione...")
                && (cbStatus.Text == "Selecione...") && (cbTipoUsuario.Text == "Selecione..."))
            {
                this.CarregarDataGrid(true, null, null, 0);
            }
            // Pesquisa por ID
            else if ((txtNome.Text == "") && (cbSubFuncao.Text == "Selecione...")
                && (cbStatus.Text == "Selecione...") && (cbTipoUsuario.Text == "Selecione..."))
            {
                this.CarregarDataGrid(false, "p.idPessoa", txtIdPessoa.Text, 0);
            }
            // Pesquisa por Nome
            else if ((txtIdPessoa.Text == "") && (cbSubFuncao.Text == "Selecione...")
               && (cbStatus.Text == "Selecione...") && (cbTipoUsuario.Text == "Selecione..."))
            {
                this.CarregarDataGrid(false, "p.nome", txtNome.Text, 0);
            }
            // Pesquisa por Sub-Função Principal
            else if ((txtIdPessoa.Text == "") && (txtNome.Text == "") && (cbStatus.Text == "Selecione...")
                    && (cbTipoUsuario.Text == "Selecione..."))
            {
                this.CarregarDataGrid(false, "p.funcaoPrincipal_fk", null, (int)cbSubFuncao.SelectedValue);
            }
            // Pesquisa por Status
            else if ((txtIdPessoa.Text == "") && (txtNome.Text == "") && (cbSubFuncao.Text == "Selecione...")
                    && (cbTipoUsuario.Text == "Selecione..."))
            {
                this.CarregarDataGrid(false, "p.status", cbStatus.Text, 0);
            }
            // Pesquisa por Tipo de Usuário
            else if ((txtIdPessoa.Text == "") && (txtNome.Text == "") && (cbSubFuncao.Text == "Selecione...")
                    && (cbStatus.Text == "Selecione..."))
            {
                this.CarregarDataGrid(false, "p.tipoUsuario_fk", null, (int)cbTipoUsuario.SelectedValue);
            }

        }

        private void dgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = dgUsuarios.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtIdPessoa.Text = dgUsuarios.Rows[e.RowIndex].Cells["idPessoa"].Value.ToString();
            cbTipoUsuario.Text = dgUsuarios.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
            cbStatus.Text = dgUsuarios.Rows[e.RowIndex].Cells["status"].Value.ToString();
            cbFuncao.Text = dgUsuarios.Rows[e.RowIndex].Cells["Função Principal"].Value.ToString();
            cbSubFuncao.Text = dgUsuarios.Rows[e.RowIndex].Cells["Sub-Função Principal"].Value.ToString();
        }

        private void dgUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            (Application.OpenForms["FormGerenciarUsuario"].Controls["tabControl1"]
                .Controls["telaPesquisa"].Controls["txtIdPesquisa"] as TextBox).Text = txtIdPessoa.Text;
            (Application.OpenForms["FormGerenciarUsuario"].Controls["tabControl1"]
                .Controls["telaPesquisa"].Controls["txtNomePesquisa"] as TextBox).Text = txtNome.Text;
            this.Close();
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
                    case "status":
                        coluna.Width = 60;
                        coluna.HeaderText = "Status";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    default:
                        break;
                }
            }
        }

        private void FormPesquisaUsuario_Load(object sender, EventArgs e)
        {
            this.preencheComboBoxTipoUsuario();
            this.preencheComboBoxFuncao();
            this.CarregarDataGrid(true, null, null, 0);
            cbFuncao.Text = "Selecione...";
            cbSubFuncao.Text = "Selecione...";
            cbTipoUsuario.Text = "Selecione...";
            cbStatus.Text = "Selecione...";
        }

        private void CarregarDataGrid(Boolean atualizacao, String campo, String valor, int id)
        {
            SqlCommand cmd = new SqlCommand();

            if (atualizacao == true)
            {
                try
                {
                    cmd.Connection = conexao.Conectar();
                    cmd.CommandText = @"SELECT p.idPessoa, p.nome, p.sobrenome, t.descricao, 
                                  f1.descricaoFuncao AS 'Função Principal', s1.descricao AS 'Sub-Função Principal', 
                                  f2.descricaoFuncao AS 'Função Secundária', s2.descricao AS 'Sub-Função Secundária', p.status
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
                    cmd.CommandText = @"SELECT p.idPessoa, p.nome, p.sobrenome, t.descricao, 
                                  f1.descricaoFuncao AS 'Função Principal', s1.descricao AS 'Sub-Função Principal', 
                                  f2.descricaoFuncao AS 'Função Secundária', s2.descricao AS 'Sub-Função Secundária', p.status
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
                    cmd.CommandText = @"SELECT p.idPessoa, p.nome, p.sobrenome, t.descricao, 
                                  f1.descricaoFuncao AS 'Função Principal', s1.descricao AS 'Sub-Função Principal', 
                                  f2.descricaoFuncao AS 'Função Secundária', s2.descricao AS 'Sub-Função Secundária', p.status
                                  FROM pessoa AS p 
	                              LEFT JOIN SubFuncao AS s1 ON s1.idSubFuncao = p.funcaoPrincipal_fk 
	                              LEFT JOIN Funcao AS f1 ON f1.idFuncao = s1.idFuncao_fk 
	                              LEFT JOIN SubFuncao AS s2 ON s2.idSubFuncao = p.funcaoSecundaria_fk 
	                              LEFT JOIN Funcao AS f2 ON f2.idFuncao = s2.idFuncao_fk 
                                  INNER JOIN TipoUsuario AS t ON t.idTipoUsuario = p.tipoUsuario_fk AND " + campo + " = " + id;


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

        private void preencheComboBoxFuncao()
        {
            cmd.CommandText = "SELECT * FROM funcao";
            Conexao conexao = new Conexao();
            try
            {
                cmd.Connection = conexao.Conectar();
                DataTable dt = new DataTable();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

                cbFuncao.DisplayMember = "descricaoFuncao";
                cbFuncao.ValueMember = "idFuncao";
                cbFuncao.DataSource = dt;

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

        private void preencheComboBoxSubFuncao()
        {
            cmd.CommandText = "SELECT * FROM subfuncao WHERE idFuncao_fk = " + (int)cbFuncao.SelectedValue;
            Conexao conexao = new Conexao();
            try
            {
                cmd.Connection = conexao.Conectar();
                DataTable dt = new DataTable();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

                cbSubFuncao.DisplayMember = "descricao";
                cbSubFuncao.ValueMember = "idSubfuncao";
                cbSubFuncao.DataSource = dt;

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

        private void btnLimparFuncao_Click(object sender, EventArgs e)
        {
            cbFuncao.Text = "Selecione...";
            cbSubFuncao.Text = "Selecione...";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cbFuncao.Text = "Selecione...";
            cbSubFuncao.Text = "Selecione...";
            cbStatus.Text = "Selecione...";
            cbTipoUsuario.Text = "Selecione...";
            txtIdPessoa.Text = "";
            txtNome.Text = "";
            this.CarregarDataGrid(true, null, null, 0);
        }

        private void cbFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.preencheComboBoxSubFuncao();
        }
        private void FormPesquisaUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    this.btnPesquisar_Click(null, null);
                    break;
                default:
                    break;
            }
        }
    }
}
