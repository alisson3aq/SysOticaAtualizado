using SysOtica.Negocio.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexao
{
    public interface IFornecedorDados
    {
        void Insert(Fornecedor fornecedor);
        void update(Fornecedor fornecedor);
        void delete(Fornecedor fornecedor);
        bool verificaduplicidade(Fornecedor fornecedor);
        List<Cliente> select(Fornecedor filtro);
        List<Fornecedor> pegaFornenedor();
    }
}
