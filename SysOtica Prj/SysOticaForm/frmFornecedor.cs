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
    public partial class frmFornecedor : Form
    {
        //public frmFornecedor()
        //{
        //    InitializeComponent();
        //}

        //private void buttonSalvar_Click(object sender, EventArgs e)
        //{


        //    try
        //    {
        //        Fornecedor fornecedor = new Fornecedor();
        //        {
        //            fornecedor.Fr_razaosocial = textBoxRazaosocial.Text;
        //            fornecedor.Fr_cnpj = maskedTextBoxCNPJ.Text;
        //            fornecedor.Fr_inscricaoestadual = textBoxInscEstadual.Text;
        //            fornecedor.Fr_fantasia = textBoxFantasia.Text;
        //            fornecedor.Fr_endereco = textBoxEndereco.Text;
        //            fornecedor.Fr_cidade = textBoxCidade.Text;
        //            fornecedor.Fr_uf = textBoxUF.Text;
        //            fornecedor.Fr_bairro = textBoxBairro.Text;
        //            fornecedor.Fr_cep = maskedTextBoxCEP.Text;
        //            fornecedor.Fr_contato = textBoxContato.Text;
        //            fornecedor.Fr_telefone = maskedTextBoxTelefone.Text;
        //            fornecedor.Fr_fax = textBoxFax.Text;
        //            fornecedor.Fr_email = textBoxEmail.Text;
        //            fornecedor.Fr_nomerepresentante = textBoxNomeRep.Text;
        //            fornecedor.Fr_telefonerepresentante = maskedTextBoxTelRep.Text;
        //            fornecedor.Fr_celularrepresentante = maskedTextBoxCelRep.Text;
        //            fornecedor.Fr_observacoes = richTextBoxObservacoes.Text;
        //        }
        //        Fachada fachadaFornecedor = new Fachada();
        //        fachadaFornecedor.InserirFornecedor(fornecedor);
        //        MessageBox.Show("Fornecedor cadastrado com sucesso!");
        //        LimparCampos();

                //new FornecedorDados().Inserir(fornecedor);
               
                
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show("Erro no Cadastro" + ex.Message);
        //    }
        //}

        //private void buttonLimpar_Click(object sender, EventArgs e)
        //{
        //    LimparCampos();
        //}

        //private void buttonSair_Click(object sender, EventArgs e)
        //{
        //    Dispose();
        //}

        //private void frmFornecedor_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        e.Handled = true;
        //        e.SuppressKeyPress = true;
        //        this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        //    }
        //}
        //public void LimparCampos()
        //{
        //    textBoxRazaosocial.Text = "";
        //    maskedTextBoxCNPJ.Text = "";
        //    textBoxInscEstadual.Text = "";
        //    textBoxFantasia.Text = "";
        //    textBoxEndereco.Text = "";
        //    textBoxCidade.Text = "";
        //    textBoxUF.Text = "";
        //    textBoxBairro.Text = "";
        //    maskedTextBoxCEP.Text = "";
        //    textBoxContato.Text = "";
        //    maskedTextBoxTelefone.Text = "";
        //    textBoxFax.Text = "";
        //    textBoxEmail.Text = "";
        //    textBoxNomeRep.Text = "";
        //    maskedTextBoxTelRep.Text = "";
        //    maskedTextBoxCelRep.Text = "";
        //    richTextBoxObservacoes.Text = "";
        //}
    }
}
