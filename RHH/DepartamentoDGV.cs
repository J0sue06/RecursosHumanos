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
    public partial class DepartamentoDGV : Form
    {
        public Contrato contrato { get; set; }
        public DepartamentoDGV()
        {
            InitializeComponent();
        }

        private void DepartamentoDGV_Load(object sender, EventArgs e)
        {            
            dgvDepartamento.DataSource = new Departamento().DatosDepartamento();
            dgvDepartamento.Columns[0].Visible = false;
        }

        private void dgvDepartamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvDepartamento_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            contrato.Departamento(dgvDepartamento.CurrentRow.Cells[2].Value.ToString());         

            Departamento.id_departamento = int.Parse(dgvDepartamento.CurrentRow.Cells[0].Value.ToString());

            PersonaModel.Id_departamento = int.Parse(dgvDepartamento.CurrentRow.Cells[0].Value.ToString());

            PersonaModel.CodigoDepartamento = dgvDepartamento.CurrentRow.Cells[1].Value.ToString();


        }
    }
}
