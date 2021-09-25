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
                Validacoes.exibeMensagem("Função cadastrada com sucesso!", Views.Outros.Mensagem.tipo.Sucesso, false);
            }
            catch (Exception ex)
            {
                Validacoes.exibeMensagem("Erro: " + ex.Message, Views.Outros.Mensagem.tipo.Erro, false);
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
                    Validacoes.exibeMensagem("Nenhuma Função foi encontrada", Views.Outros.Mensagem.tipo.Info, false);
                }
            }
            catch (Exception erro)
            {
                Validacoes.exibeMensagem("Erro: " + erro.Message, Views.Outros.Mensagem.tipo.Erro, false);
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

                Validacoes.exibeMensagem("Função alterada com sucesso!", Views.Outros.Mensagem.tipo.Sucesso, false);

            }
            catch (Exception ex)
            {
                Validacoes.exibeMensagem("Erro: " + ex.Message, Views.Outros.Mensagem.tipo.Erro, false);
            }
        }
    }
}
