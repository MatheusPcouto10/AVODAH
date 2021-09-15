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
    class Pessoa : DaoPessoa<Pessoa>
    {
        public int idPessoa { get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        [RegularExpression(@"^[a-zA-ZÀ-úç'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos.")]
        public String Nome { get; set; }

        //[Required(ErrorMessage = "Informe o Sobrenome")]
        [RegularExpression(@"^[a-zA-ZÀ-úç'\s]{1,40}$", ErrorMessage = "Números e caracteres especiais não são permitidos.")]
        public String Sobrenome { get; set; }
        public String Status { get; set; }

        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime dataCadastro { get; set; }

        //[Required(ErrorMessage = "Informe um E-mail")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Informe um email válido. Ex: exemplo@exemplo.com")]
        public String Email { get; set; }

        //[Required(ErrorMessage = "Informe uma Senha")]
        public String Senha { get; set; }

        [Required(ErrorMessage = "É necessário ter uma Função Principal")]
        public SubFuncao funcaoPrincipal = new SubFuncao();
        public SubFuncao funcaoSecundaria = new SubFuncao();

        [Required(ErrorMessage = "É necessário ter uma Função Principal")]
        public SubFuncao SubFuncaoPrincipal
        {
            get => this.funcaoPrincipal;
            set => this.funcaoPrincipal = value;
        }

        public SubFuncao SubFuncaoSecundaria
        {
            get => this.funcaoSecundaria;
            set => this.funcaoSecundaria = value;
        }

        [Required(ErrorMessage = "É necessário ter um Tipo de Usuário")]
        public TipoUsuario tipoUsuario = new TipoUsuario();
        public TipoUsuario TipoUsuarios
        {
            get => this.tipoUsuario;
            set => this.tipoUsuario = value;
        }

        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();

        public void create(Pessoa t, Boolean temFuncaoSecundaria)
        {
            try
            {
                if (temFuncaoSecundaria == true)
                {
                    cmd.CommandText = "INSERT INTO pessoa(nome, sobrenome, email, senha, " +
                                                     "tipoUsuario_fk, funcaoPrincipal_fk, funcaoSecundaria_fk, dataCadastro, status) " +
                                  "values('" + t.Nome + "', '" + t.Sobrenome + "', '" + t.Email + "', '" + t.Senha + "','" + t.tipoUsuario.idTipoUsuario
                                  + "','" + t.funcaoPrincipal.idSubFuncao + "','" + t.funcaoSecundaria.idSubFuncao + "','" + t.dataCadastro + "','" + t.Status + "')";

                    cmd.Connection = conexao.Conectar();
                    cmd.ExecuteNonQuery();
                    conexao.Desconectar();

                    MessageBox.Show("Usuário cadastrado com sucesso!");
                }
                else
                {
                    cmd.CommandText = "INSERT INTO pessoa(nome, sobrenome, email, senha, " +
                                                     "tipoUsuario_fk, funcaoPrincipal_fk, dataCadastro, status) " +
                                  "values('" + t.Nome + "', '" + t.Sobrenome + "', '" + t.Email + "', '" + t.Senha + "','" + t.tipoUsuario.idTipoUsuario
                                  + "','" + t.funcaoPrincipal.idSubFuncao + "','" + t.dataCadastro + "','" + t.Status + "')";

                    cmd.Connection = conexao.Conectar();
                    cmd.ExecuteNonQuery();
                    conexao.Desconectar();

                    MessageBox.Show("Usuário cadastrado com sucesso!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        public void delete(int id)
        {
            try
            {
                cmd.CommandText = "UPDATE pessoa SET status = 'Inativo' WHERE idPessoa = " + id;
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();

                MessageBox.Show("Usuário excluído com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        public Pessoa find(int id)
        {
            SqlCommand cmd = new SqlCommand();
            Pessoa pessoa = new Pessoa();

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = @"SELECT p.* FROM pessoa AS p 
	                              LEFT JOIN SubFuncao AS s1 ON s1.idSubFuncao = p.funcaoPrincipal_fk 
	                              LEFT JOIN Funcao AS f1 ON f1.idFuncao = s1.idFuncao_fk 
	                              LEFT JOIN SubFuncao AS s2 ON s2.idSubFuncao = p.funcaoSecundaria_fk 
	                              LEFT JOIN Funcao AS f2 ON f2.idFuncao = s2.idFuncao_fk 
                                  INNER JOIN TipoUsuario AS t ON t.idTipoUsuario = p.tipoUsuario_fk WHERE p.status = 'Ativo' AND p.idPessoa = " + id;


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    pessoa.idPessoa = dr.GetInt32(0);
                    pessoa.Nome = dr.GetString(1);
                    pessoa.Sobrenome = dr.GetString(2);
                    pessoa.Email = dr.GetString(3);
                    pessoa.tipoUsuario = tipoUsuario.find(dr.GetInt32(5));
                    pessoa.funcaoPrincipal = funcaoPrincipal.find(dr.GetInt32(6));

                    if (string.IsNullOrEmpty(dr[7].ToString()))
                        pessoa.funcaoSecundaria = null;
                    else
                        pessoa.funcaoSecundaria = funcaoSecundaria.find(dr.GetInt32(7));
                }
                else
                {
                    MessageBox.Show("Nenhum Usuário foi encontrado!", "Usuário Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            return pessoa != null ? pessoa : null;
        }
        public int getId()
        {
            SqlCommand cmd = new SqlCommand();
            int id = 0;

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.CommandText = "SELECT MAX(idPessoa) FROM Pessoa";


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    id = dr.GetInt32(0);
                }
                else
                {
                    MessageBox.Show("Nenhum Usuário foi encontrado!", "Usuário Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            return id + 1;
        }



        public void update(Pessoa t, int idPessoas, bool temFuncaoSecundaria)
        {
            try
            {
                if (temFuncaoSecundaria == true)
                {
                    cmd.CommandText = "UPDATE pessoa SET nome = '" + t.Nome +
                                                                     "', sobrenome = '" + t.Sobrenome +
                                                                     "', email = '" + t.Email +
                                                                     "', tipoUsuario_fk = " + t.tipoUsuario.idTipoUsuario +
                                                                     ", funcaoPrincipal_fk = " + t.funcaoPrincipal.idSubFuncao +
                                                                     ", funcaoSecundaria_fk = " + t.funcaoSecundaria.idSubFuncao +
                                                                     " WHERE idPessoa = " + idPessoas;
                    cmd.Connection = conexao.Conectar();
                    cmd.ExecuteNonQuery();
                    conexao.Desconectar();

                    MessageBox.Show("Alteração feita com sucesso!");
                }
                else
                {
                    cmd.CommandText = "UPDATE pessoa SET nome = '" + t.Nome +
                                                                     "', sobrenome = '" + t.Sobrenome +
                                                                     "', email = '" + t.Email +
                                                                     "', tipoUsuario_fk = " + t.tipoUsuario.idTipoUsuario +
                                                                     ", funcaoPrincipal_fk = " + t.funcaoPrincipal.idSubFuncao +
                                                                     ", funcaoSecundaria_fk = NULL" +
                                                                     " WHERE idPessoa = " + idPessoas;
                    cmd.Connection = conexao.Conectar();
                    cmd.ExecuteNonQuery();
                    conexao.Desconectar();

                    MessageBox.Show("Alteração feita com sucesso!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        public void updateSenha(string senha, int idPessoas)
        {
            try
            {

                cmd.CommandText = "UPDATE pessoa SET senha = '" + senha + "' WHERE idPessoa = " + idPessoas;
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();

                MessageBox.Show("Senha atualizada com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}
