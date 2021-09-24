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
    class TipoUsuario : DefaultDao<TipoUsuario>
    {
        public int idTipoUsuario { get; set; }

        [Required(ErrorMessage = "Informe o Tipo de Usuário")]
        public String Descricao { get; set; }

        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();

        public void create(TipoUsuario t)
        {
            try
            {
                cmd.CommandText = "INSERT INTO tipousuario(descricao) " +
                                  "values('" + t.Descricao + "')";

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                Validacoes.exibeMensagem("Tipo de Usuário cadastrado com sucesso", Views.Outros.Mensagem.tipo.Sucesso);
            }
            catch (Exception ex)
            {
                Validacoes.exibeMensagem("Erro: " + ex.Message, Views.Outros.Mensagem.tipo.Erro);
            }
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public TipoUsuario find(int id)
        {
            SqlCommand cmd = new SqlCommand();
            TipoUsuario tipo = new TipoUsuario();

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = @"SELECT t.* FROM TipoUsuario AS t WHERE t.idTipoUsuario = " + id;


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    tipo.idTipoUsuario = dr.GetInt32(0);
                    tipo.Descricao = dr.GetString(1);
                }
                else
                {
                    Validacoes.exibeMensagem("Nenhum Tipo de Usuário foi encontrado", Views.Outros.Mensagem.tipo.Info);
                }
            }
            catch (Exception erro)
            {
                Validacoes.exibeMensagem("Erro: " + erro.Message, Views.Outros.Mensagem.tipo.Erro);
            }
            finally
            {
                conexao.Desconectar();
            }

            return tipo != null ? tipo : null;
        }

        public void update(TipoUsuario t, int idTipoUsuarios)
        {
            try
            {
                cmd.CommandText = "UPDATE tipousuario SET descricao = '" + t.Descricao +
                                  "' WHERE idTipoUsuario LIKE '" + idTipoUsuarios + "'";

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();

                Validacoes.exibeMensagem("Tipo de Usuário alterado com sucesso", Views.Outros.Mensagem.tipo.Sucesso);

            }
            catch (Exception ex)
            {
                Validacoes.exibeMensagem("Erro: " + ex.Message, Views.Outros.Mensagem.tipo.Erro);
            }
        }
    }
}
