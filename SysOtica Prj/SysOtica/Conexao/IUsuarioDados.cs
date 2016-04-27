using SysOtica.Negocio.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexao
{
    interface IUsuarioDados
    {
        void Insert(Usuario usuario);
        void update(Usuario usuario);
        void delete(Usuario usuario);
        bool verificaduplicidade(Usuario usuario);
        List<Cliente> select(Usuario filtro);
    }
}
