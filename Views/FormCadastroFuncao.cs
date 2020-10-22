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
            if (txtdescricaoFuncao.Text != null)
            {
                funcoes.descricaoFuncao = txtdescricaoFuncao.Text;
                funcoes.create(funcoes);
                txtdescricaoFuncao.Text = " ";
            }
            else
            {
                MessageBox.Show("Campos não informados");
            }
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
