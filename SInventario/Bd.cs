using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SInventario
{
    public class Bd
    {
        private String CadenaConexion="";
        public Bd(String Servidor, String BaseDatos,String Usuario,String Password)
        {
          this.CadenaConexion=
                "Data Source =" + Servidor
                + "; Initial Catalog =" + BaseDatos
                + "; User ID=" + Usuario
                + "; Password=" + Password
                ;
        }

      public SqlConnection conectarse()
        {
            try
            {
                SqlConnection connection = new SqlConnection(this.CadenaConexion);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

      public Boolean inserarProducto(String nombre,Double precio,int idunidad)
        {

            String sql = "INSERT INTO Productos (nombre,precio,idunidad) values ('"+nombre+"',"+precio.ToString()
                +","+idunidad.ToString();
            try
            {
                SqlCommand comando = new SqlCommand(sql, conectarse());
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public Boolean eliminarProducto(int idproducto)
        {
            String sql = "DELETE FROM Productos WHERE id="+idproducto.ToString();
            try
            {
                SqlCommand comando = new SqlCommand(sql, conectarse());
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public Boolean actualizrProducto(String nombre, Double precio, int idunidad,int idproducto)
        {
            String sql = "UPDATE Productos SET nombre='" + nombre + "',precio=" + precio.ToString() + ",idunidad=" + idunidad.ToString() + " WHERE id="+idproducto.ToString(); 
            try
            {
                SqlCommand comando = new SqlCommand(sql, conectarse());
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public Boolean inserarUnidadMedida(String nombre, String abreviacion)
        {

            String sql = "INSERT INTO unidades (nombre,abreviacion) values ('" + nombre + "','" + abreviacion +"' )";
                
            try
            {
                SqlCommand comando = new SqlCommand(sql, conectarse());
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }



    }
}
