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

                    cmd.CommandText = @"SELECT s.idSubFuncao, s.descricao, f.descricaoFuncao FROM subFuncao AS s INNER JOIN funcao AS f 
                                        ON f.idFuncao = s.idFuncao_fk AND s.descricao LIKE '%" + txtPesquisa.Text + "%'";

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows == true)
                    {

                        DataTable dt = new DataTable();

                        dt.Load(dr);
                        dgSubFuncoes.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("Nenhuma Sub-Função Encontrada", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message);
                }
                conexao.Desconectar();
            }
        }

        private void CarregarDataGrid()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.Conectar();

                cmd.Connection = conexao.Conectar();
                cmd.CommandText = @"SELECT s.idSubFuncao, s.descricao, f.descricaoFuncao FROM subFuncao AS s INNER JOIN funcao AS f 
                                    ON f.idFuncao = s.idFuncao_fk";


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    // Cria uma tabela genérica
                    DataTable dt = new DataTable();
                    dt.Load(dr); // Carrega os dados para o DataTable
                    dgSubFuncoes.DataSource = dt; // Preenche o DataGridView
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
                form.cbFuncoes.Text = dgSubFuncoes.Rows[e.RowIndex].Cells["descricaoFuncao"].Value.ToString();
                form.Show();
            }
        }

        private void FormGerenciarSubfuncoes_Load(object sender, EventArgs e)
        {
            this.CarregarDataGrid();
        }

        private void dgFuncoes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgSubFuncoes.Rows[e.RowIndex].Cells["editar"].ToolTipText = "Clique aqui para editar";
        }

        private void FormGerenciarSubfuncoes_Activated(object sender, EventArgs e)
        {
            this.CarregarDataGrid();
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
                        coluna.Width = 220;
                        coluna.HeaderText = "Sub-Função";
                        break;
                    case "descricaoFuncao":
                        coluna.Width = 200;
                        coluna.HeaderText = "Função";
                        break;
                    case "editar":
                        coluna.Width = 40;
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
    }
}
