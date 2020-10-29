using EscalasMetodista.Conexão;
using EscalasMetodista.Model;
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

namespace EscalasMetodista.Views
{
    public partial class FormCadastroSubFuncao : Form
    {
        SqlCommand cmd = new SqlCommand();
        SubFuncao subFuncoes = new SubFuncao();
        public FormCadastroSubFuncao()
        {
            InitializeComponent();
        }

        private void btnCadastrarSubFuncao_Click(object sender, EventArgs e)
        {

            subFuncoes.Descricao = txtDescricao.Text;
            subFuncoes.idFuncao_fk = (int)cbFuncoes.SelectedValue;
            if (Validacoes.ValidarObjeto(subFuncoes) == true)
            {
                subFuncoes.create(subFuncoes);
            }

            txtDescricao.Text = " ";
        }

        private void preencheComboBoxFuncoes()
        {
            cmd.CommandText = "SELECT * FROM funcao";
            Conexao conexao = new Conexao();
            try
            {
                cmd.Connection = conexao.Conectar();
                DataTable dt = new DataTable();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);

                cbFuncoes.DisplayMember = "descricaoFuncao";
                cbFuncoes.ValueMember = "idFuncao";
                cbFuncoes.DataSource = dt;

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

        private void FormCadastroSubFuncao_Load(object sender, EventArgs e)
        {
            this.preencheComboBoxFuncoes();
        }

        private void FormCadastroSubFuncao_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    this.btnCadastrarSubFuncao_Click(null, null);
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
                default:
                    break;
            }
        }
    }
}
