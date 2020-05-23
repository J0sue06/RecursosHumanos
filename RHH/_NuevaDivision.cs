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
    public partial class _NuevaDivision : Form
    {
        Departamento d = new Departamento();
        NuevaDivision _division = new NuevaDivision();
        public Contrato3 contrato3 { get; set; }
        public _NuevaDivision()
        {
            InitializeComponent();
        }

        private void Datos_Direccion_Load(object sender, EventArgs e)
        {
            dgvDireccion.DataSource = d.DatosDepartamento();
            dgvDireccion.Columns[0].Visible = false;
            dgvDireccion.Columns[1].Visible = false;
            dgvDireccion.Columns[2].Visible = false;
            dgvDireccion.Columns[3].Visible = false;
            dgvDireccion.Columns[6].Visible = false;
        }

        private void dgvDireccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _division.txtDivision.Text = dgvDireccion.CurrentRow.Cells[4].Value.ToString();
            Departamento.id_departamento = int.Parse(dgvDireccion.CurrentRow.Cells[3].Value.ToString());
            PersonaModel.CodigoDireccion = dgvDireccion.CurrentRow.Cells[1].Value.ToString();

            this.Close();
            _division.Show();
        }
    }
}
