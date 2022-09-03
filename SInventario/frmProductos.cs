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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();

            cbUnidades.DataSource = Bd.getInstancia().listarUnidadesMedida();
            cbUnidades.DisplayMember = "abreviatura";
            cbUnidades.ValueMember = "id";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int idunidad = (int)cbUnidades.SelectedValue;
            double precio = Double.Parse(txtPrecio.Text);
            if (Bd.getInstancia().insertarProducto(txtNombre.Text, precio, idunidad))
            {
                MessageBox.Show("Se inserto con exito");
            }
        }

        private void cbUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
