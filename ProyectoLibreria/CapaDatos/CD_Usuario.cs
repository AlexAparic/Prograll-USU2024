using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<Usuarios> Listar()
        {
            List<Usuarios> lista = new List<Usuarios>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                try
                {
                    string query = "select IdUsuario, NombreCompleto, Usuario, Password from Usuario";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuarios()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Usuario = dr["Usuario"].ToString(),
                                Password = dr["Password"].ToString()
                            });
                        }
                    }


                }
                catch (Exception e)
                {

                    lista = new List<Usuarios>();

                }

            return lista;

        }
    }
}
