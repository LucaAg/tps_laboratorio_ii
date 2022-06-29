using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BibliotecaIMA
{
    public static class GestorSQL
    {
        private static string cadenaConexion;

        /// <summary>
        /// Inicializa la cadenaConexion a la base de datos correspondiente.
        /// </summary>
        static GestorSQL()
        {
            GestorSQL.cadenaConexion = "Server=.;Database=IMA_SUCURSALES;Trusted_Connection=True";
        }
        /// <summary>
        /// Lee los datos de una lista de sucursales.
        /// </summary>
        /// <returns>Lista de sucursales</returns>
        public static List<Sucursales> LeerDatos()
        {
            List<Sucursales> listaSucursales = new List<Sucursales>();
            try
            {               
                string query = "SELECT * FROM sucursales order by id";
                using (SqlConnection connection = new SqlConnection(GestorSQL.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string localidad = reader.GetString(1);
                        double numeroTelefonico = reader.GetDouble(2);
                        string direccion = reader.GetString(3);
                        Sucursales sucursal = new Sucursales(id, localidad, numeroTelefonico, direccion);
                        listaSucursales.Add(sucursal);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
           
            return listaSucursales;
        }
        /// <summary>
        /// Lee los datos de una sucursal, según el id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Sucursal por id</returns>
        public static Sucursales LeerDatosPorId(this int id)
        {
            Sucursales sucursal = null;
            try
            {
                string query = "SELECT * FROM sucursales WHERE id=@id";
                using (SqlConnection connection = new SqlConnection(GestorSQL.cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("id", id);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string localidad = reader.GetString(1);
                        double numeroTelefonico = reader.GetDouble(2);
                        string direccion = reader.GetString(3);

                        sucursal = new Sucursales(id, localidad, numeroTelefonico, direccion);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }           
            return sucursal;
        }
        /// <summary>
        /// Da de alta una nueva sucursal.
        /// </summary>
        /// <param name="sucursal"></param>
        public static void Alta(Sucursales sucursal)
        {
            string query = "INSERT INTO sucursales (localidad,numeroTelefono,direccion) values (@nombreLocalidad,@numeroTelefonico,@direccion)";
            SqlConnection connection = null;
            try
            {
                using(connection = new SqlConnection(GestorSQL.cadenaConexion))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("nombreLocalidad", sucursal.Nombre);
                    cmd.Parameters.AddWithValue("numeroTelefonico", sucursal.NumeroTelefonico);
                    cmd.Parameters.AddWithValue("Direccion", sucursal.Direccion);
                    cmd.ExecuteNonQuery();
                }                
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
