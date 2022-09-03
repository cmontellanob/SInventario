using Microsoft.VisualBasic.ApplicationServices;
using SInventario.modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SInventario
{
    public class Bd
    {
        private String CadenaConexion="";


        private static Bd instancia;
        private Bd()
        {
            String Servidor = ".";
            String BaseDatos = "bd_inventario";
            String Usuario = "sa";
            String Password = "Univalle123$";
            
          this.CadenaConexion=
                "Data Source =" + Servidor
                + "; Initial Catalog =" + BaseDatos
                + "; User ID=" + Usuario
                + "; Password=" + Password
                ;
        }

        public static Bd getInstancia()
        {
            if (instancia == null)
            {
                instancia = new Bd();
            }
            return instancia;
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

      public Boolean insertarProducto(String nombre,Double precio,int idunidad)
        {
            SqlConnection conexion = conectarse();
            String sql = "INSERT INTO Productos (nombre,precio,idunidad) values ('"+nombre+"',"+precio.ToString()
                +","+idunidad.ToString()+")";
            try
            {
                SqlCommand comando = new SqlCommand(sql, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public Boolean eliminarProducto(int idproducto)
        {
            SqlConnection conexion = conectarse();
            String sql = "DELETE FROM Productos WHERE id="+idproducto.ToString();
            try
            {
                SqlCommand comando = new SqlCommand(sql, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public Boolean actualizarProducto(String nombre, Double precio, int idunidad,int idproducto)
        {
            SqlConnection conexion = conectarse();
            String sql = "UPDATE Productos SET nombre='" + nombre + "',precio=" + precio.ToString() + ",idunidad=" + idunidad.ToString() + " WHERE id="+idproducto.ToString(); 
            try
            {
                SqlCommand comando = new SqlCommand(sql, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public Boolean insertarUnidadMedida(string nombre, string abreviacion)
        {
            SqlConnection conexion = conectarse();
            string sql = "INSERT INTO unidades (nombre,abreviacion) values ('" + nombre + "','" + abreviacion +"' )";
                
            try
            {
                SqlCommand comando = new SqlCommand(sql, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<UnidadMedida> listarUnidadesMedida()
        {
            SqlConnection conexion = conectarse();
            string sql = "SELECT id,nombre,abreviacion from unidades ";
            List<UnidadMedida> lista = new List<UnidadMedida>();
            try
            {
                SqlCommand comando = new SqlCommand(sql, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    UnidadMedida unidad= new UnidadMedida(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));

                    
                    lista.Add(unidad);
                }

                
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }



    }
}
