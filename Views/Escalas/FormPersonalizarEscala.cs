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
    public partial class FormPersonalizarEscala : Form
    {
        SqlCommand cmd = new SqlCommand();

        public FormPersonalizarEscala()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cbTipoEscala.Text = "Selecione...";
            cbIntervalo.Text = "Selecione...";
            txtNomeEscala.Text = null;
        }

        private void btnCriarEscala_Click(object sender, EventArgs e)
        {
            if (cbTipoEscala.Text == "LOUVOR")
            {
                FormEscala form = new FormEscala();
                form.Show();
                this.Close();
            }
        }
        private void preencheComboBoxTipoEscala()
        {

            cmd.CommandText = "SELECT * FROM funcao";
            Conexao conexao = new Conexao();
            try
            {
                cmd.Connection = conexao.Conectar();
                DataTable dt = new DataTable();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

                cbTipoEscala.DisplayMember = "descricaoFuncao";
                cbTipoEscala.ValueMember = "idFuncao";
                cbTipoEscala.DataSource = dt;

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

        private void preencheComboBoxIntervalo()
        {

            cmd.CommandText = "SELECT * FROM intervalo";
            Conexao conexao = new Conexao();
            try
            {
                cmd.Connection = conexao.Conectar();
                DataTable dt = new DataTable();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

                cbIntervalo.DisplayMember = "descricaoIntervalo";
                cbIntervalo.ValueMember = "idIntervalo";
                cbIntervalo.DataSource = dt;

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

        private void FormPersonalizarEscala_Load(object sender, EventArgs e)
        {
            this.preencheComboBoxTipoEscala();
            this.preencheComboBoxIntervalo();

        }
    }
}
