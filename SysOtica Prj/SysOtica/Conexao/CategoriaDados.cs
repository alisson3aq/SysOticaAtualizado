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
    class CategoriaDados : ConexaoBD, IConexaoBD
    {
        //public void Insert(Categoria categoria)
        //{
        //    try
        //    {
        //        //abrir a conexão
        //        //this.Conecta();
        //        //string sql = "INSERT INTO categoria ct_nome";
        //        ////instrucao a ser executada
        //        ////SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

        //        //cmd.Parameters.Add("@ct_nome", SqlDbType.VarChar);
        //        //cmd.Parameters["@ct_nome"].Value = categoria.Ct_nome;

        //        ////executando a instrucao 
        //        //cmd.ExecuteNonQuery();
        //        ////liberando a memoria 
        //        //cmd.Dispose();
        //        ////fechando a conexao
        //        //this.Desconecta();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Erro ao Conectar e inserir " + ex.Message);
        //    }
        //}

        //public void update(Categoria categoria)
        //{
        //    try
        //    {
        //        //abrir a conexão
        //        //this.Conecta();
        //        //string sql = "UPDATE categoria SET ( ct_nome = @ct_nome@) WHERE ct_id = @ct_id;";
        //        ////instrucao a ser executada
        //        ////SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

        //        //cmd.Parameters.Add("@ct_id", SqlDbType.Int);
        //        //cmd.Parameters["@ct_id"].Value = categoria.Ct_id;

        //        //cmd.Parameters.Add("@ct_nome", SqlDbType.VarChar);
        //        //cmd.Parameters["@ct_nome"].Value = categoria.Ct_nome;

        //        ////executando a instrucao 
        //        //cmd.ExecuteNonQuery();
        //        ////liberando a memoria 
        //        //cmd.Dispose();
        //        ////fechando a conexao
        //        //this.Desconecta();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("erro ao conectar e atualizar " + ex.Message);
        //    }
        //}

        //public void delete(Categoria categoria)
        //{
        //    try
        //    {
        //        ////abrir a conexão
        //        //this.Conecta();
        //        //string sql = "DELETE FROM categoria WHERE ct_id = @ct_id";
        //        ////instrucao a ser executada
        //        //SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
        //        //cmd.Parameters.Add("@ct_id", SqlDbType.Int);
        //        //cmd.Parameters["@ct_id"].Value = categoria.Ct_id;
        //        ////executando a instrucao 
        //        //cmd.ExecuteNonQuery();
        //        ////liberando a memoria 
        //        //cmd.Dispose();
        //        ////fechando a conexao
        //        //this.Desconecta();
        //    }
        //    catch (Exception
        //        ex)
        //    {
        //        throw new Exception("erro ao conectar e remover " + ex.Message);
        //    }
        //}

        //public bool verificaduplicidade(Categoria categoria)
        //{
        //    bool retorno = false;
        //    try
        //    {
        //        //this.Conecta();
        //        ////instrucao a ser executada
        //        //string sql = "select * from categoria where ct_id = @ct_id";
        //        //SqlCommand cmd = new SqlCommand(sql, sqlConn);
        //        //cmd.Parameters.Add("@ct_id", SqlDbType.Int);
        //        //cmd.Parameters["@ct_id"].Value = categoria.Ct_id;
        //        //executando a instrucao e colocando o resultado em um leitor
        //        //SqlDataReader dbreader = cmd.ExecuteReader();
        //        //lendo o resultado da consulta
        //        while (dbreader.Read())
        //        {
        //            retorno = true;
        //            break;
        //        }
        //        //fechando o leitor de resultados
        //        dbreader.Close();
        ////liberando a memoria 
        //cmd.Dispose();
        ////fechando a conexao
        //    //this.Desconecta();
        //}
        //catch (Exception ex)
        //{
        //    throw new Exception("erro ao conectar e selecionar " + ex.Message);
        //    }
        //    return retorno;
        //}

        //public List<Categoria> select(Categoria filtro)
        //{
        //    List<Categoria> retorno = new List<Categoria>();
        //    //try
        //    ////{
        //    //    this.Conecta();
        //        //instrucao a ser executada
        //        string sql = "select * from categoria where ct_id = @ct_id";
        //        //se foi passada uma matricula válida, esta matricula entrará como critério de filtro
        //        if (filtro.Ct_id > 0)
        //        {
        //            sql += " and  ct_id = @ct_id";
        //        }
        //        //se foi passada um nome válido, este nome entrará como critério de filtro
        //        if (filtro.Ct_nome != null && filtro.Ct_nome.Trim().Equals("") == false)
        //        {
        //            sql += " and nome like '%@Ct_nome%'";
        //        }
        //        //SqlCommand cmd = new SqlCommand(sql, sqlConn);

        //        //se foi passada uma matricula válida, esta matricula entrará como critério de filtro
        //        if (filtro.Ct_id > 0)
        //        {
        //            cmd.Parameters.Add("@ct_id", SqlDbType.Int);
        //            cmd.Parameters["@ct_id"].Value = filtro.Ct_id;
        //        }
        //        ////se foi passada um nome válido, este nome entrará como critério de filtro
        //        //if (filtro.Ct_nome != null && filtro.Ct_nome.Trim().Equals("") == false)
        //        //{
        //        //    cmd.Parameters.Add("@nome", SqlDbType.VarChar);
        //        //    cmd.Parameters["@nome"].Value = filtro.Ct_nome;

        //        //}
        //        ////executando a instrucao e colocando o resultado em um leitor
        //        //SqlDataReader dbreader = cmd.ExecuteReader();
        //        //lendo o resultado da consulta
        //        while (dbreader.Read())
        //        {
        //            Categoria categoria = new Categoria();
        //            //acessando os valores das colunas do resultado

        //            categoria.Ct_id = dbreader.GetInt32(dbreader.GetOrdinal("@ct_id"));
        //            categoria.Ct_nome = dbreader.GetString(dbreader.GetOrdinal("@ct_nome"));

        //            retorno.Add(categoria);
        //        }
        //fechando o leitor de resultados
        //                dbreader.Close();
        //                //liberando a memoria 
        //                cmd.Dispose();
        //                ////fechando a conexao
        //                //this.Desconecta();
        //            }
        //            catch (Exception ex)
        //            {
        //                throw new Exception("erro ao conectar e selecionar " + ex.Message);
        //            }
        //            return retorno;
        //        }
    }
}
