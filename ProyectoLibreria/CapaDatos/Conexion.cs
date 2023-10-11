using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaDatos
{
    public class Conexion
    {
        
        
            SqlConnection miConexion = new SqlConnection(); 
            SqlCommand miComando = new SqlCommand(); 
            SqlDataAdapter miAdaptador = new SqlDataAdapter(); 
            DataSet miDs = new DataSet(); 

            public Conexion()
            {
                String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Libreria.mdf;Integrated Security=True";
                miConexion.ConnectionString = cadenaConexion;
                miConexion.Open();
            }
        public DataSet obtenerDatos()
        {
            miDs.Clear();
            miComando.Connection = miConexion;

            miComando.CommandText = "select * from Proveedor";
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(miDs, "Proveedor");

            return miDs;
        }

        public String mantenimientoProveedor(String[] Proveedor)
        {
            String sql = "";
            if (Proveedor[0] == "nuevo")
            {
                sql = "INSERT INTO Proveedor (NombreProveedor, Telefono, Direccion, Email) VALUES('" + Proveedor[1] + "', '" + Proveedor[2] + "', '" +
                    Proveedor[3] + "', '" + Proveedor[4] + "')";
            }
            else if (Proveedor[0] == "modificar")
            {
                sql = "UPDATE Proveedor SET NombreProveedor='" + Proveedor[1] + "', Telefono='" + Proveedor[2] + "', Direccion='" + Proveedor[3] + "', Email='" + Proveedor[4] +
                    "' WHERE IdProveedor='" + Proveedor[5] + "'";
            }
            else if (Proveedor[0] == "eliminar")
            {
                sql = "DELETE FROM Proveedor WHERE IdProveedor='" + Proveedor[5] + "'";
            }
            return ejecutarSql(sql);
        }
        private string ejecutarSql(String sql)
        {
            try
            {
                miComando.CommandText = sql;
                miComando.Connection = miConexion;
                return miComando.ExecuteNonQuery().ToString();
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public static string cadena = ConfigurationManager.ConnectionStrings["cadenaConexion"].ToString();
    }

}
