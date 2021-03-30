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

namespace EscalasMetodista.Views.Escalas
{
    public partial class FormEscala : Form
    {
        public int tipoEscala;
        SqlCommand cmd = new SqlCommand();
        private Label subfuncoes, datas;
        public DateTime dataInicio, dataFim;
        public TimeSpan dias;

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
            lbNomeEscala.Left = (this.Width - lbNomeEscala.Width) / 2;
            txtNomeEscala.Left = (this.Width - txtNomeEscala.Width) / 2;
            this.carregarCabecalhoEscala();
            this.carregarTbDatasEscala();
        }

        private void carregarCabecalhoEscala()
        {
            cmd.CommandText = "SELECT descricao FROM SubFuncao WHERE idFuncao_fk = " + tipoEscala;
            Conexao conexao = new Conexao();
            try
            {
                cmd.Connection = conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    subfuncoes = new Label();
                    subfuncoes.Text = dr[0].ToString();
                    subfuncoes.TextAlign = ContentAlignment.MiddleCenter;
                    subfuncoes.Dock = DockStyle.Fill;
                    tbCabecalhoEscala.Controls.Add(subfuncoes);
                    //tbCabecalhoEscala.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180));
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

        private void carregarTbDatasEscala()
        {

            lbDataInicial.Text = dataInicio.ToString("dd/MM");

            int i = 0;
            while (dataInicio != dataFim && i < dias.Days)
            {
                dataInicio = dataInicio.AddDays(1);
                datas = new Label();
                datas.Text = dataInicio.ToString("dd/MM");
                datas.TextAlign = ContentAlignment.MiddleCenter;
                datas.Dock = DockStyle.Fill;
                tbDatasEscala.Controls.Add(datas);
            }
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
    }
}
