﻿using System;
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
        string cadena = "Data Source=192.168.90.94; Initial Catalog = recursos_humanos2; User ID=adminp; Password=Abcd1234;";

        public SqlConnection conectar()
        {            
            con.ConnectionString = cadena;
            return con;
        }

        public void cerrar()
        {
            con.Close();

        }
    }
}
