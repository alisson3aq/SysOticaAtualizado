using SysOtica.Negocio.Classes_Basicas;
using SysOtica.Negocio.Excecoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexao
{
    class UsuarioDados : IUsuarioDados
    {
        ConexaoBD conn = new ConexaoBD();

        public void inserirUsuario(Usuario usu)
        {

            string sql = "INSERT INTO Usuario VALUES ('" + usu.Us_senha + "','" + usu.Us_endereco + "','" + usu.Us_telefone + "','" + usu.Us_tipo + "','" + usu.Us_usuario + "','" + usu.Us_nome + "')";

            try
            {
                conn.AbrirConexao();
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                cmd.ExecuteNonQuery();
                conn.FecharConexao();
            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }


        }

        public void alteraUsuario(Usuario usu)
        {
            string sql = " UPDATE Usuario SET  us_senha= '" + usu.Us_senha + "', us_endereco = '" + usu.Us_endereco + "', us_telefone = '" + usu.Us_telefone + "', us_tipo = '" + usu.Us_tipo + "', us_usuario = '" + usu.Us_usuario + "', us_nome = '" + usu.Us_nome + "' WHERE us_id = " + (usu.Us_id) + "";

            try
            {
                conn.AbrirConexao();
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                cmd.ExecuteNonQuery();
                conn.FecharConexao();
            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }



        }

        public void deleteUsuario(Usuario usu)
        {
            string sql = "DELETE FROM Usuario WHERE us_id = " + (usu.Us_id) + "";

            try
            {
                conn.AbrirConexao();
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                cmd.ExecuteNonQuery();
                conn.FecharConexao();
            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }


        }



        public List<Usuario> listaUsuario()
        {
            string sql = "SELECT  us_id, us_usuario, us_senha, us_nome,  us_tipo, us_endereco , us_telefone FROM Usuario";
            List<Usuario> lista = new List<Usuario>();
            Usuario usu;


            try
            {
                conn.AbrirConexao();
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                SqlDataReader retorno = cmd.ExecuteReader();

                while (retorno.Read())
                {
                    usu = new Usuario();

                    usu.Us_id = retorno.GetInt32(retorno.GetOrdinal("us_id"));
                    usu.Us_usuario = retorno.GetString(retorno.GetOrdinal("us_usuario"));
                    usu.Us_senha = retorno.GetString(retorno.GetOrdinal("us_senha"));
                    usu.Us_nome = retorno.GetString(retorno.GetOrdinal("us_nome"));
                    usu.Us_tipo = retorno.GetString(retorno.GetOrdinal("us_tipo"));
                    usu.Us_endereco = retorno.GetString(retorno.GetOrdinal("us_endereco"));
                    usu.Us_telefone = retorno.GetString(retorno.GetOrdinal("us_telefone"));
                    
                    

                    lista.Add(usu);
                }
                conn.FecharConexao();
                return lista;

            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }

        }


 
        public bool verificaduplicidade(Usuario usu)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> pesquisaUsuario(string us_nome)
        {
            string sql = "SELECT  us_id, us_usuario, us_senha, us_nome,  us_tipo, us_endereco , us_telefone FROM Usuario";
            if (us_nome != "")
            {
                sql += "WHERE us_nome LIKE @us_nome";
            }
            List<Usuario> lista = new List<Usuario>();
            Usuario usu = new Usuario();

            try
            {
                conn.AbrirConexao();
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                if (us_nome != "")
                {
                    cmd.Parameters.AddWithValue("@us_nome", "%" + us_nome + "%");
                }
                SqlDataReader retorno = cmd.ExecuteReader();
                while (retorno.Read())
                {
                    usu = new Usuario();

                    usu.Us_id = retorno.GetInt32(retorno.GetOrdinal("us_id"));
                    usu.Us_usuario = retorno.GetString(retorno.GetOrdinal("us_usuario"));
                    usu.Us_senha = retorno.GetString(retorno.GetOrdinal("us_senha"));
                    usu.Us_nome = retorno.GetString(retorno.GetOrdinal("us_nome"));
                    usu.Us_tipo = retorno.GetString(retorno.GetOrdinal("us_tipo"));
                    usu.Us_endereco = retorno.GetString(retorno.GetOrdinal("us_endereco"));
                    usu.Us_telefone = retorno.GetString(retorno.GetOrdinal("us_telefone"));


                    lista.Add(usu);
                }

                conn.FecharConexao();
                return lista;

            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }

        }

            
    }
}
