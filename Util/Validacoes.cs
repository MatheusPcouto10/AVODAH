﻿using EscalasMetodista.Conexão;
using EscalasMetodista.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscalasMetodista.Model
{
    public static class Validacoes
    {
        public static IEnumerable<ValidationResult> getValidationErros(object obj)
        {
            var resultadoValidacao = new List<ValidationResult>();
            var contexto = new ValidationContext(obj, null, null);
            Validator.TryValidateObject(obj, contexto, resultadoValidacao, true);
            return resultadoValidacao;
        }

        public static bool ValidarObjeto(object obj)
        {
            var erros = Validacoes.getValidationErros(obj);
            foreach (var error in erros)
            {
                MessageBox.Show((error.ErrorMessage), "Dados Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool verificaUnico(string campo, string tabela, string valor, int idPessoa, string idCampo)
        {
            SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "SELECT " + campo + " FROM " + tabela + " WHERE " + campo + " = '" + valor + "' AND " + idCampo + " != " + idPessoa;
                Conexao conexao = new Conexao();
                cmd.Connection = conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                    return true;

                return false;
        }

        public static void mensagem(string mensagem, ToolTipIcon icone, string titulo, Control control)
        {
            ToolTip balaoMensagem = new ToolTip();

            balaoMensagem.IsBalloon = false;

            balaoMensagem.ToolTipIcon = icone;

            balaoMensagem.ToolTipTitle = titulo;

            balaoMensagem.Show(mensagem, control, 5000);

        }
    }
}
