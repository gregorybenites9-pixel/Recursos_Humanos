using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Menu_General1.Datos;

namespace Menu_General1.Datos
{
    public class EmpleadoDAL
    {
        Conexion cn = new Conexion();

        public DataTable ListarEmpleados()
        {
            using (SqlConnection con = cn.GetConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vw_Empleados", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable ListarTipoDocumento()
        {
            using (SqlConnection con = cn.GetConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT IdTipo_Documento, Nombre_Tipo_Doc FROM tipo_documento", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable ListarGenero()
        {
            using (SqlConnection con = cn.GetConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT IdGenero, Nombre_Genero FROM genero", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable ListarProfesiones()
        {
            using (SqlConnection con = cn.GetConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT IdProfesion, Nombre_Profesion FROM profesion", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable ListarDistritos()
        {
            using (SqlConnection con = cn.GetConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT IdDistrito, Nombre_Distrito FROM distrito", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable BuscarEmpleado(string texto)
        {
            using (SqlConnection con = cn.GetConexion())
            {
                SqlCommand cmd = new SqlCommand("SOFBE_BuscarEmpleado", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TextoBusqueda", texto);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public string InsertarEmpleado(Empleado e)
        {
            using (SqlConnection con = cn.GetConexion())
            {
                SqlCommand cmd = new SqlCommand("SOFBE_InsertarEmpleado", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdTipo_Documento", e.IdTipoDocumento);
                cmd.Parameters.AddWithValue("@Numero_Documento", e.NumeroDocumento);
                cmd.Parameters.AddWithValue("@Nombres", e.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", e.Apellidos);
                cmd.Parameters.AddWithValue("@IdGenero", e.IdGenero);
                cmd.Parameters.AddWithValue("@IdProfesion", e.IdProfesion);
                cmd.Parameters.AddWithValue("@IdDistrito", e.IdDistrito);
                cmd.Parameters.AddWithValue("@Fecha_Nacimiento", e.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Fecha_Ingreso", e.FechaIngreso);
                cmd.Parameters.AddWithValue("@Direccion_Actual", (object)e.DireccionActual ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefono1", (object)e.Telefono1 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefono2", (object)e.Telefono2 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Correo1", e.Correo1);
                cmd.Parameters.AddWithValue("@Correo2", (object)e.Correo2 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Observaciones", (object)e.Observaciones ?? DBNull.Value);

                con.Open();
                return cmd.ExecuteScalar()?.ToString();
            }
        }

        public string ModificarEmpleado(Empleado e)
        {
            using (SqlConnection con = cn.GetConexion())
            {
                SqlCommand cmd = new SqlCommand("SOFBE_ModificarEmpleado", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdEmpleado", e.IdEmpleado);
                cmd.Parameters.AddWithValue("@IdTipo_Documento", e.IdTipoDocumento);
                cmd.Parameters.AddWithValue("@Numero_Documento", e.NumeroDocumento);
                cmd.Parameters.AddWithValue("@Nombres", e.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", e.Apellidos);
                cmd.Parameters.AddWithValue("@IdGenero", e.IdGenero);
                cmd.Parameters.AddWithValue("@IdProfesion", e.IdProfesion);
                cmd.Parameters.AddWithValue("@IdDistrito", e.IdDistrito);
                cmd.Parameters.AddWithValue("@Fecha_Nacimiento", e.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Fecha_Ingreso", e.FechaIngreso);
                cmd.Parameters.AddWithValue("@Direccion_Actual", (object)e.DireccionActual ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefono1", (object)e.Telefono1 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefono2", (object)e.Telefono2 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Correo1", e.Correo1);
                cmd.Parameters.AddWithValue("@Correo2", (object)e.Correo2 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Observaciones", (object)e.Observaciones ?? DBNull.Value);

                con.Open();
                return cmd.ExecuteScalar()?.ToString();
            }
        }

        public string EliminarEmpleado(int id)
        {
            using (SqlConnection con = cn.GetConexion())
            {
                SqlCommand cmd = new SqlCommand("SOFBE_EliminarEmpleado", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdEmpleado", id);

                con.Open();
                return cmd.ExecuteScalar()?.ToString();
            }
        }
    }
}
