using EscalasMetodista.Views;
using EscalasMetodista.Views.Escalas;
using EscalasMetodista.Views.Funcoes;
using EscalasMetodista.Views.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscalasMetodista
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPersonalizarEscala());
        }
    }
}
