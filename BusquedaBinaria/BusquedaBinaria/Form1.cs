using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusquedaBinaria
{
    public partial class Form1 : Form
    {
        Vector miVector;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            miVector = new Vector(Convert.ToInt32(txtTamaño.Text));
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            miVector.llenar(Convert.ToInt32(txtLimite.Text));
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = miVector.ToString();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            miVector.ordenar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = miVector.busquedaBin(Convert.ToInt32(txtBuscar.Text)).ToString();
            txtMostrar.Text += ", " + miVector.comparaciones.ToString() + " comparaciones";
        }
    }
}
