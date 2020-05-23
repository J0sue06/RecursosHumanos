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
    public partial class NuevoUsuario : Form
    {
        UsuariosModel _usuarios = new UsuariosModel();
        

        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Usuarios().Show();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(InsertarUsuario() == "OK")
            {
                MessageBox.Show("Registrado Correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
                new Usuarios().Show();
            }
        }

        public string InsertarUsuario()
        {
            
            _usuarios.Nombre = txtNombre.Text;
            _usuarios.Apellido = txtApellido.Text;
            _usuarios.Cedula = txtCedula.Text;
            _usuarios.Usuario = txtUsuario.Text;
            _usuarios.Clave = txtClave.Text;

            if(Consultar.Checked == true)
            {
                _usuarios.Consultar = "Si";
            }
            else { _usuarios.Consultar = "No"; }
            if (Registrar.Checked == true)
            {
                _usuarios.Registrar = "Si";
            }
            else { _usuarios.Registrar = "No"; }
            if (Modificar.Checked == true)
            {
                _usuarios.Modificar = "Si";
            }
            else { _usuarios.Modificar = "No"; }
            if (Eliminar.Checked == true)
            {
                _usuarios.Eliminar = "Si";
            }
            else { _usuarios.Eliminar = "No"; }
            if (Administrador.Checked == true)
            {
                _usuarios.Administrador = "Si";
            }
            else { _usuarios.Administrador = "No"; }
            if (Reportes.Checked == true)
            {
                _usuarios.Reporte = "Si";
            }
            else { _usuarios.Reporte = "No"; }

            return  Validar();
            

        }

        private string Validar()
        {
            var resultado = "";

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El campo nombre es necesario!", "Completar los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("El campo apellido es necesario!", "Completar los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            if (txtCedula.MaskCompleted != true)
            {
                MessageBox.Show("El campo cedula es necesario!", "Completar los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("El campo usuario es necesario!", "Completar los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            if (string.IsNullOrEmpty(txtClave.Text))
            {
                MessageBox.Show("El campo clave es necesario!", "Completar los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                
                resultado = _usuarios.InsertarUsuario();                
            }

            return resultado;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {

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
    }
}
