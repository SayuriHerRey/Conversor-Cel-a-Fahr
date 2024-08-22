using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace Conversor_Cel_a_Fahr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Convertir_Click(object sender, EventArgs e)
        {
            float celsius = float.Parse(this.grdcelsius.Text);
            float fahrenheit = (celsius * 9 / 5) + 32;
            this.resultado.Text = fahrenheit.ToString();
            Convertir2.Enabled = false;
            grdfahrenheit.Enabled = false;
        }

        private void Convertir2_Click(object sender, EventArgs e)
        {
            float fahrenheit = float.Parse(this.grdfahrenheit.Text);
            float celsius = (fahrenheit - 32) * 5 / 9;
            this.resultado.Text = celsius.ToString();
            Convertir.Enabled = false;
            grdcelsius.Enabled = false;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            grdcelsius.Text = "";
            grdfahrenheit.Text = "";
            resultado.Text = "";
            Convertir.Enabled = true;
            Convertir2.Enabled = true;
            grdcelsius.Enabled = true;
            grdfahrenheit.Enabled = true;
        }
    }
}