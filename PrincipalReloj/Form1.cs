using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrincipalReloj
{
    public partial class Form1 : Form
    {
        DateTime Tiempo = new DateTime();
        DateTime anio = new DateTime();

        public Form1()
        {
            InitializeComponent();
            Temporizador.Start();
            
        }

        private void label1_Click(object sender, EventArgs e){}
        private void marcarHora()
        {
            lblDataTime.Text = DateTime.Now.Hour.ToString("G") + ":" + DateTime.Now.Minute.ToString("G") + ":" + DateTime.Now.Second.ToString("G");
            lbl_Mes.Text = Tiempo.Month.ToString("d2") +" "+ DateTime.Now.ToString("MMMM").ToUpper();//

            lbl_anio.Text = DateTime.Now.Year.ToString("G"); ; //Tiempo.Year.ToString();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
