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
        private double rc_lodesferico;
        private double rc_loeesferico;
        private double rc_podesferico;
        private double rc_poeesferico;
        private double rc_lodcilindrico;
        private double rc_loecilindrico;
        private double rc_podcilindrico;
        private double rc_poecilindrico;
        private double rc_lodeixo;
        private double rc_loeeixo;
        private double rc_podeixo;
        private double rc_poeeixo;
        private double rc_lodaltura;
        private double rc_loealtura;
        private double rc_podaltura;
        private double rc_poealtura;
        private double rc_loddnp;
        private double rc_loednp;
        private double rc_poddnp;
        private double rc_poednp;
        private double rc_adicao;
        private String rc_nomemedico;
        private String rc_observacoes;
        private DateTime rc_data;
        private DateTime rc_dtavalidade;
        private List<Cliente> cl_id;
        private List<Venda> vn_id;


        public Receita(int rc_id, DateTime rc_historico, double rc_lodesferico, double rc_loeesferico, double rc_podesferico, double rc_poeesferico, double rc_lodcilindrico, double rc_loecilindrico, double rc_podcilindrico, double rc_poecilindrico, double rc_lodeixo, double rc_loeeixo, double rc_podeixo, double rc_poeeixo, double rc_lodaltura, double rc_loealtura, double rc_podaltura, double rc_poealtura, double rc_loddnp, double rc_loednp, double rc_poddnp, double rc_poednp, double rc_adicao, String rc_nomemedico, string rc_observacoes, DateTime rc_data, DateTime rc_dtavalidade, List<Cliente> cl_id, List<Venda> vn_id)
        {
            this.Rc_id = rc_id;
            this.Rc_historico = rc_historico;
            this.Rc_lodesferico = rc_lodesferico;
            this.Rc_loeesferico = rc_loeesferico;
            this.Rc_podesferico = rc_podesferico;
            this.Rc_poeesferico = rc_poeesferico;
            this.Rc_lodcilindrico = rc_lodcilindrico;
            this.Rc_loecilindrico = rc_loecilindrico;
            this.Rc_podcilindrico = rc_podcilindrico;
            this.Rc_poecilindrico = rc_poecilindrico;
            this.Rc_lodeixo = rc_lodeixo;
            this.Rc_loeeixo = rc_loeeixo;
            this.Rc_podeixo = rc_podeixo;
            this.Rc_poeeixo = rc_poeeixo;
            this.Rc_lodaltura = rc_lodaltura;
            this.Rc_loealtura = rc_loealtura;
            this.Rc_podaltura = rc_podaltura;
            this.Rc_poealtura = rc_poealtura;
            this.Rc_loddnp = rc_loddnp;
            this.Rc_loednp = rc_loednp;
            this.Rc_poddnp = rc_poddnp;
            this.Rc_poednp = rc_poednp;
            this.Rc_adicao = rc_adicao;
            this.Rc_nomemedico = rc_nomemedico;
            this.Rc_observacoes = rc_observacoes;
            this.Rc_data = rc_data;
            this.Rc_dtavalidade = rc_dtavalidade;
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

        public double Rc_lodesferico
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

        public double Rc_loeesferico
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

        public double Rc_podesferico
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

        public double Rc_poeesferico
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

        public double Rc_lodcilindrico
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

        public double Rc_loecilindrico
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

        public double Rc_podcilindrico
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

        public double Rc_poecilindrico
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

        public double Rc_lodeixo
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

        public double Rc_loeeixo
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

        public double Rc_podeixo
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

        public double Rc_poeeixo
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

        public double Rc_lodaltura
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

        public double Rc_loealtura
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

        public double Rc_podaltura
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

        public double Rc_poealtura
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

        public double Rc_loddnp
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

        public double Rc_loednp
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

        public double Rc_poddnp
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

        public double Rc_poednp
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

        public double Rc_adicao
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
