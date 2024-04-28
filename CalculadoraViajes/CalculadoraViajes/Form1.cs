using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraViajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string puntoOrigen = txtOrigen.Text;
                string puntoDestino = txtDestino.Text;
                double velocidadConstante = Convert.ToDouble(txtVelocidad.Text);

                double distancia = CalcularDistancia(puntoOrigen, puntoDestino);
                double tiempoEstimado = distancia / velocidadConstante;

                MessageBox.Show($"Tiempo estimado de viaje desde {puntoOrigen} hasta {puntoDestino}: {tiempoEstimado:F2} horas", "Resultado");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CalcularDistancia(string origen, string destino)
        {
            Random random = new Random();
            return random.Next(10, 900);
        }
    }
}
