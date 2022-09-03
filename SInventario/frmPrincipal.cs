using System.Data.SqlClient;

namespace SInventario
{
    public partial class frmPrincipal : Form
    {
        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Nombre SErvidor BD
            string DataSource = ".";

            //nombre Base de datos
            string InitialCatalog = "bd_inventario";

            //datos de conexion
            string UserID = "sa";
            string Password = "Univalle123$";


            string connectionString = "Data Source =" + DataSource
                + "; Initial Catalog =" + InitialCatalog
                + "; User ID=" + UserID
                + "; Password=" + Password
                ;

            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                lblEstado.Text = "Nos hemos conectado a la BD" + connection.State.ToString();

                
            }
            catch (Exception ex)
            {
                lblEstado.Text ="A ocurrido un problema \n" + ex.Message;
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos fproductos = new frmProductos();
            fproductos.Show();
        }

        private void unidadesMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaUnidades flistaUnidades = new frmListaUnidades();
           
            flistaUnidades.Show();
          
        }
    }
}