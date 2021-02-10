using EscalasMetodista.Conexão;
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

namespace EscalasMetodista.Views.Funcoes
{
    public partial class FormGerenciarFuncao : Form
    {
        public int idFuncao;
        public string descricaoFuncao;

        Conexao conexao = new Conexao();
        public FormGerenciarFuncao()
        {
            InitializeComponent();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            if (txtNomePesquisa.Text == "" && txtIdPesquisa.Text == "")
            {
                this.CarregarDataGrid(true, null, null, 0);
            }
            else
            {
                if (txtIdPesquisa.Text != "")
                {
                    this.CarregarDataGrid(false, "idFuncao", null, Int32.Parse(txtIdPesquisa.Text));
                }
                else if (txtNomePesquisa.Text != "")
                {
                    this.CarregarDataGrid(false, "descricaoFuncao", txtNomePesquisa.Text, 0);
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
                    cmd.CommandText = "SELECT * FROM funcao";


                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        // Cria uma tabela genérica
                        DataTable dt = new DataTable();
                        dt.Load(dr); // Carrega os dados para o DataTable
                        dgFuncoes.DataSource = dt; // Preenche o DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma Função foi encontrada!", "Função Não Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmd.CommandText = "SELECT * FROM funcao WHERE "  + campo + " LIKE '%" + valor + "%'";


                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        // Cria uma tabela genérica
                        DataTable dt = new DataTable();
                        dt.Load(dr); // Carrega os dados para o DataTable
                        dgFuncoes.DataSource = dt; // Preenche o DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma Função foi encontrada!", "Função Não Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmd.CommandText = "SELECT * FROM funcao WHERE " + campo + " = '" + id + "'";

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        // Cria uma tabela genérica
                        DataTable dt = new DataTable();
                        dt.Load(dr); // Carrega os dados para o DataTable
                        dgFuncoes.DataSource = dt; // Preenche o DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma Função foi encontrada!", "Função Não Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message);
                }
                conexao.Desconectar();
            }
        }

        private void dgFuncoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //verificar qual a coluna clicada é a de editar
            if (dgFuncoes.Columns[e.ColumnIndex] == dgFuncoes.Columns["editar"])
            {
                FormCadastroFuncao form = new FormCadastroFuncao();
                idFuncao = Convert.ToInt32(dgFuncoes.Rows[e.RowIndex].Cells["idFuncao"].Value.ToString());
                descricaoFuncao = dgFuncoes.Rows[e.RowIndex].Cells["descricaoFuncao"].Value.ToString();

                form.idFuncao = idFuncao;
                form.txtDescricaoFuncao.Text = descricaoFuncao;
                form.updateFuncao = true;
                form.ShowDialog();
            }
        }

        private void dgFuncoes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgFuncoes.Columns)
            {
                switch (coluna.Name)
                {
                    case "idFuncao":
                        coluna.Width = 50;
                        coluna.HeaderText = "Código";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "descricaoFuncao":
                        coluna.Width = 420;
                        coluna.HeaderText = "Função";
                        break;
                    case "editar":
                        coluna.Width = 40;
                        coluna.DisplayIndex = 2;
                        break;
                    default:
                        break;
                }
            }
        }

        private void FormGerenciarFunção_Load(object sender, EventArgs e)
        {
            this.CarregarDataGrid(true, null, null, 0);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgFuncoes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgFuncoes.Rows[e.RowIndex].Cells["editar"].ToolTipText = "Clique aqui para editar";
        }

        private void FormGerenciarFuncao_Activated(object sender, EventArgs e)
        {
            this.CarregarDataGrid(true, null, null, 0);
        }

        private void FormGerenciarFuncao_KeyDown(object sender, KeyEventArgs e)
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

        private void dgFuncoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormCadastroFuncao form = new FormCadastroFuncao();
            idFuncao = Convert.ToInt32(dgFuncoes.Rows[e.RowIndex].Cells["idFuncao"].Value.ToString());
            descricaoFuncao = dgFuncoes.Rows[e.RowIndex].Cells["descricaoFuncao"].Value.ToString();

            form.idFuncao = idFuncao;
            form.txtDescricaoFuncao.Text = descricaoFuncao;
            form.updateFuncao = true;
            form.Show();
        }
    }
}
