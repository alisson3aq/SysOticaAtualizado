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
    public partial class frmListaFornecedor : Form
    {
        public frmListaFornecedor()
        {
            InitializeComponent();
        }

        private void fornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sysOticaDataSet);

        }

        private void frmListaFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sysOticaDataSet.fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.sysOticaDataSet.fornecedor);

        }
    }
}
