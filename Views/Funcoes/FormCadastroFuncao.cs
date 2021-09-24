using EscalasMetodista.Model;
using EscalasMetodista.Views.Funcoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace EscalasMetodista.Views
{
    public partial class FormCadastroFuncao : Form
    {
        Funcao funcoes = new Funcao();
        public bool updateFuncao = false;
        public int idFuncao;

        public FormCadastroFuncao()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            funcoes.descricaoFuncao = txtDescricaoFuncao.Text;
            if (updateFuncao == true)
            {
                if (Validacoes.verificaUnico("descricaoFuncao", "funcao", txtDescricaoFuncao.Text, idFuncao, "idFuncao") == true)
                {
                    Validacoes.exibeMensagem("Já existe uma Função cadastrada com este Nome", Outros.Mensagem.tipo.Warning);
                }
                else
                {
                    if (Validacoes.ValidarObjeto(funcoes) == true)
                    {
                        funcoes.update(funcoes, idFuncao);
                        updateFuncao = false;
                        this.Close();
                        txtDescricaoFuncao.Text = "";
                    }
                }
            }
            else
            {
                if (Validacoes.verificaUnico("descricaoFuncao", "funcao", txtDescricaoFuncao.Text, 0, "idFuncao") == true)
                {
                    Validacoes.exibeMensagem("Já existe uma Função cadastrada com este Nome", Outros.Mensagem.tipo.Warning);
                }
                else
                {
                    if (Validacoes.ValidarObjeto(funcoes) == true)
                    {
                        funcoes.create(funcoes);
                        updateFuncao = false;
                        this.Close();
                        txtDescricaoFuncao.Text = "";
                    }

                }
            }
        }

        private void FormCadastroFuncao_Load(object sender, EventArgs e)
        {
            if (updateFuncao)
                btnSalvar.IconChar = IconChar.Pen;
            else
                btnSalvar.IconChar = IconChar.Plus;
        }
    }
}
