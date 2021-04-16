using EscalasMetodista.Conexão;
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

        public static bool verificaUnico(String campo, String tabela, String valor, Boolean update, int idPessoa, String idCampo)
        {
            SqlCommand cmd = new SqlCommand();

            if (update == true)
            {
                cmd.CommandText = "SELECT " + campo + " FROM " + tabela + " WHERE " + campo + " = '" + valor + "' AND " + idCampo + " != " + idPessoa;
                Conexao conexao = new Conexao();
                cmd.Connection = conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    return true;
                }
                return false;
            }
            else
            {
                cmd.CommandText = "SELECT " + campo + " FROM " + tabela + " WHERE " + campo + " = '" + valor + "'";
                Conexao conexao = new Conexao();
                cmd.Connection = conexao.Conectar();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
