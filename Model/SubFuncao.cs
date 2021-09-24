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

        [Required(ErrorMessage = "Insira o nome da Sub-Função")]
        [RegularExpression(@"^[a-zA-Z0-9À-ú-/ç()'\s]{1,40}$", ErrorMessage = "Caracteres especiais não são permitidos no nome.")]
        public String Descricao { get; set; }

        [Required(ErrorMessage = "É necessário ter uma Função")]
        public Funcao funcao = new Funcao();

        [Required(ErrorMessage = "É necessário ter uma Função")]
        public Funcao funcoes
        {
            get => this.funcao;
            set => this.funcao = value;
        }


        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public void create(SubFuncao t)
        {
            try
            {
                cmd.CommandText = "INSERT INTO subfuncao(descricao, idFuncao_fk) " +
                                  "values('" + t.Descricao + "', '" + t.funcao.idFuncao + "')";

                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                Validacoes.exibeMensagem("Sub-Função cadastrada com sucesso!", Views.Outros.Mensagem.tipo.Sucesso);
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

        public SubFuncao find(int id)
        {
            SqlCommand cmd = new SqlCommand();
            SubFuncao sub = new SubFuncao();

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = @"SELECT s.* FROM SubFuncao s join Funcao f on s.idFuncao_fk = f.idFuncao WHERE s.idSubFuncao = " + id;


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    sub.idSubFuncao = dr.GetInt32(0);
                    sub.funcao = funcao.find(dr.GetInt32(1));
                    sub.Descricao = dr.GetString(2);
                }
                else
                {
                    Validacoes.exibeMensagem("Nenhuma Função foi encontrada", Views.Outros.Mensagem.tipo.Info);
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

            return sub != null ? sub : null;
        }

        public void update(SubFuncao t, int idSubFuncoes)
        {
            try
            {
                cmd.CommandText = "UPDATE subfuncao SET descricao = '" + t.Descricao +
                                                                     "', idFuncao_fk = '" + t.funcao.idFuncao +
                                                                     "' WHERE idSubFuncao LIKE '" + idSubFuncoes + "'";
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();

                Validacoes.exibeMensagem("Sub-Função alterada com sucesso!", Views.Outros.Mensagem.tipo.Sucesso);

            }
            catch (Exception ex)
            {
                Validacoes.exibeMensagem("Erro: " + ex.Message, Views.Outros.Mensagem.tipo.Erro);
            }
        }
    }
}
