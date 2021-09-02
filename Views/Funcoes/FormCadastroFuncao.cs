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

        private void btnSalvarFuncao_Click(object sender, EventArgs e)
        {
            funcoes.descricaoFuncao = txtDescricaoFuncao.Text;
            if (updateFuncao == true)
            {
                if (Validacoes.verificaUnico("descricaoFuncao", "funcao", txtDescricaoFuncao.Text, idFuncao, "idFuncao") == true)
                {
                    Validacoes.mensagem("Já existe uma Função Cadastrada!", ToolTipIcon.Error, "Função já Existente ", txtDescricaoFuncao);
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
                    Validacoes.mensagem("Já existe uma Função Cadastrada!", ToolTipIcon.Error, "Função já Existente ", txtDescricaoFuncao);
                }
                else
                {
                    if (Validacoes.ValidarObjeto(funcoes) == true)
                    {
                        funcoes.create(funcoes);
                        txtDescricaoFuncao.Text = "";
                        updateFuncao = false;
                    }
                    
                }
            }
        }
    }
}
