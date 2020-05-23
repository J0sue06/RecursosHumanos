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
    public partial class NuevaArea : Form
    {
        public NuevaArea()
        {
            InitializeComponent();
        }

        private void NuevaArea_Load(object sender, EventArgs e)
        {
            dgvDepartamento.DataSource = new Departamento().DatosDivision();
            //dgvDepartamento.Columns[0].Visible = false;
        }

        private void dgvDepartamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NuevaAreaForm area = new NuevaAreaForm();
            area.txtDepartamento.Text = dgvDepartamento.CurrentRow.Cells[3].Value.ToString();
            Departamento.Id_division = int.Parse(dgvDepartamento.CurrentRow.Cells[0].Value.ToString());            
            area.Show();
            this.Close();
        }
    }
}
