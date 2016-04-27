using SysOtica.Negocio.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexao
{
    class ProdutoDados : ConexaoBD, IConexaoBD
    {
        //    public void Insert(Produto produto)
        //    {
        //        try
        //        {
        //            //abrir a conexão
        //            this.Conecta();
        //            string sql = "INSERT INTO Produto (pr_descricao, pr_grife, pr_valor, pr_estoqueminimo, fr_id, pr_categoria,  pr_quantidade) values ( @pr_descricao, @pr_grife, @pr_valor, @pr_estoqueminimo, @fr_id, @pr_categoria, @pr_quantidade)";
        //            //instrucao a ser executada
        //            SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

        //            cmd.Parameters.Add("@pr_descricao", SqlDbType.VarChar);
        //            cmd.Parameters["@pr_descricao"].Value = produto.Pr_descricao;

        //            /*cmd.Parameters.Add("@pr_unidade", SqlDbType.VarChar);
        //            cmd.Parameters["@pr_unidade"].Value = produto.Pr_unidade;*/

        //            cmd.Parameters.Add("@pr_grife", SqlDbType.VarChar);
        //            cmd.Parameters["@pr_grife"].Value = produto.Pr_grife;

        //            cmd.Parameters.Add("@pr_valor", SqlDbType.VarChar);
        //            cmd.Parameters["@pr_valor"].Value = produto.Pr_valor;

        //            cmd.Parameters.Add("@pr_quantidade", SqlDbType.VarChar);
        //            cmd.Parameters["@pr_quantidade"].Value = produto.Pr_qtd;

        //            cmd.Parameters.Add("@pr_estoqueminimo", SqlDbType.VarChar);
        //            cmd.Parameters["@pr_estoqueminimo"].Value = produto.Pr_estoqueminimo;

        //            cmd.Parameters.Add("@fr_id", SqlDbType.Int);
        //            cmd.Parameters["@fr_id"].Value = produto.Fr_id;

        //            cmd.Parameters.Add("@pr_categoria", SqlDbType.VarChar);
        //            cmd.Parameters["@pr_categoria"].Value = produto.Pr_Categoria;



        //            //executando a instrucao 
        //            cmd.ExecuteNonQuery();
        //            //liberando a memoria 
        //            cmd.Dispose();
        //            //fechando a conexao
        //            this.Desconecta();
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("Erro ao Conectar e inserir " + ex.Message);
        //        }
        //    }

        //    public void update(Produto produto)
        //    {
        //        try
        //        {
        //            //abrir a conexão
        //            this.Conecta();
        //            string sql = "UPDATE produto SET ( pr_descricao = @pr_descricao, pr_unidade = @pr_unidade,pr_grupo = @pr_grupo,pr_grife = @pr_grife, pr_valor = @pr_valor,pr_qtd = @pr_qtd,pr_estoqueminimo = @pr_estoqueminimo) WHERE pr_id = @pr_id;";
        //            //instrucao a ser executada
        //            SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

        //            cmd.Parameters.Add("pr_id", SqlDbType.Int);
        //            cmd.Parameters["@pr_id"].Value = produto.Pr_id;

        //            cmd.Parameters.Add("@pr_descricao", SqlDbType.VarChar);
        //            cmd.Parameters["@pr_descricao"].Value = produto.Pr_descricao;

        //            cmd.Parameters.Add("@pr_unidade", SqlDbType.VarChar);
        //            cmd.Parameters["@pr_unidade"].Value = produto.Pr_unidade;

        //            cmd.Parameters.Add("@pr_grife", SqlDbType.VarChar);
        //            cmd.Parameters["@pr_grife"].Value = produto.Pr_grife;

        //            cmd.Parameters.Add("@pr_valor", SqlDbType.VarChar);
        //            cmd.Parameters["@pr_valor"].Value = produto.Pr_valor;

        //            cmd.Parameters.Add("@pr_qtd", SqlDbType.VarChar);
        //            cmd.Parameters["@pr_qtd"].Value = produto.Pr_qtd;

        //            cmd.Parameters.Add("@pr_estoqueminimo", SqlDbType.VarChar);
        //            cmd.Parameters["@pr_estoqueminimo"].Value = produto.Pr_estoqueminimo;

        //            cmd.Parameters.Add("@pr_categoria", SqlDbType.VarChar);
        //            cmd.Parameters["@pr_categoria"].Value = produto.Pr_Categoria;


        //            //executando a instrucao 
        //            cmd.ExecuteNonQuery();
        //            //liberando a memoria 
        //            cmd.Dispose();
        //            //fechando a conexao
        //            this.Desconecta();
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("erro ao conectar e atualizar " + ex.Message);
        //        }
        //    }

        //    public void delete(Produto produto)
        //    {
        //        try
        //        {
        //            //abrir a conexão
        //            this.Conecta();
        //            string sql = "DELETE FROM produto WHERE pr_id = @pr_id";
        //            //instrucao a ser executada
        //            SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
        //            cmd.Parameters.Add("@pr_id", SqlDbType.Int);
        //            cmd.Parameters["@pr_id"].Value = produto.Pr_id;
        //            //executando a instrucao 
        //            cmd.ExecuteNonQuery();
        //            //liberando a memoria 
        //            cmd.Dispose();
        //            //fechando a conexao
        //            this.Desconecta();
        //        }
        //        catch (Exception
        //            ex)
        //        {
        //            throw new Exception("erro ao conectar e remover " + ex.Message);
        //        }
        //    }

        //    public bool verificaduplicidade(Produto produto)
        //    {
        //        bool retorno = false;
        //        try
        //        {
        //            this.Conecta();
        //            //instrucao a ser executada
        //            string sql = "select * from produto where pr_id = @pr_id";
        //            SqlCommand cmd = new SqlCommand(sql, sqlConn);
        //            cmd.Parameters.Add("@pr_id", SqlDbType.Int);
        //            cmd.Parameters["@pr_id"].Value = produto.Pr_id;
        //            //executando a instrucao e colocando o resultado em um leitor
        //            SqlDataReader dbreader = cmd.ExecuteReader();
        //            //lendo o resultado da consulta
        //            while (dbreader.Read())
        //            {
        //                retorno = true;
        //                break;
        //            }
        //            //fechando o leitor de resultados
        //            dbreader.Close();
        //            //liberando a memoria 
        //            cmd.Dispose();
        //            //fechando a conexao
        //            this.Desconecta();
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("erro ao conectar e selecionar " + ex.Message);
        //        }
        //        return retorno;
        //    }

        //    public List<Produto> select(Produto filtro)
        //    {
        //        List<Produto> retorno = new List<Produto>();
        //        try
        //        {
        //            this.Conecta();
        //            //instrucao a ser executada
        //            string sql = "select * from produto where pr_id = @pr_id";
        //            //se foi passada uma matricula válida, esta matricula entrará como critério de filtro
        //            if (filtro.Pr_id > 0)
        //            {
        //                sql += " and  pr_id = @pr_id";
        //            }
        //            //se foi passada uma grife válido, esta grife entrará como critério de filtro
        //            if (filtro.Pr_grife != null && filtro.Pr_grife.Trim().Equals("") == false)
        //            {
        //                sql += " and nome like '%@Pr_grife%'";
        //            }
        //            SqlCommand cmd = new SqlCommand(sql, sqlConn);

        //            //se foi passada uma matricula válida, esta matricula entrará como critério de filtro
        //            if (filtro.Pr_id > 0)
        //            {
        //                cmd.Parameters.Add("@pr_id", SqlDbType.Int);
        //                cmd.Parameters["@pr_id"].Value = filtro.Pr_id;
        //            }
        //            //se foi passada uma grife válido, esta grife entrará como critério de filtro
        //            if (filtro.Pr_grife != null && filtro.Pr_grife.Trim().Equals("") == false)
        //            {
        //                cmd.Parameters.Add("@grife", SqlDbType.VarChar);
        //                cmd.Parameters["@grife"].Value = filtro.Pr_grife;

        //            }
        //            //executando a instrucao e colocando o resultado em um leitor
        //            SqlDataReader dbreader = cmd.ExecuteReader();
        //            //lendo o resultado da consulta
        //            while (dbreader.Read())
        //            {
        //                Produto produto = new Produto();
        //                //acessando os valores das colunas do resultado

        //                produto.Pr_id = dbreader.GetInt32(dbreader.GetOrdinal("@pr_id"));
        //                produto.Pr_descricao = dbreader.GetString(dbreader.GetOrdinal("@pr_descricao"));
        //                produto.Pr_unidade = dbreader.GetString(dbreader.GetOrdinal("@pr_unidade"));
        //                produto.Pr_Categoria = dbreader.GetString(dbreader.GetOrdinal("@pr_categoria"));
        //                produto.Pr_grife = dbreader.GetString(dbreader.GetOrdinal("@pr_grife"));
        //                produto.Pr_valor = dbreader.GetDouble(dbreader.GetOrdinal("@pr_valor"));
        //                produto.Pr_qtd = dbreader.GetInt32(dbreader.GetOrdinal("@pr_qtd"));
        //                produto.Pr_estoqueminimo = dbreader.GetInt32(dbreader.GetOrdinal("@pr_estoqueminimo"));

        //                retorno.Add(produto);
        //            }
        //            //fechando o leitor de resultados
        //            dbreader.Close();
        //            //liberando a memoria 
        //            cmd.Dispose();
        //            //fechando a conexao
        //            this.Desconecta();
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("erro ao conectar e selecionar " + ex.Message);
        //        }
        //        return retorno;
        //    }
    }
}
