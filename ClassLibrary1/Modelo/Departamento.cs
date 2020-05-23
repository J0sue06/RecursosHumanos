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
        public static string NombreDireccion { get; set; }
        public static int Id { get; set; }
        public static int id_departamento { get; set; }
        public static int Id_area { get; set; }
        public static int Id_direccion { get; set; }
        public static string Codigo { get; set; }
        public static int Id_division { get; set; }


        public SqlConnection con = new BasedeDatos().conectar();

        //Listo
        public bool InsertarDatosDepartamento(object[] datos)
        {
            
                SqlCommand cmd = new SqlCommand("SP_insertarDepartamento", con);
                cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@nombre", datos[0]));            
            cmd.Parameters.Add(new SqlParameter("@id_direccion", Id_direccion));

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

        public void ObtenerIdDireccion()
        {            
                try
                {
                    con.Close();
                    con.Open();
                    SqlDataReader reader = null;

                    SqlCommand cmd = new SqlCommand("SP_obteneIdDireccion", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@nombre", NombreDireccion));
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

                    cmd.Parameters.Add(new SqlParameter("@id_division", Id_division));
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

        public bool NuevaArea(object[] datos)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("SP_InsertarArea", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@id_departamento", Id_area));
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

        //Listo
        public bool InsertarDireccion()
        {

            try
            {
                SqlCommand cmd = new SqlCommand("SP_InsertarDireccion", con);
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.Add(new SqlParameter("@nombre", NombreDireccion));                

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

        //Se utiliza para llenar el comboBox del formulario: reporte varias personas
        public DataTable DatosDepartamento2()
        {

            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SP_obtenerDepartamentoFormReporte", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;
        }


        public DataTable DatosArea()
        {

            DataTable dt = new DataTable();


            SqlCommand cmd = new SqlCommand("SP_ObtenerArea", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@id_departamento", id_departamento));

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;
        }

        public DataTable ObtenerArea()
        {

            DataTable dt = new DataTable();


            SqlCommand cmd = new SqlCommand("SP_ObtenerAreas", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@id", Id_direccion));

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;
        }


        //Listo
        public DataTable DatosDireccion()
        {

            DataTable dt = new DataTable();


            SqlCommand cmd = new SqlCommand("SP_ObtenerDireccion", con);
            cmd.CommandType = CommandType.StoredProcedure;
           

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;
        }

        public bool InsertarDivision(object[] datos)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_InsertarDivision", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@id_departamento", id_departamento));
                cmd.Parameters.Add(new SqlParameter("@codigo", datos[1]));
                cmd.Parameters.Add(new SqlParameter("@nombre_division", datos[0]));

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
            catch (Exception ex )
            {
                Console.WriteLine("Error al insertar Division " + ex);
                return false;

            }
        }

        public DataTable DatosDivision()
        {

            DataTable dt = new DataTable();


            SqlCommand cmd = new SqlCommand("SP_obtenerDivision", con);
            cmd.CommandType = CommandType.StoredProcedure;


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            return dt;
        }


    }
}
