using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace JuegoEsferas
{
    public partial class Form1 : Form
    {
        List<PictureBox> Lista = new List<PictureBox>();
        int Velocidad = 1, ColorPong = 1;
        Random ColorBalon = new Random();
        SoundPlayer Sonido = new SoundPlayer();

        public Form1()
        {
            InitializeComponent();
            IniciarJuego();
        }

        public void IniciarJuego()
        {
            Velocidad = 1;
            pictureBox1.Tag = 1;
            this.KeyPreview = true;
            lblPuntaje.Text = "0";
            crearPelota(Lista, this);
            timer1.Start();
            timer2.Start();
            Sonido.Stream = Properties.Resources.bin;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Lista.Count; i++)
            {
                int MovimientoY = Lista[i].Location.Y + Velocidad;
                Lista[i].Location = new Point(Lista[i].Location.X, MovimientoY);

                Console.WriteLine($"Pelota {i}: X={Lista[i].Location.X}, Y={Lista[i].Location.Y}");
            }
        }

        public void crearPelota(List<PictureBox> ListaPelota, Form formulario)
        {
            PictureBox pb = new PictureBox();
            pb.Location = new Point(135, -80);
            int NumeroColor = ColorBalon.Next(1, 5);
            pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("ball" + NumeroColor);
            pb.Tag = NumeroColor;
            pb.BackColor = Color.Transparent;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;

            formulario.Controls.Add(pb);
            ListaPelota.Add(pb);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
