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
    public partial class _NuevaDireccion : Form
    {
        Departamento d = new Departamento();
        public _NuevaDireccion()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Departamento.NombreDireccion = txtDepartamento.Text;
            
            var resultado = d.InsertarDireccion();

            if (resultado == true)
            {
               
                    MessageBox.Show("Departamento Creado Satisfactoriamente!","Atencion",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
