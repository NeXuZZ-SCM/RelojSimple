using System;
using System.Windows.Forms;

namespace PrincipalReloj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e){}
        private void marcarHora()
        {
            lblDataTime.Text = DateTime.Now.ToString("G");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            marcarHora();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Temporizador.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Temporizador.Start();
        }
    }
}
