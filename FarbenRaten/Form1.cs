using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FarbenRaten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // Button farben anzeigen
        private void button1_Click(object sender, EventArgs e)
        {
            Random _random = new Random();
            int nummer = _random.Next(1, 7);
            string xx = "rot.png";

            switch (nummer)
            {
                case 1: xx = "gelb.png"; break;
                case 2: xx = "grau.png"; break;
                case 3: xx = "gruen.png"; break;
                case 4: xx = "orange.png"; break;
                case 5: xx = "rot.png"; break;
                case 6: xx = "blau.png"; break;
                default: xx = "gelb.png"; break;
            }

            pictureBox1.Load(xx);


        }

        // ende button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
