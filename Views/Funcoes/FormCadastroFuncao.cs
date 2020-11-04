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
                if (Validacoes.ValidarObjeto(funcoes) == true)
                {
                    funcoes.update(funcoes, idFuncao);
                }
                txtDescricaoFuncao.Text = " ";
                updateFuncao = false;
                this.Close();
            }
            else
            {
                if (Validacoes.ValidarObjeto(funcoes) == true)
                {
                    funcoes.create(funcoes);
                }
                txtDescricaoFuncao.Text = " ";
            }

        }

        private void FormCadastroFuncao_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    this.btnSalvarFuncao_Click(null, null);
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
