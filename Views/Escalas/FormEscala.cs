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
using EscalasMetodista.Model;

namespace EscalasMetodista.Views.Escalas
{
    public partial class FormEscala : Form
    {
        public int tipoEscala { get; set; }
        private List<DateTime> datasEscala { get; set; }

        private int indiceColunaSelecionada { get; set; }

        private int indiceLinhaSelecionada { get; set; }

        SqlCommand cmd = new SqlCommand();

        private List<SubFuncao> listaSubFuncoes = new List<SubFuncao>();

        FormCarregamento form = new FormCarregamento();

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


        private void getSubFuncoes()
        {
            cmd.CommandText = "SELECT * FROM SubFuncao WHERE idFuncao_fk = " + tipoEscala;
            Conexao conexao = new Conexao();

            try
            {
                cmd.Connection = conexao.Conectar();
                DataTable dt = new DataTable();
                int indiceColuna = 2;
                dt.Load(cmd.ExecuteReader());

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tbEscala.Columns[indiceColuna].HeaderText = dt.Rows[i][2].ToString();

                    if (tbEscala.Columns[indiceColuna].HeaderText == "VOZ (BACK)")
                    {
                        tbEscala.Columns[indiceColuna].Width = 220;
                    }
                    else
                        tbEscala.Columns[indiceColuna].Width = 170;

                    indiceColuna++;

                    SubFuncao subFuncao = new SubFuncao();
                    subFuncao.Descricao = dt.Rows[i][2].ToString();
                    subFuncao.idSubFuncao = (int)dt.Rows[i][0];
                    subFuncao.idFuncao_fk = (int)dt.Rows[i][1];

                    listaSubFuncoes.Add(subFuncao);
                }

                if (dt.Rows.Count > tbEscala.ColumnCount)
                {
                    for (int i = tbEscala.ColumnCount; i < dt.Rows.Count; i++)
                    {
                        tbEscala.Columns.Add(dt.Rows[i][2].ToString(), dt.Rows[i][2].ToString());
                        tbEscala.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                        tbEscala.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        SubFuncao subFuncao = new SubFuncao();
                        subFuncao.Descricao = dt.Rows[i][2].ToString();
                        subFuncao.idSubFuncao = (int)dt.Rows[i][0];
                        subFuncao.idFuncao_fk = (int)dt.Rows[i][1];

                        listaSubFuncoes.Add(subFuncao);

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
            getSubFuncoes();
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
                        coluna.HeaderText = "Observação";
                        coluna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    default:
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
            if (e.RowIndex == -1 && e.ColumnIndex > 1)
            {
                btnPreencherColunaUnica.Text = "Preencher Esta Coluna";
                tbEscala.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
                btnPreencherColunaUnica.Visible = true;
                indiceColunaSelecionada = e.ColumnIndex;
                indiceLinhaSelecionada = 0;


            }
            else if (e.ColumnIndex == -1)
            {
                btnPreencherColunaUnica.Text = "Preencher Esta Linha";
                tbEscala.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
                btnPreencherColunaUnica.Visible = true;
                indiceColunaSelecionada = 0;
                indiceLinhaSelecionada = e.RowIndex;
            }
            else
            {
                tbEscala.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
                btnPreencherColunaUnica.Visible = false;
                indiceColunaSelecionada = 0;
                indiceLinhaSelecionada = 0;
            }

        }

        private void btnPreencherColunaUnica_Click(object sender, EventArgs e)
        {

            try
            {
                if (indiceColunaSelecionada != 0)
                {

                    List<string> pessoasColuna = new List<string>();

                    Conexao conexao = new Conexao();

                    SqlDataReader dr;

                    for (int i = 0; i < tbEscala.Columns.GetColumnCount(DataGridViewElementStates.Selected); i++)
                    {
                        foreach (SubFuncao s in listaSubFuncoes)
                        {
                            if (s.Descricao == tbEscala.SelectedColumns[i].HeaderText)
                            {
                                cmd.Connection = conexao.Conectar();

                                cmd.CommandText = @"SELECT * FROM Pessoa p 
                                JOIN SubFuncao s1 on p.funcaoPrincipal_fk = s1.idSubFuncao 
                                LEFT JOIN SubFuncao s2 on p.funcaoSecundaria_fk = s2.idSubFuncao 
                                WHERE p.funcaoPrincipal_fk = " + s.idSubFuncao + " OR (p.funcaoSecundaria_fk = " + s.idSubFuncao + " OR p.funcaoSecundaria_fk IS NULL)" +
                                " AND s1.idFuncao_fk = " + tipoEscala + " AND s2.idFuncao_fk = " + tipoEscala + "order by NEWID()";

                                dr = cmd.ExecuteReader();


                                while (dr.Read())
                                {
                                    pessoasColuna.Add(dr.GetString(1));
                                }

                                conexao.Desconectar();
                            }
                        }
                    }

                    Random r = new Random();

                    for (int j = 0; j < pessoasColuna.Count; j++)
                    {
                        if (tipoEscala == 1 && indiceColunaSelecionada == 3)
                        {
                            tbEscala[indiceColunaSelecionada, j].Value = pessoasColuna[r.Next(pessoasColuna.Count)] + ", " + pessoasColuna[r.Next(pessoasColuna.Count)] + ", " + pessoasColuna[r.Next(pessoasColuna.Count)];
                        }
                        else
                            tbEscala[indiceColunaSelecionada, j].Value = pessoasColuna[j];
                    }
                }
                else
                {
                    Conexao conexao = new Conexao();

                    List<string> pessoasColuna = new List<string>();

                    SqlDataReader dr;

                    for (int i = 2; i < tbEscala.Columns.GetColumnCount(DataGridViewElementStates.None) - 2; i++)
                    {
                        foreach (SubFuncao s in listaSubFuncoes)
                        {
                            if (s.Descricao == tbEscala.Columns[i].HeaderText)
                            {
                                cmd.Connection = conexao.Conectar();

                                cmd.CommandText = @"SELECT * FROM Pessoa p 
                                JOIN SubFuncao s1 on p.funcaoPrincipal_fk = s1.idSubFuncao 
                                LEFT JOIN SubFuncao s2 on p.funcaoSecundaria_fk = s2.idSubFuncao 
                                WHERE p.funcaoPrincipal_fk = " + s.idSubFuncao + " OR (p.funcaoSecundaria_fk = " + s.idSubFuncao + " OR p.funcaoSecundaria_fk IS NULL)" +
                                " AND s1.idFuncao_fk = " + tipoEscala + " AND s2.idFuncao_fk = " + tipoEscala + "order by NEWID()";

                                dr = cmd.ExecuteReader();
                                dr.Read();

                                if (tipoEscala == 1 && tbEscala.Columns[i].Index == 3)
                                {
                                    while (dr.Read())
                                    {
                                        pessoasColuna.Add(dr.GetString(1));
                                    }

                                    tbEscala[tbEscala.Columns[i].Index, indiceLinhaSelecionada].Value = pessoasColuna[0] + ", " + pessoasColuna[1] + ", " + pessoasColuna[2];

                                }
                                else
                                    tbEscala[tbEscala.Columns[i].Index, indiceLinhaSelecionada].Value = dr.GetString(1);

                                conexao.Desconectar();
                            }
                        }
                    }
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

        private String idSubfuncoes()
        {
            string ids = "";

            if (indiceColunaSelecionada != 0)
            {
                for (int i = 0; i < tbEscala.Columns.GetColumnCount(DataGridViewElementStates.Selected); i++)
                {
                    foreach (SubFuncao s in listaSubFuncoes)
                    {
                        if (s.Descricao == tbEscala.SelectedColumns[i].HeaderText)
                        {
                            ids = ids + s.idSubFuncao + ",";
                        }
                    }
                }
            }
            else
            {
                for (int i = 2; i < tbEscala.Columns.GetColumnCount(DataGridViewElementStates.None) - 2; i++)
                {
                    foreach (SubFuncao s in listaSubFuncoes)
                    {
                        if (s.Descricao == tbEscala.Columns[i].HeaderText)
                        {
                            ids = ids + s.idSubFuncao + ",";
                        }
                    }
                }
            }

            return ids.Remove(ids.Length - 1);
        }
    }
}

