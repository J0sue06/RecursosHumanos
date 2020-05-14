using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RHH
{
    public partial class HacerReporte : Form
    {
        //public static string Filtro {get; set;}
        public HacerReporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ReporteRH _reporte = new ReporteRH();
            _reporte.SetParameterValue("@cedula", txtFiltro.Text);            
            Reporte reporte = new Reporte();
            
            reporte.crystalReportViewer2.ReportSource = _reporte;         
                      
            reporte.Show();
            
        }
    }
}
