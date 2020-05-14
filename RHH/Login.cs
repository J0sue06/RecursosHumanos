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

namespace RHH
{
    public partial class Login : Form
    {
        Loguear _login = new Loguear();        
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          var resultado =  _login.Acceder(txtUsuario.Text, txtClave.Text);
            
            if(resultado == "OK")
            {
                this.Hide();
                MessageBox.Show("Bienviendo al sistema!", "Iniciando sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);                
                new Inicio().Show();
            }
            else if (resultado == "False")
            {
                MessageBox.Show("Usuario o Clave incorrecta!", "Error al iniciar sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
