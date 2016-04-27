using SysOtica.Conexao;
using SysOtica.Negocio.Classes_Basicas;
using SysOtica.Negocio.Regras_de_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Fachada
{


 
 
    public class Fachada : IFachada
    {

        # region Cliente
        ClienteDados dao = new ClienteDados();
        ClienteControlador contr = new ClienteControlador();
        
        public void alterarCliente(Cliente c)
        {
            contr.ValidarCamposVazios(c);
            dao.alterarCliente(c);
        }

        public void inserirCliente(Cliente c)
        {
            contr.ValidarCamposVazios(c);
            dao.inserirCliente(c);
        }

        public void  excluirCliente(Cliente c)
        {
            contr.ValidarCamposVazios(c);
            dao.excluirCliente(c);
        }

        public List<Cliente> pesquisarCliente(string cl_nome)
        {
            return dao.pesquisarCliente(cl_nome);
        }

        public List<Cliente> listarCliente()
        {
            return dao.listarCliente();
        }
        #endregion


        #region Fornecedor 

        
        FornecedoresDados frdao = new FornecedoresDados();
        FornecedorControlador fornColtrol = new FornecedorControlador();

        public void InserirFornecedor(Fornecedor fr)
        {
            fornColtrol.VerificaPreenchimento(fr);
            frdao.inserirFornecedor(fr);

        }

        public void AlterarFornecedor(Fornecedor fr)
        {

            fornColtrol.VerificaPreenchimento(fr);
            frdao.alteraFornecedor(fr);
        }


        public void excluirFornecedor(Fornecedor fr)
        {
            frdao.excluiFornecedor(fr);

        }

        public List<Fornecedor> pesquisaFornecedor(string fr_razaosocial)
        {
            return frdao.pesquisarFornecedor(fr_razaosocial);

        }

        public List<Fornecedor> ListaFornecedor()
        {
           return frdao.listaFornecedor();

        }
        #endregion



    }
}
