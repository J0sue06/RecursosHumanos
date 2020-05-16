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
using System.IO;
using System.Drawing.Imaging;

namespace RHH
{
    public partial class Consulta : Form
    {
        
        ConsultaC _consulta = new ConsultaC();
        public Consulta()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Inicio().Show();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            
            dgListado.DataSource = _consulta.CargarLista();
            OcultarColumnas();

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltroConsulta();


        }

        private void FiltroConsulta()
        {
            ConsultaC.Cedula = "%"+txtFiltro.Text + "%";
            dgListado.DataSource = _consulta.CargarLista();
            OcultarColumnas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void OcultarColumnas()
        {
            dgListado.Columns[0].Visible = false;
            dgListado.Columns[6].Visible = false;
            dgListado.Columns[7].Visible = false;
            dgListado.Columns[8].Visible = false;
            dgListado.Columns[9].Visible = false;
            dgListado.Columns[10].Visible = false;
            dgListado.Columns[11].Visible = false;
            dgListado.Columns[12].Visible = false;
            dgListado.Columns[13].Visible = false;
            dgListado.Columns[14].Visible = false;
            dgListado.Columns[15].Visible = false;
            dgListado.Columns[16].Visible = false;
            dgListado.Columns[17].Visible = false;
            dgListado.Columns[18].Visible = false;
            dgListado.Columns[19].Visible = false;
            dgListado.Columns[20].Visible = false;
            dgListado.Columns[21].Visible = false;
            dgListado.Columns[22].Visible = false;
            dgListado.Columns[23].Visible = false;
            dgListado.Columns[24].Visible = true;
            dgListado.Columns[25].Visible = true;
            dgListado.Columns[26].Visible = false;
            dgListado.Columns[27].Visible = false;
            dgListado.Columns[28].Visible = false;
            dgListado.Columns[29].Visible = false;
            dgListado.Columns[30].Visible = false;
            dgListado.Columns[31].Visible = false;
            dgListado.Columns[32].Visible = false;
            dgListado.Columns[33].Visible = false;
            dgListado.Columns[34].Visible = false;
            dgListado.Columns[35].Visible = false;
            dgListado.Columns[36].Visible = false;
            dgListado.Columns[37].Visible = false;
            dgListado.Columns[38].Visible = false;
            dgListado.Columns[39].Visible = false;
            dgListado.Columns[40].Visible = false;
            dgListado.Columns[41].Visible = false;
            dgListado.Columns[42].Visible = false;
            dgListado.Columns[43].Visible = false;
            dgListado.Columns[44].Visible = false;
            dgListado.Columns[45].Visible = false;
            dgListado.Columns[46].Visible = false;
            dgListado.Columns[47].Visible = false;
            dgListado.Columns[48].Visible = false;
            dgListado.Columns[49].Visible = false;
            dgListado.Columns[50].Visible = false;
            dgListado.Columns[51].Visible = false;
            dgListado.Columns[52].Visible = false;
            dgListado.Columns[25].Visible = false;
            dgListado.Columns[54].Visible = false;
            dgListado.Columns[53].Visible = false;
        }

        private void dgListado_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Info _info = new Info();
            this.Hide();

            _info.Show();

            _info.lblCodigo.Text = dgListado.CurrentRow.Cells[24].Value.ToString();
            _info.txtID.Text = dgListado.CurrentRow.Cells[0].Value.ToString();
            _info.txtNombreInfo.Text = dgListado.CurrentRow.Cells[1].Value.ToString();
            _info.txtApellidoInfo.Text = dgListado.CurrentRow.Cells[2].Value.ToString();
            _info.txtCedulaInfo.Text = dgListado.CurrentRow.Cells[3].Value.ToString();
            _info.txtNacimientoInfo.Text = dgListado.CurrentRow.Cells[4].Value.ToString();
            _info.txtSexoInfo.Text = dgListado.CurrentRow.Cells[23].Value.ToString();
            _info.txtCorreoInfo.Text = dgListado.CurrentRow.Cells[5].Value.ToString();
            _info.txtEstudiosInfo.Text = dgListado.CurrentRow.Cells[6].Value.ToString();
            _info.txtGradoInfo.Text = dgListado.CurrentRow.Cells[34].Value.ToString();
            _info.txtIdiomaInfo.Text = dgListado.CurrentRow.Cells[35].Value.ToString();
            _info.txtNombrePinfo.Text = dgListado.CurrentRow.Cells[38].Value.ToString();
            _info.txtNombreMinfo.Text = dgListado.CurrentRow.Cells[41].Value.ToString();
            _info.txtTelefonoCasa.Text = dgListado.CurrentRow.Cells[7].Value.ToString();
            _info.txtTelefonoMovil.Text = dgListado.CurrentRow.Cells[8].Value.ToString();
            _info.txtCondicion.Text = dgListado.CurrentRow.Cells[9].Value.ToString();
            _info.txtRango.Text = dgListado.CurrentRow.Cells[10].Value.ToString();
            _info.txtInstitucion.Text = dgListado.CurrentRow.Cells[11].Value.ToString();
            _info.txtLugar.Text = dgListado.CurrentRow.Cells[32].Value.ToString();
            _info.txtTermino.Text = dgListado.CurrentRow.Cells[33].Value.ToString();
            _info.txtIngreso.Text = dgListado.CurrentRow.Cells[12].Value.ToString();
            _info.txtUltimoAscenso.Text = dgListado.CurrentRow.Cells[13].Value.ToString();
            _info.txtAntecedentes.Text = dgListado.CurrentRow.Cells[14].Value.ToString();
            _info.txtCalle.Text = dgListado.CurrentRow.Cells[15].Value.ToString();
            _info.txtSector.Text = dgListado.CurrentRow.Cells[16].Value.ToString();
            _info.txtCiudad.Text = dgListado.CurrentRow.Cells[17].Value.ToString();
            _info.txtNumCasa.Text = dgListado.CurrentRow.Cells[18].Value.ToString();
            _info.txtLicencia.Text = dgListado.CurrentRow.Cells[19].Value.ToString();
            _info.txtSangre.Text = dgListado.CurrentRow.Cells[20].Value.ToString();
            _info.txtDependiente.Text = dgListado.CurrentRow.Cells[21].Value.ToString();
            _info.txtEstadoP.Text = dgListado.CurrentRow.Cells[39].Value.ToString();
            _info.txtEstadoM.Text = dgListado.CurrentRow.Cells[42].Value.ToString();
            _info.txtConyugue.Text = dgListado.CurrentRow.Cells[44].Value.ToString();
            _info.txtTelConyugue.Text = dgListado.CurrentRow.Cells[45].Value.ToString();
            _info.txtPersonaEm.Text = dgListado.CurrentRow.Cells[46].Value.ToString();
            _info.txtParentesco.Text = dgListado.CurrentRow.Cells[47].Value.ToString();
            _info.txtTelefonoEm.Text = dgListado.CurrentRow.Cells[48].Value.ToString();
            _info.txtIdAcademicos.Text = dgListado.CurrentRow.Cells[29].Value.ToString();
            _info.txtInstitucionAcademica.Text = dgListado.CurrentRow.Cells[31].Value.ToString();
            _info.txtTelefonoPadre.Text = dgListado.CurrentRow.Cells[40].Value.ToString();
            _info.txtTelefonoMadre.Text = dgListado.CurrentRow.Cells[43].Value.ToString();
            _info.txtIdFamiliares.Text = dgListado.CurrentRow.Cells[37].Value.ToString();
            _info.txtSalario.Text = dgListado.CurrentRow.Cells[27].Value.ToString();

            var foto = dgListado.CurrentRow.Cells[22].Value;
            if (foto != DBNull.Value)
            {
                MemoryStream ms = new MemoryStream((byte[])dgListado.CurrentRow.Cells[22].Value‌​);
                _info.pImagenInfo.Image = Image.FromStream(ms);
            }
            else
            {
                _info.pImagenInfo.ImageLocation = @"C:\Users\c5iadmin\Desktop\RHH\No_imagen.png";
            }
        }

        private void Consulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
