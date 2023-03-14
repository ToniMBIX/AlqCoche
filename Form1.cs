using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlqCoche
{
    public partial class ventaApp : Form
    {
        public ventaApp()
        {
            InitializeComponent();
        }

        private void buttonCalcCash_Click(object sender, EventArgs e)
        {
            int startKm = (int)kmInitCount.Value;
            int endKm = (int)kmEndCount.Value;

            if (startKm >= endKm)
            {
                MessageBox.Show("El valor de los Km de inicio no puede ser mayor que los km de finalización");
            }
            else
            {
                int distance = endKm - startKm;
                double pricePerKm = 0.39;
                double totalPrice = distance * pricePerKm;

                totalCashCalc.Text = totalPrice.ToString("C2");
            }
        }

        private void buttonShowKm_Click(object sender, EventArgs e)
        {

            int startKm = (int)kmInitCount.Value;
            int endKm = (int)kmEndCount.Value;

            if (startKm >= endKm)
            {
                MessageBox.Show("El valor de los Km de inicio no puede ser mayor que los km de finalización");
            }
            else
            {
                int distance = endKm - startKm;
                MessageBox.Show("Los kilómetros recorridos son: " + distance.ToString());
            }
        }
    }
}
