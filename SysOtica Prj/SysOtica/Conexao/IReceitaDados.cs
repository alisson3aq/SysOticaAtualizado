using SysOtica.Negocio.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Conexao
{
    interface IReceitaDados
    {
        void Insert(Receita receita);
        void update(Receita receita);
        void delete(Receita receita);
        bool verificaduplicidade(Receita receita);
        List<Receita> select(Receita filtro);
    }
}
