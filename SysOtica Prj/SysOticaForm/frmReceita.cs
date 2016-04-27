using SysOtica;
using SysOtica.Negocio;
using SysOtica.Negocio.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysOticaForm
{
    public partial class frmReceita : Form
    {
        //public frmReceita()
        //{
        //    InitializeComponent();
        //}

        //private void btnCancelar_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void btnSalvar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        Receita receita = new Receita();
        //        {
        //            receita.Rc_lodesferico = Convert.ToDouble(txtLongeODesferico.Text);
        //            receita.Rc_loeesferico = Convert.ToDouble(txtLongeOEesferico.Text);
        //            receita.Rc_podesferico = Convert.ToDouble(txtPertoODesferico.Text);
        //            receita.Rc_poeesferico = Convert.ToDouble(txtPertoOEesferico.Text);
        //            receita.Rc_lodcilindrico = Convert.ToDouble(txtLongeODcilindrico.Text);
        //            receita.Rc_loecilindrico = Convert.ToDouble(txtLongeOEcilindrico.Text);
        //            receita.Rc_podcilindrico = Convert.ToDouble(txtPertoODcilindrico.Text);
        //            receita.Rc_poecilindrico = Convert.ToDouble(txtPertoOEcilindrico.Text);
        //            receita.Rc_lodeixo = Convert.ToDouble(txtLongeODeixo.Text);
        //            receita.Rc_loeeixo = Convert.ToDouble(txtLongeOEeixo.Text);
        //            receita.Rc_podeixo = Convert.ToDouble(txtPertoODeixo.Text);
        //            receita.Rc_poeeixo = Convert.ToDouble(txtPertoOEeixo.Text);
        //            receita.Rc_lodaltura = Convert.ToDouble(txtLongeODaltura.Text);
        //            receita.Rc_loealtura = Convert.ToDouble(txtLongeOEaltura.Text);
        //            receita.Rc_podaltura = Convert.ToDouble(txtPertoODaltura.Text);
        //            receita.Rc_poealtura = Convert.ToDouble(txtPertoOEaltura.Text);
        //            receita.Rc_loddnp = Convert.ToDouble(txtLongeODdnp.Text);
        //            receita.Rc_loednp = Convert.ToDouble(txtLongeOEdnp.Text);
        //            receita.Rc_poddnp = Convert.ToDouble(txtPertoODdnp.Text);
        //            receita.Rc_poednp = Convert.ToDouble(txtPertoOEdnp.Text);
        //            receita.Rc_data = DateTime.Parse(maskedTextData.Text);
        //            receita.Rc_adicao = Convert.ToDouble(textAdicao.Text);
        //            receita.Rc_nomemedico = textNomeMedico.Text.Trim();
        //            receita.Rc_observacoes = textObs.Text.Trim();

        //            string data = dateTimePickerValidade.Value.ToShortDateString();
        //            receita.Rc_dtavalidade = Convert.ToDateTime(data);

        //            Fachada fachada = new Fachada();
        //            fachada.InserirReceita(receita);
        //            MessageBox.Show("Receita cadastra com sucesso.");
        //            LimparCampos();

        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro ao conectar com o banco" + ex.Message);
        //    }


        //}

        //public void LimparCampos()
        //{
        //    txtLongeODesferico.Text = "";
        //    DateTime.Parse(maskedTextData.Text).Equals("");
        //    txtLongeOEesferico.Text = "";
        //    txtPertoODesferico.Text = "";
        //    txtPertoOEesferico.Text = "";
        //    txtLongeODcilindrico.Text = "";
        //    txtLongeOEcilindrico.Text = "";
        //    txtPertoODcilindrico.Text = "";
        //    txtPertoOEcilindrico.Text = "";
        //    txtLongeODeixo.Text = "";
        //    txtLongeOEeixo.Text = "";
        //    txtPertoODeixo.Text = "";
        //    txtPertoOEeixo.Text = "";
        //    txtLongeODaltura.Text = "";
        //    txtLongeOEaltura.Text = "";
        //    txtPertoODaltura.Text = "";
        //    txtPertoOEaltura.Text = "";
        //    txtLongeODdnp.Text = "";
        //    txtLongeOEdnp.Text = "";
        //    txtPertoODdnp.Text = "";
        //    txtPertoOEdnp.Text = "";
        //    textAdicao.Text = "";
        //    textNomeMedico.Text = "";
        //    textObs.Text = "";
            
        //}


    }

}
