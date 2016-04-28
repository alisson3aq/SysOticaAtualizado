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
   public class ProdutoDados : IProdutoDados
    {      
        ConexaoBD conn = new ConexaoBD();

    
        public void inserirProduto(Produto p)
        {
            string sql = "INSERT INTO Produto VALUES ('" + p.Pr_descricao + "','" + p.Pr_grife + "','" + p.Pr_valor + "','" + p.Pr_estoqueminimo + "','" + p.Pr_Categoria + "','" + p.Pr_qtd + "')";

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
        public void alterarProduto(Produto p)
        {
            string sql = "UPDATE Produto SET pr_descricao = '" + p.Pr_descricao + "',pr_grife ='" + p.Pr_grife + "', pr_valor ='" + p.Pr_valor + "', pr_estoqueminimo ='" + p.Pr_estoqueminimo + "', pr_categoria = '" + p.Pr_Categoria + "', pr_qtd ='" + p.Pr_qtd + "' WHERE pr_id = " + (p.Pr_id) + "";

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
        public void excluirProduto(Produto p)
        {
            string sql = "DELETE FROM Produto WHERE pr_id =" + (p.Pr_id) + "";
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


        public List<Produto> listarProduto()
        {
            string sql = "SELECT pr_id, pr_descricao, pr_grife, pr_valor, pr_estoqueminimo, pr_categoria, pr_qtd FROM Produto";
            List<Produto> lista = new List<Produto>();
            Produto p;
        
          
        try
            {
                conn.AbrirConexao();
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                SqlDataReader retorno = cmd.ExecuteReader();

                while (retorno.Read())
                {
                    p = new Produto();
                    p.Pr_id = retorno.GetInt32(retorno.GetOrdinal("pr_id"));
                    p.Pr_descricao = retorno.GetString(retorno.GetOrdinal("pr_descricao"));                 
                    p.Pr_grife = retorno.GetString(retorno.GetOrdinal("pr_grife"));
                    p.Pr_valor = retorno.GetDecimal(retorno.GetOrdinal("pr_valor"));
                    p.Pr_estoqueminimo= retorno.GetInt32(retorno.GetOrdinal("pr_estoqueminimo"));
                    p.Pr_Categoria = retorno.GetString(retorno.GetOrdinal("pr_categoria"));
                    p.Pr_qtd = retorno.GetInt32(retorno.GetOrdinal("pr_qtd"));
                    
                    lista.Add(p);
                }
                conn.FecharConexao();
                return lista;

            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }
        }


        public List<Produto> pesquisarProduto(string pr_descricao)
        {
            string sql = "SELECT  SELECT  pr_descricao, pr_grife, pr_valor, pr_estoqueminimo, pr_categoria, pr_qtd FROM Produto";
            if (pr_descricao != "")
            {
                sql += "WHERE pr_descricao ILIKE @pr_descricao";
            }
            List<Produto> lista = new List<Produto>();
            Produto p = new Produto();

            try
            {
                conn.AbrirConexao();
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                if (pr_descricao != "")
                {
                    cmd.Parameters.AddWithValue("@pr_descricao", "%" + pr_descricao + "%");
                }
                SqlDataReader retorno = cmd.ExecuteReader();
                while (retorno.Read())
                {

                    p = new Produto();
                    p.Pr_id = retorno.GetInt32(retorno.GetOrdinal("pr_id"));
                    p.Pr_descricao = retorno.GetString(retorno.GetOrdinal("pr_descricao"));
                    p.Pr_grife = retorno.GetString(retorno.GetOrdinal("pr_grife"));
                    p.Pr_valor = retorno.GetDecimal(retorno.GetOrdinal("pr_valor"));
                    p.Pr_estoqueminimo = retorno.GetInt32(retorno.GetOrdinal("pr_estoqueminimo"));
                    p.Pr_Categoria = retorno.GetString(retorno.GetOrdinal("pr_categoria"));
                    p.Pr_qtd = retorno.GetInt32(retorno.GetOrdinal("pr_qtd"));

                    lista.Add(p);
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
