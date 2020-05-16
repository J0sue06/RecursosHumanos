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
    public partial class AreaDGV : Form
    {
        public Contrato2 contrato2 { get; set; }
        public AreaDGV()
        {
            InitializeComponent();
        }

        private void AreaDGV_Load(object sender, EventArgs e)
        {
            dgvArea.DataSource = new Departamento().DatosArea();
            dgvArea.Columns[0].Visible = false;
            dgvArea.Columns[1].Visible = false;
        }

        private void dgvArea_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {             
            contrato2.Area(dgvArea.CurrentRow.Cells[2].Value.ToString());

            PersonaModel.CodigoArea = dgvArea.CurrentRow.Cells[3].Value.ToString();
            Departamento.Id_direccion = int.Parse(dgvArea.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
