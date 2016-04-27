using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Classes_Basicas
{
    public class ProdutoFornecedor
    {
        private int pf_id;
        private int pf_qtd;
        private DateTime pf_dtentrada;
        //private Fornecedor fr_id;
        private string pf_tipo;
        private string pf_observacoes;
       // private int fr_id;
        //private int pr_id;
        private List<Produto> pr_id;
        private List<Fornecedor> fr_id;

        public ProdutoFornecedor(int pf_id, int pf_qtd, DateTime pf_dtentrada, string pf_tipo, string pf_observacoes, List<Produto> pr_id, List<Fornecedor> fr_id)
        {
            this.pf_id = pf_id;
            this.pf_qtd = pf_qtd;
            this.pf_dtentrada = pf_dtentrada;         
            this.pf_tipo = pf_tipo;
            this.pf_observacoes = pf_observacoes;
            this.Pr_id = new List<Produto>();
            this.Fr_id = new List<Fornecedor>();
        }

        public ProdutoFornecedor()
        {
        }

        public int Pf_id
        {
            get
            {
                return pf_id;
            }

            set
            {
                pf_id = value;
            }
        }

        public int Pf_qtd
        {
            get
            {
                return pf_qtd;
            }

            set
            {
                pf_qtd = value;
            }
        }

        public DateTime Pf_dtentrada
        {
            get
            {
                return pf_dtentrada;
            }

            set
            {
                pf_dtentrada = value;
            }
        }


        public string Pf_tipo
        {
            get
            {
                return pf_tipo;
            }

            set
            {
                pf_tipo = value;
            }
        }

        public string Pf_observacoes
        {
            get
            {
                return pf_observacoes;
            }

            set
            {
                pf_observacoes = value;
            }
        }

        public List<Fornecedor> Fr_id
        {
            get
            {
                return fr_id;
            }

            set
            {
                fr_id = value;
            }
        }

        public List<Produto> Pr_id
        {
            get
            {
                return pr_id;
            }

            set
            {
                pr_id = value;
            }
        }
    }
}
