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
        public Contrato contrato { get; set; }
        public AreaDGV()
        {
            InitializeComponent();
        }

        private void dgvArea_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            contrato.Departamento(dgvArea.CurrentRow.Cells[2].Value.ToString());
            
        }

        private void AreaDGV_Load(object sender, EventArgs e)
        {
            dgvArea.DataSource = new Departamento().DatosArea();
            dgvArea.Columns[0].Visible = false;
            dgvArea.Columns[1].Visible = false;
        }
    }
}
