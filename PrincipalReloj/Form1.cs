using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

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


            #region leer Ciudad
            string cadenaConexion = "http://api.openweathermap.org/data/2.5/weather?q=Provincia%20de%20Buenos%20Aires,AR&mode=xml&appid=84145534d9102d50c07556d4e63b704d&lang=es&units=metric";
            XmlDocument documentoXML = new XmlDocument();
            documentoXML.Load(cadenaConexion);

            string ciudad = documentoXML.DocumentElement.SelectSingleNode("city").Attributes["name"].Value;
            lbl_ciudad.Text = ciudad;
            string temperatura = documentoXML.DocumentElement.SelectSingleNode("temperature").Attributes["value"].Value;
            lbl_temp.Text = temperatura + " ºC";
            string humedad = documentoXML.DocumentElement.SelectSingleNode("humidity").Attributes["value"].Value;
            lbl_humedad.Text = humedad + "%";
            string presion = documentoXML.DocumentElement.SelectSingleNode("pressure").Attributes["value"].Value;
            lbl_presion.Text = presion;
            string presionUnidad = documentoXML.DocumentElement.SelectSingleNode("pressure").Attributes["unit"].Value;
            lbl_uPr.Text = presionUnidad;

            string cielo = documentoXML.DocumentElement.SelectSingleNode("weather").Attributes["value"].Value;
            lbl_cielo.Text = cielo;

            #endregion

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
