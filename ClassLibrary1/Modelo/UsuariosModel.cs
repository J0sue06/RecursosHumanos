using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ClassLibrary1.Conexion;

namespace ClassLibrary1.Modelo
{
    public class UsuariosModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string Consultar { get; set; }
        public string Registrar { get; set; }
        public string Modificar { get; set; }
        public string Eliminar { get; set; }
        public string Administrador { get; set; }

        public int Resultado { get; set; }

        public SqlConnection con = new BasedeDatos().conectar();

        public string InsertarUsuario()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_insertarUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@nombre", Nombre));
                cmd.Parameters.Add(new SqlParameter("@apellido", Apellido));
                cmd.Parameters.Add(new SqlParameter("@cedula", Cedula));
                cmd.Parameters.Add(new SqlParameter("@usuario", Usuario));
                cmd.Parameters.Add(new SqlParameter("@clave", Clave));
                cmd.Parameters.Add(new SqlParameter("@consultar", Consultar));
                cmd.Parameters.Add(new SqlParameter("@registrar", Registrar));
                cmd.Parameters.Add(new SqlParameter("@modificar", Modificar));
                cmd.Parameters.Add(new SqlParameter("@eliminar", Eliminar));
                cmd.Parameters.Add(new SqlParameter("@admin", Administrador));

                con.Close();
                con.Open();

                cmd.ExecuteNonQuery();

                return "OK";
              
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error Usuarios " + ex);
                con.Close();
                return "False";
            }


        }

        public string ActualizarUsuario()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_actualizarUsuarios", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@id_usuario", Id));
                cmd.Parameters.Add(new SqlParameter("@nombre", Nombre));
                cmd.Parameters.Add(new SqlParameter("@apellido", Apellido));
                cmd.Parameters.Add(new SqlParameter("@cedula", Cedula));
                cmd.Parameters.Add(new SqlParameter("@usuario", Usuario));
                cmd.Parameters.Add(new SqlParameter("@clave", Clave));
                cmd.Parameters.Add(new SqlParameter("@consultar", Consultar));
                cmd.Parameters.Add(new SqlParameter("@registrar", Registrar));
                cmd.Parameters.Add(new SqlParameter("@modificar", Modificar));
                cmd.Parameters.Add(new SqlParameter("@eliminar", Eliminar));
                cmd.Parameters.Add(new SqlParameter("@admin", Eliminar));

                con.Close();
                con.Open();

                cmd.ExecuteNonQuery();

                return "OK";

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error Usuarios " + ex);
                con.Close();
                return "False";
            }


        }

        public DataTable CargarLista(string Filtro)
        {   
            DataTable dt = new DataTable();

            if (string.IsNullOrEmpty(Filtro))
            {
                SqlCommand cmd = new SqlCommand("SP_listaUsuarios", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            else if (!string.IsNullOrEmpty(Filtro))
            {
                SqlCommand cmd = new SqlCommand("SP_FiltroUsuarios", con);
                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.Add(new SqlParameter("@cedula", Cedula));
                cmd.Parameters.AddWithValue("@filtro", "%" + Filtro + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }
    }
}
