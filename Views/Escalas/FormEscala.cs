using EscalasMetodista.Conexão;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscalasMetodista.Views.Escalas
{
    public partial class FormEscala : Form
    {
        public int tipoEscala { get; set; }
        SqlCommand cmd = new SqlCommand();
        List<DateTime> datasEscala = null;
        FormCarregamento form = new FormCarregamento();
        private string descricaoSubFuncao { get; set; }
        private int totalColunasSelecionadas { get; set; }
        private int indexColunaSelecionada { get; set; }

        public FormEscala(List<DateTime> lista)
        {
            datasEscala = lista;
            InitializeComponent();
            //form.Show();
            //Application.DoEvents();
        }

        public FormEscala()
        {
            InitializeComponent();
        }

        private void FormEscalaLouvor_Load(object sender, EventArgs e)
        {
            formatarDataGrid();
            lbNomeEscala.Left = (this.Width - lbNomeEscala.Width) / 2;
            txtNomeEscala.Left = (this.Width - txtNomeEscala.Width) / 2;

            form.Dispose();
        }

        private void FormEscalaLouvor_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    this.editarNomeEscala();
                    break;
                default:
                    break;
            }
        }


        private void lbNomeEscala_DoubleClick(object sender, EventArgs e)
        {
            txtNomeEscala.Visible = true;
            lbNomeEscala.Visible = false;
        }

        private void editarNomeEscala()
        {
            if (string.IsNullOrWhiteSpace(txtNomeEscala.Text))
            {
                MessageBox.Show("O nome da escala não pode ficar em branco.", "Campo em Branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lbNomeEscala.Text = txtNomeEscala.Text;
                txtNomeEscala.Visible = false;
                lbNomeEscala.Visible = true;
                lbNomeEscala.Left = (this.Width - lbNomeEscala.Width) / 2;
                txtNomeEscala.Left = (this.Width - txtNomeEscala.Width) / 2;
            }
        }

        private void getDatas()
        {
            try
            {
                for (int i = 0; i <= 15; i++)
                {
                    tbEscala.Rows.Add("");
                }

                if (datasEscala.Count > tbEscala.RowCount)
                {
                    for (int i = tbEscala.RowCount; i < datasEscala.Count; i++)
                    {
                        tbEscala.Rows.Add("");
                    }
                }

                for (int i = 0; i < datasEscala.Count; i++)
                {
                    tbEscala.Rows[i].SetValues(datasEscala[i].ToString("dd/MM"));
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }


        private void getdadosCabecalho()
        {
            cmd.CommandText = "SELECT descricao FROM SubFuncao WHERE idFuncao_fk = " + tipoEscala;
            Conexao conexao = new Conexao();

            try
            {
                cmd.Connection = conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                int indiceColuna = 2;
                dt.Load(dr);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tbEscala.Columns[indiceColuna].HeaderText = dt.Rows[i][0].ToString();
                    indiceColuna++;
                }

                if (dt.Rows.Count > tbEscala.ColumnCount)
                {
                    for (int i = tbEscala.ColumnCount; i < dt.Rows.Count; i++)
                    {
                        tbEscala.Columns.Add(dt.Rows[i][0].ToString(), dt.Rows[i][0].ToString());
                        tbEscala.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }

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

        private void formatarDataGrid()
        {
            getdadosCabecalho();
            getDatas();

            foreach (DataGridViewRow linha in tbEscala.Rows)
            {
                linha.Height = 60;
            }

            foreach (DataGridViewColumn coluna in tbEscala.Columns)
            {
                switch (coluna.Name)
                {
                    case "dates":
                        coluna.Width = 120;
                        coluna.HeaderText = "DATAS";
                        coluna.HeaderCell.Style.BackColor = Color.Black;
                        coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "observacoes":
                        coluna.Width = 170;
                        coluna.HeaderText = "COMENTÁRIOS";
                        coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    default:
                        coluna.Width = 170;
                        coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair? Você pode perder todo o trabalho feito.", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void tbEscala_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                btnPreencherColunaUnica.Text = "Preencher Esta Coluna";
                tbEscala.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
                btnPreencherColunaUnica.Visible = true;

            }
            else if (e.ColumnIndex == -1)
            {
                btnPreencherColunaUnica.Text = "Preencher Esta Linha";
                tbEscala.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
                btnPreencherColunaUnica.Visible = true;
            }
            else
            {
                tbEscala.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
                btnPreencherColunaUnica.Visible = false;
            }

        }

        private void btnPreencherColunaUnica_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < tbEscala.Columns.GetColumnCount(DataGridViewElementStates.Selected); i++)
            {
                descricaoSubFuncao = tbEscala.SelectedColumns[i].HeaderText;
                indexColunaSelecionada = tbEscala.SelectedColumns[i].Index;
            }

            cmd.CommandText = "SELECT p.nome FROM Pessoa p JOIN SubFuncao s on p.funcaoPrincipal_fk = s.idSubFuncao WHERE s.descricao = '" + descricaoSubFuncao + "' AND s.idFuncao_fk = " + tipoEscala;
            Conexao conexao = new Conexao();

            try
            {
                cmd.Connection = conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows == false)
                {
                    MessageBox.Show("Nenhuma pessoa com essa função foi encontrada!");
                    return;
                }
                DataTable dt = new DataTable();
                dt.Load(dr);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tbEscala[indexColunaSelecionada, i].Value = dt.Rows[i][0].ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }

        private void btnPreencherColuna_Click(object sender, EventArgs e)
        {

        }

        private void btnPreencherEscalaLinha_Click(object sender, EventArgs e)
        {

        }

        private void btnPreencherTudo_Click(object sender, EventArgs e)
        {

        }
    }
}

