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
        public static int UltimoNumero { get; set; }

        Departamento d = new Departamento();
        public NuevoDepartamento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvDepartamento.Rows.Add(txtDireccion.Text);
            txtDireccion.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UltimoID _ultimoID = new UltimoID();

            _ultimoID.ObtenerUltimoIdDepartamento();

            var r = false;
            string letra = "0";
            int contador = UltimoNumero + 1;
            string codigo;

            foreach (DataGridViewRow item in dgvDepartamento.Rows)
            {
                if (contador >= 10)
                    codigo = Convert.ToString(contador);
                else
                {
                    codigo = letra + Convert.ToString(contador);
                }

                r = d.InsertarDatosDepartamento(new object[] { item.Cells[0].Value });

                contador++;

            }

            if (r == true)
            {
                MessageBox.Show("Direcciones Agregadas Correctamente!", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }

        private void NuevaDireccion_Load(object sender, EventArgs e)
        {
            txtDepartamento.Enabled = false;
        }
    }
}
