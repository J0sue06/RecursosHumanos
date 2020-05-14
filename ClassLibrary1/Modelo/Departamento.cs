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
    public class Departamento
    {
        public static string NombreDepartamento { get; set; }
        private int Id { get; set; }
        public static int id_departamento { get; set; }

        public SqlConnection con = new BasedeDatos().conectar();

        public string InsertarDatosDepartamento()
        {
            
                SqlCommand cmd = new SqlCommand("SP_insertarDepartamento", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@nombre", NombreDepartamento));                

                con.Close();
                con.Open();

                if (cmd.ExecuteNonQuery() == 1)
                {              
                
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

        public void ObtenerIdDepartamento()
        {            
                try
                {
                    con.Close();
                    con.Open();
                    SqlDataReader reader = null;

                    SqlCommand cmd = new SqlCommand("SP_obteneIdDepartamento", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@nombre", NombreDepartamento));
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


        public bool InsertarDatosArea(object[] datos)
        {

           try
                {
                    SqlCommand cmd = new SqlCommand("SP_InsertarArea", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@id_departamento", Id));
                    cmd.Parameters.Add(new SqlParameter("@nombre", datos[0]));
                cmd.Parameters.Add(new SqlParameter("@codigo", datos[1]));

                con.Close();
                    con.Open();

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                      con.Close();
                      return true;                     
                    }

                    else
                    {
                        //Error
                        con.Close();
                        return false;

                    }

                }
                catch (Exception)
                {
                return false;

                }
         

        }        

        public DataTable DatosDepartamento()
        {           

            DataTable dt = new DataTable();

            
                SqlCommand cmd = new SqlCommand("SP_obtenerDepartamento", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);          
           

            return dt;
        }


        public DataTable DatosArea()
        {

            DataTable dt = new DataTable();


            SqlCommand cmd = new SqlCommand("SP_ObtenerArea", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@filtro", id_departamento));

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;
        }





    }
}
