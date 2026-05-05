using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_General1.Datos
{
    public class Conexion
    {
        private string cadena = @"Server=(localdb)\MSSQLLocalDB;Database=recursos_h;Trusted_Connection=True;";

        public SqlConnection GetConexion()
        {
            return new SqlConnection(cadena);
        }
    }
}
