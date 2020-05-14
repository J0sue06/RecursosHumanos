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
    public partial class MenuReportes : Form
    {
        public MenuReportes()
        {
            InitializeComponent();
        }

        private void MenuReportes_Load(object sender, EventArgs e)
        {
            
            Departamento.Checked = true;
            Desde.Enabled = false;
            Hasta.Enabled = false;
            ComboDepartamento.Enabled = false;

        }

        private void Fecha_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Departamento_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Departamento_Click(object sender, EventArgs e)
        {
            if(Departamento.Checked == true)
            {
                ComboDepartamento.Enabled = true;
            }
            else { ComboDepartamento.Enabled = false; }
            
        }

        private void Fecha_Click(object sender, EventArgs e)
        {
            if(Fecha.Checked == true)
            {
                Desde.Enabled = true;
                Hasta.Enabled = true;
            }
            else {
                Desde.Enabled = false;
                Hasta.Enabled = false;
            }
            
        }
    }
}
