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

        List<Pessoa> pessoasLinha = new List<Pessoa>();

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
                Validacoes.mensagemErro("O nome da escala não pode ficar em branco.", ToolTipIcon.Error, "Campo em Branco", lbNomeEscala);
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

        private void getDatas(bool preenchimento)
        {
            try
            {
                if (!preenchimento)
                {
                    for (int i = 0; i <= 15; i++)
                    {
                        tbEscala.Rows.Add("");
                    }
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
            getDatas(false);

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
                this.Close();
            }
        }

        private void tbEscala_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > 1)
            {
                tbEscala.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
                indiceColunaSelecionada = e.ColumnIndex;
                indiceLinhaSelecionada = 99;
            }
            else if (e.ColumnIndex == 0)
            {
                tbEscala.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
                indiceColunaSelecionada = e.ColumnIndex;
                indiceLinhaSelecionada = 99;
            }
            else if (e.ColumnIndex == -1)
            {
                tbEscala.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
                indiceColunaSelecionada = 99;
                indiceLinhaSelecionada = e.RowIndex;
            }
            else
            {
                tbEscala.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
                indiceColunaSelecionada = 99;
                indiceLinhaSelecionada = 99;
            }

        }

        private void btnPreencherColuna_Click(object sender, EventArgs e)
        {

            if (indiceColunaSelecionada == 99)
            {
                Validacoes.mensagemErro("É necessário selecionar uma coluna antes do preenchimento!", ToolTipIcon.Error, "Nenhuma Coluna Selecionada", menuEscala);
                return;
            }

            if (indiceColunaSelecionada == 0)
            {
                getDatas(true);
            }
            else
            {
                try
                {
                    //List<Pessoa> pessoasColuna = new List<Pessoa>();
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

                                cmd.CommandText = @"SELECT p.* FROM Pessoa p 
                                JOIN SubFuncao s1 on p.funcaoPrincipal_fk = s1.idSubFuncao 
                                LEFT JOIN SubFuncao s2 on p.funcaoSecundaria_fk = s2.idSubFuncao 
                                WHERE p.funcaoPrincipal_fk = " + s.idSubFuncao + " OR (p.funcaoSecundaria_fk = " + s.idSubFuncao + " OR p.funcaoSecundaria_fk IS NULL)" +
                                    " AND s1.idFuncao_fk = " + tipoEscala + " AND s2.idFuncao_fk = " + tipoEscala + "order by NEWID()";

                                dr = cmd.ExecuteReader();

                                if (!dr.HasRows)
                                {
                                    Validacoes.mensagemErro("Não foram encontradas pessoas cadastradas com a função " + s.Descricao, ToolTipIcon.Error, "Nenhuma Pessoa Encontrada", menuEscala);
                                    return;
                                }

                                while (dr.Read())
                                {
                                    pessoasColuna.Add(dr.GetString(1));
                                }

                                for (int j = 0; j < datasEscala.Count; j++)
                                {
                                    pessoasColuna.Add(pessoasColuna[j]);
                                }

                                conexao.Desconectar();
                            }
                        }
                    }

                    Random r = new Random();

                    for (int j = 0; j < datasEscala.Count; j++)
                    {
                        if (tipoEscala == 1 && indiceColunaSelecionada == 3)
                        {
                            tbEscala[indiceColunaSelecionada, j].Value = pessoasColuna[r.Next(pessoasColuna.Count)] + ", " + pessoasColuna[r.Next(pessoasColuna.Count)] + ", " + pessoasColuna[r.Next(pessoasColuna.Count)];
                        }
                        else
                            tbEscala[indiceColunaSelecionada, j].Value = pessoasColuna[j];
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message);
                }
            }
        }

        private void btnPreencherEscalaLinha_Click(object sender, EventArgs e)
        {

            if (indiceLinhaSelecionada == 99)
            {
                Validacoes.mensagemErro("É necessário selecionar uma linha antes do preenchimento!", ToolTipIcon.Error, "Nenhuma Linha Selecionada", menuEscala);
                return;
            }

            try
            {
                Conexao conexao = new Conexao();

                SqlDataReader dr;

                int totalColunas = tbEscala.ColumnCount - (tbEscala.ColumnCount - (listaSubFuncoes.Count + 2));

                for (int i = 2; i < totalColunas; i++)
                {
                    bool add = true;

                    string top = listaSubFuncoes[i - 2].idSubFuncao != 2 ? "1 " : "10 ";

                    cmd.Connection = conexao.Conectar();

                    cmd.CommandText = "SELECT TOP " + top + @" p.* FROM Pessoa p 
                                JOIN SubFuncao s1 on p.funcaoPrincipal_fk = s1.idSubFuncao 
                                LEFT JOIN SubFuncao s2 on p.funcaoSecundaria_fk = s2.idSubFuncao 
                                WHERE p.funcaoPrincipal_fk = " + listaSubFuncoes[i - 2].idSubFuncao + " OR (p.funcaoSecundaria_fk = " + listaSubFuncoes[i - 2].idSubFuncao + " OR p.funcaoSecundaria_fk IS NULL)" +
                                " AND s1.idFuncao_fk = " + tipoEscala + " AND s2.idFuncao_fk = " + tipoEscala + " AND p.status = 'Ativo' order by NEWID()";

                    dr = cmd.ExecuteReader();

                    if (!dr.HasRows)
                    {
                        tbEscala[tbEscala.Columns[i].Index, indiceLinhaSelecionada].Value = null;
                    }
                    else
                    {

                        if (listaSubFuncoes[i - 2].idSubFuncao == 2)
                        {
                            while (dr.Read() && pessoasLinha.Count <= 4)
                            {
                                Pessoa pessoa = new Pessoa();
                                pessoa.idPessoa = dr.GetInt32(0);
                                pessoa.Nome = dr.GetString(1);
                                pessoa.Sobrenome = dr.GetString(2);
                                pessoa.Email = dr.GetString(3);

                                if (pessoasLinha.Exists(p => p.idPessoa == pessoa.idPessoa).Equals(false))
                                {
                                    pessoasLinha.Add(pessoa);
                                }
                            }
                        }
                        else
                        {
                            dr.Read();
                            Pessoa pessoa = new Pessoa();
                            pessoa.idPessoa = dr.GetInt32(0);
                            pessoa.Nome = dr.GetString(1);
                            pessoa.Sobrenome = dr.GetString(2);
                            pessoa.Email = dr.GetString(3);

                            if (pessoasLinha.Exists(p => p.idPessoa == pessoa.idPessoa).Equals(false))
                            {
                                pessoasLinha.Add(pessoa);
                                add = true;
                            }

                            else if (verificaPessoaFuncao(listaSubFuncoes[i - 2].idSubFuncao).Equals(false))
                            {
                                tbEscala[tbEscala.Columns[i].Index, indiceLinhaSelecionada].Value = null;
                                add = false;
                            }
                            else
                            {
                                add = false;
                                i--;
                            }
                        }

                        if (add)
                        {
                            if (tipoEscala == 1)
                            {
                                if (tbEscala.Columns[i].Index == 3)
                                {
                                    tbEscala[tbEscala.Columns[i].Index, indiceLinhaSelecionada].Value = pessoasLinha[1].Nome + ", " + pessoasLinha[2].Nome + ", " + pessoasLinha[3].Nome;
                                }
                                else { tbEscala[tbEscala.Columns[i].Index, indiceLinhaSelecionada].Value = pessoasLinha[pessoasLinha.Count > 1 ? pessoasLinha.Count - 1 : 0].Nome; }
                            }
                            else
                                tbEscala[tbEscala.Columns[i].Index, indiceLinhaSelecionada].Value = pessoasLinha[pessoasLinha.Count - 1].Nome;
                        }

                        tbEscala[0, indiceLinhaSelecionada].Value = datasEscala.Count > indiceLinhaSelecionada ? datasEscala[indiceLinhaSelecionada].ToString("dd/MM") : null;
                    }

                    conexao.Desconectar();
                }
                pessoasLinha = new List<Pessoa>();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }

        private void btnPreencherTudo_Click(object sender, EventArgs e)
        {
            try
            {
                indiceLinhaSelecionada = 0;

                for (int i = 0; i < datasEscala.Count; i++)
                {
                    btnPreencherEscalaLinha_Click(null, null);
                    indiceLinhaSelecionada++;
                    pessoasLinha = new List<Pessoa>();
                }
                indiceLinhaSelecionada = 99;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }

        private bool verificaPessoaFuncao(int idSubFuncao)
        {
            List<string> pessoasTemp = new List<string>();

            Conexao conexao = new Conexao();

            cmd.Connection = conexao.Conectar();

            cmd.CommandText = @"SELECT p.* FROM Pessoa p 
                                JOIN SubFuncao s1 on p.funcaoPrincipal_fk = s1.idSubFuncao 
                                LEFT JOIN SubFuncao s2 on p.funcaoSecundaria_fk = s2.idSubFuncao 
                                WHERE p.funcaoPrincipal_fk = " + idSubFuncao + " OR (p.funcaoSecundaria_fk = " + idSubFuncao + " OR p.funcaoSecundaria_fk IS NULL)" +
                                " AND s1.idFuncao_fk = " + tipoEscala + " AND s2.idFuncao_fk = " + tipoEscala;

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                pessoasTemp.Add(dr.GetString(1));
            }

            if (pessoasTemp.Count > 1)
            {
                return true;
            }
            else
                return false;
        }

        private void verificaRegistrosRepetidos()
        {
            int totalColunas = tbEscala.ColumnCount - (tbEscala.ColumnCount - (listaSubFuncoes.Count + 2));

            List<string> pessoasTemp = new List<string>();

            int itensDuplicados = 0;

            string linhasDuplicadas = "";

            for (int j = 0; j < tbEscala.RowCount; j++)
            {
                for (int i = 2; i < totalColunas; i++)
                {
                    if (tbEscala[i, j].Value != null)
                    {
                        if (tbEscala[i, j].Value.ToString().Trim().Length != 0)
                        {
                            pessoasTemp.Add(tbEscala[i, j].Value.ToString().ToUpper());

                            itensDuplicados = pessoasTemp.GroupBy(p => p)
                                                         .Where(x => x.Count() > 1)
                                                         .Sum(x => x.Count());
                        }
                    }
                }

                if (itensDuplicados > 0)
                {
                    linhasDuplicadas = linhasDuplicadas + j + ", ";
                    itensDuplicados = 0;
                }
            }

            if (linhasDuplicadas != null)
            {
                linhasDuplicadas = linhasDuplicadas.Remove(linhasDuplicadas.Trim().Length - 1);

                Validacoes.mensagemErro("Existem valores duplicados nas linhas: " + linhasDuplicadas, ToolTipIcon.Warning, "Registros Duplicados", menuEscala);
            }
        }

        private void btnLimparLinha_Click(object sender, EventArgs e)
        {
            if (indiceLinhaSelecionada == 99)
            {
                Validacoes.mensagemErro("É necessário selecionar uma linha antes do preenchimento!", ToolTipIcon.Error, "Nenhuma Linha Selecionada", menuEscala);
                return;
            }

            for (int i = 2; i < tbEscala.Columns.GetColumnCount(DataGridViewElementStates.None) - 2; i++)
            {
                tbEscala[tbEscala.Columns[i].Index, indiceLinhaSelecionada].Value = null;
            }
        }

        private void btnLimparColuna_Click(object sender, EventArgs e)
        {
            if (indiceColunaSelecionada == 99)
            {
                Validacoes.mensagemErro("É necessário selecionar uma coluna antes do preenchimento!", ToolTipIcon.Error, "Nenhuma Coluna Selecionada", menuEscala);
                return;
            }

            for (int i = 0; i < tbEscala.RowCount; i++)
            {
                tbEscala[indiceColunaSelecionada, i].Value = null;
            }
        }

        private void btnLimparTudo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tbEscala.Columns.GetColumnCount(DataGridViewElementStates.None); i++)
            {
                for (int j = 0; j < tbEscala.RowCount; j++)
                {
                    tbEscala[i, j].Value = null;
                }

            }
        }
    }
}

