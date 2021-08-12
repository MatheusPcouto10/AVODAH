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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair? Você pode perder todo o trabalho feito.", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void FormEscalaLouvor_Load(object sender, EventArgs e)
        {
            formatarDataGrid();
            lbNomeEscala.Left = (this.Width - lbNomeEscala.Width) / 2;
            txtNomeEscala.Left = (this.Width - txtNomeEscala.Width) / 2;

            //form.Dispose();
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

        private void preencherTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select p.nome, s.idSubFuncao, s.descricao from Pessoa p join SubFuncao s on p.funcaoPrincipal_fk = s.idSubFuncao " +
                              "where s.idFuncao_fk = " + tipoEscala;

            Conexao conexao = new Conexao();
            try
            {
                cmd.Connection = conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();

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

        //private void getSubfuncoes()
        //{
        //    cmd.CommandText = "SELECT * FROM SubFuncao WHERE idFuncao_fk = " + tipoEscala;
        //    Conexao conexao = new Conexao();

        //    try
        //    {
        //        cmd.Connection = conexao.Conectar();
        //        SqlDataReader dr = cmd.ExecuteReader();

        //        while (dr.Read())
        //        {
        //            dadosSubFuncao.Add(dr[2].ToString(), dr[0].ToString());
        //        }

        //    }
        //    catch (Exception erro)
        //    {
        //        MessageBox.Show("Erro: " + erro.Message);
        //    }
        //    finally
        //    {
        //        conexao.Desconectar();
        //    }
        //}

        private void getDatas()
        {
            try
            {
                for (int i = 0; i < datasEscala.Count; i++)
                {
                    tbEscala.Rows.Add(datasEscala[i].ToString("dd/MM"));
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
                dt.Load(dr);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    tbEscala.Columns.Add(dt.Rows[i][0].ToString().ToLower(), dt.Rows[i][0].ToString());
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
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    case "observacoes":
                        coluna.Width = 170;
                        coluna.HeaderText = "COMENTÁRIOS";
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                    default:
                        coluna.Width = 170;
                        coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;
                }
            }
        }
    }
}

