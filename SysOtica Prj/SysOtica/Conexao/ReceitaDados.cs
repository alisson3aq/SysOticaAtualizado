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
    public class ReceitaDados : IReceitaDados 
    {
        ConexaoBD conn = new ConexaoBD();

        public void inserirReceita(Receita receita)
        {

            string sql = "INSERT INTO Receita VALUES ('"  + receita.Rc_historico + "','"     + receita.Rc_lodesferico + "','"   + receita.Rc_loeesferico + "','" + receita.Rc_podesferico + "','"  + 
               "' + '" + receita.Rc_poeesferico + "','"   + receita.Rc_lodcilindrico + "','" + receita.Rc_loecilindrico + "','" + receita.Rc_podcilindrico +"','" + 
                         receita.Rc_poecilindrico + "','" + receita.Rc_lodeixo + "', '"      + receita.Rc_loeeixo + "','"       + receita.Rc_podeixo + "','"      + receita.Rc_poeeixo + "', '" + 
                         receita.Rc_lodaltura + "', '"    + receita.Rc_loealtura+ "', '"     + receita.Rc_podaltura + "', '"    + receita.Rc_poealtura + "', '"   + receita.Rc_loddnp + "','" + 
                         receita.Rc_loednp + "','"        + receita.Rc_poddnp + "','"        + receita.Rc_poednp + "','"        + receita.Rc_adicao + "','"       + receita.Rc_nomemedico + "', '" + 
                         receita.Rc_observacoes + "','"   + receita.Rc_data + "','"          + receita.Rc_dtavalidade + "')";

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



        public void alterarReceita(Receita receita)
        {
            string sql = "UPDATE Receita SET                           rc_historico ='"     + receita.Rc_historico + "',     rc_lodesferico = '" + receita.Rc_lodesferico + "',    rc_loeesferico=    '" + receita.Rc_loeesferico + "'    rc_podesferico = '" + receita.Rc_podesferico + "','" +
              "' +, rc_poeesferico = '" + receita.Rc_poeesferico + "', rc_lodcilindrico ='" + receita.Rc_lodcilindrico + "', rc_loecilindrico ='"+ receita.Rc_loecilindrico + "',  rc_podcilindrico= '" + receita.Rc_podcilindrico + "', rc_poecilindrico ='" +
                        receita.Rc_poecilindrico + "',                 rc_lodeixo ='"       + receita.Rc_lodeixo + "',       rc_loeeixo = '"     + receita.Rc_loeeixo + "',        rc_podeixo ='"       + receita.Rc_podeixo + "',       rc_poeeixo ='"       + receita.Rc_poeeixo + "',    rc_lodaltura ='" +
                        receita.Rc_lodaltura + "',                     rc_loealtura ='"     + receita.Rc_loealtura + "',     rc_podaltura = '"   + receita.Rc_podaltura + "',      rc_poealtura = '"    + receita.Rc_poealtura + "',     rc_loddnp ='"        + receita.Rc_loddnp + "',     rc_loednp='" +
                        receita.Rc_loednp + "',                        rc_poddnp = '"       + receita.Rc_poddnp + "',        rc_poednp ='"       + receita.Rc_poednp + "',         rc_adicao ='"        + receita.Rc_adicao + "',        rc_nomemedico ='"    + receita.Rc_nomemedico + "', rc_observacoes ='" +
                        receita.Rc_observacoes + "',                   rc_data ='"          + receita.Rc_data + "',          rc_dtavalidade ='"  + receita.Rc_dtavalidade + "'     WHERE rc_id = "      + (receita.Rc_id) + "";
            receita.rc_loe
            
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

        public void excluirreceita(Receita receita)
        {

            string sql = "DELETE FROM Produto WHERE rc_id = " + (receita.Rc_id) + "";

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

      
        public List<Receita> listaReceita()
        {
            string sql = " SELECT rc_id, rc_historico,    rc_lodesferico, rc_loeesferico,  rc_podesferico,  rc_poeesferico,  rc_lodcilindrico,           rc_loecilindrico,  rc_podcilindrico,     rc_poecilindrico," +
                      "           rc_lodeixo,             rc_loeeixo,     rc_podeixo,      rc_poeeixo,      rc_lodaltura,    rc_loealtura, rc_podaltura, rc_poealtura,      rc_loddnp,            rc_loednp,        rc_poddnp, " +
                      "           rc_poednp, rc_adicao,   rc_nomemedico,  rc_observacoes,  rc_data,         rc_dtavalidade FROM Receita";

            List<Receita> lista = new List<Receita>();
            Receita  receita;

            try
            {
                conn.AbrirConexao();
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                SqlDataReader retorno = cmd.ExecuteReader();

                while (retorno.Read())
                {
                    receita = new Receita();
                    receita.Rc_id = Convert.ToInt32(retorno.GetOrdinal("rc_id"));
                    //receita.Rc_historico = retorno.GetDateTime(retorno.GetOrdinal("rc_historico"));                                    
                    receita.Rc_lodesferico = retorno.GetDecimal(retorno.GetOrdinal("rc_lodesferico"));
                    receita.Rc_loeesferico = retorno.GetDecimal(retorno.GetOrdinal("rc_loeesferico"));                                   
                    receita.Rc_podesferico = retorno.GetDecimal(retorno.GetOrdinal("rc_podesferico"));
                    receita.Rc_poeesferico = retorno.GetDecimal(retorno.GetOrdinal("rc_poeesferico"));
                    receita.Rc_lodcilindrico = retorno.GetDecimal(retorno.GetOrdinal("rc_lodcilindrico"));
                    receita.Rc_loecilindrico = retorno.GetDecimal(retorno.GetOrdinal("rc_loecilindrico"));
                    receita.Rc_podcilindrico = retorno.GetDecimal(retorno.GetOrdinal("rc_podcilindrico"));
                    receita.Rc_poecilindrico = retorno.GetDecimal(retorno.GetOrdinal("rc_poecilindrico"));
                    receita.Rc_lodeixo = retorno.GetDecimal(retorno.GetOrdinal("rc_lodeixo"));
                    receita.Rc_loeeixo = retorno.GetDecimal(retorno.GetOrdinal("rc_loeeixo"));
                    receita.Rc_podeixo = retorno.GetDecimal(retorno.GetOrdinal("rc_podeixo")); ;
                    receita.Rc_poeeixo = retorno.GetDecimal(retorno.GetOrdinal("rc_poeeixo"));
                    receita.Rc_lodaltura = retorno.GetDecimal(retorno.GetOrdinal("rc_lodaltura"));
                    receita.Rc_loealtura = retorno.GetDecimal(retorno.GetOrdinal("rc_loealtura"));
                    receita.Rc_podaltura = retorno.GetDecimal(retorno.GetOrdinal("rc_podaltura"));
                    receita.Rc_poealtura = retorno.GetDecimal(retorno.GetOrdinal("rc_poealtura")); ;
                    receita.Rc_loddnp = retorno.GetDecimal(retorno.GetOrdinal("rc_loddnp"));
                    receita.Rc_loednp = retorno.GetDecimal(retorno.GetOrdinal("rc_loednp"));
                    receita.Rc_poddnp = retorno.GetDecimal(retorno.GetOrdinal("rc_poddnp"));
                    receita.Rc_poednp = retorno.GetDecimal(retorno.GetOrdinal("rc_poednp"));
                    receita.Rc_data = retorno.GetDateTime(retorno.GetOrdinal("rc_data"));
                    receita.Rc_adicao = retorno.GetDecimal(retorno.GetOrdinal("rc_adicao"));
                    receita.Rc_nomemedico = retorno.GetString(retorno.GetOrdinal("rc_nomemedico"));
                    receita.Rc_observacoes = retorno.GetString(retorno.GetOrdinal("rc_observacoes"));



                    lista.Add(receita);
                }
                conn.FecharConexao();
                return lista;

            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }




        }

        public List<Receita> pesquisaReceita(string rc_nomemedico)
        {
            string sql = " SELECT rc_id, rc_historico,    rc_lodesferico, rc_loeesferico,  rc_podesferico,  rc_poeesferico,  rc_lodcilindrico,           rc_loecilindrico,  rc_podcilindrico,     rc_poecilindrico," +
                      "           rc_lodeixo,             rc_loeeixo,     rc_podeixo,      rc_poeeixo,      rc_lodaltura,    rc_loealtura, rc_podaltura, rc_poealtura,      rc_loddnp,            rc_loednp,        rc_poddnp, " +
                      "           rc_poednp, rc_adicao,   rc_nomemedico,  rc_observacoes,  rc_data,         rc_dtavalidade FROM Receita";

            if (rc_nomemedico != "")
            {
                sql += "WHERE rc_nomemedico LIKE @rc_nomemedico";
            }
            List<Receita> lista = new List<Receita>();
            Receita receita = new Receita();

            try
            {
                conn.AbrirConexao();
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                if (rc_nomemedico != "")
                {
                    cmd.Parameters.AddWithValue("@rc_nomemedico", "%" + rc_nomemedico + "%");
                }
                SqlDataReader retorno = cmd.ExecuteReader();
                while (retorno.Read())
                {

                    receita = new Receita();
                    receita.Rc_id = retorno.GetInt32(retorno.GetOrdinal("rc_id"));
                    //receita.Rc_historico = retorno.GetDateTime(retorno.GetOrdinal("rc_historico"));
                    receita.Rc_lodesferico = retorno.GetDecimal(retorno.GetOrdinal("rc_lodesferico"));
                    receita.Rc_loeesferico = retorno.GetDecimal(retorno.GetOrdinal("rc_loeesferico"));
                    receita.Rc_podesferico = retorno.GetDecimal(retorno.GetOrdinal("rc_podesferico"));
                    receita.Rc_poeesferico = retorno.GetDecimal(retorno.GetOrdinal("rc_poeesferico"));
                    receita.Rc_lodcilindrico = retorno.GetDecimal(retorno.GetOrdinal("rc_lodcilindrico"));
                    receita.Rc_loecilindrico = retorno.GetDecimal(retorno.GetOrdinal("rc_loecilindrico"));
                    receita.Rc_podcilindrico = retorno.GetDecimal(retorno.GetOrdinal("rc_podcilindrico"));
                    receita.Rc_poecilindrico = retorno.GetDecimal(retorno.GetOrdinal("rc_poecilindrico"));
                    receita.Rc_lodeixo = retorno.GetDecimal(retorno.GetOrdinal("rc_lodeixo"));
                    receita.Rc_loeeixo = retorno.GetDecimal(retorno.GetOrdinal("rc_loeeixo"));
                    receita.Rc_podeixo = retorno.GetDecimal(retorno.GetOrdinal("rc_podeixo")); ;
                    receita.Rc_poeeixo = retorno.GetDecimal(retorno.GetOrdinal("rc_poeeixo"));
                    receita.Rc_lodaltura = retorno.GetDecimal(retorno.GetOrdinal("rc_lodaltura"));
                    receita.Rc_loealtura = retorno.GetDecimal(retorno.GetOrdinal("rc_loealtura"));
                    receita.Rc_podaltura = retorno.GetDecimal(retorno.GetOrdinal("rc_podaltura"));
                    receita.Rc_poealtura = retorno.GetDecimal(retorno.GetOrdinal("rc_poealtura")); ;
                    receita.Rc_loddnp = retorno.GetDecimal(retorno.GetOrdinal("rc_loddnp"));
                    receita.Rc_loednp = retorno.GetDecimal(retorno.GetOrdinal("rc_loednp"));
                    receita.Rc_poddnp = retorno.GetDecimal(retorno.GetOrdinal("rc_poddnp"));
                    receita.Rc_poednp = retorno.GetDecimal(retorno.GetOrdinal("rc_poednp"));
                    receita.Rc_data = retorno.GetDateTime(retorno.GetOrdinal("rc_data"));
                    receita.Rc_adicao = retorno.GetDecimal(retorno.GetOrdinal("rc_adicao"));
                    receita.Rc_nomemedico = retorno.GetString(retorno.GetOrdinal("rc_nomemedico"));
                    receita.Rc_observacoes = retorno.GetString(retorno.GetOrdinal("rc_observacoes"));

                    lista.Add(receita);
                }
                conn.FecharConexao();
                return lista;

            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }

        }




        public bool verificaduplicidade(Receita receita)
        {
            throw new NotImplementedException();
        }


 

        }
    }
