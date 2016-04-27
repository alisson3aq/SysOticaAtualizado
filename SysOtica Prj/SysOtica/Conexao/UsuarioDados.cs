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
    class UsuarioDados : ConexaoBD, IConexaoBD
    {
        //public void Insert(Usuario usuario)
        //{
        //    try
        //    {
        //        //abrir a conexão
        //        this.Conecta();
        //        string sql = "INSERT INTO usuario us_senha, us_endereco, us_telefone, us_tipo, us_usuario, us_nome)";
        //        //instrucao a ser executada
        //        SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

        //        cmd.Parameters.Add("@us_senha", SqlDbType.VarChar);
        //        cmd.Parameters["@us_senha"].Value = usuario.Us_senha;

        //        cmd.Parameters.Add("@us_endereco", SqlDbType.VarChar);
        //        cmd.Parameters["@us_endereco"].Value = usuario.Us_endereco;

        //        cmd.Parameters.Add("@us_telefone", SqlDbType.VarChar);
        //        cmd.Parameters["@us_telefone"].Value = usuario.Us_telefone;

        //        cmd.Parameters.Add("@us_tipo", SqlDbType.VarChar);
        //        cmd.Parameters["@us_tipo"].Value = usuario.Us_tipo;

        //        cmd.Parameters.Add("@us_usuario", SqlDbType.VarChar);
        //        cmd.Parameters["@us_usuario"].Value = usuario.Us_usuario;

        //        cmd.Parameters.Add("@us_nome", SqlDbType.VarChar);
        //        cmd.Parameters["@us_nome"].Value = usuario.Us_nome;

        //        //executando a instrucao 
        //        cmd.ExecuteNonQuery();
        //        //liberando a memoria 
        //        cmd.Dispose();
        //        //fechando a conexao
        //        this.Desconecta();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Erro ao Conectar e inserir " + ex.Message);
        //    }
        //}

        //public void update(Usuario usuario)
        //{
        //    try
        //    {
        //        //abrir a conexão
        //        this.Conecta();
        //        string sql = "UPDATE usuario SET (us_senha = @us_senha, us_endereco = @us_endereco, us_telefone = @us_telefone,us_tipo = @us_tipo, us_usuario = @us_usuario,us_nome = @us_nome) WHERE us_id = @us_id;";
        //        //instrucao a ser executada
        //        SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

        //        cmd.Parameters.Add("@us_id", SqlDbType.Int);
        //        cmd.Parameters["@us_id"].Value = usuario.Us_id;

        //        cmd.Parameters.Add("@us_senha", SqlDbType.VarChar);
        //        cmd.Parameters["@us_senha"].Value = usuario.Us_senha;

        //        cmd.Parameters.Add("@us_endereco", SqlDbType.VarChar);
        //        cmd.Parameters["@us_endereco"].Value = usuario.Us_endereco;

        //        cmd.Parameters.Add("@us_telefone", SqlDbType.VarChar);
        //        cmd.Parameters["@us_telefone"].Value = usuario.Us_telefone;

        //        cmd.Parameters.Add("@us_tipo", SqlDbType.VarChar);
        //        cmd.Parameters["@us_tipo"].Value = usuario.Us_tipo;

        //        cmd.Parameters.Add("@us_usuario", SqlDbType.VarChar);
        //        cmd.Parameters["@us_usuario"].Value = usuario.Us_usuario;

        //        cmd.Parameters.Add("@us_nome", SqlDbType.VarChar);
        //        cmd.Parameters["@us_nome"].Value = usuario.Us_nome;

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

        //public void delete(Usuario usuario)
        //{
        //    try
        //    {
        //        //abrir a conexão
        //        this.Conecta();
        //        string sql = "DELETE FROM usuario WHERE us_id = @us_id";
        //        //instrucao a ser executada
        //        SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
        //        cmd.Parameters.Add("@cl_id", SqlDbType.Int);
        //        cmd.Parameters["@cl_id"].Value = usuario.Us_id;
        //        //executando a instrucao 
        //        cmd.ExecuteNonQuery();
        //        //liberando a memoria 
        //        cmd.Dispose();
        //        //fechando a conexao
        //        this.Desconecta();
        //    }
        //    catch (Exception
        //        ex)
        //    {
        //        throw new Exception("erro ao conectar e remover " + ex.Message);
        //    }
        //}

        //public bool verificaduplicidade(Usuario usuario)
        //{
        //    bool retorno = false;
        //    try
        //    {
        //        this.Conecta();
        //        //instrucao a ser executada
        //        string sql = "select * from usuario where us_id = @us_id";
        //        SqlCommand cmd = new SqlCommand(sql, sqlConn);
        //        cmd.Parameters.Add("@us_id", SqlDbType.Int);
        //        cmd.Parameters["@us_id"].Value = usuario.Us_id;
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

        //public List<Usuario> select(Usuario filtro)
        //{
        //    List<Usuario> retorno = new List<Usuario>();
        //    try
        //    {
        //        this.Conecta();
        //        //instrucao a ser executada
        //        string sql = "select * from usuario where us_id = @us_id";
        //        //se foi passada uma matricula válida, esta matricula entrará como critério de filtro
        //        if (filtro.Us_id > 0)
        //        {
        //            sql += " and  us_id = @us_id";
        //        }
        //        //se foi passada um nome de usuario válido, este nome de usuario entrará como critério de filtro
        //        if (filtro.Us_usuario != null && filtro.Us_usuario.Trim().Equals("") == false)
        //        {
        //            sql += " and nome like '%@Us_usuario%'";
        //        }
        //        SqlCommand cmd = new SqlCommand(sql, sqlConn);

        //        //se foi passada uma matricula válida, esta matricula entrará como critério de filtro
        //        if (filtro.Us_id > 0)
        //        {
        //            cmd.Parameters.Add("@us_id", SqlDbType.Int);
        //            cmd.Parameters["@us_id"].Value = filtro.Us_id;
        //        }
        //        //se foi passada um nome válido, este nome entrará como critério de filtro
        //        if (filtro.Us_usuario != null && filtro.Us_usuario.Trim().Equals("") == false)
        //        {
        //            cmd.Parameters.Add("@usuario", SqlDbType.VarChar);
        //            cmd.Parameters["@usuario"].Value = filtro.Us_usuario;

        //        }
        //        //executando a instrucao e colocando o resultado em um leitor
        //        SqlDataReader dbreader = cmd.ExecuteReader();
        //        //lendo o resultado da consulta
        //        while (dbreader.Read())
        //        {
        //            Usuario usuario = new Usuario();
        //            //acessando os valores das colunas do resultado

        //            usuario.Us_id = dbreader.GetInt32(dbreader.GetOrdinal("@us_id"));
        //            usuario.Us_senha = dbreader.GetString(dbreader.GetOrdinal("@us_senha"));
        //            usuario.Us_endereco = dbreader.GetString(dbreader.GetOrdinal("@us_endereco"));
        //            usuario.Us_telefone = dbreader.GetString(dbreader.GetOrdinal("@us_telefone"));
        //            usuario.Us_tipo = dbreader.GetString(dbreader.GetOrdinal("@us_tipo"));
        //            usuario.Us_usuario = dbreader.GetString(dbreader.GetOrdinal("@us_usuario"));
        //            usuario.Us_nome = dbreader.GetString(dbreader.GetOrdinal("@us_nome"));
                
        //            retorno.Add(usuario);
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
    }
}
