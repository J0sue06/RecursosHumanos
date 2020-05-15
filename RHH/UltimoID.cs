using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ClassLibrary1.Conexion;

namespace RHH
{
    public class UltimoID
    {
        public SqlConnection con = new BasedeDatos().conectar();

        public bool ObtenerUltimoIdArea()
        {
            try
            {
                con.Close();
                con.Open();
                SqlDataReader reader = null;

                SqlCommand cmd = new SqlCommand("SP_ultimoCodigoArea", con);
                cmd.CommandType = CommandType.StoredProcedure;
                
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    NuevaAreaForm.UltimoNumero = int.Parse(reader["codigo"].ToString());

                }

                con.Close();
                return true;
            }
            catch (Exception)
            {
                con.Close();
                return false;

            }


        }

        public bool ObtenerUltimoIdDireccion()
        {
            try
            {
                con.Close();
                con.Open();
                SqlDataReader reader = null;

                SqlCommand cmd = new SqlCommand("SP_ultimoCodigoDireccion", con);
                cmd.CommandType = CommandType.StoredProcedure;

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    NuevaDireccion.UltimoNumero = int.Parse(reader["codigo"].ToString());

                }

                con.Close();
                return true;
            }
            catch (Exception)
            {
                con.Close();
                return false;

            }


        }



    }
}
