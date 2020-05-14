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
    public class ConsultaC
    {
        BasedeDatos db = new BasedeDatos();
        public static string Cedula { get; set; }
       
        public DataTable CargarLista()
        {
            SqlConnection con = db.conectar();

            DataTable dt = new DataTable();        
            
            if (string.IsNullOrEmpty(Cedula))
            {
                SqlCommand cmd = new SqlCommand("SP_GetAll", con);               
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            else if (!string.IsNullOrEmpty(Cedula))
            {
                SqlCommand cmd = new SqlCommand("SP_Filtrar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@cedula", Cedula);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                Cedula = null;
            }

            return dt;
        }



    }
}
