using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcVolume2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtRaio.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double verify1, verify2;
            if (double.TryParse(txtRaio.Text, out verify1) &&
                double.TryParse(txtAltura.Text, out verify2))
            {
                double resultado = Math.PI * Math.Pow(verify1, 2) * verify2;
                txtVolume.Text = resultado.ToString("N2");
            }
            else
                MessageBox.Show("Dados invalidos");
        }
    }
}
