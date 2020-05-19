using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RHH
{
    public partial class Inicio : Form
    {      

        public Inicio()
        {
            InitializeComponent();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Acceso.Registrar == "Si")
            {
                new Registro().Show();
                this.Hide();
            }
            else { MessageBox.Show("No tienes acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Acceso.Consultar == "Si")
            {
                new Consulta().Show();
                this.Hide();
            }
            else { MessageBox.Show("No tienes acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Acceso.Nombre + " " + Acceso.Apellido;
            
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HacerReporte().Show();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void reporteDeMasDeUnaPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MenuReportes().Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Acceso.Admin != "Si")
            {
                MessageBox.Show("No tienes acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                new Usuarios().Show();
            }
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void nuevoDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Acceso.Admin != "Si")
            {
                MessageBox.Show("No tienes acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                new NuevoDepartamento().Show();
            }
            
        }

        private void nuevaAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Acceso.Admin != "Si")
            {
                MessageBox.Show("No tienes acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                new NuevaArea().Show();
            }
            
        }

        private void nuevaDireccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Acceso.Admin != "Si")
            {
                MessageBox.Show("No tienes acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                new DireccionDGV().Show();
            }
            
        }
    }
}
