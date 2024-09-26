using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto1
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private Random random;
        public Form1()
        {
            InitializeComponent();
            ComponenteEditado();
        }

        private void ComponenteEditado()
        {
            timer = new Timer();
            timer.Tick += generarRandom;
            random = new Random();

            hScrollBar1.Minimum = 1;
            hScrollBar1.Maximum = 50;
            hScrollBar1.Value = 1;
            hScrollBar1.Scroll += hScrollBar1_Scroll;

            label1.Text = "Rango elegido: 0 seg";

            button1.Text = "Iniciar";
            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                button1.Text = "Iniciar";
            }
            else
            {
                timer.Start();
                button1.Text = "Detener";
            }
        }

        private void generarRandom(object sender, EventArgs e)
        {
            int numRandom = random.Next();
            label2.Text = $"Números random: {numRandom}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int rango = hScrollBar1.Value * 100;
            label1.Text = "Rango elegido: " + hScrollBar1.Value / 10 + " seg";
            timer.Interval = rango;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
