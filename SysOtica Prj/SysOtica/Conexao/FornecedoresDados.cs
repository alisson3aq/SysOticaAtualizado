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
    public class FornecedoresDados : ConexaoBD, IConexaoBD
    {

                ////abrir a conexão
                //this.Conecta();
                //string sql = "UPDATE funcionario SET ( fr_razaosocial = @fr_razaosocial, fr_inscricaoestadual =@fr_inscricaoestadual, fr_fantasia = @fr_fantasia, fr_endereco =@fr_endereco, fr_cidade = @fr_cidade, fr_uf = @fr_uf, fr_bairro = @fr_bairro, fr_cep = @fr_cep, fr_contato = @fr_contato, fr_telefone = @fr_telefone, fr_fax = @fr_fax, fr_email =@fr_email, fr_nomerepresentante = @fr_nomerepresentante, fr_telefonerepresentante = @fr_telefonerepresentante, fr_celularrepresentante = @fr_celularrepresentante, fr_observacoes = @fr_observacoes, fr_cnpj = @fr_cnpj) WHERE fr_id = @fr_id;";
                ////instrucao a ser executada
                //SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                //        cmd.Parameters.Add("@fr_id", SqlDbType.Int);
                //        cmd.Parameters["@fr_id"].Value = fornecedor.Fr_id;

                //        cmd.Parameters.Add("@fr_razaosocial", SqlDbType.VarChar);
                //        cmd.Parameters["@fr_razaosocial"].Value = fornecedor.Fr_razaosocial;

                //        cmd.Parameters.Add("@fr_inscricaoestadual", SqlDbType.VarChar);
                //        cmd.Parameters["@fr_inscricaoestadual"].Value = fornecedor.Fr_inscricaoestadual;

                //        cmd.Parameters.Add("@fr_fantasia", SqlDbType.VarChar);
                //        cmd.Parameters["@fr_fantasia"].Value = fornecedor.Fr_fantasia;

                //        cmd.Parameters.Add("@fr_endereco", SqlDbType.VarChar);
                //        cmd.Parameters["@fr_endereco"].Value = fornecedor.Fr_endereco;

                //        cmd.Parameters.Add("@fr_cidade", SqlDbType.VarChar);
                //        cmd.Parameters["@fr_cidade"].Value = fornecedor.Fr_cidade;

                //        cmd.Parameters.Add("@fr_uf", SqlDbType.VarChar);
                //        cmd.Parameters["@fr_uf"].Value = fornecedor.Fr_uf;

                //        cmd.Parameters.Add("@fr_bairro", SqlDbType.VarChar);
                //        cmd.Parameters["@fr_bairro"].Value = fornecedor.Fr_bairro;

                //        cmd.Parameters.Add("@fr_cep", SqlDbType.VarChar);
                //        cmd.Parameters["@fr_cep"].Value = fornecedor.Fr_cep;

                //        cmd.Parameters.Add("@fr_contato", SqlDbType.VarChar);
                //        cmd.Parameters["@fr_contato"].Value = fornecedor.Fr_contato;

                //        cmd.Parameters.Add("@fr_telefone", SqlDbType.VarChar);
                //        cmd.Parameters["@fr_telefone"].Value = fornecedor.Fr_telefone;

                //        cmd.Parameters.Add("@fr_fax", SqlDbType.VarChar);
                //        cmd.Parameters["@fr_fax"].Value = fornecedor.Fr_fax;

                //        cmd.Parameters.Add("@fr_email", SqlDbType.VarChar);
                //        cmd.Parameters["@fr_email"].Value = fornecedor.Fr_email;

                //        cmd.Parameters.Add("@fr_nomerepresentante", SqlDbType.VarChar);
                //        cmd.Parameters["@fr_nomerepresentante"].Value = fornecedor.Fr_nomerepresentante;

                //        cmd.Parameters.Add("@fr_telefonerepresentante", SqlDbType.VarChar);
                //        cmd.Parameters["@fr_telefonerepresentante"].Value = fornecedor.Fr_telefonerepresentante;

                //        cmd.Parameters.Add("@fr_celularrepresentante", SqlDbType.VarChar);
                //        cmd.Parameters["@fr_celularrepresentante"].Value = fornecedor.Fr_celularrepresentante;

                //        cmd.Parameters.Add("@fr_observacoes", SqlDbType.VarChar);
                //        cmd.Parameters["@fr_observacoes"].Value = fornecedor.Fr_observacoes;

                //        cmd.Parameters.Add("@fr_cnpj", SqlDbType.VarChar);
                //        cmd.Parameters["@fr_cnpj"].Value = fornecedor.Fr_cnpj;

                //        //executando a instrucao 
                //        cmd.ExecuteNonQuery();
                //        //liberando a memoria 
                //        cmd.Dispose();
                //        //fechando a conexao
                //        this.Desconecta();
                //    }
                //    catch (Exception ex)
                //    {
                //        throw new Exception("erro ao conectar e atualizar " + ex.Message);
                //    }
                //}

                //public void delete(Fornecedor fornecedor)
                //{
                //    try
                //    {
                //        //abrir a conexão
                //        this.Conecta();
                //        string sql = "DELETE FROM fornecedor WHERE fr_id = @fr_id";
                //        //instrucao a ser executada
                //        SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                //        cmd.Parameters.Add("@fr_id", SqlDbType.Int);
                //        cmd.Parameters["@fr_id"].Value = fornecedor.Fr_id;
                //        //executando a instrucao 
                //        cmd.ExecuteNonQuery();
                //        //liberando a memoria 
                //        cmd.Dispose();
                //        //fechando a conexao
                //this.Desconecta();
                //    }
                //    catch (Exception
                //        ex)
                //    {
                //        throw new Exception("erro ao conecar e remover " + ex.Message);
                //    }
                //}

                //public bool verificaduplicidade(Fornecedor fornecedor)
                //{
                //    bool retorno = false;
                //    try
                //    {
                //        //this.Conecta();
                //        ////instrucao a ser executada
                //        //string sql = "select * from fornecedor where fr_id = @fr_id";
                //        //SqlCommand cmd = new SqlCommand(sql, sqlConn);
                //        cmd.Parameters.Add("@fr_id", SqlDbType.Int);
                //        cmd.Parameters["@fr_id"].Value = fornecedor.Fr_id;
                //        //executando a instrucao e colocando o resultado em um leitor
                //        SqlDataReader dbreader = cmd.ExecuteReader();
                //        //lendo o resultado da consulta
                //        while (dbreader.Read())
                //        {
                //            retorno = true;
                //            break;
                //        }
                //        //fechando o leitor de resultados
                //        dbreader.Close();
                //        //liberando a memoria 
                //        cmd.Dispose();
                //        //fechando a conexao
                //        this.Desconecta();
                //    }
                //    catch (Exception ex)
                //    {
                //        throw new Exception("erro ao conectar e selecionar " + ex.Message);
                //    }
                //    return retorno;
                //}

                //public List<Fornecedor> select(Fornecedor filtro)
                //{
                //    List<Fornecedor> retorno = new List<Fornecedor>();
                //    try
                //    {
                //        this.Conecta();
                //        //instrucao a ser executada
                //        string sql = "select * from fornecedor where fr_id = @fr_id";
                //        //se foi passada uma matricula válida, esta matricula entrará como critério de filtro
                //        if (filtro.Fr_id > 0)
                //        {
                //            sql += " and  fr_id = @fr_id";
                //        }
                //        //se foi passada um cnpj válido, este cnpj entrará como critério de filtro
                //        if (filtro.Fr_cnpj != null && filtro.Fr_cnpj.Trim().Equals("") == false)
                //        {
                //            sql += " and nome like '%@Fr_cnpj%'";
                //        }
                //        SqlCommand cmd = new SqlCommand(sql, sqlConn);

                //        //se foi passada uma matricula válida, esta matricula entrará como critério de filtro
                //        if (filtro.Fr_id > 0)
                //        {
                //            cmd.Parameters.Add("@fr_id", SqlDbType.Int);
                //            cmd.Parameters["@fr_id"].Value = filtro.Fr_id;
                //        }
                //        //se foi passada um cnpj válido, este cnpj entrará como critério de filtro
                //        if (filtro.Fr_cnpj != null && filtro.Fr_cnpj.Trim().Equals("") == false)
                //        {
                //            cmd.Parameters.Add("@cnpj", SqlDbType.VarChar);
                //            cmd.Parameters["@cnpj"].Value = filtro.Fr_cnpj;

                //        }
                //        //executando a instrucao e colocando o resultado em um leitor
                //        SqlDataReader dbreader = cmd.ExecuteReader();
                //        //lendo o resultado da consulta
                //        while (dbreader.Read())
                //        {
                //            Fornecedor fornecedor = new Fornecedor();
                //            //acessando os valores das colunas do resultado

                //            fornecedor.Fr_id = dbreader.GetInt32(dbreader.GetOrdinal("@fr_id"));
                //            fornecedor.Fr_razaosocial = dbreader.GetString(dbreader.GetOrdinal("@fr_razaosocial"));
                //            fornecedor.Fr_inscricaoestadual = dbreader.GetString(dbreader.GetOrdinal("@fr_inscricaoestadual"));
                //            fornecedor.Fr_fantasia = dbreader.GetString(dbreader.GetOrdinal("@fr_fantasia"));
                //            fornecedor.Fr_endereco = dbreader.GetString(dbreader.GetOrdinal("@fr_endereco"));
                //            fornecedor.Fr_cidade = dbreader.GetString(dbreader.GetOrdinal("@fr_cidade"));
                //            fornecedor.Fr_uf = dbreader.GetString(dbreader.GetOrdinal("@fr_uf"));
                //            fornecedor.Fr_bairro = dbreader.GetString(dbreader.GetOrdinal("@fr_bairro"));
                //            fornecedor.Fr_cep = dbreader.GetString(dbreader.GetOrdinal("@fr_cep"));
                //            fornecedor.Fr_contato = dbreader.GetString(dbreader.GetOrdinal("@fr_contato"));
                //            fornecedor.Fr_telefone = dbreader.GetString(dbreader.GetOrdinal("@fr_telefone"));
                //            fornecedor.Fr_fax = dbreader.GetString(dbreader.GetOrdinal("@fr_fax"));
                //            fornecedor.Fr_email = dbreader.GetString(dbreader.GetOrdinal("@fr_email"));
                //            fornecedor.Fr_nomerepresentante = dbreader.GetString(dbreader.GetOrdinal("@fr_nomerepresentante"));
                //            fornecedor.Fr_telefonerepresentante = dbreader.GetString(dbreader.GetOrdinal("@fr_telefonerepresentante"));
                //            fornecedor.Fr_celularrepresentante = dbreader.GetString(dbreader.GetOrdinal("@fr_celularrepresentante"));
                //            fornecedor.Fr_observacoes = dbreader.GetString(dbreader.GetOrdinal("@fr_observacoes"));
                //            fornecedor.Fr_cnpj = dbreader.GetString(dbreader.GetOrdinal("@fr_observacoes"));

                //            retorno.Add(fornecedor);
                //        }
                //        //fechando o leitor de resultados
                //        dbreader.Close();
                //        //liberando a memoria 
                //        cmd.Dispose();
                //        //fechando a conexao
                //        this.Desconecta();
                //    }
                //    catch (Exception ex)
                //    {
                //        throw new Exception("erro ao conecar e selecionar " + ex.Message);
                //    }
                //    return retorno;
                //}



                //public List<Fornecedor> pegaFornenedor()
                //{


                //    this.Conecta();
                //    String sql = "Select * from Fornecedor Order By fr_id";
                //    List<Fornecedor> lista = new List<Fornecedor>();
                //    SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                //    SqlDataReader dr = cmd.ExecuteReader();

                //    while (dr.Read())
                //    {
                //        Fornecedor fornecedor = new Fornecedor();


                //        fornecedor.Fr_id = dr.GetInt32(dr.GetOrdinal("fr_id"));
                //        fornecedor.Fr_razaosocial = dr.GetString(dr.GetOrdinal("fr_razaosocial"));
                //        fornecedor.Fr_inscricaoestadual = dr.GetString(dr.GetOrdinal("fr_inscricaoestadual"));
                //        fornecedor.Fr_fantasia = dr.GetString(dr.GetOrdinal("fr_fantasia"));
                //        fornecedor.Fr_endereco = dr.GetString(dr.GetOrdinal("fr_endereco"));
                //        fornecedor.Fr_cidade = dr.GetString(dr.GetOrdinal("fr_cidade"));
                //        fornecedor.Fr_uf = dr.GetString(dr.GetOrdinal("fr_uf"));
                //        fornecedor.Fr_bairro = dr.GetString(dr.GetOrdinal("fr_bairro"));
                //        fornecedor.Fr_cep = dr.GetString(dr.GetOrdinal("fr_cep"));
                //        fornecedor.Fr_contato = dr.GetString(dr.GetOrdinal("fr_contato"));
                //        fornecedor.Fr_telefone = dr.GetString(dr.GetOrdinal("fr_telefone"));
                //        fornecedor.Fr_fax = dr.GetString(dr.GetOrdinal("fr_fax"));
                //        fornecedor.Fr_email = dr.GetString(dr.GetOrdinal("fr_email"));
                //        fornecedor.Fr_nomerepresentante = dr.GetString(dr.GetOrdinal("fr_nomerepresentante"));
                //        fornecedor.Fr_telefonerepresentante = dr.GetString(dr.GetOrdinal("fr_telefonerepresentante"));
                //        fornecedor.Fr_celularrepresentante = dr.GetString(dr.GetOrdinal("fr_celularrepresentante"));
                //        fornecedor.Fr_observacoes = dr.GetString(dr.GetOrdinal("fr_observacoes"));
                //        fornecedor.Fr_cnpj = dr.GetString(dr.GetOrdinal("fr_observacoes"));

                //        lista.Add(fornecedor);
                //    }
                //    dr.Close();
                //    this.Desconecta();
                //    return lista;
            //}


            }
}
