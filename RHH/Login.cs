using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1.Modelo;
using System.DirectoryServices;

namespace RHH
{
    public partial class Login : Form
    {
        Loguear _login = new Loguear();

        //Datos para el Active Directory
        string path = @"LDAP://nombre_del_servidor";
        string dominio = @"nombre_del_dominio";

        public static string nombreUsuario { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Codigo Para loguarse con slq server

            var resultado = _login.Acceder(txtUsuario.Text, txtClave.Text);

            if (resultado == "OK")
            {
                this.Hide();
                new Inicio().Show();
            }
            else if (resultado == "False")
            {
                MessageBox.Show("Usuario o Clave incorrecta!", "Error al iniciar sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //-------------------------------------------------------------------------------------------------------------------------------


            ////Codigo para loguearse con active directory            

            //string usuario = txtUsuario.Text;
            //string clave = txtClave.Text;

            //string dominioUsuario = dominio + @"\" + usuario;

            //bool Resultado = AutenticarUsuario(path, dominioUsuario, clave);
            //if (Resultado)
            //{
            //    //Aqui se llama a un metodo que se le pasa por parametro el nombre del usuario
            //    //para buscar los permisos en la base de datos que este tenga
            //}
            //else
            //{
            //    MessageBox.Show("Error al loguearse con el active directory!");
            //}

            ////----------------------------------------------------------------------------------------------------------------------------------

        }

        private bool AutenticarUsuario(string path, string user, string pass)
        {
            DirectoryEntry de = new DirectoryEntry(path, user, pass, AuthenticationTypes.Secure);

            try
            {
                DirectorySearcher ds = new DirectorySearcher(de);
                //ds.Filter = "nombre de la tabla =" + "variable que almacena el usuario" + "";
                SearchResult search = null;
                search = ds.FindOne();
                nombreUsuario = search.GetDirectoryEntry().Properties["Nombre_del_campo_en_la_BD"].Value.ToString();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;

            }
        }




    }
}
