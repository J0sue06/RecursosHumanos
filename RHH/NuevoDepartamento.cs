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
    public partial class NuevoDepartamento : Form
    {
        Departamento d = new Departamento();
        public NuevoDepartamento()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Departamento.NombreDepartamento = txtDepartamento.Text;
            
            var resultado = d.InsertarDatosDepartamento();

            if (resultado == "OK")
            {
                d.ObtenerIdDepartamento();

                var r = false;
                string letra = "0";
                int contador = 1;
                string codigo;
                

                foreach (DataGridViewRow item in dgvArea.Rows)
                {
                    codigo = letra + Convert.ToString(contador);                 
  
                    r = d.InsertarDatosArea(new object[] { item.Cells[0].Value, codigo });                    
                    
                    contador++;
                  
                }

                 if(r == true)
                {
                    MessageBox.Show("Departamento Creado Satisfactoriamente!","Atencion",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvArea.Rows.Add(txtArea.Text);
            txtArea.Clear();            
        }
    }
}
