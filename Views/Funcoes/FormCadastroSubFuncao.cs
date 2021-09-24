using EscalasMetodista.Conexão;
using EscalasMetodista.Model;
using FontAwesome.Sharp;
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

        public bool updateFuncao = false;
        public string funcao;
        public int idSubFuncao;

        public FormCadastroSubFuncao()
        {
            InitializeComponent();
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
                Validacoes.exibeMensagem("Erro: " + erro.Message, Outros.Mensagem.tipo.Erro);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        private void FormCadastroSubFuncao_Load(object sender, EventArgs e)
        {
            this.preencheComboBoxFuncoes();

            if (updateFuncao)
            {
                cbFuncoes.Text = funcao;
                btnSalvar.IconChar = IconChar.Pen;
            }
            else
            {
                btnSalvar.IconChar = IconChar.Plus;
                cbFuncoes.Text = "Selecione...";
            }
        }

        private void cbFuncoes_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcao fun = new Funcao();

            if (cbFuncoes.Text == "Selecione...")
            {
                Validacoes.exibeMensagem("É necessário ter uma Função selecionada", Outros.Mensagem.tipo.Warning);
                return;
            }
            

            if (updateFuncao == true)
            {
                if (Validacoes.verificaUnico("descricao", "subfuncao", txtDescricao.Text, idSubFuncao, "idSubFuncao") == true)
                {
                    Validacoes.exibeMensagem("Já existe uma Função Sub-Função com este Nome", Outros.Mensagem.tipo.Warning);
                }
                else
                {
                    if (Validacoes.ValidarObjeto(subFuncoes) == true)
                    {
                        subFuncoes.Descricao = txtDescricao.Text;
                        subFuncoes.funcao = fun.find((int)cbFuncoes.SelectedValue);
                        subFuncoes.update(subFuncoes, idSubFuncao);
                        updateFuncao = false;
                        this.Close();
                        txtDescricao.Text = "";
                    }
                }

            }
            else
            {
                if (Validacoes.verificaUnico("descricao", "subfuncao", txtDescricao.Text, 0, "idSubFuncao") == true)
                {
                    Validacoes.exibeMensagem("Já existe uma Função Sub-Função com este Nome", Outros.Mensagem.tipo.Warning);
                }
                else
                {
                    if (Validacoes.ValidarObjeto(subFuncoes) == true)
                    {
                        subFuncoes.Descricao = txtDescricao.Text;
                        subFuncoes.funcao = fun.find((int)cbFuncoes.SelectedValue);
                        subFuncoes.create(subFuncoes);
                        txtDescricao.Text = "";
                        updateFuncao = false;
                        this.Close();
                    }
                }
            }
        }
    }
}

