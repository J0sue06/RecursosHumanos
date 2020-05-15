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
    public partial class Datos_Direccion : Form
    {
        Departamento d = new Departamento();
        public Contrato3 contrato3 { get; set; }
        public Datos_Direccion()
        {
            InitializeComponent();
        }

        private void Datos_Direccion_Load(object sender, EventArgs e)
        {
            dgvDireccion.DataSource = d.ObtenerArea();
            dgvDireccion.Columns[0].Visible = false;
            dgvDireccion.Columns[1].Visible = false;
        }

        private void dgvDireccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            contrato3.Direccion(dgvDireccion.CurrentRow.Cells[3].Value.ToString());
            PersonaModel.CodigoDireccion = dgvDireccion.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
