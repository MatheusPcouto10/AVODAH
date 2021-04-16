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
        [RegularExpression(@"^[a-zA-ZÀ-úç'\s]{1,20}$", ErrorMessage = "Números e caracteres especiais não são permitidos.")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Informe o Sobrenome")]
        [RegularExpression(@"^[a-zA-ZÀ-úç'\s]{1,20}$", ErrorMessage = "Números e caracteres especiais não são permitidos.")]
        public String Sobrenome { get; set; }
        public String Status { get; set; }

        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime dataCadastro { get; set; }

        [Required(ErrorMessage = "Informe um E-mail")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Informe um email válido. Ex: exemplo@exemplo.com")]
        public String Email { get; set; }

        //[Required(ErrorMessage = "Informe uma Senha")]
        public String Senha { get; set; }

        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();

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

        public TipoUsuario tipoUsuario = new TipoUsuario();
        public TipoUsuario TipoUsuarios
        {
            get => this.tipoUsuario;
            set => this.tipoUsuario = value;
        }

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
            throw new NotImplementedException();
        }

        public Pessoa findById(int id)
        {
            throw new NotImplementedException();
        }

        public void update(Pessoa t, int idPessoas, Boolean temFuncaoSecundaria)
        {
            try
            {
                if (temFuncaoSecundaria == true)
                {
                    cmd.CommandText = "UPDATE pessoa SET nome = '" + t.Nome +
                                                                     "', sobrenome = '" + t.Sobrenome +
                                                                     "', email = '" + t.Email +
                                                                     "', senha = '" + t.Senha +
                                                                     "', tipoUsuario_fk = " + t.tipoUsuario.idTipoUsuario +
                                                                     ", funcaoPrincipal_fk = " + t.funcaoPrincipal.idSubFuncao +
                                                                     ", funcaoSecundaria_fk = " + t.funcaoSecundaria.idSubFuncao +
                                                                     ", dataCadastro = '" + t.dataCadastro +
                                                                     "', status = '" + t.Status +
                                                                     "' WHERE idPessoa LIKE '" + idPessoas + "'";
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
                                                                     "', senha = '" + t.Senha +
                                                                     "', tipoUsuario_fk = " + t.tipoUsuario.idTipoUsuario +
                                                                     ", funcaoPrincipal_fk = " + t.funcaoPrincipal.idSubFuncao +
                                                                     ", funcaoSecundaria_fk = NULL" +
                                                                     ", dataCadastro = '" + t.dataCadastro +
                                                                     "', status = '" + t.Status +
                                                                     "' WHERE idPessoa LIKE '" + idPessoas + "'";
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
    }
}
