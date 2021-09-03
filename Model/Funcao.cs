using EscalasMetodista.Conexão;
using EscalasMetodista.Dao;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace EscalasMetodista.Model
{
    class Funcao : DefaultDao<Funcao>
    {
        public int idFuncao { get; set; }

        [Required(ErrorMessage = "Insira o nome da Função")]
        [RegularExpression(@"^[a-zA-Z0-9À-ú-/ç()'\s]{1,40}$", ErrorMessage = "Caracteres especiais não são permitidos no nome.")]
        public String descricaoFuncao { get; set; }

        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();

        public void create(Funcao t)
        {
            try
            {
                cmd.CommandText = "INSERT INTO funcao(descricaoFuncao) " +
                                  "values('" + t.descricaoFuncao + "')";

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                MessageBox.Show("Função cadastrada com sucesso!");
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

        public Funcao find(int id)
        {
            SqlCommand cmd = new SqlCommand();
            Funcao fun = new Funcao();

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = @"SELECT f.* FROM Funcao f WHERE f.idFuncao = " + id;


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    fun.idFuncao = dr.GetInt32(0);
                    fun.descricaoFuncao = dr.GetString(1);
                }
                else
                {
                    MessageBox.Show("Nenhuma Funçao principal foi encontrada!", "Funçao Não Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }

            return fun != null ? fun : null;
        }

        public void update(Funcao t, int idFuncoes)
        {
            try
            {
                cmd.CommandText = "UPDATE funcao SET descricaoFuncao = '" + t.descricaoFuncao + 
                                  "' WHERE idFuncao LIKE '" + idFuncoes + "'";

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
