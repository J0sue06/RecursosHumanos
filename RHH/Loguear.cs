using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ClassLibrary1.Conexion;
using ClassLibrary1.Modelo;

namespace RHH
{
    public class Loguear
    {       
        public int Resultado { get; set; }
        public SqlConnection con = new BasedeDatos().conectar();

        PersonaModel _personaModel = new PersonaModel();
        
        public string Acceder(string usuario, string clave)
        {
                con.Close();
                con.Open();
                SqlDataReader reader = null;

                SqlCommand cmd = new SqlCommand("SP_Login", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@usuario", usuario));
                cmd.Parameters.Add(new SqlParameter("@clave", clave));
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {                    
                    _personaModel.IdUsuario = int.Parse(reader["id_usuario"].ToString());
                    Acceso.Nombre = reader["nombre"].ToString();
                    Acceso.Apellido = reader["apellido"].ToString();
                    Acceso.Consultar = reader["consultar"].ToString();
                    Acceso.Registrar = reader["registrar"].ToString();
                    Acceso.Modificar = reader["modificar"].ToString();
                    Acceso.Eliminar = reader["eliminar"].ToString();
                    Acceso.Admin = reader["admi"].ToString();
                    Acceso.Reporte = reader["reportes"].ToString();
                Resultado = 1;
                }             
                        
                if(Resultado == 1)
                {
                con.Close();
                return "OK";                
                }                
                else
                {
                con.Close();
                return "False";
                }
           
            
        }
    }
}
