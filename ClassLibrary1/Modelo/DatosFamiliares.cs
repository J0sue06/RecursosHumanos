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
    public class DatosFamiliares
    {
        public int Id { get; set; }
        public int IdFamiliares { get; set; }
        public string Nombre_padre { get; set; }
        public string Estado_padre { get; set; }
        public string Telefono_padre { get; set; }
        public string Nombre_madre { get; set; }
        public string Estado_madre { get; set; }
        public string Telefono_madre { get; set; }
        public string Nombre_conyugue { get; set; }
        public string Telefono_conyugue { get; set; }
        public string Persona_emergencia { get; set; }
        public string Parentesco_emergencia { get; set; }
        public string Telefono_emergencia { get; set; }
        public int Resultado { get; set; }        

        public SqlConnection con = new BasedeDatos().conectar();

        public string InsertarDatosFamiliares()
        {
            try
            {             

                SqlCommand cmd = new SqlCommand("SP_insertar_datosFamiliares", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@id_persona", Id));
                cmd.Parameters.Add(new SqlParameter("@nombre_padre", Nombre_padre));
                cmd.Parameters.Add(new SqlParameter("@estado_padre", Estado_padre));
                cmd.Parameters.Add(new SqlParameter("@telefono_padre", Telefono_padre));
                cmd.Parameters.Add(new SqlParameter("@nombre_madre", Nombre_madre));
                cmd.Parameters.Add(new SqlParameter("@estado_madre", Estado_madre));
                cmd.Parameters.Add(new SqlParameter("@telefono_madre", Telefono_madre));
                cmd.Parameters.Add(new SqlParameter("@nombre_conyugue", Nombre_conyugue));
                cmd.Parameters.Add(new SqlParameter("@telefono_conyugue", Telefono_conyugue));
                cmd.Parameters.Add(new SqlParameter("@persona_emergencia", Persona_emergencia));
                cmd.Parameters.Add(new SqlParameter("@parentesco_emergencia", Parentesco_emergencia));
                cmd.Parameters.Add(new SqlParameter("@telefono_emergencia", Telefono_emergencia));

                con.Close();
                con.Open();

                if (cmd.ExecuteNonQuery() == 1)
                {
                    //Correcto
                    Resultado = 1;
                    con.Close();
                    return "OK";
                }

                else
                {
                    //Error
                    con.Close();
                    return "False";

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error al insertar datos familiares " + ex);
            }

            return "OK";
        }

        public void Obtener(string cedulaFiltro)
        {

            try
            {

                con.Close();
                con.Open();
                SqlDataReader reader = null;

                SqlCommand cmd = new SqlCommand("SP_ultimoId2", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@cedula", cedulaFiltro));
                reader = cmd.ExecuteReader();



                while (reader.Read())
                {
                    Id = int.Parse(reader["id"].ToString());                   

                }

                con.Close();
            }
            catch (Exception)
            {
                con.Close();
                throw;

            }


        }

        public string Actualizar()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_actualizar_datosFamiliares", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@id_familiares", IdFamiliares));
                cmd.Parameters.Add(new SqlParameter("@nombre_padre", Nombre_padre));
                cmd.Parameters.Add(new SqlParameter("@estado_padre", Estado_padre));
                cmd.Parameters.Add(new SqlParameter("@telefono_padre", Telefono_padre));
                cmd.Parameters.Add(new SqlParameter("@nombre_madre", Nombre_madre));
                cmd.Parameters.Add(new SqlParameter("@estado_madre", Estado_madre));
                cmd.Parameters.Add(new SqlParameter("@telefono_madre", Telefono_madre));
                cmd.Parameters.Add(new SqlParameter("@nombre_conyugue", Nombre_conyugue));
                cmd.Parameters.Add(new SqlParameter("@telefono_conyugue", Telefono_conyugue));
                cmd.Parameters.Add(new SqlParameter("@persona_emergencia", Persona_emergencia));
                cmd.Parameters.Add(new SqlParameter("@parentesco_emergencia", Parentesco_emergencia));
                cmd.Parameters.Add(new SqlParameter("@telefono_emergencia", Telefono_emergencia));

                con.Close();
                con.Open();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    //Correcto
                    Resultado = 1;                                 

                    //Se Cierra la conexion
                    con.Close();                   

                }

                return "OK";

            }
            catch (Exception)
            {
                return "False";  

            }

            
        }

        public void InserarHijo(object[] datos)
        {            
            try
            {
                SqlCommand cmd = new SqlCommand("SP_InsertarHijos", con);
                cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@idFamiliares", IdFamiliares));
                    cmd.Parameters.Add(new SqlParameter("@nombre", datos[0]));
                    cmd.Parameters.Add(new SqlParameter("@edad", datos[1]));

                    con.Close();
                    con.Open();

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        //Correcto
                        Console.WriteLine("Hijo insertado!");

                        con.Close();
                        //Id = 0;
                    }

                    else
                    {
                        //Error
                        con.Close();
                        return;

                    }
                
            }
            catch (Exception)
            {
                throw;
                
            }
        }

        public void ObtenerIdFamiliares(string padre)
        {

            try
            {

                con.Close();
                con.Open();
                SqlDataReader reader = null;

                SqlCommand cmd = new SqlCommand("SP_IdFamiliares", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@padre", padre));
                
                reader = cmd.ExecuteReader();



                while (reader.Read())
                {
                    IdFamiliares = int.Parse(reader["id_datos_familiares"].ToString());
                }

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                Console.WriteLine("Error al obtener id datos familiares " + ex);

            }


        }


    }
}
