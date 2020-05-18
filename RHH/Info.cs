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
    public partial class Info : Form
    {       
        PersonaModel _personaModel = new PersonaModel();
        DatosAcademicos _datosAcademicos = new DatosAcademicos();
        DatosFamiliares _datosFamiliares = new DatosFamiliares();

        public Info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Consulta().Show();
            
        }
        private void bloquear()
        {
            txtNombreInfo.Enabled = false;
            txtApellidoInfo.Enabled = false;
            txtNacimientoInfo.Enabled = false;
            txtSexoInfo.Enabled = false;
            txtCedulaInfo.Enabled = false;
            txtCorreoInfo.Enabled = false;
            txtEstudiosInfo.Enabled = false;
            txtGradoInfo.Enabled = false;
            txtNombrePinfo.Enabled = false;
            txtNombreMinfo.Enabled = false;
            txtIdiomaInfo.Enabled = false;

            txtEstadoM.Enabled = false;
            txtEstadoP.Enabled = false;
            txtTelefonoCasa.Enabled = false;
            txtTelefonoMovil.Enabled = false;
            txtTelefonoMadre.Enabled = false;
            txtTelefonoPadre.Enabled = false;
            txtPersonaEm.Enabled = false;
            txtParentesco.Enabled = false;
            txtTelefonoEm.Enabled = false;
            txtConyugue.Enabled = false;
            txtTelConyugue.Enabled = false;            
            txtInstitucion.Enabled = false;
            txtLugar.Enabled = false;
            txtTermino.Enabled = false;            
            txtRango.Enabled = false;
            txtCondicion.Enabled = false;
            txtIngreso.Enabled = false;
            txtLicencia.Enabled = false;
            txtCalle.Enabled = false;
            txtAntecedentes.Enabled = false;
            txtDependiente.Enabled = false;
            txtInstitucionAcademica.Enabled = false;
            txtSector.Enabled = false;
            txtCiudad.Enabled = false;
            txtSangre.Enabled = false;
            txtNumCasa.Enabled = false;
            txtUltimoAscenso.Enabled = false;
            txtID.Visible = false;
            txtIdAcademicos.Visible = false;
            txtIdFamiliares.Visible = false;
            lblAcademicos.Visible = false;
            lblFamiliares.Visible = false;
            lblPersona.Visible = false;


        }

        private void activar()
        {
            txtNombreInfo.Enabled = true;
            txtApellidoInfo.Enabled = true;
            txtNacimientoInfo.Enabled = true;
            txtSexoInfo.Enabled = true;
            txtCedulaInfo.Enabled = true;
            txtCorreoInfo.Enabled = true;
            txtEstudiosInfo.Enabled = true;
            txtGradoInfo.Enabled = true;
            txtNombrePinfo.Enabled = true;
            txtNombreMinfo.Enabled = true;
            txtIdiomaInfo.Enabled = true;

            txtEstadoM.Enabled = true;
            txtEstadoP.Enabled = true;
            txtTelefonoCasa.Enabled = true;
            txtTelefonoMovil.Enabled = true;
            txtTelefonoMadre.Enabled = true;
            txtTelefonoPadre.Enabled = true;
            txtPersonaEm.Enabled = true;
            txtParentesco.Enabled = true;
            txtTelefonoEm.Enabled = true;
            txtConyugue.Enabled = true;
            txtTelConyugue.Enabled = true;
            txtInstitucion.Enabled = true;
            txtLugar.Enabled = true;
            txtTermino.Enabled = true;
            txtRango.Enabled = true;
            txtCondicion.Enabled = true;
            txtIngreso.Enabled = true;
            txtLicencia.Enabled = true;
            txtCalle.Enabled = true;
            txtAntecedentes.Enabled = true;
            txtDependiente.Enabled = true;
            txtInstitucionAcademica.Enabled = true;
            txtSector.Enabled = true;
            txtCiudad.Enabled = true;
            txtSangre.Enabled = true;
            txtNumCasa.Enabled = true;
            txtUltimoAscenso.Enabled = true;
            

        }

        private void Info_Load(object sender, EventArgs e)
        {
            bloquear();
            btnG.Visible = false;
            btnCancelar.Visible = false;
            btnImagen.Visible = false;
        }

        private void txtApellidoInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSexoInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNacimientoInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            activar();
            btnCerrar.Visible = false;
            btnG.Visible = true;
            btnCancelar.Visible = true;
            btnImagen.Visible = true;
            btnEliminar.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bloquear();
            btnCerrar.Visible = true;
            btnG.Visible = false;
            btnCancelar.Visible = false;
            btnImagen.Visible = false;
            btnE.Visible = true;
            btnM.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            PersonaModel _personaModel = new PersonaModel();
            _personaModel.Id = int.Parse(txtID.Text);
            _personaModel.Nombre = txtNombreInfo.Text;
            _personaModel.Apellido = txtApellidoInfo.Text;
            _personaModel.Cedula = txtCedulaInfo.Text;
            _personaModel.Nacimiento = txtNacimientoInfo.Value;
            _personaModel.Sexo = txtSexoInfo.Text;
            _personaModel.Calle = txtCalle.Text;
            _personaModel.Sector = txtSector.Text;
            _personaModel.Ciudad = txtCiudad.Text;
            _personaModel.numeroCasa = txtNumCasa.Text;
            _personaModel.Correo = txtCorreoInfo.Text;
            _personaModel.Estudios = txtEstudiosInfo.Text;
            _personaModel.Telefono_Casa = txtTelefonoCasa.Text;
            _personaModel.Telefono_Movil = txtTelefonoMovil.Text;
            _personaModel.Licencia = txtLicencia.Text;
            _personaModel.Dependiente = txtDependiente.Text;
            _personaModel.Condicion = txtCondicion.Text;
            _personaModel.Rango = txtRango.Text;
            _personaModel.Institucion = txtInstitucion.Text;
            _personaModel.fechaIngreso = txtIngreso.Text;
            _personaModel.ultimoAscenso = txtUltimoAscenso.Text;
            _personaModel.Sangre = txtSangre.Text;
            _personaModel.Antecedentes = txtAntecedentes.Text;
            _personaModel.numeroCasa = txtNumCasa.Text;
            
            //Guardar Imagen -----------------------
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pImagenInfo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            _personaModel.Imagen = ms.GetBuffer();

            var resultado = _personaModel.Actualizar();

            if(resultado == "OK")
            {
                MessageBox.Show("Registro Actualizado Correctamente");
                this.Hide();
                new Consulta().Show();
            }         



        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult rs = fo.ShowDialog();

            if (rs == DialogResult.OK)
            {
                pImagenInfo.Image = Image.FromFile(fo.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        public string actualizarDatosAcademicos()
        {
            _datosAcademicos.Id = int.Parse(txtIdAcademicos.Text);
            _datosAcademicos.Estudios = txtEstudiosInfo.Text;
            _datosAcademicos.Colegio = txtInstitucion.Text;
            _datosAcademicos.Lugar = txtLugar.Text;
            _datosAcademicos.FechaFin = txtTermino.Value;
            _datosAcademicos.Titulo = txtGradoInfo.Text;
            _datosAcademicos.Idioma = txtIdiomaInfo.Text;

            var resultado = _datosAcademicos.Actualizar();

            return resultado;
        }

        public string actualizarDatosFamiliares()
        {
            _datosFamiliares.IdFamiliares = int.Parse(txtIdFamiliares.Text);
            _datosFamiliares.Nombre_padre = txtNombrePinfo.Text;
            _datosFamiliares.Estado_padre = txtEstadoP.Text;
            _datosFamiliares.Telefono_padre = txtTelefonoPadre.Text;
            _datosFamiliares.Nombre_madre = txtNombreMinfo.Text;
            _datosFamiliares.Estado_madre = txtEstadoM.Text;
            _datosFamiliares.Telefono_madre = txtTelefonoMadre.Text;
            _datosFamiliares.Nombre_conyugue = txtConyugue.Text;
            _datosFamiliares.Telefono_conyugue = txtTelConyugue.Text;
            _datosFamiliares.Persona_emergencia = txtPersonaEm.Text;
            _datosFamiliares.Parentesco_emergencia = txtParentesco.Text;
            _datosFamiliares.Telefono_emergencia = txtTelefonoEm.Text;            

             var resultado = _datosFamiliares.Actualizar();

            return resultado;
        }

        public string actualizarPersonaModel()
        {
            _personaModel.Id = int.Parse(txtID.Text);
            _personaModel.Nombre = txtNombreInfo.Text;
            _personaModel.Apellido = txtApellidoInfo.Text;
            _personaModel.Cedula = txtCedulaInfo.Text;
            _personaModel.Nacimiento = txtNacimientoInfo.Value;
            _personaModel.Sexo = txtSexoInfo.Text;
            _personaModel.Calle = txtCalle.Text;
            _personaModel.Sector = txtSector.Text;
            _personaModel.Ciudad = txtCiudad.Text;
            _personaModel.numeroCasa = txtNumCasa.Text;
            _personaModel.Correo = txtCorreoInfo.Text;
            _personaModel.Estudios = txtEstudiosInfo.Text;
            _personaModel.Telefono_Casa = txtTelefonoCasa.Text;
            _personaModel.Telefono_Movil = txtTelefonoMovil.Text;
            _personaModel.Licencia = txtLicencia.Text;
            _personaModel.Dependiente = txtDependiente.Text;
            _personaModel.Condicion = txtCondicion.Text;
            _personaModel.Rango = txtRango.Text;
            _personaModel.Institucion = txtInstitucion.Text;
            _personaModel.fechaIngreso = txtIngreso.Text;
            _personaModel.ultimoAscenso = txtUltimoAscenso.Text;
            _personaModel.Sangre = txtSangre.Text;
            _personaModel.Antecedentes = txtAntecedentes.Text;
            _personaModel.numeroCasa = txtNumCasa.Text;
            _personaModel.Salario = txtSalario.Text;

            //Guardar Imagen -----------------------
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pImagenInfo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            _personaModel.Imagen = ms.GetBuffer();

            var resultado = _personaModel.Actualizar();

            return resultado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(actualizarPersonaModel() == "OK")
            {
                if(actualizarDatosAcademicos() == "OK")
                {
                    if(actualizarDatosFamiliares() == "OK")
                    {
                        MessageBox.Show("Actualizado Correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Hide();
                        new Consulta().Show();

                    }
                }
            }
            
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Acceso.Modificar == "Si")
            {
                activar();
                btnCerrar.Visible = false;
                btnG.Visible = true;
                btnCancelar.Visible = true;
                btnImagen.Visible = true;
                btnE.Visible = false;
                btnM.Visible = false;
            }
            else
            {
                MessageBox.Show("No tienes Acceso");
            }


        }

        private void btnE_Click(object sender, EventArgs e)
        {
            if (Acceso.Eliminar == "Si")
            {
                DialogResult result = MessageBox.Show("¿Realmente desea eliminar este registro?", "Atencion", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _personaModel.Eliminar(int.Parse(txtID.Text));
                    MessageBox.Show("Eliminado Correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Hide();
                    new Consulta().Show();
                }
            }
            else { MessageBox.Show("No tienes Acceso","Acceso Denegado",MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            
        }

        private void Info_FormClosing(object sender, FormClosingEventArgs e)
        {
            new Consulta().Show();
        }
    }
}
