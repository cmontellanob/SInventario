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
    public partial class frmUnidades : Form
    {
       
        public frmUnidades()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

          if  ( Bd.getInstancia().insertarUnidadMedida(txtNombre.Text,txtAbreviacion.Text))
            {
                MessageBox.Show("Se inserto con exito");
            }

        }
    }
}
