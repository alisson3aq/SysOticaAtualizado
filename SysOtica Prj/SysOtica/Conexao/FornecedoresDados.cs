﻿using SysOtica.Negocio.Classes_Basicas;
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
    public class FornecedoresDados : IFornecedorDados
    {
        ConexaoBD conn = new ConexaoBD();

        public void inserirFornecedor(Fornecedor fr)

        {
            string sql = "INSERT INTO Fornecedor Values ('" + fr.Fr_razaosocial + "','" + fr.Fr_inscricaoestadual + "','" + fr.Fr_fantasia + "', '" + fr.Fr_endereco + "','" + fr.Fr_cidade + "', '" + fr.Fr_uf + "', '" + fr.Fr_bairro + "','" + fr.Fr_cep + "', '" + fr.Fr_contato + "','" + fr.Fr_telefone + "','" + fr.Fr_fax + "','" + fr.Fr_email + "', '" + fr.Fr_nomerepresentante + "', '" + fr.Fr_telefonerepresentante + "', '" + fr.Fr_celularrepresentante + "','" + fr.Fr_observacoes + "', '" + fr.Fr_cnpj + "')";


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

        public void alteraFornecedor(Fornecedor fr)
        {
        
            string sql = "UPDATE Fornecedor SET  fr_razaosocial= ' " + fr.Fr_razaosocial + "', fr_inscricaoestadual = '" + fr.Fr_inscricaoestadual + "', fr_fantasia = '" + fr.Fr_fantasia + "', fr_endereco = '" + fr.Fr_endereco + "', fr_cidade = '" + fr.Fr_cidade + "', fr_uf = '" + fr.Fr_uf + "', fr_bairro = '" + fr.Fr_bairro + "', fr_cep = '" + fr.Fr_cep + "', fr_contato = '" + fr.Fr_contato + "', fr_telefone ='" + fr.Fr_telefone + "', fr_telefone = '" + fr.Fr_fax + "', fr_email = '" + fr.Fr_email + "', fr_nomerepresentante = '" + fr.Fr_nomerepresentante + "', fr_telefonerepresentante = '" + fr.Fr_telefonerepresentante + "', fr_celularrepresentante =  '" + fr.Fr_celularrepresentante + "', fr_observacoes = '" + fr.Fr_observacoes + "', fr_cnpj = '" + fr.Fr_cnpj + "'WHERE fr_id = " + (fr.Fr_id) + "";

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

        public void excluiFornecedor(Fornecedor fr)
        {

            string sql = "DELETE FROM Fornecedor WHERE fr_id = " + (fr.Fr_id) + "";

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

        public List<Fornecedor> listaFornecedor()
       {
            string sql = "SELECT * FROM Fornecedor Order by fr_id";
            List<Fornecedor> lista = new List<Fornecedor>();
            Fornecedor fr;

            try
            {
                conn.AbrirConexao();
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                SqlDataReader retorno = cmd.ExecuteReader();

                

                while (retorno.Read())
                {
                    fr = new Fornecedor();
                    fr.Fr_id = retorno.GetInt32(retorno.GetOrdinal("fr_id"));
                    fr.Fr_razaosocial = retorno.GetString(retorno.GetOrdinal("fr_razaosocial"));
                    fr.Fr_inscricaoestadual = retorno.GetString(retorno.GetOrdinal("fr_inscricaoestadual"));
                    fr.Fr_fantasia = retorno.GetString(retorno.GetOrdinal("fr_fantasia"));
                    fr.Fr_endereco = retorno.GetString(retorno.GetOrdinal("fr_endereco"));
                    fr.Fr_cidade = retorno.GetString(retorno.GetOrdinal("fr_cidade"));
                    fr.Fr_uf = retorno.GetString(retorno.GetOrdinal("fr_uf"));
                    fr.Fr_bairro = retorno.GetString(retorno.GetOrdinal("fr_bairro"));
                    fr.Fr_cep = retorno.GetString(retorno.GetOrdinal("fr_cep"));
                    fr.Fr_contato = retorno.GetString(retorno.GetOrdinal("fr_contato"));
                    fr.Fr_telefone = retorno.GetString(retorno.GetOrdinal("fr_telefone"));
                    fr.Fr_fax = retorno.GetString(retorno.GetOrdinal("fr_fax"));
                    fr.Fr_email = retorno.GetString(retorno.GetOrdinal("fr_email"));
                    fr.Fr_nomerepresentante = retorno.GetString(retorno.GetOrdinal("fr_nomerepresentante"));
                    fr.Fr_celularrepresentante = retorno.GetString(retorno.GetOrdinal("fr_celularrepresentante"));
                    fr.Fr_telefonerepresentante = retorno.GetString(retorno.GetOrdinal("fr_telefonerepresentante"));
                    fr.Fr_observacoes = retorno.GetString(retorno.GetOrdinal("fr_observacoes"));
                    fr.Fr_cnpj = retorno.GetString(retorno.GetOrdinal("fr_cnpj"));
                    
                    lista.Add(fr);
                }
                conn.FecharConexao();
                return lista;

            }
            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }
        
       }

        public List<Fornecedor> pesquisarFornecedor(string fr_fantasia)
        {
            string sql = "fr_id, fr_razaosocial, fr_inscricaoestadual, fr_fantasia, fr_endereco, fr_cidade, fr_uf, fr_bairro, fr_cep, fr_contato, fr_telefone, fr_fax, fr_email, fr_nomepresentante, fr_celularrepresentante, fr_telefonerepresentante, fr_observacoes, fr_cnpj FROM Fornecedor ";
            if (fr_fantasia != "")
            {
                sql += "WHERE fr_fantasia LIKE @fr_fantasia";
            }
            List<Fornecedor> lista = new List<Fornecedor>();
            Fornecedor fr = new Fornecedor();

            try
            {
                conn.AbrirConexao();
                SqlCommand cmd = new SqlCommand(sql, conn.cone);
                if (fr_fantasia != "")
                {
                    cmd.Parameters.AddWithValue("@fr_fantasia", "%" + fr_fantasia + "%");
                }
                SqlDataReader retorno = cmd.ExecuteReader();
                while (retorno.Read())
                {
                    fr = new Fornecedor();
                    fr.Fr_id = retorno.GetInt32(retorno.GetOrdinal("fr_id"));
                    fr.Fr_razaosocial = retorno.GetString(retorno.GetOrdinal("fr_razaosocial"));
                    fr.Fr_inscricaoestadual = retorno.GetString(retorno.GetOrdinal("fr_inscricaoestadual"));
                    fr.Fr_fantasia = retorno.GetString(retorno.GetOrdinal("fr_fantasia"));
                    fr.Fr_endereco = retorno.GetString(retorno.GetOrdinal("fr_endereco"));
                    fr.Fr_cidade = retorno.GetString(retorno.GetOrdinal("fr_cidade"));
                    fr.Fr_uf = retorno.GetString(retorno.GetOrdinal("fr_uf"));
                    fr.Fr_bairro = retorno.GetString(retorno.GetOrdinal("fr_bairro"));
                    fr.Fr_cep = retorno.GetString(retorno.GetOrdinal("fr_cep"));
                    fr.Fr_contato = retorno.GetString(retorno.GetOrdinal("fr_contato"));
                    fr.Fr_telefone = retorno.GetString(retorno.GetOrdinal("fr_telefone"));
                    fr.Fr_fax = retorno.GetString(retorno.GetOrdinal("fr_fax"));
                    fr.Fr_email = retorno.GetString(retorno.GetOrdinal("fr_email"));
                    fr.Fr_nomerepresentante = retorno.GetString(retorno.GetOrdinal("fr_nomepresentante"));
                    fr.Fr_celularrepresentante = retorno.GetString(retorno.GetOrdinal("fr_celularrepresentante"));
                    fr.Fr_telefonerepresentante = retorno.GetString(retorno.GetOrdinal("fr_telefonerepresentante"));
                    fr.Fr_observacoes = retorno.GetString(retorno.GetOrdinal("fr_observacoes"));
                    fr.Fr_cnpj = retorno.GetString(retorno.GetOrdinal("fr_cnpj"));

                    lista.Add(fr);
                }
                conn.FecharConexao();
                return lista;
            }

            catch (SqlException e)
            {
                throw new BancoDeDadosException("Falha na comunicação com o banco de dados. \n" + e.Message);
            }

        }

        public bool verificaduplicidade(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }







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
