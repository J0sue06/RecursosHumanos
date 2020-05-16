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
    public partial class MenuReportes : Form
    {
        public MenuReportes()
        {
            InitializeComponent();
        }

        private void MenuReportes_Load(object sender, EventArgs e)
        {
            DataTable dtdpto = new DataTable();
            Departamento dpto = new Departamento();
            dtdpto = dpto.DatosDepartamento();

            ComboDepartamento.DataSource = dtdpto;
            ComboDepartamento.DisplayMember = "NombreDepartamento";
            ComboDepartamento.ValueMember = "Codigo";
           
            chkDepartamento.Checked = true;
            if(chkDepartamento.Checked == true)
            {
                ComboDepartamento.Enabled = true;
            }
            Desde.Enabled = false;
            Hasta.Enabled = false;           

        }  

        private void Fecha_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Departamento_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Departamento_Click(object sender, EventArgs e)
        {
            if(chkDepartamento.Checked == true)
            {
                ComboDepartamento.Enabled = true;
            }
            else { ComboDepartamento.Enabled = false; }
            
        }

        private void Fecha_Click(object sender, EventArgs e)
        {
            if(Fecha.Checked == true)
            {
                Desde.Enabled = true;
                Hasta.Enabled = true;
            }
            else {
                Desde.Enabled = false;
                Hasta.Enabled = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chkDepartamento.Checked == true && Fecha.Checked == true)
            {
                ReporteRHVariasP2 _reporte = new ReporteRHVariasP2();
                _reporte.SetParameterValue("@codigo", ComboDepartamento.SelectedValue);
                _reporte.SetParameterValue("@fecha1", Desde.Text);
                _reporte.SetParameterValue("@fecha2", Hasta.Text);
                Reporte reporte = new Reporte();

                reporte.crystalReportViewer2.ReportSource = _reporte;

                reporte.Show();
            }
            else
            {
                if (chkDepartamento.Checked == true)
                {
                    ReporteRHVariasP _reporte = new ReporteRHVariasP();
                    _reporte.SetParameterValue("@departamento", ComboDepartamento.SelectedValue);
                    _reporte.SetParameterValue("@fecha1", null);
                    _reporte.SetParameterValue("@fecha2", null);
                    Reporte reporte = new Reporte();

                    reporte.crystalReportViewer2.ReportSource = _reporte;

                    reporte.Show();
                }
                if (Fecha.Checked == true)
                {
                    ReporteRHVariasP _reporte = new ReporteRHVariasP();
                    _reporte.SetParameterValue("@departamento", null);
                    _reporte.SetParameterValue("@fecha1", Desde.Text);
                    _reporte.SetParameterValue("@fecha2", Hasta.Text);
                    Reporte reporte = new Reporte();

                    reporte.crystalReportViewer2.ReportSource = _reporte;

                    reporte.Show();
                }

            }            
            
        }
    }
}
