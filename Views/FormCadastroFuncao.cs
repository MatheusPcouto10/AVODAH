using EscalasMetodista.Model;
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
        public FormCadastroFuncao()
        {
            InitializeComponent();
        }

        private void btnCadastrarFuncao_Click(object sender, EventArgs e)
        {
            funcoes.descricaoFuncao = txtdescricaoFuncao.Text;
            if (Validacoes.ValidarObjeto(funcoes) == true)
            {
                funcoes.create(funcoes);
            }
            txtdescricaoFuncao.Text = " ";
        }

        private void FormCadastroFuncao_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    this.btnCadastrarFuncao_Click(null, null);
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
