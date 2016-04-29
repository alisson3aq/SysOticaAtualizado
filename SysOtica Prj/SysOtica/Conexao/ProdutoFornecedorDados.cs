using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysOtica.Negocio.Classes_Basicas;
using System.Data.SqlClient;
using System.Data;
using SysOtica.Negocio.Excecoes;

namespace SysOtica.Conexao
{
    public class ProdutoFornecedorDados : IProdutoFornecedor
    {
        ConexaoBD conn = new ConexaoBD();

        public void inserir(ProdutoFornecedor pf)
        {

            string sql = "INSERT INTO produtofornecedor  Values (' " + pf.Pf_qtd + "', '" + pf.Pf_dtentrada + "', '" + pf.P.Pf_id + "', '" + pf.F.Fr_id + "','" + pf.Pf_tipo + "', '" + pf.Pf_observacoes + "')";

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



        /* public List<ProdutoFornecedor> selecionafornecedor()
         {
             try
             {
                 this.Conecta();
                 String sql = "Select p.fr_id AS IdFornecedor, f.fr_fantasia as NomeFantasia FROM Produto p Inner Join Fornecedor f on p.fr_id = f.fr_id";
                 List<ProdutoFornecedor> lista = new List<ProdutoFornecedor>();
                 SqlCommand cmd = new SqlCommand(sql, this.sqlConn);



                 SqlDataReader dr = cmd.ExecuteReader();

                 while (dr.Read())
                 {
                     Produto produto = new Produto();

                     //(pf_qtd, pf_dtentrada, pr_id, fr_id, pf_tipo, pf_observacoes)

                     //pr_descricao, pr_grife, pr_valor, pr_estoqueminimo, fr_id, pr_categoria,  pr_quantidade

                     produto.Pr_id = dr.GetInt32(dr.GetOrdinal("pr_id"));
                     produto.Pr_descricao = dr.GetString(dr.GetOrdinal("pr_descricao"));
                     produto.Pr_grife = dr.GetString(dr.GetOrdinal("pr_grife"));
                     produto.Pr_valor = dr.GetDouble(dr.GetOrdinal("pr_valor"));
                     produto.Pr_estoqueminimo = dr.GetInt32(dr.GetOrdinal("pr_estoqueminimo"));
                     produto.Fr_id = dr.GetInt32(dr.GetOrdinal("fr_id"));
                     produto.Pr_Categoria = dr.GetString(dr.GetOrdinal("pr_categoria"));
                     produto.Pr_qtd = dr.GetInt32(dr.GetOrdinal("pr_quantidade"));

                     // lista.Add(produto);


                 }
                 dr.Close();
                 this.Desconecta();
                 //return lista;









             }
             catch (Exception ex)
             { }





         }*/

        //public List<ProdutoFornecedor> selecionaproduto(Produto pr_id)
        //{
        //    throw new NotImplementedException();
        //}


        public List<ProdutoFornecedor> selecionafornecedor()
        {
            throw new NotImplementedException();
        }

        public List<ProdutoFornecedor> selecionaproduto(int pr_id)
        {
            throw new NotImplementedException();
        }
    }
}

