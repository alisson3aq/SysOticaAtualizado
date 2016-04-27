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
    public partial class frmListarUsuario : Form
    {
        public frmListarUsuario()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sysOticaDataSet);

        }

        private void frmListarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sysOticaDataSet.usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.sysOticaDataSet.usuario);

        }
    }
}
