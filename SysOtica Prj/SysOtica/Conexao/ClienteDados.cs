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
    public class ClienteDados : IClienteDados
    {
        ConexaoBD conn = new ConexaoBD();

        public void inserirCliente(Cliente c)
        {
            string sql = "INSERT INTO Cliente VALUES ('" + c.Cl_nome + "','" + c.Cl_datanascimento + "','" + c.Cl_cpf + "','" + c.Cl_rg + "','" + c.Cl_telefone + "','" + c.Cl_celular + "','" + c.Cl_telefone2 + "','" + c.Cl_cep + "','" + c.Cl_endereco + "','" + c.Cl_numero + "','" + c.Cl_bairro + "','" + c.Cl_cidade + "','" + c.Cl_uf + "','" + c.Cl_email + "','" + c.Cl_nomepai + "','" + c.Cl_nomemae + "','" + c.Cl_profissao + "','" + c.Cl_observacoes + "')";

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
        public void alterarCliente(Cliente c)
        {
            string sql = "UPDATE Cliente SET cl_nome = '" + c.Cl_nome + "',cl_datanascimento = '" + c.Cl_datanascimento + "', cl_cpf ='" + c.Cl_cpf + "', cl_rg ='" + c.Cl_rg + "', cl_telefone = '" + c.Cl_telefone + "', cl_celular ='" + c.Cl_celular + "', cl_telefone2 ='" + c.Cl_telefone2 + "', cl_cep ='" + c.Cl_cep + "', cl_endereco ='" + c.Cl_endereco + "', cl_numero ='" + c.Cl_numero + "', cl_bairro ='" + c.Cl_bairro + "', cl_cidade ='" + c.Cl_cidade + "',cl_uf='" + c.Cl_uf + "', cl_email ='" + c.Cl_email + "', cl_nomepai ='" + c.Cl_nomepai + "',cl_nomemae ='" + c.Cl_nomemae + "', cl_profissao ='" + c.Cl_profissao + "', Cl_observacoes ='" + c.Cl_observacoes + "'WHERE cl_id = " + (c.Cl_id) + "";

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
        public void excluirCliente(Cliente c)
        {
            string sql = "DELETE FROM Cliente WHERE cl_id =" + (c.Cl_id) + "";
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


        public List<Cliente> listarCliente()
        {
            string sql = "SELECT  cl_id, cl_nome,cl_datanascimento, cl_cpf, cl_rg, cl_telefone,cl_celular, cl_telefone2,cl_cep,cl_endereco,cl_numero, cl_bairro,cl_cidade, cl_uf,cl_email,cl_nomepai,cl_nomemae, cl_profissao, cl_observacoes FROM Cliente";
            List<Cliente> lista = new List<Cliente>();
            Cliente c;
            try
            {
                conn.AbrirConexao();
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                SqlDataReader retorno = cmd.ExecuteReader();

                while (retorno.Read())
                {
                    c = new Cliente();
                    c.Cl_id = retorno.GetInt32(retorno.GetOrdinal("cl_id"));
                    c.Cl_nome = retorno.GetString(retorno.GetOrdinal("cl_nome"));
                    c.Cl_datanascimento = retorno.GetDateTime(retorno.GetOrdinal("cl_datanascimento"));
                    c.Cl_cpf = retorno.GetString(retorno.GetOrdinal("cl_cpf"));
                    c.Cl_rg = retorno.GetString(retorno.GetOrdinal("cl_rg"));
                    c.Cl_telefone = retorno.GetString(retorno.GetOrdinal("cl_telefone"));
                    c.Cl_celular = retorno.GetString(retorno.GetOrdinal("cl_celular"));
                    c.Cl_telefone2 = retorno.GetString(retorno.GetOrdinal("cl_telefone2"));
                    c.Cl_cep = retorno.GetString(retorno.GetOrdinal("cl_cep"));
                    c.Cl_endereco = retorno.GetString(retorno.GetOrdinal("cl_endereco"));
                    c.Cl_numero = retorno.GetString(retorno.GetOrdinal("cl_numero"));
                    c.Cl_bairro = retorno.GetString(retorno.GetOrdinal("cl_bairro"));
                    c.Cl_cidade = retorno.GetString(retorno.GetOrdinal("cl_cidade"));
                    c.Cl_uf = retorno.GetString(retorno.GetOrdinal("cl_uf"));
                    c.Cl_email = retorno.GetString(retorno.GetOrdinal("cl_email"));
                    c.Cl_nomepai = retorno.GetString(retorno.GetOrdinal("cl_nomepai"));
                    c.Cl_nomemae = retorno.GetString(retorno.GetOrdinal("cl_nomemae"));
                    c.Cl_profissao = retorno.GetString(retorno.GetOrdinal("cl_profissao"));
                    c.Cl_observacoes = retorno.GetString(retorno.GetOrdinal("cl_observacoes"));
                    lista.Add(c);
                }
                conn.FecharConexao();
                return lista;
                
            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }
        }


        public List<Cliente> pesquisarCliente(string cl_nome)
        {
            string sql = "SELECT  cl_id, cl_nome,cl_datanascimento,cl_cpf,cl_rg, cl_telefone,cl_celular, cl_telefone2,cl_cep,cl_endereco,cl_numero, cl_bairro,cl_cidade, cl_uf,cl_email,cl_nomepai,cl_nomemae, cl_profissao, cl_observacoes FROM Cliente";
            if (cl_nome != "")
            {
                sql += "WHERE cl_nome ILIKE @cl_nome";
            }
            List<Cliente> lista = new List<Cliente>();
            Cliente c = new Cliente();

            try
            {
                conn.AbrirConexao();
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                if (cl_nome != "")
                {
                    cmd.Parameters.AddWithValue("@cl_nome", "%" + cl_nome + "%");
                }
                SqlDataReader retorno = cmd.ExecuteReader();
                while (retorno.Read())
                {
                    c = new Cliente();
                    c.Cl_id = retorno.GetInt32(retorno.GetOrdinal("cl_id"));
                    c.Cl_nome = retorno.GetString(retorno.GetOrdinal("cl_nome"));
                    c.Cl_datanascimento = retorno.GetDateTime(retorno.GetOrdinal("cl_dtnascimento"));
                    c.Cl_cpf = retorno.GetString(retorno.GetOrdinal("cl_cpf"));
                    c.Cl_rg = retorno.GetString(retorno.GetOrdinal("cl_rg"));
                    c.Cl_telefone = retorno.GetString(retorno.GetOrdinal("cl_telefone"));
                    c.Cl_celular = retorno.GetString(retorno.GetOrdinal("cl_celular"));
                    c.Cl_telefone2 = retorno.GetString(retorno.GetOrdinal("cl_telefone2"));
                    c.Cl_cep = retorno.GetString(retorno.GetOrdinal("cl_cep"));
                    c.Cl_endereco = retorno.GetString(retorno.GetOrdinal("cl_endereco"));
                    c.Cl_numero = retorno.GetString(retorno.GetOrdinal("cl_numero"));
                    c.Cl_bairro = retorno.GetString(retorno.GetOrdinal("cl_bairro"));
                    c.Cl_cidade = retorno.GetString(retorno.GetOrdinal("cl_cidade"));
                    c.Cl_uf = retorno.GetString(retorno.GetOrdinal("cl_uf"));
                    c.Cl_email = retorno.GetString(retorno.GetOrdinal("cl_email"));
                    c.Cl_nomepai = retorno.GetString(retorno.GetOrdinal("cl_nomepai"));
                    c.Cl_nomemae = retorno.GetString(retorno.GetOrdinal("cl_nomemae"));
                    c.Cl_profissao = retorno.GetString(retorno.GetOrdinal("cl_profissao"));
                    c.Cl_observacoes = retorno.GetString(retorno.GetOrdinal("cl_observacoes"));
                    lista.Add(c);
                }
                return lista;
            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }
        }


    }
}
