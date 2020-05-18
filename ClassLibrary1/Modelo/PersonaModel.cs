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
    public class PersonaModel
    {
        public int IdUsuario { get; set; }
        public static int Id_departamento { get; set; }
        public static string CodigoDepartamento { get; set; }
        public static string CodigoArea { get; set; }
        public static string CodigoDireccion { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public DateTime Nacimiento { get; set; }
        public string Sexo { get; set; }
        public string Calle { get; set; }
        public string Sector { get; set; }
        public string Ciudad { get; set; }
        public string numeroCasa { get; set; }
        public string Correo { get; set; }
        public string Estudios { get; set; }
        public string Telefono_Casa { get; set; }
        public string Telefono_Movil { get; set; }
        public string Licencia { get; set; }
        public string Dependiente { get; set; }
        public string Condicion { get; set; }
        public string Rango { get; set; }
        public string Institucion { get; set; }
        public string fechaIngreso { get; set; }
        public string ultimoAscenso { get; set; }
        public string Antecedentes { get; set; }
        public string Sangre { get; set; }
        public string Salario { get; set; }
        public int Estado = 0;
        public byte[] Imagen { get; set; }
        public int Resultado { get; set; }
        
        public SqlConnection con = new BasedeDatos().conectar();

        public void InsertarPersona()
        {
            string Codigo_final = CodigoDepartamento + CodigoArea + CodigoDireccion;
            try
            {                
                SqlCommand cmd = new SqlCommand("SP_insertar_informacionPersona", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@codigo", Codigo_final));
                cmd.Parameters.Add(new SqlParameter("@id_departamento", Id_departamento));
                cmd.Parameters.Add(new SqlParameter("@nombre", Nombre));
                cmd.Parameters.Add(new SqlParameter("@apellido", Apellido));
                cmd.Parameters.Add(new SqlParameter("@cedula", Cedula));
                cmd.Parameters.Add(new SqlParameter("@nacimiento", Nacimiento));
                cmd.Parameters.Add(new SqlParameter("@sexo", Sexo));
                cmd.Parameters.Add(new SqlParameter("@calle", Calle));
                cmd.Parameters.Add(new SqlParameter("@sector", Sector));
                cmd.Parameters.Add(new SqlParameter("@ciudad", Ciudad));
                cmd.Parameters.Add(new SqlParameter("@numeroCasa", numeroCasa));
                cmd.Parameters.Add(new SqlParameter("@correo", Correo));
                cmd.Parameters.Add(new SqlParameter("@estudios", Estudios));
                cmd.Parameters.Add(new SqlParameter("@telefono_casa", Telefono_Casa));
                cmd.Parameters.Add(new SqlParameter("@telefono_movil", Telefono_Movil));
                cmd.Parameters.Add(new SqlParameter("@licencia", Licencia));
                cmd.Parameters.Add(new SqlParameter("@dependiente", Dependiente));
                cmd.Parameters.Add(new SqlParameter("@condicion", Condicion));
                cmd.Parameters.Add(new SqlParameter("@rango", Rango));
                cmd.Parameters.Add(new SqlParameter("@institucion", Institucion));
                cmd.Parameters.Add(new SqlParameter("@fecha_ingreso", fechaIngreso));
                cmd.Parameters.Add(new SqlParameter("@ultimo_ascenso", ultimoAscenso));
                cmd.Parameters.Add(new SqlParameter("@antecedentes", Antecedentes));
                cmd.Parameters.Add(new SqlParameter("@grupoSanguineo", Sangre));

                cmd.Parameters.Add("@foto", SqlDbType.Image).Value = Imagen;

                cmd.Parameters.Add(new SqlParameter("@salario", Salario));
                cmd.Parameters.Add(new SqlParameter("@estado", Estado));

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
                    return;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar datos personales" + ex);
            }           

        }

        public void Eliminar(int Id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_Eliminar", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@id_persona", Id));         

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
                    return;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al borrar" + ex);
            }
        }

        public string  Actualizar()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_actualizar_informacionPersona", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@id_persona", Id));
                cmd.Parameters.Add(new SqlParameter("@nombre", Nombre));
                cmd.Parameters.Add(new SqlParameter("@apellido", Apellido));
                cmd.Parameters.Add(new SqlParameter("@cedula", Cedula));
                cmd.Parameters.Add(new SqlParameter("@nacimiento", Nacimiento));
                cmd.Parameters.Add(new SqlParameter("@sexo", Sexo));
                cmd.Parameters.Add(new SqlParameter("@calle", Calle));
                cmd.Parameters.Add(new SqlParameter("@sector", Sector));
                cmd.Parameters.Add(new SqlParameter("@ciudad", Ciudad));
                cmd.Parameters.Add(new SqlParameter("@numero_casa", numeroCasa));
                cmd.Parameters.Add(new SqlParameter("@correo", Correo));
                cmd.Parameters.Add(new SqlParameter("@estudios", Estudios));
                cmd.Parameters.Add(new SqlParameter("@telefono_casa", Telefono_Casa));
                cmd.Parameters.Add(new SqlParameter("@telefono_movil", Telefono_Movil));
                cmd.Parameters.Add(new SqlParameter("@licencia", Licencia));
                cmd.Parameters.Add(new SqlParameter("@dependiente", Dependiente));
                cmd.Parameters.Add(new SqlParameter("@condicion", Condicion));
                cmd.Parameters.Add(new SqlParameter("@rango", Rango));
                cmd.Parameters.Add(new SqlParameter("@institucion", Institucion));
                cmd.Parameters.Add(new SqlParameter("@fecha_ingreso", fechaIngreso));
                cmd.Parameters.Add(new SqlParameter("@ultimo_ascenso", ultimoAscenso));
                cmd.Parameters.Add(new SqlParameter("@antecedentes", Antecedentes));
                cmd.Parameters.Add(new SqlParameter("@sangre", Sangre));                
                cmd.Parameters.Add("@imagen", SqlDbType.Image).Value = Imagen;
                cmd.Parameters.Add(new SqlParameter("@salario", Salario));

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
                throw;
                //Console.WriteLine("Error al actualizar datos personales" + ex);
            }

            return "OK";
        }

       

    }
}
