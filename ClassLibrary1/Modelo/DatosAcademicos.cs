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
    public class DatosAcademicos
    {
        public int Id { get; set; }
        public string Estudios { get; set; }
        public string Colegio { get; set; }
        public string Lugar { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Titulo { get; set; }
        public string Idioma { get; set; }
        private int Resultado { get; set; }

        public SqlConnection con = new BasedeDatos().conectar();
       // PersonaModel _personaModel = new PersonaModel();

        public void InsertarDatosAcademicos()
        {            
            try
            {               
                SqlCommand cmd = new SqlCommand("SP_insertar_datosAcademicos", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@id_persona", Id));
                cmd.Parameters.Add(new SqlParameter("@estudios", Estudios));
                cmd.Parameters.Add(new SqlParameter("@colegio", Colegio));
                cmd.Parameters.Add(new SqlParameter("@lugar", Lugar));
                cmd.Parameters.Add(new SqlParameter("@fechaFin", FechaFin));
                cmd.Parameters.Add(new SqlParameter("@titulo", Titulo));
                cmd.Parameters.Add(new SqlParameter("@idioma", Idioma));

                con.Close();
                con.Open();

                if (cmd.ExecuteNonQuery() == 1)
                {
                    //Correcto
                    Resultado = 1;

                    con.Close();
                   
                }

                else
                {
                    //Error
                    con.Close();
                    Console.WriteLine("Error al insertar");

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error datos academicos " + ex);
            }
           

        }

        public string Actualizar()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_actualizar_datosAcademicos", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@id_datos", Id));
                cmd.Parameters.Add(new SqlParameter("@nivel", Estudios));
                cmd.Parameters.Add(new SqlParameter("@institucion", Colegio));
                cmd.Parameters.Add(new SqlParameter("@lugar", Lugar));
                cmd.Parameters.Add(new SqlParameter("@finalizar", FechaFin));
                cmd.Parameters.Add(new SqlParameter("@grado", Titulo));
                cmd.Parameters.Add(new SqlParameter("@idioma", Idioma));                

                con.Close();
                con.Open();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    //Correcto
                    Resultado = 1;
                    //Se obtiene el Id                    

                    //Se Cierra la conexion
                    con.Close();
                }

                else
                {
                    con.Close();
                    return "False";

                }
            }
            catch (Exception)
            {
                return "False";
                throw;
               
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


    }
}
