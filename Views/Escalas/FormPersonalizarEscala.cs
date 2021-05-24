using EscalasMetodista.Conexão;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-br");
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cbTipoEscala.Text = "Selecione...";
            cbIntervalo.Text = "Selecione...";
            txtNomeEscala.Text = null;
            dtInicioEscala.ResetText();
            dtFimEscala.ResetText();

            for (int i = 0; i < clDiasSemanaEscala.Items.Count; i++)
            {
                clDiasSemanaEscala.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void btnCriarEscala_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTipoEscala.Text == "Selecione.." || cbIntervalo.Text == "Selecione..." || string.IsNullOrWhiteSpace(txtNomeEscala.Text))
                {
                    MessageBox.Show("Campos não informados. Por favor informe.", "Campo em Branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DateTime dataInicio = new DateTime(dtInicioEscala.Value.Year, dtInicioEscala.Value.Month, dtInicioEscala.Value.Day);
                    DateTime dataFim = new DateTime(dtFimEscala.Value.Year, dtFimEscala.Value.Month, dtFimEscala.Value.Day);

                    FormEscala form = new FormEscala(gerarDatas(dataInicio, dataFim));
                    form.lbNomeEscala.Text = txtNomeEscala.Text;
                    form.tipoEscala = (int)cbTipoEscala.SelectedValue;
                    form.Show();
                    this.Hide();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
        }

        public List<DateTime> gerarDatas(DateTime inicio, DateTime fim)
        {
            List<DateTime> datas = new List<DateTime>();
            List<String> diasSemana = new List<String>();
            DateTime dataIncremento = inicio;

            for (int i = 0; i <= (clDiasSemanaEscala.Items.Count - 1); i++)
            {
                if (clDiasSemanaEscala.GetItemChecked(i))
                {
                    diasSemana.Add(clDiasSemanaEscala.Items[i].ToString());
                }
            }

            while (dataIncremento <= fim)
            {
                if (diasSemana.Contains(dataIncremento.ToString("dddd")))
                {
                    datas.Add(dataIncremento);
                }
                // se não tiver nenhum dia da semana selecionado, adiciona todos
                if (diasSemana.Count == 0)
                {
                    datas.Add(dataIncremento);
                }
                dataIncremento = dataIncremento.AddDays(1);
            }

            return datas;
        }

        private void clDiasSemanaEscala_SelectedValueChanged(object sender, EventArgs e)
        {
            if (clDiasSemanaEscala.CheckedItems.Count != 7)
            {
                checkTodos.Checked = false;
            }
        }

        private void checkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTodos.Checked == true)
            {
                for (int i = 0; i <= (clDiasSemanaEscala.Items.Count - 1); i++)
                {
                    clDiasSemanaEscala.SetItemChecked(i, true);
                }
            }
            else if (checkTodos.Checked == false && clDiasSemanaEscala.CheckedItems.Count == 7)
            {
                for (int i = 0; i <= (clDiasSemanaEscala.Items.Count - 1); i++)
                {
                    clDiasSemanaEscala.SetItemChecked(i, false);
                }
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

            cmd.CommandText = "SELECT * FROM intervalo where idIntervalo <> 1";
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
            preencheComboBoxTipoEscala();
            preencheComboBoxIntervalo();
            cbTipoEscala.Text = "Selecione...";
            cbIntervalo.Text = "Selecione...";
            dtInicioEscala.MinDate = DateTime.Today;
            dtFimEscala.MinDate = DateTime.Today;
        }

        private void dtInicioEscala_ValueChanged(object sender, EventArgs e)
        {
            defineLimiteDataEscala();
        }
        private void cbIntervalo_SelectedIndexChanged(object sender, EventArgs e)
        {
            defineLimiteDataEscala();
        }

        private void defineLimiteDataEscala()
        {
            DateTime dataInicio = new DateTime(dtInicioEscala.Value.Year, dtInicioEscala.Value.Month, dtInicioEscala.Value.Day);

            if (dataInicio > dtFimEscala.MaxDate)
            {
                dtFimEscala.MaxDate = dataInicio;
                dtFimEscala.Value = dataInicio;
            }

            if ((int)cbIntervalo.SelectedValue == 2)
            {
                dataInicio = dataInicio.AddDays(6);
                dtFimEscala.MaxDate = dataInicio;
                dtFimEscala.Refresh();
            }
            if ((int)cbIntervalo.SelectedValue == 3)
            {
                dataInicio = dataInicio.AddMonths(1).AddDays(-1);
                dtFimEscala.MaxDate = dtFimEscala.MaxDate = dataInicio;
                dtFimEscala.Refresh();
            }
            if ((int)cbIntervalo.SelectedValue == 4)
            {
                dataInicio = dataInicio.AddMonths(3).AddDays(-1);
                dtFimEscala.MaxDate = dataInicio;
                dtFimEscala.Refresh();
            }
        }

        private void cbTipoEscala_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cbIntervalo_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
