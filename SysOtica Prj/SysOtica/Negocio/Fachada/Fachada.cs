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
    }
}
