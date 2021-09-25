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
using Excel = Microsoft.Office.Interop.Excel;

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

        private List<Pessoa> pessoasLinha = new List<Pessoa>();

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
            indiceColunaSelecionada = 99;
            indiceLinhaSelecionada = 99;

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
                Validacoes.exibeMensagem("Informe o nome da Escala", Outros.Mensagem.tipo.Erro, false);
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
                Validacoes.exibeMensagem("Erro: " + erro.Message, Outros.Mensagem.tipo.Erro, false);
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

                    if (tipoEscala == 1)
                    {
                        if (tbEscala.Columns[indiceColuna].HeaderText == "VOZ (BACK)")
                        {
                            tbEscala.Columns[indiceColuna].Width = 240;
                        }
                        else
                            tbEscala.Columns[indiceColuna].Width = 170;
                    }

                    if (tipoEscala == 2 || tipoEscala == 4)
                    {
                        tbEscala.Columns[indiceColuna].Width = 220;
                    }

                    if (tipoEscala == 3)
                    {
                        if (tbEscala.Columns[indiceColuna].HeaderText == "LANCHE")
                        {
                            tbEscala.Columns[indiceColuna].Width = 220;
                        }
                        else if (tbEscala.Columns[indiceColuna].HeaderText == "LIMPEZA - CORREDOR")
                        {
                            tbEscala.Columns[indiceColuna].Width = 400;
                        }
                        else
                            tbEscala.Columns[indiceColuna].Width = 650;
                    }

                    indiceColuna++;

                    SubFuncao subFuncao = new SubFuncao();
                    subFuncao = subFuncao.find((int)dt.Rows[i][0]);

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
                        subFuncao = subFuncao.find((int)dt.Rows[i][0]);

                        listaSubFuncoes.Add(subFuncao);

                    }
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
                Close();
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
                Validacoes.exibeMensagem("É necessário selecionar uma coluna antes do preenchimento!", Outros.Mensagem.tipo.Erro, false);
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
                                    Validacoes.exibeMensagem("Não foram encontradas pessoas cadastradas com a função " + s.Descricao, Outros.Mensagem.tipo.Info, false);
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
                    Validacoes.exibeMensagem("Erro: " + erro.Message, Outros.Mensagem.tipo.Erro, false);
                }
            }
        }

        private void btnPreencherEscalaLinha_Click(object sender, EventArgs e)
        {

            if (indiceLinhaSelecionada == 99)
            {
                Validacoes.exibeMensagem("É necessário selecionar uma linha antes do preenchimento!", Outros.Mensagem.tipo.Erro, false);
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

                    string top = listaSubFuncoes[i - 2].idSubFuncao == 2 || listaSubFuncoes[i - 2].idSubFuncao == 22 || listaSubFuncoes[i - 2].idSubFuncao == 24 ? "p.* " : "TOP 1 p.*";

                    cmd.Connection = conexao.Conectar();

                    cmd.CommandText = "SELECT " + top + @" FROM Pessoa p 
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
                        else if (listaSubFuncoes[i - 2].idSubFuncao == 22)
                        {
                            while (dr.Read() && pessoasLinha.Count < 5)
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
                        else if (listaSubFuncoes[i - 2].idSubFuncao == 24)
                        {
                            while (dr.Read() && pessoasLinha.Count <= 8)
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
                            else if (tipoEscala == 3)
                            {
                                if (tbEscala.Columns[i].Index == 2)
                                {
                                    tbEscala[tbEscala.Columns[i].Index, indiceLinhaSelecionada].Value = pessoasLinha[1].Nome + ", " + pessoasLinha[2].Nome + ", " + pessoasLinha[3].Nome + ", " + pessoasLinha[4].Nome;
                                }
                                else if (tbEscala.Columns[i].Index == 4)
                                {
                                    tbEscala[tbEscala.Columns[i].Index, indiceLinhaSelecionada].Value = pessoasLinha[6].Nome + ", " + pessoasLinha[7].Nome;
                                }
                                else { tbEscala[tbEscala.Columns[i].Index, indiceLinhaSelecionada].Value = pessoasLinha[5].Nome; }
                            }
                            else { tbEscala[tbEscala.Columns[i].Index, indiceLinhaSelecionada].Value = pessoasLinha[pessoasLinha.Count - 1].Nome; }
                        }

                        tbEscala[0, indiceLinhaSelecionada].Value = datasEscala.Count > indiceLinhaSelecionada ? datasEscala[indiceLinhaSelecionada].ToString("dd/MM") : null;
                    }

                    conexao.Desconectar();
                }
                pessoasLinha = new List<Pessoa>();
            }

            catch (Exception erro)
            {
                Validacoes.exibeMensagem("Erro: " + erro.Message, Outros.Mensagem.tipo.Erro, false);
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
                Validacoes.exibeMensagem("Erro: " + erro.Message, Outros.Mensagem.tipo.Erro, false);
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

                Validacoes.mensagem("Existem valores duplicados nas linhas: " + linhasDuplicadas, ToolTipIcon.Warning, "Registros Duplicados", menuEscala);
            }
        }

        private void btnLimparLinha_Click(object sender, EventArgs e)
        {
            if (indiceLinhaSelecionada == 99)
            {
                Validacoes.exibeMensagem("É necessário selecionar uma linha antes da limpeza!", Outros.Mensagem.tipo.Erro, false);
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
                Validacoes.exibeMensagem("É necessário selecionar uma coluna antes da limpeza!", Outros.Mensagem.tipo.Erro, false);
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

        private void btnExportarXls_Click(object sender, EventArgs e)
        {

            int totalColunas = tbEscala.ColumnCount - (tbEscala.ColumnCount - listaSubFuncoes.Count + 2);

            SaveFileDialog salvar = new SaveFileDialog();
            salvar.Title = "Exportar para o Excel";
            salvar.Filter = "Arquivo do Excel *.xlsx | *.xlsx";
            salvar.FileName = lbNomeEscala.Text;

            // Inicia o componente Excel
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            //Cria uma planilha temporária na memória do computador
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            try
            {
                for (int i = 0; i < tbEscala.ColumnCount; i++)
                {
                    for (int j = 0; j < tbEscala.RowCount; j++)
                    {
                        int linha = j + 1, coluna = i + 1;

                        xlWorkSheet.Rows[linha].RowHeight = 40;

                        if (linha == 1)
                            xlWorkSheet.Cells[linha, coluna] = tbEscala.Columns[i].HeaderText;

                        else
                            xlWorkSheet.Cells[linha, coluna] = tbEscala[i, j - 1].Value == null ? "" : tbEscala[i, j - 1].Value;
                    }
                }

                if (tipoEscala == 1)
                {
                    xlWorkSheet.Range["A1", "A99"].Columns.ColumnWidth = 20;
                    xlWorkSheet.Range["B1", "Z99"].Columns.ColumnWidth = 30;
                    xlWorkSheet.Range["D1", "D99"].Columns.ColumnWidth = 40;
                }


                if (tipoEscala == 2 || tipoEscala == 4)
                {
                    xlWorkSheet.Range["A1", "A99"].Columns.ColumnWidth = 20;
                    xlWorkSheet.Range["B1", "B99"].Columns.ColumnWidth = 30;
                    xlWorkSheet.Range["C1", "Z99"].Columns.ColumnWidth = 35;
                }

                if (tipoEscala == 3)
                {
                    xlWorkSheet.Range["A1", "A99"].Columns.ColumnWidth = 20;
                    xlWorkSheet.Range["B1", "B99"].Columns.ColumnWidth = 30;
                    xlWorkSheet.Range["C1", "C99"].Columns.ColumnWidth = 100;
                    xlWorkSheet.Range["D1", "D99"].Columns.ColumnWidth = 35;
                    xlWorkSheet.Range["E1", "E99"].Columns.ColumnWidth = 60;
                }

                xlWorkSheet.Range["B1", "Z1"].Interior.Color = Color.DarkRed;
                xlWorkSheet.Range["A1", "A1"].Interior.Color = Color.Black;

                xlWorkSheet.Range["A1", "Z99"].Font.Name = "Microsoft Sans Serif";
                xlWorkSheet.Range["A1", "Z1"].Font.Size = 14;
                xlWorkSheet.Range["A2", "Z99"].Font.Size = 11;
                xlWorkSheet.Range["A1", "Z1"].Font.Color = Color.White;
                xlWorkSheet.Range["A2", "Z99"].Font.Color = Color.Black;
                xlWorkSheet.Range["A1", "Z1"].Font.Bold = true;

                xlWorkSheet.Range["A1", "Z99"].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                xlWorkSheet.Range["A1", "Z99"].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                xlWorkSheet.Range["A1", "Z99"].Style.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                if (salvar.ShowDialog() == DialogResult.OK)
                {
                    //Salva o arquivo de acordo com a documentação do Excel.
                    xlWorkBook.SaveAs(salvar.FileName, Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue, misValue,
                    Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    xlWorkBook.Close(true, misValue, misValue);

                    if (System.IO.File.Exists(salvar.FileName))
                    {
                        Validacoes.exibeMensagem("Arquivo salvo com sucesso", Outros.Mensagem.tipo.Sucesso, false);
                        Thread.Sleep(3000);
                        System.Diagnostics.Process.Start(salvar.FileName);
                    }

                    xlApp.Quit();
                }

            }
            catch (Exception erro)
            {
                Validacoes.exibeMensagem("Erro: " + erro.Message, Outros.Mensagem.tipo.Erro, false);
                xlApp.Quit();
            }
        }
    }
}

