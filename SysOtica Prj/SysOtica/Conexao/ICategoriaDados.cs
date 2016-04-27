using SysOtica.Negocio.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexao
{
    interface ICategoriaDados
    {
        void Insert(Categoria categoria);
        void update(Categoria categoria);
        void delete(Categoria categoria);
        bool verificaduplicidade(Categoria categoria);
        List<Categoria> select(Categoria filtro);
    }
}
