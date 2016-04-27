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
    public class ReceitaDados : ConexaoBD, IConexaoBD
    {
        //public void Insert(Receita receita)
        //{
            //    try
            //    {
            //        //abrir a conexão
            //        this.Conecta();
            //        string sql = "INSERT INTO receita rc_historico, rc_lodesferico, rc_loeesferico,rc_podesferico, rc_poeesferico,rc_lodcilindrico,rc_loecilindrico, rc_podcilindrico ,rc_poecilindrico,rc_lodeixo,rc_loeeixo,rc_podeixo,rc_poeeixo,rc_lodaltura,rc_loealtura,rc_podaltura,rc_poealtura,rc_loddnp,rc_loednp, rc_poddnp,rc_poednp,rc_adicao,rc_nomemedico,rc_observacoes,rc_data,rc_dtavalidade";
            //        //instrucao a ser executada
            //        SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

            //        cmd.Parameters.Add("@rc_historico", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_historico"].Value = receita.Rc_historico;

            //        cmd.Parameters.Add("@rc_lodesferico", SqlDbType.Date);
            //        cmd.Parameters["@rc_lodesferico"].Value = receita.Rc_lodesferico;

            //        cmd.Parameters.Add("@rc_loeesferico", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_loeesferico"].Value = receita.Rc_loeesferico;

            //        cmd.Parameters.Add("@rc_podesferico", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_podesferico"].Value = receita.Rc_podesferico;

            //        cmd.Parameters.Add("@rc_poeesferico", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_poeesferico"].Value = receita.Rc_poeesferico;

            //        cmd.Parameters.Add("@rc_lodcilindrico", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_lodcilindrico"].Value = receita.Rc_lodcilindrico;

            //        cmd.Parameters.Add("@rc_loecilindrico", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_loecilindrico"].Value = receita.Rc_loecilindrico;

            //        cmd.Parameters.Add("@rc_podcilindrico", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_podcilindrico"].Value = receita.Rc_podcilindrico;

            //        cmd.Parameters.Add("@rc_poecilindrico", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_poecilindrico"].Value = receita.Rc_poecilindrico;

            //        cmd.Parameters.Add("@rc_lodeixo", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_lodeixo"].Value = receita.Rc_lodeixo;

            //        cmd.Parameters.Add("@rc_loeeixo", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_loeeixo"].Value = receita.Rc_loeeixo;

            //        cmd.Parameters.Add("@rc_podeixo", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_podeixo"].Value = receita.Rc_podeixo;

            //        cmd.Parameters.Add("@rc_poeeixo", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_poeeixo"].Value = receita.Rc_poeeixo;

            //        cmd.Parameters.Add("@rc_lodaltura", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_lodaltura"].Value = receita.Rc_lodaltura;

            //        cmd.Parameters.Add("@rc_loealtura", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_loealtura"].Value = receita.Rc_loealtura;

            //        cmd.Parameters.Add("@rc_podaltura", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_podaltura"].Value = receita.Rc_podaltura;

            //        cmd.Parameters.Add("@rc_poealtura", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_poealtura"].Value = receita.Rc_poealtura;

            //        cmd.Parameters.Add("@rc_loddnp", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_loddnp"].Value = receita.Rc_loddnp;

            //        cmd.Parameters.Add("@rc_loednp", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_loednp"].Value = receita.Rc_loednp;

            //        cmd.Parameters.Add("@rc_poddnp", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_poddnp"].Value = receita.Rc_poddnp;

            //        cmd.Parameters.Add("@rc_poednp", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_poednp"].Value = receita.Rc_poednp;

            //        cmd.Parameters.Add("@rc_adicao", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_adicao"].Value = receita.Rc_adicao;

            //        cmd.Parameters.Add("@rc_nomemedico", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_nomemedico"].Value = receita.Rc_nomemedico;

            //        cmd.Parameters.Add("@rc_observacoes", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_observacoes"].Value = receita.Rc_observacoes;

            //        cmd.Parameters.Add("@rc_data", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_data"].Value = receita.Rc_data;

            //        cmd.Parameters.Add("@rc_dtavalidade", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_dtavalidade"].Value = receita.Rc_dtavalidade;

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

            //public void update(Receita receita)
            //{
            //    try
            //    {
            //        //abrir a conexão
            //        this.Conecta();
            //        string sql = "UPDATE receita SET (rc_historico = @rc_historico, rc_lodesferico = @rc_lodesferico, rc_loeesferico = @rc_loeesferico,rc_podesferico = @rc_podesferico, rc_poeesferico = @rc_poeesferico,rc_lodcilindrico = @rc_lodcilindrico,rc_loecilindrico = @rc_loecilindrico, rc_podcilindrico = @rc_podcilindrico ,rc_poecilindrico = @rc_poecilindrico,rc_lodeixo = @rc_lodeixo,rc_loeeixo = @rc_loeeixo,rc_podeixo = @rc_podeixo,rc_poeeixo = @rc_poeeixo,rc_lodaltura = @rc_lodaltura,rc_loealtura = @rc_loealtura,rc_podaltura = @rc_podaltura,rc_poealtura = @rc_poealtura,rc_loddnp = @rc_loddnp,rc_loednp = @rc_loednp, rc_poddnp = @rc_poddnp,rc_poednp = @rc_poednp,rc_adicao = @rc_adicao,rc_nomemedico = @c_nomemedico,rc_observacoes = @rc_observacoes,rc_data = @rc_data,rc_dtavalidade = @rc_dtavalidade ) WHERE rc_id = @rc_id;";
            //        //instrucao a ser executada
            //        SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

            //        cmd.Parameters.Add("@rc_id", SqlDbType.Int);
            //        cmd.Parameters["@rc_id"].Value = receita.Rc_id;

            //        cmd.Parameters.Add("@rc_historico", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_historico"].Value = receita.Rc_historico;

            //        cmd.Parameters.Add("@rc_lodesferico", SqlDbType.Date);
            //        cmd.Parameters["@rc_lodesferico"].Value = receita.Rc_lodesferico;

            //        cmd.Parameters.Add("@rc_loeesferico", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_loeesferico"].Value = receita.Rc_loeesferico;

            //        cmd.Parameters.Add("@rc_podesferico", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_podesferico"].Value = receita.Rc_podesferico;

            //        cmd.Parameters.Add("@rc_poeesferico", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_poeesferico"].Value = receita.Rc_poeesferico;

            //        cmd.Parameters.Add("@rc_lodcilindrico", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_lodcilindrico"].Value = receita.Rc_lodcilindrico;

            //        cmd.Parameters.Add("@rc_loecilindrico", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_loecilindrico"].Value = receita.Rc_loecilindrico;

            //        cmd.Parameters.Add("@rc_podcilindrico", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_podcilindrico"].Value = receita.Rc_podcilindrico;

            //        cmd.Parameters.Add("@rc_poecilindrico", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_poecilindrico"].Value = receita.Rc_poecilindrico;

            //        cmd.Parameters.Add("@rc_lodeixo", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_lodeixo"].Value = receita.Rc_lodeixo;

            //        cmd.Parameters.Add("@rc_loeeixo", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_loeeixo"].Value = receita.Rc_loeeixo;

            //        cmd.Parameters.Add("@rc_podeixo", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_podeixo"].Value = receita.Rc_podeixo;

            //        cmd.Parameters.Add("@rc_poeeixo", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_poeeixo"].Value = receita.Rc_poeeixo;

            //        cmd.Parameters.Add("@rc_lodaltura", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_lodaltura"].Value = receita.Rc_lodaltura;

            //        cmd.Parameters.Add("@rc_loealtura", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_loealtura"].Value = receita.Rc_loealtura;

            //        cmd.Parameters.Add("@rc_podaltura", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_podaltura"].Value = receita.Rc_podaltura;

            //        cmd.Parameters.Add("@rc_poealtura", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_poealtura"].Value = receita.Rc_poealtura;

            //        cmd.Parameters.Add("@rc_loddnp", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_loddnp"].Value = receita.Rc_loddnp;

            //        cmd.Parameters.Add("@rc_loednp", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_loednp"].Value = receita.Rc_loednp;

            //        cmd.Parameters.Add("@rc_poddnp", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_poddnp"].Value = receita.Rc_poddnp;

            //        cmd.Parameters.Add("@rc_poednp", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_poednp"].Value = receita.Rc_poednp;

            //        cmd.Parameters.Add("@rc_adicao", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_adicao"].Value = receita.Rc_adicao;

            //        cmd.Parameters.Add("@rc_nomemedico", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_nomemedico"].Value = receita.Rc_nomemedico;

            //        cmd.Parameters.Add("@rc_observacoes", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_observacoes"].Value = receita.Rc_observacoes;

            //        cmd.Parameters.Add("@rc_data", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_data"].Value = receita.Rc_data;

            //        cmd.Parameters.Add("@rc_dtavalidade", SqlDbType.VarChar);
            //        cmd.Parameters["@rc_dtavalidade"].Value = receita.Rc_dtavalidade;

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

            //public void delete(Receita receita)
            //{
            //    try
            //    {
            //        //abrir a conexão
            //        this.Conecta();
            //        string sql = "DELETE FROM receita WHERE rc_id = @rc_id";
            //        //instrucao a ser executada
            //        SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
            //        cmd.Parameters.Add("@rc_id", SqlDbType.Int);
            //        cmd.Parameters["@rc_id"].Value = receita.Rc_id;
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

            //public bool verificaduplicidade(Receita receita)
            //{
            //    bool retorno = false;
            //    try
            //    {
            //        this.Conecta();
            //        //instrucao a ser executada
            //        string sql = "select * from receita where rc_id = @rc_id";
            //        SqlCommand cmd = new SqlCommand(sql, sqlConn);
            //        cmd.Parameters.Add("@rc_id", SqlDbType.Int);
            //        cmd.Parameters["@rc_id"].Value = receita.Rc_id;
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
            //        throw new Exception("erro ao conecar e selecionar " + ex.Message);
            //    }
            //    return retorno;
            //}

            //public List<Receita> select(Receita filtro)
            //{
            //    List<Receita> retorno = new List<Receita>();
            //    try
            //    {
            //        this.Conecta();
            //        //instrucao a ser executada
            //        string sql = "select * from receita where rc_id = @rc_id";
            //        //se foi passada uma matricula válida, esta matricula entrará como critério de filtro
            //        if (filtro.Rc_id > 0)
            //        {
            //            sql += " and  rc_id = @rc_id";
            //        }
            //        //se foi passada uma data válido, esta data entrará como critério de filtro
            //        if (filtro.Rc_data != null && filtro.Rc_id.Equals("") == false)
            //        {
            //            sql += " and nome like '%@Rc_data%'";
            //        }
            //        SqlCommand cmd = new SqlCommand(sql, sqlConn);

            //        //se foi passada uma matricula válida, esta matricula entrará como critério de filtro
            //        if (filtro.Rc_id > 0)
            //        {
            //            cmd.Parameters.Add("@rc_id", SqlDbType.Int);
            //            cmd.Parameters["@rc_id"].Value = filtro.Rc_id;
            //        }
            //        //se foi passada um nome válido, este nome entrará como critério de filtro
            //        if (filtro.Rc_data != null && filtro.Rc_data.Equals("") == false)
            //        {
            //            cmd.Parameters.Add("@data", SqlDbType.VarChar);
            //            cmd.Parameters["@data"].Value = filtro.Rc_data;

            //        }
            //        //executando a instrucao e colocando o resultado em um leitor
            //        SqlDataReader dbreader = cmd.ExecuteReader();
            //        //lendo o resultado da consulta
            //        while (dbreader.Read())
            //        {
            //            Receita receita = new Receita();
            //            //acessando os valores das colunas do resultado

            //            receita.Rc_id = dbreader.GetInt32(dbreader.GetOrdinal("@rc_id"));
            //            receita.Rc_historico = dbreader.GetDateTime(dbreader.GetOrdinal("@rc_historico"));
            //            receita.Rc_lodesferico = dbreader.GetDouble(dbreader.GetOrdinal("@rc_lodesferico"));
            //            receita.Rc_loeesferico = dbreader.GetDouble(dbreader.GetOrdinal("@rc_loeesferico"));
            //            receita.Rc_podesferico = dbreader.GetDouble(dbreader.GetOrdinal("@rc_podesferico"));
            //            receita.Rc_poeesferico = dbreader.GetDouble(dbreader.GetOrdinal("@rc_poeesferico"));
            //            receita.Rc_lodcilindrico = dbreader.GetDouble(dbreader.GetOrdinal("@rc_lodcilindrico"));
            //            receita.Rc_loecilindrico = dbreader.GetDouble(dbreader.GetOrdinal("@rc_loecilindrico"));
            //            receita.Rc_podcilindrico = dbreader.GetDouble(dbreader.GetOrdinal("@rc_podcilindrico"));
            //            receita.Rc_poecilindrico = dbreader.GetDouble(dbreader.GetOrdinal("@rc_poecilindrico"));
            //            receita.Rc_lodeixo = dbreader.GetDouble(dbreader.GetOrdinal("@rc_lodeixo"));
            //            receita.Rc_loeeixo = dbreader.GetDouble(dbreader.GetOrdinal("@rc_loeeixo"));
            //            receita.Rc_podeixo = dbreader.GetDouble(dbreader.GetOrdinal("@rc_podeixo"));
            //            receita.Rc_poeeixo = dbreader.GetDouble(dbreader.GetOrdinal("@rc_poeeixo"));
            //            receita.Rc_lodaltura = dbreader.GetDouble(dbreader.GetOrdinal("@rc_lodaltura"));
            //            receita.Rc_loealtura = dbreader.GetDouble(dbreader.GetOrdinal("@rc_loealtura"));
            //            receita.Rc_podaltura = dbreader.GetDouble(dbreader.GetOrdinal("@rc_podaltura"));
            //            receita.Rc_poealtura = dbreader.GetDouble(dbreader.GetOrdinal("@rc_poealtura"));
            //            receita.Rc_loddnp = dbreader.GetDouble(dbreader.GetOrdinal("@rc_loddnp"));
            //            receita.Rc_loednp = dbreader.GetDouble(dbreader.GetOrdinal("@rc_loednp"));
            //            receita.Rc_poddnp = dbreader.GetDouble(dbreader.GetOrdinal("@rc_poddnp"));
            //            receita.Rc_poednp = dbreader.GetDouble(dbreader.GetOrdinal("@rc_poednp"));
            //            receita.Rc_adicao = dbreader.GetDouble(dbreader.GetOrdinal("@rc_adicao"));
            //            receita.Rc_nomemedico = dbreader.GetString(dbreader.GetOrdinal("@rc_nomemedico"));
            //            receita.Rc_observacoes = dbreader.GetString(dbreader.GetOrdinal("@rc_observacoes"));
            //            receita.Rc_data = dbreader.GetDateTime(dbreader.GetOrdinal("@rc_data"));
            //            receita.Rc_dtavalidade = dbreader.GetDateTime(dbreader.GetOrdinal("@rc_dtavalidade"));

            //            retorno.Add(receita);
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
