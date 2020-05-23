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
    public partial class Usuarios : Form
    {
        UsuariosModel _usuariosModel = new UsuariosModel();
        public Usuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new NuevoUsuario().Show();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = _usuariosModel.CargarLista(txtFiltro.Text);
            dgvUsuarios.Columns[0].Visible = false;
            dgvUsuarios.Columns[5].Visible = false;
            dgvUsuarios.Columns[6].Visible = false;
            dgvUsuarios.Columns[7].Visible = false;
            dgvUsuarios.Columns[8].Visible = false;
            dgvUsuarios.Columns[9].Visible = false;
            dgvUsuarios.Columns[10].Visible = false;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            _usuariosModel.Cedula = txtFiltro.Text;
            dgvUsuarios.DataSource = _usuariosModel.CargarLista(txtFiltro.Text);
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            InfoUsuarios _infoUsuarios = new InfoUsuarios();

            _infoUsuarios.txtIdUsuarios.Text = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            _infoUsuarios.txtNombre.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            _infoUsuarios.txtApellido.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            _infoUsuarios.txtCedula.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
            _infoUsuarios.txtUsuario.Text = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
            _infoUsuarios.txtClave.Text = dgvUsuarios.CurrentRow.Cells[5].Value.ToString();

            string Consultar = dgvUsuarios.CurrentRow.Cells[6].Value.ToString();
            string Registrar = dgvUsuarios.CurrentRow.Cells[7].Value.ToString();
            string Modificar = dgvUsuarios.CurrentRow.Cells[8].Value.ToString();
            string Eliminar = dgvUsuarios.CurrentRow.Cells[9].Value.ToString();
            string Admin = dgvUsuarios.CurrentRow.Cells[10].Value.ToString();
            string Reporte = dgvUsuarios.CurrentRow.Cells[11].Value.ToString();

            if (Consultar == "Si")
            {
                _infoUsuarios.Consultar.Checked = true;
            }
            else
            {
                _infoUsuarios.Consultar.Checked = false;
            }
            if(Registrar == "Si")
            {
                _infoUsuarios.Registrar.Checked = true;
            }
            else
            {
                _infoUsuarios.Registrar.Checked = false;
            }
            if (Modificar == "Si")
            {
                _infoUsuarios.Modificar.Checked = true;
            }
            else
            {
                _infoUsuarios.Modificar.Checked = false;
            }
            if (Eliminar == "Si")
            {
                _infoUsuarios.Eliminar.Checked = true;
            }
            if (Admin == "Si")
            {
                _infoUsuarios.Eliminar.Checked = true;
            }
            else
            {
                _infoUsuarios.Administrador.Checked = false;
            }
            if (Reporte == "Si")
            {
                _infoUsuarios.Reportes.Checked = true;
            }
            else
            {
                _infoUsuarios.Reportes.Checked = false;
            }

            this.Hide();
            _infoUsuarios.Show();

        }
    }
}
