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
    public partial class frmListarProduto : Form
    {
        public frmListarProduto()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sysOticaDataSet);

        }

        private void frmListarProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sysOticaDataSet.produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.sysOticaDataSet.produto);

        }
    }
}
