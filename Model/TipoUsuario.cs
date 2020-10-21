using EscalasMetodista.Conexão;
using EscalasMetodista.Dao;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscalasMetodista.Model
{
    class TipoUsuario : DaoTipoUsuario<TipoUsuario>
    {
        public int idTipoUsuario { get; set; }
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
                MessageBox.Show("Tipo de Usuário cadastrado com sucesso!");
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

        public TipoUsuario findById(int id)
        {
            throw new NotImplementedException();
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

                MessageBox.Show("Alteração feita com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}
