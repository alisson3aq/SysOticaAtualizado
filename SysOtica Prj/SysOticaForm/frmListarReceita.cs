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
    public partial class frmListarReceita : Form
    {
        public frmListarReceita()
        {
            InitializeComponent();
        }

        private void receitaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.receitaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sysOticaDataSet);

        }

        private void frmListarReceita_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sysOticaDataSet.receita' table. You can move, or remove it, as needed.
            this.receitaTableAdapter.Fill(this.sysOticaDataSet.receita);

        }
    }
}
