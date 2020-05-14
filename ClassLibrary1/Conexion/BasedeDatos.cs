using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary1.Conexion
{
    public class BasedeDatos
    {
        public SqlConnection con = new SqlConnection();
        string cadena = "Data Source=TEC007\\EXPRESS; Initial Catalog = recursos_humanos2; Integrated Security=true;";

        public SqlConnection conectar()
        {
            //con = new SqlConnection("Data Source=.; Initial Catalog = recursos_humanos; Integrated Security=true;");
            con.ConnectionString = cadena;
            return con;
        }

        public void cerrar()
        {
            con.Close();

        }
    }
}
