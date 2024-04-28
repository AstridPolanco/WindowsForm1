using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumoCombustible
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double distanciaRecorrida = Convert.ToDouble(txtDistancia.Text);
                double rendimiento = Convert.ToDouble(txtRendimiento.Text);

                if (rendimiento==0)
                {
                    MessageBox.Show("Ingrese un valor válido. El rendimiento no puede ser cero", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double galonesConsumidos = distanciaRecorrida / rendimiento;

                lblResult.Text = $"Cantidad de galones consumidos: {galonesConsumidos:F2}";
            }
            catch (FormatException) 
            {
                MessageBox.Show("Ingrese valores válidos.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show($"Ocurrió un error.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
