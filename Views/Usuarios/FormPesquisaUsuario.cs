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
using System.Threading;
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

            if (txtCodigoNome.Text == null && cbSubFuncao.Text == "Selecione..." && cbTipoUsuario.Text == "Selecione...")
            {
                this.CarregarDataGrid(false);
                return;
            }
            this.CarregarDataGrid(true);

        }

        private void dgUsuariosPesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoNome.Text = dgUsuariosPesquisa.Rows[e.RowIndex].Cells["idPessoa"].Value.ToString() + " - " + dgUsuariosPesquisa.Rows[e.RowIndex].Cells["nome"].Value.ToString() + " " + dgUsuariosPesquisa.Rows[e.RowIndex].Cells["sobrenome"].Value.ToString();
            cbTipoUsuario.Text = dgUsuariosPesquisa.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
            cbFuncao.Text = dgUsuariosPesquisa.Rows[e.RowIndex].Cells["Função Principal"].Value.ToString();
            cbSubFuncao.Text = dgUsuariosPesquisa.Rows[e.RowIndex].Cells["Sub-Função Principal"].Value.ToString();

        }

        private void dgUsuariosPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Application.OpenForms["FormCadastrarUsuario"].Hide();


            FormCadastrarUsuario form2 = new FormCadastrarUsuario((int)dgUsuariosPesquisa.Rows[e.RowIndex].Cells["idPessoa"].Value);
            form2.Show();

            Application.OpenForms["FormCadastrarUsuario"].Close();

            this.Close();
        }

        private void dgUsuariosPesquisa_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgUsuariosPesquisa.Columns)
            {
                switch (coluna.Name)
                {
                    case "idPessoa":
                        coluna.Width = 60;
                        coluna.HeaderText = "ID";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "nome":
                        coluna.Width = 160;
                        coluna.HeaderText = "Nome";
                        break;
                    case "sobrenome":
                        coluna.Width = 160;
                        coluna.HeaderText = "Sobrenome";
                        break;
                    case "descricao":
                        coluna.Width = 90;
                        coluna.HeaderText = "Tipo de Usuário";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "Função Principal":
                        coluna.Width = 100;
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "Sub-Função Principal":
                        coluna.Width = 120;
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "Função Secundária":
                        coluna.Width = 100;
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "Sub-Função Secundária":
                        coluna.Width = 120;
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    default:
                        break;
                }
            }
        }

        private void FormPesquisaUsuario_Load(object sender, EventArgs e)
        {
            this.CarregarDataGrid(false);
            this.preencheComboBoxTipoUsuario();
            this.preencheComboBoxFuncao();
            cbFuncao.Text = "Selecione...";
            cbSubFuncao.Text = "Selecione...";
            cbTipoUsuario.Text = "Selecione...";
            txtCodigoNome.Text = null;

        }

        private void CarregarDataGrid(bool pesquisa)
        {
            SqlCommand cmd = new SqlCommand();

            string campoPesquisa = null;

            if (txtCodigoNome.Text != null)
            {
                campoPesquisa = "AND (p.idPessoa IS NULL OR cast(p.idPessoa as varchar) = '" + txtCodigoNome.Text + "') OR (p.nome IS NULL OR p.nome LIKE '%" + txtCodigoNome.Text + "%') " +
                                  "OR (p.sobrenome IS NULL OR p.sobrenome LIKE '%" + txtCodigoNome.Text + "%') ";
            }

            if (cbFuncao.Text != "Selecione...")
            {
                campoPesquisa = "AND (f1.descricaoFuncao IS NULL OR f1.descricaoFuncao = '" + cbFuncao.Text + "') ";
            }

            if (cbSubFuncao.Text != "Selecione...")
            {
                campoPesquisa = "AND (s1.descricao IS NULL OR s1.descricao = '" + cbSubFuncao.Text + "') ";
            }


            if (cbTipoUsuario.Text != "Selecione...")
            {
                campoPesquisa = "AND (t.descricao IS NULL OR t.descricao = '" + cbTipoUsuario.Text + "') ";
            }

            try
            {
                cmd.Connection = conexao.Conectar();

                if (pesquisa)
                {
                    cmd.CommandText = @"SELECT p.idPessoa, p.nome, p.sobrenome, t.descricao,
                                  f1.descricaoFuncao AS 'Função Principal', s1.descricao AS 'Sub-Função Principal', 
                                  f2.descricaoFuncao AS 'Função Secundária', s2.descricao AS 'Sub-Função Secundária'
                                  FROM pessoa AS p 
	                              LEFT JOIN SubFuncao AS s1 ON s1.idSubFuncao = p.funcaoPrincipal_fk 
	                              LEFT JOIN Funcao AS f1 ON f1.idFuncao = s1.idFuncao_fk 
	                              LEFT JOIN SubFuncao AS s2 ON s2.idSubFuncao = p.funcaoSecundaria_fk 
	                              LEFT JOIN Funcao AS f2 ON f2.idFuncao = s2.idFuncao_fk 
                                  INNER JOIN TipoUsuario AS t ON t.idTipoUsuario = p.tipoUsuario_fk
								  WHERE	p.status = 'Ativo' " + campoPesquisa;
                }
                else
                {
                    cmd.CommandText = @"SELECT p.idPessoa, p.nome, p.sobrenome, t.descricao,
                                  f1.descricaoFuncao AS 'Função Principal', s1.descricao AS 'Sub-Função Principal', 
                                  f2.descricaoFuncao AS 'Função Secundária', s2.descricao AS 'Sub-Função Secundária'
                                  FROM pessoa AS p 
	                              LEFT JOIN SubFuncao AS s1 ON s1.idSubFuncao = p.funcaoPrincipal_fk 
	                              LEFT JOIN Funcao AS f1 ON f1.idFuncao = s1.idFuncao_fk 
	                              LEFT JOIN SubFuncao AS s2 ON s2.idSubFuncao = p.funcaoSecundaria_fk 
	                              LEFT JOIN Funcao AS f2 ON f2.idFuncao = s2.idFuncao_fk 
                                  INNER JOIN TipoUsuario AS t ON t.idTipoUsuario = p.tipoUsuario_fk
								  WHERE	p.status = 'Ativo'";
                }

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    // Cria uma tabela genérica
                    DataTable dt = new DataTable();
                    dt.Load(dr); // Carrega os dados para o DataTable
                    dgUsuariosPesquisa.DataSource = dt; // Preenche o DataGridView
                }
                else
                {
                    Validacoes.exibeMensagem("Nenhum Usuário foi encontrado!", Outros.Mensagem.tipo.Info, false);
                }
            }
            catch (Exception erro)
            {
                Validacoes.exibeMensagem("Erro: " + erro.Message, Outros.Mensagem.tipo.Erro, false);
            }
            finally
            {
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
                Validacoes.exibeMensagem("Erro: " + erro.Message, Outros.Mensagem.tipo.Erro, false);
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
                Validacoes.exibeMensagem("Erro: " + erro.Message, Outros.Mensagem.tipo.Erro, false);
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
                Validacoes.exibeMensagem("Erro: " + erro.Message, Outros.Mensagem.tipo.Erro, false);
            }
            finally
            {
                conexao.Desconectar();
            }
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

        private void cbTipoUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cbFuncao_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cbSubFuncao_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void btnLimparForm_Click(object sender, EventArgs e)
        {
            cbFuncao.Text = "Selecione...";
            cbSubFuncao.Text = "Selecione...";
            cbTipoUsuario.Text = "Selecione...";
            txtCodigoNome.Text = null;
            this.CarregarDataGrid(false);
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

        private void btnLimparFuncaoSecundaria_Click(object sender, EventArgs e)
        {
            cbFuncao.Text = "Selecione...";
            cbSubFuncao.Text = "Selecione...";
        }
    }
}