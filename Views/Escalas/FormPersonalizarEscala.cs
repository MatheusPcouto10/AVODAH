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
            try
            {
                if (string.IsNullOrWhiteSpace(txtNomeEscala.Text))
                {
                    MessageBox.Show("O nome da escala não pode ficar em branco.", "Campo em Branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DateTime dataInicio = new DateTime(dtInicioEscala.Value.Year, dtInicioEscala.Value.Month, dtInicioEscala.Value.Day);
                    DateTime dataFim = new DateTime(dtFimEscala.Value.Year, dtFimEscala.Value.Month, dtFimEscala.Value.Day);
                    TimeSpan dias = dataFim - dataInicio;

                    //if (cbIntervalo.Text == "Semanal")
                    //{
                    //    var limiteData = new DateTime(dataInicio.Year, dataInicio.Month, 1);
                    //    dtFimEscala.MaxDate = limiteData.AddDays(6);
                    //}
                    //else if (cbIntervalo.Text == "Mensal")
                    //{
                    //    dtFimEscala.MaxDate = dataInicio.AddMonths(1).AddDays(-1);

                    //}
                    //else if (cbIntervalo.Text == "Trimestral")
                    //{
                    //    dtFimEscala.MaxDate = dataInicio.AddMonths(3).AddDays(-1);
                    //}

                    FormEscala form = new FormEscala();
                    form.dias = dias;
                    form.dataInicio = dataInicio;
                    form.dataFim = dataFim;
                    form.lbNomeEscala.Text = txtNomeEscala.Text;
                    form.tipoEscala = (int)cbTipoEscala.SelectedValue;
                    form.Show();
                    this.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
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

        private void dtInicioEscala_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
