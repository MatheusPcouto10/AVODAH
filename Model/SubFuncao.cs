using EscalasMetodista.Conexão;
using EscalasMetodista.Dao;
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
    class SubFuncao : DefaultDao<SubFuncao>
    {
        public int idSubFuncao { get; set; }

        public int idFuncao_fk { get; set; }

        [Required(ErrorMessage = "Insira o nome da Sub-Função")]
        [RegularExpression(@"^[a-zA-Z0-9À-ú-/ç()'\s]{1,40}$", ErrorMessage = "Caracteres especiais não são permitidos no nome.")]
        public String Descricao { get; set; }

        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public void create(SubFuncao t)
        {
            try
            {
                cmd.CommandText = "INSERT INTO subfuncao(descricao, idFuncao_fk) " +
                                  "values('" + t.Descricao + "', '" + t.idFuncao_fk + "')";

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                MessageBox.Show("Sub-Função cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public SubFuncao find(int id)
        {
            throw new NotImplementedException();
        }

        public void update(SubFuncao t, int idSubFuncoes)
        {
            try
            {
                cmd.CommandText = "UPDATE subfuncao SET descricao = '" + t.Descricao +
                                                                     "', idFuncao_fk = '" + t.idFuncao_fk +
                                                                     "' WHERE idSubFuncao LIKE '" + idSubFuncoes + "'";
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();

                MessageBox.Show("Alteração feita com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}
