using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SInventario
{
    public partial class frmListaUnidades : Form
    {
        public frmListaUnidades()
        {
            InitializeComponent();
            dgvUnidades.DataSource = Bd.getInstancia().listarUnidadesMedida();
        }

        private void frmListaUnidades_Load(object sender, EventArgs e)
        {

        }

        private void dgvUnidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUnidades funidades = new frmUnidades();
            funidades.Show();
           
        }

        private void frmListaUnidades_Activated(object sender, EventArgs e)
        {
            dgvUnidades.DataSource = Bd.getInstancia().listarUnidadesMedida();
        }
    }
}
