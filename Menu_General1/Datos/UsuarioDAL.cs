using Menu_General1.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_General1.Datos
{
    internal class UsuarioDAL
    {
        Conexion cn = new Conexion();

        public DataTable ValidarUsuario(string username, string password)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = cn.GetConexion())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(
                        @"SELECT u.IdUsuario, u.Username, r.Nombre_Rol 
                          FROM usuario u 
                          INNER JOIN rol r ON u.IdRol = r.IdRol
                          WHERE u.Username = @user 
                          AND u.Password = @pass 
                          AND u.Estado = 1", con);

                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            if (dt.Rows.Count > 0)
            {
                UsuarioSesion.IdUsuario = Convert.ToInt32(dt.Rows[0]["IdUsuario"]);
                UsuarioSesion.Username = dt.Rows[0]["Username"].ToString();
                UsuarioSesion.NombreRol = dt.Rows[0]["Nombre_Rol"].ToString();
            }
            return dt;
        }
    }
}
