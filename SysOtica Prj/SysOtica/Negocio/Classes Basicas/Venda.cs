using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Classes_Basicas
{
    public class Venda
    {
        private int vn_id;
        private Cliente cl_id;
        private Usuario usuario;
        private List<Receita> receita;
        private ProdutoVenda pv_id;

        public Venda(int vn_id, Cliente cl_id, Usuario usuario, List<Receita> receita, ProdutoVenda pv_id)
        {
            this.vn_id = vn_id;
            this.cl_id = new Cliente();
            this.usuario = new Usuario();
            this.receita = receita;
            this.pv_id = pv_id;
        }

        public int Vn_id
        {
            get
            {
                return vn_id;
            }

            set
            {
                vn_id = value;
            }
        }

        public Cliente Cl_id
        {
            get
            {
                return cl_id;
            }

            set
            {
                cl_id = value;
            }
        }

        public Usuario Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public List<Receita> Receita
        {
            get
            {
                return receita;
            }

            set
            {
                receita = value;
            }
        }

        public ProdutoVenda Pv_id
        {
            get
            {
                return pv_id;
            }

            set
            {
                pv_id = value;
            }
        }
    }
}
