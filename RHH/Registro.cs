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
    public partial class Registro : Form, Contrato,Contrato2,Contrato3
    {
        PersonaModel _personasModel = new PersonaModel();
        DatosAcademicos _datosAcademicos = new DatosAcademicos();
        DatosFamiliares _datosFamiliares = new DatosFamiliares();       


        public Registro()
        {
            InitializeComponent();

            LicenciaNo.Checked = true;
            txtLicencia.Enabled = false;
            LicenciaSi.Checked = false;
            AntecedentesNo.Checked = true;

            noVivePadre.Checked = true;
            txtTelefonoPadre.Enabled = false;
            _datosFamiliares.Estado_padre = "No Vive";
            _datosFamiliares.Telefono_padre = "No Aplica";

            noViveMadre.Checked = true;
            txtTelefonoMadre.Enabled = false;
            _datosFamiliares.Estado_madre = "No Vive";
            _datosFamiliares.Telefono_madre = "No Aplica";

            ConyugueNo.Checked = true;
            txtConyugue.Enabled = false;
            txtTelefonoConyugue.Enabled = false;

            hijoNo.Checked = true;
            Hijo1.Enabled = false;
            EdadHijo1.Enabled = false;
            btnHijo.Enabled = false;            

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {      
            _personasModel.Nombre = txtNombre.Text;
            _personasModel.Apellido = txtApellido.Text;
            _personasModel.Cedula = mCedula.Text;
            _personasModel.Nacimiento = txtNacimiento.Value;
            _personasModel.Calle = txtCalle.Text;
            _personasModel.Sector = txtSector.Text;
            _personasModel.Ciudad = txtCiudad.Text;
            _personasModel.numeroCasa = txtNumCasa.Text;
            _personasModel.Correo = txtCorreo.Text;
            _personasModel.Estudios = cEstudios.Text;
            _personasModel.Telefono_Casa = txtTelCasa.Text;
            _personasModel.Telefono_Movil = txtTelMovil.Text;
            _personasModel.Dependiente = txtDependiente.Text;
            _personasModel.Sexo = txtSexo.Text;
            if (txtCondicion.Text == "Civil")
            {
                _personasModel.Condicion = txtCondicion.Text;
                _personasModel.Rango = "No Aplica";
                _personasModel.Institucion = "No Aplica";
                _personasModel.fechaIngreso = Convert.ToDateTime(txtIngreso.Text);
                _personasModel.ultimoAscenso = "No Aplica";
            }
            if (txtCondicion.Text == "Militar")
            {
                _personasModel.Condicion = txtCondicion.Text;
                _personasModel.Rango = txtRango.Text;
                _personasModel.Institucion = txtInstitucion.Text;
                _personasModel.fechaIngreso = Convert.ToDateTime(txtIngreso.Text);
                _personasModel.ultimoAscenso = TxtAscenso.Text;
            }
            if (txtCondicion.Text == "Asimilado")
            {
                _personasModel.Condicion = txtCondicion.Text;
                _personasModel.Rango = "No Aplica";
                _personasModel.Institucion = txtInstitucion.Text;
                _personasModel.fechaIngreso = Convert.ToDateTime(txtIngreso.Text);
                _personasModel.ultimoAscenso = "No Aplica";
            }

                if (LicenciaSi.Checked == true)
            {
                _personasModel.Licencia = txtLicencia.Text;
            }
            if(LicenciaNo.Checked == true)
            { _personasModel.Licencia = LicenciaNo.Text; }       
            
            if (AntecedentesSi.Checked == true)
            { _personasModel.Antecedentes = AntecedentesSi.Text; }
            else { _personasModel.Antecedentes = AntecedentesNo.Text; }
            _personasModel.Sangre = txtSangre.Text;

            //Guardar Imagen -----------------------
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            
            _personasModel.Imagen = ms.GetBuffer();
            //---------------------------------------
            validar();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new Inicio().Show();
            this.Hide();
        }

        private void validarAcademicos()
        {
            if (txtEstudios.Text == string.Empty)
            {
                MessageBox.Show("El campo nivel academico es necesario!", "Completar los campos con *", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtColegio.Text))
            {
                MessageBox.Show("El campo institucion es necesario!", "Completar los campos con *", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtLugar.Text))
            {
                
            }
            else if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                MessageBox.Show("El campo titulo o grado es necesario!", "Completar los campos con *", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtIdiomas.Text))
            {
                MessageBox.Show("El campo idioma es necesario!", "Completar los campos con *", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                _datosAcademicos.InsertarDatosAcademicos();
                tabControl1.SelectedTab = tabPage1;
            }
        }


        private void validar()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El campo nombre es necesario!","Completar los campos con *",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("El campo apellido es necesario!", "Completar los campos con *", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (mCedula.MaskCompleted == false)
            {
                MessageBox.Show("El campo cedula es necesario!", "Completar los campos con *", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(cEstudios.Text == string.Empty)
            {
                MessageBox.Show("El nivel academico es necesario!", "Completar los campos con *", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtNacimiento.Text))
            {
                MessageBox.Show("El campo fecha de nacimiento es necesario!", "Completar los campos con *", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtSexo.Text == string.Empty)
            {
                MessageBox.Show("Debe seleccionar el sexo!", "Completar los campos con *", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtCondicion.Text))
            {
                MessageBox.Show("El campo condicion es necesario!", "Completar los campos con *", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
            else if (string.IsNullOrEmpty(AntecedentesNo.Text) | string.IsNullOrEmpty(AntecedentesSi.Text))
            {
                MessageBox.Show("Debe llenar el campo de antecedentes!", "Completar los campos con *", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtCalle.Text))
            {
                MessageBox.Show("El campo calle es necesario!", "Completar los campos con *", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtSector.Text))
            {
                MessageBox.Show("El campo sector es necesario!", "Completar los campos con *", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtCiudad.Text))
            {
                MessageBox.Show("El campo ciudad es necesario!", "Completar los campos con *", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!txtTelCasa.MaskCompleted && !txtTelMovil.MaskCompleted)
            {
                MessageBox.Show("Debe llenar al menos 1 telefono", "Completar los campos con *", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {               
                _personasModel.InsertarPersona();
                //string cedula = mCedula.Text;
                _datosAcademicos.Obtener(mCedula.Text);
                tabControl1.SelectedTab = tabPage3;
            }

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void LicenciaNo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void LicenciaSi_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _datosAcademicos.Estudios = txtEstudios.Text;
            _datosAcademicos.Colegio = txtColegio.Text;
            _datosAcademicos.Lugar = txtLugar.Text;
            _datosAcademicos.FechaFin = txtFechaFin.Value;
            _datosAcademicos.Titulo = txtTitulo.Text;
            _datosAcademicos.Idioma = txtIdiomas.Text;

            validarAcademicos();

        }

        private void LicenciaNo_Click(object sender, EventArgs e)
        {
            txtLicencia.Enabled = false;
            LicenciaSi.Checked = false;
        }

        private void LicenciaSi_Click(object sender, EventArgs e)
        {
            txtLicencia.Enabled = true;
            LicenciaNo.Checked = false;

        }

        private void txtCondicion_Click(object sender, EventArgs e)
        {
           
        }

        private void txtCondicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtCondicion.Text == "Civil")
            {               
                txtRango.Enabled = false;
                txtInstitucion.Enabled = false;
                txtIngreso.Enabled = false;
                TxtAscenso.Enabled = false;
            }
            else if (txtCondicion.Text == "Militar")
            {  
                txtRango.Enabled = true;
                txtInstitucion.Enabled = true;
                txtIngreso.Enabled = true;
                TxtAscenso.Enabled = true;
            }
            else if(txtCondicion.Text == "Asimilado")
            {
                txtRango.Enabled = false;
                txtInstitucion.Enabled = true;
                txtIngreso.Enabled = true;
                TxtAscenso.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {       
            _datosFamiliares.Nombre_conyugue = txtConyugue.Text;
            _datosFamiliares.Telefono_conyugue = txtTelefonoConyugue.Text;
            _datosFamiliares.Persona_emergencia = txtPersonaEmergencia.Text;
            _datosFamiliares.Parentesco_emergencia = txtParentescoEmergencia.Text;
            _datosFamiliares.Telefono_emergencia = txtTelefonoEmergencia.Text;

            if (VivePadre.Checked == true)
            {
                _datosFamiliares.Telefono_padre = txtTelefonoPadre.Text;
            }
            if(ViveMadre.Checked == true)
            {
                _datosFamiliares.Telefono_madre = txtTelefonoMadre.Text;
            }

            if (ValidarFamiliares() == "OK")
            {

                _datosFamiliares.Obtener(mCedula.Text);
                var resultado = _datosFamiliares.InsertarDatosFamiliares();

                _datosFamiliares.ObtenerIdFamiliares(txtNombrePadre.Text);



                foreach (DataGridViewRow item in DGVHijo.Rows)
                {
                    _datosFamiliares.InserarHijo(new object[] { item.Cells[0].Value, item.Cells[1].Value });
                }

                if (resultado == "OK")
                {
                    MessageBox.Show("Datos Guardados Correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    new Inicio().Show();
                }
                else { MessageBox.Show("Error al insertar Datos Familiares!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            
        }

        private string ValidarFamiliares()
        {
            if(string.IsNullOrEmpty(txtNombrePadre.Text))
            {
                MessageBox.Show("El nombre del padre es obligatorio!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "False";
            }
            else
            {
                _datosFamiliares.Nombre_padre = txtNombrePadre.Text;
            }
            if (string.IsNullOrEmpty(txtNombreMadre.Text))
            {
                MessageBox.Show("El nombre de la madre es obligatorio!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "False";
            }
            else
            {
                _datosFamiliares.Nombre_madre = txtNombreMadre.Text;
            }
            
            if(string.IsNullOrEmpty(txtPersonaEmergencia.Text))
            {
                MessageBox.Show("El campo persona a notificar es obligatorio!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "False";
            }
            if (txtTelefonoEmergencia.MaskCompleted != true)
            {
                MessageBox.Show("El telefono emergencia es obligatorio!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "False";
            }

            return "OK";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult rs = fo.ShowDialog();

            if (rs == DialogResult.OK)
            {
                pImagen.Image = Image.FromFile(fo.FileName);
            }
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            txtConyugue.Enabled = false;
            txtTelefonoConyugue.Enabled = false;            
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            txtConyugue.Enabled = true;
            txtTelefonoConyugue.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DGVHijo.Rows.Add(Hijo1.Text, EdadHijo1.Text);
            Hijo1.Clear();
            EdadHijo1.Clear();
        }

        private void noVivePadre_CheckedChanged(object sender, EventArgs e)
        {
            txtTelefonoPadre.Enabled = false;
            _datosFamiliares.Estado_padre = "No Vive";
            _datosFamiliares.Telefono_padre = "No Aplica";
        }

        private void VivePadre_CheckedChanged(object sender, EventArgs e)
        {
            txtTelefonoPadre.Enabled = true;
            _datosFamiliares.Estado_padre = "Vive";
            
        }

        private void noViveMadre_CheckedChanged(object sender, EventArgs e)
        {
            txtTelefonoMadre.Enabled = false;
            _datosFamiliares.Estado_madre = "No Vive";
            _datosFamiliares.Telefono_madre = "No Aplica";
        }

        private void ViveMadre_CheckedChanged(object sender, EventArgs e)
        {
            txtTelefonoMadre.Enabled = true;
            _datosFamiliares.Estado_madre = "Vive";
            
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            Hijo1.Enabled = false;
            EdadHijo1.Enabled = false;
            btnHijo.Enabled = false;
            DGVHijo.Rows.Add("No Tiene", "No Tiene");
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            Hijo1.Enabled = true;
            EdadHijo1.Enabled = true;
            btnHijo.Enabled = true;

            DGVHijo.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Inicio().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Inicio().Show();
            this.Hide();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
           if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
           if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNumCasa_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtNumCasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtLicencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLicencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtRango_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtInstitucion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRango_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtInstitucion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtAscenso_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAscenso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtColegio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtColegio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtLugar_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtLugar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNombrePadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNombreMadre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreMadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtConyugue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPersonaEmergencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtParentescoEmergencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Hijo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void EdadHijo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void mCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
          if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            
        }

        private void cDepartamento_Click(object sender, EventArgs e)
        {         
            DepartamentoDGV d = new DepartamentoDGV();
            d.contrato = this;
            d.Show();
        }

        private void cDepartamento_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void Departamento(string texto)
        {
            cDepartamento.Text = texto;
        }
        public void Area(string texto)
        {
            cArea.Text = texto;
        }
        public void Direccion(string texto)
        {
            txtDireccion.Text = texto;
        }

        private void cArea_MouseClick(object sender, MouseEventArgs e)
        {
            AreaDGV a = new AreaDGV();
            a.contrato2 = this;
            a.Show();
        }

        private void cDepartamento_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtDireccion_MouseClick(object sender, MouseEventArgs e)
        {
            Datos_Direccion d = new Datos_Direccion();
            d.contrato3 = this;
            d.Show();
        }

        private void cArea_TextChanged(object sender, EventArgs e)
        {

        }
    }

    }

