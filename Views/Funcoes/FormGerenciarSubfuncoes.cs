using EscalasMetodista.Conexão;
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
using EscalasMetodista.Model;

namespace EscalasMetodista.Views.Funcoes
{
    public partial class FormGerenciarSubfuncoes : Form
    {
        public int idSubFuncao;
        public string descricao;

        Conexao conexao = new Conexao();
        public FormGerenciarSubfuncoes()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtPesquisa.Text)))
                CarregarDataGrid(true, null);
            else
                CarregarDataGrid(false, txtPesquisa.Text);
        }

        private void CarregarDataGrid(bool atualizacao, string pesquisa)
        {
            SqlCommand cmd = new SqlCommand();

            if (atualizacao == true)
            {
                try
                {
                    cmd.Connection = conexao.Conectar();
                    cmd.CommandText = @"SELECT s.idSubFuncao, s.descricao, f.descricaoFuncao FROM subFuncao AS s INNER JOIN funcao AS f 
                                      ON f.idFuncao = s.idFuncao_fk order by s.idSubFuncao, f.descricaoFuncao";


                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        // Cria uma tabela genérica
                        DataTable dt = new DataTable();
                        dt.Load(dr); // Carrega os dados para o DataTable
                        dgSubFuncoes.DataSource = dt; // Preenche o DataGridView
                    }
                    else
                        Validacoes.exibeMensagem("Nenhuma Sub-Função foi encontrada!", Outros.Mensagem.tipo.Info);
                }
                catch (Exception erro)
                {
                    Validacoes.exibeMensagem("Erro: " + erro.Message, Outros.Mensagem.tipo.Erro);
                }
                conexao.Desconectar();
            }
            else if (atualizacao == false && pesquisa != null)
            {
                try
                {
                    cmd.Connection = conexao.Conectar();
                    cmd.CommandText ="SELECT s.idSubFuncao, s.descricao, f.descricaoFuncao FROM subFuncao AS s INNER JOIN funcao AS f " +
                                     "ON f.idFuncao = s.idFuncao_fk WHERE cast(s.idSubFuncao as varchar) = '" + pesquisa + "' OR s.descricao LIKE '%" + pesquisa + "%' " +
                                     "OR f.descricaoFuncao LIKE '%" + pesquisa + "%' order by s.idSubFuncao, f.descricaoFuncao";


                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        // Cria uma tabela genérica
                        DataTable dt = new DataTable();
                        dt.Load(dr); // Carrega os dados para o DataTable
                        dgSubFuncoes.DataSource = dt; // Preenche o DataGridView
                    }
                    else
                        Validacoes.exibeMensagem("Nenhuma Sub-Função foi encontrada!", Outros.Mensagem.tipo.Info);
                }
                catch (Exception erro)
                {
                    Validacoes.exibeMensagem("Erro: " + erro.Message, Outros.Mensagem.tipo.Erro);
                }
                conexao.Desconectar();
            }
        }

        private void dgFuncoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //verificar qual a coluna clicada é a de editar
            if (dgSubFuncoes.Columns[e.ColumnIndex] == dgSubFuncoes.Columns["editar"])
            {
                FormCadastroSubFuncao form = new FormCadastroSubFuncao();
                idSubFuncao = Convert.ToInt32(dgSubFuncoes.Rows[e.RowIndex].Cells["idSubFuncao"].Value.ToString());
                descricao = dgSubFuncoes.Rows[e.RowIndex].Cells["descricao"].Value.ToString();

                form.idSubFuncao = idSubFuncao;
                form.txtDescricao.Text = descricao;
                form.updateFuncao = true;
                form.funcao = dgSubFuncoes.Rows[e.RowIndex].Cells["descricaoFuncao"].Value.ToString();
                form.ShowDialog();
            }
        }

        private void FormGerenciarSubfuncoes_Load(object sender, EventArgs e)
        {
            CarregarDataGrid(true, null);
        }

        private void dgFuncoes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgSubFuncoes.Rows[e.RowIndex].Cells["editar"].ToolTipText = "Clique aqui para editar";
        }

        private void dgSubFuncoes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgSubFuncoes.Columns)
            {
                switch (coluna.Name)
                {
                    case "idSubFuncao":
                        coluna.Width = 50;
                        coluna.HeaderText = "Código";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "descricao":
                        coluna.Width = 300;
                        coluna.HeaderText = "Sub-Função";
                        break;
                    case "descricaoFuncao":
                        coluna.Width = 300;
                        coluna.HeaderText = "Função";
                        break;
                    case "editar":
                        coluna.Width = 45;
                        coluna.DisplayIndex = 3;
                        break;
                    default:
                        break;
                }
            }
        }

        private void FormGerenciarSubfuncoes_KeyDown(object sender, KeyEventArgs e)
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
        private void dgSubFuncoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormCadastroSubFuncao form = new FormCadastroSubFuncao();
            idSubFuncao = Convert.ToInt32(dgSubFuncoes.Rows[e.RowIndex].Cells["idSubFuncao"].Value.ToString());
            descricao = dgSubFuncoes.Rows[e.RowIndex].Cells["descricao"].Value.ToString();

            form.idSubFuncao = idSubFuncao;
            form.txtDescricao.Text = descricao;
            form.updateFuncao = true;
            form.funcao = dgSubFuncoes.Rows[e.RowIndex].Cells["descricaoFuncao"].Value.ToString();
            form.Show();
        }

        private void FormGerenciarSubfuncoes_Activated(object sender, EventArgs e)
        {
            CarregarDataGrid(true, null);
        }

        private void btnCadastrarNovo_Click(object sender, EventArgs e)
        {
            FormCadastroSubFuncao form = new FormCadastroSubFuncao();
            form.updateFuncao = false;
            form.ShowDialog();
        }
    }
}
