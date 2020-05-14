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
    public partial class InfoUsuarios : Form
    {
        public InfoUsuarios()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Usuarios().Show();
        }

        private void InfoUsuarios_Load(object sender, EventArgs e)
        {
            Bloquear();            
            btnGuardar.Visible = false;
            txtIdUsuarios.Visible = false;
        }

        private void Bloquear()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtCedula.Enabled = false;
            txtUsuario.Enabled = false;
            txtClave.Enabled = false;
            Consultar.Enabled = false;
            Registrar.Enabled = false;
            Modificar.Enabled = false;
            Eliminar.Enabled = false;
            Administrador.Enabled = false;
        }

        private void Activar()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtCedula.Enabled = true;
            txtUsuario.Enabled = true;
            txtClave.Enabled = true;
            Consultar.Enabled = true;
            Registrar.Enabled = true;
            Modificar.Enabled = true;
            Eliminar.Enabled = true;
            Administrador.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Activar();
            btnModificar.Visible = false;
            btnGuardar.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuariosModel _usuariosModel = new UsuariosModel();

            _usuariosModel.Id = int.Parse(txtIdUsuarios.Text);
            _usuariosModel.Nombre = txtNombre.Text;
            _usuariosModel.Apellido = txtApellido.Text;
            _usuariosModel.Cedula = txtCedula.Text;
            _usuariosModel.Usuario = txtUsuario.Text;
            _usuariosModel.Clave = txtClave.Text;
            
            if(Consultar.Checked == true)
            {
                _usuariosModel.Consultar = "Si";
            }
            else
            {
                _usuariosModel.Consultar = "No";
            }

            if (Registrar.Checked == true)
            {
                _usuariosModel.Registrar = "Si";
            }
            else
            {
                _usuariosModel.Registrar = "No";
            }

            if (Modificar.Checked == true)
            {
                _usuariosModel.Modificar = "Si";
            }
            else
            {
                _usuariosModel.Modificar = "No";
            }

            if (Eliminar.Checked == true)
            {
                _usuariosModel.Eliminar = "Si";
            }
            else
            {
                _usuariosModel.Eliminar = "No";
            }
            if (Administrador.Checked == true)
            {
                _usuariosModel.Administrador = "Si";
            }
            else
            {
                _usuariosModel.Administrador = "No";
            }

            var resultado = _usuariosModel.ActualizarUsuario();

            if(resultado == "OK")
            {
                MessageBox.Show("Usuario Actualizado Correctamente!");
                this.Hide();
                new Usuarios().Show();
            }


        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
