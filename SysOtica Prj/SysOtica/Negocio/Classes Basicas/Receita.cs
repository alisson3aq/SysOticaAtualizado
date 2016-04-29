using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOtica.Negocio.Classes_Basicas
{
    public class Receita
    {
        private int rc_id;
        private DateTime rc_historico;
        private decimal rc_lodesferico;
        private decimal rc_loeesferico;
        private decimal rc_podesferico;
        private decimal rc_poeesferico;
        private decimal rc_lodcilindrico;
        private decimal rc_loecilindrico;
        private decimal rc_podcilindrico;
        private decimal rc_poecilindrico;
        private decimal rc_lodeixo;
        private decimal rc_loeeixo;
        private decimal rc_podeixo;
        private decimal rc_poeeixo;
        private decimal rc_lodaltura;
        private decimal rc_loealtura;
        private decimal rc_podaltura;
        private decimal rc_poealtura;
        private decimal rc_loddnp;
        private decimal rc_loednp;
        private decimal rc_poddnp;
        private decimal rc_poednp;
        private decimal rc_adicao;
        private String rc_nomemedico;
        private String rc_observacoes;
        private DateTime rc_data;
        private DateTime rc_dtavalidade;
        private List<Cliente> cl_id;
        private List<Venda> vn_id;


        public Receita(int rc_id, DateTime rc_historico, decimal rc_lodesferico, decimal rc_loeesferico, decimal rc_podesferico, decimal rc_poeesferico, decimal rc_lodcilindrico, decimal rc_loecilindrico, decimal rc_podcilindrico, decimal rc_poecilindrico, decimal rc_lodeixo, decimal rc_loeeixo, decimal rc_podeixo, decimal rc_poeeixo, decimal rc_lodaltura, decimal rc_loealtura, decimal rc_podaltura, decimal rc_poealtura, decimal rc_loddnp, decimal rc_loednp, decimal rc_poddnp, decimal rc_poednp, decimal rc_adicao, String rc_nomemedico, string rc_observacoes, DateTime rc_data, DateTime rc_dtavalidade, List<Cliente> cl_id, List<Venda> vn_id)
        {
            this.rc_id = rc_id;
            this.rc_historico = rc_historico;
            this.rc_lodesferico = rc_lodesferico;
            this.rc_loeesferico = rc_loeesferico;
            this.rc_podesferico = rc_podesferico;
            this.rc_poeesferico = rc_poeesferico;
            this.rc_lodcilindrico = rc_lodcilindrico;
            this.rc_loecilindrico = rc_loecilindrico;
            this.rc_podcilindrico = rc_podcilindrico;
            this.rc_poecilindrico = rc_poecilindrico;
            this.rc_lodeixo = rc_lodeixo;
            this.rc_loeeixo = rc_loeeixo;
            this.rc_podeixo = rc_podeixo;
            this.rc_poeeixo = rc_poeeixo;
            this.rc_lodaltura = rc_lodaltura;
            this.rc_loealtura = rc_loealtura;
            this.rc_podaltura = rc_podaltura;
            this.rc_poealtura = rc_poealtura;
            this.rc_loddnp = rc_loddnp;
            this.rc_loednp = rc_loednp;
            this.rc_poddnp = rc_poddnp;
            this.rc_poednp = rc_poednp;
            this.rc_adicao = rc_adicao;
            this.rc_nomemedico = rc_nomemedico;
            this.rc_observacoes = rc_observacoes;
            this.rc_data = rc_data;
            this.rc_dtavalidade = rc_dtavalidade;
            this.Cl_id = new List<Cliente>();
            this.Vn_id = new List<Venda>();
        }

        public Receita()
        {
        }

        public int Rc_id
        {
            get
            {
                return rc_id;
            }

            set
            {
                rc_id = value;
            }
        }

        public DateTime Rc_historico
        {
            get
            {
                return rc_historico;
            }

            set
            {
                rc_historico = value;
            }
        }

        public decimal Rc_lodesferico
        {
            get
            {
                return rc_lodesferico;
            }

            set
            {
                rc_lodesferico = value;
            }
        }

        public decimal Rc_loeesferico
        {
            get
            {
                return rc_loeesferico;
            }

            set
            {
                rc_loeesferico = value;
            }
        }

        public decimal Rc_podesferico
        {
            get
            {
                return rc_podesferico;
            }

            set
            {
                rc_podesferico = value;
            }
        }

        public decimal Rc_poeesferico
        {
            get
            {
                return rc_poeesferico;
            }

            set
            {
                rc_poeesferico = value;
            }
        }

        public decimal Rc_lodcilindrico
        {
            get
            {
                return rc_lodcilindrico;
            }

            set
            {
                rc_lodcilindrico = value;
            }
        }

        public decimal Rc_loecilindrico
        {
            get
            {
                return rc_loecilindrico;
            }

            set
            {
                rc_loecilindrico = value;
            }
        }

        public decimal Rc_podcilindrico
        {
            get
            {
                return rc_podcilindrico;
            }

            set
            {
                rc_podcilindrico = value;
            }
        }

        public decimal Rc_poecilindrico
        {
            get
            {
                return rc_poecilindrico;
            }

            set
            {
                rc_poecilindrico = value;
            }
        }

        public decimal Rc_lodeixo
        {
            get
            {
                return rc_lodeixo;
            }

            set
            {
                rc_lodeixo = value;
            }
        }

        public decimal Rc_loeeixo
        {
            get
            {
                return rc_loeeixo;
            }

            set
            {
                rc_loeeixo = value;
            }
        }

        public decimal Rc_podeixo
        {
            get
            {
                return rc_podeixo;
            }

            set
            {
                rc_podeixo = value;
            }
        }

        public decimal Rc_poeeixo
        {
            get
            {
                return rc_poeeixo;
            }

            set
            {
                rc_poeeixo = value;
            }
        }

        public decimal Rc_lodaltura
        {
            get
            {
                return rc_lodaltura;
            }

            set
            {
                rc_lodaltura = value;
            }
        }

        public decimal Rc_loealtura
        {
            get
            {
                return rc_loealtura;
            }

            set
            {
                rc_loealtura = value;
            }
        }

        public decimal Rc_podaltura
        {
            get
            {
                return rc_podaltura;
            }

            set
            {
                rc_podaltura = value;
            }
        }

        public decimal Rc_poealtura
        {
            get
            {
                return rc_poealtura;
            }

            set
            {
                rc_poealtura = value;
            }
        }

        public decimal Rc_loddnp
        {
            get
            {
                return rc_loddnp;
            }

            set
            {
                rc_loddnp = value;
            }
        }

        public decimal Rc_loednp
        {
            get
            {
                return rc_loednp;
            }

            set
            {
                rc_loednp = value;
            }
        }

        public decimal Rc_poddnp
        {
            get
            {
                return rc_poddnp;
            }

            set
            {
                rc_poddnp = value;
            }
        }

        public decimal Rc_poednp
        {
            get
            {
                return rc_poednp;
            }

            set
            {
                rc_poednp = value;
            }
        }

        public decimal Rc_adicao
        {
            get
            {
                return rc_adicao;
            }

            set
            {
                rc_adicao = value;
            }
        }

        public string Rc_nomemedico
        {
            get
            {
                return rc_nomemedico;
            }

            set
            {
                rc_nomemedico = value;
            }
        }

        public string Rc_observacoes
        {
            get
            {
                return rc_observacoes;
            }

            set
            {
                rc_observacoes = value;
            }
        }

        public DateTime Rc_data
        {
            get
            {
                return rc_data;
            }

            set
            {
                rc_data = value;
            }
        }

        public DateTime Rc_dtavalidade
        {
            get
            {
                return rc_dtavalidade;
            }

            set
            {
                rc_dtavalidade = value;
            }
        }

        public List<Cliente> Cl_id
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

        public List<Venda> Vn_id
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

    }
}
