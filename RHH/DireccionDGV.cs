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
    public partial class DireccionDGV : Form
    {      

        NuevaDireccion d = new NuevaDireccion();
        public DireccionDGV()
        {
            InitializeComponent();
        }

        private void dgvArea_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Departamento.Id_direccion = int.Parse(dgvDireccion.CurrentRow.Cells[0].Value.ToString());
            d.txtDepartamento.Text = dgvDireccion.CurrentRow.Cells[2].Value.ToString();
            d.Show();           
            this.Close();
        }

        private void DireccionDGV_Load(object sender, EventArgs e)
        {
            dgvDireccion.DataSource = new Departamento().DatosDireccion();
            dgvDireccion.Columns[0].Visible = false;
            dgvDireccion.Columns[1].Visible = false;
        }
    }
}
